Public Class LogoffWindow
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim CurLocation, AppLocation As New Point(0, 0)
    Public composedwindow As Form = New Form()
    Private Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr
    Private Sub LogoffWindow_VisibleChanged(sender As System.Object, e As System.EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible = True Then
            Me.ForeColor = Desktop.appFg.BackColor
            LogoffTitle.BackColor = Desktop.labelBg.BackColor
            LogoffTitle.ForeColor = Desktop.labelFg.BackColor
            composedwindow.Opacity = 0.0
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.BackColor = Desktop.appBg.BackColor
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
                Me.TransparencyKey = Desktop.appBg.BackColor
                If Desktop.Label3.Visible = False Then Form1.translucency(Me, composedwindow, True)
            End If
        End If
    End Sub

    Private Sub LogoffTitle_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles LogoffTitle.MouseDown
        drag = True
        mousex = Cursor.Position.X - Left
        mousey = Cursor.Position.Y - Top
    End Sub

    Private Sub LogoffTitle_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles LogoffTitle.MouseMove
        If drag Then
            Top = Cursor.Position.Y - mousey
            Left = Cursor.Position.X - mousex
            composedwindow.Top = Me.Top
            composedwindow.Left = Me.Left
        End If
    End Sub

    Private Sub LogoffTitle_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles LogoffTitle.MouseUp
        drag = False
        composedwindow.BringToFront()
        Me.BringToFront()
    End Sub

    Private Sub LogoffWindow_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        composedwindow.Close()
    End Sub

    Private Sub LogoffWindow_Deactivate(sender As System.Object, e As System.EventArgs) Handles MyBase.Deactivate
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            If composedwindow.IsDisposed = False Then
                If Not GetActiveWindow <> composedwindow.Handle Then
                    Me.BringToFront()
                End If
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Me.Visible = True
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Timer1.Enabled = False
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            If composedwindow.IsDisposed = False Then
                If Not GetActiveWindow <> composedwindow.Handle Then
                    Me.BringToFront()
                End If
            End If
        End If
    End Sub

    Private Sub LogoffWindow_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Desktop.Label3.Visible = False Then
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Opacity = 1.0
        ElseIf Desktop.Label3.Visible = True Then
            Me.Location = New Point(Screen.PrimaryScreen.Bounds.Width + Me.Width + 1, Screen.PrimaryScreen.Bounds.Height + Me.Height + 1)
            Me.Opacity = 0.0
        End If
        Timer1.Enabled = True
    End Sub
End Class