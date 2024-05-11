<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartfieldEasterEgg
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
        Me.i = New System.Windows.Forms.Label()
        Me.iii = New System.Windows.Forms.Label()
        Me.ii = New System.Windows.Forms.Label()
        Me.iv = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'i
        '
        Me.i.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.i.Location = New System.Drawing.Point(343, 243)
        Me.i.Name = "i"
        Me.i.Size = New System.Drawing.Size(24, 23)
        Me.i.TabIndex = 0
        Me.i.Text = "."
        '
        'iii
        '
        Me.iii.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.iii.Location = New System.Drawing.Point(279, 243)
        Me.iii.Name = "iii"
        Me.iii.Size = New System.Drawing.Size(24, 23)
        Me.iii.TabIndex = 1
        Me.iii.Text = "."
        Me.iii.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ii
        '
        Me.ii.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ii.Location = New System.Drawing.Point(310, 214)
        Me.ii.Name = "ii"
        Me.ii.Size = New System.Drawing.Size(24, 23)
        Me.ii.TabIndex = 2
        Me.ii.Text = "."
        Me.ii.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'iv
        '
        Me.iv.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.iv.Location = New System.Drawing.Point(310, 260)
        Me.iv.Name = "iv"
        Me.iv.Size = New System.Drawing.Size(24, 23)
        Me.iv.TabIndex = 3
        Me.iv.Text = "."
        Me.iv.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'StartfieldEasterEgg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(640, 480)
        Me.Controls.Add(Me.iv)
        Me.Controls.Add(Me.ii)
        Me.Controls.Add(Me.iii)
        Me.Controls.Add(Me.i)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StartfieldEasterEgg"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StartfieldEasterEgg"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents i As System.Windows.Forms.Label
    Friend WithEvents iii As System.Windows.Forms.Label
    Friend WithEvents ii As System.Windows.Forms.Label
    Friend WithEvents iv As System.Windows.Forms.Label
End Class
