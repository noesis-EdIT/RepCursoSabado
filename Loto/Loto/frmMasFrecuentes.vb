Imports System.Data.SqlClient

Public Class frmMasFrecuentes
    'http://luismuhidalgo.blogspot.com.ar/2012/11/graficos-en-vb-net.html
    'http://www.visual-basic-tutorials.com/display-data-as-charts-and-graph-in-visual-basic.html

    Dim htSorteo As New Hashtable
    Dim VecOrdenado(41, 1) As String

    Private Sub frmGraficos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpFechaDesde.Value = New DateTime(Year(Now), 1, 1) : dtpFechaHasta.Text = Date.Now

        dgvCantPorNumero.ColumnCount = 2
        dgvCantPorNumero.RowHeadersVisible = False
        dgvCantPorNumero.Columns(0).Name = "Nro."
        dgvCantPorNumero.Columns(1).Name = "Cant."

        dgvCantPorNumero.Width = 75
        dgvCantPorNumero.Columns("Nro.").Width = 35
        dgvCantPorNumero.Columns("Cant.").Width = 37
        dgvCantPorNumero.Columns("Nro.").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvCantPorNumero.Columns("Cant.").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Dim dr As SqlDataReader
        Dim Consulta As String
        Dim dFecha1, dFecha2 As Date
        Dim j As Integer
        Dim tablaNueva As New DataTable

        Call ControlarFechas()
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
                CargarHashTable(Mid(tablaNueva.Rows(i).Item(0), j, 2))
            Next
        Next

        If Not dr.HasRows Then
            dr.Close()
            Exit Sub
        End If

        OrdenarSorteos()
        IncluirNumerosNoSorteados()
        CargarDataGridYChart()
        dr.Close()
    End Sub

    Sub CargarHashTable(ByVal sNum As String)
        Dim ValorAnterior As Integer    '<-- ¿o long?

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

    Sub OrdenarSorteos()
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

        'Ordeno por cantidad de mayor a menor:
        For i = 0 To (VecOrdenado.Length \ 2) - 2
            maximo = i
            For j = i + 1 To (VecOrdenado.Length \ 2) - 1
                If CInt(VecOrdenado(maximo, 1)) < CInt(VecOrdenado(j, 1)) Then
                    maximo = j
                End If
            Next j

            temp = VecOrdenado(i, 0)
            VecOrdenado(i, 0) = VecOrdenado(maximo, 0)
            VecOrdenado(maximo, 0) = IIf(Len(CStr(temp)) < 2, "0" & CStr(temp), CStr(temp))

            temp = VecOrdenado(i, 1)
            VecOrdenado(i, 1) = VecOrdenado(maximo, 1)
            VecOrdenado(maximo, 1) = temp
        Next i
    End Sub

    Sub IncluirNumerosNoSorteados()
        'Para agregar al chart los valores que nunca fueron sorteados (con cantidad cero).
        Dim ListaFaltantes As New List(Of Integer)
        Dim ValActual, PrimeraPosVacia, j As Byte

        Do While ValActual <> 42
            Do While j < 42
                If VecOrdenado(j, 0) <> ValActual Then
                    j += 1
                Else
                    If VecOrdenado(j, 0) = Nothing Then
                        ListaFaltantes.Add(VecOrdenado(j, 0))
                        If PrimeraPosVacia = 0 And VecOrdenado.Length > 0 Then PrimeraPosVacia = j
                    Else
                        j = 0
                        Exit Do
                    End If
                End If
            Loop
            ValActual += 1
        Loop

        If ListaFaltantes.Count = 0 Then Exit Sub

        For i = 0 To ListaFaltantes.Count - 1
            VecOrdenado(PrimeraPosVacia, 0) = ListaFaltantes(i)
            PrimeraPosVacia += 1
        Next
    End Sub

    Sub CargarDataGridYChart()
        Dim fila As Integer

        Chart1.Series.Clear()
        dgvCantPorNumero.RowCount = 1
        For i = 0 To 5
            If Not (String.IsNullOrEmpty(VecOrdenado(i, 0))) Then
                Chart1.Series.Add(CStr(VecOrdenado(i, 0)))
            End If
        Next

        For i = 0 To (VecOrdenado.Length \ 2) - 1
            If i <> (VecOrdenado.Length \ 2) - 1 Then dgvCantPorNumero.Rows.Add(1)
            If Not (String.IsNullOrEmpty(VecOrdenado(i, 0))) Then
                dgvCantPorNumero.Item(0, fila).Value = VecOrdenado(i, 0)
                dgvCantPorNumero.Item(1, fila).Value = VecOrdenado(i, 1)
                fila += 1
            End If
        Next

        If dgvCantPorNumero.RowCount > 17 Then dgvCantPorNumero.Width = 93

        'Sin esto, en cada nuevo cálculo podrían quedar varias columnas fuera del chart (por estar fuera de escala debido a una sumatoria mayor):
        Chart1.ChartAreas(0).AxisY.Maximum = VecOrdenado(0, 1) + 10

        For i = 0 To 5
            If Not (String.IsNullOrEmpty(VecOrdenado(i, 0))) Then
                Chart1.Series(VecOrdenado(i, 0)).Points.AddXY(VecOrdenado(i, 0), VecOrdenado(i, 1))
                Chart1.Series(VecOrdenado(i, 0)).IsValueShownAsLabel = True
                'Tipo de gráfico mostrado:
                'Chart1.Series(VecOrdenado(i, 0)).ChartType = DataVisualization.Charting.SeriesChartType.Column
            End If
        Next
    End Sub

    Private Sub ControlarFechas()
        Dim dFecha1, dFecha2 As Date

        dFecha1 = dtpFechaDesde.Text : dFecha2 = dtpFechaHasta.Text

        If Not dtpFechaDesde.Focused And Not dtpFechaHasta.Focused Then
            If dFecha2 < dFecha1 Then
                panel1.Text = "La fecha inicial no puede ser posterior a la final"
                MessageBox.Show("La fecha inicial no puede ser posterior a la final.", "Fecha", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtpFechaDesde.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class