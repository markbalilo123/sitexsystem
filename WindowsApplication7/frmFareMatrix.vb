
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Printing

Public Class frmFareMatrix

    Dim PPD As New PrintPreviewDialog

    Public overallItemCount As Integer
    Public overallItemIndex As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PPD.Document = PrintDocument1
        PrintDocument1.DefaultPageSettings.PaperSize = New PaperSize("Legal", 850, 1135)
        PPD.WindowState = FormWindowState.Maximized
        PPD.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

    End Sub
End Class