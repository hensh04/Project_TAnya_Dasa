<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBarang
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
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.txthrgbrg = New System.Windows.Forms.TextBox()
        Me.combojnsbrg = New System.Windows.Forms.ComboBox()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btncaribrg = New System.Windows.Forms.Button()
        Me.txtnm_brg = New System.Windows.Forms.TextBox()
        Me.txtkd_brg = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(409, 220)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnkeluar.TabIndex = 13
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'btnbatal
        '
        Me.btnbatal.Location = New System.Drawing.Point(409, 160)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(75, 45)
        Me.btnbatal.TabIndex = 12
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(409, 101)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(75, 45)
        Me.btnhapus.TabIndex = 11
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnubah
        '
        Me.btnubah.Location = New System.Drawing.Point(303, 206)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(75, 50)
        Me.btnubah.TabIndex = 10
        Me.btnubah.Text = "Ubah"
        Me.btnubah.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtStok)
        Me.GroupBox1.Controls.Add(Me.txthrgbrg)
        Me.GroupBox1.Controls.Add(Me.combojnsbrg)
        Me.GroupBox1.Controls.Add(Me.btnkeluar)
        Me.GroupBox1.Controls.Add(Me.btnbatal)
        Me.GroupBox1.Controls.Add(Me.btnhapus)
        Me.GroupBox1.Controls.Add(Me.btnubah)
        Me.GroupBox1.Controls.Add(Me.btnsimpan)
        Me.GroupBox1.Controls.Add(Me.btncaribrg)
        Me.GroupBox1.Controls.Add(Me.txtnm_brg)
        Me.GroupBox1.Controls.Add(Me.txtkd_brg)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(88, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(497, 262)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Barang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Stok"
        '
        'txtStok
        '
        Me.txtStok.Location = New System.Drawing.Point(180, 171)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(100, 22)
        Me.txtStok.TabIndex = 16
        '
        'txthrgbrg
        '
        Me.txthrgbrg.Location = New System.Drawing.Point(180, 136)
        Me.txthrgbrg.Name = "txthrgbrg"
        Me.txthrgbrg.Size = New System.Drawing.Size(100, 22)
        Me.txthrgbrg.TabIndex = 15
        '
        'combojnsbrg
        '
        Me.combojnsbrg.FormattingEnabled = True
        Me.combojnsbrg.Location = New System.Drawing.Point(180, 101)
        Me.combojnsbrg.MaxLength = 10
        Me.combojnsbrg.Name = "combojnsbrg"
        Me.combojnsbrg.Size = New System.Drawing.Size(131, 24)
        Me.combojnsbrg.TabIndex = 14
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(180, 206)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 50)
        Me.btnsimpan.TabIndex = 9
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btncaribrg
        '
        Me.btncaribrg.Location = New System.Drawing.Point(303, 40)
        Me.btncaribrg.Name = "btncaribrg"
        Me.btncaribrg.Size = New System.Drawing.Size(75, 23)
        Me.btncaribrg.TabIndex = 8
        Me.btncaribrg.Text = "Cari"
        Me.btncaribrg.UseVisualStyleBackColor = True
        '
        'txtnm_brg
        '
        Me.txtnm_brg.Location = New System.Drawing.Point(180, 67)
        Me.txtnm_brg.MaxLength = 35
        Me.txtnm_brg.Name = "txtnm_brg"
        Me.txtnm_brg.Size = New System.Drawing.Size(198, 22)
        Me.txtnm_brg.TabIndex = 5
        '
        'txtkd_brg
        '
        Me.txtkd_brg.Location = New System.Drawing.Point(180, 40)
        Me.txtkd_brg.MaxLength = 5
        Me.txtkd_brg.Name = "txtkd_brg"
        Me.txtkd_brg.Size = New System.Drawing.Size(100, 22)
        Me.txtkd_brg.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Harga Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Jenis Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Kode Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(267, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Entry Data Barang"
        '
        'FrmBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 381)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmBarang"
        Me.Text = "Form Entry Data Barang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnubah As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents combojnsbrg As System.Windows.Forms.ComboBox
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btncaribrg As System.Windows.Forms.Button
    Friend WithEvents txtnm_brg As System.Windows.Forms.TextBox
    Friend WithEvents txtkd_brg As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txthrgbrg As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtStok As System.Windows.Forms.TextBox
End Class
