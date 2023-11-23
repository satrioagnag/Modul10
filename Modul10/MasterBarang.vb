Imports MySql.Data.MySqlClient

Public Class MasterBarang
    Dim conn As New MySqlConnection
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet
    Private Sub PembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembelianToolStripMenuItem.Click
        FormPembelian.Show()
        Me.Dispose()
        Me.Hide()
    End Sub

    Private Sub MasterTransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterTransaksiToolStripMenuItem.Click
        MasterTransaksi.Show()
        Me.Dispose()
        Me.Hide()
    End Sub

    Sub koneksi()
        conn = New MySqlConnection("server= localhost" + ";user id=root" + "; password=" + "" + ";database=db_master")
    End Sub

    Private Sub MasterBarang_Load(sender As Object, e As EventArgs) Handles Me.Load
        koneksi()
        tampil_data()
    End Sub

    Sub showitem()
        ds.Clear()
        da = New MySqlDataAdapter("SELECT COUNT(*) AS jumlah_barang FROM tbl_barang;", conn)
    End Sub

    Sub clear()
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Then
                ctr.Text = ""
            ElseIf TypeOf ctr Is ComboBox Then
                DirectCast(ctr, ComboBox).SelectedItem = Nothing
            ElseIf TypeOf ctr Is RadioButton Then
                DirectCast(ctr, RadioButton).Checked = False
            ElseIf TypeOf ctr Is NumericUpDown Then
                DirectCast(ctr, NumericUpDown).Value = 0
            End If
        Next
    End Sub

    Sub tampil_data()
        Try
            ds.Clear()
            da = New MySqlDataAdapter("SELECT * FROM tbl_barang;", conn)
            da.Fill(ds, "barang")
            dgvBarang.Rows.Clear()

            For i As Integer = 0 To ds.Tables("barang").Rows.Count - 1
                dgvBarang.Rows.Add(ds.Tables("barang").Rows(i).Item(0).ToString,
                                    ds.Tables("barang").Rows(i).Item(1).ToString,
                                    ds.Tables("barang").Rows(i).Item(2).ToString,
                                    ds.Tables("barang").Rows(i).Item(3).ToString)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim id_barang As String = "0"
        If rbMakanan.Checked Then
            ds.Clear()
            da = New MySqlDataAdapter("SELECT CASE 
                                         WHEN MAX(CAST(SUBSTRING(id_barang, 2, 2) AS UNSIGNED)) IS NULL THEN 'F001'
                                         ELSE CONCAT('F', LPAD(MAX(CAST(SUBSTRING(id_barang, 2, 3) AS UNSIGNED)) + 1, 3, '0'))
                                       END AS nomor
                                       FROM tbl_barang
                                       WHERE id_barang LIKE 'F%';", conn)
            da.Fill(ds, "id")
            id_barang = ds.Tables("id").Rows(0).Item(0)
        ElseIf rbMinuman.Checked Then
            ds.Clear()
            da = New MySqlDataAdapter("SELECT CASE 
                                         WHEN MAX(CAST(SUBSTRING(id_barang, 2, 2) AS UNSIGNED)) IS NULL THEN 'D001'
                                         ELSE CONCAT('D', LPAD(MAX(CAST(SUBSTRING(id_barang, 2, 3) AS UNSIGNED)) + 1, 3, '0'))
                                       END AS nomor
                                       FROM tbl_barang
                                       WHERE id_barang LIKE 'D%';", conn)
            da.Fill(ds, "id")
            id_barang = ds.Tables("id").Rows(0).Item(0)
        Else
            MessageBox.Show("Pilih jenis terlebih dahulu")
        End If

        ds.Clear()
        da = New MySqlDataAdapter("insert into tbl_barang values (?,?,?,?)", conn)
        da.SelectCommand.Parameters.AddWithValue("id_barang", id_barang)
        da.SelectCommand.Parameters.AddWithValue("nama_barang", tbNama.Text)
        da.SelectCommand.Parameters.AddWithValue("harga", tbHarga.Text)
        da.SelectCommand.Parameters.AddWithValue("stock", nudStock.Value)
        da.Fill(ds, "data_barang")
        ds.Clear()
        MessageBox.Show("Data berhasil disimpan")
        clear()
        tampil_data()

    End Sub
    Dim id As String
    Private Sub dgvBarang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBarang.CellContentClick
        If e.ColumnIndex = dgvBarang.Columns("btHapus").Index AndAlso e.RowIndex >= 0 Then
            Dim result As DialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus menu ini?",
                                                          "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim id_barang As String = dgvBarang.Rows(e.RowIndex).Cells("id_barang").Value
                dgvBarang.Rows.RemoveAt(e.RowIndex)
                da = New MySqlDataAdapter("DELETE from tbl_barang where id_barang = '" & id_barang & "'", conn)
                da.Fill(ds, "delete")
                tampil_data()
            End If
        End If

        If e.ColumnIndex = dgvBarang.Columns("btUbah").Index AndAlso e.RowIndex >= 0 Then
            id = dgvBarang.Rows(e.RowIndex).Cells("id_barang").Value.ToString()
            tbNama.Text = dgvBarang.Rows(e.RowIndex).Cells("nama_barang").Value.ToString()
            tbHarga.Text = dgvBarang.Rows(e.RowIndex).Cells("harga").Value
            nudStock.Value = Integer.Parse(dgvBarang.Rows(e.RowIndex).Cells("stock").Value)
            Dim id_barang As String = dgvBarang.Rows(e.RowIndex).Cells("id_barang").Value.ToString()
            If id_barang.StartsWith("F") Then
                rbMakanan.Checked = True
                rbMinuman.Checked = False
            Else
                rbMakanan.Checked = False
                rbMinuman.Checked = True
            End If

        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin mengupdate menu ini?",
                                                        "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ds.Clear()
            da = New MySqlDataAdapter("UPDATE tbl_barang SET nama_barang = @nama_barang, harga = @harga, stock = @stock where id_barang = '" & id & "'", conn)
            da.SelectCommand.Parameters.AddWithValue("nama_barang", tbNama.Text)
            da.SelectCommand.Parameters.AddWithValue("harga", tbHarga.Text)
            da.SelectCommand.Parameters.AddWithValue("stock", nudStock.Text)
            da.Fill(ds, "data_barang")
            ds.Clear()
            tampil_data()
        End If
    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        crystal_report.Show()
        Me.Hide()
    End Sub
End Class