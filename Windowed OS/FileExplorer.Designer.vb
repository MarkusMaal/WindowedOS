<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileExplorer
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("My Documents", 0)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Root", 2)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Host Filesystem", 1)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FileExplorer))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.FileImages = New System.Windows.Forms.ImageList(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.FileNameText = New System.Windows.Forms.TextBox()
        Me.DescList = New System.Windows.Forms.ListBox()
        Me.FilterList = New System.Windows.Forms.ListBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fsInfo = New System.Windows.Forms.Label()
        Me.fnInfo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDesktopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TerminateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.WaitForAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ResizeTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.DimGray
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(2, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(779, 14)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "File Explorer"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(5, 44)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ListView2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(767, 506)
        Me.SplitContainer1.SplitterDistance = 115
        Me.SplitContainer1.TabIndex = 13
        '
        'ListView2
        '
        Me.ListView2.Dock = System.Windows.Forms.DockStyle.Fill
        ListViewItem1.StateImageIndex = 0
        ListViewItem2.Checked = True
        ListViewItem2.IndentCount = 1
        ListViewItem2.StateImageIndex = 1
        ListViewItem3.Checked = True
        ListViewItem3.IndentCount = 2
        ListViewItem3.StateImageIndex = 2
        Me.ListView2.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
        Me.ListView2.LargeImageList = Me.ImageList1
        Me.ListView2.Location = New System.Drawing.Point(0, 0)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Scrollable = False
        Me.ListView2.Size = New System.Drawing.Size(115, 506)
        Me.ListView2.SmallImageList = Me.ImageList1
        Me.ListView2.TabIndex = 15
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.SmallIcon
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "docs.png")
        Me.ImageList1.Images.SetKeyName(1, "host.png")
        Me.ImageList1.Images.SetKeyName(2, "root.png")
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.ComboBox2)
        Me.SplitContainer2.Panel2.Controls.Add(Me.FileNameText)
        Me.SplitContainer2.Panel2.Controls.Add(Me.DescList)
        Me.SplitContainer2.Panel2.Controls.Add(Me.FilterList)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Button3)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Button2)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer2.Panel2.Controls.Add(Me.fsInfo)
        Me.SplitContainer2.Panel2.Controls.Add(Me.fnInfo)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer2.Size = New System.Drawing.Size(648, 506)
        Me.SplitContainer2.SplitterDistance = 412
        Me.SplitContainer2.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer3.Panel1.Controls.Add(Me.TextBox1)
        Me.SplitContainer3.Panel1.Controls.Add(Me.ComboBox1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.ListView1)
        Me.SplitContainer3.Size = New System.Drawing.Size(648, 412)
        Me.SplitContainer3.SplitterDistance = 27
        Me.SplitContainer3.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(469, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Go"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(460, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "\Documents"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Details", "Small Icons", "Large Icons", "List", "Tile"})
        Me.ComboBox1.Location = New System.Drawing.Point(524, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'ListView1
        '
        Me.ListView1.AllowColumnReorder = True
        Me.ListView1.BackColor = System.Drawing.Color.White
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.ForeColor = System.Drawing.Color.Black
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.LargeImageList = Me.ImageList2
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(648, 381)
        Me.ListView1.SmallImageList = Me.FileImages
        Me.ListView1.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "File"
        Me.ColumnHeader1.Width = 180
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Size(Kb)"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Date"
        '
        'ImageList2
        '
        Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList2.ImageSize = New System.Drawing.Size(64, 64)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'FileImages
        '
        Me.FileImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.FileImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.FileImages.TransparentColor = System.Drawing.Color.Transparent
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(491, 13)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox2.TabIndex = 8
        '
        'FileNameText
        '
        Me.FileNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FileNameText.Location = New System.Drawing.Point(15, 13)
        Me.FileNameText.Name = "FileNameText"
        Me.FileNameText.Size = New System.Drawing.Size(470, 20)
        Me.FileNameText.TabIndex = 0
        Me.FileNameText.Visible = False
        '
        'DescList
        '
        Me.DescList.FormattingEnabled = True
        Me.DescList.Location = New System.Drawing.Point(285, 28)
        Me.DescList.Name = "DescList"
        Me.DescList.Size = New System.Drawing.Size(120, 95)
        Me.DescList.TabIndex = 7
        Me.DescList.Visible = False
        '
        'FilterList
        '
        Me.FilterList.FormattingEnabled = True
        Me.FilterList.Location = New System.Drawing.Point(159, 29)
        Me.FilterList.Name = "FilterList"
        Me.FilterList.Size = New System.Drawing.Size(120, 95)
        Me.FilterList.TabIndex = 6
        Me.FilterList.Visible = False
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(479, 58)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(560, 58)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "OK"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Type"
        '
        'fsInfo
        '
        Me.fsInfo.AutoSize = True
        Me.fsInfo.Location = New System.Drawing.Point(12, 50)
        Me.fsInfo.Name = "fsInfo"
        Me.fsInfo.Size = New System.Drawing.Size(30, 13)
        Me.fsInfo.TabIndex = 2
        Me.fsInfo.Text = "Size:"
        '
        'fnInfo
        '
        Me.fnInfo.AutoSize = True
        Me.fnInfo.Location = New System.Drawing.Point(12, 37)
        Me.fnInfo.Name = "fnInfo"
        Me.fnInfo.Size = New System.Drawing.Size(38, 13)
        Me.fnInfo.TabIndex = 1
        Me.fnInfo.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "File details"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(5, 17)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(132, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpToolStripMenuItem, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.CloseToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'UpToolStripMenuItem
        '
        Me.UpToolStripMenuItem.Image = Global.Windowed_OS.My.Resources.Resources.load
        Me.UpToolStripMenuItem.Name = "UpToolStripMenuItem"
        Me.UpToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Left), System.Windows.Forms.Keys)
        Me.UpToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.UpToolStripMenuItem.Text = "Up"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = Global.Windowed_OS.My.Resources.Resources.cut
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        Me.CutToolStripMenuItem.ToolTipText = "Makes a copy of a file, then deletes it."
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = Global.Windowed_OS.My.Resources.Resources.copy
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        Me.CopyToolStripMenuItem.ToolTipText = "Makes a copy of a file."
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = Global.Windowed_OS.My.Resources.Resources.paste
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        Me.PasteToolStripMenuItem.ToolTipText = "Confirms Cut/Copy action"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        Me.DeleteToolStripMenuItem.ToolTipText = "Deletes a file or a directory"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        Me.CloseToolStripMenuItem.ToolTipText = "Closes this window of File Explorer, but leaves the process running"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.Windowed_OS.My.Resources.Resources._exit
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        Me.ExitToolStripMenuItem.ToolTipText = "Exits File Explorer"
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
        Me.ViewDesktopToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.ViewDesktopToolStripMenuItem.Text = "View desktop"
        Me.ViewDesktopToolStripMenuItem.ToolTipText = "Shows the desktop"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.Windowed_OS.My.Resources.Resources.question
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        Me.AboutToolStripMenuItem.ToolTipText = "Shows additional information about this program."
        '
        'TerminateTimer
        '
        Me.TerminateTimer.Enabled = True
        '
        'WaitForAnimation
        '
        Me.WaitForAnimation.Enabled = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DimGray
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(766, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "H"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.Label5.Location = New System.Drawing.Point(773, 553)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(11, 10)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "/"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'ResizeTimer
        '
        Me.ResizeTimer.Interval = 10
        '
        'FileExplorer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FileExplorer"
        Me.Opacity = 0.0R
        Me.ShowIcon = False
        Me.Text = "FileExplorer"
        Me.TopMost = True
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fsInfo As System.Windows.Forms.Label
    Friend WithEvents fnInfo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewDesktopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents FileImages As System.Windows.Forms.ImageList
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents UpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents TerminateTimer As System.Windows.Forms.Timer
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents FileNameText As System.Windows.Forms.TextBox
    Friend WithEvents DescList As System.Windows.Forms.ListBox
    Friend WithEvents FilterList As System.Windows.Forms.ListBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WaitForAnimation As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ResizeTimer As System.Windows.Forms.Timer
End Class
