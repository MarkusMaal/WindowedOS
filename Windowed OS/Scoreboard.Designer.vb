<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scoreboard
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Team1 = New System.Windows.Forms.Label()
        Me.Team2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Name1 = New System.Windows.Forms.Label()
        Me.Name2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ResizeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.KillTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeNameForTeam1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeNameForTeam2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EndProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDesktopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MakesuretocloseTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.DimGray
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(756, 14)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Scoreboard"
        '
        'Team1
        '
        Me.Team1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Team1.BackColor = System.Drawing.Color.Transparent
        Me.Team1.Font = New System.Drawing.Font("Microsoft Sans Serif", 102.0!)
        Me.Team1.Location = New System.Drawing.Point(22, 124)
        Me.Team1.Name = "Team1"
        Me.Team1.Size = New System.Drawing.Size(306, 154)
        Me.Team1.TabIndex = 12
        Me.Team1.Text = "0"
        '
        'Team2
        '
        Me.Team2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Team2.BackColor = System.Drawing.Color.Transparent
        Me.Team2.Font = New System.Drawing.Font("Microsoft Sans Serif", 102.0!)
        Me.Team2.Location = New System.Drawing.Point(455, 124)
        Me.Team2.Name = "Team2"
        Me.Team2.Size = New System.Drawing.Size(284, 154)
        Me.Team2.TabIndex = 13
        Me.Team2.Text = "0"
        Me.Team2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 102.0!)
        Me.Label3.Location = New System.Drawing.Point(312, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 154)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "-"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Name1
        '
        Me.Name1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Name1.BackColor = System.Drawing.Color.Transparent
        Me.Name1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Name1.Location = New System.Drawing.Point(12, 88)
        Me.Name1.Name = "Name1"
        Me.Name1.Size = New System.Drawing.Size(316, 36)
        Me.Name1.TabIndex = 15
        Me.Name1.Text = "Team 1"
        '
        'Name2
        '
        Me.Name2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Name2.BackColor = System.Drawing.Color.Transparent
        Me.Name2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Name2.Location = New System.Drawing.Point(423, 88)
        Me.Name2.Name = "Name2"
        Me.Name2.Size = New System.Drawing.Size(316, 36)
        Me.Name2.TabIndex = 16
        Me.Name2.Text = "Team 2"
        Me.Name2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(18, 281)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(720, 281)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(23, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "+"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(770, 305)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(66, 23)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Reset"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(770, 334)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(143, 23)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "Change name for Team 1"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(770, 363)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(143, 23)
        Me.Button5.TabIndex = 22
        Me.Button5.Text = "Change name for Team 2"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(842, 305)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(71, 23)
        Me.Button6.TabIndex = 23
        Me.Button6.Text = "Exit"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.Label5.Location = New System.Drawing.Point(752, 314)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(11, 10)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "/"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'ResizeTimer
        '
        Me.ResizeTimer.Interval = 10
        '
        'KillTimer
        '
        Me.KillTimer.Enabled = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatorToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(5, 19)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(295, 24)
        Me.MenuStrip1.TabIndex = 40
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeNameForTeam1ToolStripMenuItem, Me.ChangeNameForTeam2ToolStripMenuItem, Me.ResetToolStripMenuItem, Me.ExitToolStripMenuItem, Me.EndProcessToolStripMenuItem})
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.CalculatorToolStripMenuItem.Text = "Scoreboard"
        '
        'ChangeNameForTeam1ToolStripMenuItem
        '
        Me.ChangeNameForTeam1ToolStripMenuItem.Name = "ChangeNameForTeam1ToolStripMenuItem"
        Me.ChangeNameForTeam1ToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.ChangeNameForTeam1ToolStripMenuItem.Text = "Change name for Team 1"
        '
        'ChangeNameForTeam2ToolStripMenuItem
        '
        Me.ChangeNameForTeam2ToolStripMenuItem.Name = "ChangeNameForTeam2ToolStripMenuItem"
        Me.ChangeNameForTeam2ToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.ChangeNameForTeam2ToolStripMenuItem.Text = "Change name for Team 2"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.Windowed_OS.My.Resources.Resources._exit
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.ExitToolStripMenuItem.Text = "Close"
        '
        'EndProcessToolStripMenuItem
        '
        Me.EndProcessToolStripMenuItem.Image = Global.Windowed_OS.My.Resources.Resources._exit
        Me.EndProcessToolStripMenuItem.Name = "EndProcessToolStripMenuItem"
        Me.EndProcessToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.EndProcessToolStripMenuItem.Text = "Exit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewDesktopToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ViewDesktopToolStripMenuItem
        '
        Me.ViewDesktopToolStripMenuItem.Name = "ViewDesktopToolStripMenuItem"
        Me.ViewDesktopToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.ViewDesktopToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ViewDesktopToolStripMenuItem.Text = "View desktop"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'MakesuretocloseTimer
        '
        Me.MakesuretocloseTimer.Enabled = True
        Me.MakesuretocloseTimer.Interval = 10
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(744, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "H"
        '
        'Scoreboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 322)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Name2)
        Me.Controls.Add(Me.Name1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Team2)
        Me.Controls.Add(Me.Team1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Scoreboard"
        Me.Opacity = 0R
        Me.ShowIcon = False
        Me.Text = "Scoreboard"
        Me.TopMost = True
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Team1 As System.Windows.Forms.Label
    Friend WithEvents Team2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Name1 As System.Windows.Forms.Label
    Friend WithEvents Name2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ResizeTimer As System.Windows.Forms.Timer
    Friend WithEvents KillTimer As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeNameForTeam1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeNameForTeam2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EndProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MakesuretocloseTimer As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewDesktopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
