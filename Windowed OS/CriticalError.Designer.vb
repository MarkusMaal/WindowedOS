<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CriticalError
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CriticalError))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "RS: Critical Startup ERROR"
        Me.Label7.UseWaitCursor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(348, 483)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(304, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Close program (ENTER)"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.UseWaitCursor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(348, 454)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(304, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Try recreating system configuration file (TAB - ENTER)"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.UseWaitCursor = True
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(365, 392)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(287, 59)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Unknown error (0x00000000)"
        Me.Label5.UseWaitCursor = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(365, 378)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Error information:"
        Me.Label4.UseWaitCursor = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(365, 304)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(302, 39)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Try running Windowed OS as administrator. If this doesn't help," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "try rebuilding M" & _
    "icrosoft .NET cache. If none of this helps you," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "contact Windowed OS developer f" & _
    "or further assistance."
        Me.Label3.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(365, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(269, 91)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = resources.GetString("Label2.Text")
        Me.Label2.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(258, 203)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 50)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = ":'-("
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label1.UseCompatibleTextRendering = True
        Me.Label1.UseWaitCursor = True
        '
        'CriticalError
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(896, 637)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CriticalError"
        Me.Text = "CriticalError"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
