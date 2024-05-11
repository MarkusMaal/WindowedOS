<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartupWindow
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
        Me.LogoffTitle = New System.Windows.Forms.Label()
        Me.LogoffWindow = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LogoffTitle
        '
        Me.LogoffTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LogoffTitle.BackColor = System.Drawing.Color.DimGray
        Me.LogoffTitle.ForeColor = System.Drawing.Color.White
        Me.LogoffTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LogoffTitle.Location = New System.Drawing.Point(3, 2)
        Me.LogoffTitle.Name = "LogoffTitle"
        Me.LogoffTitle.Size = New System.Drawing.Size(341, 14)
        Me.LogoffTitle.TabIndex = 18
        Me.LogoffTitle.Text = "Starting up"
        Me.LogoffTitle.UseWaitCursor = True
        '
        'LogoffWindow
        '
        Me.LogoffWindow.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LogoffWindow.BackColor = System.Drawing.Color.Transparent
        Me.LogoffWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoffWindow.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.LogoffWindow.ForeColor = System.Drawing.Color.Black
        Me.LogoffWindow.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LogoffWindow.Location = New System.Drawing.Point(0, 35)
        Me.LogoffWindow.Name = "LogoffWindow"
        Me.LogoffWindow.Size = New System.Drawing.Size(347, 61)
        Me.LogoffWindow.TabIndex = 19
        Me.LogoffWindow.Text = "Loading..."
        Me.LogoffWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LogoffWindow.UseCompatibleTextRendering = True
        Me.LogoffWindow.UseWaitCursor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ProgressBar1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ProgressBar1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.ProgressBar1.Location = New System.Drawing.Point(4, 113)
        Me.ProgressBar1.Maximum = 70
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(338, 20)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 20
        Me.ProgressBar1.UseWaitCursor = True
        Me.ProgressBar1.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'StartupWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(347, 137)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.LogoffWindow)
        Me.Controls.Add(Me.LogoffTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StartupWindow"
        Me.Opacity = 0.0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StartupWindow"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LogoffTitle As System.Windows.Forms.Label
    Friend WithEvents LogoffWindow As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
