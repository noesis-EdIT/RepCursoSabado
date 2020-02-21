Imports System.Data.SqlClient

Module Module1
    Public CN As SqlConnection
    Public statusBar1 As New StatusBar()
    Public panel1 As New StatusBarPanel()
    Public objConexion As New clsConexion
    Public objConfig As New clsConfigXml
    Public objParametroJugada As New clsParametrosJugada
    Public dt As New DataTable  '--> no funciona si lo declaro en el formulario frmBuscarJugada
    Public LabelAnterior, LabelActual As Label

    Sub EncabezadoDataGrid(ByVal dgv As DataGridView)
        dgv.RowCount = 1
        dgv.ColumnCount = 5
        dgv.Columns(0).Width = 85
        dgv.Columns(1).Width = 80

        dgv.Columns(0).HeaderText = "Nº sorteo"
        dgv.Columns(1).HeaderText = "Fecha"
        dgv.Columns(2).HeaderText = "Sorteo 1"
        dgv.Columns(3).HeaderText = "Sorteo 2"
        dgv.Columns(4).HeaderText = "Sorteo 3"

        dgv.RowHeadersVisible = False
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 9.0, FontStyle.Bold)
    End Sub

    Sub SetearCantidadCaracteresColumnas(ByVal dgv As DataGridView)
        'Limita la cant de caracteres que se pueden ingresar en cada celda
        Dim instanceA As DataGridViewTextBoxColumn

        instanceA = dgv.Columns(0) : instanceA.MaxInputLength = 5
        instanceA = dgv.Columns(1) : instanceA.MaxInputLength = 10
        instanceA = dgv.Columns(2) : instanceA.MaxInputLength = 17
        instanceA = dgv.Columns(3) : instanceA.MaxInputLength = 17
        instanceA = dgv.Columns(4) : instanceA.MaxInputLength = 17
    End Sub

    Function FechaIncorrecta(ByVal dgv As DataGridView) As String    '-> devuelve la fila en la que está el error
        Dim CantFilas As Integer = dgv.RowCount
        Dim dFecha, dResult As Date
        Dim Celda As String

        FechaIncorrecta = ""
        For j = 0 To CantFilas - 2
            If Not (Date.TryParse(dgv.Item(1, j).Value, dResult)) Then 'dgvCarga.Item(columna, fila)
                MessageBox.Show("Fecha incorrecta", "Fecha incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DesSeleccionarCeldasGrilla(dgv)
                dgv.Item(1, j).Selected = True
                Celda = "(" & CStr(j) & "," & CStr(1) & ")"
                dgv.FirstDisplayedScrollingRowIndex = j
                Return Celda
            Else
                dFecha = dgv.Item(1, j).Value
                If dFecha < "01/01/1993" Then
                    MessageBox.Show("Fecha anterior a 01/01/1993", "Fecha incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DesSeleccionarCeldasGrilla(dgv)
                    dgv.Item(1, j).Selected = True
                    Celda = "(" & CStr(j) & "," & CStr(1) & ")"
                    dgv.FirstDisplayedScrollingRowIndex = j
                    Return Celda
                End If
            End If
        Next
    End Function

    Function AjustarFecha(ByVal strFecha As String) As String
        Dim PosBarra, PosBarra2 As Byte
        Dim sFechaNueva As String
        Dim sDia, SMes, sAño As String

        PosBarra = InStr(strFecha, "/")
        PosBarra2 = InStr(Mid(strFecha, PosBarra + 1, Len(strFecha)), "/") + PosBarra

        sDia = Mid(strFecha, 1, PosBarra - 1)
        SMes = Mid(strFecha, PosBarra + 1, PosBarra2 - PosBarra - 1)
        sAño = Mid(strFecha, PosBarra2 + 1, Len(strFecha))

        If PosBarra <> 0 And PosBarra2 <> 0 Then
            If Len(sDia) = 0 Then
                sDia = "00"
            ElseIf Len(sDia) = 1 Then
                sDia = "0" & sDia
            End If

            If Len(SMes) = 0 Then
                SMes = "00"
            ElseIf Len(SMes) = 1 Then
                SMes = "0" & SMes
            End If

            If Len(sAño) = 0 Then
                sAño = "0000"
            ElseIf Len(sAño) = 1 Then
                sAño = sAño & "000"
            ElseIf Len(sAño) = 2 Then
                sAño = sAño & "00"
            ElseIf Len(sAño) = 3 Then
                sAño = sAño & "0"
            End If
        End If

        sFechaNueva = sDia & "/" & SMes & "/" & sAño

        Do While Len(sFechaNueva) < 10
            sFechaNueva = sFechaNueva & "0"
        Loop

        Return sFechaNueva
    End Function

    Sub DesSeleccionarCeldasGrilla(ByVal DataG As DataGridView)
        For j = 0 To DataG.RowCount - 1
            For i = 0 To DataG.ColumnCount - 1
                DataG.Item(i, j).Selected = False
            Next
        Next
    End Sub

    Function NumeroFueraDeRango(ByVal dgv As DataGridView) As String
        Dim CantFilas As Integer = dgv.RowCount
        Dim Col, iNumActual As Byte
        Dim sSorteo As String
        Dim i As Byte
        Dim Celda As String

        NumeroFueraDeRango = ""
        For Fila = 0 To CantFilas - 2
            For Col = 2 To 4
                sSorteo = dgv.Item(Col, Fila).Value
                sSorteo = Replace(sSorteo, " ", "")
                Select Case Col
                    Case 2, 3, 4
                        i = 1
                        If String.IsNullOrEmpty(sSorteo) Then Continue For
                        Do While i < 13
                            iNumActual = CInt(Mid(sSorteo, i, 2))
                            If iNumActual > 44 Then
                                Celda = "(" & CStr(Fila) & "," & CStr(Col) & ")"
                                Return Celda
                            End If
                            i += 2
                        Loop
                End Select
            Next Col
        Next
    End Function

    Function SorteoIncompleto(ByVal dgv As DataGridView) As String
        Dim CantFilas As Integer = dgv.RowCount
        Dim sSorteoActual As String
        Dim Incompleto As Boolean = False
        Dim Celda As String

        SorteoIncompleto = ""
        For j = 0 To CantFilas - 2
            For i = 2 To dgv.ColumnCount - 1
                sSorteoActual = dgv.Item(i, j).Value
                sSorteoActual = Replace(sSorteoActual, " ", "")
                If Len(sSorteoActual) < 12 And Not String.IsNullOrEmpty(sSorteoActual) Then
                    dgv.Item(i, j).Selected = True
                    Celda = "(" & CStr(j) & "," & CStr(i) & ")"
                    Return Celda
                    Exit Function
                End If
            Next i
        Next j
    End Function

    Function TransformarFechaASql(ByVal Fecha As Date) As String
        TransformarFechaASql = Format(Fecha, "dd/MM/yyyy")
    End Function

    Function NumeroDuplicadoEnSorteo(ByVal dgv As DataGridView) As String
        Dim CantFilas As Integer = dgv.RowCount
        Dim sSorteoActual As String
        Dim bDuplicado As Boolean = False
        Dim Celda As String = ""

        NumeroDuplicadoEnSorteo = ""
        For j = 0 To CantFilas - 2
            For i = 2 To dgv.ColumnCount - 1
                If i = 2 Or i = 3 Or i = 4 Then
                    sSorteoActual = dgv.Item(i, j).Value
                    sSorteoActual = Replace(sSorteoActual, " ", "")
                    bDuplicado = NumeroEncontrado(sSorteoActual)
                    If bDuplicado = True And Not String.IsNullOrEmpty(sSorteoActual) And (sSorteoActual <> "000000000000") Then
                        Celda = "(" & CStr(j) & "," & CStr(i) & ")"
                        Return Celda
                    End If
                End If
            Next i
        Next j
    End Function

    Function NumeroEncontrado(ByVal sSorteo As String) As Boolean
        Dim sNumActual As String

        NumeroEncontrado = False
        For k = 1 To 9 Step 2
            sNumActual = Mid(sSorteo, k, 2)
            For l = k + 2 To 11 Step 2
                If sNumActual = Mid(sSorteo, l, 2) Then
                    Return True
                End If
            Next
        Next
    End Function

    Function OrdenarSorteo(ByVal sSorteo As String) As String
        Dim sNumeros(5), sSorteoOrdenado, index As String
        Dim n, j As Integer

        sSorteoOrdenado = ""

        Try
            For m = 1 To 11 Step 2
                sNumeros(n) = Mid(sSorteo, m, 2)
                n += 1
            Next

            For i = 1 To sNumeros.Length - 1
                index = sNumeros(i)
                j = i - 1
                Do While (j >= 0)
                    If index > sNumeros(j) Then
                        Exit Do
                    Else
                        sNumeros(j + 1) = sNumeros(j)
                        j = j - 1
                    End If
                Loop
                sNumeros(j + 1) = index
            Next i

            For i = 0 To 5
                sSorteoOrdenado = sSorteoOrdenado & sNumeros(i)
            Next

            Return sSorteoOrdenado

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Function

    Function AgregarEspacios(ByVal Sorteo As String) As String
        Dim sSorteo As String = ""
        Dim Vec(13) As String

        Vec(0) = Mid(Sorteo, 1, 2)
        Vec(1) = " "
        Vec(2) = Mid(Sorteo, 3, 2)
        Vec(3) = " "
        Vec(4) = Mid(Sorteo, 5, 2)
        Vec(5) = " "
        Vec(6) = Mid(Sorteo, 7, 2)
        Vec(8) = " "
        Vec(9) = Mid(Sorteo, 9, 2)
        Vec(10) = " "
        Vec(11) = Mid(Sorteo, 11, 2)
        Vec(12) = " "
        Vec(13) = Mid(Sorteo, 13, 2)
        For i = 0 To 13
            sSorteo = sSorteo & Vec(i)
        Next
        Return sSorteo
    End Function

    Public Sub ColoresFilasDataGrid(ByVal frm As Form, ByVal dgv As DataGridView)
        Dim i As Integer = 0

        For Each item As DataGridViewRow In dgv.Rows
            item.DefaultCellStyle.BackColor = Color.LightGreen
            If i Mod 2 = 0 Then
                item.DefaultCellStyle.BackColor = Color.LightGreen
            Else
                item.DefaultCellStyle.BackColor = Color.White
            End If

            i += 1
        Next
    End Sub

    Public Sub ColoresFilaListView(ByVal frm As Form, ByVal lv As ListView)
        Dim i As Integer = 0

        For Each item As ListViewItem In lv.Items
            item.BackColor = Color.LightBlue
            If i Mod 2 = 0 Then
                item.BackColor = Color.LightGreen
            Else
                item.BackColor = Color.White
            End If

            i += 1
        Next
    End Sub

    Public Sub TipoLetraListView(ByVal LView1 As ListView)
        Dim lvi As ListViewItem
        For Each lvi In LView1.Items
            lvi.Font = New Font(New FontFamily("Microsoft Sans Serif"), 8.25, FontStyle.Regular)
        Next
    End Sub

    Public Sub MostrarAyuda(ByVal NombreForm As Form, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim FormActivo As Form = NombreForm.ActiveMdiChild
        If e.KeyCode = Keys.F1 Then
            If frmPrincipal.gbHelp.Visible Then
                frmPrincipal.gbHelp.Visible = False
            Else
                frmPrincipal.gbHelp.Visible = True
                frmPrincipal.WebBrowser1.Navigate(Application.StartupPath + "\Reglamento.htm")
            End If
        End If
    End Sub

    Sub AplicarNegrita(ByVal lab As Label)
        If LabelAnterior.Name <> lab.Name Then
            lab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Bold)
            LabelAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular)
        End If
        LabelAnterior = lab
    End Sub

    Public Sub QuitarNegrita()
        LabelAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular)
    End Sub

End Module
