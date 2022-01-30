Public Class add_vehicle_type



    Private Sub txt_type_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_type.KeyPress
        Dim Validinputchar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz " + vbBack
        If Not Validinputchar.Contains(e.KeyChar) Then
            e.KeyChar = Nothing

        End If
    End Sub


    Sub clear_type()
        txt_type.Text = ""
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click



        Try
            If is_Empty(txt_type.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_type.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return
            ElseIf is_lettersOnly(txt_type.text) = True Then
                MsgBox("Textbox must be letters only!", vbCritical)
                Return
            End If

            If MsgBox("Save data?", vbQuestion + vbYesNo) = vbYes Then


                Dim sql As String = "sp_vehicle_type"
                cmd.Connection = con
                cmd.CommandText = sql
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("@id", lbl_id.Text)
                    .AddWithValue("@vehicle_type", txt_type.Text.Trim)



                End With


                Try

                    Dim returnValue As Integer = CType(cmd.ExecuteNonQuery, Integer)

                    If returnValue = 1 Then
                        recordAction(frmMaintenance.date_today, frmMaintenance.time_now, newdashboard.txt_user.Text, newdashboard.txt_userlevel.Text, "Add vehicle type " + txt_type.Text)
                        clear_type()
                        'load form here
                        frmMaintenance.load_vehicle_type()
                        Me.Close()
                    Else
                        MsgBox("Vehicle type already exist!", vbCritical)
                    End If






                Catch ex As Exception

                    con.Close()
                    MsgBox(ex.Message, vbCritical)
                End Try
            End If
        Catch ex As Exception

            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub



    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click



        Try
            If is_Empty(txt_type.Text) = True Then
                Return
            ElseIf has_ContainsSpecialChars(txt_type.Text) = True Then
                MsgBox("Textbox contains special character!", vbCritical)
                Return
            ElseIf is_lettersOnly(txt_type.Text) = True Then
                MsgBox("Textbox must be letters only!", vbCritical)
                Return
            End If

            If MsgBox("Save data?", vbQuestion + vbYesNo) = vbYes Then


                Dim sql As String = "sp_vehicle_type"
                cmd.Connection = con
                cmd.CommandText = sql
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("@id", lbl_id.Text)
                    .AddWithValue("@vehicle_type", txt_type.Text.Trim)



                End With


                Try

                    Dim returnValue As Integer = CType(cmd.ExecuteNonQuery, Integer)

                    If returnValue = 1 Then
                        recordAction(frmMaintenance.date_today, frmMaintenance.time_now, newdashboard.txt_user.Text, newdashboard.txt_userlevel.Text, "Add vehicle type " + txt_type.Text)
                        clear_type()
                        'load form here
                        frmMaintenance.load_vehicle_type()
                        Me.Close()
                    Else
                        MsgBox("Vehicle type already exist!", vbCritical)
                    End If






                Catch ex As Exception

                    con.Close()
                    MsgBox(ex.Message, vbCritical)
                End Try
            End If
        Catch ex As Exception

            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class