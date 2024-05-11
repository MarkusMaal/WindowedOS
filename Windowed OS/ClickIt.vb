Public Class ClickIt
    Dim mousex As Integer
    Dim mousey As Integer
    Dim drag As Boolean
    Dim score As Integer = 0
    Dim composedwindow As Form = New Form()
    Dim rap As Boolean = False
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

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        ViewDesktopToolStripMenuItem.PerformClick()
    End Sub

    Private Sub GameplayRulesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GameplayRulesToolStripMenuItem.Click
        MessageDialog.messageicon = "Help"
        MessageDialog.messagetitle = "Click it gameplay"
        MessageDialog.messagetext = "Your goal is to click the button. Altough it is actually impossible. Get as high score as possible!"
        'MessageDialog.ff = Me
        'MessageDialog.sf = composedwindow
        MessageDialog.ShowDialog()
    End Sub

    Sub sufflepos()
        Dim rndx As Random = New Random
        Dim rndy As Random = New Random
        Dim btn1x As Integer = rndx.Next(505)
        Dim btn1y As Integer = rndy.Next(228)
        Dim btn2x As Integer = rndx.Next(505)
        Dim btn2y As Integer = rndy.Next(228)
        Dim btn3x As Integer = rndx.Next(505)
        Dim btn3y As Integer = rndy.Next(228)
        Dim btn4x As Integer = rndx.Next(505)
        Dim btn4y As Integer = rndy.Next(228)
        Dim btn5x As Integer = rndx.Next(505)
        Dim btn5y As Integer = rndy.Next(228)
        Dim btn6x As Integer = rndx.Next(505)
        Dim btn6y As Integer = rndy.Next(228)
        Button1.Location = New Point(btn1x, btn1y + 43)
        Button2.Location = New Point(btn2x, btn2y + 43)
        Button3.Location = New Point(btn3x, btn3y + 43)
        Button4.Location = New Point(btn4x, btn4y + 43)
        Button5.Location = New Point(btn5x, btn5y + 43)
        Button6.Location = New Point(btn6x, btn6y + 43)
    End Sub

    Private Sub Button6_MouseMove_1(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Button6.MouseMove, Button5.MouseMove, Button4.MouseMove, Button3.MouseMove, Button2.MouseMove, Button1.MouseMove
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        sufflepos()
        Dim rnd As Random = New Random
        Dim i As Integer = rnd.Next(6)
        If i <= 0 Then Button1.Visible = True
        If i = 1 Then Button1.Visible = True
        If i = 2 Then Button2.Visible = True
        If i = 3 Then Button3.Visible = True
        If i = 4 Then Button4.Visible = True
        If i = 5 Then Button5.Visible = True
        If i = 6 Then Button6.Visible = True
        If i >= 6 Then Button6.Visible = True
        score = score + 1
        Score0ToolStripMenuItem.Text = "Score: " & score.ToString()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.fadeout_animation(Me, composedwindow)
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Close()
    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RestartToolStripMenuItem.Click
        Score0ToolStripMenuItem.Text = "Score: 0"
        score = 0
        Button1.Location = New Point(310, 193)
        Button1.Visible = True
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
    End Sub

    Private Sub ClickIt_VisibleChanged(sender As System.Object, e As System.EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible = True Then
            Form1.Setfont(Me, Label4, Label3)
            Label3.BackColor = Desktop.labelBg.BackColor
            Label3.ForeColor = Desktop.labelFg.BackColor
            Label4.BackColor = Desktop.labelBg.BackColor
            Label4.ForeColor = Desktop.labelFg.BackColor
            Button1.ForeColor = Desktop.appFg.BackColor
            Button2.ForeColor = Desktop.appFg.BackColor
            Button3.ForeColor = Desktop.appFg.BackColor
            Button4.ForeColor = Desktop.appFg.BackColor
            Button5.ForeColor = Desktop.appFg.BackColor
            Button6.ForeColor = Desktop.appFg.BackColor
            Button1.BackColor = Desktop.appBg.BackColor
            Button2.BackColor = Desktop.appBg.BackColor
            Button3.BackColor = Desktop.appBg.BackColor
            Button4.BackColor = Desktop.appBg.BackColor
            Button5.BackColor = Desktop.appBg.BackColor
            Button6.BackColor = Desktop.appBg.BackColor
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.BackColor = Desktop.appBg.BackColor
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.translucency(Me, composedwindow, True)
            Me.ForeColor = Desktop.appFg.BackColor
        End If
    End Sub

    Private Sub Button6_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Button6.MouseClick, Button5.MouseClick, Button4.MouseClick, Button3.MouseClick, Button2.MouseClick, Button1.MouseClick
        MessageDialog.messageicon = "Info"
        MessageDialog.messagetitle = "Click it"
        MessageDialog.messagetext = "You win!"
        'MessageDialog.ff = Me
        'MessageDialog.sf = composedwindow
        MessageDialog.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MessageDialog.messageicon = "Info"
        MessageDialog.messagetext = "Click it 1.0c"
        MessageDialog.messagetitle = "About"
        'MessageDialog.ff = Me
        'MessageDialog.sf = composedwindow
        MessageDialog.ShowDialog()
    End Sub

    Private Sub ViewDesktopToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewDesktopToolStripMenuItem.Click
        Me.Hide()
        composedwindow.Hide()
    End Sub

    Private Sub ClickIt_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        Label4.BackColor = Desktop.labelBg.BackColor
        Label3.BackColor = Desktop.labelBg.BackColor
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

    Private Sub ClickIt_Deactivate(sender As System.Object, e As System.EventArgs) Handles MyBase.Deactivate
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
        Label3.BackColor = col
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            If composedwindow.IsDisposed = False Then
                If Not GetActiveWindow <> composedwindow.Handle Then
                    Me.BringToFront()
                End If
            End If
        End If
        rap = False
    End Sub

    Private Sub ClickIt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Opacity = 1.0
    End Sub

    Private Sub TerminateTimer_Tick(sender As System.Object, e As System.EventArgs) Handles TerminateTimer.Tick
        If LogoffWindow.Visible = True Then
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Close()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.fadeout_animation(Me, composedwindow)
        ElseIf Lock.Visible = True Then
            Me.Hide()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Hide()
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
End Class