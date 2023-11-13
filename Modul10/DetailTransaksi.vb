Imports MySql.Data.MySqlClient
Public Class DetailTransaksi
    Dim conn As New MySqlConnection
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet
    Dim no_invoice As String = MasterTransaksi.no_Invoice
    Dim nama_pembeli As String = MasterTransaksi.nama_pembeli

    Sub koneksi()
        conn = New MySqlConnection("server= localhost" + ";user id=root" + "; password=" + "" + ";database=db_master")
    End Sub
    Sub clear()
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Then
                ctr.Text = ""
            ElseIf TypeOf ctr Is ComboBox Then
                DirectCast(ctr, ComboBox).SelectedItem = Nothing
            End If
        Next
    End Sub

    Sub tampil_data()
        ds.Clear()
        da = New MySqlDataAdapter(“SELECT
                                        b.nama_barang AS nama_barang,
                                        dt.jumlah AS jumlah,
                                        b.harga AS harga,
                                        dt.subtotal AS subtotal
                                    FROM
                                        tbl_transaksi t
                                    JOIN
                                        tbl_detailtransaksi dt ON t.no_invoice = dt.no_invoice
                                    JOIN
                                        tbl_barang b ON dt.id_barang = b.id_barang
                                    WHERE dt.no_invoice='" & no_invoice & "'", conn)
        da.Fill(ds, "detail")
        dgvDetail.Rows.Clear()
        For i As Integer = 0 To ds.Tables("detail").Rows.Count - 1
            dgvDetail.Rows.Add(ds.Tables("detail").Rows(i).Item(0).ToString,
                                ds.Tables("detail").Rows(i).Item(2).ToString,
                                ds.Tables("detail").Rows(i).Item(1).ToString,
                                ds.Tables("detail").Rows(i).Item(3).ToString)
        Next
    End Sub

    Private Sub DetailTransaksi_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        koneksi()
        tampil_data()
        tbInvoice.Text = no_invoice
        tbNama.Text = nama_pembeli
        Dim total As Integer = 0
        For Each row As DataGridViewRow In dgvDetail.Rows
            If row.Cells("subtotal").Value IsNot Nothing Then
                total += row.Cells("subtotal").Value
            End If
        Next
        tbTotal.Text = total
    End Sub

    Private Sub btBack_Click(sender As Object, e As EventArgs) Handles btBack.Click
        clear()
        Me.Dispose()
        MasterTransaksi.Show()
        Me.Hide()
    End Sub
End Class