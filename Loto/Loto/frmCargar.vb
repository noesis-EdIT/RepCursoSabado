Imports System
Imports System.IO
Imports System.Collections
Imports System.Data.SqlClient
Imports System.Data.OleDb   'para trabajar con archivos excel
Imports Microsoft.Office.Interop

Public Class frmCargar
    Dim sCopiado As String = ""
    Dim CantLineas As Integer
    Dim Resultado() As String

    Private Sub frmImportarTxt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call EncabezadoDataGrid(dgvCarga)
        Call SetearCantidadCaracteresColumnas(dgvCarga)
        Call ColoresFilasDataGrid(Me, dgvCarga)
    End Sub

    Function ObtenerFecha(ByVal sCadena As String) As String
        Dim sFecha As String
        Dim iLongMes, iLongDia, iLongFecha As Byte

        If Microsoft.VisualBasic.Right(sCadena, 7) = "/" Then
            'en este caso el mes sólo tiene un dígito
            iLongMes = 1
        Else
            iLongMes = 2
        End If

        If iLongMes = 1 Then
            If IsNumeric(Microsoft.VisualBasic.Right(sCadena, 7)) Then
                iLongDia = 2
            Else
                iLongDia = 1
            End If
        End If

        iLongFecha = 6 + iLongDia + iLongMes
        sFecha = Microsoft.VisualBasic.Right(sCadena, iLongFecha)
        Return sFecha
    End Function

    Private Sub Enviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        Dim sNumeroFilaFechaIncorrecta, sNumDuplicado, sNumeroFueraDeRango, sNumIncompleto As String
        Dim iCol, iFila, iPosComa As Integer

        If dgvCarga.Rows.Count < 2 Then Exit Sub

        sNumeroFilaFechaIncorrecta = FechaIncorrecta(dgvCarga)
        If sNumeroFilaFechaIncorrecta <> "" Then Exit Sub

        'If Numero_sorteo_o_sorteo_ingresado_con_error(dgvCarga) Then Exit Sub

        sNumIncompleto = SorteoIncompleto(dgvCarga)
        If sNumIncompleto <> "" Then
            iPosComa = InStr(sNumIncompleto, ",")
            iFila = Mid(sNumIncompleto, 2, iPosComa - 1)
            iCol = Mid(sNumIncompleto, iPosComa + 1, Len(sNumIncompleto) - 1 - iPosComa)
            MessageBox.Show("Algún sorteo no está completo.", "Faltan números", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

        Cursor = Cursors.WaitCursor
        Call Alta()
        Call btnLimpiar_Click(sender, e)
        Cursor = Cursors.Arrow
    End Sub

    Sub Alta()
        Dim ComandoADO As SqlCommand = New SqlCommand("spAgregarReg", CN)
        Dim Valor1 As Long
        Dim Valor2 As Date 
        Dim Valor3, Valor4, Valor5 As String
        Dim i, CantFilas As Integer
        Dim paramNumSorteo, paramFecha, paramSorteoTra, paramSorteoDes, paramSorteoSal As SqlParameter
        Dim Rta As MsgBoxResult

        CantFilas = dgvCarga.RowCount
        ComandoADO.CommandType = CommandType.StoredProcedure

        paramNumSorteo = New SqlParameter("@NumSorteo", SqlDbType.Int, 4)
        paramFecha = New SqlParameter("@Fecha", SqlDbType.SmallDateTime, 10)
        paramSorteoTra = New SqlParameter("@SorteoTra", SqlDbType.VarChar, 12)
        paramSorteoDes = New SqlParameter("@SorteoDes", SqlDbType.VarChar, 12)
        paramSorteoSal = New SqlParameter("@SorteoSal", SqlDbType.VarChar, 12)

        Rta = MessageBox.Show("¿Confirma el alta? ", "Alta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
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
                            i += 1
                        Case 3
                            Valor4 = dgvCarga.Item(i, j).Value
                            i += 1
                        Case 4
                            Valor5 = dgvCarga.Item(i, j).Value
                            i += 1
                    End Select
                Loop

                If YaExisteNumSorteo(CStr(Valor1)) Then
                    MessageBox.Show("Ya existe el número de sorteo " & CStr(Valor1) & "." & vbCrLf & "Ingresar otro nro. de sorteo o modificar el registro correspondiente a ese nro. desde el formulario de búsqueda.", "Sorteo ya cargado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                If Valor1 > 32767 Then
                    MessageBox.Show("El número de sorteo " & CStr(Valor1) & " es incorrecto.", "Número de sorteo fuera de rango", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                Valor3 = OrdenarSorteo(Valor3) : Valor4 = OrdenarSorteo(Valor4) : Valor5 = OrdenarSorteo(Valor5)

                paramNumSorteo.Value = Valor1
                ComandoADO.Parameters.Add(paramNumSorteo)

                If Valor2 <> #12:00:00 AM# Then Valor2 = TransformarFechaASql(Valor2)
                paramFecha.Value = Valor2
                ComandoADO.Parameters.Add(paramFecha)

                paramSorteoTra.Value = Valor3
                ComandoADO.Parameters.Add(paramSorteoTra)

                paramSorteoDes.Value = Valor4
                ComandoADO.Parameters.Add(paramSorteoDes)

                paramSorteoSal.Value = Valor5
                ComandoADO.Parameters.Add(paramSorteoSal)

                ComandoADO.ExecuteNonQuery()
                i = 0

                ComandoADO.Parameters.Clear()
            Next j

            If CantFilas - 2 = 0 Then
                panel1.Text = "Se agregó el registro"
                MessageBox.Show("Se agregó el registro.", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf CantFilas - 2 > 0 Then
                panel1.Text = "Se agregaron los registros"
                MessageBox.Show("Se agregaron los registros.", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            If Err.Number = 6 Then
                MessageBox.Show("Fecha fuera de rango.", "Fecha incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error " & Err.Number & ": " & ex.Message)
            End If
        Finally

        End Try
    End Sub

    Function TransformarFechaASql(ByVal Fecha As Date) As String
        TransformarFechaASql = Format(Fecha, "dd/MM/yyyy")
    End Function

    Function YaExisteNumSorteo(ByVal sNum As String) As Boolean
        Dim ComandoADO As SqlCommand
        Dim myReader As SqlDataReader
        Dim paramEntrada1, paramEntrada2, paramEntrada3 As SqlParameter
        Dim bEncontrado As Boolean

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
        paramEntrada2.Value = DBNull.Value
        ComandoADO.Parameters.Add(paramEntrada2)

        paramEntrada3 = New SqlParameter("@Fecha2", SqlDbType.DateTime, 8)
        paramEntrada3.Direction = ParameterDirection.Input
        paramEntrada3.Value = DBNull.Value
        ComandoADO.Parameters.Add(paramEntrada3)

        myReader = ComandoADO.ExecuteReader()

        If myReader.HasRows Then bEncontrado = True

        myReader.Close()
        If bEncontrado Then Return True
    End Function

    Private Sub btnAbrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbrir.Click
        Dim fic, texto As String
        Dim OFD As New OpenFileDialog
        Dim sr As System.IO.StreamReader

        OFD.Filter = "Archivos de texto (*.txt)|*.txt"
        'OFD.InitialDirectory = Application.StartupPath
        OFD.InitialDirectory = "C:\Users\Fernando\Downloads\Carpetas mías (backup PC)\Loto"
        If OFD.ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub
        fic = OFD.FileName
        sr = New System.IO.StreamReader(fic)
        texto = sr.ReadToEnd()
        sr.Close()
    End Sub

    Private Sub btnCerrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub PegarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PegarToolStripMenuItem1.Click, btnPegar.Click
        sCopiado = My.Computer.Clipboard.GetText()
        If sCopiado = "" Then Exit Sub

        sCopiado = Replace(sCopiado, vbCrLf, "|")
        sCopiado = Replace(sCopiado, " ", "")
        sCopiado = Replace(sCopiado, "	", "")
        sCopiado = Replace(sCopiado, ":", "")
        'sCopiado = Replace(sCopiado, "||", "|")
        Do While sCopiado.Contains("||")
            sCopiado = Replace(sCopiado, "||", "|")
        Loop
        If sCopiado.Substring(sCopiado.Length - 1) = "|" Then sCopiado = sCopiado.Remove(sCopiado.Length - 1, 1) 'por si se copiara con un renglón vacío al final
        Do While sCopiado.StartsWith("|")
            sCopiado = sCopiado.Remove(0, 1)
        Loop

        If sCopiado.IndexOf("SORTEO") <> -1 Then                                            'Copiado de página web y con el formato: Etiqueta SORTEO + Nro. sorteo + Etiqueta FECHA + fecha + números del sorteo
            Call PegarConEtiquetas(sCopiado)
        ElseIf sCopiado.IndexOf("SORTEO") = -1 And sCopiado.IndexOf("FECHA:") = -1 Then     'Cuando lo copiado no tiene las etiquetas y está en el formato: Nro. sorteo + Fecha + Nros. del sorteo
            Call PegarSinEtiquetas(sCopiado)
        End If
    End Sub

    Sub PegarConEtiquetas(ByVal scopiado As String)
        Dim iNumSorteo As Integer
        Dim sFecha, sSorteo1, sSorteo2, sSorteo3 As String
        Dim PosIniNumSorteo, PosFinNumSorteo, PosIniFecha, PosFinFecha As Integer

        If scopiado.IndexOf("|") = -1 Then Exit Sub

        Try
            Do While scopiado.IndexOf("SORTEO") <> -1
                PosIniNumSorteo = scopiado.IndexOf("SORTEO") + 8 : PosFinNumSorteo = scopiado.IndexOf("FECHA")
                PosIniFecha = scopiado.IndexOf("FECHA") + 5 : PosFinFecha = scopiado.IndexOf("|")
                iNumSorteo = scopiado.Substring(PosIniNumSorteo, PosIniFecha - PosIniNumSorteo - 5)   '--> 5 es por la longitud de "FECHA:"
                sFecha = scopiado.Substring(PosIniFecha, PosFinFecha - PosIniFecha)
                sFecha = AjustarFecha(sFecha)
                scopiado = scopiado.Replace(scopiado.Substring(PosIniFecha, PosFinFecha - PosIniFecha), sFecha)
                PosFinFecha = scopiado.IndexOf("|")   '--> repito línea porque al modificar sCopiado, cambia PosFinFecha (y se necesita nuevamente más adelante con su valor actualizado)

                If scopiado.Length < 39 Then Exit Sub '--> el 1º sorteo termina en posición 39

                If scopiado.Length >= 39 Then
                    If IsNumeric(CLng(scopiado.Substring(PosFinFecha + 1, 12))) Then sSorteo1 = scopiado.Substring(PosFinFecha + 1, 12)
                End If

                If scopiado.Length >= 52 Then sSorteo2 = scopiado.Substring(scopiado.IndexOf(sSorteo1) + 13, 12)

                If scopiado.Length >= 65 Then
                    If IsNumeric(CLng(scopiado.Substring(scopiado.IndexOf(sSorteo2) + 13, 12))) Then sSorteo3 = scopiado.Substring(scopiado.IndexOf(sSorteo2) + 13, 12) '--> posición del tercer sorteo completo = 65
                End If

                dgvCarga.Rows.Add(iNumSorteo, sFecha, sSorteo1, sSorteo2, sSorteo3)
                sSorteo1 = "" : sSorteo2 = "" : sSorteo3 = ""
                If scopiado.IndexOf("|SORTEO") = -1 Then Exit Do
                scopiado = scopiado.Remove(0, scopiado.IndexOf("|SORTEO") + 1)
            Loop
        Catch ex As Exception
            MessageBox.Show("Algunos datos copiados no tienen el formato correcto.", "Formato de datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub PegarSinEtiquetas(ByVal sCopiado As String)
        Dim VectorSorteos() As String
        Dim i, iNumSorteo1, iNumSorteo2, iNumSorteo3, PosFinNumSorteo, PosIniFecha, PosFinFecha As Integer
        Dim sFecha, sSorteo1, sSorteo2, sSorteo3 As String

        sSorteo2 = "" : sSorteo3 = ""
        VectorSorteos = Split(sCopiado, "|")

        If VectorSorteos.Length Mod 5 <> 0 Then Exit Sub
        If VectorSorteos.Length < 3 Then
            MessageBox.Show("No se copiaron los nros. del sorteo", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If VectorSorteos.Length = 4 Then
            MessageBox.Show("Reemplazar sorteo faltante con ceros", "Falta un sorteo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Not IsNumeric(VectorSorteos(0)) Then Exit Sub
        If Not IsDate(VectorSorteos(1)) Then Exit Sub

        Do While i <= VectorSorteos.Length - 1
            PosFinNumSorteo = VectorSorteos(i).IndexOf("/") - 3
            PosIniFecha = VectorSorteos(i).IndexOf("/") - 2 : PosFinFecha = PosIniFecha + 10
            iNumSorteo1 = VectorSorteos(i) : i += 1

            sFecha = VectorSorteos(i) : i += 1
            sSorteo1 = VectorSorteos(i) : i += 1
            sSorteo2 = VectorSorteos(i) : i += 1
            sSorteo3 = VectorSorteos(i) : i += 1
            
            dgvCarga.Rows.Add(iNumSorteo1, sFecha, sSorteo1, sSorteo2, sSorteo3)
        Loop
    End Sub

    Private Sub dgvCarga_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvCarga.KeyDown
        'Dim i As Integer
        'Dim NumFilaSeleccionada As Integer = dgvCarga.GetCellCount(DataGridViewElementStates.Selected)

        'iFilaActual = dgvCarga.SelectedCells(i).RowIndex
        'iColActual = dgvCarga.SelectedCells(i).ColumnIndex

        If e.KeyCode = Keys.Delete Then
            If dgvCarga.SelectedRows.Count = 1 Then
                panel1.Text = "Se eliminó la fila seleccionada"
            ElseIf dgvCarga.SelectedRows.Count > 1 Then
                panel1.Text = "Se eliminaron las filas seleccionadas"
            End If
        End If
    End Sub

    Private Sub dgvCarga_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgvCarga.KeyPress
        If e.KeyChar = Chr(13) Then SendKeys.Send("{tab}") : SendKeys.Send("{up}")
    End Sub

    Private Sub dgvCarga_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvCarga.EditingControlShowing
        Dim columnIndex As Integer = dgvCarga.CurrentCell.ColumnIndex
        Dim dText As DataGridViewTextBoxEditingControl = DirectCast(e.Control, DataGridViewTextBoxEditingControl)

        RemoveHandler dText.KeyPress, AddressOf dText_KeyPress
        AddHandler dText.KeyPress, AddressOf dText_KeyPress
    End Sub

    Private Sub dText_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim columnIndex As Integer = dgvCarga.CurrentCell.ColumnIndex

        Select Case dgvCarga.Columns(columnIndex).Index
            Case 0
                If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 Then e.KeyChar = ""
            Case 1
                If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 47 Then e.KeyChar = ""
            Case 2 To 4
                If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 Then e.KeyChar = ""
        End Select

        'If Len(dgvCarga.Item(dgvCarga.CurrentCell.ColumnIndex, dgvCarga.CurrentCell.RowIndex).Value) > 10 Then SendKeys.Send("{tab}")
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        dgvCarga.RowCount = 1
        For j = 0 To dgvCarga.ColumnCount - 1
            dgvCarga.Item(j, 0).Value = ""
        Next j
        panel1.Text = ""
    End Sub

    Private Sub dgvCarga_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvCarga.RowsAdded
        ColoresFilasDataGrid(Me, dgvCarga)
    End Sub

    Private Sub LinkLabel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkLabel1.Click
        System.Diagnostics.Process.Start("http://www.telekinos.com.ar/loto.html")
    End Sub

    Private Sub btnImportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportarExcel.Click
        Dim openFileDialog1 As New OpenFileDialog
        Dim Ruta, cadconex, NombreHojaExcel As String
        Dim Version As Double   '95 = 7.0; 97 = 8.0; 2000 = 9.0; 2002 = 10.0; 2003 = 11.0; 2007 = 12.0
        Dim cn As New OleDb.OleDbConnection
        Dim cmd As New OleDbCommand
        Dim Excel As Object = CreateObject("Excel.Application")
        Dim NumSorteo, Fecha, Sort1, Sort2, Sort3, SorteoEnExcel As String
        Dim ListaHojasExcel As List(Of String)
        Dim PosCaracter As Byte

        If Excel Is Nothing Then
            MsgBox("Al parecer, Excel no está instalado en la máquina. Es necesario que MS Excel esté instalado en la máquina", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Version = CDbl(Val(VersionExcel))

        openFileDialog1.InitialDirectory = Application.StartupPath & "\ReportesExcel\" 'Application.StartupPath  'openFileDialog1.InitialDirectory = "C:\"
        openFileDialog1.Title = "Abrir planilla Excel"
        openFileDialog1.Filter = "Archivos de Microsoft Office Excel (*.xls, *.xlsx)|*.xls; *.xlsx"

        If openFileDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub

        Try
            Cursor = Cursors.WaitCursor
            If openFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Ruta = openFileDialog1.FileName

                'Instancio cadena de conexión para excel, con ruta del archivo:
                If Version < 12.0 Then
                    cadconex = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Ruta.Trim & ";Extended Properties=""Excel 8.0;HDR=Yes;"""        '(Excel 97 - 2003)
                ElseIf Version >= 12.0 Then
                    cadconex = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Ruta.Trim & ";Extended Properties=""Excel 12.0 Xml;HDR=YES"""  '(Excel 2007 en adelante)
                End If

                cn.ConnectionString = cadconex
                ListaHojasExcel = ObtenerNombresHojas(Ruta.Trim)    'NombreHojaExcel = ObtenerNombrePrimeraHoja(Ruta.Trim)
                cmd.Connection = cn
            End If

            For i = 0 To ListaHojasExcel.Count - 1
                Dim da As New OleDb.OleDbDataAdapter
                Dim dt As New DataTable
                cmd.CommandText = "select * from [" & ListaHojasExcel.Item(i) & "$]" 'cmd.CommandText = "select * from [Hoja1$]"
                cmd.CommandType = CommandType.Text
                da.SelectCommand = cmd
                da.Fill(dt)
                dgvCarga.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                If dt.Rows.Count = 0 Then Exit Sub
                For j = 0 To dt.Rows.Count - 1
                    If IsDBNull(dt.Rows(0).Item(0)) Then Exit Sub
                    NumSorteo = dt.Rows(j).Item(0)

                    If IsDBNull(dt.Rows(j).Item(1)) Then
                        MessageBox.Show("Problema con la fecha en el sorteo " & NumSorteo & "." & vbCrLf & "Verificar que todas las filas de la columna Fecha del archivo Excel sean de tipo Fecha y que no contenga espacios.", "Sorteo nro.: " & NumSorteo, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If

                    Fecha = dt.Rows(j).Item(1)

                    If Not IsDBNull(dt.Rows(j).Item(2)) And Not IsDBNull(dt.Rows(j).Item(3)) And Not IsDBNull(dt.Rows(j).Item(4)) And Not IsDBNull(dt.Rows(j).Item(5)) And Not IsDBNull(dt.Rows(j).Item(6)) And Not IsDBNull(dt.Rows(j).Item(7)) Then
                        SorteoEnExcel = dt.Rows(j).Item(2) & dt.Rows(j).Item(3) & dt.Rows(j).Item(4) & dt.Rows(j).Item(5) & dt.Rows(j).Item(6) & dt.Rows(j).Item(7)
                    End If

                    'Para cuando se copian números con espacios entre ellos, esto los quita (a veces en Excel a simple vista los nros. parecen no tener espacio delante, pero al posicionar el mouse delante de ellos se descubre un espacio):
                    Do While SorteoEnExcel.Contains(" ")
                        PosCaracter = SorteoEnExcel.IndexOf(" ")
                        SorteoEnExcel = SorteoEnExcel.Remove(PosCaracter, 1)
                    Loop

                    If Sort1 = "" And Not IsDBNull(SorteoEnExcel) Then
                        Sort1 = SorteoEnExcel
                    ElseIf Sort2 = "" And Not IsDBNull(SorteoEnExcel) Then
                        Sort2 = SorteoEnExcel
                    ElseIf Sort3 = "" And Not IsDBNull(SorteoEnExcel) Then
                        Sort3 = SorteoEnExcel
                    End If

                    If j = dt.Rows.Count - 1 Then
                        dgvCarga.Rows.Add(NumSorteo, Fecha, Sort1, Sort2, Sort3)
                        Sort1 = "" : Sort2 = "" : Sort3 = ""
                        Exit For
                    End If

                    If Not IsDBNull(dt.Rows(j + 1).Item(0)) Then
                        If NumSorteo <> dt.Rows(j + 1).Item(0) Then
                            dgvCarga.Rows.Add(NumSorteo, Fecha, Sort1, Sort2, Sort3)
                            Sort1 = "" : Sort2 = "" : Sort3 = ""
                        End If
                    ElseIf j < dt.Rows.Count - 1 Then
                        dgvCarga.Rows.Add(NumSorteo, Fecha, Sort1, Sort2, Sort3)
                        Sort1 = "" : Sort2 = "" : Sort3 = ""
                        Exit For
                    End If
                Next (j)
            Next (i)

        Catch ex As Exception
            'MessageBox.Show("Error " & Err.Number & ": " & Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("Error " & Err.Number & ": " & Err.Description & vbCrLf & "Revisar no haya espacios en las filas del archivo Excel.", "Sorteo nro.: " & NumSorteo, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Cursor = Cursors.Arrow
        End Try
    End Sub

    Private Function VersionExcel() As String
        Dim Obj As Object
        Dim TempVer As String

        Obj = CreateObject("Excel.Application")
        TempVer = Obj.version

        'cerrar y eliminar la referencia creada:
        Obj.quit()
        Obj = Nothing

        Return TempVer
    End Function

    Private Function ObtenerNombresHojas(ByVal rutaLibro As String) As List(Of String)
        Dim app As Excel.Application = Nothing
        Dim Lista As New List(Of String)
        Try
            app = New Excel.Application()
            Dim wb As Excel.Workbook = app.Workbooks.Open(rutaLibro)
            Dim ws As Excel.Worksheet
            Dim name As String

            For i = 1 To wb.Worksheets.Count
                ws = CType(wb.Worksheets.Item(i), Excel.Worksheet)
                name = ws.Name.ToString
                Lista.Add(name)
            Next

            ws = Nothing : wb.Close() : wb = Nothing
            Return Lista
        Catch ex As Exception
            Throw
        Finally
            If (Not app Is Nothing) Then app.Quit()
            Runtime.InteropServices.Marshal.ReleaseComObject(app)
            app = Nothing
        End Try
    End Function
End Class