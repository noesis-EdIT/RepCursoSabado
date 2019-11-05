Imports System.Data.SqlClient

Public Class frmBuscarJugada
    Dim CantNumerosABuscar, iNum1 As Integer, iNum2 As Integer, iNum3 As Integer, iNum4 As Integer, iNum5 As Integer, iNum6 As Integer
    Dim sFechaInicial As String
    Dim sFechaFinal As String
    Public sNum As String

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
        'FALTA considerar que cuando la consulta no traiga datos, no produzca error
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
        Dim dFecha1, dFecha2, dFechaInicialSql, dFechaFinalSql As Date

        sFechaInicial = dtpDesde.Text : sFechaFinal = dtpHasta.Text

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
            panel1.Text = "La fecha inicial no puede ser posterior a la final"
            MessageBox.Show("La fecha inicial no puede ser posterior a la final.", "Fecha", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'Verifico las fechas estén dentro del rango de sorteos:
        If dFechaInicialSql < #1/1/1993# OrElse dFechaFinalSql < #1/1/1993# Then
            panel1.Text = "Fecha fuera de rango"
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
        sNum = txtBusquedaOrdenada.Text : sNum = sNum.Replace("-", "")
        Dim a() As String
        a = Split(sNum, "  ")
        For i = 0 To UBound(a)
            If Len(a(i)) < 2 Then a(i) = "0" & a(i)
        Next
        sNum = ""
        For i = 0 To UBound(a)
            sNum = sNum & a(i)
        Next

        If CantNumerosABuscar = 0 Then sNum = ""
        Cursor = Cursors.WaitCursor
        Call Buscar(sNum, dFecha1, dFecha2)
        ColoresFilaListView(Me, lvBuscarJugada)
        TipoLetraListView(lvBuscarJugada)
        Cursor = Cursors.Arrow
        'Conviene ListView mejor para mostrar datos y DataGridView para mostrar y modificar datos
    End Sub

    Public Sub Buscar(ByVal sNum As String, ByVal dFechaInicialSql As Date, ByVal dFechaFinalSql As Date)
        Dim ComandoADO As SqlCommand
        Dim myReader As SqlDataReader
        Dim paramEntrada1, paramEntrada2, paramEntrada3 As SqlParameter
        Dim CantFilas As Integer
        Dim SorteoTConEspacio, SorteoDConEspacio, SorteoSConEspacio As String

        lvBuscarJugada.Items.Clear()
        ComandoADO = New SqlCommand("spBuscarSorteo", CN)
        ComandoADO.CommandType = CommandType.StoredProcedure

        paramEntrada1 = New SqlParameter("@Sorteo", SqlDbType.VarChar, 12)
        paramEntrada1.Direction = ParameterDirection.Input
        If sNum = "" Then
            paramEntrada1.Value = DBNull.Value
        Else
            paramEntrada1.Value = sNum
        End If
        ComandoADO.Parameters.Add(paramEntrada1)

        paramEntrada2 = New SqlParameter("@Fecha1", SqlDbType.DateTime, 8)
        paramEntrada2.Direction = ParameterDirection.Input
        paramEntrada2.Value = dFechaInicialSql
        ComandoADO.Parameters.Add(paramEntrada2)

        paramEntrada3 = New SqlParameter("@Fecha2", SqlDbType.DateTime, 8)
        paramEntrada3.Direction = ParameterDirection.Input
        paramEntrada3.Value = dFechaFinalSql
        ComandoADO.Parameters.Add(paramEntrada3)

        myReader = ComandoADO.ExecuteReader()

        If myReader.HasRows Then
            Do While myReader.Read
                SorteoTConEspacio = AgregarEspacios(System.Convert.ToString(myReader.GetSqlValue(2)))
                SorteoDConEspacio = AgregarEspacios(System.Convert.ToString(myReader.GetSqlValue(3)))
                SorteoSConEspacio = AgregarEspacios(System.Convert.ToString(myReader.GetSqlValue(4)))
                With lvBuscarJugada.Items.Add(System.Convert.ToString(myReader.GetSqlValue(0)))
                    .SubItems.Add(System.Convert.ToString(myReader.GetSqlValue(1)))
                    .SubItems.Add(SorteoTConEspacio)
                    .SubItems.Add(SorteoDConEspacio)
                    .SubItems.Add(SorteoSConEspacio)
                End With
                CantFilas += 1
            Loop
        End If
        myReader.Close()
        panel1.Text = CantFilas & " filas."
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
        If mtbBuscar.Text = "  -  -  -  -  -" Then txtBusquedaOrdenada.Text = ""

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
            txtBusquedaOrdenada.Text = ""
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

        'Ordenamiento por 'inserción'
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
        txtBusquedaOrdenada.Text = ""
        txtBusquedaOrdenada.Text = Vector(0)
        j += 1
        While j <= Vector.Length - 1
            txtBusquedaOrdenada.Text = txtBusquedaOrdenada.Text & " - " & Vector(j)
            j += 1
        End While
    End Sub

    Private Sub frmBuscarJugada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub rbUltimoSorteo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbUltimoSorteo.Click
        Dim dFecha1, dFecha2 As Date

        dFecha1 = BuscarUltimaFecha()
        dFecha2 = dtpHasta.Text
        dtpDesde.Text = dFecha1

        If dFecha1 > dFecha2 Then
            erpBuscarJugada.SetError(dtpHasta, "La fecha inicial no puede ser posterior a la fecha final")
        End If
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
        Call Buscar(sNum, sFechaInicial, sFechaFinal)
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
        Dim bln As Boolean
        Dim Rta As MsgBoxResult
        Dim CantFilasEliminadas As Integer

        bln = DateTime.TryParse(dtpDesde.Text, dFecha1)
        bln = DateTime.TryParse(dtpHasta.Text, dFecha2)

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

        Call Buscar("", dFecha1, dFecha2)
        ColoresFilaListView(Me, lvBuscarJugada)
        TipoLetraListView(lvBuscarJugada)

        If CantFilasEliminadas = 1 Then
            panel1.Text = CantFilasEliminadas & " fila eliminada"
        Else
            panel1.Text = CantFilasEliminadas & " filas eliminadas"
        End If
    End Sub

    'Private Sub Ejecutar(ByVal Consulta As String)
    '    Dim Filas As Integer
    '    Dim com As SqlCommand = New SqlCommand(Consulta, CN)
    '    com.Connection = CN
    '    com.CommandText = Consulta
    '    Filas = com.ExecuteNonQuery
    'End Sub

    Private Sub mtbFechaDesde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then SendKeys.Send("{tab}")
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
            panel1.Text = lvBuscarJugada.SelectedItems.Count & " fila seleccionada"
        Else
            panel1.Text = lvBuscarJugada.SelectedItems.Count & " filas seleccionadas"
        End If
    End Sub

    Private Sub rbUltimoSorteo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbUltimoSorteo.CheckedChanged

    End Sub
End Class