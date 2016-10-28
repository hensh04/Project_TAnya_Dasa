Imports System.Data.Odbc
Public Class FrmCustomer

    Dim objCustomer As New clscustomer
    Private Sub FrmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaConn()
        txtkd_cus.Text = objCustomer.autonumber()
        txtkd_cus.Enabled = False
        txtnm_cus.Enabled = True
        txttlpcus.Enabled = True
        txtalmtcus.Enabled = True

        btnbatal.Enabled = False
        btncaricus.Enabled = True
        btnubah.Enabled = False
        btnhapus.Enabled = False
    End Sub

    Private Sub FrmCustomer_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtnm_cus.Focus()
    End Sub

    Private Sub bersih()
        txtnm_cus.Text = ""
        txttlpcus.Text = ""
        txtalmtcus.Text = ""
        btnsimpan.Enabled = True
        btncaricus.Enabled = True
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        Try
            If txtkd_cus.Text = "" Or txtnm_cus.Text = "" Or txttlpcus.Text = "" Or txtalmtcus.Text = "" Then
                MsgBox("Terdapat Data Kosong")
            Else
                objCustomer.pkd_cus = txtkd_cus.Text
                objCustomer.pnm_cus = txtnm_cus.Text
                objCustomer.ptlpcus = txttlpcus.Text
                objCustomer.palmtcus = txtalmtcus.Text

                If objCustomer.simpan = 1 Then
                    MessageBox.Show("Data Berhasil Disimpan", "Berhasil")
                    bersih()
                    txtkd_cus.Text = objCustomer.autonumber()
                Else
                    MessageBox.Show("Data Gagal Disimpan", "Gagal")
                End If

                bersih()
                txtkd_cus.Text = objCustomer.autonumber()
                txtkd_cus.Enabled = False
                txtnm_cus.Enabled = True
                txttlpcus.Enabled = True
                txtalmtcus.Enabled = True

                btnbatal.Enabled = False
                btncaricus.Enabled = True
                btnubah.Enabled = False
                btnhapus.Enabled = False
                txtkd_cus.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnubah.Click
        Try
            If txtkd_cus.Text = "" Or txtnm_cus.Text = "" Or txttlpcus.Text = "" Or txtalmtcus.Text = "" Then
                MsgBox("Terdapat Data Kosong")
            Else
                objCustomer.pkd_cus = txtkd_cus.Text
                objCustomer.pnm_cus = txtnm_cus.Text
                objCustomer.ptlpcus = txttlpcus.Text
                objCustomer.palmtcus = txtalmtcus.Text

                If objCustomer.ubah = 1 Then
                    MessageBox.Show("Data Berhasil Diubah", "Berhasil")
                    bersih()
                    txtkd_cus.Text = objCustomer.autonumber()
                Else
                    MessageBox.Show("Data Gagal Diubah", "Gagal")
                End If

                bersih()
                txtkd_cus.Text = objCustomer.autonumber()
                txtkd_cus.Enabled = False
                txtnm_cus.Enabled = True
                txttlpcus.Enabled = True
                txtalmtcus.Enabled = True

                btnbatal.Enabled = False
                btncaricus.Enabled = True
                btnubah.Enabled = False
                btnhapus.Enabled = False
                txtkd_cus.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        Try
            objCustomer.pkd_cus = txtkd_cus.Text
            If objCustomer.hapus = 1 Then
                MessageBox.Show("Data Berhasil Dihapus", "Berhasil")
                bersih()
                txtkd_cus.Text = objCustomer.autonumber()

                txtkd_cus.Enabled = False
                txtnm_cus.Enabled = True
                txttlpcus.Enabled = True
                txtalmtcus.Enabled = True

                btnbatal.Enabled = False
                btncaricus.Enabled = True
                btnubah.Enabled = False
                btnhapus.Enabled = False
                txtkd_cus.Focus()

            Else
                MessageBox.Show("Data Gagal Dihapus", "Gagal")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        bersih()
        txtkd_cus.Text = objCustomer.autonumber()
        txtkd_cus.Enabled = False
        txtnm_cus.Enabled = True
        txttlpcus.Enabled = True
        txtalmtcus.Enabled = True

        btnbatal.Enabled = False
        btncaricus.Enabled = True
        btnubah.Enabled = False
        btnhapus.Enabled = False
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Me.Close()
    End Sub

    Private Sub txtkd_cus_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtkd_cus.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtkd_cus.Enabled = False
            objCustomer.pkd_cus = txtkd_cus.Text
            If objCustomer.cari = True Then
                txtkd_cus.Text = objCustomer.pkd_cus
                txtnm_cus.Text = objCustomer.pnm_cus
                txttlpcus.Text = objCustomer.ptlpcus
                txtalmtcus.Text = objCustomer.palmtcus
                btnsimpan.Enabled = False
            Else
                btnubah.Enabled = False
                btnhapus.Enabled = False
            End If
            btncaricus.Enabled = False
            txtkd_cus.Enabled = False
            txtnm_cus.Enabled = True
            txttlpcus.Enabled = True
            txtalmtcus.Enabled = True
            txtnm_cus.Focus()
        End If
    End Sub

    Private Sub txttlpcus_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttlpcus.KeyPress
        If Not (Asc(e.KeyChar) >= Asc("0") And Asc(e.KeyChar) <= Asc("9") Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13) Then
            e.KeyChar = Chr(0)
            MessageBox.Show("Harus Masukan Angka!")
        End If
    End Sub

    Private Sub btncaricus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncaricus.Click
        Dim opop As New popupcus
        opop.ShowDialog()
        If opop.rkd_cus <> "" Then
            txtkd_cus.Text = opop.rkd_cus
            txtnm_cus.Text = opop.rNm_cus
            txttlpcus.Text = opop.rtlpcus
            txtalmtcus.Text = opop.ralmtcus

            txtkd_cus.Enabled = False
            btnsimpan.Enabled = False
            btnbatal.Enabled = True
            btncaricus.Enabled = True
            btnubah.Enabled = True
            btnhapus.Enabled = True
            txtnm_cus.Focus()
        End If
    End Sub
End Class