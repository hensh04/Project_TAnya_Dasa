Imports System.Data.Odbc
Public Class clscustomer
    Private fkd_cus As String
    Private fnm_cus As String
    Private ftlpcus As String
    Private falmtcus As String

    Public Property pnm_cus() As String
        Get
            Return fnm_cus
        End Get
        Set(ByVal value As String)
            fnm_cus = value
        End Set
    End Property

    Public Property pkd_cus() As String
        Get
            Return fkd_cus
        End Get
        Set(ByVal value As String)
            fkd_cus = value
        End Set
    End Property

    Public Property ptlpcus() As String
        Get
            Return ftlpcus
        End Get
        Set(ByVal value As String)
            ftlpcus = value
        End Set
    End Property

    Public Property palmtcus() As String
        Get
            Return falmtcus
        End Get
        Set(ByVal value As String)
            falmtcus = value
        End Set
    End Property

    Public Function autonumber() As String
        Dim nilai As String
        sql = "select max(kd_cus) as max from customer"
        cmmd = New OdbcCommand(sql, MyCn)
        Bacadata = cmmd.ExecuteReader
        Bacadata.Read()
        If Bacadata.IsDBNull(0) Then
            nilai = "C0001"
        Else
            nilai = Val(Mid(Bacadata.Item("max"), 2, 4)) + 1
            If Len(nilai) = 1 Then
                nilai = "C000" + nilai
            ElseIf Len(nilai) = 2 Then
                nilai = "C00" + nilai
            ElseIf Len(nilai) = 3 Then
                nilai = "C0" + nilai
            ElseIf Len(nilai) = 4 Then
                nilai = "C" + nilai
            End If
        End If
        Bacadata.Close()
        Return nilai
    End Function

    Public Function cari() As Boolean
        sql = "select * from customer where kd_cus=?"
        cmmd = New OdbcCommand(sql, MyCn)
        cmmd.Parameters.AddWithValue("?", fkd_cus)
        Bacadata = cmmd.ExecuteReader
        Bacadata.Read()
        If Bacadata.HasRows = True Then
            fkd_cus = Bacadata.Item("kd_cus")
            fnm_cus = Bacadata.Item("nm_cus")
            ftlpcus = Bacadata.Item("tlpcus")
            falmtcus = Bacadata.Item("almtcus")
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

        xHapus = "Delete from customer where kd_cus=?"
        xMyCmd = New OdbcCommand(xHapus, MyCn)
        xMyCmd.Parameters.AddWithValue("kd_cus", fkd_cus)
        xMyCmd.Prepare()
        X = xMyCmd.ExecuteNonQuery()
        xMyCmd.Dispose()
        Return X
    End Function

    Public Function simpan() As Integer
        Dim xSimpan As String
        Dim X As Integer
        Dim xMyCmd As OdbcCommand

        xSimpan = "Insert Into customer "
        xSimpan &= "(kd_cus,nm_cus,tlpcus,almtcus) "
        xSimpan &= " values(?,?,?,?)"
        xMyCmd = New OdbcCommand(xSimpan, MyCn)

        xMyCmd.Parameters.AddWithValue("kd_cus", fkd_cus)
        xMyCmd.Parameters.AddWithValue("nm_cus", fnm_cus)
        xMyCmd.Parameters.AddWithValue("tlpcus", ftlpcus)
        xMyCmd.Parameters.AddWithValue("almtcus", falmtcus)
        xMyCmd.Prepare()
        X = xMyCmd.ExecuteNonQuery()
        xMyCmd.Dispose()
        Return X
    End Function

    Public Function tampildata(ByVal xnama_customer As String) As List(Of clscustomer)
        Dim viloid As String
        Dim baca_class As New List(Of clscustomer)

        viloid = "select kd_cus,nm_cus,tlpcus,almtcus"
        viloid &= " from customer where nm_cus like '%" & xnama_customer & "%'"
        cmmd = New OdbcCommand(viloid, MyCn)

        Bacadata = cmmd.ExecuteReader
        If Bacadata.HasRows Then
            While Bacadata.Read
                Dim objTemp As New clscustomer
                objTemp.fkd_cus = Bacadata.Item("kd_cus")
                objTemp.fnm_cus = Bacadata.Item("nm_cus")
                objTemp.ftlpcus = Bacadata.Item("tlpcus")
                objTemp.falmtcus = Bacadata.Item("almtcus")
                baca_class.Add(objTemp)
            End While
        End If
        Bacadata.Close() : Return baca_class
    End Function

    Public Function ubah() As Integer
        Dim xUbah As String
        Dim x As Integer
        Dim xMyCmd As OdbcCommand

        xUbah = "Update customer set nm_cus=? ,tlpcus=? ,almtcus=?"
        xUbah &= " Where kd_cus=?"
        xMyCmd = New OdbcCommand(xUbah, MyCn)

        xMyCmd.Parameters.AddWithValue("nm_cus", fnm_cus)
        xMyCmd.Parameters.AddWithValue("tlpcus", ftlpcus)
        xMyCmd.Parameters.AddWithValue("almtcus", falmtcus)
        xMyCmd.Parameters.AddWithValue("kd_cus", fkd_cus)

        xMyCmd.Prepare()
        x = xMyCmd.ExecuteNonQuery()

        xMyCmd.Dispose()
        Return x
    End Function
End Class
