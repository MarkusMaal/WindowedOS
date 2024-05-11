Imports System.IO
Public Class Lock
    Dim wakefromsleep As Boolean = False
    Private Sub Lock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Desktop.backupos = Windows.Forms.Cursor.Position
        If Wait.Visible = True Then
            UnlockButton.Visible = True
            TextBox1.Visible = False
            Me.WindowState = FormWindowState.Minimized
            Delay.Enabled = True
            Exit Sub
        End If
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & Desktop.user & ".png") Then
            PictureBox1.BackgroundImage = Image.FromFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & Desktop.user & ".png")
        End If
        Label4.Text = Desktop.user
        TextBox1.BackColor = Desktop.appBg.BackColor
        TextBox1.ForeColor = Desktop.appFg.BackColor
        If Desktop.passwd = "JlnAU+w22tzhFyQmEMDK/g==" Then
            UnlockButton.Visible = True
            TextBox1.Visible = False
            Label2.Text = "No password set. Press unlock to return to the desktop."
        Else
            Me.BackgroundImage = My.Resources.lock
            UnlockButton.Visible = False
            TextBox1.Visible = True
            Cursor.Hide()
        End If
        If Desktop.Sleep.CheckState = CheckState.Checked Then
            Me.Text = "Double click to wake up"
            If Form1.es = True Then My.Computer.Audio.Play(My.Resources.sleep9, AudioPlayMode.Background)
            Label3.BackColor = Desktop.appBg.BackColor
            Label3.ForeColor = Desktop.appFg.BackColor
            Label3.Visible = True
            sleepTimer.Enabled = True
        ElseIf Desktop.Sleep.CheckState = CheckState.Unchecked Then
            If Form1.es = True Then My.Computer.Audio.Play(My.Resources.lock9, AudioPlayMode.Background)
            Me.BackgroundImage = My.Resources.lock
        End If
    End Sub

    Private Sub UnlockButton_Click(sender As Object, e As EventArgs) Handles UnlockButton.Click
        Dim pointn As Point = New Point(My.Computer.Screen.WorkingArea.Width / 2, My.Computer.Screen.WorkingArea.Height / 2)
        Windows.Forms.Cursor.Position = Desktop.backupos
        Desktop.Show()
        If wakefromsleep = False Then
            If Form1.es = True Then My.Computer.Audio.Play(My.Resources.unlock9, AudioPlayMode.Background)
        End If
        Desktop.Sleep.Checked = False
        Desktop.RestoreAllWindowsToolStripMenuItem.PerformClick()
        Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Login.Encrypt(TextBox1.Text, TextBox1.Text) = Desktop.passwd Then
            UnlockButton.Visible = True
            TextBox1.Visible = False
            Windows.Forms.Cursor.Show()
            Dim pointn As Point = New Point(My.Computer.Screen.WorkingArea.Width / 2, My.Computer.Screen.WorkingArea.Height / 2)
            Label2.Text = "Correct password. Press unlock to return to the desktop."
        End If
    End Sub

    Private Sub Lock_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If TextBox1.Visible = True Then
            e.Cancel = True
        Else
            PictureBox1.BackgroundImage.Dispose()
            e.Cancel = False
        End If
    End Sub

    Private Sub sleepTimer_Tick(sender As Object, e As EventArgs) Handles sleepTimer.Tick
        Me.WindowState = FormWindowState.Minimized
        Label3.Text = "Restoring session..."
        If Not Desktop.obj.Visible Then Desktop.obj.Show()
        If Not UnlockButton.Visible Then Label3.Visible = False
        sleepTimer.Enabled = False
        If Form1.es = True Then SleepRecovery.Enabled = True
    End Sub

    Private Sub SleepRecovery_Tick(sender As Object, e As EventArgs) Handles SleepRecovery.Tick
        If Me.WindowState = FormWindowState.Maximized Then
            If Form1.es = True Then My.Computer.Audio.Play(My.Resources.wake_up9, AudioPlayMode.Background)
            Me.Text = "Lock"
            Label3.Text = "Saving session..."
            If Desktop.obj.Visible Then Desktop.obj.Hide()
            SleepRecovery.Enabled = False
            Button1.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            If UnlockButton.Visible Then
                wakefromsleep = True
                UnlockButton.PerformClick()
            Else
                wakefromsleep = False
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label3.Visible = True
        sleepTimer.Enabled = True
        Me.Text = "Double click to wake up"
        My.Computer.Audio.Play(My.Resources.sleep9, AudioPlayMode.Background)
        Button1.Visible = False
        Label1.Visible = False
        Label2.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Visible = False
        Button3.Visible = False
        Button1.Visible = False
        Label2.Visible = False
        Label1.Visible = False
        TextBox1.Visible = False
        UnlockButton.Visible = False
        Me.TopMost = False
        LogoffWindow.LogoffTitle.Text = "Ending your session"
        LogoffWindow.Label1.Text = "Shutting down..."
        LogoffWindow.Show()
        ShutDown.restart = False
        ShutDown.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button2.Visible = False
        Button3.Visible = False
        Button1.Visible = False
        Label2.Visible = False
        Label1.Visible = False
        TextBox1.Visible = False
        UnlockButton.Visible = False
        Me.TopMost = False
        LogoffWindow.LogoffTitle.Text = "Ending your session"
        LogoffWindow.Label1.Text = "Restarting..."
        LogoffWindow.Show()
        ShutDown.restart = True
        ShutDown.Show()
    End Sub

    Private Sub Delay_Tick(sender As Object, e As EventArgs) Handles Delay.Tick
        Desktop.RestoreAllWindowsToolStripMenuItem.PerformClick()
        Delay.Enabled = False
        TopMost = True
        Me.Close()
    End Sub
End Class