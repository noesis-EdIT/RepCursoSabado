Imports System.Data.SqlClient
Imports System.Math

Public Class frmAnalizarGrupoJugadas
    Dim VecOrdenado(41, 1) As String
    Dim dtSorteos As New DataTable
    Dim lista As New List(Of String)

    Private Sub dtpFechaDesde_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFechaDesde.TextChanged, dtpFechaHasta.TextChanged
        Dim Fecha1, Fecha2 As Date

        erpAnalizarVariasJugadas.Dispose()
        Fecha1 = dtpFechaDesde.Text : Fecha2 = dtpFechaHasta.Text
        If Fecha1 > Fecha2 Then
            erpAnalizarVariasJugadas.SetError(dtpFechaHasta, "La fecha inicial no debe ser posterior a la fecha final.")
        End If
    End Sub

    Private Sub btnAnalizarJugada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnalizarJugada.Click
        Dim dFecha1, dFecha2 As Date

        If chlSorteos.CheckedItems.Count < 1 Then Exit Sub
        Cursor = Cursors.WaitCursor
        pnlAnalizarVariasJugadas.Text = "Procesando jugadas..."
        dFecha1 = dtpFechaDesde.Text : dFecha2 = dtpFechaHasta.Text
        lista.Clear()
        dtSorteos.Clear()

        Call LimpiarControles()
        Call BuscarJugada(0, dFecha1, dFecha2)
        If dtSorteos.Rows.Count = 0 Then
            Cursor = Cursors.Default
            Exit Sub
        End If
        Call CargarListaDeSorteos()
        Call NumerosMasFrecuentes()
        Call NumerosMenosFrecuentes()
        Call CantPares()
        Call TerminacionMasRepetida()
        Call ObtenerNumerosSorteoAnterior()
        Call PromedioCantidadNumerosConUnDigito()
        Call Consecutivos()
        Call SumatoriaPromedio()
        Call DiferenciaMinimaYMaximaEntreContiguos()
        Call CantPrimosPromedio()

        Cursor = Cursors.Default
        pnlAnalizarVariasJugadas.Text = ""
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
        txtDiferenciaMinMax.Text = ""
        txtCantNumerosPrimos.Text = ""
    End Sub

    Public Sub BuscarJugada(ByVal iNumSorteo As UShort, ByVal Fecha1 As Date, ByVal Fecha2 As Date)
        Dim objDa As SqlDataAdapter

        objDa = objConexion.BuscarJugadaDA(iNumSorteo, "", Fecha1, Fecha2)
        objDa.Fill(dtSorteos)
    End Sub

    Private Sub CargarListaDeSorteos()
        If dtSorteos.Rows.Count > 0 Then
            For i = 0 To dtSorteos.Rows.Count - 1
                If chlSorteos.GetItemCheckState(0).ToString() = "Checked" Then
                    lista.Add(dtSorteos.Rows(i).Item(2))
                Else
                    lista.Add("xxxxxxxxxxxx")
                End If

                If chlSorteos.GetItemCheckState(1).ToString() = "Checked" Then
                    lista(i) = lista(i) & Replace(dtSorteos.Rows(i).Item(3), "000000000000", "xxxxxxxxxxxx")
                Else
                    lista(i) = lista(i) & "xxxxxxxxxxxx"
                End If

                If chlSorteos.GetItemCheckState(2).ToString() = "Checked" Then
                    lista(i) = lista(i) & Replace(dtSorteos.Rows(i).Item(4), "000000000000", "xxxxxxxxxxxx")
                Else
                    lista(i) = lista(i) & "xxxxxxxxxxxx"
                End If
            Next i
        End If
    End Sub

    Sub NumerosMasFrecuentes()
        Dim Vec(0 To 41), iMayor, iValor As Byte
        Dim sNumMasRepetido As String

        For i = 0 To lista.Count - 1
            For j = 1 To lista(i).Length - 1 Step 2
                If Mid(lista(i), j, 2) <> "xx" Then
                    iValor = Mid(lista(i), j, 2)
                    Vec(iValor) += 1
                End If
            Next j
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

    Sub NumerosMenosFrecuentes()
        Dim Vec(0 To 41), iMenor, iValor As Byte
        Dim sNumMasRepetido As String

        iMenor = lista.Count - 1

        For i = 0 To lista.Count - 1
            For j = 1 To lista(i).Length - 1 Step 2
                If Mid(lista(i), j, 2) <> "xx" Then
                    iValor = Mid(lista(i), j, 2)
                    Vec(iValor) += 1
                End If
            Next j
        Next i

        For i = 0 To Vec.Length - 1
            If Vec(i) < iMenor Then
                iMenor = Vec(i)
            End If
        Next

        For i = 0 To Vec.Length - 1
            If Vec(i) = iMenor Then
                sNumMasRepetido = CStr(i)
                If Len(sNumMasRepetido) = 1 Then sNumMasRepetido = "0" & sNumMasRepetido
                cbxMenosFrecuentes.Items.Add(sNumMasRepetido)
            End If
        Next

        If cbxMenosFrecuentes.Items.Count > 0 Then cbxMenosFrecuentes.Text = cbxMenosFrecuentes.Items(0)
    End Sub

    Private Sub CantPares()
        Dim sngCantPares, dProm As Single

        For i = 0 To lista.Count - 1
            For j = 1 To lista(i).Length - 1 Step 2
                If Mid(lista(i), j, 2) <> "xx" Then
                    If Mid(lista(i), j, 2) Mod 2 = 0 Then
                        sngCantPares += 1
                    End If
                End If
            Next j
        Next i

        If lista.Count <> 0 Then
            sngCantPares = sngCantPares / lista.Count
            txtCantPares.Text = Round(sngCantPares, 2)
        End If

        dProm = Round(sngCantPares / chlSorteos.CheckedItems.Count, 2)
        txtCantPares.Text = txtCantPares.Text & " (" & dProm & ")"
    End Sub

    Private Sub TerminacionMasRepetida()
        Dim VecCantidadTerminaciones(0 To 9), iSegundoDigito, iMayor As Byte
        Dim sNumMasRepetido As String

        'Obtengo la cantidad de veces que tuvo cada terminación:
        For i = 0 To lista.Count - 1
            For j = 1 To lista(i).Length - 1 Step 2
                If Mid(lista(i), j, 2) <> "xx" Then
                    iSegundoDigito = Mid(lista(i), j + 1, 1)
                    VecCantidadTerminaciones(iSegundoDigito) += 1
                End If
            Next j
        Next i

        'Busco la CANTIDAD de veces que salió el dígito que más se repitió:
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
                'cbxTerminacion.Items.Add(sNumMasRepetido)
                cbxTerminacion.Items.Add(sNumMasRepetido & " (" & CStr(iMayor) & ")")
            End If
        Next

        If cbxTerminacion.Items.Count > 0 Then cbxTerminacion.Text = cbxTerminacion.Items(0)
    End Sub

    Private Sub ObtenerNumerosSorteoAnterior()
        Dim sConsulta, sSorteoAnterior, sSorteoPosterior, sResultado As String
        Dim iNumSorteo0, iNumSorteo1, iNumSorteoFinal As Integer
        Dim myReader As SqlDataReader
        Dim iCont As Byte


        iNumSorteo1 = dtSorteos.Rows(0).Item(0)
        iNumSorteoFinal = dtSorteos.Rows(dtSorteos.Rows.Count - 1).Item(0)
        sConsulta = "select max (NumSorteo) from Sorteos where NumSorteo < " & iNumSorteo1
        myReader = objConexion.EjecutarConsultaDR(sConsulta)

        If myReader.HasRows Then
            Do While myReader.Read
                iNumSorteo0 = myReader(0)
            Loop
            myReader.Close()
        End If

        sConsulta = "select NumSorteo, CONVERT(VARCHAR(10), Fecha, 103) "

        If chlSorteos.GetItemCheckState(0).ToString() = "Checked" Then sConsulta = sConsulta & ", SorteoTra "
        If chlSorteos.GetItemCheckState(1).ToString() = "Checked" Then sConsulta = sConsulta & ", SorteoDes "
        If chlSorteos.GetItemCheckState(2).ToString() = "Checked" Then sConsulta = sConsulta & ", SorteoSal "
        'sConsulta = sConsulta & "from Sorteos where NumSorteo = " & iNumSorteo0
        sConsulta = sConsulta & "from Sorteos where NumSorteo = " & iNumSorteo0 & " or NumSorteo = " & iNumSorteo1

        myReader = objConexion.EjecutarConsultaDR(sConsulta)

        If myReader.HasRows Then
            Do While myReader.Read
                sSorteoPosterior = ""
                iCont += 1
                If iCont = 1 Then
                    For i = 2 To myReader.FieldCount - 1
                        sSorteoAnterior = sSorteoAnterior & Replace(myReader.Item(i), "000000000000", "xxxxxxxxxxxx")
                    Next
                ElseIf iCont = 2 Then
                    For i = 2 To myReader.FieldCount - 1
                        sSorteoPosterior = sSorteoPosterior & Replace(myReader.Item(i), "000000000000", "xxxxxxxxxxxx")
                    Next
                    sResultado = sResultado & (DevolverNumerosCoincidentes(sSorteoAnterior, sSorteoPosterior))

                    sSorteoAnterior = sSorteoPosterior
                    iCont = 1
                End If
            Loop
        End If
        myReader.Close()

        DevolverNumerosCoincidentesConMasCantidad(sResultado)
    End Sub

    Private Function DevolverNumerosCoincidentes(ByVal sSorteo1 As String, ByVal sSorteo2 As String) As String
        Dim sNumActual, sResultado As String
        Dim lstSorteoAnt As New List(Of String)

        If sSorteo1 = "xxxxxxxxxxxx" Or sSorteo2 = "xxxxxxxxxxxx" Then Exit Function

        For i = 1 To sSorteo1.Length - 1 Step 2
            lstSorteoAnt.Add(Mid(sSorteo1, i, 2))
        Next

        sResultado = ""

        For i = 0 To lstSorteoAnt.Count - 1
            sNumActual = lstSorteoAnt(i)
            If sSorteo2.Contains(sNumActual) Then
                sResultado = sResultado & sNumActual
            End If
        Next

        Return sResultado
    End Function

    Private Sub DevolverNumerosCoincidentesConMasCantidad(ByVal sResult As String)
        'Agrego a lstResult considerando que no sean valores ya agregados:
        Dim sNum As String
        Dim ValorAnterior As Byte
        Dim oEnumerador As IDictionaryEnumerator
        Dim iCantMaxima As Integer
        Dim lstResultado As New List(Of String)
        Dim sorted As SortedList(Of Integer, Integer) = New SortedList(Of Integer, Integer)

        If sResult = "" Then Exit Sub

        For i = 1 To sResult.Length - 1 Step 2
            sNum = Mid(sResult, i, 2)
            If sNum <> "xx" Then
                If sorted.ContainsKey(sNum) Then
                    ValorAnterior = sorted(sNum)
                    ValorAnterior += 1
                    sorted.Remove(sNum)
                    sorted.Add(sNum, ValorAnterior)
                Else
                    ValorAnterior = 1
                    sorted.Add(sNum, ValorAnterior)
                End If
            End If
        Next

        oEnumerador = sorted.GetEnumerator()
        iCantMaxima = 0
        While oEnumerador.MoveNext
            If oEnumerador.Value > iCantMaxima Then
                iCantMaxima = oEnumerador.Value
            End If
        End While

        oEnumerador = sorted.GetEnumerator()
        While oEnumerador.MoveNext
            If oEnumerador.Value >= iCantMaxima Then
                lstResultado.Add(oEnumerador.Key)
            End If
        End While

        For j = 0 To lstResultado.Count - 1
            cbxNumSorteoAnterior.Items.Add(lstResultado(j))
        Next

        If cbxNumSorteoAnterior.Items.Count > 0 Then cbxNumSorteoAnterior.Text = cbxNumSorteoAnterior.Items(0)
    End Sub

    Private Sub PromedioCantidadNumerosConUnDigito()
        Dim sCant, dProm As Single

        If lista.Count = 0 Then Exit Sub

        For i = 0 To lista.Count - 1
            For j = 1 To lista(i).Length - 1 Step 2
                If Mid(lista(i), j, 2) <> "xx" Then
                    If Mid(lista(i), j, 2) < 10 Then sCant += 1
                End If
            Next j
        Next i

        If lista.Count <> 0 Then
            sCant = sCant / lista.Count
            txtCantUnDigito.Text = Round(sCant, 2)
        End If

        dProm = Round(sCant / chlSorteos.CheckedItems.Count, 2)
        txtCantUnDigito.Text = txtCantUnDigito.Text & " (" & dProm & ")"
    End Sub

    Private Sub Consecutivos()
        Dim sListaActual, sNum, sNumSgte As String
        Dim srtList As New SortedList
        Dim iCantidadAnterior, iCantMaxima As Integer
        Dim oEnumerador As IDictionaryEnumerator
        Dim lstResultado As New List(Of String)

        If chlSorteos.GetItemCheckState(0).ToString() = "Checked" Then
            For i = 0 To lista.Count - 1
                sListaActual = lista(i)
                For j = 0 To 8 Step 2
                    sNum = Mid(sListaActual, j + 1, 2)
                    sNumSgte = Mid(sListaActual, j + 3, 2)
                    If CInt(sNum) + 1 = CInt(sNumSgte) Then
                        If srtList.ContainsKey(sNum + "-" + sNumSgte) Then
                            iCantidadAnterior = srtList(sNum + "-" + sNumSgte)
                            iCantidadAnterior += 1
                            srtList.Remove(sNum + "-" + sNumSgte)
                            srtList.Add(sNum + "-" + sNumSgte, iCantidadAnterior)
                        Else
                            iCantidadAnterior = 1
                            srtList.Add(sNum + "-" + sNumSgte, iCantidadAnterior)
                        End If
                    End If
                Next j
            Next i
        End If

        iCantidadAnterior = 0
        If chlSorteos.GetItemCheckState(1).ToString() = "Checked" Then
            For i = 0 To lista.Count - 1
                sListaActual = lista(i)
                For j = 12 To 20 Step 2
                    sNum = Mid(sListaActual, j + 1, 2)
                    sNumSgte = Mid(sListaActual, j + 3, 2)
                    If CInt(sNum) + 1 = CInt(sNumSgte) Then
                        If srtList.ContainsKey(sNum + "-" + sNumSgte) Then
                            iCantidadAnterior = srtList(sNum + "-" + sNumSgte)
                            iCantidadAnterior += 1
                            srtList.Remove(sNum + "-" + sNumSgte)
                            srtList.Add(sNum + "-" + sNumSgte, iCantidadAnterior)
                        Else
                            iCantidadAnterior = 1
                            srtList.Add(sNum + "-" + sNumSgte, iCantidadAnterior)
                        End If
                    End If
                Next j
            Next i
        End If

        iCantidadAnterior = 0
        If chlSorteos.GetItemCheckState(2).ToString() = "Checked" Then
            For i = 0 To lista.Count - 1
                sListaActual = lista(i)
                For j = 24 To 32 Step 2
                    sNum = Mid(sListaActual, j + 1, 2)
                    sNumSgte = Mid(sListaActual, j + 3, 2)
                    If CInt(sNum) + 1 = CInt(sNumSgte) Then
                        If srtList.ContainsKey(sNum + "-" + sNumSgte) Then
                            iCantidadAnterior = srtList(sNum + "-" + sNumSgte)
                            iCantidadAnterior += 1
                            srtList.Remove(sNum + "-" + sNumSgte)
                            srtList.Add(sNum + "-" + sNumSgte, iCantidadAnterior)
                        Else
                            iCantidadAnterior = 1
                            srtList.Add(sNum + "-" + sNumSgte, iCantidadAnterior)
                        End If
                    End If
                Next j
            Next i
        End If

        oEnumerador = srtList.GetEnumerator()
        iCantMaxima = 0
        While oEnumerador.MoveNext
            If oEnumerador.Value > iCantMaxima Then
                iCantMaxima = oEnumerador.Value
            End If
        End While

        oEnumerador = srtList.GetEnumerator()
        While oEnumerador.MoveNext
            If oEnumerador.Value >= iCantMaxima Then
                lstResultado.Add(oEnumerador.Key & " (" & oEnumerador.Value & ")")
            End If
        End While

        For j = 0 To lstResultado.Count - 1
            cbxDosConsecutivos.Items.Add(lstResultado(j))
        Next

        If cbxDosConsecutivos.Items.Count > 0 Then cbxDosConsecutivos.Text = cbxDosConsecutivos.Items(0)
    End Sub

    Private Sub SumatoriaPromedio()
        Dim iSuma As Integer
        Dim SumaPromedio, dProm As Single

        For i = 0 To lista.Count - 1
            For j = 0 To lista(i).Length - 1 Step 2
                If lista(i).Substring(j, 2) <> "xx" Then
                    iSuma += CInt(lista(i).Substring(j, 2))
                End If
            Next j
        Next

        If lista.Count > 0 Then
            SumaPromedio = iSuma / lista.Count
            txtSumatoria.Text = Format(SumaPromedio, "##,##0.00")
        End If

        dProm = Round(SumaPromedio / chlSorteos.CheckedItems.Count, 2)
        txtSumatoria.Text = txtSumatoria.Text & " (" & dProm & ")"
    End Sub

    Private Sub DiferenciaMinimaYMaximaEntreContiguos()
        Dim iNum1, iNum2 As Byte
        Dim iDifMinima, iDifMaxima As Integer
        Dim sFilaActual As String

        iDifMinima = 50

        For i = 0 To lista.Count - 1
            If chlSorteos.GetItemCheckState(0).ToString() = "Checked" Then
                sFilaActual = lista(i).Substring(0, 12)
                For j = 0 To 9 Step 2
                    iNum1 = CInt(sFilaActual.Substring(j, 2))
                    iNum2 = CInt(sFilaActual.Substring(j + 2, 2))
                    If Math.Abs(iNum2 - iNum1) > iDifMaxima Then iDifMaxima = Math.Abs(iNum2 - iNum1)
                    If Math.Abs(iNum2 - iNum1) < iDifMinima Then iDifMinima = Math.Abs(iNum2 - iNum1)
                Next j
            End If

            If chlSorteos.GetItemCheckState(1).ToString() = "Checked" Then
                sFilaActual = lista(i).Substring(12, 12)
                For j = 0 To 9 Step 2
                    iNum1 = CInt(sFilaActual.Substring(j, 2))
                    iNum2 = CInt(sFilaActual.Substring(j + 2, 2))
                    If Math.Abs(iNum2 - iNum1) > iDifMaxima Then iDifMaxima = Math.Abs(iNum2 - iNum1)
                    If Math.Abs(iNum2 - iNum1) < iDifMinima Then iDifMinima = Math.Abs(iNum2 - iNum1)
                Next j
            End If

            If chlSorteos.GetItemCheckState(2).ToString() = "Checked" Then
                sFilaActual = lista(i).Substring(24, 12)
                For j = 0 To 9 Step 2
                    iNum1 = CInt(sFilaActual.Substring(j, 2))
                    iNum2 = CInt(sFilaActual.Substring(j + 2, 2))
                    If Math.Abs(iNum2 - iNum1) > iDifMaxima Then iDifMaxima = Math.Abs(iNum2 - iNum1)
                    If Math.Abs(iNum2 - iNum1) < iDifMinima Then iDifMinima = Math.Abs(iNum2 - iNum1)
                Next j
            End If
        Next i

        txtDiferenciaMinMax.Text = iDifMinima & " - " & iDifMaxima
    End Sub

    Private Sub CantPrimosPromedio()
        Dim sFilaActual As String
        Dim iNumActual, iCantDivisores As Byte, iCantPrimos As Integer
        Dim dPromedioPrimos, dProm As Single

        For i = 0 To lista.Count - 1
            sFilaActual = lista(i)

            For j = 0 To sFilaActual.Length - 1 Step 2
                If sFilaActual.Substring(j, 2) <> "xx" Then
                    iNumActual = sFilaActual.Substring(j, 2)
                End If
                For k = 1 To iNumActual
                    If iNumActual Mod k = 0 Then iCantDivisores += 1
                Next k
                If iCantDivisores = 2 Then iCantPrimos += 1
                iCantDivisores = 0
            Next j
        Next i

        If lista.Count > 0 Then
            dPromedioPrimos = Format((iCantPrimos / lista.Count), "##,##0.00")
            txtCantNumerosPrimos.Text = dPromedioPrimos
        End If

        dProm = Round(dPromedioPrimos / chlSorteos.CheckedItems.Count, 2)
        txtCantNumerosPrimos.Text = txtCantNumerosPrimos.Text & " (" & dProm & ")"
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmAnalizarGrupoJugadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpFechaDesde.Value = New DateTime(Year(Now), 1, 1) : dtpFechaHasta.Value = Date.Now
        chlSorteos.SetItemChecked(0, True)
    End Sub

    Private Sub frmAnalizarGrupoJugadas_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Call CambiarForecolors()
    End Sub

    Sub CambiarForecolors()
        For Each ctrl In pnlAnalizarVariasJugadas.Controls
            If TypeOf ctrl Is Label Then
                ctrl.ForeColor = Color.Transparent
            ElseIf TypeOf ctrl Is GroupBox Then
                For Each ctrl2 In ctrl.Controls
                    If TypeOf ctrl2 Is Label Then
                        ctrl2.ForeColor = Color.Transparent
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub frmAnalizarGrupoJugadas_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
        Me.Refresh()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlAnalizarVariasJugadas.Paint
        Dim Rect As Rectangle = New Rectangle(0, 0, pnlAnalizarVariasJugadas.Width, pnlAnalizarVariasJugadas.Height)
        Dim LinearBrush As Drawing2D.LinearGradientBrush = New Drawing2D.LinearGradientBrush(Rect, Color.DimGray, Color.DarkGray, Drawing2D.LinearGradientMode.Vertical)
        'Dim LinearBrush As Drawing2D.LinearGradientBrush = New Drawing2D.LinearGradientBrush(Rect, Color.DarkGray, Color.Black, Drawing2D.LinearGradientMode.Vertical)
        Dim g As Graphics = e.Graphics

        g.FillRectangle(LinearBrush, 0, 0, pnlAnalizarVariasJugadas.Width, pnlAnalizarVariasJugadas.Height)
    End Sub

    Private Sub cbxMasFrecuentes_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxMasFrecuentes.MouseEnter, cbxMenosFrecuentes.MouseEnter
        panel1.Text = "Más información en formulario de 'Números más frecuentes'"
    End Sub

    Private Sub cbxMasFrecuentes_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxMasFrecuentes.MouseLeave, cbxMenosFrecuentes.MouseLeave
        panel1.Text = ""
    End Sub

    Private Sub txtNumSorteoDesde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumSorteoDesde.KeyPress, txtNumSorteoHasta.KeyPress
        If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 127 And Asc(e.KeyChar) <> 32 Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = 13 Then
            If txtNumSorteoDesde.Text = "" Then
                erpAnalizarVariasJugadas.SetError(txtNumSorteoDesde, "Falta ingresar el nº de sorteo inicial")
            ElseIf txtNumSorteoHasta.Text = "" Then
                erpAnalizarVariasJugadas.SetError(txtNumSorteoHasta, "Falta ingresar el nº de sorteo final")
            Else
                Call BuscarPorNumeroDeJugada()
            End If
        End If
    End Sub

    Sub BuscarPorNumeroDeJugada()

    End Sub
End Class