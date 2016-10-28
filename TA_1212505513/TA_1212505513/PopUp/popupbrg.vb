Public Class popupbrg

    Public rkd_brg As String
    Public rNm_brg As String
    Public rJnsbrg As String
    Public rhrgbrg As String
    Public rstok As String

    Dim objbarang As New clsbarang

    Sub isiListView(Optional ByVal kriteria As String = "%")
        Dim xList As List(Of clsbarang)
        xList = objbarang.tampildata(kriteria)
        ListView1.Items.Clear()
        For baris As Integer = 0 To xList.Count - 1
            ListView1.Items.Add(xList.Item(baris).pkd_brg)
            ListView1.Items(baris).SubItems.Add(xList.Item(baris).pnm_brg)
            ListView1.Items(baris).SubItems.Add(xList.Item(baris).pjnsbrg)
            ListView1.Items(baris).SubItems.Add(xList.Item(baris).phrgbrg)
            ListView1.Items(baris).SubItems.Add(xList.Item(baris).pstok)
        Next
    End Sub

    Sub PilihBarisView()
        rkd_brg = ListView1.FocusedItem.Text
        rNm_brg = ListView1.FocusedItem.SubItems(1).Text
        rJnsbrg = ListView1.FocusedItem.SubItems(2).Text
        rhrgbrg = ListView1.FocusedItem.SubItems(3).Text
        rstok = ListView1.FocusedItem.SubItems(4).Text
        Me.Dispose()
    End Sub

    Private Sub popupbrg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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