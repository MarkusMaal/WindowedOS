<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recovery
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 16.25!)
        Me.Label1.Location = New System.Drawing.Point(36, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Recovery mode"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(38, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(618, 36)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Warning: Recovery mode should only be used for troubleshooting. Messing with thes" & _
    "e options without knowing what you are doing, may cause system to malfunction."
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(231, 222)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(225, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "F12 factory reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(231, 251)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(225, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Complete factory reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(231, 280)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(225, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Developer mode"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(231, 309)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(225, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Remove autologin"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button5.Enabled = False
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(231, 338)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(225, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Uninstall all custom apps"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(231, 367)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(225, 23)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Restart Windowed OS"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Location = New System.Drawing.Point(231, 396)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(225, 23)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Shut down Windowed OS"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Recovery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(706, 574)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Recovery"
        Me.Text = "Recovery"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
End Class
