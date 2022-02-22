Imports System.Data.SqlClient
Imports System.IO


Public Class add_users

    Public txt_opt As String = ""
    Public check_user As String = ""

    Dim time_now As String = TimeOfDay.ToString("h:mm:ss tt")
    Dim date_today As String = DateTime.Now.ToString("yyyy/MM/dd")



    Public Sub clear_users()
        txt_user.Text = ""
        txt_pass.Text = ""
        txt_pass2.Text = ""
        cmb_userlevel.SelectedIndex = -1
    End Sub

    Public Sub fill_cmb_operator(ByVal cmb As ComboBox)

        connect()
        sql = "select * from tbl_operator"
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then
            For x = 0 To ds.Tables("a").Rows.Count - 1
                With ds.Tables("a")
                    'dept_id.text = .rows(x).item("departmentid").tostring
                    cmb.Items.Add(.Rows(x).Item("name").ToString)

                End With
            Next
        End If
    End Sub

    Private Function check_number_of_user()
        Dim count As Integer
        Dim user As String = "STUDENT"

        sql = "Select userlevel from tbl_users WHERE userlevel=@userlvl"
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.SelectCommand.Parameters.AddWithValue("@userlvl", user)
        adp.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then
            For x = 0 To ds.Tables("a").Rows.Count - 1
                With ds.Tables("a")
                    count = count + 1
                End With
            Next
        End If


        Return count
    End Function


    Private Function check_number_of_admin()
        Dim count As Integer
        Dim user_admin As String = "ADMIN"

        sql = "Select userlevel from tbl_users WHERE userlevel=@userlvl"
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.SelectCommand.Parameters.AddWithValue("@userlvl", user_admin)
        adp.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then
            For x = 0 To ds.Tables("a").Rows.Count - 1
                With ds.Tables("a")
                    count = count + 1
                End With
            Next
        End If


        Return count
    End Function


    'Public Sub fill_cmbuserlevel()
    '    cmb_userlevel.Items.Clear()
    '    connect()
    '    sql = "Select * from tbl_userlevel"
    '    adp = New SqlDataAdapter(sql, con)
    '    ds = New DataSet
    '    adp.Fill(ds, "a")
    '    If ds.Tables("a").Rows.Count > 0 Then
    '        For x = 0 To ds.Tables("a").Rows.Count - 1
    '            With ds.Tables("a")

    '                cmb_userlevel.Items.Add(.Rows(x).Item("userlevel").ToString)

    '            End With
    '        Next
    '    End If
    'End Sub



    Private Function countUserlevel(ByVal userlevel As String)
        Dim cntMaxUser As Integer = 0
        Dim cntNumofUser As Integer

        connect()

        sql = "Select max_user from tbl_userlevel where userlevel=@userlevel"
        '   cmd.Parameters.AddWithValue("@dept_name", cmb_dept.Text)
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.SelectCommand.Parameters.AddWithValue("userlevel", userlevel)
        adp.Fill(ds, "a")

        If ds.Tables("a").Rows.Count > 0 Then
            With ds.Tables("a")
                cntMaxUser = .Rows(0).Item("max_user")
            End With

        End If

        ' MsgBox(cntMaxUser)



        'count the number of userlevel if its not reach the max user
        connect()

        sql = "Select count(userlevel) As cnt from tbl_users a left join tbl_userlevel b On a.UserlevelID = b.UserlevelID where userlevel=@userlevel"
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.SelectCommand.Parameters.AddWithValue("userlevel", userlevel)
        adp.Fill(ds, "a")

        If ds.Tables("a").Rows.Count > 0 Then
            With ds.Tables("a")
                cntNumofUser = .Rows(0).Item("cnt")
            End With

        End If


        '      MsgBox(cntNumofUser)


        If cntNumofUser >= cntMaxUser Then
            MsgBox(userlevel + " accounts have reach maximum number!", vbCritical)
            Return False
        Else
            Return True
        End If




    End Function


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Dim checkNumOfUser As Boolean = countUserlevel(cmb_userlevel.Text)

        'If checkNumOfUSer = False Then Return



        'Dim cntAdmin As Integer = check_number_of_admin()
        'If cntAdmin > 4 Then
        '    MsgBox("Admin accounts have reach maximum number!", vbExclamation)
        '    Return
        'End If



        'Dim cntUser As Integer = check_number_of_user()
        'If cntUser > 1 Then
        '    MsgBox("User accounts have reach maximum number!", vbExclamation)
        '    Return
        'End If
        If cmb_userlevel.Text = "SUPERADMIN" Then Return

        Try
            If is_Empty(txt_user.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_user.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return

            End If


            If is_Empty(txt_pass.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_pass.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return

            End If



            If is_Empty(txt_pass2.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_pass2.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return

            End If

            If is_Empty(cmb_userlevel.Text) = True Then Return

            'If cmb_userlevel.Text = "STUDENT" Then
            '    '  MsgBox("USER")
            '    Dim cntUser As Integer = check_number_of_user()
            '    If cntUser >= 1 Then
            '        MsgBox("Student accounts have reach maximum number!", vbExclamation)
            '        Return
            '    End If
            'ElseIf cmb_userlevel.Text = "ADMIN" Then
            '    ' MsgBox("ADMIN")
            '    Dim cntAdmin As Integer = check_number_of_admin()
            '    '   MsgBox(cntAdmin)
            '    If cntAdmin >= 4 Then
            '        MsgBox("Admin accounts have reach maximum number!", vbExclamation)
            '        Return
            '    End If
            'End If


            If (txt_pass.Text <> txt_pass2.Text) = True Then
                MsgBox("Password don't match!")
                Return
            End If

            If MsgBox("Save data?", vbQuestion + vbYesNo) = vbYes Then


                Dim sql As String = "user_insert2"
                cmd.Connection = con
                cmd.CommandText = sql
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("@id", lbl_id.Text)
                    .AddWithValue("@fullname", txt_fname.Text.Trim)



                    .AddWithValue("@username", txt_user.Text.Trim)

                    .AddWithValue("@password", txt_pass.Text)
                    '  .AddWithValue("@userlevelid", txt_userlvlid.Text)
                    .AddWithValue("@userlevel", cmb_userlevel.Text)
                    If cmb_userlevel.Text = "STAFF" Then
                        .AddWithValue("@operator", cmb_opt.Text)
                    Else
                        .AddWithValue("@operator", "")
                    End If



                End With

                Try


                    Dim returnValue As Integer = CType(cmd.ExecuteNonQuery, Integer)

                    '  cmd.ExecuteNonQuery()
                    If returnValue = 1 Then


                        recordAction(date_today, time_now, newdashboard.txt_user.Text, newdashboard.txt_userlevel.Text, "Add " + txt_user.Text + " as " + cmb_userlevel.Text)
                        '  frmMaintenance.load_auditTrails()
                        clear_users()
                        frmMaintenance.load_users()

                        If check_user <> "" Then
                            frmAdmin.load_users()

                        End If

                        Me.Close()
                        Else
                            MsgBox("Username already exist!", vbCritical)


                    End If











                Catch ex As Exception

                    con.Close()
                    MsgBox(ex.Message, vbCritical)
                End Try
            End If
        Catch ex As Exception

            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub





    Private Sub add_usersLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        'If tx_userlevel.Text = "" Then
        '    cmb_userlevel.Items.Clear()
        '    cmb_userlevel.Items.Add("ADMIN")
        '    cmb_userlevel.Items.Add("STUDENT")
        'ElseIf tx_userlevel.Text = "SUPERADMIN" Then
        '    cmb_userlevel.Items.Clear()
        '    cmb_userlevel.Items.Add("SUPERADMIN")
        '    cmb_userlevel.Text = "SUPERADMIN"
        'Else
        '    cmb_userlevel.Items.Clear()
        '    cmb_userlevel.Items.Add("ADMIN")
        '    cmb_userlevel.Items.Add("STUDENT")
        '    cmb_userlevel.Text = tx_userlevel.Text
        'End If
        'cmb_userlevel.Text = tx_userlevel.Text

        'If tx_userlevel.Text = "superadmin" Then
        '    cmb_userlevel.Enabled = False
        'End If
        'fill_cmb(cmb_dept)


        ' fill_cmbuserlevel()
        cmb_userlevel.Text = tx_userlevel.Text
        If cmb_userlevel.Text = "SUPERADMIN" Then
            cmb_userlevel.Enabled = False
        End If

        fill_cmb_operator(cmb_opt)

        cmb_opt.Text = txt_opt

        If check_user <> "" Then
            cmb_opt.Enabled = False
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        'If cmb_userlevel.Text = "SUPERADMIN" Then

        '    Return
        'End If

        Try
            If is_Empty(txt_user.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_user.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return

            End If


            If is_Empty(txt_pass.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_pass.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return

            End If



            If is_Empty(txt_pass2.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_pass2.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return

            End If

            If is_Empty(cmb_userlevel.Text) = True Then Return

            'If cmb_userlevel.SelectedValue = "superadmin" Then
            '    MsgBox("Error userlevel!")
            '    Return
            'End If

            'If cmb_userlevel.Text = "USER" Then

            '    Dim cntUser As Integer = check_number_of_user()
            '    If cntUser >= 1 Then
            '        MsgBox("User accounts have reach maximum number!", vbExclamation)
            '        Return
            '    End If

            'ElseIf cmb_userlevel.Text = "ADMIN" Then

            '    Dim cntAdmin As Integer = check_number_of_admin()

            '    If cntAdmin >= 4 Then
            '        MsgBox("Admin accounts have reach maximum number!", vbExclamation)
            '        Return
            '    End If
            'End If



            If (txt_pass.Text <> txt_pass2.Text) = True Then
                MsgBox("Password don't match!")
                Return
            End If

            If MsgBox("Update data?", vbQuestion + vbYesNo) = vbYes Then


                Dim sql As String = "user_insert2"
                cmd.Connection = con
                cmd.CommandText = sql
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("@id", lbl_id.Text)
                    .AddWithValue("@fullname", txt_fname.Text.Trim)


                    .AddWithValue("@username", txt_user.Text.Trim)
                    .AddWithValue("@password", txt_pass.Text)
                    '   .AddWithValue("@userlevelid", txt_userlvlid.Text)
                    .AddWithValue("@userlevel", cmb_userlevel.Text)

                    If cmb_userlevel.Text = "STAFF" Then
                        .AddWithValue("@operator", cmb_opt.Text)
                    Else
                        .AddWithValue("@operator", "")
                    End If


                End With

                Try
                    Dim returnValue As Integer = CType(cmd.ExecuteNonQuery, Integer)

                    '  cmd.ExecuteNonQuery()
                    If returnValue = 1 Then


                        recordAction(date_today, time_now, newdashboard.txt_user.Text, newdashboard.txt_userlevel.Text, "Edit user " + txt_user.Text)
                        'frmMaintenance.load_auditTrails()
                        clear_users()
                        frmMaintenance.load_users()
                        Me.Close()
                    Else
                        MsgBox("Username already exist!", vbCritical)

                    End If



                Catch ex As Exception

                    con.Close()
                    MsgBox(ex.Message, vbCritical)
                End Try
            End If
        Catch ex As Exception

            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub txt_user_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_user.KeyPress
        Dim Validinputchar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789" + vbBack
        If Not Validinputchar.Contains(e.KeyChar) Then
            e.KeyChar = Nothing

        End If
    End Sub

    Private Sub txt_pass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pass.KeyPress
        Dim Validinputchar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789" + vbBack
        If Not Validinputchar.Contains(e.KeyChar) Then
            e.KeyChar = Nothing

        End If
    End Sub

    Private Sub txt_pass2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pass2.KeyPress
        Dim Validinputchar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789" + vbBack
        If Not Validinputchar.Contains(e.KeyChar) Then
            e.KeyChar = Nothing

        End If
    End Sub

    Private Sub cmb_userlevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_userlevel.SelectedIndexChanged
        connect()
        sql = "Select UserlevelID from tbl_userlevel where userlevel=@userlevel"
        '   cmd.Parameters.AddWithValue("@dept_name", cmb_dept.Text)
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.SelectCommand.Parameters.AddWithValue("userlevel", cmb_userlevel.Text)
        adp.Fill(ds, "a")

        If ds.Tables("a").Rows.Count > 0 Then
            With ds.Tables("a")
                txt_userlvlid.Text = .Rows(0).Item("UserlevelID").ToString()
            End With

        End If
    End Sub


    Private Sub cmb_userlevel_TextChanged(sender As Object, e As EventArgs) Handles cmb_userlevel.TextChanged
        If cmb_userlevel.Text = "STAFF" Then
            cmb_opt.Enabled = True
        Else
            cmb_opt.Enabled = False
        End If
    End Sub
End Class