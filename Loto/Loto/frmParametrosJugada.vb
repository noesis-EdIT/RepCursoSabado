Imports System.Xml.Serialization
Imports System.IO

Public Class frmParametrosJugada
    Dim objParam As New clsParametrosJugada

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim SeIncluyeronValoresRepetidos As Boolean

        Try
            If Len(txtExcluir1.Text) = 1 Then txtExcluir1.Text = "0" & txtExcluir1.Text
            If Len(txtExcluir2.Text) = 1 Then txtExcluir2.Text = "0" & txtExcluir2.Text
            If Len(txtExcluir3.Text) = 1 Then txtExcluir3.Text = "0" & txtExcluir3.Text

            objParam.NumIncluir1 = IIf(txtIncluir1.Text <> "", txtIncluir1.Text, -1)
            objParam.NumIncluir2 = IIf(txtIncluir2.Text <> "", txtIncluir2.Text, -1)
            objParam.NumIncluir3 = IIf(txtIncluir3.Text <> "", txtIncluir3.Text, -1)
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

            SeIncluyeronValoresRepetidos = ValoresRepetidos()
            If SeIncluyeronValoresRepetidos Then Exit Sub
            Call objParam.Guardar()
            MessageBox.Show("Parámetros guardados correctamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Function ValoresRepetidos() As Boolean
        Dim iValor1, iValor2, iValor3, num As SByte

        iValor1 = IIf(Byte.TryParse(objParam.NumIncluir1, num), objParam.NumIncluir1, -1)
        iValor2 = IIf(Byte.TryParse(objParam.NumIncluir2, num), objParam.NumIncluir2, -1)
        iValor3 = IIf(Byte.TryParse(objParam.NumIncluir3, num), objParam.NumIncluir3, -1)

        If (iValor1 <> -1) Then
            If (iValor2 <> -1) Then
                If iValor1 = iValor2 Then
                    erParametros.SetError(txtIncluir3, "Valores repetidos.")
                    txtIncluir1.Focus()
                    Return True
                End If
            End If

            If (iValor3 <> -1) Then
                If iValor1 = iValor3 Then
                    erParametros.SetError(txtIncluir3, "Valores repetidos.")
                    txtIncluir1.Focus()
                    Return True
                End If
            End If
        End If

        If (iValor2 <> -1) Then
            If (iValor3 <> -1) Then
                If iValor2 = iValor3 Then
                    erParametros.SetError(txtIncluir3, "Valores repetidos.")
                    txtIncluir1.Focus()
                    Return True
                End If
            End If
        End If

        iValor1 = IIf(Byte.TryParse(objParam.NumExcluido1, num), objParam.NumExcluido1, -1)
        iValor2 = IIf(Byte.TryParse(objParam.NumExcluido2, num), objParam.NumExcluido2, -1)
        iValor3 = IIf(Byte.TryParse(objParam.NumExcluido3, num), objParam.NumExcluido3, -1)

        If (iValor1 <> -1) Then
            If (iValor2 <> -1) Then
                If iValor1 = iValor2 Then
                    erParametros.SetError(txtExcluir3, "Valores repetidos.")
                    txtExcluir1.Focus()
                    Return True
                End If
            End If

            If (iValor3 <> -1) Then
                If iValor1 = iValor3 Then
                    erParametros.SetError(txtExcluir3, "Valores repetidos.")
                    txtExcluir1.Focus()
                    Return True
                End If
            End If
        End If

        If (iValor2 <> -1) Then
            If (iValor3 <> -1) Then
                If iValor2 = iValor3 Then
                    erParametros.SetError(txtExcluir3, "Valores repetidos.")
                    txtExcluir1.Focus()
                    Return True
                End If
            End If
        End If
    End Function


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
        txtIncluir1.Text = IIf(objParam.NumIncluir1 = -1, "", objParam.NumIncluir1)
        txtIncluir2.Text = IIf(objParam.NumIncluir2 = -1, "", objParam.NumIncluir2)
        txtIncluir3.Text = IIf(objParam.NumIncluir3 = -1, "", objParam.NumIncluir3)
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

    Private Sub txtMasFrec1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIncluir1.KeyPress, txtIncluir2.KeyPress, txtIncluir3.KeyPress, txtTerminacion.KeyPress, txtNumSorteoAnt.KeyPress, txtUnSoloDigito.KeyPress, txtPrimos.KeyPress, txtExcluir1.KeyPress, txtExcluir2.KeyPress, txtExcluir3.KeyPress
        erParametros.Dispose()
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