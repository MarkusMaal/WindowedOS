<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Store
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TopMenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Apps = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ResizeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TerminateTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TopMenu.SuspendLayout()
        Me.Apps.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DimGray
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(536, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "H"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(2, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(549, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "App Center"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(5, 19)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TopMenu)
        Me.SplitContainer1.Panel1MinSize = 30
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Apps)
        Me.SplitContainer1.Size = New System.Drawing.Size(542, 369)
        Me.SplitContainer1.SplitterDistance = 30
        Me.SplitContainer1.TabIndex = 47
        '
        'TopMenu
        '
        Me.TopMenu.Controls.Add(Me.TextBox1)
        Me.TopMenu.Controls.Add(Me.Button1)
        Me.TopMenu.Controls.Add(Me.Button2)
        Me.TopMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TopMenu.Location = New System.Drawing.Point(0, 0)
        Me.TopMenu.MinimumSize = New System.Drawing.Size(0, 34)
        Me.TopMenu.Name = "TopMenu"
        Me.TopMenu.Size = New System.Drawing.Size(542, 34)
        Me.TopMenu.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.TextBox1.Location = New System.Drawing.Point(3, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(246, 27)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(255, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 27)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(336, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 27)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Apps
        '
        Me.Apps.Controls.Add(Me.Button3)
        Me.Apps.Controls.Add(Me.Button5)
        Me.Apps.Controls.Add(Me.Button6)
        Me.Apps.Controls.Add(Me.Button7)
        Me.Apps.Controls.Add(Me.Button8)
        Me.Apps.Controls.Add(Me.Button9)
        Me.Apps.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Apps.Location = New System.Drawing.Point(0, 0)
        Me.Apps.Name = "Apps"
        Me.Apps.Size = New System.Drawing.Size(542, 335)
        Me.Apps.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.Windowed_OS.My.Resources.Resources.calc
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(3, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 90)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Calculator"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = Global.Windowed_OS.My.Resources.Resources.colors
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.Location = New System.Drawing.Point(99, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(90, 90)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "Windowed Desktop Environment"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Image = Global.Windowed_OS.My.Resources.Resources.draw
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.Location = New System.Drawing.Point(195, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(90, 90)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "Image Drawer"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Image = Global.Windowed_OS.My.Resources.Resources.media_player
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.Location = New System.Drawing.Point(291, 3)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(90, 90)
        Me.Button7.TabIndex = 4
        Me.Button7.Text = "Media Player"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Image = Global.Windowed_OS.My.Resources.Resources.notepad
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button8.Location = New System.Drawing.Point(387, 3)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(90, 90)
        Me.Button8.TabIndex = 5
        Me.Button8.Text = "Rich Text Notepad"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Image = Global.Windowed_OS.My.Resources.Resources.pictureviewer
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button9.Location = New System.Drawing.Point(3, 99)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(90, 90)
        Me.Button9.TabIndex = 6
        Me.Button9.Text = "Picture Viewer"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.Label12.Location = New System.Drawing.Point(542, 388)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 10)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "/"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'ResizeTimer
        '
        Me.ResizeTimer.Interval = 10
        '
        'TerminateTimer
        '
        Me.TerminateTimer.Enabled = True
        '
        'Store
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(553, 397)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label12)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(345, 264)
        Me.Name = "Store"
        Me.Opacity = 0R
        Me.Text = "Store"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TopMenu.ResumeLayout(False)
        Me.TopMenu.PerformLayout()
        Me.Apps.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TopMenu As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Apps As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ResizeTimer As System.Windows.Forms.Timer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents TerminateTimer As System.Windows.Forms.Timer
End Class
