<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MasterBarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterTransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.tbHarga = New System.Windows.Forms.TextBox()
        Me.rbMakanan = New System.Windows.Forms.RadioButton()
        Me.rbMinuman = New System.Windows.Forms.RadioButton()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.dgvBarang = New System.Windows.Forms.DataGridView()
        Me.id_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btUbah = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btHapus = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.nudStock = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_totalItem = New System.Windows.Forms.TextBox()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PembelianToolStripMenuItem, Me.MasterBarangToolStripMenuItem, Me.MasterTransaksiToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PembelianToolStripMenuItem
        '
        Me.PembelianToolStripMenuItem.Name = "PembelianToolStripMenuItem"
        Me.PembelianToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.PembelianToolStripMenuItem.Text = "Pembelian"
        '
        'MasterBarangToolStripMenuItem
        '
        Me.MasterBarangToolStripMenuItem.Name = "MasterBarangToolStripMenuItem"
        Me.MasterBarangToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.MasterBarangToolStripMenuItem.Text = "Master Barang"
        '
        'MasterTransaksiToolStripMenuItem
        '
        Me.MasterTransaksiToolStripMenuItem.Name = "MasterTransaksiToolStripMenuItem"
        Me.MasterTransaksiToolStripMenuItem.Size = New System.Drawing.Size(105, 20)
        Me.MasterTransaksiToolStripMenuItem.Text = "Master Transaksi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(301, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Master Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Barang/Item"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Jenis"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(436, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Harga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(436, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Stock"
        '
        'tbNama
        '
        Me.tbNama.Location = New System.Drawing.Point(163, 98)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(229, 20)
        Me.tbNama.TabIndex = 6
        '
        'tbHarga
        '
        Me.tbHarga.Location = New System.Drawing.Point(491, 98)
        Me.tbHarga.Name = "tbHarga"
        Me.tbHarga.Size = New System.Drawing.Size(173, 20)
        Me.tbHarga.TabIndex = 7
        '
        'rbMakanan
        '
        Me.rbMakanan.AutoSize = True
        Me.rbMakanan.Location = New System.Drawing.Point(163, 152)
        Me.rbMakanan.Name = "rbMakanan"
        Me.rbMakanan.Size = New System.Drawing.Size(70, 17)
        Me.rbMakanan.TabIndex = 8
        Me.rbMakanan.TabStop = True
        Me.rbMakanan.Text = "Makanan"
        Me.rbMakanan.UseVisualStyleBackColor = True
        '
        'rbMinuman
        '
        Me.rbMinuman.AutoSize = True
        Me.rbMinuman.Location = New System.Drawing.Point(256, 152)
        Me.rbMinuman.Name = "rbMinuman"
        Me.rbMinuman.Size = New System.Drawing.Size(68, 17)
        Me.rbMinuman.TabIndex = 9
        Me.rbMinuman.TabStop = True
        Me.rbMinuman.Text = "Minuman"
        Me.rbMinuman.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(568, 149)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 10
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(660, 149)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'dgvBarang
        '
        Me.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_barang, Me.nama_barang, Me.Harga, Me.Stock, Me.btUbah, Me.btHapus})
        Me.dgvBarang.Location = New System.Drawing.Point(46, 188)
        Me.dgvBarang.Name = "dgvBarang"
        Me.dgvBarang.Size = New System.Drawing.Size(698, 250)
        Me.dgvBarang.TabIndex = 12
        '
        'id_barang
        '
        Me.id_barang.HeaderText = "ID Barang"
        Me.id_barang.Name = "id_barang"
        '
        'nama_barang
        '
        Me.nama_barang.HeaderText = "Nama Barang"
        Me.nama_barang.Name = "nama_barang"
        '
        'Harga
        '
        Me.Harga.HeaderText = "Harga"
        Me.Harga.Name = "Harga"
        '
        'Stock
        '
        Me.Stock.HeaderText = "Stock"
        Me.Stock.Name = "Stock"
        '
        'btUbah
        '
        Me.btUbah.HeaderText = ""
        Me.btUbah.Name = "btUbah"
        Me.btUbah.Text = "UBAH"
        Me.btUbah.UseColumnTextForButtonValue = True
        '
        'btHapus
        '
        Me.btHapus.HeaderText = ""
        Me.btHapus.Name = "btHapus"
        Me.btHapus.Text = "HAPUS"
        Me.btHapus.UseColumnTextForButtonValue = True
        '
        'nudStock
        '
        Me.nudStock.Location = New System.Drawing.Point(491, 150)
        Me.nudStock.Name = "nudStock"
        Me.nudStock.Size = New System.Drawing.Size(71, 20)
        Me.nudStock.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(565, 466)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Total Item"
        '
        'tb_totalItem
        '
        Me.tb_totalItem.Location = New System.Drawing.Point(644, 462)
        Me.tb_totalItem.Name = "tb_totalItem"
        Me.tb_totalItem.Size = New System.Drawing.Size(100, 20)
        Me.tb_totalItem.TabIndex = 15
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'MasterBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 510)
        Me.Controls.Add(Me.tb_totalItem)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.nudStock)
        Me.Controls.Add(Me.dgvBarang)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.rbMinuman)
        Me.Controls.Add(Me.rbMakanan)
        Me.Controls.Add(Me.tbHarga)
        Me.Controls.Add(Me.tbNama)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MasterBarang"
        Me.Text = "MasterBarang"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PembelianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterTransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbNama As TextBox
    Friend WithEvents tbHarga As TextBox
    Friend WithEvents rbMakanan As RadioButton
    Friend WithEvents rbMinuman As RadioButton
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents dgvBarang As DataGridView
    Friend WithEvents nudStock As NumericUpDown
    Friend WithEvents id_barang As DataGridViewTextBoxColumn
    Friend WithEvents nama_barang As DataGridViewTextBoxColumn
    Friend WithEvents Harga As DataGridViewTextBoxColumn
    Friend WithEvents Stock As DataGridViewTextBoxColumn
    Friend WithEvents btUbah As DataGridViewButtonColumn
    Friend WithEvents btHapus As DataGridViewButtonColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_totalItem As TextBox
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
End Class
