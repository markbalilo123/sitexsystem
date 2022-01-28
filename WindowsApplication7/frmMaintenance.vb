Imports System.Data.SqlClient
Imports System.IO


Public Class frmMaintenance


    Public time_now As String = TimeOfDay.ToString("h:mm:ss tt")
    Public date_today As String = DateTime.Now.ToString("yyyy/MM/dd")


    'Sub load_school()
    '    connect()
    '    sql = "Select * from tbl_school"
    '    adp = New SqlDataAdapter(sql, con)
    '    ds = New DataSet
    '    adp.Fill(ds, "a")
    '    If ds.Tables("a").Rows.Count > 0 Then
    '        For x = 0 To ds.Tables("a").Rows.Count - 1
    '            With ds.Tables("a")

    '                tbl_id.Text = .Rows(x).Item("SchoolID").ToString
    '                txt_school.Text = .Rows(x).Item("school_name").ToString
    '                txt_contact.Text = .Rows(x).Item("contact").ToString
    '                txt_address.Text = .Rows(x).Item("address").ToString

    '                Dim tmp_str As String = .Rows(x).Item("sy").ToString

    '                Dim strArr() As String

    '                strArr = tmp_str.Split("-")

    '                If strArr.Length = 2 Then
    '                    txt_yr1.Text = strArr(0)
    '                    txt_yr2.Text = strArr(1)
    '                End If
    '            End With
    '        Next
    '    End If
    'End Sub

    'Public Sub load_departments()
    '    DataGridView1.Rows.Clear()
    '    Dim i As Integer
    '    connect()
    '    sql = "Select DepartmentID, department, total, description from tbl_departments"
    '    adp = New SqlDataAdapter(sql, con)
    '    ds = New DataSet
    '    adp.Fill(ds, "a")
    '    If ds.Tables("a").Rows.Count > 0 Then
    '        For x = 0 To ds.Tables("a").Rows.Count - 1
    '            With ds.Tables("a")
    '                i += 1

    '                'this code will hide our ALL value in the departments so that they cant manage it
    '                If .Rows(x).Item("department").ToString <> "ALL" Then
    '                    DataGridView1.Rows.Add(.Rows(x).Item("DepartmentID").ToString, i, .Rows(x).Item("department").ToString, .Rows(x).Item("description").ToString, .Rows(x).Item("total").ToString)
    '                End If






    '            End With
    '        Next
    '    End If
    'End Sub


    ''Public Sub load_userlevel()
    ''    DataGridView6.Rows.Clear()
    ''    Dim i As Integer
    ''    connect()
    ''    sql = "Select * from tbl_userlevel order by userlevel"
    ''    adp = New SqlDataAdapter(sql, con)
    ''    ds = New DataSet
    ''    adp.Fill(ds, "a")
    ''    If ds.Tables("a").Rows.Count > 0 Then
    ''        For x = 0 To ds.Tables("a").Rows.Count - 1
    ''            With ds.Tables("a")
    ''                i += 1
    ''                DataGridView6.Rows.Add(.Rows(x).Item("UserlevelID").ToString, i, .Rows(x).Item("userlevel").ToString, .Rows(x).Item("max_user").ToString)





    ''            End With
    ''        Next
    ''    End If
    ''End Sub

    'Public Sub load_courseyear()
    '    DataGridView5.Rows.Clear()
    '    Dim i As Integer
    '    connect()
    '    sql = "Select * from tbl_courseyear"
    '    adp = New SqlDataAdapter(sql, con)
    '    ds = New DataSet
    '    adp.Fill(ds, "a")
    '    If ds.Tables("a").Rows.Count > 0 Then
    '        For x = 0 To ds.Tables("a").Rows.Count - 1
    '            With ds.Tables("a")
    '                i += 1
    '                DataGridView5.Rows.Add(.Rows(x).Item("YearID").ToString, i, .Rows(x).Item("year").ToString)





    '            End With
    '        Next
    '    End If
    'End Sub




    'Public Sub load_course()
    '    DataGridView2.Rows.Clear()
    '    Dim i As Integer
    '    connect()
    '    'sql = "Select id, department, course from tbl_course "
    '    sql = "Select CourseID, department, course, yearlevel, a.description from tbl_course a left join tbl_departments b On a.DepartmentID = b.DepartmentID"
    '    adp = New SqlDataAdapter(sql, con)
    '    ds = New DataSet
    '    adp.Fill(ds, "a")
    '    If ds.Tables("a").Rows.Count > 0 Then
    '        For x = 0 To ds.Tables("a").Rows.Count - 1
    '            With ds.Tables("a")
    '                i += 1
    '                DataGridView2.Rows.Add(.Rows(x).Item("CourseID").ToString, i, .Rows(x).Item("department").ToString, .Rows(x).Item("course").ToString, .Rows(x).Item("description").ToString, .Rows(x).Item("yearlevel").ToString)





    '            End With
    '        Next
    '    End If
    'End Sub

    'Public Sub load_users()
    '    DataGridView3.Rows.Clear()
    '    Dim i As Integer
    '    connect()
    '    sql = "Select * from tbl_users a left join tbl_departments b on a.DepartmentID=b.DepartmentID"
    '    adp = New SqlDataAdapter(sql, con)
    '    ds = New DataSet
    '    adp.Fill(ds, "a")
    '    If ds.Tables("a").Rows.Count > 0 Then
    '        For x = 0 To ds.Tables("a").Rows.Count - 1
    '            With ds.Tables("a")
    '                i += 1
    '                DataGridView3.Rows.Add(.Rows(x).Item("id").ToString, i, .Rows(x).Item("department").ToString, .Rows(x).Item("fullname").ToString, .Rows(x).Item("username").ToString, .Rows(x).Item("password").ToString, .Rows(x).Item("userlevel").ToString)





    '            End With
    '        Next
    '    End If
    'End Sub


    ''Public Sub load_population()
    ''    DataGridView6.Rows.Clear()
    ''    Dim i As Integer
    ''    connect()
    ''    sql = "Select * from tbl_department_population a left join tbl_departments b On a.DepartmentID = b.DepartmentID"
    ''    adp = New SqlDataAdapter(sql, con)
    ''    ds = New DataSet
    ''    adp.Fill(ds, "a")
    ''    If ds.Tables("a").Rows.Count > 0 Then
    ''        For x = 0 To ds.Tables("a").Rows.Count - 1
    ''            With ds.Tables("a")
    ''                i += 1
    ''                DataGridView6.Rows.Add(.Rows(x).Item("DeptPopulationID").ToString, i, .Rows(x).Item("department").ToString, .Rows(x).Item("total").ToString)





    ''            End With
    ''        Next
    ''    End If
    ''End Sub


    'Public Sub load_auditTrails()

    '    DataGridView4.Rows.Clear()
    '    Dim i As Integer
    '    connect()
    '    sql = "Select id, date, time, username, userlevel, action from tbl_audittrail where date=@edate"
    '    adp = New SqlDataAdapter(sql, con)
    '    ds = New DataSet
    '    adp.SelectCommand.Parameters.AddWithValue("@edate", date_today)
    '    adp.Fill(ds, "a")
    '    If ds.Tables("a").Rows.Count > 0 Then
    '        For x = 0 To ds.Tables("a").Rows.Count - 1
    '            With ds.Tables("a")
    '                i += 1
    '                DataGridView4.Rows.Add(.Rows(x).Item("id").ToString, i, .Rows(x).Item("date").ToString, .Rows(x).Item("time").ToString, .Rows(x).Item("username").ToString, .Rows(x).Item("userlevel").ToString, .Rows(x).Item("action").ToString)





    '            End With
    '        Next
    '    End If
    'End Sub

    'Private Sub newdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    load_school()

    '    load_departments()
    '    'load_userlevel()
    '    load_courseyear()
    '    load_course()
    '    'load_population()
    '    load_users()


    '    txt_elect_date.MaxDate = DateTime.Today

    '    txt_elect_date.Format = DateTimePickerFormat.Custom
    '    txt_elect_date.CustomFormat = "yyyy/MM/dd"
    '    load_auditTrails()
    'End Sub

    'Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    '    Dim f As New Form

    '    Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
    '    Try
    '        If colname = "colEdit" Then
    '            Dim tbl_dept_id As Integer = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
    '            Dim dept_name As String = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
    '            Dim desc As String = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
    '            Dim total As String = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString

    '            With add_department
    '                .btnSave.Enabled = False
    '                .btnUpdate.Enabled = True
    '                .lbl_dept_id.Text = tbl_dept_id
    '                .txt_dept.Text = dept_name
    '                .txt_total.Text = total
    '                .txt_desc.Text = desc

    '                f.WindowState = FormWindowState.Maximized
    '                f.FormBorderStyle = FormBorderStyle.None
    '                f.StartPosition = FormStartPosition.Manual
    '                f.BackColor = Color.Black
    '                f.Opacity = 0.5
    '                f.ShowInTaskbar = False
    '                f.Show()
    '                .Owner = f
    '                .ShowDialog()

    '            End With
    '        ElseIf colname = "colDelete" Then
    '            Dim dept_name As String = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
    '            If load_dt("SELECT * from tbl_election_status a left join tbl_departments b on a.DepartmentID = b.DepartmentID where department='" & dept_name & "' And vote_status ='Election created' or vote_status='Election started'", 0) = True Then
    '                ' addcand_cmb_partylist.Items.Add(dt.Rows(0).Item("ptlist1_name").ToString)
    '                MsgBox("Unable to delete election alreardy created.")
    '                Return
    '            Else

    '                If MsgBox("Do you want to delete department?", vbQuestion + vbYesNo) = vbYes Then


    '                    Dim id As Integer = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
    '                    '      Dim dept_name As String = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString

    '                    sql = "DELETE tbl_departments WHERE DepartmentID=@id"
    '                    cmd = New SqlCommand(sql, con)
    '                    cmd.Parameters.AddWithValue("@id", id)

    '                    cmd.ExecuteNonQuery()

    '                    recordAction(date_today, time_now, newdashboard.txt_user.Text, newdashboard.txt_userlevel.Text, "Delete department " + dept_name)
    '                    load_auditTrails()



    '                    load_departments()



    '                End If
    '            End If
    '        End If

    '    Catch ex As Exception
    '        con.Close()
    '        MsgBox(ex.Message, vbCritical)
    '    Finally
    '        f.Dispose()
    '    End Try

    'End Sub

    'Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
    '    Dim f As New Form
    '    Try
    '        With f
    '            .WindowState = FormWindowState.Maximized
    '            .StartPosition = FormStartPosition.Manual
    '            .BackColor = Color.Black
    '            .Opacity = 0.5
    '            .ShowInTaskbar = False
    '            .FormBorderStyle = FormBorderStyle.None
    '            .Show()
    '            add_department.Owner = f
    '            add_department.btnUpdate.Enabled = False
    '            add_department.ShowDialog()


    '        End With
    '    Catch ex As Exception

    '    Finally
    '        f.Dispose()
    '    End Try
    'End Sub

    'Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
    '    Me.Dispose()
    'End Sub

    'Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
    '    Dim f As New Form
    '    Try
    '        With f
    '            .WindowState = FormWindowState.Maximized
    '            .StartPosition = FormStartPosition.Manual
    '            .BackColor = Color.Black
    '            .Opacity = 0.5
    '            .ShowInTaskbar = False
    '            .FormBorderStyle = FormBorderStyle.None
    '            .Show()
    '            add_course.Owner = f
    '            add_course.btnUpdate.Enabled = False
    '            add_course.ShowDialog()


    '        End With
    '    Catch ex As Exception

    '    Finally
    '        f.Dispose()
    '    End Try
    'End Sub

    'Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
    '    Dim f As New Form

    '    Dim colname As String = DataGridView2.Columns(e.ColumnIndex).Name
    '    Try
    '        If colname = "colEdit2" Then
    '            Dim tbl_dept_id As Integer = DataGridView2.Rows(e.RowIndex).Cells(0).Value.ToString
    '            Dim dept_name As String = DataGridView2.Rows(e.RowIndex).Cells(2).Value.ToString
    '            Dim course_name As String = DataGridView2.Rows(e.RowIndex).Cells(3).Value.ToString
    '            Dim desc As String = DataGridView2.Rows(e.RowIndex).Cells(4).Value.ToString
    '            Dim yearlevel As String = DataGridView2.Rows(e.RowIndex).Cells(5).Value.ToString


    '            With add_course
    '                .btnSave.Enabled = False
    '                .btnUpdate.Enabled = True
    '                .lbl_id.Text = tbl_dept_id
    '                .cmb_dept_name.text = dept_name
    '                .txt_course.Text = course_name

    '                .tmp_year.Text = yearlevel

    '                .txt_desc.Text = desc

    '                f.WindowState = FormWindowState.Maximized
    '                f.FormBorderStyle = FormBorderStyle.None
    '                f.StartPosition = FormStartPosition.Manual
    '                f.BackColor = Color.Black
    '                f.Opacity = 0.5
    '                f.ShowInTaskbar = False
    '                f.Show()
    '                .Owner = f
    '                .ShowDialog()

    '            End With
    '        ElseIf colname = "colDelete2" Then
    '            If MsgBox("Do you want to delete course?", vbQuestion + vbYesNo) = vbYes Then


    '                Dim id As Integer = DataGridView2.Rows(e.RowIndex).Cells(0).Value.ToString
    '                Dim course_name As String = DataGridView2.Rows(e.RowIndex).Cells(3).Value.ToString

    '                sql = "DELETE tbl_course WHERE CourseID=@id"
    '                cmd = New SqlCommand(sql, con)
    '                cmd.Parameters.AddWithValue("@id", id)


    '                cmd.ExecuteNonQuery()


    '                recordAction(date_today, time_now, newdashboard.txt_user.Text, newdashboard.txt_userlevel.Text, "Delete course " + course_name)
    '                load_auditTrails()


    '                load_course()


    '            End If
    '        End If


    '    Catch ex As Exception
    '        con.Close()
    '        MsgBox(ex.Message, vbCritical)
    '    Finally
    '        f.Dispose()
    '    End Try

    'End Sub

    'Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick
    '    Dim f As New Form

    '    Dim colname As String = DataGridView4.Columns(e.ColumnIndex).Name
    '    Try
    '        If colname = "colDelete4" Then
    '            If MsgBox("Do you want to delete?", vbQuestion + vbYesNo) = vbYes Then


    '                Dim id As Integer = DataGridView4.Rows(e.RowIndex).Cells(0).Value.ToString

    '                sql = "DELETE tbl_audittrail WHERE id=@id"
    '                cmd = New SqlCommand(sql, con)
    '                cmd.Parameters.AddWithValue("@id", id)

    '                cmd.ExecuteNonQuery()
    '                load_auditTrails()


    '            End If
    '        End If


    '    Catch ex As Exception
    '        con.Close()
    '        MsgBox(ex.Message, vbCritical)
    '    Finally
    '        f.Dispose()
    '    End Try

    'End Sub

    'Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
    '    Dim f As New Form
    '    Try
    '        With f
    '            .WindowState = FormWindowState.Maximized
    '            .StartPosition = FormStartPosition.Manual
    '            .BackColor = Color.Black
    '            .Opacity = 0.5
    '            .ShowInTaskbar = False
    '            .FormBorderStyle = FormBorderStyle.None

    '            .Show()
    '            fill_cmb(add_users.cmb_dept)
    '            add_users.tx_userlevel.Text = ""

    '            add_users.Owner = f
    '            add_users.btnUpdate.Enabled = False
    '            add_users.ShowDialog()


    '        End With
    '    Catch ex As Exception

    '    Finally
    '        f.Dispose()
    '    End Try
    'End Sub

    'Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
    '    Dim f As New Form

    '    Dim colname As String = DataGridView3.Columns(e.ColumnIndex).Name
    '    Try
    '        If colname = "colEdit3" Then
    '            Dim tbl_id As Integer = DataGridView3.Rows(e.RowIndex).Cells(0).Value.ToString
    '            Dim department As String = DataGridView3.Rows(e.RowIndex).Cells(2).Value.ToString
    '            Dim fullname As String = DataGridView3.Rows(e.RowIndex).Cells(3).Value.ToString
    '            Dim username As String = DataGridView3.Rows(e.RowIndex).Cells(4).Value.ToString
    '            Dim password As String = DataGridView3.Rows(e.RowIndex).Cells(5).Value.ToString
    '            Dim userlevel As String = DataGridView3.Rows(e.RowIndex).Cells(6).Value.ToString

    '            With add_users
    '                .btnSave.Enabled = False
    '                .btnUpdate.Enabled = True
    '                .lbl_id.Text = tbl_id
    '                .txt_user.Text = username
    '                .txt_pass.Text = password
    '                .txt_pass2.Text = password

    '                If department = "" Then
    '                    .is_staff.Checked = True
    '                End If

    '                .txt_fname.Text = fullname
    '                fill_cmb(.cmb_dept)
    '                .cmb_dept.Text = department
    '                If userlevel = "SUPERADMIN" Then
    '                    .cmb_userlevel.Items.Add("SUPERADMIN")
    '                    .tx_userlevel.Text = userlevel
    '                    .cmb_userlevel.Enabled = False


    '                Else
    '                    .tx_userlevel.Text = userlevel

    '                End If
    '                '    .tx_userlevel.Text = userlevel

    '                f.AcceptButton = .btnUpdate

    '                f.WindowState = FormWindowState.Maximized
    '                f.FormBorderStyle = FormBorderStyle.None
    '                f.StartPosition = FormStartPosition.Manual
    '                f.BackColor = Color.Black
    '                f.Opacity = 0.5
    '                f.ShowInTaskbar = False
    '                f.Show()
    '                .Owner = f
    '                .ShowDialog()

    '            End With
    '        ElseIf colname = "colDelete3" Then

    '            Dim userlevel As String = DataGridView3.Rows(e.RowIndex).Cells(6).Value.ToString
    '            Dim tmp_username As String = DataGridView3.Rows(e.RowIndex).Cells(4).Value.ToString

    '            If userlevel = "SUPERADMIN" Then Return


    '            If MsgBox("Do you want to delete users?", vbQuestion + vbYesNo) = vbYes Then


    '                Dim id As Integer = DataGridView3.Rows(e.RowIndex).Cells(0).Value.ToString
    '                Dim username As String = DataGridView3.Rows(e.RowIndex).Cells(4).Value.ToString

    '                sql = "DELETE tbl_users WHERE id=@id"
    '                cmd = New SqlCommand(sql, con)
    '                cmd.Parameters.AddWithValue("@id", id)



    '                cmd.ExecuteNonQuery()


    '                recordAction(date_today, time_now, newdashboard.txt_user.Text, newdashboard.txt_userlevel.Text, "Delete user " + tmp_username)
    '                load_auditTrails()

    '                load_users()

    '                'record audit trail for users


    '            End If
    '        ElseIf colname = "colView" Then
    '            Dim user_password As String = DataGridView3.Rows(e.RowIndex).Cells(5).Value.ToString
    '            Dim password As String = ""
    '            '   For i As Integer = 0 To DataGridView3.Rows.Count - 1
    '            password = DataGridView3.Rows(e.RowIndex).Cells(5).Value & vbLf
    '            ' Next
    '            MessageBox.Show(password)
    '        End If

    '    Catch ex As Exception
    '        con.Close()
    '        MsgBox(ex.Message, vbCritical)
    '    Finally
    '        f.Dispose()
    '    End Try

    'End Sub

    'Private Sub txt_elect_date_ValueChanged(sender As Object, e As EventArgs) Handles txt_elect_date.ValueChanged
    '    ' MsgBox(txt_elect_date.Text)

    '    DataGridView4.Rows.Clear()
    '    Dim i As Integer
    '    connect()
    '    sql = "Select id, date, time, username, userlevel, action from tbl_audittrail where date=@date"
    '    adp = New SqlDataAdapter(sql, con)
    '    ds = New DataSet
    '    adp.SelectCommand.Parameters.AddWithValue("@date", txt_elect_date.Text)
    '    adp.Fill(ds, "a")
    '    If ds.Tables("a").Rows.Count > 0 Then
    '        For x = 0 To ds.Tables("a").Rows.Count - 1
    '            With ds.Tables("a")
    '                i += 1
    '                DataGridView4.Rows.Add(.Rows(x).Item("id").ToString, i, .Rows(x).Item("date").ToString, .Rows(x).Item("time").ToString, .Rows(x).Item("username").ToString, .Rows(x).Item("userlevel").ToString, .Rows(x).Item("action").ToString)





    '            End With
    '        Next
    '    End If
    'End Sub

    'Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles MetroButton5.Click
    '    Dim f As New Form
    '    Try
    '        With f
    '            .WindowState = FormWindowState.Maximized
    '            .StartPosition = FormStartPosition.Manual
    '            .BackColor = Color.Black
    '            .Opacity = 0.5
    '            .ShowInTaskbar = False
    '            .FormBorderStyle = FormBorderStyle.None
    '            .Show()
    '            add_courseyear.Owner = f
    '            add_courseyear.btnUpdate.Enabled = False
    '            add_courseyear.ShowDialog()


    '        End With
    '    Catch ex As Exception

    '    Finally
    '        f.Dispose()
    '    End Try
    'End Sub

    'Private Sub DataGridView5_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView5.CellContentClick
    '    Dim f As New Form

    '    Dim colname As String = DataGridView5.Columns(e.ColumnIndex).Name
    '    Try
    '        If colname = "colEdit4" Then
    '            Dim tbl_yearid As Integer = DataGridView5.Rows(e.RowIndex).Cells(0).Value.ToString
    '            Dim courseyear As String = DataGridView5.Rows(e.RowIndex).Cells(2).Value.ToString


    '            With add_courseyear
    '                .btnSave.Enabled = False
    '                .btnUpdate.Enabled = True
    '                .lbl_year_id.Text = tbl_yearid
    '                .txt_courseyear.Text = courseyear


    '                f.WindowState = FormWindowState.Maximized
    '                f.FormBorderStyle = FormBorderStyle.None
    '                f.StartPosition = FormStartPosition.Manual
    '                f.BackColor = Color.Black
    '                f.Opacity = 0.5
    '                f.ShowInTaskbar = False
    '                f.Show()
    '                .Owner = f
    '                .ShowDialog()

    '            End With
    '        ElseIf colname = "colDelete4" Then


    '            If MsgBox("Do you want to delete course year?", vbQuestion + vbYesNo) = vbYes Then


    '                Dim id As Integer = DataGridView5.Rows(e.RowIndex).Cells(0).Value.ToString
    '                Dim courseyear As String = DataGridView5.Rows(e.RowIndex).Cells(2).Value.ToString
    '                '      Dim dept_name As String = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString

    '                sql = "DELETE tbl_courseyear WHERE YearID=@id"
    '                cmd = New SqlCommand(sql, con)
    '                cmd.Parameters.AddWithValue("@id", id)

    '                cmd.ExecuteNonQuery()

    '                recordAction(date_today, time_now, newdashboard.txt_user.Text, newdashboard.txt_userlevel.Text, "Delete course year " + courseyear)
    '                load_auditTrails()



    '                load_courseyear()



    '            End If
    '        End If

    '    Catch ex As Exception
    '        con.Close()
    '        MsgBox(ex.Message, vbCritical)
    '    Finally
    '        f.Dispose()
    '    End Try
    'End Sub

    ''Private Sub DataGridView6_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
    ''    Dim f As New Form

    ''    Dim colname As String = DataGridView6.Columns(e.ColumnIndex).Name



    ''    Try

    ''        Dim check_userlevel As String = DataGridView6.Rows(e.RowIndex).Cells(2).Value.ToString

    ''        If check_userlevel = "SUPERADMIN" Then Return

    ''        If colname = "colEdit5" Then
    ''            Dim tbl_userlevelid As Integer = DataGridView6.Rows(e.RowIndex).Cells(0).Value.ToString
    ''            Dim userlevel As String = DataGridView6.Rows(e.RowIndex).Cells(2).Value.ToString
    ''            Dim max_user As String = DataGridView6.Rows(e.RowIndex).Cells(3).Value.ToString


    ''            With add_userlevel
    ''                .btnSave.Enabled = False
    ''                .btnUpdate.Enabled = True
    ''                .txt_id.Text = tbl_userlevelid
    ''                .txt_userlevel.Text = userlevel
    ''                .txt_max.Text = max_user

    ''                f.WindowState = FormWindowState.Maximized
    ''                f.FormBorderStyle = FormBorderStyle.None
    ''                f.StartPosition = FormStartPosition.Manual
    ''                f.BackColor = Color.Black
    ''                f.Opacity = 0.5
    ''                f.ShowInTaskbar = False
    ''                f.Show()
    ''                .Owner = f
    ''                .ShowDialog()

    ''            End With
    ''        ElseIf colname = "colDelete5" Then


    ''            If MsgBox("Do you want to delete course year?", vbQuestion + vbYesNo) = vbYes Then


    ''                Dim id As Integer = DataGridView6.Rows(e.RowIndex).Cells(0).Value.ToString
    ''                Dim userlevel As String = DataGridView6.Rows(e.RowIndex).Cells(2).Value.ToString
    ''                '      Dim dept_name As String = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString

    ''                sql = "DELETE tbl_userlevel WHERE UserlevelID=@id"
    ''                cmd = New SqlCommand(sql, con)
    ''                cmd.Parameters.AddWithValue("@id", id)

    ''                cmd.ExecuteNonQuery()

    ''                recordAction(date_today, time_now, newdashboard.txt_user.Text, newdashboard.txt_userlevel.Text, "Delete userlevel " + userlevel)
    ''                load_auditTrails()



    ''                load_userlevel()



    ''            End If
    ''        End If

    ''    Catch ex As Exception
    ''        con.Close()
    ''        MsgBox(ex.Message, vbCritical)
    ''    Finally
    ''        f.Dispose()
    ''    End Try
    ''End Sub

    'Private Sub MetroButton6_Click(sender As Object, e As EventArgs)
    '    Dim f As New Form
    '    Try
    '        With f
    '            .WindowState = FormWindowState.Maximized
    '            .StartPosition = FormStartPosition.Manual
    '            .BackColor = Color.Black
    '            .Opacity = 0.5
    '            .ShowInTaskbar = False
    '            .FormBorderStyle = FormBorderStyle.None
    '            .Show()
    '            add_userlevel.Owner = f
    '            add_userlevel.btnUpdate.Enabled = False
    '            add_userlevel.ShowDialog()


    '        End With
    '    Catch ex As Exception

    '    Finally
    '        f.Dispose()
    '    End Try
    'End Sub

    'Private Sub DataGridView3_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView3.CellFormatting
    '    If DataGridView3.Columns(e.ColumnIndex).Index = 5 Then
    '        If e.Value IsNot Nothing Then
    '            e.Value = New String("*"c, e.Value.ToString().Length)
    '            e.FormattingApplied = True

    '        End If
    '    End If
    'End Sub

    'Private Sub DataGridView3_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DataGridView3.EditingControlShowing
    '    Dim t As TextBox = TryCast(e.Control, TextBox)
    '    If t IsNot Nothing Then
    '        t.Text = CStr(DataGridView3.SelectedCells(3).Value.ToString)
    '    End If

    'End Sub

    'Private Sub MetroButton6_Click_1(sender As Object, e As EventArgs)
    '    Dim f As New Form
    '    Try
    '        With f
    '            .WindowState = FormWindowState.Maximized
    '            .StartPosition = FormStartPosition.Manual
    '            .BackColor = Color.Black
    '            .Opacity = 0.5
    '            .ShowInTaskbar = False
    '            .FormBorderStyle = FormBorderStyle.None
    '            .Show()
    '            add_population.Owner = f
    '            add_population.btnUpdate.Enabled = False
    '            add_population.ShowDialog()


    '        End With
    '    Catch ex As Exception

    '    Finally
    '        f.Dispose()
    '    End Try
    'End Sub

    'Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
    '    If MsgBox("Save data?", vbQuestion + vbYesNo) = vbYes Then


    '        Dim sql As String = "insert_school"
    '        cmd.Connection = con
    '        cmd.CommandText = sql
    '        cmd.CommandType = CommandType.StoredProcedure
    '        With cmd.Parameters
    '            .Clear()
    '            .AddWithValue("@name", txt_school.Text.Trim)
    '            .AddWithValue("@contact", txt_contact.Text)
    '            .AddWithValue("@address", txt_address.Text.Trim)
    '            .AddWithValue("@sy", txt_yr1.Text + "-" + txt_yr2.Text)
    '            .AddWithValue("@id", tbl_id.Text)

    '        End With

    '        Try
    '            Dim returnValue As Integer = CType(cmd.ExecuteNonQuery, Integer)
    '            '  MsgBox(returnValue)
    '            If returnValue = 1 Then
    '                ' recordAction(frmNewElection.date_today, frmNewElection.time_now, newdashboard.txt_user.Text, newdashboard.txt_userlevel.Text, "Add position " + txt_pos.Text.Trim + " to " + cmb_dept1.Text)
    '                '    frmMaintenance.load_auditTrails()
    '                '     clear_pos()
    '                load_school()
    '                '   Me.Dispose()
    '                MsgBox("Success!", vbInformation)
    '                'Else
    '                '    MsgBox("School already exist!", vbCritical)

    '            End If







    '        Catch ex As Exception
    '            con.Close()
    '            MsgBox(ex.Message, vbCritical)
    '        End Try
    '    End If
    'End Sub
End Class