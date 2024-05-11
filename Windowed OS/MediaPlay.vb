Public Class MediaPlay
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Public sreq As Boolean
    Dim CurLocation, AppLocation As New Point(0, 0)
    Dim volume As Integer = 50
    Dim fsize As New Size(Me.Width, Me.Height)
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
        fsize = Me.Size
        If Size = MinimumSize Then
            CompactModeToolStripMenuItem.Checked = True
        Else
            CompactModeToolStripMenuItem.Checked = False
        End If
        composedwindow.Size = Me.Size
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
            composedwindow.Left = Me.Left
            composedwindow.Top = Me.Top
        End If
    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp
        drag = False
        composedwindow.BringToFront()
        Me.BringToFront()
    End Sub
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        If TrackBar1.Value = 0 Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If
        volume = TrackBar1.Value
        AxWindowsMediaPlayer1.settings.volume = TrackBar1.Value
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TrackBar1.Value = 0
            AxWindowsMediaPlayer1.settings.volume = TrackBar1.Value.ToString
        Else
            TrackBar1.Value = 50
            AxWindowsMediaPlayer1.settings.volume = TrackBar1.Value.ToString
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
            If OpenFileDialog1.FileName.Contains(".mp3") Then
yuppy:
                ResizeVideoToolStripMenuItem.Enabled = False
                Size = RichTextBox1.Size
                CompactModeToolStripMenuItem.Checked = True
                Exit Sub
            ElseIf OpenFileDialog1.FileName.Contains(".wav") Then
                GoTo yuppy
            ElseIf OpenFileDialog1.FileName.Contains(".acc") Then
                GoTo yuppy
            ElseIf OpenFileDialog1.FileName.Contains(".wma") Then
                GoTo yuppy
            ElseIf OpenFileDialog1.FileName.Contains(".aif") Then
                GoTo yuppy
            ElseIf OpenFileDialog1.FileName.Contains(".aiff") Then
                GoTo yuppy
            ElseIf OpenFileDialog1.FileName.Contains(".ogg") Then
                GoTo yuppy
            Else
                ResizeVideoToolStripMenuItem.Enabled = True
                resizethattimer.Enabled = True
                CompactModeToolStripMenuItem.Checked = False
                Exit Sub
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
        If Not Desktop.usertype = "Guest" Then
            Dim companion As String = "False"
            If CheckBox1.Checked = True Then companion = "True"
            Dim data As String = volume.ToString() & ";" & fsize.Width & ";" & fsize.Height & ";" & companion & ";" & OpenFileDialog1.FileName & ";" & TrackBar2.Value & ";"
            My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & Desktop.user & "_mediaplayer.txt", data, False)
        End If
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            Form1.fadeout_animation(Me, composedwindow)
            Exit Sub
        Else
            Close()
        End If
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPaused Then
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        ElseIf AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayer1.Ctlcontrols.pause()
        Else
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If
    End Sub

    Private Sub ColorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorsToolStripMenuItem.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub FastForwardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FastForwardToolStripMenuItem.Click
        AxWindowsMediaPlayer1.Ctlcontrols.fastForward()
    End Sub

    Private Sub FastBackwardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FastBackwardToolStripMenuItem.Click
        AxWindowsMediaPlayer1.Ctlcontrols.fastReverse()
    End Sub

    Private Sub MaximizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaximizeToolStripMenuItem.Click
        If AxWindowsMediaPlayer1.fullScreen = False Then
            AxWindowsMediaPlayer1.fullScreen = True
        Else
            AxWindowsMediaPlayer1.fullScreen = False
        End If
    End Sub

    Private Sub MinimizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizeToolStripMenuItem.Click
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.hideanimation(Me, composedwindow)
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Hide()
    End Sub

    Private Sub TimeTracker_Tick(sender As Object, e As EventArgs) Handles TimeTracker.Tick
        Try
            If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
                TrackBar2.Visible = True
                Label5.Text = AxWindowsMediaPlayer1.Ctlcontrols.currentPositionString & "/" & AxWindowsMediaPlayer1.currentMedia.durationString
                TrackBar2.Maximum = AxWindowsMediaPlayer1.currentMedia.duration
                TrackBar2.Value = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition
                AxWindowsMediaPlayer1.Visible = True
                If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
                    'If CheckBox2.Checked = False Then Me.TransparencyKey = Nothing
                    Me.TransparencyKey = Desktop.appBg.BackColor
                End If
            ElseIf AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsReady Then
                Label5.Text = "00: 00/00:00"
                TrackBar2.Visible = False
                AxWindowsMediaPlayer1.Visible = False
                If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Me.TransparencyKey = Desktop.appBg.BackColor
                Exit Sub
            ElseIf AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPaused Then
                Label5.Text = AxWindowsMediaPlayer1.Ctlcontrols.currentPositionString & "/" & AxWindowsMediaPlayer1.currentMedia.durationString
                TrackBar2.Visible = True
                AxWindowsMediaPlayer1.Visible = True
                If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Me.TransparencyKey = Desktop.appBg.BackColor
                Exit Sub
            ElseIf AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsStopped Then
                Label5.Text = "00:00/00:00"
                TrackBar2.Visible = False
                AxWindowsMediaPlayer1.Visible = False
                If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Me.TransparencyKey = Desktop.appBg.BackColor
                Exit Sub
            ElseIf AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsUndefined Then
                Label5.Text = "00:00/00:00"
                TrackBar2.Visible = False
                AxWindowsMediaPlayer1.Visible = False
                If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Me.TransparencyKey = Desktop.appBg.BackColor
                Exit Sub
            ElseIf AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsWaiting Then
                Label5.Text = "00:00/00:00"
                TrackBar2.Visible = False
                AxWindowsMediaPlayer1.Visible = False
                If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Me.TransparencyKey = Desktop.appBg.BackColor
                Exit Sub
            Else
                TrackBar2.Visible = True
                Label5.Text = AxWindowsMediaPlayer1.Ctlcontrols.currentPositionString & "/" & AxWindowsMediaPlayer1.currentMedia.durationString
                TrackBar2.Maximum = AxWindowsMediaPlayer1.currentMedia.duration
                TrackBar2.Value = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition
                If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Me.TransparencyKey = Desktop.appBg.BackColor
                AxWindowsMediaPlayer1.Visible = True
            End If
            If Desktop.alldown Then
                'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
                Close()
            End If
        Catch ex As Exception
            TimeTracker.Enabled = False
            ESOD.Label5.Text = ex.Message
            ESOD.ShowDialog()
            TimeTracker.Enabled = True
        End Try
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.hideanimation(Me, composedwindow)
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Hide()
    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageDialog.messagetitle = "About"
        MessageDialog.messagetext = "Media Player 1.0a"
        MessageDialog.messageicon = "Info"
        'MessageDialog.ff = Me
        'MessageDialog.sf = composedwindow
        MessageDialog.ShowDialog()
    End Sub

    Private Sub TrackBar2_MouseUp(sender As Object, e As MouseEventArgs) Handles TrackBar2.MouseUp
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = TrackBar2.Value
        TimeTracker.Enabled = True
    End Sub

    Private Sub CompactModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompactModeToolStripMenuItem.Click
        If CompactModeToolStripMenuItem.Checked = True Then
            Size = MinimumSize
        ElseIf CompactModeToolStripMenuItem.Checked = False Then
            AxWindowsMediaPlayer1.stretchToFit = False
            If Not AxWindowsMediaPlayer1.currentMedia.imageSourceHeight = 0 Then
                Me.Size = New Size(AxWindowsMediaPlayer1.currentMedia.imageSourceWidth + 13, AxWindowsMediaPlayer1.currentMedia.imageSourceHeight + 94)
            Else
                Me.Size = New Size(574, 399)
            End If
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub TrackBar2_MouseDown(sender As Object, e As MouseEventArgs) Handles TrackBar2.MouseDown
        TimeTracker.Enabled = False
    End Sub

    Private Sub MediaPlay_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.BringToFront()
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Opacity = 1.0
        sreq = False
        If Desktop.dev = True Then CheckBox2.Visible = True
        If Not Desktop.usertype = "Guest" Then
            If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData.ToString() & "\Windowed\" & Desktop.user & "_mediaplayer.txt") Then
                Dim lst As String
                lst = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData.ToString() & "\Windowed\" & Desktop.user & "_mediaplayer.txt")
                Dim lstbox As ListBox = New ListBox
                lstbox.Items.AddRange(lst.Split(";"))
                lstbox.SelectedIndex = 0
                TrackBar1.Value = lstbox.SelectedItem
                lstbox.SelectedIndex = 1
                Dim x As Integer
                x = lstbox.SelectedItem
                lstbox.SelectedIndex = 2
                Dim y As Integer
                y = lstbox.SelectedItem
                Me.Size = New Size(x, y)
                fsize = Me.Size
                lstbox.SelectedIndex = 3
                If lstbox.SelectedItem = "True" Then CheckBox1.Checked = True
                If lstbox.SelectedItem = "False" Then CheckBox1.Checked = False
                lstbox.SelectedIndex = 4
                If My.Computer.FileSystem.FileExists(lstbox.SelectedItem) Then
                    OpenFileDialog1.FileName = lstbox.SelectedItem
                    AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
                    'lstbox.SelectedIndex = 5
                    'TrackBar2.Value = lstbox.SelectedItem
                Else
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub MediaPlay_VisibleChanged(sender As Object, e As System.EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            Form1.Setfont(Me, Label1, Label3)
            Label1.BackColor = Desktop.labelBg.BackColor
            Label1.ForeColor = Desktop.labelFg.BackColor
            Label3.BackColor = Desktop.labelBg.BackColor
            Label3.ForeColor = Desktop.labelFg.BackColor
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then
                Me.BackColor = Desktop.appBg.BackColor
            Else
                Me.BackColor = Desktop.appBg.BackColor
                Me.TransparencyKey = Desktop.appBg.BackColor
                With composedwindow
                    .AllowTransparency = True
                    .Opacity = 0.0
                    .Size = Size
                    .TopMost = True
                    .BackColor = Desktop.appBg.BackColor
                    .FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    .ShowInTaskbar = False
                    .ShowIcon = False
                End With
                composedwindow.Show()
                composedwindow.Size = Me.Size
                composedwindow.Location = Me.Location
                composedwindow.BringToFront()
                Form1.Fadein_animation(Me, composedwindow)
                Me.BringToFront()
            End If
            Me.ForeColor = Desktop.appFg.BackColor
        End If
    End Sub

    Private Sub Label1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles Label1.DoubleClick
        MaximizeToolStripMenuItem.PerformClick()
    End Sub

    Private Sub TerminateTimer_Tick(sender As System.Object, e As System.EventArgs) Handles TerminateTimer.Tick
        If LogoffWindow.Visible = True Then
            ExitToolStripMenuItem.PerformClick()
        ElseIf Desktop.MediaPlayerKill.Text = "kill" Then
            ExitToolStripMenuItem.PerformClick()
        ElseIf Lock.Visible = True Then
            Me.Hide()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Hide()
        ElseIf Desktop.restorewindow.Text = "Media Player" Then
            Me.Opacity = 1.0
            composedwindow.Opacity = 0.9
            Me.Show()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Show()
        End If
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            If composedwindow.IsDisposed = False Then
                If Not GetActiveWindow <> composedwindow.Handle Then
                    BringToFront()
                    If Me.Opacity = 1.0 Then MakesuretocloseTimer.Enabled = True
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

    Private Sub MediaPlay_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        Try
            Label1.BackColor = Desktop.labelBg.BackColor
            Label3.BackColor = Desktop.labelBg.BackColor
            'composedwindow.BringToFront()
            'Me.BringToFront()
            'If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            '   If rap = False Then
            '       If composedwindow.IsDisposed = False Then
            '           Me.BringToFront()
            '           rap = True
            '       End If
            '   End If
            ' End If
        Catch ex As Exception
            ESOD.Label5.Text = "Failed to apply theme: Theme engine may be corrupted" & vbNewLine & ex.Message
        End Try
    End Sub

    Private Sub MediaPlay_Deactivate(sender As System.Object, e As System.EventArgs) Handles MyBase.Deactivate
        Try
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
            rap = False
        Catch ex As Exception
            Form1.Hide()
            Form1.Timer1.Enabled = False
            ESOD.Button1.Visible = True
            ESOD.Label5.Text = "Failed to interact with theme: Theme engine may be damaged" & vbNewLine & ex.Message
            Try
                ESOD.ShowDialog()
            Catch exs As Exception
                ESOD.Label5.Text = "Failed to display YellowScreen" & vbNewLine & ex.Message
            End Try
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        tskmgr.ListBox1.Items.Remove("Media Player")
        Desktop.MediaPlayerKill.Text = "kill"
        Desktop.killtimer.Enabled = True
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
        ExitToolStripMenuItem.PerformClick()
    End Sub

    Private Sub OriginalSizeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OriginalSizeToolStripMenuItem.Click
        AxWindowsMediaPlayer1.stretchToFit = True
        Me.Size = New Size(AxWindowsMediaPlayer1.currentMedia.imageSourceWidth * 2 + 13, AxWindowsMediaPlayer1.currentMedia.imageSourceHeight * 2 + 94)
        fsize = Me.Size
    End Sub

    Private Sub OriginalSizeToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles OriginalSizeToolStripMenuItem1.Click
        AxWindowsMediaPlayer1.stretchToFit = False
        Me.Size = New Size(AxWindowsMediaPlayer1.currentMedia.imageSourceWidth + 13, AxWindowsMediaPlayer1.currentMedia.imageSourceHeight + 94)
        fsize = Me.Size
    End Sub

    Private Sub OfOriginalSizeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OfOriginalSizeToolStripMenuItem.Click
        AxWindowsMediaPlayer1.stretchToFit = False
        Me.Size = New Size(AxWindowsMediaPlayer1.currentMedia.imageSourceWidth / 2 + 13, AxWindowsMediaPlayer1.currentMedia.imageSourceHeight / 2 + 94)
        fsize = Me.Size
    End Sub

    Private Sub Resizethattimer_Tick(sender As System.Object, e As System.EventArgs) Handles resizethattimer.Tick
        AxWindowsMediaPlayer1.stretchToFit = False
        Me.Size = New Size(AxWindowsMediaPlayer1.currentMedia.imageSourceWidth + 13, AxWindowsMediaPlayer1.currentMedia.imageSourceHeight + 94)
        fsize = Me.Size
        resizethattimer.Enabled = False
    End Sub

    Private Sub MediaPlay_SizeChanged(sender As System.Object, e As System.EventArgs) Handles MyBase.SizeChanged
        composedwindow.Size = Me.Size
    End Sub

    Private Sub AxWindowsMediaPlayer1_PlayStateChange(sender As System.Object, e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayer1.PlayStateChange

    End Sub

    Private Sub MakesuretocloseTimer_Tick(sender As System.Object, e As System.EventArgs) Handles MakesuretocloseTimer.Tick
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then MakesuretocloseTimer.Enabled = False
        If Form1.FadeInTimer.Enabled = True Then Exit Sub
        If Not Me.Opacity = 1.0 Or Me.Opacity = 0.0 Then
            Form1.fadeout_animation(Me, composedwindow)
        End If
    End Sub

    Private Sub DocumentationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentationToolStripMenuItem.Click
        Docs.launchdoc(My.Resources.MediaPlayerDocs, "Media player documentation")
    End Sub
End Class