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

            txttotalhrg.Text = Format(CDbl(asubtotal()), " ###,###,###")

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
        If combojnsbrg.Text = "---Silahkan Pilih---" Then
            txtdp.Enabled = False
            txtsisabayar.Enabled = False

        ElseIf combojnsbrg.Text = "Lunas" Then
            txtdp.Text = txtsisabayar.Text

        ElseIf combojnsbrg.Text = "DP" Then
            txtdp.Enabled = True

        End If
    End Sub

    Private Sub txtdp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdp.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(txtdp.Text) > Val(txttotalhrg.Text) Then
                MsgBox("Jumlah DP Tidak Boleh Kurang Dari Total", MsgBoxStyle.Information, "Peringatan")
            Else
                txtsisabayar.Text = Val(txtdp.Text) + Val(txttotalhrg.Text)
                MsgBox("" & txtsisabayar.Text & vbCrLf & " (" & Terbilang(txtsisabayar.Text) & ")", MsgBoxStyle.Information, "Sisa Pembayaran")
            End If
        End If
    End Sub

    'Private Sub txtdp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdp.TextChanged
    '    txtsisabayar.Text = Val(txttotalhrg.Text) - Val(txtdp.Text)
    'End Sub

    Private Sub txtdp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdp.TextChanged
        Dim a As Double
        a = txtdp.Text
        txtdp.Text = Format(a, "###,###,###")
        txtdp.SelectionStart = Len(txtdp.Text)
    End Sub
End Class