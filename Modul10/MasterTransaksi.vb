Imports MySql.Data.MySqlClient
Public Class MasterTransaksi
    Dim conn As New MySqlConnection
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet

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
        Try
            ds.Clear()
            da = New MySqlDataAdapter("select*from tbl_transaksi", conn)
            da.Fill(ds, "transaksi")
            dgvMaster.Rows.Clear()
            If ds.Tables("transaksi").Rows.Count > 0 Then
                dgvMaster.Visible = True
                For i As Integer = 0 To ds.Tables("transaksi").Rows.Count - 1
                    dgvMaster.Rows.Add(ds.Tables("transaksi").Rows(i).Item(0).ToString,
                                         ds.Tables("transaksi").Rows(i).Item(1).ToString,
                                         ds.Tables("transaksi").Rows(i).Item(2).ToString)
                Next
            Else
                dgvMaster.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub MasterTransaksi_Load(sender As Object, e As EventArgs) Handles Me.Load
        koneksi()
        tampil_data()
        Dim total As Integer = 0
        For Each row As DataGridViewRow In dgvMaster.Rows
            If row.Cells("total").Value IsNot Nothing Then
                total += row.Cells("total").Value
            End If
        Next
        tbSubtotal.Text = total
    End Sub

    Private Sub btBack_Click(sender As Object, e As EventArgs) Handles btBack.Click
        FormPembelian.Show()
        Me.Dispose()
        Me.Hide()
    End Sub

    Public no_Invoice As String
    Public nama_pembeli As String
    Private Sub dgvMaster_DoubleClick(sender As Object, e As EventArgs) Handles dgvMaster.DoubleClick
        Try
            If dgvMaster.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = dgvMaster.SelectedRows(0)
                no_Invoice = selectedRow.Cells("invoice").Value.ToString()
                nama_pembeli = selectedRow.Cells("nama").Value.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        clear()
        Me.Hide()
        DetailTransaksi.Show()
        Me.Dispose()

    End Sub
End Class