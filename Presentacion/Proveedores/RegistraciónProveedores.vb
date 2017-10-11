Public Class RegistraciónProveedores
    Public nroTelProveedor, domicilioProveedor, descProveedor As String
    Public activoProveedor As Boolean
    Public id As Integer
    Private Sub RegistraciónProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSsalir_Click(sender As Object, e As EventArgs) Handles btnSsalir.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    'Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

    '    If txtDescripcion.Text <> "" And txtDomicilio.Text <> "" And txtTelefono.Text <> "" Then
    '        RegistrarProveedor()
    '        MsgBox("Proveedor registrado exitosamente")
    '        LimpiarCampos()
    '    Else
    '        MsgBox("Ningun campo debe estar vacio")
    '    End If
    'End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If txtDescripcion.Text <> "" And txtDomicilio.Text <> "" And txtTelefono.Text <> "" Then
            If btnRegistrar.Text = "Registrar cliente" Then
                RegistrarProveedor()
                MsgBox("Cliente registrado exitosamente")
                LimpiarCampos()
            Else
                ModificarProveedor(id)
                MsgBox("Cliente modificado correctamente")
                LimpiarCampos()

            End If
            btnRegistrar.Text = "Registrar cliente"
            btn_eliminar.Visible = False

        Else
            MsgBox("No debe haber ningun campo vacio")
        End If
    End Sub


    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tablaA As New Data.DataTable
        conexion.ConnectionString = "Data Source=DESKTOP-PP344HH;Initial Catalog=SistemaGimnasio;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from proveedorMaquina where provMaquinaDescripcion = '" & txtDescripcion.Text & "'" & " and provMaquinaActivo = 1"
        tablaA.Load(cmd.ExecuteReader())
        If tablaA.Rows.Count = 0 Then
            MsgBox("No existe el Cliente")
        Else
            id = tablaA.Rows(0).Item(0)
            txtDescripcion.Text = tablaA.Rows(0).Item(1)
            txtDomicilio.Text = tablaA.Rows(0).Item(2)
            txtTelefono.Text = tablaA.Rows(0).Item(3)
        End If

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        EliminarCliente(id)
        MsgBox("Cliente dado de baja")
        LimpiarCampos()
        btnRegistrar.Text = "Registrar cliente"
        btn_eliminar.Visible = False
    End Sub

    Private Sub EliminarCliente(ByVal id As Integer)
        Dim conexion As New Data.SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-PP344HH;Initial Catalog=SistemaGimnasio;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

        Dim cmd As New Data.SqlClient.SqlCommand
        conexion.Open()
        Dim consulta As String = ""

        consulta = "update ProveedoresMquina set provMaquinaActivo = " & 0 & " where provMaquinaId = " & id
        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta
        cmd.Connection = conexion
        cmd.ExecuteNonQuery()
        conexion.Close()
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

        consulta = "insert into ProveedorMaquina (provMaquinDescripcion,provMaquinDomicilio,provMaquinTelefono,provMaquinActivo)"
        consulta &= "values ('" & Me.txtDescripcion.Text & "','" & Me.txtDomicilio.Text & "','" & Me.txtTelefono.Text & "'," & 1 & ") "


        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta
        cmd.Connection = conexion
        cmd.ExecuteNonQuery()

        conexion.Close()

    End Sub

    Private Sub ModificarProveedor(ByVal id As Integer)
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

        consulta = "Update ProveedorMaquina set provMaquinDescripcion = '" & Me.txtDescripcion.Text & "',provMaquinDomicilio = '" & Me.txtDomicilio.Text & "', provMaquinTelefono= '" & Me.txtTelefono.Text & "',provMaquinActivo = 1"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta
        cmd.Connection = conexion
        cmd.ExecuteNonQuery()
        conexion.Close()
    End Sub


End Class