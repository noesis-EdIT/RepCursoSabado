Imports System.Data.SqlClient

Public Class frmBuscarJugada
    Dim CantNumerosABuscar As Integer
    Dim iNum1 As Integer, iNum2 As Integer, iNum3 As Integer, iNum4 As Integer, iNum5 As Integer, iNum6 As Byte
    Dim sContenido, sFechaInicial, sFechaFinal As String
    Dim iNumJugada1, iNumJugada2 As UShort
    Dim bBusquedaPorContenido, bBusquedaPorNumJugada As Boolean
    Dim UsrControlVisible As Boolean
    Dim FocoEnText1, FocoEnText2 As Boolean
    Dim ListaDeBusqueda As New List(Of String)

    Function NumerosRepetidos() As Boolean
        'Verifica que la jugada que se ingresó no contenga un mismo número más de una vez
        Dim Vector(2)
        Vector(0) = iNum1 : Vector(1) = iNum2 : Vector(2) = iNum3
        'Es requisito anterior haber ingresado 3 números como mínimo, por el resto hay que averiguar si fueron ingresados:
        If Vector.Length > 3 Then ReDim Preserve Vector(UBound(Vector) + 1) : Vector(3) = iNum4
        If Vector.Length > 4 Then ReDim Preserve Vector(UBound(Vector) + 1) : Vector(4) = iNum5
        If Vector.Length > 5 Then ReDim Preserve Vector(UBound(Vector) + 1) : Vector(5) = iNum6

        For i = 0 To Vector.GetUpperBound(0)
            For j = i + 1 To Vector.GetUpperBound(0) - 1
                If Vector(i) = Vector(j) Then
                    Return (True)
                    Exit Function
                End If
            Next
        Next
    End Function

    Function ConvertirFechaAFormatoSql(ByVal sFecha As String) As String
        Dim sFechaSql As String
        Dim sMes As String, sAño As String, sDia As String

        sFechaSql = sFecha.Remove(2, 1)
        sFechaSql = sFechaSql.Remove(4, 1)
        sAño = sFechaSql.Substring(4)
        sMes = sFechaSql.Substring(2, 2)
        sDia = sFechaSql.Substring(0, 2)
        sFechaSql = sAño & sMes & sDia

        Return sFechaSql
    End Function

    Function BuscarFechaInicial() As String
        Dim ComandoADO As SqlCommand
        Dim myReader As SqlDataReader
        Dim paramResultado As SqlParameter
        Dim dFecha1 As Date
        Dim bln As Boolean

        ComandoADO = New SqlCommand("spObtenerPrimeraFecha", CN)
        ComandoADO.CommandType = CommandType.StoredProcedure

        paramResultado = New SqlParameter("@Resultado", SqlDbType.DateTime, 8)     '#11/3/2003#
        paramResultado.Direction = ParameterDirection.Output
        ComandoADO.Parameters.Add(paramResultado)

        myReader = ComandoADO.ExecuteReader()
        If IsDBNull(paramResultado.Value) Then Exit Function

        bln = DateTime.TryParse(paramResultado.Value, dFecha1)
        myReader.Close()
        Return dFecha1
    End Function

    Function BuscarUltimaFecha() As Date
        Dim ComandoADO As SqlCommand
        Dim myReader As SqlDataReader
        Dim paramResultado As SqlParameter
        Dim dFecha1 As Date
        Dim bln As Boolean

        ComandoADO = New SqlCommand("spObtenerUltimaFecha", CN)
        ComandoADO.CommandType = CommandType.StoredProcedure

        paramResultado = New SqlParameter("@Resultado", SqlDbType.DateTime, 8)     '#11/3/2003#
        paramResultado.Direction = ParameterDirection.Output
        ComandoADO.Parameters.Add(paramResultado)

        myReader = ComandoADO.ExecuteReader()
        If IsDBNull(paramResultado.Value) Then Exit Function

        bln = DateTime.TryParse(paramResultado.Value, dFecha1)
        myReader.Close()
        Return dFecha1
    End Function

    Public Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If bBusquedaPorContenido Then
            Call BuscarPorContenido()
        ElseIf bBusquedaPorNumJugada Then
            Call BuscarPorNumeroJugada()
        End If
        'Conviene ListView mejor para mostrar datos y DataGridView para mostrar y modificar datos
    End Sub

    Sub BuscarPorContenido()
        Dim dFecha1, dFecha2, dFechaInicialSql, dFechaFinalSql As Date

        sFechaInicial = dtpDesde.Text : sFechaFinal = dtpHasta.Text
        sContenido = ""

        dFecha1 = dtpDesde.Text : dFecha2 = dtpHasta.Text
        If dFecha1 > dFecha2 Then
            erpBuscarJugada.SetError(dtpHasta, "La fecha inicial no puede ser posterior a la fecha final")
            Exit Sub
        End If

        'Para que se completen los números de derecha a izquierda sin dejar espacios:
        If (iNum2 <> 99 And iNum1 = 99) Or (iNum3 <> 99 And (iNum1 = 99 Or iNum2 = 99)) Or (iNum4 <> 99 And (iNum1 = 99 Or iNum2 = 99 Or iNum3 = 99)) Or (iNum4 <> 99 And (iNum1 = 99 Or iNum2 = 99 Or iNum3 = 99)) Or (iNum5 <> 99 And (iNum1 = 99 Or iNum2 = 99 Or iNum3 = 99 Or iNum4 = 99)) Or (iNum6 <> 99 And (iNum1 = 99 Or iNum2 = 99 Or iNum3 = 99 Or iNum4 = 99 Or iNum5 = 99)) Then
            MessageBox.Show("Los números integrantes del sorteo a buscar" & vbCrLf & "no deben contener espacios en blanco.", "Espacio en blanco", MessageBoxButtons.OK)
            mtbBuscar.Focus()
            Exit Sub
        End If

        dFechaInicialSql = sFechaInicial : dFechaFinalSql = sFechaFinal

        'Verifico que la fecha final sea posterior a la inicial:
        If dFecha2 < dFecha1 Then
            pnlBuscarContenido.Text = "La fecha inicial no puede ser posterior a la final"
            MessageBox.Show("La fecha inicial no puede ser posterior a la final.", "Fecha", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'Verifico que las fechas estén dentro del rango de sorteos:
        If dFechaInicialSql < #1/1/1993# OrElse dFechaFinalSql < #1/1/1993# Then
            pnlBuscarContenido.Text = "Fecha fuera de rango"
            MessageBox.Show("Fecha fuera de rango", "Fecha equivocada", MessageBoxButtons.OK, MessageBoxIcon.Error)

            If dFechaInicialSql < #1/1/1993# Then
                dtpDesde.Focus()
                Exit Sub
            End If

            If dFechaFinalSql < #1/1/1993# Then
                dtpDesde.Focus()
                Exit Sub
            End If
        End If

        'Agrego ceros a la secuencia cuando corresponda, para que cada número tenga siempre dos dígitos
        For i = 0 To ListaDeBusqueda.Count - 1
            sContenido = sContenido & ListaDeBusqueda(i)
        Next

        If CantNumerosABuscar = 0 Then sContenido = ""
        Cursor = Cursors.WaitCursor
        Call Buscar(0, sContenido, dFecha1, dFecha2)
        ColoresFilaListView(Me, lvBuscarJugada)
        TipoLetraListView(lvBuscarJugada)
        Cursor = Cursors.Arrow
    End Sub

    Sub BuscarPorNumeroJugada()
        Dim rdReader As SqlDataReader
        Dim Consulta, SorteoTConEspacio, SorteoDConEspacio, SorteoSConEspacio As String
        Dim CantFilas As Integer

        iNumJugada1 = IIf(txtNumSorteo.Text = "", 0, txtNumSorteo.Text)
        iNumJugada2 = IIf(txtNumSorteo2.Text = "", 0, txtNumSorteo2.Text)

        If iNumJugada1 = 0 And iNumJugada2 <> 0 Then
            MessageBox.Show("Falta el nº de jugada inicial.", "Números", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf iNumJugada2 = 0 Then
            Consulta = "SELECT NumSorteo, CONVERT(VARCHAR(10), Fecha, 103), SorteoTra, SorteoDes, SorteoSal FROM sorteos WHERE NumSorteo = " & iNumJugada1 & " ORDER BY Fecha"
        ElseIf iNumJugada1 > iNumJugada2 Then
            MessageBox.Show("El nº de jugada inicial no debe" & vbCrLf & "ser mayor que el nº final.", "Números", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNumSorteo.Focus()
            Exit Sub
        Else
            Consulta = "SELECT NumSorteo, CONVERT(VARCHAR(10), Fecha, 103), SorteoTra, SorteoDes, SorteoSal FROM sorteos WHERE (NumSorteo between " & iNumJugada1 & " and " & iNumJugada2 & ")" & " ORDER BY Fecha"
        End If

        lvBuscarJugada.Items.Clear()
        rdReader = objConexion.EjecutarConsultaDR(Consulta)
        Cursor = Cursors.WaitCursor

        If rdReader.HasRows Then
            Do While rdReader.Read
                SorteoTConEspacio = AgregarEspacios(System.Convert.ToString(rdReader.GetSqlValue(2)))
                SorteoDConEspacio = AgregarEspacios(System.Convert.ToString(rdReader.GetSqlValue(3)))
                SorteoSConEspacio = AgregarEspacios(System.Convert.ToString(rdReader.GetSqlValue(4)))
                With lvBuscarJugada.Items.Add(System.Convert.ToString(rdReader.GetSqlValue(0)))
                    .SubItems.Add(System.Convert.ToString(rdReader.GetSqlValue(1)))
                    .SubItems.Add(SorteoTConEspacio)
                    .SubItems.Add(SorteoDConEspacio)
                    .SubItems.Add(SorteoSConEspacio)
                End With
                txtFecha.Text = System.Convert.ToString(rdReader.GetSqlValue(1))
                CantFilas += 1
            Loop
        End If

        pnlBuscarContenido.Text = CantFilas & " filas."

        ColoresFilaListView(Me, lvBuscarJugada)
        TipoLetraListView(lvBuscarJugada)
        Cursor = Cursors.Arrow
    End Sub

    Sub Buscar(ByVal iNumeroSorteo As UShort, ByVal sContenido As String, ByVal dFechaInicialSql As Date, ByVal dFechaFinalSql As Date)
        Dim rdReader As SqlDataReader
        Dim SorteoTConEspacio, SorteoDConEspacio, SorteoSConEspacio As String
        Dim CantFilas As Integer

        lvBuscarJugada.Items.Clear()
        rdReader = objConexion.BuscarJugada(iNumeroSorteo, sContenido, dFechaInicialSql, dFechaFinalSql)

        If rdReader.HasRows Then
            Do While rdReader.Read
                SorteoTConEspacio = AgregarEspacios(System.Convert.ToString(rdReader.GetSqlValue(2)))
                SorteoDConEspacio = AgregarEspacios(System.Convert.ToString(rdReader.GetSqlValue(3)))
                SorteoSConEspacio = AgregarEspacios(System.Convert.ToString(rdReader.GetSqlValue(4)))
                With lvBuscarJugada.Items.Add(System.Convert.ToString(rdReader.GetSqlValue(0)))
                    .SubItems.Add(System.Convert.ToString(rdReader.GetSqlValue(1)))
                    .SubItems.Add(SorteoTConEspacio)
                    .SubItems.Add(SorteoDConEspacio)
                    .SubItems.Add(SorteoSConEspacio)
                End With
                txtFecha.Text = System.Convert.ToString(rdReader.GetSqlValue(1))
                CantFilas += 1
            Loop
        End If

        pnlBuscarContenido.Text = CantFilas & " filas."
    End Sub

    Function CantidadDeNumerosABuscar() As Byte
        Dim Cant As Byte
        Dim Vector(6) As Byte

        Vector(0) = iNum1 : Vector(1) = iNum2 : Vector(2) = iNum3 : Vector(3) = iNum4 : Vector(4) = iNum5 : Vector(5) = iNum6

        For i = 0 To 5
            If Vector(i) <> 99 Then Cant += 1
        Next

        Return Cant
    End Function

    Private Sub mtbBuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mtbBuscar.Click
        mtbBuscar.SelectionStart = 0    '--> enviar cursor a la primera posición del control
    End Sub

    Private Sub mtbBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mtbBuscar.KeyPress
        If Asc(e.KeyChar) = 13 Then btnBuscar_Click(sender, e)

        If ((Asc(e.KeyChar) < 48) Or (Asc(e.KeyChar) > 57)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub mtbBuscar_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mtbBuscar.KeyUp   '--> elimina el número ingresado si es mayor a 41
        Dim strValor As String

        If mtbBuscar.SelectionStart = 1 Then
            If IsNumeric(Mid(mtbBuscar.Text, 1, 2)) Then
                If CInt(Mid(mtbBuscar.Text, 1, 2)) > 41 Then
                    strValor = mtbBuscar.Text
                    strValor = strValor.Replace(Mid(mtbBuscar.Text, 1, 2), "  ")
                    mtbBuscar.Text = strValor
                    mtbBuscar.Focus()
                    mtbBuscar.SelectionStart = 0
                End If
            End If
        ElseIf mtbBuscar.SelectionStart > 1 Then
            If IsNumeric(Mid(mtbBuscar.Text, mtbBuscar.SelectionStart - 1, 2)) Then
                If CInt(Mid(mtbBuscar.Text, mtbBuscar.SelectionStart - 1, 2)) > 41 Then
                    strValor = mtbBuscar.Text
                    strValor = strValor.Replace(Mid(mtbBuscar.Text, mtbBuscar.SelectionStart - 1, 2), "  ")
                    mtbBuscar.Text = strValor
                    mtbBuscar.Focus()
                    mtbBuscar.SelectionStart = 0
                End If
            End If
        End If
    End Sub

    Private Sub mtbBuscar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mtbBuscar.LostFocus
        If mtbBuscar.Text.Substring(0, 2) <> "  " Then
            iNum1 = mtbBuscar.Text.Substring(0, 2)
        Else
            iNum1 = 99
        End If

        If mtbBuscar.Text.Substring(3, 2) <> "  " Then
            iNum2 = mtbBuscar.Text.Substring(3, 2)
        Else
            iNum2 = 99
        End If

        If mtbBuscar.Text.Substring(6, 2) <> "  " Then
            iNum3 = mtbBuscar.Text.Substring(6, 2)
        Else
            iNum3 = 99
        End If

        If mtbBuscar.Text.Substring(9, 2) <> "  " Then
            iNum4 = mtbBuscar.Text.Substring(9, 2)
        Else
            iNum4 = 99
        End If

        If mtbBuscar.Text.Substring(12, 2) <> "  " Then
            iNum5 = mtbBuscar.Text.Substring(12, 2)
        Else
            iNum5 = 99
        End If

        If Len(mtbBuscar.Text) = 15 Then   '--> este if porque mtbBuscar.Text no toma los dos últimos símbolos '__' cuando estas posiciones no tienen dígitos
            iNum6 = 99
        ElseIf Len(mtbBuscar.Text) = 16 Then
            MessageBox.Show("Cada número debe tener dos dígitos y ser menor que 42." & vbCr & "Completar con el dígito cero cuando el nro. sea menor que 10.", "Sorteo a buscar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            iNum6 = mtbBuscar.Text.Substring(15, 2)
        End If

        CantNumerosABuscar = CantidadDeNumerosABuscar()

        If (CantNumerosABuscar < 3) And (CantNumerosABuscar <> 0) Then
            MessageBox.Show("Ingresar al menos 3 números del sorteo a buscar.", "Sorteo a buscar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mtbBuscar.Text = ""
            Exit Sub
        End If

        If (CantNumerosABuscar <> 0) And NumerosRepetidos() Then
            MessageBox.Show("Hay números repetidos en la secuencia a buscar.", "Corregir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If CantNumerosABuscar <> 0 Then Call OrdenarNumeros()
    End Sub

    Sub OrdenarNumeros()
        Dim iCant As Byte
        Dim Vector() As Byte
        Dim i, j, index As Integer

        If iNum1 <> 99 Then iCant += 1
        If iNum2 <> 99 Then iCant += 1
        If iNum3 <> 99 Then iCant += 1
        If iNum4 <> 99 Then iCant += 1
        If iNum5 <> 99 Then iCant += 1
        If iNum6 <> 99 Then iCant += 1
        ReDim Vector(iCant - 1)

        Vector(0) = iNum1
        Vector(1) = iNum2
        Vector(2) = iNum3 '<-- el usuario debe ingresar como mínimo dos números del sorteo a buscar
        If Vector.Length >= 4 Then Vector(3) = iNum4
        If Vector.Length >= 5 Then Vector(4) = iNum5
        If Vector.Length >= 6 Then Vector(5) = iNum6

        For i = 0 To Vector.Length - 1
            index = Vector(i)
            j = i - 1
            Do While (j >= 0)
                If index > Vector(j) Then
                    Exit Do
                Else
                    Vector(j + 1) = Vector(j)
                    j = j - 1
                End If
            Loop
            Vector(j + 1) = index
        Next i

        j = 0
        While j <= Vector.Length - 1
            If Len(Vector(j) < 2) Then
                ListaDeBusqueda.Add("0" & Vector(j))
            Else
                ListaDeBusqueda.Add(Vector(j))
            End If
            j += 1
        End While
    End Sub

    Private Sub frmBuscarJugada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bBusquedaPorNumJugada = False : bBusquedaPorContenido = True

        lvBuscarJugada.View = View.Details
        lvBuscarJugada.LabelEdit = True
        lvBuscarJugada.AllowColumnReorder = True
        lvBuscarJugada.GridLines = True

        lvBuscarJugada.Columns.Add("Nro.", 59, HorizontalAlignment.Center)
        lvBuscarJugada.Columns.Add("Fecha", 70, HorizontalAlignment.Center)
        lvBuscarJugada.Columns.Add("      Sorteo 1", 104, HorizontalAlignment.Left)
        lvBuscarJugada.Columns.Add("      Sorteo 2", 104, HorizontalAlignment.Left)
        lvBuscarJugada.Columns.Add("      Sorteo 3", 104, HorizontalAlignment.Left)

        lvBuscarJugada.Width = lvBuscarJugada.Columns(0).Width + lvBuscarJugada.Columns(1).Width + lvBuscarJugada.Columns(2).Width + lvBuscarJugada.Columns(3).Width + lvBuscarJugada.Columns(4).Width + 21
        lvBuscarJugada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0, FontStyle.Bold)

        dtpDesde.Value = New DateTime(Year(Now), 1, 1) : dtpHasta.Value = Date.Now

        dt.Columns.Add("NumSorteo")
        dt.Columns.Add("Fecha")
        dt.Columns.Add("Sorteo1")
        dt.Columns.Add("Sorteo2")
        dt.Columns.Add("Sorteo3")

        'Estas tres líneas para evitar que parpadee todo el listView al modificar:
        Dim propiedadListView As System.Reflection.PropertyInfo
        propiedadListView = GetType(ListView).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance)
        propiedadListView.SetValue(lvBuscarJugada, True, Nothing)
        Me.BringToFront()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub rbPrimerSorteo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbPrimerSorteo.Click
        sFechaInicial = BuscarFechaInicial()
        dtpDesde.Text = sFechaInicial
        mtbBuscar.Focus()
    End Sub

    Private Sub rbUltimoSorteo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbUltimoSorteo.Click
        Dim dFecha1, dFecha2 As Date

        dFecha1 = BuscarUltimaFecha()
        dFecha2 = dtpHasta.Text
        dtpDesde.Text = dFecha1
        dtpHasta.Value = Date.Now

        mtbBuscar.Focus()
    End Sub

    Private Sub chkUltimoSorteo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkUltimoSorteo.Click
        Dim dFecha As Date
        Dim myReader As SqlDataReader

        myReader = objConexion.EjecutarConsultaDR("SELECT MAX(NumSorteo) FROM sorteos")
        If myReader.HasRows Then
            Do While myReader.Read
                txtNumSorteo.Text = myReader(0)
            Loop
            myReader.Close()
        End If

        dFecha = BuscarUltimaFecha()
        txtFecha.Text = dFecha
    End Sub

    Private Sub dtpDesde_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDesde.ValueChanged
        erpBuscarJugada.Dispose()
    End Sub

    Private Sub dtpHasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpHasta.ValueChanged
        erpBuscarJugada.Dispose()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim row As DataRow
        Dim Cadena As String
        Dim f As New frmModificar()
        Dim iFilaSeleccionada As Integer

        If lvBuscarJugada.SelectedIndices.Count < 1 Then Exit Sub
        dt.Clear()

        For Each i In lvBuscarJugada.SelectedIndices
            row = dt.NewRow
            Cadena = lvBuscarJugada.Items(i).SubItems(0).ToString
            row("NumSorteo") = Microsoft.VisualBasic.Mid(Cadena, Cadena.IndexOf("{") + 2, 4)
            If Microsoft.VisualBasic.Mid(Cadena, Cadena.IndexOf("{") + 2, 4).Last = "}" Then
                row("NumSorteo") = Replace(row("NumSorteo"), "}", "")
            End If

            Cadena = lvBuscarJugada.Items(i).SubItems(1).ToString
            row("Fecha") = Microsoft.VisualBasic.Mid(Cadena, Cadena.IndexOf("{") + 2, 10)   'ListViewSubItem: {06/01/2013}

            Cadena = lvBuscarJugada.Items(i).SubItems(2).ToString
            row("Sorteo1") = Microsoft.VisualBasic.Mid(Cadena, Cadena.IndexOf("{") + 2, 17)

            Cadena = lvBuscarJugada.Items(i).SubItems(3).ToString
            row("Sorteo2") = Microsoft.VisualBasic.Mid(Cadena, Cadena.IndexOf("{") + 2, 17)

            Cadena = lvBuscarJugada.Items(i).SubItems(4).ToString
            row("Sorteo3") = Microsoft.VisualBasic.Mid(Cadena, Cadena.IndexOf("{") + 2, 17)

            dt.Rows.Add(row)
        Next

        iFilaSeleccionada = lvBuscarJugada.SelectedIndices(0)

        f.ShowDialog(Me)
        f.Dispose()
        Call Buscar(iNumJugada1, "", #12:00:00 AM#, #12:00:00 AM#)

        ColoresFilaListView(Me, lvBuscarJugada)
        TipoLetraListView(lvBuscarJugada)

        'al regresar a este formulario (después de ir a Modificar), mostrar la misma fila que antes estaba visualizada:
        lvBuscarJugada.Items(iFilaSeleccionada).Selected = True
        lvBuscarJugada.Focus()
        lvBuscarJugada.EnsureVisible(iFilaSeleccionada)
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim Consulta, CadenaFila, NumSorteo As String
        Dim dFecha1, dFecha2 As Date
        Dim Rta As MsgBoxResult
        Dim CantFilasEliminadas As Integer

        If bBusquedaPorContenido Then
            dFecha1 = dtpDesde.Text : dFecha2 = dtpHasta.Text
        ElseIf bBusquedaPorNumJugada Then
            dFecha1 = txtFecha.Text : dFecha2 = txtFecha.Text
        End If

        Rta = MessageBox.Show("¿Confirma eliminación de registros?", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Rta = vbNo Then Exit Sub

        For Each Fila In lvBuscarJugada.SelectedIndices
            CadenaFila = lvBuscarJugada.Items(Fila).SubItems(0).ToString
            NumSorteo = Microsoft.VisualBasic.Mid(CadenaFila, CadenaFila.IndexOf("{") + 2, 4)
            NumSorteo = NumSorteo.Replace("}", "")
            Consulta = "DELETE from sorteos where NumSorteo = '" & NumSorteo & "'"
            objConexion.EjecutarConsulta(Consulta)
            CantFilasEliminadas += 1
        Next

        If bBusquedaPorContenido Then
            Call Buscar(0, "", dFecha1, dFecha2)
        ElseIf bBusquedaPorNumJugada Then
            Call Buscar(iNumJugada1, "", #12:00:00 AM#, #12:00:00 AM#)
        End If

        ColoresFilaListView(Me, lvBuscarJugada)
        TipoLetraListView(lvBuscarJugada)

        If CantFilasEliminadas = 1 Then
            pnlBuscarContenido.Text = CantFilasEliminadas & " fila eliminada"
        Else
            pnlBuscarContenido.Text = CantFilasEliminadas & " filas eliminadas"
        End If
    End Sub

    Private Sub lvBuscarJugada_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvBuscarJugada.Click
        btnModificar.Enabled = True : btnEliminar.Enabled = True
    End Sub

    Private Sub lvBuscarJugada_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvBuscarJugada.DoubleClick
        Call btnModificar_Click(sender, e)
    End Sub

    Private Sub lvBuscarJugada_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvBuscarJugada.KeyDown
        If e.KeyCode = Keys.Delete Then
            Call btnEliminar_Click(sender, e)
        End If
    End Sub

    Private Sub lvBuscarJugada_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvBuscarJugada.SelectedIndexChanged
        If lvBuscarJugada.SelectedItems.Count < 2 Then
            pnlBuscarContenido.Text = lvBuscarJugada.SelectedItems.Count & " fila seleccionada"
        Else
            pnlBuscarContenido.Text = lvBuscarJugada.SelectedItems.Count & " filas seleccionadas"
        End If
    End Sub

    Private Sub btnCambiarBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiarBusqueda.Click
        bBusquedaPorNumJugada = Not bBusquedaPorNumJugada
        bBusquedaPorContenido = Not bBusquedaPorContenido

        If bBusquedaPorNumJugada Then
            pnlBuscarNumJugada.Left = 17
            btnCambiarBusqueda.Text = "Cambiar a buscar por contenido"
            pnlBuscarNumJugada.Visible = False
            tmrDesplazarGb1 = New Timer
            tmrDesplazarGb1.Interval = 25
            tmrDesplazarGb1.Enabled = True
        ElseIf bBusquedaPorContenido Then
            pnlBuscarContenido.Left = 17
            btnCambiarBusqueda.Text = "Cambiar a buscar por nº de jugada"
            pnlBuscarContenido.Visible = False
            tmrDesplazarGb2 = New Timer
            tmrDesplazarGb2.Interval = 25
            tmrDesplazarGb2.Enabled = True
        End If
    End Sub

    Private Sub tmrDesplazarGb1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrDesplazarGb1.Tick
        pnlBuscarContenido.Left = pnlBuscarContenido.Left - 100
        If pnlBuscarContenido.Left <= -1000 Then
            pnlBuscarNumJugada.Visible = True
            tmrDesplazarGb1.Enabled = False
            txtNumSorteo.Focus()
        End If
    End Sub

    Private Sub tmrDesplazarGb2_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrDesplazarGb2.Tick
        pnlBuscarNumJugada.Left = pnlBuscarNumJugada.Left - 100
        If pnlBuscarNumJugada.Left <= -1000 Then
            pnlBuscarContenido.Visible = True
            tmrDesplazarGb2.Enabled = False
            mtbBuscar.Focus()
        End If
    End Sub

    Private Sub txtNumSorteo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumSorteo.KeyPress, txtNumSorteo2.KeyPress
        If ((Asc(e.KeyChar) < 48) Or (Asc(e.KeyChar) > 57)) And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then
            e.Handled = True
        End If
    End Sub

    Private Sub picTeclado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picTeclado.Click
        pnlTeclado.Visible = True
        UsrTecladoVirtual1.Focus()

        If UsrControlVisible = False Then
            UsrControlVisible = True
            pnlTeclado.Visible = True
        Else
            UsrControlVisible = False
            pnlTeclado.Visible = False
        End If
    End Sub

    Private Sub UsrTecladoVirtual1_PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs) Handles UsrTecladoVirtual1.PropertyChanged
        If UsrTecladoVirtual1.TeclaPulsada <> "Cerrar" Then
            If FocoEnText1 Then
                If Len(txtNumSorteo.Text) < txtNumSorteo.MaxLength Then
                    txtNumSorteo.Text = txtNumSorteo.Text & UsrTecladoVirtual1.TeclaPulsada
                End If
            ElseIf FocoEnText2 Then
                If Len(txtNumSorteo2.Text) < txtNumSorteo2.MaxLength Then
                    txtNumSorteo2.Text = txtNumSorteo2.Text & UsrTecladoVirtual1.TeclaPulsada
                End If
            End If
        Else
            pnlTeclado.Visible = False
            UsrControlVisible = False
        End If
    End Sub

    Private Sub txtNumSorteo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumSorteo.LostFocus
        FocoEnText1 = True : FocoEnText2 = False
    End Sub

    Private Sub txtNumSorteo2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumSorteo2.LostFocus
        FocoEnText1 = False : FocoEnText2 = True
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