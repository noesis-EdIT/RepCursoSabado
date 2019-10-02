Public Class frmFiltrar
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        Dim Vector(), VecAux(), Vector2(), sCopiado, sCadenAux As String
        Dim indiceVector, iResult, j As Integer
        Dim lResult As Long

        sCadenAux = ""
        sCopiado = My.Computer.Clipboard.GetText()

        VecAux = Split(sCopiado, vbCrLf)
        ReDim Vector(0)
        '1- Preparo el vector simplificándolo:
        For i = 0 To UBound(VecAux)
            If VecAux(i).Length = 1 Then

            ElseIf VecAux(i) = "" Or VecAux(i) = vbTab Then

            ElseIf VecAux(i) = "LOTO Tradicional" Or VecAux(i) = "LOTO Desquite" Or VecAux(i) = "LOTO Sale o Sale" Then

            ElseIf VecAux(i) = Space(2) + vbTab + Space(2) + vbTab + Space(2) + vbTab + Space(2) + vbTab + Space(2) + vbTab + Space(1) Then '--> "  	  	  	  	  	 "

            ElseIf VecAux(i) = "	  	  	 " Then

            ElseIf VecAux(i) = "	 " Then

            ElseIf VecAux(i).Contains("$") Or VecAux(i).Contains("+") Then

            ElseIf UCase(VecAux(i)) = "EXTRACTO" Then

            ElseIf Len(VecAux(i)) = 4 And Not IsNumeric(Mid(VecAux(i), Len(VecAux(i)) - 1, 1)) Then
                'Datos tipo: "6 		"
            ElseIf VecAux(i).EndsWith("aciertos 	") Then
                VecAux(i + 1) = "	 "
            ElseIf VecAux(i).Contains("N°") And VecAux(i).Contains("/") Then
                'Si contiene Nro. sorteo y Fecha en la misma fila, los separo:
                Vector(indiceVector) = Mid(VecAux(i), 1, 7)
                ReDim Preserve Vector(UBound(Vector) + 1)
                indiceVector = UBound(Vector)

                Vector(indiceVector) = Mid(VecAux(i), 8, VecAux(i).Length)
                ReDim Preserve Vector(UBound(Vector) + 1)
                indiceVector = UBound(Vector)
            ElseIf VecAux(i) = "JACKPOT" Then
                VecAux(i + 1) = ""
            Else
                Vector(indiceVector) = VecAux(i)
                ReDim Preserve Vector(UBound(Vector) + 1)
                indiceVector = UBound(Vector)
            End If
        Next
        ReDim Preserve Vector(UBound(Vector) - 1)

        '2 - Agrego cero a aquellos nros. cuya longitud sea menor a 0:
        Dim sDigitoActual, sFilaActual As String
        Dim y As Integer
        sDigitoActual = "" : sFilaActual = ""
        For x = 0 To Vector.Length - 1
            For y = 1 To Vector(x).Length
                sDigitoActual = Mid(Vector(x), y, 1)
                If sDigitoActual <> "" And (Long.TryParse(Replace(sFilaActual, " ", ""), lResult) Or sFilaActual = "") And (Long.TryParse(sDigitoActual, lResult)) And (Vector(x).Length < 22) Then
                    If y < 2 Then   '--> entra acá sólo para el primer dígito de sDigitoActual o Vector(x), ya que en ese caso no debo comprobar si el valor anterior es " ", ya que el primer dígito no tiene un anterior.
                        If IsNumeric(CInt(sDigitoActual)) And Mid(Vector(x), y + 1, 1) = " " Then
                            sDigitoActual = "0" & sDigitoActual
                        End If
                        sFilaActual = sFilaActual & sDigitoActual
                    ElseIf y >= 2 Then
                        If IsNumeric(CInt(sDigitoActual)) And Mid(Vector(x), y + 1, 1) = " " And Mid(Vector(x), y - 1, 1) = " " Then
                            sDigitoActual = "0" & sDigitoActual
                        End If
                        sFilaActual = sFilaActual & sDigitoActual
                    End If
                Else
                    sFilaActual = sFilaActual & sDigitoActual
                End If
            Next
            Vector(x) = sFilaActual
            sFilaActual = ""
        Next

        If Len(sCopiado) < 22 Then Exit Sub
        ReDim Preserve Vector2(0)

        '3 - Proceso el vector para obtener los datos necesarios en limpio:
        For i = 0 To UBound(Vector)
            If UCase(Vector(i)) = "LOTO TRADICIONAL" Or UCase(Vector(i)) = "LOTO DESQUITE" Or UCase(Vector(i)) = "LOTO SALE O SALE" Or UCase(Vector(i)) = "LOTO YAPA" Then
                Continue For
            ElseIf Len(Vector(i)) > 22 Then
                Continue For
            End If

            j += 1
            Do While j < Vector(i).Length + 1
                If (Mid(Vector(i), j, 1) = "/") Or (Integer.TryParse(Mid(Vector(i), j, 1), iResult)) Then
                    sCadenAux = sCadenAux + Mid(Vector(i), j, 1)
                    j += 1
                    If (Len(sCadenAux) = 12) And (Long.TryParse(sCadenAux, lResult)) Then
                        Vector2(UBound(Vector2)) = sCadenAux
                        ReDim Preserve Vector2(UBound(Vector2) + 1)
                        j = 0 : sCadenAux = ""
                        Continue For
                    ElseIf Len(sCadenAux) = 4 And Not sCadenAux.Contains("/") And Vector2(0) = "" Then
                        Vector2(UBound(Vector2)) = sCadenAux
                        ReDim Preserve Vector2(UBound(Vector2) + 1)
                        j = 0 : sCadenAux = ""
                        Continue For
                    ElseIf (Len(sCadenAux) = 10 And sCadenAux.Contains("/")) Then
                        Vector2(UBound(Vector2)) = sCadenAux
                        ReDim Preserve Vector2(UBound(Vector2) + 1)
                        j = 0 : sCadenAux = ""
                        Continue For
                    End If
                ElseIf (Integer.TryParse(sCadenAux, iResult)) And Not (Integer.TryParse(Mid(Vector(i), j, 1), iResult)) And Not (Mid(Vector(i), j, 1) = " ") And Not (Mid(Vector(i), j, 1) = vbTab) Then
                    j = 0 : sCadenAux = ""
                    Continue For
                Else
                    j += 1
                End If
            Loop
            j = 0
        Next
        ReDim Preserve Vector2(UBound(Vector2) - 1)

        For i = 0 To UBound(Vector2)
            txtSorteo.Text = txtSorteo.Text & Vector2(i) & vbCrLf
        Next

        txtSorteo.Focus()
        txtSorteo.SelectionStart = txtSorteo.TextLength
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        txtSorteo.Text = ""
    End Sub

    Private Sub btnFiltrar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFiltrar.MouseEnter
        panel1.Text = "Agrega ordenadamente en este formulario los datos del sorteo copiado de una pág. web, para luego agregarlos en el formulario de carga."
    End Sub

    Private Sub btnFiltrar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFiltrar.MouseLeave
        panel1.Text = ""
    End Sub
End Class