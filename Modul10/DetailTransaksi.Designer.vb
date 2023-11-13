<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailTransaksi
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbInvoice = New System.Windows.Forms.TextBox()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.dgvDetail = New System.Windows.Forms.DataGridView()
        Me.namaItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btBack = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Invoice"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Pembeli"
        '
        'tbInvoice
        '
        Me.tbInvoice.Location = New System.Drawing.Point(206, 55)
        Me.tbInvoice.Name = "tbInvoice"
        Me.tbInvoice.ReadOnly = True
        Me.tbInvoice.Size = New System.Drawing.Size(173, 20)
        Me.tbInvoice.TabIndex = 2
        '
        'tbNama
        '
        Me.tbNama.Location = New System.Drawing.Point(206, 90)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.ReadOnly = True
        Me.tbNama.Size = New System.Drawing.Size(100, 20)
        Me.tbNama.TabIndex = 3
        '
        'dgvDetail
        '
        Me.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.namaItem, Me.harga, Me.jumlah, Me.subtotal})
        Me.dgvDetail.Location = New System.Drawing.Point(53, 152)
        Me.dgvDetail.Name = "dgvDetail"
        Me.dgvDetail.Size = New System.Drawing.Size(544, 171)
        Me.dgvDetail.TabIndex = 4
        '
        'namaItem
        '
        Me.namaItem.HeaderText = "Nama Item"
        Me.namaItem.Name = "namaItem"
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
        Me.subtotal.HeaderText = "Sub Total"
        Me.subtotal.Name = "subtotal"
        '
        'btBack
        '
        Me.btBack.Location = New System.Drawing.Point(53, 354)
        Me.btBack.Name = "btBack"
        Me.btBack.Size = New System.Drawing.Size(75, 23)
        Me.btBack.TabIndex = 5
        Me.btBack.Text = "Kembali"
        Me.btBack.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(424, 359)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "TOTAL   Rp"
        '
        'tbTotal
        '
        Me.tbTotal.Location = New System.Drawing.Point(496, 355)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.ReadOnly = True
        Me.tbTotal.Size = New System.Drawing.Size(100, 20)
        Me.tbTotal.TabIndex = 7
        '
        'DetailTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 450)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btBack)
        Me.Controls.Add(Me.dgvDetail)
        Me.Controls.Add(Me.tbNama)
        Me.Controls.Add(Me.tbInvoice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DetailTransaksi"
        Me.Text = "DetailTransaksi"
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbInvoice As TextBox
    Friend WithEvents tbNama As TextBox
    Friend WithEvents dgvDetail As DataGridView
    Friend WithEvents namaItem As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents jumlah As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents btBack As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tbTotal As TextBox
End Class
