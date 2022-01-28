'Imports System.Data.SqlClient
'Imports System.IO

'Public Class frmParty

'    Dim date_today As String = Date.Now.ToString("yyyy/MM/dd")

'    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
'        Me.Dispose()
'    End Sub


'    Public Sub load_party1()

'        If load_dt("SELECT id, ptlist1_name, ptlist1_motto, ptlist1_picture from tbl_party1 WHERE election_date = '" & date_today & "'", 0) = True Then
'            pt1_id.Text = dt.Rows(0).Item("id").ToString
'            pt1_name.Text = dt.Rows(0).Item("ptlist1_name").ToString
'            pt1_motto.Text = dt.Rows(0).Item("ptlist1_motto").ToString

'            Dim img() As Byte
'            img = dt.Rows(0).Item("ptlist1_picture")

'            Dim ms As New MemoryStream(img)
'            pt1_pic.Image = Image.FromStream(ms)

'            btnAdd1.Enabled = False
'            btnEdit1.Enabled = True
'            btnDel1.Enabled = True
'        Else
'            btnAdd1.Enabled = True
'            btnEdit1.Enabled = False
'            btnDel1.Enabled = False
'            pt1_id.Text = ""
'            pt1_name.Text = ""
'            pt1_motto.Text = ""
'            pt1_pic.Image = Nothing

'        End If
'    End Sub

'    Public Sub load_party2()

'        If load_dt("SELECT id, ptlist2_name, ptlist2_motto, ptlist2_picture from tbl_party2 WHERE election_date = '" & date_today & "'", 0) = True Then
'            pt2_id.Text = dt.Rows(0).Item("id").ToString
'            pt2_name.Text = dt.Rows(0).Item("ptlist2_name").ToString
'            pt2_motto.Text = dt.Rows(0).Item("ptlist2_motto").ToString

'            Dim img() As Byte
'            img = dt.Rows(0).Item("ptlist2_picture")

'            Dim ms As New MemoryStream(img)
'            pt2_pic.Image = Image.FromStream(ms)

'            btnAdd2.Enabled = False
'            btnEdit2.Enabled = True
'            btnDel2.Enabled = True
'        Else
'            btnAdd2.Enabled = True
'            btnEdit2.Enabled = False
'            btnDel2.Enabled = False
'            pt2_id.Text = ""
'            pt2_name.Text = ""
'            pt2_motto.Text = ""
'            pt2_pic.Image = Nothing

'        End If
'    End Sub

'    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd2.Click
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
'                add_partylist.Owner = f
'                add_partylist.btnUpdate.Enabled = False
'                add_partylist.cmb_dept_txt.Text = partylist2.Text
'                add_partylist.pt_lbl_id.Text = pt2_id.Text
'                add_partylist.ShowDialog()


'            End With
'        Catch ex As Exception

'        Finally
'            f.Dispose()
'        End Try
'    End Sub


'    Private Sub btnEdit2_Click(sender As Object, e As EventArgs) Handles btnEdit2.Click
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
'                add_partylist.Owner = f
'                add_partylist.btnUpdate.Enabled = True
'                add_partylist.btnSave.Enabled = False
'                add_partylist.cmb_dept_txt.Text = partylist2.Text
'                add_partylist.pt_lbl_id.Text = pt2_id.Text
'                add_partylist.pt_name.Text = pt2_name.Text
'                add_partylist.pt_motto.Text = pt2_name.Text
'                add_partylist.pt_pic.Image = pt2_pic.Image

'                add_partylist.ShowDialog()


'            End With
'        Catch ex As Exception

'        Finally
'            f.Dispose()
'        End Try
'    End Sub

'    Private Sub btnDel2_Click(sender As Object, e As EventArgs) Handles btnDel2.Click
'        If MsgBox("Do you want to delete this student?", vbQuestion + vbYesNo) = vbYes Then


'            ' Dim id As Integer = pt2_id.Text

'            sql = "DELETE tbl_party2 WHERE id=@id"
'            cmd = New SqlCommand(sql, con)
'            cmd.Parameters.AddWithValue("@id", pt2_id.Text)
'            Try

'                cmd.ExecuteNonQuery()
'                load_party2()

'            Catch ex As Exception
'                con.Close()
'                MsgBox(ex.Message, vbCritical)
'            End Try



'        End If
'    End Sub

'    Private Sub btnAdd1_Click(sender As Object, e As EventArgs) Handles btnAdd1.Click
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
'                add_partylist.Owner = f
'                add_partylist.btnUpdate.Enabled = False
'                add_partylist.cmb_dept_txt.Text = partylist1.Text
'                add_partylist.pt_lbl_id.Text = pt1_id.Text
'                add_partylist.ShowDialog()


'            End With
'        Catch ex As Exception

'        Finally
'            f.Dispose()
'        End Try
'    End Sub

'    Private Sub btnEdit1_Click(sender As Object, e As EventArgs) Handles btnEdit1.Click
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
'                add_partylist.Owner = f
'                add_partylist.btnUpdate.Enabled = True
'                add_partylist.btnSave.Enabled = False
'                add_partylist.cmb_dept_txt.Text = partylist1.Text
'                add_partylist.pt_lbl_id.Text = pt1_id.Text
'                add_partylist.pt_name.Text = pt1_name.Text
'                add_partylist.pt_motto.Text = pt1_name.Text
'                add_partylist.pt_pic.Image = pt1_pic.Image

'                add_partylist.ShowDialog()


'            End With
'        Catch ex As Exception

'        Finally
'            f.Dispose()
'        End Try
'    End Sub

'    Private Sub btnDel1_Click(sender As Object, e As EventArgs) Handles btnDel1.Click
'        If MsgBox("Do you want to delete this student?", vbQuestion + vbYesNo) = vbYes Then


'            ' Dim id As Integer = pt2_id.Text

'            sql = "DELETE tbl_party1 WHERE id=@id"
'            cmd = New SqlCommand(sql, con)
'            cmd.Parameters.AddWithValue("@id", pt1_id.Text)
'            Try

'                cmd.ExecuteNonQuery()
'                load_party1()

'            Catch ex As Exception
'                con.Close()
'                MsgBox(ex.Message, vbCritical)
'            End Try



'        End If
'    End Sub

'    Private Sub frmParty_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'        '  load_pt1()
'        load_party2()
'        load_party1()

'    End Sub

'End Class