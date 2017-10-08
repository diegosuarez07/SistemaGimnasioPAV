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
End Class