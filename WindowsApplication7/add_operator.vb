Imports System.Data.SqlClient
Imports System.IO


Public Class add_operator

    Dim time_now As String = TimeOfDay.ToString("h:mm:ss tt")
    Dim date_today As String = DateTime.Now.ToString("yyyy/MM/dd")

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class