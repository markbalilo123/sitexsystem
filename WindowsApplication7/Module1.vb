Imports System.Data.SqlClient

Module Module1





    'Public con As New SqlConnection("Data Source=AWE-6C8F7D502C7\SQLEXPRESS;Initial Catalog=db_votingsystem;Integrated Security=True")
    Public con As New SqlConnection("Data Source=DESKTOP-RNAMSMV;Initial Catalog=db_votesystem;Integrated Security=True")
    Public adp As New SqlDataAdapter
    Public cmd As New SqlCommand
    Public dt As New DataTable
    Public ds As New DataSet
    '   Public dr As New SqlDataReader
    Public sql As String
    Public userlevel As String
    Public username As String


    Dim trimChars As Char() = {" "c}



    Public action As Boolean
    Public user_action As Boolean

    'this action will just hold the add/edit module
    'this will decide if we add or edit in the module

    Public cand_pres_action As Boolean
    Public cand_vp_action As Boolean
    Public cand_sec_action As Boolean
    Public cand_ass_sec_action As Boolean
    Public cand_aud_action As Boolean
    Public cand_treas_action As Boolean
    Public cand_pro_action As Boolean
    Public cand_pc1_action As Boolean
    Public cand_pc2_action As Boolean
    Public cand_1yr_action As Boolean
    Public cand_2yr_action As Boolean
    Public cand_3yr_action As Boolean
    Public cand_4yr_action As Boolean


    Public student_status As Boolean

    Public pos_for_view_in_user As String
    Public user_form_track As Integer
    Public track_addcand_tab As Integer


    'This cd action is a new action fr our candidates
    ' this will be use instead of action in the up
    Public cd_action As Boolean
    Public pt_action As Boolean
    Public pt_action2 As Boolean


    Public param_name(10) As String
    Public param_values(10) As String
    Public Sub connect()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Public Function load_dt(ByVal query As String, ByVal number_of_parameter As Integer) As Boolean
        Try
            Using cmd
                Using adp
                    connect()
                    cmd = New SqlClient.SqlCommand(query, con)
                    With cmd.Parameters
                        .Clear()
                        For i = 0 To number_of_parameter - 1
                            .AddWithValue(param_name(i), param_values(i))
                        Next
                    End With
                    adp = New SqlClient.SqlDataAdapter(cmd)
                    Using dt
                        dt = New DataTable
                        adp.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            Return True
                            Exit Function
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function

    Sub DoubleBufferedControl(ByVal obj As Object)
        Dim type As Type = obj.GetType
        Dim pi As System.Reflection.PropertyInfo = type.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
        pi.SetValue(obj, True, Nothing)
    End Sub

    Function is_Empty(ByVal txtbox As String)
        If txtbox = "" Then
            Return True


        ElseIf txtbox <> "" Then
            If txtbox.Trim = "" Then
                MsgBox("Textbox only contains space characters!", vbExclamation)
                Return True
            Else
                Return False
            End If

        Else
            Return False

        End If



    End Function





    Public Sub fill_cmb(ByVal cmb As ComboBox)

        connect()
        sql = "Select * from tbl_departments where department <> 'ALL'"
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then
            For x = 0 To ds.Tables("a").Rows.Count - 1
                With ds.Tables("a")
                    cmb.Items.Add(.Rows(x).Item("department").ToString)

                End With
            Next
        End If
    End Sub


    ' record audit trail
    Public Sub recordAction(date_today As String, time_now As String, username As String, userlevel As String, action As String)
        connect()
        sql = "INSERT INTO tbl_audittrail (date, time, username, userlevel, action) VALUES (@date, @time, @uname, @ulvl, @action)"
        cmd = New SqlCommand(sql, con)

        cmd.Parameters.AddWithValue("@date", date_today)
        cmd.Parameters.AddWithValue("@time", time_now)
        cmd.Parameters.AddWithValue("@uname", username)
        cmd.Parameters.AddWithValue("@ulvl", userlevel)


        cmd.Parameters.AddWithValue("@action", action)

        Try
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Function has_ContainsSpecialChars(str As String) As Boolean
        Return str.IndexOfAny("[~`!@#$%^&*()-+=|{}':;.,<>/?]".ToCharArray) <> -1
    End Function

    Function is_lettersOnly(s As String) As Boolean
        Return s.Any(Function(c) Not (Char.IsLetter(c) OrElse Char.IsWhiteSpace(c)))
    End Function

    Function is_digitsOnly(s As String) As Boolean
        Return s.Any(Function(c) Not (Char.IsDigit(c)))
    End Function

End Module