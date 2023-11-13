Imports MySql.Data.MySqlClient

Public Class FormPembelian
    Dim conn As New MySqlConnection
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet
    'membuat variabel untuk mencatat tanggal dan waktu transaksi(no 3)
    Dim tanggalTransaksi As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

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

    Sub isi_combobox()
        da = New MySqlDataAdapter("select * from tbl_barang order by id_barang", conn)
        da.Fill(ds, "barang")
        cbMenu.Items.Clear()
        For i As Integer = 0 To ds.Tables("barang").Rows.Count - 1
            cbMenu.Items.Add(ds.Tables("barang").Rows(i).Item(1).ToString())
        Next
    End Sub

    Sub Invoice()
        ds.Clear()
        da = New MySqlDataAdapter("SELECT 
                                    CASE WHEN 
                                    MAX(CAST(SUBSTRING(no_invoice, 5, 3) AS UNSIGNED)) 
                                    IS NULL THEN
                                    1 ELSE MAX(CAST(SUBSTRING(no_invoice, 5, 3) AS UNSIGNED)) + 1
                                    END AS nomor
                                    FROM (
                                        SELECT
                                        MAX(CAST(SUBSTRING(no_invoice, 9, 2) AS UNSIGNED)) AS bln,
                                        MAX(CAST(SUBSTRING(no_invoice, 12, 4) AS UNSIGNED)) AS thn,
                                        no_invoice
                                        FROM tbl_transaksi
                                        GROUP BY no_invoice) a
                                        WHERE a.bln = MONTH(NOW()) AND a.thn = YEAR (NOW());", conn)
        da.Fill(ds, "nomor")
        Dim num As Integer
        num = Integer.Parse(ds.Tables("nomor").Rows(0).Item(0))
        tbInvoice.Text = "INV/" & Format(num, "#0##") & "/" & Format(Now.Month, "0#") & "/" & Now.Year
    End Sub

    Private Sub FormPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            koneksi()
            isi_combobox()
            Invoice()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FormPembelian_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Invoice()
    End Sub

    Private Sub btTambah_Click(sender As Object, e As EventArgs) Handles btTambah.Click
        Try
            Dim nama_pembeli As String = tbPembeli.Text
            Dim nama_item As String = cbMenu.SelectedItem
            'variabel untuk menyimpan kondisi data pada datagridview apakah data yang dimasukan sudah ada atau belum(no 1)
            Dim existingRow As DataGridViewRow = Nothing

            'fungsi untuk mengecek apakah barang sudah ada atau belum di dalam datagridview(no 1)
            For Each row As DataGridViewRow In dgvTransaksi.Rows
                If row.Cells("namaItem").Value IsNot Nothing AndAlso row.Cells("namaItem").Value.ToString() = nama_item Then
                    existingRow = row
                    Exit For
                End If
            Next

            ds.Clear()
            da = New MySqlDataAdapter("SELECT stock FROM tbl_barang WHERE nama_barang='" & nama_item & "'", conn)
            da.Fill(ds, "barang")
            Dim stock As Integer = Integer.Parse(ds.Tables("barang").Rows(0).Item("stock"))

            'untuk mengecek apakah stok tersedia(no 4)
            If stock > 0 Then
                stock -= 1

                'fungsi if-else untuk memproses apakah data diupdate atau ditambahkan di datagridview(no 1)
                If existingRow IsNot Nothing Then

                    Dim jumlah As Integer = Integer.Parse(existingRow.Cells("jumlah").Value) + Integer.Parse(tbJumlah.Text)
                    existingRow.Cells("jumlah").Value = jumlah

                    Dim harga As Integer = Integer.Parse(existingRow.Cells("harga").Value)
                    existingRow.Cells("subtotal").Value = jumlah * harga
                Else
                    ds.Clear()
                    da = New MySqlDataAdapter("select harga from tbl_barang where nama_barang='" & cbMenu.SelectedItem.ToString() & "'", conn)
                    da.Fill(ds, "harga")
                    Dim harga As Integer = Integer.Parse(ds.Tables("harga").Rows(0).Item(0))
                    Dim jumlah As Integer = Integer.Parse(tbJumlah.Text)
                    Dim subtotal As Integer = jumlah * harga
                    dgvTransaksi.Rows.Add(nama_item, harga, jumlah, subtotal)
                End If

                Dim total As Integer = 0
                For Each row As DataGridViewRow In dgvTransaksi.Rows
                    If row.Cells("subtotal").Value IsNot Nothing Then
                        total += row.Cells("subtotal").Value
                    End If
                Next

                tbTotal.Text = total
                'fungsi untuk mengupdate stock barang(no 4)
                da = New MySqlDataAdapter("UPDATE tbl_barang SET stock='" & stock & "' WHERE nama_barang='" & nama_item & "'", conn)
                da.Fill(ds, "stock")

            Else
                MessageBox.Show("Stok habis")
            End If

            cbMenu.SelectedItem = Nothing
            tbJumlah.Text = String.Empty
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvTransaksi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransaksi.CellContentClick
        If e.ColumnIndex = dgvTransaksi.Columns("btRemove").Index AndAlso e.RowIndex >= 0 Then
            dgvTransaksi.Rows.RemoveAt(e.RowIndex)
        End If
        Dim total As Integer = 0
        For Each row As DataGridViewRow In dgvTransaksi.Rows
            If row.Cells("subtotal").Value IsNot Nothing Then
                total += row.Cells("subtotal").Value
            End If
        Next
        tbTotal.Text = total

    End Sub

    Private Sub btSelesai_Click(sender As Object, e As EventArgs) Handles btSelesai.Click
        Try
            ds.Clear()
            da = New MySqlDataAdapter("insert into tbl_transaksi Values (?,?,?,?)", conn)
            da.SelectCommand.Parameters.AddWithValue("no_invoice", tbInvoice.Text)
            da.SelectCommand.Parameters.AddWithValue("nama_pembeli", tbPembeli.Text)
            da.SelectCommand.Parameters.AddWithValue("total", tbTotal.Text)
            'command untuk menambahkan data tanggal ke database(no 3)
            da.SelectCommand.Parameters.AddWithValue("tanggal_transaksi", tanggalTransaksi)
            da.Fill(ds, "transaksi")
            ds.Clear()

            For i As Integer = 0 To dgvTransaksi.Rows.Count - 1
                Dim jumlah As Integer = dgvTransaksi.Rows(i).Cells("jumlah").Value
                Dim subtotal As Integer = dgvTransaksi.Rows(i).Cells("subtotal").Value
                Dim nama_item As String = dgvTransaksi.Rows(i).Cells("namaItem").Value
                ds.Clear()
                da = New MySqlDataAdapter("select id_barang from tbl_barang where nama_barang='" & nama_item & "'", conn)
                da.Fill(ds, "barang")
                If ds.Tables("barang").Rows.Count > 0 Then
                    Dim id_item As String = ds.Tables(0).Rows(0).Item(0)
                    If Not (jumlah = 0 OrElse subtotal = 0) Then
                        ds.Clear()
                        da = New MySqlDataAdapter("insert into tbl_detailtransaksi (no_invoice, id_barang, jumlah, subtotal) values (?,?,?,?)", conn)
                        da.SelectCommand.Parameters.AddWithValue("no_invoice", tbInvoice.Text)
                        da.SelectCommand.Parameters.AddWithValue("id_barang", id_item)
                        da.SelectCommand.Parameters.AddWithValue("jumlah", jumlah)
                        da.SelectCommand.Parameters.AddWithValue("subtotal", subtotal)
                        da.Fill(ds, "detail")
                    End If
                End If
            Next

            clear()
            MessageBox.Show("Data berhasil disimpan")
            Invoice()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btMaster_Click(sender As Object, e As EventArgs) Handles btMaster.Click
        clear()
        MasterTransaksi.Show()
        Me.Hide()
    End Sub

    'button untuk membersihkan semua inputan(no 2)
    Private Sub btBersihkan_Click(sender As Object, e As EventArgs) Handles btBersihkan.Click
        clear()
        For Each ctr In Me.Controls
            If TypeOf ctr Is DataGridView Then
                Dim dgv As DataGridView = DirectCast(ctr, DataGridView)
                dgv.Rows.Clear()
            End If
        Next
    End Sub
End Class
