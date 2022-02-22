
Imports System.Data.SqlClient
Imports System.IO

Public Class frm_kiosk_terminal

    Dim time_now As String = TimeOfDay.ToString("h:mm:ss tt")
    Dim date_today As String = DateTime.Now.ToString("yyyy/MM/dd")

    Public tmp_cmb_type As String = ""

    Public Sub fill_cmb_type(ByVal cmb As ComboBox)

        connect()
        sql = "Select * from tbl_vehicle_type"
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then
            For x = 0 To ds.Tables("a").Rows.Count - 1
                With ds.Tables("a")
                    'dept_id.Text = .Rows(x).Item("DepartmentID").ToString
                    cmb.Items.Add(.Rows(x).Item("vehicle_name").ToString)

                End With
            Next
        End If
    End Sub

    Sub load_server_vehicle_all()
        Try
            DataGridView3.Rows.Clear()
            Dim route As String = ""
            Dim i As Integer
            connect()
            sql = "Select * from tbl_sitexserver a left join tbl_vehicle b on a.VehicleID=b.VehicleID left join tbl_operator c on b.OperatorID=c.OperatorID left join tbl_vehicle_type d on c.VehicleTypeID=d.VehicleTypeID left join tbl_terminal e on c.OperatorID=e.OperatorID"
            adp = New SqlDataAdapter(sql, con)
            ds = New DataSet
            '     adp.SelectCommand.Parameters.AddWithValue("@opt_id", opt_id)
            adp.Fill(ds, "a")
            If ds.Tables("a").Rows.Count > 0 Then
                For x = 0 To ds.Tables("a").Rows.Count - 1
                    With ds.Tables("a")
                        i += 1
                        route = .Rows(x).Item("start_point").ToString + "-" + .Rows(x).Item("destination").ToString
                        DataGridView3.Rows.Add(i, .Rows(x).Item("ServerID").ToString, .Rows(x).Item("terminal_name").ToString, .Rows(x).Item("name").ToString, .Rows(x).Item("plate_no").ToString, route, .Rows(x).Item("available_seat").ToString, .Rows(x).Item("no_passenger").ToString, .Rows(x).Item("seat_capacity").ToString)

                    End With
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub


    Private Sub frm_kiosk_terminal_Load(sender As Object, e As EventArgs) Handles Me.Load
        fill_cmb_type(cmb_type)
        cmb_type.Items.Add("All")
        cmb_type.Text = "All"
        load_server_vehicle_all()
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

        Dim strArr() As String

        Dim f As New Form

        Dim colname As String = DataGridView3.Columns(e.ColumnIndex).Name
        Try

            If colname = "colMap" Then


                Dim routes As String = DataGridView3.Rows(e.RowIndex).Cells(5).Value.ToString

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

    Private Sub cmb_type_TextChanged(sender As Object, e As EventArgs) Handles cmb_type.TextChanged
        If cmb_type.Text = "All" Then
            load_server_vehicle_all()

        Else

            Try
                DataGridView3.Rows.Clear()
                Dim route As String = ""
                Dim i As Integer
                connect()
                sql = "Select * from tbl_sitexserver a left join tbl_vehicle b on a.VehicleID=b.VehicleID left join tbl_operator c on b.OperatorID=c.OperatorID left join tbl_vehicle_type d on c.VehicleTypeID=d.VehicleTypeID left join tbl_terminal e on c.OperatorID=e.OperatorID where vehicle_name=@vname"
                adp = New SqlDataAdapter(sql, con)
                ds = New DataSet
                adp.SelectCommand.Parameters.AddWithValue("@vname", cmb_type.Text)
                adp.Fill(ds, "a")
                If ds.Tables("a").Rows.Count > 0 Then
                    For x = 0 To ds.Tables("a").Rows.Count - 1
                        With ds.Tables("a")
                            i += 1
                            route = .Rows(x).Item("start_point").ToString + "-" + .Rows(x).Item("destination").ToString
                            DataGridView3.Rows.Add(i, .Rows(x).Item("ServerID").ToString, .Rows(x).Item("terminal_name").ToString, .Rows(x).Item("name").ToString, .Rows(x).Item("plate_no").ToString, route, .Rows(x).Item("no_passenger").ToString, .Rows(x).Item("available_seat").ToString, .Rows(x).Item("seat_capacity").ToString)

                        End With
                    Next
                End If
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            End Try
        End If

    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        If cmb_type.Text = "" Then
            MsgBox("Choose vehicle type first!", vbCritical)
            Return
        Else

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If cmb_type.Text = "All" Then
            load_server_vehicle_all()
        Else
            Try
                DataGridView3.Rows.Clear()
                Dim route As String = ""
                Dim i As Integer
                connect()
                sql = "Select * from tbl_sitexserver a left join tbl_vehicle b on a.VehicleID=b.VehicleID left join tbl_operator c on b.OperatorID=c.OperatorID left join tbl_vehicle_type d on c.VehicleTypeID=d.VehicleTypeID left join tbl_terminal e on c.OperatorID=e.OperatorID where vehicle_name=@vname"
                adp = New SqlDataAdapter(sql, con)
                ds = New DataSet
                adp.SelectCommand.Parameters.AddWithValue("@vname", cmb_type.Text)
                adp.Fill(ds, "a")
                If ds.Tables("a").Rows.Count > 0 Then
                    For x = 0 To ds.Tables("a").Rows.Count - 1
                        With ds.Tables("a")
                            i += 1
                            route = .Rows(x).Item("start_point").ToString + "-" + .Rows(x).Item("destination").ToString
                            DataGridView3.Rows.Add(i, .Rows(x).Item("ServerID").ToString, .Rows(x).Item("terminal_name").ToString, .Rows(x).Item("name").ToString, .Rows(x).Item("plate_no").ToString, route, .Rows(x).Item("no_passenger").ToString, .Rows(x).Item("available_seat").ToString, .Rows(x).Item("seat_capacity").ToString)

                        End With
                    Next
                End If
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            End Try
        End If
    End Sub
End Class