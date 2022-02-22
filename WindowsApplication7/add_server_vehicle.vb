
Imports System.Data.SqlClient
Imports System.IO

Public Class add_server_vehicle

    Dim time_now As String = TimeOfDay.ToString("h:mm:ss tt")
    Dim date_today As String = DateTime.Now.ToString("yyyy/MM/dd")

    Public opt_id As String = ""

    Sub clear()
        txt_opt.Text = ""
        txt_vtype.Text = ""
        txt_cap.Text = ""
        txt_plate.Text = ""
        lbl_id.Text = ""
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clear()
        Me.Close()
    End Sub

    Sub load_vehicles_opt()

        DataGridView3.Rows.Clear()
        Dim i As Integer = 0
        connect()
        sql = "Select * from tbl_vehicle a left join tbl_operator b on a.OperatorID=b.OperatorID left join tbl_vehicle_type c on b.VehicleTypeID=c.VehicleTypeID where b.OperatorID = @opt_id and VehicleID NOT IN (SELECT VehicleID FROM tbl_sitexserver)"
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.SelectCommand.Parameters.AddWithValue("@opt_id", opt_id)
        adp.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then
            For x = 0 To ds.Tables("a").Rows.Count - 1
                With ds.Tables("a")
                    i += 1
                    '    MsgBox(i)
                    DataGridView3.Rows.Add(i, .Rows(x).Item("VehicleID").ToString, .Rows(x).Item("plate_no").ToString, .Rows(x).Item("vehicle_name").ToString, .Rows(x).Item("name").ToString, .Rows(x).Item("seat_capacity").ToString)

                End With
            Next

        End If

    End Sub

    Private Sub add_server_vehicle_Load(sender As Object, e As EventArgs) Handles Me.Load
        '    MsgBox(opt_id)
        load_vehicles_opt()
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        Dim f As New Form

        Dim colname As String = DataGridView3.Columns(e.ColumnIndex).Name
        Try
            If colname = "colAdd" Then
                Dim tbl_id As Integer = DataGridView3.Rows(e.RowIndex).Cells(1).Value.ToString
                Dim plate As String = DataGridView3.Rows(e.RowIndex).Cells(2).Value.ToString
                Dim type As String = DataGridView3.Rows(e.RowIndex).Cells(3).Value.ToString
                Dim opt As String = DataGridView3.Rows(e.RowIndex).Cells(4).Value.ToString
                Dim cap As String = DataGridView3.Rows(e.RowIndex).Cells(5).Value.ToString

                lbl_id.text = tbl_id
                txt_opt.Text = opt
                txt_plate.Text = plate
                txt_vtype.Text = type
                txt_cap.Text = cap
                MsgBox("Vehicle sucessfully added!", vbInformation)
            End If
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        Finally
            f.Dispose()
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            If is_Empty(lbl_id.Text) Then
                MsgBox("Vehicle required!", vbCritical)
            End If


            If MsgBox("Save data?", vbQuestion + vbYesNo) = vbYes Then


                Dim sql As String = "sp_sitexserver"
                cmd.Connection = con
                cmd.CommandText = sql
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("@id", "")
                    .AddWithValue("@VehicleID", lbl_id.Text)
                    .AddWithValue("@cap", txt_cap.Text)
                    .AddWithValue("@no", "0")

                End With

                Try


                    Dim returnValue As Integer = CType(cmd.ExecuteNonQuery, Integer)

                    '  cmd.ExecuteNonQuery()
                    If returnValue = 1 Then


                        '  recordAction(date_today, time_now, newdashboard.txt_user.Text, newdashboard.txt_userlevel.Text, "Add driver with license no " + txt_licno.Text.Trim)
                        '  frmMaintenance.load_auditTrails()
                        clear()
                        frmAdminTerminal.load_server_vehicle_opt()
                        frmAdminTerminal.check_full_pass()
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

    Private Sub txtstdsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtstdsearch.KeyPress
        Dim Validinputchar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789-#@  " + vbBack
        If Not Validinputchar.Contains(e.KeyChar) Then
            e.KeyChar = Nothing

        End If
    End Sub

    'Private Sub txtstdsearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtstdsearch.KeyUp

    '    If is_Empty(txtstdsearch.Text) = True Then
    '        Return

    '    ElseIf has_ContainsSpecialChars(txtstdsearch.Text) = True Then
    '        MsgBox("Textbox contains special character!", vbCritical)
    '        Return
    '    End If


    '    DataGridView3.Rows.Clear()
    '    Dim i As Integer
    '    connect()
    '    '  sql = "Select id, department, student_id, lastname, firstname, middle_initial, course, yrlevel, status  from tbl_students"
    '    'sql = "Select * from tbl_students a left join tbl_departments b on a.DepartmentID = b.DepartmentID left join tbl_course c on a.CourseID = c.CourseID where student_id like @std_id or lastname like @std_id or firstname like @std_id or course like @std_id or yrlevel like @std_id OR status like @std_id"
    '    sql = "Select * from tbl_vehicle a left join tbl_operator b on a.OperatorID=b.OperatorID left join tbl_vehicle_type c on b.VehicleTypeID=c.VehicleTypeID where b.OperatorID = @opt_id or plate_no like @std_id and VehicleID NOT IN (SELECT VehicleID FROM tbl_sitexserver)"

    '    adp = New SqlDataAdapter(sql, con)
    '    ds = New DataSet
    '    adp.SelectCommand.Parameters.AddWithValue("@std_id", txtstdsearch.Text)
    '    adp.Fill(ds, "a")
    '    If ds.Tables("a").Rows.Count > 0 Then
    '        For x = 0 To ds.Tables("a").Rows.Count - 1
    '            With ds.Tables("a")
    '                i += 1
    '                DataGridView3.Rows.Add(i, .Rows(x).Item("VehicleID").ToString, .Rows(x).Item("plate_no").ToString, .Rows(x).Item("vehicle_name").ToString, .Rows(x).Item("name").ToString, .Rows(x).Item("seat_capacity").ToString)





    '            End With
    '        Next
    '    Else

    '        load_vehicles_opt()
    '    End If
    'End Sub
End Class