Public Class Scoreboard
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim composedwindow As Form = New Form()
    Dim CurLocation, AppLocation As New Point(0, 0)
    Dim rap As Boolean = False
    Private Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim t1 As Integer
        t1 = Convert.ToInt32(Team1.Text) + 1
        Team1.Text = t1.ToString()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim t2 As Integer
        t2 = Convert.ToInt32(Team2.Text) + 1
        Team2.Text = t2.ToString()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Team1.Text = "0"
        Team2.Text = "0"
        Name1.Text = "Team 1"
        Name2.Text = "Team 2"
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Desktop.StandByToolStripMenuItem.PerformClick()
        Me.Hide()
        InputBoxDialog.txt = "Enter name for Team 1"
        InputBoxDialog.wintitle = "Change team names"
        InputBoxDialog.password = False
        InputBoxDialog.ShowDialog()
        Dim s As String
        s = InputBoxDialog.finalinput
        Me.Show()
        Desktop.WindowState = FormWindowState.Maximized
        Name1.Text = s
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Desktop.StandByToolStripMenuItem.PerformClick()
        Me.Hide()
        InputBoxDialog.txt = "Enter name for Team 2"
        InputBoxDialog.wintitle = "Change team names"
        InputBoxDialog.password = False
        InputBoxDialog.ShowDialog()
        Dim s As String
        s = InputBoxDialog.finalinput
        Me.Show()
        Desktop.WindowState = FormWindowState.Maximized
        Name2.Text = s
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        tskmgr.ListBox1.Items.Remove("Scoreboard")
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
        Me.Close()
    End Sub

    Private Sub Label4_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Label4.MouseDown
        drag = True
        mousex = Cursor.Position.X - Left
        mousey = Cursor.Position.Y - Top
    End Sub

    Private Sub Label4_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Label4.MouseMove
        If drag Then
            Top = Cursor.Position.Y - mousey
            Left = Cursor.Position.X - mousex
            composedwindow.Top = Me.Top
            composedwindow.Left = Me.Left
        End If
    End Sub

    Private Sub Label4_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Label4.MouseUp
        drag = False
        composedwindow.BringToFront()
        Me.BringToFront()
    End Sub

    Private Sub ResizeTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ResizeTimer.Tick
        Size = AppLocation - CurLocation + Cursor.Position
        composedwindow.Size = Me.Size
    End Sub
    Private Sub Scoreboard_VisibleChanged(sender As Object, e As System.EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            Form1.Setfont(Me, Label4, Label1)
            Label4.BackColor = Desktop.labelBg.BackColor
            Label4.ForeColor = Desktop.labelFg.BackColor
            Label1.BackColor = Label4.BackColor
            Label1.ForeColor = Label4.ForeColor
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then
                Me.BackColor = Desktop.appBg.BackColor
                Me.TransparencyKey = Nothing
            ElseIf Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
                Form1.Translucency(Me, composedwindow, True)
            End If
            'Me.Label3.BackColor = Desktop.appBg.BackColor
            'Me.Team1.BackColor = Desktop.appBg.BackColor
            'Me.Team2.BackColor = Desktop.appBg.BackColor
            'Me.Name1.BackColor = Desktop.appBg.BackColor
            'Me.Name2.BackColor = Desktop.appBg.BackColor

            Me.Button1.BackColor = Desktop.appBg.BackColor
            Me.Button2.BackColor = Desktop.appBg.BackColor
            Me.ForeColor = Desktop.appFg.BackColor
            Label5.BackColor = Me.BackColor
        End If
    End Sub

    Private Sub Label5_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Label5.MouseDown
        ResizeTimer.Start()
        Sync()
    End Sub

    Private Sub Label5_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Label5.MouseUp
        ResizeTimer.Stop()
        Sync()
        composedwindow.BringToFront()
        Me.BringToFront()
    End Sub
    Private Sub Sync()
        CurLocation = Cursor.Position
        AppLocation = Size
    End Sub

    Private Sub Scoreboard_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        Label4.BackColor = Desktop.labelBg.BackColor
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

    Private Sub Scoreboard_Deactivate(sender As System.Object, e As System.EventArgs) Handles MyBase.Deactivate
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
        Label4.BackColor = col
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            If composedwindow.IsDisposed = False Then
                If Not GetActiveWindow <> composedwindow.Handle Then
                    Me.BringToFront()
                End If
            End If
        End If
        rap = False
    End Sub

    Private Sub Scoreboard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Opacity = 1.0
        If Not tskmgr.ListBox1.Items.Contains("Scoreboard") Then tskmgr.ListBox1.Items.Add("Scoreboard")
    End Sub

    Private Sub KillTimer_Tick(sender As System.Object, e As System.EventArgs) Handles KillTimer.Tick
        If Desktop.scoreboardkill.Text = "kill" Then
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
                Form1.fadeout_animation(Me, composedwindow)
                Exit Sub
            Else
                Me.Close()
            End If

        ElseIf Desktop.restorewindow.Text = "Scoreboard" Then
            Me.Opacity = 1.0
            composedwindow.Opacity = 0.9
            Me.Show()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Show()

        ElseIf Lock.Visible = True Then
            Me.Hide()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Hide()
        ElseIf LogoffWindow.Visible = True Then
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
                Form1.fadeout_animation(Me, composedwindow)
                Exit Sub
            Else
                Me.Close()
            End If
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

    Private Sub ChangeNameForTeam1ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChangeNameForTeam1ToolStripMenuItem.Click
        Name1.Text = Form1.InputDialog("Enter name for team 1", "Manage teams")
    End Sub

    Private Sub ChangeNameForTeam2ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChangeNameForTeam2ToolStripMenuItem.Click
        Name2.Text = Form1.InputDialog("Enter name for team 2", "Manage teams")
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        Button3.PerformClick()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            Form1.fadeout_animation(Me, composedwindow)
            Exit Sub
        Else
            Me.Close()
        End If
    End Sub

    Private Sub EndProcessToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EndProcessToolStripMenuItem.Click
        tskmgr.ListBox1.Items.Remove("Scoreboard")
        Desktop.scoreboardkill.Text = "kill"
        Desktop.killtimer.Enabled = True
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            Form1.fadeout_animation(Me, composedwindow)
            Exit Sub
        Else
            Me.Close()
        End If
    End Sub

    Private Sub MakesuretocloseTimer_Tick(sender As System.Object, e As System.EventArgs) Handles MakesuretocloseTimer.Tick
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then MakesuretocloseTimer.Enabled = False
        If Form1.FadeInTimer.Enabled = True Then Exit Sub
        If Not Me.Opacity = 1.0 Or Me.Opacity = 0.0 Then
            Form1.fadeout_animation(Me, composedwindow)
        End If
    End Sub

    Private Sub Label4_BackColorChanged(sender As Object, e As EventArgs) Handles Label4.BackColorChanged
        Label1.BackColor = Label4.BackColor
        Label1.ForeColor = Label4.ForeColor
    End Sub

    Private Sub ViewDesktopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDesktopToolStripMenuItem.Click
        Me.Hide()
        composedwindow.Hide()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Form1.MsgDialog("Scoreboard 1.0r", "About", "Info")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ViewDesktopToolStripMenuItem.PerformClick()
    End Sub

End Class