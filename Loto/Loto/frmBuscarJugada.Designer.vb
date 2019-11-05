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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mtbBuscar = New System.Windows.Forms.MaskedTextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lvBuscarJugada = New System.Windows.Forms.ListView()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.rbUltimoSorteo = New System.Windows.Forms.RadioButton()
        Me.txtBusquedaOrdenada = New System.Windows.Forms.TextBox()
        Me.rbPrimerSorteo = New System.Windows.Forms.RadioButton()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.erpBuscarJugada = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.erpBuscarJugada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 15)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Sorteo a buscar:"
        '
        'mtbBuscar
        '
        Me.mtbBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbBuscar.Location = New System.Drawing.Point(22, 44)
        Me.mtbBuscar.Mask = "00-00-00-00-00-00"
        Me.mtbBuscar.Name = "mtbBuscar"
        Me.mtbBuscar.Size = New System.Drawing.Size(109, 22)
        Me.mtbBuscar.TabIndex = 0
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(17, 237)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
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
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(98, 262)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpHasta)
        Me.GroupBox1.Controls.Add(Me.rbUltimoSorteo)
        Me.GroupBox1.Controls.Add(Me.txtBusquedaOrdenada)
        Me.GroupBox1.Controls.Add(Me.rbPrimerSorteo)
        Me.GroupBox1.Controls.Add(Me.dtpDesde)
        Me.GroupBox1.Controls.Add(Me.lblHasta)
        Me.GroupBox1.Controls.Add(Me.lblDesde)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.mtbBuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(289, 200)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'dtpHasta
        '
        Me.dtpHasta.CausesValidation = False
        Me.dtpHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(150, 104)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(99, 21)
        Me.dtpHasta.TabIndex = 48
        '
        'rbUltimoSorteo
        '
        Me.rbUltimoSorteo.AutoSize = True
        Me.rbUltimoSorteo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbUltimoSorteo.Location = New System.Drawing.Point(22, 166)
        Me.rbUltimoSorteo.Name = "rbUltimoSorteo"
        Me.rbUltimoSorteo.Size = New System.Drawing.Size(187, 19)
        Me.rbUltimoSorteo.TabIndex = 48
        Me.rbUltimoSorteo.TabStop = True
        Me.rbUltimoSorteo.Text = "Buscar desde el último sorteo"
        Me.rbUltimoSorteo.UseVisualStyleBackColor = True
        '
        'txtBusquedaOrdenada
        '
        Me.txtBusquedaOrdenada.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtBusquedaOrdenada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBusquedaOrdenada.Enabled = False
        Me.txtBusquedaOrdenada.Location = New System.Drawing.Point(148, 41)
        Me.txtBusquedaOrdenada.MaxLength = 12
        Me.txtBusquedaOrdenada.Multiline = True
        Me.txtBusquedaOrdenada.Name = "txtBusquedaOrdenada"
        Me.txtBusquedaOrdenada.Size = New System.Drawing.Size(127, 24)
        Me.txtBusquedaOrdenada.TabIndex = 43
        '
        'rbPrimerSorteo
        '
        Me.rbPrimerSorteo.AutoSize = True
        Me.rbPrimerSorteo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPrimerSorteo.Location = New System.Drawing.Point(22, 141)
        Me.rbPrimerSorteo.Name = "rbPrimerSorteo"
        Me.rbPrimerSorteo.Size = New System.Drawing.Size(189, 19)
        Me.rbPrimerSorteo.TabIndex = 47
        Me.rbPrimerSorteo.TabStop = True
        Me.rbPrimerSorteo.Text = "Buscar desde el primer sorteo"
        Me.rbPrimerSorteo.UseVisualStyleBackColor = True
        '
        'dtpDesde
        '
        Me.dtpDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(21, 104)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(99, 21)
        Me.dtpDesde.TabIndex = 47
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.BackColor = System.Drawing.Color.Transparent
        Me.lblHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasta.Location = New System.Drawing.Point(150, 90)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(42, 15)
        Me.lblHasta.TabIndex = 13
        Me.lblHasta.Text = "Hasta:"
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.BackColor = System.Drawing.Color.Transparent
        Me.lblDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesde.Location = New System.Drawing.Point(22, 90)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(46, 15)
        Me.lblDesde.TabIndex = 14
        Me.lblDesde.Text = "Desde:"
        '
        'btnModificar
        '
        Me.btnModificar.Enabled = False
        Me.btnModificar.Location = New System.Drawing.Point(17, 262)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 45
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(98, 237)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 46
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'erpBuscarJugada
        '
        Me.erpBuscarJugada.ContainerControl = Me
        '
        'frmBuscarJugada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(801, 555)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.lvBuscarJugada)
        Me.Controls.Add(Me.btnBuscar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(817, 593)
        Me.MinimumSize = New System.Drawing.Size(817, 593)
        Me.Name = "frmBuscarJugada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar jugada"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.erpBuscarJugada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mtbBuscar As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents lvBuscarJugada As System.Windows.Forms.ListView
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents lblDesde As System.Windows.Forms.Label
    Friend WithEvents txtBusquedaOrdenada As System.Windows.Forms.TextBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbUltimoSorteo As System.Windows.Forms.RadioButton
    Friend WithEvents rbPrimerSorteo As System.Windows.Forms.RadioButton
    Friend WithEvents erpBuscarJugada As System.Windows.Forms.ErrorProvider
End Class
