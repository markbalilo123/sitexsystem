
Imports System.Data.SqlClient
Imports System.IO

Public Class add_passenger
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Sub clear()
        txt_passenger.Text = ""
    End Sub

    Function get_available_seat()
        Dim ret As String = ""

        Try
            connect()
            sql = "Select available_seat from tbl_sitexserver where ServerID=@id"
            adp = New SqlDataAdapter(sql, con)
            ds = New DataSet
            adp.SelectCommand.Parameters.AddWithValue("@id", tbl_id.Text)
            adp.Fill(ds, "a")
            If ds.Tables("a").Rows.Count > 0 Then
                For x = 0 To ds.Tables("a").Rows.Count - 1
                    With ds.Tables("a")

                        ret = .Rows(x).Item("available_seat").ToString

                    End With
                Next
                Return ret
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

        Return Nothing
    End Function

    Function check_seat()
        Dim str As String = ""
        str = get_available_seat()
        If CInt(str) - CInt(txt_passenger.Text) < 0 Then
            MsgBox("Invalid number! Their are only " & str & " available seat!", vbCritical)
            Return False
        Else Return True
        End If
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If check_seat() = True Then
            Dim sql As String = "sp_sitexserver"
            cmd.Connection = con
            cmd.CommandText = sql
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .Clear()
                .AddWithValue("@id", tbl_id.Text)
                .AddWithValue("@VehicleID", "")
                .AddWithValue("@cap", txt_passenger.Text)
                .AddWithValue("@no", txt_passenger.Text)

            End With

            Try
                Dim returnValue As Integer = CType(cmd.ExecuteNonQuery, Integer)

                If returnValue = 1 Then
                    MsgBox("Success adding passenger", vbInformation)
                    '    clear()
                    frmAdminTerminal.load_server_vehicle_opt()
                    frmAdminTerminal.check_full_pass()
                    Me.Close()


                End If
            Catch ex As Exception

                con.Close()
                MsgBox(ex.Message, vbCritical)
            End Try
        End If

    End Sub


End Class