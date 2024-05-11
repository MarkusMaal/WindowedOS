Public Class New_name_password
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
        Close()
    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Left
        mousey = Cursor.Position.Y - Top
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
        If drag Then
            Top = Cursor.Position.Y - mousey
            Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp
        drag = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Notepad.RichTextBox1.Text = TextBox1.Text
        Notepad.RichTextBox1.SaveFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\login_2.rtf", RichTextBoxStreamType.RichText)
        Notepad.RichTextBox1.Text = TextBox2.Text
        Notepad.RichTextBox1.SaveFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\login_3.rtf", RichTextBoxStreamType.RichText)
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
        Close()
    End Sub

    Private Sub New_name_password_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Label1.BackColor = Desktop.labelBg.BackColor
    End Sub

    Private Sub New_name_password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Notepad.RichTextBox1.Text = "True"
    End Sub

    Private Sub New_name_password_Deactivate(sender As System.Object, e As System.EventArgs) Handles MyBase.Deactivate
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
        Label1.BackColor = col
    End Sub
End Class