<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class popuppesanan
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
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btnpilih = New System.Windows.Forms.Button()
        Me.txtkatakunci = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tanggal Pesanan"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 191
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader2, Me.ColumnHeader6})
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(29, 97)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1099, 178)
        Me.ListView1.TabIndex = 10
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nomor Pesanan"
        Me.ColumnHeader1.Width = 153
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama Customer"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 239
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Kode Customer"
        Me.ColumnHeader4.Width = 125
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Nomor Telepon"
        Me.ColumnHeader6.Width = 117
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Kata Kunci"
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(713, 314)
        Me.btnkeluar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(100, 28)
        Me.btnkeluar.TabIndex = 12
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'btnpilih
        '
        Me.btnpilih.Location = New System.Drawing.Point(328, 314)
        Me.btnpilih.Margin = New System.Windows.Forms.Padding(4)
        Me.btnpilih.Name = "btnpilih"
        Me.btnpilih.Size = New System.Drawing.Size(100, 28)
        Me.btnpilih.TabIndex = 11
        Me.btnpilih.Text = "Pilih"
        Me.btnpilih.UseVisualStyleBackColor = True
        '
        'txtkatakunci
        '
        Me.txtkatakunci.Location = New System.Drawing.Point(160, 38)
        Me.txtkatakunci.Margin = New System.Windows.Forms.Padding(4)
        Me.txtkatakunci.MaxLength = 35
        Me.txtkatakunci.Name = "txtkatakunci"
        Me.txtkatakunci.Size = New System.Drawing.Size(345, 22)
        Me.txtkatakunci.TabIndex = 14
        '
        'popuppesanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1161, 366)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnpilih)
        Me.Controls.Add(Me.txtkatakunci)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "popuppesanan"
        Me.Text = "popuppesanan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents btnpilih As System.Windows.Forms.Button
    Friend WithEvents txtkatakunci As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
End Class
