Imports System.IO
Public Class Settings
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim composedwindow As Form = New Form()
    Private Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr
    Dim CurLocation, AppLocation As New Point(0, 0)
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        composedwindow.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        FontDialog1.Font = voide.TextBox1.Font
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then
            Me.TransparencyKey = Nothing
            Me.Opacity = 1.0
        End If
        If Desktop.usertype = "Admin" Then
            DevelopmentPanel.Visible = False
            ToolStripLabel1.Text = "Note: You are currently in administrator access mode. You can access all settings apart from development settings."
        ElseIf Desktop.usertype = "Power" Then
            ToolStripLabel1.Text = "Note: You are currently in developer access mode. You can access all settings."
        ElseIf Desktop.usertype = "Standard" Then
            DevelopmentPanel.Visible = False
            SystemPanel.Visible = False
            ResetAppSettingsAll.Visible = False
            AddUser.Visible = False
            AutologinLabel.Visible = False
            ToolStripLabel1.Text = "Note: You are currently in standard access mode. Please log in as a higher priviledge user to access more settings."
        ElseIf Desktop.usertype = "Limited" Then
            DevelopmentPanel.Visible = False
            SystemPanel.Visible = False
            ResetAppSettingsAll.Visible = False
            CustomizationLink.Visible = False
            AddUser.Visible = False
            AutologinLabel.Visible = False
            ToolStripLabel1.Text = "Note: You are currently in limited access mode. Please log in as a higher priviledge user to access more settings."
        ElseIf Desktop.usertype = "Guest" Then
            DevelopmentPanel.Visible = False
            SystemPanel.Visible = False
            ResetAppSettingsAll.Visible = False
            CustomizationLink.Visible = False
            AddUser.Visible = False
            AddPasswd.Visible = False
            ChangeName.Visible = False
            AppPanel.Visible = False
            CustomizePanel.Visible = False
            AutologinLabel.Visible = False
            ToolStripLabel1.Text = "Note: You are currently in guest access mode. Most of these setting will not be saved after logging out."
        End If
        If Desktop.PictureBox9.Visible = True Then
            LinkLabel3.Text = "Hide desktop icons"
        ElseIf Desktop.PictureBox9.Visible = False Then
            LinkLabel3.Text = "Show desktop icons"
        End If
        If Desktop.passwd = "JlnAU+w22tzhFyQmEMDK/g==" Then
            AddPasswd.Text = "Add a password"
        Else
            AddPasswd.Text = "Change your password"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tskmgr.ListBox1.Items.Remove("Settings")
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then
            Me.Close()
        Else
            Form1.fadeout_animation(Me, composedwindow)
        End If
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

    Private Sub Settings_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible = True Then
            Form1.Setfont(Me, Label4)
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Show()
            Label4.BackColor = Desktop.labelBg.BackColor
            Label4.ForeColor = Desktop.labelFg.BackColor
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.BackColor = Desktop.appBg.BackColor
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.translucency(Me, composedwindow, True)
            composedwindow.TopMost = True
            composedwindow.BringToFront()
            Me.BringToFront()
            Label5.BackColor = Me.BackColor
            ToolStrip1.BackColor = Me.BackColor
            Me.ForeColor = Desktop.appFg.BackColor
            ToolStrip1.ForeColor = Me.ForeColor
        End If
    End Sub

    Private Sub TerminateTimer_Tick(sender As Object, e As EventArgs) Handles TerminateTimer.Tick
        If LogoffWindow.Visible = True Then
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Close()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.fadeout_animation(Me, composedwindow)
        ElseIf Lock.Visible = True Then
            Me.Hide()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Hide()
        ElseIf Desktop.KillSignal.Text = "Settings" Then
            'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Close()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.fadeout_animation(Me, composedwindow)
        ElseIf Desktop.restorewindow.Text = "Settings" Then
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

    Private Sub ChangePicture_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ChangePicture.LinkClicked
        Me.Hide()
        composedwindow.Hide()
        AccountImage.Show()
    End Sub

    Private Sub AddUser_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AddUser.LinkClicked
        Desktop.NotepadKill.Text = "kill"
        Desktop.WebBrowserKill.Text = "kill"
        Desktop.paintkill.Text = "kill"
        Desktop.calckill.Text = "kill"
        Desktop.commandkill.Text = "kill"
        Desktop.scoreboardkill.Text = "kill"
        Desktop.PictureKill.Text = "kill"
        Desktop.MediaPlayerKill.Text = "kill"
        'shows account setup
        Setup.Show()
    End Sub

    Private Sub DeleteUser_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles DeleteUser.LinkClicked
        Dim appdata As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData
        File.Delete(appdata & "\Windowed\" & Desktop.user & ".txt")
        If Desktop.usertype = "Power" Then
            File.Delete(appdata & "\Windowed\" & Desktop.user & "_power.txt")
        ElseIf Desktop.usertype = "Admin" Then
            File.Delete(appdata & "\Windowed\" & Desktop.user & "_admin.txt")
        ElseIf Desktop.usertype = "Standard" Then
            File.Delete(appdata & "\Windowed\" & Desktop.user & "_standard.txt")
        ElseIf Desktop.usertype = "Limited" Then
            File.Delete(appdata & "\Windowed\" & Desktop.user & "_limited.txt")
        ElseIf Desktop.usertype = "Guest" Then
            File.Delete(appdata & "\Windowed\" & Desktop.user & "_guest.txt")
        End If
        If Directory.Exists(appdata & "\Windowed\" & Desktop.user) Then Directory.Delete(appdata & "\Windowed\" & Desktop.user, True)
        MessageDialog.messageicon = "Info"
        MessageDialog.messagetype = "OKOnly"
        MessageDialog.messagetitle = "Account deletion"
        MessageDialog.messagetext = "Account has been successfully deleted. Logging out now..."
        MessageDialog.ShowDialog()
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Close()
        Desktop.Close()
        LogoffWindow.Show()
        Login.Show()
        Me.Close()
    End Sub

    Private Sub AddPasswd_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AddPasswd.LinkClicked
        InputBoxDialog.txt = "Enter your new password"
        InputBoxDialog.wintitle = "New password"
        InputBoxDialog.password = True
        InputBoxDialog.ShowDialog()
        Dim p As String
        p = InputBoxDialog.finalinput
        Desktop.passwd = Login.Encrypt(p, p)
    End Sub

    Private Sub ChangeName_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ChangeName.LinkClicked
        InputBoxDialog.txt = "Enter new username"
        InputBoxDialog.wintitle = "Change username"
        InputBoxDialog.password = False
        InputBoxDialog.ShowDialog()
        Desktop.user = InputBoxDialog.finalinput
    End Sub

    Private Sub CustomizationLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CustomizationLink.LinkClicked
        CustomizationCenter.Show()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Desktop.ShowhideIconsToolStripMenuItem.PerformClick()
        If Desktop.PictureBox9.Visible = True Then
            LinkLabel3.Text = "Hide desktop icons"
        ElseIf Desktop.PictureBox9.Visible = False Then
            LinkLabel3.Text = "Show desktop icons"
        End If
    End Sub

    Private Sub SystemSettings_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SystemSettings.LinkClicked
        GlobalSysConfig.Show()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Desktop.ChangeWallpaperToolStripMenuItem.PerformClick()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Recovery.Button5.PerformClick()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        'shows the font dialog, if user click OK process the request
        If FontDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'sets the font
            voide.TextBox1.Font = FontDialog1.Font
            'converts font family and em size to semicolon separated string
            Dim fontstring As String = voide.TextBox1.Font.FontFamily.ToString() & ";" & voide.TextBox1.Font.SizeInPoints.ToString & ";"
            'checks if development.txt exists, if it does, deletes it
            If File.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\development.txt") Then File.Delete(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\development.txt")
            'writes the font info to development.txt
            File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\development.txt", fontstring, System.Text.Encoding.ASCII)
        End If
    End Sub

    Private Sub FactoryReset_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles FactoryReset.LinkClicked
        InputBoxDialog.password = True
        InputBoxDialog.TextBox1.Text = ""
        InputBoxDialog.txt = "Enter password:"
        If InputBoxDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim unencrypt As String = InputBoxDialog.finalinput
            Dim encrypt As String = Login.Encrypt(unencrypt, unencrypt)
            If encrypt = Desktop.passwd Then
                MessageDialog.messageicon = "Warning"
                MessageDialog.messagetitle = "Factory reset warning"
                MessageDialog.messagetext = "You have requested a factory reset. This will delete all users, apps and settings. Are you sure you want to continue?"
                MessageDialog.messagetype = "YesNo"
                If MessageDialog.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                    Recovery.Button2.PerformClick()
                Else
                    MessageDialog.messageicon = "Info"
                    MessageDialog.messagetitle = "Factory reset cancelled"
                    MessageDialog.messagetext = "No changes have been made"
                    MessageDialog.messagetype = "OKOnly"
                    MessageDialog.ShowDialog()
                End If
            Else
                MessageDialog.messageicon = "Critical"
                MessageDialog.messagetitle = "Authentication failed"
                MessageDialog.messagetext = "Invalid password"
                MessageDialog.messagetype = "OKOnly"
                MessageDialog.ShowDialog()
            End If
        End If
    End Sub

    Private Sub ResetSettings_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ResetSettings.LinkClicked
        InputBoxDialog.password = True
        InputBoxDialog.TextBox1.Text = ""
        InputBoxDialog.txt = "Enter password:"
        If InputBoxDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim unencrypt As String = InputBoxDialog.finalinput
            Dim encrypt As String = Login.Encrypt(unencrypt, unencrypt)
            If encrypt = Desktop.passwd Then
                MessageDialog.messagetype = "YesNo"
                MessageDialog.messagetext = "Are you sure you want to delete all settings? This will delete all user accounts and their settings"
                MessageDialog.messagetitle = "Delete system settings"
                MessageDialog.messageicon = "Warning"
                If MessageDialog.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                    GoTo justdoit
                Else
                    MessageDialog.messagetype = "OKOnly"
                    MessageDialog.messagetext = "No action will be performed"
                    MessageDialog.messagetitle = "User pressed no"
                    MessageDialog.messageicon = "Info"
                    MessageDialog.ShowDialog()
                    Exit Sub
                End If
justdoit:
                Desktop.OpenFileDialog1.FileName = "Factory_reset_request"
                Desktop.Save()
                If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\config.rtf") Then My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\config.rtf")
                If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\locations.txt") Then My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\locations.txt")
                Try
                    If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed") Then My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed", FileIO.DeleteDirectoryOption.DeleteAllContents)
                    MessageDialog.messagetype = "OKOnly"
                    MessageDialog.messagetext = "Settings have now been reset. System will now restart"
                    MessageDialog.messagetitle = "Delete system settings"
                    MessageDialog.messageicon = "Info"
                    MessageDialog.ShowDialog()
                    Process.Start("Windowed OS.exe")
                    If Notepad.Visible = True Then Notepad.Hide()
                    If MediaPlay.Visible = True Then MediaPlay.Hide()
                    If tskmgr.Visible = True Then tskmgr.Hide()
                    If WebBrowser.Visible = True Then WebBrowser.Hide()
                    If PictureViewer.Visible = True Then PictureViewer.Hide()
                    ShutDown.Show()
                    Close()
                Catch ex As Exception
                    ESOD.Label5.Text = ex.Message
                    ESOD.ShowDialog()
                End Try
            Else
                MessageDialog.messageicon = "Critical"
                MessageDialog.messagetitle = "Authentication failed"
                MessageDialog.messagetext = "Invalid password"
                MessageDialog.messagetype = "OKOnly"
                MessageDialog.ShowDialog()
            End If
        End If
    End Sub

    Private Sub AutologinLabel_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles AutologinLabel.LinkClicked
        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\login.txt") Then
            MessageDialog.messagetype = "YesNo"
            MessageDialog.messagetitle = "Remove autologin information"
            MessageDialog.messagetext = "Are you sure that you would like to delete autologin information?"
            MessageDialog.messageicon = "Warning"
            If MessageDialog.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\login.txt")
                MessageDialog.messagetype = "OKOnly"
                MessageDialog.messagetitle = "Remove autologin information"
                MessageDialog.messagetext = "Autologin information deleted successfully"
                MessageDialog.messageicon = "Info"
                MessageDialog.ShowDialog()
                Exit Sub
            Else
                MessageDialog.messagetype = "OKOnly"
                MessageDialog.messagetitle = "Windowed OS"
                MessageDialog.messagetext = "No changes have been made"
                MessageDialog.messageicon = "Info"
                MessageDialog.ShowDialog()
                Exit Sub
            End If
        Else
            MessageDialog.messagetype = "OKOnly"
            MessageDialog.messagetitle = "Remove autologin information"
            MessageDialog.messagetext = "Autologin information not found. Click 'login automatically' in the login screen to make some"
            MessageDialog.messageicon = "Critical"
            MessageDialog.ShowDialog()
            Exit Sub
        End If
    End Sub

    Private Sub DeleteAppSettingsUser_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles DeleteAppSettingsUser.LinkClicked
        MessageDialog.messagetype = "YesNo"
        MessageDialog.messagetitle = "Delete app settings"
        MessageDialog.messagetext = "This will delete any application specific settings for current user. To avoid setting recreation, close any apps before doing this. Are you sure you want to continue?"
        MessageDialog.messageicon = "Warning"
        If MessageDialog.ShowDialog() = Windows.Forms.DialogResult.Yes Then
            Dim di As New DirectoryInfo(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed")
            Dim dirs As String = ""
            For Each fi As FileInfo In di.EnumerateFiles(Desktop.user & "_*")
                File.Delete(fi.FullName)
            Next
            File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & Desktop.user & "_" & Desktop.usertype & ".txt", "This is a replacement file for user type after app settings have been reset")
            MessageDialog.messagetype = "OKOnly"
            MessageDialog.messagetitle = "Operation successful"
            MessageDialog.messagetext = "Application specific data for this user has been successfully erased"
            MessageDialog.messageicon = "Info"
            MessageDialog.ShowDialog()
        Else
            MessageDialog.messagetype = "OKOnly"
            MessageDialog.messagetitle = "Operation cancelled"
            MessageDialog.messagetext = "No changes have been made"
            MessageDialog.messageicon = "Info"
            MessageDialog.ShowDialog()
        End If
    End Sub

    Private Sub ResetAppSettingsAll_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ResetAppSettingsAll.LinkClicked
        InputBoxDialog.password = True
        InputBoxDialog.TextBox1.Text = ""
        InputBoxDialog.txt = "Enter password:"
        If Desktop.passwd = "JlnAU+w22tzhFyQmEMDK/g==" Then
            InputBoxDialog.finalinput = Desktop.passwd
            GoTo skip_passcode
        End If
        If InputBoxDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
skip_passcode:
            Dim unencrypt As String = InputBoxDialog.finalinput
            Dim encrypt As String = Login.Encrypt(unencrypt, unencrypt)
            If encrypt = Desktop.passwd Then
                MessageDialog.messagetype = "YesNo"
                MessageDialog.messagetitle = "Delete app settings"
                MessageDialog.messagetext = "This will delete any application specific settings for ALL users. To avoid setting recreation, close any apps before doing this. Are you sure you want to continue?"
                MessageDialog.messageicon = "Warning"
                If MessageDialog.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                    Dim di As New DirectoryInfo(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed")
                    Dim dirs As String = ""
                    For Each fi As FileInfo In di.EnumerateFiles("*_*")
                        If di.Name.EndsWith("standard.txt") Then Continue For
                        If di.Name.EndsWith("admin.txt") Then Continue For
                        If di.Name.EndsWith("limited.txt") Then Continue For
                        If di.Name.EndsWith("guest.txt") Then Continue For
                        If di.Name.EndsWith("power.txt") Then Continue For
                        File.Delete(fi.FullName)
                    Next
                    MessageDialog.messagetype = "OKOnly"
                    MessageDialog.messagetitle = "Operation successful"
                    MessageDialog.messagetext = "Application specific data for all users have been successfully erased"
                    MessageDialog.messageicon = "Info"
                    MessageDialog.ShowDialog()
                Else
                    MessageDialog.messagetype = "OKOnly"
                    MessageDialog.messagetitle = "Operation cancelled"
                    MessageDialog.messagetext = "No changes have been made"
                    MessageDialog.messageicon = "Info"
                    MessageDialog.ShowDialog()
                End If
            Else
                MessageDialog.messagetype = "OKOnly"
                MessageDialog.messagetitle = "Operation failed"
                MessageDialog.messagetext = "Authentication failure. Make sure you entered a correct password."
                MessageDialog.messageicon = "Critical"
                MessageDialog.ShowDialog()
            End If
        Else
            MessageDialog.messagetype = "OKOnly"
            MessageDialog.messagetitle = "Operation cancelled"
            MessageDialog.messagetext = "No changes have been made"
            MessageDialog.messageicon = "Info"
            MessageDialog.ShowDialog()
        End If
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        UpdateSettings.Show()
    End Sub
End Class