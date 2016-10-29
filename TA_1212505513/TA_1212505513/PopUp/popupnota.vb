Imports System.Data.Odbc
Public Class popupnota

    Public rno_nota As String
    Public rtgl_nota As Date
    Public rno_pesan As String
    Public rkd_customer As String
    Public rnm_cus As String

    Dim objnota As New clsnota
    Dim objpesanan As New clssp
    Dim objdetil_sp As New clsdetil_sp
    Dim objcustomer As New clscustomer
    Dim objbarang As New clsbarang

    Sub isiListView(Optional ByVal kriteria As String = "%")
        Dim xList As List(Of clsnota)
        xList = objnota.tampildata(kriteria)
        ListView1.Items.Clear()
        For baris As Integer = 0 To xList.Count - 1
            ListView1.Items.Add(xList.Item(baris).pno_nota)
            ListView1.Items(baris).SubItems.Add(xList.Item(baris).ptglnota)
            ListView1.Items(baris).SubItems.Add(xList.Item(baris).pno_sp)
            objpesanan.pno_sp = xList.Item(baris).pno_sp
            If objpesanan.cari = True Then
                ListView1.Items(baris).SubItems.Add(objpesanan.pkd_cus)
            End If
            objcustomer.pkd_cus = objcustomer.pkd_cus
            If objcustomer.cari = True Then
                ListView1.Items(baris).SubItems.Add(objcustomer.pnm_cus)
            End If
        Next
    End Sub

    Sub PilihBarisView()
        rno_nota = ListView1.FocusedItem.Text
        rtgl_nota = ListView1.FocusedItem.SubItems(1).Text
        rno_pesan = ListView1.FocusedItem.SubItems(2).Text
        rkd_customer = ListView1.FocusedItem.SubItems(3).Text
        rnm_cus = ListView1.FocusedItem.SubItems(4).Text
        Me.Close()
    End Sub

    Private Sub popupnota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaConn()
        isiListView()
    End Sub

    Private Sub btnpilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpilih.Click
        PilihBarisView()
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Me.Close()
    End Sub

    Private Sub txtkatakunci_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkatakunci.TextChanged
        Call isiListView(txtkatakunci.Text)
    End Sub

    Private Sub ListView1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseDoubleClick
        Call PilihBarisView()
    End Sub
End Class