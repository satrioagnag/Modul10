﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterTransaksi
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
        Me.dgvMaster = New System.Windows.Forms.DataGridView()
        Me.Invoice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btBack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbSubtotal = New System.Windows.Forms.TextBox()
        CType(Me.dgvMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(302, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Master Transaksi"
        '
        'dgvMaster
        '
        Me.dgvMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMaster.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Invoice, Me.nama, Me.total})
        Me.dgvMaster.Location = New System.Drawing.Point(60, 79)
        Me.dgvMaster.Name = "dgvMaster"
        Me.dgvMaster.Size = New System.Drawing.Size(678, 252)
        Me.dgvMaster.TabIndex = 1
        '
        'Invoice
        '
        Me.Invoice.HeaderText = "No Invoice"
        Me.Invoice.Name = "Invoice"
        '
        'nama
        '
        Me.nama.HeaderText = "Nama Pembeli"
        Me.nama.Name = "nama"
        '
        'total
        '
        Me.total.HeaderText = "Total Pembelian"
        Me.total.Name = "total"
        '
        'btBack
        '
        Me.btBack.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btBack.Location = New System.Drawing.Point(60, 362)
        Me.btBack.Name = "btBack"
        Me.btBack.Size = New System.Drawing.Size(138, 23)
        Me.btBack.TabIndex = 2
        Me.btBack.Text = "Ke Form Pembelian"
        Me.btBack.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(470, 367)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Total Pemasukan    Rp"
        '
        'tbSubtotal
        '
        Me.tbSubtotal.Location = New System.Drawing.Point(592, 363)
        Me.tbSubtotal.Name = "tbSubtotal"
        Me.tbSubtotal.ReadOnly = True
        Me.tbSubtotal.Size = New System.Drawing.Size(140, 20)
        Me.tbSubtotal.TabIndex = 4
        '
        'MasterTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tbSubtotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btBack)
        Me.Controls.Add(Me.dgvMaster)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MasterTransaksi"
        Me.Text = "MasterTransaksi"
        CType(Me.dgvMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvMaster As DataGridView
    Friend WithEvents Invoice As DataGridViewTextBoxColumn
    Friend WithEvents nama As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents btBack As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents tbSubtotal As TextBox
End Class
