Imports System.Data.SqlClient
Imports System.IO


Public Class newdashboard

    Dim time_now As String = TimeOfDay.ToString("h:mm:ss tt")
    Dim date_today As String = DateTime.Now.ToString("yyyy/MM/dd")

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        '   New(100)

        ' Add any initialization after the InitializeComponent() call.
        Me.Width = Screen.GetWorkingArea(Me).Width
        Me.Height = Screen.GetWorkingArea(Me).Height + 1

        DoubleBufferedControl(Panel5)
    End Sub


    Sub load_sy()
        connect()
        sql = "Select sy from tbl_school"
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then
            For x = 0 To ds.Tables("a").Rows.Count - 1
                With ds.Tables("a")

                    txt_sy.Text = .Rows(x).Item("sy").ToString

                End With
            Next
        End If
    End Sub


    Private Function checkStatus()
        Try
            Dim status As String = "Election started"
            connect()

            Dim adp As New SqlDataAdapter
            Dim dt As New DataTable
            Dim que As String = "SELECT * FROM tbl_election_status a left join tbl_departments b on a.DepartmentID = b.DepartmentID WHERE vote_status=@stat and a.status=@bitstat"

            Dim cmd As New SqlCommand(que, con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@stat", status)
            cmd.Parameters.AddWithValue("@bitstat", 1)

            With adp
                .SelectCommand = cmd
                .Fill(dt)
            End With
            If dt.Rows.Count >= 1 Then
                ' newUserDash.election_ID.Text = dt.Rows(0).Item("ElectionID")
                '   newUserDash.ename.Text = dt.Rows(0).Item("election_name")
                '   newUserDash.dept.Text = dt.Rows(0).Item("department")
                Return True
                Exit Function
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
        Return Nothing
    End Function



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Panel3.Width = 46 Then
            Timer1.Start()
        ElseIf Panel3.Width = 208 Then
            Timer2.Start()


        End If
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Panel3.Width = 208 Then
            Timer1.Stop()
            Label6.ForeColor = Color.White
            txt_sy.ForeColor = Color.White
            Label2.ForeColor = Color.White
            Label4.ForeColor = Color.White
            txt_user.ForeColor = Color.White
            txt_userlevel.ForeColor = Color.White


            For Each f As Form In My.Application.OpenForms
                If f.Name = frmDashboardMain.Name Then Return
            Next
            closeForms()
            With frmDashboardMain
                .Width = Panel5.Width
                .Height = Panel5.Height
                .TopLevel = False
                Panel5.Controls.Add(frmDashboardMain)
                .BringToFront()
                .Show()

            End With

        Else
            PictureBox1.Left += 2
            Panel3.Width = Panel3.Width + 2
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Panel3.Width = 46 Then
            Timer2.Stop()
            Label6.ForeColor = System.Drawing.Color.FromArgb(0, 175, 219)
            txt_sy.ForeColor = System.Drawing.Color.FromArgb(0, 175, 219)
            Label2.ForeColor = System.Drawing.Color.FromArgb(0, 175, 219)
            Label4.ForeColor = System.Drawing.Color.FromArgb(0, 175, 219)
            txt_user.ForeColor = System.Drawing.Color.FromArgb(0, 175, 219)
            txt_userlevel.ForeColor = System.Drawing.Color.FromArgb(0, 175, 219)
        Else
            PictureBox1.left -= 2
            panel3.width = panel3.width - 2
        End If
    End Sub

    Sub closeForms()
        For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
            If My.Application.OpenForms(i) IsNot Me Then My.Application.OpenForms(i).Dispose()

        Next
    End Sub

    Private Sub btnMakeelection_Click(sender As Object, e As EventArgs)
        For Each f As Form In My.Application.OpenForms
            If f.Name = frmMakeelection.Name Then Return
        Next
        closeForms()
        With frmMakeelection
            .Width = Panel5.Width
            .Height = Panel5.Height
            .TopLevel = False
            Panel5.Controls.Add(frmMakeelection)
            .BringToFront()
            .Show()

        End With
    End Sub



    Private Sub Panel5_Resize(sender As Object, e As EventArgs)
        For Each f As Form In Panel5.Controls
            f.Width = Panel5.Width
            f.Height = Panel5.Height

        Next
    End Sub






    Public Sub setup_pos_in_candidates()


        connect()
        Dim sql As String = "insert_pos_to_cand"
        cmd.Connection = con
        cmd.CommandText = sql
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Clear()

            .AddWithValue("@department", txt_user.Text)
            .AddWithValue("@election_date", date_today)



        End With

        Try
            cmd.ExecuteNonQuery()
            ' MsgBox("Data successfully save")
            'insert position in the tbl_candidates
            ' insert_in_tbl_cand()



        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'For Each f As Form In My.Application.OpenForms
        '    If f.Name = frmResults.Name Then Return
        'Next
        'closeForms()
        'With frmResults
        '    .Width = Panel5.Width
        '    .Height = Panel5.Height
        '    .TopLevel = False
        '    Panel5.Controls.Add(frmResults)
        '    .BringToFront()
        '    .Show()

        'End With
        For Each f As Form In My.Application.OpenForms
            If f.Name = frmDashboardMain.Name Then Return
        Next
        closeForms()
        With frmDashboardMain
            .Width = Panel5.Width
            .Height = Panel5.Height
            .TopLevel = False
            Panel5.Controls.Add(frmDashboardMain)
            .BringToFront()
            .Show()

        End With
    End Sub


    'Function cnt_dept_population()
    '    Dim retCnt As Integer = 0

    '    sql = " Select COUNT(student_id) As cnt from tbl_students where vote_status='Election started' and vote_start_date=@edate"
    '    adp = New SqlDataAdapter(sql, con)
    '    ds = New DataSet
    '    adp.SelectCommand.Parameters.AddWithValue("@edate", date_today)
    '    adp.Fill(ds, "a")
    '    If ds.Tables("a").Rows.Count > 0 Then
    '        For x = 0 To ds.Tables("a").Rows.Count - 1
    '            With ds.Tables("a")
    '                retCnt = .Rows(x).Item("cnt").ToString
    '            End With
    '        Next

    '        Return retCnt
    '    End If

    '    Return Nothing
    'End Function

    'Public Sub update_population()

    'End Sub


    Private Sub newdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'frmMakeelection.load_election()
        ' load_all_students()
        ' load_candidates1()
        ' load_candidates2()
        load_sy()
        'get number of students per dept

        Timer1.Start()
        Label2.ForeColor = System.Drawing.Color.FromArgb(0, 175, 219)
        Label4.ForeColor = System.Drawing.Color.FromArgb(0, 175, 219)
        txt_user.ForeColor = System.Drawing.Color.FromArgb(0, 175, 219)
        txt_userlevel.ForeColor = System.Drawing.Color.FromArgb(0, 175, 219)
        txt_sy.ForeColor = System.Drawing.Color.FromArgb(0, 175, 219)
        Label6.ForeColor = System.Drawing.Color.FromArgb(0, 175, 219)
        txt_user.Text = username
        txt_userlevel.Text = userlevel
    End Sub
    ' load_pt1()
    ' load_pt2()
    ' pos_list()



    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        If txt_userlevel.Text <> "SUPERADMIN" Then
            Return
        End If

        For Each f As Form In My.Application.OpenForms
            If f.Name = frmMaintenance.Name Then Return
        Next
        closeForms()
        With frmMaintenance
            .Width = Panel5.Width
            .Height = Panel5.Height
            .TopLevel = False
            Panel5.Controls.Add(frmMaintenance)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For Each f As Form In My.Application.OpenForms
            If f.Name = frmDashboardMain.Name Then Return
        Next
        closeForms()
        With frmDashboardMain
            .Width = Panel5.Width
            .Height = Panel5.Height
            .TopLevel = False
            Panel5.Controls.Add(frmDashboardMain)
            .BringToFront()
            .Show()

        End With
    End Sub

    Public Sub clearLoginDetails()
        txt_user.Text = ""
        txt_userlevel.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If MsgBox("Are you sure you want to exit?", vbQuestion + vbYesNo) = vbYes Then
            recordAction(date_today, time_now, txt_user.Text, txt_userlevel.Text, "Logout")
            clearLoginDetails()

            'record login audit trail


            Me.Close()
            login.Show()
        Else

        End If

    End Sub


End Class