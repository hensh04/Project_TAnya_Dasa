Public Class MenuUtama

    Private Sub EntryDatacToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntryDatacToolStripMenuItem.Click
        FrmCustomer.ShowDialog()
    End Sub

    Private Sub EntryDataBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntryDataBarangToolStripMenuItem.Click
        FrmBarang.ShowDialog()
    End Sub

    Private Sub EntryDataKurirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntryDataKurirToolStripMenuItem.Click
        FrmKurir.ShowDialog()
    End Sub

    Private Sub EntryPesananToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntryPesananToolStripMenuItem.Click
        Frmentrypesanan.ShowDialog()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CetakNotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CetakNotaToolStripMenuItem.Click
        frmcetaknota.ShowDialog()
    End Sub
End Class
