Imports System.Text
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.IO

Public Class frmBackup

    Private Sub btnExaminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExaminar.Click
        Dim sBase As String = objConexion.Database
        Dim sNumDia, sMes, sAño, sHora, sMinuto As String
        Dim sFecha As String

        sAño = Year(Now) : sMes = Month(Now) : sNumDia = Day(Now) : sHora = Hour(Now) : sMinuto = Minute(Now)
        If Len(CStr(sMes)) < 2 Then sMes = "0" & sMes
        If Len(CStr(sNumDia)) < 2 Then sNumDia = "0" & sNumDia
        If Len(CStr(sHora)) < 2 Then sHora = "0" & sHora
        If Len(CStr(sMinuto)) < 2 Then sMinuto = "0" & sMinuto

        sFecha = sAño & sMes & sNumDia & sHora & sMinuto

        If Directory.Exists("C:\Program Files (x86)\Microsoft SQL Server\MSSQL.1\MSSQL\Backup\") Then
            SaveFileDialog1.InitialDirectory = "C:\Program Files (x86)\Microsoft SQL Server\MSSQL.1\MSSQL\Backup\"
        End If

        SaveFileDialog1.FileName = sBase & sFecha
        SaveFileDialog1.Filter = "Archivos de backup (*.bak)|*.bak"
        SaveFileDialog1.ShowDialog()
        txtDirPathBackup.Text = SaveFileDialog1.FileName

        Dim i As Byte = 0, UbiBarra As Byte
        For i = 1 To Len(txtDirPathBackup.Text)
            If Mid(txtDirPathBackup.Text, i, 1) = "\" Then UbiBarra = i
        Next
        If UbiBarra = 0 Then txtDirPathBackup.Text = ""

        If txtDirPathBackup.Text.Length <> 0 Then
            txtDirPathBackup.Text = txtDirPathBackup.Text
        End If
    End Sub

    Private Sub btnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackup.Click
        Dim sServidor As String = objConexion.Server

        Cursor = Cursors.WaitCursor
        If sServidor <> "" Then
            If txtDirPathBackup.Text <> "" Then
                If crear_backup() = True Then
                    MessageBox.Show("Backup creado satisfactoriamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnMostrarArchivo.Enabled = True
                End If
            Else
                MessageBox.Show("Seleccionar la ruta donde se creará el Backup.", "Carpeta", MessageBoxButtons.OK, MessageBoxIcon.Question)
            End If
        Else
            MessageBox.Show("Ingresar el Nombre del Servidor de Datos SQL", "Servidor Sql", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Cursor = Cursors.Arrow
    End Sub

    Private Function crear_backup() As Boolean
        Dim conecsb As New SqlConnectionStringBuilder
        Dim NombreBackup As String
        Dim sCmd As New StringBuilder

        conecsb.DataSource = objConexion.Server
        conecsb.InitialCatalog = "master"
        conecsb.IntegratedSecurity = True

        Using con As New SqlConnection(conecsb.ConnectionString)
            Try

                NombreBackup = Microsoft.VisualBasic.Right(txtDirPathBackup.Text, Len(txtDirPathBackup.Text) - PosicionBarra())
                con.Open()
                sCmd.Append("BACKUP DATABASE [" + objConexion.Database + "] TO  DISK = N'" + SaveFileDialog1.FileName + "' ")
                sCmd.Append("WITH DESCRIPTION = N'" + txtDescrip_Backup.Text + "', NOFORMAT, NOINIT")
                sCmd.Append(", NAME = N'" + NombreBackup + "', SKIP, NOREWIND, NOUNLOAD,  STATS = 10")
                Dim cmd As New SqlCommand(sCmd.ToString, con)
                cmd.ExecuteNonQuery()
                crear_backup = True
            Catch ex As Exception
                crear_backup = False
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Function

    Private Function PosicionBarra() As Integer
        Dim PosBarra As Integer

        For i = 1 To Len(txtDirPathBackup.Text)
            If Mid(txtDirPathBackup.Text, i, 1) = "\" Then
                PosBarra = i
            End If
        Next
        Return PosBarra
    End Function

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
        panel1.Text = ""
    End Sub

    Private Sub btnRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestore.Click
        Dim i As Integer, UbiPunto As Integer
        Dim NombreBackup As String = ""
        Dim sBackup As String

        For i = 1 To Len(txtBackup.Text)
            If Mid(txtBackup.Text, i, 1) = "." Then UbiPunto = i
        Next

        If UbiPunto <> 0 Then NombreBackup = txtBackup.Text

        If NombreBackup = "" Then
            MessageBox.Show("Falta seleccionar el archivo de backup." & vbCrLf & "No se restaurará.", "Falta archivo .bak", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        btnRestore.Enabled = False
        btnRestore.Refresh()

        sBackup = "USE Master; RESTORE DATABASE " & txtBaseRest.Text & " FROM DISK = '" & NombreBackup & "'" & " WITH REPLACE"

        Try
            Restaurar(sBackup)
            MessageBox.Show("Se ha restaurado la copia de la base de datos.", "Restauración de la base", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error " & Err.Number & ". " & ex.Message, "Error al restaurar la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try

        btnRestore.Text = "Restaurar copia"
        btnRestore.Enabled = True
        btnRestore.Refresh()
    End Sub

    Sub Restaurar(ByVal ConsultaRes As String)
        Dim com As SqlCommand = New SqlCommand(ConsultaRes, CN)
        Dim dr As SqlDataReader
        dr = com.ExecuteReader()
        dr.Close()
    End Sub

    Private Sub frmBackup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtServidorRest.Text = objConexion.Server
        txtBaseRest.Text = objConexion.Database
    End Sub

    Private Sub btnExaminarRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExaminarRes.Click
        If Directory.Exists("C:\Program Files (x86)\Microsoft SQL Server\MSSQL.1\MSSQL\Backup\") Then
            OpenFileDialog1.InitialDirectory = "C:\Program Files (x86)\Microsoft SQL Server\MSSQL.1\MSSQL\Backup\"
        End If

        'OpenFileDialog1.Filter = "Archivos de backup (*.bak, *.join)|*.bak; *.join"
        OpenFileDialog1.Filter = "Archivos de backup (*.bak)|*.bak"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtBackup.Text = OpenFileDialog1.FileName
        Else : Exit Sub
        End If
    End Sub

    Private Sub btnExaminar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnExaminar.KeyDown, txtDirPathBackup.KeyDown, btnBackup.KeyDown, txtServidorRest.KeyDown, txtBaseRest.KeyDown, txtBackup.KeyDown, btnExaminar.KeyDown, btnRestore.KeyDown, btnCerrar.KeyDown
        MostrarAyuda(Me, e)
    End Sub

    Private Sub btnMostrarArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrarArchivo.Click
        Dim Carpeta As String

        Dim i As Byte = 0, UbiBarra As Byte
        For i = 1 To Len(txtDirPathBackup.Text)
            If Mid(txtDirPathBackup.Text, i, 1) = "\" Then UbiBarra = i
        Next
        If UbiBarra = 0 Then Exit Sub

        Carpeta = Mid(txtDirPathBackup.Text, 1, UbiBarra - 1)
        Process.Start("explorer.exe", Carpeta)
    End Sub
End Class