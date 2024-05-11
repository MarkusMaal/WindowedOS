Public Class ESOD
    Dim dam As Boolean
    Private Sub ESOD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Label1.ForeColor = Me.ForeColor
            Label2.ForeColor = Me.ForeColor
            Label3.ForeColor = Me.ForeColor
            Label4.ForeColor = Me.ForeColor
            Label5.ForeColor = Me.ForeColor
            Label6.ForeColor = Me.ForeColor
            Label7.ForeColor = Me.ForeColor
            If Me.BackColor = Color.Green Then
                Label3.Text = "Try checking for mistakes in your code. If problems" & vbNewLine & "continue, contact Windowed OS development team."
                Label6.Visible = False
            ElseIf Me.BackColor = Color.DodgerBlue Then
                Label3.Text = "Try rerunning the program. If problems continue," & vbNewLine & "please contact the application developer." & vbNewLine & "If problems still continue, contact Windowed OS Voide team."
                Label6.Visible = False
            End If
            If Form1.Visible = True Then Button1.Visible = False
            If Form1.Visible = True Then Button2.Text = "Close program (ENTER)"
            If Form1.es = True Then My.Computer.Audio.Play(My.Resources.errror9, AudioPlayMode.WaitToComplete)
            If Form1.Visible = True Then
                If CheckBox1.Checked = False Then
                    CheckBox1.Checked = True
                    Me.Close()
                End If
            End If
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
        Me.BackColor = Color.Gold
        Me.ForeColor = Color.Black
        Label7.Text = "ESOD: Critical ERROR"
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Desktop.RichTextBox1.Text = "No sound"
            ShutDown.Show()
            Close()
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