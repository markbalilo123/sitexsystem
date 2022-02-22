<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_passenger
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
        Me.txt_passenger = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.btnCancel = New MetroFramework.Controls.MetroButton()
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.tbl_id = New MetroFramework.Controls.MetroLabel()
        Me.VehicleID = New MetroFramework.Controls.MetroLabel()
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
        Me.Panel1.Size = New System.Drawing.Size(362, 37)
        Me.Panel1.TabIndex = 102
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MetroLabel1.Location = New System.Drawing.Point(0, 9)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(109, 19)
        Me.MetroLabel1.TabIndex = 27
        Me.MetroLabel1.Text = "Add passenger"
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'txt_passenger
        '
        Me.txt_passenger.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txt_passenger.CustomButton.Image = Nothing
        Me.txt_passenger.CustomButton.Location = New System.Drawing.Point(157, 1)
        Me.txt_passenger.CustomButton.Name = ""
        Me.txt_passenger.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.txt_passenger.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_passenger.CustomButton.TabIndex = 1
        Me.txt_passenger.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_passenger.CustomButton.UseSelectable = True
        Me.txt_passenger.CustomButton.Visible = False
        Me.txt_passenger.Lines = New String(-1) {}
        Me.txt_passenger.Location = New System.Drawing.Point(87, 87)
        Me.txt_passenger.MaxLength = 49
        Me.txt_passenger.Multiline = True
        Me.txt_passenger.Name = "txt_passenger"
        Me.txt_passenger.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_passenger.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_passenger.SelectedText = ""
        Me.txt_passenger.SelectionLength = 0
        Me.txt_passenger.SelectionStart = 0
        Me.txt_passenger.Size = New System.Drawing.Size(187, 31)
        Me.txt_passenger.TabIndex = 1
        Me.txt_passenger.UseCustomBackColor = True
        Me.txt_passenger.UseSelectable = True
        Me.txt_passenger.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_passenger.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(87, 65)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(58, 19)
        Me.MetroLabel6.TabIndex = 105
        Me.MetroLabel6.Text = "Number"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnCancel.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancel.Location = New System.Drawing.Point(103, 166)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnCancel.TabIndex = 104
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
        Me.btnSave.Location = New System.Drawing.Point(184, 166)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnSave.TabIndex = 103
        Me.btnSave.Text = "Save"
        Me.btnSave.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSave.UseCustomBackColor = True
        Me.btnSave.UseCustomForeColor = True
        Me.btnSave.UseSelectable = True
        '
        'tbl_id
        '
        Me.tbl_id.AutoSize = True
        Me.tbl_id.Location = New System.Drawing.Point(334, 40)
        Me.tbl_id.Name = "tbl_id"
        Me.tbl_id.Size = New System.Drawing.Size(16, 19)
        Me.tbl_id.TabIndex = 107
        Me.tbl_id.Text = "0"
        Me.tbl_id.Visible = False
        '
        'VehicleID
        '
        Me.VehicleID.AutoSize = True
        Me.VehicleID.Location = New System.Drawing.Point(334, 65)
        Me.VehicleID.Name = "VehicleID"
        Me.VehicleID.Size = New System.Drawing.Size(16, 19)
        Me.VehicleID.TabIndex = 108
        Me.VehicleID.Text = "0"
        Me.VehicleID.Visible = False
        '
        'add_passenger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(362, 226)
        Me.Controls.Add(Me.VehicleID)
        Me.Controls.Add(Me.tbl_id)
        Me.Controls.Add(Me.txt_passenger)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "add_passenger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "add_passenger"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_passenger As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnCancel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents tbl_id As MetroFramework.Controls.MetroLabel
    Friend WithEvents VehicleID As MetroFramework.Controls.MetroLabel
End Class
