Public Class frmConfigBase
    Dim claseconnect As New clsConexion

    Dim sServidorInicial, sBaseInicial, sUsuarioInicial, sClaveInicial As String

    Private Sub frmConfigBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objConfig = clsConfigXml.LeerInicial
        txtServidor.Text = objConfig.Server   'FERNANDO-PC\SQLEXPRESS
        txtBase.Text = objConfig.Database
        txtUsuario.Text = objConfig.User

        sServidorInicial = objConfig.Server
        sBaseInicial = objConfig.Database
        sUsuarioInicial = objConfig.User
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnProbarConexion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProbarConexion.Click
        'Para conexión con autenticación de Windows:
        If txtServidor.Text <> "" And txtBase.Text <> "" Then
            Dim nuevaconexion As String = "Data Source=" + txtServidor.Text + ";Initial Catalog=" + txtBase.Text + ";Integrated Security=True"

            Cursor = Cursors.WaitCursor
            If claseconnect.ProbarConexion(nuevaconexion) Then
                MessageBox.Show("Conexión exitosa.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Conexión fallida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub btnGuardarConexion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarConexion.Click
        If txtServidor.Text <> "" And txtBase.Text <> "" Then
            Try
                If IsNothing(objConfig) Then
                    objConfig = New clsConfigXml
                End If

                objConfig.Database = txtBase.Text
                objConfig.Password = txtClave.Text
                objConfig.Server = txtServidor.Text
                objConfig.User = txtUsuario.Text
                objConfig.Guardar()

                MessageBox.Show("La conexión se guardó correctamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Todos los datos son necesarios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        txtServidor.Text = sServidorInicial
        txtBase.Text = sBaseInicial
        txtUsuario.Text = sUsuarioInicial
    End Sub
End Class