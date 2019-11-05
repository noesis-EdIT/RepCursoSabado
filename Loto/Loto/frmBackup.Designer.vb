<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBackup))
        Me.gbBackup = New System.Windows.Forms.GroupBox()
        Me.txtDescrip_Backup = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnMostrarArchivo = New System.Windows.Forms.Button()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.btnExaminar = New System.Windows.Forms.Button()
        Me.lblDirectorio = New System.Windows.Forms.Label()
        Me.txtDirPathBackup = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.gbRestaurar = New System.Windows.Forms.GroupBox()
        Me.btnExaminarRes = New System.Windows.Forms.Button()
        Me.txtServidorRest = New System.Windows.Forms.TextBox()
        Me.lblServidorSql = New System.Windows.Forms.Label()
        Me.txtBackup = New System.Windows.Forms.TextBox()
        Me.lblBackupRestore = New System.Windows.Forms.Label()
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.txtBaseRest = New System.Windows.Forms.TextBox()
        Me.lblBaseRestore = New System.Windows.Forms.Label()
        Me.gbBackup.SuspendLayout()
        Me.gbRestaurar.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbBackup
        '
        Me.gbBackup.BackColor = System.Drawing.Color.Transparent
        Me.gbBackup.Controls.Add(Me.txtDescrip_Backup)
        Me.gbBackup.Controls.Add(Me.Label5)
        Me.gbBackup.Controls.Add(Me.btnMostrarArchivo)
        Me.gbBackup.Controls.Add(Me.btnBackup)
        Me.gbBackup.Controls.Add(Me.btnExaminar)
        Me.gbBackup.Controls.Add(Me.lblDirectorio)
        Me.gbBackup.Controls.Add(Me.txtDirPathBackup)
        Me.gbBackup.Location = New System.Drawing.Point(15, 21)
        Me.gbBackup.Name = "gbBackup"
        Me.gbBackup.Size = New System.Drawing.Size(548, 171)
        Me.gbBackup.TabIndex = 0
        Me.gbBackup.TabStop = False
        Me.gbBackup.Text = "Backup"
        '
        'txtDescrip_Backup
        '
        Me.txtDescrip_Backup.Location = New System.Drawing.Point(98, 51)
        Me.txtDescrip_Backup.MaxLength = 100
        Me.txtDescrip_Backup.Multiline = True
        Me.txtDescrip_Backup.Name = "txtDescrip_Backup"
        Me.txtDescrip_Backup.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescrip_Backup.Size = New System.Drawing.Size(374, 62)
        Me.txtDescrip_Backup.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(10, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 31)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Observación (opcional):"
        '
        'btnMostrarArchivo
        '
        Me.btnMostrarArchivo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnMostrarArchivo.Enabled = False
        Me.btnMostrarArchivo.Location = New System.Drawing.Point(258, 130)
        Me.btnMostrarArchivo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMostrarArchivo.Name = "btnMostrarArchivo"
        Me.btnMostrarArchivo.Size = New System.Drawing.Size(93, 27)
        Me.btnMostrarArchivo.TabIndex = 37
        Me.btnMostrarArchivo.Text = "Mostrar archivo"
        Me.btnMostrarArchivo.UseVisualStyleBackColor = True
        '
        'btnBackup
        '
        Me.btnBackup.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBackup.Location = New System.Drawing.Point(161, 130)
        Me.btnBackup.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(93, 27)
        Me.btnBackup.TabIndex = 24
        Me.btnBackup.Text = "Crear Backup"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'btnExaminar
        '
        Me.btnExaminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExaminar.Location = New System.Drawing.Point(483, 25)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(58, 23)
        Me.btnExaminar.TabIndex = 3
        Me.btnExaminar.Text = "Examinar"
        Me.btnExaminar.UseVisualStyleBackColor = True
        '
        'lblDirectorio
        '
        Me.lblDirectorio.AutoSize = True
        Me.lblDirectorio.Location = New System.Drawing.Point(10, 31)
        Me.lblDirectorio.Name = "lblDirectorio"
        Me.lblDirectorio.Size = New System.Drawing.Size(55, 13)
        Me.lblDirectorio.TabIndex = 35
        Me.lblDirectorio.Text = "Directorio:"
        '
        'txtDirPathBackup
        '
        Me.txtDirPathBackup.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtDirPathBackup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDirPathBackup.Location = New System.Drawing.Point(65, 25)
        Me.txtDirPathBackup.Name = "txtDirPathBackup"
        Me.txtDirPathBackup.ReadOnly = True
        Me.txtDirPathBackup.Size = New System.Drawing.Size(404, 20)
        Me.txtDirPathBackup.TabIndex = 36
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(219, 346)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(93, 27)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'gbRestaurar
        '
        Me.gbRestaurar.BackColor = System.Drawing.Color.Transparent
        Me.gbRestaurar.Controls.Add(Me.btnExaminarRes)
        Me.gbRestaurar.Controls.Add(Me.txtServidorRest)
        Me.gbRestaurar.Controls.Add(Me.lblServidorSql)
        Me.gbRestaurar.Controls.Add(Me.txtBackup)
        Me.gbRestaurar.Controls.Add(Me.lblBackupRestore)
        Me.gbRestaurar.Controls.Add(Me.btnRestore)
        Me.gbRestaurar.Controls.Add(Me.txtBaseRest)
        Me.gbRestaurar.Controls.Add(Me.lblBaseRestore)
        Me.gbRestaurar.Location = New System.Drawing.Point(15, 198)
        Me.gbRestaurar.Name = "gbRestaurar"
        Me.gbRestaurar.Size = New System.Drawing.Size(472, 140)
        Me.gbRestaurar.TabIndex = 1
        Me.gbRestaurar.TabStop = False
        Me.gbRestaurar.Text = "Restauración"
        '
        'btnExaminarRes
        '
        Me.btnExaminarRes.Location = New System.Drawing.Point(402, 76)
        Me.btnExaminarRes.Name = "btnExaminarRes"
        Me.btnExaminarRes.Size = New System.Drawing.Size(63, 23)
        Me.btnExaminarRes.TabIndex = 14
        Me.btnExaminarRes.Text = "Examinar"
        Me.btnExaminarRes.UseVisualStyleBackColor = True
        '
        'txtServidorRest
        '
        Me.txtServidorRest.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtServidorRest.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtServidorRest.Location = New System.Drawing.Point(109, 26)
        Me.txtServidorRest.Name = "txtServidorRest"
        Me.txtServidorRest.ReadOnly = True
        Me.txtServidorRest.Size = New System.Drawing.Size(287, 20)
        Me.txtServidorRest.TabIndex = 8
        Me.txtServidorRest.Text = "(local)"
        '
        'lblServidorSql
        '
        Me.lblServidorSql.BackColor = System.Drawing.Color.Transparent
        Me.lblServidorSql.Location = New System.Drawing.Point(23, 29)
        Me.lblServidorSql.Name = "lblServidorSql"
        Me.lblServidorSql.Size = New System.Drawing.Size(80, 18)
        Me.lblServidorSql.TabIndex = 7
        Me.lblServidorSql.Text = "Servidor SQL:"
        '
        'txtBackup
        '
        Me.txtBackup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBackup.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtBackup.Location = New System.Drawing.Point(109, 79)
        Me.txtBackup.Name = "txtBackup"
        Me.txtBackup.ReadOnly = True
        Me.txtBackup.Size = New System.Drawing.Size(287, 20)
        Me.txtBackup.TabIndex = 12
        '
        'lblBackupRestore
        '
        Me.lblBackupRestore.BackColor = System.Drawing.Color.Transparent
        Me.lblBackupRestore.Location = New System.Drawing.Point(23, 82)
        Me.lblBackupRestore.Name = "lblBackupRestore"
        Me.lblBackupRestore.Size = New System.Drawing.Size(80, 18)
        Me.lblBackupRestore.TabIndex = 11
        Me.lblBackupRestore.Text = "Backup:"
        '
        'btnRestore
        '
        Me.btnRestore.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestore.Location = New System.Drawing.Point(203, 105)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(94, 27)
        Me.btnRestore.TabIndex = 13
        Me.btnRestore.Text = "Restaurar base"
        Me.btnRestore.UseVisualStyleBackColor = True
        '
        'txtBaseRest
        '
        Me.txtBaseRest.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBaseRest.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtBaseRest.Location = New System.Drawing.Point(109, 52)
        Me.txtBaseRest.Name = "txtBaseRest"
        Me.txtBaseRest.ReadOnly = True
        Me.txtBaseRest.Size = New System.Drawing.Size(287, 20)
        Me.txtBaseRest.TabIndex = 10
        '
        'lblBaseRestore
        '
        Me.lblBaseRestore.BackColor = System.Drawing.Color.Transparent
        Me.lblBaseRestore.Location = New System.Drawing.Point(23, 55)
        Me.lblBaseRestore.Name = "lblBaseRestore"
        Me.lblBaseRestore.Size = New System.Drawing.Size(80, 18)
        Me.lblBaseRestore.TabIndex = 9
        Me.lblBaseRestore.Text = "Base datos:"
        '
        'frmBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(577, 383)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.gbRestaurar)
        Me.Controls.Add(Me.gbBackup)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(593, 421)
        Me.MinimumSize = New System.Drawing.Size(593, 421)
        Me.Name = "frmBackup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Backup / Restore"
        Me.gbBackup.ResumeLayout(False)
        Me.gbBackup.PerformLayout()
        Me.gbRestaurar.ResumeLayout(False)
        Me.gbRestaurar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbBackup As System.Windows.Forms.GroupBox
    Friend WithEvents btnExaminar As System.Windows.Forms.Button
    Friend WithEvents lblDirectorio As System.Windows.Forms.Label
    Friend WithEvents txtDirPathBackup As System.Windows.Forms.TextBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents gbRestaurar As System.Windows.Forms.GroupBox
    Friend WithEvents btnExaminarRes As System.Windows.Forms.Button
    Friend WithEvents txtServidorRest As System.Windows.Forms.TextBox
    Friend WithEvents lblServidorSql As System.Windows.Forms.Label
    Friend WithEvents txtBackup As System.Windows.Forms.TextBox
    Friend WithEvents lblBackupRestore As System.Windows.Forms.Label
    Private WithEvents btnRestore As System.Windows.Forms.Button
    Friend WithEvents txtBaseRest As System.Windows.Forms.TextBox
    Friend WithEvents lblBaseRestore As System.Windows.Forms.Label
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents btnMostrarArchivo As System.Windows.Forms.Button
    Friend WithEvents txtDescrip_Backup As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
