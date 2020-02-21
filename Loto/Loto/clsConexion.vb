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

    Public Function BuscarJugada(ByVal iNumSorteo As UShort, ByVal sContenido As String, ByVal dFechaInicialSql As Date, ByVal dFechaFinalSql As Date) As SqlDataReader
        Dim ComandoADO As SqlCommand
        Dim myReader As SqlDataReader
        Dim paramEntrada1, paramEntrada2, paramEntrada3, paramEntrada4 As SqlParameter

        ComandoADO = New SqlCommand("spBuscarSorteo", CN)
        ComandoADO.CommandType = CommandType.StoredProcedure

        paramEntrada1 = New SqlParameter("@NumSorteo", SqlDbType.Int, 5)
        paramEntrada1.Direction = ParameterDirection.Input
        paramEntrada1.Value = IIf(iNumSorteo = 0, DBNull.Value, iNumSorteo)
        ComandoADO.Parameters.Add(paramEntrada1)

        paramEntrada2 = New SqlParameter("@Sorteo", SqlDbType.VarChar, 12)
        paramEntrada2.Direction = ParameterDirection.Input
        paramEntrada2.Value = IIf(sContenido = "", DBNull.Value, sContenido)
        ComandoADO.Parameters.Add(paramEntrada2)

        paramEntrada3 = New SqlParameter("@Fecha1", SqlDbType.DateTime, 8)
        paramEntrada3.Direction = ParameterDirection.Input
        paramEntrada3.Value = IIf(dFechaInicialSql = #12:00:00 AM#, DBNull.Value, dFechaInicialSql)
        ComandoADO.Parameters.Add(paramEntrada3)

        paramEntrada4 = New SqlParameter("@Fecha2", SqlDbType.DateTime, 8)
        paramEntrada4.Direction = ParameterDirection.Input
        paramEntrada4.Value = IIf(dFechaFinalSql = #12:00:00 AM#, DBNull.Value, dFechaFinalSql)
        ComandoADO.Parameters.Add(paramEntrada4)

        myReader = ComandoADO.ExecuteReader()
        Return myReader
    End Function

    Public Function BuscarJugadaDA(ByVal iNumSorteo As UShort, ByVal sContenido As String, ByVal dFechaInicialSql As Date, ByVal dFechaFinalSql As Date) As SqlDataAdapter
        Dim ComandoADO As SqlCommand
        Dim paramEntrada1, paramEntrada2, paramEntrada3, paramEntrada4 As SqlParameter
        Dim objDa As SqlDataAdapter

        ComandoADO = New SqlCommand("spBuscarSorteo", CN)
        ComandoADO.CommandType = CommandType.StoredProcedure

        paramEntrada1 = New SqlParameter("@NumSorteo", SqlDbType.Int, 5)
        paramEntrada1.Direction = ParameterDirection.Input
        paramEntrada1.Value = IIf(iNumSorteo = 0, DBNull.Value, iNumSorteo)
        ComandoADO.Parameters.Add(paramEntrada1)

        paramEntrada2 = New SqlParameter("@Sorteo", SqlDbType.VarChar, 12)
        paramEntrada2.Direction = ParameterDirection.Input
        paramEntrada2.Value = IIf(sContenido = "", DBNull.Value, sContenido)
        ComandoADO.Parameters.Add(paramEntrada2)

        paramEntrada3 = New SqlParameter("@Fecha1", SqlDbType.DateTime, 8)
        paramEntrada3.Direction = ParameterDirection.Input
        paramEntrada3.Value = IIf(dFechaInicialSql = #12:00:00 AM#, DBNull.Value, dFechaInicialSql)
        ComandoADO.Parameters.Add(paramEntrada3)

        paramEntrada4 = New SqlParameter("@Fecha2", SqlDbType.DateTime, 8)
        paramEntrada4.Direction = ParameterDirection.Input
        paramEntrada4.Value = IIf(dFechaFinalSql = #12:00:00 AM#, DBNull.Value, dFechaFinalSql)
        ComandoADO.Parameters.Add(paramEntrada4)

        objDa = New SqlDataAdapter(ComandoADO)
        Return objDa
    End Function

    Public Sub ConectarABase()
        CN = New SqlClient.SqlConnection
        'My.Settings.ConnectionString = "Data Source=" + txtServidor.Text + ";Initial Catalog=" + txtBaseDatos.Text + ";Persist Security Info=True;User ID=" + txtUsuario.Text + ";Password=" + txtContrasena.Text + ""
        CN.ConnectionString = "Data Source=" + Me.Server + "; Initial Catalog=" + Me.Database + "; Integrated Security=True; MultipleActiveResultSets=true;"   '<-- permite varios datareaders sin necesidad de cerrarlos
        CN = New SqlConnection(CN.ConnectionString)
        Conectar()
    End Sub
End Class
