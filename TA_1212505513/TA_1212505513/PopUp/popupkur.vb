Public Class popupkur
    Public rkd_kur As String
    Public rNm_kur As String
    Public rtlpkur As String
    Public ralmtkur As String

    Dim objkurir As New clskurir

    Sub isiListView(Optional ByVal kriteria As String = "%")
        Dim xList As List(Of clskurir)
        xList = objkurir.tampildata(kriteria)
        ListView1.Items.Clear()
        For baris As Integer = 0 To xList.Count - 1
            ListView1.Items.Add(xList.Item(baris).pkd_kur)
            ListView1.Items(baris).SubItems.Add(xList.Item(baris).pnm_kur)
            ListView1.Items(baris).SubItems.Add(xList.Item(baris).ptlpkur)
            ListView1.Items(baris).SubItems.Add(xList.Item(baris).palmtkur)
        Next
    End Sub
    Sub PilihBarisView()
        rkd_kur = ListView1.FocusedItem.Text
        rnm_kur = ListView1.FocusedItem.SubItems(1).Text
        rtlpkur = ListView1.FocusedItem.SubItems(2).Text
        ralmtkur = ListView1.FocusedItem.SubItems(3).Text
        Me.Dispose()
    End Sub

    Private Sub popupkur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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