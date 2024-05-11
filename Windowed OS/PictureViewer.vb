Public Class PictureViewer
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim CurLocation, AppLocation As New Point(0, 0)
    Dim composedwindow As Form = New Form()
    Dim rap As Boolean = False
    Private Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr

    Private Sub Sync()
        CurLocation = Cursor.Position
        AppLocation = Size
    End Sub

    Private Sub Label2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label2.MouseDown
        ResizeTimer.Start()
        Sync()
    End Sub

    Private Sub Label2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label2.MouseUp
        ResizeTimer.Stop()
        Sync()
        composedwindow.BringToFront()
        Me.BringToFront()
    End Sub

    Private Sub ResizeTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ResizeTimer.Tick
        Size = AppLocation - CurLocation + Cursor.Position
        composedwindow.Size = Size
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.hideanimation(Me, composedwindow)
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Close()
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.fadeout_animation(Me, composedwindow)
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Notepad.TopMost = False
        TopMost = False
        MediaPlay.TopMost = False
        WebBrowser.TopMost = False
        TicTacToe.TopMost = False
        ClickIt.TopMost = False
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox1.Load(OpenFileDialog1.FileName)
            PictureBox1.BackgroundImage = PictureBox1.Image
            PictureBox1.Image = Nothing
            GoTo lolo
        Else

            MessageDialog.messagetitle = "Picture Viewer"
            MessageDialog.messagetext = "You didn't pick a picture"
            MessageDialog.messageicon = "Information"
            'MessageDialog.ff = Me
            'MessageDialog.sf = composedwindow
            MessageDialog.ShowDialog()
            GoTo lolo
        End If
lolo:
        Notepad.TopMost = True
        MediaPlay.TopMost = True
        WebBrowser.TopMost = True
        TicTacToe.TopMost = True
        ClickIt.TopMost = True
        TopMost = True
    End Sub

    Private Sub RotateRightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RotateRightToolStripMenuItem.Click
        PictureBox1.Hide()
        PictureBox1.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipNone)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.Show()
    End Sub

    Private Sub RotateLeftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RotateLeftToolStripMenuItem.Click
        PictureBox1.Hide()
        PictureBox1.BackgroundImage.RotateFlip(RotateFlipType.Rotate270FlipNone)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.Show()
    End Sub

    Private Sub FlipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlipToolStripMenuItem.Click
        PictureBox1.Hide()
        PictureBox1.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipY)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.Show()
    End Sub

    Private Sub MirrorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MirrorToolStripMenuItem.Click
        PictureBox1.Hide()
        PictureBox1.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipXY)
        PictureBox1.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipY)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.Show()
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        PictureBox1.Load(OpenFileDialog1.FileName)
        PictureBox1.BackgroundImage = PictureBox1.Image
        PictureBox1.Image = Nothing
    End Sub

    Private Sub MaximizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaximizeToolStripMenuItem.Click
        Try
            If WindowState = FormWindowState.Normal Then
                composedwindow.WindowState = FormWindowState.Maximized
                WindowState = FormWindowState.Maximized
                If PictureBox1.BackgroundImage.PhysicalDimension.Height * PictureBox1.BackgroundImage.PhysicalDimension.Width < 307200 Then
                    PictureBox2.BackgroundImageLayout = ImageLayout.Center
                Else
                    PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
                End If
                PictureBox2.BackgroundImage = PictureBox1.BackgroundImage
                PictureBox2.Visible = True
            Else
                PictureBox2.Visible = False
                WindowState = FormWindowState.Normal
                composedwindow.WindowState = FormWindowState.Normal
            End If
        Catch ex As Exception
            ESOD.Label5.Text = ex.Message
            ESOD.ShowDialog()
        End Try
    End Sub

    Private Sub MinimizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizeToolStripMenuItem.Click
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.hideanimation(Me, composedwindow)
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Hide()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageDialog.messagetitle = "About"
        MessageDialog.messagetext = "Picture View 1.0b"
        MessageDialog.messageicon = "Info"
        'MessageDialog.ff = Me
        'MessageDialog.sf = composedwindow
        MessageDialog.ShowDialog()
    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Left
        mousey = Cursor.Position.Y - Top
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
        If drag Then
            Top = Cursor.Position.Y - mousey
            Left = Cursor.Position.X - mousex
            composedwindow.Left = Left
            composedwindow.Top = Top
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp
        drag = False
        composedwindow.BringToFront()
        Me.BringToFront()
    End Sub

    Private Sub StretchToolStripMenuItem_Click(sender As Object, e As EventArgs)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    Private Sub TileToolStripMenuItem_Click(sender As Object, e As EventArgs)
        PictureBox1.SizeMode = PictureBoxSizeMode.Normal
    End Sub

    Private Sub FitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
    End Sub

    Private Sub CenterToolStripMenuItem_Click(sender As Object, e As EventArgs)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
    End Sub

    Private Sub PictureViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Opacity = 1.0
        Label1.BackColor = Notepad.Label1.BackColor
        Label1.ForeColor = Notepad.Label1.ForeColor
        Label3.BackColor = Notepad.Label3.BackColor
        Label3.ForeColor = Notepad.Label3.ForeColor
        BackColor = Notepad.BackColor
        ForeColor = Notepad.ForeColor
    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        Try
            If WindowState = FormWindowState.Normal Then
                WindowState = FormWindowState.Maximized
                If PictureBox1.BackgroundImage.PhysicalDimension.Height * PictureBox1.BackgroundImage.PhysicalDimension.Width < 307200 Then
                    PictureBox2.BackgroundImageLayout = ImageLayout.Center
                Else
                    PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
                End If
                PictureBox2.BackgroundImage = PictureBox1.BackgroundImage
                PictureBox2.Visible = True
                If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
                    composedwindow.WindowState = FormWindowState.Maximized
                End If
            Else
                PictureBox2.Visible = False
                WindowState = FormWindowState.Normal
                If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
                    composedwindow.WindowState = FormWindowState.Normal
                    composedwindow.Size = Me.Size
                    composedwindow.Location = Me.Location
                End If
            End If
        Catch ex As Exception
            ESOD.Label5.Text = ex.Message
            ESOD.ShowDialog()
        End Try
    End Sub

    Private Sub PictureViewer_VisibleChanged(sender As Object, e As System.EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            Form1.Setfont(Me, Label1, Label3)
            Label1.BackColor = Desktop.labelBg.BackColor
            Label1.ForeColor = Desktop.labelFg.BackColor
            Label3.BackColor = Desktop.labelBg.BackColor
            Label3.ForeColor = Desktop.labelFg.BackColor
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.BackColor = Desktop.appBg.BackColor
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.translucency(Me, composedwindow, True)
            Me.ForeColor = Desktop.appFg.BackColor
        End If
    End Sub

    Private Sub TerminateTimer_Tick(sender As System.Object, e As System.EventArgs) Handles TerminateTimer.Tick
        If LogoffWindow.Visible = True Then
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Close()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.fadeout_animation(Me, composedwindow)
        ElseIf Desktop.PictureKill.Text = "kill" Then
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Close()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.fadeout_animation(Me, composedwindow)
        ElseIf Lock.Visible = True Then
            Me.Hide()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Hide()
        ElseIf Desktop.restorewindow.Text = "Picture View" Then
            Me.Opacity = 1.0
            composedwindow.Opacity = 0.9
            Me.Show()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Show()
        End If
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            If composedwindow.IsDisposed = False Then
                If Not GetActiveWindow <> composedwindow.Handle Then
                    Me.BringToFront()
                End If
            End If
        End If
        If Me.Visible = True Then
            If CustomizationCenter.ApplyTheme.Enabled = True Then
                composedwindow.Hide()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub PictureBox2_DoubleClick(sender As System.Object, e As System.EventArgs) Handles PictureBox2.DoubleClick
        PictureBox2.Visible = False
        Me.WindowState = FormWindowState.Normal
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            composedwindow.WindowState = FormWindowState.Normal
            composedwindow.Size = Me.Size
            composedwindow.Location = Me.Location
        End If
    End Sub

    Private Sub PictureViewer_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        Label1.BackColor = Desktop.labelBg.BackColor
        Label3.BackColor = Desktop.labelBg.BackColor
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            If rap = False Then
                If composedwindow.IsDisposed = False Then
                    composedwindow.BringToFront()
                    Me.BringToFront()
                    rap = True
                End If
            End If
        End If
    End Sub

    Private Sub PictureViewer_Deactivate(sender As System.Object, e As System.EventArgs) Handles MyBase.Deactivate
        Dim r As Integer
        Dim g As Integer
        Dim b As Integer
        r = Desktop.labelBg.BackColor.R - 25
        If r < 0 Then r = 255 + r
        g = Desktop.labelBg.BackColor.G - 25
        If g < 0 Then g = 255 + g
        b = Desktop.labelBg.BackColor.B - 25
        If b < 0 Then b = 255 + b
        GoTo exitif
exitif:
        Dim col As Color = Color.FromArgb(r, g, b)
        Label1.BackColor = col
        Label3.BackColor = col
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            If composedwindow.IsDisposed = False Then
                If Not GetActiveWindow <> composedwindow.Handle Then
                    Me.BringToFront()
                End If
            End If
        End If
        rap = False
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        tskmgr.ListBox1.Items.Remove("Picture View")
        Desktop.PictureKill.Text = "kill"
        Desktop.killtimer.Enabled = True
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Close()
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.fadeout_animation(Me, composedwindow)
    End Sub
End Class