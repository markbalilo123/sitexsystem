
Public Class frmMiniMap

    Public start As String = ""
    Public dest As String = ""

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmMiniMap_Load(sender As Object, e As EventArgs) Handles Me.Load
        'WebBrowser1.setdefaultbrowser("chrome.google.browserid")

        MsgBox(start)
        MsgBox(dest)
        Dim url_str As String = "https://www.google.com/maps/dir/" + start + "/" + dest
        MsgBox(url_str)
        ' WebBrowser1.Navigate("https://www.google.com/maps/dir/SITEX,+Grand+Terminal+Bus+Stop,+AH26,+Sorsogon+City,+Sorsogon//@12.9747581,123.9857262,13z/data=!4m9!4m8!1m5!1m1!1s0x33a0efec65a6e06b:0x7fe33eedf6776cd6!2m2!1d124.0207459!2d12.9746768!1m0!3e0")
        WebBrowser1.Navigate(url_str)

    End Sub
End Class