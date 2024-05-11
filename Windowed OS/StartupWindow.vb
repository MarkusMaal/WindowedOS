Public Class StartupWindow
    Public composedwindow As Form = New Form()
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Me.TopMost = False
        Me.TopMost = True
    End Sub

    Private Sub StartupWindow_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        composedwindow.Close()
    End Sub

    Private Sub StartupWindow_VisibleChanged(sender As System.Object, e As System.EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible = True Then
            If Form1.edc = False Then Me.BackColor = Form1.appBg.BackColor
            If Form1.edc = True Then
                composedwindow.TopMost = True
                composedwindow.Opacity = 0.0
                composedwindow.BackColor = Form1.appBg.BackColor
                Desktop.appBg.BackColor = Form1.appBg.BackColor
                Me.Opacity = 0.0
                Me.Show()
                composedwindow.BringToFront()
                Me.TransparencyKey = Me.BackColor
                composedwindow.StartPosition = FormStartPosition.CenterScreen
                composedwindow.BackColor = Form1.appBg.BackColor
                composedwindow.Size = Me.Size
                composedwindow.Location = Me.Location
                composedwindow.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                composedwindow.Opacity = 0.9
                composedwindow.TopMost = True
                Me.TopMost = True
                composedwindow.Show()
                Me.Opacity = 1.0
                Me.BringToFront()
            End If
            Me.ForeColor = Form1.appFg.BackColor
            Me.LogoffTitle.BackColor = Form1.labelBg.BackColor
            Me.LogoffTitle.ForeColor = Form1.labelFg.BackColor
        End If
    End Sub

    Private Sub StartupWindow_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Form1.edc = False Then Me.Opacity = 1.0
        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\locator.txt") Then
            LogoffWindow.Text = "Cleaning temporary update files..."
            LogoffTitle.Text = "Finalizing update..."
            ProgressBar1.Visible = False
        End If
        LogoffWindow.ForeColor = Form1.appFg.BackColor
    End Sub

    Private Sub StartupWindow_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Delete Then
            Form1.Timer1.Enabled = False
            Me.Hide()
            If Form1.edc = True Then composedwindow.Hide()
            Recovery.ShowDialog()
        ElseIf e.KeyCode = Keys.F2 Then
            Me.Hide()
            Form1.Timer1.Enabled = False
            Desktop.appBg = Form1.appBg
            Desktop.appFg = Form1.appFg
            Desktop.labelBg = Form1.labelBg
            Desktop.labelFg = Form1.labelFg
            MessageDialog.messagetitle = "Uninstall all apps?"
            MessageDialog.messageicon = "Warning"
            MessageDialog.messagetext = "You've requested to delete all custom apps. Are you sure you want to do that? (all data made by these apps will be lost)"
            MessageDialog.messagetype = "YesNo"
            If MessageDialog.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                Try
                    My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Programs", FileIO.DeleteDirectoryOption.DeleteAllContents)
                Catch
                    MessageDialog.messagetype = "OKOnly"
                    MessageDialog.messageicon = "Critical"
                    MessageDialog.messagetitle = "Operation failed"
                    MessageDialog.messagetext = "System will now continue booting normally"
                    MessageDialog.ShowDialog()
                    Form1.Timer1.Enabled = True
                    Me.Show()
                    Exit Sub
                End Try
                MessageDialog.messagetype = "OKOnly"
                MessageDialog.messageicon = "Info"
                MessageDialog.messagetitle = "Operation successful"
                MessageDialog.messagetext = "System will now restart"
                MessageDialog.ShowDialog()
                Process.Start("Windowed OS.exe")
                Form1.Close()
                Me.Close()
                Form1.Timer1.Enabled = False
                Exit Sub
            Else
                Form1.Timer1.Enabled = True
                Me.Show()
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.W Then
            Process.Start(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed")
            Me.Close()
            Form1.Close()
            ElseIf e.KeyCode = Keys.Escape Then
                ShutDown.restart = False
                ShutDown.Show()
                Form1.Timer1.Enabled = False
                Exit Sub
            ElseIf e.KeyCode = Keys.F9 Then
                BIOS.Show()
                black.Show()
                Calculator.Show()
                ClickIt.Show()
                CMD.Show()
                CustomizationCenter.Show()
                Desktop.Show()
                ESOD.Show()
                GlobalSysConfig.Show()
                Login.Show()
                LoginPrompt.Show()
                LogoffWindow.Show()
                MediaPlay.Show()
                MessageDialog.Show()
                New_name_password.Show()
                Notepad.Show()
                Paintbrush.Show()
                PictureViewer.Show()
                Scoreboard.Show()
                Setup.Show()
                simon.Show()
                TicTacToe.Show()
                tskmgr.Show()
                WebBrowser.Show()
                Exit Sub
            ElseIf e.KeyCode = Keys.F8 Then
                Desktop.EnableDesktopCompositionToolStripMenuItem.Visible = False
                Desktop.PowerToolStripMenuItem.Visible = False
                Desktop.ShutDownToolStripMenuItem.Visible = False
                Desktop.FasterslowPerformanceToolStripMenuItem.Visible = False
                Desktop.ViewToolStripMenuItem.Visible = False
                Desktop.SettingsToolStripMenuItem.Visible = False
                Desktop.ProgramsToolStripMenuItem.Visible = False
                Desktop.AboutToolStripMenuItem.Visible = False
                Desktop.CheckForUpdatesToolStripMenuItem.Visible = False
                Desktop.PictureBox1.Visible = False
                Desktop.PictureBox2.Visible = False
                Desktop.PictureBox3.Visible = False
                Desktop.PictureBox4.Visible = False
                Desktop.PictureBox5.Visible = False
                Desktop.PictureBox6.Visible = False
                Desktop.PictureBox7.Visible = False
                Desktop.PictureBox8.Visible = False
                Desktop.PictureBox9.Visible = False
                Desktop.PictureBox10.Visible = False
                Desktop.ContextMenuStrip5.Enabled = False
                Desktop.Enabled = False
                Desktop.WindowState = FormWindowState.Minimized
            ElseIf e.KeyCode = Keys.F7 Then
                Form1.appBg = Nothing
                Form1.appFg = Nothing
                Form1.labelBg = Nothing
                Form1.labelFg = Nothing
                Desktop.appBg = Nothing
                Desktop.appFg = Nothing
                Desktop.labelBg = Nothing
                Desktop.labelFg = Nothing
                Form1.elw = Nothing
                Form1.ebs = Nothing
                Form1.edc = Nothing
                Form1.es = Nothing
                Form1.dev = Nothing
                Form1.bi = Nothing
                Form1.dtl = Nothing
                ProgressBar1.Value = ProgressBar1.Maximum
                Exit Sub
        ElseIf e.KeyCode = Keys.F12 Then
            beepboop()
        End If
    End Sub

    Private Sub LogoffWindow_Click(sender As Object, e As EventArgs) Handles LogoffWindow.Click

    End Sub

    Public Sub beepboop()
        Me.Hide()
        Form1.Timer1.Enabled = False
        Desktop.appBg = Form1.appBg
        Desktop.appFg = Form1.appFg
        Desktop.labelBg = Form1.labelBg
        Desktop.labelFg = Form1.labelFg
        MessageDialog.messagetype = "YesNo"
        MessageDialog.messageicon = "Warning"
        MessageDialog.messagetitle = "Emergency factory reset"
        MessageDialog.messagetext = "Would you like to perform F12 factory reset? (this will delete any user data)"
        If MessageDialog.ShowDialog() = Windows.Forms.DialogResult.Yes Then
            My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed", FileIO.DeleteDirectoryOption.DeleteAllContents)
            MessageDialog.messagetype = "OKOnly"
            MessageDialog.messageicon = "Info"
            MessageDialog.messagetitle = "Emergency factory reset"
            MessageDialog.messagetext = "System will now restart"
            MessageDialog.ShowDialog()
            Process.Start("Windowed OS.exe")
            Form1.Close()
            Me.Close()
            Form1.Timer1.Enabled = False
            Exit Sub
        Else
            If Recovery.Visible = False Then
                Form1.Timer1.Enabled = True
                Me.Show()
            End If
        End If
    End Sub
End Class