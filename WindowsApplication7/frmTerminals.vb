
Imports System.Data.SqlClient
Imports System.IO

Public Class frmTerminals

    Public time_now As String = TimeOfDay.ToString("h:mm:ss tt")
    Public date_today As String = DateTime.Now.ToString("yyyy/MM/dd")

    Dim start As String = ""
    Dim dest As String = ""

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.Dispose()
    End Sub

    Sub load_terminal()
        Dim routes As String = ""


        DataGridView1.Rows.Clear()
        Dim i As Integer
        connect()
        sql = "Select * from tbl_terminal a left join tbl_operator b on a.OperatorID=b.OperatorID left join tbl_vehicle_type c on b.VehicleTypeID=c.VehicleTypeID"
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then
            For x = 0 To ds.Tables("a").Rows.Count - 1
                With ds.Tables("a")
                    i += 1

                    start = .Rows(x).Item("start_point").ToString
                    dest = .Rows(x).Item("destination").ToString
                    routes = start + "-" + dest
                    DataGridView1.Rows.Add(i, .Rows(x).Item("TerminalID").ToString, .Rows(x).Item("terminal_name").ToString, .Rows(x).Item("name").ToString, .Rows(x).Item("vehicle_name").ToString, routes, .Rows(x).Item("date_added").ToString, .Rows(x).Item("status").ToString)


                End With
            Next
        End If
    End Sub


    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
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
                add_terminal.Owner = f
                add_terminal.btnUpdate.Enabled = False
                add_terminal.ShowDialog()


            End With
        Catch ex As Exception

        Finally
            f.Dispose()
        End Try
    End Sub

    Private Sub frmTerminals_Load(sender As Object, e As EventArgs) Handles Me.Load
        load_terminal()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Dim strArr() As String

        Dim f As New Form

        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
        Try
            If colname = "colEdit" Then
                Dim tbl_id As Integer = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                Dim terminal_name As String = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                Dim operator_name As String = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                Dim vehicle_type As String = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString

                Dim routes As String = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString

                strArr = routes.Split("-")

                Dim date_added As String = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString
                Dim status As String = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString

                With add_terminal
                    .btnSave.Enabled = False
                    .btnUpdate.Enabled = True
                    .lbl_id.Text = tbl_id
                    .txt_terminal.Text = terminal_name
                    .txt_start.Text = strArr(0)
                    .txt_dest.Text = strArr(1)
                    .tmp_cmb_opt = operator_name

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

                If MsgBox("Do you want to delete terminal?", vbQuestion + vbYesNo) = vbYes Then

                    Dim tbl_id As Integer = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                    Dim terminal_name As String = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString


                    sql = "DELETE tbl_terminal WHERE TerminalID=@id"
                    cmd = New SqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@id", tbl_id)

                    cmd.ExecuteNonQuery()

                    recordAction(date_today, time_now, newdashboard.txt_user.Text, newdashboard.txt_userlevel.Text, "Delete terminal " + terminal_name)

                    frmMaintenance.load_auditTrails()
                    load_terminal()

                End If

            ElseIf colname = "colMap" Then


                Dim routes As String = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString

                strArr = routes.Split("-")

                'MsgBox("mapa")
                'MsgBox(strArr(0))
                'MsgBox(strArr(1))

                With frmMiniMap

                    .start = strArr(0)
                    .dest = strArr(1)
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
            End If


        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        Finally
            f.Dispose()
        End Try
    End Sub

    Private Sub txtstdsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtstdsearch.KeyPress
        Dim Validinputchar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789 " + vbBack
        If Not Validinputchar.Contains(e.KeyChar) Then
            e.KeyChar = Nothing

        End If
    End Sub

    Private Sub txtstdsearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtstdsearch.KeyUp
        If is_Empty(txtstdsearch.Text) = True Then
            Return

        ElseIf has_ContainsSpecialChars(txtstdsearch.Text) = True Then
            MsgBox("Textbox contains special character!", vbCritical)
            Return
        End If

        Dim routes As String = ""

        DataGridView1.Rows.Clear()
        Dim i As Integer
        connect()
        '  sql = "Select id, department, student_id, lastname, firstname, middle_initial, course, yrlevel, status  from tbl_students"
        sql = "Select * from tbl_terminal a left join tbl_operator b on a.OperatorID=b.OperatorID left join tbl_vehicle_type c on b.VehicleTypeID=c.VehicleTypeID where terminal_name like @std_id or a.status like @std_id or name like @std_id or vehicle_name like @std_id"
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.SelectCommand.Parameters.AddWithValue("@std_id", txtstdsearch.Text)
        adp.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then
            For x = 0 To ds.Tables("a").Rows.Count - 1
                With ds.Tables("a")
                    i += 1
                    start = .Rows(x).Item("start_point").ToString
                    dest = .Rows(x).Item("destination").ToString
                    routes = start + "-" + dest
                    DataGridView1.Rows.Add(i, .Rows(x).Item("TerminalID").ToString, .Rows(x).Item("terminal_name").ToString, .Rows(x).Item("name").ToString, .Rows(x).Item("vehicle_name").ToString, routes, .Rows(x).Item("date_added").ToString, .Rows(x).Item("status").ToString)




                End With
            Next
        Else

            load_terminal()
        End If
    End Sub
End Class