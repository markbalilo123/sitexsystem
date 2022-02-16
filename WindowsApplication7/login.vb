Imports System.Data.SqlClient
Imports System.IO


Public Class login

    Dim opt_id As String = ""

    Dim time_now As String = TimeOfDay.ToString("h:mm:ss tt")
    Dim date_today As String = DateTime.Now.ToString("yyyy/MM/dd")

    Private Sub btnDel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Public Sub clear()
        txt_user.Clear()
        txt_password.Clear()
    End Sub


    Private Function checksNewuser()
        Try
            connect()

            Dim adp As New SqlDataAdapter
            Dim dt As New DataTable
            Dim que As String = "SELECT * FROM tbl_users a left join tbl_userlevel b on a.UserlevelID = b.UserlevelID WHERE username=@un and password=@ps and userlevel <> 'STUDENT'"

            Dim cmd As New SqlCommand(que, con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@un", txt_user.Text)
            cmd.Parameters.AddWithValue("@ps", txt_password.Text)
            '    cmd.Parameters.AddWithValue("@ul", a)
            With adp
                .SelectCommand = cmd
                .Fill(dt)
            End With
            '  MsgBox(dt.Rows.Count)

            If dt.Rows.Count >= 1 Then
                userlevel = dt.Rows(0).Item("userlevel")
                username = dt.Rows(0).Item("username")
                Return True
                Exit Function
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
        Return Nothing
    End Function


    Private Function checksuperadmin()
        Try
            connect()
            Dim a As String = "superadmin"
            Dim adp As New SqlDataAdapter
            Dim dt As New DataTable
            Dim que As String = "SELECT * FROM tbl_users WHERE username =@un and password =@ps and userlevel =@ul "

            Dim cmd As New SqlCommand(que, con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@un", txt_user.Text)
            cmd.Parameters.AddWithValue("@ps", txt_password.Text)
            cmd.Parameters.AddWithValue("@ul", a)
            With adp
                .SelectCommand = cmd
                .Fill(dt)
            End With
            If dt.Rows.Count >= 1 Then
                userlevel = dt.Rows(0).Item("userlevel")
                username = dt.Rows(0).Item("username")
                Return True
                Exit Function
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
        Return Nothing
    End Function

    Private Function checkAdmin()
        Try
            connect()
            Dim a As String = "ADMIN"
            Dim adp As New SqlDataAdapter
            Dim dt As New DataTable
            Dim que As String = "SELECT * FROM tbl_users a left join tbl_operator b on a.OperatorId=b.OperatorID WHERE username =@un and password =@ps and userlevel =@ul "

            Dim cmd As New SqlCommand(que, con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@un", txt_user.Text)
            cmd.Parameters.AddWithValue("@ps", txt_password.Text)
            cmd.Parameters.AddWithValue("@ul", a)
            With adp
                .SelectCommand = cmd
                .Fill(dt)
            End With
            If dt.Rows.Count >= 1 Then
                userlevel = dt.Rows(0).Item("userlevel")
                username = dt.Rows(0).Item("username")
                Return True
                Exit Function
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
        Return Nothing
    End Function

    Private Function checkStaff()
        Try
            connect()
            Dim a As String = "STAFF"
            Dim adp As New SqlDataAdapter
            Dim dt As New DataTable
            Dim que As String = "SELECT * FROM tbl_users WHERE username =@un and password =@ps and userlevel =@ul "

            Dim cmd As New SqlCommand(que, con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@un", txt_user.Text)
            cmd.Parameters.AddWithValue("@ps", txt_password.Text)
            cmd.Parameters.AddWithValue("@ul", a)
            With adp
                .SelectCommand = cmd
                .Fill(dt)
            End With
            If dt.Rows.Count >= 1 Then
                userlevel = dt.Rows(0).Item("userlevel")
                username = dt.Rows(0).Item("username")
                opt_id = dt.Rows(0).Item("OperatorID")
                Return True
                Exit Function
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
        Return Nothing
    End Function

    Private Function checkuser()
        Try
            connect()
            Dim a As String = "STUDENT"
            Dim adp As New SqlDataAdapter
            Dim dt As New DataTable
            Dim que As String = "SELECT * FROM tbl_users WHERE username =@un and password =@ps and userlevel =@ul"

            Dim cmd As New SqlCommand(que, con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@un", txt_user.Text)
            cmd.Parameters.AddWithValue("@ps", txt_password.Text)
            cmd.Parameters.AddWithValue("@ul", a)
            With adp
                .SelectCommand = cmd
                .Fill(dt)
            End With
            If dt.Rows.Count > 0 Then
                userlevel = dt.Rows(0).Item("userlevel")
                username = dt.Rows(0).Item("username")
                Return True
                Exit Function
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
        Return Nothing
    End Function


    'Private Function checkStatus()
    '    Try
    '        Dim status As String = "Election started"
    '        connect()

    '        Dim adp As New SqlDataAdapter
    '        Dim dt As New DataTable
    '        Dim que As String = "SELECT * FROM tbl_election_status a left join tbl_departments b on a.DepartmentID = b.DepartmentID WHERE vote_status=@stat and status=@bitstat"

    '        Dim cmd As New SqlCommand(que, con)
    '        cmd.Parameters.Clear()
    '        cmd.Parameters.AddWithValue("@stat", status)
    '        cmd.Parameters.AddWithValue("@bitstat", 1)

    '        With adp
    '            .SelectCommand = cmd
    '            .Fill(dt)
    '        End With
    '        If dt.Rows.Count >= 1 Then
    '            ' newUserDash.election_ID.Text = dt.Rows(0).Item("ElectionID")
    '            '   newUserDash.ename.Text = dt.Rows(0).Item("election_name")
    '            '   newUserDash.dept.Text = dt.Rows(0).Item("department")
    '            Return True
    '            Exit Function
    '        End If
    '    Catch ex As Exception
    '        MsgBox(Err.Description)
    '    End Try
    '    Return Nothing
    'End Function



    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AcceptButton = btnLogin

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txt_user.Text = "" Or txt_password.Text = "" Then
            '   MsgBox("Fill up all fields!")
            MetroFramework.MetroMessageBox.Show(Me, "Fill up all fields!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf has_ContainsSpecialChars(txt_user.Text) = True Then
            MsgBox("Textbox contains special character!", vbCritical)
            Return
        ElseIf has_ContainsSpecialChars(txt_password.Text) = True Then
            MsgBox("Textbox contains special character!", vbCritical)
            Return

        ElseIf checksuperadmin() = True Then
            ' MsgBox("Successfully Logged In")
            MetroFramework.MetroMessageBox.Show(Me, "Successfully Logged In", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Me.Hide()
            clear()
            newdashboard.txt_user.Text = username
            newdashboard.txt_userlevel.Text = userlevel
            newdashboard.Show()


            'record login audit trail
            recordAction(date_today, time_now, username, userlevel, "Login")

        ElseIf checkAdmin() = True Then
            MetroFramework.MetroMessageBox.Show(Me, "Successfully Logged In", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Hide()
            clear()
            newdashboard.txt_user.Text = username
            newdashboard.txt_userlevel.Text = userlevel
            newdashboard.Show()

            recordAction(date_today, time_now, username, userlevel, "Login")
        ElseIf checkStaff() = True Then
            MetroFramework.MetroMessageBox.Show(Me, "Successfully Logged In", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Hide()
            clear()
            frmAdmin.opt_id = opt_id
            frmAdmin.txt_user.Text = username
            frmAdmin.txt_userlevel.Text = userlevel
            frmAdmin.Show()

            recordAction(date_today, time_now, username, userlevel, "Login")
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Invalid username and password!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub


    Private Sub MetroButton1_Click_1(sender As Object, e As EventArgs)
        Dim trimChars As Char() = {" "c}


        txt_user.Text.Trim(trimChars)
        MsgBox(txt_user.Text.Trim(trimChars))
    End Sub



    Private Sub btn_add_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_add.MouseDown
        txt_password.PasswordChar = ""
        txt_password.UseSystemPasswordChar = False
    End Sub

    Private Sub btn_add_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_add.MouseUp
        txt_password.PasswordChar = "*"
        txt_password.UseSystemPasswordChar = True
    End Sub

    Private Sub txt_user_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_user.KeyPress
        Dim Validinputchar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789" + vbBack
        If Not Validinputchar.Contains(e.KeyChar) Then
            e.KeyChar = Nothing

        End If
    End Sub

    Private Sub txt_password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_password.KeyPress
        Dim Validinputchar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789" + vbBack
        If Not Validinputchar.Contains(e.KeyChar) Then
            e.KeyChar = Nothing

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Are you sure you want to exit?", vbQuestion + vbYesNo) = vbYes Then
            Me.Close()

        End If


    End Sub
End Class