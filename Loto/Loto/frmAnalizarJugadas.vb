Imports System.Data.SqlClient
Imports System.Math

Public Class frmAnalizarJugadas
    'https://foro.elhacker.net/net/solucionado_cambiar_el_color_de_una_linea_en_un_richtextbox-t377047.0.html

    Dim lstNumerosTodos, lstNumerosSinRepetir As New List(Of String)
    Dim strSorteo, strSorteoNeto As String
    Dim UsrControlVisible As Boolean

    Private Sub btnAnalizarJugada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnalizarJugada.Click
        Dim iNumSorteo As Integer = txtNumSorteo.Text
        Dim myReader As SqlDataReader
        Dim bln As Boolean

        Call LimpiarControles()
        strSorteo = "" : strSorteoNeto = "" : lstNumerosSinRepetir = New List(Of String)

        bln = Integer.TryParse(txtNumSorteo.Text, iNumSorteo)
        If Not bln Then Exit Sub

        myReader = objConexion.BuscarJugada(iNumSorteo, "", #12:00:00 AM#, #12:00:00 AM#)

        If myReader.HasRows Then
            Do While myReader.Read
                dtpFecha.Text = System.Convert.ToString(myReader.GetSqlValue(1))
                'Dim number As Date
                'dtpFecha.Text = IIf(Date.TryParse(System.Convert.ToString(myReader.GetSqlValue(1)), number), System.Convert.ToString(myReader.GetSqlValue(1)), "")
                If chlSorteos.GetItemCheckState(0).ToString() = "Checked" Then
                    If myReader(2) = "000000000000" Then
                        strSorteo = "xxxxxxxxxxxx"
                    ElseIf myReader(2) <> "000000000000" Then
                        strSorteo = myReader(2)
                    End If
                Else
                    strSorteo = strSorteo & "xxxxxxxxxxxx"
                End If

                If chlSorteos.GetItemCheckState(1).ToString() = "Checked" Then
                    If myReader(3) = "000000000000" Then
                        strSorteo = strSorteo & "xxxxxxxxxxxx"
                    ElseIf myReader(3) <> "000000000000" Then
                        strSorteo = strSorteo & myReader(3)
                    End If
                Else
                    strSorteo = strSorteo & "xxxxxxxxxxxx"
                End If

                If chlSorteos.GetItemCheckState(2).ToString() = "Checked" Then
                    If myReader(4) = "000000000000" Then
                        strSorteo = strSorteo & "xxxxxxxxxxxx"
                    ElseIf myReader(4) <> "000000000000" Then
                        strSorteo = strSorteo & myReader(4)
                    End If
                Else
                    strSorteo = strSorteo & "xxxxxxxxxxxx"
                End If
            Loop
        End If

        myReader.Close()

        If strSorteo = "" Then Exit Sub

        Call CargarListasNumeros()
        Call NumerosMasFrecuentes()
        Call NumerosMenosFrecuentes()
        Call CantPares()
        Call TerminacionMasRepetida()
        Call ObtenerNumeroSorteoAnterior()
        Call CantNumUnSoloDigito()
        Call Consecutivos()
        Call Sumatoria()
        Call DiferenciaMinimaYMaximaEntreContiguos()
        Call CantPrimos()
    End Sub

    Sub LimpiarControles()
        cbxMasFrecuentes.Items.Clear()
        cbxMenosFrecuentes.Items.Clear()
        txtCantPares.Text = ""
        cbxTerminacion.Items.Clear()
        cbxTerminacion.Text = ""
        cbxNumSorteoAnterior.Items.Clear()
        cbxNumSorteoAnterior.Text = ""
        txtCantUnDigito.Text = ""
        cbxDosConsecutivos.Items.Clear()
        txtSumatoria.Text = ""
        txtTra.Text = "" : txtDes.Text = "" : txtSos.Text = ""
    End Sub

    Private Sub CargarListasNumeros()
        Dim lstNumeros As New List(Of String)

        lstNumerosTodos.Clear() : lstNumeros.Clear()

        For i = 0 To strSorteo.Length - 1 Step 2
            lstNumerosTodos.Add(Mid(strSorteo, i + 1, 2))
        Next

        For i = 0 To strSorteo.Length - 1
            If Mid(strSorteo, i + 1, 1) <> "x" Then
                strSorteoNeto = strSorteoNeto & Mid(strSorteo, i + 1, 1)
            End If
        Next

        For i = 0 To strSorteoNeto.Length - 1 Step 2
            lstNumeros.Add(Mid(strSorteoNeto, i + 1, 2))
        Next

        For i = 0 To lstNumeros.Count - 1
            If Not lstNumerosSinRepetir.Contains(lstNumeros(i)) Then
                lstNumerosSinRepetir.Add(lstNumeros(i))
            End If
        Next

        If chlSorteos.GetItemCheckState(0).ToString() = "Checked" Then
            If lstNumerosTodos(0) <> lstNumerosTodos(1) Then  '--> sorteos como el nro. 300, que tienen el SOS compuesto de todos ceros porque no se sorteó, no considerarlos.
                For i = 0 To 5
                    txtTra.Text = txtTra.Text & lstNumerosTodos(i) & " "
                Next
            End If
        Else
            txtTra.Text = ""
        End If

        If chlSorteos.GetItemCheckState(1).ToString() = "Checked" Then
            If lstNumerosTodos(6) <> lstNumerosTodos(7) Then
                For i = 6 To 11
                    txtDes.Text = txtDes.Text & lstNumerosTodos(i) & " "
                Next
            End If
        Else
            txtDes.Text = ""
        End If

        Dim a As New List(Of String)
        a = lstNumerosTodos
        If chlSorteos.GetItemCheckState(2).ToString() = "Checked" Then
            If lstNumerosTodos(12) <> lstNumerosTodos(13) Then
                For i = 12 To 17
                    txtSos.Text = txtSos.Text & lstNumerosTodos(i) & " "
                Next
            End If
        Else
            txtSos.Text = ""
        End If
    End Sub

    Private Sub NumerosMasFrecuentes()
        Dim Vec(0 To 41), iMayor, iValor As Byte
        Dim sNumMasRepetido As String

        For i = 0 To lstNumerosTodos.Count - 1
            If Mid(lstNumerosTodos(i), 1, 2) <> "xx" Then
                iValor = Mid(lstNumerosTodos(i), 1, 2)
                Vec(iValor) += 1
            End If
        Next i

        For i = 0 To Vec.Length - 1
            If Vec(i) > iMayor Then
                iMayor = Vec(i)
            End If
        Next

        For i = 0 To Vec.Length - 1
            If Vec(i) = iMayor And iMayor > 1 Then
                sNumMasRepetido = CStr(i)
                If Len(sNumMasRepetido) = 1 Then sNumMasRepetido = "0" & sNumMasRepetido
                cbxMasFrecuentes.Items.Add(sNumMasRepetido)
            End If
        Next

        If cbxMasFrecuentes.Items.Count > 0 Then cbxMasFrecuentes.Text = cbxMasFrecuentes.Items(0)
    End Sub

    Private Sub NumerosMenosFrecuentes()
        Dim Vec(0 To 41), iValor As Byte
        Dim sNumMasRepetido As String

        For i = 0 To lstNumerosTodos.Count - 1
            If Mid(lstNumerosTodos(i), 1, 2) <> "xx" Then
                iValor = Mid(lstNumerosTodos(i), 1, 2)
                Vec(iValor) += 1
            End If
        Next i

        For i = 0 To Vec.Length - 1
            If Vec(i) = 0 Then
                sNumMasRepetido = CStr(i)
                If Len(sNumMasRepetido) = 1 Then sNumMasRepetido = "0" & sNumMasRepetido
                cbxMenosFrecuentes.Items.Add(sNumMasRepetido)
            End If
        Next

        If cbxMenosFrecuentes.Items.Count > 0 Then cbxMenosFrecuentes.Text = cbxMenosFrecuentes.Items(0)
    End Sub

    Private Sub CantPares()
        Dim iCantPares As Byte
        Dim dPromCantPares As Double

        For i = 0 To strSorteoNeto.Length - 1 Step 2
            If Mid(strSorteoNeto, i + 1, 2) Mod 2 = 0 Then
                iCantPares += 1
            End If
        Next

        If chlSorteos.CheckedItems.Count > 0 Then
            dPromCantPares = Round(iCantPares / chlSorteos.CheckedItems.Count, 2)
        End If

        txtCantPares.Text = iCantPares & " (" & dPromCantPares & ")"
    End Sub

    Private Sub TerminacionMasRepetida()
        Dim VecCantidadTerminaciones(0 To 9), iMayor, iSegundoDigito As Byte
        Dim sNumMasRepetido As String

        'Obtengo la cantidad de veces que tuvo cada terminación:
        For j = 0 To lstNumerosTodos.Count - 1
            If Mid(lstNumerosTodos(j), 1, 2) <> "xx" Then
                iSegundoDigito = Mid(lstNumerosTodos(j), 2, 1)
                VecCantidadTerminaciones(iSegundoDigito) += 1
            End If
        Next j

        'Busco la CANTIDAD de veces que salió el dígito que más se repitió:
        iMayor = 0
        For j = 0 To 9
            If VecCantidadTerminaciones(j) > iMayor Then
                iMayor = VecCantidadTerminaciones(j)
            End If
        Next

        'Busco los nros. que lograron esa cantidad de veces (los que más veces se repitieron):
        For j = 0 To 9
            If VecCantidadTerminaciones(j) = iMayor And iMayor > 1 Then
                sNumMasRepetido = CStr(j)
                If Len(sNumMasRepetido) = 1 Then sNumMasRepetido = "0" & sNumMasRepetido
                cbxTerminacion.Items.Add(sNumMasRepetido)
            End If
        Next

        If cbxTerminacion.Items.Count > 0 Then cbxTerminacion.Text = cbxTerminacion.Items(0)
    End Sub

    Private Sub ObtenerNumeroSorteoAnterior()
        Dim sNumSorteo As String = txtNumSorteo.Text
        Dim iNumSorteoAnterior, iNumSorteo As Integer
        Dim bln As Boolean
        Dim sSorteoAnterior, sConsulta As String
        Dim lSorteoAnterior As New List(Of String)
        Dim myReader As SqlDataReader

        If sNumSorteo = "" Then Exit Sub

        bln = Integer.TryParse(sNumSorteo, iNumSorteo)

        sConsulta = "select max (NumSorteo) from Sorteos where NumSorteo < " & iNumSorteo
        myReader = objConexion.EjecutarConsultaDR(sConsulta)

        If myReader.HasRows Then
            Do While myReader.Read
                iNumSorteoAnterior = myReader(0)
            Loop
        End If
        myReader.Close()

        If iNumSorteoAnterior <> 0 Then
            sConsulta = "select * from Sorteos where NumSorteo = " & iNumSorteoAnterior
            myReader = objConexion.EjecutarConsultaDR(sConsulta)

            If myReader.HasRows Then
                Do While myReader.Read
                    If chlSorteos.GetItemCheckState(0).ToString() = "Checked" Then
                        sSorteoAnterior = myReader(2)
                    Else
                        sSorteoAnterior = "xxxxxxxxxxxx"
                    End If

                    If chlSorteos.GetItemCheckState(1).ToString() = "Checked" Then
                        sSorteoAnterior = sSorteoAnterior & myReader(3)
                    Else
                        sSorteoAnterior = sSorteoAnterior & "xxxxxxxxxxxx"
                    End If

                    If chlSorteos.GetItemCheckState(2).ToString() = "Checked" Then
                        sSorteoAnterior = sSorteoAnterior & myReader(4)
                    Else
                        sSorteoAnterior = sSorteoAnterior & "xxxxxxxxxxxx"
                    End If
                Loop
                myReader.Close()
            End If

        Else
            Exit Sub
        End If


        Dim Vec(0 To 41), iMayor As Byte
        Dim sMayor As String
        For i = 1 To sSorteoAnterior.Length - 2 Step 2
            For j = 1 To strSorteoNeto.Length - 2 Step 2
                If Mid(sSorteoAnterior, i, 2) = Mid(strSorteoNeto, j, 2) Then
                    Vec(Mid(sSorteoAnterior, i, 2)) += 1
                End If
            Next
        Next

        For i = 0 To Vec.Length - 1
            If Vec(i) > iMayor Then
                iMayor = Vec(i)
            End If
        Next

        For i = 0 To Vec.Length - 1
            If Vec(i) = iMayor Then
                sMayor = i
                If Len(sMayor) = 1 Then sMayor = "0" & sMayor
                cbxNumSorteoAnterior.Items.Add(sMayor)
            End If
        Next

        If cbxNumSorteoAnterior.Items.Count > 0 Then
            cbxNumSorteoAnterior.Text = cbxNumSorteoAnterior.Items(0)
        End If
    End Sub

    Private Sub CantNumUnSoloDigito()
        Dim Cant As Byte
        Dim dPromCant As Double

        For i = 0 To lstNumerosTodos.Count - 1
            If lstNumerosTodos(i) <> "xx" Then
                If CInt(lstNumerosTodos(i)) < 10 Then
                    Cant += 1
                End If
            End If
        Next

        If chlSorteos.CheckedItems.Count > 0 Then
            dPromCant = Round(Cant / chlSorteos.CheckedItems.Count, 2)
        End If
        txtCantUnDigito.Text = Cant & " (" & dPromCant & ")"
    End Sub

    Private Sub Consecutivos()
        Dim lSorteo1, lSorteo2, lSorteo3 As New List(Of String)
        Dim sNum As String

        If chlSorteos.GetItemCheckState(0).ToString() = "Checked" Then
            For i = 0 To 5
                lSorteo1.Add(lstNumerosTodos(i))
            Next

            sNum = lSorteo1(0)
            For i = 1 To lSorteo1.Count - 1
                If CInt(sNum) + 1 = lSorteo1(i) Then
                    cbxDosConsecutivos.Items.Add(sNum + "-" + lSorteo1(i))
                End If
                sNum = lSorteo1(i)
            Next
        End If

        If chlSorteos.GetItemCheckState(1).ToString() = "Checked" Then
            If lstNumerosTodos(6) <> "xx" Then
                For i = 6 To 11
                    lSorteo2.Add(lstNumerosTodos(i))
                Next

                sNum = lSorteo2(0)
                For i = 1 To lSorteo2.Count - 1
                    If CInt(sNum) + 1 = lSorteo2(i) Then
                        cbxDosConsecutivos.Items.Add(sNum + "-" + lSorteo2(i))
                    End If
                    sNum = lSorteo2(i)
                Next
            End If
        End If

        If chlSorteos.GetItemCheckState(2).ToString() = "Checked" Then
            If lstNumerosTodos(12) <> "xx" Then
                For i = 12 To 17
                    lSorteo3.Add(lstNumerosTodos(i))
                Next

                sNum = lSorteo3(0)
                For i = 1 To lSorteo3.Count - 1
                    If CInt(sNum) + 1 = lSorteo3(i) Then
                        cbxDosConsecutivos.Items.Add(sNum + "-" + lSorteo3(i))
                    End If
                    sNum = lSorteo3(i)
                Next
            End If
        End If

        If cbxDosConsecutivos.Items.Count > 0 Then
            cbxDosConsecutivos.Text = cbxDosConsecutivos.Items(0)
        End If
    End Sub

    Private Sub Sumatoria()
        Dim iSuma As Integer
        Dim dPromSuma As Double

        For i = 0 To lstNumerosTodos.Count - 1
            If lstNumerosTodos(i) <> "xx" Then iSuma = iSuma + CInt(lstNumerosTodos(i))
        Next

        If chlSorteos.CheckedItems.Count > 0 Then
            dPromSuma = Round(iSuma / chlSorteos.CheckedItems.Count, 2)
        End If

        txtSumatoria.Text = iSuma & " (" & dPromSuma & ")"
    End Sub

    Private Sub DiferenciaMinimaYMaximaEntreContiguos()
        Dim iNum1, iNum2 As Byte
        Dim iDifMinima, iDifMaxima As Integer

        iDifMinima = 50

        If chlSorteos.GetItemCheckState(0).ToString() = "Checked" Then
            For i = 0 To 4
                iNum1 = CInt(lstNumerosTodos(i))
                iNum2 = CInt(lstNumerosTodos(i + 1))
                If Abs(iNum2 - iNum1) > iDifMaxima Then iDifMaxima = Abs(iNum2 - iNum1)
                If Abs(iNum2 - iNum1) < iDifMinima Then iDifMinima = Abs(iNum2 - iNum1)
            Next
        End If

        If chlSorteos.GetItemCheckState(1).ToString() = "Checked" Then
            If lstNumerosTodos(6) <> "xx" Then
                For i = 6 To 10
                    iNum1 = CInt(lstNumerosTodos(i))
                    iNum2 = CInt(lstNumerosTodos(i + 1))
                    If Abs(iNum2 - iNum1) > iDifMaxima Then iDifMaxima = Abs(iNum2 - iNum1)
                    If Abs(iNum2 - iNum1) < iDifMinima Then iDifMinima = Abs(iNum2 - iNum1)
                Next
            End If
        End If

        If chlSorteos.GetItemCheckState(2).ToString() = "Checked" Then
            If lstNumerosTodos(12) <> "xx" Then
                For i = 12 To 16
                    iNum1 = CInt(lstNumerosTodos(i))
                    iNum2 = CInt(lstNumerosTodos(i + 1))
                    If Abs(iNum2 - iNum1) > iDifMaxima Then iDifMaxima = Abs(iNum2 - iNum1)
                    If Abs(iNum2 - iNum1) < iDifMinima Then iDifMinima = Abs(iNum2 - iNum1)
                Next
            End If
        End If

        txtDiferenciaMinMax.Text = iDifMinima & " - " & iDifMaxima
    End Sub

    Private Sub CantPrimos()
        Dim iNumActual, iCantDivisores, iCantPrimos As Byte
        Dim dPromCantPrimos As Single

        For i = 0 To lstNumerosTodos.Count - 1
            If lstNumerosTodos(i) <> "xx" Then
                iNumActual = lstNumerosTodos(i)
                For j = 1 To iNumActual
                    If iNumActual Mod j = 0 Then
                        iCantDivisores += 1
                    End If
                Next j
                If iCantDivisores = 2 Then iCantPrimos += 1
                iCantDivisores = 0
            End If
        Next i

        dPromCantPrimos = Round(iCantPrimos / chlSorteos.CheckedItems.Count, 2)
        txtCantNumerosPrimos.Text = iCantPrimos & " (" & dPromCantPrimos & ")"
    End Sub

    Private Sub dtpFecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecha.KeyPress
        Dim dFecha As Date
        Dim Consulta As String

        dFecha = dtpFecha.Text
        Consulta = "SELECT * from Sorteos where Fecha = '" & dFecha & "'"
    End Sub

    Private Sub frmAnalizarJugadas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        QuitarNegrita()
    End Sub

    Private Sub frmAnalizarJugadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chlSorteos.SetItemChecked(0, True)
        LabelAnterior = lblSorteo : LabelActual = lblSorteo
        Me.Size = New System.Drawing.Size(402, 476)
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        'Dim Rta As MsgBoxResult

        'Rta = MessageBox.Show("Confirmar salida.", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If Rta = vbYes Then Me.Close()
        Me.Close()
    End Sub

    Private Sub txtNumSorteo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumSorteo.KeyPress
        If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 127 And Asc(e.KeyChar) <> 32 Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = 13 Then
            btnAnalizarJugada.Focus()
        End If
    End Sub

    Private Sub lblNumSorteoAnterior_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblNumSorteoAnterior.MouseEnter
        panel1.Text = "Números del sorteo anterior más frecuentes en este sorteo."
    End Sub

    Private Sub lblNumSorteoAnterior_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblNumSorteoAnterior.MouseLeave, lblTerminacionMasRepetida.MouseLeave
        panel1.Text = ""
    End Sub

    Private Sub lblTerminacion_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblTerminacionMasRepetida.MouseEnter
        panel1.Text = "Dígito final de un nro. que más veces se repite en el o los sorteos."
    End Sub

#Region "AplicarNegrita"
    Private Sub lblSorteo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblSorteo.Click
        AplicarNegrita(lblSorteo)
    End Sub

    Private Sub lblFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFecha.Click
        AplicarNegrita(lblFecha)
    End Sub

    Private Sub lblNumMasFrecuente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblNumMasFrecuente.Click
        AplicarNegrita(lblNumMasFrecuente)
    End Sub

    Private Sub lblNumMenosFrecuente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblNumMenosFrecuente.Click
        AplicarNegrita(lblNumMenosFrecuente)
    End Sub

    Private Sub lblCantidadPares_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblCantidadPares.Click
        AplicarNegrita(lblCantidadPares)
    End Sub

    Private Sub lblTerminacionMasRepetida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTerminacionMasRepetida.Click
        AplicarNegrita(lblTerminacionMasRepetida)
    End Sub

    Private Sub lblNumSorteoAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNumSorteoAnterior.Click
        AplicarNegrita(lblNumSorteoAnterior)
    End Sub

    Private Sub lblCantNumerosUnDigito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCantNumerosUnDigito.Click
        AplicarNegrita(lblCantNumerosUnDigito)
    End Sub

    Private Sub lblAlMenosDosConsecutivos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAlMenosDosConsecutivos.Click
        AplicarNegrita(lblAlMenosDosConsecutivos)
    End Sub

    Private Sub lblSumatoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSumatoria.Click
        AplicarNegrita(lblSumatoria)
    End Sub

    Private Sub lblDiferenciasEntreContiguos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDiferenciasEntreContiguos.Click
        AplicarNegrita(lblDiferenciasEntreContiguos)
    End Sub

    Private Sub lblCantidadPrimos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCantidadPrimos.Click
        AplicarNegrita(lblCantidadPrimos)
    End Sub
#End Region

    Private Sub picTeclado_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picTeclado.MouseEnter
        Cursor = System.Windows.Forms.Cursors.Hand
        panel1.Text = "Clic para acceder al teclado virtual"
    End Sub

    Private Sub picTeclado_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picTeclado.MouseLeave
        Cursor = System.Windows.Forms.Cursors.Arrow
        panel1.Text = ""
    End Sub

    Private Sub picTeclado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picTeclado.Click
        UsrTecladoVirtual1.Visible = True
        UsrTecladoVirtual1.Focus()

        If UsrControlVisible = False Then
            UsrControlVisible = True
            Me.Width = 595
        Else
            UsrControlVisible = False
            Me.Width = 402
        End If
    End Sub

    Private Sub UsrTecladoVirtual1_PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs) Handles UsrTecladoVirtual1.PropertyChanged
        If UsrTecladoVirtual1.TeclaPulsada <> "Cerrar" Then
            If Len(txtNumSorteo.Text) < txtNumSorteo.MaxLength Then
                txtNumSorteo.Text = txtNumSorteo.Text & UsrTecladoVirtual1.TeclaPulsada
            End If
        Else
            Me.Width = 402
            UsrControlVisible = False
        End If
    End Sub
End Class