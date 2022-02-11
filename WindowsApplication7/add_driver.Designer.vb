<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_driver
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_address = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_id = New MetroFramework.Controls.MetroLabel()
        Me.txt_lname = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.txt_contact = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.btnUpdate = New MetroFramework.Controls.MetroButton()
        Me.btnCancel = New MetroFramework.Controls.MetroButton()
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txt_licno = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.cmb_operator = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.txt_fname = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txt_mname = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_address
        '
        Me.txt_address.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txt_address.CustomButton.Image = Nothing
        Me.txt_address.CustomButton.Location = New System.Drawing.Point(318, 2)
        Me.txt_address.CustomButton.Name = ""
        Me.txt_address.CustomButton.Size = New System.Drawing.Size(93, 93)
        Me.txt_address.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_address.CustomButton.TabIndex = 1
        Me.txt_address.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_address.CustomButton.UseSelectable = True
        Me.txt_address.CustomButton.Visible = False
        Me.txt_address.Lines = New String(-1) {}
        Me.txt_address.Location = New System.Drawing.Point(145, 225)
        Me.txt_address.MaxLength = 49
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_address.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_address.SelectedText = ""
        Me.txt_address.SelectionLength = 0
        Me.txt_address.SelectionStart = 0
        Me.txt_address.Size = New System.Drawing.Size(414, 98)
        Me.txt_address.TabIndex = 110
        Me.txt_address.UseCustomBackColor = True
        Me.txt_address.UseSelectable = True
        Me.txt_address.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_address.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(45, 225)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel3.TabIndex = 109
        Me.MetroLabel3.Text = "Address:"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(29, 40)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(16, 19)
        Me.lbl_id.TabIndex = 108
        Me.lbl_id.Text = "0"
        Me.lbl_id.Visible = False
        '
        'txt_lname
        '
        Me.txt_lname.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txt_lname.CustomButton.Image = Nothing
        Me.txt_lname.CustomButton.Location = New System.Drawing.Point(106, 1)
        Me.txt_lname.CustomButton.Name = ""
        Me.txt_lname.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.txt_lname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_lname.CustomButton.TabIndex = 1
        Me.txt_lname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_lname.CustomButton.UseSelectable = True
        Me.txt_lname.CustomButton.Visible = False
        Me.txt_lname.Lines = New String(-1) {}
        Me.txt_lname.Location = New System.Drawing.Point(145, 123)
        Me.txt_lname.MaxLength = 49
        Me.txt_lname.Multiline = True
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_lname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_lname.SelectedText = ""
        Me.txt_lname.SelectionLength = 0
        Me.txt_lname.SelectionStart = 0
        Me.txt_lname.Size = New System.Drawing.Size(136, 31)
        Me.txt_lname.TabIndex = 107
        Me.txt_lname.UseCustomBackColor = True
        Me.txt_lname.UseSelectable = True
        Me.txt_lname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_lname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(45, 123)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel6.TabIndex = 106
        Me.MetroLabel6.Text = "Last name:"
        '
        'txt_contact
        '
        Me.txt_contact.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txt_contact.CustomButton.Image = Nothing
        Me.txt_contact.CustomButton.Location = New System.Drawing.Point(106, 1)
        Me.txt_contact.CustomButton.Name = ""
        Me.txt_contact.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.txt_contact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_contact.CustomButton.TabIndex = 1
        Me.txt_contact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_contact.CustomButton.UseSelectable = True
        Me.txt_contact.CustomButton.Visible = False
        Me.txt_contact.Lines = New String(-1) {}
        Me.txt_contact.Location = New System.Drawing.Point(423, 168)
        Me.txt_contact.MaxLength = 11
        Me.txt_contact.Multiline = True
        Me.txt_contact.Name = "txt_contact"
        Me.txt_contact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_contact.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_contact.SelectedText = ""
        Me.txt_contact.SelectionLength = 0
        Me.txt_contact.SelectionStart = 0
        Me.txt_contact.Size = New System.Drawing.Size(136, 31)
        Me.txt_contact.TabIndex = 105
        Me.txt_contact.UseCustomBackColor = True
        Me.txt_contact.UseSelectable = True
        Me.txt_contact.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_contact.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(323, 168)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(79, 19)
        Me.MetroLabel2.TabIndex = 104
        Me.MetroLabel2.Text = "Contact no.:"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnUpdate.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUpdate.Location = New System.Drawing.Point(270, 355)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnUpdate.TabIndex = 103
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
        Me.btnCancel.Location = New System.Drawing.Point(189, 355)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnCancel.TabIndex = 102
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
        Me.btnSave.Location = New System.Drawing.Point(351, 355)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnSave.TabIndex = 101
        Me.btnSave.Text = "Save"
        Me.btnSave.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSave.UseCustomBackColor = True
        Me.btnSave.UseCustomForeColor = True
        Me.btnSave.UseSelectable = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MetroLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(613, 37)
        Me.Panel1.TabIndex = 100
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MetroLabel1.Location = New System.Drawing.Point(0, 9)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(82, 19)
        Me.MetroLabel1.TabIndex = 27
        Me.MetroLabel1.Text = "Add driver"
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'txt_licno
        '
        Me.txt_licno.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txt_licno.CustomButton.Image = Nothing
        Me.txt_licno.CustomButton.Location = New System.Drawing.Point(106, 1)
        Me.txt_licno.CustomButton.Name = ""
        Me.txt_licno.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.txt_licno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_licno.CustomButton.TabIndex = 1
        Me.txt_licno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_licno.CustomButton.UseSelectable = True
        Me.txt_licno.CustomButton.Visible = False
        Me.txt_licno.Lines = New String(-1) {}
        Me.txt_licno.Location = New System.Drawing.Point(145, 79)
        Me.txt_licno.MaxLength = 11
        Me.txt_licno.Multiline = True
        Me.txt_licno.Name = "txt_licno"
        Me.txt_licno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_licno.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_licno.SelectedText = ""
        Me.txt_licno.SelectionLength = 0
        Me.txt_licno.SelectionStart = 0
        Me.txt_licno.Size = New System.Drawing.Size(136, 31)
        Me.txt_licno.TabIndex = 114
        Me.txt_licno.UseCustomBackColor = True
        Me.txt_licno.UseSelectable = True
        Me.txt_licno.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_licno.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(45, 79)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(75, 19)
        Me.MetroLabel5.TabIndex = 113
        Me.MetroLabel5.Text = "License no.:"
        '
        'cmb_operator
        '
        Me.cmb_operator.FormattingEnabled = True
        Me.cmb_operator.ItemHeight = 23
        Me.cmb_operator.Location = New System.Drawing.Point(423, 77)
        Me.cmb_operator.Name = "cmb_operator"
        Me.cmb_operator.Size = New System.Drawing.Size(136, 29)
        Me.cmb_operator.TabIndex = 116
        Me.cmb_operator.UseSelectable = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(323, 79)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(68, 19)
        Me.MetroLabel7.TabIndex = 115
        Me.MetroLabel7.Text = "Operator:"
        '
        'txt_fname
        '
        Me.txt_fname.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txt_fname.CustomButton.Image = Nothing
        Me.txt_fname.CustomButton.Location = New System.Drawing.Point(106, 1)
        Me.txt_fname.CustomButton.Name = ""
        Me.txt_fname.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.txt_fname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_fname.CustomButton.TabIndex = 1
        Me.txt_fname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_fname.CustomButton.UseSelectable = True
        Me.txt_fname.CustomButton.Visible = False
        Me.txt_fname.Lines = New String(-1) {}
        Me.txt_fname.Location = New System.Drawing.Point(423, 123)
        Me.txt_fname.MaxLength = 49
        Me.txt_fname.Multiline = True
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_fname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_fname.SelectedText = ""
        Me.txt_fname.SelectionLength = 0
        Me.txt_fname.SelectionStart = 0
        Me.txt_fname.Size = New System.Drawing.Size(136, 31)
        Me.txt_fname.TabIndex = 118
        Me.txt_fname.UseCustomBackColor = True
        Me.txt_fname.UseSelectable = True
        Me.txt_fname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_fname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(323, 123)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel4.TabIndex = 117
        Me.MetroLabel4.Text = "First name:"
        '
        'txt_mname
        '
        Me.txt_mname.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txt_mname.CustomButton.Image = Nothing
        Me.txt_mname.CustomButton.Location = New System.Drawing.Point(106, 1)
        Me.txt_mname.CustomButton.Name = ""
        Me.txt_mname.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.txt_mname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_mname.CustomButton.TabIndex = 1
        Me.txt_mname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_mname.CustomButton.UseSelectable = True
        Me.txt_mname.CustomButton.Visible = False
        Me.txt_mname.Lines = New String(-1) {}
        Me.txt_mname.Location = New System.Drawing.Point(145, 168)
        Me.txt_mname.MaxLength = 49
        Me.txt_mname.Multiline = True
        Me.txt_mname.Name = "txt_mname"
        Me.txt_mname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_mname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_mname.SelectedText = ""
        Me.txt_mname.SelectionLength = 0
        Me.txt_mname.SelectionStart = 0
        Me.txt_mname.Size = New System.Drawing.Size(136, 31)
        Me.txt_mname.TabIndex = 120
        Me.txt_mname.UseCustomBackColor = True
        Me.txt_mname.UseSelectable = True
        Me.txt_mname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_mname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(45, 168)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(90, 19)
        Me.MetroLabel8.TabIndex = 119
        Me.MetroLabel8.Text = "Middle name:"
        '
        'add_driver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(613, 397)
        Me.Controls.Add(Me.txt_mname)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.txt_fname)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.cmb_operator)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.txt_licno)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.txt_lname)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.txt_contact)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "add_driver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "add_driver"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_address As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_id As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_lname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_contact As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnUpdate As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_licno As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmb_operator As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_fname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_mname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
End Class
