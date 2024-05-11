<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class simon
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FreeModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GameSpeedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SlowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MediumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FastToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GameplayRulesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DimTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.showtimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.KillTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkRed
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(25, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 100)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Button2.ForeColor = System.Drawing.Color.Lime
        Me.Button2.Location = New System.Drawing.Point(142, 65)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 100)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Button3.ForeColor = System.Drawing.Color.Blue
        Me.Button3.Location = New System.Drawing.Point(142, 180)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 100)
        Me.Button3.TabIndex = 3
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Olive
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Button4.ForeColor = System.Drawing.Color.Yellow
        Me.Button4.Location = New System.Drawing.Point(25, 180)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 100)
        Me.Button4.TabIndex = 2
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.DimGray
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(4, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(258, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Simon"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(7, 20)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(102, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GameToolStripMenuItem
        '
        Me.GameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestartToolStripMenuItem, Me.FreeModeToolStripMenuItem, Me.CloseToolStripMenuItem, Me.GameSpeedToolStripMenuItem})
        Me.GameToolStripMenuItem.Name = "GameToolStripMenuItem"
        Me.GameToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.GameToolStripMenuItem.Text = "Game"
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.RestartToolStripMenuItem.Text = "Restart"
        '
        'FreeModeToolStripMenuItem
        '
        Me.FreeModeToolStripMenuItem.Name = "FreeModeToolStripMenuItem"
        Me.FreeModeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F2), System.Windows.Forms.Keys)
        Me.FreeModeToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.FreeModeToolStripMenuItem.Text = "Free mode"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'GameSpeedToolStripMenuItem
        '
        Me.GameSpeedToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SlowToolStripMenuItem, Me.MediumToolStripMenuItem, Me.FastToolStripMenuItem})
        Me.GameSpeedToolStripMenuItem.Name = "GameSpeedToolStripMenuItem"
        Me.GameSpeedToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.GameSpeedToolStripMenuItem.Text = "Game speed"
        '
        'SlowToolStripMenuItem
        '
        Me.SlowToolStripMenuItem.Checked = True
        Me.SlowToolStripMenuItem.CheckOnClick = True
        Me.SlowToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SlowToolStripMenuItem.Name = "SlowToolStripMenuItem"
        Me.SlowToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.SlowToolStripMenuItem.Text = "Slow"
        '
        'MediumToolStripMenuItem
        '
        Me.MediumToolStripMenuItem.CheckOnClick = True
        Me.MediumToolStripMenuItem.Name = "MediumToolStripMenuItem"
        Me.MediumToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.MediumToolStripMenuItem.Text = "Medium"
        '
        'FastToolStripMenuItem
        '
        Me.FastToolStripMenuItem.CheckOnClick = True
        Me.FastToolStripMenuItem.Name = "FastToolStripMenuItem"
        Me.FastToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.FastToolStripMenuItem.Text = "Fast"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameplayRulesToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'GameplayRulesToolStripMenuItem
        '
        Me.GameplayRulesToolStripMenuItem.Name = "GameplayRulesToolStripMenuItem"
        Me.GameplayRulesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.GameplayRulesToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.GameplayRulesToolStripMenuItem.Text = "Gameplay / Rules"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'DimTimer
        '
        Me.DimTimer.Interval = 1000
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(54, 301)
        Me.ProgressBar1.Maximum = 2
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(55, 23)
        Me.ProgressBar1.TabIndex = 15
        Me.ProgressBar1.Visible = False
        '
        'showtimer
        '
        Me.showtimer.Interval = 2000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(160, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(217, 307)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 17
        Me.ListBox1.Visible = False
        '
        'KillTimer
        '
        Me.KillTimer.Enabled = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Location = New System.Drawing.Point(152, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Press F2 to begin"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'simon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 322)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "simon"
        Me.Text = "simon"
        Me.TopMost = True
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GameplayRulesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DimTimer As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents showtimer As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents KillTimer As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents FreeModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GameSpeedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SlowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MediumToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FastToolStripMenuItem As ToolStripMenuItem
End Class
