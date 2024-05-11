<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogoffWindow
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LogoffTitle
        '
        Me.LogoffTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LogoffTitle.BackColor = System.Drawing.Color.DimGray
        Me.LogoffTitle.ForeColor = System.Drawing.Color.White
        Me.LogoffTitle.Location = New System.Drawing.Point(3, 3)
        Me.LogoffTitle.Name = "LogoffTitle"
        Me.LogoffTitle.Size = New System.Drawing.Size(342, 14)
        Me.LogoffTitle.TabIndex = 17
        Me.LogoffTitle.Text = "Logging off..."
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label1.Location = New System.Drawing.Point(0, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 39)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Saving settings..."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'LogoffWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(347, 137)
        Me.Controls.Add(Me.LogoffTitle)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LogoffWindow"
        Me.Opacity = 0.0R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LogoffWindow"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LogoffTitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
