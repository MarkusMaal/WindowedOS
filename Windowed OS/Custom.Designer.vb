<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Custom
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
        Me.MainForm = New System.Windows.Forms.Label()
        Me.MenuBar = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDesktopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TerminateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ResizeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.s_sv = New System.Windows.Forms.TextBox()
        Me.quotationmark = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainForm
        '
        Me.MainForm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainForm.BackColor = System.Drawing.Color.DimGray
        Me.MainForm.ForeColor = System.Drawing.Color.White
        Me.MainForm.Location = New System.Drawing.Point(3, 2)
        Me.MainForm.Name = "MainForm"
        Me.MainForm.Size = New System.Drawing.Size(634, 14)
        Me.MainForm.TabIndex = 12
        Me.MainForm.Text = "My Program"
        '
        'MenuBar
        '
        Me.MenuBar.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuBar.Location = New System.Drawing.Point(6, 16)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuBar.Size = New System.Drawing.Size(171, 24)
        Me.MenuBar.TabIndex = 13
        Me.MenuBar.Text = "MenuStrip1"
        Me.MenuBar.Visible = False
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
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
        Me.ViewDesktopToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ViewDesktopToolStripMenuItem.Text = "View Desktop"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.AboutToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(106, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.Label5.Location = New System.Drawing.Point(629, 471)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(11, 10)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "/"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'TerminateTimer
        '
        Me.TerminateTimer.Enabled = True
        '
        'ResizeTimer
        '
        Me.ResizeTimer.Interval = 10
        '
        's_sv
        '
        Me.s_sv.Location = New System.Drawing.Point(500, 338)
        Me.s_sv.Multiline = True
        Me.s_sv.Name = "s_sv"
        Me.s_sv.Size = New System.Drawing.Size(100, 116)
        Me.s_sv.TabIndex = 15
        Me.s_sv.Visible = False
        '
        'quotationmark
        '
        Me.quotationmark.Location = New System.Drawing.Point(368, 426)
        Me.quotationmark.Name = "quotationmark"
        Me.quotationmark.Size = New System.Drawing.Size(100, 20)
        Me.quotationmark.TabIndex = 16
        Me.quotationmark.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DimGray
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(622, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "H"
        '
        'Custom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(640, 480)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.quotationmark)
        Me.Controls.Add(Me.s_sv)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MainForm)
        Me.Controls.Add(Me.MenuBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuBar
        Me.Name = "Custom"
        Me.Opacity = 0.0R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Custom"
        Me.TopMost = True
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainForm As System.Windows.Forms.Label
    Friend WithEvents MenuBar As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewDesktopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TerminateTimer As System.Windows.Forms.Timer
    Friend WithEvents ResizeTimer As System.Windows.Forms.Timer
    Friend WithEvents s_sv As System.Windows.Forms.TextBox
    Friend WithEvents quotationmark As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
