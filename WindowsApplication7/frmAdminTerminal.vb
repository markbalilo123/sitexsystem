Imports System.Data.SqlClient
Imports System.IO

Public Class frmAdminTerminal
    Dim time_now As String = TimeOfDay.ToString("h:mm:ss tt")
    Dim date_today As String = DateTime.Now.ToString("yyyy/MM/dd")

    Public opt_id As String = ""

    Sub load_admin_opt(ByVal opt_name As String)
        Try

            Dim route As String = ""

            connect()
            sql = "Select * from tbl_terminal a left join tbl_operator b on a.OperatorID=b.OperatorID left join tbl_vehicle_type c on b.VehicleTypeID=c.VehicleTypeID where a.OperatorID=@opt_id"
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
                        txt_type.Text = .Rows(x).Item("vehicle_name").ToString
                        txt_contact.Text = .Rows(x).Item("contact").ToString
                        txt_address.Text = .Rows(x).Item("address").ToString
                        route = .Rows(x).Item("start_point").ToString & "-" & .Rows(x).Item("destination").ToString
                        lbl_route.Text = route
                    End With
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Sub delete_vehicle_into_server(ByVal id As String)
        Try
            sql = "DELETE tbl_sitexserver WHERE ServerID=@id"
            cmd = New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@id", id)

            cmd.ExecuteNonQuery()

            load_server_vehicle_opt()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Sub insert_into_tbl_dispatch(ByVal id As String)

        Dim sql As String = "sp_dispatch"
        cmd.Connection = con
        cmd.CommandText = sql
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Clear()
            .AddWithValue("@id", id)
            .AddWithValue("@date_today", date_today)
        End With

        Try

            Dim returnValue As Integer = CType(cmd.ExecuteNonQuery, Integer)
            If returnValue = 1 Then

            End If
        Catch ex As Exception

            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Function check_full_pass()
        Dim tmp_num As Integer = 0
        Dim tmp_num2 As Integer = 0
        Dim tmp_id As String = ""

        Try
            connect()
            sql = "Select ServerID, no_passenger, seat_capacity from tbl_sitexserver a left join tbl_vehicle b on a.VehicleID=b.VehicleID left join tbl_operator c on b.OperatorID=c.OperatorID where b.OperatorID=@opt_id"
            adp = New SqlDataAdapter(sql, con)
            ds = New DataSet
            adp.SelectCommand.Parameters.AddWithValue("@opt_id", opt_id)
            adp.Fill(ds, "a")
            If ds.Tables("a").Rows.Count > 0 Then
                For x = 0 To ds.Tables("a").Rows.Count - 1
                    With ds.Tables("a")

                        tmp_num = .Rows(x).Item("no_passenger").ToString
                        tmp_num2 = .Rows(x).Item("seat_capacity").ToString
                        tmp_id = .Rows(x).Item("ServerID").ToString
                    End With
                Next
            End If

            If tmp_num = tmp_num2 And tmp_num <> "0" Then
                MsgBox("Equals")
                MsgBox(tmp_id)
                If MsgBox("Vehicle now is already full. Do you want to dispatch?", vbQuestion + vbYesNo) = vbYes Then
                    insert_into_tbl_dispatch(tmp_id)
                    delete_vehicle_into_server(tmp_id)
                    load_server_vehicle_opt()
                    load_dispatch()
                    Return True
                End If

            Else

                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try


        Return Nothing

    End Function

    Sub load_server_vehicle_opt()
        Try
            DataGridView3.Rows.Clear()
            Dim route As String = ""
            Dim i As Integer
            connect()
            sql = "Select * from tbl_sitexserver a left join tbl_vehicle b on a.VehicleID=b.VehicleID left join tbl_operator c on b.OperatorID=c.OperatorID left join tbl_vehicle_type d on c.VehicleTypeID=d.VehicleTypeID where b.OperatorID=@opt_id"
            adp = New SqlDataAdapter(sql, con)
            ds = New DataSet
            adp.SelectCommand.Parameters.AddWithValue("@opt_id", opt_id)
            adp.Fill(ds, "a")
            If ds.Tables("a").Rows.Count > 0 Then
                For x = 0 To ds.Tables("a").Rows.Count - 1
                    With ds.Tables("a")
                        i += 1

                        DataGridView3.Rows.Add(.Rows(x).Item("ServerID").ToString, i, .Rows(x).Item("plate_no").ToString, .Rows(x).Item("vehicle_name").ToString, .Rows(x).Item("name").ToString, .Rows(x).Item("no_passenger").ToString, .Rows(x).Item("available_seat").ToString, .Rows(x).Item("seat_capacity").ToString)

                    End With
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Sub load_dispatch()
        Try
            DataGridView1.Rows.Clear()
            Dim route As String = ""
            Dim i As Integer
            connect()
            sql = "Select * from tbl_dispatch a left join tbl_vehicle b on a.VehicleID=b.VehicleID left join tbl_operator c on b.OperatorID=c.OperatorID left join tbl_vehicle_type d on c.VehicleTypeID=d.VehicleTypeID where b.OperatorID=@opt_id and record_date=@dated"
            adp = New SqlDataAdapter(sql, con)
            ds = New DataSet
            adp.SelectCommand.Parameters.AddWithValue("@opt_id", opt_id)
            adp.SelectCommand.Parameters.AddWithValue("@dated", date_today)
            adp.Fill(ds, "a")
            If ds.Tables("a").Rows.Count > 0 Then
                For x = 0 To ds.Tables("a").Rows.Count - 1
                    With ds.Tables("a")
                        i += 1

                        DataGridView1.Rows.Add(.Rows(x).Item("DispatchID").ToString, i, .Rows(x).Item("timestamp").ToString, .Rows(x).Item("plate_no").ToString, .Rows(x).Item("vehicle_name").ToString, .Rows(x).Item("name").ToString, .Rows(x).Item("no_passenger").ToString, .Rows(x).Item("available_seat").ToString, .Rows(x).Item("seat_capacity").ToString)

                    End With
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub frmAdminTerminal_Load(sender As Object, e As EventArgs) Handles Me.Load
        '  MsgBox(opt_id)
        load_admin_opt(opt_id)
        load_server_vehicle_opt()
        load_dispatch()
        check_full_pass()

        txt_date.MaxDate = DateTime.Today
        txt_date.Format = DateTimePickerFormat.Custom
        txt_date.CustomFormat = "yyyy/MM/dd"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs)

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
                .cmb_operator.Enabled = False

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

    Private Sub Button2_Click(sender As Object, e As EventArgs)
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


                add_server_vehicle.opt_id = opt_id
                add_server_vehicle.Owner = f

                add_server_vehicle.ShowDialog()


            End With
        Catch ex As Exception

        Finally
            f.Dispose()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

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
                .cmb_operator.Enabled = False

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        Dim f As New Form

        Dim colname As String = DataGridView3.Columns(e.ColumnIndex).Name
        Try
            If colname = "colAdd" Then
                Dim tbl_id As Integer = DataGridView3.Rows(e.RowIndex).Cells(0).Value.ToString

                With add_passenger

                    .tbl_id.Text = tbl_id

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

                If MsgBox("Do you want to delete vehicle?", vbQuestion + vbYesNo) = vbYes Then

                    Dim id As Integer = DataGridView3.Rows(e.RowIndex).Cells(0).Value.ToString

                    sql = "DELETE tbl_sitexserver WHERE ServerID=@id"
                    cmd = New SqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@id", id)

                    cmd.ExecuteNonQuery()

                    load_server_vehicle_opt()
                End If
            End If
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        Finally
            f.Dispose()
        End Try
    End Sub

    Private Sub txt_date_ValueChanged(sender As Object, e As EventArgs) Handles txt_date.ValueChanged
        'asd
        Try
            DataGridView1.Rows.Clear()
            Dim route As String = ""
            Dim i As Integer
            connect()
            sql = "Select * from tbl_dispatch a left join tbl_vehicle b on a.VehicleID=b.VehicleID left join tbl_operator c on b.OperatorID=c.OperatorID left join tbl_vehicle_type d on c.VehicleTypeID=d.VehicleTypeID where record_date=@date"
            adp = New SqlDataAdapter(sql, con)
            ds = New DataSet
            adp.SelectCommand.Parameters.AddWithValue("@date", txt_date.Text)
            adp.Fill(ds, "a")
            If ds.Tables("a").Rows.Count > 0 Then
                For x = 0 To ds.Tables("a").Rows.Count - 1
                    With ds.Tables("a")
                        i += 1

                        DataGridView1.Rows.Add(.Rows(x).Item("DispatchID").ToString, i, .Rows(x).Item("timestamp").ToString, .Rows(x).Item("plate_no").ToString, .Rows(x).Item("vehicle_name").ToString, .Rows(x).Item("name").ToString, .Rows(x).Item("no_passenger").ToString, .Rows(x).Item("available_seat").ToString, .Rows(x).Item("seat_capacity").ToString)

                    End With
                Next
            Else
                load_dispatch()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class