Public Class RegistracionSuplemento
    Private Sub ABM_sumplementos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tablaA As New Data.DataTable
        conexion.ConnectionString = "Data Source=GASTON-5132\SQLEXPRESS;Initial Catalog=SistemaGimnasio;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from ProveedorSuplemento where provSuplemActivo = 1"
        tablaA.Load(cmd.ExecuteReader())
        cmb_proveedor.DataSource = tablaA
        cmb_proveedor.DisplayMember = "provSuplemNombre"
        cmb_proveedor.ValueMember = "provSuplemId"
        conexion.Close()
        cmb_proveedor.SelectedIndex = -1

    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tablaA As New Data.DataTable
        conexion.ConnectionString = "Data Source=GASTON-5132\SQLEXPRESS;Initial Catalog=SistemaGimnasio;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from Suplemento where supId = " & txt_codigo.Value
        tablaA.Load(cmd.ExecuteReader())
        If tablaA.Rows.Count = 0 Then
            Windows.Forms.MessageBox.Show("No existe el suplemento")
        Else

            txt_codigo.Value = tablaA.Rows(0).Item(0)
            txt_nombre.Text = tablaA.Rows(0).Item(1).ToString()
            txt_preciocompra.Value = tablaA.Rows(0).Item(2)
            txt_precioventa.Value = tablaA.Rows(0).Item(3).ToString()
            cmb_proveedor.SelectedValue = tablaA.Rows(0).Item(4).ToString()
            If tablaA.Rows(0).Item(5).ToString() = 1 Then
                ckb_activo.Checked = True
            Else
                ckb_activo.Checked = False



            End If
        End If
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        txt_nombre.Enabled = True
        txt_preciocompra.Enabled = True
        txt_precioventa.Enabled = True
        cmb_proveedor.Enabled = True
        ckb_activo.Enabled = True
        txt_codigo.Value = 0
        txt_nombre.Text = ""
        txt_preciocompra.Value = 0
        txt_precioventa.Value = 0
        cmb_proveedor.SelectedIndex = -1
        ckb_activo.Checked = False

        btn_guardar.Enabled = True

    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tablaA As New Data.DataTable
        conexion.ConnectionString = "Data Source=GASTON-5132\SQLEXPRESS;Initial Catalog=SistemaGimnasio;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Suplemento (supId , supNombre, supPrecioCompra, supPrecioVenta, provId, supActivo) values(" & txt_codigo.Value & ",'" & txt_nombre.Text & "'," & txt_preciocompra.Value & "," & txt_precioventa.Value & "," & cmb_proveedor.SelectedValue & ",1)"
        cmd.ExecuteNonQuery()
        txt_codigo.Value = 0
        txt_nombre.Text = ""
        txt_preciocompra.Value = 0
        txt_precioventa.Value = 0
        cmb_proveedor.SelectedIndex = -1

    End Sub

End Class