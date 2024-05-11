<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dev = New System.Windows.Forms.Label()
        Me.devtimer = New System.Windows.Forms.Timer(Me.components)
        Me.FadeInTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FadeOutTimer = New System.Windows.Forms.Timer(Me.components)
        Me.HideTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ForceFadeInTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ForceFadeOutTimer = New System.Windows.Forms.Timer(Me.components)
        Me.tt = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.Label2.Location = New System.Drawing.Point(284, 543)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(235, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Preparing System.IO"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label2.UseWaitCursor = True
        Me.Label2.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(199, 640)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 3
        Me.ListBox1.UseWaitCursor = True
        Me.ListBox1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(465, 412)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.UseWaitCursor = True
        Me.TextBox1.Visible = False
        '
        'dev
        '
        Me.dev.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.dev.AutoSize = True
        Me.dev.BackColor = System.Drawing.Color.MidnightBlue
        Me.dev.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.dev.ForeColor = System.Drawing.Color.White
        Me.dev.Location = New System.Drawing.Point(282, 538)
        Me.dev.Name = "dev"
        Me.dev.Size = New System.Drawing.Size(249, 37)
        Me.dev.TabIndex = 14
        Me.dev.Text = "Developer mode"
        Me.dev.UseWaitCursor = True
        Me.dev.Visible = False
        '
        'devtimer
        '
        Me.devtimer.Enabled = True
        Me.devtimer.Interval = 1
        '
        'FadeInTimer
        '
        Me.FadeInTimer.Interval = 10
        '
        'FadeOutTimer
        '
        Me.FadeOutTimer.Interval = 10
        '
        'HideTimer
        '
        Me.HideTimer.Interval = 10
        '
        'ForceFadeInTimer
        '
        Me.ForceFadeInTimer.Interval = 10
        '
        'ForceFadeOutTimer
        '
        Me.ForceFadeOutTimer.Interval = 10
        '
        'tt
        '
        Me.tt.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.dev)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Windowed OS is starting up"
        Me.TransparencyKey = System.Drawing.Color.MediumBlue
        Me.UseWaitCursor = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents dev As System.Windows.Forms.Label
    Friend WithEvents devtimer As System.Windows.Forms.Timer
    Friend WithEvents FadeInTimer As System.Windows.Forms.Timer
    Friend WithEvents FadeOutTimer As System.Windows.Forms.Timer
    Friend WithEvents HideTimer As System.Windows.Forms.Timer
    Friend WithEvents ForceFadeInTimer As System.Windows.Forms.Timer
    Friend WithEvents ForceFadeOutTimer As System.Windows.Forms.Timer
    Friend WithEvents tt As System.Windows.Forms.Timer
End Class
