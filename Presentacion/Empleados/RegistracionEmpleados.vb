Imports System.Windows.Forms

Public Class RegistracionEmpleados
    Private Sub RegistracionEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tablaA As New Data.DataTable
        Dim tablaB As New Data.DataTable
        conexion.ConnectionString = "Data Source=DESKTOP-PP344HH;Initial Catalog=SistemaGimnasio;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from EmpleadoFuncion where empFuncionActivo = 1"
        tablaA.Load(cmd.ExecuteReader())
        cmd.CommandText = "Select* from EmpleadoHorario"
        tablaB.Load(cmd.ExecuteReader())
        cmb_funcion.DataSource = tablaA
        cmb_funcion.DisplayMember = "empFuncionDescripcion"
        cmb_funcion.ValueMember = "empFuncionId"
        cmb_funcion.SelectedIndex = -1
        cmb_horario.DataSource = tablaB
        cmb_horario.DisplayMember = "empHoraInicio"
        cmb_horario.ValueMember = "empHorId"
        cmb_horario.SelectedIndex = -1
        conexion.Close()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tablaA As New Data.DataTable
        conexion.ConnectionString = "Data Source=DESKTOP-PP344HH;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Empleado (empApellido, empNombre, empFuncionId, empDomicilio, empHorId ,empActivo) values(" & txt_apellido.Text & "','" & txt_nombre.Text & "'," & cmb_funcion.SelectedValue & "," & cmb_horario.SelectedValue & ",1"
        cmd.ExecuteNonQuery()
        txt_apellido.Text = 0
        txt_nombre.Text = ""
        txt_direccion.Text = 0
        txt_documento.Value = 0
        cmb_funcion.SelectedIndex = -1
        cmb_horario.SelectedIndex = -1
        MsgBox("Empleado registrado exitosamente")
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        LimpiarCampos()
    End Sub


    Private Sub LimpiarCampos()

        txt_apellido.Text = ""
        txt_nombre.Text = ""
        txt_direccion.Text = ""
        cmb_funcion.SelectedValue = 0
        cmb_horario.SelectedIndex = -1
        checkActivo.Checked = False



    End Sub

    Private Sub btn_buscar_Click_1(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tablaA As New Data.DataTable
        conexion.ConnectionString = "Data Source=DESKTOP-PP344HH;Initial Catalog=SistemaGimnasio;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from Empleado where empApellido =" & txt_apellido.Text
        tablaA.Load(cmd.ExecuteReader())
        If tablaA.Rows.Count = 0 Then
            MessageBox.Show("No existe el Empleado")
        Else

            txt_apellido.Text = tablaA.Rows(0).Item(1)
            txt_nombre.Text = tablaA.Rows(0).Item(2).ToString()
            txt_documento.Value = tablaA.Rows(0).Item(3)
            cmb_funcion.SelectedValue = tablaA.Rows(0).Item(4)
            txt_direccion.Text = tablaA.Rows(0).Item(5).ToString()
            cmb_horario.SelectedValue = tablaA.Rows(0).Item(6).ToString()
            If tablaA.Rows(0).Item(7).ToString() = 1 Then
                checkActivo.Checked = True
            Else
                checkActivo.Checked = False

            End If
        End If
    End Sub
End Class