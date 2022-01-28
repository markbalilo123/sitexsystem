<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
    Inherits System.Windows.Forms.Form
    'Inherits MetroFramework.Forms.MetroForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.btnLogin = New MetroFramework.Controls.MetroButton()
        Me.txt_password = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txt_user = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(38, 443)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.btn_add)
        Me.Panel2.Controls.Add(Me.MetroLabel4)
        Me.Panel2.Controls.Add(Me.btnLogin)
        Me.Panel2.Controls.Add(Me.txt_password)
        Me.Panel2.Controls.Add(Me.MetroLabel3)
        Me.Panel2.Controls.Add(Me.txt_user)
        Me.Panel2.Controls.Add(Me.MetroLabel2)
        Me.Panel2.Controls.Add(Me.MetroLabel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(38, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(512, 443)
        Me.Panel2.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(474, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 28)
        Me.Button1.TabIndex = 92
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackgroundImage = CType(resources.GetObject("btn_add.BackgroundImage"), System.Drawing.Image)
        Me.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.Location = New System.Drawing.Point(368, 247)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(49, 28)
        Me.btn_add.TabIndex = 91
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.MetroLabel4.Location = New System.Drawing.Point(22, 6)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(425, 19)
        Me.MetroLabel4.TabIndex = 25
        Me.MetroLabel4.Text = "TFVC VOTING AND EVENT MONITORING ATTENDANCE SYSTEM"
        Me.MetroLabel4.UseCustomBackColor = True
        Me.MetroLabel4.UseCustomForeColor = True
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnLogin.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogin.Location = New System.Drawing.Point(25, 340)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(395, 37)
        Me.btnLogin.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnLogin.UseCustomBackColor = True
        Me.btnLogin.UseCustomForeColor = True
        Me.btnLogin.UseSelectable = True
        '
        'txt_password
        '
        Me.txt_password.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_password.CustomButton.Image = Nothing
        Me.txt_password.CustomButton.Location = New System.Drawing.Point(365, 1)
        Me.txt_password.CustomButton.Name = ""
        Me.txt_password.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.txt_password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_password.CustomButton.TabIndex = 1
        Me.txt_password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_password.CustomButton.UseSelectable = True
        Me.txt_password.CustomButton.Visible = False
        Me.txt_password.Lines = New String(-1) {}
        Me.txt_password.Location = New System.Drawing.Point(25, 245)
        Me.txt_password.MaxLength = 29
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_password.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_password.SelectedText = ""
        Me.txt_password.SelectionLength = 0
        Me.txt_password.SelectionStart = 0
        Me.txt_password.Size = New System.Drawing.Size(395, 31)
        Me.txt_password.TabIndex = 2
        Me.txt_password.UseCustomBackColor = True
        Me.txt_password.UseSelectable = True
        Me.txt_password.UseSystemPasswordChar = True
        Me.txt_password.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_password.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel3.ForeColor = System.Drawing.Color.Silver
        Me.MetroLabel3.Location = New System.Drawing.Point(25, 214)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(73, 15)
        Me.MetroLabel3.TabIndex = 2
        Me.MetroLabel3.Text = "PASSWORD"
        Me.MetroLabel3.UseCustomBackColor = True
        Me.MetroLabel3.UseCustomForeColor = True
        '
        'txt_user
        '
        Me.txt_user.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txt_user.CustomButton.Image = Nothing
        Me.txt_user.CustomButton.Location = New System.Drawing.Point(365, 1)
        Me.txt_user.CustomButton.Name = ""
        Me.txt_user.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.txt_user.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_user.CustomButton.TabIndex = 1
        Me.txt_user.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_user.CustomButton.UseSelectable = True
        Me.txt_user.CustomButton.Visible = False
        Me.txt_user.Lines = New String(-1) {}
        Me.txt_user.Location = New System.Drawing.Point(25, 131)
        Me.txt_user.MaxLength = 29
        Me.txt_user.Multiline = True
        Me.txt_user.Name = "txt_user"
        Me.txt_user.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_user.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_user.SelectedText = ""
        Me.txt_user.SelectionLength = 0
        Me.txt_user.SelectionStart = 0
        Me.txt_user.Size = New System.Drawing.Size(395, 31)
        Me.txt_user.TabIndex = 1
        Me.txt_user.UseCustomBackColor = True
        Me.txt_user.UseSelectable = True
        Me.txt_user.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_user.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.ForeColor = System.Drawing.Color.Silver
        Me.MetroLabel2.Location = New System.Drawing.Point(25, 113)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(71, 15)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "USERNAME"
        Me.MetroLabel2.UseCustomBackColor = True
        Me.MetroLabel2.UseCustomForeColor = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.MetroLabel1.Location = New System.Drawing.Point(25, 77)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(63, 25)
        Me.MetroLabel1.TabIndex = 6
        Me.MetroLabel1.Text = "LOGIN"
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 443)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_password As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_user As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnLogin As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_add As Button
    Friend WithEvents Button1 As Button
End Class
