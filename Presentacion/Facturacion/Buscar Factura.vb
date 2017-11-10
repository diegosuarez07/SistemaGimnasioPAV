Public Class Buscar_Factura
    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tablaA As New Data.DataTable
        Dim tablaB As New Data.DataTable
        Dim tablaC As New Data.DataTable
        conexion.ConnectionString = "Data Source=GASTON-5132\SQLEXPRESS;Initial Catalog=SistemaGimnasio;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * From FacturaCompra where fcoId =" & txt_numerofac.Value
        tablaA.Load(cmd.ExecuteReader())
        If tablaA.Rows.Count = 0 Then
            MsgBox("No Existe esa Factura")
        Else
            Dim id_cliente As Integer = tablaA.Rows(0).Item(1)
            txt_fecha.Text = tablaA.Rows(0).Item(2).ToString()
            cmd.CommandText = "Select * from cliente where cliId = " & id_cliente
            tablaB.Load(cmd.ExecuteReader())
            txt_cliente.Text = tablaB.Rows(0).Item(1).ToString()
            Dim id_factura As Integer = tablaA.Rows(0).Item(0)
            cmd.CommandText = "Select * from DetalleFacturaCompra where dfaId = " & id_factura
            tablaC.Load(cmd.ExecuteReader())
            DataGridView1.DataSource = tablaC
            With DataGridView1
                .RowHeadersVisible = False
                .Columns(0).Visible = False
                .Columns(1).HeaderCell.Value = "Codigo Articulo"
                .Columns(2).HeaderCell.Value = "Cantidad"
                .Columns(3).HeaderCell.Value = "Precio Total"

            End With
            txt_cliente.Enabled = False
            txt_fecha.Enabled = False
            txt_numerofac.Enabled = False
            btn_buscar.Enabled = False
            DataGridView1.Enabled = False

        End If
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click


        txt_cliente.Text = ""
        txt_fecha.Text = ""
        txt_numerofac.Value = 0
        DataGridView1.DataSource = Nothing
        txt_numerofac.Enabled = True
        btn_buscar.Enabled = True

        Me.Close()


    End Sub

    Private Sub Buscar_Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class