Imports System.Data.Odbc
Public Class clsnota

    Private fno_nota As String
    Private ftglnota As Date
    Private fdp As Double
    Private fjnsbyr As String
    Private fno_sp As String

    Public Property pno_nota() As String
        Get
            Return fno_nota
        End Get
        Set(ByVal value As String)
            fno_nota = value
        End Set
    End Property

    Public Property ptglnota() As Date
        Get
            Return ftglnota
        End Get
        Set(ByVal value As Date)
            ftglnota = value
        End Set
    End Property

    Public Property pdp() As Double
        Get
            Return fdp
        End Get
        Set(ByVal value As Double)
            fdp = value
        End Set
    End Property

    Public Property pjnsbyr() As String
        Get
            Return fjnsbyr
        End Get
        Set(ByVal value As String)
            fjnsbyr = value
        End Set
    End Property

    Public Property pno_sp() As String
        Get
            Return fno_sp
        End Get
        Set(ByVal value As String)
            fno_sp = value
        End Set
    End Property

    Public Function autonumber() As String
        Dim nilai As String
        sql = "select max(no_nota) as max from nota"
        cmmd = New OdbcCommand(sql, MyCn)
        Bacadata = cmmd.ExecuteReader
        Bacadata.Read()
        If Bacadata.IsDBNull(0) Then
            nilai = "NT00001"
        Else
            nilai = Val(Mid(Bacadata.Item("max"), 3, 5)) + 1
            If Len(nilai) = 1 Then
                nilai = "NT0000" + nilai
            ElseIf Len(nilai) = 2 Then
                nilai = "NT000" + nilai
            ElseIf Len(nilai) = 3 Then
                nilai = "NT00" + nilai
            ElseIf Len(nilai) = 4 Then
                nilai = "NT0" + nilai
            ElseIf Len(nilai) = 5 Then
                nilai = "NT" + nilai
            End If
        End If
        Bacadata.Close()
        Return nilai
    End Function

    Public Function cari() As Boolean
        sql = "select * from nota where no_nota=@1"
        cmmd = New OdbcCommand(sql, MyCn)
        cmmd.Parameters.AddWithValue("@1", fno_nota)
        Bacadata = cmmd.ExecuteReader
        Bacadata.Read()
        If Bacadata.HasRows = True Then
            fno_nota = Bacadata.Item("no_nota")
            ftglnota = Bacadata.Item("tglnota")
            fdp = Bacadata.Item("dp")
            fjnsbyr = Bacadata.Item("jnsbyr")
            fno_sp = Bacadata.Item("no_sp")
            Return True
        Else
            Bacadata.Close()
            Return False
        End If
    End Function

    Public Function simpan() As Integer
        sql = "insert into nota(no_nota,tglnota,dp,jnsbyr,no_sp) values(?,?,?,?,?)"
        cmmd = New OdbcCommand(sql, MyCn)
        cmmd.Parameters.AddWithValue("?", fno_nota)
        cmmd.Parameters.AddWithValue("?", ftglnota)
        cmmd.Parameters.AddWithValue("?", fdp)
        cmmd.Parameters.AddWithValue("?", fjnsbyr)
        cmmd.Parameters.AddWithValue("?", fno_sp)
        Return cmmd.ExecuteNonQuery
    End Function

    Public Function tampildata(ByVal xData As String) As List(Of clsnota)
        Dim viloid As String
        Dim baca_class As New List(Of clsnota)

        viloid = "select * from nota where no_nota like '%" & xData & "%'"
        cmmd = New OdbcCommand(viloid, MyCn)

        Bacadata = cmmd.ExecuteReader
        If Bacadata.HasRows Then
            While Bacadata.Read
                Dim objTemp As New clsnota
                objTemp.fno_nota = Bacadata.Item("no_nota")
                objTemp.ftglnota = Bacadata.Item("tglnota")
                objTemp.fdp = Bacadata.Item("dp")
                objTemp.fjnsbyr = Bacadata.Item("jnsbyr")
                objTemp.fno_sp = Bacadata.Item("no_sp")
                baca_class.Add(objTemp)
            End While
        End If
        Bacadata.Close() : Return baca_class
    End Function

End Class
