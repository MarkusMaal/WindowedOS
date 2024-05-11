Imports System.IO
Public Class ShutDown
    'restart indicates wheter or not this form opens Windowed OS again
    Public restart As Boolean
    Dim I As Integer = 0
    Private Sub ShutDown_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Try
            If restart Then GoTo skipyo
            restart = False
skipyo:
            'old way of shutting down all applications
            Desktop.alldown = True
            'saves icon locations (old method)
            Dim filecontentx As String
            Dim filecontenty As String
            Dim ailecontentx As String
            Dim ailecontenty As String
            Dim bilecontentx As String
            Dim bilecontenty As String
            Dim cilecontentx As String
            Dim cilecontenty As String
            filecontentx = Desktop.PictureBox2.Location.X.ToString()
            filecontenty = Desktop.PictureBox2.Location.Y.ToString()
            ailecontentx = Desktop.PictureBox3.Location.X.ToString()
            ailecontenty = Desktop.PictureBox3.Location.Y.ToString()
            bilecontentx = Desktop.PictureBox4.Location.X.ToString()
            bilecontenty = Desktop.PictureBox4.Location.Y.ToString()
            cilecontentx = Desktop.PictureBox5.Location.X.ToString()
            cilecontenty = Desktop.PictureBox5.Location.Y.ToString()
            File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\locations.txt", filecontentx & ";" & filecontenty & ";" & ailecontentx & ";" & ailecontenty & ";" & bilecontentx & ";" & bilecontenty & ";" & cilecontentx & ";" & cilecontenty & ";")
            If File.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\config.rtf") Then Desktop.RichTextBox1.LoadFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\config.rtf", RichTextBoxStreamType.RichText)
            'plays shutdown sound
            If Form1.es = False Then WaitToCloseTimer.Interval = 1
            WaitToCloseTimer.Enabled = True
            Exit Sub
            If Not restart Then
                If Form1.es = True Then
                    My.Computer.Audio.Play(My.Resources.shutdown9, AudioPlayMode.Background)
                    Exit Sub
                End If
            End If
            'closes everything
            black.Close()
            If ESOD.Visible = True Then ESOD.Close()
            'starts Windowed OS again from current directory
            If restart Then Process.Start("Windowed OS.exe")
            Form1.Close()
            Desktop.Close()
            Close()
        Catch ex As Exception
            'old trycatch
            If File.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\config.sys") Then
                If Not Directory.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed") Then Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed")
                File.Delete(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\config.sys")
                Notepad.RichTextBox1.Text = Desktop.OpenFileDialog1.FileName
                Notepad.RichTextBox1.SaveFile(Desktop.SaveFileDialog1.FileName, RichTextBoxStreamType.RichText)
retrry:
                Notepad.RichTextBox1.Text = Desktop.OpenFileDialog1.FileName
                If Notepad.RichTextBox1.Text = "" Then GoTo retrry
                Notepad.RichTextBox1.SaveFile(Desktop.SaveFileDialog1.FileName, RichTextBoxStreamType.RichText)
                Desktop.RichTextBox1.LoadFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\config.rtf", RichTextBoxStreamType.RichText)
            End If
            Close()
        End Try
    End Sub

    Private Sub WaitToCloseTimer_Tick(sender As System.Object, e As System.EventArgs) Handles WaitToCloseTimer.Tick
        If I = 10 Then
            LogoffWindow.Opacity = 1.0
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then LogoffWindow.composedwindow.Opacity = 0.9
            If Form1.es = True Then My.Computer.Audio.Play(My.Resources.shutdown11, AudioPlayMode.Background)
            If DateTime.Today.Hour = 3 Then
                If Form1.es = True Then My.Computer.Audio.Play(My.Resources.shutdown10, AudioPlayMode.Background)
            End If
        End If
        If I = 65 Then
            WaitToCloseTimer.Enabled = False
            'closes everything
            black.Close()
            If ESOD.Visible = True Then ESOD.Close()
            'starts Windowed OS again from current directory
            If Login.Visible = True Then Login.Close()
            If restart Then Process.Start("Windowed OS.exe")
            Form1.Close()
            Desktop.Close()
            Close()
        Else
            I += 1
        End If
    End Sub
End Class