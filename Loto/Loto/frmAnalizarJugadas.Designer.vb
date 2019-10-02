<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnalizarJugadas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnalizarJugadas))
        Me.lblCantidadPares = New System.Windows.Forms.Label()
        Me.lblTerminacionMasRepetida = New System.Windows.Forms.Label()
        Me.lblCantNumerosUnDigito = New System.Windows.Forms.Label()
        Me.lblNumSorteoAnterior = New System.Windows.Forms.Label()
        Me.lblCantidadPrimos = New System.Windows.Forms.Label()
        Me.lblDiferenciasEntreContiguos = New System.Windows.Forms.Label()
        Me.lblSumatoria = New System.Windows.Forms.Label()
        Me.lblAlMenosDosConsecutivos = New System.Windows.Forms.Label()
        Me.txtCantPares = New System.Windows.Forms.TextBox()
        Me.txtCantUnDigito = New System.Windows.Forms.TextBox()
        Me.txtCantNumerosPrimos = New System.Windows.Forms.TextBox()
        Me.txtDiferenciaMinMax = New System.Windows.Forms.TextBox()
        Me.txtSumatoria = New System.Windows.Forms.TextBox()
        Me.lblSorteo = New System.Windows.Forms.Label()
        Me.txtNumSorteo = New System.Windows.Forms.TextBox()
        Me.btnAnalizarJugada = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.txtTra = New System.Windows.Forms.TextBox()
        Me.chlSorteos = New System.Windows.Forms.CheckedListBox()
        Me.txtDes = New System.Windows.Forms.TextBox()
        Me.txtSos = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.cbxNumSorteoAnterior = New System.Windows.Forms.ComboBox()
        Me.cbxTerminacion = New System.Windows.Forms.ComboBox()
        Me.lblNumMasFrecuente = New System.Windows.Forms.Label()
        Me.cbxMasFrecuentes = New System.Windows.Forms.ComboBox()
        Me.cbxDosConsecutivos = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNumMenosFrecuente = New System.Windows.Forms.Label()
        Me.cbxMenosFrecuentes = New System.Windows.Forms.ComboBox()
        Me.picTeclado = New System.Windows.Forms.PictureBox()
        Me.UsrTecladoVirtual1 = New Loto.usrTecladoVirtual()
        Me.lblNota = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picTeclado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCantidadPares
        '
        Me.lblCantidadPares.AutoSize = True
        Me.lblCantidadPares.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadPares.Location = New System.Drawing.Point(17, 69)
        Me.lblCantidadPares.Name = "lblCantidadPares"
        Me.lblCantidadPares.Size = New System.Drawing.Size(110, 15)
        Me.lblCantidadPares.TabIndex = 1
        Me.lblCantidadPares.Text = "Cantidad de pares:"
        '
        'lblTerminacionMasRepetida
        '
        Me.lblTerminacionMasRepetida.AutoSize = True
        Me.lblTerminacionMasRepetida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTerminacionMasRepetida.Location = New System.Drawing.Point(17, 92)
        Me.lblTerminacionMasRepetida.Name = "lblTerminacionMasRepetida"
        Me.lblTerminacionMasRepetida.Size = New System.Drawing.Size(180, 15)
        Me.lblTerminacionMasRepetida.TabIndex = 2
        Me.lblTerminacionMasRepetida.Text = "Terminación que más se repite:"
        '
        'lblCantNumerosUnDigito
        '
        Me.lblCantNumerosUnDigito.AutoSize = True
        Me.lblCantNumerosUnDigito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantNumerosUnDigito.Location = New System.Drawing.Point(17, 136)
        Me.lblCantNumerosUnDigito.Name = "lblCantNumerosUnDigito"
        Me.lblCantNumerosUnDigito.Size = New System.Drawing.Size(194, 15)
        Me.lblCantNumerosUnDigito.TabIndex = 4
        Me.lblCantNumerosUnDigito.Text = "Cantidad de números con 1 dígito:"
        '
        'lblNumSorteoAnterior
        '
        Me.lblNumSorteoAnterior.AutoSize = True
        Me.lblNumSorteoAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumSorteoAnterior.Location = New System.Drawing.Point(17, 114)
        Me.lblNumSorteoAnterior.Name = "lblNumSorteoAnterior"
        Me.lblNumSorteoAnterior.Size = New System.Drawing.Size(208, 15)
        Me.lblNumSorteoAnterior.TabIndex = 3
        Me.lblNumSorteoAnterior.Text = "Incluir un número del sorteo anterior:"
        '
        'lblCantidadPrimos
        '
        Me.lblCantidadPrimos.AutoSize = True
        Me.lblCantidadPrimos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadPrimos.Location = New System.Drawing.Point(17, 226)
        Me.lblCantidadPrimos.Name = "lblCantidadPrimos"
        Me.lblCantidadPrimos.Size = New System.Drawing.Size(169, 15)
        Me.lblCantidadPrimos.TabIndex = 8
        Me.lblCantidadPrimos.Text = "Cantidad de números primos:"
        '
        'lblDiferenciasEntreContiguos
        '
        Me.lblDiferenciasEntreContiguos.AutoSize = True
        Me.lblDiferenciasEntreContiguos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiferenciasEntreContiguos.Location = New System.Drawing.Point(17, 202)
        Me.lblDiferenciasEntreContiguos.Name = "lblDiferenciasEntreContiguos"
        Me.lblDiferenciasEntreContiguos.Size = New System.Drawing.Size(217, 15)
        Me.lblDiferenciasEntreContiguos.TabIndex = 7
        Me.lblDiferenciasEntreContiguos.Text = "Dif. mín. y máx. entre núms. contiguos:"
        '
        'lblSumatoria
        '
        Me.lblSumatoria.AutoSize = True
        Me.lblSumatoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSumatoria.Location = New System.Drawing.Point(17, 181)
        Me.lblSumatoria.Name = "lblSumatoria"
        Me.lblSumatoria.Size = New System.Drawing.Size(113, 15)
        Me.lblSumatoria.TabIndex = 6
        Me.lblSumatoria.Text = "Sumatoria sorteo/s:"
        '
        'lblAlMenosDosConsecutivos
        '
        Me.lblAlMenosDosConsecutivos.AutoSize = True
        Me.lblAlMenosDosConsecutivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlMenosDosConsecutivos.Location = New System.Drawing.Point(17, 160)
        Me.lblAlMenosDosConsecutivos.Name = "lblAlMenosDosConsecutivos"
        Me.lblAlMenosDosConsecutivos.Size = New System.Drawing.Size(196, 15)
        Me.lblAlMenosDosConsecutivos.TabIndex = 5
        Me.lblAlMenosDosConsecutivos.Text = "Al menos 2 números consecutivos:"
        '
        'txtCantPares
        '
        Me.txtCantPares.Location = New System.Drawing.Point(288, 64)
        Me.txtCantPares.MaxLength = 1
        Me.txtCantPares.Name = "txtCantPares"
        Me.txtCantPares.Size = New System.Drawing.Size(36, 20)
        Me.txtCantPares.TabIndex = 18
        Me.txtCantPares.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCantUnDigito
        '
        Me.txtCantUnDigito.Location = New System.Drawing.Point(288, 132)
        Me.txtCantUnDigito.Name = "txtCantUnDigito"
        Me.txtCantUnDigito.Size = New System.Drawing.Size(36, 20)
        Me.txtCantUnDigito.TabIndex = 21
        Me.txtCantUnDigito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCantNumerosPrimos
        '
        Me.txtCantNumerosPrimos.Location = New System.Drawing.Point(288, 222)
        Me.txtCantNumerosPrimos.Name = "txtCantNumerosPrimos"
        Me.txtCantNumerosPrimos.Size = New System.Drawing.Size(36, 20)
        Me.txtCantNumerosPrimos.TabIndex = 25
        Me.txtCantNumerosPrimos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDiferenciaMinMax
        '
        Me.txtDiferenciaMinMax.Location = New System.Drawing.Point(288, 200)
        Me.txtDiferenciaMinMax.Name = "txtDiferenciaMinMax"
        Me.txtDiferenciaMinMax.Size = New System.Drawing.Size(50, 20)
        Me.txtDiferenciaMinMax.TabIndex = 24
        Me.txtDiferenciaMinMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSumatoria
        '
        Me.txtSumatoria.Location = New System.Drawing.Point(288, 177)
        Me.txtSumatoria.Name = "txtSumatoria"
        Me.txtSumatoria.Size = New System.Drawing.Size(50, 20)
        Me.txtSumatoria.TabIndex = 23
        Me.txtSumatoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSorteo
        '
        Me.lblSorteo.AutoSize = True
        Me.lblSorteo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSorteo.Location = New System.Drawing.Point(18, 25)
        Me.lblSorteo.Name = "lblSorteo"
        Me.lblSorteo.Size = New System.Drawing.Size(70, 15)
        Me.lblSorteo.TabIndex = 25
        Me.lblSorteo.Text = "Sorteo nro.:"
        '
        'txtNumSorteo
        '
        Me.txtNumSorteo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumSorteo.Location = New System.Drawing.Point(90, 20)
        Me.txtNumSorteo.MaxLength = 5
        Me.txtNumSorteo.Name = "txtNumSorteo"
        Me.txtNumSorteo.Size = New System.Drawing.Size(48, 24)
        Me.txtNumSorteo.TabIndex = 17
        '
        'btnAnalizarJugada
        '
        Me.btnAnalizarJugada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnalizarJugada.Location = New System.Drawing.Point(250, 349)
        Me.btnAnalizarJugada.Name = "btnAnalizarJugada"
        Me.btnAnalizarJugada.Size = New System.Drawing.Size(75, 29)
        Me.btnAnalizarJugada.TabIndex = 26
        Me.btnAnalizarJugada.Text = "Analizar"
        Me.btnAnalizarJugada.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(284, 20)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(88, 21)
        Me.dtpFecha.TabIndex = 27
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(242, 27)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha.TabIndex = 28
        Me.lblFecha.Text = "Fecha:"
        '
        'txtTra
        '
        Me.txtTra.Location = New System.Drawing.Point(123, 349)
        Me.txtTra.Name = "txtTra"
        Me.txtTra.Size = New System.Drawing.Size(100, 20)
        Me.txtTra.TabIndex = 29
        '
        'chlSorteos
        '
        Me.chlSorteos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chlSorteos.FormattingEnabled = True
        Me.chlSorteos.Items.AddRange(New Object() {"Tradicional", "Desquite", "S.O.S."})
        Me.chlSorteos.Location = New System.Drawing.Point(19, 349)
        Me.chlSorteos.Name = "chlSorteos"
        Me.chlSorteos.Size = New System.Drawing.Size(93, 55)
        Me.chlSorteos.TabIndex = 30
        '
        'txtDes
        '
        Me.txtDes.Location = New System.Drawing.Point(123, 371)
        Me.txtDes.Name = "txtDes"
        Me.txtDes.Size = New System.Drawing.Size(100, 20)
        Me.txtDes.TabIndex = 31
        '
        'txtSos
        '
        Me.txtSos.Location = New System.Drawing.Point(123, 394)
        Me.txtSos.Name = "txtSos"
        Me.txtSos.Size = New System.Drawing.Size(100, 20)
        Me.txtSos.TabIndex = 32
        '
        'btnCerrar
        '
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(250, 379)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 29)
        Me.btnCerrar.TabIndex = 33
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'cbxNumSorteoAnterior
        '
        Me.cbxNumSorteoAnterior.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxNumSorteoAnterior.FormattingEnabled = True
        Me.cbxNumSorteoAnterior.Location = New System.Drawing.Point(288, 109)
        Me.cbxNumSorteoAnterior.Name = "cbxNumSorteoAnterior"
        Me.cbxNumSorteoAnterior.Size = New System.Drawing.Size(50, 21)
        Me.cbxNumSorteoAnterior.TabIndex = 35
        '
        'cbxTerminacion
        '
        Me.cbxTerminacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTerminacion.FormattingEnabled = True
        Me.cbxTerminacion.Location = New System.Drawing.Point(288, 86)
        Me.cbxTerminacion.Name = "cbxTerminacion"
        Me.cbxTerminacion.Size = New System.Drawing.Size(50, 21)
        Me.cbxTerminacion.TabIndex = 36
        '
        'lblNumMasFrecuente
        '
        Me.lblNumMasFrecuente.AutoSize = True
        Me.lblNumMasFrecuente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumMasFrecuente.Location = New System.Drawing.Point(17, 21)
        Me.lblNumMasFrecuente.Name = "lblNumMasFrecuente"
        Me.lblNumMasFrecuente.Size = New System.Drawing.Size(148, 15)
        Me.lblNumMasFrecuente.TabIndex = 37
        Me.lblNumMasFrecuente.Text = "Números más frecuentes:"
        '
        'cbxMasFrecuentes
        '
        Me.cbxMasFrecuentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMasFrecuentes.FormattingEnabled = True
        Me.cbxMasFrecuentes.Location = New System.Drawing.Point(288, 15)
        Me.cbxMasFrecuentes.Name = "cbxMasFrecuentes"
        Me.cbxMasFrecuentes.Size = New System.Drawing.Size(50, 21)
        Me.cbxMasFrecuentes.TabIndex = 39
        '
        'cbxDosConsecutivos
        '
        Me.cbxDosConsecutivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDosConsecutivos.FormattingEnabled = True
        Me.cbxDosConsecutivos.Location = New System.Drawing.Point(288, 154)
        Me.cbxDosConsecutivos.Name = "cbxDosConsecutivos"
        Me.cbxDosConsecutivos.Size = New System.Drawing.Size(50, 21)
        Me.cbxDosConsecutivos.TabIndex = 40
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblNumMenosFrecuente)
        Me.GroupBox1.Controls.Add(Me.cbxMenosFrecuentes)
        Me.GroupBox1.Controls.Add(Me.lblNumMasFrecuente)
        Me.GroupBox1.Controls.Add(Me.lblCantidadPares)
        Me.GroupBox1.Controls.Add(Me.lblTerminacionMasRepetida)
        Me.GroupBox1.Controls.Add(Me.cbxDosConsecutivos)
        Me.GroupBox1.Controls.Add(Me.lblNumSorteoAnterior)
        Me.GroupBox1.Controls.Add(Me.cbxMasFrecuentes)
        Me.GroupBox1.Controls.Add(Me.lblCantNumerosUnDigito)
        Me.GroupBox1.Controls.Add(Me.lblAlMenosDosConsecutivos)
        Me.GroupBox1.Controls.Add(Me.cbxTerminacion)
        Me.GroupBox1.Controls.Add(Me.lblSumatoria)
        Me.GroupBox1.Controls.Add(Me.cbxNumSorteoAnterior)
        Me.GroupBox1.Controls.Add(Me.lblDiferenciasEntreContiguos)
        Me.GroupBox1.Controls.Add(Me.lblCantidadPrimos)
        Me.GroupBox1.Controls.Add(Me.txtCantPares)
        Me.GroupBox1.Controls.Add(Me.txtCantUnDigito)
        Me.GroupBox1.Controls.Add(Me.txtSumatoria)
        Me.GroupBox1.Controls.Add(Me.txtDiferenciaMinMax)
        Me.GroupBox1.Controls.Add(Me.txtCantNumerosPrimos)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 252)
        Me.GroupBox1.TabIndex = 94
        Me.GroupBox1.TabStop = False
        '
        'lblNumMenosFrecuente
        '
        Me.lblNumMenosFrecuente.AutoSize = True
        Me.lblNumMenosFrecuente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumMenosFrecuente.ForeColor = System.Drawing.Color.Gray
        Me.lblNumMenosFrecuente.Location = New System.Drawing.Point(17, 46)
        Me.lblNumMenosFrecuente.Name = "lblNumMenosFrecuente"
        Me.lblNumMenosFrecuente.Size = New System.Drawing.Size(229, 15)
        Me.lblNumMenosFrecuente.TabIndex = 94
        Me.lblNumMenosFrecuente.Text = "Números menos frecuentes (no salidos):"
        '
        'cbxMenosFrecuentes
        '
        Me.cbxMenosFrecuentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMenosFrecuentes.FormattingEnabled = True
        Me.cbxMenosFrecuentes.Location = New System.Drawing.Point(288, 40)
        Me.cbxMenosFrecuentes.Name = "cbxMenosFrecuentes"
        Me.cbxMenosFrecuentes.Size = New System.Drawing.Size(50, 21)
        Me.cbxMenosFrecuentes.TabIndex = 95
        '
        'picTeclado
        '
        Me.picTeclado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picTeclado.Image = CType(resources.GetObject("picTeclado.Image"), System.Drawing.Image)
        Me.picTeclado.Location = New System.Drawing.Point(145, 16)
        Me.picTeclado.Name = "picTeclado"
        Me.picTeclado.Size = New System.Drawing.Size(41, 27)
        Me.picTeclado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTeclado.TabIndex = 96
        Me.picTeclado.TabStop = False
        '
        'UsrTecladoVirtual1
        '
        Me.UsrTecladoVirtual1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UsrTecladoVirtual1.Location = New System.Drawing.Point(390, 55)
        Me.UsrTecladoVirtual1.Name = "UsrTecladoVirtual1"
        Me.UsrTecladoVirtual1.Size = New System.Drawing.Size(176, 225)
        Me.UsrTecladoVirtual1.TabIndex = 97
        Me.UsrTecladoVirtual1.TeclaPulsada = Nothing
        Me.UsrTecladoVirtual1.Visible = False
        '
        'lblNota
        '
        Me.lblNota.ForeColor = System.Drawing.Color.Sienna
        Me.lblNota.Location = New System.Drawing.Point(21, 306)
        Me.lblNota.Name = "lblNota"
        Me.lblNota.Size = New System.Drawing.Size(351, 27)
        Me.lblNota.TabIndex = 98
        Me.lblNota.Text = "* Entre paréntesis se indica el promedio por tipo de jugada (que puede ser Tradic" & _
            "ional, Desquite o SOS)"
        '
        'frmAnalizarJugadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 438)
        Me.Controls.Add(Me.lblNota)
        Me.Controls.Add(Me.UsrTecladoVirtual1)
        Me.Controls.Add(Me.picTeclado)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtSos)
        Me.Controls.Add(Me.txtDes)
        Me.Controls.Add(Me.chlSorteos)
        Me.Controls.Add(Me.txtTra)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.btnAnalizarJugada)
        Me.Controls.Add(Me.txtNumSorteo)
        Me.Controls.Add(Me.lblSorteo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAnalizarJugadas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Analizar jugada"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picTeclado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCantidadPares As System.Windows.Forms.Label
    Friend WithEvents lblTerminacionMasRepetida As System.Windows.Forms.Label
    Friend WithEvents lblCantNumerosUnDigito As System.Windows.Forms.Label
    Friend WithEvents lblNumSorteoAnterior As System.Windows.Forms.Label
    Friend WithEvents lblCantidadPrimos As System.Windows.Forms.Label
    Friend WithEvents lblDiferenciasEntreContiguos As System.Windows.Forms.Label
    Friend WithEvents lblSumatoria As System.Windows.Forms.Label
    Friend WithEvents lblAlMenosDosConsecutivos As System.Windows.Forms.Label
    Friend WithEvents txtCantPares As System.Windows.Forms.TextBox
    Friend WithEvents txtCantUnDigito As System.Windows.Forms.TextBox
    Friend WithEvents txtCantNumerosPrimos As System.Windows.Forms.TextBox
    Friend WithEvents txtDiferenciaMinMax As System.Windows.Forms.TextBox
    Friend WithEvents txtSumatoria As System.Windows.Forms.TextBox
    Friend WithEvents lblSorteo As System.Windows.Forms.Label
    Friend WithEvents txtNumSorteo As System.Windows.Forms.TextBox
    Friend WithEvents btnAnalizarJugada As System.Windows.Forms.Button
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents txtTra As System.Windows.Forms.TextBox
    Friend WithEvents chlSorteos As System.Windows.Forms.CheckedListBox
    Friend WithEvents txtDes As System.Windows.Forms.TextBox
    Friend WithEvents txtSos As System.Windows.Forms.TextBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents cbxNumSorteoAnterior As System.Windows.Forms.ComboBox
    Friend WithEvents cbxTerminacion As System.Windows.Forms.ComboBox
    Friend WithEvents lblNumMasFrecuente As System.Windows.Forms.Label
    Friend WithEvents cbxMasFrecuentes As System.Windows.Forms.ComboBox
    Friend WithEvents cbxDosConsecutivos As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNumMenosFrecuente As System.Windows.Forms.Label
    Friend WithEvents cbxMenosFrecuentes As System.Windows.Forms.ComboBox
    Friend WithEvents picTeclado As System.Windows.Forms.PictureBox
    Friend WithEvents UsrTecladoVirtual1 As Loto.usrTecladoVirtual
    Friend WithEvents lblNota As System.Windows.Forms.Label
End Class
