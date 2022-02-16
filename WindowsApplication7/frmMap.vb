Public Class frmMap

    Public start As String = ""
    Public destination As String = ""

    Private Sub frmMap_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try
            WebBrowser1.Navigate("https://www.google.com/maps/dir/SITEX,+Grand+Terminal+Bus+Stop,+AH26,+Sorsogon+City,+Sorsogon//@12.9747581,123.9857262,13z/data=!4m9!4m8!1m5!1m1!1s0x33a0efec65a6e06b:0x7fe33eedf6776cd6!2m2!1d124.0207459!2d12.9746768!1m0!3e0")

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            Me.Close()
        End Try
    End Sub

End Class