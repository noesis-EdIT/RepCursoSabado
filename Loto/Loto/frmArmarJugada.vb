Imports System.Random
Imports System.Data.SqlClient
Imports System
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging

Public Class frmArmarJugada
    Dim NumerosGenerados(5) As String
    Dim Opcion(0 To 9) As Boolean
    Dim oLabel() As Label
    Dim iNumPicActual As Integer
    Dim VecOrdenado(41, 1) As String

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        statusBar1.Panels.Remove(panel1)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCantPares.Text = 3
        dtpFechaDesde.Value = New DateTime(Year(Now), 1, 1)
        Call CargarParametros()
    End Sub

    Private Sub CargarParametros()
        objParametroJugada = clsParametrosJugada.Leer
        txtIncluir1.Text = IIf(objParametroJugada.NumIncluir1 = -1, "", objParametroJugada.NumIncluir1)
        txtIncluir2.Text = IIf(objParametroJugada.NumIncluir2 = -1, "", objParametroJugada.NumIncluir2)
        txtIncluir3.Text = IIf(objParametroJugada.NumIncluir3 = -1, "", objParametroJugada.NumIncluir3)
        txtCantPares.Text = objParametroJugada.CantPares
        txtTerminacion.Text = objParametroJugada.TerminacionParaDosNum
        txtNumSorteoAnterior.Text = IIf(objParametroJugada.NumSorteoAnterior = -1, "", objParametroJugada.NumSorteoAnterior)
        txtCantUnDigito.Text = objParametroJugada.CantNumUnSoloDigito
        chkUnParConsecutivos.Checked = IIf(objParametroJugada.AlmenosDosNumConsec = True, True, False)
        NumericUpDownInferior.Value = objParametroJugada.SumatoriaMinima
        NumericUpDownSuperior.Value = objParametroJugada.SumatoriaMaxima
        nudDifMinima.Value = objParametroJugada.DifEntreConsecutivosMin
        nudDifMaxima.Value = objParametroJugada.DifEntreConsecutivosMax
        txtPrimos.Text = objParametroJugada.CantMinimaPrimos
        txtExcluir1.Text = IIf(objParametroJugada.NumExcluido1 = -1, "", objParametroJugada.NumExcluido1)
        txtExcluir2.Text = IIf(objParametroJugada.NumExcluido2 = -1, "", objParametroJugada.NumExcluido2)
        txtExcluir3.Text = IIf(objParametroJugada.NumExcluido3 = -1, "", objParametroJugada.NumExcluido3)
    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        '0 = Incluir números | 1 = Cantidad de pares | 2 = Números con igual terminación | 3 = Incluir un número del sorteo anterior | 4 = Cantidad de números con sólo 1 dígito | 5 = Al menos dos números consecutivos | 
        Dim sNumero As String

        Cursor = Cursors.WaitCursor
        panel1.Text = "Generando sorteo..."
        For i = 0 To 9
            Opcion(i) = True
        Next

        Opcion(0) = IIf(chklstOpciones.GetItemCheckState(0).ToString() = "Checked", False, True)
        Opcion(1) = IIf(chklstOpciones.GetItemCheckState(1).ToString() = "Checked", False, True)
        Opcion(2) = IIf(chklstOpciones.GetItemCheckState(2).ToString() = "Checked", False, True)
        Opcion(3) = IIf(chklstOpciones.GetItemCheckState(3).ToString() = "Checked", False, True)
        Opcion(4) = IIf(chklstOpciones.GetItemCheckState(4).ToString() = "Checked", False, True)
        Opcion(5) = IIf(chklstOpciones.GetItemCheckState(5).ToString() = "Checked", False, True)
        Opcion(6) = IIf(chklstOpciones.GetItemCheckState(6).ToString() = "Checked", False, True)
        Opcion(7) = IIf(chklstOpciones.GetItemCheckState(7).ToString() = "Checked", False, True)
        Opcion(8) = IIf(chklstOpciones.GetItemCheckState(8).ToString() = "Checked", False, True)
        Opcion(9) = IIf(chklstOpciones.GetItemCheckState(9).ToString() = "Checked", False, True)

        Do While (Not Opcion(0) Or Not Opcion(1) Or Not Opcion(2) Or Not Opcion(3) Or Not Opcion(4) Or Not Opcion(5) Or Not Opcion(6) Or Not Opcion(7) Or Not Opcion(8) Or Not Opcion(9))
            GenerarSorteo()

            If Not OpcionesConsistentes() Then
                Cursor = Cursors.Default
                Exit Sub
            End If

            OrdenacionPorSeleccion(NumerosGenerados)

            If chklstOpciones.GetItemCheckState(0).ToString() = "Checked" Then
                Call IncluirNumero()
                If Not Opcion(0) Then Continue Do
            End If

            If chklstOpciones.GetItemCheckState(1).ToString() = "Checked" Then
                Call CantidadDeParesGeneradas()
                If Not Opcion(1) Then Continue Do
            End If

            If chklstOpciones.GetItemCheckState(2).ToString() = "Checked" Then
                Call HayDosNumerosConIgualTerminacion()
                If Not Opcion(2) Then Continue Do
            End If

            If chklstOpciones.GetItemCheckState(3).ToString() = "Checked" Then
                Call NumeroDelSorteoAnterior()
                If Not Opcion(3) Then Continue Do
            End If

            If chklstOpciones.GetItemCheckState(4).ToString() = "Checked" Then
                Call CantidadNumerosUnDigito()
                If Not Opcion(4) Then Continue Do
            End If

            If chklstOpciones.GetItemCheckState(5).ToString() = "Checked" Then
                Call HayAlMenosDosNumerosConsecutivos()
                If Not Opcion(5) Then Continue Do
            End If

            If chklstOpciones.GetItemCheckState(6).ToString() = "Checked" Then
                Call Sumatoria()
                If Not Opcion(6) Then Continue Do
            End If

            If chklstOpciones.GetItemCheckState(7).ToString() = "Checked" Then
                Call DiferenciaMinimaYMaximaEntreNumerosContiguos()
                If Not Opcion(7) Then Continue Do
            End If

            If chklstOpciones.GetItemCheckState(8).ToString() = "Checked" Then
                Call HayNumeroPrimo()
                If Not Opcion(8) Then Continue Do
            End If

            If chklstOpciones.GetItemCheckState(9).ToString() = "Checked" Then
                Call NumerosExcluidos()
                If Not Opcion(9) Then Continue Do
            End If
        Loop

        If (Opcion(0) And Opcion(1) And Opcion(2) And Opcion(3) And Opcion(4) And Opcion(5) And Opcion(6) And Opcion(7) And Opcion(8) And Opcion(9)) Then
            GenerarSorteo()
            'OrdenacionPorBurbujeo(NumerosGenerados)
            OrdenacionPorSeleccion(NumerosGenerados)
        End If

        For i = 0 To 5
            If sNumero = "" Then
                sNumero = NumerosGenerados(i)
            Else
                sNumero = sNumero & " " & NumerosGenerados(i)
            End If
        Next




EfectosSorteo:
        If Not IsNothing(oLabel) Then
            For i = 0 To oLabel.Length - 1
                oLabel(i).Visible = False
            Next
        End If
        CrearLabels()
        iNumPicActual = 0
        IniciarEfectos()
        EstableceObjetos()

        lstSorteos.Items.Add(sNumero)
        Cursor = Cursors.Default
        panel1.Text = ""
    End Sub

    Private Function OpcionesConsistentes() As Boolean
        Dim sNumIncluir1, sNumIncluir2, sNumIncluir3, sNumExcluir1, sNumExcluir2, sNumExcluir3 As String
        Dim iCantParesIngresados, iCantParesAObtener, iTerminacionPares As Byte
        Dim num As Integer

        OpcionesConsistentes = True

        'Opción 1 (no ingresar un nº. fuera del rango permitido):
        If chklstOpciones.GetItemCheckState(0).ToString() = "Checked" Then
            If txtIncluir1.Text <> "" Then
                If CInt(txtIncluir1.Text) > 41 Then
                    MessageBox.Show("Se ingresó un nro. fuera de rango." & vbCrLf & "Deben estar entre 0 y 41.", "Opción 1", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    panel1.Text = "Ingresar número de la opción 1."
                    txtIncluir1.Focus()
                    Cursor = Cursors.Default
                    Return False
                End If
            End If

            If txtIncluir2.Text <> "" Then
                If CInt(txtIncluir2.Text) > 41 Then
                    MessageBox.Show("Se ingresó un nro. fuera de rango." & vbCrLf & "Deben estar entre 0 y 41.", "Opción 1", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    panel1.Text = "Ingresar número de la opción 1."
                    txtIncluir2.Focus()
                    Cursor = Cursors.Default
                    Return False
                End If
            End If

            If txtIncluir3.Text <> "" Then
                If CInt(txtIncluir3.Text) > 41 Then
                    MessageBox.Show("Se ingresó un nro. fuera de rango." & vbCrLf & "Deben estar entre 0 y 41.", "Opción 1", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    panel1.Text = "Ingresar número de la opción 1."
                    txtIncluir3.Focus()
                    Cursor = Cursors.Default
                    Return False
                End If
            End If
        End If

        'Opción 7 (que su límite inferior no supere al superior):
        If chklstOpciones.GetItemCheckState(6).ToString() = "Checked" Then
            If NumericUpDownInferior.Value > NumericUpDownSuperior.Value Then
                panel1.Text = "El valor máximo de la sumatoria no puede ser inferior al mínimo - Opción 7"
                MessageBox.Show("El valor máximo de la sumatoria no puede ser" & vbCrLf & "inferior al valor mínimo de la sumatoria.", "Opción 7", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                NumericUpDownInferior.Focus()
                Cursor = Cursors.Default
                Return False
            End If
        End If

        sNumIncluir1 = IIf(Integer.TryParse(txtIncluir1.Text, num), txtIncluir1.Text, -1)
        sNumIncluir2 = IIf(Integer.TryParse(txtIncluir2.Text, num), txtIncluir2.Text, -1)
        sNumIncluir3 = IIf(Integer.TryParse(txtIncluir3.Text, num), txtIncluir3.Text, -1)
        sNumExcluir1 = IIf(Integer.TryParse(txtExcluir1.Text, num), txtExcluir1.Text, -3)
        sNumExcluir2 = IIf(Integer.TryParse(txtExcluir2.Text, num), txtExcluir2.Text, -3)
        sNumExcluir3 = IIf(Integer.TryParse(txtExcluir3.Text, num), txtExcluir3.Text, -3)
        If Len(sNumIncluir1) = 1 Then sNumIncluir1 = "0" & sNumIncluir1
        If Len(sNumIncluir2) = 1 Then sNumIncluir2 = "0" & sNumIncluir2
        If Len(sNumIncluir3) = 1 Then sNumIncluir3 = "0" & sNumIncluir3
        If Len(sNumExcluir1) = 1 Then sNumExcluir1 = "0" & sNumExcluir1
        If Len(sNumExcluir2) = 1 Then sNumExcluir2 = "0" & sNumExcluir2
        If Len(sNumExcluir3) = 1 Then sNumExcluir3 = "0" & sNumExcluir3

        iTerminacionPares = IIf(Integer.TryParse(txtTerminacion.Text, num), txtTerminacion.Text, 0)
        iCantParesAObtener = IIf(Integer.TryParse(txtCantPares.Text, num), txtCantPares.Text, 0)

        If sNumIncluir1 <> "" Then
            If (CInt(sNumIncluir1) Mod 2) = 0 Then iCantParesIngresados += 1
        End If

        If sNumIncluir2 <> "" Then
            If (CInt(sNumIncluir2) Mod 2) = 0 Then iCantParesIngresados += 1
        End If

        If sNumIncluir3 <> "" Then
            If (CInt(sNumIncluir3 Mod 2)) = 0 Then iCantParesIngresados += 1
        End If

        'Opciones 1 y 10 (que los nros. a incluir no coincidan con los nros. a excluir):
        If chklstOpciones.GetItemCheckState(0).ToString() = "Checked" And chklstOpciones.GetItemCheckState(9).ToString() = "Checked" Then
            If Not (txtIncluir1.Text = "" And txtIncluir2.Text = "" And txtIncluir3.Text = "" And txtExcluir1.Text = "" And txtExcluir2.Text = "" And txtExcluir3.Text = "") Then
                If (sNumIncluir1 = sNumExcluir1) Or (sNumIncluir1 = sNumExcluir2) Or (sNumIncluir1 = sNumExcluir3) _
                Or (sNumIncluir2 = sNumExcluir1) Or (sNumIncluir2 = sNumExcluir2) Or (sNumIncluir2 = sNumExcluir3) _
                Or (sNumIncluir3 = sNumExcluir1) Or (sNumIncluir3 = sNumExcluir2) Or (sNumIncluir3 = sNumExcluir3) Then
                    MessageBox.Show("Uno o más números a incluir coinciden" & vbCrLf & "con los números a excluir." & vbCrLf & "Opciones 1 y 10.", "Inconsistencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtIncluir1.Focus()
                    Return False
                End If
            End If
        End If

        'Opciones 1 y 2 (que los nros. incluídos no tengan más pares que la cantidad de pares indicados):
        If (iCantParesIngresados > iCantParesAObtener) And chklstOpciones.GetItemCheckState(0).ToString() = "Checked" And chklstOpciones.GetItemCheckState(1).ToString() = "Checked" = True Then
            MessageBox.Show("Entre los nros. a incluir se ingresaron mayor cantidad de pares" & vbCrLf & "que la cantidad de pares que luego se indicó." & vbCrLf & "Opciones 1 y 2.", "Inconsistencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCantPares.Focus()
            Return False
        End If

        'Opciones 2 y 3 (no pueden haber más terminaciones pares que cantidad de nros. pares):
        If chklstOpciones.GetItemCheckState(1).ToString() = "Checked" And chklstOpciones.GetItemCheckState(2).ToString() = "Checked" And chklstOpciones.GetItemCheckState(0).ToString() = "Unchecked" Then
            'iTerminacionPares = IIf(Integer.TryParse(txtTerminacion.Text, num), txtTerminacion.Text, 0)
            'iCantPares = txtCantPares.Text
            If (iTerminacionPares Mod 2) = 0 Then
                If iCantParesAObtener < 2 Then
                    MessageBox.Show("Hay más terminaciones pares (dos)" & vbCrLf & "que cantidad de pares." & vbCrLf & "Opciones 2 y 3.", "Inconsistencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtCantPares.Focus()
                    Return False
                End If
            End If
        End If

        'Opciones 1 y 3 con 2 (que los nros. a incluir más los dos con igual terminación, no tengan más pares que lo indicado en la opción 2):
        If chklstOpciones.GetItemCheckState(0).ToString() = "Checked" And chklstOpciones.GetItemCheckState(1).ToString() = "Checked" And chklstOpciones.GetItemCheckState(2).ToString() = "Checked" Then
            Dim ParesOpcion123 As Byte

            If ((iTerminacionPares Mod 2) = 0) And (iTerminacionPares <> CInt(sNumIncluir1)) And (iTerminacionPares <> CInt(sNumIncluir2)) And (iTerminacionPares <> CInt(sNumIncluir3)) Then
                ParesOpcion123 = iCantParesIngresados + 2
            ElseIf ((iTerminacionPares Mod 2) = 0) Then
                ParesOpcion123 = iCantParesIngresados + 1
            End If
            If ParesOpcion123 > iCantParesAObtener Then
                MessageBox.Show("Se ingresó una mayor cantidad de pares que" & vbCrLf & "los pares indicados en opción 2." & vbCrLf & "Opciones 1, 3 y 2.", "Inconsistencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtCantPares.Focus()
                Return False
            End If
        End If

        'Opciones 1 y 4 con 2 (evitar que entre los nros. a incluir más el nro. anterior, se supere la cantidad de pares indicados):
        If chklstOpciones.GetItemCheckState(0).ToString() = "Checked" And chklstOpciones.GetItemCheckState(3).ToString() = "Checked" And chklstOpciones.GetItemCheckState(1).ToString() = "Checked" Then
            Dim ParesOpcion124 As Byte
            Dim sNumSorteoAnterior As String

            ParesOpcion124 = iCantParesIngresados
            sNumSorteoAnterior = IIf(Integer.TryParse(txtNumSorteoAnterior.Text, num), txtNumSorteoAnterior.Text, -1)
            If Len(sNumSorteoAnterior) = 1 Then sNumSorteoAnterior = "0" & sNumSorteoAnterior

            If sNumSorteoAnterior <> -1 Then
                If ((sNumSorteoAnterior Mod 2) = 0) Then
                    If (sNumIncluir1 <> sNumSorteoAnterior) And (sNumIncluir2 <> sNumSorteoAnterior) And (sNumIncluir2 <> sNumSorteoAnterior) Then
                        ParesOpcion124 += 1
                    End If
                End If
            End If

            If ParesOpcion124 > iCantParesAObtener Then
                MessageBox.Show("Se ingresó una mayor cantidad de pares que" & vbCrLf & "los pares indicados en opción 2." & vbCrLf & "Opciones 1, 4 y 2.", "Inconsistencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtCantPares.Focus()
                Return False
            End If
        End If

    End Function

    Sub GenerarSorteo()
        Dim sValorAleatorio As String
        Dim numAleatorio As New Random()

        sValorAleatorio = numAleatorio.Next(0, 41)
        NumerosGenerados(0) = sValorAleatorio
        For i = 0 To 5
            Do While ValorRepetido(sValorAleatorio, NumerosGenerados)
                sValorAleatorio = numAleatorio.Next(0, 41)
            Loop
            NumerosGenerados(i) = sValorAleatorio
        Next
    End Sub

    Private Function ValorRepetido(ByVal Valor As Byte, ByVal Vector() As String) As Boolean
        ValorRepetido = False

        For i = 0 To Vector.Length - 1
            If Valor = Vector(i) Then Return True
        Next
    End Function

    Sub IncluirNumero()
        Dim strValActual1 As String = txtIncluir1.Text
        Dim strValActual2 As String = txtIncluir2.Text
        Dim strValActual3 As String = txtIncluir3.Text
        Dim iCantNumeros As Byte = 3
        Dim bEstaVal1, bEstaVal2, bEstaVal3 As Boolean

        Opcion(0) = False

        strValActual1 = strValActual1.Replace(" ", "")
        strValActual2 = strValActual2.Replace(" ", "")
        strValActual3 = strValActual3.Replace(" ", "")

        If String.IsNullOrEmpty(strValActual1) Then '<-- el usuario no agrega este nº a incluir, entonces lo considero como incluído en el sorteo generado.
            iCantNumeros -= 1
            bEstaVal1 = True
        End If

        If String.IsNullOrEmpty(strValActual2) Then
            iCantNumeros -= 1
            bEstaVal2 = True
        End If

        If String.IsNullOrEmpty(strValActual3) Then
            iCantNumeros -= 1
            bEstaVal3 = True
        End If

        If iCantNumeros = 0 Then
            Opcion(0) = True   '<-- no ingresó ningún nº, considero esta opción como terminada ya que el usuario no desea incluir nros. específicos
            Exit Sub
        End If

        If Len(strValActual1) = 1 Then strValActual1 = "0" & strValActual1
        If Len(strValActual2) = 1 Then strValActual2 = "0" & strValActual2
        If Len(strValActual3) = 1 Then strValActual3 = "0" & strValActual3

        For i = 0 To NumerosGenerados.Length - 1
            If (Mid(NumerosGenerados(i), 1, 2) = strValActual1) And (bEstaVal1 = False) Then
                bEstaVal1 = True
            ElseIf (Mid(NumerosGenerados(i), 1, 2) = strValActual2) And (bEstaVal2 = False) Then
                bEstaVal2 = True
            ElseIf (Mid(NumerosGenerados(i), 1, 2) = strValActual3) And (bEstaVal3 = False) Then
                bEstaVal3 = True
            End If
        Next

        If bEstaVal1 And bEstaVal2 And bEstaVal3 Then
            Opcion(0) = True
        End If
    End Sub

#Region "NumerosMasFrecuentes"

    Sub NumerosMasFrecuentes()
        Dim ComandoADO As SqlCommand
        Dim dr As SqlDataReader
        Dim Consulta As String
        Dim dFecha1, dFecha2 As Date
        Dim j As Integer
        Dim tablaNueva As New DataTable
        Dim htSorteo As New Hashtable

        htSorteo.Clear()
        dFecha1 = dtpFechaDesde.Text : dFecha2 = dtpFechaHasta.Text

        Consulta = "SELECT SorteoTra, SorteoDes, SorteoSal from Sorteos where Fecha between '" & dFecha1 & "'" & " and '" & dFecha2 & "'"

        ComandoADO = New SqlCommand(Consulta, CN)
        ComandoADO.CommandType = CommandType.Text
        ComandoADO.CommandText = Consulta
        dr = ComandoADO.ExecuteReader

        tablaNueva.Columns.Add("Sorteo")

        While dr.Read
            tablaNueva.Rows.Add(dr("SorteoTra") & dr("SorteoDes") & dr("SorteoSal"))
        End While

        For i = 0 To tablaNueva.Rows.Count - 1
            For j = 1 To 36 Step 2
                CargarHashTable(Mid(tablaNueva.Rows(i).Item(0), j, 2), htSorteo)
            Next
        Next

        If Not dr.HasRows Then
            dr.Close()
            Exit Sub
        End If

        Call OrdenarSorteos(htSorteo)
        Call CargarControlesDeNumerosMasFrecuentes()
        dr.Close()
    End Sub

    Sub CargarHashTable(ByVal sNum As String, ByVal htSorteo As Hashtable)
        Dim ValorAnterior As Integer

        If htSorteo.ContainsKey(sNum) Then
            ValorAnterior = htSorteo(sNum)
            ValorAnterior += 1
            htSorteo.Remove(sNum)
            htSorteo.Add(sNum, ValorAnterior)
        Else
            ValorAnterior = 1
            htSorteo.Add(sNum, ValorAnterior)
        End If
    End Sub

    Private Sub OrdenarSorteos(ByVal htSorteo)
        Dim oEnumerador As IDictionaryEnumerator
        Dim iNumeroActual As Integer = 0
        Dim VecAuxiliar(41, 1) As String
        Dim j As Integer
        Dim maximo, temp As Integer
        Dim Vueltas As Integer

        oEnumerador = htSorteo.GetEnumerator()

        For i = 0 To (VecAuxiliar.Length \ 2) - 1
            For j = 0 To 1
                VecOrdenado(i, j) = Nothing
            Next
        Next

        j = 0
        While oEnumerador.MoveNext
            VecAuxiliar(j, 0) = oEnumerador.Key
            VecAuxiliar(j, 1) = oEnumerador.Value
            j += 1
        End While

        While iNumeroActual < 42
            Vueltas = 0
            For i = 0 To (VecAuxiliar.Length \ 2) - 1
                If iNumeroActual = CInt(VecAuxiliar(i, 0)) Then
                    VecOrdenado(iNumeroActual, 0) = VecAuxiliar(i, 0)
                    VecOrdenado(iNumeroActual, 1) = VecAuxiliar(i, 1)
                    iNumeroActual += 1
                    Exit For
                Else
                    If Vueltas = 41 Then
                        VecOrdenado(iNumeroActual, 0) = iNumeroActual
                        VecOrdenado(iNumeroActual, 1) = 0
                        iNumeroActual += 1
                    End If
                End If
                Vueltas += 1
            Next
        End While

        'Ordeno separadamente cada grupo de 7 filas del vector (0 a 6, 7 a 13, 14 a 20, 21 a 27, 28 a 34, 35 a 41) de mayor a menor:
        Dim LimiteInf As Byte = 0
        Dim LimiteSup As Byte = 6

        Do While LimiteSup < 42
            For i = LimiteInf To LimiteSup - 1
                maximo = i
                For j = i + 1 To LimiteSup
                    If VecOrdenado(maximo, 1) < VecOrdenado(j, 1) Then
                        maximo = j
                    End If
                Next j

                temp = VecOrdenado(i, 0)
                VecOrdenado(i, 0) = VecOrdenado(maximo, 0)
                VecOrdenado(maximo, 0) = temp

                temp = VecOrdenado(i, 1)
                VecOrdenado(i, 1) = VecOrdenado(maximo, 1)
                VecOrdenado(maximo, 1) = temp
            Next i

            LimiteInf += 7 : LimiteSup += 7
        Loop
    End Sub

    Sub CargarControlesDeNumerosMasFrecuentes()
        '6 bloques: 0 a 6, 7 a 13, 14 a 20, 21 a 27, 28 a 34, 35 a 41
        mtbCol1.Text = "" : mtbCol2.Text = "" : mtbCol3.Text = "" : mtbCol4.Text = "" : mtbCol5.Text = "" : mtbCol6.Text = ""

        If Len(VecOrdenado(0, 0)) < 2 Then VecOrdenado(0, 0) = "0" & VecOrdenado(0, 0)
        If Len(VecOrdenado(1, 0)) < 2 Then VecOrdenado(1, 0) = "0" & VecOrdenado(1, 0)
        If Len(VecOrdenado(2, 0)) < 2 Then VecOrdenado(2, 0) = "0" & VecOrdenado(2, 0)
        If VecOrdenado(0, 1) > 0 And VecOrdenado(1, 1) > 0 And VecOrdenado(2, 1) > 0 Then
            mtbCol1.Text = VecOrdenado(0, 0) + VecOrdenado(1, 0) + VecOrdenado(2, 0)
        ElseIf VecOrdenado(0, 1) > 0 And VecOrdenado(1, 1) > 0 Then
            mtbCol1.Text = VecOrdenado(0, 0) + VecOrdenado(1, 0)
        ElseIf VecOrdenado(0, 1) > 0 Then
            mtbCol1.Text = VecOrdenado(0, 0)
        End If

        If Len(VecOrdenado(7, 0)) < 2 Then VecOrdenado(7, 0) = "0" & VecOrdenado(7, 0)
        If Len(VecOrdenado(8, 0)) < 2 Then VecOrdenado(8, 0) = "0" & VecOrdenado(8, 0)
        If Len(VecOrdenado(9, 0)) < 2 Then VecOrdenado(9, 0) = "0" & VecOrdenado(9, 0)
        If VecOrdenado(7, 1) > 0 And VecOrdenado(8, 1) > 0 And VecOrdenado(9, 1) > 0 Then
            mtbCol2.Text = VecOrdenado(7, 0) + VecOrdenado(8, 0) + VecOrdenado(9, 0)
        ElseIf VecOrdenado(7, 1) > 0 And VecOrdenado(8, 1) > 0 Then
            mtbCol2.Text = VecOrdenado(7, 0) + VecOrdenado(8, 0)
        ElseIf VecOrdenado(7, 1) > 0 Then
            mtbCol2.Text = VecOrdenado(7, 0)
        End If

        If VecOrdenado(14, 1) > 0 And VecOrdenado(15, 1) > 0 And VecOrdenado(16, 1) > 0 Then
            mtbCol3.Text = VecOrdenado(14, 0) + VecOrdenado(15, 0) + VecOrdenado(16, 0)
        ElseIf VecOrdenado(14, 1) > 0 And VecOrdenado(15, 1) > 0 Then
            mtbCol3.Text = VecOrdenado(14, 0) + VecOrdenado(15, 0)
        ElseIf VecOrdenado(14, 1) > 0 Then
            mtbCol3.Text = VecOrdenado(14, 0)
        End If

        If VecOrdenado(21, 1) > 0 And VecOrdenado(22, 1) > 0 And VecOrdenado(23, 1) > 0 Then
            mtbCol4.Text = VecOrdenado(21, 0) + VecOrdenado(22, 0) + VecOrdenado(23, 0)
        ElseIf VecOrdenado(21, 1) > 0 And VecOrdenado(22, 1) > 0 Then
            mtbCol4.Text = VecOrdenado(21, 0) + VecOrdenado(22, 0)
        ElseIf VecOrdenado(21, 1) > 0 Then
            mtbCol4.Text = VecOrdenado(21, 0)
        End If

        If VecOrdenado(28, 1) > 0 And VecOrdenado(29, 1) > 0 And VecOrdenado(30, 1) > 0 Then
            mtbCol5.Text = VecOrdenado(28, 0) + VecOrdenado(29, 0) + VecOrdenado(30, 0)
        ElseIf VecOrdenado(28, 1) > 0 And VecOrdenado(29, 1) > 0 Then
            mtbCol5.Text = VecOrdenado(28, 0) + VecOrdenado(29, 0)
        ElseIf VecOrdenado(28, 1) > 0 Then
            mtbCol5.Text = VecOrdenado(28, 0)
        End If

        If VecOrdenado(35, 1) > 0 And VecOrdenado(36, 1) > 0 And VecOrdenado(37, 1) > 0 Then
            mtbCol6.Text = VecOrdenado(35, 0) + VecOrdenado(36, 0) + VecOrdenado(37, 0)
        ElseIf VecOrdenado(35, 1) > 0 And VecOrdenado(36, 1) > 0 Then
            mtbCol6.Text = VecOrdenado(35, 0) + VecOrdenado(36, 0)
        ElseIf VecOrdenado(35, 1) > 0 Then
            mtbCol6.Text = VecOrdenado(35, 0)
        End If

    End Sub

#End Region

    Sub CantidadDeParesGeneradas()
        Dim CantPares, iCantParesAObtener, num As Byte

        Opcion(1) = False

        iCantParesAObtener = IIf(Byte.TryParse(txtCantPares.Text, num), txtCantPares.Text, 0)
        If iCantParesAObtener = 0 And txtCantPares.Text = "" Then txtCantPares.Text = 0

        For i = 0 To NumerosGenerados.Length - 1
            If (NumerosGenerados(i) Mod 2) = 0 Then CantPares += 1
        Next

        If (CantPares = iCantParesAObtener) Then
            Opcion(1) = True
        Else
            Opcion(1) = False
        End If
    End Sub

    Sub HayDosNumerosConIgualTerminacion()
        Dim sTerminacionQueDebeEstarDosVeces As String = txtTerminacion.Text
        Dim CantQueCumpleCondicion As Byte

        For i = 0 To NumerosGenerados.Length - 1
            If Mid(NumerosGenerados(i), 2, 1) = sTerminacionQueDebeEstarDosVeces Then
                CantQueCumpleCondicion += 1
            End If
        Next

        If CantQueCumpleCondicion = 2 Then
            Opcion(2) = True
        Else
            Opcion(2) = False
        End If
    End Sub

    Sub HayAlMenosDosNumerosConsecutivos()
        Opcion(5) = False
        For i = 0 To 4
            If NumerosGenerados(i + 1) = NumerosGenerados(i) + 1 Then
                Opcion(5) = True
            End If
        Next
    End Sub

    Sub NumeroDelSorteoAnterior()
        Dim sNumSorteoAnterior, sNumIngresadoPorUsuario As String
        Dim j As Byte = 0
        Dim UltimaFechaBase, UltimaFechaReal As Date
        Dim bEncontrado As Boolean

        UltimaFechaBase = UltimaFechaIngresada()
        UltimaFechaReal = UltimaFechaSorteada()

        If UltimaFechaBase <> UltimaFechaReal Then
            MessageBox.Show("IMPORTANTE: La base no está actualizada con el último sorteo." & vbCrLf & "El último sorteo en la base es del " & UltimaFechaBase & "." & vbCrLf & "Se considerará como sorteo anterior al último sorteo ingresado" & vbCrLf & "(el de fecha más reciente).", "Último sorteo.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        sNumSorteoAnterior = BuscarUltimaJugada()

        'Opción 1: se usa el nro. que ingresó el usuario y no se busca un nro. del último sorteo de la base -->
        If rbSorteoAnteriorManual.Checked Then
            bEncontrado = False

            If txtNumSorteoAnterior.Text <> "" Then
                sNumIngresadoPorUsuario = txtNumSorteoAnterior.Text
                For i = 0 To sNumSorteoAnterior.Length - 1 Step 2
                    If Mid(sNumSorteoAnterior, i + 1, 2) = sNumIngresadoPorUsuario Then
                        bEncontrado = True
                        Exit For
                    End If
                Next
            End If

            If bEncontrado = False Then
                MessageBox.Show("El nro. de sorteo anterior ingresado manualmente (opción 4)," & vbCrLf & "no pertenece al último sorteo. Ingresar otro nro. o" & vbCrLf & "seleccionar la opción automática.", "Nro. de sorteo anterior - No se considerará esta opción.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtNumSorteoAnterior.Focus()
                Opcion(3) = True
                Exit Sub
            End If

            If bEncontrado Then
                For i = 0 To 4
                    If sNumIngresadoPorUsuario = Mid(NumerosGenerados(i), i + 1, 2) Then
                        Opcion(3) = True
                        Exit Sub
                    End If
                Next
            End If
        End If

        'Opción 2: se busca uno de los nros. del último sorteo de la base -->
        If rbSorteoAnteriorAutom.Checked Then
            For i = 0 To 4
                For j = 0 To Len(sNumSorteoAnterior) - 1 Step 2
                    If NumerosGenerados(i) = Mid(sNumSorteoAnterior, j + 1, 2) Then
                        txtNumSorteoAnterior.Text = Mid(sNumSorteoAnterior, j + 1, 2)
                        Opcion(3) = True
                        Exit Sub
                    End If
                Next j
            Next i
        End If
    End Sub

    Sub CantidadNumerosUnDigito()
        Dim CantRequerida As Byte = txtCantUnDigito.Text
        Dim CantGenerada As Byte

        Opcion(4) = False
        For i = 0 To NumerosGenerados.Length - 1
            If CInt(NumerosGenerados(i)) < 10 Then CantGenerada += 1
        Next
        If CantGenerada = CantRequerida Then Opcion(4) = True
    End Sub

    Sub Sumatoria()
        Dim Suma, iLimiteInferior, iLimiteSuperior As Integer

        Opcion(6) = False
        iLimiteInferior = NumericUpDownInferior.Value
        iLimiteSuperior = NumericUpDownSuperior.Value
        For i = 0 To 5
            Suma = Suma + NumerosGenerados(i)
        Next

        If (Suma > iLimiteInferior) And (Suma < iLimiteSuperior) Then
            Opcion(6) = True
        End If
    End Sub

    Sub DiferenciaMinimaYMaximaEntreNumerosContiguos()
        Dim iDiferenciaMinima, iDiferenciaMaxima As Integer

        iDiferenciaMinima = nudDifMinima.Value
        iDiferenciaMaxima = nudDifMaxima.Value
        Opcion(7) = True

        For i = 0 To NumerosGenerados.Length - 2
            If (Math.Abs(CInt(NumerosGenerados(i)) - CInt(NumerosGenerados(i + 1))) < iDiferenciaMinima) Or (Math.Abs(CInt(NumerosGenerados(i)) - CInt(NumerosGenerados(i + 1))) > iDiferenciaMaxima) Then
                Opcion(7) = False
                Exit Sub
            End If
        Next
    End Sub

    Sub HayNumeroPrimo()
        Dim lNumerosPrimos As New List(Of Byte)
        Dim iCantPrimos As Byte

        lNumerosPrimos.Add(2) : lNumerosPrimos.Add(3) : lNumerosPrimos.Add(5) : lNumerosPrimos.Add(7)
        lNumerosPrimos.Add(11) : lNumerosPrimos.Add(13) : lNumerosPrimos.Add(17) : lNumerosPrimos.Add(19)
        lNumerosPrimos.Add(23) : lNumerosPrimos.Add(29) : lNumerosPrimos.Add(31) : lNumerosPrimos.Add(37)
        lNumerosPrimos.Add(41)

        Opcion(8) = False

        If txtPrimos.Text = 0 Then
            Opcion(8) = True
            Exit Sub
        End If

        For i = 0 To NumerosGenerados.Length - 1
            If lNumerosPrimos.Contains(NumerosGenerados(i)) Then
                iCantPrimos += 1
                If iCantPrimos = txtPrimos.Text Then
                    Opcion(8) = True
                    Exit Sub
                End If
            End If
        Next
    End Sub

    Function EsNumeroPar(ByVal Numero As Byte) As Boolean
        EsNumeroPar = False
        If (Numero Mod 2) = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub OrdenacionPorSeleccion(ByVal Vector() As String)
        Dim minimo, temp As Integer

        For i = 0 To Vector.Length - 2
            minimo = i
            For j = i + 1 To Vector.Length - 1
                If CInt(Vector(minimo)) > CInt(Vector(j)) Then
                    minimo = j
                End If
            Next j
            temp = Vector(i)
            Vector(i) = Vector(minimo)
            Vector(minimo) = temp
        Next i

        For i = 0 To Vector.Length - 1
            If Len(Vector(i)) < 2 Then Vector(i) = "0" & Vector(i)
        Next
    End Sub

    Sub NumerosExcluidos()
        Dim lstLista As New List(Of Byte)

        If txtExcluir1.Text <> "" Then lstLista.Add(txtExcluir1.Text)
        If txtExcluir2.Text <> "" Then lstLista.Add(txtExcluir2.Text)
        If txtExcluir3.Text <> "" Then lstLista.Add(txtExcluir3.Text)

        Opcion(9) = True

        For i = 0 To lstLista.Count - 1
            lstLista(i) = IIf(Len(lstLista(i)) = 1, "0" & lstLista(i), lstLista(i))

            For j = 0 To NumerosGenerados.Length - 1
                If NumerosGenerados(j).Contains(lstLista(i)) Then
                    Opcion(9) = False
                    Exit Sub
                End If
            Next j
        Next i
    End Sub

    Function BuscarUltimaJugada() As String
        Dim ComandoADO As SqlCommand = New SqlCommand("spObtenerUltimoSorteo", CN)
        Dim myReader As SqlDataReader
        Dim sSorteo As String

        ComandoADO.CommandType = CommandType.StoredProcedure

        Dim paramResultado As SqlParameter = New SqlParameter("@Resultado", SqlDbType.VarChar, 36)
        paramResultado.Direction = ParameterDirection.Output
        ComandoADO.Parameters.Add(paramResultado)

        myReader = ComandoADO.ExecuteReader()

        sSorteo = paramResultado.Value
        myReader.Close()
        Return sSorteo
    End Function

    Private Sub txtCantPares_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantPares.KeyPress
        If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 54) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 127 And Asc(e.KeyChar) <> 32 Then e.Handled = True
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub txtTerminacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTerminacion.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 127 And Asc(e.KeyChar) <> 32 Then e.Handled = True
    End Sub

    Private Sub txtCantUnDigito_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantUnDigito.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 127 And Asc(e.KeyChar) <> 32 Then e.Handled = True
    End Sub

    Function UltimaFechaIngresada() As Date
        Dim da As SqlDataAdapter
        Dim dtTablas As DataTable
        Dim dtSP As DataTable
        Dim Consulta As String
        Dim UltimaFecha As Date

        dtTablas = New DataTable
        dtSP = New DataTable

        Consulta = "SELECT (CONVERT(VARCHAR(10), max(Fecha), 103)) from Sorteos"
        da = New SqlDataAdapter(Consulta, CN)
        da.Fill(dtTablas)

        For Each drFechas As DataRow In dtTablas.Rows
            UltimaFecha = drFechas(0)
        Next

        Return UltimaFecha
    End Function

    Function UltimaFechaSorteada() As Date 'Calcula la última fecha de un sorteo oficial, aunque no esté en la base
        Dim UltimaFecha As Date
        Dim FechaDeHoy As Date

        '1 - Considerar si la fecha actual es miércoles o domingo después de las 21 hs
        '2 - Si no es miércoles o domingo entonces buscar si la fecha anterior más cercana a la actual fue un miércoles o domingo

        FechaDeHoy = Format(Now, "dd/MM/yy")
        Select Case Weekday(Now)    'Now = #3/22/2017 6:16:16 PM#
            Case 1
                If TimeOfDay > #10:00:00 PM# Then
                    UltimaFecha = FechaDeHoy 'Domingo
                Else
                    UltimaFecha = FechaDeHoy.AddDays(-4)
                End If
            Case 4
                If TimeOfDay > #10:00:00 PM# Then
                    UltimaFecha = FechaDeHoy
                Else
                    UltimaFecha = FechaDeHoy.AddDays(-3)
                End If
            Case 2, 5
                UltimaFecha = FechaDeHoy.AddDays(-1)
            Case 3, 6
                UltimaFecha = FechaDeHoy.AddDays(-2)
            Case 7
                UltimaFecha = FechaDeHoy.AddDays(-3)
        End Select

        Return UltimaFecha
    End Function

    Private Sub gbSorteoAnterior_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles gbSorteoAnterior.MouseEnter, txtNumSorteoAnterior.MouseEnter, rbSorteoAnteriorAutom.MouseEnter, rbSorteoAnteriorManual.MouseEnter
        panel1.Text = "Selecciona un número entre los 18 salidos en el sorteo anterior."
        panel1.Icon = Nothing
    End Sub

    Private Sub gbSorteoAnterior_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles gbSorteoAnterior.MouseLeave, txtNumSorteoAnterior.MouseLeave, rbSorteoAnteriorAutom.MouseLeave, rbSorteoAnteriorManual.MouseLeave, lstSorteos.MouseLeave
        panel1.Text = ""
        panel1.Icon = Nothing
    End Sub

    Private Sub gbSumatoriaSorteo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles gbSumatoriaSorteo.MouseEnter
        panel1.Text = "Para indicar los límites inferior y superior que tendrá la sumatoria de todos los números incluídos en el sorteo."
        panel1.Icon = Nothing
    End Sub

    Private Sub gbSumatoriaSorteo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles gbSumatoriaSorteo.MouseLeave
        panel1.Text = ""
        panel1.Icon = Nothing
    End Sub

    Private Sub rbSorteoAnteriorManual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSorteoAnteriorManual.CheckedChanged
        txtNumSorteoAnterior.ReadOnly = False
        txtNumSorteoAnterior.Focus()
    End Sub

    Private Sub rbSorteoAnteriorAutom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSorteoAnteriorAutom.CheckedChanged
        txtNumSorteoAnterior.Text = ""
        txtNumSorteoAnterior.ReadOnly = True
    End Sub

    Private Sub txtCol11_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 127 And Asc(e.KeyChar) <> 32 Then e.Handled = True
    End Sub

    Private Sub txtNumSorteoAnterior_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumSorteoAnterior.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 127 And Asc(e.KeyChar) <> 32 Then e.Handled = True
    End Sub

    Private Sub txtSorteoGenerado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

#Region "Efectos especiales"

#Region " Variables a nivel de modulo "
    Private Tiempo As New Timer()
    Private VelocidadEfecto As Integer

    'Cuenta las veces que se debe ejecutar el evento Tick para cada efecto
    Private Contador As Integer
    'Contiene una copia de la imagen usada
    Private bmCopia As Bitmap
    'Creamos un objeto Graphics para dibujar en Copia
    Private Gr As Graphics
    'Creamos un TextureBrush con la textura de la imágen del PictureBox
    Private Brocha As TextureBrush
    'Contienen el Ancho y Alto de la Imágen respectivamente
    Private AnchoImagen, AltoImagen As Single
#End Region

#Region " Variables especificas de Efectos "
    'Cantidad en que se aumentan las transformaciones de ejes.
    Private xAumentaPos, yAumentaPos As Single

    'Determina si es la primera vez que se ejecuta un efecto
    Private EsPrimera As Boolean
    'Aumento progresivo de los dibujos
    Private Aumento As Single
#End Region

    Sub CrearLabels()
        Dim intLeft As Integer = 25
        Dim Exists As Boolean

        oLabel = New Label(5) {}

        For j As Integer = 0 To oLabel.Length - 1
            oLabel(j) = New Label
            oLabel(j).Location = New Point(intLeft, 290)
            oLabel(j).Anchor = AnchorStyles.None

            Exists = System.IO.File.Exists(Application.StartupPath & "\Iconos\EsferaGreen.ico")
            If Not Exists Then Application.ExitThread()
            oLabel(j).Image = New Bitmap(Application.StartupPath & "\Iconos\EsferaGreen.ico")
            oLabel(j).Visible = False
            oLabel(j).Size = New Size(34, 36)
            oLabel(j).Font = New Font(FontFamily.GenericSansSerif, 13.0F, FontStyle.Regular)
            oLabel(j).TextAlign = ContentAlignment.MiddleCenter
            Me.Controls.Add(oLabel(j))
            intLeft += 35
        Next
    End Sub

    'Inicia las variables de nivel de modulo y establece algunas propiedades de la interface
    Sub IniciarEfectos()
        Dim exists As Boolean = System.IO.File.Exists(Application.StartupPath & "\Iconos\EsferaGreen.ico")
        If Not exists Then Application.ExitThread()
        oLabel(iNumPicActual).Image = New Bitmap(Application.StartupPath & "\Iconos\EsferaGreen.ico")

        'Hay imagenes que tienen un formato de pixel que no permite crear un objeto Graphics para dibujar sobre ellas, por eso creamos una copia de pic.Image,del mismo tamaño y con un formato de pixel que no de problemas
        bmCopia = New Bitmap(oLabel(iNumPicActual).Image.Width, oLabel(iNumPicActual).Image.Height, PixelFormat.Format32bppArgb)

        'Establecemos las variables de nivel de modulo
        AnchoImagen = bmCopia.Width
        AltoImagen = bmCopia.Height
        'Controlador del evento Tick del objeto Timer
        AddHandler Tiempo.Tick, AddressOf TiempoEfectos
        Tiempo.Interval = 120
    End Sub

    'Controlador del evento Tick del control Timer
    Sub TiempoEfectos(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'Ejecutamos cada 100 milesimas de segundo, el efecto selecionado
            Empujar()
        Catch ex As System.Exception
        End Try
    End Sub

    'Genera los efectos de Empuje
    Private Sub Empujar()
        'Si es la primera vez que se llega aquí, establecemos las transformaciónes iniciales según la variante de efecto de Empuje

        If EsPrimera Then
            Gr.TranslateTransform(-AnchoImagen, 0)
            xAumentaPos = AnchoImagen / VelocidadEfecto : yAumentaPos = 0
        End If
        EsPrimera = False

        'Limpiamos el contenido de bmCopia
        Gr.Clear(oLabel(iNumPicActual).BackColor)

        'Dibujamos la imagen con las transformaciónes de ejes.
        Dim RecEmpuja As New RectangleF(0, 0, AnchoImagen, AltoImagen)
        Gr.FillRectangle(Brocha, RecEmpuja)
        Gr.TranslateTransform(xAumentaPos, yAumentaPos)
        oLabel(iNumPicActual).Refresh()
        'Contamos las veces que se ejecutó este evento
        Contador += 1
        'Cuando el evento se halla ejecutado VelocidadEfecto + 1 veces terminamos el efecto
        If Contador = VelocidadEfecto + 1 Then
            DescargaObjetos()
            oLabel(iNumPicActual).Text = NumerosGenerados(iNumPicActual)
            iNumPicActual += 1
            IniciarEfectos()
            EstableceObjetos()
        End If
    End Sub

    'Descarga Gr y Brocha, activa controles y detiene el Timer
    Private Sub DescargaObjetos()
        Gr.Dispose()
        Brocha.Dispose()
        Tiempo.Stop()
        Tiempo = New Timer  '<-- agregué para que el timer no altere la velocidad luego de terminado cada sorteo
    End Sub

    'Inicia objetos, variables y controles
    Sub EstableceObjetos()
        'Iniciamos el objeto Graphics
        Gr = Graphics.FromImage(bmCopia)
        'Iniciamos el objeto TextureBrush
        Brocha = New TextureBrush(oLabel(iNumPicActual).Image)
        'Asignamos bmCopia a el PictureBox
        oLabel(iNumPicActual).Image = bmCopia
        'Limpiamos el contenido de bmCopia
        Gr.Clear(oLabel(iNumPicActual).BackColor)

        'Elección de Velocidades
        VelocidadEfecto = 5

        'Reiniciamos variables
        Contador = 0
        Aumento = 0
        xAumentaPos = 0
        yAumentaPos = 0
        EsPrimera = True

        oLabel(iNumPicActual).Visible = True
        Tiempo.Start()
    End Sub
#End Region

    Private Sub chkSeleccionarTodas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSeleccionarTodas.Click
        For i = 0 To chklstOpciones.Items.Count - 1
            chklstOpciones.SetItemChecked(i, True)
        Next
    End Sub

    Private Sub txtPrimos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrimos.KeyPress
        If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 50) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 127 And Asc(e.KeyChar) <> 32 Then e.Handled = True
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarToolStripMenuItem.Click
        Dim sCopiado As String

        Clipboard.Clear()

        For i = 0 To lstSorteos.Items.Count - 1
            If lstSorteos.GetSelected(i) = True Then
                Clipboard.SetText(lstSorteos.Items(i))
                sCopiado = sCopiado & vbCrLf & Clipboard.GetText
            End If
        Next

        Clipboard.Clear()
        Clipboard.SetText(sCopiado)
        lstSorteos.Focus()
    End Sub

    Private Sub lstSorteos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstSorteos.MouseEnter
        panel1.Text = "CTRL + C para copiar contenido."
    End Sub

    Private Sub btnBuscarFrec_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        panel1.Text = "Ir a: Estadísticas - Nros. más frecuentes por col."
    End Sub

    Private Sub dtpFechaDesde_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFechaDesde.TextChanged, dtpFechaHasta.TextChanged
        Dim Fecha1, Fecha2 As Date

        Fecha1 = dtpFechaDesde.Text : Fecha2 = dtpFechaHasta.Text
        If Fecha1 > Fecha2 Then
            MessageBox.Show("La fecha inicial no debe ser posterior a la fecha final.", "Fechas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Call NumerosMasFrecuentes()
    End Sub

    Private Sub gbMasFrecuentes_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles gbMasFrecuentes.MouseEnter, lblCol1.MouseEnter, lblCol2.MouseEnter, lblCol3.MouseEnter, lblCol4.MouseEnter, lblCol5.MouseEnter, lblCol6.MouseEnter, lblIntervalo.MouseEnter, dtpFechaDesde.MouseEnter, dtpFechaHasta.MouseEnter, btnBuscar.MouseEnter
        panel1.Text = "Permite buscar los nros. más sorteados en el perídodo seleccionado e indicar que el sorteo generado contenga un nro. en particular."
    End Sub

    Private Sub gbMasFrecuentes_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles gbMasFrecuentes.MouseLeave
        panel1.Text = ""
    End Sub

    Private Sub chkUnParConsecutivos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkUnParConsecutivos.MouseEnter
        panel1.Text = "Ejemplo: sólo el 2 es consecutivo del 1."
    End Sub

    Private Sub chkUnParConsecutivos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkUnParConsecutivos.MouseLeave
        panel1.Text = ""
    End Sub

    Private Sub gbDiferenciaMinMax_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles gbDiferenciaMinMax.MouseEnter
        panel1.Text = "Es, en orden ascendente, el nro. que sucede a otro, no necesariamente consecutivo."
    End Sub

    Private Sub gbDiferenciaMinMax_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles gbDiferenciaMinMax.MouseLeave
        panel1.Text = ""
    End Sub

    Private Sub txtNumFrecuente_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        panel1.Text = "Se incluirá este número en el sorteo."
    End Sub

    Private Sub txtNumFrecuente_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        panel1.Text = ""
    End Sub

    Private Sub txtExcluir1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtExcluir1.KeyPress, txtExcluir2.KeyPress, txtExcluir3.KeyPress, txtIncluir1.KeyPress, txtIncluir2.KeyPress, txtIncluir3.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And (e.KeyChar <> Chr(8) And e.KeyChar <> Chr(13)) Then
            e.Handled = True
        End If
    End Sub
End Class
