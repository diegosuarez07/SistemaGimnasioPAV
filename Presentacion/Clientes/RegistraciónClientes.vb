Imports System.Data.SqlClient
Imports Datos

Public Class RegistraciónClientes
    Dim cadenaConexion As String = "Data Source=DESKTOP-PP344HH;Initial Catalog=SistemaGimnasio;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    Public id As Integer
    Public nombre, apellido, domicilio, nroTelefono, dni As String
    Public fechaNacimiento As DateTime
    Public cuota, planEntren As Integer
    Public activo As Boolean

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If txtApellido.Text <> "" And txtNombre.Text <> "" And txtDni.Text <> "" And txtDomicilio.Text <> "" And txtTelefono.Text <> "" And cmbCuota.SelectedValue <> -1 And cmbCuota.SelectedValue <> -1 Then
            If btnRegistrar.Text = "Registrar cliente" Then
                RegistrarCliente()
                MsgBox("Cliente registrado exitosamente")
                LimpiarCampos()
            Else
                ModificarCliente(id)
                MsgBox("Cliente modificado correctamente")
                LimpiarCampos()

            End If
            btnRegistrar.Text = "Registrar cliente"
            btnEliminar.Visible = False

        Else
            MsgBox("No debe haber ningun campo vacio")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LimpiarCampos()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tablaA As New Data.DataTable
        conexion.ConnectionString = "Data Source=DESKTOP-PP344HH;Initial Catalog=SistemaGimnasio;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from Cliente where cliApellido = '" & txtApellido.Text & "'" & " and cliActivo = " & 1
        tablaA.Load(cmd.ExecuteReader())
        If tablaA.Rows.Count = 0 Then
            MsgBox("No existe el Cliente")
        Else

            id = tablaA.Rows(0).Item(0)
            txtApellido.Text = tablaA.Rows(0).Item(1)
            txtNombre.Text = tablaA.Rows(0).Item(2).ToString()
            txtDni.Text = tablaA.Rows(0).Item(3)
            txtTelefono.Text = tablaA.Rows(0).Item(4)
            dtpFechaNacimiento.Value = tablaA.Rows(0).Item(5).ToString()
            txtDomicilio.Text = tablaA.Rows(0).Item(6).ToString()
            cmbPlanEntrenamiento.SelectedValue = tablaA.Rows(0).Item(7)
            cmbCuota.SelectedValue = tablaA.Rows(0).Item(8)

            btnRegistrar.Text = "Modificar"
            btnEliminar.Visible = True

        End If
    End Sub

    Private Sub RegistraciónClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tablaA As New Data.DataTable
        Dim tablaB As New Data.DataTable
        conexion.ConnectionString = cadenaConexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from PlanEntrenamiento where planActivo = 1"
        tablaA.Load(cmd.ExecuteReader())
        cmbPlanEntrenamiento.DataSource = tablaA
        cmbPlanEntrenamiento.DisplayMember = "planNombre"
        cmbPlanEntrenamiento.ValueMember = "planId"
        cmd.CommandText = "Select * from Cuota"
        tablaB.Load(cmd.ExecuteReader())
        cmbCuota.DataSource = tablaB
        cmbCuota.ValueMember = "cuoid"
        cmbCuota.DisplayMember = "cuoNombre"
        conexion.Close()
        cmbPlanEntrenamiento.SelectedIndex = -1
        cmbCuota.SelectedIndex = -1
    End Sub

    Private Sub ModificarCliente(ByVal id As Integer)

        nombre = txtNombre.Text
        apellido = txtApellido.Text
        dni = txtDni.Text
        domicilio = txtDomicilio.Text
        nroTelefono = txtTelefono.Text
        cuota = cmbCuota.SelectedValue
        fechaNacimiento = dtpFechaNacimiento.Value
        planEntren = cmbPlanEntrenamiento.SelectedValue
        activo = True

        Dim consulta As String = ""

        consulta = "update Cliente Set cliApellido = '" & txtApellido.Text & "', cliNombre = '" & txtNombre.Text & "', cliDni = '" & txtDni.Text & "', cliTelefono = '" & txtTelefono.Text & "', cliFechaNacimiento = " & dtpFechaNacimiento.Value & ", cliDomicilio = '" & txtDomicilio.Text & "', planId = " & cmbPlanEntrenamiento.SelectedValue & ", cuoId = " & cmbCuota.SelectedValue & ", cliActivo = " & 1 & " where cliId = " & id
        Datos.AccesoBD.ejecutarConsulta(consulta)


    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        EliminarCliente(id)
        MsgBox("Cliente dado de baja")
        LimpiarCampos()
        btnRegistrar.Text = "Registrar cliente"
        btnEliminar.Visible = False
    End Sub

    Private Sub EliminarCliente(ByVal id As Integer)

        Dim consulta As String = ""

        consulta = "update Cliente set cliActivo = " & 0 & " where cliId = " & id
        Datos.AccesoBD.ejecutarConsulta(consulta)



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

        Dim consulta As String = ""

        consulta = "insert into Cliente (cliApellido, cliNombre, cliDni, cliTelefono, cliFechaNacimiento, cliDomicilio, planId, cuoId, cliActivo) "
        consulta &= "values ('" & Me.txtApellido.Text & "','" & Me.txtNombre.Text & "','" & Me.txtDni.Text & "','" & Me.txtTelefono.Text & "'," & Date.Now.Date & ",'" & Me.txtDomicilio.Text & "'," & Me.cmbPlanEntrenamiento.SelectedValue & "," & Me.cmbCuota.SelectedValue & "," & 1 & ") "

        Datos.AccesoBD.ejecutarConsulta(consulta)



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