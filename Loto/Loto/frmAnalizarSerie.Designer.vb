<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnalizarSerie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnalizarSerie))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNumMenosFrecuente = New System.Windows.Forms.Label()
        Me.cbxMenosFrecuentes = New System.Windows.Forms.ComboBox()
        Me.lblNumMasFrecuente = New System.Windows.Forms.Label()
        Me.lblCantidadPares = New System.Windows.Forms.Label()
        Me.lblTerminacionMasRepetida = New System.Windows.Forms.Label()
        Me.cbxDosConsecutivos = New System.Windows.Forms.ComboBox()
        Me.lblNumSorteoAnterior = New System.Windows.Forms.Label()
        Me.cbxMasFrecuentes = New System.Windows.Forms.ComboBox()
        Me.lblCantNumerosUnDigito = New System.Windows.Forms.Label()
        Me.lblAlMenosDosConsecutivos = New System.Windows.Forms.Label()
        Me.cbxTerminacion = New System.Windows.Forms.ComboBox()
        Me.lblSumatoria = New System.Windows.Forms.Label()
        Me.cbxNumSorteoAnterior = New System.Windows.Forms.ComboBox()
        Me.lblDiferenciasEntreContiguos = New System.Windows.Forms.Label()
        Me.lblCantidadPrimos = New System.Windows.Forms.Label()
        Me.txtCantPares = New System.Windows.Forms.TextBox()
        Me.txtCantUnDigito = New System.Windows.Forms.TextBox()
        Me.txtSumatoria = New System.Windows.Forms.TextBox()
        Me.txtDiferenciaMinMax = New System.Windows.Forms.TextBox()
        Me.txtCantNumerosPrimos = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnAnalizarJugada = New System.Windows.Forms.Button()
        Me.lblSerie = New System.Windows.Forms.Label()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.txtNum4 = New System.Windows.Forms.TextBox()
        Me.txtNum3 = New System.Windows.Forms.TextBox()
        Me.txtNum6 = New System.Windows.Forms.TextBox()
        Me.txtNum5 = New System.Windows.Forms.TextBox()
        Me.erpAnalizarSerie = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSorteoAnterior = New System.Windows.Forms.TextBox()
        Me.mtbSerieAnteriorTra = New System.Windows.Forms.MaskedTextBox()
        Me.mtbSerieAnteriorDes = New System.Windows.Forms.MaskedTextBox()
        Me.mtbSerieAnteriorSos = New System.Windows.Forms.MaskedTextBox()
        Me.UsrTecladoVirtual1 = New Loto.usrTecladoVirtual()
        Me.picTeclado = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.erpAnalizarSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTeclado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupBox1.Location = New System.Drawing.Point(16, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 252)
        Me.GroupBox1.TabIndex = 10
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
        Me.lblNumMenosFrecuente.TabIndex = 2
        Me.lblNumMenosFrecuente.Text = "Números menos frecuentes (no salidos):"
        '
        'cbxMenosFrecuentes
        '
        Me.cbxMenosFrecuentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMenosFrecuentes.FormattingEnabled = True
        Me.cbxMenosFrecuentes.Location = New System.Drawing.Point(288, 40)
        Me.cbxMenosFrecuentes.Name = "cbxMenosFrecuentes"
        Me.cbxMenosFrecuentes.Size = New System.Drawing.Size(50, 21)
        Me.cbxMenosFrecuentes.TabIndex = 3
        '
        'lblNumMasFrecuente
        '
        Me.lblNumMasFrecuente.AutoSize = True
        Me.lblNumMasFrecuente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumMasFrecuente.Location = New System.Drawing.Point(17, 21)
        Me.lblNumMasFrecuente.Name = "lblNumMasFrecuente"
        Me.lblNumMasFrecuente.Size = New System.Drawing.Size(148, 15)
        Me.lblNumMasFrecuente.TabIndex = 0
        Me.lblNumMasFrecuente.Text = "Números más frecuentes:"
        '
        'lblCantidadPares
        '
        Me.lblCantidadPares.AutoSize = True
        Me.lblCantidadPares.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadPares.Location = New System.Drawing.Point(17, 69)
        Me.lblCantidadPares.Name = "lblCantidadPares"
        Me.lblCantidadPares.Size = New System.Drawing.Size(110, 15)
        Me.lblCantidadPares.TabIndex = 4
        Me.lblCantidadPares.Text = "Cantidad de pares:"
        '
        'lblTerminacionMasRepetida
        '
        Me.lblTerminacionMasRepetida.AutoSize = True
        Me.lblTerminacionMasRepetida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTerminacionMasRepetida.Location = New System.Drawing.Point(17, 92)
        Me.lblTerminacionMasRepetida.Name = "lblTerminacionMasRepetida"
        Me.lblTerminacionMasRepetida.Size = New System.Drawing.Size(180, 15)
        Me.lblTerminacionMasRepetida.TabIndex = 6
        Me.lblTerminacionMasRepetida.Text = "Terminación que más se repite:"
        '
        'cbxDosConsecutivos
        '
        Me.cbxDosConsecutivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDosConsecutivos.FormattingEnabled = True
        Me.cbxDosConsecutivos.Location = New System.Drawing.Point(288, 154)
        Me.cbxDosConsecutivos.Name = "cbxDosConsecutivos"
        Me.cbxDosConsecutivos.Size = New System.Drawing.Size(50, 21)
        Me.cbxDosConsecutivos.TabIndex = 13
        '
        'lblNumSorteoAnterior
        '
        Me.lblNumSorteoAnterior.AutoSize = True
        Me.lblNumSorteoAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumSorteoAnterior.Location = New System.Drawing.Point(17, 114)
        Me.lblNumSorteoAnterior.Name = "lblNumSorteoAnterior"
        Me.lblNumSorteoAnterior.Size = New System.Drawing.Size(208, 15)
        Me.lblNumSorteoAnterior.TabIndex = 8
        Me.lblNumSorteoAnterior.Text = "Incluir un número del sorteo anterior:"
        '
        'cbxMasFrecuentes
        '
        Me.cbxMasFrecuentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMasFrecuentes.FormattingEnabled = True
        Me.cbxMasFrecuentes.Location = New System.Drawing.Point(288, 15)
        Me.cbxMasFrecuentes.Name = "cbxMasFrecuentes"
        Me.cbxMasFrecuentes.Size = New System.Drawing.Size(50, 21)
        Me.cbxMasFrecuentes.TabIndex = 1
        '
        'lblCantNumerosUnDigito
        '
        Me.lblCantNumerosUnDigito.AutoSize = True
        Me.lblCantNumerosUnDigito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantNumerosUnDigito.Location = New System.Drawing.Point(17, 136)
        Me.lblCantNumerosUnDigito.Name = "lblCantNumerosUnDigito"
        Me.lblCantNumerosUnDigito.Size = New System.Drawing.Size(194, 15)
        Me.lblCantNumerosUnDigito.TabIndex = 10
        Me.lblCantNumerosUnDigito.Text = "Cantidad de números con 1 dígito:"
        '
        'lblAlMenosDosConsecutivos
        '
        Me.lblAlMenosDosConsecutivos.AutoSize = True
        Me.lblAlMenosDosConsecutivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlMenosDosConsecutivos.Location = New System.Drawing.Point(17, 160)
        Me.lblAlMenosDosConsecutivos.Name = "lblAlMenosDosConsecutivos"
        Me.lblAlMenosDosConsecutivos.Size = New System.Drawing.Size(196, 15)
        Me.lblAlMenosDosConsecutivos.TabIndex = 12
        Me.lblAlMenosDosConsecutivos.Text = "Al menos 2 números consecutivos:"
        '
        'cbxTerminacion
        '
        Me.cbxTerminacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTerminacion.FormattingEnabled = True
        Me.cbxTerminacion.Location = New System.Drawing.Point(288, 86)
        Me.cbxTerminacion.Name = "cbxTerminacion"
        Me.cbxTerminacion.Size = New System.Drawing.Size(50, 21)
        Me.cbxTerminacion.TabIndex = 7
        '
        'lblSumatoria
        '
        Me.lblSumatoria.AutoSize = True
        Me.lblSumatoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSumatoria.Location = New System.Drawing.Point(17, 181)
        Me.lblSumatoria.Name = "lblSumatoria"
        Me.lblSumatoria.Size = New System.Drawing.Size(113, 15)
        Me.lblSumatoria.TabIndex = 14
        Me.lblSumatoria.Text = "Sumatoria sorteo/s:"
        '
        'cbxNumSorteoAnterior
        '
        Me.cbxNumSorteoAnterior.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxNumSorteoAnterior.FormattingEnabled = True
        Me.cbxNumSorteoAnterior.Location = New System.Drawing.Point(288, 109)
        Me.cbxNumSorteoAnterior.Name = "cbxNumSorteoAnterior"
        Me.cbxNumSorteoAnterior.Size = New System.Drawing.Size(50, 21)
        Me.cbxNumSorteoAnterior.TabIndex = 9
        '
        'lblDiferenciasEntreContiguos
        '
        Me.lblDiferenciasEntreContiguos.AutoSize = True
        Me.lblDiferenciasEntreContiguos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiferenciasEntreContiguos.Location = New System.Drawing.Point(17, 202)
        Me.lblDiferenciasEntreContiguos.Name = "lblDiferenciasEntreContiguos"
        Me.lblDiferenciasEntreContiguos.Size = New System.Drawing.Size(217, 15)
        Me.lblDiferenciasEntreContiguos.TabIndex = 16
        Me.lblDiferenciasEntreContiguos.Text = "Dif. mín. y máx. entre núms. contiguos:"
        '
        'lblCantidadPrimos
        '
        Me.lblCantidadPrimos.AutoSize = True
        Me.lblCantidadPrimos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadPrimos.Location = New System.Drawing.Point(17, 226)
        Me.lblCantidadPrimos.Name = "lblCantidadPrimos"
        Me.lblCantidadPrimos.Size = New System.Drawing.Size(169, 15)
        Me.lblCantidadPrimos.TabIndex = 18
        Me.lblCantidadPrimos.Text = "Cantidad de números primos:"
        '
        'txtCantPares
        '
        Me.txtCantPares.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantPares.Location = New System.Drawing.Point(288, 64)
        Me.txtCantPares.MaxLength = 1
        Me.txtCantPares.Name = "txtCantPares"
        Me.txtCantPares.ReadOnly = True
        Me.txtCantPares.Size = New System.Drawing.Size(50, 20)
        Me.txtCantPares.TabIndex = 5
        Me.txtCantPares.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCantUnDigito
        '
        Me.txtCantUnDigito.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantUnDigito.Location = New System.Drawing.Point(288, 132)
        Me.txtCantUnDigito.Name = "txtCantUnDigito"
        Me.txtCantUnDigito.ReadOnly = True
        Me.txtCantUnDigito.Size = New System.Drawing.Size(50, 20)
        Me.txtCantUnDigito.TabIndex = 11
        Me.txtCantUnDigito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSumatoria
        '
        Me.txtSumatoria.BackColor = System.Drawing.SystemColors.Window
        Me.txtSumatoria.Location = New System.Drawing.Point(288, 177)
        Me.txtSumatoria.Name = "txtSumatoria"
        Me.txtSumatoria.ReadOnly = True
        Me.txtSumatoria.Size = New System.Drawing.Size(50, 20)
        Me.txtSumatoria.TabIndex = 15
        Me.txtSumatoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDiferenciaMinMax
        '
        Me.txtDiferenciaMinMax.BackColor = System.Drawing.SystemColors.Window
        Me.txtDiferenciaMinMax.Location = New System.Drawing.Point(288, 200)
        Me.txtDiferenciaMinMax.Name = "txtDiferenciaMinMax"
        Me.txtDiferenciaMinMax.ReadOnly = True
        Me.txtDiferenciaMinMax.Size = New System.Drawing.Size(50, 20)
        Me.txtDiferenciaMinMax.TabIndex = 17
        Me.txtDiferenciaMinMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCantNumerosPrimos
        '
        Me.txtCantNumerosPrimos.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantNumerosPrimos.Location = New System.Drawing.Point(288, 222)
        Me.txtCantNumerosPrimos.Name = "txtCantNumerosPrimos"
        Me.txtCantNumerosPrimos.ReadOnly = True
        Me.txtCantNumerosPrimos.Size = New System.Drawing.Size(50, 20)
        Me.txtCantNumerosPrimos.TabIndex = 19
        Me.txtCantNumerosPrimos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCerrar
        '
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(19, 403)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 29)
        Me.btnCerrar.TabIndex = 12
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnAnalizarJugada
        '
        Me.btnAnalizarJugada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnalizarJugada.Location = New System.Drawing.Point(19, 373)
        Me.btnAnalizarJugada.Name = "btnAnalizarJugada"
        Me.btnAnalizarJugada.Size = New System.Drawing.Size(75, 29)
        Me.btnAnalizarJugada.TabIndex = 11
        Me.btnAnalizarJugada.Text = "Analizar"
        Me.btnAnalizarJugada.UseVisualStyleBackColor = True
        '
        'lblSerie
        '
        Me.lblSerie.AutoSize = True
        Me.lblSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerie.Location = New System.Drawing.Point(26, 22)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(85, 15)
        Me.lblSerie.TabIndex = 0
        Me.lblSerie.Text = "Ingresar serie:"
        '
        'txtNum1
        '
        Me.txtNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum1.Location = New System.Drawing.Point(111, 16)
        Me.txtNum1.MaxLength = 2
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(22, 22)
        Me.txtNum1.TabIndex = 0
        '
        'txtNum2
        '
        Me.txtNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum2.Location = New System.Drawing.Point(134, 16)
        Me.txtNum2.MaxLength = 2
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(22, 22)
        Me.txtNum2.TabIndex = 1
        '
        'txtNum4
        '
        Me.txtNum4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum4.Location = New System.Drawing.Point(180, 16)
        Me.txtNum4.MaxLength = 2
        Me.txtNum4.Name = "txtNum4"
        Me.txtNum4.Size = New System.Drawing.Size(22, 22)
        Me.txtNum4.TabIndex = 3
        '
        'txtNum3
        '
        Me.txtNum3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum3.Location = New System.Drawing.Point(157, 16)
        Me.txtNum3.MaxLength = 2
        Me.txtNum3.Name = "txtNum3"
        Me.txtNum3.Size = New System.Drawing.Size(22, 22)
        Me.txtNum3.TabIndex = 2
        '
        'txtNum6
        '
        Me.txtNum6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum6.Location = New System.Drawing.Point(226, 16)
        Me.txtNum6.MaxLength = 2
        Me.txtNum6.Name = "txtNum6"
        Me.txtNum6.Size = New System.Drawing.Size(22, 22)
        Me.txtNum6.TabIndex = 5
        '
        'txtNum5
        '
        Me.txtNum5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum5.Location = New System.Drawing.Point(203, 16)
        Me.txtNum5.MaxLength = 2
        Me.txtNum5.Name = "txtNum5"
        Me.txtNum5.Size = New System.Drawing.Size(22, 22)
        Me.txtNum5.TabIndex = 4
        '
        'erpAnalizarSerie
        '
        Me.erpAnalizarSerie.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 13)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "Ingresar el nº de sorteo anterior:"
        '
        'txtSorteoAnterior
        '
        Me.txtSorteoAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSorteoAnterior.Location = New System.Drawing.Point(185, 46)
        Me.txtSorteoAnterior.MaxLength = 5
        Me.txtSorteoAnterior.Name = "txtSorteoAnterior"
        Me.txtSorteoAnterior.Size = New System.Drawing.Size(45, 21)
        Me.txtSorteoAnterior.TabIndex = 6
        '
        'mtbSerieAnteriorTra
        '
        Me.mtbSerieAnteriorTra.BackColor = System.Drawing.SystemColors.Window
        Me.mtbSerieAnteriorTra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbSerieAnteriorTra.Location = New System.Drawing.Point(26, 76)
        Me.mtbSerieAnteriorTra.Mask = "00-00-00-00-00-00"
        Me.mtbSerieAnteriorTra.Name = "mtbSerieAnteriorTra"
        Me.mtbSerieAnteriorTra.ReadOnly = True
        Me.mtbSerieAnteriorTra.Size = New System.Drawing.Size(109, 22)
        Me.mtbSerieAnteriorTra.TabIndex = 7
        '
        'mtbSerieAnteriorDes
        '
        Me.mtbSerieAnteriorDes.BackColor = System.Drawing.SystemColors.Window
        Me.mtbSerieAnteriorDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbSerieAnteriorDes.Location = New System.Drawing.Point(138, 76)
        Me.mtbSerieAnteriorDes.Mask = "00-00-00-00-00-00"
        Me.mtbSerieAnteriorDes.Name = "mtbSerieAnteriorDes"
        Me.mtbSerieAnteriorDes.ReadOnly = True
        Me.mtbSerieAnteriorDes.Size = New System.Drawing.Size(109, 22)
        Me.mtbSerieAnteriorDes.TabIndex = 8
        '
        'mtbSerieAnteriorSos
        '
        Me.mtbSerieAnteriorSos.BackColor = System.Drawing.SystemColors.Window
        Me.mtbSerieAnteriorSos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbSerieAnteriorSos.Location = New System.Drawing.Point(250, 76)
        Me.mtbSerieAnteriorSos.Mask = "00-00-00-00-00-00"
        Me.mtbSerieAnteriorSos.Name = "mtbSerieAnteriorSos"
        Me.mtbSerieAnteriorSos.ReadOnly = True
        Me.mtbSerieAnteriorSos.Size = New System.Drawing.Size(109, 22)
        Me.mtbSerieAnteriorSos.TabIndex = 9
        '
        'UsrTecladoVirtual1
        '
        Me.UsrTecladoVirtual1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UsrTecladoVirtual1.Location = New System.Drawing.Point(384, 85)
        Me.UsrTecladoVirtual1.Name = "UsrTecladoVirtual1"
        Me.UsrTecladoVirtual1.Size = New System.Drawing.Size(176, 225)
        Me.UsrTecladoVirtual1.TabIndex = 108
        Me.UsrTecladoVirtual1.TeclaPulsada = Nothing
        Me.UsrTecladoVirtual1.Visible = False
        '
        'picTeclado
        '
        Me.picTeclado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picTeclado.Image = CType(resources.GetObject("picTeclado.Image"), System.Drawing.Image)
        Me.picTeclado.Location = New System.Drawing.Point(236, 39)
        Me.picTeclado.Name = "picTeclado"
        Me.picTeclado.Size = New System.Drawing.Size(41, 27)
        Me.picTeclado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTeclado.TabIndex = 110
        Me.picTeclado.TabStop = False
        '
        'frmAnalizarSerie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 448)
        Me.Controls.Add(Me.picTeclado)
        Me.Controls.Add(Me.mtbSerieAnteriorSos)
        Me.Controls.Add(Me.mtbSerieAnteriorDes)
        Me.Controls.Add(Me.mtbSerieAnteriorTra)
        Me.Controls.Add(Me.txtSorteoAnterior)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNum6)
        Me.Controls.Add(Me.txtNum5)
        Me.Controls.Add(Me.txtNum4)
        Me.Controls.Add(Me.txtNum3)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.UsrTecladoVirtual1)
        Me.Controls.Add(Me.lblSerie)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnAnalizarJugada)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(395, 486)
        Me.Name = "frmAnalizarSerie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Analizar serie no sorteada"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.erpAnalizarSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTeclado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNumMenosFrecuente As System.Windows.Forms.Label
    Friend WithEvents cbxMenosFrecuentes As System.Windows.Forms.ComboBox
    Friend WithEvents lblNumMasFrecuente As System.Windows.Forms.Label
    Friend WithEvents lblCantidadPares As System.Windows.Forms.Label
    Friend WithEvents lblTerminacionMasRepetida As System.Windows.Forms.Label
    Friend WithEvents cbxDosConsecutivos As System.Windows.Forms.ComboBox
    Friend WithEvents lblNumSorteoAnterior As System.Windows.Forms.Label
    Friend WithEvents cbxMasFrecuentes As System.Windows.Forms.ComboBox
    Friend WithEvents lblCantNumerosUnDigito As System.Windows.Forms.Label
    Friend WithEvents lblAlMenosDosConsecutivos As System.Windows.Forms.Label
    Friend WithEvents cbxTerminacion As System.Windows.Forms.ComboBox
    Friend WithEvents lblSumatoria As System.Windows.Forms.Label
    Friend WithEvents cbxNumSorteoAnterior As System.Windows.Forms.ComboBox
    Friend WithEvents lblDiferenciasEntreContiguos As System.Windows.Forms.Label
    Friend WithEvents lblCantidadPrimos As System.Windows.Forms.Label
    Friend WithEvents txtCantPares As System.Windows.Forms.TextBox
    Friend WithEvents txtCantUnDigito As System.Windows.Forms.TextBox
    Friend WithEvents txtSumatoria As System.Windows.Forms.TextBox
    Friend WithEvents txtDiferenciaMinMax As System.Windows.Forms.TextBox
    Friend WithEvents txtCantNumerosPrimos As System.Windows.Forms.TextBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnAnalizarJugada As System.Windows.Forms.Button
    Friend WithEvents lblSerie As System.Windows.Forms.Label
    Friend WithEvents UsrTecladoVirtual1 As Loto.usrTecladoVirtual
    Friend WithEvents txtNum1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum4 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum3 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum6 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum5 As System.Windows.Forms.TextBox
    Friend WithEvents erpAnalizarSerie As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtSorteoAnterior As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mtbSerieAnteriorTra As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbSerieAnteriorSos As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbSerieAnteriorDes As System.Windows.Forms.MaskedTextBox
    Friend WithEvents picTeclado As System.Windows.Forms.PictureBox
End Class
