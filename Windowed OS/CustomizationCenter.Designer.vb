<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomizationCenter
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WindowBackground = New System.Windows.Forms.GroupBox()
        Me.WindowButton = New System.Windows.Forms.Button()
        Me.WindowTitle = New System.Windows.Forms.Label()
        Me.WindowText = New System.Windows.Forms.Label()
        Me.apiImage = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.BottomRightButton = New System.Windows.Forms.RadioButton()
        Me.RightButton = New System.Windows.Forms.RadioButton()
        Me.TopRightButton = New System.Windows.Forms.RadioButton()
        Me.BottomButton = New System.Windows.Forms.RadioButton()
        Me.TopButton = New System.Windows.Forms.RadioButton()
        Me.NoneButton = New System.Windows.Forms.RadioButton()
        Me.BottomLeftButton = New System.Windows.Forms.RadioButton()
        Me.TopLeftButton = New System.Windows.Forms.RadioButton()
        Me.LeftButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.BottomRight = New System.Windows.Forms.RadioButton()
        Me.RightBtn = New System.Windows.Forms.RadioButton()
        Me.TopRight = New System.Windows.Forms.RadioButton()
        Me.BottomBtn = New System.Windows.Forms.RadioButton()
        Me.TopBtn = New System.Windows.Forms.RadioButton()
        Me.None = New System.Windows.Forms.RadioButton()
        Me.BottomLeft = New System.Windows.Forms.RadioButton()
        Me.TopLeft = New System.Windows.Forms.RadioButton()
        Me.LeftBtn = New System.Windows.Forms.RadioButton()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.ThemeChangerDialog = New System.Windows.Forms.ColorDialog()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TerminateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ApplyTheme = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.MainFont = New System.Windows.Forms.Label()
        Me.TitleFont = New System.Windows.Forms.Label()
        Me.MessageFont = New System.Windows.Forms.Label()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SystemFontDialog = New System.Windows.Forms.FontDialog()
        Me.SolidColorDialog = New System.Windows.Forms.ColorDialog()
        Me.BackgroundImageDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.WindowBackground.SuspendLayout()
        CType(Me.apiImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(5, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(696, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Customization panel"
        '
        'WindowBackground
        '
        Me.WindowBackground.BackColor = System.Drawing.Color.WhiteSmoke
        Me.WindowBackground.Controls.Add(Me.WindowButton)
        Me.WindowBackground.Controls.Add(Me.WindowTitle)
        Me.WindowBackground.Controls.Add(Me.WindowText)
        Me.WindowBackground.Controls.Add(Me.apiImage)
        Me.WindowBackground.ForeColor = System.Drawing.Color.Black
        Me.WindowBackground.Location = New System.Drawing.Point(24, 85)
        Me.WindowBackground.Name = "WindowBackground"
        Me.WindowBackground.Size = New System.Drawing.Size(361, 203)
        Me.WindowBackground.TabIndex = 39
        Me.WindowBackground.TabStop = False
        Me.WindowBackground.Text = "Preview"
        '
        'WindowButton
        '
        Me.WindowButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.WindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WindowButton.Location = New System.Drawing.Point(144, 161)
        Me.WindowButton.Name = "WindowButton"
        Me.WindowButton.Size = New System.Drawing.Size(75, 23)
        Me.WindowButton.TabIndex = 35
        Me.WindowButton.Text = "OK"
        Me.WindowButton.UseVisualStyleBackColor = True
        '
        'WindowTitle
        '
        Me.WindowTitle.BackColor = System.Drawing.Color.DimGray
        Me.WindowTitle.ForeColor = System.Drawing.Color.White
        Me.WindowTitle.Location = New System.Drawing.Point(6, 16)
        Me.WindowTitle.Name = "WindowTitle"
        Me.WindowTitle.Size = New System.Drawing.Size(348, 15)
        Me.WindowTitle.TabIndex = 16
        Me.WindowTitle.Text = "Sample title"
        '
        'WindowText
        '
        Me.WindowText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WindowText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.WindowText.Location = New System.Drawing.Point(94, 50)
        Me.WindowText.Name = "WindowText"
        Me.WindowText.Size = New System.Drawing.Size(253, 104)
        Me.WindowText.TabIndex = 18
        Me.WindowText.Text = "Sample text"
        Me.WindowText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'apiImage
        '
        Me.apiImage.BackgroundImage = Global.Windowed_OS.My.Resources.Resources.colors
        Me.apiImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.apiImage.Location = New System.Drawing.Point(11, 63)
        Me.apiImage.Name = "apiImage"
        Me.apiImage.Size = New System.Drawing.Size(77, 78)
        Me.apiImage.TabIndex = 17
        Me.apiImage.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Location = New System.Drawing.Point(391, 35)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(303, 141)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Colors"
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(6, 108)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(291, 23)
        Me.Button5.TabIndex = 33
        Me.Button5.Text = "Title bar text"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(6, 79)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(291, 23)
        Me.Button4.TabIndex = 32
        Me.Button4.Text = "Title bar background"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(6, 50)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(291, 23)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "Window text"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(6, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(291, 23)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Window background"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CheckBox1)
        Me.GroupBox4.Controls.Add(Me.BottomRightButton)
        Me.GroupBox4.Controls.Add(Me.RightButton)
        Me.GroupBox4.Controls.Add(Me.TopRightButton)
        Me.GroupBox4.Controls.Add(Me.BottomButton)
        Me.GroupBox4.Controls.Add(Me.TopButton)
        Me.GroupBox4.Controls.Add(Me.NoneButton)
        Me.GroupBox4.Controls.Add(Me.BottomLeftButton)
        Me.GroupBox4.Controls.Add(Me.TopLeftButton)
        Me.GroupBox4.Controls.Add(Me.LeftButton)
        Me.GroupBox4.Location = New System.Drawing.Point(391, 182)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(144, 129)
        Me.GroupBox4.TabIndex = 41
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Launcher anchor"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Location = New System.Drawing.Point(6, 106)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(61, 17)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "Docked"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'BottomRightButton
        '
        Me.BottomRightButton.AutoSize = True
        Me.BottomRightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BottomRightButton.Location = New System.Drawing.Point(116, 77)
        Me.BottomRightButton.Name = "BottomRightButton"
        Me.BottomRightButton.Size = New System.Drawing.Size(13, 12)
        Me.BottomRightButton.TabIndex = 19
        Me.BottomRightButton.UseVisualStyleBackColor = True
        '
        'RightButton
        '
        Me.RightButton.AutoSize = True
        Me.RightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RightButton.Location = New System.Drawing.Point(116, 48)
        Me.RightButton.Name = "RightButton"
        Me.RightButton.Size = New System.Drawing.Size(13, 12)
        Me.RightButton.TabIndex = 16
        Me.RightButton.UseVisualStyleBackColor = True
        '
        'TopRightButton
        '
        Me.TopRightButton.AutoSize = True
        Me.TopRightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TopRightButton.Location = New System.Drawing.Point(116, 19)
        Me.TopRightButton.Name = "TopRightButton"
        Me.TopRightButton.Size = New System.Drawing.Size(13, 12)
        Me.TopRightButton.TabIndex = 13
        Me.TopRightButton.UseVisualStyleBackColor = True
        '
        'BottomButton
        '
        Me.BottomButton.AutoSize = True
        Me.BottomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BottomButton.Location = New System.Drawing.Point(66, 77)
        Me.BottomButton.Name = "BottomButton"
        Me.BottomButton.Size = New System.Drawing.Size(13, 12)
        Me.BottomButton.TabIndex = 18
        Me.BottomButton.UseVisualStyleBackColor = True
        '
        'TopButton
        '
        Me.TopButton.AutoSize = True
        Me.TopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TopButton.Location = New System.Drawing.Point(66, 19)
        Me.TopButton.Name = "TopButton"
        Me.TopButton.Size = New System.Drawing.Size(13, 12)
        Me.TopButton.TabIndex = 12
        Me.TopButton.UseVisualStyleBackColor = True
        '
        'NoneButton
        '
        Me.NoneButton.AutoSize = True
        Me.NoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NoneButton.Location = New System.Drawing.Point(66, 48)
        Me.NoneButton.Name = "NoneButton"
        Me.NoneButton.Size = New System.Drawing.Size(13, 12)
        Me.NoneButton.TabIndex = 15
        Me.NoneButton.UseVisualStyleBackColor = True
        '
        'BottomLeftButton
        '
        Me.BottomLeftButton.AutoSize = True
        Me.BottomLeftButton.Checked = True
        Me.BottomLeftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BottomLeftButton.Location = New System.Drawing.Point(17, 77)
        Me.BottomLeftButton.Name = "BottomLeftButton"
        Me.BottomLeftButton.Size = New System.Drawing.Size(13, 12)
        Me.BottomLeftButton.TabIndex = 17
        Me.BottomLeftButton.TabStop = True
        Me.BottomLeftButton.UseVisualStyleBackColor = True
        '
        'TopLeftButton
        '
        Me.TopLeftButton.AutoSize = True
        Me.TopLeftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TopLeftButton.Location = New System.Drawing.Point(17, 19)
        Me.TopLeftButton.Name = "TopLeftButton"
        Me.TopLeftButton.Size = New System.Drawing.Size(13, 12)
        Me.TopLeftButton.TabIndex = 11
        Me.TopLeftButton.UseVisualStyleBackColor = True
        '
        'LeftButton
        '
        Me.LeftButton.AutoSize = True
        Me.LeftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LeftButton.Location = New System.Drawing.Point(17, 48)
        Me.LeftButton.Name = "LeftButton"
        Me.LeftButton.Size = New System.Drawing.Size(13, 12)
        Me.LeftButton.TabIndex = 14
        Me.LeftButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckBox2)
        Me.GroupBox3.Controls.Add(Me.BottomRight)
        Me.GroupBox3.Controls.Add(Me.RightBtn)
        Me.GroupBox3.Controls.Add(Me.TopRight)
        Me.GroupBox3.Controls.Add(Me.BottomBtn)
        Me.GroupBox3.Controls.Add(Me.TopBtn)
        Me.GroupBox3.Controls.Add(Me.None)
        Me.GroupBox3.Controls.Add(Me.BottomLeft)
        Me.GroupBox3.Controls.Add(Me.TopLeft)
        Me.GroupBox3.Controls.Add(Me.LeftBtn)
        Me.GroupBox3.Location = New System.Drawing.Point(550, 182)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(144, 129)
        Me.GroupBox3.TabIndex = 42
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CCC anchor"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox2.Location = New System.Drawing.Point(6, 106)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox2.TabIndex = 20
        Me.CheckBox2.Text = "Background"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'BottomRight
        '
        Me.BottomRight.AutoSize = True
        Me.BottomRight.Checked = True
        Me.BottomRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BottomRight.Location = New System.Drawing.Point(116, 77)
        Me.BottomRight.Name = "BottomRight"
        Me.BottomRight.Size = New System.Drawing.Size(13, 12)
        Me.BottomRight.TabIndex = 29
        Me.BottomRight.TabStop = True
        Me.BottomRight.UseVisualStyleBackColor = True
        '
        'RightBtn
        '
        Me.RightBtn.AutoSize = True
        Me.RightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RightBtn.Location = New System.Drawing.Point(116, 48)
        Me.RightBtn.Name = "RightBtn"
        Me.RightBtn.Size = New System.Drawing.Size(13, 12)
        Me.RightBtn.TabIndex = 26
        Me.RightBtn.UseVisualStyleBackColor = True
        '
        'TopRight
        '
        Me.TopRight.AutoSize = True
        Me.TopRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TopRight.Location = New System.Drawing.Point(116, 19)
        Me.TopRight.Name = "TopRight"
        Me.TopRight.Size = New System.Drawing.Size(13, 12)
        Me.TopRight.TabIndex = 23
        Me.TopRight.UseVisualStyleBackColor = True
        '
        'BottomBtn
        '
        Me.BottomBtn.AutoSize = True
        Me.BottomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BottomBtn.Location = New System.Drawing.Point(66, 77)
        Me.BottomBtn.Name = "BottomBtn"
        Me.BottomBtn.Size = New System.Drawing.Size(13, 12)
        Me.BottomBtn.TabIndex = 28
        Me.BottomBtn.UseVisualStyleBackColor = True
        '
        'TopBtn
        '
        Me.TopBtn.AutoSize = True
        Me.TopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TopBtn.Location = New System.Drawing.Point(66, 19)
        Me.TopBtn.Name = "TopBtn"
        Me.TopBtn.Size = New System.Drawing.Size(13, 12)
        Me.TopBtn.TabIndex = 22
        Me.TopBtn.UseVisualStyleBackColor = True
        '
        'None
        '
        Me.None.AutoSize = True
        Me.None.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.None.Location = New System.Drawing.Point(66, 48)
        Me.None.Name = "None"
        Me.None.Size = New System.Drawing.Size(13, 12)
        Me.None.TabIndex = 25
        Me.None.UseVisualStyleBackColor = True
        '
        'BottomLeft
        '
        Me.BottomLeft.AutoSize = True
        Me.BottomLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BottomLeft.Location = New System.Drawing.Point(17, 77)
        Me.BottomLeft.Name = "BottomLeft"
        Me.BottomLeft.Size = New System.Drawing.Size(13, 12)
        Me.BottomLeft.TabIndex = 27
        Me.BottomLeft.UseVisualStyleBackColor = True
        '
        'TopLeft
        '
        Me.TopLeft.AutoSize = True
        Me.TopLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TopLeft.Location = New System.Drawing.Point(17, 19)
        Me.TopLeft.Name = "TopLeft"
        Me.TopLeft.Size = New System.Drawing.Size(13, 12)
        Me.TopLeft.TabIndex = 21
        Me.TopLeft.UseVisualStyleBackColor = True
        '
        'LeftBtn
        '
        Me.LeftBtn.AutoSize = True
        Me.LeftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LeftBtn.Location = New System.Drawing.Point(17, 48)
        Me.LeftBtn.Name = "LeftBtn"
        Me.LeftBtn.Size = New System.Drawing.Size(13, 12)
        Me.LeftBtn.TabIndex = 24
        Me.LeftBtn.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(251, 424)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "Reset"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Enabled = False
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Location = New System.Drawing.Point(8, 424)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 1
        Me.Button7.Text = "OK"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(89, 424)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 2
        Me.Button8.Text = "Close"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Location = New System.Drawing.Point(170, 424)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 3
        Me.Button9.Text = "Apply"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'ThemeChangerDialog
        '
        Me.ThemeChangerDialog.AnyColor = True
        Me.ThemeChangerDialog.Color = System.Drawing.Color.WhiteSmoke
        Me.ThemeChangerDialog.FullOpen = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Grey Metallic", "Modern Orange", "Fancy Blue", "Minimal Indigo", "Stan", "H20", "Beach", "Winter", "Neon", "Pink Sugar", "Dark Mode", "Grass Green", "Gold Overload", "Simply Violet", "Midnight Blue", "Sweet Chocolate", "High Contrast #1", "High Contrast #2", "High Contrast #3", "Import from host"})
        Me.ComboBox1.Location = New System.Drawing.Point(24, 54)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(361, 21)
        Me.ComboBox1.TabIndex = 34
        Me.ComboBox1.Text = "(custom)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Default schemes"
        '
        'TerminateTimer
        '
        Me.TerminateTimer.Enabled = True
        '
        'ApplyTheme
        '
        Me.ApplyTheme.Interval = 2000
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Button11)
        Me.GroupBox1.Controls.Add(Me.Button10)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(391, 317)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 100)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Font settings"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Location = New System.Drawing.Point(150, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(147, 79)
        Me.Panel1.TabIndex = 7
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.MainFont)
        Me.FlowLayoutPanel1.Controls.Add(Me.TitleFont)
        Me.FlowLayoutPanel1.Controls.Add(Me.MessageFont)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(147, 79)
        Me.FlowLayoutPanel1.TabIndex = 24
        Me.FlowLayoutPanel1.WrapContents = False
        '
        'MainFont
        '
        Me.MainFont.AutoSize = True
        Me.MainFont.Location = New System.Drawing.Point(3, 0)
        Me.MainFont.Name = "MainFont"
        Me.MainFont.Size = New System.Drawing.Size(60, 13)
        Me.MainFont.TabIndex = 8
        Me.MainFont.Text = "ABC (Main)"
        '
        'TitleFont
        '
        Me.TitleFont.AutoSize = True
        Me.TitleFont.BackColor = System.Drawing.Color.DimGray
        Me.TitleFont.ForeColor = System.Drawing.Color.White
        Me.TitleFont.Location = New System.Drawing.Point(3, 13)
        Me.TitleFont.Name = "TitleFont"
        Me.TitleFont.Size = New System.Drawing.Size(57, 13)
        Me.TitleFont.TabIndex = 6
        Me.TitleFont.Text = "ABC (Title)"
        '
        'MessageFont
        '
        Me.MessageFont.AutoSize = True
        Me.MessageFont.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.MessageFont.Location = New System.Drawing.Point(3, 26)
        Me.MessageFont.Name = "MessageFont"
        Me.MessageFont.Size = New System.Drawing.Size(121, 20)
        Me.MessageFont.TabIndex = 9
        Me.MessageFont.Text = "ABC (Message)"
        '
        'Button11
        '
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Location = New System.Drawing.Point(81, 72)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(63, 25)
        Me.Button11.TabIndex = 9
        Me.Button11.Text = "Change"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Location = New System.Drawing.Point(81, 44)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(63, 27)
        Me.Button10.TabIndex = 8
        Me.Button10.Text = "Change"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(81, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 25)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Change"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Message font: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Title bar: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Main font: "
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.FlowLayoutPanel2)
        Me.GroupBox5.Location = New System.Drawing.Point(24, 294)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(361, 123)
        Me.GroupBox5.TabIndex = 38
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Desktop background"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.PictureBox1)
        Me.FlowLayoutPanel2.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(355, 104)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Windowed_OS.My.Resources.Resources.startup1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(124, 101)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button13)
        Me.Panel2.Controls.Add(Me.Button12)
        Me.Panel2.Controls.Add(Me.ListBox1)
        Me.Panel2.Location = New System.Drawing.Point(133, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(218, 100)
        Me.Panel2.TabIndex = 1
        '
        'Button13
        '
        Me.Button13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Location = New System.Drawing.Point(34, 74)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(66, 23)
        Me.Button13.TabIndex = 6
        Me.Button13.Text = "Solid color"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Location = New System.Drawing.Point(0, 74)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(28, 23)
        Me.Button12.TabIndex = 5
        Me.Button12.Text = "..."
        Me.Button12.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Flowers", "Blue burst", "Windowed OS logo (DAR system)"})
        Me.ListBox1.Location = New System.Drawing.Point(0, 0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(218, 67)
        Me.ListBox1.TabIndex = 36
        '
        'SystemFontDialog
        '
        Me.SystemFontDialog.Color = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        '
        'SolidColorDialog
        '
        Me.SolidColorDialog.AnyColor = True
        Me.SolidColorDialog.FullOpen = True
        Me.SolidColorDialog.SolidColorOnly = True
        '
        'BackgroundImageDialog
        '
        Me.BackgroundImageDialog.Filter = "Common picture types (*.jpg,*.png,*.jpeg,*.tiff,*.bmp)|*.bmp;*.jpg;*.jpeg;*.png;*" &
    ".tiff|All files (*.*)|*.*"
        Me.BackgroundImageDialog.FilterIndex = 0
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Location = New System.Drawing.Point(332, 420)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(369, 38)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Warning: Changing the font to a very large size may make some objects in windows " &
    "unreachable. If this happens, press F7 to restore the defaults."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CustomizationCenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(704, 458)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.WindowBackground)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CustomizationCenter"
        Me.Opacity = 0R
        Me.ShowIcon = False
        Me.Text = "Customization Panel"
        Me.TopMost = True
        Me.WindowBackground.ResumeLayout(False)
        CType(Me.apiImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents WindowBackground As System.Windows.Forms.GroupBox
    Friend WithEvents WindowButton As System.Windows.Forms.Button
    Friend WithEvents WindowText As System.Windows.Forms.Label
    Friend WithEvents apiImage As System.Windows.Forms.PictureBox
    Friend WithEvents WindowTitle As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BottomRightButton As System.Windows.Forms.RadioButton
    Friend WithEvents RightButton As System.Windows.Forms.RadioButton
    Friend WithEvents TopRightButton As System.Windows.Forms.RadioButton
    Friend WithEvents BottomButton As System.Windows.Forms.RadioButton
    Friend WithEvents TopButton As System.Windows.Forms.RadioButton
    Friend WithEvents NoneButton As System.Windows.Forms.RadioButton
    Friend WithEvents BottomLeftButton As System.Windows.Forms.RadioButton
    Friend WithEvents TopLeftButton As System.Windows.Forms.RadioButton
    Friend WithEvents LeftButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BottomRight As System.Windows.Forms.RadioButton
    Friend WithEvents RightBtn As System.Windows.Forms.RadioButton
    Friend WithEvents TopRight As System.Windows.Forms.RadioButton
    Friend WithEvents BottomBtn As System.Windows.Forms.RadioButton
    Friend WithEvents TopBtn As System.Windows.Forms.RadioButton
    Friend WithEvents None As System.Windows.Forms.RadioButton
    Friend WithEvents BottomLeft As System.Windows.Forms.RadioButton
    Friend WithEvents TopLeft As System.Windows.Forms.RadioButton
    Friend WithEvents LeftBtn As System.Windows.Forms.RadioButton
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents ThemeChangerDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TerminateTimer As System.Windows.Forms.Timer
    Friend WithEvents ApplyTheme As System.Windows.Forms.Timer
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents MainFont As Label
    Friend WithEvents TitleFont As Label
    Friend WithEvents MessageFont As Label
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button13 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents SystemFontDialog As FontDialog
    Friend WithEvents SolidColorDialog As ColorDialog
    Friend WithEvents BackgroundImageDialog As OpenFileDialog
    Friend WithEvents Label6 As Label
End Class
