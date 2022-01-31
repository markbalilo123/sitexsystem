Imports System.Data.SqlClient
Imports System.IO


Public Class add_operator

    Dim time_now As String = TimeOfDay.ToString("h:mm:ss tt")
    Dim date_today As String = DateTime.Now.ToString("yyyy/MM/dd")

    Public tmp_cmb_type As String = ""

    Public Sub fill_cmb_type(ByVal cmb As ComboBox)

        connect()
        sql = "Select * from tbl_vehicle_type"
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then
            For x = 0 To ds.Tables("a").Rows.Count - 1
                With ds.Tables("a")
                    'dept_id.Text = .Rows(x).Item("DepartmentID").ToString
                    cmb.Items.Add(.Rows(x).Item("vehicle_name").ToString)

                End With
            Next
        End If
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Sub clear()
        txt_name.Text = ""
        txt_address.Text = ""
        txt_contact.Text = ""
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            If is_Empty(cmb_type.Text) Then
                MsgBox("Vehicle type is required!", vbCritical)
                Return
            End If

            If is_Empty(txt_name.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_name.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return
            ElseIf is_lettersOnly(txt_name.Text) Then

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


                Dim sql As String = "sp_operator"
                cmd.Connection = con
                cmd.CommandText = sql
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("@id", lbl_id.Text)
                    .AddWithValue("@name", txt_name.Text.Trim)



                    .AddWithValue("@address", txt_address.Text.Trim)
                    .AddWithValue("@vehicle", cmb_type.Text)
                    .AddWithValue("@contact", txt_contact.Text)


                    .AddWithValue("@status", "Active")
                    .AddWithValue("@date_added", date_today)


                End With

                Try


                    Dim returnValue As Integer = CType(cmd.ExecuteNonQuery, Integer)

                    '  cmd.ExecuteNonQuery()
                    If returnValue = 1 Then


                        recordAction(date_today, time_now, newdashboard.txt_user.Text, newdashboard.txt_userlevel.Text, "Add operator " + txt_name.Text.Trim)
                        '  frmMaintenance.load_auditTrails()
                        clear()
                        frmOperator.load_operator()
                        Me.Close()
                    Else
                        MsgBox("Operator already exist!", vbCritical)


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

    Private Sub add_operator_Load(sender As Object, e As EventArgs) Handles Me.Load
        fill_cmb_type(cmb_type)

        cmb_type.Text = tmp_cmb_type
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try

            If is_Empty(cmb_type.Text) Then
                MsgBox("Vehicle type is required!", vbCritical)
                Return
            End If

            If is_Empty(txt_name.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_name.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return
            ElseIf is_lettersOnly(txt_name.Text) Then

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


                Dim sql As String = "sp_operator"
                cmd.Connection = con
                cmd.CommandText = sql
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("@id", lbl_id.Text)
                    .AddWithValue("@name", txt_name.Text.Trim)



                    .AddWithValue("@address", txt_address.Text.Trim)
                    .AddWithValue("@vehicle", cmb_type.Text)
                    .AddWithValue("@contact", txt_contact.Text)


                    .AddWithValue("@status", "Active")
                    .AddWithValue("@date_added", date_today)


                End With

                Try


                    Dim returnValue As Integer = CType(cmd.ExecuteNonQuery, Integer)

                    '  cmd.ExecuteNonQuery()
                    If returnValue = 1 Then


                        recordAction(date_today, time_now, newdashboard.txt_user.Text, newdashboard.txt_userlevel.Text, "Update operator " + txt_name.Text.Trim)
                        '  frmMaintenance.load_auditTrails()
                        clear()
                        frmOperator.load_operator()
                        Me.Close()
                    Else
                        MsgBox("Operator already exist!", vbCritical)


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

    Private Sub txt_contact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_contact.KeyPress
        Dim Validinputchar = "0123456789" + vbBack
        If Not Validinputchar.Contains(e.KeyChar) Then
            e.KeyChar = Nothing

        End If
    End Sub

    Private Sub txt_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_name.KeyPress
        Dim Validinputchar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz. " + vbBack
        If Not Validinputchar.Contains(e.KeyChar) Then
            e.KeyChar = Nothing

        End If
    End Sub

    Private Sub txt_address_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_address.KeyPress
        Dim Validinputchar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz. " + vbBack
        If Not Validinputchar.Contains(e.KeyChar) Then
            e.KeyChar = Nothing

        End If
    End Sub
End Class