Imports System.Data.Odbc
Public Class clsbarang

    Private fkd_brg As String
    Private fjnsbrg As String
    Private fhrgbrg As Double
    Private fstok As Integer
    Private fnm_brg As String

    Public Property pkd_brg() As String
        Get
            Return fkd_brg
        End Get
        Set(ByVal value As String)
            fkd_brg = value
        End Set
    End Property

    Public Property pnm_brg() As String
        Get
            Return fnm_brg
        End Get
        Set(ByVal value As String)
            fnm_brg = value
        End Set
    End Property

    Public Property pjnsbrg() As String
        Get
            Return fjnsbrg
        End Get
        Set(ByVal value As String)
            fjnsbrg = value
        End Set
    End Property

    Public Property phrgbrg() As Double
        Get
            Return fhrgbrg
        End Get
        Set(ByVal value As Double)
            fhrgbrg = value
        End Set
    End Property

    Public Property pstok() As Integer
        Get
            Return fstok
        End Get
        Set(ByVal value As Integer)
            fstok = value
        End Set
    End Property

    Public Function simpan() As Integer
        Dim xSimpan As String
        Dim X As Integer
        Dim xMyCmd As OdbcCommand

        xSimpan = "Insert Into barang "
        xSimpan &= "(kd_brg,nm_brg,jnsbrg,hrgbrg,stok) "
        xSimpan &= " values(?,?,?,?,?)"
        xMyCmd = New OdbcCommand(xSimpan, MyCn)

        xMyCmd.Parameters.AddWithValue("kd_brg", fkd_brg)
        xMyCmd.Parameters.AddWithValue("nm_brg", fnm_brg)
        xMyCmd.Parameters.AddWithValue("jnsbrg", fjnsbrg)
        xMyCmd.Parameters.AddWithValue("hrgbrg", fhrgbrg)
        xMyCmd.Parameters.AddWithValue("stok", fstok)
        xMyCmd.Prepare()
        X = xMyCmd.ExecuteNonQuery()
        xMyCmd.Dispose()
        Return X
    End Function

    Public Function ubah() As Integer
        Dim xUbah As String
        Dim x As Integer
        Dim xMyCmd As OdbcCommand

        xUbah = "Update barang set nm_brg=? ,jnsbrg=? ,hrgbrg=? ,stok=?"
        xUbah &= " Where kd_brg=?"
        xMyCmd = New OdbcCommand(xUbah, MyCn)

        xMyCmd.Parameters.AddWithValue("nm_brg", fnm_brg)
        xMyCmd.Parameters.AddWithValue("jnsbrg", fjnsbrg)
        xMyCmd.Parameters.AddWithValue("hrgbrg", fhrgbrg)
        xMyCmd.Parameters.AddWithValue("stok", fstok)
        xMyCmd.Parameters.AddWithValue("kd_brg", fkd_brg)

        xMyCmd.Prepare()
        x = xMyCmd.ExecuteNonQuery()

        xMyCmd.Dispose()
        Return x

    End Function

    Public Function hapus() As Integer
        Dim xHapus As String
        Dim X As Integer
        Dim xMyCmd As OdbcCommand

        xHapus = "Delete from barang where kd_brg=?"
        xMyCmd = New OdbcCommand(xHapus, MyCn)
        xMyCmd.Parameters.AddWithValue("kd_brg", fkd_brg)
        xMyCmd.Prepare()
        X = xMyCmd.ExecuteNonQuery()
        xMyCmd.Dispose()
        Return X
    End Function

    Public Function cari() As Boolean
        sql = "select * from barang where kd_brg=@1"
        cmmd = New OdbcCommand(sql, MyCn)
        cmmd.Parameters.AddWithValue("@1", fkd_brg)
        Bacadata = cmmd.ExecuteReader
        Bacadata.Read()
        If Bacadata.HasRows = True Then
            fkd_brg = Bacadata.Item("kd_brg")
            fnm_brg = Bacadata.Item("nm_brg")
            fjnsbrg = Bacadata.Item("jnsbrg")
            fhrgbrg = Bacadata.Item("hrgbrg")
            fstok = Bacadata.Item("stok")
            Return True
        Else
            Bacadata.Close()
            Return False
        End If
    End Function

    Public Function autonumber() As String
        Dim nilai As String
        sql = "select max(kd_brg) as max from barang"
        cmmd = New OdbcCommand(sql, MyCn)
        Bacadata = cmmd.ExecuteReader
        Bacadata.Read()
        If Bacadata.IsDBNull(0) Then
            nilai = "B0001"
        Else
            nilai = Val(Mid(Bacadata.Item("max"), 2, 4)) + 1
            If Len(nilai) = 1 Then
                nilai = "B000" + nilai
            ElseIf Len(nilai) = 2 Then
                nilai = "B00" + nilai
            ElseIf Len(nilai) = 3 Then
                nilai = "B0" + nilai
            ElseIf Len(nilai) = 4 Then
                nilai = "B" + nilai
            End If
        End If
        Bacadata.Close()
        Return nilai
    End Function

    Public Function tampildata(ByVal xnama_barang As String) As List(Of clsbarang)
        Dim viloid As String
        Dim baca_class As New List(Of clsbarang)

        viloid = "select kd_brg,nm_brg,jnsbrg,hrgbrg,stok"
        viloid &= " from barang where nm_brg like '%" & xnama_barang & "%'"
        cmmd = New OdbcCommand(viloid, MyCn)

        Bacadata = cmmd.ExecuteReader
        If Bacadata.HasRows Then
            While Bacadata.Read
                Dim objTemp As New clsbarang
                objTemp.fkd_brg = Bacadata.Item("kd_brg")
                objTemp.fnm_brg = Bacadata.Item("nm_brg")
                objTemp.fjnsbrg = Bacadata.Item("jnsbrg")
                objTemp.fhrgbrg = Bacadata.Item("hrgbrg")
                objTemp.fstok = Bacadata.Item("stok")
                baca_class.Add(objTemp)
            End While
        End If
        Bacadata.Close() : Return baca_class
    End Function
End Class
