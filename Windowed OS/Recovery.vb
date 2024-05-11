Imports System.IO
Public Class Recovery

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Directory.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed") Then
            Button7.Enabled = False
            ShutDown.restart = False
            ShutDown.Show()
        Else
            My.Computer.Audio.Play(My.Resources.shutdown9, AudioPlayMode.WaitToComplete)
            Form1.Close()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Directory.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed") Then
            Button6.Enabled = False
            ShutDown.restart = True
            ShutDown.Show()
            Exit Sub
        Else
            My.Computer.Audio.Play(My.Resources.shutdown9, AudioPlayMode.WaitToComplete)
            Process.Start("Windowed OS.exe")
            Form1.Close()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button5.Enabled = False
        If Directory.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Programs") Then
            MessageDialog.messageicon = "Info"
            MessageDialog.messagetext = "Done"
            MessageDialog.messagetitle = "Recovery mode"
            MessageDialog.messagetype = "OKOnly"
            Directory.Delete(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Programs", True)
            MessageDialog.ShowDialog()
            Exit Sub
        Else
            MessageDialog.messageicon = "Critical"
            MessageDialog.messagetext = "Directory does not exist"
            MessageDialog.messagetitle = "Recovery mode"
            MessageDialog.messagetype = "OKOnly"
            MessageDialog.ShowDialog()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button4.Enabled = False
        If Directory.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\login.txt") Then
            File.Delete(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\login.txt")
            MessageDialog.messageicon = "Info"
            MessageDialog.messagetext = "Done"
            MessageDialog.messagetitle = "Recovery mode"
            MessageDialog.messagetype = "OKOnly"
            MessageDialog.ShowDialog()
        Else
            MessageDialog.messageicon = "Critical"
            MessageDialog.messagetext = "File does not exist"
            MessageDialog.messagetitle = "Recovery mode"
            MessageDialog.messagetype = "OKOnly"
            MessageDialog.ShowDialog()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Enabled = False
        If Directory.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Programs") Then Directory.Delete(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Programs", True)
        If Directory.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed") Then My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed", FileIO.DeleteDirectoryOption.DeleteAllContents)
        MessageDialog.messageicon = "Info"
        MessageDialog.messagetext = "Done"
        MessageDialog.messagetitle = "Recovery mode"
        MessageDialog.messagetype = "OKOnly"
        MessageDialog.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        StartupWindow.beepboop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Enabled = False
        MessageDialog.messageicon = "Help"
        MessageDialog.messagetext = "Would you like to enable developer mode? This allows you to install and develop custom applications."
        MessageDialog.messagetitle = "Recovery mode"
        MessageDialog.messagetype = "YesNo"
        If MessageDialog.ShowDialog() = Windows.Forms.DialogResult.Yes Then
            Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Programs")
            File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Programs\dummy.DAT", "Dummy file", System.Text.Encoding.ASCII)
            MessageDialog.messageicon = "Info"
            MessageDialog.messagetext = "Done"
            MessageDialog.messagetitle = "Recovery mode"
            MessageDialog.messagetype = "OKOnly"
            MessageDialog.ShowDialog()
        End If
    End Sub

    Private Sub Recovery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.appBg.BackColor = Color.WhiteSmoke
        Form1.appFg.BackColor = Color.Black
        Form1.labelBg.BackColor = Color.DimGray
        Form1.labelFg.ForeColor = Color.White
        If Directory.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Programs") Then
            Button5.Enabled = True
            Button3.Enabled = False
        End If
    End Sub

    Private Sub Recovery_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = False
        Button6.Enabled = True
        Button7.Enabled = True
        If Directory.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Programs") Then
            Button5.Enabled = True
            Button3.Enabled = False
        End If
    End Sub
End Class