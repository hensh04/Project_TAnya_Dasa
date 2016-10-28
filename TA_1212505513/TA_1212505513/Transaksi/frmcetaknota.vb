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
            txNo_pesan.Text = opop.rno_sp
            DateTimePicker1.Value = opop.rtglsp
            txtnm_cus.Text = opop.rnmcus


        End If
        btncetak.Enabled = True
        btnbatal.Enabled = True
    End Sub
End Class