Imports System.Data.SqlClient
Imports System.IO

Public Class add_vehicle

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

    Private Sub add_vehicle_Load(sender As Object, e As EventArgs) Handles Me.Load
        fill_cmb_operator(cmb_opt)
        cmb_opt.Text = tmp_cmb_opt
    End Sub


    Sub clear()
        txt_plate.Text = ""
        txt_dealer.Text = ""
        txt_yr.Text = ""
        cmb_opt.SelectedIndex = -1
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            If is_Empty(txt_cap.Text) Then
                MsgBox("Capacity is required!", vbCritical)
                Return
            End If

            If is_Empty(txt_cap.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_plate.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return

            End If


            If is_Empty(cmb_opt.Text) Then
                MsgBox("Operator is required!", vbCritical)
                Return
            End If

            If is_Empty(txt_plate.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_plate.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return

            End If

            If is_Empty(txt_yr.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_yr.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return

            End If


            If is_Empty(txt_dealer.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_dealer.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return

            End If


            If MsgBox("Save data?", vbQuestion + vbYesNo) = vbYes Then


                Dim sql As String = "sp_vehicle"
                cmd.Connection = con
                cmd.CommandText = sql
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("@id", lbl_id.Text)
                    .AddWithValue("@plate", txt_plate.Text.Trim)
                    .AddWithValue("@operator", cmb_opt.Text)
                    .AddWithValue("@dealer", txt_dealer.Text.Trim)
                    .AddWithValue("@yrmodel", txt_yr.Text.Trim)
                    .AddWithValue("@status", "Active")
                    .AddWithValue("@date_added", date_today)
                    .AddWithValue("@cap", txt_cap.Text)


                End With

                Try


                    Dim returnValue As Integer = CType(cmd.ExecuteNonQuery, Integer)

                    '  cmd.ExecuteNonQuery()
                    If returnValue = 1 Then


                        recordAction(date_today, time_now, newdashboard.txt_user.Text, newdashboard.txt_userlevel.Text, "Add vehicle with plate no " + txt_plate.Text.Trim)
                        '  frmMaintenance.load_auditTrails()
                        clear()
                        frmVehicles.load_vehicles()
                        Me.Close()
                    Else
                        MsgBox("Vehicle already exist!", vbCritical)


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

            If is_Empty(txt_cap.Text) Then
                MsgBox("Capacity is required!", vbCritical)
                Return
            End If

            If is_Empty(txt_cap.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_plate.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return

            End If

            If is_Empty(cmb_opt.Text) Then
                MsgBox("Operator is required!", vbCritical)
                Return
            End If

            If is_Empty(txt_plate.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_plate.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return

            End If

            If is_Empty(txt_yr.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_yr.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return

            End If


            If is_Empty(txt_dealer.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_dealer.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return

            End If


            If MsgBox("Update data?", vbQuestion + vbYesNo) = vbYes Then


                Dim sql As String = "sp_vehicle"
                cmd.Connection = con
                cmd.CommandText = sql
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("@id", lbl_id.Text)
                    .AddWithValue("@plate", txt_plate.Text.Trim)
                    .AddWithValue("@operator", cmb_opt.Text)
                    .AddWithValue("@dealer", txt_dealer.Text.Trim)
                    .AddWithValue("@yrmodel", txt_yr.Text.Trim)
                    .AddWithValue("@status", "Active")
                    .AddWithValue("@date_added", date_today)
                    .AddWithValue("@cap", txt_cap.Text)

                End With

                Try


                    Dim returnValue As Integer = CType(cmd.ExecuteNonQuery, Integer)

                    '  cmd.ExecuteNonQuery()
                    If returnValue = 1 Then


                        recordAction(date_today, time_now, newdashboard.txt_user.Text, newdashboard.txt_userlevel.Text, "Update vehicle with plate no " + txt_plate.Text.Trim)
                        '  frmMaintenance.load_auditTrails()
                        clear()
                        frmVehicles.load_vehicles()
                        Me.Close()
                    Else
                        MsgBox("Vehicle already exist!", vbCritical)


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