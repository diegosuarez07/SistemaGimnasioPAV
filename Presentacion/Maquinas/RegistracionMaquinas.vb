Imports System.Windows.Forms

Public Class RegistracionMaquinas


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

            Dim cadenaConexion As String = "Provider=.NET Framework Data Provider for SQL Server;Data Source=localhost;Initial Catalog=SistemaGimnasio;Integrated Security=True"
            Dim conexion As New Data.OleDb.OleDbConnection
            conexion.ConnectionString = cadenaConexion

            Dim cmd As New Data.OleDb.OleDbCommand
            conexion.Open()
            Dim consulta As String = ""

            consulta = "insert into Maquina (maqnombre, maqdescripcion, provmaquinid, maqFechaCompra, areaEntrenid, maqactivo) values ('" & txt_nombre.Text & "','" & txt_descripcion.Text & "'," & cmb_prov.SelectedValue & "," & txt_date.Text.ToString() & "," & cmb_area.SelectedValue & ",1)"
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = consulta
            cmd.ExecuteNonQuery()

        End If
    End Sub
    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click

        LimpiarCampos()

    End Sub
    Private Sub LimpiarCampos()

        txt_nombre.Enabled = True

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

    End Sub
End Class