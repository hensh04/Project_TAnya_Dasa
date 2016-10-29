Imports System.Data.Odbc
Public Class frmcetaknota

    Dim objnota As New clsnota
    Dim objpesanan As New clssp
    Dim objdetil_sp As New clsdetil_sp
    Dim objbarang As New clsbarang
    Dim objcustomer As New clscustomer

    Private Sub frmcetaknota_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        btnCari.Focus()
    End Sub

    Private Sub frmcetaknota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaConn()
        txtNo_nota.Text = objnota.autonumber
        btnCari.Focus()
        dtpTgl_nota.Enabled = False
        txtNo_nota.Enabled = False
        DateTimePicker1.Enabled = False
        txtNo_pesan.Enabled = False
        txtnm_cus.Enabled = False
        txttotalhrg.Enabled = False
        combojnsbrg.Enabled = False
        txtdp.Enabled = False
        txtsisabayar.Enabled = False
        combojnsbrg.Text = "---Silahkan Pilih---"
    End Sub

    Function asubtotal() As Double
        Dim xsubtotal As Double = 0
        For i As Integer = 0 To ListView1.Items.Count - 1
            xsubtotal = xsubtotal + CDbl(ListView1.Items(i).SubItems(5).Text)
        Next
        Return xsubtotal

    End Function

    Private Sub tampildata(ByVal xData As String)
        Dim objdetil_sp As New clsdetil_sp

        Dim xList As List(Of clsdetil_sp)
        xList = objdetil_sp.tampildata(xData)
        ListView1.Items.Clear()
        For baris As Integer = 0 To xList.Count - 1
            ListView1.Items.Add(xList.Item(baris).pkd_brg)

            Dim objbarang As New clsbarang
            objbarang.pkd_brg = xList.Item(baris).pkd_brg
            If objbarang.cari = True Then
                ListView1.Items(baris).SubItems.Add(objbarang.pnm_brg)
                ListView1.Items(baris).SubItems.Add(objbarang.pjnsbrg)
                ListView1.Items(baris).SubItems.Add(objbarang.phrgbrg)
            End If

            ListView1.Items(baris).SubItems.Add(xList.Item(baris).pjmlsp)
            ListView1.Items(baris).SubItems.Add(xList.Item(baris).phrgsp)

            Dim subtotal As Integer
            subtotal = CInt(xList.Item(baris).pjmlsp) * CInt(objbarang.phrgbrg)
            ListView1.Items(baris).SubItems.Add(subtotal)

            txttotalhrg.Text = Format(asubtotal(), "###,##0")

        Next
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        Dim opop As New popuppesanan
        opop.ShowDialog()
        If opop.rno_sp <> "" Then
            txtNo_pesan.Text = opop.rno_sp
            DateTimePicker1.Value = opop.rtglsp
            txtnm_cus.Text = opop.rnmcus

            tampildata(txtNo_pesan.Text)

            objpesanan.pno_sp = txtNo_pesan.Text
            If objpesanan.cari = True Then
                tampildata(objpesanan.pno_sp)
            End If

        End If
        btncetak.Enabled = True
        btnbatal.Enabled = True
        combojnsbrg.Enabled = True
    End Sub

    Private Sub combojnsbrg_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combojnsbrg.SelectedIndexChanged
        'If combojnsbrg.Text = "---Silahkan Pilih---" Then
        '    txtdp.Enabled = False
        '    txtsisabayar.Enabled = False

        'ElseIf combojnsbrg.Text = "Lunas" Then
        '    txtdp.Text = txtsisabayar.Text
        '    txtdp.Clear()
        '    txtsisabayar.Text = "0"
        '    txtdp.Enabled = False
        '    txtsisabayar.Enabled = False

        'ElseIf combojnsbrg.Text = "DP" Then
        '    txtdp.Enabled = True
        '    txtdp.Text = 0
        'End If

        If combojnsbrg.SelectedItem = "DP" Then
            txtdp.Text = Val(txttotalhrg.Text) * 0.5
            txtdp.Text = Format(txttotalhrg.Text * 0.5, "###,##0")
            txtsisabayar.Text = Val(txttotalhrg.Text) - Val(txtdp.Text)
            txtsisabayar.Text = Format(txttotalhrg.Text - txtdp.Text, "###,##0")
        Else
            txtdp.Text = 0
            txtsisabayar.Text = 0
        End If

    End Sub

    Private Sub txtdp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdp.KeyDown
        '    If e.KeyCode = Keys.Enter Then
        '        If Val(txtdp.Text) > Val(txttotalhrg.Text) Then
        '            MsgBox("Jumlah DP Tidak Boleh lebih Dari Total", MsgBoxStyle.Information, "Peringatan")
        '        Else
        txtsisabayar.Text = Format(txttotalhrg.Text - txtdp.Text, "###,##0")
        '            MsgBox("" & txtsisabayar.Text & vbCrLf & " (" & Terbilang(txtsisabayar.Text) & ")", MsgBoxStyle.Information, "Sisa Pembayaran")
        '        End If
        '    End If
    End Sub

    Private Sub txtdp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdp.KeyPress
        '    If Not (Asc(e.KeyChar) >= Asc("0") And Asc(e.KeyChar) <= Asc("9") Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13) Then
        '        e.KeyChar = Chr(0)
        '        MessageBox.Show("Harus Masukan Angka!")
        '    End If
        'End Sub

        'Private Sub txtdp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdp.TextChanged
        'If txtdp.Text.Length < 1 Then
        '    txtdp.Text = 0
        'Else
        Dim a As Double
        a = txtdp.Text
        txtdp.Text = Format(a, "###,##0")
        txtdp.SelectionStart = Len(txtdp.Text)
        'End If
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Me.Dispose()
    End Sub

    Private Sub btncetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncetak.Click
        If txtNo_nota.Text = "" Or combojnsbrg.Text = "---Silahkan Pilih---" Or combojnsbrg.Text = "0" Then
            MsgBox("Data Belum Lengkap...!", MsgBoxStyle.Information, "INFORMASI")
        Else
            Dim nilaikembali1 As Integer
            objnota.pno_nota = txtNo_nota.Text
            objnota.ptglnota = Format(dtpTgl_nota.Value, "dd-MM-yyyy")
            objnota.pdp = txtdp.Text
            objnota.pjnsbyr = combojnsbrg.Text
            objnota.pno_sp = txtNo_pesan.Text
            nilaikembali1 = objnota.simpan()

            If nilaikembali1 = 1 Then
                MsgBox("Data Berhasil Disimpan...!", MsgBoxStyle.Information, "INFORMASI")
                IdCetakan = "1"
                TampilCetakan.ShowDialog()
            Else
                MessageBox.Show("Data Gagal Disimpan...!")
            End If

            'Kunci()
            ' Clear()
            txtNo_nota.Text = objnota.autonumber()
            btncetak.Enabled = False
            btnbatal.Enabled = False
            btnCari.Focus()
        End If
    End Sub
End Class