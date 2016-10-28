Imports System.Data.Odbc
Public Class popuppesanan

    Public rno_sp As String
    Public rtglsp As Date
    Public rkdcus As String
    Public rnmcus As String
    Public rtlpcus As String

    Dim objpesanan As New clssp
    Dim objcustomer As New clscustomer


    Sub isiListView(Optional ByVal kriteria As String = "%")
        Dim xList As List(Of clssp)
        xList = objpesanan.tampildata(kriteria)
        ListView1.Items.Clear()
        For baris As Integer = 0 To xList.Count - 1
            ListView1.Items.Add(xList.Item(baris).pno_sp)
            ListView1.Items(baris).SubItems.Add(xList.Item(baris).ptglsp)
            ListView1.Items(baris).SubItems.Add(xList.Item(baris).pkd_cus)
            objcustomer.pkd_cus = xList.Item(baris).pkd_cus
            If objcustomer.cari = True Then
                ListView1.Items(baris).SubItems.Add(objcustomer.pnm_cus)
                ListView1.Items(baris).SubItems.Add(objcustomer.ptlpcus)
            End If
        Next
    End Sub

    Sub PilihBarisView()
        rno_sp = ListView1.FocusedItem.Text
        rtglsp = ListView1.FocusedItem.SubItems(1).Text
        rkdcus = ListView1.FocusedItem.SubItems(2).Text
        rnmcus = ListView1.FocusedItem.SubItems(3).Text
        rtlpcus = ListView1.FocusedItem.SubItems(4).Text
        Me.Close()
    End Sub

    Private Sub popuppesanan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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