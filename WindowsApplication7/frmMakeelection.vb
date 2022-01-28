'Imports System.Data.SqlClient
'Imports System.IO


'Public Class frmMakeelection

'    Dim date_today As String = Date.Now.ToString("yyyy/MM/dd")


'    Sub load_pos()
'        Try
'            DataGridView1.Rows.Clear()
'            Dim i As Integer
'            connect()
'            cmd = New SqlCommand("Select * from tbl_ccs_pos", con)
'            dr = New SqlDataReader
'            dr = cmd.ExecuteReader
'            While dr.Read
'                i += 1
'                DataGridView1.Rows.Add(i, dr.Item("id").ToString, dr.Item(("position_name").ToString))
'                DataGridView1.ClearSelection()

'            End While
'            dr.Close()
'            con.Close()

'        Catch ex As Exception

'        End Try
'        DataGridView1.Rows.Clear()
'        Dim i As Integer
'        connect()
'        sql = "Select * from tbl_ccs_pos"
'        adp = New SqlDataAdapter(sql, con)
'        ds = New DataSet
'        adp.Fill(ds, "a")
'        If ds.Tables("a").Rows.Count > 0 Then
'            For x = 0 To ds.Tables("a").Rows.Count - 1
'                With ds.Tables("a")
'                    i += 1
'                    DataGridView1.Rows.Add(.Rows(x).Item("id").ToString, i, .Rows(x).Item("position_name").ToString)





'                End With
'            Next
'        End If
'    End Sub

'    Private Sub frmMakeelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        load_election()
'        load_pos()
'        load_all_students()
'        load_candidates1()
'        load_candidates2()

'        load_pt1()
'        load_pt2()
'        pos_list()

'    End Sub

'    Private Sub MetroButton1_Click(sender As Object, e As EventArgs)
'        add_makeelection.ShowDialog()

'    End Sub

'    Public Sub load_election()
'        Dim date_today As String = Date.Now.ToString("yyyy/MM/dd")

'        If load_dt("SELECT id, vote_start_date, department, vote_status, election_name from tbl_election_status WHERE vote_start_date = '" & date_today & "'", 0) = True Then
'            If load_dt("SELECT id, vote_start_date, vote_school_year, department, vote_status, election_name from tbl_election_status", 0) = True Then

'                txt_me_elect_id.Text = dt.Rows(0).Item("id").ToString
'                txtEname.Text = dt.Rows(0).Item("election_name").ToString
'                txt_deptname.Text = dt.Rows(0).Item("department").ToString
'                me_elect_date.Text = dt.Rows(0).Item("vote_start_date").ToString

'                lock_me()
'                btnAdd.Enabled = False
'                btnDel.Enabled = True
'                btnEdit.Enabled = True

'                newdashboard.elect_status.Text = dt.Rows(0).Item("vote_status").ToString
'                elect_status.Text = dt.Rows(0).Item("vote_status").ToString

'            set the position in the candidates tables

'        Else
'                put restrict here
'            clear_me()
'                lock_me()
'                btnAdd.Enabled = True
'                btnEdit.Enabled = False
'                btnDel.Enabled = False

'            End If
'    End Sub

'    Public Sub clear_me()
'        txt_me_elect_id.Text = ""
'        txtEname.Text = ""
'        txt_deptname.Text = ""

'    End Sub

'    Public Sub lock_me()
'        txtEname.Enabled = False
'        txt_deptname.Enabled = False
'        btnSave.Enabled = False

'    End Sub

'    Public Sub unlock_me()
'        txtEname.Enabled = True
'        txt_deptname.Enabled = False
'        btnSave.Enabled = True
'    End Sub

'    Private Sub MetroButton3_Click(sender As Object, e As EventArgs)
'        unlock_me()
'        txt_deptname.Text = newdashboard.txt_deptname1.Text
'    End Sub

'    Private Sub btnSave_Click(sender As Object, e As EventArgs)
'        Dim date_today As String = Date.Now.ToString("yyyy/MM/dd")
'        If txtEname.Text = "" Then
'            MetroFramework.MetroMessageBox.Show(Me, "Fill up all fields!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        Else
'            connect()
'            Dim sql As String = "me_insert"
'            cmd.Connection = con
'            cmd.CommandText = sql
'            cmd.CommandType = CommandType.StoredProcedure
'            With cmd.Parameters
'                .Clear()
'                .AddWithValue("@election_name", txtEname.Text)
'                .AddWithValue("@department", txt_deptname.Text)
'                .AddWithValue("@election_date", date_today)
'                .AddWithValue("@vote_status", "Election created")
'                .AddWithValue("@id", txt_me_elect_id.Text)

'            End With

'            Try
'                cmd.ExecuteNonQuery()
'                MsgBox("Data successfully save")
'                insert position in the tbl_candidates
'                 insert_in_tbl_cand()
'                clear_me()

'                lock_me()

'                load_election()
'            Catch ex As Exception
'                MsgBox(ex.Message)

'            End Try
'        End If

'    End Sub

'    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
'        lock_me()
'    End Sub

'    Private Sub MetroButton2_Click(sender As Object, e As EventArgs)
'        unlock_me()
'    End Sub

'    Private Sub MetroButton1_Click_1(sender As Object, e As EventArgs)
'        If MetroFramework.MetroMessageBox.Show(Me, "Are you sure to delete election?", "Notifications", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then
'            connect()
'            sql = "DELETE FROM tbl_election_status where id = @id"
'            cmd = New SqlCommand(sql, con)
'            cmd.Parameters.AddWithValue("@id", txt_me_elect_id.Text)

'            Try
'                cmd.ExecuteNonQuery()
'                MetroFramework.MetroMessageBox.Show(Me, "Data successfully deleted.", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Error)
'                load_election()

'            Catch ex As Exception
'                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
'            End Try
'        End If
'    End Sub

'    Private Sub MetroButton1_Click_2(sender As Object, e As EventArgs)

'    End Sub

'    Private Sub Button1_Click(sender As Object, e As EventArgs)
'        unlock_me()
'        txt_deptname.Text = newdashboard.txt_deptname1.Text
'    End Sub

'    Private Sub Button4_Click(sender As Object, e As EventArgs)
'        unlock_me()
'    End Sub

'    Private Sub Button5_Click(sender As Object, e As EventArgs)
'        If MetroFramework.MetroMessageBox.Show(Me, "Are you sure to delete election?", "Notifications", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then
'            connect()
'            sql = "DELETE FROM tbl_election_status where id = @id"
'            cmd = New SqlCommand(sql, con)
'            cmd.Parameters.AddWithValue("@id", txt_me_elect_id.Text)

'            Try
'                cmd.ExecuteNonQuery()
'                MetroFramework.MetroMessageBox.Show(Me, "Data successfully deleted.", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Error)
'                load_election()

'            Catch ex As Exception
'                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
'            End Try
'        End If
'    End Sub

'    Private Sub MetroButton4_Click(sender As Object, e As EventArgs)
'        Me.Dispose()
'    End Sub

'    Private Sub MetroButton3_Click_1(sender As Object, e As EventArgs)
'        Dim f As New Form
'        Try
'            With f
'                .WindowState = FormWindowState.Maximized
'                .StartPosition = FormStartPosition.Manual
'                .BackColor = Color.Black
'                .Opacity = 0.5
'                .ShowInTaskbar = False
'                .FormBorderStyle = FormBorderStyle.None
'                .Show()
'                add_position.Owner = f
'                add_position.btnUpdate.Enabled = False
'                add_position.ShowDialog()


'            End With
'        Catch ex As Exception

'        Finally
'            f.Dispose()
'        End Try
'    End Sub


'    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
'        Dim f As New Form

'        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
'        Try
'            If colname = "colEdit" Then
'                Dim id As Integer = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
'                Dim pos As String = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString

'                With add_position
'                    .btnSave.Enabled = False
'                    .btnUpdate.Enabled = True
'                    .txt_pos.Text = pos
'                    .lbl_pos_id.Text = id
'                    f.WindowState = FormWindowState.Maximized
'                    f.FormBorderStyle = FormBorderStyle.None
'                    f.StartPosition = FormStartPosition.Manual
'                    f.BackColor = Color.Black
'                    f.Opacity = 0.5
'                    f.ShowInTaskbar = False
'                    f.Show()
'                    .Owner = f
'                    .ShowDialog()

'                End With
'            ElseIf colname = "colDelete" Then
'                If MsgBox("Do you want to delete this position?", vbQuestion + vbYesNo) = vbYes Then


'                    Dim id As Integer = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString

'                    sql = "DELETE tbl_ccs_pos WHERE id=@id"
'                    cmd = New SqlCommand(sql, con)
'                    cmd.Parameters.AddWithValue("@id", id)

'                    cmd.ExecuteNonQuery()
'                    load_pos()


'                End If
'            End If

'        Catch ex As Exception
'            con.Close()
'            MsgBox(ex.Message, vbCritical)
'        Finally
'            f.Dispose()
'        End Try



'    End Sub

'    Private Sub MetroTabPage2_Click(sender As Object, e As EventArgs)

'    End Sub
'End Class