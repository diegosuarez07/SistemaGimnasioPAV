Imports System.Windows.Forms
Imports Microsoft.Reporting.WinForms

Public Class GraficoMaq2
    Private Sub GraficoMaq2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim strconex As String
        Dim conex As New SqlClient.SqlConnection
        strconex = "Data Source=GASTON-5132\SQLEXPRESS;Initial Catalog=SistemaGimnasio;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        conex.ConnectionString = strconex
        conex.Open()
        Dim cmdrepo As New SqlClient.SqlCommand
        Dim ds As New DataSet4
        Dim rds As ReportDataSource = New ReportDataSource
        cmdrepo.CommandType = CommandType.Text
        cmdrepo.Connection = conex
        cmdrepo.CommandText = "Select a.maqId, a.maqNombre, a.maqDescripcion , b.provMaquinDescripcion , a.maqFechaCompra , a.areaEntrenId ,a.maqActivo  from Maquina a, Proveedormaquina b where a.provMaquinId= b.provMaquinId"
        ds.DataTable1.Load(cmdrepo.ExecuteReader())
        MessageBox.Show("Filas a mostrar: " & ds.DataTable1.Rows.Count().ToString())
        rds.Name = "DataSet1"
        rds.Value = ds.DataTable1
        With ReportViewer1
            .LocalReport.DataSources.Clear()
            .LocalReport.DataSources.Add(rds)
            .RefreshReport()
            .Refresh()
        End With
    End Sub

End Class