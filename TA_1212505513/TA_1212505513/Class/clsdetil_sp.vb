﻿Imports System.Data.Odbc
Public Class clsdetil_sp
    Private fno_sp As String
    Private fkd_brg As String
    Private fjmlsp As Integer
    Private fhrgsp As Double

    Public Property pkd_brg() As String
        Get
            Return fkd_brg
        End Get
        Set(ByVal value As String)
            fkd_brg = value
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

    Public Property pjmlsp() As Integer
        Get
            Return fjmlsp
        End Get
        Set(ByVal value As Integer)
            fjmlsp = value
        End Set
    End Property

    Public Property phrgsp() As Double
        Get
            Return fhrgsp
        End Get
        Set(ByVal value As Double)
            fhrgsp = value
        End Set
    End Property


    Public Function cari() As Boolean
        sql = "select * from detil_sp where no_sp=?"
        cmmd = New OdbcCommand(sql, MyCn)
        cmmd.Parameters.AddWithValue("@1", fno_sp)
        Bacadata = cmmd.ExecuteReader
        Bacadata.Read()
        If Bacadata.HasRows = True Then
            fno_sp = Bacadata.Item("no_sp")
            fkd_brg = Bacadata.Item("kd_brg")
            fjmlsp = Bacadata.Item("jmlsp")
            fhrgsp = Bacadata.Item("hrgsp")
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

        xSimpan = "INSERT INTO detil_sp"
        xSimpan &= "(no_sp,kd_brg,jmlsp,hrgsp)"
        xSimpan &= "values(?,?,?,?)"
        myCmd = New OdbcCommand(xSimpan, MyCn)

        myCmd.Parameters.AddWithValue("no_sp", fno_sp)
        myCmd.Parameters.AddWithValue("kd_brg", fkd_brg)
        myCmd.Parameters.AddWithValue("jmlsp", fjmlsp)
        myCmd.Parameters.AddWithValue("hrgsp", fhrgsp)

        X = myCmd.ExecuteNonQuery

        myCmd.Dispose()
        Return X

    End Function


    Public Function tampildata(ByVal xData As String) As List(Of clsdetil_sp)
        Dim viloid As String
        Dim baca_class As New List(Of clsdetil_sp)

        viloid = "select * from detil_sp where no_sp like '%" & xData & "%'"
        cmmd = New OdbcCommand(viloid, MyCn)

        Bacadata = cmmd.ExecuteReader
        If Bacadata.HasRows Then
            While Bacadata.Read
                Dim objTemp As New clsdetil_sp
                objTemp.fno_sp = Bacadata.Item("no_sp")
                objTemp.fkd_brg = Bacadata.Item("kd_brg")
                objTemp.fjmlsp = Bacadata.Item("jmlsp")
                objTemp.fhrgsp = Bacadata.Item("hrgsp")
                baca_class.Add(objTemp)
            End While
        End If
        Bacadata.Close() : Return baca_class
    End Function
End Class
