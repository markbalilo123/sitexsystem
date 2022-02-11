<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_terminal
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
        Me.btnUpdate = New MetroFramework.Controls.MetroButton()
        Me.btnCancel = New MetroFramework.Controls.MetroButton()
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.cmb_operator = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.txt_terminal = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_id = New MetroFramework.Controls.MetroLabel()
        Me.txt_start = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txt_dest = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnUpdate.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUpdate.Location = New System.Drawing.Point(163, 275)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnUpdate.TabIndex = 107
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
        Me.btnCancel.Location = New System.Drawing.Point(82, 275)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnCancel.TabIndex = 106
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
        Me.btnSave.Location = New System.Drawing.Point(244, 275)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnSave.TabIndex = 105
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
        Me.Panel1.Size = New System.Drawing.Size(405, 37)
        Me.Panel1.TabIndex = 104
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MetroLabel1.Location = New System.Drawing.Point(0, 9)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(97, 19)
        Me.MetroLabel1.TabIndex = 27
        Me.MetroLabel1.Text = "Add terminal"
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'cmb_operator
        '
        Me.cmb_operator.FormattingEnabled = True
        Me.cmb_operator.ItemHeight = 23
        Me.cmb_operator.Location = New System.Drawing.Point(161, 71)
        Me.cmb_operator.Name = "cmb_operator"
        Me.cmb_operator.Size = New System.Drawing.Size(187, 29)
        Me.cmb_operator.TabIndex = 118
        Me.cmb_operator.UseSelectable = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(61, 73)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(68, 19)
        Me.MetroLabel7.TabIndex = 117
        Me.MetroLabel7.Text = "Operator:"
        '
        'txt_terminal
        '
        Me.txt_terminal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txt_terminal.CustomButton.Image = Nothing
        Me.txt_terminal.CustomButton.Location = New System.Drawing.Point(157, 1)
        Me.txt_terminal.CustomButton.Name = ""
        Me.txt_terminal.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.txt_terminal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_terminal.CustomButton.TabIndex = 1
        Me.txt_terminal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_terminal.CustomButton.UseSelectable = True
        Me.txt_terminal.CustomButton.Visible = False
        Me.txt_terminal.Lines = New String(-1) {}
        Me.txt_terminal.Location = New System.Drawing.Point(161, 112)
        Me.txt_terminal.MaxLength = 49
        Me.txt_terminal.Multiline = True
        Me.txt_terminal.Name = "txt_terminal"
        Me.txt_terminal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_terminal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_terminal.SelectedText = ""
        Me.txt_terminal.SelectionLength = 0
        Me.txt_terminal.SelectionStart = 0
        Me.txt_terminal.Size = New System.Drawing.Size(187, 31)
        Me.txt_terminal.TabIndex = 120
        Me.txt_terminal.UseCustomBackColor = True
        Me.txt_terminal.UseSelectable = True
        Me.txt_terminal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_terminal.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(61, 112)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(98, 19)
        Me.MetroLabel6.TabIndex = 119
        Me.MetroLabel6.Text = "Terminal name:"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.ForeColor = System.Drawing.Color.Red
        Me.lbl_id.Location = New System.Drawing.Point(377, 40)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(16, 19)
        Me.lbl_id.TabIndex = 121
        Me.lbl_id.Text = "0"
        '
        'txt_start
        '
        Me.txt_start.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txt_start.CustomButton.Image = Nothing
        Me.txt_start.CustomButton.Location = New System.Drawing.Point(157, 1)
        Me.txt_start.CustomButton.Name = ""
        Me.txt_start.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.txt_start.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_start.CustomButton.TabIndex = 1
        Me.txt_start.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_start.CustomButton.UseSelectable = True
        Me.txt_start.CustomButton.Visible = False
        Me.txt_start.Lines = New String(-1) {}
        Me.txt_start.Location = New System.Drawing.Point(161, 156)
        Me.txt_start.MaxLength = 49
        Me.txt_start.Multiline = True
        Me.txt_start.Name = "txt_start"
        Me.txt_start.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_start.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_start.SelectedText = ""
        Me.txt_start.SelectionLength = 0
        Me.txt_start.SelectionStart = 0
        Me.txt_start.Size = New System.Drawing.Size(187, 31)
        Me.txt_start.TabIndex = 123
        Me.txt_start.UseCustomBackColor = True
        Me.txt_start.UseSelectable = True
        Me.txt_start.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_start.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(59, 156)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(74, 19)
        Me.MetroLabel2.TabIndex = 122
        Me.MetroLabel2.Text = "Start point:"
        '
        'txt_dest
        '
        Me.txt_dest.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txt_dest.CustomButton.Image = Nothing
        Me.txt_dest.CustomButton.Location = New System.Drawing.Point(157, 1)
        Me.txt_dest.CustomButton.Name = ""
        Me.txt_dest.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.txt_dest.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_dest.CustomButton.TabIndex = 1
        Me.txt_dest.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_dest.CustomButton.UseSelectable = True
        Me.txt_dest.CustomButton.Visible = False
        Me.txt_dest.Lines = New String(-1) {}
        Me.txt_dest.Location = New System.Drawing.Point(161, 200)
        Me.txt_dest.MaxLength = 49
        Me.txt_dest.Multiline = True
        Me.txt_dest.Name = "txt_dest"
        Me.txt_dest.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_dest.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_dest.SelectedText = ""
        Me.txt_dest.SelectionLength = 0
        Me.txt_dest.SelectionStart = 0
        Me.txt_dest.Size = New System.Drawing.Size(187, 31)
        Me.txt_dest.TabIndex = 125
        Me.txt_dest.UseCustomBackColor = True
        Me.txt_dest.UseSelectable = True
        Me.txt_dest.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_dest.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(59, 200)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(76, 19)
        Me.MetroLabel3.TabIndex = 124
        Me.MetroLabel3.Text = "Destination:"
        '
        'add_terminal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(405, 331)
        Me.Controls.Add(Me.txt_dest)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.txt_start)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.txt_terminal)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.cmb_operator)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "add_terminal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "add_terminal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUpdate As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmb_operator As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_terminal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_id As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_start As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_dest As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
End Class
