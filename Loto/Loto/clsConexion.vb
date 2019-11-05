Imports System.Data.SqlClient

Public Class clsConexion
    Public Property Server As String
    Public Property Password As String
    Public Property User As String
    Public Property Database As String

    Dim connectionBD As New SqlConnection
    Private objTransaccion As SqlTransaction
    Private objComand As SqlCommand
    Private objDr As SqlDataReader
    Private objDa As SqlDataAdapter

    Public Function ProbarConexion(ByVal nuevaconexion As String) As Boolean
        connectionBD.ConnectionString = nuevaconexion
        If AbrirConexion() Then
            ProbarConexion = True
            CerrarConexion()
        Else : ProbarConexion = False
        End If
    End Function

    Private Function AbrirConexion() As Boolean
        Try
            connectionBD.Open()
            AbrirConexion = True
        Catch ex As Exception
            AbrirConexion = False
        End Try
    End Function

    Private Function CerrarConexion() As Boolean
        Try
            connectionBD.Close()
            CerrarConexion = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            CerrarConexion = False
        End Try
    End Function

    Public Sub Conectar()
        Try
            CN.Open()
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
    End Sub

    Public Sub EjecutarConsulta(ByVal Consulta As String)
        Dim Filas As Integer
        Dim com As SqlCommand = New SqlCommand(Consulta, CN)
        com.Connection = CN
        com.CommandText = Consulta
        Filas = com.ExecuteNonQuery
    End Sub

    Public Function EjecutarConsultaDR(ByVal consulta As String) As SqlDataReader   '<-- invocado para cargar lista
        objComand = New SqlCommand
        objComand.Connection = CN
        objComand.CommandText = consulta
        objComand.Transaction = objTransaccion
        objDr = objComand.ExecuteReader
        Return objDr
    End Function

    Public Function EjecutarConsultaDT(ByVal consulta As String) As DataTable       '<-- para cargar lista
        Dim dt As New DataTable

        objDa = New SqlDataAdapter(consulta, CN)
        objDa.SelectCommand.Transaction = objTransaccion
        objDa.Fill(dt)
        Return dt
    End Function

    Public Sub ConectarABase()
        CN = New SqlClient.SqlConnection
        'My.Settings.ConnectionString = "Data Source=" + txtServidor.Text + ";Initial Catalog=" + txtBaseDatos.Text + ";Persist Security Info=True;User ID=" + txtUsuario.Text + ";Password=" + txtContrasena.Text + ""
        CN.ConnectionString = "Data Source=" + Me.Server + ";Initial Catalog=" + Me.Database + ";Integrated Security=True"
        CN = New SqlConnection(CN.ConnectionString)
        Conectar()
    End Sub
End Class
