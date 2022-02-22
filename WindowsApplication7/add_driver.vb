Imports System.Data.SqlClient
Imports System.IO

Public Class add_driver

    Dim time_now As String = TimeOfDay.ToString("h:mm:ss tt")
    Dim date_today As String = DateTime.Now.ToString("yyyy/MM/dd")

    Public tmp_cmb_opt As String = ""
    Public tmp_cmb_optName As String = ""


    Public Sub fill_cmb_operator(ByVal cmb As ComboBox)
        If tmp_cmb_optName = "" Then
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
        Else
            connect()
            sql = "select * from tbl_operator where name=@opt_name"
            adp = New SqlDataAdapter(sql, con)
            ds = New DataSet
            adp.SelectCommand.Parameters.AddWithValue("@opt_name", tmp_cmb_optName)
            adp.Fill(ds, "a")
            If ds.Tables("a").Rows.Count > 0 Then
                For x = 0 To ds.Tables("a").Rows.Count - 1
                    With ds.Tables("a")
                        'dept_id.text = .rows(x).item("departmentid").tostring
                        cmb.Items.Add(.Rows(x).Item("name").ToString)

                    End With
                Next
            End If
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub add_driver_Load(sender As Object, e As EventArgs) Handles Me.Load
        fill_cmb_operator(cmb_operator)

        cmb_operator.Text = tmp_cmb_opt
    End Sub


    Sub clear()
        txt_licno.Text = ""
        txt_address.Text = ""
        txt_contact.Text = ""
        txt_fname.Text = ""
        txt_lname.Text = ""
        txt_mname.Text = ""

        cmb_operator.SelectedIndex = -1
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            If is_Empty(cmb_operator.Text) Then
                MsgBox("Operator is required!", vbCritical)
                Return
            End If

            If is_Empty(txt_licno.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_licno.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return
            End If

            If is_Empty(txt_lname.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_lname.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return

            ElseIf is_lettersOnly(txt_lname.Text) Then

                MsgBox("Textbox must be letters only!", vbCritical)
                Return
            End If


            If is_Empty(txt_fname.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_fname.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return

            ElseIf is_lettersOnly(txt_fname.Text) Then

                MsgBox("Textbox must be letters only!", vbCritical)
                Return
            End If


            If is_Empty(txt_mname.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_mname.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return

            ElseIf is_lettersOnly(txt_mname.Text) Then

                MsgBox("Textbox must be letters only!", vbCritical)
                Return
            End If


            If is_Empty(txt_address.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_address.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return

            ElseIf is_lettersOnly(txt_address.Text) Then

                MsgBox("Textbox must be letters only!", vbCritical)
                Return
            End If


            If is_Empty(txt_contact.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_contact.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return
            ElseIf is_digitsOnly(txt_contact.Text) Then

                MsgBox("Textbox must be digitss only!", vbCritical)
                Return
            End If


            If MsgBox("Save data?", vbQuestion + vbYesNo) = vbYes Then


                Dim sql As String = "sp_driver"
                cmd.Connection = con
                cmd.CommandText = sql
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("@id", lbl_id.Text)
                    .AddWithValue("@lname", txt_lname.Text.Trim)
                    .AddWithValue("@fname", txt_fname.Text.Trim)
                    .AddWithValue("@mname", txt_mname.Text.Trim)

                    .AddWithValue("@license_no", txt_licno.Text.Trim)

                    .AddWithValue("@address", txt_address.Text.Trim)
                    .AddWithValue("@operator", cmb_operator.Text)
                    .AddWithValue("@contact", txt_contact.Text)


                    .AddWithValue("@status", "Active")
                    .AddWithValue("@date_added", date_today)


                End With

                Try


                    Dim returnValue As Integer = CType(cmd.ExecuteNonQuery, Integer)

                    '  cmd.ExecuteNonQuery()
                    If returnValue = 1 Then


                        recordAction(date_today, time_now, newdashboard.txt_user.Text, newdashboard.txt_userlevel.Text, "Add driver with license no " + txt_licno.Text.Trim)
                        '  frmMaintenance.load_auditTrails()
                        clear()
                        frmDrivers.load_driver()
                        Me.Close()
                    Else
                        MsgBox("Driver already exist!", vbCritical)


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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try

            If is_Empty(cmb_operator.Text) Then
                MsgBox("Operator is required!", vbCritical)
                Return
            End If

            If is_Empty(txt_licno.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_licno.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return
            End If

            If is_Empty(txt_lname.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_lname.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return

            ElseIf is_lettersOnly(txt_lname.Text) Then

                MsgBox("Textbox must be letters only!", vbCritical)
                Return
            End If


            If is_Empty(txt_fname.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_fname.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return

            ElseIf is_lettersOnly(txt_fname.Text) Then

                MsgBox("Textbox must be letters only!", vbCritical)
                Return
            End If


            If is_Empty(txt_mname.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_mname.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return

            ElseIf is_lettersOnly(txt_mname.Text) Then

                MsgBox("Textbox must be letters only!", vbCritical)
                Return
            End If


            If is_Empty(txt_address.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_address.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return

            ElseIf is_lettersOnly(txt_address.Text) Then

                MsgBox("Textbox must be letters only!", vbCritical)
                Return
            End If


            If is_Empty(txt_contact.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_contact.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return
            ElseIf is_digitsOnly(txt_contact.Text) Then

                MsgBox("Textbox must be digitss only!", vbCritical)
                Return
            End If


            If MsgBox("Update data?", vbQuestion + vbYesNo) = vbYes Then


                Dim sql As String = "sp_driver"
                cmd.Connection = con
                cmd.CommandText = sql
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("@id", lbl_id.Text)
                    .AddWithValue("@lname", txt_lname.Text.Trim)
                    .AddWithValue("@fname", txt_fname.Text.Trim)
                    .AddWithValue("@mname", txt_mname.Text.Trim)

                    .AddWithValue("@license_no", txt_licno.Text.Trim)

                    .AddWithValue("@address", txt_address.Text.Trim)
                    .AddWithValue("@operator", cmb_operator.Text)
                    .AddWithValue("@contact", txt_contact.Text)


                    .AddWithValue("@status", "Active")
                    .AddWithValue("@date_added", date_today)


                End With

                Try


                    Dim returnValue As Integer = CType(cmd.ExecuteNonQuery, Integer)

                    '  cmd.ExecuteNonQuery()
                    If returnValue = 1 Then


                        recordAction(date_today, time_now, newdashboard.txt_user.Text, newdashboard.txt_userlevel.Text, "Update driver with license no " + txt_licno.Text.Trim)
                        '  frmMaintenance.load_auditTrails()
                        clear()
                        frmDrivers.load_driver()
                        Me.Close()
                    Else
                        MsgBox("Driver already exist!", vbCritical)


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

    Private Sub cmb_operator_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_operator.SelectedIndexChanged

    End Sub

    Private Sub txt_licno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_licno.KeyPress
        Dim Validinputchar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789-  " + vbBack
        If Not Validinputchar.Contains(e.KeyChar) Then
            e.KeyChar = Nothing

        End If
    End Sub

    Private Sub txt_lname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_lname.KeyPress
        Dim Validinputchar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz " + vbBack
        If Not Validinputchar.Contains(e.KeyChar) Then
            e.KeyChar = Nothing

        End If
    End Sub

    Private Sub txt_mname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_mname.KeyPress
        Dim Validinputchar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz " + vbBack
        If Not Validinputchar.Contains(e.KeyChar) Then
            e.KeyChar = Nothing

        End If
    End Sub

    Private Sub txt_fname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_fname.KeyPress
        Dim Validinputchar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz " + vbBack
        If Not Validinputchar.Contains(e.KeyChar) Then
            e.KeyChar = Nothing

        End If
    End Sub

    Private Sub txt_contact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_contact.KeyPress
        Dim Validinputchar = "0123456789" + vbBack
        If Not Validinputchar.Contains(e.KeyChar) Then
            e.KeyChar = Nothing

        End If
    End Sub

    Private Sub txt_address_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_address.KeyPress
        Dim Validinputchar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789#@  " + vbBack
        If Not Validinputchar.Contains(e.KeyChar) Then
            e.KeyChar = Nothing

        End If
    End Sub
End Class