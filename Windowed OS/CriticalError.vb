Public Class CriticalError
        Dim dam As Boolean
        Private Sub ESOD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Try
            If Form1.Visible = True Then Button1.Visible = False
            If Form1.Visible = True Then Button2.Text = "Close program (ENTER)"
            My.Computer.Audio.Play(My.Resources.errror10, AudioPlayMode.WaitToComplete)
        Catch ex As Exception
            Label7.Text = Label7.Text & vbNewLine & "Failed to play error sound: please install proper audio drivers"
            GoTo stopanyway
            End Try
stopanyway:
            Desktop.Timer1.Enabled = False
            MediaPlay.TimeTracker.Enabled = False
            Desktop.CPU_Tracker.Enabled = False
            Form1.Timer1.Enabled = False
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Close()
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            Try
                Desktop.RichTextBox1.Text = "No sound"
                ShutDown.Show()
            Catch ex As Exception

                MessageDialog.messagetitle = "Windowed OS"
                MessageDialog.messagetext = ex.Message
                MessageDialog.messageicon = ""
                MessageDialog.ShowDialog()
            End Try
        End Sub

        Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        End Sub

        Private Sub Label1_DoubleClick(sender As Object, e As EventArgs) Handles Label1.DoubleClick
            If Label1.Text = ":'-(" Then
                Label1.Text = ":-)"
            ElseIf Label1.Text = ":-)" Then
                Label1.Text = ">:-O"
            ElseIf Label1.Text = ">:-O" Then
                Label1.Text = ":'-("
            End If
        End Sub
End Class