Public Class Store

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim CurLocation, AppLocation As New Point(0, 0)
    Dim composedwindow As Form = New Form()
    Private Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr

    Private Sub Sync()
        CurLocation = Cursor.Position
        AppLocation = Size
    End Sub

    Private Sub Label2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label12.MouseDown
        ResizeTimer.Start()
        Sync()
    End Sub

    Private Sub Label2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label12.MouseUp
        ResizeTimer.Stop()
        Sync()
        composedwindow.BringToFront()
        Me.BringToFront()
    End Sub

    Private Sub ResizeTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ResizeTimer.Tick
        Size = AppLocation - CurLocation + Cursor.Position
        composedwindow.Size = Me.Size()
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
            composedwindow.Top = Me.Top
            composedwindow.Left = Me.Left
        End If
    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp
        drag = False
        composedwindow.BringToFront()
        Me.BringToFront()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Store_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Opacity = 1.0
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.translucency(Me, composedwindow, True)
    End Sub

    Private Sub Store_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
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
        Label4.BackColor = col
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            If composedwindow.IsDisposed = False Then
                If Not GetActiveWindow <> composedwindow.Handle Then
                    Me.BringToFront()
                End If
            End If
        End If
    End Sub

    Private Sub Store_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Label1.BackColor = Desktop.labelBg.BackColor
        Label4.BackColor = Desktop.labelBg.BackColor
        Me.BackColor = Desktop.appBg.BackColor
        Label12.BackColor = Desktop.appBg.BackColor
        Me.ForeColor = Desktop.appFg.BackColor
        SplitContainer1.BackColor = Me.BackColor
        SplitContainer1.ForeColor = Desktop.appFg.BackColor
        SplitContainer1.BackColor = Desktop.appBg.BackColor
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tskmgr.ListBox1.Items.Remove("App Center")
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            Form1.fadeout_animation(Me, composedwindow)
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Hide()
        Me.Hide()
    End Sub

    Private Sub Store_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Show()
        Form1.Setfont(Me, Label1, Label4)
    End Sub


    Private Sub TerminateTimer_Tick(sender As Object, e As EventArgs) Handles TerminateTimer.Tick
        If LogoffWindow.Visible = True Then
            composedwindow.Close()
            Me.Close()
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
        If Desktop.KillSignal.Text = "App Center" Then
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Close()
            Me.Close()
        End If
        If Desktop.restorewindow.Text = "App Center" Then
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Show()
            Me.Show()
        End If
    End Sub
End Class