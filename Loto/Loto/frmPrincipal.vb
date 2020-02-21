
Public Class frmPrincipal
    Private Sub mnuArchivoSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuArchivoSalir.Click
        Me.Close()
        Dispose()
    End Sub

    Sub AbrirFormulario(ByVal Frm As Windows.Forms.Form)
        Dim AbiertoForm As Boolean = False
        For i As Integer = 0 To My.Application.OpenForms.Count - 1
            If Frm.Name = My.Application.OpenForms.Item(i).Name Then
                AbiertoForm = True
            End If
        Next

        If AbiertoForm = False Then
            Frm.MdiParent = Me
            Frm.WindowState = FormWindowState.Normal
            Frm.Show()
        Else
            Frm.WindowState = FormWindowState.Normal
            Frm.BringToFront()
        End If
    End Sub

    Private Sub frmPrincipal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'http://support.microsoft.com/kb/304643/es
        MostrarAyuda(Me, e)
    End Sub

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        panel1.Width = 1000
        statusBar1.Panels.Add(panel1)
        statusBar1.ShowPanels = True
        Me.Controls.Add(statusBar1)
        panel1.Text = "Conectando a la base..."

        objConfig = clsConfigXml.LeerInicial

        If IsNothing(objConfig) Then
            MsgBox("Falta configurar la conexión.")
            Exit Sub
        Else
            objConexion.Server = objConfig.Server
            objConexion.Database = objConfig.Database
            objConexion.ConectarABase()
        End If

        CambiarEstilo(gbHelp)
        Call Alinear()
        panel1.Text = ""
    End Sub

    Private Sub mnuBuscarBuscarJugadaContenido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBuscarBuscarJugada.Click
        Dim frm As New frmBuscarJugada
        AbrirFormulario(frm)
    End Sub

    Private Sub mnuBuscarBuscarJugadaNumSorteo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub mnuArchivoBasesConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuArchivoBasesConfig.Click
        Dim frm As New frmConfigBase
        AbrirFormulario(frm)
    End Sub

    Private Sub mnuArchivoCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuArchivoCargar.Click
        Dim frm As New frmCargar
        AbrirFormulario(frm)
    End Sub

    Private Sub mnuArchivoFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuArchivoFiltrar.Click
        Dim frm As New frmFiltrar
        AbrirFormulario(frm)
    End Sub

    Private Sub mnuArchivoBasesBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuArchivoBasesBackup.Click
        Dim frm As New frmBackup
        AbrirFormulario(frm)
    End Sub

    Private Sub mnuAyudaVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAyudaVer.Click
        Dim FormActivo As Form = Me.ActiveMdiChild
        If Me.gbHelp.Visible Then
            Me.gbHelp.Visible = False
        Else
            Me.gbHelp.Visible = True
            Me.WebBrowser1.Navigate(Application.StartupPath + "\Reglamento.htm")
        End If
    End Sub

    Private Sub mnuAyudaAcercade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAyudaAcercade.Click
        ShellAbout(0, "Loto 1.0", "Desarrollado por ƒ€rn4nd0" & vbCrLf & "© 2019", 1)
    End Sub

    'Declaración API para mostrar ventana "acerca de":
    Public Declare Function ShellAbout Lib "shell32.dll" Alias "ShellAboutA" (ByVal hwnd As Int32, ByVal szApp As String, ByVal szOtherStuff As String, ByVal hIcon As Int32) As Int32

    'Declaraciones de variables, APIs y constantes para redimensionar panel de ayuda:
    Private DX, DY As Integer

    Private Declare Function GetWindowLong Lib "user32" Alias "GetWindowLongA" (ByVal hwnd As Integer, ByVal nIndex As Integer) As Integer
    Private Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" (ByVal hwnd As Integer, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
    Private Declare Function SetWindowPos Lib "user32" (ByVal hwnd As Integer, ByVal hWndInsertAfter As Integer, ByVal X As Integer, ByVal Y As Integer, ByVal cX As Integer, ByVal cY As Integer, ByVal wFlags As Integer) As Integer

    Const GWL_STYLE As Integer = (-16)
    Const WS_THICKFRAME As Integer = &H40000 ' Con borde redimensionable

    Const SWP_DRAWFRAME As Integer = &H20
    Const SWP_NOMOVE As Integer = &H2
    Const SWP_NOSIZE As Integer = &H1
    Const SWP_NOZORDER As Integer = &H4

    Private Sub CambiarEstilo(ByVal aControl As Control)
        ' Agrega o quita el estilo dimensionable
        Dim Style As Integer
        Try  'Si se produce un error, no hacer nada...
            Style = GetWindowLong(aControl.Handle.ToInt32, GWL_STYLE)
            If (Style And WS_THICKFRAME) = WS_THICKFRAME Then
                ' Si ya lo tiene, lo quita
                Style = Style Xor WS_THICKFRAME
            Else  'Si no lo tiene, lo agrega
                Style = Style Or WS_THICKFRAME
            End If
            SetWindowLong(aControl.Handle.ToInt32, GWL_STYLE, Style)
            SetWindowPos(aControl.Handle.ToInt32, Me.Handle.ToInt32, 0, 0, 0, 0, SWP_NOZORDER Or SWP_NOSIZE Or SWP_NOMOVE Or SWP_DRAWFRAME)
        Catch
        End Try
    End Sub

    Sub Alinear()
        Dim c As Control = CType(gbHelp, Control)
        c.Height = c.Parent.ClientSize.Height - 52 '<- 22 el tamaño de la barra de estado
        c.Left = (c.Parent.ClientSize.Width - c.Width - 4)
    End Sub

    Private Sub picCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCerrar.Click
        gbHelp.Visible = False
    End Sub

    Private Sub picCerrar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCerrar.MouseDown
        picCerrar.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub picCerrar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picCerrar.MouseLeave
        picCerrar.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub picCerrar_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCerrar.MouseUp
        picCerrar.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Dim Ruta As String = WebBrowser1.Url.OriginalString

        lblLink.Text = ""
        lblLink.SendToBack()
        WebBrowser1.ScriptErrorsSuppressed = True
        'lblLink.Text = Ruta
    End Sub

    Private Sub WebBrowser1_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles WebBrowser1.PreviewKeyDown
        Me.Focus()
    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub btnAdelante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdelante.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub mnuEstadisticasSumatoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEstadisticasSumatoria.Click
        Dim frm As New frmSumatoria
        AbrirFormulario(frm)
    End Sub

    Private Sub mnuEstadisticasNrosFrecuentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEstadisticasNrosFrecuentes.Click
        Dim frm As New frmMasFrecuentes
        AbrirFormulario(frm)
    End Sub

    Private Sub mnuEstadisticasNrosFrecuentesCol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEstadisticasNrosFrecuentesCol.Click
        Dim frm As New frmMasFrecuentesCol
        AbrirFormulario(frm)
    End Sub

    Private Sub mnuVentanasHorizontal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVentanasHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub mnuVentanasVertical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVentanasVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub mnuVentanasMosaicos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVentanasMosaicos.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub mnuVentanasCerrarTodas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVentanasCerrarTodas.Click
        Dim CantForms As Integer = Me.MdiChildren.Length - 1
        For i As Integer = 0 To CantForms
            Me.MdiChildren(0).Close()
        Next
    End Sub

    Private Sub mnuEstadisticasPromedio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEstadisticasPromedio.Click
        Dim frm As New frmPromedio
        AbrirFormulario(frm)
    End Sub

    Private Sub mnuEstadisticasAnalizarJugada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEstadisticasAnalizarJugada.Click
        Dim frm As New frmAnalizarJugadas
        AbrirFormulario(frm)
    End Sub

    Private Sub mnuJugadaArmarJugada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuJugadaArmarJugada.Click
        Dim frm As New frmArmarJugada
        AbrirFormulario(frm)
    End Sub

    Private Sub mnuJugadaParametros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuJugadaParametros.Click
        Dim frm As New frmParametrosJugada
        AbrirFormulario(frm)
    End Sub

    Private Sub mnuEstadisticasAnalizarGrupoJugadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEstadisticasAnalizarGrupoJugadas.Click
        Dim frm As New frmAnalizarGrupoJugadas
        AbrirFormulario(frm)
    End Sub

    Private Sub mnuEstadisticasAnalizarSerie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEstadisticasAnalizarSerie.Click
        Dim frm As New frmAnalizarSerie
        AbrirFormulario(frm)
    End Sub
End Class