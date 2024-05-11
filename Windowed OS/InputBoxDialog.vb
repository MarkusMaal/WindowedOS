Public Class InputBoxDialog
    Public finalinput As String
    Public password As Boolean = False
    Public wintitle As String
    Public txt As String
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim composedwindow As Form = New Form()
    Private Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr
    Dim CurLocation, AppLocation As New Point(0, 0)
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        finalinput = TextBox1.Text
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.fadeout_animation(Me, composedwindow)
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Close()
    End Sub

    Private Sub InputBoxDialog_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Label4.BackColor = Desktop.labelBg.BackColor
        Label4.ForeColor = Desktop.labelFg.BackColor
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then
            Me.BackColor = Desktop.appBg.BackColor
            Me.TransparencyKey = Nothing
        ElseIf Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            Form1.translucency(Me, composedwindow, True)
        End If
        Me.ForeColor = Desktop.appFg.BackColor
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Opacity = 1.0
        If password Then
            TextBox1.PasswordChar = LoginPrompt.PassField.PasswordChar
        ElseIf Not password Then
            TextBox1.PasswordChar = ""
        End If
        Label1.Text = txt
        Label4.Text = wintitle
    End Sub

    Private Sub TextBox1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
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

End Class