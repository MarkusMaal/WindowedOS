Public Class Docs

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim composedwindow As Form = New Form()
    Dim CurLocation, AppLocation As New Point(0, 0)
    Dim rap As Boolean = False
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
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            composedwindow.Size = Me.Size
        End If
    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label6.MouseDown
        drag = True
        mousex = Cursor.Position.X - Left
        mousey = Cursor.Position.Y - Top
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label6.MouseMove
        If drag Then
            Top = Cursor.Position.Y - mousey
            Left = Cursor.Position.X - mousex
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
                composedwindow.Top = Me.Top
                composedwindow.Left = Me.Left
            End If
        End If
    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label6.MouseUp
        drag = False
        composedwindow.BringToFront()
        Me.BringToFront()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            Form1.fadeout_animation(Me, composedwindow)
            Exit Sub
        Else
            Me.Opacity = 0.0
            Close()
        End If
    End Sub

    Private Sub Docs_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible = True Then
            Form1.Setfont(Me, Label6)
            Label6.BackColor = Desktop.labelBg.BackColor
            Label6.ForeColor = Desktop.labelFg.BackColor
            Label2.BackColor = Desktop.appBg.BackColor
            Label2.ForeColor = Desktop.appFg.BackColor
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then
                Me.BackColor = Desktop.appBg.BackColor
                Me.TransparencyKey = Nothing
                GoTo wow
            Else
                Form1.Translucency(Me, composedwindow, True)
            End If
wow:
            Button1.BackColor = Me.BackColor
            Dim r As Integer = Button1.BackColor.R - 1
            Dim g As Integer = Button1.BackColor.G - 1
            Dim b As Integer = Button1.BackColor.B - 1
            If r < 0 Then r += 2
            If g < 0 Then g += 2
            If b < 0 Then b += 2
            Button1.BackColor = Color.FromArgb(r, g, b)
            Me.ForeColor = Desktop.appFg.BackColor
        End If
    End Sub

    Private Sub Docs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Opacity = 1.0
    End Sub

    Private Sub TerminateTimer_Tick(sender As Object, e As EventArgs) Handles TerminateTimer.Tick
        If LogoffWindow.Visible = True Then
            Button1.PerformClick()
        ElseIf Lock.Visible = True Then
            Me.Hide()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Hide()
        ElseIf Desktop.restorewindow.Text = "Documentation" Then
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
        If Me.Visible = True Then
            If CustomizationCenter.ApplyTheme.Enabled = True Then
                composedwindow.Hide()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub Docs_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Label6.BackColor = Desktop.labelBg.BackColor
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

    Private Sub Docs_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
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
        Label6.BackColor = col
        If composedwindow.IsDisposed = False Then
            If Not GetActiveWindow <> composedwindow.Handle Then
                Me.BringToFront()
            End If
        End If
        rap = False
    End Sub

    Public Sub launchdoc(ByVal document As String, ByVal title As String)
        RichTextBox1.Rtf = document
        Label6.Text = title
        Me.Show()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Dim d As Double
        d = Convert.ToDouble(TrackBar1.Value) / 100.0
        RichTextBox1.ZoomFactor = d
        Label1.Text = "Zoom (" & d.ToString() & "x)"
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            RichTextBox1.WordWrap = True
        ElseIf CheckBox1.Checked = False Then
            RichTextBox1.WordWrap = False
        End If
    End Sub
End Class