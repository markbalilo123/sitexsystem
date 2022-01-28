<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMakeelection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMakeelection))
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.elect_status = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.MetroTabControl3 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage7 = New MetroFramework.Controls.MetroTabPage()
        Me.txt_deptname = New MetroFramework.Controls.MetroTextBox()
        Me.txtEname = New MetroFramework.Controls.MetroTextBox()
        Me.btnCancel = New MetroFramework.Controls.MetroButton()
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.txt_me_elect_id = New MetroFramework.Controls.MetroLabel()
        Me.me_elect_date = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.MetroTabControl3.SuspendLayout()
        Me.MetroTabPage7.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Location = New System.Drawing.Point(0, -112)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(1013, 972)
        Me.MetroTabControl1.TabIndex = 1
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.elect_status)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel1)
        Me.MetroTabPage1.Controls.Add(Me.MetroButton2)
        Me.MetroTabPage1.Controls.Add(Me.MetroButton1)
        Me.MetroTabPage1.Controls.Add(Me.MetroPanel1)
        Me.MetroTabPage1.Controls.Add(Me.MetroTabControl3)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(1005, 930)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Manage election"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'elect_status
        '
        Me.elect_status.AutoSize = True
        Me.elect_status.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.elect_status.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.elect_status.Location = New System.Drawing.Point(464, 404)
        Me.elect_status.Name = "elect_status"
        Me.elect_status.Size = New System.Drawing.Size(111, 25)
        Me.elect_status.TabIndex = 26
        Me.elect_status.Text = "elect_status"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(341, 404)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(117, 25)
        Me.MetroLabel1.TabIndex = 25
        Me.MetroLabel1.Text = "Vote status: "
        '
        'MetroButton2
        '
        Me.MetroButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.MetroButton2.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.MetroButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MetroButton2.Location = New System.Drawing.Point(583, 465)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(151, 48)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroButton2.TabIndex = 24
        Me.MetroButton2.Text = "End election"
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton2.UseCustomBackColor = True
        Me.MetroButton2.UseCustomForeColor = True
        Me.MetroButton2.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.MetroButton1.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.MetroButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MetroButton1.Location = New System.Drawing.Point(341, 465)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(151, 48)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroButton1.TabIndex = 23
        Me.MetroButton1.Text = "Start election"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseCustomBackColor = True
        Me.MetroButton1.UseCustomForeColor = True
        Me.MetroButton1.UseSelectable = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.btnDel)
        Me.MetroPanel1.Controls.Add(Me.btnEdit)
        Me.MetroPanel1.Controls.Add(Me.btnAdd)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(564, 44)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(174, 44)
        Me.MetroPanel1.TabIndex = 4
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.White
        Me.btnDel.BackgroundImage = CType(resources.GetObject("btnDel.BackgroundImage"), System.Drawing.Image)
        Me.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDel.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnDel.Location = New System.Drawing.Point(144, 11)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(27, 30)
        Me.btnDel.TabIndex = 31
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.White
        Me.btnEdit.BackgroundImage = CType(resources.GetObject("btnEdit.BackgroundImage"), System.Drawing.Image)
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnEdit.Location = New System.Drawing.Point(111, 11)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(27, 30)
        Me.btnEdit.TabIndex = 30
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.White
        Me.btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAdd.Location = New System.Drawing.Point(78, 11)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(27, 30)
        Me.btnAdd.TabIndex = 27
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'MetroTabControl3
        '
        Me.MetroTabControl3.Controls.Add(Me.MetroTabPage7)
        Me.MetroTabControl3.Location = New System.Drawing.Point(337, 56)
        Me.MetroTabControl3.Name = "MetroTabControl3"
        Me.MetroTabControl3.SelectedIndex = 0
        Me.MetroTabControl3.Size = New System.Drawing.Size(401, 311)
        Me.MetroTabControl3.TabIndex = 3
        Me.MetroTabControl3.UseSelectable = True
        '
        'MetroTabPage7
        '
        Me.MetroTabPage7.Controls.Add(Me.txt_deptname)
        Me.MetroTabPage7.Controls.Add(Me.txtEname)
        Me.MetroTabPage7.Controls.Add(Me.btnCancel)
        Me.MetroTabPage7.Controls.Add(Me.btnSave)
        Me.MetroTabPage7.Controls.Add(Me.txt_me_elect_id)
        Me.MetroTabPage7.Controls.Add(Me.me_elect_date)
        Me.MetroTabPage7.Controls.Add(Me.MetroLabel11)
        Me.MetroTabPage7.Controls.Add(Me.MetroLabel12)
        Me.MetroTabPage7.Controls.Add(Me.MetroLabel5)
        Me.MetroTabPage7.HorizontalScrollbarBarColor = True
        Me.MetroTabPage7.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage7.HorizontalScrollbarSize = 10
        Me.MetroTabPage7.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage7.Name = "MetroTabPage7"
        Me.MetroTabPage7.Size = New System.Drawing.Size(393, 269)
        Me.MetroTabPage7.TabIndex = 0
        Me.MetroTabPage7.Text = "Make election"
        Me.MetroTabPage7.VerticalScrollbarBarColor = True
        Me.MetroTabPage7.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage7.VerticalScrollbarSize = 10
        '
        'txt_deptname
        '
        '
        '
        '
        Me.txt_deptname.CustomButton.Image = Nothing
        Me.txt_deptname.CustomButton.Location = New System.Drawing.Point(179, 1)
        Me.txt_deptname.CustomButton.Name = ""
        Me.txt_deptname.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_deptname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_deptname.CustomButton.TabIndex = 1
        Me.txt_deptname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_deptname.CustomButton.UseSelectable = True
        Me.txt_deptname.CustomButton.Visible = False
        Me.txt_deptname.Lines = New String(-1) {}
        Me.txt_deptname.Location = New System.Drawing.Point(159, 75)
        Me.txt_deptname.MaxLength = 32767
        Me.txt_deptname.Name = "txt_deptname"
        Me.txt_deptname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_deptname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_deptname.SelectedText = ""
        Me.txt_deptname.SelectionLength = 0
        Me.txt_deptname.SelectionStart = 0
        Me.txt_deptname.Size = New System.Drawing.Size(201, 23)
        Me.txt_deptname.TabIndex = 25
        Me.txt_deptname.UseSelectable = True
        Me.txt_deptname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_deptname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtEname
        '
        '
        '
        '
        Me.txtEname.CustomButton.Image = Nothing
        Me.txtEname.CustomButton.Location = New System.Drawing.Point(179, 1)
        Me.txtEname.CustomButton.Name = ""
        Me.txtEname.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtEname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEname.CustomButton.TabIndex = 1
        Me.txtEname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEname.CustomButton.UseSelectable = True
        Me.txtEname.CustomButton.Visible = False
        Me.txtEname.Lines = New String(-1) {}
        Me.txtEname.Location = New System.Drawing.Point(159, 24)
        Me.txtEname.MaxLength = 32767
        Me.txtEname.Name = "txtEname"
        Me.txtEname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEname.SelectedText = ""
        Me.txtEname.SelectionLength = 0
        Me.txtEname.SelectionStart = 0
        Me.txtEname.Size = New System.Drawing.Size(201, 23)
        Me.txtEname.TabIndex = 24
        Me.txtEname.UseSelectable = True
        Me.txtEname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnCancel.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancel.Location = New System.Drawing.Point(229, 209)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnCancel.TabIndex = 23
        Me.btnCancel.Text = "Cancel"
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
        Me.btnSave.Location = New System.Drawing.Point(104, 209)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Save"
        Me.btnSave.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSave.UseCustomBackColor = True
        Me.btnSave.UseCustomForeColor = True
        Me.btnSave.UseSelectable = True
        '
        'txt_me_elect_id
        '
        Me.txt_me_elect_id.AutoSize = True
        Me.txt_me_elect_id.Location = New System.Drawing.Point(374, 19)
        Me.txt_me_elect_id.Name = "txt_me_elect_id"
        Me.txt_me_elect_id.Size = New System.Drawing.Size(0, 0)
        Me.txt_me_elect_id.TabIndex = 18
        '
        'me_elect_date
        '
        Me.me_elect_date.Enabled = False
        Me.me_elect_date.Location = New System.Drawing.Point(159, 134)
        Me.me_elect_date.MinimumSize = New System.Drawing.Size(0, 29)
        Me.me_elect_date.Name = "me_elect_date"
        Me.me_elect_date.Size = New System.Drawing.Size(201, 29)
        Me.me_elect_date.TabIndex = 13
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(28, 75)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(83, 19)
        Me.MetroLabel11.TabIndex = 4
        Me.MetroLabel11.Text = "Department:"
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(28, 134)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(87, 19)
        Me.MetroLabel12.TabIndex = 6
        Me.MetroLabel12.Text = "Election date:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(28, 24)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(94, 19)
        Me.MetroLabel5.TabIndex = 2
        Me.MetroLabel5.Text = "Election name:"
        '
        'frmMakeelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1013, 749)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMakeelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroTabControl3.ResumeLayout(False)
        Me.MetroTabPage7.ResumeLayout(False)
        Me.MetroTabPage7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents elect_status As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents btnDel As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents MetroTabControl3 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage7 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents txt_deptname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtEname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnCancel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents txt_me_elect_id As MetroFramework.Controls.MetroLabel
    Friend WithEvents me_elect_date As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
End Class
