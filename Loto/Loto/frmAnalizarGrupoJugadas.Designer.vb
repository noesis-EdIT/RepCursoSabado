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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnalizarGrupoJugadas))
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.cbxDosConsecutivos = New System.Windows.Forms.ComboBox()
        Me.cbxMasFrecuentes = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbxTerminacion = New System.Windows.Forms.ComboBox()
        Me.cbxNumSorteoAnterior = New System.Windows.Forms.ComboBox()
        Me.txtCantNumerosPrimos = New System.Windows.Forms.TextBox()
        Me.txtDiferenciaMinMax = New System.Windows.Forms.TextBox()
        Me.txtSumatoria = New System.Windows.Forms.TextBox()
        Me.txtCantUnDigito = New System.Windows.Forms.TextBox()
        Me.txtCantPares = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.chlSorteos = New System.Windows.Forms.CheckedListBox()
        Me.btnAnalizarJugada = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxMenosFrecuentes = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPromNumerosPrimos = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesde.Location = New System.Drawing.Point(26, 25)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(41, 13)
        Me.lblDesde.TabIndex = 70
        Me.lblDesde.Text = "Desde:"
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaHasta.Location = New System.Drawing.Point(120, 41)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(88, 21)
        Me.dtpFechaHasta.TabIndex = 69
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDesde.Location = New System.Drawing.Point(26, 41)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(88, 21)
        Me.dtpFechaDesde.TabIndex = 68
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasta.Location = New System.Drawing.Point(117, 25)
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
        Me.cbxDosConsecutivos.Size = New System.Drawing.Size(70, 21)
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(10, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 15)
        Me.Label10.TabIndex = 87
        Me.Label10.Text = "Números más frecuentes:"
        '
        'cbxTerminacion
        '
        Me.cbxTerminacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTerminacion.FormattingEnabled = True
        Me.cbxTerminacion.Location = New System.Drawing.Point(270, 86)
        Me.cbxTerminacion.Name = "cbxTerminacion"
        Me.cbxTerminacion.Size = New System.Drawing.Size(42, 21)
        Me.cbxTerminacion.TabIndex = 86
        '
        'cbxNumSorteoAnterior
        '
        Me.cbxNumSorteoAnterior.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxNumSorteoAnterior.FormattingEnabled = True
        Me.cbxNumSorteoAnterior.Location = New System.Drawing.Point(270, 109)
        Me.cbxNumSorteoAnterior.Name = "cbxNumSorteoAnterior"
        Me.cbxNumSorteoAnterior.Size = New System.Drawing.Size(42, 21)
        Me.cbxNumSorteoAnterior.TabIndex = 85
        '
        'txtCantNumerosPrimos
        '
        Me.txtCantNumerosPrimos.Location = New System.Drawing.Point(270, 222)
        Me.txtCantNumerosPrimos.Name = "txtCantNumerosPrimos"
        Me.txtCantNumerosPrimos.Size = New System.Drawing.Size(27, 20)
        Me.txtCantNumerosPrimos.TabIndex = 84
        Me.txtCantNumerosPrimos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDiferenciaMinMax
        '
        Me.txtDiferenciaMinMax.Location = New System.Drawing.Point(270, 200)
        Me.txtDiferenciaMinMax.Name = "txtDiferenciaMinMax"
        Me.txtDiferenciaMinMax.Size = New System.Drawing.Size(42, 20)
        Me.txtDiferenciaMinMax.TabIndex = 83
        Me.txtDiferenciaMinMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSumatoria
        '
        Me.txtSumatoria.Location = New System.Drawing.Point(270, 177)
        Me.txtSumatoria.Name = "txtSumatoria"
        Me.txtSumatoria.Size = New System.Drawing.Size(42, 20)
        Me.txtSumatoria.TabIndex = 82
        Me.txtSumatoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCantUnDigito
        '
        Me.txtCantUnDigito.Location = New System.Drawing.Point(270, 132)
        Me.txtCantUnDigito.Name = "txtCantUnDigito"
        Me.txtCantUnDigito.Size = New System.Drawing.Size(27, 20)
        Me.txtCantUnDigito.TabIndex = 81
        Me.txtCantUnDigito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCantPares
        '
        Me.txtCantPares.Location = New System.Drawing.Point(270, 64)
        Me.txtCantPares.MaxLength = 1
        Me.txtCantPares.Name = "txtCantPares"
        Me.txtCantPares.Size = New System.Drawing.Size(27, 20)
        Me.txtCantPares.TabIndex = 80
        Me.txtCantPares.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(241, 15)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Promedio de nros. primos en los 3 sorteos:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(217, 15)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Dif. mín. y máx. entre núms. contiguos:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(168, 15)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "Promedio sumatoria sorteo/s:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(207, 15)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "2 nros. consecutivos más frecuentes:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(245, 15)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Prom. de cantidad de números con 1 dígito:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 15)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Nros. del sorteo anterior:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 15)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Terminación más repetida:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 15)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Promedio cantidad de pares:"
        '
        'btnCerrar
        '
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(138, 406)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 29)
        Me.btnCerrar.TabIndex = 92
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'chlSorteos
        '
        Me.chlSorteos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chlSorteos.FormattingEnabled = True
        Me.chlSorteos.Items.AddRange(New Object() {"Tradicional", "Desquite", "S.O.S."})
        Me.chlSorteos.Location = New System.Drawing.Point(18, 376)
        Me.chlSorteos.Name = "chlSorteos"
        Me.chlSorteos.Size = New System.Drawing.Size(93, 55)
        Me.chlSorteos.TabIndex = 91
        '
        'btnAnalizarJugada
        '
        Me.btnAnalizarJugada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnalizarJugada.Location = New System.Drawing.Point(138, 376)
        Me.btnAnalizarJugada.Name = "btnAnalizarJugada"
        Me.btnAnalizarJugada.Size = New System.Drawing.Size(75, 29)
        Me.btnAnalizarJugada.TabIndex = 90
        Me.btnAnalizarJugada.Text = "Analizar"
        Me.btnAnalizarJugada.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxMenosFrecuentes)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtPromNumerosPrimos)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cbxDosConsecutivos)
        Me.GroupBox1.Controls.Add(Me.cbxMasFrecuentes)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cbxTerminacion)
        Me.GroupBox1.Controls.Add(Me.cbxNumSorteoAnterior)
        Me.GroupBox1.Controls.Add(Me.txtCantNumerosPrimos)
        Me.GroupBox1.Controls.Add(Me.txtDiferenciaMinMax)
        Me.GroupBox1.Controls.Add(Me.txtSumatoria)
        Me.GroupBox1.Controls.Add(Me.txtCantUnDigito)
        Me.GroupBox1.Controls.Add(Me.txtCantPares)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 283)
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(162, 15)
        Me.Label11.TabIndex = 92
        Me.Label11.Text = "Números menos frecuentes:"
        '
        'txtPromNumerosPrimos
        '
        Me.txtPromNumerosPrimos.Location = New System.Drawing.Point(270, 245)
        Me.txtPromNumerosPrimos.Name = "txtPromNumerosPrimos"
        Me.txtPromNumerosPrimos.Size = New System.Drawing.Size(27, 20)
        Me.txtPromNumerosPrimos.TabIndex = 91
        Me.txtPromNumerosPrimos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 249)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(250, 15)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "Prom. nros. primos para c/u de los 3 sorteos:"
        '
        'frmAnalizarGrupoJugadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 457)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.chlSorteos)
        Me.Controls.Add(Me.btnAnalizarJugada)
        Me.Controls.Add(Me.lblHasta)
        Me.Controls.Add(Me.lblDesde)
        Me.Controls.Add(Me.dtpFechaHasta)
        Me.Controls.Add(Me.dtpFechaDesde)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAnalizarGrupoJugadas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Analizar grupo de jugadas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDesde As System.Windows.Forms.Label
    Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents cbxDosConsecutivos As System.Windows.Forms.ComboBox
    Friend WithEvents cbxMasFrecuentes As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbxTerminacion As System.Windows.Forms.ComboBox
    Friend WithEvents cbxNumSorteoAnterior As System.Windows.Forms.ComboBox
    Friend WithEvents txtCantNumerosPrimos As System.Windows.Forms.TextBox
    Friend WithEvents txtDiferenciaMinMax As System.Windows.Forms.TextBox
    Friend WithEvents txtSumatoria As System.Windows.Forms.TextBox
    Friend WithEvents txtCantUnDigito As System.Windows.Forms.TextBox
    Friend WithEvents txtCantPares As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents chlSorteos As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnAnalizarJugada As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPromNumerosPrimos As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbxMenosFrecuentes As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
