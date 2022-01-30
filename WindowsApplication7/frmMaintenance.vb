Imports System.Data.SqlClient
Imports System.IO


Public Class frmMaintenance


    Public time_now As String = TimeOfDay.ToString("h:mm:ss tt")
    Public date_today As String = DateTime.Now.ToString("yyyy/MM/dd")

    Sub load_sysinfo()
        connect()
        sql = "Select * from tbl_systeminfo"
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then
            For x = 0 To ds.Tables("a").Rows.Count - 1
                With ds.Tables("a")

                    tbl_id.Text = .Rows(x).Item("id").ToString
                    txt_sysname.Text = .Rows(x).Item("system_name").ToString
                    txt_name.Text = .Rows(x).Item("company_name").ToString
                    txt_contact.Text = .Rows(x).Item("contact_no").ToString
                    txt_address.Text = .Rows(x).Item("address").ToString



                End With
            Next
        End If
    End Sub

    Public Sub load_vehicle_type()
        DataGridView1.Rows.Clear()
        Dim i As Integer
        connect()
        sql = "Select * from tbl_vehicle_type"
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then
            For x = 0 To ds.Tables("a").Rows.Count - 1
                With ds.Tables("a")
                    i += 1


                    DataGridView1.Rows.Add(.Rows(x).Item("VehicleTypeID").ToString, i, .Rows(x).Item("vehicle_name").ToString)


                End With
            Next
        End If
    End Sub


    Public Sub load_users()
        DataGridView3.Rows.Clear()
        Dim i As Integer
        connect()
        sql = "Select * from tbl_users"
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then
            For x = 0 To ds.Tables("a").Rows.Count - 1
                With ds.Tables("a")
                    i += 1
                    DataGridView3.Rows.Add(.Rows(x).Item("id").ToString, i, .Rows(x).Item("fullname").ToString, .Rows(x).Item("username").ToString, .Rows(x).Item("password").ToString, .Rows(x).Item("userlevel").ToString)





                End With
            Next
        End If
    End Sub


    Public Sub load_auditTrails()

        DataGridView4.Rows.Clear()
        Dim i As Integer
        connect()
        sql = "Select id, date, time, username, userlevel, action from tbl_audittrail where date=@edate"
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.SelectCommand.Parameters.AddWithValue("@edate", date_today)
        adp.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then
            For x = 0 To ds.Tables("a").Rows.Count - 1
                With ds.Tables("a")
                    i += 1
                    DataGridView4.Rows.Add(.Rows(x).Item("id").ToString, i, .Rows(x).Item("date").ToString, .Rows(x).Item("time").ToString, .Rows(x).Item("username").ToString, .Rows(x).Item("userlevel").ToString, .Rows(x).Item("action").ToString)





                End With
            Next
        End If
    End Sub



    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
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
                add_vehicle_type.Owner = f
                add_vehicle_type.btnUpdate.Enabled = False
                add_vehicle_type.ShowDialog()


            End With
        Catch ex As Exception

        Finally
            f.Dispose()
        End Try
    End Sub

    Private Sub frmMaintenance_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_elect_date.MaxDate = DateTime.Today

        txt_elect_date.Format = DateTimePickerFormat.Custom
        txt_elect_date.CustomFormat = "yyyy/MM/dd"

        load_sysinfo()
        load_vehicle_type()
        load_users()
        load_auditTrails()




    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim f As New Form

        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
        Try
            If colname = "colEdit" Then
                Dim tbl_id As Integer = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
                Dim type As String = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString

                With add_vehicle_type
                    .btnSave.Enabled = False
                    .btnUpdate.Enabled = True
                    .lbl_id.Text = tbl_id
                    .txt_type.Text = type

                    f.WindowState = FormWindowState.Maximized
                    f.FormBorderStyle = FormBorderStyle.None
                    f.StartPosition = FormStartPosition.Manual
                    f.BackColor = Color.Black
                    f.Opacity = 0.5
                    f.ShowInTaskbar = False
                    f.Show()
                    .Owner = f
                    .ShowDialog()

                End With
            ElseIf colname = "colDelete" Then
                Dim type As String = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString


                If MsgBox("Do you want to delete vehicle type?", vbQuestion + vbYesNo) = vbYes Then


                    Dim id As Integer = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString

                    sql = "DELETE tbl_vehicle_type WHERE VehicleTypeID=@id"
                    cmd = New SqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@id", id)

                    cmd.ExecuteNonQuery()

                    recordAction(date_today, time_now, newdashboard.txt_user.Text, newdashboard.txt_userlevel.Text, "Delete vehicle_type " + type)
                    '   load_auditTrails()



                    load_vehicle_type()



                End If
            End If


        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        Finally
            f.Dispose()
        End Try

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
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

                add_users.tx_userlevel.Text = ""

                add_users.Owner = f
                add_users.btnUpdate.Enabled = False
                add_users.ShowDialog()


            End With
        Catch ex As Exception

        Finally
            f.Dispose()
        End Try
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        Dim f As New Form

        Dim colname As String = DataGridView3.Columns(e.ColumnIndex).Name
        Try
            If colname = "colEdit3" Then
                Dim tbl_id As Integer = DataGridView3.Rows(e.RowIndex).Cells(0).Value.ToString

                Dim fullname As String = DataGridView3.Rows(e.RowIndex).Cells(2).Value.ToString
                Dim username As String = DataGridView3.Rows(e.RowIndex).Cells(3).Value.ToString
                Dim password As String = DataGridView3.Rows(e.RowIndex).Cells(4).Value.ToString
                Dim userlevel As String = DataGridView3.Rows(e.RowIndex).Cells(5).Value.ToString

                With add_users
                    .btnSave.Enabled = False
                    .btnUpdate.Enabled = True
                    .lbl_id.Text = tbl_id
                    .txt_user.Text = username
                    .txt_pass.Text = password
                    .txt_pass2.Text = password



                    .txt_fname.Text = fullname


                    If userlevel = "SUPERADMIN" Then
                        .cmb_userlevel.Items.Add("SUPERADMIN")
                        .tx_userlevel.Text = userlevel
                        .cmb_userlevel.Enabled = False


                    Else
                        .tx_userlevel.Text = userlevel

                    End If
                    '    .tx_userlevel.Text = userlevel

                    f.AcceptButton = .btnUpdate

                    f.WindowState = FormWindowState.Maximized
                    f.FormBorderStyle = FormBorderStyle.None
                    f.StartPosition = FormStartPosition.Manual
                    f.BackColor = Color.Black
                    f.Opacity = 0.5
                    f.ShowInTaskbar = False
                    f.Show()
                    .Owner = f
                    .ShowDialog()

                End With
            ElseIf colname = "colDelete3" Then

                Dim userlevel As String = DataGridView3.Rows(e.RowIndex).Cells(5).Value.ToString
                Dim tmp_username As String = DataGridView3.Rows(e.RowIndex).Cells(3).Value.ToString

                If userlevel = "SUPERADMIN" Then Return


                If MsgBox("Do you want to delete users?", vbQuestion + vbYesNo) = vbYes Then


                    Dim id As Integer = DataGridView3.Rows(e.RowIndex).Cells(0).Value.ToString
                    Dim username As String = DataGridView3.Rows(e.RowIndex).Cells(3).Value.ToString

                    sql = "DELETE tbl_users WHERE id=@id"
                    cmd = New SqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@id", id)



                    cmd.ExecuteNonQuery()


                    recordAction(date_today, time_now, newdashboard.txt_user.Text, newdashboard.txt_userlevel.Text, "Delete user " + tmp_username)
                    '  load_auditTrails()

                    load_users()

                    'record audit trail for users


                End If
            ElseIf colname = "colView" Then
                Dim user_password As String = DataGridView3.Rows(e.RowIndex).Cells(4).Value.ToString
                Dim password As String = ""
                '   For i As Integer = 0 To DataGridView3.Rows.Count - 1
                password = DataGridView3.Rows(e.RowIndex).Cells(4).Value & vbLf
                ' Next
                MessageBox.Show(password)
            End If

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        Finally
            f.Dispose()
        End Try
    End Sub

    Private Sub txt_elect_date_ValueChanged(sender As Object, e As EventArgs) Handles txt_elect_date.ValueChanged
        ' MsgBox(txt_elect_date.Text)

        DataGridView4.Rows.Clear()
        Dim i As Integer
        connect()
        sql = "Select id, date, time, username, userlevel, action from tbl_audittrail where date=@date"
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.SelectCommand.Parameters.AddWithValue("@date", txt_elect_date.Text)
        adp.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then
            For x = 0 To ds.Tables("a").Rows.Count - 1
                With ds.Tables("a")
                    i += 1
                    DataGridView4.Rows.Add(.Rows(x).Item("id").ToString, i, .Rows(x).Item("date").ToString, .Rows(x).Item("time").ToString, .Rows(x).Item("username").ToString, .Rows(x).Item("userlevel").ToString, .Rows(x).Item("action").ToString)





                End With
            Next
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If MsgBox("Save data?", vbQuestion + vbYesNo) = vbYes Then


            Dim sql As String = "insert_sysinfo"
            cmd.Connection = con
            cmd.CommandText = sql
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .Clear()
                .AddWithValue("@sysname", txt_sysname.Text.Trim)
                .AddWithValue("@name", txt_name.Text.Trim)

                .AddWithValue("@contact", txt_contact.Text)
                .AddWithValue("@address", txt_address.Text.Trim)

                .AddWithValue("@id", tbl_id.Text)

            End With

            Try
                Dim returnValue As Integer = CType(cmd.ExecuteNonQuery, Integer)
                '  MsgBox(returnValue)
                If returnValue = 1 Then
                    ' recordAction(frmNewElection.date_today, frmNewElection.time_now, newdashboard.txt_user.Text, newdashboard.txt_userlevel.Text, "Add position " + txt_pos.Text.Trim + " to " + cmb_dept1.Text)
                    '    frmMaintenance.load_auditTrails()
                    '     clear_pos()
                    load_sysinfo()
                    '   Me.Dispose()
                    MsgBox("Success!", vbInformation)
                    'Else
                    '    MsgBox("School already exist!", vbCritical)

                End If







            Catch ex As Exception
                con.Close()
                MsgBox(ex.Message, vbCritical)
            End Try
        End If
    End Sub
End Class