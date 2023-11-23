Imports MySql.Data.MySqlClient
Public Class crystal_report
    Dim conn As New MySqlConnection
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet

    Sub koneksi()
        conn = New MySqlConnection("server= localhost" + ";user id=root" + "; password=" + "" + ";database=db_master")
    End Sub

    Sub tampil_data()
        da = New MySqlDataAdapter("select * from tbl_transaksi", conn)
        da.Fill(ds, "xxx")
    End Sub

    Private Sub btShow_Click(sender As Object, e As EventArgs) Handles btShow.Click
        ds.Clear()
        koneksi()
        Try
            Dim myrpt As New CrystalReport1
            tampil_data()
            myrpt.SetDataSource(ds.Tables("xxx"))
            CrystalReportViewer1.ReportSource = Nothing
            CrystalReportViewer1.ReportSource = myrpt

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


End Class