Imports System.Data.Odbc
Public Class FrmKurir

    Dim objKurir As New clskurir
    Private Sub FrmBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaConn()
        txtkd_kur.Text = objKurir.autonumber()
        txtkd_kur.Enabled = False
        txtnm_kur.Enabled = True
        txttlpkur.Enabled = True
        txtalmtkur.Enabled = True

        btnsimpan.Enabled = True
        btnbatal.Enabled = False
        btncarikur.Enabled = True
        btnubah.Enabled = False
        btnhapus.Enabled = False
    End Sub

    Private Sub FrmBarang_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtnm_kur.Focus()
    End Sub
    Private Sub bersih()
        txtnm_kur.Text = ""
        txttlpkur.Text = ""
        txtalmtkur.Text = ""
        btnsimpan.Enabled = True
        btncarikur.Enabled = True
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        Try
            If txtkd_kur.Text = "" Or txtnm_kur.Text = "" Or txttlpkur.Text = "" Or txtalmtkur.Text = "" Then
                MsgBox("Terdapat Data Kosong")
            Else
                objKurir.pkd_kur = txtkd_kur.Text
                objKurir.pnm_kur = txtnm_kur.Text
                objKurir.ptlpkur = txttlpkur.Text
                objKurir.palmtkur = txtalmtkur.Text
             

                If objKurir.simpan = 1 Then
                    MessageBox.Show("Data Berhasil Disimpan", "Berhasil")
                    bersih()
                    txtkd_kur.Text = objKurir.autonumber()
                Else
                    MessageBox.Show("Data Gagal Disimpan", "Gagal")
                End If

                bersih()
                txtkd_kur.Text = objKurir.autonumber()
                txtkd_kur.Enabled = True
                btncarikur.Enabled = True
                txtkd_kur.Enabled = False
                txtnm_kur.Enabled = True
                txttlpkur.Enabled = True
                txtalmtkur.Enabled = True

                btnsimpan.Enabled = True
                btnbatal.Enabled = False
                btncarikur.Enabled = True
                btnubah.Enabled = False
                btnhapus.Enabled = False
                txtkd_kur.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btncarikur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncarikur.Click
        Dim opop As New popupkur
        opop.ShowDialog()
        If opop.rkd_kur <> "" Then
            txtkd_kur.Text = opop.rkd_kur
            txtnm_kur.Text = opop.rNm_kur
            txttlpkur.Text = opop.rtlpkur
            txtalmtkur.Text = opop.ralmtkur

            txtkd_kur.Enabled = False
            txtnm_kur.Enabled = True
            txttlpkur.Enabled = True
            txtalmtkur.Enabled = True

            btnsimpan.Enabled = False
            btnbatal.Enabled = True
            btncarikur.Enabled = True
            btnubah.Enabled = True
            btnhapus.Enabled = True
            txtnm_kur.Focus()
        End If
    End Sub

    Private Sub btnubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnubah.Click
        Try
            If txtkd_kur.Text = "" Or txtnm_kur.Text = "" Or txttlpkur.Text = "" Or txtalmtkur.Text = "" Then
                MsgBox("Terdapat Data Kosong")
            Else
                objKurir.pkd_kur = txtkd_kur.Text
                objKurir.pnm_kur = txtnm_kur.Text
                objKurir.ptlpkur = txttlpkur.Text
                objKurir.palmtkur = txtalmtkur.Text

                If objKurir.ubah = 1 Then
                    MessageBox.Show("Data Berhasil Diubah", "Berhasil")
                    bersih()
                    txtkd_kur.Text = objKurir.autonumber()
                Else
                    MessageBox.Show("Data Gagal Diubah", "Gagal")
                End If

                bersih()
                txtkd_kur.Enabled = False
                txtnm_kur.Enabled = True
                txttlpkur.Enabled = True
                txtalmtkur.Enabled = True

                btnsimpan.Enabled = True
                btnbatal.Enabled = False
                btncarikur.Enabled = True
                btnubah.Enabled = False
                btnhapus.Enabled = False
                txtkd_kur.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        Try
            objKurir.pkd_kur = txtkd_kur.Text
            If objKurir.hapus = 1 Then
                MessageBox.Show("Data Berhasil Dihapus", "Berhasil")
                bersih()
                txtkd_kur.Text = objKurir.autonumber()
                txtkd_kur.Enabled = False
                txtnm_kur.Enabled = True
                txttlpkur.Enabled = True
                txtalmtkur.Enabled = True

                btnsimpan.Enabled = True
                btnbatal.Enabled = False
                btncarikur.Enabled = True
                btnubah.Enabled = False
                btnhapus.Enabled = False
            Else
                MessageBox.Show("Data Gagal Dihapus", "Gagal")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        bersih()
        txtkd_kur.Text = objKurir.autonumber()
        txtkd_kur.Enabled = False
        txtnm_kur.Enabled = True
        txttlpkur.Enabled = True
        txtalmtkur.Enabled = True

        btnsimpan.Enabled = True
        btnbatal.Enabled = False
        btncarikur.Enabled = True
        btnubah.Enabled = False
        btnhapus.Enabled = False
    End Sub

    Private Sub txtkd_kur_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtkd_kur.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtkd_kur.Enabled = False
            objKurir.pkd_kur = txtkd_kur.Text
            If objKurir.cari = True Then
                txtkd_kur.Text = objKurir.pkd_kur
                txtnm_kur.Text = objKurir.pnm_kur
                txttlpkur.Text = objKurir.ptlpkur
                txtalmtkur.Text = objKurir.palmtkur
                btnsimpan.Enabled = False
            Else
                btnubah.Enabled = False
                btnhapus.Enabled = False
            End If
            btncarikur.Enabled = False
            txtnm_kur.Focus()
        End If
    End Sub
    Private Sub txttlpkur_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttlpkur.KeyPress
        If Not (Asc(e.KeyChar) >= Asc("0") And Asc(e.KeyChar) <= Asc("9") Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13) Then
            e.KeyChar = Chr(0)
            MessageBox.Show("Harus Masukan Angka!")
        End If
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Me.Close()
    End Sub
End Class