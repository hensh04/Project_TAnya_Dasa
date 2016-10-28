Imports System.Data.Odbc
Public Class clssp

    Private fno_sp As String
    Private ftglsp As Date
    Private fkd_cus As String
    Private falmtkrm As String
    Private ftgl_krm As Date

    Public Property palmtkrm() As String
        Get
            Return falmtkrm
        End Get
        Set(ByVal value As String)
            falmtkrm = value
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

    Public Property pno_sp() As String
        Get
            Return fno_sp
        End Get
        Set(ByVal value As String)
            fno_sp = value
        End Set
    End Property

    Public Property ptgl_krm() As Date
        Get
            Return ftgl_krm
        End Get
        Set(ByVal value As Date)
            ftgl_krm = value
        End Set
    End Property

    Public Property ptglsp() As Date
        Get
            Return ftglsp
        End Get
        Set(ByVal value As Date)
            ftglsp = value
        End Set
    End Property


    Public Function autonumber() As String
        Dim nilai As String
        sql = "select max(no_sp) as max from sp"
        cmmd = New OdbcCommand(sql, MyCn)
        Bacadata = cmmd.ExecuteReader
        Bacadata.Read()
        If Bacadata.IsDBNull(0) Then
            nilai = "SP00001"
        Else
            nilai = Val(Mid(Bacadata.Item("max"), 3, 5)) + 1
            If Len(nilai) = 1 Then
                nilai = "SP0000" + nilai
            ElseIf Len(nilai) = 2 Then
                nilai = "SP000" + nilai
            ElseIf Len(nilai) = 3 Then
                nilai = "SP00" + nilai
            ElseIf Len(nilai) = 4 Then
                nilai = "SP0" + nilai
            ElseIf Len(nilai) = 5 Then
                nilai = "SP" + nilai
            End If
        End If
        Bacadata.Close()
        Return nilai
    End Function


    Public Function cari() As Boolean
        sql = "select * from sp where no_sp=@1"
        cmmd = New OdbcCommand(sql, MyCn)
        cmmd.Parameters.AddWithValue("@1", fno_sp)
        Bacadata = cmmd.ExecuteReader
        Bacadata.Read()
        If Bacadata.HasRows = True Then
            fno_sp = Bacadata.Item("no_sp")
            ftglsp = Bacadata.Item("tglsp")
            fkd_cus = Bacadata.Item("ks_cus")
            falmtkrm = Bacadata.Item("almtkrm")
            ftgl_krm = Bacadata.Item("tgl_krm")
            Return True
        Else
            Bacadata.Close()
            Return False
        End If
    End Function

    Public Function simpan() As Integer
        Dim xSimpan As String
        Dim X As Integer
        Dim myCmd As OdbcCommand

        xSimpan = "Insert Into sp"
        xSimpan &= "(no_sp,tglsp,kd_cus,almtkrm,tgl_krm)"
        xSimpan &= "values(?,?,?,?,?)"
        myCmd = New OdbcCommand(xSimpan, MyCn)

        myCmd.Parameters.AddWithValue("no_sp", fno_sp)
        myCmd.Parameters.AddWithValue("tglsp", ftglsp)
        myCmd.Parameters.AddWithValue("kd_cus", fkd_cus)
        myCmd.Parameters.AddWithValue("almtkrm", falmtkrm)
        myCmd.Parameters.AddWithValue("tgl_krm", ftgl_krm)

        myCmd.Prepare()
        X = myCmd.ExecuteNonQuery

        myCmd.Dispose()
        Return X

    End Function

    Public Function tampildata(ByVal xData As String) As List(Of clssp)
        Dim viloid As String
        Dim baca_class As New List(Of clssp)

        viloid = "select * from sp where no_sp like '%" & xData & "%'"
        cmmd = New OdbcCommand(viloid, MyCn)

        Bacadata = cmmd.ExecuteReader
        If Bacadata.HasRows Then
            While Bacadata.Read
                Dim objTemp As New clssp
                objTemp.fno_sp = Bacadata.Item("no_sp")
                objTemp.ftglsp = Bacadata.Item("tglsp")
                objTemp.fkd_cus = Bacadata.Item("kd_cus")
                objTemp.falmtkrm = Bacadata.Item("almtkrm")
                objTemp.ftgl_krm = Bacadata.Item("tgl_krm")
                baca_class.Add(objTemp)
            End While
        End If
        Bacadata.Close() : Return baca_class
    End Function
End Class
