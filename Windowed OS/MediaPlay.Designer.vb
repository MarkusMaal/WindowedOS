<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MediaPlay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MediaPlay))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FastForwardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FastBackwardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaximizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompactModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResizeVideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OriginalSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OriginalSizeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OfOriginalSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ResizeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TimeTracker = New System.Windows.Forms.Timer(Me.components)
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TerminateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.resizethattimer = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.MakesuretocloseTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.Label2.Location = New System.Drawing.Point(565, 389)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 10)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "/"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DimGray
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(553, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "H"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(562, 14)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Media Player"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.FormatToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(7, 21)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(185, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = Global.Windowed_OS.My.Resources.Resources.load
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.Windowed_OS.My.Resources.Resources._exit
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Close"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Image = Global.Windowed_OS.My.Resources.Resources._exit
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'FormatToolStripMenuItem
        '
        Me.FormatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem, Me.ColorsToolStripMenuItem, Me.FastForwardToolStripMenuItem, Me.FastBackwardToolStripMenuItem})
        Me.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        Me.FormatToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.FormatToolStripMenuItem.Text = "Media"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Image = Global.Windowed_OS.My.Resources.Resources.media_player
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.FontToolStripMenuItem.Text = "Play/Pause"
        '
        'ColorsToolStripMenuItem
        '
        Me.ColorsToolStripMenuItem.Name = "ColorsToolStripMenuItem"
        Me.ColorsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.ColorsToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ColorsToolStripMenuItem.Text = "Stop"
        '
        'FastForwardToolStripMenuItem
        '
        Me.FastForwardToolStripMenuItem.Name = "FastForwardToolStripMenuItem"
        Me.FastForwardToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FastForwardToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.FastForwardToolStripMenuItem.Text = "Fast forward"
        '
        'FastBackwardToolStripMenuItem
        '
        Me.FastBackwardToolStripMenuItem.Name = "FastBackwardToolStripMenuItem"
        Me.FastBackwardToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.FastBackwardToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.FastBackwardToolStripMenuItem.Text = "Fast backward"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MinimizeToolStripMenuItem, Me.MaximizeToolStripMenuItem, Me.CompactModeToolStripMenuItem, Me.ResizeVideoToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'MinimizeToolStripMenuItem
        '
        Me.MinimizeToolStripMenuItem.Name = "MinimizeToolStripMenuItem"
        Me.MinimizeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.MinimizeToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.MinimizeToolStripMenuItem.Text = "View &desktop"
        '
        'MaximizeToolStripMenuItem
        '
        Me.MaximizeToolStripMenuItem.Name = "MaximizeToolStripMenuItem"
        Me.MaximizeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.MaximizeToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.MaximizeToolStripMenuItem.Text = "&Full screen"
        '
        'CompactModeToolStripMenuItem
        '
        Me.CompactModeToolStripMenuItem.CheckOnClick = True
        Me.CompactModeToolStripMenuItem.Name = "CompactModeToolStripMenuItem"
        Me.CompactModeToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CompactModeToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.CompactModeToolStripMenuItem.Text = "Compact mode"
        '
        'ResizeVideoToolStripMenuItem
        '
        Me.ResizeVideoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OriginalSizeToolStripMenuItem, Me.OriginalSizeToolStripMenuItem1, Me.OfOriginalSizeToolStripMenuItem})
        Me.ResizeVideoToolStripMenuItem.Name = "ResizeVideoToolStripMenuItem"
        Me.ResizeVideoToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ResizeVideoToolStripMenuItem.Text = "Resize video"
        '
        'OriginalSizeToolStripMenuItem
        '
        Me.OriginalSizeToolStripMenuItem.Name = "OriginalSizeToolStripMenuItem"
        Me.OriginalSizeToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.OriginalSizeToolStripMenuItem.Text = "200% of original size"
        '
        'OriginalSizeToolStripMenuItem1
        '
        Me.OriginalSizeToolStripMenuItem1.Name = "OriginalSizeToolStripMenuItem1"
        Me.OriginalSizeToolStripMenuItem1.Size = New System.Drawing.Size(181, 22)
        Me.OriginalSizeToolStripMenuItem1.Text = "100% of original size"
        '
        'OfOriginalSizeToolStripMenuItem
        '
        Me.OfOriginalSizeToolStripMenuItem.Name = "OfOriginalSizeToolStripMenuItem"
        Me.OfOriginalSizeToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.OfOriginalSizeToolStripMenuItem.Text = "50% of original size"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DocumentationToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'DocumentationToolStripMenuItem
        '
        Me.DocumentationToolStripMenuItem.Name = "DocumentationToolStripMenuItem"
        Me.DocumentationToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.DocumentationToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DocumentationToolStripMenuItem.Text = "Documentation"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "Abo&ut"
        '
        'TrackBar1
        '
        Me.TrackBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackBar1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TrackBar1.Location = New System.Drawing.Point(456, 21)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(104, 45)
        Me.TrackBar1.TabIndex = 15
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.None
        Me.TrackBar1.Value = 50
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(405, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Volume:"
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Location = New System.Drawing.Point(411, 37)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(47, 17)
        Me.CheckBox1.TabIndex = 17
        Me.CheckBox1.Text = "Mute"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(6, 60)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(562, 305)
        Me.AxWindowsMediaPlayer1.TabIndex = 18
        Me.AxWindowsMediaPlayer1.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Common media types (*.mp3;*.mp4;*.avi;*.wav;*.aiff;*.ogg;*.flv;*.mkv;*.acc;*.wma;" &
    "*.wmv;*.aif)|*.mp3;*.mp4;*.avi;*.wav;*.aiff;*.ogg;*.flv;*.mkv;*.acc;*.wma;*.wmv;" &
    "*.aif"
        '
        'ResizeTimer
        '
        Me.ResizeTimer.Interval = 10
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(284, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 17)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "00:00/00:00"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TimeTracker
        '
        Me.TimeTracker.Enabled = True
        Me.TimeTracker.Interval = 500
        '
        'TrackBar2
        '
        Me.TrackBar2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackBar2.Cursor = System.Windows.Forms.Cursors.Default
        Me.TrackBar2.Location = New System.Drawing.Point(9, 371)
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(555, 45)
        Me.TrackBar2.TabIndex = 21
        Me.TrackBar2.TickStyle = System.Windows.Forms.TickStyle.None
        Me.TrackBar2.Visible = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(521, 389)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(14, 10)
        Me.RichTextBox1.TabIndex = 22
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.Visible = False
        '
        'TerminateTimer
        '
        Me.TerminateTimer.Enabled = True
        '
        'resizethattimer
        '
        Me.resizethattimer.Interval = 1000
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(288, 21)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(114, 17)
        Me.CheckBox2.TabIndex = 23
        Me.CheckBox2.Text = "force transparency"
        Me.CheckBox2.UseVisualStyleBackColor = True
        Me.CheckBox2.Visible = False
        '
        'MakesuretocloseTimer
        '
        Me.MakesuretocloseTimer.Interval = 10
        '
        'MediaPlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(574, 399)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.TrackBar2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(505, 79)
        Me.Name = "MediaPlay"
        Me.Opacity = 0R
        Me.Text = "Media Player"
        Me.TopMost = True
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinimizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaximizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents FastForwardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FastBackwardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ResizeTimer As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents TimeTracker As Timer
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents CompactModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TerminateTimer As System.Windows.Forms.Timer
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResizeVideoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OriginalSizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OriginalSizeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OfOriginalSizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents resizethattimer As System.Windows.Forms.Timer
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents MakesuretocloseTimer As System.Windows.Forms.Timer
    Friend WithEvents DocumentationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
