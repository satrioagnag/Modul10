<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPembelian
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbPembeli = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbMenu = New System.Windows.Forms.ComboBox()
        Me.tbInvoice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbJumlah = New System.Windows.Forms.TextBox()
        Me.btTambah = New System.Windows.Forms.Button()
        Me.dgvTransaksi = New System.Windows.Forms.DataGridView()
        Me.NamaItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btRemove = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.btSelesai = New System.Windows.Forms.Button()
        Me.btMaster = New System.Windows.Forms.Button()
        Me.btBersihkan = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterTransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Pembeli"
        '
        'tbPembeli
        '
        Me.tbPembeli.Location = New System.Drawing.Point(202, 43)
        Me.tbPembeli.Name = "tbPembeli"
        Me.tbPembeli.Size = New System.Drawing.Size(329, 20)
        Me.tbPembeli.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pilih Menu"
        '
        'cbMenu
        '
        Me.cbMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMenu.FormattingEnabled = True
        Me.cbMenu.Location = New System.Drawing.Point(202, 84)
        Me.cbMenu.Name = "cbMenu"
        Me.cbMenu.Size = New System.Drawing.Size(121, 21)
        Me.cbMenu.TabIndex = 3
        '
        'tbInvoice
        '
        Me.tbInvoice.Location = New System.Drawing.Point(574, 43)
        Me.tbInvoice.Name = "tbInvoice"
        Me.tbInvoice.ReadOnly = True
        Me.tbInvoice.Size = New System.Drawing.Size(157, 20)
        Me.tbInvoice.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(358, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Jumlah"
        '
        'tbJumlah
        '
        Me.tbJumlah.Location = New System.Drawing.Point(431, 85)
        Me.tbJumlah.Name = "tbJumlah"
        Me.tbJumlah.Size = New System.Drawing.Size(100, 20)
        Me.tbJumlah.TabIndex = 6
        '
        'btTambah
        '
        Me.btTambah.BackColor = System.Drawing.Color.Honeydew
        Me.btTambah.Location = New System.Drawing.Point(574, 82)
        Me.btTambah.Name = "btTambah"
        Me.btTambah.Size = New System.Drawing.Size(75, 23)
        Me.btTambah.TabIndex = 7
        Me.btTambah.Text = "Tambah"
        Me.btTambah.UseVisualStyleBackColor = False
        '
        'dgvTransaksi
        '
        Me.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransaksi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NamaItem, Me.harga, Me.jumlah, Me.subtotal, Me.btRemove})
        Me.dgvTransaksi.Location = New System.Drawing.Point(67, 169)
        Me.dgvTransaksi.Name = "dgvTransaksi"
        Me.dgvTransaksi.Size = New System.Drawing.Size(652, 136)
        Me.dgvTransaksi.TabIndex = 8
        '
        'NamaItem
        '
        Me.NamaItem.HeaderText = "Nama Item"
        Me.NamaItem.Name = "NamaItem"
        '
        'harga
        '
        Me.harga.HeaderText = "Harga"
        Me.harga.Name = "harga"
        '
        'jumlah
        '
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.Name = "jumlah"
        '
        'subtotal
        '
        Me.subtotal.HeaderText = "Subtotal"
        Me.subtotal.Name = "subtotal"
        '
        'btRemove
        '
        Me.btRemove.HeaderText = ""
        Me.btRemove.Name = "btRemove"
        Me.btRemove.Text = "REMOVE"
        Me.btRemove.UseColumnTextForButtonValue = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(553, 334)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Total = Rp"
        '
        'tbTotal
        '
        Me.tbTotal.Location = New System.Drawing.Point(619, 330)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.ReadOnly = True
        Me.tbTotal.Size = New System.Drawing.Size(100, 20)
        Me.tbTotal.TabIndex = 10
        '
        'btSelesai
        '
        Me.btSelesai.BackColor = System.Drawing.Color.SandyBrown
        Me.btSelesai.Location = New System.Drawing.Point(574, 376)
        Me.btSelesai.Name = "btSelesai"
        Me.btSelesai.Size = New System.Drawing.Size(75, 23)
        Me.btSelesai.TabIndex = 11
        Me.btSelesai.Text = "Selesai"
        Me.btSelesai.UseVisualStyleBackColor = False
        '
        'btMaster
        '
        Me.btMaster.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btMaster.Location = New System.Drawing.Point(67, 376)
        Me.btMaster.Name = "btMaster"
        Me.btMaster.Size = New System.Drawing.Size(145, 23)
        Me.btMaster.TabIndex = 12
        Me.btMaster.Text = "Ke Master Transaksi"
        Me.btMaster.UseVisualStyleBackColor = False
        '
        'btBersihkan
        '
        Me.btBersihkan.BackColor = System.Drawing.Color.Honeydew
        Me.btBersihkan.Location = New System.Drawing.Point(656, 82)
        Me.btBersihkan.Name = "btBersihkan"
        Me.btBersihkan.Size = New System.Drawing.Size(75, 23)
        Me.btBersihkan.TabIndex = 13
        Me.btBersihkan.Text = "Bersihkan"
        Me.btBersihkan.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PembelianToolStripMenuItem, Me.MasterBarangToolStripMenuItem, Me.MasterTransaksiToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(767, 24)
        Me.MenuStrip1.TabIndex = 14
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
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'FormPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btBersihkan)
        Me.Controls.Add(Me.btMaster)
        Me.Controls.Add(Me.btSelesai)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvTransaksi)
        Me.Controls.Add(Me.btTambah)
        Me.Controls.Add(Me.tbJumlah)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbInvoice)
        Me.Controls.Add(Me.cbMenu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbPembeli)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPembelian"
        Me.Text = "Form Pembelian"
        CType(Me.dgvTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbPembeli As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbMenu As ComboBox
    Friend WithEvents tbInvoice As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbJumlah As TextBox
    Friend WithEvents btTambah As Button
    Friend WithEvents dgvTransaksi As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents btSelesai As Button
    Friend WithEvents btMaster As Button
    Friend WithEvents NamaItem As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents jumlah As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents btRemove As DataGridViewButtonColumn
    Friend WithEvents btBersihkan As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PembelianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterTransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
End Class
