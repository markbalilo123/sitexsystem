﻿Imports System.Data.SqlClient
Imports System.IO


Public Class frmDrivers

    Public time_now As String = TimeOfDay.ToString("h:mm:ss tt")
    Public date_today As String = DateTime.Now.ToString("yyyy/MM/dd")


    Sub load_driver()

        DataGridView1.Rows.Clear()
        Dim i As Integer
        connect()
        sql = "Select * from tbl_driver a left join tbl_operator b on a.OperatorID=b.OperatorID left join tbl_vehicle_type c  on b.VehicleTypeID=c.VehicleTypeID"
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then
            For x = 0 To ds.Tables("a").Rows.Count - 1
                With ds.Tables("a")
                    i += 1


                    DataGridView1.Rows.Add(i, .Rows(x).Item("DriverID").ToString, .Rows(x).Item("license_no").ToString, .Rows(x).Item("last_name").ToString, .Rows(x).Item("first_name").ToString, .Rows(x).Item("middle_initial").ToString, .Rows(x).Item("name").ToString, .Rows(x).Item("vehicle_name").ToString, .Rows(x).Item("address").ToString, .Rows(x).Item("contact").ToString, .Rows(x).Item("dated_added").ToString, .Rows(x).Item("status").ToString)


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
                add_driver.Owner = f
                add_driver.btnUpdate.Enabled = False
                add_driver.ShowDialog()


            End With
        Catch ex As Exception

        Finally
            f.Dispose()
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.Dispose()
    End Sub

    Private Sub frmDrivers_Load(sender As Object, e As EventArgs) Handles Me.Load
        load_driver()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim f As New Form

        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
        Try
            If colname = "colEdit" Then
                Dim tbl_id As Integer = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                Dim license As String = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                Dim lname As String = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                Dim fname As String = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
                Dim mname As String = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
                Dim opt As String = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
                Dim address As String = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString

                Dim contact As String = DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString

                With add_driver
                    .btnSave.Enabled = False
                    .btnUpdate.Enabled = True
                    .lbl_id.Text = tbl_id
                    .txt_lname.Text = lname
                    .txt_fname.Text = fname
                    .txt_mname.Text = mname
                    .tmp_cmb_opt = opt
                    .txt_licno.Text = license
                    .txt_address.Text = address
                    .txt_contact.Text = contact



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

                If MsgBox("Do you want to delete driver?", vbQuestion + vbYesNo) = vbYes Then

                    Dim tbl_id As Integer = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                    Dim license As String = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString


                    sql = "DELETE tbl_driver WHERE DriverID=@id"
                    cmd = New SqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@id", tbl_id)

                    cmd.ExecuteNonQuery()

                    recordAction(date_today, time_now, newdashboard.txt_user.Text, newdashboard.txt_userlevel.Text, "Delete driver with license no. " + license)


                    frmMaintenance.load_auditTrails()
                    load_driver()



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