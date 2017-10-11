Imports System.Windows.Forms

Public Class RegistracionMaquinas
    Dim id As Integer

    Private Sub txt_nombre_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombre.KeyPress

        If IsNumeric(e.KeyChar) = True Then
            e.KeyChar = ""
            MessageBox.Show("Se ha ingresado un nombre no valido")
        End If

    End Sub


    Private Sub cmd_save_Click(sender As Object, e As EventArgs) Handles cmd_save.Click
        If txt_nombre.Text = "" Or txt_descripcion.Text = "" Or txt_descripcion.Text = "" Or txt_date.Text = "" Then
            MessageBox.Show("Ha dejado algun campo vacio")

        ElseIf cmb_area.SelectedIndex = -1 Then
            MessageBox.Show("No se ha ingresado area de entrenamiento")
        ElseIf cmb_prov.SelectedIndex = -1 Then
            MessageBox.Show("No se ha ingresado proveedor")

        Else
            RegistrarMaquina()
            MsgBox("Maquina registrada correctamente")
            LimpiarCampos()


        End If
    End Sub
    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click

        HabilitarCampos()

    End Sub
    Private Sub LimpiarCampos()
        txt_date.Text = ""
        txt_nombre.Text = ""
        txt_descripcion.Text = ""
        cmb_area.SelectedIndex = -1
        cmb_prov.SelectedIndex = -1
    End Sub
    Private Sub RegistrarMaquina()
        Dim cadenaConexion As String = "Data Source=DESKTOP-PP344HH;Initial Catalog=SistemaGimnasio;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        Dim conexion As New Data.SqlClient.SqlConnection
        conexion.ConnectionString = cadenaConexion

        Dim cmd As New Data.SqlClient.SqlCommand
        conexion.Open()
        Dim consulta As String = ""

        consulta = "insert into Maquina (maqnombre, maqdescripcion, provmaquinid, maqFechaCompra, areaEntrenid, maqactivo) values ('" & txt_nombre.Text & "','" & txt_descripcion.Text & "'," & cmb_prov.SelectedValue & "," & txt_date.Text.ToString() & "," & cmb_area.SelectedValue & "," & 1 & ")"
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta
        cmd.ExecuteNonQuery()
        conexion.Close()
    End Sub
    Private Sub HabilitarCampos()

        txt_nombre.Enabled = True
        txt_date.Enabled = True
        cmb_area.Enabled = True
        txt_descripcion.Enabled = True
        cmb_prov.Enabled = True

        cmd_save.Enabled = True
    End Sub

    Private Sub cmd_exit_Click(sender As Object, e As EventArgs) Handles cmd_exit.Click
        Me.Close()
    End Sub

    Private Sub RegistracionMaquinas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Estas seguro que desea salir?", "ABM", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub RegistracionMaquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tablaA As New Data.DataTable
        Dim tablaB As New Data.DataTable
        Dim cadenaConexion As String
        cadenaConexion = "Data Source=DESKTOP-PP344HH;Initial Catalog=SistemaGimnasio;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        conexion.ConnectionString = cadenaConexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from ProveedorMaquina where provMaquinActivo = 1"
        tablaA.Load(cmd.ExecuteReader())
        cmb_prov.DataSource = tablaA
        cmb_prov.DisplayMember = "provMaquinDescripcion"
        cmb_prov.ValueMember = "provMaquinId"
        cmd.CommandText = "Select * from AreaEntrenamiento where areaEntrenActivo = 1"
        tablaB.Load(cmd.ExecuteReader())
        cmb_area.DataSource = tablaB
        cmb_area.ValueMember = "areaEntrenId"
        cmb_area.DisplayMember = "areaEntrenDescripcion"
        conexion.Close()
        cmb_prov.SelectedIndex = -1
        cmb_area.SelectedIndex = -1
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click

        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tablaA As New Data.DataTable
        conexion.ConnectionString = "Data Source=DESKTOP-PP344HH;Initial Catalog=SistemaGimnasio;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from Maquina where maqnombre = '" & txt_nombre.Text & "'" & " and cliActivo = 1"
        tablaA.Load(cmd.ExecuteReader())
        If tablaA.Rows.Count = 0 Then
            MsgBox("No existe la Maquina")
        Else
            id = tablaA.Rows(0).Item(0)
            txt_nombre.Text = tablaA.Rows(0).Item(1)
            txt_descripcion.Text = tablaA.Rows(0).Item(2)
            cmb_prov.SelectedValue = tablaA.Rows(0).Item(3)
            txt_date.Text = tablaA.Rows(0).Item(4)
            cmb_area.SelectedValue = tablaA.Rows(0).Item(5)
            cmd_save.Text = "Modificar"
            cmd_eliminar.Visible = True
        End If
    End Sub

    Private Sub cmd_eliminar_Click(sender As Object, e As EventArgs) Handles cmd_eliminar.Click
        EliminarCliente(id)
        MsgBox("Cliente dado de baja")
        LimpiarCampos()
        cmd_save.Text = "Guardar"
        cmd_eliminar.Visible = False
    End Sub

    Private Sub EliminarCliente(ByVal id As Integer)
        Dim conexion As New Data.SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=DESKTOP-PP344HH;Initial Catalog=SistemaGimnasio;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

        Dim cmd As New Data.SqlClient.SqlCommand
        conexion.Open()
        Dim consulta As String = ""

        consulta = "update Maquina set maqActivo = " & 0 & " where cliId = " & id
        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta
        cmd.Connection = conexion
        cmd.ExecuteNonQuery()
        conexion.Close()
    End Sub
End Class