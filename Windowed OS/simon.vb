Public Class simon
    Dim pim As String = ""
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim aim As String = ""
    Public composedwindow As Form = New Form()
    Dim rap As Boolean = False
    Private Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Button1.BackColor = Color.Red
        Button1.ForeColor = Color.Red
        DimTimer.Enabled = True
        If Form1.es = True Then My.Computer.Audio.Play(My.Resources.pitch1, AudioPlayMode.Background)
        If aim = "" And pim = "" Then
            Label2.Text = "Red"
            Exit Sub
        End If
        If showtimer.Enabled = False Then aim = aim & "r"
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Button2.BackColor = Color.Lime
        Button2.ForeColor = Color.Lime
        DimTimer.Enabled = True
        If Form1.es = True Then My.Computer.Audio.Play(My.Resources.pitch2, AudioPlayMode.Background)
        If aim = "" And pim = "" Then
            Label2.Text = "Green"
            Exit Sub
        End If
        If showtimer.Enabled = False Then aim = aim & "g"
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Button4.BackColor = Color.Yellow
        Button4.ForeColor = Color.Yellow
        DimTimer.Enabled = True
        If Form1.es = True Then My.Computer.Audio.Play(My.Resources.pitch3, AudioPlayMode.Background)
        If aim = "" And pim = "" Then
            Label2.Text = "Yellow"
            Exit Sub
        End If
        If showtimer.Enabled = False Then aim = aim & "y"
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Button3.BackColor = Color.Blue
        Button3.ForeColor = Color.Blue
        DimTimer.Enabled = True
        If Form1.es = True Then My.Computer.Audio.Play(My.Resources.pitch4, AudioPlayMode.Background)
        If aim = "" And pim = "" Then
            Label2.Text = "Blue"
            Exit Sub
        End If
        If showtimer.Enabled = False Then aim = aim & "b"
    End Sub

    Private Sub DimTimer_Tick(sender As System.Object, e As System.EventArgs) Handles DimTimer.Tick
        Button1.BackColor = Color.DarkRed
        Button2.BackColor = Color.DarkGreen
        Button3.BackColor = Color.DarkBlue
        Button4.BackColor = Color.Olive
        DimTimer.Enabled = False
        If aim = "" And pim = "" Then
            Exit Sub
        End If
        If aim = pim Then
            If aim = "" Then Exit Sub
            aim = ""
            Dim Rnd As Random = New Random()
            Dim s As Integer = Rnd.Next(4)
            If s = 0 Then pim += "r"
            If s = 1 Then pim += "g"
            If s = 2 Then pim += "y"
            If s = 3 Then pim += "b"
            If s = 4 Then pim += "b"
            ProgressBar1.Maximum = pim.Length
            Label2.Text = "Difficulty: " + pim.Length.ToString()
            If showtimer.Interval > 20 Then
                showtimer.Interval = showtimer.Interval - 20
            End If
            showtimer.Enabled = True
        End If
        If aim.Length > pim.Length Then
            RestartToolStripMenuItem.PerformClick()
        End If
    End Sub

    Private Sub showtimer_Tick(sender As System.Object, e As System.EventArgs) Handles showtimer.Tick
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
            Label2.Text = "Difficulty: " + pim.Length.ToString()
            showtimer.Enabled = False
            ProgressBar1.Value = 0
        Else
            Label2.Text = "Demo"
            Try
                Button1.Enabled = True
                Button2.Enabled = True
                Button3.Enabled = True
                Button4.Enabled = True
                If pim.Substring(ProgressBar1.Value, 1) = "r" Then Button1.PerformClick()
                If pim.Substring(ProgressBar1.Value, 1) = "g" Then Button2.PerformClick()
                If pim.Substring(ProgressBar1.Value, 1) = "y" Then Button4.PerformClick()
                If pim.Substring(ProgressBar1.Value, 1) = "b" Then Button3.PerformClick()
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                ProgressBar1.Value = ProgressBar1.Value + 1
                Label1.Text = pim
            Catch
                showtimer.Enabled = False
            End Try
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Close()
    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RestartToolStripMenuItem.Click
        pim = ""
        aim = ""
        Label2.Text = "Difficulty: 1"
        Dim Rnd As Random = New Random()
        Dim s As Integer = Rnd.Next(4)
        If s = 0 Then pim += "r"
        If s = 1 Then pim += "g"
        If s = 2 Then pim += "y"
        If s = 3 Then pim += "b"
        If s = 4 Then pim += "b"
        ProgressBar1.Maximum = pim.Length
        If SlowToolStripMenuItem.Checked = True Then
            showtimer.Interval = 2000
            DimTimer.Interval = 1000
        ElseIf MediumToolStripMenuItem.Checked = True Then
            showtimer.Interval = 1000
            DimTimer.Interval = 500
        ElseIf FastToolStripMenuItem.Checked = True Then
            showtimer.Interval = 500
            DimTimer.Interval = 250
        End If
        showtimer.Enabled = True
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click
        pim = "r"
        aim = "r"
        DimTimer.Enabled = True
    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label4.MouseDown
        drag = True
        mousex = Cursor.Position.X - Left
        mousey = Cursor.Position.Y - Top
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label4.MouseMove
        If drag Then
            Top = Cursor.Position.Y - mousey
            Left = Cursor.Position.X - mousex
            composedwindow.Location = Me.Location
        End If
    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label4.MouseUp
        drag = False
        composedwindow.BringToFront()
        Me.BringToFront()
    End Sub

    Private Sub Simon_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible = True Then
            Form1.Setfont(Me, Label4)
            Label4.BackColor = Desktop.labelBg.BackColor
            Label4.ForeColor = Desktop.labelFg.BackColor
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then
                Me.Opacity = 1.0
                Me.BackColor = Desktop.appBg.BackColor
                Me.TransparencyKey = Nothing
            ElseIf Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
                composedwindow.Opacity = 0.8
                Me.BackColor = Desktop.appBg.BackColor
                Me.TransparencyKey = Desktop.appBg.BackColor
                composedwindow.AllowTransparency = True
                composedwindow.Size = Me.Size
                composedwindow.TopMost = True
                composedwindow.BackColor = Desktop.appBg.BackColor
                composedwindow.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                composedwindow.ShowInTaskbar = False
                composedwindow.ShowIcon = False
                composedwindow.Show()
                composedwindow.Size = Me.Size
                composedwindow.Location = Me.Location
                composedwindow.BringToFront()
                Me.BringToFront()
            End If
            Me.ForeColor = Desktop.appFg.BackColor
        End If
    End Sub

    Private Sub Simon_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub KillTimer_Tick(sender As Object, e As EventArgs) Handles KillTimer.Tick
        If LogoffWindow.Visible = True Then
            CloseToolStripMenuItem.PerformClick()
            Exit Sub
        End If
        If Desktop.paintkill.Text = "kill" Then
            CloseToolStripMenuItem.PerformClick()
            Exit Sub
        ElseIf Lock.Visible = True Then
            Me.Hide()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Hide()
        ElseIf LogoffWindow.Visible = True Then
            CloseToolStripMenuItem.PerformClick()
            Exit Sub
        ElseIf Desktop.restorewindow.Text = "Simon says" Then
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

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageDialog.messageicon = "Info"
        MessageDialog.messagetext = "Simon says for Windowed O/S version 1.0r"
        MessageDialog.messagetitle = "About Simon"
        MessageDialog.messagetype = "OKOnly"
        MessageDialog.ShowDialog()
    End Sub

    Private Sub GameplayRulesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GameplayRulesToolStripMenuItem.Click
        MessageDialog.messageicon = "Help"
        MessageDialog.messagetext = "How to play simon:" + vbNewLine + "This is a simple memory game. After pressing Restart or making a correct turn, you'll get a demonstration on the sequence of colored buttons you need to press. Each time the sequence gets longer and the demonstration gets faster. If you make an incorrect turn, the game will reset automatically."
        MessageDialog.messagetitle = "Gameplay rules"
        MessageDialog.messagetype = "OKOnly"
        MessageDialog.ShowDialog()
    End Sub

    Private Sub Button3_KeyDown(sender As Object, e As KeyEventArgs) Handles Button4.KeyDown, Button3.KeyDown, Button2.KeyDown, Button1.KeyDown
        If e.KeyCode = Keys.Q Then
            Button1.PerformClick()
        ElseIf e.KeyCode = Keys.W Then
            Button2.PerformClick()
        ElseIf e.KeyCode = Keys.A Then
            Button4.PerformClick()
        ElseIf e.KeyCode = Keys.S Then
            Button3.PerformClick()
        End If
    End Sub

    Private Sub FreeModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FreeModeToolStripMenuItem.Click
        aim = ""
        pim = ""
        Label2.Text = "Free mode"
    End Sub

    Private Sub SlowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SlowToolStripMenuItem.Click
        If SlowToolStripMenuItem.Checked = True Then
            MediumToolStripMenuItem.Checked = False
            FastToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub MediumToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MediumToolStripMenuItem.Click
        If MediumToolStripMenuItem.Checked = True Then
            SlowToolStripMenuItem.Checked = False
            FastToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub FastToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FastToolStripMenuItem.Click
        If FastToolStripMenuItem.Checked = True Then
            SlowToolStripMenuItem.Checked = False
            MediumToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub Simon_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
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

    Private Sub Simon_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
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
End Class