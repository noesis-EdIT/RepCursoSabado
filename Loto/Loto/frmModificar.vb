Imports System.Data.SqlClient

Public Class frmModificar
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmModificar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvCarga.DataSource = dt
        Call SetearCantidadCaracteresColumnas(dgvCarga)
        dgvCarga.Columns(0).ReadOnly = True
        dgvCarga.Columns(0).Width = 75
        dgvCarga.Columns(1).Width = 80
        dgvCarga.Width = dgvCarga.Columns(0).Width + dgvCarga.Columns(1).Width + dgvCarga.Columns(2).Width + dgvCarga.Columns(3).Width + dgvCarga.Columns(4).Width + 3
        Call ColoresFilasDataGrid(Me, dgvCarga)
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim sNumeroFilaFechaIncorrecta, sNumDuplicado, sNumeroFueraDeRango, sNumIncompleto As String
        Dim iCol, iFila, iPosComa As Integer

        sNumeroFilaFechaIncorrecta = FechaIncorrecta(dgvCarga)
        If sNumeroFilaFechaIncorrecta <> "" Then Exit Sub

        'If Numero_sorteo_o_sorteo_ingresado_con_error(dgvCarga) Then Exit Sub

        sNumIncompleto = SorteoIncompleto(dgvCarga)
        If sNumIncompleto <> "" Then
            iPosComa = InStr(sNumIncompleto, ",")
            iFila = Mid(sNumIncompleto, 2, iPosComa - 1)
            iCol = Mid(sNumIncompleto, iPosComa + 1, Len(sNumIncompleto) - 1 - iPosComa)
            MessageBox.Show("Algún sorteo no está completo", "Faltan números", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DesSeleccionarCeldasGrilla(dgvCarga)
            dgvCarga.Item(iCol, iFila).Selected = True
            dgvCarga.FirstDisplayedScrollingRowIndex = iFila
            Exit Sub
        End If

        sNumDuplicado = NumeroDuplicadoEnSorteo(dgvCarga)
        If sNumDuplicado <> "" Then
            iPosComa = InStr(sNumDuplicado, ",")
            iFila = Mid(sNumDuplicado, 2, iPosComa - 1)
            iCol = Mid(sNumDuplicado, iPosComa + 1, Len(sNumDuplicado) - 1 - iPosComa)
            MessageBox.Show("Se encontró un valor duplicado.", "Valor repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DesSeleccionarCeldasGrilla(dgvCarga)
            dgvCarga.Item(iCol, iFila).Selected = True
            dgvCarga.FirstDisplayedScrollingRowIndex = iFila
            Exit Sub
        End If

        sNumeroFueraDeRango = NumeroFueraDeRango(dgvCarga)
        If sNumeroFueraDeRango <> "" Then
            iPosComa = InStr(sNumeroFueraDeRango, ",")
            iFila = Mid(sNumeroFueraDeRango, 2, iPosComa - 1)
            iCol = Mid(sNumeroFueraDeRango, iPosComa + 1, Len(sNumeroFueraDeRango) - 1 - iPosComa)
            MessageBox.Show("Se ingresó un número mayor a 41.", "Número equivocado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DesSeleccionarCeldasGrilla(dgvCarga)
            dgvCarga.Item(iCol, iFila).Selected = True
            dgvCarga.FirstDisplayedScrollingRowIndex = iFila
            Exit Sub
        End If

        Call Modificar()
    End Sub

    Sub Modificar()
        Dim Comando As SqlCommand = New SqlCommand("spModificarReg", CN)
        Dim Valor1 As Long
        Dim Valor2 As Date
        Dim Valor3, Valor4, Valor5 As String
        Dim CantFilas As Integer = dgvCarga.RowCount
        Dim i As Integer
        Dim paramNumSorteo, paramFecha, paramSorteoTra, paramSorteoDes, paramSorteoSal As SqlParameter
        Dim Rta As MsgBoxResult

        Comando.CommandType = CommandType.StoredProcedure

        paramNumSorteo = New SqlParameter("@NumSorteo", SqlDbType.Int, 4)
        paramFecha = New SqlParameter("@Fecha", SqlDbType.SmallDateTime, 10)
        paramSorteoTra = New SqlParameter("@SorteoTra", SqlDbType.VarChar, 12)
        paramSorteoDes = New SqlParameter("@SorteoDes", SqlDbType.VarChar, 12)
        paramSorteoSal = New SqlParameter("@SorteoSal", SqlDbType.VarChar, 12)

        Rta = MessageBox.Show("¿Confirma modificación del registro? ", "Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Rta = vbNo Then Exit Sub

        Try
            For j = 0 To CantFilas - 2
                Do While i < dgvCarga.ColumnCount
                    Select Case i
                        Case 0
                            Valor1 = dgvCarga.Item(i, j).Value
                            i += 1
                        Case 1
                            Valor2 = dgvCarga.Item(i, j).Value
                            i += 1
                        Case 2
                            Valor3 = dgvCarga.Item(i, j).Value
                            Valor3 = Replace(Valor3, " ", "")
                            i += 1
                        Case 3
                            Valor4 = dgvCarga.Item(i, j).Value
                            Valor4 = Replace(Valor4, " ", "")
                            i += 1
                        Case 4
                            Valor5 = dgvCarga.Item(i, j).Value
                            Valor5 = Replace(Valor5, " ", "")
                            i += 1
                    End Select
                Loop

                If Valor1 <> 0 And Valor2 <> #12:00:00 AM# And Valor3 <> "" And Valor4 <> "" And Valor5 <> "" Then
                    Valor3 = OrdenarSorteo(Valor3) : Valor4 = OrdenarSorteo(Valor4) : Valor5 = OrdenarSorteo(Valor5)

                    paramNumSorteo.Value = Valor1
                    Comando.Parameters.Add(paramNumSorteo)

                    If Valor2 <> #12:00:00 AM# Then Valor2 = TransformarFechaASql(Valor2)
                    paramFecha.Value = Valor2
                    Comando.Parameters.Add(paramFecha)

                    paramSorteoTra.Value = Valor3
                    Comando.Parameters.Add(paramSorteoTra)

                    paramSorteoDes.Value = Valor4
                    Comando.Parameters.Add(paramSorteoDes)

                    paramSorteoSal.Value = Valor5
                    Comando.Parameters.Add(paramSorteoSal)

                    Comando.ExecuteNonQuery()
                    i = 0
                End If

                Comando.Parameters.Clear()
            Next j

            If CantFilas - 2 = 0 Then
                MessageBox.Show("Se modificó el registro.", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf CantFilas - 2 > 0 Then
                MessageBox.Show("Se modificaron los registros.", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class