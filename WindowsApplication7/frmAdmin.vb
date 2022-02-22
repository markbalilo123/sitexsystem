Imports System.Data.SqlClient
Imports System.IO

Public Class frmAdmin
    Dim time_now As String = TimeOfDay.ToString("h:mm:ss tt")
    Dim date_today As String = DateTime.Now.ToString("yyyy/MM/dd")

    Public tmp_password As String = ""
    Public tmp_fullname As String = ""
    Public tmp_id As String = ""

    Public opt_id As String = ""

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        '   New(100)

        ' Add any initialization after the InitializeComponent() call.
        Me.Width = Screen.GetWorkingArea(Me).Width
        Me.Height = Screen.GetWorkingArea(Me).Height + 1

        DoubleBufferedControl(Panel5)
    End Sub


    Sub closeForms()
        For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
            If My.Application.OpenForms(i) IsNot Me Then My.Application.OpenForms(i).Dispose()

        Next
    End Sub

    Sub load_sysname()
        Try
            connect()
            sql = "Select system_name from tbl_systeminfo"
            adp = New SqlDataAdapter(sql, con)
            ds = New DataSet
            adp.Fill(ds, "a")
            If ds.Tables("a").Rows.Count > 0 Then
                For x = 0 To ds.Tables("a").Rows.Count - 1
                    With ds.Tables("a")
                        txt_sysname.Text = .Rows(x).Item("system_name").ToString()
                    End With
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Panel3.Width = 46 Then
            Timer1.Start()
        ElseIf Panel3.Width = 208 Then
            Timer2.Start()


        End If
    End Sub

    Public Sub load_users()

        connect()
        sql = "Select * from tbl_users a left join tbl_operator b on a.OperatorID=b.OperatorID where id=@id"
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.SelectCommand.Parameters.AddWithValue("@id", lbl_userId.Text)
        adp.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then
            For x = 0 To ds.Tables("a").Rows.Count - 1
                With ds.Tables("a")

                    tmp_fullname = .Rows(x).Item("fullname").ToString
                    txt_user.Text = .Rows(x).Item("username").ToString
                    tmp_password = .Rows(x).Item("password").ToString
                    txt_userlevel.Text = .Rows(x).Item("userlevel").ToString
                    txt_opt.Text = .Rows(x).Item("name").ToString
                    tmp_id = .Rows(x).Item("id").ToString
                End With
            Next
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Panel3.Width = 208 Then
            Timer1.Stop()

            Label2.ForeColor = Color.White
            Label4.ForeColor = Color.White
            txt_user.ForeColor = Color.White
            txt_userlevel.ForeColor = Color.White
            txt_opt.ForeColor = Color.White
            Label6.ForeColor = Color.White

            For Each f As Form In My.Application.OpenForms
                If f.Name = frmDashboardMain.Name Then Return
            Next
            closeForms()
            With frmDashboardMain
                .Width = Panel5.Width
                .Height = Panel5.Height
                .TopLevel = False
                Panel5.Controls.Add(frmDashboardMain)
                .BringToFront()
                .Show()

            End With

        Else
            PictureBox1.Left += 2
            Panel3.Width = Panel3.Width + 2
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Panel3.Width = 46 Then
            Timer2.Stop()

            Label2.ForeColor = System.Drawing.Color.FromArgb(0, 175, 219)
            Label4.ForeColor = System.Drawing.Color.FromArgb(0, 175, 219)
            txt_user.ForeColor = System.Drawing.Color.FromArgb(0, 175, 219)
            txt_userlevel.ForeColor = System.Drawing.Color.FromArgb(0, 175, 219)
            txt_opt.ForeColor = System.Drawing.Color.FromArgb(0, 175, 219)
            Label6.ForeColor = System.Drawing.Color.FromArgb(0, 175, 219)
        Else
            PictureBox1.Left -= 2
            Panel3.Width = Panel3.Width - 2
        End If
    End Sub

    Private Sub Panel5_Resize(sender As Object, e As EventArgs) Handles Panel5.Resize
        For Each f As Form In Panel5.Controls
            f.Width = Panel5.Width
            f.Height = Panel5.Height

        Next
    End Sub

    Function getOptName(ByVal optId As String)
        Try
            Dim ret As String = ""

            connect()
            sql = "Select name from tbl_operator where OperatorID=@opt_id"
            adp = New SqlDataAdapter(sql, con)
            ds = New DataSet
            adp.SelectCommand.Parameters.AddWithValue("@opt_id", opt_id)
            adp.Fill(ds, "a")
            If ds.Tables("a").Rows.Count > 0 Then
                For x = 0 To ds.Tables("a").Rows.Count - 1
                    With ds.Tables("a")
                        ret = .Rows(x).Item("name").ToString()
                        Return ret
                    End With
                Next
            End If
            Return Nothing
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        Return Nothing
    End Function

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
        Label2.ForeColor = System.Drawing.Color.FromArgb(0, 175, 219)
        Label4.ForeColor = System.Drawing.Color.FromArgb(0, 175, 219)
        txt_user.ForeColor = System.Drawing.Color.FromArgb(0, 175, 219)
        txt_userlevel.ForeColor = System.Drawing.Color.FromArgb(0, 175, 219)
        txt_opt.ForeColor = System.Drawing.Color.FromArgb(0, 175, 219)
        Label6.ForeColor = System.Drawing.Color.FromArgb(0, 175, 219)
        txt_opt.Text = getOptName(opt_id)
        load_sysname()
    End Sub

    Public Sub clearLoginDetails()
        txt_user.Text = ""
        txt_userlevel.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If MsgBox("Are you sure you want to exit?", vbQuestion + vbYesNo) = vbYes Then
            recordAction(date_today, time_now, txt_user.Text, txt_userlevel.Text, "Logout")
            clearLoginDetails()

            'record login audit trail


            Me.Close()
            login.Show()
        Else

        End If
    End Sub


    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        For Each f As Form In My.Application.OpenForms
            If f.Name = frmAdminOpt.Name Then Return
        Next
        closeForms()
        With frmAdminOpt
            .opt_id = opt_id
            .Width = Panel5.Width
            .Height = Panel5.Height
            .TopLevel = False
            Panel5.Controls.Add(frmAdminOpt)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each f As Form In My.Application.OpenForms
            If f.Name = frmDashboardMain.Name Then Return
        Next
        closeForms()
        With frmDashboardMain
            .Width = Panel5.Width
            .Height = Panel5.Height
            .TopLevel = False
            Panel5.Controls.Add(frmDashboardMain)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub btnMakeelection_Click(sender As Object, e As EventArgs) Handles btnMakeelection.Click
        For Each f As Form In My.Application.OpenForms
            If f.Name = frmDrivers.Name Then Return
        Next
        closeForms()
        With frmDrivers
            ' .btnCreateNew.Visible = False

            .opt_id = opt_id
            .Width = Panel5.Width
            .Height = Panel5.Height
            .TopLevel = False
            Panel5.Controls.Add(frmDrivers)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        For Each f As Form In My.Application.OpenForms
            If f.Name = frmVehicles.Name Then Return
        Next
        closeForms()
        With frmVehicles
            '  .btnCreateNew.Visible = False
            .opt_id = opt_id
            .Width = Panel5.Width
            .Height = Panel5.Height
            .TopLevel = False
            Panel5.Controls.Add(frmVehicles)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each f As Form In My.Application.OpenForms
            If f.Name = frmAdminTerminal.Name Then Return
        Next
        closeForms()
        With frmAdminTerminal
            .opt_id = opt_id
            .Width = Panel5.Width
            .Height = Panel5.Height
            .TopLevel = False
            Panel5.Controls.Add(frmAdminTerminal)
            .BringToFront()
            .Show()

        End With
    End Sub



    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        load_users()
        Dim f As New Form
        Try
            With f

                .WindowState = FormWindowState.Maximized
                .StartPosition = FormStartPosition.Manual
                .BackColor = Color.Black
                .Opacity = 0.5
                .ShowInTaskbar = False
                .FormBorderStyle = FormBorderStyle.None
                .Show()
                add_users.Owner = f

                add_users.txt_fname.Text = tmp_fullname
                add_users.txt_user.Text = txt_user.Text
                add_users.txt_pass.Text = tmp_password
                add_users.txt_pass2.Text = tmp_password
                add_users.txt_pass.Text = tmp_password
                add_users.cmb_userlevel.Text = txt_userlevel.Text
                add_users.cmb_userlevel.Enabled = False
                add_users.txt_opt = txt_opt.Text
                add_users.lbl_id.Text = tmp_id
                'add_users.cmb_opt.Enabled = False
                add_users.check_user = txt_opt.Text
                add_users.btnUpdate.Enabled = False
                add_users.ShowDialog()

            End With
        Catch ex As Exception

        Finally
            f.Dispose()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        For Each f As Form In My.Application.OpenForms
            If f.Name = frmFareMatrix.Name Then Return
        Next
        closeForms()
        With frmFareMatrix
            '.opt_id = opt_id
            .Width = Panel5.Width
            .Height = Panel5.Height
            .TopLevel = False
            Panel5.Controls.Add(frmFareMatrix)
            .BringToFront()
            .Show()

        End With
    End Sub
End Class