Imports System.Data.SqlClient
Imports System.Math

Public Class frmAnalizarSerie
    'https://foro.elhacker.net/net/solucionado_cambiar_el_color_de_una_linea_en_un_richtextbox-t377047.0.html

    Dim lstNumeros, lstNumerosSinRepetir As New List(Of String)
    Dim strSorteo, strSorteoNeto As String
    Dim UsrControlVisible As Boolean

    Private Sub btnAnalizarJugada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnalizarJugada.Click
        erpAnalizarSerie.Clear()    'erpAnalizarSerie.Dispose()
        Call LimpiarControles()

        strSorteo = "" : strSorteoNeto = "" : lstNumerosSinRepetir = New List(Of String)

        If txtNum1.Text = "" Or txtNum2.Text = "" Or txtNum3.Text = "" Or txtNum4.Text = "" Or txtNum5.Text = "" Or txtNum6.Text = "" Then
            erpAnalizarSerie.SetError(txtNum6, "La serie no contiene los 6 números")
            Exit Sub
        End If

        If txtNum1.Text > 41 Or txtNum2.Text > 41 Or txtNum3.Text > 41 Or txtNum4.Text > 41 Or txtNum5.Text > 41 Or txtNum6.Text > 41 Then
            erpAnalizarSerie.SetError(txtNum6, "La serie contiene números mayores a 41")
            Exit Sub
        End If

        strSorteo = txtNum1.Text & txtNum2.Text & txtNum3.Text & txtNum4.Text & txtNum5.Text & txtNum6.Text

        If strSorteo = "" Then Exit Sub

        Call CargarListasNumeros()
        Call NumerosMasFrecuentes()
        Call NumerosMenosFrecuentes()
        Call CantPares()
        Call TerminacionMasRepetida()
        Call ObtenerNumerosSorteoAnterior()
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
    End Sub

    Private Sub CargarListasNumeros()
        For i = 0 To strSorteo.Length - 1
            strSorteoNeto = strSorteoNeto & Mid(strSorteo, i + 1, 1)
        Next

        For i = 0 To strSorteoNeto.Length - 1 Step 2
            lstNumeros.Add(Mid(strSorteoNeto, i + 1, 2))
        Next

        For i = 0 To lstNumeros.Count - 1
            lstNumerosSinRepetir.Add(lstNumeros(i))
        Next
    End Sub

    Private Sub NumerosMasFrecuentes()
        Dim Vec(0 To 41), iMayor, iValor As Byte
        Dim sNumMasRepetido As String

        For i = 0 To lstNumeros.Count - 1
            If Mid(lstNumeros(i), 1, 2) <> "xx" Then
                iValor = Mid(lstNumeros(i), 1, 2)
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

        For i = 0 To lstNumeros.Count - 1
            If Mid(lstNumeros(i), 1, 2) <> "xx" Then
                iValor = Mid(lstNumeros(i), 1, 2)
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

        For i = 0 To strSorteoNeto.Length - 1 Step 2
            If Mid(strSorteoNeto, i + 1, 2) Mod 2 = 0 Then
                iCantPares += 1
            End If
        Next

        txtCantPares.Text = iCantPares
    End Sub

    Private Sub TerminacionMasRepetida()
        Dim VecCantidadTerminaciones(0 To 9), iMayor, iSegundoDigito As Byte
        Dim sNumMasRepetido As String

        'Obtengo la cantidad de veces que tuvo cada terminación:
        For j = 0 To lstNumeros.Count - 1
            iSegundoDigito = Mid(lstNumeros(j), 2, 1)
            VecCantidadTerminaciones(iSegundoDigito) += 1
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

    'Private Sub ObtenerNumerosSorteoAnterior()
    '    Dim sNumSorteo, sSorteoAnterior As String
    '    Dim lSorteoAnterior As New List(Of String)
    '    Dim myReader As SqlDataReader
    '    Dim ComandoADO As SqlCommand
    '    Dim paramEntrada1, paramEntrada2, paramEntrada3 As SqlParameter

    '    If txtSorteoAnterior.Text = "" Then Exit Sub
    '    sNumSorteo = txtSorteoAnterior.Text

    '    ComandoADO = New SqlCommand("spBuscarSorteo", CN)
    '    ComandoADO.CommandType = CommandType.StoredProcedure

    '    paramEntrada1 = New SqlParameter("@Sorteo", SqlDbType.VarChar, 12)
    '    paramEntrada1.Direction = ParameterDirection.Input
    '    paramEntrada1.Value = sNumSorteo
    '    ComandoADO.Parameters.Add(paramEntrada1)

    '    paramEntrada2 = New SqlParameter("@Fecha1", SqlDbType.DateTime, 8)
    '    paramEntrada2.Direction = ParameterDirection.Input
    '    paramEntrada2.Value = DBNull.Value
    '    ComandoADO.Parameters.Add(paramEntrada2)

    '    paramEntrada3 = New SqlParameter("@Fecha2", SqlDbType.DateTime, 8)
    '    paramEntrada3.Direction = ParameterDirection.Input
    '    paramEntrada3.Value = DBNull.Value
    '    ComandoADO.Parameters.Add(paramEntrada3)

    '    myReader = ComandoADO.ExecuteReader()

    '    If myReader.HasRows Then
    '        Do While myReader.Read
    '            sSorteoAnterior = myReader(2) & myReader(3) & myReader(4)
    '        Loop
    '    Else
    '        erpAnalizarSerie.SetError(txtSorteoAnterior, "No se encontraron jugadas de este sorteo")
    '        Exit Sub
    '    End If

    '    myReader.Close()

    '    Dim Vec(0 To 41), iMayor As Byte
    '    Dim sMayor As String
    '    For i = 1 To sSorteoAnterior.Length - 2 Step 2
    '        For j = 1 To strSorteoNeto.Length - 2 Step 2
    '            If Mid(sSorteoAnterior, i, 2) = Mid(strSorteoNeto, j, 2) Then
    '                Vec(Mid(sSorteoAnterior, i, 2)) += 1
    '            End If
    '        Next
    '    Next

    '    mtbSerieAnteriorTra.Text = sSorteoAnterior.Substring(0, 12)
    '    If Len(sSorteoAnterior) > 12 Then mtbSerieAnteriorDes.Text = sSorteoAnterior.Substring(12, 12)
    '    If Len(sSorteoAnterior) > 24 Then mtbSerieAnteriorSos.Text = sSorteoAnterior.Substring(24, 12)

    '    For i = 0 To Vec.Length - 1
    '        If Vec(i) > iMayor Then
    '            iMayor = Vec(i)
    '        End If
    '    Next

    '    If iMayor = 0 Then Exit Sub

    '    For i = 0 To Vec.Length - 1
    '        If Vec(i) = iMayor Then
    '            sMayor = i
    '            If Len(sMayor) = 1 Then sMayor = "0" & sMayor
    '            cbxNumSorteoAnterior.Items.Add(sMayor)
    '        End If
    '    Next

    '    If cbxNumSorteoAnterior.Items.Count > 0 Then
    '        cbxNumSorteoAnterior.Text = cbxNumSorteoAnterior.Items(0)
    '    End If
    'End Sub

    Private Sub ObtenerNumerosSorteoAnterior()
        Dim iNumSorteo As Integer
        Dim sSorteoAnterior As String
        Dim lSorteoAnterior As New List(Of String)
        Dim myReader As SqlDataReader

        If txtSorteoAnterior.Text = "" Then Exit Sub
        iNumSorteo = txtSorteoAnterior.Text

        myReader = objConexion.BuscarJugada(iNumSorteo, "", #12:00:00 AM#, #12:00:00 AM#)

        If myReader.HasRows Then
            Do While myReader.Read
                sSorteoAnterior = myReader(2) & myReader(3) & myReader(4)
            Loop
        Else
            erpAnalizarSerie.SetError(txtSorteoAnterior, "No se encontraron jugadas de este sorteo")
            Exit Sub
        End If

        myReader.Close()

        Dim Vec(0 To 41), iMayor As Byte
        Dim sMayor As String
        For i = 1 To sSorteoAnterior.Length - 2 Step 2
            For j = 1 To strSorteoNeto.Length - 2 Step 2
                If Mid(sSorteoAnterior, i, 2) = Mid(strSorteoNeto, j, 2) Then
                    Vec(Mid(sSorteoAnterior, i, 2)) += 1
                End If
            Next
        Next

        mtbSerieAnteriorTra.Text = sSorteoAnterior.Substring(0, 12)
        If Len(sSorteoAnterior) > 12 Then mtbSerieAnteriorDes.Text = sSorteoAnterior.Substring(12, 12)
        If Len(sSorteoAnterior) > 24 Then mtbSerieAnteriorSos.Text = sSorteoAnterior.Substring(24, 12)

        For i = 0 To Vec.Length - 1
            If Vec(i) > iMayor Then
                iMayor = Vec(i)
            End If
        Next

        If iMayor = 0 Then Exit Sub

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

        For i = 0 To lstNumeros.Count - 1
            If lstNumeros(i) <> "xx" Then
                If CInt(lstNumeros(i)) < 10 Then
                    Cant += 1
                End If
            End If
        Next

        txtCantUnDigito.Text = Cant
    End Sub

    Private Sub Consecutivos()
        Dim lSorteo1, lSorteo2, lSorteo3 As New List(Of String)
        Dim sNum As String

        For i = 0 To 5
            lSorteo1.Add(lstNumeros(i))
        Next

        sNum = lSorteo1(0)
        For i = 1 To lSorteo1.Count - 1
            If CInt(sNum) + 1 = lSorteo1(i) Then
                cbxDosConsecutivos.Items.Add(sNum + "-" + lSorteo1(i))
            End If
            sNum = lSorteo1(i)
        Next

        If cbxDosConsecutivos.Items.Count > 0 Then
            cbxDosConsecutivos.Text = cbxDosConsecutivos.Items(0)
        End If
    End Sub

    Private Sub Sumatoria()
        Dim iSuma As Integer

        For i = 0 To lstNumeros.Count - 1
            If lstNumeros(i) <> "xx" Then iSuma = iSuma + CInt(lstNumeros(i))
        Next

        txtSumatoria.Text = iSuma
    End Sub

    Private Sub DiferenciaMinimaYMaximaEntreContiguos()
        Dim iNum1, iNum2 As SByte
        Dim iDifMinima, iDifMaxima As Integer

        iDifMinima = 50

        For i = 0 To 4
            iNum1 = CInt(lstNumeros(i))
            iNum2 = CInt(lstNumeros(i + 1))
            If Abs(iNum2 - iNum1) > iDifMaxima Then iDifMaxima = Abs(iNum2 - iNum1)
            If Abs(iNum2 - iNum1) < iDifMinima Then iDifMinima = Abs(iNum2 - iNum1)
        Next

        txtDiferenciaMinMax.Text = iDifMinima & " - " & iDifMaxima
    End Sub

    Private Sub CantPrimos()
        Dim iNumActual, iCantDivisores, iCantPrimos As Byte

        For i = 0 To lstNumeros.Count - 1
            If lstNumeros(i) <> "xx" Then
                iNumActual = lstNumeros(i)
                For j = 1 To iNumActual
                    If iNumActual Mod j = 0 Then
                        iCantDivisores += 1
                    End If
                Next j
                If iCantDivisores = 2 Then iCantPrimos += 1
                iCantDivisores = 0
            End If
        Next i

        txtCantNumerosPrimos.Text = iCantPrimos
    End Sub

    Private Sub frmAnalizarJugadas_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        QuitarNegrita()
    End Sub

    Private Sub frmAnalizarJugadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LabelAnterior = lblSerie : LabelActual = lblSerie
        Me.Size = New System.Drawing.Size(402, 476)
    End Sub

    Private Sub txtSorteoAnterior_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSorteoAnterior.KeyPress
        If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 127 And Asc(e.KeyChar) <> 32 Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = 13 Then
            btnAnalizarJugada.Focus()
        End If
    End Sub

    Private Sub lblNumSorteoAnterior_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblNumSorteoAnterior.MouseLeave, lblTerminacionMasRepetida.MouseLeave
        panel1.Text = ""
    End Sub

    Private Sub lblTerminacionMasRepetida_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblTerminacionMasRepetida.MouseEnter
        panel1.Text = "Dígito final de un nro. que más veces se repite en el o los sorteos."
    End Sub

#Region "AplicarNegrita"
    Private Sub lblSerie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSerie.Click
        AplicarNegrita(lblSerie)
    End Sub

    ''Private Sub lblSorteoAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ''    AplicarNegrita(lblSorteoAnterior)
    ''End Sub

    Private Sub lblNumMasFrecuente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNumMasFrecuente.Click
        AplicarNegrita(lblNumMasFrecuente)
    End Sub

    Private Sub lblNumMenosFrecuente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNumMenosFrecuente.Click
        AplicarNegrita(lblNumMenosFrecuente)
    End Sub

    Private Sub lblCantidadPares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCantidadPares.Click
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

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub txtNum1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNum1.KeyPress, txtNum2.KeyPress, txtNum3.KeyPress, txtNum4.KeyPress, txtNum5.KeyPress, txtNum6.KeyPress
        If ((Asc(e.KeyChar) < 48) Or (Asc(e.KeyChar) > 57)) And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(13) Then SendKeys.Send("{tab}")
    End Sub

    Private Sub txtNum1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNum1.KeyUp
        If Len(txtNum1.Text) = 2 Then SendKeys.Send("{tab}")
    End Sub

    Private Sub txtNum2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNum2.KeyUp
        If Len(txtNum2.Text) = 2 Then SendKeys.Send("{tab}")
    End Sub

    Private Sub txtNum3_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNum3.KeyUp
        If Len(txtNum3.Text) = 2 Then SendKeys.Send("{tab}")
    End Sub

    Private Sub txtNum4_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNum4.KeyUp
        If Len(txtNum4.Text) = 2 Then SendKeys.Send("{tab}")
    End Sub

    Private Sub txtNum5_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNum5.KeyUp
        If Len(txtNum5.Text) = 2 Then SendKeys.Send("{tab}")
    End Sub

    Private Sub txtNum6_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNum6.KeyUp
        If Len(txtNum6.Text) = 2 Then SendKeys.Send("{tab}")
    End Sub

    Private Sub txtSorteoAnterior_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSorteoAnterior.MouseEnter
        panel1.Text = "Nº de sorteo que se tomará como referencia (se supondrá la última jugada)"
    End Sub

    Private Sub txtSorteoAnterior_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSorteoAnterior.MouseLeave
        panel1.Text = ""
    End Sub

    Private Sub txtSorteoAnterior_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSorteoAnterior.TextChanged
        If txtSorteoAnterior.Text = "" Then erpAnalizarSerie.Clear()
    End Sub

    Private Sub picTeclado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picTeclado.Click
        UsrTecladoVirtual1.Visible = True
        UsrTecladoVirtual1.Focus()

        If UsrControlVisible = False Then
            UsrControlVisible = True
            Me.Width = 595
        Else
            UsrControlVisible = False
            Me.Width = 395
        End If
    End Sub

    Private Sub UsrTecladoVirtual1_PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs) Handles UsrTecladoVirtual1.PropertyChanged
        If UsrTecladoVirtual1.TeclaPulsada <> "Cerrar" Then
            If Len(txtSorteoAnterior.Text) < txtSorteoAnterior.MaxLength Then
                txtSorteoAnterior.Text = txtSorteoAnterior.Text & UsrTecladoVirtual1.TeclaPulsada
            End If
        Else
            Me.Width = 402
            UsrControlVisible = False
        End If
    End Sub

    Private Sub picTeclado_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles picTeclado.MouseEnter
        Cursor = System.Windows.Forms.Cursors.Hand
        panel1.Text = "Clic para acceder al teclado virtual"
    End Sub

    Private Sub picTeclado_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picTeclado.MouseLeave
        Cursor = System.Windows.Forms.Cursors.Arrow
        panel1.Text = ""
    End Sub
End Class