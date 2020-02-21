<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarJugada
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarJugada))
        Me.lvBuscarJugada = New System.Windows.Forms.ListView()
        Me.erpBuscarJugada = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tmrDesplazarGb1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlBuscarContenido = New System.Windows.Forms.Panel()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.rbUltimoSorteo = New System.Windows.Forms.RadioButton()
        Me.rbPrimerSorteo = New System.Windows.Forms.RadioButton()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mtbBuscar = New System.Windows.Forms.MaskedTextBox()
        Me.tmrDesplazarGb2 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlBuscarNumJugada = New System.Windows.Forms.Panel()
        Me.txtNumSorteo2 = New System.Windows.Forms.TextBox()
        Me.chkUltimoSorteo = New System.Windows.Forms.CheckBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.picTeclado = New System.Windows.Forms.PictureBox()
        Me.txtNumSorteo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlTeclado = New System.Windows.Forms.Panel()
        Me.btnCambiarBusqueda = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.UsrTecladoVirtual1 = New Loto.usrTecladoVirtual()
        CType(Me.erpBuscarJugada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBuscarContenido.SuspendLayout()
        Me.pnlBuscarNumJugada.SuspendLayout()
        CType(Me.picTeclado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTeclado.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvBuscarJugada
        '
        Me.lvBuscarJugada.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lvBuscarJugada.FullRowSelect = True
        Me.lvBuscarJugada.Location = New System.Drawing.Point(316, 25)
        Me.lvBuscarJugada.Name = "lvBuscarJugada"
        Me.lvBuscarJugada.Size = New System.Drawing.Size(438, 501)
        Me.lvBuscarJugada.TabIndex = 43
        Me.lvBuscarJugada.UseCompatibleStateImageBehavior = False
        '
        'erpBuscarJugada
        '
        Me.erpBuscarJugada.ContainerControl = Me
        '
        'tmrDesplazarGb1
        '
        '
        'pnlBuscarContenido
        '
        Me.pnlBuscarContenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBuscarContenido.Controls.Add(Me.dtpHasta)
        Me.pnlBuscarContenido.Controls.Add(Me.rbUltimoSorteo)
        Me.pnlBuscarContenido.Controls.Add(Me.rbPrimerSorteo)
        Me.pnlBuscarContenido.Controls.Add(Me.dtpDesde)
        Me.pnlBuscarContenido.Controls.Add(Me.lblHasta)
        Me.pnlBuscarContenido.Controls.Add(Me.lblDesde)
        Me.pnlBuscarContenido.Controls.Add(Me.Label2)
        Me.pnlBuscarContenido.Controls.Add(Me.mtbBuscar)
        Me.pnlBuscarContenido.Location = New System.Drawing.Point(17, 25)
        Me.pnlBuscarContenido.Name = "pnlBuscarContenido"
        Me.pnlBuscarContenido.Size = New System.Drawing.Size(272, 180)
        Me.pnlBuscarContenido.TabIndex = 0
        '
        'dtpHasta
        '
        Me.dtpHasta.CausesValidation = False
        Me.dtpHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(140, 84)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(99, 21)
        Me.dtpHasta.TabIndex = 56
        '
        'rbUltimoSorteo
        '
        Me.rbUltimoSorteo.AutoSize = True
        Me.rbUltimoSorteo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbUltimoSorteo.Location = New System.Drawing.Point(12, 146)
        Me.rbUltimoSorteo.Name = "rbUltimoSorteo"
        Me.rbUltimoSorteo.Size = New System.Drawing.Size(187, 19)
        Me.rbUltimoSorteo.TabIndex = 57
        Me.rbUltimoSorteo.TabStop = True
        Me.rbUltimoSorteo.Text = "Buscar desde el último sorteo"
        Me.rbUltimoSorteo.UseVisualStyleBackColor = True
        '
        'rbPrimerSorteo
        '
        Me.rbPrimerSorteo.AutoSize = True
        Me.rbPrimerSorteo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPrimerSorteo.Location = New System.Drawing.Point(12, 121)
        Me.rbPrimerSorteo.Name = "rbPrimerSorteo"
        Me.rbPrimerSorteo.Size = New System.Drawing.Size(189, 19)
        Me.rbPrimerSorteo.TabIndex = 54
        Me.rbPrimerSorteo.TabStop = True
        Me.rbPrimerSorteo.Text = "Buscar desde el primer sorteo"
        Me.rbPrimerSorteo.UseVisualStyleBackColor = True
        '
        'dtpDesde
        '
        Me.dtpDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(11, 84)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(99, 21)
        Me.dtpDesde.TabIndex = 55
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.BackColor = System.Drawing.Color.Transparent
        Me.lblHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasta.Location = New System.Drawing.Point(140, 70)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(42, 15)
        Me.lblHasta.TabIndex = 50
        Me.lblHasta.Text = "Hasta:"
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.BackColor = System.Drawing.Color.Transparent
        Me.lblDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesde.Location = New System.Drawing.Point(12, 70)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(46, 15)
        Me.lblDesde.TabIndex = 51
        Me.lblDesde.Text = "Desde:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 15)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Contenido a buscar:"
        '
        'mtbBuscar
        '
        Me.mtbBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbBuscar.Location = New System.Drawing.Point(12, 34)
        Me.mtbBuscar.Mask = "00-00-00-00-00-00"
        Me.mtbBuscar.Name = "mtbBuscar"
        Me.mtbBuscar.Size = New System.Drawing.Size(109, 22)
        Me.mtbBuscar.TabIndex = 49
        '
        'tmrDesplazarGb2
        '
        '
        'pnlBuscarNumJugada
        '
        Me.pnlBuscarNumJugada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBuscarNumJugada.Controls.Add(Me.txtNumSorteo2)
        Me.pnlBuscarNumJugada.Controls.Add(Me.chkUltimoSorteo)
        Me.pnlBuscarNumJugada.Controls.Add(Me.txtFecha)
        Me.pnlBuscarNumJugada.Controls.Add(Me.picTeclado)
        Me.pnlBuscarNumJugada.Controls.Add(Me.txtNumSorteo)
        Me.pnlBuscarNumJugada.Controls.Add(Me.Label1)
        Me.pnlBuscarNumJugada.Location = New System.Drawing.Point(17, 25)
        Me.pnlBuscarNumJugada.Name = "pnlBuscarNumJugada"
        Me.pnlBuscarNumJugada.Size = New System.Drawing.Size(272, 180)
        Me.pnlBuscarNumJugada.TabIndex = 44
        Me.pnlBuscarNumJugada.Visible = False
        '
        'txtNumSorteo2
        '
        Me.txtNumSorteo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumSorteo2.Location = New System.Drawing.Point(98, 46)
        Me.txtNumSorteo2.MaxLength = 5
        Me.txtNumSorteo2.Name = "txtNumSorteo2"
        Me.txtNumSorteo2.Size = New System.Drawing.Size(78, 21)
        Me.txtNumSorteo2.TabIndex = 115
        '
        'chkUltimoSorteo
        '
        Me.chkUltimoSorteo.Location = New System.Drawing.Point(12, 146)
        Me.chkUltimoSorteo.Name = "chkUltimoSorteo"
        Me.chkUltimoSorteo.Size = New System.Drawing.Size(168, 17)
        Me.chkUltimoSorteo.TabIndex = 114
        Me.chkUltimoSorteo.Text = "Buscar el último nº de sorteo"
        Me.chkUltimoSorteo.UseVisualStyleBackColor = True
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.SystemColors.Window
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(15, 70)
        Me.txtFecha.MaxLength = 5
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(78, 21)
        Me.txtFecha.TabIndex = 113
        '
        'picTeclado
        '
        Me.picTeclado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picTeclado.Image = CType(resources.GetObject("picTeclado.Image"), System.Drawing.Image)
        Me.picTeclado.Location = New System.Drawing.Point(181, 40)
        Me.picTeclado.Name = "picTeclado"
        Me.picTeclado.Size = New System.Drawing.Size(41, 27)
        Me.picTeclado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTeclado.TabIndex = 111
        Me.picTeclado.TabStop = False
        '
        'txtNumSorteo
        '
        Me.txtNumSorteo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumSorteo.Location = New System.Drawing.Point(15, 46)
        Me.txtNumSorteo.MaxLength = 5
        Me.txtNumSorteo.Name = "txtNumSorteo"
        Me.txtNumSorteo.Size = New System.Drawing.Size(78, 21)
        Me.txtNumSorteo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nº de jugada:"
        '
        'pnlTeclado
        '
        Me.pnlTeclado.Controls.Add(Me.UsrTecladoVirtual1)
        Me.pnlTeclado.Location = New System.Drawing.Point(17, 296)
        Me.pnlTeclado.Name = "pnlTeclado"
        Me.pnlTeclado.Size = New System.Drawing.Size(187, 234)
        Me.pnlTeclado.TabIndex = 51
        Me.pnlTeclado.Visible = False
        '
        'btnCambiarBusqueda
        '
        Me.btnCambiarBusqueda.Location = New System.Drawing.Point(179, 226)
        Me.btnCambiarBusqueda.Name = "btnCambiarBusqueda"
        Me.btnCambiarBusqueda.Size = New System.Drawing.Size(110, 48)
        Me.btnCambiarBusqueda.TabIndex = 50
        Me.btnCambiarBusqueda.Text = "Cambiar a buscar por nº de jugada"
        Me.btnCambiarBusqueda.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(98, 226)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 47
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Enabled = False
        Me.btnModificar.Location = New System.Drawing.Point(17, 251)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 48
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(98, 251)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 49
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(17, 226)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 46
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'UsrTecladoVirtual1
        '
        Me.UsrTecladoVirtual1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UsrTecladoVirtual1.Location = New System.Drawing.Point(5, 5)
        Me.UsrTecladoVirtual1.Name = "UsrTecladoVirtual1"
        Me.UsrTecladoVirtual1.Size = New System.Drawing.Size(176, 225)
        Me.UsrTecladoVirtual1.TabIndex = 44
        Me.UsrTecladoVirtual1.TeclaPulsada = Nothing
        Me.UsrTecladoVirtual1.Visible = False
        '
        'frmBuscarJugada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(801, 555)
        Me.Controls.Add(Me.pnlTeclado)
        Me.Controls.Add(Me.btnCambiarBusqueda)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.pnlBuscarNumJugada)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.pnlBuscarContenido)
        Me.Controls.Add(Me.lvBuscarJugada)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(817, 593)
        Me.MinimumSize = New System.Drawing.Size(817, 593)
        Me.Name = "frmBuscarJugada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar jugada"
        CType(Me.erpBuscarJugada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBuscarContenido.ResumeLayout(False)
        Me.pnlBuscarContenido.PerformLayout()
        Me.pnlBuscarNumJugada.ResumeLayout(False)
        Me.pnlBuscarNumJugada.PerformLayout()
        CType(Me.picTeclado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTeclado.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvBuscarJugada As System.Windows.Forms.ListView
    Friend WithEvents erpBuscarJugada As System.Windows.Forms.ErrorProvider
    Friend WithEvents tmrDesplazarGb1 As System.Windows.Forms.Timer
    Friend WithEvents pnlBuscarContenido As System.Windows.Forms.Panel
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbUltimoSorteo As System.Windows.Forms.RadioButton
    Friend WithEvents rbPrimerSorteo As System.Windows.Forms.RadioButton
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents lblDesde As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mtbBuscar As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tmrDesplazarGb2 As System.Windows.Forms.Timer
    Friend WithEvents pnlTeclado As System.Windows.Forms.Panel
    Friend WithEvents UsrTecladoVirtual1 As Loto.usrTecladoVirtual
    Friend WithEvents btnCambiarBusqueda As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents pnlBuscarNumJugada As System.Windows.Forms.Panel
    Friend WithEvents chkUltimoSorteo As System.Windows.Forms.CheckBox
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents picTeclado As System.Windows.Forms.PictureBox
    Friend WithEvents txtNumSorteo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumSorteo2 As System.Windows.Forms.TextBox
End Class
