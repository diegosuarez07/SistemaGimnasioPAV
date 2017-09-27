Public Class Menu

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub RegistraciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistraciónToolStripMenuItem.Click
        Dim form1 As New Form1
        form1.ShowDialog()
    End Sub

    Private Sub RegistraciónToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RegistraciónToolStripMenuItem1.Click
        Dim form2 As New Form2
        form2.ShowDialog()
    End Sub
End Class