<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GlobalSysConfig
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.BsBgDialog = New System.Windows.Forms.OpenFileDialog()
        Me.GDBDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TerminateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(695, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Global system configuration panel"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.Windowed_OS.My.Resources.Resources.startup1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(12, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(376, 302)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Boot screen"
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Location = New System.Drawing.Point(12, 362)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(154, 17)
        Me.CheckBox1.TabIndex = 17
        Me.CheckBox1.Text = "Display system load window"
        Me.ToolTip1.SetToolTip(Me.CheckBox1, "Displays the loading window with the progress bar during startup.")
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox2.Location = New System.Drawing.Point(12, 385)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(112, 17)
        Me.CheckBox2.TabIndex = 18
        Me.CheckBox2.Text = "Enable bootscreen"
        Me.ToolTip1.SetToolTip(Me.CheckBox2, "Displays an image during startup.")
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(405, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "System sounds"
        '
        'CheckBox3
        '
        Me.CheckBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Checked = True
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox3.Location = New System.Drawing.Point(407, 48)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(128, 17)
        Me.CheckBox3.TabIndex = 20
        Me.CheckBox3.Text = "Enable system sounds"
        Me.ToolTip1.SetToolTip(Me.CheckBox3, "Allows system to play notification sounds during startup, shutdown, sleep, wake u" &
        "p, lock, unlock, errors, information dialogs, questions and warnings.")
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(404, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(232, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Bootscreen, Guest/Limited, Login screen theme"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(12, 414)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Change background image"
        Me.ToolTip1.SetToolTip(Me.Button1, "Customize the image system displays when booting up.")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(407, 84)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(263, 23)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Copy current theme"
        Me.ToolTip1.SetToolTip(Me.Button2, "Applies current theme system wide (with the exception of other existing users)")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(407, 113)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(263, 23)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Change global desktop background"
        Me.ToolTip1.SetToolTip(Me.Button3, "Change the desktop background for new users.")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Checked = True
        Me.CheckBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox4.Location = New System.Drawing.Point(407, 157)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(217, 17)
        Me.CheckBox4.TabIndex = 25
        Me.CheckBox4.Text = "Display date and time on the login screen"
        Me.ToolTip1.SetToolTip(Me.CheckBox4, "Displays date and time on the top right corner of the screen when not logged in.")
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'BsBgDialog
        '
        Me.BsBgDialog.FileName = "def"
        Me.BsBgDialog.Filter = "Typical image file formats|*.jpg;*.png;*.gif;*.jpeg;*.tiff;*.tif;*.jpe;*.wmf"
        Me.BsBgDialog.Title = "Choose background image for the bootscreen"
        '
        'GDBDialog
        '
        Me.GDBDialog.FileName = "Local_1"
        Me.GDBDialog.Filter = "Typical image file formats|*.jpg;*.png;*.gif;*.jpeg;*.tiff;*.tif;*.jpe;*.wmf"
        Me.GDBDialog.Title = "Choose global desktop background image"
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(603, 414)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 23)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "OK"
        Me.ToolTip1.SetToolTip(Me.Button4, "Applies these changes to be applied during next startup.")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(517, 414)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 23)
        Me.Button5.TabIndex = 27
        Me.Button5.Text = "Cancel"
        Me.ToolTip1.SetToolTip(Me.Button5, "Discards current changes")
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Location = New System.Drawing.Point(391, 374)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(292, 37)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Note: You must restart Windowed OS in order for these settings to take effect."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(163, 414)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(103, 23)
        Me.Button6.TabIndex = 29
        Me.Button6.Text = "Restore default"
        Me.ToolTip1.SetToolTip(Me.Button6, "Restores default startup image.")
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TerminateTimer
        '
        Me.TerminateTimer.Enabled = True
        '
        'CheckBox5
        '
        Me.CheckBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Checked = True
        Me.CheckBox5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox5.Location = New System.Drawing.Point(407, 180)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(207, 17)
        Me.CheckBox5.TabIndex = 30
        Me.CheckBox5.Text = "Display user names on the login screen"
        Me.ToolTip1.SetToolTip(Me.CheckBox5, "If this check box is checked, all usernames and account images will be displayed " &
        "on the login screen. Otherwise, it will use a simple login prompt with username " &
        "and password fiields.")
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Checked = True
        Me.CheckBox6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox6.Location = New System.Drawing.Point(407, 203)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(235, 17)
        Me.CheckBox6.TabIndex = 31
        Me.CheckBox6.Text = "Allow switching the mode on the login screen"
        Me.ToolTip1.SetToolTip(Me.CheckBox6, "Allows users to switch between two login screen modes:  Classic and New.")
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Checked = True
        Me.CheckBox7.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox7.Location = New System.Drawing.Point(407, 226)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(277, 17)
        Me.CheckBox7.TabIndex = 32
        Me.CheckBox7.Text = "Allow shutting down and restarting on the login screen"
        Me.ToolTip1.SetToolTip(Me.CheckBox7, "Allow any user to shut down or restart the machine without logging in first.")
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Checked = True
        Me.CheckBox8.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox8.Location = New System.Drawing.Point(408, 246)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(292, 30)
        Me.CheckBox8.TabIndex = 33
        Me.CheckBox8.Text = "Remember user accounts background image and apply it" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "on the login screen"
        Me.ToolTip1.SetToolTip(Me.CheckBox8, "A default feature in Windowed OS that applies last logged in users background ima" &
        "ge to the login screen. If you don't want this feature, check this box.")
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Checked = True
        Me.CheckBox9.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox9.Location = New System.Drawing.Point(408, 282)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(229, 17)
        Me.CheckBox9.TabIndex = 34
        Me.CheckBox9.Text = "Display autologin button on the login screen"
        Me.ToolTip1.SetToolTip(Me.CheckBox9, "This check box allows users to start Windowed OS right to their desktop, no login" &
        " required.")
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox10.Location = New System.Drawing.Point(408, 328)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(180, 17)
        Me.CheckBox10.TabIndex = 35
        Me.CheckBox10.Text = "Welcome message during startup"
        Me.ToolTip1.SetToolTip(Me.CheckBox10, "Displays a welcome message before login screen or autologon.")
        Me.CheckBox10.UseVisualStyleBackColor = True
        Me.CheckBox10.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(406, 351)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(277, 20)
        Me.TextBox1.TabIndex = 36
        Me.TextBox1.Text = "This message will be displayed when the system starts up"
        Me.TextBox1.Visible = False
        '
        'CheckBox11
        '
        Me.CheckBox11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox11.Location = New System.Drawing.Point(408, 305)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(109, 17)
        Me.CheckBox11.TabIndex = 37
        Me.CheckBox11.Text = "Display watermark"
        Me.ToolTip1.SetToolTip(Me.CheckBox11, "Shows system version info on the login screen and desktop.")
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(404, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Login and startup"
        '
        'GlobalSysConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(699, 449)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CheckBox11)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CheckBox10)
        Me.Controls.Add(Me.CheckBox9)
        Me.Controls.Add(Me.CheckBox8)
        Me.Controls.Add(Me.CheckBox7)
        Me.Controls.Add(Me.CheckBox6)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GlobalSysConfig"
        Me.Opacity = 0R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GlobalSysConfig"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents BsBgDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GDBDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TerminateTimer As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CheckBox11 As CheckBox
    Friend WithEvents Label6 As Label
End Class
