Public Class Solitaire
    Dim cardtype As String = "clubs"
    Dim cardvalue As Integer = 1
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim CurLocation, AppLocation As New Point(0, 0)
    Dim rap As Boolean = False
    Dim homepage As String = "http://www.google.com"
    Dim composedwindow As Form = New Form()

    'CardStack - a deck of cards on top left
    'StackIndex - index of that deck
    Dim CardStack As Integer()
    Dim CardStackTypes As String()
    Dim StackIndex As Integer = 0

    Private Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr
    Private Sub Sync()
        CurLocation = Cursor.Position
        AppLocation = Size
    End Sub

    Private Sub Label2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label2.MouseDown
        ResizeTimer.Start()
        Sync()
    End Sub

    Private Sub Label2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label2.MouseUp
        ResizeTimer.Stop()
        Sync()
        composedwindow.BringToFront()
        Me.BringToFront()
    End Sub

    Private Sub ResizeTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ResizeTimer.Tick
        Size = AppLocation - CurLocation + Cursor.Position
        composedwindow.Size = Size
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
            composedwindow.Top = Top
            composedwindow.Left = Left
        End If
    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp
        drag = False
        composedwindow.BringToFront()
        Me.BringToFront()
    End Sub

    Sub NewGame()
        Dim i As Integer = 0
        While i < 23
            cardvalue = New Random().Next(1, 13)
            Dim cardtypes As String() = {"clubs", "diamonds", "hearts", "spades"}
            cardtype = cardtypes(New Random().Next(0, 4)).ToString()
            CardStack.SetValue(cardvalue, i)
            CardStackTypes.SetValue(cardtype, i)
            i += 1
        End While
    End Sub

    Private Sub Solitaire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CardStack = New Integer(23) {}
        CardStackTypes = New String(23) {}
        NewGame()
        'If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Opacity = 1.0
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.Hideanimation(Me, composedwindow)
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Hide()
    End Sub

    Private Sub Solitaire_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible = True Then
            Form1.Setfont(Me, Label1, Label3)
            Label1.BackColor = Desktop.labelBg.BackColor
            Label1.ForeColor = Desktop.labelFg.BackColor
            Label3.BackColor = Desktop.labelBg.BackColor
            Label3.ForeColor = Desktop.labelFg.BackColor
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then
                Me.BackColor = Desktop.appBg.BackColor
            Else
                Form1.Translucency(Me, composedwindow, True)
            End If
            Me.ForeColor = Desktop.appFg.BackColor
            Label2.BackColor = Me.BackColor
        End If
    End Sub

    Private Sub TerminateTimer_Tick(sender As Object, e As EventArgs) Handles TerminateTimer.Tick
        If Desktop.WebBrowserKill.Text = "kill" Then
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Close()
            Me.Close()
        ElseIf LogoffWindow.Visible = True Then
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Close()
            Me.Close()
        ElseIf Lock.Visible = True Then
            Me.Hide()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Hide()
        ElseIf Desktop.restorewindow.Text = "Solitaire" Then
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
        If Form1.FadeInTimer.Enabled = True Then Exit Sub
        If Not Me.Opacity = 1.0 Or Me.Opacity = 0.0 Then
            Form1.Fadeout_animation(Me, composedwindow)
        End If
        If Me.Visible = True Then
            If CustomizationCenter.ApplyTheme.Enabled = True Then
                composedwindow.Hide()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub Solitaire_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Label1.BackColor = Desktop.labelBg.BackColor
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

    Private Sub Solitaire_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
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

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        tskmgr.ListBox1.Items.Remove("Solitaire")
        Desktop.KillSignal.Text = "Solitaire"
        Desktop.killtimer.Enabled = True
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
        ExitToolStripMenuItem.PerformClick()
    End Sub

    Private Sub StackPile_Click(sender As Object, e As EventArgs) Handles StackPile.Click
        If Not StackIndex = 23 Then
            StackIndex += 1
            PlaceHolderStack.Image = decodecard(CardStack.GetValue(StackIndex), CardStackTypes.GetValue(StackIndex))
        Else
            PlaceHolderStack.Image = decodecard(CardStack.GetValue(StackIndex), CardStackTypes.GetValue(StackIndex))
            StackPile.Image = Nothing
            StackIndex += 1
            StackPile.BackColor = Color.Silver
        End If

    End Sub

    Function decodecard(ByVal i As Integer, ByVal type As String)
        Dim newresource As Bitmap = My.Resources.texture
        If type = "clubs" Then
            If i = 1 Then newresource = My.Resources.ace_of_clubs
            If i = 2 Then newresource = My.Resources._2_of_clubs
            If i = 3 Then newresource = My.Resources._3_of_clubs
            If i = 4 Then newresource = My.Resources._4_of_clubs
            If i = 5 Then newresource = My.Resources._5_of_clubs
            If i = 6 Then newresource = My.Resources._6_of_clubs
            If i = 7 Then newresource = My.Resources._7_of_clubs
            If i = 8 Then newresource = My.Resources._8_of_clubs
            If i = 9 Then newresource = My.Resources._9_of_clubs
            If i = 10 Then newresource = My.Resources._10_of_clubs
            If i = 11 Then newresource = My.Resources.jack_of_clubs2
            If i = 12 Then newresource = My.Resources.queen_of_clubs2
            If i = 13 Then newresource = My.Resources.king_of_clubs2
        ElseIf type = "diamonds" Then
            If i = 1 Then newresource = My.Resources.ace_of_diamonds
            If i = 2 Then newresource = My.Resources._2_of_diamonds
            If i = 3 Then newresource = My.Resources._3_of_diamonds
            If i = 4 Then newresource = My.Resources._4_of_diamonds
            If i = 5 Then newresource = My.Resources._5_of_diamonds
            If i = 6 Then newresource = My.Resources._6_of_diamonds
            If i = 7 Then newresource = My.Resources._7_of_diamonds
            If i = 8 Then newresource = My.Resources._8_of_diamonds
            If i = 9 Then newresource = My.Resources._9_of_diamonds
            If i = 10 Then newresource = My.Resources._10_of_diamonds
            If i = 11 Then newresource = My.Resources.jack_of_diamonds2
            If i = 12 Then newresource = My.Resources.queen_of_diamonds2
            If i = 13 Then newresource = My.Resources.king_of_diamonds2
        ElseIf type = "hearts" Then
            If i = 1 Then newresource = My.Resources.ace_of_hearts
            If i = 2 Then newresource = My.Resources._2_of_hearts
            If i = 3 Then newresource = My.Resources._3_of_hearts
            If i = 4 Then newresource = My.Resources._4_of_hearts
            If i = 5 Then newresource = My.Resources._5_of_hearts
            If i = 6 Then newresource = My.Resources._6_of_hearts
            If i = 7 Then newresource = My.Resources._7_of_hearts
            If i = 8 Then newresource = My.Resources._8_of_hearts
            If i = 9 Then newresource = My.Resources._9_of_hearts
            If i = 10 Then newresource = My.Resources._10_of_hearts
            If i = 11 Then newresource = My.Resources.jack_of_hearts2
            If i = 12 Then newresource = My.Resources.queen_of_hearts2
            If i = 13 Then newresource = My.Resources.king_of_hearts2
        ElseIf type = "spades" Then
            If i = 1 Then newresource = My.Resources.ace_of_spades
            If i = 2 Then newresource = My.Resources._2_of_spades
            If i = 3 Then newresource = My.Resources._3_of_spades
            If i = 4 Then newresource = My.Resources._4_of_spades
            If i = 5 Then newresource = My.Resources._5_of_spades
            If i = 6 Then newresource = My.Resources._6_of_spades
            If i = 7 Then newresource = My.Resources._7_of_spades
            If i = 8 Then newresource = My.Resources._8_of_spades
            If i = 9 Then newresource = My.Resources._9_of_spades
            If i = 10 Then newresource = My.Resources._10_of_spades
            If i = 11 Then newresource = My.Resources.jack_of_spades2
            If i = 12 Then newresource = My.Resources.queen_of_spades2
            If i = 13 Then newresource = My.Resources.king_of_spades2
        End If
        Return newresource
    End Function
End Class