<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MaenDuluYangBenerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntryDataBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntryDatacToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntryDataKurirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntryPesananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CetakNotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CetakKwitansiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaenDuluYangBenerToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1207, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MaenDuluYangBenerToolStripMenuItem
        '
        Me.MaenDuluYangBenerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntryDataBarangToolStripMenuItem, Me.EntryDatacToolStripMenuItem, Me.EntryDataKurirToolStripMenuItem})
        Me.MaenDuluYangBenerToolStripMenuItem.Name = "MaenDuluYangBenerToolStripMenuItem"
        Me.MaenDuluYangBenerToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.MaenDuluYangBenerToolStripMenuItem.Text = "Master"
        '
        'EntryDataBarangToolStripMenuItem
        '
        Me.EntryDataBarangToolStripMenuItem.Name = "EntryDataBarangToolStripMenuItem"
        Me.EntryDataBarangToolStripMenuItem.Size = New System.Drawing.Size(214, 24)
        Me.EntryDataBarangToolStripMenuItem.Text = "Entry Data Barang"
        '
        'EntryDatacToolStripMenuItem
        '
        Me.EntryDatacToolStripMenuItem.Name = "EntryDatacToolStripMenuItem"
        Me.EntryDatacToolStripMenuItem.Size = New System.Drawing.Size(214, 24)
        Me.EntryDatacToolStripMenuItem.Text = "Entry Data Customer"
        '
        'EntryDataKurirToolStripMenuItem
        '
        Me.EntryDataKurirToolStripMenuItem.Name = "EntryDataKurirToolStripMenuItem"
        Me.EntryDataKurirToolStripMenuItem.Size = New System.Drawing.Size(214, 24)
        Me.EntryDataKurirToolStripMenuItem.Text = "Entry Data Kurir"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntryPesananToolStripMenuItem, Me.CetakNotaToolStripMenuItem, Me.CetakKwitansiToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'EntryPesananToolStripMenuItem
        '
        Me.EntryPesananToolStripMenuItem.Name = "EntryPesananToolStripMenuItem"
        Me.EntryPesananToolStripMenuItem.Size = New System.Drawing.Size(173, 24)
        Me.EntryPesananToolStripMenuItem.Text = "Entry Pesanan"
        '
        'CetakNotaToolStripMenuItem
        '
        Me.CetakNotaToolStripMenuItem.Name = "CetakNotaToolStripMenuItem"
        Me.CetakNotaToolStripMenuItem.Size = New System.Drawing.Size(173, 24)
        Me.CetakNotaToolStripMenuItem.Text = "Cetak Nota"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'CetakKwitansiToolStripMenuItem
        '
        Me.CetakKwitansiToolStripMenuItem.Name = "CetakKwitansiToolStripMenuItem"
        Me.CetakKwitansiToolStripMenuItem.Size = New System.Drawing.Size(173, 24)
        Me.CetakKwitansiToolStripMenuItem.Text = "Cetak Kwitansi"
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1207, 537)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MenuUtama"
        Me.Text = "Menu Utama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MaenDuluYangBenerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntryDataBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntryDataKurirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntryDatacToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntryPesananToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CetakNotaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CetakKwitansiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
