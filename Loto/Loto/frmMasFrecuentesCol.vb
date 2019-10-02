Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmMasFrecuentesCol
    Dim htSorteo As New Hashtable
    Dim slSorteo As New SortedList
    Dim VecOrdenado(41, 1) As String

    Private Sub frmMasFrecuentesCol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpFechaDesde.Value = New DateTime(Year(Now), 1, 1) : dtpFechaHasta.Text = Date.Now

        dgvCantPorNumero.ColumnCount = 2
        dgvCantPorNumero.RowHeadersVisible = False
        dgvCantPorNumero.Columns(0).Name = "Nro."
        dgvCantPorNumero.Columns(1).Name = "Cantidad"

        dgvCantPorNumero.Width = 93
        dgvCantPorNumero.Columns("Nro.").Width = 40
        dgvCantPorNumero.Columns("Cantidad").Width = 50
        dgvCantPorNumero.Columns("Nro.").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvCantPorNumero.Columns("Cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        cbxColumna.Items.Add("Col. 1 (00 a 06)")
        cbxColumna.Items.Add("Col. 2 (07 a 13)")
        cbxColumna.Items.Add("Col. 3 (14 a 20)")
        cbxColumna.Items.Add("Col. 4 (21 a 27)")
        cbxColumna.Items.Add("Col. 5 (28 a 34)")
        cbxColumna.Items.Add("Col. 6 (35 a 41)")
        cbxColumna.SelectedIndex = 0
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Dim dr As SqlDataReader
        Dim Consulta, sClave As String
        Dim dFecha1, dFecha2 As Date
        Dim tablaNueva As New DataTable
        Dim iMayor As Byte
        Dim VecSorteosCant(slSorteo.Count - 1, 1), x As Integer

        htSorteo.Clear()
        dFecha1 = dtpFechaDesde.Text : dFecha2 = dtpFechaHasta.Text
        If dFecha1 > dFecha2 Then
            MessageBox.Show("La fecha inicial no debe ser posterior a la fecha final.", "Fechas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Consulta = "SELECT SorteoTra, SorteoDes, SorteoSal from Sorteos where Fecha between '" & dFecha1 & "'" & " and '" & dFecha2 & "'"
        dr = objConexion.EjecutarConsultaDR(Consulta)

        tablaNueva.Columns.Add("Sorteo")

        While dr.Read
            tablaNueva.Rows.Add(dr("SorteoTra") & dr("SorteoDes") & dr("SorteoSal"))
        End While

        For i = 0 To tablaNueva.Rows.Count - 1
            For j = 1 To 36 Step 2
                CargarSortedList(Mid(tablaNueva.Rows(i).Item(0), j, 2))
            Next
        Next

        ReDim VecSorteosCant(slSorteo.Count - 1, 1)

        Do While slSorteo.Count > 0
            For Each Clave In slSorteo.Keys
                If slSorteo(Clave) > iMayor Then
                    sClave = Clave
                    iMayor = slSorteo(Clave)
                End If
            Next

            VecSorteosCant(x, 0) = sClave : VecSorteosCant(x, 1) = iMayor
            iMayor = 0
            x += 1
            slSorteo.Remove(sClave)
        Loop

        If Not dr.HasRows Then
            dr.Close()
            Exit Sub
        End If

        CargarDataGridYChart(VecSorteosCant)
        dr.Close()
    End Sub

    Sub CargarSortedList(ByVal sNum As String)
        Dim ValorAnterior As Integer

        If slSorteo.ContainsKey(sNum) Then
            ValorAnterior = slSorteo(sNum)
            ValorAnterior += 1
            slSorteo.Remove(sNum)
            slSorteo.Add(sNum, ValorAnterior)
        Else
            ValorAnterior = 1
            slSorteo.Add(sNum, ValorAnterior)
        End If
    End Sub

    Sub CargarDataGridYChart(ByVal Vector(,) As Integer)
        Dim iRow, iColInicial, iColFinal, fila As Byte

        Chart1.Series(0).Points.Clear()
        Chart1.Series(0).ChartType = SeriesChartType.Pie
        Chart1.ChartAreas(0).Area3DStyle.Enable3D = True

        dgvCantPorNumero.RowCount = 1

        Select Case cbxColumna.SelectedIndex
            Case 0
                iColInicial = 0 : iColFinal = 6
            Case 1
                iColInicial = 7 : iColFinal = 13
            Case 2
                iColInicial = 14 : iColFinal = 20
            Case 3
                iColInicial = 21 : iColFinal = 27
            Case 4
                iColInicial = 28 : iColFinal = 34
            Case 5
                iColInicial = 35 : iColFinal = 41
        End Select

        For iRow = iColInicial To iColFinal
            Chart1.Series(0).Points.AddY(0)
        Next

        For i = 0 To (Vector.Length \ 2) - 1
            If Vector(i, 0) <= iColFinal And Vector(i, 0) >= iColInicial Then
                dgvCantPorNumero.Rows.Add(1)
                dgvCantPorNumero.Item(0, fila).Value = Vector(i, 0)
                dgvCantPorNumero.Item(1, fila).Value = Vector(i, 1)
                Chart1.Series(0).Points(fila).LegendText = Vector(i, 0)
                fila += 1
            End If

        Next

        Chart1.Series(0).Label = "#VAL{0}"  '--> para que los muestre como enteros. Otras: #VAL{0.0}, #VAL{0.0}, #VAL{C}, etc.

        For i = 0 To fila - 1
            Chart1.Series(0).Points(i).SetValueY(Vector(i, 1))
        Next
        Chart1.Series.Invalidate()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class