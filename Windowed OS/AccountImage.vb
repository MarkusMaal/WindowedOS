Imports System.IO
Imports System.Resources
Imports System.Collections
Public Class AccountImage
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim composedwindow As Form = New Form()
    Private Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr
    Dim CurLocation, AppLocation As New Point(0, 0)
    Dim type As String = "Circle;47;20;50;50;" & vbNewLine & "Circle;47;78;50;50;" & vbNewLine & "Circle;47;79;50;50;" & vbNewLine & "Circle;47;80;50;50;" & vbNewLine & "Circle;47;81;50;50;" & vbNewLine & "Circle;47;82;50;50;" & vbNewLine & "Circle;47;83;50;50;" & vbNewLine & "Circle;47;84;50;50;" & vbNewLine & "Circle;47;85;50;50;" & vbNewLine & "Circle;47;86;50;50;" & vbNewLine & "Circle;47;87;50;50;" & vbNewLine & "Circle;47;88;50;50;" & vbNewLine & "Circle;47;89;50;50;" & vbNewLine & "Circle;47;90;50;50;" & vbNewLine & "Circle;47;91;50;50;" & vbNewLine & "Circle;47;92;50;50;" & vbNewLine & "Circle;47;93;50;50;" & vbNewLine & "Circle;47;94;50;50;" & vbNewLine & "Circle;47;95;50;50;" & vbNewLine & "Circle;47;96;50;50;" & vbNewLine & "Circle;47;97;50;50;" & vbNewLine & "Circle;47;98;50;50;" & vbNewLine & "Circle;47;99;50;50;" & vbNewLine & "Circle;47;100;50;50;" & vbNewLine & "Circle;47;101;50;50;" & vbNewLine & "Circle;47;102;50;50;" & vbNewLine & "Circle;47;102;50;50;" & vbNewLine & "Circle;47;103;50;50;" & vbNewLine & "Circle;47;104;50;50;" & vbNewLine & "Circle;47;105;50;50;" & vbNewLine & "Circle;47;106;50;50;" & vbNewLine & "Circle;47;107;50;50;" & vbNewLine & "Circle;47;108;50;50;" & vbNewLine & "Circle;47;109;50;50;"
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim r As String
        Try
            r = ComboBox2.Items(ComboBox2.SelectedIndex).ToString()
        Catch
            Exit Sub
        End Try

        Dim pic As Paintbrush = New Paintbrush With {
            .Size = New Size(155, 190)
        }
        pic.Sup(Color.FromName(ComboBox1.SelectedItem.ToString()))
        pic.pencolor = Color.FromName(r)
        pic.secondcolor = pic.pencolor
        Clipboard.SetText(type, TextDataFormat.Text)
        pic.Pastedrawdata()
        PictureBox1.BackgroundImage = pic.PictureBox1.Image
        pic.composedwindow.Close()
        pic.Close()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim r As String
        Try
            r = ComboBox2.Items(ComboBox2.SelectedIndex).ToString()
        Catch
            Exit Sub
        End Try

        Dim pic As Paintbrush = New Paintbrush With {
            .Size = New Size(155, 190)
        }
        pic.Sup(Color.FromName(ComboBox1.SelectedItem.ToString()))
        pic.pencolor = Color.FromName(r)
        pic.secondcolor = pic.pencolor
        Clipboard.SetText(type, TextDataFormat.Text)
        pic.Pastedrawdata()
        PictureBox1.BackgroundImage = pic.PictureBox1.Image
        pic.composedwindow.Close()
        pic.Close()
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

    Private Sub Settings_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible = True Then
            Form1.Setfont(Me, Label4)
            Label4.BackColor = Desktop.labelBg.BackColor
            Label4.ForeColor = Desktop.labelFg.BackColor
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.BackColor = Desktop.appBg.BackColor
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.Translucency(Me, composedwindow, True)
            composedwindow.TopMost = True
            composedwindow.BringToFront()
            Me.BringToFront()
            Me.ForeColor = Desktop.appFg.BackColor
        End If
    End Sub

    Private Sub TerminateTimer_Tick(sender As Object, e As EventArgs) Handles TerminateTimer.Tick
        If LogoffWindow.Visible = True Then
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Close()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.fadeout_animation(Me, composedwindow)
        ElseIf Lock.Visible = True Then
            Me.Hide()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Hide()
        ElseIf Desktop.KillSignal.Text = "Settings" Then
            'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Close()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.fadeout_animation(Me, composedwindow)
        ElseIf Desktop.restorewindow.Text = "Settings" Then
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

    Private Sub AccountImage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Opacity = 1.0
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.TransparencyKey = Nothing
        composedwindow.FormBorderStyle = Windows.Forms.FormBorderStyle.None
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oi As OpenFileDialog = PictureViewer.OpenFileDialog1
        If oi.ShowDialog = Windows.Forms.DialogResult.OK Then
            File.Copy(oi.FileName, My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & Desktop.user & ".png", True)
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
                Form1.fadeout_animation(Me, composedwindow)
            Else
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim img As Image = CombineAvatar(PictureBox1.BackgroundImage, PictureBox1.BackColor)
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = Nothing
        PictureBox1.BackgroundImage = img
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & Desktop.user & ".png") Then File.Delete(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & Desktop.user & ".png")
        PictureBox1.BackgroundImage.Save(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & Desktop.user & ".png", Imaging.ImageFormat.Png)
        img.Dispose()
        PictureBox1.BackgroundImage.Dispose()
        If Not Setup.Visible = True Then Settings.Show()
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            Form1.fadeout_animation(Me, composedwindow)
        Else
            Me.Close()
        End If
    End Sub

    Public Function CombineAvatar(av As Image, bg As Color) As Image
        Dim bmp As New Bitmap(250, 250)
        Using g As Graphics = Graphics.FromImage(bmp)
            Using br As New SolidBrush(bg)
                g.FillRectangle(br, 0, 0, bmp.Width, bmp.Height)
            End Using
            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
            g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
            g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            g.DrawImage(av, 0, 0, bmp.Width, bmp.Height)
        End Using
        Return bmp
    End Function

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.SelectedIndex = 0 Then
            type = "Circle;47;20;50;50;" & vbNewLine & "Circle;47;78;50;50;" & vbNewLine & "Circle;47;79;50;50;" & vbNewLine & "Circle;47;80;50;50;" & vbNewLine & "Circle;47;81;50;50;" & vbNewLine & "Circle;47;82;50;50;" & vbNewLine & "Circle;47;83;50;50;" & vbNewLine & "Circle;47;84;50;50;" & vbNewLine & "Circle;47;85;50;50;" & vbNewLine & "Circle;47;86;50;50;" & vbNewLine & "Circle;47;87;50;50;" & vbNewLine & "Circle;47;88;50;50;" & vbNewLine & "Circle;47;89;50;50;" & vbNewLine & "Circle;47;90;50;50;" & vbNewLine & "Circle;47;91;50;50;" & vbNewLine & "Circle;47;92;50;50;" & vbNewLine & "Circle;47;93;50;50;" & vbNewLine & "Circle;47;94;50;50;" & vbNewLine & "Circle;47;95;50;50;" & vbNewLine & "Circle;47;96;50;50;" & vbNewLine & "Circle;47;97;50;50;" & vbNewLine & "Circle;47;98;50;50;" & vbNewLine & "Circle;47;99;50;50;" & vbNewLine & "Circle;47;100;50;50;" & vbNewLine & "Circle;47;101;50;50;" & vbNewLine & "Circle;47;102;50;50;" & vbNewLine & "Circle;47;102;50;50;" & vbNewLine & "Circle;47;103;50;50;" & vbNewLine & "Circle;47;104;50;50;" & vbNewLine & "Circle;47;105;50;50;" & vbNewLine & "Circle;47;106;50;50;" & vbNewLine & "Circle;47;107;50;50;" & vbNewLine & "Circle;47;108;50;50;" & vbNewLine & "Circle;47;109;50;50;"
        ElseIf ComboBox3.SelectedIndex = 1 Then
            type = "Circle;45;43;50;50;"
        End If
        If ComboBox3.SelectedItem.ToString() = "Letter A" Then
            type = "Text;A;Segoe UI;72;25;2;"
        ElseIf ComboBox3.SelectedItem.ToString() = "Letter B" Then
            type = "Text;B;Segoe UI;72;25;2;"
        ElseIf ComboBox3.SelectedItem.ToString() = "Letter C" Then
            type = "Text;C;Segoe UI;72;25;2;"
        ElseIf ComboBox3.SelectedItem.ToString() = "Letter D" Then
            type = "Text;D;Segoe UI;72;25;2;"
        ElseIf ComboBox3.SelectedItem.ToString() = "Letter E" Then
            type = "Text;E;Segoe UI;72;25;2;"
        ElseIf ComboBox3.SelectedItem.ToString() = "Letter F" Then
            type = "Text;F;Segoe UI;72;25;2;"
        ElseIf ComboBox3.SelectedItem.ToString() = "Letter G" Then
            type = "Text;G;Segoe UI;72;25;2;"
        ElseIf ComboBox3.SelectedItem.ToString() = "Letter H" Then
            type = "Text;H;Segoe UI;72;25;2;"
        ElseIf ComboBox3.SelectedItem.ToString() = "Letter I" Then
            type = "Text;I;Segoe UI;72;25;2;"
        ElseIf ComboBox3.SelectedItem.ToString() = "Letter J" Then
            type = "Text;J;Segoe UI;72;25;2;"
        ElseIf ComboBox3.SelectedItem.ToString() = "Letter K" Then
            type = "Text;K;Segoe UI;72;25;2;"
        ElseIf ComboBox3.SelectedItem.ToString() = "Letter L" Then
            type = "Text;L;Segoe UI;72;25;2;"
        ElseIf ComboBox3.SelectedItem.ToString() = "Letter M" Then
            type = "Text;M;Segoe UI;72;25;2;"
        ElseIf ComboBox3.SelectedItem.ToString() = "Letter N" Then
            type = "Text;N;Segoe UI;72;25;2;"
        ElseIf ComboBox3.SelectedItem.ToString() = "Letter O" Then
            type = "Text;O;Segoe UI;72;25;2;"
        ElseIf ComboBox3.SelectedItem.ToString() = "Letter P" Then
            type = "Text;P;Segoe UI;72;25;2;"
        ElseIf ComboBox3.SelectedItem.ToString() = "Letter Q" Then
            type = "Text;Q;Segoe UI;72;25;2;"
        ElseIf ComboBox3.SelectedItem.ToString() = "Letter R" Then
            type = "Text;R;Segoe UI;72;25;2;"
        ElseIf ComboBox3.SelectedItem.ToString() = "Letter S" Then
            type = "Text;S;Segoe UI;72;25;2;"
        ElseIf ComboBox3.SelectedItem.ToString() = "Letter T" Then
            type = "Text;T;Segoe UI;72;25;2;"
        ElseIf ComboBox3.SelectedItem.ToString() = "Letter U" Then
            type = "Text;U;Segoe UI;72;25;2;"
        ElseIf ComboBox3.SelectedItem.ToString() = "Letter V" Then
            type = "Text;V;Segoe UI;72;25;2;"
        ElseIf ComboBox3.SelectedItem.ToString() = "Letter W" Then
            type = "Text;W;Segoe UI;72;25;2;"
        ElseIf ComboBox3.SelectedItem.ToString() = "Letter X" Then
            type = "Text;X;Segoe UI;72;25;2;"
        ElseIf ComboBox3.SelectedItem.ToString() = "Letter Y" Then
            type = "Text;Y;Segoe UI;72;25;2;"
        ElseIf ComboBox3.SelectedItem.ToString() = "Letter Z" Then
            type = "Text;Z;Segoe UI;72;25;2;"
        End If
        If Not ComboBox2.SelectedIndex = 0 Then
            ComboBox2.SelectedIndex -= 1
            ComboBox2.SelectedIndex += 1
            Exit Sub
        Else
            ComboBox2.SelectedIndex += 1
            ComboBox2.SelectedIndex -= 1
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim r As Random = New Random()
        ComboBox1.SelectedIndex = r.Next(0, ComboBox1.Items.Count - 1)
        ComboBox2.SelectedIndex = r.Next(0, ComboBox2.Items.Count - 1)
        ComboBox3.SelectedIndex = r.Next(0, ComboBox3.Items.Count - 1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim r As Random = New Random()
        ComboBox1.SelectedIndex = r.Next(0, ComboBox1.Items.Count - 1)
        ComboBox2.SelectedIndex = r.Next(0, ComboBox2.Items.Count - 1)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim r As Random = New Random()
        ComboBox3.SelectedIndex = r.Next(0, ComboBox3.Items.Count - 1)
    End Sub
End Class