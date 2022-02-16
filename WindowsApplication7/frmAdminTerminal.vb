Imports System.Data.SqlClient
Imports System.IO

Public Class frmAdminTerminal
    Dim time_now As String = TimeOfDay.ToString("h:mm:ss tt")
    Dim date_today As String = DateTime.Now.ToString("yyyy/MM/dd")


    Public opt_id As String = ""

    Sub load_admin_opt(ByVal opt_name As String)
        Dim route As String = ""

        connect()
        sql = "Select * from tbl_terminal a left join tbl_operator b on a.OperatorID=b.OperatorID where a.OperatorID=@opt_id"
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.SelectCommand.Parameters.AddWithValue("@opt_id", opt_id)
        adp.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then
            For x = 0 To ds.Tables("a").Rows.Count - 1
                With ds.Tables("a")

                    tbl_id.Text = .Rows(x).Item("TerminalID").ToString
                    txt_terminal.Text = .Rows(x).Item("terminal_name").ToString
                    txt_opt.Text = .Rows(x).Item("name").ToString
                    txt_contact.Text = .Rows(x).Item("contact").ToString
                    txt_address.Text = .Rows(x).Item("address").ToString
                    route = .Rows(x).Item("start_point").ToString & "-" & .Rows(x).Item("destination").ToString
                    lbl_route.Text = route
                End With
            Next
        Else
            MsgBox("Operator has no Terminal!", vbCritical)
        End If
    End Sub

    Private Sub frmAdminTerminal_Load(sender As Object, e As EventArgs) Handles Me.Load
        MsgBox(opt_id)
        load_admin_opt(opt_id)
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim strArr() As String

        Dim f As New Form
        Try
            With add_terminal
                .btnSave.Enabled = False
                .btnUpdate.Enabled = True
                .lbl_id.Text = tbl_id.Text
                .txt_terminal.Text = txt_terminal.Text
                strArr = lbl_route.Text.Split("-")
                .txt_start.Text = strArr(0)
                .txt_dest.Text = strArr(1)
                .tmp_cmb_opt = txt_opt.Text


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
        Catch ex As Exception

        Finally
            f.Dispose()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim strArr() As String
        strArr = lbl_route.Text.Split("-")
        Dim f As New Form
        Try
            With f
                frmMiniMap.start = strArr(0)
                frmMiniMap.dest = strArr(1)
                .WindowState = FormWindowState.Maximized
                .StartPosition = FormStartPosition.Manual
                .BackColor = Color.Black
                .Opacity = 0.5
                .ShowInTaskbar = False
                .FormBorderStyle = FormBorderStyle.None
                .Show()
                frmMiniMap.Owner = f
                frmMiniMap.ShowDialog()



            End With
        Catch ex As Exception

        Finally
            f.Dispose()
        End Try



    End Sub
End Class