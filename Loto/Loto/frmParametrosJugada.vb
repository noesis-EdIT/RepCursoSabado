Imports System.Xml.Serialization
Imports System.IO

Public Class frmParametrosJugada
    Dim objParam As New clsParametrosJugada

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If Len(txtExcluir1.Text) = 1 Then txtExcluir1.Text = "0" & txtExcluir1.Text
            If Len(txtExcluir2.Text) = 1 Then txtExcluir2.Text = "0" & txtExcluir2.Text
            If Len(txtExcluir3.Text) = 1 Then txtExcluir3.Text = "0" & txtExcluir3.Text

            objParam.NumMasFrecuente1 = IIf(txtMasFrec1.Text <> "", txtMasFrec1.Text, -1)
            objParam.NumMasFrecuente2 = IIf(txtMasFrec2.Text <> "", txtMasFrec2.Text, -1)
            objParam.NumMasFrecuente3 = IIf(txtMasFrec3.Text <> "", txtMasFrec3.Text, -1)
            objParam.CantPares = txtCantPares.Text
            objParam.TerminacionParaDosNum = IIf(txtTerminacion.Text = "", "-1", txtTerminacion.Text)
            objParam.NumSorteoAnterior = IIf(txtNumSorteoAnt.Text = "", "-1", txtNumSorteoAnt.Text)
            objParam.CantNumUnSoloDigito = IIf(txtUnSoloDigito.Text = "", "0", txtUnSoloDigito.Text)
            objParam.AlmenosDosNumConsec = IIf(chkDosConsecutivos.CheckState = 1, True, False)
            objParam.SumatoriaMinima = nudSumatoriaInferior.Value
            objParam.SumatoriaMaxima = nudSumatoriaSuperior.Value
            objParam.DifEntreConsecutivosMin = nudDifMinima.Value
            objParam.DifEntreConsecutivosMax = nudDifMaxima.Value
            objParam.CantMinimaPrimos = IIf(txtPrimos.Text = "", "-1", txtPrimos.Text)
            objParam.NumExcluido1 = IIf(txtExcluir1.Text <> "", txtExcluir1.Text, -1)
            objParam.NumExcluido2 = IIf(txtExcluir2.Text <> "", txtExcluir2.Text, -1)
            objParam.NumExcluido3 = IIf(txtExcluir3.Text <> "", txtExcluir3.Text, -1)

            Call objParam.Guardar()
            MessageBox.Show("Parámetros guardados correctamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmParametrosJugada_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim Res As MsgBoxResult
        If e.KeyCode = Keys.Escape Then
            Res = MessageBox.Show("¿Cerrar Parámetros?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End If

        If Res = MsgBoxResult.Yes Then Me.Close()
    End Sub

    Private Sub frmParametrosJugada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objParam = clsParametrosJugada.Leer
        Call CargarControles()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        objParam = clsParametrosJugada.Leer
        Call CargarControles()
    End Sub

    Private Sub chkDosConsecutivos_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDosConsecutivos.CheckedChanged
        chkDosConsecutivos.Text = IIf(chkDosConsecutivos.CheckState = 1, "Sí", "No")
    End Sub

    Private Sub CargarControles()
        txtMasFrec1.Text = IIf(objParam.NumMasFrecuente1 = -1, "", objParam.NumMasFrecuente1)
        txtMasFrec2.Text = IIf(objParam.NumMasFrecuente2 = -1, "", objParam.NumMasFrecuente2)
        txtMasFrec3.Text = IIf(objParam.NumMasFrecuente3 = -1, "", objParam.NumMasFrecuente3)
        txtCantPares.Text = objParam.CantPares
        txtTerminacion.Text = IIf(objParam.TerminacionParaDosNum = -1, "", objParam.TerminacionParaDosNum)
        txtNumSorteoAnt.Text = IIf(objParam.NumSorteoAnterior = -1, "", objParam.NumSorteoAnterior)
        txtUnSoloDigito.Text = objParam.CantNumUnSoloDigito
        chkDosConsecutivos.CheckState = IIf(objParam.AlmenosDosNumConsec = True, 1, 0)
        nudSumatoriaInferior.Value = objParam.SumatoriaMinima
        nudSumatoriaSuperior.Value = objParam.SumatoriaMaxima
        nudDifMinima.Value = objParam.DifEntreConsecutivosMin
        nudDifMaxima.Value = objParam.DifEntreConsecutivosMax
        txtPrimos.Text = IIf(objParam.CantMinimaPrimos = -1, "", objParam.CantMinimaPrimos)
        txtExcluir1.Text = IIf(objParam.NumExcluido1 = -1, "", objParam.NumExcluido1)
        txtExcluir2.Text = IIf(objParam.NumExcluido2 = -1, "", objParam.NumExcluido2)
        txtExcluir3.Text = IIf(objParam.NumExcluido3 = -1, "", objParam.NumExcluido3)
    End Sub

    Private Sub txtMasFrec1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMasFrec1.KeyPress, txtMasFrec2.KeyPress, txtMasFrec3.KeyPress, txtTerminacion.KeyPress, txtNumSorteoAnt.KeyPress, txtUnSoloDigito.KeyPress, txtPrimos.KeyPress, txtExcluir1.KeyPress, txtExcluir2.KeyPress, txtExcluir3.KeyPress
        ValidarEnteros(e)
    End Sub

    Private Sub ValidarEnteros(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If ((Asc(e.KeyChar) < 48) Or (Asc(e.KeyChar) > 57)) And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class