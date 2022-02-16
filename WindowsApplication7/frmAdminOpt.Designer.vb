<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminOpt
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.cmb_type = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txt_address = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txt_name = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.txt_contact = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.tbl_id = New MetroFramework.Controls.MetroLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.MetroButton1)
        Me.Panel1.Location = New System.Drawing.Point(4, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1013, 53)
        Me.Panel1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 30)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Operator Profile"
        '
        'MetroButton1
        '
        Me.MetroButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.MetroButton1.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.MetroButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MetroButton1.Location = New System.Drawing.Point(722, 2)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(151, 48)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroButton1.TabIndex = 25
        Me.MetroButton1.Text = "Close"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseCustomBackColor = True
        Me.MetroButton1.UseCustomForeColor = True
        Me.MetroButton1.UseSelectable = True
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Location = New System.Drawing.Point(0, 53)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(1013, 841)
        Me.MetroTabControl1.TabIndex = 8
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.cmb_type)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel4)
        Me.MetroTabPage1.Controls.Add(Me.txt_address)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel3)
        Me.MetroTabPage1.Controls.Add(Me.txt_name)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel6)
        Me.MetroTabPage1.Controls.Add(Me.txt_contact)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel2)
        Me.MetroTabPage1.Controls.Add(Me.btnSave)
        Me.MetroTabPage1.Controls.Add(Me.tbl_id)
        Me.MetroTabPage1.Controls.Add(Me.Label2)
        Me.MetroTabPage1.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(1005, 799)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Manage Operator"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'cmb_type
        '
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.ItemHeight = 23
        Me.cmb_type.Location = New System.Drawing.Point(447, 142)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(187, 29)
        Me.cmb_type.TabIndex = 110
        Me.cmb_type.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(304, 144)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(83, 19)
        Me.MetroLabel4.TabIndex = 109
        Me.MetroLabel4.Text = "Vehicle Type:"
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
        Me.txt_address.Location = New System.Drawing.Point(447, 228)
        Me.txt_address.MaxLength = 49
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_address.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_address.SelectedText = ""
        Me.txt_address.SelectionLength = 0
        Me.txt_address.SelectionStart = 0
        Me.txt_address.Size = New System.Drawing.Size(187, 83)
        Me.txt_address.TabIndex = 108
        Me.txt_address.UseCustomBackColor = True
        Me.txt_address.UseSelectable = True
        Me.txt_address.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_address.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(308, 228)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel3.TabIndex = 107
        Me.MetroLabel3.Text = "Address:"
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
        Me.txt_name.Location = New System.Drawing.Point(447, 99)
        Me.txt_name.MaxLength = 49
        Me.txt_name.Multiline = True
        Me.txt_name.Name = "txt_name"
        Me.txt_name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_name.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_name.SelectedText = ""
        Me.txt_name.SelectionLength = 0
        Me.txt_name.SelectionStart = 0
        Me.txt_name.Size = New System.Drawing.Size(187, 31)
        Me.txt_name.TabIndex = 106
        Me.txt_name.UseCustomBackColor = True
        Me.txt_name.UseSelectable = True
        Me.txt_name.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_name.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(304, 99)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(104, 19)
        Me.MetroLabel6.TabIndex = 105
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
        Me.txt_contact.Location = New System.Drawing.Point(447, 183)
        Me.txt_contact.MaxLength = 11
        Me.txt_contact.Multiline = True
        Me.txt_contact.Name = "txt_contact"
        Me.txt_contact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_contact.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_contact.SelectedText = ""
        Me.txt_contact.SelectionLength = 0
        Me.txt_contact.SelectionStart = 0
        Me.txt_contact.Size = New System.Drawing.Size(187, 31)
        Me.txt_contact.TabIndex = 104
        Me.txt_contact.UseCustomBackColor = True
        Me.txt_contact.UseSelectable = True
        Me.txt_contact.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_contact.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(308, 183)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(79, 19)
        Me.MetroLabel2.TabIndex = 103
        Me.MetroLabel2.Text = "Contact no.:"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSave.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSave.Location = New System.Drawing.Point(558, 335)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnSave.TabIndex = 100
        Me.btnSave.Text = "Save"
        Me.btnSave.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSave.UseCustomBackColor = True
        Me.btnSave.UseCustomForeColor = True
        Me.btnSave.UseSelectable = True
        '
        'tbl_id
        '
        Me.tbl_id.AutoSize = True
        Me.tbl_id.Location = New System.Drawing.Point(617, 36)
        Me.tbl_id.Name = "tbl_id"
        Me.tbl_id.Size = New System.Drawing.Size(16, 19)
        Me.tbl_id.TabIndex = 58
        Me.tbl_id.Text = "0"
        Me.tbl_id.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(303, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 30)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Operator information"
        '
        'frmAdminOpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(997, 473)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAdminOpt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmAdminOpt"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tbl_id As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_type As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_address As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_name As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_contact As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
End Class
