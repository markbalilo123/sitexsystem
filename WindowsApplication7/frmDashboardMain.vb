
Imports System.Data.SqlClient
Imports System.IO

Public Class frmDashboardMain

    Public time_now As String = TimeOfDay.ToString("h:mm:ss tt")
    Public date_today As String = DateTime.Now.ToString("yyyy/MM/dd")



    Public Sub load_all_ename()
        DataGridView2.Rows.Clear()

        connect()
        '     sql = "Select id, department, position_name from tbl_positions where department=@dept_name"
        sql = "Select election_name From tbl_election_status where vote_status='Election started' or vote_status='Election ended'"
        'cmd.Parameters.AddWithValue("@dept_name", cmb_dept.Text)
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        '    adp.SelectCommand.Parameters.AddWithValue("@eid", txt_eid2.Text)
        adp.Fill(ds, "a")

        If ds.Tables("a").Rows.Count > 0 Then
            For x = 0 To ds.Tables("a").Rows.Count - 1
                With ds.Tables("a")

                    ' DataGridView2.Rows.Add(.Rows(x).Item("PositionID").ToString, i, .Rows(x).Item("department").ToString, .Rows(x).Item("position_name").ToString, .Rows(x).Item("year").ToString)
                    cmb_allename.Items.Add(.Rows(x).Item("election_name").ToString)




                End With
            Next
        End If
    End Sub

    Public Sub load_all_pos()
        'DataGridView2.Rows.Clear()

        connect()
        '     sql = "Select id, department, position_name from tbl_positions where department=@dept_name"
        sql = "Select position_name From tbl_election_status a left join tbl_departments b on a.DepartmentID=b.DepartmentID left join tbl_positions c on b.DepartmentID=c.DepartmentID where vote_status='Election started' or vote_status='Election ended'"
        'sql = "Select position_name From tbl_election_status a left join tbl_ where vote_status='Election started' or vote_status='Election ended'"
        'cmd.Parameters.AddWithValue("@dept_name", cmb_dept.Text)
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        '    adp.SelectCommand.Parameters.AddWithValue("@eid", txt_eid2.Text)
        adp.Fill(ds, "a")

        If ds.Tables("a").Rows.Count > 0 Then
            For x = 0 To ds.Tables("a").Rows.Count - 1
                With ds.Tables("a")

                    ' DataGridView2.Rows.Add(.Rows(x).Item("PositionID").ToString, i, .Rows(x).Item("department").ToString, .Rows(x).Item("position_name").ToString, .Rows(x).Item("year").ToString)
                    cmb_pos_name.Items.Add(.Rows(x).Item("position_name").ToString)




                End With
            Next
        End If
    End Sub


    Public Sub load_eid(ByVal ename As ComboBox, ByVal eid As Label)

        connect()
        ' sql = "Select * from tbl_election_status a left join tbl_departments b on a.DepartmentID = b.DepartmentID"
        'sql = "Select id, vote_start_date, department, election_name, vote_status, partylist1, partylist2 from tbl_election_status a left join tbl_departments on a.DepartmentID = b.DepartmentID"
        sql = "Select ElectionID from tbl_election_status where election_name=@e_name"

        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.SelectCommand.Parameters.AddWithValue("@e_name", ename.Text)
        adp.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then

            With ds.Tables("a")
                eid.Text = .Rows(0).Item("ElectionID").ToString


            End With

        End If
    End Sub


    Private Sub MetroButton4_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Public Sub getNumElection()


        sql = " Select COUNT(vote_status) As cnt from tbl_election_status where vote_status='Election started' and vote_start_date=@edate"
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.SelectCommand.Parameters.AddWithValue("@edate", date_today)
        adp.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then
            For x = 0 To ds.Tables("a").Rows.Count - 1
                With ds.Tables("a")
                    lblno_of_elect.Text = .Rows(x).Item("cnt").ToString
                End With
            Next
        End If



    End Sub


    Public Sub refreshTally()
        DataGridView2.Rows.Clear()
        Dim i As Integer
        connect()
        ' sql = "Select * from tbl_election_status a left join tbl_departments b on a.DepartmentID = b.DepartmentID"
        'sql = "Select id, vote_start_date, department, election_name, vote_status, partylist1, partylist2 from tbl_election_status a left join tbl_departments on a.DepartmentID = b.DepartmentID"
        '   sql = "Select * from tbl_electwinners a left join tbl_departments b on a.DepartmentID = b.DepartmentID"
        'sql = "select * from tbl_electwinners a left join tbl_students b on a.student_id = b.student_id left join tbl_positions c on a.PositionID = c.PositionID left join tbl_partylist d on a.PartylistID = d.PartylistID  left join tbl_election_status e on a.ElectionID = e.ElectionID left join tbl_course f on b.CourseID = f.CourseID left join tbl_departments g on b.DepartmentID = g.DepartmentID where a.PartylistID=@pt1_id and a.ElectionID=@e_id"
        '    sql = "select * from tbl_candidates a left join tbl_electwinners b on a.CandidateID = b.CandidateID left join tbl_election_status c on b.ElectionID = c.ElectionID left join tbl_departments d on c.DepartmentID = d.DepartmentID left join tbl_partylist e on a.PartylistID = e.PartylistID left join tbl_students f on a.student_id = f.student_id where b.ElectionID=@eid"
        ' sql = "select * from tbl_electwinners where ElectionID=@eid"
        sql = "select * from tbl_candidates a left join tbl_students b on a.student_id = b.student_id left join tbl_positions c on a.PositionID = c.PositionID left join tbl_partylist d on a.PartylistID = d.PartylistID  left join tbl_election_status e on a.ElectionID = e.ElectionID left join tbl_course f on b.CourseID = f.CourseID left join tbl_departments g on b.DepartmentID = g.DepartmentID where a.ElectionID=@eid order by position_name, partylist_name"
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.SelectCommand.Parameters.AddWithValue("@eid", tally_eid.Text)
        adp.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then
            For x = 0 To ds.Tables("a").Rows.Count - 1
                With ds.Tables("a")
                    i += 1
                    '   DataGridView2.Rows.Add(.Rows(x).Item("ElectionID").ToString, i, .Rows(x).Item("vote_start_date").ToString, .Rows(x).Item("department").ToString, .Rows(x).Item("election_name").ToString, .Rows(x).Item("partylist_name").ToString, .Rows(x).Item("partylist_name").ToString, .Rows(x).Item("vote_status").ToString)
                    '  Dim fullname As String = .Rows(x).Item("lastname").ToString + ", " + .Rows(x).Item("firstname").ToString + ", " + .Rows(x).Item("middle_initial").ToString
                    '   DataGridView1.Rows.Add(.Rows(x).Item("ResultsID").ToString, i, .Rows(x).Item("ElectionID").ToString, .Rows(x).Item("election_date").ToString, .Rows(x).Item("department").ToString, .Rows(x).Item("position").ToString, .Rows(x).Item("partylist").ToString, .Rows(x).Item("fullname").ToString, .Rows(x).Item("vote_count").ToString, .Rows(x).Item("remarks").ToString)
                    DataGridView2.Rows.Add(.Rows(x).Item("CandidateID").ToString, i, .Rows(x).Item("ElectionID").ToString, .Rows(x).Item("vote_start_date").ToString, .Rows(x).Item("department").ToString, .Rows(x).Item("position_name").ToString, .Rows(x).Item("partylist_name").ToString, .Rows(x).Item("student_id").ToString, .Rows(x).Item("lastname").ToString + ", " + .Rows(x).Item("firstname").ToString + ", " + .Rows(x).Item("middle_initial").ToString, .Rows(x).Item("vote_count"))





                End With
            Next
        End If
    End Sub


    Private Sub frmDashboardMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getNumElection()
        load_all_pos()
        load_all_ename()
    End Sub

    Private Sub cmb_allename_TextChanged(sender As Object, e As EventArgs) Handles cmb_allename.TextChanged
        'load_eid(cmb_allename, tally_eid)
        'DataGridView2.Rows.Clear()
        'Dim i As Integer
        'connect()
        '' sql = "Select * from tbl_election_status a left join tbl_departments b on a.DepartmentID = b.DepartmentID"
        ''sql = "Select id, vote_start_date, department, election_name, vote_status, partylist1, partylist2 from tbl_election_status a left join tbl_departments on a.DepartmentID = b.DepartmentID"
        ''   sql = "Select * from tbl_electwinners a left join tbl_departments b on a.DepartmentID = b.DepartmentID"
        ''sql = "select * from tbl_electwinners a left join tbl_students b on a.student_id = b.student_id left join tbl_positions c on a.PositionID = c.PositionID left join tbl_partylist d on a.PartylistID = d.PartylistID  left join tbl_election_status e on a.ElectionID = e.ElectionID left join tbl_course f on b.CourseID = f.CourseID left join tbl_departments g on b.DepartmentID = g.DepartmentID where a.PartylistID=@pt1_id and a.ElectionID=@e_id"
        ''    sql = "select * from tbl_candidates a left join tbl_electwinners b on a.CandidateID = b.CandidateID left join tbl_election_status c on b.ElectionID = c.ElectionID left join tbl_departments d on c.DepartmentID = d.DepartmentID left join tbl_partylist e on a.PartylistID = e.PartylistID left join tbl_students f on a.student_id = f.student_id where b.ElectionID=@eid"
        '' sql = "select * from tbl_electwinners where ElectionID=@eid"
        ''original query
        ''sql = "select * from tbl_candidates a left join tbl_students b on a.student_id = b.student_id left join tbl_positions c on a.PositionID = c.PositionID left join tbl_partylist d on a.PartylistID = d.PartylistID  left join tbl_election_status e on a.ElectionID = e.ElectionID left join tbl_course f on b.CourseID = f.CourseID left join tbl_departments g on b.DepartmentID = g.DepartmentID where a.ElectionID=@eid order by position_name, partylist_name"
        'sql = "select * from tbl_candidates a left join tbl_students b on a.StudentID = b.StudentID left join tbl_positions c on a.PositionID = c.PositionID left join tbl_partylist d on a.PartylistID = d.PartylistID  left join tbl_election_status e on a.ElectionID = e.ElectionID left join tbl_course f on b.CourseID = f.CourseID left join tbl_departments g on b.DepartmentID = g.DepartmentID where a.ElectionID=@eid order by position_name, partylist_name"

        'adp = New SqlDataAdapter(sql, con)
        'ds = New DataSet
        'adp.SelectCommand.Parameters.AddWithValue("@eid", tally_eid.Text)
        'adp.Fill(ds, "a")
        'If ds.Tables("a").Rows.Count > 0 Then
        '    For x = 0 To ds.Tables("a").Rows.Count - 1
        '        With ds.Tables("a")
        '            i += 1
        '            '   DataGridView2.Rows.Add(.Rows(x).Item("ElectionID").ToString, i, .Rows(x).Item("vote_start_date").ToString, .Rows(x).Item("department").ToString, .Rows(x).Item("election_name").ToString, .Rows(x).Item("partylist_name").ToString, .Rows(x).Item("partylist_name").ToString, .Rows(x).Item("vote_status").ToString)
        '            '  Dim fullname As String = .Rows(x).Item("lastname").ToString + ", " + .Rows(x).Item("firstname").ToString + ", " + .Rows(x).Item("middle_initial").ToString
        '            '   DataGridView1.Rows.Add(.Rows(x).Item("ResultsID").ToString, i, .Rows(x).Item("ElectionID").ToString, .Rows(x).Item("election_date").ToString, .Rows(x).Item("department").ToString, .Rows(x).Item("position").ToString, .Rows(x).Item("partylist").ToString, .Rows(x).Item("fullname").ToString, .Rows(x).Item("vote_count").ToString, .Rows(x).Item("remarks").ToString)
        '            DataGridView2.Rows.Add(.Rows(x).Item("CandidateID").ToString, i, .Rows(x).Item("ElectionID").ToString, .Rows(x).Item("vote_start_date").ToString, .Rows(x).Item("department").ToString, .Rows(x).Item("position_name").ToString, .Rows(x).Item("partylist_name").ToString, .Rows(x).Item("student_id").ToString, .Rows(x).Item("lastname").ToString + ", " + .Rows(x).Item("firstname").ToString + ", " + .Rows(x).Item("middle_initial").ToString, .Rows(x).Item("vote_count"))





        '        End With
        '    Next
        'End If
        If cmb_allename.Text = "" Then
            MsgBox("Choose election name!", vbCritical)
            Return
        End If
        '  If cmb_pos_name.Text = "" Then Return


        'refreshTally()
        load_eid(cmb_allename, tally_eid)
        DataGridView2.Rows.Clear()
        Dim i As Integer
        connect()
        ' sql = "Select * from tbl_election_status a left join tbl_departments b on a.DepartmentID = b.DepartmentID"
        'sql = "Select id, vote_start_date, department, election_name, vote_status, partylist1, partylist2 from tbl_election_status a left join tbl_departments on a.DepartmentID = b.DepartmentID"
        '   sql = "Select * from tbl_electwinners a left join tbl_departments b on a.DepartmentID = b.DepartmentID"
        'sql = "select * from tbl_electwinners a left join tbl_students b on a.student_id = b.student_id left join tbl_positions c on a.PositionID = c.PositionID left join tbl_partylist d on a.PartylistID = d.PartylistID  left join tbl_election_status e on a.ElectionID = e.ElectionID left join tbl_course f on b.CourseID = f.CourseID left join tbl_departments g on b.DepartmentID = g.DepartmentID where a.PartylistID=@pt1_id and a.ElectionID=@e_id"
        '    sql = "select * from tbl_candidates a left join tbl_electwinners b on a.CandidateID = b.CandidateID left join tbl_election_status c on b.ElectionID = c.ElectionID left join tbl_departments d on c.DepartmentID = d.DepartmentID left join tbl_partylist e on a.PartylistID = e.PartylistID left join tbl_students f on a.student_id = f.student_id where b.ElectionID=@eid"
        ' sql = "select * from tbl_electwinners where ElectionID=@eid"
        'original query
        'sql = "select * from tbl_candidates a left join tbl_students b on a.student_id = b.student_id left join tbl_positions c on a.PositionID = c.PositionID left join tbl_partylist d on a.PartylistID = d.PartylistID  left join tbl_election_status e on a.ElectionID = e.ElectionID left join tbl_course f on b.CourseID = f.CourseID left join tbl_departments g on b.DepartmentID = g.DepartmentID where a.ElectionID=@eid order by position_name, partylist_name"
        sql = "select * from tbl_candidates a left join tbl_students b on a.StudentID = b.StudentID left join tbl_positions c on a.PositionID = c.PositionID left join tbl_partylist d on a.PartylistID = d.PartylistID  left join tbl_election_status e on a.ElectionID = e.ElectionID left join tbl_course f on b.CourseID = f.CourseID left join tbl_departments g on b.DepartmentID = g.DepartmentID where a.ElectionID=@eid order by position_name, partylist_name"

        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.SelectCommand.Parameters.AddWithValue("@eid", tally_eid.Text)
        ' adp.SelectCommand.Parameters.AddWithValue("@pos", cmb_pos_name.Text)
        adp.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then
            For x = 0 To ds.Tables("a").Rows.Count - 1
                With ds.Tables("a")
                    i += 1
                    '   DataGridView2.Rows.Add(.Rows(x).Item("ElectionID").ToString, i, .Rows(x).Item("vote_start_date").ToString, .Rows(x).Item("department").ToString, .Rows(x).Item("election_name").ToString, .Rows(x).Item("partylist_name").ToString, .Rows(x).Item("partylist_name").ToString, .Rows(x).Item("vote_status").ToString)
                    '  Dim fullname As String = .Rows(x).Item("lastname").ToString + ", " + .Rows(x).Item("firstname").ToString + ", " + .Rows(x).Item("middle_initial").ToString
                    '   DataGridView1.Rows.Add(.Rows(x).Item("ResultsID").ToString, i, .Rows(x).Item("ElectionID").ToString, .Rows(x).Item("election_date").ToString, .Rows(x).Item("department").ToString, .Rows(x).Item("position").ToString, .Rows(x).Item("partylist").ToString, .Rows(x).Item("fullname").ToString, .Rows(x).Item("vote_count").ToString, .Rows(x).Item("remarks").ToString)
                    DataGridView2.Rows.Add(.Rows(x).Item("CandidateID").ToString, i, .Rows(x).Item("ElectionID").ToString, .Rows(x).Item("vote_start_date").ToString, .Rows(x).Item("department").ToString, .Rows(x).Item("position_name").ToString, .Rows(x).Item("partylist_name").ToString, .Rows(x).Item("student_id").ToString, .Rows(x).Item("lastname").ToString + ", " + .Rows(x).Item("firstname").ToString + ", " + .Rows(x).Item("middle_initial").ToString, .Rows(x).Item("vote_count"))





                End With
            Next
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        'If cmb_allename.Text = "" Then Return
        'If cmb_pos_name.Text = "" Then Return


        ''refreshTally()
        'load_eid(cmb_allename, tally_eid)
        'DataGridView2.Rows.Clear()
        'Dim i As Integer
        'connect()
        '' sql = "Select * from tbl_election_status a left join tbl_departments b on a.DepartmentID = b.DepartmentID"
        ''sql = "Select id, vote_start_date, department, election_name, vote_status, partylist1, partylist2 from tbl_election_status a left join tbl_departments on a.DepartmentID = b.DepartmentID"
        ''   sql = "Select * from tbl_electwinners a left join tbl_departments b on a.DepartmentID = b.DepartmentID"
        ''sql = "select * from tbl_electwinners a left join tbl_students b on a.student_id = b.student_id left join tbl_positions c on a.PositionID = c.PositionID left join tbl_partylist d on a.PartylistID = d.PartylistID  left join tbl_election_status e on a.ElectionID = e.ElectionID left join tbl_course f on b.CourseID = f.CourseID left join tbl_departments g on b.DepartmentID = g.DepartmentID where a.PartylistID=@pt1_id and a.ElectionID=@e_id"
        ''    sql = "select * from tbl_candidates a left join tbl_electwinners b on a.CandidateID = b.CandidateID left join tbl_election_status c on b.ElectionID = c.ElectionID left join tbl_departments d on c.DepartmentID = d.DepartmentID left join tbl_partylist e on a.PartylistID = e.PartylistID left join tbl_students f on a.student_id = f.student_id where b.ElectionID=@eid"
        '' sql = "select * from tbl_electwinners where ElectionID=@eid"
        ''original query
        ''sql = "select * from tbl_candidates a left join tbl_students b on a.student_id = b.student_id left join tbl_positions c on a.PositionID = c.PositionID left join tbl_partylist d on a.PartylistID = d.PartylistID  left join tbl_election_status e on a.ElectionID = e.ElectionID left join tbl_course f on b.CourseID = f.CourseID left join tbl_departments g on b.DepartmentID = g.DepartmentID where a.ElectionID=@eid order by position_name, partylist_name"
        'sql = "select * from tbl_candidates a left join tbl_students b on a.StudentID = b.StudentID left join tbl_positions c on a.PositionID = c.PositionID left join tbl_partylist d on a.PartylistID = d.PartylistID  left join tbl_election_status e on a.ElectionID = e.ElectionID left join tbl_course f on b.CourseID = f.CourseID left join tbl_departments g on b.DepartmentID = g.DepartmentID where a.ElectionID=@eid and position_name=@pos order by position_name, partylist_name"

        'adp = New SqlDataAdapter(sql, con)
        'ds = New DataSet
        'adp.SelectCommand.Parameters.AddWithValue("@eid", tally_eid.Text)
        'adp.SelectCommand.Parameters.AddWithValue("@pos", cmb_pos_name.Text)
        'adp.Fill(ds, "a")
        'If ds.Tables("a").Rows.Count > 0 Then
        '    For x = 0 To ds.Tables("a").Rows.Count - 1
        '        With ds.Tables("a")
        '            i += 1
        '            '   DataGridView2.Rows.Add(.Rows(x).Item("ElectionID").ToString, i, .Rows(x).Item("vote_start_date").ToString, .Rows(x).Item("department").ToString, .Rows(x).Item("election_name").ToString, .Rows(x).Item("partylist_name").ToString, .Rows(x).Item("partylist_name").ToString, .Rows(x).Item("vote_status").ToString)
        '            '  Dim fullname As String = .Rows(x).Item("lastname").ToString + ", " + .Rows(x).Item("firstname").ToString + ", " + .Rows(x).Item("middle_initial").ToString
        '            '   DataGridView1.Rows.Add(.Rows(x).Item("ResultsID").ToString, i, .Rows(x).Item("ElectionID").ToString, .Rows(x).Item("election_date").ToString, .Rows(x).Item("department").ToString, .Rows(x).Item("position").ToString, .Rows(x).Item("partylist").ToString, .Rows(x).Item("fullname").ToString, .Rows(x).Item("vote_count").ToString, .Rows(x).Item("remarks").ToString)
        '            DataGridView2.Rows.Add(.Rows(x).Item("CandidateID").ToString, i, .Rows(x).Item("ElectionID").ToString, .Rows(x).Item("vote_start_date").ToString, .Rows(x).Item("department").ToString, .Rows(x).Item("position_name").ToString, .Rows(x).Item("partylist_name").ToString, .Rows(x).Item("student_id").ToString, .Rows(x).Item("lastname").ToString + ", " + .Rows(x).Item("firstname").ToString + ", " + .Rows(x).Item("middle_initial").ToString, .Rows(x).Item("vote_count"))





        '        End With
        '    Next
        'End If
        'cmb_allename.SelectedIndex = -1
        'cmb_pos_name.SelectedIndex = -1
        DataGridView2.Rows.Clear()
    End Sub

    Private Sub cmb_pos_name_TextChanged(sender As Object, e As EventArgs) Handles cmb_pos_name.TextChanged
        If cmb_allename.Text = "" Then
            MsgBox("Choose event first!", vbCritical)
            Return
        End If
        If cmb_pos_name.Text = "" Then
            MsgBox("Choose position first!", vbCritical)

            Return
        End If


        'refreshTally()
        load_eid(cmb_allename, tally_eid)
        DataGridView2.Rows.Clear()
        Dim i As Integer
        connect()
        ' sql = "Select * from tbl_election_status a left join tbl_departments b on a.DepartmentID = b.DepartmentID"
        'sql = "Select id, vote_start_date, department, election_name, vote_status, partylist1, partylist2 from tbl_election_status a left join tbl_departments on a.DepartmentID = b.DepartmentID"
        '   sql = "Select * from tbl_electwinners a left join tbl_departments b on a.DepartmentID = b.DepartmentID"
        'sql = "select * from tbl_electwinners a left join tbl_students b on a.student_id = b.student_id left join tbl_positions c on a.PositionID = c.PositionID left join tbl_partylist d on a.PartylistID = d.PartylistID  left join tbl_election_status e on a.ElectionID = e.ElectionID left join tbl_course f on b.CourseID = f.CourseID left join tbl_departments g on b.DepartmentID = g.DepartmentID where a.PartylistID=@pt1_id and a.ElectionID=@e_id"
        '    sql = "select * from tbl_candidates a left join tbl_electwinners b on a.CandidateID = b.CandidateID left join tbl_election_status c on b.ElectionID = c.ElectionID left join tbl_departments d on c.DepartmentID = d.DepartmentID left join tbl_partylist e on a.PartylistID = e.PartylistID left join tbl_students f on a.student_id = f.student_id where b.ElectionID=@eid"
        ' sql = "select * from tbl_electwinners where ElectionID=@eid"
        'original query
        'sql = "select * from tbl_candidates a left join tbl_students b on a.student_id = b.student_id left join tbl_positions c on a.PositionID = c.PositionID left join tbl_partylist d on a.PartylistID = d.PartylistID  left join tbl_election_status e on a.ElectionID = e.ElectionID left join tbl_course f on b.CourseID = f.CourseID left join tbl_departments g on b.DepartmentID = g.DepartmentID where a.ElectionID=@eid order by position_name, partylist_name"
        sql = "select * from tbl_candidates a left join tbl_students b on a.StudentID = b.StudentID left join tbl_positions c on a.PositionID = c.PositionID left join tbl_partylist d on a.PartylistID = d.PartylistID  left join tbl_election_status e on a.ElectionID = e.ElectionID left join tbl_course f on b.CourseID = f.CourseID left join tbl_departments g on b.DepartmentID = g.DepartmentID where a.ElectionID=@eid and position_name=@pos order by position_name, partylist_name"

        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.SelectCommand.Parameters.AddWithValue("@eid", tally_eid.Text)
        adp.SelectCommand.Parameters.AddWithValue("@pos", cmb_pos_name.Text)
        adp.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then
            For x = 0 To ds.Tables("a").Rows.Count - 1
                With ds.Tables("a")
                    i += 1
                    '   DataGridView2.Rows.Add(.Rows(x).Item("ElectionID").ToString, i, .Rows(x).Item("vote_start_date").ToString, .Rows(x).Item("department").ToString, .Rows(x).Item("election_name").ToString, .Rows(x).Item("partylist_name").ToString, .Rows(x).Item("partylist_name").ToString, .Rows(x).Item("vote_status").ToString)
                    '  Dim fullname As String = .Rows(x).Item("lastname").ToString + ", " + .Rows(x).Item("firstname").ToString + ", " + .Rows(x).Item("middle_initial").ToString
                    '   DataGridView1.Rows.Add(.Rows(x).Item("ResultsID").ToString, i, .Rows(x).Item("ElectionID").ToString, .Rows(x).Item("election_date").ToString, .Rows(x).Item("department").ToString, .Rows(x).Item("position").ToString, .Rows(x).Item("partylist").ToString, .Rows(x).Item("fullname").ToString, .Rows(x).Item("vote_count").ToString, .Rows(x).Item("remarks").ToString)
                    DataGridView2.Rows.Add(.Rows(x).Item("CandidateID").ToString, i, .Rows(x).Item("ElectionID").ToString, .Rows(x).Item("vote_start_date").ToString, .Rows(x).Item("department").ToString, .Rows(x).Item("position_name").ToString, .Rows(x).Item("partylist_name").ToString, .Rows(x).Item("student_id").ToString, .Rows(x).Item("lastname").ToString + ", " + .Rows(x).Item("firstname").ToString + ", " + .Rows(x).Item("middle_initial").ToString, .Rows(x).Item("vote_count"))





                End With
            Next
        End If
    End Sub



    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    If Label5.Text = "P1" Then
    '        PictureBox3.Image = My.Resources.a1
    '        Label5.Text = "P2"
    '    ElseIf Label5.Text = "P2" Then
    '        PictureBox3.Image = My.Resources.a2
    '        Label5.Text = "P3"
    '    ElseIf Label5.Text = "P3" Then
    '        PictureBox3.Image = My.Resources.a3
    '        Label5.Text = "P4"
    '    ElseIf Label5.Text = "P4" Then
    '        PictureBox3.Image = My.Resources.a4
    '        Label5.Text = "P5"
    '    ElseIf Label5.Text = "P5" Then
    '        PictureBox3.Image = My.Resources.a5
    '        Label5.Text = "P6"
    '    ElseIf Label5.Text = "P6" Then
    '        PictureBox3.Image = My.Resources.a6
    '        Label5.Text = "P7"
    '    ElseIf Label5.Text = "P7" Then
    '        PictureBox3.Image = My.Resources.a7
    '        Label5.Text = "P8"
    '    ElseIf Label5.Text = "P8" Then
    '        PictureBox3.Image = My.Resources.a8
    '        Label5.Text = "P9"
    '    ElseIf Label5.Text = "P9" Then
    '        PictureBox3.Image = My.Resources.a9
    '        Label5.Text = "P1"
    '    End If
    'End Sub
End Class