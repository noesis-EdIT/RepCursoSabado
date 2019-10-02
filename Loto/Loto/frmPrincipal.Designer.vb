<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuArchivoCargar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuArchivoFiltrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuArchivoBases = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuArchivoBasesConfig = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuArchivoBasesBackup = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuArchivoSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuJugada = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuJugadaArmarJugada = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuJugadaParametros = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBuscar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBuscarBuscarJugada = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEstadisticas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEstadisticasNrosFrecuentes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEstadisticasNrosFrecuentesCol = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEstadisticasSumatoria = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEstadisticasPromedio = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEstadisticasAnalizarJugada = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEstadisticasAnalizarGrupoJugadas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEstadisticasVariacionDeUnNro = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVentanas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVentanasHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVentanasVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVentanasMosaicos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVentanasCerrarTodas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAyuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAyudaVer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAyudaAcercade = New System.Windows.Forms.ToolStripMenuItem()
        Me.SkinEngine1 = New Sunisoft.IrisSkin.SkinEngine(CType(Me, System.ComponentModel.Component))
        Me.lblLateralIzq = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblLateralDer = New System.Windows.Forms.Label()
        Me.picCerrar = New System.Windows.Forms.PictureBox()
        Me.lblIzquierda = New System.Windows.Forms.Label()
        Me.lblAbajo = New System.Windows.Forms.Label()
        Me.lblArriba = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnAdelante = New System.Windows.Forms.Button()
        Me.lblDerecha = New System.Windows.Forms.Label()
        Me.lblLink = New System.Windows.Forms.Label()
        Me.gbHelp = New System.Windows.Forms.GroupBox()
        Me.lblTaparArriba = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbHelp.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuArchivo, Me.mnuJugada, Me.mnuBuscar, Me.mnuEstadisticas, Me.mnuVentanas, Me.mnuAyuda})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.mnuVentanas
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(777, 25)
        Me.MenuStrip1.TabIndex = 31
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuArchivo
        '
        Me.mnuArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuArchivoCargar, Me.mnuArchivoFiltrar, Me.mnuArchivoBases, Me.mnuArchivoSalir})
        Me.mnuArchivo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuArchivo.Name = "mnuArchivo"
        Me.mnuArchivo.Size = New System.Drawing.Size(63, 21)
        Me.mnuArchivo.Text = "Archivo"
        '
        'mnuArchivoCargar
        '
        Me.mnuArchivoCargar.Name = "mnuArchivoCargar"
        Me.mnuArchivoCargar.Size = New System.Drawing.Size(165, 22)
        Me.mnuArchivoCargar.Text = "Cargar sorteo"
        '
        'mnuArchivoFiltrar
        '
        Me.mnuArchivoFiltrar.Name = "mnuArchivoFiltrar"
        Me.mnuArchivoFiltrar.Size = New System.Drawing.Size(165, 22)
        Me.mnuArchivoFiltrar.Text = "Filtrar datos"
        '
        'mnuArchivoBases
        '
        Me.mnuArchivoBases.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuArchivoBasesConfig, Me.mnuArchivoBasesBackup})
        Me.mnuArchivoBases.Name = "mnuArchivoBases"
        Me.mnuArchivoBases.Size = New System.Drawing.Size(165, 22)
        Me.mnuArchivoBases.Text = "Bases de datos"
        '
        'mnuArchivoBasesConfig
        '
        Me.mnuArchivoBasesConfig.Name = "mnuArchivoBasesConfig"
        Me.mnuArchivoBasesConfig.Size = New System.Drawing.Size(236, 22)
        Me.mnuArchivoBasesConfig.Text = "Config. conexión Sql Server"
        '
        'mnuArchivoBasesBackup
        '
        Me.mnuArchivoBasesBackup.Name = "mnuArchivoBasesBackup"
        Me.mnuArchivoBasesBackup.Size = New System.Drawing.Size(236, 22)
        Me.mnuArchivoBasesBackup.Text = "Backup / Restaurar"
        '
        'mnuArchivoSalir
        '
        Me.mnuArchivoSalir.Name = "mnuArchivoSalir"
        Me.mnuArchivoSalir.Size = New System.Drawing.Size(165, 22)
        Me.mnuArchivoSalir.Text = "Salir"
        '
        'mnuJugada
        '
        Me.mnuJugada.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuJugadaArmarJugada, Me.mnuJugadaParametros})
        Me.mnuJugada.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuJugada.Name = "mnuJugada"
        Me.mnuJugada.Size = New System.Drawing.Size(62, 21)
        Me.mnuJugada.Text = "Jugada"
        '
        'mnuJugadaArmarJugada
        '
        Me.mnuJugadaArmarJugada.Name = "mnuJugadaArmarJugada"
        Me.mnuJugadaArmarJugada.Size = New System.Drawing.Size(156, 22)
        Me.mnuJugadaArmarJugada.Text = "Armar jugada"
        '
        'mnuJugadaParametros
        '
        Me.mnuJugadaParametros.Name = "mnuJugadaParametros"
        Me.mnuJugadaParametros.Size = New System.Drawing.Size(156, 22)
        Me.mnuJugadaParametros.Text = "Parámetros"
        '
        'mnuBuscar
        '
        Me.mnuBuscar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBuscarBuscarJugada})
        Me.mnuBuscar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuBuscar.Name = "mnuBuscar"
        Me.mnuBuscar.Size = New System.Drawing.Size(58, 21)
        Me.mnuBuscar.Text = "Buscar"
        '
        'mnuBuscarBuscarJugada
        '
        Me.mnuBuscarBuscarJugada.Name = "mnuBuscarBuscarJugada"
        Me.mnuBuscarBuscarJugada.Size = New System.Drawing.Size(158, 22)
        Me.mnuBuscarBuscarJugada.Text = "Buscar jugada"
        '
        'mnuEstadisticas
        '
        Me.mnuEstadisticas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEstadisticasNrosFrecuentes, Me.mnuEstadisticasNrosFrecuentesCol, Me.mnuEstadisticasSumatoria, Me.mnuEstadisticasPromedio, Me.mnuEstadisticasAnalizarJugada, Me.mnuEstadisticasAnalizarGrupoJugadas, Me.mnuEstadisticasVariacionDeUnNro})
        Me.mnuEstadisticas.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuEstadisticas.Name = "mnuEstadisticas"
        Me.mnuEstadisticas.Size = New System.Drawing.Size(87, 21)
        Me.mnuEstadisticas.Text = "Estadísticas"
        '
        'mnuEstadisticasNrosFrecuentes
        '
        Me.mnuEstadisticasNrosFrecuentes.Name = "mnuEstadisticasNrosFrecuentes"
        Me.mnuEstadisticasNrosFrecuentes.Size = New System.Drawing.Size(249, 22)
        Me.mnuEstadisticasNrosFrecuentes.Text = "Nros. más frecuentes"
        '
        'mnuEstadisticasNrosFrecuentesCol
        '
        Me.mnuEstadisticasNrosFrecuentesCol.Name = "mnuEstadisticasNrosFrecuentesCol"
        Me.mnuEstadisticasNrosFrecuentesCol.Size = New System.Drawing.Size(249, 22)
        Me.mnuEstadisticasNrosFrecuentesCol.Text = "Nros. más frecuentes por col."
        '
        'mnuEstadisticasSumatoria
        '
        Me.mnuEstadisticasSumatoria.Name = "mnuEstadisticasSumatoria"
        Me.mnuEstadisticasSumatoria.Size = New System.Drawing.Size(249, 22)
        Me.mnuEstadisticasSumatoria.Text = "Sumatoria"
        '
        'mnuEstadisticasPromedio
        '
        Me.mnuEstadisticasPromedio.Name = "mnuEstadisticasPromedio"
        Me.mnuEstadisticasPromedio.Size = New System.Drawing.Size(249, 22)
        Me.mnuEstadisticasPromedio.Text = "Promedio"
        '
        'mnuEstadisticasAnalizarJugada
        '
        Me.mnuEstadisticasAnalizarJugada.Name = "mnuEstadisticasAnalizarJugada"
        Me.mnuEstadisticasAnalizarJugada.Size = New System.Drawing.Size(249, 22)
        Me.mnuEstadisticasAnalizarJugada.Text = "Analizar jugada"
        '
        'mnuEstadisticasAnalizarGrupoJugadas
        '
        Me.mnuEstadisticasAnalizarGrupoJugadas.Name = "mnuEstadisticasAnalizarGrupoJugadas"
        Me.mnuEstadisticasAnalizarGrupoJugadas.Size = New System.Drawing.Size(249, 22)
        Me.mnuEstadisticasAnalizarGrupoJugadas.Text = "Analizar varias jugadas"
        '
        'mnuEstadisticasVariacionDeUnNro
        '
        Me.mnuEstadisticasVariacionDeUnNro.Name = "mnuEstadisticasVariacionDeUnNro"
        Me.mnuEstadisticasVariacionDeUnNro.Size = New System.Drawing.Size(249, 22)
        Me.mnuEstadisticasVariacionDeUnNro.Text = "Variación de un mismo nro."
        '
        'mnuVentanas
        '
        Me.mnuVentanas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuVentanasHorizontal, Me.mnuVentanasVertical, Me.mnuVentanasMosaicos, Me.mnuVentanasCerrarTodas})
        Me.mnuVentanas.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuVentanas.Name = "mnuVentanas"
        Me.mnuVentanas.Size = New System.Drawing.Size(73, 21)
        Me.mnuVentanas.Text = "Ventanas"
        '
        'mnuVentanasHorizontal
        '
        Me.mnuVentanasHorizontal.Name = "mnuVentanasHorizontal"
        Me.mnuVentanasHorizontal.Size = New System.Drawing.Size(152, 22)
        Me.mnuVentanasHorizontal.Text = "Horizontal"
        '
        'mnuVentanasVertical
        '
        Me.mnuVentanasVertical.Name = "mnuVentanasVertical"
        Me.mnuVentanasVertical.Size = New System.Drawing.Size(152, 22)
        Me.mnuVentanasVertical.Text = "Vertical"
        '
        'mnuVentanasMosaicos
        '
        Me.mnuVentanasMosaicos.Name = "mnuVentanasMosaicos"
        Me.mnuVentanasMosaicos.Size = New System.Drawing.Size(152, 22)
        Me.mnuVentanasMosaicos.Text = "Mosaicos"
        '
        'mnuVentanasCerrarTodas
        '
        Me.mnuVentanasCerrarTodas.Name = "mnuVentanasCerrarTodas"
        Me.mnuVentanasCerrarTodas.Size = New System.Drawing.Size(152, 22)
        Me.mnuVentanasCerrarTodas.Text = "Cerrar todas"
        '
        'mnuAyuda
        '
        Me.mnuAyuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAyudaVer, Me.mnuAyudaAcercade})
        Me.mnuAyuda.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuAyuda.Name = "mnuAyuda"
        Me.mnuAyuda.Size = New System.Drawing.Size(56, 21)
        Me.mnuAyuda.Text = "Ayuda"
        '
        'mnuAyudaVer
        '
        Me.mnuAyudaVer.Name = "mnuAyudaVer"
        Me.mnuAyudaVer.Size = New System.Drawing.Size(149, 22)
        Me.mnuAyudaVer.Text = "Ver la ayuda"
        '
        'mnuAyudaAcercade
        '
        Me.mnuAyudaAcercade.Name = "mnuAyudaAcercade"
        Me.mnuAyudaAcercade.Size = New System.Drawing.Size(149, 22)
        Me.mnuAyudaAcercade.Text = "Acerca de..."
        '
        'SkinEngine1
        '
        Me.SkinEngine1.SerialNumber = "n7cKULtvGKV9Xvrwywp6jEjZtTJqexLVUVJm+5BfuNMgk1tYsIPRmw=="
        Me.SkinEngine1.SkinFile = "C:\Program Files (x86)\Sunisoft\IrisSkin\Skins\Diamond\DiamondGreen.ssk"
        Me.SkinEngine1.SkinStreamMain = CType(resources.GetObject("SkinEngine1.SkinStreamMain"), System.IO.Stream)
        '
        'lblLateralIzq
        '
        Me.lblLateralIzq.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLateralIzq.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblLateralIzq.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLateralIzq.Location = New System.Drawing.Point(1, 5)
        Me.lblLateralIzq.Name = "lblLateralIzq"
        Me.lblLateralIzq.Size = New System.Drawing.Size(4, 514)
        Me.lblLateralIzq.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.BackColor = System.Drawing.Color.DimGray
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(0, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(3, 521)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Label1"
        '
        'lblLateralDer
        '
        Me.lblLateralDer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLateralDer.BackColor = System.Drawing.Color.DimGray
        Me.lblLateralDer.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLateralDer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLateralDer.Location = New System.Drawing.Point(204, 0)
        Me.lblLateralDer.Name = "lblLateralDer"
        Me.lblLateralDer.Size = New System.Drawing.Size(4, 519)
        Me.lblLateralDer.TabIndex = 40
        Me.lblLateralDer.Text = "Label1"
        '
        'picCerrar
        '
        Me.picCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picCerrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCerrar.Cursor = System.Windows.Forms.Cursors.Default
        Me.picCerrar.Image = CType(resources.GetObject("picCerrar.Image"), System.Drawing.Image)
        Me.picCerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picCerrar.Location = New System.Drawing.Point(176, 11)
        Me.picCerrar.Name = "picCerrar"
        Me.picCerrar.Size = New System.Drawing.Size(19, 17)
        Me.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCerrar.TabIndex = 53
        Me.picCerrar.TabStop = False
        '
        'lblIzquierda
        '
        Me.lblIzquierda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblIzquierda.BackColor = System.Drawing.Color.Black
        Me.lblIzquierda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblIzquierda.Location = New System.Drawing.Point(13, 35)
        Me.lblIzquierda.Name = "lblIzquierda"
        Me.lblIzquierda.Size = New System.Drawing.Size(1, 452)
        Me.lblIzquierda.TabIndex = 54
        Me.lblIzquierda.Text = "Label12"
        '
        'lblAbajo
        '
        Me.lblAbajo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAbajo.BackColor = System.Drawing.Color.Black
        Me.lblAbajo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAbajo.Location = New System.Drawing.Point(13, 486)
        Me.lblAbajo.Name = "lblAbajo"
        Me.lblAbajo.Size = New System.Drawing.Size(188, 1)
        Me.lblAbajo.TabIndex = 55
        Me.lblAbajo.Text = "Label11"
        '
        'lblArriba
        '
        Me.lblArriba.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblArriba.BackColor = System.Drawing.Color.Black
        Me.lblArriba.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblArriba.Location = New System.Drawing.Point(13, 35)
        Me.lblArriba.Name = "lblArriba"
        Me.lblArriba.Size = New System.Drawing.Size(188, 1)
        Me.lblArriba.TabIndex = 56
        Me.lblArriba.Text = "Label10"
        '
        'btnAtras
        '
        Me.btnAtras.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAtras.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAtras.Image = CType(resources.GetObject("btnAtras.Image"), System.Drawing.Image)
        Me.btnAtras.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAtras.Location = New System.Drawing.Point(31, 496)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(71, 22)
        Me.btnAtras.TabIndex = 57
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnAdelante
        '
        Me.btnAdelante.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAdelante.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAdelante.Image = CType(resources.GetObject("btnAdelante.Image"), System.Drawing.Image)
        Me.btnAdelante.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAdelante.Location = New System.Drawing.Point(108, 496)
        Me.btnAdelante.Name = "btnAdelante"
        Me.btnAdelante.Size = New System.Drawing.Size(71, 22)
        Me.btnAdelante.TabIndex = 58
        Me.btnAdelante.UseVisualStyleBackColor = True
        '
        'lblDerecha
        '
        Me.lblDerecha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDerecha.BackColor = System.Drawing.Color.Black
        Me.lblDerecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDerecha.Location = New System.Drawing.Point(202, 35)
        Me.lblDerecha.Name = "lblDerecha"
        Me.lblDerecha.Size = New System.Drawing.Size(1, 452)
        Me.lblDerecha.TabIndex = 57
        Me.lblDerecha.Text = "Label9"
        '
        'lblLink
        '
        Me.lblLink.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLink.AutoSize = True
        Me.lblLink.Location = New System.Drawing.Point(13, 16)
        Me.lblLink.Name = "lblLink"
        Me.lblLink.Size = New System.Drawing.Size(37, 13)
        Me.lblLink.TabIndex = 48
        Me.lblLink.Text = "lblLink"
        '
        'gbHelp
        '
        Me.gbHelp.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbHelp.Controls.Add(Me.lblLink)
        Me.gbHelp.Controls.Add(Me.lblTaparArriba)
        Me.gbHelp.Controls.Add(Me.lblDerecha)
        Me.gbHelp.Controls.Add(Me.btnAdelante)
        Me.gbHelp.Controls.Add(Me.btnAtras)
        Me.gbHelp.Controls.Add(Me.lblArriba)
        Me.gbHelp.Controls.Add(Me.lblAbajo)
        Me.gbHelp.Controls.Add(Me.lblIzquierda)
        Me.gbHelp.Controls.Add(Me.picCerrar)
        Me.gbHelp.Controls.Add(Me.lblLateralDer)
        Me.gbHelp.Controls.Add(Me.Label14)
        Me.gbHelp.Controls.Add(Me.WebBrowser1)
        Me.gbHelp.Controls.Add(Me.lblLateralIzq)
        Me.gbHelp.Cursor = System.Windows.Forms.Cursors.Default
        Me.gbHelp.Location = New System.Drawing.Point(570, 28)
        Me.gbHelp.Name = "gbHelp"
        Me.gbHelp.Size = New System.Drawing.Size(207, 521)
        Me.gbHelp.TabIndex = 44
        Me.gbHelp.TabStop = False
        Me.gbHelp.Visible = False
        '
        'lblTaparArriba
        '
        Me.lblTaparArriba.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTaparArriba.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTaparArriba.Location = New System.Drawing.Point(3, -2)
        Me.lblTaparArriba.Name = "lblTaparArriba"
        Me.lblTaparArriba.Size = New System.Drawing.Size(201, 8)
        Me.lblTaparArriba.TabIndex = 43
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(15, 37)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(186, 448)
        Me.WebBrowser1.TabIndex = 7
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 565)
        Me.Controls.Add(Me.gbHelp)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Name = "frmPrincipal"
        Me.Text = "Loto"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbHelp.ResumeLayout(False)
        Me.gbHelp.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuArchivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuArchivoCargar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuArchivoSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuJugada As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBuscar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBuscarBuscarJugada As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAyuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAyudaVer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAyudaAcercade As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuArchivoBases As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuArchivoBasesConfig As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuArchivoBasesBackup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuArchivoFiltrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEstadisticas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEstadisticasNrosFrecuentes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEstadisticasSumatoria As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEstadisticasAnalizarJugada As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEstadisticasVariacionDeUnNro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
    Friend WithEvents lblLateralIzq As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblLateralDer As System.Windows.Forms.Label
    Private WithEvents picCerrar As System.Windows.Forms.PictureBox
    Friend WithEvents lblIzquierda As System.Windows.Forms.Label
    Friend WithEvents lblAbajo As System.Windows.Forms.Label
    Friend WithEvents lblArriba As System.Windows.Forms.Label
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents btnAdelante As System.Windows.Forms.Button
    Friend WithEvents lblDerecha As System.Windows.Forms.Label
    Friend WithEvents lblLink As System.Windows.Forms.Label
    Friend WithEvents gbHelp As System.Windows.Forms.GroupBox
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents lblTaparArriba As System.Windows.Forms.Label
    Friend WithEvents mnuEstadisticasPromedio As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEstadisticasNrosFrecuentesCol As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVentanas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVentanasHorizontal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVentanasVertical As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVentanasMosaicos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVentanasCerrarTodas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuJugadaArmarJugada As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuJugadaParametros As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEstadisticasAnalizarGrupoJugadas As System.Windows.Forms.ToolStripMenuItem
End Class
