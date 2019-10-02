﻿'http://oranetperu.blogspot.com/2013/08/reportes-estadisticos-primera-parte.html

Imports System.Data.SqlClient

Public Class frmPromedio
    Dim htSorteo As New Hashtable
    Dim tablaTra, tablaDes, tablaSos As New DataTable
    Dim bSeriesPrincipalesMostradas, bSeriePrevisionMostrada As Boolean

    Private Sub frmPromedio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim campoNumerico As New Integer

        dtpFechaDesde.Text = New DateTime(Year(Now), 1, 1) : dtpFechaHasta.Text = Date.Now
        chkSorteos.SetItemChecked(0, True)

        tablaTra.Columns.Add("Sorteo1") : tablaTra.Columns.Add("Fecha") : tablaTra.Columns.Add("Promedio", campoNumerico.GetType())
        tablaDes.Columns.Add("Sorteo2") : tablaDes.Columns.Add("Fecha") : tablaDes.Columns.Add("Promedio", campoNumerico.GetType())
        tablaSos.Columns.Add("Sorteo3") : tablaSos.Columns.Add("Fecha") : tablaSos.Columns.Add("Promedio", campoNumerico.GetType())

        cboTipoGrafico.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cboTipoGrafico.AutoCompleteSource = AutoCompleteSource.ListItems
        cboTipoGrafico.DropDownStyle = ComboBoxStyle.DropDownList
        cboTipoGrafico.SelectedIndex = 0
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Call CargarTablasDeSeriesPrincipales()
        Call CargarSeriesPrincipalesEnChart()
        If chkEstimacion.Checked Then Call CargarSerieDeEstimacionEnChart()
        bSeriesPrincipalesMostradas = True
    End Sub

    Private Sub CargarTablasDeSeriesPrincipales()
        Dim dr As SqlDataReader
        Dim Consulta, sValorActual As String
        Dim dFecha1, dFecha2 As Date
        Dim iSuma As Integer
        Dim dblPromedio As Double

        htSorteo.Clear()
        dFecha1 = dtpFechaDesde.Text : dFecha2 = dtpFechaHasta.Text

        Consulta = "SELECT SorteoTra, SorteoDes, SorteoSal, CONVERT(VARCHAR(10), Fecha, 103) as Fecha from Sorteos where Fecha between '" & dFecha1 & "'" & " and '" & dFecha2 & "'"
        dr = objConexion.EjecutarConsultaDR(Consulta)

        Chart1.Series.Clear()

        If chkSorteos.GetItemCheckState(0).ToString() = "Checked" Then Chart1.Series.Add("Tradicional")
        If chkSorteos.GetItemCheckState(1).ToString() = "Checked" Then Chart1.Series.Add("Desquite")
        If chkSorteos.GetItemCheckState(2).ToString() = "Checked" Then Chart1.Series.Add("SOS")

        tablaTra.Clear() : tablaDes.Clear() : tablaSos.Clear()

        While dr.Read
            If chkSorteos.GetItemCheckState(0).ToString() = "Checked" Then
                sValorActual = dr("SorteoTra")
                For i = 1 To 11 Step 2
                    iSuma = iSuma + CInt(Mid(sValorActual, i, 2))
                Next
                dblPromedio = iSuma / 6
                tablaTra.Rows.Add(dr("SorteoTra"), dr("Fecha"), dblPromedio)
                iSuma = 0 : dblPromedio = 0
            End If

            If chkSorteos.GetItemCheckState(1).ToString() = "Checked" Then
                sValorActual = dr("SorteoDes")
                For i = 1 To 11 Step 2
                    iSuma = iSuma + CInt(Mid(sValorActual, i, 2))
                Next
                dblPromedio = iSuma / 6
                tablaDes.Rows.Add(dr("SorteoDes"), dr("Fecha"), dblPromedio)
                iSuma = 0
            End If

            If chkSorteos.GetItemCheckState(2).ToString() = "Checked" Then
                sValorActual = dr("SorteoSal")
                For i = 1 To 11 Step 2
                    iSuma = iSuma + CInt(Mid(sValorActual, i, 2))
                Next
                dblPromedio = iSuma / 6
                tablaSos.Rows.Add(dr("SorteoSal"), dr("Fecha"), dblPromedio)
                iSuma = 0
            End If
        End While

        dr.Close()
    End Sub

    Sub CargarSeriesPrincipalesEnChart()
        Dim TipoGrafico As System.Windows.Forms.DataVisualization.Charting.SeriesChartType
        Dim NumSerie As Byte

        For Each fila As DataRow In tablaTra.Rows
            Chart1.Series("Tradicional").Points.AddXY(fila("Fecha").ToString, fila("Promedio").ToString)
        Next
        Chart1.Series(0).Color = Color.CadetBlue

        For Each fila As DataRow In tablaDes.Rows
            Chart1.Series("Desquite").Points.AddXY(fila("Fecha").ToString, fila("Promedio").ToString)
        Next

        For Each fila As DataRow In tablaSos.Rows
            Chart1.Series("SOS").Points.AddXY(fila("Fecha").ToString, fila("Promedio").ToString)
        Next

        For j = 0 To cboTipoGrafico.Items.Count - 1
            If cboTipoGrafico.SelectedIndex = 0 Then
                TipoGrafico = DataVisualization.Charting.SeriesChartType.Spline         'Línea
                Exit For
            ElseIf cboTipoGrafico.SelectedIndex = 1 Then
                TipoGrafico = DataVisualization.Charting.SeriesChartType.SplineRange    'Línea de área
                Exit For
            ElseIf cboTipoGrafico.SelectedIndex = 2 Then
                TipoGrafico = DataVisualization.Charting.SeriesChartType.FastPoint
                Exit For
            ElseIf cboTipoGrafico.SelectedIndex = 3 Then
                TipoGrafico = DataVisualization.Charting.SeriesChartType.Column         'Barras (por defecto)
                Exit For
            ElseIf cboTipoGrafico.SelectedIndex = 4 Then
                TipoGrafico = DataVisualization.Charting.SeriesChartType.Range          'Area
                Exit For
            ElseIf cboTipoGrafico.SelectedIndex = 5 Then
                TipoGrafico = DataVisualization.Charting.SeriesChartType.Renko
                Exit For
            ElseIf cboTipoGrafico.SelectedIndex = 6 Then
                TipoGrafico = DataVisualization.Charting.SeriesChartType.Stock
                Exit For
            ElseIf cboTipoGrafico.SelectedIndex = 7 Then
                TipoGrafico = DataVisualization.Charting.SeriesChartType.FastLine
                Exit For
            ElseIf cboTipoGrafico.SelectedIndex = 8 Then
                TipoGrafico = DataVisualization.Charting.SeriesChartType.BoxPlot
                Exit For
            End If
        Next

        For i = 0 To 2
            If chkSorteos.GetItemCheckState(i).ToString() = "Checked" Then
                Chart1.Series(NumSerie).ChartType = TipoGrafico
                NumSerie += 1
            End If
        Next

        'Chart1.ChartAreas(0).AxisX.Interval = 6
        'Chart1.ChartAreas(0).AxisX.LabelStyle.Interval = 2
    End Sub

    Private Sub CargarSerieDeEstimacionEnChart()
        'http://www.cirvirlab.com/index.php/c-sharp-code-examples/financialformula-forecasting-in-mschart-c.html
        'https://msdn.microsoft.com/es-es/library/system.windows.forms.datavisualization.charting(v=vs.110).aspx
        'https://msdn.microsoft.com/es-es/library/dd456655.aspx
        'https://social.msdn.microsoft.com/Forums/es-ES/b49d6986-e9cd-4574-901a-cdd66855a2ef/como-mostrar-las-fechas-correspondiente-en-el-diagrama-en-vb-net?forum=vbes

        If chkEstimacion.Checked Then
            Chart1.Series.Add("Previsión")
            Chart1.Series("Previsión").AxisLabel = "Próximo sorteo"
            Chart1.Series("Previsión").BorderWidth = 2
            Chart1.Series("Previsión").ChartType = DataVisualization.Charting.SeriesChartType.Spline
            'Chart1.ChartAreas(0).AxisX.Interval = 6

            'Parámetros en: http://www.4guysfromrolla.com/articles/111809-1.aspx  -->
            Chart1.DataManipulator.FinancialFormula(DataVisualization.Charting.FinancialFormula.Forecasting, "4, 3, false, false", Chart1.Series(0), Chart1.Series("Previsión"))
            bSeriePrevisionMostrada = True

        End If

        'Chart1.Series(0).XValueType = ChartValueType.DateTime;
        'Dim x As New System.DateTime(2018, 5, 30)
        'Chart1.Series(0).Points.AddXY(x.ToOADate(), 34)
    End Sub

    Private Sub Chart1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Chart1.MouseMove
        'https://social.msdn.microsoft.com/Forums/es-ES/f43bbb40-b22d-4b2c-bd50-8b3712f70c17/como-ver-los-valores-de-un-grafico-chart-al-pasar-el-mouse-sobre-la-linea-del-grafico-en-vbnet?forum=vsgenerales
        Dim result As DataVisualization.Charting.HitTestResult = Chart1.HitTest(e.X, e.Y, DataVisualization.Charting.ChartElementType.DataPoint)

        If Not result.Object Is Nothing Then
            For k As Integer = 0 To result.Series.Points.Count - 1
                result.Series.Points.Item(k).IsValueShownAsLabel = (k = result.PointIndex)
            Next
        End If
    End Sub

    Private Sub mtbFechaDesde_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim bln As Boolean
        Dim dFecha As Date

        panel1.Text = ""
        bln = DateTime.TryParse(dtpFechaDesde.Text, dFecha)
        If (Not (bln)) Then
            panel1.Text = "Fecha inicial incorrecta!!!"
            dtpFechaDesde.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub mtbFechaHasta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim bln As Boolean
        Dim dFecha As Date

        panel1.Text = ""
        bln = DateTime.TryParse(dtpFechaHasta.Text, dFecha)
        If (Not (bln)) Then
            panel1.Text = "Fecha inicial incorrecta!!!"
            dtpFechaHasta.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub chkEstimacion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkEstimacion.Click
        'Sólo si ya se había pulsado en Calcular, entonces que calcule nuevamente añadiendo la estimación (sino, que espere hasta que se pulse en Calcular por primera vez):
        If bSeriesPrincipalesMostradas Then Call btnCalcular_Click(sender, e)
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class