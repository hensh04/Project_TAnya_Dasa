<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcetakkwt
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
        Me.dtpTgl_kwit = New System.Windows.Forms.DateTimePicker()
        Me.txtNo_kwit = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNo_nota = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNm_cus = New System.Windows.Forms.TextBox()
        Me.txttotalbyr = New System.Windows.Forms.TextBox()
        Me.txtTerbilang = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtcari = New System.Windows.Forms.GroupBox()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.btn_cetak = New System.Windows.Forms.Button()
        Me.btncari = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.txtcari.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpTgl_kwit
        '
        Me.dtpTgl_kwit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTgl_kwit.Location = New System.Drawing.Point(171, 20)
        Me.dtpTgl_kwit.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpTgl_kwit.Name = "dtpTgl_kwit"
        Me.dtpTgl_kwit.Size = New System.Drawing.Size(265, 26)
        Me.dtpTgl_kwit.TabIndex = 9
        '
        'txtNo_kwit
        '
        Me.txtNo_kwit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNo_kwit.Location = New System.Drawing.Point(761, 20)
        Me.txtNo_kwit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNo_kwit.Name = "txtNo_kwit"
        Me.txtNo_kwit.Size = New System.Drawing.Size(160, 26)
        Me.txtNo_kwit.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 23)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Tanggal Kwitansi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(651, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "No Kwitansi"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNo_kwit)
        Me.GroupBox1.Controls.Add(Me.dtpTgl_kwit)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 68)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(944, 57)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(383, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 36)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Cetak Kwitansi"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtNo_nota
        '
        Me.txtNo_nota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNo_nota.Location = New System.Drawing.Point(159, 30)
        Me.txtNo_nota.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNo_nota.Name = "txtNo_nota"
        Me.txtNo_nota.Size = New System.Drawing.Size(160, 26)
        Me.txtNo_nota.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 30)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "No Nota"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, 82)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Nama Customer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(509, 26)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Total Bayar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(509, 82)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Terbilang"
        '
        'txtNm_cus
        '
        Me.txtNm_cus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNm_cus.Location = New System.Drawing.Point(160, 82)
        Me.txtNm_cus.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNm_cus.Name = "txtNm_cus"
        Me.txtNm_cus.Size = New System.Drawing.Size(160, 26)
        Me.txtNm_cus.TabIndex = 17
        '
        'txttotalbyr
        '
        Me.txttotalbyr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalbyr.Location = New System.Drawing.Point(672, 22)
        Me.txttotalbyr.Margin = New System.Windows.Forms.Padding(4)
        Me.txttotalbyr.Name = "txttotalbyr"
        Me.txttotalbyr.Size = New System.Drawing.Size(160, 26)
        Me.txttotalbyr.TabIndex = 18
        '
        'txtTerbilang
        '
        Me.txtTerbilang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTerbilang.Location = New System.Drawing.Point(672, 76)
        Me.txtTerbilang.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTerbilang.Multiline = True
        Me.txtTerbilang.Name = "txtTerbilang"
        Me.txtTerbilang.Size = New System.Drawing.Size(207, 54)
        Me.txtTerbilang.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(632, 30)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Rp."
        '
        'txtcari
        '
        Me.txtcari.Controls.Add(Me.btn_keluar)
        Me.txtcari.Controls.Add(Me.btn_batal)
        Me.txtcari.Controls.Add(Me.btn_cetak)
        Me.txtcari.Controls.Add(Me.btncari)
        Me.txtcari.Controls.Add(Me.Label8)
        Me.txtcari.Controls.Add(Me.txtTerbilang)
        Me.txtcari.Controls.Add(Me.txttotalbyr)
        Me.txtcari.Controls.Add(Me.txtNm_cus)
        Me.txtcari.Controls.Add(Me.Label7)
        Me.txtcari.Controls.Add(Me.Label5)
        Me.txtcari.Controls.Add(Me.Label6)
        Me.txtcari.Controls.Add(Me.txtNo_nota)
        Me.txtcari.Controls.Add(Me.Label4)
        Me.txtcari.Location = New System.Drawing.Point(16, 151)
        Me.txtcari.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Padding = New System.Windows.Forms.Padding(4)
        Me.txtcari.Size = New System.Drawing.Size(943, 283)
        Me.txtcari.TabIndex = 21
        Me.txtcari.TabStop = False
        '
        'btn_keluar
        '
        Me.btn_keluar.Location = New System.Drawing.Point(591, 225)
        Me.btn_keluar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(100, 50)
        Me.btn_keluar.TabIndex = 24
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'btn_batal
        '
        Me.btn_batal.Location = New System.Drawing.Point(247, 225)
        Me.btn_batal.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(100, 50)
        Me.btn_batal.TabIndex = 23
        Me.btn_batal.Text = "Batal"
        Me.btn_batal.UseVisualStyleBackColor = True
        '
        'btn_cetak
        '
        Me.btn_cetak.Location = New System.Drawing.Point(405, 160)
        Me.btn_cetak.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cetak.Name = "btn_cetak"
        Me.btn_cetak.Size = New System.Drawing.Size(123, 55)
        Me.btn_cetak.TabIndex = 22
        Me.btn_cetak.Text = "Cetak"
        Me.btn_cetak.UseVisualStyleBackColor = True
        '
        'btncari
        '
        Me.btncari.Location = New System.Drawing.Point(356, 20)
        Me.btncari.Margin = New System.Windows.Forms.Padding(4)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(100, 47)
        Me.btncari.TabIndex = 21
        Me.btncari.Text = "Cari"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'frmcetakkwt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 470)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmcetakkwt"
        Me.Text = "Form Cetak Kwitansi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.txtcari.ResumeLayout(False)
        Me.txtcari.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpTgl_kwit As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNo_kwit As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNo_nota As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNm_cus As System.Windows.Forms.TextBox
    Friend WithEvents txttotalbyr As System.Windows.Forms.TextBox
    Friend WithEvents txtTerbilang As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtcari As System.Windows.Forms.GroupBox
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents btn_keluar As System.Windows.Forms.Button
    Friend WithEvents btn_batal As System.Windows.Forms.Button
    Friend WithEvents btn_cetak As System.Windows.Forms.Button
End Class
