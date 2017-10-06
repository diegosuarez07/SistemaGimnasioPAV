Public Class RegistraciónProveedores
    Public nroTelProveedor, domicilioProveedor, descProveedor As String
    Public activoProveedor As Boolean
    Private Sub RegistraciónProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSsalir_Click(sender As Object, e As EventArgs) Handles btnSsalir.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If txtDescripcion.Text <> "" And txtDomicilio.Text <> "" And txtTelefono.Text <> "" Then
            RegistrarProveedor()
            MsgBox("Proveedor registrado exitosamente")
            LimpiarCampos()
        Else
            MsgBox("Ningun campo debe estar vacio")
        End If
    End Sub

    Private Sub LimpiarCampos()

        txtTelefono.Text = ""
        txtDomicilio.Text = ""
        txtDescripcion.Text = ""

    End Sub

    Private Sub RegistrarProveedor()
        descProveedor = txtDescripcion.Text
        domicilioProveedor = txtDomicilio.Text
        nroTelProveedor = txtTelefono.Text
        activoProveedor = True

        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cadenaConexion As String = "Data Source=DESKTOP-PP344HH;Initial Catalog=SistemaGimnasio;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        conexion.ConnectionString = cadenaConexion

        Dim cmd As New Data.SqlClient.SqlCommand


        conexion.Open()

        Dim consulta As String = ""

        consulta = "insert into ProveedorMaquina (provMaquinDescripcion, provMaquinDomicilio, provMaquinTelefono, provMaquinActivo) "
        consulta &= "values ('" & Me.descProveedor & "'"
        consulta &= ", '" & Me.domicilioProveedor & "'"
        consulta &= ", '" & Me.nroTelProveedor & "'"
        consulta &= ", " & Me.activoProveedor & ")"


        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta
        cmd.Connection = conexion
        cmd.ExecuteNonQuery()

        conexion.Close()

    End Sub
End Class