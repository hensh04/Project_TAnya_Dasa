Imports System.Data.Odbc
Public Class clskurir

    Private fkd_kur As String
    Private fnm_kur As String
    Private ftlpkur As String
    Private falmtkur As String

    Public Property pkd_kur() As String
        Get
            Return fkd_kur
        End Get
        Set(ByVal value As String)
            fkd_kur = value
        End Set
    End Property

    Public Property pnm_kur() As String
        Get
            Return fnm_kur
        End Get
        Set(ByVal value As String)
            fnm_kur = value
        End Set
    End Property

    Public Property ptlpkur() As String
        Get
            Return ftlpkur
        End Get
        Set(ByVal value As String)
            ftlpkur = value
        End Set
    End Property

    Public Property palmtkur() As String
        Get
            Return falmtkur
        End Get
        Set(ByVal value As String)
            falmtkur = value
        End Set
    End Property


    Public Function autonumber() As String
        Dim nilai As String
        sql = "select max(kd_kur) as max from kurir"
        cmmd = New OdbcCommand(sql, MyCn)
        Bacadata = cmmd.ExecuteReader
        Bacadata.Read()
        If Bacadata.IsDBNull(0) Then
            nilai = "K01"
        Else
            nilai = Val(Mid(Bacadata.Item("max"), 2, 2)) + 1
            If Len(nilai) = 1 Then
                nilai = "K0" + nilai
            ElseIf Len(nilai) = 2 Then
                nilai = "K" + nilai
            End If
        End If
        Bacadata.Close()
        Return nilai
    End Function

    Public Function cari() As Boolean
        sql = "select * from kurir where kd_kur=@1"
        cmmd = New OdbcCommand(sql, MyCn)
        cmmd.Parameters.AddWithValue("@1", fkd_kur)
        Bacadata = cmmd.ExecuteReader
        Bacadata.Read()
        If Bacadata.HasRows = True Then
            fkd_kur = Bacadata.Item("kd_kur")
            fnm_kur = Bacadata.Item("nm_kur")
            ftlpkur = Bacadata.Item("tlpkur")
            falmtkur = Bacadata.Item("almtkur")
            Return True
        Else
            Bacadata.Close()
            Return False
        End If
    End Function

    Public Function hapus() As Integer
        Dim xHapus As String
        Dim X As Integer
        Dim xMyCmd As OdbcCommand

        xHapus = "Delete from kurir where kd_kur=?"
        xMyCmd = New OdbcCommand(xHapus, MyCn)
        xMyCmd.Parameters.AddWithValue("kd_kur", fkd_kur)
        xMyCmd.Prepare()
        X = xMyCmd.ExecuteNonQuery()
        xMyCmd.Dispose()
        Return X
    End Function

    Public Function simpan() As Integer
        Dim xSimpan As String
        Dim X As Integer
        Dim xMyCmd As OdbcCommand

        xSimpan = "Insert Into kurir "
        xSimpan &= "(kd_kur,nm_kur,tlpkur,almtkur) "
        xSimpan &= " values(?,?,?,?)"
        xMyCmd = New OdbcCommand(xSimpan, MyCn)

        xMyCmd.Parameters.AddWithValue("kd_kur", fkd_kur)
        xMyCmd.Parameters.AddWithValue("nm_kur", fnm_kur)
        xMyCmd.Parameters.AddWithValue("tlpkur", ftlpkur)
        xMyCmd.Parameters.AddWithValue("almtkur", falmtkur)
        xMyCmd.Prepare()
        X = xMyCmd.ExecuteNonQuery()
        xMyCmd.Dispose()
        Return X
    End Function

    Public Function tampildata(ByVal xnama_kurir As String) As List(Of clskurir)
        Dim viloid As String
        Dim baca_class As New List(Of clskurir)

        viloid = "select kd_kur,nm_kur,tlpkur,almtkur"
        viloid &= " from kurir where nm_kur like '%" & xnama_kurir & "%'"
        cmmd = New OdbcCommand(viloid, MyCn)

        Bacadata = cmmd.ExecuteReader
        If Bacadata.HasRows Then
            While Bacadata.Read
                Dim objTemp As New clskurir
                objTemp.fkd_kur = Bacadata.Item("kd_kur")
                objTemp.fnm_kur = Bacadata.Item("nm_kur")
                objTemp.ftlpkur = Bacadata.Item("tlpkur")
                objTemp.falmtkur = Bacadata.Item("almtkur")
                baca_class.Add(objTemp)
            End While
        End If
        Bacadata.Close() : Return baca_class
    End Function

    Public Function ubah() As Integer
        Dim xUbah As String
        Dim x As Integer
        Dim xMyCmd As OdbcCommand

        xUbah = "Update kurir set nm_kur=? ,tlpkur=? ,almtkur=?"
        xUbah &= " Where kd_kur=?"
        xMyCmd = New OdbcCommand(xUbah, MyCn)

        xMyCmd.Parameters.AddWithValue("nm_kur", fnm_kur)
        xMyCmd.Parameters.AddWithValue("tlpkur", ftlpkur)
        xMyCmd.Parameters.AddWithValue("almtkur", falmtkur)
        xMyCmd.Parameters.AddWithValue("kd_kur", fkd_kur)

        xMyCmd.Prepare()
        x = xMyCmd.ExecuteNonQuery()

        xMyCmd.Dispose()
        Return x
    End Function
End Class
