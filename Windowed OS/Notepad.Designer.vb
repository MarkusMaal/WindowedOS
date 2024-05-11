<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notepad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Notepad))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenRecentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WordWrapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaximizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WYSIWYGSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ResizeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TerminateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(4, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(471, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Notepad"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.FormatToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(5, 21)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(229, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.OpenRecentToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveasToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = Global.Windowed_OS.My.Resources.Resources._new
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = Global.Windowed_OS.My.Resources.Resources.load
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'OpenRecentToolStripMenuItem
        '
        Me.OpenRecentToolStripMenuItem.Name = "OpenRecentToolStripMenuItem"
        Me.OpenRecentToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpenRecentToolStripMenuItem.Text = "Open recent"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = Global.Windowed_OS.My.Resources.Resources.save
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveasToolStripMenuItem
        '
        Me.SaveasToolStripMenuItem.Name = "SaveasToolStripMenuItem"
        Me.SaveasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveasToolStripMenuItem.Text = "Save &as"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.Windowed_OS.My.Resources.Resources._exit
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
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
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.SelectAllToolStripMenuItem, Me.WordWrapToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = Global.Windowed_OS.My.Resources.Resources.cut
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = Global.Windowed_OS.My.Resources.Resources.copy
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = Global.Windowed_OS.My.Resources.Resources.paste
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select all"
        '
        'WordWrapToolStripMenuItem
        '
        Me.WordWrapToolStripMenuItem.CheckOnClick = True
        Me.WordWrapToolStripMenuItem.Name = "WordWrapToolStripMenuItem"
        Me.WordWrapToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.WordWrapToolStripMenuItem.Text = "WordWrap"
        '
        'FormatToolStripMenuItem
        '
        Me.FormatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem, Me.ColorsToolStripMenuItem})
        Me.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        Me.FormatToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.FormatToolStripMenuItem.Text = "Format"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Image = Global.Windowed_OS.My.Resources.Resources.fonts
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.FontToolStripMenuItem.Text = "&Font"
        '
        'ColorsToolStripMenuItem
        '
        Me.ColorsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextToolStripMenuItem, Me.BackgroundToolStripMenuItem})
        Me.ColorsToolStripMenuItem.Image = Global.Windowed_OS.My.Resources.Resources.colors
        Me.ColorsToolStripMenuItem.Name = "ColorsToolStripMenuItem"
        Me.ColorsToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.ColorsToolStripMenuItem.Text = "Colo&rs"
        '
        'TextToolStripMenuItem
        '
        Me.TextToolStripMenuItem.Name = "TextToolStripMenuItem"
        Me.TextToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.TextToolStripMenuItem.Text = "Selected text"
        '
        'BackgroundToolStripMenuItem
        '
        Me.BackgroundToolStripMenuItem.Name = "BackgroundToolStripMenuItem"
        Me.BackgroundToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.BackgroundToolStripMenuItem.Text = "Background"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MinimizeToolStripMenuItem, Me.MaximizeToolStripMenuItem, Me.WYSIWYGSystemToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'MinimizeToolStripMenuItem
        '
        Me.MinimizeToolStripMenuItem.Name = "MinimizeToolStripMenuItem"
        Me.MinimizeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.MinimizeToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.MinimizeToolStripMenuItem.Text = "View &desktop"
        '
        'MaximizeToolStripMenuItem
        '
        Me.MaximizeToolStripMenuItem.Name = "MaximizeToolStripMenuItem"
        Me.MaximizeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.MaximizeToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.MaximizeToolStripMenuItem.Text = "&Full screen"
        '
        'WYSIWYGSystemToolStripMenuItem
        '
        Me.WYSIWYGSystemToolStripMenuItem.CheckOnClick = True
        Me.WYSIWYGSystemToolStripMenuItem.Name = "WYSIWYGSystemToolStripMenuItem"
        Me.WYSIWYGSystemToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.WYSIWYGSystemToolStripMenuItem.Text = "WYSIWYG system"
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
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(-1, 45)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(480, 295)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.WordWrap = False
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(219, 230)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(100, 96)
        Me.RichTextBox2.TabIndex = 4
        Me.RichTextBox2.Text = ""
        Me.RichTextBox2.Visible = False
        '
        'FontDialog1
        '
        Me.FontDialog1.Color = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "*.rtf"
        Me.OpenFileDialog1.Filter = "Rich Text Format (*.rtf)|*.rtf|Plain text documents (*.txt)|*.txt|Command scripts" &
    " (*.bat;*.cmd)|*.bat;*.cmd"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "*.rtf"
        Me.SaveFileDialog1.Filter = "Rich Text Format (*.rtf)|*.rtf"
        '
        'Button1
        '
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(5, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 24)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Exit fullscreen"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'TrackBar1
        '
        Me.TrackBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackBar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TrackBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TrackBar1.Location = New System.Drawing.Point(371, 21)
        Me.TrackBar1.Maximum = 4000
        Me.TrackBar1.Minimum = 50
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(104, 45)
        Me.TrackBar1.TabIndex = 6
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.None
        Me.TrackBar1.Value = 100
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DimGray
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(459, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "H"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(468, 351)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 10)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "/"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'ResizeTimer
        '
        Me.ResizeTimer.Interval = 10
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'TerminateTimer
        '
        Me.TerminateTimer.Enabled = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(258, 91)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 11
        Me.ListBox1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(312, 332)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(17, 20)
        Me.TextBox1.TabIndex = 12
        Me.TextBox1.Text = """"
        Me.TextBox1.Visible = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(2, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(477, 295)
        Me.Label4.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 343)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "0 word(s), 1 line(s), 0 character(s)"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(341, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "1,00x"
        '
        'Notepad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(478, 360)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TrackBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(377, 89)
        Me.Name = "Notepad"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Notepad"
        Me.TopMost = True
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinimizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaximizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ColorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents WordWrapToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ResizeTimer As Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TerminateTimer As System.Windows.Forms.Timer
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents OpenRecentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents WYSIWYGSystemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DocumentationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
