Imports System.Data.Odbc
Public Class clskwitansi

    Private fno_kwit As String
    Private ftglkwit As Date
    Private fno_nota As String

    Public Property pno_kwit() As String
        Get
            Return fno_kwit
        End Get
        Set(ByVal value As String)
            fno_kwit = value
        End Set
    End Property

    Public Property ptglkwit() As Date
        Get
            Return ftglkwit
        End Get
        Set(ByVal value As Date)
            ftglkwit = value
        End Set
    End Property

    Public Property pno_nota() As String
        Get
            Return fno_nota
        End Get
        Set(ByVal value As String)
            fno_nota = value
        End Set
    End Property

    Public Function autonumber() As String
        Dim nilai As String
        sql = "select max(no_kwit) as max from kwitansi"
        cmmd = New OdbcCommand(sql, MyCn)
        Bacadata = cmmd.ExecuteReader
        Bacadata.Read()
        If Bacadata.IsDBNull(0) Then
            nilai = "KW00001"
        Else
            nilai = Val(Mid(Bacadata.Item("max"), 3, 5)) + 1
            If Len(nilai) = 1 Then
                nilai = "KW0000" + nilai
            ElseIf Len(nilai) = 2 Then
                nilai = "KW000" + nilai
            ElseIf Len(nilai) = 3 Then
                nilai = "KW00" + nilai
            ElseIf Len(nilai) = 4 Then
                nilai = "KW0" + nilai
            ElseIf Len(nilai) = 5 Then
                nilai = "KW" + nilai
            End If
        End If
        Bacadata.Close()
        Return nilai
    End Function

    Public Function cari() As Boolean
        sql = "select * from kwitansi where no_kwit=@1"
        cmmd = New OdbcCommand(sql, MyCn)
        cmmd.Parameters.AddWithValue("@1", fno_kwit)
        Bacadata = cmmd.ExecuteReader
        Bacadata.Read()
        If Bacadata.HasRows = True Then
            fno_kwit = Bacadata.Item("no_kwit")
            ftglkwit = Bacadata.Item("tglkwit")
            fno_nota = Bacadata.Item("no_nota")
            Return True
        Else
            Bacadata.Close()
            Return False
        End If
    End Function

    Public Function simpan() As Integer
        sql = "insert into kwitansi(no_kwit,tglkwit,no_nota) values(@1,@2,@3)"
        cmmd = New OdbcCommand(sql, MyCn)
        cmmd.Parameters.AddWithValue("@1", fno_kwit)
        cmmd.Parameters.AddWithValue("@2", ftglkwit)
        cmmd.Parameters.AddWithValue("@3", fno_nota)
        Return cmmd.ExecuteNonQuery
    End Function

    Public Function tampildata(ByVal xData As String) As List(Of clskwitansi)
        Dim viloid As String
        Dim baca_class As New List(Of clskwitansi)

        viloid = "select * from kwitansi where no_kwit like '%" & xData & "%'"
        cmmd = New OdbcCommand(viloid, MyCn)

        Bacadata = cmmd.ExecuteReader
        If Bacadata.HasRows Then
            While Bacadata.Read
                Dim objTemp As New clskwitansi
                objTemp.fno_kwit = Bacadata.Item("no_kwit")
                objTemp.ftglkwit = Bacadata.Item("tglkwit")
                objTemp.fno_nota = Bacadata.Item("no_nota")
                baca_class.Add(objTemp)
            End While
        End If
        Bacadata.Close() : Return baca_class
    End Function
End Class
