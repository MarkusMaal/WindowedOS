Imports System.IO
Public Class UpdateSettings

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim composedwindow As Form = New Form()
    Dim rap As Boolean = False
    Private Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData + "\Windowed\update.cfg", Form1.channel + ";" + Form1.check + ";" + Form1.server)
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            Form1.Fadeout_animation(Me, composedwindow)
            Exit Sub
        Else
            Me.Opacity = 0.0
            Close()
        End If
    End Sub

    Private Sub UpdateSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Opacity = 1.0
        If Form1.check = "Download" Then RadioButton1.Checked = True
        If Form1.check = "Check" Then RadioButton2.Checked = True
        If Form1.check = "Manual" Then RadioButton3.Checked = True
        TextBox1.Text = Form1.server
        If Form1.channel = "Stable" Then RadioButton4.Checked = True
        If Form1.channel = "Prerelease" Then RadioButton7.Checked = True
        If Form1.channel = "Beta" Then RadioButton5.Checked = True
        If Form1.channel = "Alpha" Then RadioButton6.Checked = True
    End Sub

    Private Sub UpdateSettings_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
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

    Private Sub UpdateSettings_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
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

    Private Sub UpdateSettings_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible = True Then
            Form1.Setfont(Me, Label6)
            Label6.BackColor = Desktop.labelBg.BackColor
            Label6.ForeColor = Desktop.labelFg.BackColor
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

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            TextBox1.Text = "http://markustegelane.tk/firmware/windowed_os/releases/update.txt"
            Form1.channel = "Stable"
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then
            TextBox1.Text = "http://markustegelane.tk/firmware/windowed_os/prereleases/update.txt"
            Form1.channel = "Prerelease"
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            TextBox1.Text = "http://markustegelane.tk/firmware/windowed_os/betas/update.txt"
            Form1.channel = "Beta"
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            TextBox1.Text = "http://markustegelane.tk/firmware/windowed_os/experimental/update.txt"
            Form1.channel = "Alpha"
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Form1.check = "Download"
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Form1.check = "Check"
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            Form1.check = "Manual"
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Form1.server = TextBox1.Text
    End Sub
End Class