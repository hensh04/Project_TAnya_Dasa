Public Class popupcus

    Public rkd_cus As String
    Public rNm_cus As String
    Public rtlpcus As String
    Public ralmtcus As String

    Dim objbarang As New clscustomer

    Sub isiListView(Optional ByVal kriteria As String = "%")
        Dim xList As List(Of clscustomer)
        xList = objbarang.tampildata(kriteria)
        ListView1.Items.Clear()
        For baris As Integer = 0 To xList.Count - 1
            ListView1.Items.Add(xList.Item(baris).pkd_cus)
            ListView1.Items(baris).SubItems.Add(xList.Item(baris).pnm_cus)
            ListView1.Items(baris).SubItems.Add(xList.Item(baris).ptlpcus)
            ListView1.Items(baris).SubItems.Add(xList.Item(baris).palmtcus)
        Next
    End Sub

    Sub PilihBarisView()
        rkd_cus = ListView1.FocusedItem.Text
        rNm_cus = ListView1.FocusedItem.SubItems(1).Text
        rtlpcus = ListView1.FocusedItem.SubItems(2).Text
        ralmtcus = ListView1.FocusedItem.SubItems(3).Text
        Me.Dispose()
    End Sub

    Private Sub popupcus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaConn()
        Call isiListView()
    End Sub

    Private Sub txtkatakunci_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtkatakunci.MouseDoubleClick
        Call PilihBarisView()
    End Sub

    Private Sub txtkatakunci_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkatakunci.TextChanged
        Call isiListView(txtkatakunci.Text)
    End Sub

    Private Sub btnpilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpilih.Click
        Call PilihBarisView()
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Me.Close()
    End Sub
End Class