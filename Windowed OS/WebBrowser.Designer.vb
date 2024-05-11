<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WebBrowser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WebBrowser))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoBackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoForwardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetAsHomepageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomePageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopNavigationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FullScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowDesktopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ResizeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.LoadTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TerminateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(660, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Web Explorer"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBox1.Location = New System.Drawing.Point(171, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(438, 23)
        Me.TextBox1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Button1.Location = New System.Drawing.Point(615, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "&Go"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(6, 20)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(161, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.FileToolStripMenuItem.Text = "Program"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.Windowed_OS.My.Resources.Resources._exit
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ExitToolStripMenuItem.Text = "Close"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Image = Global.Windowed_OS.My.Resources.Resources._exit
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoBackToolStripMenuItem, Me.GoForwardToolStripMenuItem, Me.SetAsHomepageToolStripMenuItem, Me.HomePageToolStripMenuItem, Me.RefreshToolStripMenuItem, Me.StopNavigationToolStripMenuItem, Me.FullScreenToolStripMenuItem, Me.ShowDesktopToolStripMenuItem, Me.HistoryToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.EditToolStripMenuItem.Text = "View"
        '
        'GoBackToolStripMenuItem
        '
        Me.GoBackToolStripMenuItem.Name = "GoBackToolStripMenuItem"
        Me.GoBackToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.GoBackToolStripMenuItem.Text = "Go back"
        '
        'GoForwardToolStripMenuItem
        '
        Me.GoForwardToolStripMenuItem.Name = "GoForwardToolStripMenuItem"
        Me.GoForwardToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.GoForwardToolStripMenuItem.Text = "Go forward"
        '
        'SetAsHomepageToolStripMenuItem
        '
        Me.SetAsHomepageToolStripMenuItem.Name = "SetAsHomepageToolStripMenuItem"
        Me.SetAsHomepageToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SetAsHomepageToolStripMenuItem.Text = "Set as homepage"
        '
        'HomePageToolStripMenuItem
        '
        Me.HomePageToolStripMenuItem.Name = "HomePageToolStripMenuItem"
        Me.HomePageToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.HomePageToolStripMenuItem.Text = "Home page"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'StopNavigationToolStripMenuItem
        '
        Me.StopNavigationToolStripMenuItem.Name = "StopNavigationToolStripMenuItem"
        Me.StopNavigationToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.StopNavigationToolStripMenuItem.Text = "Stop navigation"
        '
        'FullScreenToolStripMenuItem
        '
        Me.FullScreenToolStripMenuItem.Name = "FullScreenToolStripMenuItem"
        Me.FullScreenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.FullScreenToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.FullScreenToolStripMenuItem.Text = "Full screen"
        '
        'ShowDesktopToolStripMenuItem
        '
        Me.ShowDesktopToolStripMenuItem.Name = "ShowDesktopToolStripMenuItem"
        Me.ShowDesktopToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ShowDesktopToolStripMenuItem.Text = "Show desktop"
        '
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.HistoryToolStripMenuItem.Text = "History"
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
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "Abo&ut"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(4, 21)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(161, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Exit fullscreen"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.Label2.Location = New System.Drawing.Point(654, 499)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 10)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "/"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'ResizeTimer
        '
        Me.ResizeTimer.Interval = 10
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DimGray
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(648, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "H"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(4, 498)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(88, 10)
        Me.ProgressBar1.TabIndex = 9
        Me.ProgressBar1.Visible = False
        '
        'LoadTimer
        '
        Me.LoadTimer.Enabled = True
        Me.LoadTimer.Interval = 1000
        '
        'TerminateTimer
        '
        Me.TerminateTimer.Enabled = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(501, 243)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 10
        Me.ListBox1.Visible = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.AllowWebBrowserDrop = False
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser1.Location = New System.Drawing.Point(4, 50)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(661, 458)
        Me.WebBrowser1.TabIndex = 11
        '
        'WebBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(666, 508)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(326, 48)
        Me.Name = "WebBrowser"
        Me.Opacity = 0R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Web Explorer"
        Me.TopMost = True
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GoBackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GoForwardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StopNavigationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HomePageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FullScreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowDesktopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ResizeTimer As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents LoadTimer As Timer
    Friend WithEvents TerminateTimer As System.Windows.Forms.Timer
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetAsHomepageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
End Class
