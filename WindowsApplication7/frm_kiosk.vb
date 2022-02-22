Public Class frm_kiosk

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        '   New(100)

        ' Add any initialization after the InitializeComponent() call.
        Me.Width = Screen.GetWorkingArea(Me).Width
        Me.Height = Screen.GetWorkingArea(Me).Height + 1

        DoubleBufferedControl(Panel2)
    End Sub


    Sub closeForms()
        For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
            If My.Application.OpenForms(i) IsNot Me Then My.Application.OpenForms(i).Dispose()

        Next
    End Sub

    Private Sub frm_kiosk_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each f As Form In My.Application.OpenForms
            If f.Name = frm_kiosk_home.Name Then Return
        Next
        closeForms()
        With frm_kiosk_home
            .Width = Panel4.Width
            .Height = Panel4.Height
            .TopLevel = False
            Panel4.Controls.Add(frm_kiosk_home)
            .PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            .BringToFront()
            .Show()

        End With

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        For Each f As Form In My.Application.OpenForms
            If f.Name = frmJeep.Name Then Return
        Next
        closeForms()
        With frmJeep
            .Width = Panel2.Width
            .Height = Panel2.Height
            .TopLevel = False
            Panel2.Controls.Add(frmJeep)
            .BringToFront()
            .Show()

        End With
    End Sub

    'Private Sub Panel2_Resize(sender As Object, e As EventArgs) Handles Panel2.Resize
    '    For Each f As Form In Panel2.Controls
    '        f.Width = Panel2.Width
    '        f.Height = Panel2.Height

    '    Next
    'End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        For Each f As Form In My.Application.OpenForms
            If f.Name = frmMap.Name Then Return
        Next
        closeForms()
        With frmMap
            .Width = Panel2.Width
            .Height = Panel2.Height
            .TopLevel = False
            Panel2.Controls.Add(frmMap)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)
        MsgBox("tae")
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        For Each f As Form In My.Application.OpenForms
            If f.Name = frm_kiosk_terminal.Name Then Return
        Next
        closeForms()
        With frm_kiosk_terminal
            .Width = Panel4.Width
            .Height = Panel4.Height
            .TopLevel = False
            Panel4.Controls.Add(frm_kiosk_terminal)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        For Each f As Form In My.Application.OpenForms
            If f.Name = frm_kiosk_home.Name Then Return
        Next
        closeForms()
        With frm_kiosk_home
            .Width = Panel4.Width
            .Height = Panel4.Height
            .TopLevel = False
            Panel4.Controls.Add(frm_kiosk_home)
            .PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each f As Form In My.Application.OpenForms
            If f.Name = frmMap.Name Then Return
        Next
        closeForms()
        With frmMap
            .Width = Panel4.Width
            .Height = Panel4.Height
            .TopLevel = False
            Panel4.Controls.Add(frmMap)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For Each f As Form In My.Application.OpenForms
            If f.Name = frm_kiosk_about.Name Then Return
        Next
        closeForms()
        With frm_kiosk_about
            .Width = Panel4.Width
            .Height = Panel4.Height
            .TopLevel = False
            Panel4.Controls.Add(frm_kiosk_about)
            .BringToFront()
            .Show()

        End With
    End Sub
End Class