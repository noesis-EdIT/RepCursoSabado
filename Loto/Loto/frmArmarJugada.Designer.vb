<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArmarJugada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArmarJugada))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCantPares = New System.Windows.Forms.TextBox()
        Me.lblCol1 = New System.Windows.Forms.Label()
        Me.lblCol2 = New System.Windows.Forms.Label()
        Me.lblCol3 = New System.Windows.Forms.Label()
        Me.lblCol4 = New System.Windows.Forms.Label()
        Me.lblCol5 = New System.Windows.Forms.Label()
        Me.lblCol6 = New System.Windows.Forms.Label()
        Me.gbMasFrecuentes = New System.Windows.Forms.GroupBox()
        Me.txtIncluir3 = New System.Windows.Forms.TextBox()
        Me.txtIncluir2 = New System.Windows.Forms.TextBox()
        Me.txtIncluir1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblIntervalo = New System.Windows.Forms.Label()
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.mtbCol6 = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCol5 = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCol4 = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCol3 = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCol2 = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCol1 = New System.Windows.Forms.MaskedTextBox()
        Me.chklstOpciones = New System.Windows.Forms.CheckedListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gbPares = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTerminacion = New System.Windows.Forms.TextBox()
        Me.gbSorteoAnterior = New System.Windows.Forms.GroupBox()
        Me.rbSorteoAnteriorAutom = New System.Windows.Forms.RadioButton()
        Me.txtNumSorteoAnterior = New System.Windows.Forms.TextBox()
        Me.rbSorteoAnteriorManual = New System.Windows.Forms.RadioButton()
        Me.txtCantUnDigito = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkUnParConsecutivos = New System.Windows.Forms.CheckBox()
        Me.NumericUpDownSuperior = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownInferior = New System.Windows.Forms.NumericUpDown()
        Me.gbSumatoriaSorteo = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.gbDiferenciaMinMax = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudDifMaxima = New System.Windows.Forms.NumericUpDown()
        Me.nudDifMinima = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkSeleccionarTodas = New System.Windows.Forms.CheckBox()
        Me.lstSorteos = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtPrimos = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.gbNumeroExcluir = New System.Windows.Forms.GroupBox()
        Me.txtExcluir3 = New System.Windows.Forms.TextBox()
        Me.txtExcluir2 = New System.Windows.Forms.TextBox()
        Me.txtExcluir1 = New System.Windows.Forms.TextBox()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.gbMasFrecuentes.SuspendLayout()
        Me.gbPares.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbSorteoAnterior.SuspendLayout()
        CType(Me.NumericUpDownSuperior, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownInferior, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSumatoriaSorteo.SuspendLayout()
        Me.gbDiferenciaMinMax.SuspendLayout()
        CType(Me.nudDifMaxima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDifMinima, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.gbNumeroExcluir.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cantidad de pares:"
        '
        'txtCantPares
        '
        Me.txtCantPares.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantPares.Location = New System.Drawing.Point(126, 23)
        Me.txtCantPares.MaxLength = 1
        Me.txtCantPares.Name = "txtCantPares"
        Me.txtCantPares.Size = New System.Drawing.Size(35, 22)
        Me.txtCantPares.TabIndex = 1
        Me.txtCantPares.Text = "3"
        '
        'lblCol1
        '
        Me.lblCol1.AutoSize = True
        Me.lblCol1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCol1.Location = New System.Drawing.Point(13, 26)
        Me.lblCol1.Name = "lblCol1"
        Me.lblCol1.Size = New System.Drawing.Size(79, 13)
        Me.lblCol1.TabIndex = 2
        Me.lblCol1.Text = "Col. 1 (00 a 06)"
        '
        'lblCol2
        '
        Me.lblCol2.AutoSize = True
        Me.lblCol2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCol2.Location = New System.Drawing.Point(13, 50)
        Me.lblCol2.Name = "lblCol2"
        Me.lblCol2.Size = New System.Drawing.Size(79, 13)
        Me.lblCol2.TabIndex = 21
        Me.lblCol2.Text = "Col. 2 (07 a 13)"
        '
        'lblCol3
        '
        Me.lblCol3.AutoSize = True
        Me.lblCol3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCol3.Location = New System.Drawing.Point(13, 73)
        Me.lblCol3.Name = "lblCol3"
        Me.lblCol3.Size = New System.Drawing.Size(79, 13)
        Me.lblCol3.TabIndex = 22
        Me.lblCol3.Text = "Col. 3 (14 a 20)"
        '
        'lblCol4
        '
        Me.lblCol4.AutoSize = True
        Me.lblCol4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCol4.Location = New System.Drawing.Point(13, 98)
        Me.lblCol4.Name = "lblCol4"
        Me.lblCol4.Size = New System.Drawing.Size(79, 13)
        Me.lblCol4.TabIndex = 23
        Me.lblCol4.Text = "Col. 4 (21 a 27)"
        '
        'lblCol5
        '
        Me.lblCol5.AutoSize = True
        Me.lblCol5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCol5.Location = New System.Drawing.Point(13, 122)
        Me.lblCol5.Name = "lblCol5"
        Me.lblCol5.Size = New System.Drawing.Size(79, 13)
        Me.lblCol5.TabIndex = 24
        Me.lblCol5.Text = "Col. 5 (28 a 34)"
        '
        'lblCol6
        '
        Me.lblCol6.AutoSize = True
        Me.lblCol6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCol6.Location = New System.Drawing.Point(13, 147)
        Me.lblCol6.Name = "lblCol6"
        Me.lblCol6.Size = New System.Drawing.Size(79, 13)
        Me.lblCol6.TabIndex = 25
        Me.lblCol6.Text = "Col. 6 (35 a 41)"
        '
        'gbMasFrecuentes
        '
        Me.gbMasFrecuentes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbMasFrecuentes.Controls.Add(Me.txtIncluir3)
        Me.gbMasFrecuentes.Controls.Add(Me.txtIncluir2)
        Me.gbMasFrecuentes.Controls.Add(Me.txtIncluir1)
        Me.gbMasFrecuentes.Controls.Add(Me.Label13)
        Me.gbMasFrecuentes.Controls.Add(Me.btnBuscar)
        Me.gbMasFrecuentes.Controls.Add(Me.lblIntervalo)
        Me.gbMasFrecuentes.Controls.Add(Me.dtpFechaHasta)
        Me.gbMasFrecuentes.Controls.Add(Me.dtpFechaDesde)
        Me.gbMasFrecuentes.Controls.Add(Me.mtbCol6)
        Me.gbMasFrecuentes.Controls.Add(Me.mtbCol5)
        Me.gbMasFrecuentes.Controls.Add(Me.mtbCol4)
        Me.gbMasFrecuentes.Controls.Add(Me.mtbCol3)
        Me.gbMasFrecuentes.Controls.Add(Me.mtbCol2)
        Me.gbMasFrecuentes.Controls.Add(Me.mtbCol1)
        Me.gbMasFrecuentes.Controls.Add(Me.lblCol1)
        Me.gbMasFrecuentes.Controls.Add(Me.lblCol6)
        Me.gbMasFrecuentes.Controls.Add(Me.lblCol5)
        Me.gbMasFrecuentes.Controls.Add(Me.lblCol4)
        Me.gbMasFrecuentes.Controls.Add(Me.lblCol3)
        Me.gbMasFrecuentes.Controls.Add(Me.lblCol2)
        Me.gbMasFrecuentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMasFrecuentes.Location = New System.Drawing.Point(286, 12)
        Me.gbMasFrecuentes.Name = "gbMasFrecuentes"
        Me.gbMasFrecuentes.Size = New System.Drawing.Size(199, 288)
        Me.gbMasFrecuentes.TabIndex = 26
        Me.gbMasFrecuentes.TabStop = False
        Me.gbMasFrecuentes.Text = "1 - Incluir números"
        '
        'txtIncluir3
        '
        Me.txtIncluir3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIncluir3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncluir3.Location = New System.Drawing.Point(65, 259)
        Me.txtIncluir3.MaxLength = 2
        Me.txtIncluir3.Name = "txtIncluir3"
        Me.txtIncluir3.Size = New System.Drawing.Size(25, 22)
        Me.txtIncluir3.TabIndex = 72
        '
        'txtIncluir2
        '
        Me.txtIncluir2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIncluir2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncluir2.Location = New System.Drawing.Point(39, 259)
        Me.txtIncluir2.MaxLength = 2
        Me.txtIncluir2.Name = "txtIncluir2"
        Me.txtIncluir2.Size = New System.Drawing.Size(25, 22)
        Me.txtIncluir2.TabIndex = 71
        '
        'txtIncluir1
        '
        Me.txtIncluir1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIncluir1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncluir1.Location = New System.Drawing.Point(13, 259)
        Me.txtIncluir1.MaxLength = 2
        Me.txtIncluir1.Name = "txtIncluir1"
        Me.txtIncluir1.Size = New System.Drawing.Size(25, 22)
        Me.txtIncluir1.TabIndex = 70
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(11, 243)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(110, 15)
        Me.Label13.TabIndex = 69
        Me.Label13.Text = "Incluir en el sorteo:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(13, 212)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 59
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblIntervalo
        '
        Me.lblIntervalo.AutoSize = True
        Me.lblIntervalo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntervalo.Location = New System.Drawing.Point(13, 171)
        Me.lblIntervalo.Name = "lblIntervalo"
        Me.lblIntervalo.Size = New System.Drawing.Size(112, 15)
        Me.lblIntervalo.TabIndex = 67
        Me.lblIntervalo.Text = "Intervalo de fechas:"
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaHasta.Location = New System.Drawing.Point(106, 187)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(84, 21)
        Me.dtpFechaHasta.TabIndex = 66
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDesde.Location = New System.Drawing.Point(13, 187)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(84, 21)
        Me.dtpFechaDesde.TabIndex = 65
        '
        'mtbCol6
        '
        Me.mtbCol6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbCol6.Location = New System.Drawing.Point(98, 141)
        Me.mtbCol6.Mask = "00  00  00"
        Me.mtbCol6.Name = "mtbCol6"
        Me.mtbCol6.Size = New System.Drawing.Size(60, 22)
        Me.mtbCol6.TabIndex = 64
        Me.mtbCol6.Text = "373839"
        '
        'mtbCol5
        '
        Me.mtbCol5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbCol5.Location = New System.Drawing.Point(98, 116)
        Me.mtbCol5.Mask = "00  00  00"
        Me.mtbCol5.Name = "mtbCol5"
        Me.mtbCol5.Size = New System.Drawing.Size(60, 22)
        Me.mtbCol5.TabIndex = 63
        Me.mtbCol5.Text = "293233"
        '
        'mtbCol4
        '
        Me.mtbCol4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbCol4.Location = New System.Drawing.Point(98, 90)
        Me.mtbCol4.Mask = "00  00  00"
        Me.mtbCol4.Name = "mtbCol4"
        Me.mtbCol4.Size = New System.Drawing.Size(60, 22)
        Me.mtbCol4.TabIndex = 62
        Me.mtbCol4.Text = "212223"
        '
        'mtbCol3
        '
        Me.mtbCol3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbCol3.Location = New System.Drawing.Point(98, 66)
        Me.mtbCol3.Mask = "00  00  00"
        Me.mtbCol3.Name = "mtbCol3"
        Me.mtbCol3.Size = New System.Drawing.Size(60, 22)
        Me.mtbCol3.TabIndex = 61
        Me.mtbCol3.Text = "151718"
        '
        'mtbCol2
        '
        Me.mtbCol2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbCol2.Location = New System.Drawing.Point(98, 43)
        Me.mtbCol2.Mask = "00  00  00"
        Me.mtbCol2.Name = "mtbCol2"
        Me.mtbCol2.Size = New System.Drawing.Size(60, 22)
        Me.mtbCol2.TabIndex = 60
        Me.mtbCol2.Text = "070809"
        '
        'mtbCol1
        '
        Me.mtbCol1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbCol1.Location = New System.Drawing.Point(98, 19)
        Me.mtbCol1.Mask = "00  00  00"
        Me.mtbCol1.Name = "mtbCol1"
        Me.mtbCol1.Size = New System.Drawing.Size(60, 22)
        Me.mtbCol1.TabIndex = 59
        Me.mtbCol1.Text = "010204"
        '
        'chklstOpciones
        '
        Me.chklstOpciones.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chklstOpciones.FormattingEnabled = True
        Me.chklstOpciones.Items.AddRange(New Object() {"01 - Incluir número(s)", "02 - Cantidad de pares", "03 - Números con igual terminación", "04 - Incluir un número del sorteo anterior", "05 - Cantidad de números con 1 dígito", "06 - Al menos 2 números consecutivos", "07 - Sumatoria de los números seleccionados", "08 - Dif. mín. y máx. entre núms. contiguos", "09 - Números primos", "10 - Excluir número(s)"})
        Me.chklstOpciones.Location = New System.Drawing.Point(32, 28)
        Me.chklstOpciones.Name = "chklstOpciones"
        Me.chklstOpciones.Size = New System.Drawing.Size(240, 154)
        Me.chklstOpciones.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(31, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Opciones:"
        '
        'gbPares
        '
        Me.gbPares.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbPares.Controls.Add(Me.Label1)
        Me.gbPares.Controls.Add(Me.txtCantPares)
        Me.gbPares.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPares.Location = New System.Drawing.Point(286, 311)
        Me.gbPares.Name = "gbPares"
        Me.gbPares.Size = New System.Drawing.Size(200, 56)
        Me.gbPares.TabIndex = 32
        Me.gbPares.TabStop = False
        Me.gbPares.Text = "2 - Pares"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtTerminacion)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(286, 376)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 78)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "3 - Terminación"
        '
        'Label9
        '
        Me.Label9.AllowDrop = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(185, 31)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Indicar la terminación de dos números (1-9):"
        '
        'txtTerminacion
        '
        Me.txtTerminacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTerminacion.Location = New System.Drawing.Point(12, 50)
        Me.txtTerminacion.MaxLength = 1
        Me.txtTerminacion.Name = "txtTerminacion"
        Me.txtTerminacion.Size = New System.Drawing.Size(35, 22)
        Me.txtTerminacion.TabIndex = 1
        Me.txtTerminacion.Text = "2"
        '
        'gbSorteoAnterior
        '
        Me.gbSorteoAnterior.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbSorteoAnterior.Controls.Add(Me.rbSorteoAnteriorAutom)
        Me.gbSorteoAnterior.Controls.Add(Me.txtNumSorteoAnterior)
        Me.gbSorteoAnterior.Controls.Add(Me.rbSorteoAnteriorManual)
        Me.gbSorteoAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSorteoAnterior.Location = New System.Drawing.Point(286, 472)
        Me.gbSorteoAnterior.Name = "gbSorteoAnterior"
        Me.gbSorteoAnterior.Size = New System.Drawing.Size(199, 99)
        Me.gbSorteoAnterior.TabIndex = 34
        Me.gbSorteoAnterior.TabStop = False
        Me.gbSorteoAnterior.Text = "4 - Número del sorteo anterior"
        '
        'rbSorteoAnteriorAutom
        '
        Me.rbSorteoAnteriorAutom.AutoSize = True
        Me.rbSorteoAnteriorAutom.Checked = True
        Me.rbSorteoAnteriorAutom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSorteoAnteriorAutom.Location = New System.Drawing.Point(9, 48)
        Me.rbSorteoAnteriorAutom.MinimumSize = New System.Drawing.Size(166, 17)
        Me.rbSorteoAnteriorAutom.Name = "rbSorteoAnteriorAutom"
        Me.rbSorteoAnteriorAutom.Size = New System.Drawing.Size(186, 19)
        Me.rbSorteoAnteriorAutom.TabIndex = 53
        Me.rbSorteoAnteriorAutom.TabStop = True
        Me.rbSorteoAnteriorAutom.Text = "Buscar nro. automáticamente"
        Me.rbSorteoAnteriorAutom.UseVisualStyleBackColor = True
        '
        'txtNumSorteoAnterior
        '
        Me.txtNumSorteoAnterior.BackColor = System.Drawing.SystemColors.Window
        Me.txtNumSorteoAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumSorteoAnterior.Location = New System.Drawing.Point(6, 18)
        Me.txtNumSorteoAnterior.MaxLength = 2
        Me.txtNumSorteoAnterior.Name = "txtNumSorteoAnterior"
        Me.txtNumSorteoAnterior.ReadOnly = True
        Me.txtNumSorteoAnterior.Size = New System.Drawing.Size(35, 22)
        Me.txtNumSorteoAnterior.TabIndex = 1
        '
        'rbSorteoAnteriorManual
        '
        Me.rbSorteoAnteriorManual.AutoSize = True
        Me.rbSorteoAnteriorManual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSorteoAnteriorManual.Location = New System.Drawing.Point(9, 73)
        Me.rbSorteoAnteriorManual.MinimumSize = New System.Drawing.Size(166, 17)
        Me.rbSorteoAnteriorManual.Name = "rbSorteoAnteriorManual"
        Me.rbSorteoAnteriorManual.Size = New System.Drawing.Size(174, 19)
        Me.rbSorteoAnteriorManual.TabIndex = 52
        Me.rbSorteoAnteriorManual.Text = "Ingresar nro. manualmente"
        Me.rbSorteoAnteriorManual.UseVisualStyleBackColor = True
        '
        'txtCantUnDigito
        '
        Me.txtCantUnDigito.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCantUnDigito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantUnDigito.Location = New System.Drawing.Point(7, 35)
        Me.txtCantUnDigito.MaxLength = 2
        Me.txtCantUnDigito.Name = "txtCantUnDigito"
        Me.txtCantUnDigito.Size = New System.Drawing.Size(35, 22)
        Me.txtCantUnDigito.TabIndex = 37
        Me.txtCantUnDigito.Text = "2"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(13, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 15)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Límite inferior:"
        '
        'chkUnParConsecutivos
        '
        Me.chkUnParConsecutivos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkUnParConsecutivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUnParConsecutivos.Location = New System.Drawing.Point(519, 89)
        Me.chkUnParConsecutivos.Name = "chkUnParConsecutivos"
        Me.chkUnParConsecutivos.Size = New System.Drawing.Size(215, 34)
        Me.chkUnParConsecutivos.TabIndex = 39
        Me.chkUnParConsecutivos.Text = "6 - Verificar que haya al menos un par de números consecutivos"
        Me.chkUnParConsecutivos.UseVisualStyleBackColor = True
        '
        'NumericUpDownSuperior
        '
        Me.NumericUpDownSuperior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownSuperior.Location = New System.Drawing.Point(113, 49)
        Me.NumericUpDownSuperior.Maximum = New Decimal(New Integer() {231, 0, 0, 0})
        Me.NumericUpDownSuperior.Minimum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.NumericUpDownSuperior.Name = "NumericUpDownSuperior"
        Me.NumericUpDownSuperior.Size = New System.Drawing.Size(47, 22)
        Me.NumericUpDownSuperior.TabIndex = 43
        Me.NumericUpDownSuperior.Value = New Decimal(New Integer() {148, 0, 0, 0})
        '
        'NumericUpDownInferior
        '
        Me.NumericUpDownInferior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownInferior.Location = New System.Drawing.Point(113, 23)
        Me.NumericUpDownInferior.Maximum = New Decimal(New Integer() {231, 0, 0, 0})
        Me.NumericUpDownInferior.Minimum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.NumericUpDownInferior.Name = "NumericUpDownInferior"
        Me.NumericUpDownInferior.Size = New System.Drawing.Size(47, 22)
        Me.NumericUpDownInferior.TabIndex = 44
        Me.NumericUpDownInferior.Value = New Decimal(New Integer() {83, 0, 0, 0})
        '
        'gbSumatoriaSorteo
        '
        Me.gbSumatoriaSorteo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbSumatoriaSorteo.Controls.Add(Me.Label12)
        Me.gbSumatoriaSorteo.Controls.Add(Me.NumericUpDownInferior)
        Me.gbSumatoriaSorteo.Controls.Add(Me.Label11)
        Me.gbSumatoriaSorteo.Controls.Add(Me.NumericUpDownSuperior)
        Me.gbSumatoriaSorteo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSumatoriaSorteo.Location = New System.Drawing.Point(516, 140)
        Me.gbSumatoriaSorteo.Name = "gbSumatoriaSorteo"
        Me.gbSumatoriaSorteo.Size = New System.Drawing.Size(216, 86)
        Me.gbSumatoriaSorteo.TabIndex = 45
        Me.gbSumatoriaSorteo.TabStop = False
        Me.gbSumatoriaSorteo.Text = "7 - Sumatoria entre los 6 números"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(14, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 15)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Límite superior:"
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(32, 527)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(82, 34)
        Me.btnCerrar.TabIndex = 49
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'gbDiferenciaMinMax
        '
        Me.gbDiferenciaMinMax.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbDiferenciaMinMax.Controls.Add(Me.Label3)
        Me.gbDiferenciaMinMax.Controls.Add(Me.nudDifMaxima)
        Me.gbDiferenciaMinMax.Controls.Add(Me.nudDifMinima)
        Me.gbDiferenciaMinMax.Controls.Add(Me.Label2)
        Me.gbDiferenciaMinMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDiferenciaMinMax.Location = New System.Drawing.Point(516, 238)
        Me.gbDiferenciaMinMax.Name = "gbDiferenciaMinMax"
        Me.gbDiferenciaMinMax.Size = New System.Drawing.Size(216, 92)
        Me.gbDiferenciaMinMax.TabIndex = 51
        Me.gbDiferenciaMinMax.TabStop = False
        Me.gbDiferenciaMinMax.Text = "8 - Diferencia mín. y máx. entre números contiguos:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Mínima:"
        '
        'nudDifMaxima
        '
        Me.nudDifMaxima.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDifMaxima.Location = New System.Drawing.Point(123, 57)
        Me.nudDifMaxima.Maximum = New Decimal(New Integer() {37, 0, 0, 0})
        Me.nudDifMaxima.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudDifMaxima.Name = "nudDifMaxima"
        Me.nudDifMaxima.Size = New System.Drawing.Size(47, 22)
        Me.nudDifMaxima.TabIndex = 55
        Me.nudDifMaxima.Value = New Decimal(New Integer() {13, 0, 0, 0})
        '
        'nudDifMinima
        '
        Me.nudDifMinima.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDifMinima.Location = New System.Drawing.Point(123, 32)
        Me.nudDifMinima.Maximum = New Decimal(New Integer() {37, 0, 0, 0})
        Me.nudDifMinima.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudDifMinima.Name = "nudDifMinima"
        Me.nudDifMinima.Size = New System.Drawing.Size(47, 22)
        Me.nudDifMinima.TabIndex = 54
        Me.nudDifMinima.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Máxima:"
        '
        'chkSeleccionarTodas
        '
        Me.chkSeleccionarTodas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkSeleccionarTodas.AutoSize = True
        Me.chkSeleccionarTodas.Location = New System.Drawing.Point(35, 188)
        Me.chkSeleccionarTodas.MaximumSize = New System.Drawing.Size(176, 17)
        Me.chkSeleccionarTodas.MinimumSize = New System.Drawing.Size(176, 17)
        Me.chkSeleccionarTodas.Name = "chkSeleccionarTodas"
        Me.chkSeleccionarTodas.Size = New System.Drawing.Size(176, 17)
        Me.chkSeleccionarTodas.TabIndex = 52
        Me.chkSeleccionarTodas.Text = "Seleccionar todas"
        Me.chkSeleccionarTodas.UseVisualStyleBackColor = True
        '
        'lstSorteos
        '
        Me.lstSorteos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lstSorteos.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lstSorteos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSorteos.ForeColor = System.Drawing.Color.Green
        Me.lstSorteos.FormattingEnabled = True
        Me.lstSorteos.ItemHeight = 15
        Me.lstSorteos.Location = New System.Drawing.Point(32, 336)
        Me.lstSorteos.Name = "lstSorteos"
        Me.lstSorteos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstSorteos.Size = New System.Drawing.Size(127, 184)
        Me.lstSorteos.TabIndex = 53
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(152, 26)
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Image = CType(resources.GetObject("CopiarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CopiarToolStripMenuItem.Text = "&Copiar"
        '
        'txtPrimos
        '
        Me.txtPrimos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimos.Location = New System.Drawing.Point(9, 32)
        Me.txtPrimos.Name = "txtPrimos"
        Me.txtPrimos.Size = New System.Drawing.Size(35, 22)
        Me.txtPrimos.TabIndex = 55
        Me.txtPrimos.Text = "1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.txtCantUnDigito)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(514, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(218, 66)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "5 - Cantidad de números con sólo un dígito:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox5.Controls.Add(Me.txtPrimos)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(516, 336)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(216, 70)
        Me.GroupBox5.TabIndex = 58
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "9 - Cantidad mínima de nros. primos"
        '
        'gbNumeroExcluir
        '
        Me.gbNumeroExcluir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbNumeroExcluir.Controls.Add(Me.txtExcluir3)
        Me.gbNumeroExcluir.Controls.Add(Me.txtExcluir2)
        Me.gbNumeroExcluir.Controls.Add(Me.txtExcluir1)
        Me.gbNumeroExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbNumeroExcluir.Location = New System.Drawing.Point(516, 412)
        Me.gbNumeroExcluir.Name = "gbNumeroExcluir"
        Me.gbNumeroExcluir.Size = New System.Drawing.Size(216, 56)
        Me.gbNumeroExcluir.TabIndex = 61
        Me.gbNumeroExcluir.TabStop = False
        Me.gbNumeroExcluir.Text = "10 - Nros. a excluir"
        '
        'txtExcluir3
        '
        Me.txtExcluir3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExcluir3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExcluir3.Location = New System.Drawing.Point(64, 26)
        Me.txtExcluir3.MaxLength = 2
        Me.txtExcluir3.Name = "txtExcluir3"
        Me.txtExcluir3.Size = New System.Drawing.Size(25, 22)
        Me.txtExcluir3.TabIndex = 63
        '
        'txtExcluir2
        '
        Me.txtExcluir2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExcluir2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExcluir2.Location = New System.Drawing.Point(38, 26)
        Me.txtExcluir2.MaxLength = 2
        Me.txtExcluir2.Name = "txtExcluir2"
        Me.txtExcluir2.Size = New System.Drawing.Size(25, 22)
        Me.txtExcluir2.TabIndex = 62
        '
        'txtExcluir1
        '
        Me.txtExcluir1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExcluir1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExcluir1.Location = New System.Drawing.Point(12, 26)
        Me.txtExcluir1.MaxLength = 2
        Me.txtExcluir1.Name = "txtExcluir1"
        Me.txtExcluir1.Size = New System.Drawing.Size(25, 22)
        Me.txtExcluir1.TabIndex = 61
        '
        'btnGenerar
        '
        Me.btnGenerar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.Image = CType(resources.GetObject("btnGenerar.Image"), System.Drawing.Image)
        Me.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGenerar.Location = New System.Drawing.Point(32, 210)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(84, 55)
        Me.btnGenerar.TabIndex = 47
        Me.btnGenerar.Text = "                              Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'frmArmarJugada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(781, 587)
        Me.Controls.Add(Me.gbNumeroExcluir)
        Me.Controls.Add(Me.lstSorteos)
        Me.Controls.Add(Me.chkSeleccionarTodas)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.gbDiferenciaMinMax)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chklstOpciones)
        Me.Controls.Add(Me.gbPares)
        Me.Controls.Add(Me.gbSumatoriaSorteo)
        Me.Controls.Add(Me.gbSorteoAnterior)
        Me.Controls.Add(Me.chkUnParConsecutivos)
        Me.Controls.Add(Me.gbMasFrecuentes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmArmarJugada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Armar jugada"
        Me.gbMasFrecuentes.ResumeLayout(False)
        Me.gbMasFrecuentes.PerformLayout()
        Me.gbPares.ResumeLayout(False)
        Me.gbPares.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbSorteoAnterior.ResumeLayout(False)
        Me.gbSorteoAnterior.PerformLayout()
        CType(Me.NumericUpDownSuperior, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownInferior, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSumatoriaSorteo.ResumeLayout(False)
        Me.gbSumatoriaSorteo.PerformLayout()
        Me.gbDiferenciaMinMax.ResumeLayout(False)
        Me.gbDiferenciaMinMax.PerformLayout()
        CType(Me.nudDifMaxima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDifMinima, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.gbNumeroExcluir.ResumeLayout(False)
        Me.gbNumeroExcluir.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCantPares As System.Windows.Forms.TextBox
    Friend WithEvents lblCol1 As System.Windows.Forms.Label
    Friend WithEvents lblCol2 As System.Windows.Forms.Label
    Friend WithEvents lblCol3 As System.Windows.Forms.Label
    Friend WithEvents lblCol4 As System.Windows.Forms.Label
    Friend WithEvents lblCol5 As System.Windows.Forms.Label
    Friend WithEvents lblCol6 As System.Windows.Forms.Label
    Friend WithEvents gbMasFrecuentes As System.Windows.Forms.GroupBox
    Friend WithEvents chklstOpciones As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gbPares As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTerminacion As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents gbSorteoAnterior As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumSorteoAnterior As System.Windows.Forms.TextBox
    Friend WithEvents txtCantUnDigito As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chkUnParConsecutivos As System.Windows.Forms.CheckBox
    Friend WithEvents NumericUpDownSuperior As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDownInferior As System.Windows.Forms.NumericUpDown
    Friend WithEvents gbSumatoriaSorteo As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents gbDiferenciaMinMax As System.Windows.Forms.GroupBox
    Friend WithEvents rbSorteoAnteriorManual As System.Windows.Forms.RadioButton
    Friend WithEvents rbSorteoAnteriorAutom As System.Windows.Forms.RadioButton
    Friend WithEvents chkSeleccionarTodas As System.Windows.Forms.CheckBox
    Friend WithEvents lstSorteos As System.Windows.Forms.ListBox
    Friend WithEvents txtPrimos As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents mtbCol1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbCol2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbCol6 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbCol5 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbCol4 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbCol3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblIntervalo As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents gbNumeroExcluir As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nudDifMaxima As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudDifMinima As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtExcluir2 As System.Windows.Forms.TextBox
    Friend WithEvents txtExcluir1 As System.Windows.Forms.TextBox
    Friend WithEvents txtExcluir3 As System.Windows.Forms.TextBox
    Friend WithEvents txtIncluir3 As System.Windows.Forms.TextBox
    Friend WithEvents txtIncluir2 As System.Windows.Forms.TextBox
    Friend WithEvents txtIncluir1 As System.Windows.Forms.TextBox

End Class
