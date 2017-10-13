Public Class AccesoBD
    Public Shared Function AbrirConexion()
        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand

        Dim cadenaConexion As String = "Data Source=GASTON-5132\SQLEXPRESS;Initial Catalog=SistemaGimnasio;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        conexion.ConnectionString = cadenaConexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text

        Return cmd
    End Function

    Public Shared Sub CerrarConexion(ByVal conex As Data.SqlClient.SqlConnection)
        conex.Close()
    End Sub

    Public Shared Sub ejecutarConsulta(ByVal consulta As String)
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd = AbrirConexion()

        cmd.CommandText = consulta
        cmd.ExecuteNonQuery()

    End Sub



End Class
