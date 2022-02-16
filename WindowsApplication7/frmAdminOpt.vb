Imports System.Data.SqlClient
Imports System.IO

Public Class frmAdminOpt

    Dim time_now As String = TimeOfDay.ToString("h:mm:ss tt")
    Dim date_today As String = DateTime.Now.ToString("yyyy/MM/dd")

    Public opt_id As String = ""

    Sub load_admin_opt(ByVal opt_name As String)

        connect()
        sql = "Select * from tbl_operator a left join tbl_vehicle_type b on a.VehicleTypeID=b.VehicleTypeID where OperatorID=@opt_id"
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.SelectCommand.Parameters.AddWithValue("@opt_id", opt_id)
        adp.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then
            For x = 0 To ds.Tables("a").Rows.Count - 1
                With ds.Tables("a")

                    tbl_id.Text = .Rows(x).Item("OperatorID").ToString
                    txt_name.Text = .Rows(x).Item("name").ToString
                    cmb_type.Text = .Rows(x).Item("vehicle_name").ToString
                    txt_contact.Text = .Rows(x).Item("contact").ToString
                    txt_address.Text = .Rows(x).Item("address").ToString

                End With
            Next
        End If
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.Dispose()

    End Sub

    Sub clear()
        txt_name.Text = ""
        txt_address.Text = ""
        txt_contact.Text = ""
    End Sub


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

    Private Sub frmAdminOpt_Load(sender As Object, e As EventArgs) Handles Me.Load
        fill_cmb_type(cmb_type)

        load_admin_opt(opt_id)
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
                    .AddWithValue("@id", tbl_id.Text)
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

                        load_admin_opt(txt_name.Text)
                        MsgBox("Data successfully save!", vbInformation)

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
End Class