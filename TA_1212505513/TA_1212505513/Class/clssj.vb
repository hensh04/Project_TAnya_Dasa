Imports System.Data.Odbc
Public Class clssj

    Private fno_sj As String
    Private ftglsj As Date
    Private fno_kwit As String
    Private fkd_kur As String

    Public Property pkd_kur() As String
        Get
            Return fkd_kur
        End Get
        Set(ByVal value As String)
            fkd_kur = value
        End Set
    End Property

    Public Property pno_kwit() As String
        Get
            Return fno_kwit
        End Get
        Set(ByVal value As String)
            fno_kwit = value
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

    Public Property ptglsj() As Date
        Get
            Return ftglsj
        End Get
        Set(ByVal value As Date)
            ftglsj = value
        End Set
    End Property


    Public Function autonumber() As String
        Dim nilai As String
        sql = "select max(no_sj) as max from sj"
        cmmd = New OdbcCommand(sql, MyCn)
        Bacadata = cmmd.ExecuteReader
        Bacadata.Read()
        If Bacadata.IsDBNull(0) Then
            nilai = "SJ00001"
        Else
            nilai = Val(Mid(Bacadata.Item("max"), 3, 5)) + 1
            If Len(nilai) = 1 Then
                nilai = "SJ0000" + nilai
            ElseIf Len(nilai) = 2 Then
                nilai = "SJ000" + nilai
            ElseIf Len(nilai) = 3 Then
                nilai = "SJ00" + nilai
            ElseIf Len(nilai) = 4 Then
                nilai = "SJ0" + nilai
            ElseIf Len(nilai) = 5 Then
                nilai = "SJ" + nilai
            End If
        End If
        Bacadata.Close()
        Return nilai
    End Function


    Public Function cari() As Boolean
        sql = "select * from sj where no_sj=?"
        cmmd = New OdbcCommand(sql, MyCn)
        cmmd.Parameters.AddWithValue("@1", fno_sj)
        Bacadata = cmmd.ExecuteReader
        Bacadata.Read()
        If Bacadata.HasRows = True Then
            fno_sj = Bacadata.Item("no_sj")
            ftglsj = Bacadata.Item("tglsj")
            fno_kwit = Bacadata.Item("no_kwit")
            fkd_kur = Bacadata.Item("kd_kur")
            Return True
        Else
            Bacadata.Close()
            Return False
        End If
    End Function

    Public Function simpan() As Integer
        sql = "insert into sj(no_sj,tglsj,no_kwit,kd_kur) values(?,?,?,?)"
        cmmd = New OdbcCommand(sql, MyCn)
        cmmd.Parameters.AddWithValue("@1", fno_sj)
        cmmd.Parameters.AddWithValue("@2", ftglsj)
        cmmd.Parameters.AddWithValue("@3", fno_kwit)
        cmmd.Parameters.AddWithValue("@4", fkd_kur)
        Return cmmd.ExecuteNonQuery
    End Function

    Public Function tampildata(ByVal xData As String) As List(Of clssj)
        Dim viloid As String
        Dim baca_class As New List(Of clssj)

        viloid = "select * from sj where no_sj like '%" & xData & "%'"
        cmmd = New OdbcCommand(viloid, MyCn)

        Bacadata = cmmd.ExecuteReader
        If Bacadata.HasRows Then
            While Bacadata.Read
                Dim objTemp As New clssj
                objTemp.fno_sj = Bacadata.Item("no_sj")
                objTemp.ftglsj = Bacadata.Item("tglsj")
                objTemp.fno_kwit = Bacadata.Item("no_kwit")
                objTemp.fkd_kur = Bacadata.Item("kd_kur")
                baca_class.Add(objTemp)
            End While
        End If
        Bacadata.Close() : Return baca_class
    End Function
End Class
