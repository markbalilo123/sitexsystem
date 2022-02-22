Imports System.Data.SqlClient
Imports System.IO

Public Class frm_kiosk_about

    Public time_now As String = TimeOfDay.ToString("h:mm:ss tt")
    Public date_today As String = DateTime.Now.ToString("yyyy/MM/dd")

    Sub load_sysinfo()
        connect()
        sql = "Select * from tbl_systeminfo"
        adp = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adp.Fill(ds, "a")
        If ds.Tables("a").Rows.Count > 0 Then
            For x = 0 To ds.Tables("a").Rows.Count - 1
                With ds.Tables("a")

                    '    tbl_id.Text = .Rows(x).Item("id").ToString
                    txt_sysname.Text = .Rows(x).Item("system_name").ToString
                    txt_name.Text = .Rows(x).Item("company_name").ToString
                    txt_contact.Text = .Rows(x).Item("contact_no").ToString
                    txt_address.Text = .Rows(x).Item("address").ToString



                End With
            Next
        End If
    End Sub

    Private Sub frm_kiosk_about_Load(sender As Object, e As EventArgs) Handles Me.Load
        load_sysinfo()
    End Sub
End Class