<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tskmgr
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
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"System I/O Framework", "1"}, -1)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Tasks and resources", "1"}, -1)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Windowed Desktop Environment", "1"}, -1)
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResizeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TerminateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.instancebox = New System.Windows.Forms.ListBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Process = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Instances = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.CPUCounter = New System.Diagnostics.PerformanceCounter()
        Me.RAMCounter = New System.Diagnostics.PerformanceCounter()
        Me.DiskAccessCounter = New System.Diagnostics.PerformanceCounter()
        Me.DiskReadCounter = New System.Diagnostics.PerformanceCounter()
        Me.GraphUpdater = New System.Windows.Forms.Timer(Me.components)
        Me.CPULabel = New System.Windows.Forms.Label()
        Me.RAMLabel = New System.Windows.Forms.Label()
        Me.DiskReadLabel = New System.Windows.Forms.Label()
        Me.DiskWriteLabel = New System.Windows.Forms.Label()
        Me.TaskLabel = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CPUCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RAMCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiskAccessCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiskReadCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.Label2.Location = New System.Drawing.Point(448, 338)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 10)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "/"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(451, 14)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Tasks and resources"
        '
        'ListBox1
        '
        Me.ListBox1.AllowDrop = True
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.Items.AddRange(New Object() {"System I/O Framework", "Tasks and resources", "Windowed Desktop Environment"})
        Me.ListBox1.Location = New System.Drawing.Point(3, 3)
        Me.ListBox1.MultiColumn = True
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(429, 237)
        Me.ListBox1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(6, 17)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(88, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.SuleToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ExitToolStripMenuItem.Text = "Hide"
        '
        'SuleToolStripMenuItem
        '
        Me.SuleToolStripMenuItem.Name = "SuleToolStripMenuItem"
        Me.SuleToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.SuleToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SuleToolStripMenuItem.Text = "Exit"
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
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ResizeTimer
        '
        Me.ResizeTimer.Interval = 10
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(374, 319)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "&Stop"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DimGray
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(439, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "H"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(293, 319)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "&Restore..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TerminateTimer
        '
        Me.TerminateTimer.Enabled = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 44)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(443, 269)
        Me.TabControl1.TabIndex = 19
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ListBox2)
        Me.TabPage1.Controls.Add(Me.instancebox)
        Me.TabPage1.Controls.Add(Me.ListBox1)
        Me.TabPage1.Controls.Add(Me.ListView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(435, 243)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tasks"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Items.AddRange(New Object() {"1", "2", "3"})
        Me.ListBox2.Location = New System.Drawing.Point(283, 44)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 95)
        Me.ListBox2.TabIndex = 27
        Me.ListBox2.Visible = False
        '
        'instancebox
        '
        Me.instancebox.FormattingEnabled = True
        Me.instancebox.Items.AddRange(New Object() {"System I/O Framework", "Tasks and resources", "Windowed Desktop Environment"})
        Me.instancebox.Location = New System.Drawing.Point(283, 145)
        Me.instancebox.Name = "instancebox"
        Me.instancebox.Size = New System.Drawing.Size(120, 95)
        Me.instancebox.TabIndex = 26
        Me.instancebox.Visible = False
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Process, Me.Instances})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem4, ListViewItem5, ListViewItem6})
        Me.ListView1.Location = New System.Drawing.Point(3, 3)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(429, 237)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        Me.ListView1.Visible = False
        '
        'Process
        '
        Me.Process.Text = "Process"
        Me.Process.Width = 200
        '
        'Instances
        '
        Me.Instances.Text = "Instances"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Chart1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(435, 243)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Resources"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Black
        Me.Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
        Me.Chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chart1.BackImageTransparentColor = System.Drawing.Color.Transparent
        Me.Chart1.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Chart1.BorderlineColor = System.Drawing.Color.MediumBlue
        Me.Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea2.Area3DStyle.Inclination = 0
        ChartArea2.Area3DStyle.IsRightAngleAxes = False
        ChartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea2.Area3DStyle.Rotation = 0
        ChartArea2.AxisX.InterlacedColor = System.Drawing.Color.White
        ChartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea2.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds
        ChartArea2.AxisX.IsStartedFromZero = False
        ChartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea2.AxisX.LineColor = System.Drawing.Color.White
        ChartArea2.AxisX.LogarithmBase = 20.0R
        ChartArea2.AxisX.MajorGrid.Enabled = False
        ChartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.White
        ChartArea2.AxisX.MajorTickMark.Enabled = False
        ChartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White
        ChartArea2.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis
        ChartArea2.AxisX.Maximum = 20.0R
        ChartArea2.AxisX.MaximumAutoSize = 100.0!
        ChartArea2.AxisX.Minimum = 1.0R
        ChartArea2.AxisX.MinorGrid.Enabled = True
        ChartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        ChartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White
        ChartArea2.AxisX.ScaleBreakStyle.Spacing = 1.0R
        ChartArea2.AxisX.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.No
        ChartArea2.AxisX.Title = "Time (sec)"
        ChartArea2.AxisX.TitleFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        ChartArea2.AxisX.TitleForeColor = System.Drawing.Color.White
        ChartArea2.AxisX2.InterlacedColor = System.Drawing.Color.White
        ChartArea2.AxisX2.LineColor = System.Drawing.Color.White
        ChartArea2.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White
        ChartArea2.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White
        ChartArea2.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White
        ChartArea2.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White
        ChartArea2.AxisY.IsLabelAutoFit = False
        ChartArea2.AxisY.LabelStyle.Angle = -90
        ChartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea2.AxisY.LineColor = System.Drawing.Color.White
        ChartArea2.AxisY.LogarithmBase = 100.0R
        ChartArea2.AxisY.MajorGrid.Enabled = False
        ChartArea2.AxisY.MajorTickMark.Enabled = False
        ChartArea2.AxisY.Maximum = 100.0R
        ChartArea2.AxisY.MinorGrid.Enabled = True
        ChartArea2.AxisY.MinorGrid.Interval = Double.NaN
        ChartArea2.AxisY.MinorGrid.IntervalOffset = Double.NaN
        ChartArea2.AxisY.MinorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea2.AxisY.MinorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        ChartArea2.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Gray
        ChartArea2.AxisY.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.None
        ChartArea2.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270
        ChartArea2.AxisY.Title = "Usage (%)"
        ChartArea2.AxisY.TitleFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        ChartArea2.AxisY.TitleForeColor = System.Drawing.Color.White
        ChartArea2.AxisY2.InterlacedColor = System.Drawing.Color.White
        ChartArea2.AxisY2.LineColor = System.Drawing.Color.White
        ChartArea2.AxisY2.MinorGrid.LineColor = System.Drawing.Color.DarkGray
        ChartArea2.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.Gray
        ChartArea2.AxisY2.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.None
        ChartArea2.BackColor = System.Drawing.Color.Black
        ChartArea2.BackSecondaryColor = System.Drawing.Color.White
        ChartArea2.BorderColor = System.Drawing.Color.White
        ChartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.BackColor = System.Drawing.Color.Navy
        Legend2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft
        Legend2.BackSecondaryColor = System.Drawing.Color.Blue
        Legend2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Legend2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Legend2.ForeColor = System.Drawing.Color.White
        Legend2.IsTextAutoFit = False
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(3, 3)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.Chart1.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.Blue, System.Drawing.Color.Gold, System.Drawing.Color.Lime, System.Drawing.Color.Red}
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series5.LabelForeColor = System.Drawing.Color.White
        Series5.Legend = "Legend1"
        Series5.MarkerColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Series5.MarkerSize = 3
        Series5.MarkerStep = 3
        Series5.Name = "CPU usage"
        Series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series6.Legend = "Legend1"
        Series6.MarkerColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Series6.MarkerSize = 3
        Series6.MarkerStep = 3
        Series6.Name = "RAM usage"
        Series7.ChartArea = "ChartArea1"
        Series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series7.Legend = "Legend1"
        Series7.MarkerColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Series7.MarkerSize = 3
        Series7.MarkerStep = 3
        Series7.Name = "Disk access"
        Series8.ChartArea = "ChartArea1"
        Series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series8.Legend = "Legend1"
        Series8.MarkerImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Series8.MarkerSize = 3
        Series8.MarkerStep = 3
        Series8.Name = "Disk write"
        Series8.YValuesPerPoint = 4
        Me.Chart1.Series.Add(Series5)
        Me.Chart1.Series.Add(Series6)
        Me.Chart1.Series.Add(Series7)
        Me.Chart1.Series.Add(Series8)
        Me.Chart1.Size = New System.Drawing.Size(429, 237)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        Title2.Font = New System.Drawing.Font("Consolas", 20.0!)
        Title2.ForeColor = System.Drawing.Color.LawnGreen
        Title2.Name = "Resources"
        Title2.Text = "Resources"
        Me.Chart1.Titles.Add(Title2)
        '
        'CPUCounter
        '
        Me.CPUCounter.CategoryName = "Processor"
        Me.CPUCounter.CounterName = "% Processor Time"
        Me.CPUCounter.InstanceName = "_Total"
        '
        'RAMCounter
        '
        Me.RAMCounter.CategoryName = "Memory"
        Me.RAMCounter.CounterName = "% Committed Bytes In Use"
        '
        'DiskAccessCounter
        '
        Me.DiskAccessCounter.CategoryName = "LogicalDisk"
        Me.DiskAccessCounter.CounterName = "% Disk Read Time"
        Me.DiskAccessCounter.InstanceName = "C:"
        '
        'DiskReadCounter
        '
        Me.DiskReadCounter.CategoryName = "LogicalDisk"
        Me.DiskReadCounter.CounterName = "% Disk Write Time"
        Me.DiskReadCounter.InstanceName = "C:"
        '
        'GraphUpdater
        '
        Me.GraphUpdater.Enabled = True
        Me.GraphUpdater.Interval = 1000
        '
        'CPULabel
        '
        Me.CPULabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CPULabel.AutoSize = True
        Me.CPULabel.Location = New System.Drawing.Point(7, 319)
        Me.CPULabel.Name = "CPULabel"
        Me.CPULabel.Size = New System.Drawing.Size(49, 13)
        Me.CPULabel.TabIndex = 20
        Me.CPULabel.Text = "CPU: 0%"
        '
        'RAMLabel
        '
        Me.RAMLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RAMLabel.AutoSize = True
        Me.RAMLabel.Location = New System.Drawing.Point(7, 332)
        Me.RAMLabel.Name = "RAMLabel"
        Me.RAMLabel.Size = New System.Drawing.Size(51, 13)
        Me.RAMLabel.TabIndex = 21
        Me.RAMLabel.Text = "RAM: 0%"
        '
        'DiskReadLabel
        '
        Me.DiskReadLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DiskReadLabel.AutoSize = True
        Me.DiskReadLabel.Location = New System.Drawing.Point(73, 319)
        Me.DiskReadLabel.Name = "DiskReadLabel"
        Me.DiskReadLabel.Size = New System.Drawing.Size(57, 13)
        Me.DiskReadLabel.TabIndex = 22
        Me.DiskReadLabel.Text = "LDDR: 0%"
        '
        'DiskWriteLabel
        '
        Me.DiskWriteLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DiskWriteLabel.AutoSize = True
        Me.DiskWriteLabel.Location = New System.Drawing.Point(73, 332)
        Me.DiskWriteLabel.Name = "DiskWriteLabel"
        Me.DiskWriteLabel.Size = New System.Drawing.Size(60, 13)
        Me.DiskWriteLabel.TabIndex = 23
        Me.DiskWriteLabel.Text = "LDDW: 0%"
        '
        'TaskLabel
        '
        Me.TaskLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TaskLabel.AutoSize = True
        Me.TaskLabel.Location = New System.Drawing.Point(155, 319)
        Me.TaskLabel.Name = "TaskLabel"
        Me.TaskLabel.Size = New System.Drawing.Size(68, 13)
        Me.TaskLabel.TabIndex = 24
        Me.TaskLabel.Text = "Processes: 3"
        '
        'TimeLabel
        '
        Me.TimeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Location = New System.Drawing.Point(155, 332)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(65, 13)
        Me.TimeLabel.TabIndex = 25
        Me.TimeLabel.Text = "TIME: 0 sec"
        '
        'tskmgr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(456, 347)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.TaskLabel)
        Me.Controls.Add(Me.DiskWriteLabel)
        Me.Controls.Add(Me.DiskReadLabel)
        Me.Controls.Add(Me.RAMLabel)
        Me.Controls.Add(Me.CPULabel)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(171, 108)
        Me.Name = "tskmgr"
        Me.Opacity = 0.0R
        Me.Text = "Task Manager"
        Me.TopMost = True
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CPUCounter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RAMCounter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiskAccessCounter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiskReadCounter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResizeTimer As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents SuleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TerminateTimer As System.Windows.Forms.Timer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents CPUCounter As System.Diagnostics.PerformanceCounter
    Friend WithEvents RAMCounter As System.Diagnostics.PerformanceCounter
    Friend WithEvents DiskAccessCounter As System.Diagnostics.PerformanceCounter
    Friend WithEvents DiskReadCounter As System.Diagnostics.PerformanceCounter
    Friend WithEvents GraphUpdater As System.Windows.Forms.Timer
    Friend WithEvents CPULabel As System.Windows.Forms.Label
    Friend WithEvents RAMLabel As System.Windows.Forms.Label
    Friend WithEvents DiskReadLabel As System.Windows.Forms.Label
    Friend WithEvents DiskWriteLabel As System.Windows.Forms.Label
    Friend WithEvents TaskLabel As System.Windows.Forms.Label
    Friend WithEvents TimeLabel As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Process As System.Windows.Forms.ColumnHeader
    Friend WithEvents Instances As System.Windows.Forms.ColumnHeader
    Friend WithEvents instancebox As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
End Class
