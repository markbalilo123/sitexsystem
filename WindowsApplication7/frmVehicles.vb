﻿Imports System.Data.SqlClient
Imports System.IO

Public Class frmVehicles

    Public time_now As String = TimeOfDay.ToString("h:mm:ss tt")
    Public date_today As String = DateTime.Now.ToString("yyyy/MM/dd")

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.Dispose()
    End Sub

    Sub load_vehicles()

        DataGridView1.Rows.Clear()
        Dim i As Integer
        connect()
        sql = "Select * from tbl_vehicle a left join tbl_operator b on a.OperatorID=b.OperatorID left join tbl_vehicle_type c on b.VehicleTypeID=c.VehicleTypeID"
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then
            For x = 0 To ds.Tables("a").Rows.Count - 1
                With ds.Tables("a")
                    i += 1


                    DataGridView1.Rows.Add(i, .Rows(x).Item("VehicleID").ToString, .Rows(x).Item("plate_no").ToString, .Rows(x).Item("name").ToString, .Rows(x).Item("vehicle_name").ToString, .Rows(x).Item("yrmodel").ToString, .Rows(x).Item("dealer").ToString, .Rows(x).Item("date_added").ToString, .Rows(x).Item("status").ToString)


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
                add_vehicle.Owner = f
                add_vehicle.btnUpdate.Enabled = False
                add_vehicle.ShowDialog()


            End With
        Catch ex As Exception

        Finally
            f.Dispose()
        End Try
    End Sub

    Private Sub frmVehicles_Load(sender As Object, e As EventArgs) Handles Me.Load
        load_vehicles()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim f As New Form

        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
        Try
            If colname = "colEdit" Then
                Dim tbl_id As Integer = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                Dim plate As String = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                Dim opt As String = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                Dim yrmodel As String = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
                Dim dealer As String = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString


                With add_vehicle
                    .btnSave.Enabled = False
                    .btnUpdate.Enabled = True
                    .lbl_id.Text = tbl_id
                    .txt_plate.Text = plate
                    .txt_dealer.Text = dealer
                    .txt_yr.Text = yrmodel


                    .tmp_cmb_opt = opt

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

                    Dim tbl_id As Integer = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                    Dim plate As String = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString


                    sql = "DELETE tbl_vehicle WHERE VehicleID=@id"
                    cmd = New SqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@id", tbl_id)

                    cmd.ExecuteNonQuery()

                    recordAction(date_today, time_now, newdashboard.txt_user.Text, newdashboard.txt_userlevel.Text, "Delete vehicle with plate no " + plate)


                    frmMaintenance.load_auditTrails()
                    load_vehicles()



                End If
            End If


        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        Finally
            f.Dispose()
        End Try
    End Sub
End Class