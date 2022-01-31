<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_operator
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txt_name = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.txt_contact = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.btnUpdate = New MetroFramework.Controls.MetroButton()
        Me.btnCancel = New MetroFramework.Controls.MetroButton()
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.lbl_id = New MetroFramework.Controls.MetroLabel()
        Me.txt_address = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.cmb_type = New MetroFramework.Controls.MetroComboBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MetroLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(506, 37)
        Me.Panel1.TabIndex = 81
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MetroLabel1.Location = New System.Drawing.Point(0, 9)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(101, 19)
        Me.MetroLabel1.TabIndex = 27
        Me.MetroLabel1.Text = "Add operator"
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txt_name.CustomButton.Image = Nothing
        Me.txt_name.CustomButton.Location = New System.Drawing.Point(157, 1)
        Me.txt_name.CustomButton.Name = ""
        Me.txt_name.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.txt_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_name.CustomButton.TabIndex = 1
        Me.txt_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_name.CustomButton.UseSelectable = True
        Me.txt_name.CustomButton.Visible = False
        Me.txt_name.Lines = New String(-1) {}
        Me.txt_name.Location = New System.Drawing.Point(196, 80)
        Me.txt_name.MaxLength = 49
        Me.txt_name.Multiline = True
        Me.txt_name.Name = "txt_name"
        Me.txt_name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_name.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_name.SelectedText = ""
        Me.txt_name.SelectionLength = 0
        Me.txt_name.SelectionStart = 0
        Me.txt_name.Size = New System.Drawing.Size(187, 31)
        Me.txt_name.TabIndex = 94
        Me.txt_name.UseCustomBackColor = True
        Me.txt_name.UseSelectable = True
        Me.txt_name.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_name.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(96, 80)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(104, 19)
        Me.MetroLabel6.TabIndex = 93
        Me.MetroLabel6.Text = "Operator name:"
        '
        'txt_contact
        '
        Me.txt_contact.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txt_contact.CustomButton.Image = Nothing
        Me.txt_contact.CustomButton.Location = New System.Drawing.Point(157, 1)
        Me.txt_contact.CustomButton.Name = ""
        Me.txt_contact.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.txt_contact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_contact.CustomButton.TabIndex = 1
        Me.txt_contact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_contact.CustomButton.UseSelectable = True
        Me.txt_contact.CustomButton.Visible = False
        Me.txt_contact.Lines = New String(-1) {}
        Me.txt_contact.Location = New System.Drawing.Point(196, 164)
        Me.txt_contact.MaxLength = 11
        Me.txt_contact.Multiline = True
        Me.txt_contact.Name = "txt_contact"
        Me.txt_contact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_contact.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_contact.SelectedText = ""
        Me.txt_contact.SelectionLength = 0
        Me.txt_contact.SelectionStart = 0
        Me.txt_contact.Size = New System.Drawing.Size(187, 31)
        Me.txt_contact.TabIndex = 87
        Me.txt_contact.UseCustomBackColor = True
        Me.txt_contact.UseSelectable = True
        Me.txt_contact.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_contact.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(96, 164)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(79, 19)
        Me.MetroLabel2.TabIndex = 86
        Me.MetroLabel2.Text = "Contact no.:"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnUpdate.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUpdate.Location = New System.Drawing.Point(210, 354)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnUpdate.TabIndex = 85
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
        Me.btnCancel.Location = New System.Drawing.Point(129, 354)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnCancel.TabIndex = 84
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
        Me.btnSave.Location = New System.Drawing.Point(291, 354)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnSave.TabIndex = 83
        Me.btnSave.Text = "Save"
        Me.btnSave.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSave.UseCustomBackColor = True
        Me.btnSave.UseCustomForeColor = True
        Me.btnSave.UseSelectable = True
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(478, 49)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(16, 19)
        Me.lbl_id.TabIndex = 95
        Me.lbl_id.Text = "0"
        '
        'txt_address
        '
        Me.txt_address.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txt_address.CustomButton.Image = Nothing
        Me.txt_address.CustomButton.Location = New System.Drawing.Point(105, 1)
        Me.txt_address.CustomButton.Name = ""
        Me.txt_address.CustomButton.Size = New System.Drawing.Size(81, 81)
        Me.txt_address.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_address.CustomButton.TabIndex = 1
        Me.txt_address.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_address.CustomButton.UseSelectable = True
        Me.txt_address.CustomButton.Visible = False
        Me.txt_address.Lines = New String(-1) {}
        Me.txt_address.Location = New System.Drawing.Point(196, 218)
        Me.txt_address.MaxLength = 49
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_address.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_address.SelectedText = ""
        Me.txt_address.SelectionLength = 0
        Me.txt_address.SelectionStart = 0
        Me.txt_address.Size = New System.Drawing.Size(187, 83)
        Me.txt_address.TabIndex = 97
        Me.txt_address.UseCustomBackColor = True
        Me.txt_address.UseSelectable = True
        Me.txt_address.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_address.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(96, 218)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel3.TabIndex = 96
        Me.MetroLabel3.Text = "Address:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(96, 125)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(83, 19)
        Me.MetroLabel4.TabIndex = 98
        Me.MetroLabel4.Text = "Vehicle Type:"
        '
        'cmb_type
        '
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.ItemHeight = 23
        Me.cmb_type.Location = New System.Drawing.Point(196, 123)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(187, 29)
        Me.cmb_type.TabIndex = 99
        Me.cmb_type.UseSelectable = True
        '
        'add_operator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(506, 388)
        Me.Controls.Add(Me.cmb_type)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.txt_contact)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "add_operator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "add"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_name As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_contact As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnUpdate As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents lbl_id As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_address As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmb_type As MetroFramework.Controls.MetroComboBox
End Class
