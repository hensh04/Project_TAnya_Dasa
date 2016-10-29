Imports System.Data.Odbc
Public Class frmcetakkwt

    Dim objkwitansi As New clskwitansi
    Dim objnota As New clsnota
    Dim objpesanan As New clssp
    Dim objcustomer As New clscustomer
    Dim objdetil_sp As New clsdetil_sp
    Dim objbarang As New clsbarang

    Private Sub frmcetakkwt_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        btnCari.Focus()
    End Sub

    Private Sub frmcetakkwt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaConn()
        txtNo_kwit.Text = objkwitansi.autonumber
        btncari.Focus()
        dtpTgl_kwit.Enabled = False
        txtNo_kwit.Enabled = False
        txtNo_nota.Enabled = False
        txtNm_cus.Enabled = False
        txttotalbyr.Enabled = False
        txtTerbilang.Enabled = False
    End Sub

    Private Sub btncari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncari.Click
        Dim opop As New popupnota
        opop.ShowDialog()
        If opop.rno_nota <> "" Then
            txtNo_nota.Text = opop.rno_nota
            txtNm_cus.Text = opop.rnm_cus

            'tampildata(txtNo_pesan.Text)

            'objpesanan.pno_sp = txtNo_pesan.Text
            'If objpesanan.cari = True Then
            '    tampildata(objpesanan.pno_sp)
            'End If

        End If
        btn_cetak.Enabled = True
        btn_batal.Enabled = True
    End Sub
End Class