Public Class RegistraciónClientes
    Public nombre, apellido, domicilio, nroTelefono, dni As String
    Public fechaNacimiento As DateTime
    Public cuota, planEntren As Integer
    Public activo As Boolean

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtApellido.Text <> "" And txtNombre.Text <> "" And txtDni.Text <> "" And txtDomicilio.Text <> "" And txtTelefono.Text <> "" And cmbCuota.SelectedValue <> -1 And cmbCuota.SelectedValue <> -1 Then
            RegistrarCliente()
            MsgBox("Cliente registrado exitosamente")
            LimpiarCampos()

        Else
            MsgBox("No debe haber ningun campo vacio")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LimpiarCampos()
    End Sub

    Private Sub RegistraciónClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub RegistrarCliente()
        nombre = txtNombre.Text
        apellido = txtApellido.Text
        dni = txtDni.Text
        domicilio = txtDomicilio.Text
        nroTelefono = txtTelefono.Text
        cuota = cmbCuota.SelectedValue
        fechaNacimiento = dtpFechaNacimiento.Value
        planEntren = cmbPlanEntrenamiento.SelectedValue
        activo = True


        Dim cadenaConexion As String = "Data Source=localhost;Initial Catalog=SistemaGimnasio;Integrated Security=True"
        Dim conexion As New Data.OleDb.OleDbConnection
        conexion.ConnectionString = cadenaConexion

        Dim cmd As New Data.OleDb.OleDbCommand
        conexion.Open()
        Dim consulta As String = ""

        consulta = "insert into Cliente (cliApellido, cliNombre, cliDni, cliTelefono, cliFechaNacimiento, cliDomicilio, planId, cuoId, cliActivo) "
        consulta &= "values ('" & Me.apellido & "'"
        consulta &= ", '" & Me.nombre & "'"
        consulta &= ", '" & Me.dni & "'"
        consulta &= ", '" & Me.nroTelefono & "'"
        consulta &= ", " & Me.fechaNacimiento & ""
        consulta &= ", '" & Me.domicilio & "'"
        consulta &= ", " & Me.planEntren & ""
        consulta &= ", " & Me.cuota & ""
        consulta &= ", " & Me.activo & ""


        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta
        cmd.Connection = conexion
        cmd.ExecuteNonQuery()
        conexion.Close()

    End Sub




    Private Sub LimpiarCampos()
        txtApellido.Text = ""
        txtDni.Text = ""
        txtDomicilio.Text = ""
        txtNombre.Text = ""
        txtTelefono.Text = ""
        cmbCuota.SelectedValue = -1
        cmbPlanEntrenamiento.SelectedValue = -1
    End Sub

End Class