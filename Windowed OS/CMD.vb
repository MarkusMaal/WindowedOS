Public Class CMD
    Dim drag As Boolean
    Dim mousey As Integer
    Dim mousex As Integer
    Dim CurLocation, AppLocation As New Point(0, 0)
    Dim composedwindow As Form = New Form()
    Dim rap As Boolean = False
    Dim commands(999) As String
    Dim index As Integer = 0
    Private Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label4.MouseDown
        drag = True
        mousex = Cursor.Position.X - Left
        mousey = Cursor.Position.Y - Top
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label4.MouseMove
        If drag Then
            Top = Cursor.Position.Y - mousey
            Left = Cursor.Position.X - mousex
            composedwindow.Left = Left
            composedwindow.Top = Top
        End If
    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label4.MouseUp
        drag = False
        composedwindow.BringToFront()
        Me.BringToFront()
    End Sub

    Private Sub CMD_Deactivate(sender As Object, e As System.EventArgs) Handles Me.Deactivate
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
    Private Sub CMD_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Opacity = 1.0
        TextBox1.Select()
    End Sub

    Private Sub TextBox1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            commands(index) = TextBox1.Text
            If index = 999 Then index = -1
            index += 1
            If TextBox1.Text = "?" Then
                TextBox2.Text = TextBox2.Text & vbNewLine & "? out (text) ver hide whoami prompt sytem (s/r/l/sb/la/r/(c)/sc) font (1-15) app (appname) user (name/password) exit (-a)"
            ElseIf TextBox1.Text = "exit" Then
                'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
                If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Close()
                If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.Fadeout_animation(Me, composedwindow)
            ElseIf TextBox1.Text = "exit -a" Then
                Desktop.commandkill.Text = "kill"
                Desktop.killtimer.Enabled = True
                If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Close()
                If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.Fadeout_animation(Me, composedwindow)
            ElseIf TextBox1.Text = "user name" Then
                InputBoxDialog.txt = "Enter your new password"
                InputBoxDialog.wintitle = "New password"
                InputBoxDialog.password = True
                InputBoxDialog.ShowDialog()
                Dim p As String
                p = InputBoxDialog.finalinput
                Desktop.passwd = Login.Encrypt(p, p)
            ElseIf TextBox1.Text = "user password" Then
                Desktop.NotepadKill.Text = "kill"
                Desktop.WebBrowserKill.Text = "kill"
                Desktop.paintkill.Text = "kill"
                Desktop.calckill.Text = "kill"
                Desktop.commandkill.Text = "kill"
                Desktop.scoreboardkill.Text = "kill"
                Desktop.PictureKill.Text = "kill"
                Desktop.MediaPlayerKill.Text = "kill"
                'shows account setup
                Setup.ShowDialog()
                MessageDialog.messageicon = "Info"
                MessageDialog.messagetext = "Now logging out..."
                MessageDialog.messagetitle = "User account creation successful"
                MessageDialog.ShowDialog()
                'performs logout operation
                Desktop.LogOutToolStripMenuItem.PerformClick()
                Form1.Fadeout_animation(Me, composedwindow)
            ElseIf TextBox1.Text = "apps" Then
                listapps()
            ElseIf TextBox1.Text = "log" Then
                TextBox2.Text = TextBox2.Text & vbNewLine & "---------Command log start---------"
                Dim i As Integer = 0
                While commands(i) IsNot Nothing
                    TextBox2.Text = TextBox2.Text & vbNewLine & commands(i).ToString()
                    i += 1
                End While
                TextBox2.Text = TextBox2.Text & vbNewLine & "----------Command log end----------"
            ElseIf TextBox1.Text.StartsWith("app ") Then
                runapp(TextBox1.Text.Replace("app ", ""))
            ElseIf TextBox1.Text = "ver" Then
                TextBox2.Text = TextBox2.Text & vbNewLine & "Windowed OS version 1.1e"
            ElseIf TextBox1.Text = "hide" Then
                Me.Hide()
            ElseIf TextBox1.Text = "whoami" Then
                TextBox2.Text = TextBox2.Text & vbNewLine & "You are logged in as " & Desktop.user & " (" & Desktop.usertype & ")"
            ElseIf TextBox1.Text = "prompt" Then
                Dim myform As CMD = New CMD()
                myform.Show()
            ElseIf TextBox1.Text.StartsWith("system") Then
                If TextBox1.Text.EndsWith(" s") Then
                    Desktop.ShutDownToolStripMenuItem.PerformClick()
                ElseIf TextBox1.Text.EndsWith(" r") Then
                    Desktop.RebootToolStripMenuItem.PerformClick()
                ElseIf TextBox1.Text.EndsWith(" l") Then
                    Desktop.LogOutToolStripMenuItem.PerformClick()
                ElseIf TextBox1.Text.EndsWith(" sb") Then
                    Desktop.StandByToolStripMenuItem.PerformClick()
                ElseIf TextBox1.Text.EndsWith(" la") Then
                    Desktop.LockToolStripMenuItem.PerformClick()
                ElseIf TextBox1.Text.EndsWith(" sc") Then
                    My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\recovery.log", "This text file is used to automatically reboot to recovery mode", False)
                    Desktop.RebootToolStripMenuItem.PerformClick()
                ElseIf TextBox1.Text.EndsWith(" c") Then
                    Desktop.PerformCrashToolStripMenuItem.PerformClick()
                Else
                    TextBox2.Text = TextBox2.Text & vbNewLine & "Syntax error"
                End If
            ElseIf TextBox1.Text.StartsWith("font") Then
                Dim f As String = TextBox1.Text.Replace("font ", "")
                If f = 1 Then TextBox2.Font = New Font("Arial", 8, FontStyle.Regular, GraphicsUnit.Pixel)
                If f = 2 Then TextBox2.Font = New Font("Arial", 9, FontStyle.Regular, GraphicsUnit.Pixel)
                If f = 3 Then TextBox2.Font = New Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Pixel)
                If f = 4 Then TextBox2.Font = New Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Pixel)
                If f = 5 Then TextBox2.Font = New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Pixel)
                If f = 6 Then TextBox2.Font = New Font("Arial", 13, FontStyle.Regular, GraphicsUnit.Pixel)
                If f = 7 Then TextBox2.Font = New Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Pixel)
                If f = 8 Then TextBox2.Font = New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel)
                If f = 9 Then TextBox2.Font = New Font("Arial", 16, FontStyle.Regular, GraphicsUnit.Pixel)
                If f = 10 Then TextBox2.Font = New Font("Arial", 17, FontStyle.Regular, GraphicsUnit.Pixel)
                If f = 11 Then TextBox2.Font = New Font("Arial", 18, FontStyle.Regular, GraphicsUnit.Pixel)
                If f = 12 Then TextBox2.Font = New Font("Arial", 19, FontStyle.Regular, GraphicsUnit.Pixel)
                If f = 13 Then TextBox2.Font = New Font("Arial", 20, FontStyle.Regular, GraphicsUnit.Pixel)
                If f = 14 Then TextBox2.Font = New Font("Arial", 21, FontStyle.Regular, GraphicsUnit.Pixel)
                If f = 15 Then TextBox2.Font = New Font("Arial", 22, FontStyle.Regular, GraphicsUnit.Pixel)
                TextBox2.Text = TextBox2.Text & vbNewLine & "New font: " & f
            ElseIf TextBox1.Text.StartsWith("out") Then
                If TextBox1.Text = "out" Then
                    TextBox2.Text = ""
                    TextBox1.Text = ""
                    Exit Sub
                End If
                TextBox2.Text = TextBox2.Text & vbNewLine & TextBox1.Text.Replace("out ", "")
            Else
                TextBox2.Text = TextBox2.Text & vbNewLine & "Invalid command. Please type '?', to see all possible commands"
            End If
            TextBox1.Text = ""
        End If
    End Sub

    Sub runapp(ByVal appName As String)
        appName = appName.Replace(" ", "")
        appName = appName.ToUpper()
        Dim currentitem As ToolStripMenuItem = New ToolStripMenuItem()
        For j As Integer = 0 To Desktop.ProgramsToolStripMenuItem.DropDownItems.Count - 1
            currentitem = Desktop.ProgramsToolStripMenuItem.DropDownItems(j)
            For i As Integer = 0 To currentitem.DropDownItems.Count - 1
                If currentitem.DropDownItems(i).Text.Replace(" ", "").Replace("&", "").ToUpper = appName Then
                    TextBox2.Text = TextBox2.Text & vbNewLine & "Application launched at: " & currentitem.Text.Replace("&", "") & " " & currentitem.DropDownItems(i).Text.Replace("&", "")
                    currentitem.DropDownItems(i).PerformClick()
                    Exit Sub
                End If
            Next
        Next
        TextBox2.Text = TextBox2.Text & vbNewLine & "Specified application does not exist"
    End Sub

    Sub listapps()
        Dim currentitem As ToolStripMenuItem = New ToolStripMenuItem()
        For j As Integer = 0 To Desktop.ProgramsToolStripMenuItem.DropDownItems.Count - 1
            currentitem = Desktop.ProgramsToolStripMenuItem.DropDownItems(j)
            For i As Integer = 0 To currentitem.DropDownItems.Count - 1
                TextBox2.Text = TextBox2.Text & vbNewLine & currentitem.Text.Replace("&", "") & " " & currentitem.DropDownItems(i).Text.Replace("&", "") & " (" & currentitem.DropDownItems(i).Text.Replace("&", "").Replace(" ", "").ToUpper() & ")"
            Next
        Next
    End Sub
    Private Sub Sync()
        CurLocation = Cursor.Position
        AppLocation = Size
    End Sub

    Private Sub Label2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label5.MouseDown
        ResizeTimer.Start()
        Sync()
    End Sub

    Private Sub Label2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label5.MouseUp
        ResizeTimer.Stop()
        Sync()
        composedwindow.BringToFront()
        Me.BringToFront()
    End Sub

    Private Sub ResizeTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ResizeTimer.Tick
        Size = AppLocation - CurLocation + Cursor.Position
        composedwindow.Size = Size
    End Sub

    Private Sub CMD_VisibleChanged(sender As Object, e As System.EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            Form1.Setfont(Me, Label1)
            Label4.BackColor = Desktop.labelBg.BackColor
            Label4.ForeColor = Desktop.labelFg.BackColor
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.BackColor = Desktop.appBg.BackColor
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.Translucency(Me, composedwindow, True)
            Me.ForeColor = Desktop.appFg.BackColor
            Label5.BackColor = Me.BackColor
        End If
    End Sub

    Private Sub TerminateTimer_Tick(sender As System.Object, e As System.EventArgs) Handles TerminateTimer.Tick
        If LogoffWindow.Visible = True Then
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Close()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.fadeout_animation(Me, composedwindow)
        ElseIf Lock.Visible = True Then
            Me.Hide()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Hide()
        ElseIf Desktop.commandkill.Text = "kill" Then
            'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Close()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.fadeout_animation(Me, composedwindow)
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

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub CMD_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
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

    Private Sub TextBox1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.F11 Then
            If WindowState = FormWindowState.Normal Then
                WindowState = FormWindowState.Maximized
                Label4.Visible = False
                Exit Sub
            Else
                WindowState = FormWindowState.Normal
                Label4.Visible = True
                Exit Sub
            End If

        ElseIf e.KeyCode = Keys.Up Then
            index -= 1
            If index < 0 Then index = 0
            If commands(index) IsNot Nothing Then
                TextBox1.Text = commands(index)
            End If
        ElseIf e.KeyCode = Keys.Down Then
            index += 1
            If index > 999 Then index = 999
            If commands(index) IsNot Nothing Then
                TextBox1.Text = commands(index)
            End If
        End If
    End Sub

    Private Sub CMD_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F11 Then
            If WindowState = FormWindowState.Normal Then
                WindowState = FormWindowState.Maximized
                Label4.Visible = False
                Exit Sub
            Else
                WindowState = FormWindowState.Normal
                Label4.Visible = True
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Label4_DoubleClick(sender As Object, e As EventArgs) Handles Label4.DoubleClick
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
            Exit Sub
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub TextBox2_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.F11 Then
            If WindowState = FormWindowState.Normal Then
                TextBox2.Size = New Size(591, 334)
                TextBox2.Location = New Point(3, 1)
                WindowState = FormWindowState.Maximized
                Label4.Visible = False
                Exit Sub
            Else
                WindowState = FormWindowState.Normal
                TextBox2.Size = New Size(569, 264)
                TextBox2.Location = New Point(15, 47)
                Label4.Visible = True
                Exit Sub
            End If
        End If
    End Sub
End Class