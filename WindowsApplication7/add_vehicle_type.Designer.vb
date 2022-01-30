<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_vehicle_type
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
        Me.btnUpdate = New MetroFramework.Controls.MetroButton()
        Me.txt_type = New MetroFramework.Controls.MetroTextBox()
        Me.btnCancel = New MetroFramework.Controls.MetroButton()
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.txt = New MetroFramework.Controls.MetroLabel()
        Me.lbl_id = New MetroFramework.Controls.MetroLabel()
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
        Me.Panel1.Size = New System.Drawing.Size(461, 37)
        Me.Panel1.TabIndex = 2
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MetroLabel1.Location = New System.Drawing.Point(0, 9)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(122, 19)
        Me.MetroLabel1.TabIndex = 27
        Me.MetroLabel1.Text = "Add vehicle type"
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnUpdate.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUpdate.Location = New System.Drawing.Point(189, 173)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnUpdate.TabIndex = 48
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnUpdate.UseCustomBackColor = True
        Me.btnUpdate.UseCustomForeColor = True
        Me.btnUpdate.UseSelectable = True
        '
        'txt_type
        '
        Me.txt_type.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txt_type.CustomButton.Image = Nothing
        Me.txt_type.CustomButton.Location = New System.Drawing.Point(157, 1)
        Me.txt_type.CustomButton.Name = ""
        Me.txt_type.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.txt_type.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_type.CustomButton.TabIndex = 1
        Me.txt_type.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_type.CustomButton.UseSelectable = True
        Me.txt_type.CustomButton.Visible = False
        Me.txt_type.Lines = New String(-1) {}
        Me.txt_type.Location = New System.Drawing.Point(194, 95)
        Me.txt_type.MaxLength = 29
        Me.txt_type.Multiline = True
        Me.txt_type.Name = "txt_type"
        Me.txt_type.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_type.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_type.SelectedText = ""
        Me.txt_type.SelectionLength = 0
        Me.txt_type.SelectionStart = 0
        Me.txt_type.Size = New System.Drawing.Size(187, 31)
        Me.txt_type.TabIndex = 47
        Me.txt_type.UseCustomBackColor = True
        Me.txt_type.UseSelectable = True
        Me.txt_type.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_type.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnCancel.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancel.Location = New System.Drawing.Point(108, 173)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnCancel.TabIndex = 46
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
        Me.btnSave.Location = New System.Drawing.Point(270, 173)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnSave.TabIndex = 45
        Me.btnSave.Text = "Save"
        Me.btnSave.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSave.UseCustomBackColor = True
        Me.btnSave.UseCustomForeColor = True
        Me.btnSave.UseSelectable = True
        '
        'txt
        '
        Me.txt.AutoSize = True
        Me.txt.Location = New System.Drawing.Point(68, 99)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(81, 19)
        Me.txt.TabIndex = 44
        Me.txt.Text = "Vehicle type:"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(329, 40)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(16, 19)
        Me.lbl_id.TabIndex = 51
        Me.lbl_id.Text = "0"
        Me.lbl_id.Visible = False
        '
        'add_vehicle_type
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(461, 236)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "add_vehicle_type"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "add_vehicle_type"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnUpdate As MetroFramework.Controls.MetroButton
    Friend WithEvents txt_type As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnCancel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents txt As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_id As MetroFramework.Controls.MetroLabel
End Class
