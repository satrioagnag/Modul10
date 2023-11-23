Imports MySql.Data.MySqlClient
Public Class struk
    Dim conn As New MySqlConnection
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet

    Public Property InvoiceNumber As String
    Public Property CustomerName As String

    Sub Koneksi()
        conn = New MySqlConnection("server=localhost" + "; user id=root" + "; password=" + "" + "; database=db_master")
    End Sub

    Sub Tampil_Data()
        Try
            da = New MySqlDataAdapter("SELECT
                                            t.no_invoice,
                                            t.nama_pembeli,
                                            b.nama_barang AS nama_barang,
                                            dt.jumlah AS jumlah,
                                            b.harga AS harga,
                                            dt.subtotal AS subtotal
                                       FROM
                                            tbl_transaksi t 
                                       JOIN 
                                            tbl_detailtransaksi dt ON t.no_invoice = dt.no_invoice
                                       LEFT JOIN
                                            tbl_barang b ON dt.id_barang = b.id_barang
                                       WHERE 
                                            dt.no_invoice = @no_invoice", conn)
            da.SelectCommand.Parameters.AddWithValue("@no_invoice", InvoiceNumber)
            da.Fill(ds, "xxx")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Form6_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ds.Clear()
        Koneksi()
        Try
            Dim report As New CrystalReport2

            Tampil_Data()
            report.SetDataSource(ds.Tables("xxx"))

            For Each paramField As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition In report.ParameterFields
                Select Case paramField.Name
                    Case "nama_pembeli"
                        paramField.CurrentValues.Clear()
                        paramField.CurrentValues.AddValue(CustomerName)
                        report.DataDefinition.ParameterFields(paramField.Name).ApplyCurrentValues(paramField.CurrentValues)
                    Case "id_transaksi"
                        paramField.CurrentValues.Clear()
                        paramField.CurrentValues.AddValue(InvoiceNumber)
                        report.DataDefinition.ParameterFields(paramField.Name).ApplyCurrentValues(paramField.CurrentValues)
                End Select
            Next

            CrystalReportViewer1.ReportSource = report
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message & vbCrLf & ex.StackTrace, "Crystal Reports Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class