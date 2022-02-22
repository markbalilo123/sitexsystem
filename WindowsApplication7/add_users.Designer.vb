<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class add_users
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txt_fname = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txt_pass2 = New MetroFramework.Controls.MetroTextBox()
        Me.cmb_userlevel = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txt_pass = New MetroFramework.Controls.MetroTextBox()
        Me.txt_user = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.btnUpdate = New MetroFramework.Controls.MetroButton()
        Me.btnCancel = New MetroFramework.Controls.MetroButton()
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_title = New MetroFramework.Controls.MetroLabel()
        Me.lbl_id = New MetroFramework.Controls.MetroLabel()
        Me.txt_userlevelid = New MetroFramework.Controls.MetroLabel()
        Me.tx_userlevel = New MetroFramework.Controls.MetroLabel()
        Me.txt_userlvlid = New MetroFramework.Controls.MetroLabel()
        Me.cmb_opt = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_fname
        '
        Me.txt_fname.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txt_fname.CustomButton.Image = Nothing
        Me.txt_fname.CustomButton.Location = New System.Drawing.Point(157, 1)
        Me.txt_fname.CustomButton.Name = ""
        Me.txt_fname.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.txt_fname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_fname.CustomButton.TabIndex = 1
        Me.txt_fname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_fname.CustomButton.UseSelectable = True
        Me.txt_fname.CustomButton.Visible = False
        Me.txt_fname.Lines = New String(-1) {}
        Me.txt_fname.Location = New System.Drawing.Point(215, 143)
        Me.txt_fname.MaxLength = 49
        Me.txt_fname.Multiline = True
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_fname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_fname.SelectedText = ""
        Me.txt_fname.SelectionLength = 0
        Me.txt_fname.SelectionStart = 0
        Me.txt_fname.Size = New System.Drawing.Size(187, 31)
        Me.txt_fname.TabIndex = 76
        Me.txt_fname.UseCustomBackColor = True
        Me.txt_fname.UseSelectable = True
        Me.txt_fname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_fname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(118, 143)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(65, 19)
        Me.MetroLabel6.TabIndex = 75
        Me.MetroLabel6.Text = "Fullname:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(91, 285)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(118, 19)
        Me.MetroLabel4.TabIndex = 74
        Me.MetroLabel4.Text = "Confirm Password:"
        '
        'txt_pass2
        '
        Me.txt_pass2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txt_pass2.CustomButton.Image = Nothing
        Me.txt_pass2.CustomButton.Location = New System.Drawing.Point(157, 1)
        Me.txt_pass2.CustomButton.Name = ""
        Me.txt_pass2.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.txt_pass2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_pass2.CustomButton.TabIndex = 1
        Me.txt_pass2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_pass2.CustomButton.UseSelectable = True
        Me.txt_pass2.CustomButton.Visible = False
        Me.txt_pass2.Lines = New String(-1) {}
        Me.txt_pass2.Location = New System.Drawing.Point(215, 285)
        Me.txt_pass2.MaxLength = 49
        Me.txt_pass2.Multiline = True
        Me.txt_pass2.Name = "txt_pass2"
        Me.txt_pass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_pass2.SelectedText = ""
        Me.txt_pass2.SelectionLength = 0
        Me.txt_pass2.SelectionStart = 0
        Me.txt_pass2.Size = New System.Drawing.Size(187, 31)
        Me.txt_pass2.TabIndex = 73
        Me.txt_pass2.UseCustomBackColor = True
        Me.txt_pass2.UseSelectable = True
        Me.txt_pass2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_pass2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cmb_userlevel
        '
        Me.cmb_userlevel.FormattingEnabled = True
        Me.cmb_userlevel.ItemHeight = 23
        Me.cmb_userlevel.Items.AddRange(New Object() {"ADMIN", "STAFF"})
        Me.cmb_userlevel.Location = New System.Drawing.Point(215, 53)
        Me.cmb_userlevel.Name = "cmb_userlevel"
        Me.cmb_userlevel.Size = New System.Drawing.Size(187, 29)
        Me.cmb_userlevel.TabIndex = 72
        Me.cmb_userlevel.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(118, 240)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel3.TabIndex = 71
        Me.MetroLabel3.Text = "Password:"
        '
        'txt_pass
        '
        Me.txt_pass.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txt_pass.CustomButton.Image = Nothing
        Me.txt_pass.CustomButton.Location = New System.Drawing.Point(157, 1)
        Me.txt_pass.CustomButton.Name = ""
        Me.txt_pass.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.txt_pass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_pass.CustomButton.TabIndex = 1
        Me.txt_pass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_pass.CustomButton.UseSelectable = True
        Me.txt_pass.CustomButton.Visible = False
        Me.txt_pass.Lines = New String(-1) {}
        Me.txt_pass.Location = New System.Drawing.Point(215, 240)
        Me.txt_pass.MaxLength = 49
        Me.txt_pass.Multiline = True
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_pass.SelectedText = ""
        Me.txt_pass.SelectionLength = 0
        Me.txt_pass.SelectionStart = 0
        Me.txt_pass.Size = New System.Drawing.Size(187, 31)
        Me.txt_pass.TabIndex = 70
        Me.txt_pass.UseCustomBackColor = True
        Me.txt_pass.UseSelectable = True
        Me.txt_pass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_pass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_user
        '
        Me.txt_user.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txt_user.CustomButton.Image = Nothing
        Me.txt_user.CustomButton.Location = New System.Drawing.Point(157, 1)
        Me.txt_user.CustomButton.Name = ""
        Me.txt_user.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.txt_user.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_user.CustomButton.TabIndex = 1
        Me.txt_user.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_user.CustomButton.UseSelectable = True
        Me.txt_user.CustomButton.Visible = False
        Me.txt_user.Lines = New String(-1) {}
        Me.txt_user.Location = New System.Drawing.Point(215, 190)
        Me.txt_user.MaxLength = 49
        Me.txt_user.Multiline = True
        Me.txt_user.Name = "txt_user"
        Me.txt_user.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_user.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_user.SelectedText = ""
        Me.txt_user.SelectionLength = 0
        Me.txt_user.SelectionStart = 0
        Me.txt_user.Size = New System.Drawing.Size(187, 31)
        Me.txt_user.TabIndex = 69
        Me.txt_user.UseCustomBackColor = True
        Me.txt_user.UseSelectable = True
        Me.txt_user.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_user.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(118, 190)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel2.TabIndex = 68
        Me.MetroLabel2.Text = "Username:"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnUpdate.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUpdate.Location = New System.Drawing.Point(225, 345)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnUpdate.TabIndex = 67
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnUpdate.UseCustomBackColor = True
        Me.btnUpdate.UseCustomForeColor = True
        Me.btnUpdate.UseSelectable = True
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnCancel.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancel.Location = New System.Drawing.Point(144, 345)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnCancel.TabIndex = 66
        Me.btnCancel.Text = "Back"
        Me.btnCancel.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnCancel.UseCustomBackColor = True
        Me.btnCancel.UseCustomForeColor = True
        Me.btnCancel.UseSelectable = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSave.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSave.Location = New System.Drawing.Point(306, 345)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnSave.TabIndex = 65
        Me.btnSave.Text = "Save"
        Me.btnSave.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSave.UseCustomBackColor = True
        Me.btnSave.UseCustomForeColor = True
        Me.btnSave.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(119, 53)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(64, 19)
        Me.MetroLabel5.TabIndex = 64
        Me.MetroLabel5.Text = "Userlevel:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_title)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(522, 37)
        Me.Panel1.TabIndex = 80
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lbl_title.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_title.Location = New System.Drawing.Point(0, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(75, 19)
        Me.lbl_title.TabIndex = 27
        Me.lbl_title.Text = "Add users"
        Me.lbl_title.UseCustomBackColor = True
        Me.lbl_title.UseCustomForeColor = True
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(463, 40)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(16, 19)
        Me.lbl_id.TabIndex = 81
        Me.lbl_id.Text = "0"
        Me.lbl_id.Visible = False
        '
        'txt_userlevelid
        '
        Me.txt_userlevelid.AutoSize = True
        Me.txt_userlevelid.Location = New System.Drawing.Point(463, 100)
        Me.txt_userlevelid.Name = "txt_userlevelid"
        Me.txt_userlevelid.Size = New System.Drawing.Size(16, 19)
        Me.txt_userlevelid.TabIndex = 82
        Me.txt_userlevelid.Text = "0"
        Me.txt_userlevelid.Visible = False
        '
        'tx_userlevel
        '
        Me.tx_userlevel.AutoSize = True
        Me.tx_userlevel.Location = New System.Drawing.Point(463, 166)
        Me.tx_userlevel.Name = "tx_userlevel"
        Me.tx_userlevel.Size = New System.Drawing.Size(16, 19)
        Me.tx_userlevel.TabIndex = 83
        Me.tx_userlevel.Text = "0"
        Me.tx_userlevel.Visible = False
        '
        'txt_userlvlid
        '
        Me.txt_userlvlid.AutoSize = True
        Me.txt_userlvlid.Location = New System.Drawing.Point(463, 219)
        Me.txt_userlvlid.Name = "txt_userlvlid"
        Me.txt_userlvlid.Size = New System.Drawing.Size(16, 19)
        Me.txt_userlvlid.TabIndex = 84
        Me.txt_userlvlid.Text = "0"
        Me.txt_userlvlid.Visible = False
        '
        'cmb_opt
        '
        Me.cmb_opt.FormattingEnabled = True
        Me.cmb_opt.ItemHeight = 23
        Me.cmb_opt.Location = New System.Drawing.Point(215, 98)
        Me.cmb_opt.Name = "cmb_opt"
        Me.cmb_opt.Size = New System.Drawing.Size(187, 29)
        Me.cmb_opt.TabIndex = 86
        Me.cmb_opt.UseSelectable = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(119, 98)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(68, 19)
        Me.MetroLabel7.TabIndex = 85
        Me.MetroLabel7.Text = "Operator:"
        '
        'add_users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(522, 382)
        Me.Controls.Add(Me.cmb_opt)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.txt_userlvlid)
        Me.Controls.Add(Me.tx_userlevel)
        Me.Controls.Add(Me.txt_userlevelid)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_fname)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.txt_pass2)
        Me.Controls.Add(Me.cmb_userlevel)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.MetroLabel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "add_users"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "add_users"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_fname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_pass2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cmb_userlevel As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_pass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_user As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnUpdate As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_title As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_id As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_userlevelid As MetroFramework.Controls.MetroLabel
    Friend WithEvents tx_userlevel As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_userlvlid As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmb_opt As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
End Class
