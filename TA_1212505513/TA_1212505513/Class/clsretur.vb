Imports System.Data.Odbc
Public Class clsretur

    Private fno_ret As String
    Private ftglret As Date
    Private fno_sj As String

    Public Property pno_ret() As String
        Get
            Return fno_ret
        End Get
        Set(ByVal value As String)
            fno_ret = value
        End Set
    End Property

    Public Property pno_sj() As String
        Get
            Return fno_sj
        End Get
        Set(ByVal value As String)
            fno_sj = value
        End Set
    End Property

    Public Property ptglret() As Date
        Get
            Return ftglret
        End Get
        Set(ByVal value As Date)
            ftglret = value
        End Set
    End Property

    Public Function autonumber() As String
        Dim nilai As String
        sql = "select max(no_ret) as max from retur"
        cmmd = New OdbcCommand(sql, MyCn)
        Bacadata = cmmd.ExecuteReader
        Bacadata.Read()
        If Bacadata.IsDBNull(0) Then
            nilai = "RT0001"
        Else
            nilai = Val(Mid(Bacadata.Item("max"), 3, 4)) + 1
            If Len(nilai) = 1 Then
                nilai = "RT000" + nilai
            ElseIf Len(nilai) = 2 Then
                nilai = "RT00" + nilai
            ElseIf Len(nilai) = 3 Then
                nilai = "RT0" + nilai
            ElseIf Len(nilai) = 4 Then
                nilai = "RT" + nilai
            End If
        End If
        Bacadata.Close()
        Return nilai
    End Function

    Public Function cari() As Boolean
        sql = "select * from retur where no_ret=@1"
        cmmd = New OdbcCommand(sql, MyCn)
        cmmd.Parameters.AddWithValue("@1", fno_ret)
        Bacadata = cmmd.ExecuteReader
        Bacadata.Read()
        If Bacadata.HasRows = True Then
            fno_ret = Bacadata.Item("no_ret")
            ftglret = Bacadata.Item("tglret")
            fno_sj = Bacadata.Item("no_sj")
            Return True
        Else
            Bacadata.Close()
            Return False
        End If
    End Function

    Public Function simpan() As Integer
        sql = "insert into retur(no_ret,tglret,no_sj) values(@1,@2,@3)"
        cmmd = New OdbcCommand(sql, MyCn)
        cmmd.Parameters.AddWithValue("@1", fno_ret)
        cmmd.Parameters.AddWithValue("@2", ftglret)
        cmmd.Parameters.AddWithValue("@3", fno_sj)
        Return cmmd.ExecuteNonQuery
    End Function

    Public Function tampildata(ByVal xData As String) As List(Of clsretur)
        Dim viloid As String
        Dim baca_class As New List(Of clsretur)

        viloid = "select * from retur where no_ret like '%" & xData & "%'"
        cmmd = New OdbcCommand(viloid, MyCn)

        Bacadata = cmmd.ExecuteReader
        If Bacadata.HasRows Then
            While Bacadata.Read
                Dim objTemp As New clsretur
                objTemp.fno_ret = Bacadata.Item("no_ret")
                objTemp.ftglret = Bacadata.Item("tglret")
                objTemp.fno_sj = Bacadata.Item("no_sj")
                baca_class.Add(objTemp)
            End While
        End If
        Bacadata.Close() : Return baca_class
    End Function
End Class
