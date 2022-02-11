Imports System.Data.SqlClient
Imports System.IO

Public Class add_terminal

    Dim time_now As String = TimeOfDay.ToString("h:mm:ss tt")
    Dim date_today As String = DateTime.Now.ToString("yyyy/MM/dd")

    Public tmp_cmb_opt As String = ""

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


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub add_terminal_Load(sender As Object, e As EventArgs) Handles Me.Load
        fill_cmb_operator(cmb_operator)
        cmb_operator.Text = tmp_cmb_opt
    End Sub

    Sub clear()
        txt_terminal.Text = ""
        txt_start.Text = ""
        txt_dest.Text = ""
        cmb_operator.SelectedIndex = -1
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            If is_Empty(cmb_operator.Text) Then
                MsgBox("Operator is required!", vbCritical)
                Return
            End If

            If is_Empty(txt_terminal.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_terminal.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return
            End If

            If is_Empty(txt_start.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_terminal.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return
            End If

            If is_Empty(txt_dest.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_terminal.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return
            End If

            If MsgBox("Save data?", vbQuestion + vbYesNo) = vbYes Then


                Dim sql As String = "sp_terminal"
                cmd.Connection = con
                cmd.CommandText = sql
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("@id", lbl_id.Text)
                    .AddWithValue("@terminal_name", txt_terminal.Text.Trim)
                    .AddWithValue("@operator", cmb_operator.Text)
                    .AddWithValue("@status", "Active")
                    .AddWithValue("@date_added", date_today)
                    .AddWithValue("@start", txt_start.Text.Trim)
                    .AddWithValue("@dest", txt_dest.Text.Trim)


                End With

                Try


                    Dim returnValue As Integer = CType(cmd.ExecuteNonQuery, Integer)

                    '  cmd.ExecuteNonQuery()
                    If returnValue = 1 Then


                        recordAction(date_today, time_now, newdashboard.txt_user.Text, newdashboard.txt_userlevel.Text, "Add terminal " + txt_terminal.Text.Trim)
                        '  frmMaintenance.load_auditTrails()
                        clear()
                        frmTerminals.load_terminal()
                        Me.Close()
                    Else
                        MsgBox("Terminal name already exist!", vbCritical)


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

            If is_Empty(txt_terminal.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_terminal.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return
            End If

            If is_Empty(txt_start.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_terminal.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return
            End If

            If is_Empty(txt_dest.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_terminal.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return
            End If

            If MsgBox("Update data?", vbQuestion + vbYesNo) = vbYes Then


                Dim sql As String = "sp_terminal"
                cmd.Connection = con
                cmd.CommandText = sql
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("@id", lbl_id.Text)
                    .AddWithValue("@terminal_name", txt_terminal.Text.Trim)
                    .AddWithValue("@operator", cmb_operator.Text)
                    .AddWithValue("@status", "Active")
                    .AddWithValue("@date_added", date_today)
                    .AddWithValue("@start", txt_start.Text.Trim)
                    .AddWithValue("@dest", txt_dest.Text.Trim)


                End With

                Try


                    Dim returnValue As Integer = CType(cmd.ExecuteNonQuery, Integer)

                    '  cmd.ExecuteNonQuery()
                    If returnValue = 1 Then


                        recordAction(date_today, time_now, newdashboard.txt_user.Text, newdashboard.txt_userlevel.Text, "Add terminal " + txt_terminal.Text.Trim)
                        '  frmMaintenance.load_auditTrails()
                        clear()
                        frmTerminals.load_terminal()
                        Me.Close()
                    Else
                        MsgBox("Terminal name already exist!", vbCritical)


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
End Class