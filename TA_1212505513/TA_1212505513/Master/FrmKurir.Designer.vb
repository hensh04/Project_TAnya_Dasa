<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmKurir
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btncarikur = New System.Windows.Forms.Button()
        Me.txtalmtkur = New System.Windows.Forms.TextBox()
        Me.txttlpkur = New System.Windows.Forms.TextBox()
        Me.txtnm_kur = New System.Windows.Forms.TextBox()
        Me.txtkd_kur = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(239, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Entry Data Kurir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnkeluar)
        Me.GroupBox1.Controls.Add(Me.btnbatal)
        Me.GroupBox1.Controls.Add(Me.btnhapus)
        Me.GroupBox1.Controls.Add(Me.btnubah)
        Me.GroupBox1.Controls.Add(Me.btnsimpan)
        Me.GroupBox1.Controls.Add(Me.btncarikur)
        Me.GroupBox1.Controls.Add(Me.txtalmtkur)
        Me.GroupBox1.Controls.Add(Me.txttlpkur)
        Me.GroupBox1.Controls.Add(Me.txtnm_kur)
        Me.GroupBox1.Controls.Add(Me.txtkd_kur)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(36, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(544, 274)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Kurir"
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(435, 228)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnkeluar.TabIndex = 13
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'btnbatal
        '
        Me.btnbatal.Location = New System.Drawing.Point(435, 148)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(75, 48)
        Me.btnbatal.TabIndex = 12
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(435, 92)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(75, 50)
        Me.btnhapus.TabIndex = 11
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnubah
        '
        Me.btnubah.Location = New System.Drawing.Point(303, 215)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(75, 49)
        Me.btnubah.TabIndex = 10
        Me.btnubah.Text = "Ubah"
        Me.btnubah.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(180, 215)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 49)
        Me.btnsimpan.TabIndex = 9
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btncarikur
        '
        Me.btncarikur.Location = New System.Drawing.Point(303, 40)
        Me.btncarikur.Name = "btncarikur"
        Me.btncarikur.Size = New System.Drawing.Size(75, 23)
        Me.btncarikur.TabIndex = 8
        Me.btncarikur.Text = "Cari"
        Me.btncarikur.UseVisualStyleBackColor = True
        '
        'txtalmtkur
        '
        Me.txtalmtkur.Location = New System.Drawing.Point(180, 137)
        Me.txtalmtkur.MaxLength = 55
        Me.txtalmtkur.Multiline = True
        Me.txtalmtkur.Name = "txtalmtkur"
        Me.txtalmtkur.Size = New System.Drawing.Size(198, 59)
        Me.txtalmtkur.TabIndex = 7
        '
        'txttlpkur
        '
        Me.txttlpkur.Location = New System.Drawing.Point(180, 100)
        Me.txttlpkur.MaxLength = 12
        Me.txttlpkur.Name = "txttlpkur"
        Me.txttlpkur.Size = New System.Drawing.Size(123, 22)
        Me.txttlpkur.TabIndex = 6
        '
        'txtnm_kur
        '
        Me.txtnm_kur.Location = New System.Drawing.Point(180, 67)
        Me.txtnm_kur.MaxLength = 35
        Me.txtnm_kur.Name = "txtnm_kur"
        Me.txtnm_kur.Size = New System.Drawing.Size(198, 22)
        Me.txtnm_kur.TabIndex = 5
        '
        'txtkd_kur
        '
        Me.txtkd_kur.Location = New System.Drawing.Point(180, 40)
        Me.txtkd_kur.MaxLength = 3
        Me.txtkd_kur.Name = "txtkd_kur"
        Me.txtkd_kur.Size = New System.Drawing.Size(100, 22)
        Me.txtkd_kur.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Alamat Kurir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Telpon Kurir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama Kurir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Kode Kurir"
        '
        'FrmKurir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 358)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmKurir"
        Me.Text = "FrmKurir"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btncarikur As System.Windows.Forms.Button
    Friend WithEvents txtalmtkur As System.Windows.Forms.TextBox
    Friend WithEvents txttlpkur As System.Windows.Forms.TextBox
    Friend WithEvents txtnm_kur As System.Windows.Forms.TextBox
    Friend WithEvents txtkd_kur As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnubah As System.Windows.Forms.Button
End Class
