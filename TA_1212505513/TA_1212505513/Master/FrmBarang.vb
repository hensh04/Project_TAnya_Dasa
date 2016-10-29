Imports System.Data.Odbc
Public Class FrmBarang

    Dim objBarang As New clsbarang

    Private Sub FrmBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaConn()
        txtkd_brg.Text = objBarang.autonumber()
        txtkd_brg.Enabled = False
        txtnm_brg.Enabled = True
        combojnsbrg.Enabled = True
        txthrgbrg.Enabled = True
        txtStok.Enabled = True

        btnbatal.Enabled = False
        btncaribrg.Enabled = True
        btnubah.Enabled = False
        btnhapus.Enabled = False
    End Sub

    Private Sub FrmBarang_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtnm_brg.Focus()
        combojnsbrg.Text = "--Pilih--"
    End Sub

    Private Sub bersih()
        txtnm_brg.Text = ""
        combojnsbrg.Text = "--Pilih--"
        txthrgbrg.Text = ""
        txtStok.Text = ""
        btnsimpan.Enabled = True
        btncaribrg.Enabled = True
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        Try
            If txtkd_brg.Text = "" Or txtnm_brg.Text = "" Or txthrgbrg.Text = "" Or txtStok.Text = "" Or combojnsbrg.Text = "--Pilih--" Or combojnsbrg.Text = "" Then
                MsgBox("Terdapat Data Kosong")
            Else
                objBarang.pkd_brg = txtkd_brg.Text
                objBarang.pnm_brg = txtnm_brg.Text
                objBarang.pjnsbrg = combojnsbrg.Text
                objBarang.phrgbrg = txthrgbrg.Text
                objBarang.pstok = txtStok.Text


                If objBarang.simpan = 1 Then
                    MessageBox.Show("Data Berhasil Disimpan", "Berhasil")
                    bersih()
                    txtkd_brg.Text = objBarang.autonumber()
                Else
                    MessageBox.Show("Data Gagal Disimpan", "Gagal")
                End If

                bersih()
                txtkd_brg.Text = objBarang.autonumber()
                txtkd_brg.Enabled = False
                txtnm_brg.Enabled = True
                combojnsbrg.Enabled = True
                txthrgbrg.Enabled = True
                txtStok.Enabled = True

                btnbatal.Enabled = False
                btncaribrg.Enabled = True
                btnubah.Enabled = False
                btnhapus.Enabled = False
                txtkd_brg.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnubah.Click
        Try
            If txtkd_brg.Text = "" Or txtnm_brg.Text = "" Or txthrgbrg.Text = "" Or txtStok.Text = "" Or combojnsbrg.Text = "--Pilih--" Or combojnsbrg.Text = "" Then
                MsgBox("Terdapat Data Kosong")
            Else
                objBarang.pkd_brg = txtkd_brg.Text
                objBarang.pnm_brg = txtnm_brg.Text
                objBarang.pjnsbrg = combojnsbrg.Text
                objBarang.phrgbrg = txthrgbrg.Text
                objBarang.pstok = txtStok.Text
                If objBarang.ubah = 1 Then
                    MessageBox.Show("Data Berhasil Diubah", "Berhasil")
                    bersih()
                    txtkd_brg.Text = objBarang.autonumber()
                Else
                    MessageBox.Show("Data Gagal Diubah", "Gagal")
                End If

                bersih()
                txtkd_brg.Text = objBarang.autonumber()
                txtkd_brg.Enabled = False
                txtnm_brg.Enabled = True
                combojnsbrg.Enabled = True
                txthrgbrg.Enabled = True
                txtStok.Enabled = True

                btnbatal.Enabled = False
                btncaribrg.Enabled = True
                btnubah.Enabled = False
                btnhapus.Enabled = False
                txtkd_brg.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        Try
            objBarang.pkd_brg = txtkd_brg.Text
            If objBarang.hapus = 1 Then
                MessageBox.Show("Data Berhasil Dihapus", "Berhasil")
                bersih()
                txtkd_brg.Text = objBarang.autonumber()
                txtkd_brg.Enabled = False
                txtnm_brg.Enabled = True
                combojnsbrg.Enabled = True
                txthrgbrg.Enabled = True
                txtStok.Enabled = True

                btnbatal.Enabled = False
                btncaribrg.Enabled = True
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
        txtkd_brg.Text = objBarang.autonumber()
        txtkd_brg.Enabled = False
        txtnm_brg.Enabled = True
        combojnsbrg.Enabled = True
        txthrgbrg.Enabled = True
        txtStok.Enabled = True

        btnbatal.Enabled = False
        btncaribrg.Enabled = True
        btnubah.Enabled = False
        btnhapus.Enabled = False
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Me.Close()
    End Sub

    Private Sub txtkd_brg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtkd_brg.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtkd_brg.Enabled = False
            objBarang.pkd_brg = txtkd_brg.Text
            If objBarang.cari = True Then
                txtkd_brg.Text = objBarang.pkd_brg
                txtnm_brg.Text = objBarang.pnm_brg
                txthrgbrg.Text = objBarang.phrgbrg
                txtStok.Text = objBarang.pstok
                combojnsbrg.Text = objBarang.pjnsbrg
                btnsimpan.Enabled = False
            Else
                btnubah.Enabled = False
                btnhapus.Enabled = False
            End If
            btncaribrg.Enabled = False
            txtnm_brg.Focus()
        End If
    End Sub

    Private Sub txthrgbrg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txthrgbrg.KeyPress
        If Not (Asc(e.KeyChar) >= Asc("0") And Asc(e.KeyChar) <= Asc("9") Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13) Then
            e.KeyChar = Chr(0)
            MessageBox.Show("Harus Masukan Angka!")
        End If
    End Sub

    Private Sub txtStok_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStok.KeyPress
        If Not (Asc(e.KeyChar) >= Asc("0") And Asc(e.KeyChar) <= Asc("9") Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13) Then
            e.KeyChar = Chr(0)
            MessageBox.Show("Harus Masukan Angka!")
        End If
    End Sub

    Private Sub btncaribrg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncaribrg.Click
        Dim opop As New popupbrg
        opop.ShowDialog()
        If opop.rkd_brg <> "" Then
            txtkd_brg.Text = opop.rkd_brg
            txtnm_brg.Text = opop.rNm_brg
            txthrgbrg.Text = opop.rhrgbrg
            combojnsbrg.Text = opop.rJnsbrg
            txtStok.Text = opop.rstok

            txtkd_brg.Enabled = False
            txtnm_brg.Enabled = True
            combojnsbrg.Enabled = True
            txthrgbrg.Enabled = True
            txtStok.Enabled = True

            btnsimpan.Enabled = False
            btnbatal.Enabled = True
            btncaribrg.Enabled = True
            btnubah.Enabled = True
            btnhapus.Enabled = True
            txtnm_brg.Focus()
        End If
    End Sub
End Class