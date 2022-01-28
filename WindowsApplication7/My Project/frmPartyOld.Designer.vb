<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParty
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParty))
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.btnDel1 = New System.Windows.Forms.Button()
        Me.btnEdit1 = New System.Windows.Forms.Button()
        Me.btnAdd1 = New System.Windows.Forms.Button()
        Me.partylist1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabControl2 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.pt1_id = New MetroFramework.Controls.MetroLabel()
        Me.pt1_motto = New MetroFramework.Controls.MetroTextBox()
        Me.pt1_name = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.pt1_pic = New System.Windows.Forms.PictureBox()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.partylist2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.btnDel2 = New System.Windows.Forms.Button()
        Me.btnEdit2 = New System.Windows.Forms.Button()
        Me.btnAdd2 = New System.Windows.Forms.Button()
        Me.MetroTabControl3 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage7 = New MetroFramework.Controls.MetroTabPage()
        Me.pt2_id = New MetroFramework.Controls.MetroLabel()
        Me.pt2_motto = New MetroFramework.Controls.MetroTextBox()
        Me.pt2_name = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.pt2_pic = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MetroButton4 = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        Me.MetroTabControl2.SuspendLayout()
        Me.MetroTabPage3.SuspendLayout()
        CType(Me.pt1_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabPage2.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.MetroTabControl3.SuspendLayout()
        Me.MetroTabPage7.SuspendLayout()
        CType(Me.pt2_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Location = New System.Drawing.Point(0, 53)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 1
        Me.MetroTabControl1.Size = New System.Drawing.Size(1013, 735)
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.MetroPanel2)
        Me.MetroTabPage1.Controls.Add(Me.partylist1)
        Me.MetroTabPage1.Controls.Add(Me.MetroTabControl2)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 2
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(1005, 693)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Manage Partylist1"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 3
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.btnDel1)
        Me.MetroPanel2.Controls.Add(Me.btnEdit1)
        Me.MetroPanel2.Controls.Add(Me.btnAdd1)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 2
        Me.MetroPanel2.Location = New System.Drawing.Point(597, 41)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(174, 41)
        Me.MetroPanel2.TabIndex = 18
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 3
        '
        'btnDel1
        '
        Me.btnDel1.BackColor = System.Drawing.Color.White
        Me.btnDel1.BackgroundImage = CType(resources.GetObject("btnDel1.BackgroundImage"), System.Drawing.Image)
        Me.btnDel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDel1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDel1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnDel1.Location = New System.Drawing.Point(144, 11)
        Me.btnDel1.Name = "btnDel1"
        Me.btnDel1.Size = New System.Drawing.Size(27, 30)
        Me.btnDel1.TabIndex = 31
        Me.btnDel1.UseVisualStyleBackColor = False
        '
        'btnEdit1
        '
        Me.btnEdit1.BackColor = System.Drawing.Color.White
        Me.btnEdit1.BackgroundImage = CType(resources.GetObject("btnEdit1.BackgroundImage"), System.Drawing.Image)
        Me.btnEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEdit1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEdit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEdit1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnEdit1.Location = New System.Drawing.Point(111, 11)
        Me.btnEdit1.Name = "btnEdit1"
        Me.btnEdit1.Size = New System.Drawing.Size(27, 30)
        Me.btnEdit1.TabIndex = 30
        Me.btnEdit1.UseVisualStyleBackColor = False
        '
        'btnAdd1
        '
        Me.btnAdd1.BackColor = System.Drawing.Color.White
        Me.btnAdd1.BackgroundImage = CType(resources.GetObject("btnAdd1.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdd1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAdd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAdd1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAdd1.Location = New System.Drawing.Point(78, 11)
        Me.btnAdd1.Name = "btnAdd1"
        Me.btnAdd1.Size = New System.Drawing.Size(27, 30)
        Me.btnAdd1.TabIndex = 27
        Me.btnAdd1.UseVisualStyleBackColor = False
        '
        'partylist1
        '
        Me.partylist1.AutoSize = True
        Me.partylist1.Location = New System.Drawing.Point(28, 15)
        Me.partylist1.Name = "partylist1"
        Me.partylist1.Size = New System.Drawing.Size(63, 19)
        Me.partylist1.TabIndex = 17
        Me.partylist1.Text = "Partylist 1"
        Me.partylist1.Visible = False
        '
        'MetroTabControl2
        '
        Me.MetroTabControl2.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl2.Location = New System.Drawing.Point(183, 50)
        Me.MetroTabControl2.Name = "MetroTabControl2"
        Me.MetroTabControl2.SelectedIndex = 0
        Me.MetroTabControl2.Size = New System.Drawing.Size(593, 438)
        Me.MetroTabControl2.TabIndex = 5
        Me.MetroTabControl2.UseSelectable = True
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.Controls.Add(Me.pt1_id)
        Me.MetroTabPage3.Controls.Add(Me.pt1_motto)
        Me.MetroTabPage3.Controls.Add(Me.pt1_name)
        Me.MetroTabPage3.Controls.Add(Me.MetroLabel3)
        Me.MetroTabPage3.Controls.Add(Me.MetroLabel4)
        Me.MetroTabPage3.Controls.Add(Me.pt1_pic)
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.HorizontalScrollbarSize = 2
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(585, 396)
        Me.MetroTabPage3.TabIndex = 0
        Me.MetroTabPage3.Text = "Partylist 1 information       "
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 3
        '
        'pt1_id
        '
        Me.pt1_id.AutoSize = True
        Me.pt1_id.Location = New System.Drawing.Point(466, 12)
        Me.pt1_id.Name = "pt1_id"
        Me.pt1_id.Size = New System.Drawing.Size(0, 0)
        Me.pt1_id.TabIndex = 44
        Me.pt1_id.Visible = False
        '
        'pt1_motto
        '
        '
        '
        '
        Me.pt1_motto.CustomButton.Image = Nothing
        Me.pt1_motto.CustomButton.Location = New System.Drawing.Point(56, 1)
        Me.pt1_motto.CustomButton.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.pt1_motto.CustomButton.Name = ""
        Me.pt1_motto.CustomButton.Size = New System.Drawing.Size(80, 70)
        Me.pt1_motto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.pt1_motto.CustomButton.TabIndex = 1
        Me.pt1_motto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.pt1_motto.CustomButton.UseSelectable = True
        Me.pt1_motto.CustomButton.Visible = False
        Me.pt1_motto.Enabled = False
        Me.pt1_motto.Lines = New String(-1) {}
        Me.pt1_motto.Location = New System.Drawing.Point(246, 198)
        Me.pt1_motto.MaxLength = 32767
        Me.pt1_motto.Multiline = True
        Me.pt1_motto.Name = "pt1_motto"
        Me.pt1_motto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.pt1_motto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.pt1_motto.SelectedText = ""
        Me.pt1_motto.SelectionLength = 0
        Me.pt1_motto.SelectionStart = 0
        Me.pt1_motto.Size = New System.Drawing.Size(182, 109)
        Me.pt1_motto.TabIndex = 43
        Me.pt1_motto.UseSelectable = True
        Me.pt1_motto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.pt1_motto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'pt1_name
        '
        Me.pt1_name.AutoSize = True
        Me.pt1_name.Location = New System.Drawing.Point(246, 156)
        Me.pt1_name.Name = "pt1_name"
        Me.pt1_name.Size = New System.Drawing.Size(0, 0)
        Me.pt1_name.TabIndex = 20
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(112, 198)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(97, 19)
        Me.MetroLabel3.TabIndex = 16
        Me.MetroLabel3.Text = "Partylist motto:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(112, 156)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(94, 19)
        Me.MetroLabel4.TabIndex = 15
        Me.MetroLabel4.Text = "Partylist name:"
        '
        'pt1_pic
        '
        Me.pt1_pic.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pt1_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pt1_pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pt1_pic.Location = New System.Drawing.Point(246, 44)
        Me.pt1_pic.Name = "pt1_pic"
        Me.pt1_pic.Size = New System.Drawing.Size(117, 84)
        Me.pt1_pic.TabIndex = 14
        Me.pt1_pic.TabStop = False
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.partylist2)
        Me.MetroTabPage2.Controls.Add(Me.MetroPanel1)
        Me.MetroTabPage2.Controls.Add(Me.MetroTabControl3)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 2
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(1005, 693)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Manage Partylist2"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 3
        '
        'partylist2
        '
        Me.partylist2.AutoSize = True
        Me.partylist2.Location = New System.Drawing.Point(42, 9)
        Me.partylist2.Name = "partylist2"
        Me.partylist2.Size = New System.Drawing.Size(65, 19)
        Me.partylist2.TabIndex = 16
        Me.partylist2.Text = "Partylist 2"
        Me.partylist2.Visible = False
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.btnDel2)
        Me.MetroPanel1.Controls.Add(Me.btnEdit2)
        Me.MetroPanel1.Controls.Add(Me.btnAdd2)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 2
        Me.MetroPanel1.Location = New System.Drawing.Point(597, 41)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(174, 41)
        Me.MetroPanel1.TabIndex = 5
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 3
        '
        'btnDel2
        '
        Me.btnDel2.BackColor = System.Drawing.Color.White
        Me.btnDel2.BackgroundImage = CType(resources.GetObject("btnDel2.BackgroundImage"), System.Drawing.Image)
        Me.btnDel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDel2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDel2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnDel2.Location = New System.Drawing.Point(144, 11)
        Me.btnDel2.Name = "btnDel2"
        Me.btnDel2.Size = New System.Drawing.Size(27, 30)
        Me.btnDel2.TabIndex = 31
        Me.btnDel2.UseVisualStyleBackColor = False
        '
        'btnEdit2
        '
        Me.btnEdit2.BackColor = System.Drawing.Color.White
        Me.btnEdit2.BackgroundImage = CType(resources.GetObject("btnEdit2.BackgroundImage"), System.Drawing.Image)
        Me.btnEdit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEdit2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEdit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEdit2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnEdit2.Location = New System.Drawing.Point(111, 11)
        Me.btnEdit2.Name = "btnEdit2"
        Me.btnEdit2.Size = New System.Drawing.Size(27, 30)
        Me.btnEdit2.TabIndex = 30
        Me.btnEdit2.UseVisualStyleBackColor = False
        '
        'btnAdd2
        '
        Me.btnAdd2.BackColor = System.Drawing.Color.White
        Me.btnAdd2.BackgroundImage = CType(resources.GetObject("btnAdd2.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdd2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAdd2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAdd2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAdd2.Location = New System.Drawing.Point(78, 11)
        Me.btnAdd2.Name = "btnAdd2"
        Me.btnAdd2.Size = New System.Drawing.Size(27, 30)
        Me.btnAdd2.TabIndex = 27
        Me.btnAdd2.UseVisualStyleBackColor = False
        '
        'MetroTabControl3
        '
        Me.MetroTabControl3.Controls.Add(Me.MetroTabPage7)
        Me.MetroTabControl3.Location = New System.Drawing.Point(183, 50)
        Me.MetroTabControl3.Name = "MetroTabControl3"
        Me.MetroTabControl3.SelectedIndex = 0
        Me.MetroTabControl3.Size = New System.Drawing.Size(593, 438)
        Me.MetroTabControl3.TabIndex = 4
        Me.MetroTabControl3.UseSelectable = True
        '
        'MetroTabPage7
        '
        Me.MetroTabPage7.Controls.Add(Me.pt2_id)
        Me.MetroTabPage7.Controls.Add(Me.pt2_motto)
        Me.MetroTabPage7.Controls.Add(Me.pt2_name)
        Me.MetroTabPage7.Controls.Add(Me.MetroLabel15)
        Me.MetroTabPage7.Controls.Add(Me.MetroLabel16)
        Me.MetroTabPage7.Controls.Add(Me.pt2_pic)
        Me.MetroTabPage7.HorizontalScrollbarBarColor = True
        Me.MetroTabPage7.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage7.HorizontalScrollbarSize = 2
        Me.MetroTabPage7.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage7.Name = "MetroTabPage7"
        Me.MetroTabPage7.Size = New System.Drawing.Size(585, 396)
        Me.MetroTabPage7.TabIndex = 0
        Me.MetroTabPage7.Text = "Partylist 2 information       "
        Me.MetroTabPage7.VerticalScrollbarBarColor = True
        Me.MetroTabPage7.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage7.VerticalScrollbarSize = 3
        '
        'pt2_id
        '
        Me.pt2_id.AutoSize = True
        Me.pt2_id.Location = New System.Drawing.Point(466, 12)
        Me.pt2_id.Name = "pt2_id"
        Me.pt2_id.Size = New System.Drawing.Size(0, 0)
        Me.pt2_id.TabIndex = 44
        Me.pt2_id.Visible = False
        '
        'pt2_motto
        '
        '
        '
        '
        Me.pt2_motto.CustomButton.Image = Nothing
        Me.pt2_motto.CustomButton.Location = New System.Drawing.Point(56, 1)
        Me.pt2_motto.CustomButton.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.pt2_motto.CustomButton.Name = ""
        Me.pt2_motto.CustomButton.Size = New System.Drawing.Size(80, 70)
        Me.pt2_motto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.pt2_motto.CustomButton.TabIndex = 1
        Me.pt2_motto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.pt2_motto.CustomButton.UseSelectable = True
        Me.pt2_motto.CustomButton.Visible = False
        Me.pt2_motto.Enabled = False
        Me.pt2_motto.Lines = New String(-1) {}
        Me.pt2_motto.Location = New System.Drawing.Point(246, 198)
        Me.pt2_motto.MaxLength = 32767
        Me.pt2_motto.Multiline = True
        Me.pt2_motto.Name = "pt2_motto"
        Me.pt2_motto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.pt2_motto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.pt2_motto.SelectedText = ""
        Me.pt2_motto.SelectionLength = 0
        Me.pt2_motto.SelectionStart = 0
        Me.pt2_motto.Size = New System.Drawing.Size(182, 109)
        Me.pt2_motto.TabIndex = 43
        Me.pt2_motto.UseSelectable = True
        Me.pt2_motto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.pt2_motto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'pt2_name
        '
        Me.pt2_name.AutoSize = True
        Me.pt2_name.Location = New System.Drawing.Point(246, 156)
        Me.pt2_name.Name = "pt2_name"
        Me.pt2_name.Size = New System.Drawing.Size(0, 0)
        Me.pt2_name.TabIndex = 20
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.Location = New System.Drawing.Point(112, 198)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(97, 19)
        Me.MetroLabel15.TabIndex = 16
        Me.MetroLabel15.Text = "Partylist motto:"
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.Location = New System.Drawing.Point(112, 156)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(94, 19)
        Me.MetroLabel16.TabIndex = 15
        Me.MetroLabel16.Text = "Partylist name:"
        '
        'pt2_pic
        '
        Me.pt2_pic.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pt2_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pt2_pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pt2_pic.Location = New System.Drawing.Point(246, 44)
        Me.pt2_pic.Name = "pt2_pic"
        Me.pt2_pic.Size = New System.Drawing.Size(117, 84)
        Me.pt2_pic.TabIndex = 14
        Me.pt2_pic.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.MetroButton4)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1013, 53)
        Me.Panel3.TabIndex = 2
        '
        'MetroButton4
        '
        Me.MetroButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.MetroButton4.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.MetroButton4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MetroButton4.Location = New System.Drawing.Point(722, 2)
        Me.MetroButton4.Name = "MetroButton4"
        Me.MetroButton4.Size = New System.Drawing.Size(151, 48)
        Me.MetroButton4.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroButton4.TabIndex = 25
        Me.MetroButton4.Text = "Close"
        Me.MetroButton4.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton4.UseCustomBackColor = True
        Me.MetroButton4.UseCustomForeColor = True
        Me.MetroButton4.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 30)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Partylist"
        '
        'frmParty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1013, 749)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmParty"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroTabControl2.ResumeLayout(False)
        Me.MetroTabPage3.ResumeLayout(False)
        Me.MetroTabPage3.PerformLayout()
        CType(Me.pt1_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroTabControl3.ResumeLayout(False)
        Me.MetroTabPage7.ResumeLayout(False)
        Me.MetroTabPage7.PerformLayout()
        CType(Me.pt2_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MetroButton4 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabControl3 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage7 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents pt2_pic As PictureBox
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents btnDel2 As Button
    Friend WithEvents btnEdit2 As Button
    Friend WithEvents btnAdd2 As Button
    Friend WithEvents pt2_name As MetroFramework.Controls.MetroLabel
    Friend WithEvents pt2_motto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents partylist2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents pt2_id As MetroFramework.Controls.MetroLabel
    Friend WithEvents partylist1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTabControl2 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents pt1_id As MetroFramework.Controls.MetroLabel
    Friend WithEvents pt1_motto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pt1_name As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents pt1_pic As PictureBox
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents btnDel1 As Button
    Friend WithEvents btnEdit1 As Button
    Friend WithEvents btnAdd1 As Button
    Friend WithEvents Label1 As Label
End Class
