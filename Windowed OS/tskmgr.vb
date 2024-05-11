Public Class tskmgr
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim CurLocation, AppLocation As New Point(0, 0)
    Dim composedwindow As Form = New Form()
    Dim rap As Boolean = False
    Dim x As Integer = 1
    Public ninstance As Integer = 0
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
        composedwindow.Size = Me.Size()
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
            composedwindow.Top = Me.Top
            composedwindow.Left = Me.Left
        End If
    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp
        drag = False
        composedwindow.BringToFront()
        Me.BringToFront()
    End Sub

    Private Sub tskmgr_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Opacity = 1.0
        For i As Integer = 0 To ListBox1.Items.Count - 1
            ListBox1.SelectedIndex = i
        Next
        Hide()
    End Sub
    Public Sub GetProcesses()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Sorted = False
        If ListBox1.SelectedItem = "Rich Text Notepad" Then
            Notepad.Close()
            ListBox1.Items.Remove("Rich Text Notepad")
            Desktop.NotepadKill.Text = "kill"
            'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
            Desktop.killtimer.Enabled = True
        ElseIf ListBox1.SelectedItem = "Web Explorer" Then
            WebBrowser.Close()
            ListBox1.Items.Remove("Web Explorer")
            Desktop.WebBrowserKill.Text = "kill"
            'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
            Desktop.killtimer.Enabled = True
        ElseIf ListBox1.SelectedItem = "Calculator" Then
            Calculator.Close()
            ListBox1.Items.Remove("Calculator")
            Desktop.calckill.Text = "kill"
            'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
            Desktop.killtimer.Enabled = True
        ElseIf ListBox1.SelectedItem = "App Center" Then
            Store.Close()
            ListBox1.Items.Remove("App Center")
            Desktop.KillSignal.Text = "App Center"
        ElseIf ListBox1.SelectedItem = "Paintbrush" Then
            Paintbrush.Close()
            ListBox1.Items.Remove("Paintbrush")
            Desktop.paintkill.Text = "kill"
            'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
            Desktop.killtimer.Enabled = True
        ElseIf ListBox1.SelectedItem = "Scoreboard" Then
            Scoreboard.Close()
            ListBox1.Items.Remove("Scoreboard")
            Desktop.scoreboardkill.Text = "kill"
            'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
            Desktop.killtimer.Enabled = True
        ElseIf ListBox1.SelectedItem = "Media Player" Then
            MediaPlay.Close()
            ListBox1.Items.Remove("Media Player")
            Desktop.MediaPlayerKill.Text = "kill"
            'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
            Desktop.killtimer.Enabled = True
        ElseIf ListBox1.SelectedItem = "Picture View" Then
            PictureViewer.Close()
            ListBox1.Items.Remove("Picture View")
            Desktop.PictureKill.Text = "kill"
            'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
            Desktop.killtimer.Enabled = True
        ElseIf ListBox1.SelectedItem = "TicTacToe game" Then
            TicTacToe.Close()
            ListBox1.Items.Remove("TicTacToe game")
            'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
            MessageDialog.messagetitle = "Task manager"
            MessageDialog.messagetext = "Done"
            MessageDialog.messageicon = "Info"
            'MessageDialog.ff = Me
            'MessageDialog.sf = composedwindow
            MessageDialog.ShowDialog()
        ElseIf ListBox1.SelectedItem = "Tasks and resources" Then
            ListBox1.Items.Remove("Tasks and resources")
            'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
            ListBox1.UseWaitCursor = True
            UseWaitCursor = True
            Button1.UseWaitCursor = True
            Button2.UseWaitCursor = True
            Label1.UseWaitCursor = True
            Label2.UseWaitCursor = True
            MenuStrip1.UseWaitCursor = True
            Label3.UseWaitCursor = True
            Label1.Visible = False
            Label2.Visible = False
            Button1.Visible = False
            Label3.Visible = False
            Button2.Visible = False
            MenuStrip1.Visible = False
            ListBox1.Visible = False
            MessageDialog.messagetitle = "Task manager"
            MessageDialog.messagetext = "Done"
            MessageDialog.messageicon = "Info"
            'MessageDialog.ff = Me
            'MessageDialog.sf = composedwindow
            MessageDialog.ShowDialog()
        ElseIf ListBox1.SelectedItem = "System I/O Framework" Then
            UseWaitCursor = True
            ListBox1.UseWaitCursor = True
            Button1.UseWaitCursor = True
            Desktop.MediaPlayerToolStripMenuItem.Visible = False
            Desktop.PictureViewToolStripMenuItem.Visible = False
            Desktop.NotepadToolStripMenuItem.Visible = False
            Desktop.WebBrowserToolStripMenuItem.Visible = False
            If PictureViewer.Visible = True Then PictureViewer.Close()
            ListBox1.Items.Remove("Picture View")
            If WebBrowser.Visible = True Then WebBrowser.Close()
            ListBox1.Items.Remove("Web Explorer")
            If MediaPlay.Visible = True Then MediaPlay.Close()
            ListBox1.Items.Remove("Media Player")
            If Notepad.Visible = True Then Notepad.Close()
            ListBox1.Items.Remove("Rich Text Notepad")
            ListBox1.Items.Remove("System I/O Framework")
            Desktop.ContextMenuStrip5.Enabled = False
            Desktop.ContextMenuStrip5.Items.Clear()
            Desktop.PictureBox2.Visible = False
            Desktop.PictureBox3.Visible = False
            Desktop.PictureBox4.Visible = False
            Desktop.PictureBox5.Visible = False
            Desktop.CPU_Tracker.Enabled = False
            Desktop.ChangeWallpaperToolStripMenuItem.Enabled = False
            Desktop.ChangeTickSpeedToolStripMenuItem.Enabled = False
            Desktop.ShowCPUUsageToolStripMenuItem.Visible = False
            Desktop.Timer1.Enabled = False
            Desktop.ShowDateAndTimeToolStripMenuItem.Visible = False
            MessageDialog.messagetitle = "Date and time Tracker"
            MessageDialog.messagetext = "Unable to update date and time"
            MessageDialog.messageicon = "Critical"
            'MessageDialog.ff = Me
            'MessageDialog.sf = composedwindow
            MessageDialog.ShowDialog()
            Desktop.Label1.Text = ""
            MessageDialog.messagetitle = "CPU Tracker"
            MessageDialog.messagetext = "Unable to update CPU usage"
            MessageDialog.messageicon = "Critical"
            'MessageDialog.ff = Me
            'MessageDialog.sf = composedwindow
            MessageDialog.ShowDialog()
            Desktop.Label2.Text = ""
            UseWaitCursor = False
            ListBox1.UseWaitCursor = False
            Button1.UseWaitCursor = False
            'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
            MessageDialog.messagetitle = "Task manager"
            MessageDialog.messagetext = "Done"
            MessageDialog.messageicon = "Info"
            'MessageDialog.ff = Me
            'MessageDialog.sf = composedwindow
            MessageDialog.ShowDialog()
            MessageDialog.messagetitle = "Critical Error"
            MessageDialog.messagetext = "Some apps were disabled, because the System.IO is corrupted, terminated or absent."
            MessageDialog.messageicon = "Critical"
            'MessageDialog.ff = Me
            'MessageDialog.sf = composedwindow
            MessageDialog.ShowDialog()
            MessageDialog.messagetitle = "Task Manager"
            MessageDialog.messagetext = "Some applications related to this application were closed too"
            MessageDialog.messageicon = "Warning"
            'MessageDialog.ff = Me
            'MessageDialog.sf = composedwindow
            MessageDialog.ShowDialog()
        ElseIf ListBox1.SelectedItem = "Windowed Desktop Environment" Then
            'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
            Desktop.Close()
            ListBox1.Items.Remove("Windowed Desktop Environment")
            MessageDialog.messagetitle = "Task manager"
            MessageDialog.messagetext = "Done"
            MessageDialog.messageicon = "Info"
            'MessageDialog.ff = Me
            'MessageDialog.sf = composedwindow
            MessageDialog.ShowDialog()
        Else
            Desktop.KillSignal.Text = ListBox1.SelectedItem.ToString()
            ListBox1.Items.Remove(ListBox1.SelectedItem.ToString())
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageDialog.messagetitle = "About"
        MessageDialog.messagetext = "Task Manager 1.0a"
        MessageDialog.messageicon = "Info"
        'MessageDialog.ff = Me
        'MessageDialog.sf = composedwindow
        MessageDialog.ShowDialog()
    End Sub

    Private Sub ViewDesktopToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.hideanimation(Me, composedwindow)
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.hideanimation(Me, composedwindow)
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Desktop.restorewindow.Text = ListBox1.SelectedItem.ToString()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub SuleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuleToolStripMenuItem.Click
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.hideanimation(Me, composedwindow)
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Hide()
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        If ListBox1.SelectedItem = "Rich Text Notepad" Then
            Notepad.Show()
        ElseIf ListBox1.SelectedItem = "Web Explorer" Then
            WebBrowser.Show()
        ElseIf ListBox1.SelectedItem = "Media Player" Then
            MediaPlay.Show()
        ElseIf ListBox1.SelectedItem = "Picture View" Then
            PictureViewer.Show()
        ElseIf ListBox1.SelectedItem = "Task Manager" Then
            Show()
        ElseIf ListBox1.SelectedItem = "TicTacToe game" Then
            TicTacToe.Show()
        ElseIf ListBox1.SelectedItem = "System I/O Framework" Then
            MsgBox("<blink>Stop it!</blink>")
        ElseIf ListBox1.SelectedItem = "Windowed Desktop Environment" Then
            Desktop.Show()
        End If
    End Sub

    Private Sub tskmgr_VisibleChanged(sender As Object, e As System.EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Opacity = 1.0
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Me.Opacity = 0.0
            Label1.BackColor = Desktop.labelBg.BackColor
            Label1.ForeColor = Desktop.labelFg.BackColor
            Form1.Setfont(Me, Label1, Label3)
            Label3.BackColor = Desktop.labelBg.BackColor
            Label3.ForeColor = Desktop.labelFg.BackColor
            composedwindow.Opacity = 0.0
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.BackColor = Desktop.appBg.BackColor
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.translucency(Me, composedwindow, True)
            Me.ForeColor = Desktop.appFg.BackColor
            Label2.BackColor = Me.BackColor
        ElseIf Me.Visible = False Then
            composedwindow.Hide()
        End If
    End Sub

    Private Sub TerminateTimer_Tick(sender As System.Object, e As System.EventArgs) Handles TerminateTimer.Tick
        If LogoffWindow.Visible = True Then
            composedwindow.Close()
            Me.Close()
        ElseIf Lock.Visible = True Then
            Me.Hide()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Hide()
        End If
        If Desktop.Label4.Text = "Finished restoring windows" Then
            composedwindow.Show()
            Me.Show()
            composedwindow.Hide()
            Me.Hide()
            Desktop.Label4.Text = "Ready"
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
                Button1.BackColor = Desktop.appBg.BackColor
                Button2.BackColor = Desktop.appBg.BackColor
                composedwindow.Hide()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub tskmgr_Deactivate(sender As System.Object, e As System.EventArgs) Handles MyBase.Deactivate
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

    Private Sub tskmgr_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
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

    Private Sub TabControl1_TabIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.TabIndexChanged
        If TabControl1.TabIndex = 1 Then
            Button1.Visible = False
            Button2.Visible = False
        ElseIf TabControl1.TabIndex = 0 Then
            Button1.Visible = True
            Button2.Visible = True
        End If
    End Sub

    Private Sub GraphUpdater_Tick(sender As Object, e As EventArgs) Handles GraphUpdater.Tick
        Dim y As Integer
        y = CPUCounter.NextValue()
        Chart1.Series("CPU usage").Points.AddXY(x, y)
        CPULabel.Text = "CPU: " & y.ToString() & "%"
        y = RAMCounter.NextValue()
        Chart1.Series("RAM usage").Points.AddXY(x, y)
        RAMLabel.Text = "RAM: " & y.ToString() & "%"
        y = DiskAccessCounter.NextValue()
        Chart1.Series("Disk access").Points.AddXY(x, y)
        DiskReadLabel.Text = "LDDR: " & y.ToString() & "%"
        y = DiskReadCounter.NextValue()
        Chart1.Series("Disk write").Points.AddXY(x, y)
        DiskWriteLabel.Text = "LDDW: " & y.ToString() & "%"
        If x > 20 Then
            Chart1.ChartAreas("ChartArea1").AxisX.Minimum = x - 19
            Chart1.ChartAreas("ChartArea1").AxisX.Maximum = x
            Chart1.ChartAreas("ChartArea1").AxisX.Title = "Uptime (" + Chart1.ChartAreas("ChartArea1").AxisX.Maximum.ToString() + " seconds)"
        Else
            Chart1.ChartAreas("ChartArea1").AxisX.Title = "Uptime (" + x.ToString() + " seconds)"
        End If
        TimeLabel.Text = "TIME: " & x.ToString() & " secs"
        TaskLabel.Text = "Processes: " & ListBox1.Items.Count.ToString()
        x = x + 1
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 1 Then
            Button1.Visible = False
            Button2.Visible = False
        ElseIf TabControl1.SelectedIndex = 0 Then
            Button1.Visible = True
            Button2.Visible = True
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            ListBox1.Sorted = True
            ListBox1.SelectedIndex = ListView1.SelectedItems(0).Index
            ListBox1.Sorted = False
        Catch
        End Try
    End Sub

    Private Sub tskmgr_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

    End Sub
End Class