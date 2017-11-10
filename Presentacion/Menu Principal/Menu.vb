Public Class Menu

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub RegistraciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistraciónToolStripMenuItem.Click
        Dim regClientes As New RegistraciónClientes
        regClientes.ShowDialog()
    End Sub

    Private Sub RegistraciónToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RegistraciónToolStripMenuItem1.Click
        Dim regMaquinas As New RegistracionMaquinas
        regMaquinas.ShowDialog()
    End Sub

    Private Sub RegistraciónToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RegistraciónToolStripMenuItem2.Click
        Dim regProveedores As New RegistraciónProveedores
        regProveedores.ShowDialog()
    End Sub

    Private Sub RegistrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrToolStripMenuItem.Click
        Dim regEmpleados As New RegistracionEmpleados()
        regEmpleados.ShowDialog()
    End Sub

    Private Sub RegistraciónToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles RegistraciónToolStripMenuItem3.Click
        Dim regSuplementos As New RegistracionSuplemento
        regSuplementos.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim Factura As New Facturacion
        Factura.ShowDialog()
    End Sub

    Private Sub BuscarFacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarFacturaToolStripMenuItem.Click
        Dim buscarfactura As New Buscar_Factura
        Buscar_Factura.ShowDialog()
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        Dim informecliente As New Informes
        informecliente.ShowDialog()
    End Sub

    Private Sub SuplementoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuplementoToolStripMenuItem.Click
        Dim asd As New InfomeSup
        asd.ShowDialog()
    End Sub

    Private Sub EmpleadosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem1.Click
        Dim das As New InformeEmp
        das.ShowDialog()
    End Sub

    Private Sub MquinasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MquinasToolStripMenuItem.Click
        Dim qwe As New InformeMaq
        qwe.ShowDialog()
    End Sub

    Private Sub ProveedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem1.Click
        Dim xzx As New InformeProveedorvb
        xzx.ShowDialog()
    End Sub

    Private Sub EmpleadoPorAreaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadoPorAreaToolStripMenuItem.Click
        Dim aaa As New Graficoemp
        aaa.ShowDialog()
    End Sub

    Private Sub MaquinasPorAreaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaquinasPorAreaToolStripMenuItem.Click
        Dim grap As New GraficoMaq
        grap.ShowDialog()
    End Sub

    Private Sub MaquinasPorProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaquinasPorProveedorToolStripMenuItem.Click
        Dim rrr As New GraficoMaq2
        rrr.ShowDialog()
    End Sub
End Class