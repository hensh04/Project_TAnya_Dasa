Imports CrystalDecisions.CrystalReports.Engine
Public Class TampilCetakan

    Private Sub TampilCetakan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Dim objreport As New ReportDocument
        If IdCetakan = "1" Then
            objreport = New Cetak_Nota
            objreport.SetParameterValue("NomorNota", frmcetaknota.txtNo_nota.Text)
            objreport.RecordSelectionFormula = "{nota1.no_nota} = '" & frmcetaknota.txtNo_nota.Text & "'"
            objreport.SetParameterValue("SisaBayar", frmcetaknota.txtsisabayar.Text)
        End If
        CrystalReportViewer1.ReportSource = objreport
    End Sub
End Class