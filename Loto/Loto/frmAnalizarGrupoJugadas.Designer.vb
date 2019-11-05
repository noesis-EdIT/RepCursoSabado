<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnalizarGrupoJugadas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnalizarGrupoJugadas))
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.cbxDosConsecutivos = New System.Windows.Forms.ComboBox()
        Me.cbxMasFrecuentes = New System.Windows.Forms.ComboBox()
        Me.lblMasFrecuentes = New System.Windows.Forms.Label()
        Me.cbxTerminacion = New System.Windows.Forms.ComboBox()
        Me.cbxNumSorteoAnterior = New System.Windows.Forms.ComboBox()
        Me.txtCantNumerosPrimos = New System.Windows.Forms.TextBox()
        Me.txtDiferenciaMinMax = New System.Windows.Forms.TextBox()
        Me.txtSumatoria = New System.Windows.Forms.TextBox()
        Me.txtCantUnDigito = New System.Windows.Forms.TextBox()
        Me.txtCantPares = New System.Windows.Forms.TextBox()
        Me.lblCantNumerosPrimos = New System.Windows.Forms.Label()
        Me.lblDiferenciaMinMax = New System.Windows.Forms.Label()
        Me.lblSumatoria = New System.Windows.Forms.Label()
        Me.lblDosConsecutivos = New System.Windows.Forms.Label()
        Me.lblCantUnDigito = New System.Windows.Forms.Label()
        Me.lblNumSorteoAnterior = New System.Windows.Forms.Label()
        Me.lblTerminacion = New System.Windows.Forms.Label()
        Me.lblCantPares = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.chlSorteos = New System.Windows.Forms.CheckedListBox()
        Me.btnAnalizarJugada = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxMenosFrecuentes = New System.Windows.Forms.ComboBox()
        Me.lblMenosFrecuentes = New System.Windows.Forms.Label()
        Me.pnlAnalizarVariasJugadas = New System.Windows.Forms.Panel()
        Me.txtNumSorteoDesde = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.erpAnalizarVariasJugadas = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtNumSorteoHasta = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.pnlAnalizarVariasJugadas.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.erpAnalizarVariasJugadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.BackColor = System.Drawing.Color.Transparent
        Me.lblDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesde.Location = New System.Drawing.Point(30, 13)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(41, 13)
        Me.lblDesde.TabIndex = 70
        Me.lblDesde.Text = "Desde:"
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaHasta.Location = New System.Drawing.Point(124, 29)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(88, 21)
        Me.dtpFechaHasta.TabIndex = 69
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDesde.Location = New System.Drawing.Point(30, 29)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(88, 21)
        Me.dtpFechaDesde.TabIndex = 68
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.BackColor = System.Drawing.Color.Transparent
        Me.lblHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasta.Location = New System.Drawing.Point(121, 13)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(38, 13)
        Me.lblHasta.TabIndex = 71
        Me.lblHasta.Text = "Hasta:"
        '
        'cbxDosConsecutivos
        '
        Me.cbxDosConsecutivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDosConsecutivos.FormattingEnabled = True
        Me.cbxDosConsecutivos.Location = New System.Drawing.Point(270, 154)
        Me.cbxDosConsecutivos.Name = "cbxDosConsecutivos"
        Me.cbxDosConsecutivos.Size = New System.Drawing.Size(83, 21)
        Me.cbxDosConsecutivos.TabIndex = 89
        '
        'cbxMasFrecuentes
        '
        Me.cbxMasFrecuentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMasFrecuentes.FormattingEnabled = True
        Me.cbxMasFrecuentes.Location = New System.Drawing.Point(270, 16)
        Me.cbxMasFrecuentes.Name = "cbxMasFrecuentes"
        Me.cbxMasFrecuentes.Size = New System.Drawing.Size(42, 21)
        Me.cbxMasFrecuentes.TabIndex = 88
        '
        'lblMasFrecuentes
        '
        Me.lblMasFrecuentes.AutoSize = True
        Me.lblMasFrecuentes.BackColor = System.Drawing.Color.Transparent
        Me.lblMasFrecuentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMasFrecuentes.Location = New System.Drawing.Point(10, 22)
        Me.lblMasFrecuentes.Name = "lblMasFrecuentes"
        Me.lblMasFrecuentes.Size = New System.Drawing.Size(148, 15)
        Me.lblMasFrecuentes.TabIndex = 87
        Me.lblMasFrecuentes.Text = "Números más frecuentes:"
        '
        'cbxTerminacion
        '
        Me.cbxTerminacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTerminacion.FormattingEnabled = True
        Me.cbxTerminacion.Location = New System.Drawing.Point(270, 86)
        Me.cbxTerminacion.Name = "cbxTerminacion"
        Me.cbxTerminacion.Size = New System.Drawing.Size(43, 21)
        Me.cbxTerminacion.TabIndex = 86
        '
        'cbxNumSorteoAnterior
        '
        Me.cbxNumSorteoAnterior.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxNumSorteoAnterior.FormattingEnabled = True
        Me.cbxNumSorteoAnterior.Location = New System.Drawing.Point(270, 109)
        Me.cbxNumSorteoAnterior.Name = "cbxNumSorteoAnterior"
        Me.cbxNumSorteoAnterior.Size = New System.Drawing.Size(43, 21)
        Me.cbxNumSorteoAnterior.TabIndex = 85
        '
        'txtCantNumerosPrimos
        '
        Me.txtCantNumerosPrimos.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantNumerosPrimos.Location = New System.Drawing.Point(270, 222)
        Me.txtCantNumerosPrimos.MaxLength = 20
        Me.txtCantNumerosPrimos.Name = "txtCantNumerosPrimos"
        Me.txtCantNumerosPrimos.ReadOnly = True
        Me.txtCantNumerosPrimos.Size = New System.Drawing.Size(64, 20)
        Me.txtCantNumerosPrimos.TabIndex = 84
        Me.txtCantNumerosPrimos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDiferenciaMinMax
        '
        Me.txtDiferenciaMinMax.BackColor = System.Drawing.SystemColors.Window
        Me.txtDiferenciaMinMax.Location = New System.Drawing.Point(270, 200)
        Me.txtDiferenciaMinMax.MaxLength = 20
        Me.txtDiferenciaMinMax.Name = "txtDiferenciaMinMax"
        Me.txtDiferenciaMinMax.ReadOnly = True
        Me.txtDiferenciaMinMax.Size = New System.Drawing.Size(43, 20)
        Me.txtDiferenciaMinMax.TabIndex = 83
        Me.txtDiferenciaMinMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSumatoria
        '
        Me.txtSumatoria.BackColor = System.Drawing.SystemColors.Window
        Me.txtSumatoria.Location = New System.Drawing.Point(270, 177)
        Me.txtSumatoria.MaxLength = 20
        Me.txtSumatoria.Name = "txtSumatoria"
        Me.txtSumatoria.ReadOnly = True
        Me.txtSumatoria.Size = New System.Drawing.Size(83, 20)
        Me.txtSumatoria.TabIndex = 82
        Me.txtSumatoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCantUnDigito
        '
        Me.txtCantUnDigito.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantUnDigito.Location = New System.Drawing.Point(270, 132)
        Me.txtCantUnDigito.MaxLength = 20
        Me.txtCantUnDigito.Name = "txtCantUnDigito"
        Me.txtCantUnDigito.ReadOnly = True
        Me.txtCantUnDigito.Size = New System.Drawing.Size(64, 20)
        Me.txtCantUnDigito.TabIndex = 81
        Me.txtCantUnDigito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCantPares
        '
        Me.txtCantPares.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantPares.Location = New System.Drawing.Point(270, 64)
        Me.txtCantPares.MaxLength = 20
        Me.txtCantPares.Name = "txtCantPares"
        Me.txtCantPares.ReadOnly = True
        Me.txtCantPares.Size = New System.Drawing.Size(64, 20)
        Me.txtCantPares.TabIndex = 80
        Me.txtCantPares.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCantNumerosPrimos
        '
        Me.lblCantNumerosPrimos.AutoSize = True
        Me.lblCantNumerosPrimos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantNumerosPrimos.Location = New System.Drawing.Point(10, 226)
        Me.lblCantNumerosPrimos.Name = "lblCantNumerosPrimos"
        Me.lblCantNumerosPrimos.Size = New System.Drawing.Size(241, 15)
        Me.lblCantNumerosPrimos.TabIndex = 79
        Me.lblCantNumerosPrimos.Text = "Promedio de nros. primos en los 3 sorteos:"
        '
        'lblDiferenciaMinMax
        '
        Me.lblDiferenciaMinMax.AutoSize = True
        Me.lblDiferenciaMinMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiferenciaMinMax.Location = New System.Drawing.Point(10, 202)
        Me.lblDiferenciaMinMax.Name = "lblDiferenciaMinMax"
        Me.lblDiferenciaMinMax.Size = New System.Drawing.Size(217, 15)
        Me.lblDiferenciaMinMax.TabIndex = 78
        Me.lblDiferenciaMinMax.Text = "Dif. mín. y máx. entre núms. contiguos:"
        '
        'lblSumatoria
        '
        Me.lblSumatoria.AutoSize = True
        Me.lblSumatoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSumatoria.Location = New System.Drawing.Point(10, 181)
        Me.lblSumatoria.Name = "lblSumatoria"
        Me.lblSumatoria.Size = New System.Drawing.Size(168, 15)
        Me.lblSumatoria.TabIndex = 77
        Me.lblSumatoria.Text = "Promedio sumatoria sorteo/s:"
        '
        'lblDosConsecutivos
        '
        Me.lblDosConsecutivos.AutoSize = True
        Me.lblDosConsecutivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDosConsecutivos.Location = New System.Drawing.Point(10, 160)
        Me.lblDosConsecutivos.Name = "lblDosConsecutivos"
        Me.lblDosConsecutivos.Size = New System.Drawing.Size(207, 15)
        Me.lblDosConsecutivos.TabIndex = 76
        Me.lblDosConsecutivos.Text = "2 nros. consecutivos más frecuentes:"
        '
        'lblCantUnDigito
        '
        Me.lblCantUnDigito.AutoSize = True
        Me.lblCantUnDigito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantUnDigito.Location = New System.Drawing.Point(10, 136)
        Me.lblCantUnDigito.Name = "lblCantUnDigito"
        Me.lblCantUnDigito.Size = New System.Drawing.Size(245, 15)
        Me.lblCantUnDigito.TabIndex = 75
        Me.lblCantUnDigito.Text = "Prom. de cantidad de números con 1 dígito:"
        '
        'lblNumSorteoAnterior
        '
        Me.lblNumSorteoAnterior.AutoSize = True
        Me.lblNumSorteoAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumSorteoAnterior.Location = New System.Drawing.Point(10, 114)
        Me.lblNumSorteoAnterior.Name = "lblNumSorteoAnterior"
        Me.lblNumSorteoAnterior.Size = New System.Drawing.Size(141, 15)
        Me.lblNumSorteoAnterior.TabIndex = 74
        Me.lblNumSorteoAnterior.Text = "Nros. del sorteo anterior:"
        '
        'lblTerminacion
        '
        Me.lblTerminacion.AutoSize = True
        Me.lblTerminacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTerminacion.Location = New System.Drawing.Point(10, 92)
        Me.lblTerminacion.Name = "lblTerminacion"
        Me.lblTerminacion.Size = New System.Drawing.Size(154, 15)
        Me.lblTerminacion.TabIndex = 73
        Me.lblTerminacion.Text = "Terminación más repetida:"
        '
        'lblCantPares
        '
        Me.lblCantPares.AutoSize = True
        Me.lblCantPares.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantPares.Location = New System.Drawing.Point(10, 69)
        Me.lblCantPares.Name = "lblCantPares"
        Me.lblCantPares.Size = New System.Drawing.Size(165, 15)
        Me.lblCantPares.TabIndex = 72
        Me.lblCantPares.Text = "Promedio cantidad de pares:"
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(5, 40)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 28)
        Me.btnCerrar.TabIndex = 92
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'chlSorteos
        '
        Me.chlSorteos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chlSorteos.FormattingEnabled = True
        Me.chlSorteos.Items.AddRange(New Object() {"Tradicional", "Desquite", "S.O.S."})
        Me.chlSorteos.Location = New System.Drawing.Point(22, 348)
        Me.chlSorteos.Name = "chlSorteos"
        Me.chlSorteos.Size = New System.Drawing.Size(93, 55)
        Me.chlSorteos.TabIndex = 91
        '
        'btnAnalizarJugada
        '
        Me.btnAnalizarJugada.BackColor = System.Drawing.Color.Transparent
        Me.btnAnalizarJugada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnalizarJugada.Location = New System.Drawing.Point(5, 10)
        Me.btnAnalizarJugada.Name = "btnAnalizarJugada"
        Me.btnAnalizarJugada.Size = New System.Drawing.Size(75, 28)
        Me.btnAnalizarJugada.TabIndex = 90
        Me.btnAnalizarJugada.Text = "Analizar"
        Me.btnAnalizarJugada.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cbxMenosFrecuentes)
        Me.GroupBox1.Controls.Add(Me.lblMenosFrecuentes)
        Me.GroupBox1.Controls.Add(Me.cbxDosConsecutivos)
        Me.GroupBox1.Controls.Add(Me.cbxMasFrecuentes)
        Me.GroupBox1.Controls.Add(Me.lblMasFrecuentes)
        Me.GroupBox1.Controls.Add(Me.cbxTerminacion)
        Me.GroupBox1.Controls.Add(Me.cbxNumSorteoAnterior)
        Me.GroupBox1.Controls.Add(Me.txtCantNumerosPrimos)
        Me.GroupBox1.Controls.Add(Me.txtDiferenciaMinMax)
        Me.GroupBox1.Controls.Add(Me.txtSumatoria)
        Me.GroupBox1.Controls.Add(Me.txtCantUnDigito)
        Me.GroupBox1.Controls.Add(Me.txtCantPares)
        Me.GroupBox1.Controls.Add(Me.lblCantNumerosPrimos)
        Me.GroupBox1.Controls.Add(Me.lblDiferenciaMinMax)
        Me.GroupBox1.Controls.Add(Me.lblSumatoria)
        Me.GroupBox1.Controls.Add(Me.lblDosConsecutivos)
        Me.GroupBox1.Controls.Add(Me.lblCantUnDigito)
        Me.GroupBox1.Controls.Add(Me.lblNumSorteoAnterior)
        Me.GroupBox1.Controls.Add(Me.lblTerminacion)
        Me.GroupBox1.Controls.Add(Me.lblCantPares)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 253)
        Me.GroupBox1.TabIndex = 93
        Me.GroupBox1.TabStop = False
        '
        'cbxMenosFrecuentes
        '
        Me.cbxMenosFrecuentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMenosFrecuentes.FormattingEnabled = True
        Me.cbxMenosFrecuentes.Location = New System.Drawing.Point(271, 40)
        Me.cbxMenosFrecuentes.Name = "cbxMenosFrecuentes"
        Me.cbxMenosFrecuentes.Size = New System.Drawing.Size(42, 21)
        Me.cbxMenosFrecuentes.TabIndex = 93
        '
        'lblMenosFrecuentes
        '
        Me.lblMenosFrecuentes.AutoSize = True
        Me.lblMenosFrecuentes.BackColor = System.Drawing.Color.Transparent
        Me.lblMenosFrecuentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenosFrecuentes.Location = New System.Drawing.Point(10, 46)
        Me.lblMenosFrecuentes.Name = "lblMenosFrecuentes"
        Me.lblMenosFrecuentes.Size = New System.Drawing.Size(162, 15)
        Me.lblMenosFrecuentes.TabIndex = 92
        Me.lblMenosFrecuentes.Text = "Números menos frecuentes:"
        '
        'pnlAnalizarVariasJugadas
        '
        Me.pnlAnalizarVariasJugadas.Controls.Add(Me.txtNumSorteoHasta)
        Me.pnlAnalizarVariasJugadas.Controls.Add(Me.txtNumSorteoDesde)
        Me.pnlAnalizarVariasJugadas.Controls.Add(Me.GroupBox2)
        Me.pnlAnalizarVariasJugadas.Controls.Add(Me.dtpFechaDesde)
        Me.pnlAnalizarVariasJugadas.Controls.Add(Me.GroupBox1)
        Me.pnlAnalizarVariasJugadas.Controls.Add(Me.dtpFechaHasta)
        Me.pnlAnalizarVariasJugadas.Controls.Add(Me.lblDesde)
        Me.pnlAnalizarVariasJugadas.Controls.Add(Me.chlSorteos)
        Me.pnlAnalizarVariasJugadas.Controls.Add(Me.lblHasta)
        Me.pnlAnalizarVariasJugadas.Location = New System.Drawing.Point(0, 0)
        Me.pnlAnalizarVariasJugadas.Name = "pnlAnalizarVariasJugadas"
        Me.pnlAnalizarVariasJugadas.Size = New System.Drawing.Size(410, 428)
        Me.pnlAnalizarVariasJugadas.TabIndex = 94
        '
        'txtNumSorteoDesde
        '
        Me.txtNumSorteoDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumSorteoDesde.Location = New System.Drawing.Point(28, 60)
        Me.txtNumSorteoDesde.MaxLength = 5
        Me.txtNumSorteoDesde.Name = "txtNumSorteoDesde"
        Me.txtNumSorteoDesde.Size = New System.Drawing.Size(48, 24)
        Me.txtNumSorteoDesde.TabIndex = 95
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnAnalizarJugada)
        Me.GroupBox2.Controls.Add(Me.btnCerrar)
        Me.GroupBox2.Location = New System.Drawing.Point(134, 341)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(83, 71)
        Me.GroupBox2.TabIndex = 94
        Me.GroupBox2.TabStop = False
        '
        'erpAnalizarVariasJugadas
        '
        Me.erpAnalizarVariasJugadas.ContainerControl = Me
        '
        'txtNumSorteoHasta
        '
        Me.txtNumSorteoHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumSorteoHasta.Location = New System.Drawing.Point(124, 60)
        Me.txtNumSorteoHasta.MaxLength = 5
        Me.txtNumSorteoHasta.Name = "txtNumSorteoHasta"
        Me.txtNumSorteoHasta.Size = New System.Drawing.Size(48, 24)
        Me.txtNumSorteoHasta.TabIndex = 96
        '
        'frmAnalizarGrupoJugadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 427)
        Me.Controls.Add(Me.pnlAnalizarVariasJugadas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAnalizarGrupoJugadas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Analizar grupo de jugadas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlAnalizarVariasJugadas.ResumeLayout(False)
        Me.pnlAnalizarVariasJugadas.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.erpAnalizarVariasJugadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblDesde As System.Windows.Forms.Label
    Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents cbxDosConsecutivos As System.Windows.Forms.ComboBox
    Friend WithEvents cbxMasFrecuentes As System.Windows.Forms.ComboBox
    Friend WithEvents lblMasFrecuentes As System.Windows.Forms.Label
    Friend WithEvents cbxTerminacion As System.Windows.Forms.ComboBox
    Friend WithEvents cbxNumSorteoAnterior As System.Windows.Forms.ComboBox
    Friend WithEvents txtCantNumerosPrimos As System.Windows.Forms.TextBox
    Friend WithEvents txtDiferenciaMinMax As System.Windows.Forms.TextBox
    Friend WithEvents txtSumatoria As System.Windows.Forms.TextBox
    Friend WithEvents txtCantUnDigito As System.Windows.Forms.TextBox
    Friend WithEvents txtCantPares As System.Windows.Forms.TextBox
    Friend WithEvents lblCantNumerosPrimos As System.Windows.Forms.Label
    Friend WithEvents lblDiferenciaMinMax As System.Windows.Forms.Label
    Friend WithEvents lblSumatoria As System.Windows.Forms.Label
    Friend WithEvents lblDosConsecutivos As System.Windows.Forms.Label
    Friend WithEvents lblCantUnDigito As System.Windows.Forms.Label
    Friend WithEvents lblNumSorteoAnterior As System.Windows.Forms.Label
    Friend WithEvents lblTerminacion As System.Windows.Forms.Label
    Friend WithEvents lblCantPares As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents chlSorteos As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnAnalizarJugada As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbxMenosFrecuentes As System.Windows.Forms.ComboBox
    Friend WithEvents lblMenosFrecuentes As System.Windows.Forms.Label
    Friend WithEvents pnlAnalizarVariasJugadas As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents erpAnalizarVariasJugadas As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtNumSorteoDesde As System.Windows.Forms.TextBox
    Friend WithEvents txtNumSorteoHasta As System.Windows.Forms.TextBox
End Class
