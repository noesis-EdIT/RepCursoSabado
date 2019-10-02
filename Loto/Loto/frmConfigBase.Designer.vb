<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigBase
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfigBase))
        Me.btnGuardarConexion = New System.Windows.Forms.Button()
        Me.btnProbarConexion = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBase = New System.Windows.Forms.TextBox()
        Me.lblServidor = New System.Windows.Forms.Label()
        Me.txtServidor = New System.Windows.Forms.TextBox()
        Me.lblBase = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblClave = New System.Windows.Forms.Label()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGuardarConexion
        '
        Me.btnGuardarConexion.Location = New System.Drawing.Point(353, 46)
        Me.btnGuardarConexion.Name = "btnGuardarConexion"
        Me.btnGuardarConexion.Size = New System.Drawing.Size(99, 25)
        Me.btnGuardarConexion.TabIndex = 2
        Me.btnGuardarConexion.Text = "Guardar conexión"
        Me.btnGuardarConexion.UseVisualStyleBackColor = True
        '
        'btnProbarConexion
        '
        Me.btnProbarConexion.Location = New System.Drawing.Point(353, 17)
        Me.btnProbarConexion.Name = "btnProbarConexion"
        Me.btnProbarConexion.Size = New System.Drawing.Size(99, 25)
        Me.btnProbarConexion.TabIndex = 1
        Me.btnProbarConexion.Text = "Probar conexión"
        Me.btnProbarConexion.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBase)
        Me.GroupBox1.Controls.Add(Me.lblServidor)
        Me.GroupBox1.Controls.Add(Me.txtServidor)
        Me.GroupBox1.Controls.Add(Me.lblBase)
        Me.GroupBox1.Controls.Add(Me.lblUsuario)
        Me.GroupBox1.Controls.Add(Me.lblClave)
        Me.GroupBox1.Controls.Add(Me.txtClave)
        Me.GroupBox1.Controls.Add(Me.txtUsuario)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(331, 154)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtBase
        '
        Me.txtBase.Location = New System.Drawing.Point(83, 50)
        Me.txtBase.Name = "txtBase"
        Me.txtBase.Size = New System.Drawing.Size(216, 20)
        Me.txtBase.TabIndex = 5
        '
        'lblServidor
        '
        Me.lblServidor.AutoSize = True
        Me.lblServidor.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServidor.Location = New System.Drawing.Point(20, 26)
        Me.lblServidor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblServidor.Name = "lblServidor"
        Me.lblServidor.Size = New System.Drawing.Size(56, 15)
        Me.lblServidor.TabIndex = 0
        Me.lblServidor.Text = "Servidor:"
        '
        'txtServidor
        '
        Me.txtServidor.Location = New System.Drawing.Point(83, 24)
        Me.txtServidor.Name = "txtServidor"
        Me.txtServidor.Size = New System.Drawing.Size(216, 20)
        Me.txtServidor.TabIndex = 4
        '
        'lblBase
        '
        Me.lblBase.AutoSize = True
        Me.lblBase.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBase.Location = New System.Drawing.Point(20, 53)
        Me.lblBase.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBase.Name = "lblBase"
        Me.lblBase.Size = New System.Drawing.Size(36, 15)
        Me.lblBase.TabIndex = 1
        Me.lblBase.Text = "Base:"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(20, 82)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(54, 15)
        Me.lblUsuario.TabIndex = 2
        Me.lblUsuario.Text = "Usuario:"
        '
        'lblClave
        '
        Me.lblClave.AutoSize = True
        Me.lblClave.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClave.Location = New System.Drawing.Point(20, 110)
        Me.lblClave.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClave.Name = "lblClave"
        Me.lblClave.Size = New System.Drawing.Size(40, 15)
        Me.lblClave.TabIndex = 3
        Me.lblClave.Text = "Clave:"
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(83, 105)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(216, 20)
        Me.txtClave.TabIndex = 7
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(83, 77)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(216, 20)
        Me.txtUsuario.TabIndex = 6
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(353, 101)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(99, 23)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(353, 75)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(99, 23)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmConfigBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 179)
        Me.Controls.Add(Me.btnGuardarConexion)
        Me.Controls.Add(Me.btnProbarConexion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(480, 217)
        Me.MinimumSize = New System.Drawing.Size(480, 217)
        Me.Name = "frmConfigBase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración de la conexión"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGuardarConexion As System.Windows.Forms.Button
    Friend WithEvents btnProbarConexion As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBase As System.Windows.Forms.TextBox
    Friend WithEvents lblServidor As System.Windows.Forms.Label
    Friend WithEvents txtServidor As System.Windows.Forms.TextBox
    Friend WithEvents lblBase As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents lblClave As System.Windows.Forms.Label
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
