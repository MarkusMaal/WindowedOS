<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Watermark = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dev = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(767, 388)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 7
        Me.ListBox1.Visible = False
        '
        'Watermark
        '
        Me.Watermark.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Watermark.BackColor = System.Drawing.Color.Transparent
        Me.Watermark.ForeColor = System.Drawing.Color.LightGray
        Me.Watermark.Location = New System.Drawing.Point(-1, 520)
        Me.Watermark.Name = "Watermark"
        Me.Watermark.Size = New System.Drawing.Size(224, 40)
        Me.Watermark.TabIndex = 11
        Me.Watermark.Text = "Windowed OS 1.1f" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Codename: KeepCsAway" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Build: 11f005"
        Me.Watermark.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(387, 461)
        Me.ProgressBar1.Maximum = 2
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.TabIndex = 12
        Me.ProgressBar1.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'dev
        '
        Me.dev.AutoSize = True
        Me.dev.ForeColor = System.Drawing.Color.White
        Me.dev.Location = New System.Drawing.Point(12, 9)
        Me.dev.Name = "dev"
        Me.dev.Size = New System.Drawing.Size(85, 13)
        Me.dev.TabIndex = 13
        Me.dev.Text = "Developer mode"
        Me.dev.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 200
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(594, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 900
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        Me.Timer4.Interval = 10
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(718, 560)
        Me.Controls.Add(Me.dev)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Watermark)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Login screen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Watermark As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents dev As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
End Class
