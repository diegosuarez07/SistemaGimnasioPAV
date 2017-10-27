Public Class Facturacion
    Dim _clienteid As Integer
    Private Sub btn_seleccionar_Click(sender As Object, e As EventArgs) Handles btn_seleccionar.Click
        If cmb_cliente.SelectedIndex <> -1 Then
            _clienteid = cmb_cliente.SelectedValue
            cmb_cliente.Enabled = False
            btn_seleccionar.Enabled = True
            DataGridView1.Enabled = True
            cmb_articulo.Enabled = True
            txt_cantidad.Enabled = True
            btn_añadir.Enabled = True
            btn_eliminar.Enabled = True
            btn_fin.Enabled = True
        Else
            MsgBox("No ha selecionado Cliente")
        End If
    End Sub

    Private Sub btn_añadir_Click(sender As Object, e As EventArgs) Handles btn_añadir.Click
        If txt_cantidad.Value > 0 Then
            Dim conexion As New Data.SqlClient.SqlConnection
            Dim cmd As New Data.SqlClient.SqlCommand
            Dim tablaA As New Data.DataTable
            conexion.ConnectionString = "Data Source=GASTON-5132\SQLEXPRESS;Initial Catalog=SistemaGimnasio;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Select * from Suplemento where supID = " & cmb_articulo.SelectedValue
            tablaA.Load(cmd.ExecuteReader())
            Dim NuevaFila() As String = {tablaA.Rows(0).Item(0).ToString(), tablaA.Rows(0).Item(1).ToString(), txt_cantidad.Value, tablaA.Rows(0).Item(4).ToString()}
            DataGridView1.Rows.Add(NuevaFila)
            txt_total.Text = txt_total.Text + (tablaA.Rows(0).Item(4) * txt_cantidad.Value)
            conexion.Close()
        Else
            MsgBox("Debe seleccionar por lo menos 1 articulo")
        End If
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim cantidad As String = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        Dim precio As String = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        txt_total.Text = txt_total.Text - (cantidad * precio)
        DataGridView1.Rows.Remove(DataGridView1.Rows(DataGridView1.SelectedCells.Item(0).RowIndex))

    End Sub

    Private Sub Facturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tablaA As New Data.DataTable
        Dim tablaB As New Data.DataTable
        conexion.ConnectionString = "Data Source=GASTON-5132\SQLEXPRESS;Initial Catalog=SistemaGimnasio;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * From Cliente"
        tablaA.Load(cmd.ExecuteReader())
        cmb_cliente.DataSource = tablaA
        cmb_cliente.ValueMember = "CliId"
        cmb_cliente.DisplayMember = "CliApellido"
        cmd.CommandText = "Select * From Suplemento"
        tablaB.Load(cmd.ExecuteReader())
        cmb_articulo.DataSource = tablaB
        cmb_articulo.DisplayMember = "supNombre"
        cmb_articulo.ValueMember = "supId"
        conexion.Close()
        cmb_cliente.SelectedIndex = -1
    End Sub

    Private Sub btn_fin_Click(sender As Object, e As EventArgs) Handles btn_fin.Click
        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tablaA As New Data.DataTable
        Dim ahora As DateTime = DateTime.Now.ToShortDateString()
        Dim asd As String = ahora.ToString("yyyy-MM-dd")
        Dim total As Integer = DataGridView1.Rows.Count
        Dim consulta As String = "Insert into FacturaCompra (CliId, fcoFechaCompra) values (" & _clienteid & ",'" & ahora & "')"
        Datos.AccesoBD.ejecutarConsulta(consulta)

        conexion.ConnectionString = "Data Source=GASTON-5132\SQLEXPRESS;Initial Catalog=SistemaGimnasio;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT TOP 1 * FROM FacturaCompra ORDER BY fcoId DESC"
        tablaA.Load(cmd.ExecuteReader())

        Dim i As Integer
        For i = 0 To total - 2
            Dim consulta2 As String = "Insert into  DetalleFacturaCompra (dfaId, supId, dfaCantidadSuplemento, dfaPresupuesto) values (" & tablaA.Rows(0).Item(0).ToString() & "," & DataGridView1.Rows(i).Cells(0).Value.ToString() & "," & DataGridView1.Rows(i).Cells(2).Value.ToString() & "," & (DataGridView1.Rows(i).Cells(2).Value.ToString() * DataGridView1.Rows(i).Cells(3).Value.ToString()) & ")"
            Datos.AccesoBD.ejecutarConsulta(consulta2)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class