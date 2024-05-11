<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Paintbrush
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
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvatarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDesktopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResizeToPhysicalResolutionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrushesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CircleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RectangleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PtToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PtToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PtToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PtToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PtToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GradientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GradienthorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaintBucketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForegroundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecondaryForegroundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TutorialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ResizeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.KillTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShowDrawingHistorydevToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label4.Size = New System.Drawing.Size(573, 14)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Image Drawer"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.BrushesToolStripMenuItem, Me.ColorsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(9, 18)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(382, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ExitToolStripMenuItem1, Me.AvatarToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = Global.Windowed_OS.My.Resources.Resources._new
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = Global.Windowed_OS.My.Resources.Resources.load
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Image = Global.Windowed_OS.My.Resources.Resources.save
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save as"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.Windowed_OS.My.Resources.Resources._exit
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Close"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Image = Global.Windowed_OS.My.Resources.Resources._exit
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'AvatarToolStripMenuItem
        '
        Me.AvatarToolStripMenuItem.Name = "AvatarToolStripMenuItem"
        Me.AvatarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AvatarToolStripMenuItem.Text = "Avatar"
        Me.AvatarToolStripMenuItem.Visible = False
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewDesktopToolStripMenuItem, Me.ResizeToPhysicalResolutionToolStripMenuItem, Me.ShowDrawingHistorydevToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ViewDesktopToolStripMenuItem
        '
        Me.ViewDesktopToolStripMenuItem.Name = "ViewDesktopToolStripMenuItem"
        Me.ViewDesktopToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.ViewDesktopToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ViewDesktopToolStripMenuItem.Text = "View desktop"
        '
        'ResizeToPhysicalResolutionToolStripMenuItem
        '
        Me.ResizeToPhysicalResolutionToolStripMenuItem.Name = "ResizeToPhysicalResolutionToolStripMenuItem"
        Me.ResizeToPhysicalResolutionToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ResizeToPhysicalResolutionToolStripMenuItem.Text = "Resize to physical resolution"
        '
        'BrushesToolStripMenuItem
        '
        Me.BrushesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LineToolStripMenuItem, Me.CircleToolStripMenuItem, Me.RectangleToolStripMenuItem, Me.PaintBucketToolStripMenuItem, Me.SizeToolStripMenuItem, Me.GradientToolStripMenuItem, Me.GradienthorizontalToolStripMenuItem, Me.AddTextToolStripMenuItem})
        Me.BrushesToolStripMenuItem.Name = "BrushesToolStripMenuItem"
        Me.BrushesToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.BrushesToolStripMenuItem.Text = "Brushes"
        '
        'LineToolStripMenuItem
        '
        Me.LineToolStripMenuItem.Checked = True
        Me.LineToolStripMenuItem.CheckOnClick = True
        Me.LineToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LineToolStripMenuItem.Name = "LineToolStripMenuItem"
        Me.LineToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LineToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.LineToolStripMenuItem.Text = "Line"
        '
        'CircleToolStripMenuItem
        '
        Me.CircleToolStripMenuItem.CheckOnClick = True
        Me.CircleToolStripMenuItem.Name = "CircleToolStripMenuItem"
        Me.CircleToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CircleToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.CircleToolStripMenuItem.Text = "Circle"
        '
        'RectangleToolStripMenuItem
        '
        Me.RectangleToolStripMenuItem.CheckOnClick = True
        Me.RectangleToolStripMenuItem.Name = "RectangleToolStripMenuItem"
        Me.RectangleToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RectangleToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.RectangleToolStripMenuItem.Text = "Rectangle"
        '
        'SizeToolStripMenuItem
        '
        Me.SizeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PtToolStripMenuItem, Me.PtToolStripMenuItem1, Me.PtToolStripMenuItem2, Me.PtToolStripMenuItem3, Me.PtToolStripMenuItem4, Me.PtToolStripMenuItem5})
        Me.SizeToolStripMenuItem.Name = "SizeToolStripMenuItem"
        Me.SizeToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.SizeToolStripMenuItem.Text = "Size"
        '
        'PtToolStripMenuItem
        '
        Me.PtToolStripMenuItem.CheckOnClick = True
        Me.PtToolStripMenuItem.Name = "PtToolStripMenuItem"
        Me.PtToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.PtToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.PtToolStripMenuItem.Text = "1 pt"
        '
        'PtToolStripMenuItem1
        '
        Me.PtToolStripMenuItem1.Checked = True
        Me.PtToolStripMenuItem1.CheckOnClick = True
        Me.PtToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PtToolStripMenuItem1.Name = "PtToolStripMenuItem1"
        Me.PtToolStripMenuItem1.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.F3), System.Windows.Forms.Keys)
        Me.PtToolStripMenuItem1.Size = New System.Drawing.Size(184, 22)
        Me.PtToolStripMenuItem1.Text = "3 pt"
        '
        'PtToolStripMenuItem2
        '
        Me.PtToolStripMenuItem2.CheckOnClick = True
        Me.PtToolStripMenuItem2.Name = "PtToolStripMenuItem2"
        Me.PtToolStripMenuItem2.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.F5), System.Windows.Forms.Keys)
        Me.PtToolStripMenuItem2.Size = New System.Drawing.Size(184, 22)
        Me.PtToolStripMenuItem2.Text = "5 pt"
        '
        'PtToolStripMenuItem3
        '
        Me.PtToolStripMenuItem3.CheckOnClick = True
        Me.PtToolStripMenuItem3.Name = "PtToolStripMenuItem3"
        Me.PtToolStripMenuItem3.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.F10), System.Windows.Forms.Keys)
        Me.PtToolStripMenuItem3.Size = New System.Drawing.Size(184, 22)
        Me.PtToolStripMenuItem3.Text = "10 pt"
        '
        'PtToolStripMenuItem4
        '
        Me.PtToolStripMenuItem4.CheckOnClick = True
        Me.PtToolStripMenuItem4.Name = "PtToolStripMenuItem4"
        Me.PtToolStripMenuItem4.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.F20), System.Windows.Forms.Keys)
        Me.PtToolStripMenuItem4.Size = New System.Drawing.Size(184, 22)
        Me.PtToolStripMenuItem4.Text = "20 pt"
        '
        'PtToolStripMenuItem5
        '
        Me.PtToolStripMenuItem5.CheckOnClick = True
        Me.PtToolStripMenuItem5.Name = "PtToolStripMenuItem5"
        Me.PtToolStripMenuItem5.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F5), System.Windows.Forms.Keys)
        Me.PtToolStripMenuItem5.Size = New System.Drawing.Size(184, 22)
        Me.PtToolStripMenuItem5.Text = "50 pt"
        '
        'GradientToolStripMenuItem
        '
        Me.GradientToolStripMenuItem.CheckOnClick = True
        Me.GradientToolStripMenuItem.Name = "GradientToolStripMenuItem"
        Me.GradientToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GradientToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.GradientToolStripMenuItem.Text = "Gradient (vertical)"
        Me.GradientToolStripMenuItem.ToolTipText = "Allows brush to have a two color gradient vertically"
        '
        'GradienthorizontalToolStripMenuItem
        '
        Me.GradienthorizontalToolStripMenuItem.CheckOnClick = True
        Me.GradienthorizontalToolStripMenuItem.Name = "GradienthorizontalToolStripMenuItem"
        Me.GradienthorizontalToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GradienthorizontalToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.GradienthorizontalToolStripMenuItem.Text = "Gradient (horizontal)"
        Me.GradienthorizontalToolStripMenuItem.ToolTipText = "Allows brush to have a gradient horizontally"
        '
        'AddTextToolStripMenuItem
        '
        Me.AddTextToolStripMenuItem.Name = "AddTextToolStripMenuItem"
        Me.AddTextToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.AddTextToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.AddTextToolStripMenuItem.Text = "Add text"
        '
        'PaintBucketToolStripMenuItem
        '
        Me.PaintBucketToolStripMenuItem.CheckOnClick = True
        Me.PaintBucketToolStripMenuItem.Name = "PaintBucketToolStripMenuItem"
        Me.PaintBucketToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.PaintBucketToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.PaintBucketToolStripMenuItem.Text = "Flood"
        '
        'ColorsToolStripMenuItem
        '
        Me.ColorsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackgroundToolStripMenuItem, Me.ForegroundToolStripMenuItem, Me.SecondaryForegroundToolStripMenuItem})
        Me.ColorsToolStripMenuItem.Image = Global.Windowed_OS.My.Resources.Resources.colors
        Me.ColorsToolStripMenuItem.Name = "ColorsToolStripMenuItem"
        Me.ColorsToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.ColorsToolStripMenuItem.Text = "Colors"
        '
        'BackgroundToolStripMenuItem
        '
        Me.BackgroundToolStripMenuItem.Name = "BackgroundToolStripMenuItem"
        Me.BackgroundToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BackgroundToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.BackgroundToolStripMenuItem.Text = "Background"
        '
        'ForegroundToolStripMenuItem
        '
        Me.ForegroundToolStripMenuItem.Name = "ForegroundToolStripMenuItem"
        Me.ForegroundToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.ForegroundToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.ForegroundToolStripMenuItem.Text = "Foreground"
        '
        'SecondaryForegroundToolStripMenuItem
        '
        Me.SecondaryForegroundToolStripMenuItem.Name = "SecondaryForegroundToolStripMenuItem"
        Me.SecondaryForegroundToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.SecondaryForegroundToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.SecondaryForegroundToolStripMenuItem.Text = "Secondary foreground"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TutorialToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'TutorialToolStripMenuItem
        '
        Me.TutorialToolStripMenuItem.Name = "TutorialToolStripMenuItem"
        Me.TutorialToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.TutorialToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.TutorialToolStripMenuItem.Text = "Documentation"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Image files|*.jpg;*.bmp;*.png;*.jpeg;*.jpe;*.gif;*.tif;*.tiff"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.Label5.Location = New System.Drawing.Point(572, 325)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(11, 10)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "/"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'ResizeTimer
        '
        Me.ResizeTimer.Interval = 10
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "*.png"
        Me.SaveFileDialog1.Filter = "Portable Network Graphics|*.png"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(6, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(570, 277)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'KillTimer
        '
        Me.KillTimer.Enabled = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DimGray
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(561, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "H"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(324, 240)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(126, 95)
        Me.TextBox1.TabIndex = 16
        Me.TextBox1.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(456, 240)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 17
        Me.ListBox1.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(286, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 24)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "X: 0, Y:0"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ShowDrawingHistorydevToolStripMenuItem
        '
        Me.ShowDrawingHistorydevToolStripMenuItem.Name = "ShowDrawingHistorydevToolStripMenuItem"
        Me.ShowDrawingHistorydevToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ShowDrawingHistorydevToolStripMenuItem.Text = "Show drawing history (dev)"
        Me.ShowDrawingHistorydevToolStripMenuItem.Visible = False
        '
        'Paintbrush
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(579, 334)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Paintbrush"
        Me.Opacity = 0R
        Me.ShowIcon = False
        Me.Text = "paintbrush"
        Me.TopMost = True
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrushesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CircleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RectangleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ForegroundToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PtToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PtToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PtToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PtToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PtToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ResizeTimer As System.Windows.Forms.Timer
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TutorialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KillTimer As System.Windows.Forms.Timer
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GradientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GradienthorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddTextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SecondaryForegroundToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewDesktopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents AvatarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResizeToPhysicalResolutionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaintBucketToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents ShowDrawingHistorydevToolStripMenuItem As ToolStripMenuItem
End Class
