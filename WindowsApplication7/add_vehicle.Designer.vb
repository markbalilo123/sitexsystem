<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_vehicle
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
        Me.cmb_opt = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_id = New MetroFramework.Controls.MetroLabel()
        Me.txt_plate = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.txt_yr = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.btnUpdate = New MetroFramework.Controls.MetroButton()
        Me.btnCancel = New MetroFramework.Controls.MetroButton()
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.txt_dealer = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
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
        Me.Panel1.TabIndex = 82
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MetroLabel1.Location = New System.Drawing.Point(0, 9)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(88, 19)
        Me.MetroLabel1.TabIndex = 27
        Me.MetroLabel1.Text = "Add vehicle"
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'cmb_opt
        '
        Me.cmb_opt.FormattingEnabled = True
        Me.cmb_opt.ItemHeight = 23
        Me.cmb_opt.Location = New System.Drawing.Point(198, 65)
        Me.cmb_opt.Name = "cmb_opt"
        Me.cmb_opt.Size = New System.Drawing.Size(187, 29)
        Me.cmb_opt.TabIndex = 111
        Me.cmb_opt.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(98, 67)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(68, 19)
        Me.MetroLabel4.TabIndex = 110
        Me.MetroLabel4.Text = "Operator:"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(480, 47)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(16, 19)
        Me.lbl_id.TabIndex = 107
        Me.lbl_id.Text = "0"
        '
        'txt_plate
        '
        Me.txt_plate.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txt_plate.CustomButton.Image = Nothing
        Me.txt_plate.CustomButton.Location = New System.Drawing.Point(157, 1)
        Me.txt_plate.CustomButton.Name = ""
        Me.txt_plate.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.txt_plate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_plate.CustomButton.TabIndex = 1
        Me.txt_plate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_plate.CustomButton.UseSelectable = True
        Me.txt_plate.CustomButton.Visible = False
        Me.txt_plate.Lines = New String(-1) {}
        Me.txt_plate.Location = New System.Drawing.Point(198, 111)
        Me.txt_plate.MaxLength = 49
        Me.txt_plate.Multiline = True
        Me.txt_plate.Name = "txt_plate"
        Me.txt_plate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_plate.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_plate.SelectedText = ""
        Me.txt_plate.SelectionLength = 0
        Me.txt_plate.SelectionStart = 0
        Me.txt_plate.Size = New System.Drawing.Size(187, 31)
        Me.txt_plate.TabIndex = 106
        Me.txt_plate.UseCustomBackColor = True
        Me.txt_plate.UseSelectable = True
        Me.txt_plate.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_plate.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(98, 111)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(60, 19)
        Me.MetroLabel6.TabIndex = 105
        Me.MetroLabel6.Text = "Plate no:"
        '
        'txt_yr
        '
        Me.txt_yr.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txt_yr.CustomButton.Image = Nothing
        Me.txt_yr.CustomButton.Location = New System.Drawing.Point(157, 1)
        Me.txt_yr.CustomButton.Name = ""
        Me.txt_yr.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.txt_yr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_yr.CustomButton.TabIndex = 1
        Me.txt_yr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_yr.CustomButton.UseSelectable = True
        Me.txt_yr.CustomButton.Visible = False
        Me.txt_yr.Lines = New String(-1) {}
        Me.txt_yr.Location = New System.Drawing.Point(198, 162)
        Me.txt_yr.MaxLength = 11
        Me.txt_yr.Multiline = True
        Me.txt_yr.Name = "txt_yr"
        Me.txt_yr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_yr.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_yr.SelectedText = ""
        Me.txt_yr.SelectionLength = 0
        Me.txt_yr.SelectionStart = 0
        Me.txt_yr.Size = New System.Drawing.Size(187, 31)
        Me.txt_yr.TabIndex = 104
        Me.txt_yr.UseCustomBackColor = True
        Me.txt_yr.UseSelectable = True
        Me.txt_yr.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_yr.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(98, 162)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(79, 19)
        Me.MetroLabel2.TabIndex = 103
        Me.MetroLabel2.Text = "Year model:"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnUpdate.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUpdate.Location = New System.Drawing.Point(229, 285)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnUpdate.TabIndex = 102
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
        Me.btnCancel.Location = New System.Drawing.Point(148, 285)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnCancel.TabIndex = 101
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
        Me.btnSave.Location = New System.Drawing.Point(310, 285)
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
        'txt_dealer
        '
        Me.txt_dealer.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txt_dealer.CustomButton.Image = Nothing
        Me.txt_dealer.CustomButton.Location = New System.Drawing.Point(157, 1)
        Me.txt_dealer.CustomButton.Name = ""
        Me.txt_dealer.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.txt_dealer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_dealer.CustomButton.TabIndex = 1
        Me.txt_dealer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_dealer.CustomButton.UseSelectable = True
        Me.txt_dealer.CustomButton.Visible = False
        Me.txt_dealer.Lines = New String(-1) {}
        Me.txt_dealer.Location = New System.Drawing.Point(198, 209)
        Me.txt_dealer.MaxLength = 11
        Me.txt_dealer.Multiline = True
        Me.txt_dealer.Name = "txt_dealer"
        Me.txt_dealer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_dealer.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_dealer.SelectedText = ""
        Me.txt_dealer.SelectionLength = 0
        Me.txt_dealer.SelectionStart = 0
        Me.txt_dealer.Size = New System.Drawing.Size(187, 31)
        Me.txt_dealer.TabIndex = 113
        Me.txt_dealer.UseCustomBackColor = True
        Me.txt_dealer.UseSelectable = True
        Me.txt_dealer.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_dealer.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(98, 209)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel3.TabIndex = 112
        Me.MetroLabel3.Text = "Dealer:"
        '
        'add_vehicle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(506, 334)
        Me.Controls.Add(Me.txt_dealer)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.cmb_opt)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.txt_plate)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.txt_yr)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "add_vehicle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "add_vehicle"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmb_opt As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_id As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_plate As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_yr As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnUpdate As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents txt_dealer As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
End Class
