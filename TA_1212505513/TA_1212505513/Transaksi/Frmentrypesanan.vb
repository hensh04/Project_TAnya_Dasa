Imports System.Data.Odbc
Public Class Frmentrypesanan

    Dim objpesan As New clssp
    Dim objcustomer As New clscustomer
    Dim objbarang As New clsbarang
    Dim objDetil_SP As New clsdetil_sp

    Private Sub clearForm()
        txtNo_pesan.Text = objpesan.autonumber
        dtpTgl_SP.Value = Now
        txtkd_cus.Clear()
        txtnm_cus.Clear()
        txttlpcus.Clear()
        txtalmtcus.Clear()
        txtkd_brg.Clear()
        txtnm_brg.Clear()
        combojnsbrg.Text = "--Pilih--"
        txthrgbrg.Clear()
        txtStok.Clear()
        txtalmtkrm.Clear()
        txtJmlpsn.Clear()
        DtpTgl_kirim.Value = Now
    End Sub

    Private Sub Kunci()

    End Sub

    Private Sub Frmpesanan_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        btncaricus.Focus()
    End Sub

    Private Sub Frmpesanan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaConn()
        txtNo_pesan.Text = objpesan.autonumber
        txtNo_pesan.Enabled = False
    End Sub

    Private Sub btncaricus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncaricus.Click
        Dim oPop As New popupcus
        oPop.ShowDialog()
        If oPop.rkd_cus <> "" Then
            txtkd_cus.Text = oPop.rkd_cus
            txtnm_cus.Text = oPop.rNm_cus
            txttlpcus.Text = oPop.rtlpcus
            txtalmtcus.Text = oPop.ralmtcus
        End If
    End Sub

    Private Sub txtbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbatal.Click
        clearForm()
    End Sub

    Private Sub btncaribrg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncaribrg.Click
        Dim oPop As New popupbrg
        oPop.ShowDialog()
        If oPop.rkd_brg <> "" Then
            txtkd_brg.Text = oPop.rkd_brg
            txtnm_brg.Text = oPop.rNm_brg
            combojnsbrg.Text = oPop.rJnsbrg
            txthrgbrg.Text = oPop.rhrgbrg
            txtStok.Text = oPop.rstok
        End If
    End Sub

    Private Sub txtkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkeluar.Click
        Me.Dispose()
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        Dim n As Integer
        For n = 0 To ListView1.Items.Count - 1
            If ListView1.Items(n).Text = txtkd_brg.Text Then
                MsgBox("Data Sudah Masuk ke List...!")
                Exit Sub
            End If
        Next
        If Val(txtStok.Text) < Val(txtJmlpsn.Text) Then
            MsgBox("Stok Barang Tidak Mencukupi", MsgBoxStyle.Information, "Peringatan")
            Exit Sub
        End If
        If txtkd_brg.Text = "" Then
            MsgBox("Data Tidak Masuk ke List...!")
            btncaribrg.Focus()
            Exit Sub
        ElseIf txtJmlpsn.Text = "" Or txtJmlpsn.Text = "0" Then
            MsgBox("Masukkan Jumlah Pesan")
            txtJmlpsn.Focus()
            Exit Sub
        Else
            ListView1.Items.Add(txtkd_brg.Text)
            ListView1.Items(n).SubItems.Add(txtnm_brg.Text)
            ListView1.Items(n).SubItems.Add(combojnsbrg.Text)
            ListView1.Items(n).SubItems.Add(txthrgbrg.Text)
            ListView1.Items(n).SubItems.Add(txtJmlpsn.Text)
            ListView1.Items(n).SubItems.Add(Val(txtJmlpsn.Text) * Val(txthrgbrg.Text))

            'txtJmlpsn.Enabled = True
            txtgtotal.Enabled = False
            txtgtotal.Text = Format(CDbl(SUBTOTAL()), " ###,###,###")
            btncaribrg.Focus()
        End If

        txtJmlpsn.Enabled = True
    End Sub

    Function SUBTOTAL() As Double
        Dim xSubtotal As Double = 0
        For i As Integer = 0 To ListView1.Items.Count - 1
            xSubtotal = xSubtotal + CDbl(ListView1.Items(i).SubItems(5).Text)
        Next
        Return xSubtotal
    End Function

    Private Sub txtsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        If txtkd_brg.Text = "" Or txtnm_cus.Text = "" Or ListView1.Items.Count = 0 Then
            MsgBox("Data Belum Lengkap...!", MsgBoxStyle.Information, "INFORMASI")
        Else
            Dim nilaikembali1, nilaikembali2 As Integer
            objpesan.pno_sp = txtNo_pesan.Text
            objpesan.ptglsp = Format(dtpTgl_SP.Value, "dd-MM-yyyy")
            objpesan.pkd_cus = txtkd_cus.Text
            objpesan.palmtkrm = txtalmtkrm.Text
            objpesan.ptgl_krm = Format(DtpTgl_kirim.Value, "dd-MM-yyyy")
            nilaikembali1 = objpesan.simpan()
            For x As Integer = 0 To ListView1.Items.Count - 1
                objDetil_SP.pno_sp = txtNo_pesan.Text
                objDetil_SP.pkd_brg = ListView1.Items(x).SubItems(0).Text
                objDetil_SP.pjmlsp = CDbl(ListView1.Items(x).SubItems(4).Text)
                objDetil_SP.phrgsp = ListView1.Items(x).SubItems(5).Text
                nilaikembali2 = objDetil_SP.simpan()

            Next
            If nilaikembali1 = 1 And nilaikembali2 = 1 Then
                MsgBox("Data Berhasil Disimpan...!", MsgBoxStyle.Information, "INFORMASI")
                clearForm()
            Else
                MessageBox.Show("Data Gagal Disimpan...!")
            End If

            Kunci()
            txtNo_pesan.Text = objpesan.autonumber()
            btnsimpan.Enabled = True
            btnbatal.Enabled = True
            btncaricus.Focus()
            ListView1.Items.Clear()
        End If
    End Sub

    Private Sub ListView1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseDoubleClick
        With ListView1.SelectedItems.Item(0)
            txtkd_brg.Text = .Text
            txtnm_brg.Text = .SubItems(1).Text
            combojnsbrg.Text = .SubItems(2).Text
            txthrgbrg.Text = .SubItems(3).Text
            txtJmlpsn.Text = .SubItems(4).Text
        End With
        If ListView1.SelectedItems.Count <> 0 Then
            Dim pesan = MessageBox.Show("Apakah Anda Ingin Menghapus Barang Ini?", "Konfirmasi", MessageBoxButtons.YesNo)
            If pesan = Windows.Forms.DialogResult.Yes Then
                ListView1.SelectedItems(0).Remove()
                'Bersibarang()
                'Else
                'Bersihbarang()
            End If
        End If
    End Sub
End Class