Imports System.Drawing.Imaging

Public Class Paintbrush
    Dim pdrag As Boolean
    Public pencolor As Color = Color.Black
    Public secondcolor As Color = pencolor
    Dim brushx As Integer = 3
    Dim brushy As Integer = brushx
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim CurLocation, AppLocation As New Point(0, 0)
    Dim clicklistener As Boolean = False
    Dim p As Point = New Point(0, 0)
    Dim input As String
    Dim rap As Boolean = False
    Dim flood As Boolean = False
    Dim fontdlg As FontDialog = New FontDialog()
    Public composedwindow As Form = New Form()
    Dim endstroke As Boolean = False
    Dim startline As Point = New Point(0, 0)
    Dim sizemode As Integer = 5
    Dim curx As Integer = 0
    Dim cury As Integer = 0
    Private Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr
    Private Sub PictureBox1_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        If flood Then
            curx = Cursor.Position.X - PictureBox1.Location.X - Me.Location.X
            cury = Cursor.Position.Y - PictureBox1.Location.Y - Me.Location.Y
            Dim backups As Integer() = {curx, cury}
            Dim flox As Integer = curx
            Dim floy As Integer = cury
            Dim b As Bitmap = PictureBox1.Image
            Dim backupcolor As Color = b.GetPixel(curx, cury)
            Dim curPixColor As Color = b.GetPixel(curx, cury)
            Dim curSecColor As Color = b.GetPixel(curx, cury)

            While True
                flox = backups(0)
                floy -= 1
                If floy < 0 Then Exit While
                While True
                    Try
                        If curSecColor.Equals(backupcolor) Then
                            b.SetPixel(flox, floy, ColorDialog1.Color)
                        End If
                        flox -= 1
                        curSecColor = b.GetPixel(flox, floy)
                        If Not curSecColor.Equals(backupcolor) Then
                            Exit While
                        End If
                    Catch
                        Exit While
                    End Try
                End While
                PictureBox1.Image = b
                b = PictureBox1.Image
            End While
            floy = backups(1)
            While True
                flox = backups(0)
                If floy > PictureBox1.Height Then Exit While
                While True
                    Try
                        If curSecColor.Equals(backupcolor) Then
                            b.SetPixel(flox, floy, ColorDialog1.Color)
                        End If
                        flox -= 1
                        curSecColor = b.GetPixel(flox, floy)
                        If Not curSecColor.Equals(backupcolor) Then
                            Exit While
                        End If
                    Catch
                        Exit While
                    End Try
                End While
                floy += 1
                PictureBox1.Image = b
                b = PictureBox1.Image
            End While
            While True
                curx = backups(0) + 1
                cury -= 1
                If cury < 0 Then Exit While
                While True
                    Try
                        If curPixColor.Equals(backupcolor) Then
                            b.SetPixel(curx, cury, ColorDialog1.Color)
                        End If
                        curx += 1
                        curPixColor = b.GetPixel(curx, cury)
                        If Not curPixColor.Equals(backupcolor) Then
                            Exit While
                        End If
                    Catch
                        Exit While
                    End Try
                End While
                PictureBox1.Image = b
                b = PictureBox1.Image
            End While
            cury = backups(1)
            While True
                curx = backups(0) + 1
                If cury > PictureBox1.Height Then Exit While
                While True
                    Try
                        If curPixColor.Equals(backupcolor) Then
                            b.SetPixel(curx, cury, ColorDialog1.Color)
                        End If
                        curx += 1
                        curPixColor = b.GetPixel(curx, cury)
                        If Not curPixColor.Equals(backupcolor) Then
                            Exit While
                        End If
                    Catch
                        Exit While
                    End Try
                End While
                PictureBox1.Image = b
                b = PictureBox1.Image
                cury += 1
            End While
            PictureBox1.Image = b
            Exit Sub
        End If
        If clicklistener = True Then
            p = New Point(Windows.Forms.Cursor.Position.X - Me.Location.X - 6, Windows.Forms.Cursor.Position.Y - Me.Location.Y - 45)
            AddTextToolStripMenuItem.PerformClick()
            Exit Sub
        End If

        If LineToolStripMenuItem.Checked = True Then
            If endstroke = False Then
                startline = e.Location
                endstroke = True
                Exit Sub
            ElseIf endstroke = True Then
                Dim g As Graphics
                Dim img As Bitmap = PictureBox1.Image
                g = Graphics.FromImage(img)
                g.CompositingMode = Drawing2D.CompositingMode.SourceCopy
                Dim lackpen As New Drawing2D.LinearGradientBrush(PictureBox1.DisplayRectangle, pencolor, secondcolor, Drawing2D.LinearGradientMode.Horizontal)
                Dim blackpen As New Drawing2D.LinearGradientBrush(PictureBox1.DisplayRectangle, pencolor, secondcolor, Drawing2D.LinearGradientMode.Vertical)
                Dim black As New Drawing.Pen(pencolor)
                g.DrawLine(black, startline.X, startline.Y, e.Location.X, e.Location.Y)
                Dim papa As String = "Line;" & e.X.ToString() & ";" & e.Y.ToString() & ";" & brushx.ToString() & ";" & brushx.ToString() & ";"
                If Not TextBox1.Text.Contains(papa) Then TextBox1.Text = TextBox1.Text & vbNewLine & papa
                endstroke = False
                PictureBox1.Image = img
                Exit Sub
            End If
        End If
        pdrag = True
    End Sub


    Private Sub PictureBox1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        Try
            curx = Cursor.Position.X - PictureBox1.Location.X - Me.Location.X
            cury = Cursor.Position.Y - PictureBox1.Location.Y - Me.Location.Y
            Label1.Text = "X:" & curx.ToString() & ", Y:" & cury.ToString()
            If pdrag Then
                Dim ogsize = New Size(PictureBox1.Image.Width + 9, PictureBox1.Image.Height + 57)
                Dim xmultiplier As Double = Size.Width / ogsize.Width
                Dim ymultiplier As Double = Size.Height / ogsize.Height
                Dim g As Graphics
                Dim img As Bitmap = PictureBox1.Image
                g = Graphics.FromImage(img)
                g.CompositingMode = Drawing2D.CompositingMode.SourceCopy
                Dim lackpen As New Drawing2D.LinearGradientBrush(PictureBox1.DisplayRectangle, pencolor, secondcolor, Drawing2D.LinearGradientMode.Horizontal)
                Dim blackpen As New Drawing2D.LinearGradientBrush(PictureBox1.DisplayRectangle, pencolor, secondcolor, Drawing2D.LinearGradientMode.Vertical)
                Dim black As New Drawing.Pen(pencolor)
                If GradientToolStripMenuItem.Checked = True Then
                    Dim dhalvex As Double = brushx / 2
                    Dim dhalvey As Double = brushy / 2
                    Dim halvex As Integer = Convert.ToInt32(dhalvex)
                    Dim halvey As Integer = Convert.ToInt32(dhalvey)
                    If LineToolStripMenuItem.Checked = True Then
                        g.DrawLine(black, e.X - halvex, e.Y - halvey, e.X + brushx, e.Y + brushy)
                    ElseIf CircleToolStripMenuItem.Checked = True Then
                        Dim rect As New Rectangle(New Point(e.Location.X - halvex, e.Location.Y - halvey), New Size(brushx, brushy))
                        g.FillEllipse(blackpen, rect)
                    ElseIf RectangleToolStripMenuItem.Checked = True Then
                        Dim rect As New Rectangle(New Point(e.Location.X - halvex, e.Location.Y - halvey), New Size(brushx, brushy))
                        g.FillRectangle(blackpen, rect)
                    End If
                    PictureBox1.Image = img
                    Exit Sub
                Else
                    Dim dhalvex As Double = brushx / 2
                    Dim dhalvey As Double = brushy / 2
                    Dim halvex As Integer = Convert.ToInt32(dhalvex)
                    Dim halvey As Integer = Convert.ToInt32(dhalvey)
                    If CircleToolStripMenuItem.Checked = True Then
                        Dim rect As New Rectangle(New Point(e.Location.X - halvex, e.Location.Y - halvey), New Size(brushx, brushy))
                        Dim papa As String = "Circle;" & e.X.ToString() & ";" & e.Y.ToString() & ";" & brushx.ToString() & ";" & brushx.ToString() & ";"
                        If Not TextBox1.Text.Contains(papa) Then TextBox1.Text = TextBox1.Text & vbNewLine & papa
                        g.FillEllipse(lackpen, rect)
                    ElseIf RectangleToolStripMenuItem.Checked = True Then
                        Dim rect As New Rectangle(New Point(e.Location.X - halvex, e.Location.Y - halvey), New Size(brushx, brushy))
                        Dim papa As String = "Square;" & e.X.ToString() & ";" & e.Y.ToString() & ";" & brushx.ToString() & ";" & brushx.ToString() & ";"
                        If Not TextBox1.Text.Contains(papa) Then TextBox1.Text = TextBox1.Text & vbNewLine & papa
                        g.FillRectangle(lackpen, rect)
                    End If
                    PictureBox1.Image = img
                End If
            End If
        Catch ex As Exception
            ESOD.Label5.Text = ex.Message
            ESOD.ShowDialog()
        End Try
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        pdrag = False
    End Sub

    Private Sub ForegroundToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ForegroundToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            pencolor = ColorDialog1.Color
            If GradienthorizontalToolStripMenuItem.Checked = False And GradientToolStripMenuItem.Checked = False Then
                secondcolor = pencolor
            End If
        End If
    End Sub

    Private Sub PtToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PtToolStripMenuItem.Click
        brushx = 1
        brushy = brushx
        PtToolStripMenuItem1.Checked = False
        PtToolStripMenuItem2.Checked = False
        PtToolStripMenuItem3.Checked = False
        PtToolStripMenuItem4.Checked = False
        PtToolStripMenuItem5.Checked = False
    End Sub

    Private Sub PtToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles PtToolStripMenuItem1.Click
        brushx = 3
        brushy = brushx
        PtToolStripMenuItem.Checked = False
        PtToolStripMenuItem2.Checked = False
        PtToolStripMenuItem3.Checked = False
        PtToolStripMenuItem4.Checked = False
        PtToolStripMenuItem5.Checked = False
    End Sub

    Private Sub PtToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles PtToolStripMenuItem2.Click
        brushx = 5
        brushy = brushx
        PtToolStripMenuItem1.Checked = False
        PtToolStripMenuItem.Checked = False
        PtToolStripMenuItem3.Checked = False
        PtToolStripMenuItem4.Checked = False
        PtToolStripMenuItem5.Checked = False
    End Sub

    Private Sub PtToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles PtToolStripMenuItem3.Click
        brushx = 10
        brushy = brushx
        PtToolStripMenuItem1.Checked = False
        PtToolStripMenuItem2.Checked = False
        PtToolStripMenuItem.Checked = False
        PtToolStripMenuItem4.Checked = False
        PtToolStripMenuItem5.Checked = False
    End Sub

    Private Sub PtToolStripMenuItem4_Click(sender As System.Object, e As System.EventArgs) Handles PtToolStripMenuItem4.Click
        brushx = 20
        brushy = brushx
        PtToolStripMenuItem1.Checked = False
        PtToolStripMenuItem2.Checked = False
        PtToolStripMenuItem3.Checked = False
        PtToolStripMenuItem.Checked = False
        PtToolStripMenuItem5.Checked = False
    End Sub

    Private Sub PtToolStripMenuItem5_Click(sender As System.Object, e As System.EventArgs) Handles PtToolStripMenuItem5.Click
        brushx = 50
        brushy = brushx
        PtToolStripMenuItem1.Checked = False
        PtToolStripMenuItem2.Checked = False
        PtToolStripMenuItem3.Checked = False
        PtToolStripMenuItem4.Checked = False
        PtToolStripMenuItem.Checked = False
    End Sub

    Private Sub BackgroundToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BackgroundToolStripMenuItem.Click
        Try
            If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                PictureBox1.BackColor = ColorDialog1.Color
                Dim g As Graphics
                Dim img As Bitmap = PictureBox1.Image
                g = Graphics.FromImage(img)
                g.CompositingMode = Drawing2D.CompositingMode.SourceCopy
                Dim bc As New Drawing.SolidBrush(ColorDialog1.Color)
                g.FillRectangle(bc, 0, 0, PictureBox1.Width, PictureBox1.Height)
                PictureBox1.Image = img
            End If
        Catch ex As Exception
            ESOD.Label5.Text = ex.Message
            ESOD.ShowDialog()
        End Try
    End Sub
    Public Sub Sup(ByVal col As Color)
        PictureBox1.Image = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        PictureBox1.BackColor = ColorDialog1.Color
        Dim g As Graphics
        Dim img As Bitmap = PictureBox1.Image
        g = Graphics.FromImage(img)
        g.CompositingMode = Drawing2D.CompositingMode.SourceCopy
        Dim bc As New Drawing.SolidBrush(col)
        g.FillRectangle(bc, 0, 0, PictureBox1.Width, PictureBox1.Height)
        PictureBox1.Image = img
    End Sub
    Private Sub LineToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LineToolStripMenuItem.Click
        CircleToolStripMenuItem.Checked = False
        RectangleToolStripMenuItem.Checked = False
        endstroke = False
    End Sub

    Private Sub CircleToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CircleToolStripMenuItem.Click
        LineToolStripMenuItem.Checked = False
        RectangleToolStripMenuItem.Checked = False
    End Sub

    Private Sub RectangleToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RectangleToolStripMenuItem.Click
        CircleToolStripMenuItem.Checked = False
        LineToolStripMenuItem.Checked = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)

        If Not Desktop.usertype = "Guest" Then
            Dim brush As String = "Line"
            If LineToolStripMenuItem.Checked = True Then brush = "Line"
            If CircleToolStripMenuItem.Checked = True Then brush = "Circle"
            If RectangleToolStripMenuItem.Checked = True Then brush = "Rectangle"
            Dim data As String
            data = Me.Width & ";" & Me.Height & ";" & brushx.ToString() & ";" & brush & ";"
            My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & Desktop.user & "_draw.txt", data, False)
        End If
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            Form1.fadeout_animation(Me, composedwindow)
            Exit Sub
        Else
            composedwindow.Close()
            Me.Close()
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            Dim dimx As Integer
            Dim dimy As Integer
            dimx = PictureBox1.Image.PhysicalDimension.Width
            dimy = PictureBox1.Image.PhysicalDimension.Height
            Me.Size = New Size(dimx + 9, dimy + 57)
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewToolStripMenuItem.Click
        TextBox1.Text = ""
        PictureBox1.Image = Nothing
        PictureBox1.BackColor = Color.Gray
        PictureBox1.BackColor = Color.White
        PictureBox1.Image = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        Dim g As Graphics
        Dim img As Bitmap = PictureBox1.Image
        g = Graphics.FromImage(img)
        g.CompositingMode = Drawing2D.CompositingMode.SourceCopy
        Dim bc As New Drawing.SolidBrush(PictureBox1.BackColor)
        g.FillRectangle(bc, 0, 0, PictureBox1.Width, PictureBox1.Height)
        PictureBox1.Image = img
    End Sub

    Private Sub Paintbrush_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        If Not tskmgr.ListBox1.Items.Contains("Paintbrush") Then tskmgr.ListBox1.Items.Add("Paintbrush")
        If Not Desktop.usertype = "Guest" Then
            If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & Desktop.user & "_draw.txt") Then
                Dim lst As String = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & Desktop.user & "_draw.txt")
                Dim lstbox As ListBox = New ListBox
                lstbox.Items.AddRange(lst.Split(";"))
                lstbox.SelectedIndex = 0
                Dim x As Integer = lstbox.SelectedItem
                lstbox.SelectedIndex = 1
                Dim y As Integer = lstbox.SelectedItem
                Me.Size = New Size(x, y)
                lstbox.SelectedIndex = 2
                brushx = lstbox.SelectedItem
                brushy = brushx
                PtToolStripMenuItem.Checked = False
                PtToolStripMenuItem1.Checked = False
                PtToolStripMenuItem2.Checked = False
                PtToolStripMenuItem3.Checked = False
                PtToolStripMenuItem4.Checked = False
                PtToolStripMenuItem5.Checked = False
                If brushx = 1 Then PtToolStripMenuItem.Checked = True
                If brushx = 3 Then PtToolStripMenuItem1.Checked = True
                If brushx = 5 Then PtToolStripMenuItem2.Checked = True
                If brushx = 10 Then PtToolStripMenuItem3.Checked = True
                If brushx = 20 Then PtToolStripMenuItem4.Checked = True
                If brushx = 50 Then PtToolStripMenuItem5.Checked = True
                lstbox.SelectedIndex = 3
                If lstbox.SelectedItem = "Circle" Then
                    CircleToolStripMenuItem.Checked = True
                    RectangleToolStripMenuItem.Checked = False
                    LineToolStripMenuItem.Checked = False
                ElseIf lstbox.SelectedItem = "Rectangle" Then
                    CircleToolStripMenuItem.Checked = False
                    RectangleToolStripMenuItem.Checked = True
                    LineToolStripMenuItem.Checked = False
                ElseIf lstbox.SelectedItem = "Line" Then
                    CircleToolStripMenuItem.Checked = False
                    RectangleToolStripMenuItem.Checked = False
                    LineToolStripMenuItem.Checked = True
                End If
            End If
        End If
        PictureBox1.Image = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        Dim g As Graphics
        Dim img As Bitmap = PictureBox1.Image
        g = Graphics.FromImage(img)
        g.CompositingMode = Drawing2D.CompositingMode.SourceCopy
        Dim bc As New Drawing.SolidBrush(Color.White)
        g.FillRectangle(bc, 0, 0, PictureBox1.Width, PictureBox1.Height)
        PictureBox1.Image = img
    End Sub

    Private Sub Paintbrush_VisibleChanged(sender As Object, e As System.EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            If Desktop.dev = True Then AvatarToolStripMenuItem.Enabled = True
            If Desktop.dev = True Then ShowDrawingHistorydevToolStripMenuItem.Enabled = True
            Form1.Setfont(Me, Label4, Label3)
            Label4.BackColor = Desktop.labelBg.BackColor
            Label4.ForeColor = Desktop.labelFg.BackColor
            Label3.BackColor = Label4.BackColor
            Label3.ForeColor = Label4.ForeColor
            Label5.BackColor = Desktop.appBg.BackColor
            Label5.ForeColor = Desktop.appFg.BackColor
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then
                Me.Opacity = 1.0
                Me.BackColor = Desktop.appBg.BackColor
                Me.TransparencyKey = Nothing
            ElseIf Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
                composedwindow.Opacity = 0.0
                Form1.fadein_animation(Me, composedwindow)
                Me.BackColor = Desktop.appBg.BackColor
                Me.TransparencyKey = Desktop.appBg.BackColor
                composedwindow.AllowTransparency = True
                composedwindow.Size = Me.Size
                composedwindow.TopMost = True
                composedwindow.BackColor = Desktop.appBg.BackColor
                composedwindow.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                composedwindow.ShowInTaskbar = False
                composedwindow.ShowIcon = False
                composedwindow.Show()
                composedwindow.Size = Me.Size
                composedwindow.Location = Me.Location
                composedwindow.BringToFront()
                Me.BringToFront()
            End If
            Me.ForeColor = Desktop.appFg.BackColor
        End If
    End Sub
    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label4.MouseDown
        drag = True
        mousex = Cursor.Position.X - Left
        mousey = Cursor.Position.Y - Top
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label4.MouseMove
        If drag Then
            Top = Cursor.Position.Y - mousey
            Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label4.MouseUp
        drag = False
        composedwindow.BringToFront()
        Me.BringToFront()
    End Sub

    Private Sub Sync()
        CurLocation = Cursor.Position
        AppLocation = Size
    End Sub
    Private Sub Label5_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Label5.MouseDown
        ResizeTimer.Start()
        Sync()
    End Sub

    Private Sub Label5_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Label5.MouseUp
        ResizeTimer.Stop()
        Sync()
        composedwindow.BringToFront()
        Me.BringToFront()
    End Sub

    Private Sub ResizeTimer_Tick(sender As System.Object, e As System.EventArgs) Handles ResizeTimer.Tick
        Try
            Dim presize As Size = Me.Size
            Size = AppLocation - CurLocation + Cursor.Position

            If sizemode = 1 Then
                'ugly resizing mode, should not be used, because of crappy quality
                PictureBox1.Image = New Bitmap(PictureBox1.Image, New Size(PictureBox1.Width, PictureBox1.Height))
                'resizing mode that puts image in the topleft corner while resizing
            ElseIf sizemode = 0 Then
                Dim x As Integer = 0
                Dim y As Integer = 0
                Dim k = 0
                Dim l = 0
                Dim bm As New Bitmap(PictureBox1.Image)
                Dim om As New Bitmap(PictureBox1.Image.Width, PictureBox1.Image.Height)
                Dim r, g, b As Byte
                Do While x < bm.Width - 1
                    y = 0
                    l = 0
                    Do While y < bm.Height - 1
                        r = 255 - bm.GetPixel(x, y).R
                        g = 255 - bm.GetPixel(x, y).G
                        b = 255 - bm.GetPixel(x, y).B
                        om.SetPixel(l, k, Color.FromArgb(r, g, b))
                        y += 3
                        l += 1
                    Loop
                    x += 3
                    k += 1
                Loop
                PictureBox1.Image = om
                'doesn't work, shouldn't be used
            ElseIf sizemode = 2 Then
                Dim src As New Bitmap(PictureBox1.Image)
                Dim target As New Bitmap(PictureBox1.Image.Size.Width, PictureBox1.Image.Size.Height, PixelFormat.Format24bppRgb)
                Using gr As Graphics = Graphics.FromImage(PictureBox1.Image)
                    gr.DrawImage(src, New Size(PictureBox1.Width, PictureBox1.Height))
                End Using
            ElseIf sizemode = 5 Then
                Dim b As New Bitmap(PictureBox1.Image)
                Dim target As New Bitmap(PictureBox1.Width, PictureBox1.Height)
                Dim g As Graphics
                Dim img As Bitmap = PictureBox1.Image
                g = Graphics.FromImage(b)
                g.CompositingMode = Drawing2D.CompositingMode.SourceCopy
                Dim bc As New Drawing.SolidBrush(PictureBox1.BackColor)
                g.FillRectangle(bc, PictureBox1.Image.Size.Width, 0, PictureBox1.Width - PictureBox1.Image.Size.Width, PictureBox1.Height)
                g.FillRectangle(bc, 0, PictureBox1.Image.Size.Height, PictureBox1.Width, PictureBox1.Height - PictureBox1.Image.Size.Height)
                PictureBox1.Image = b
            ElseIf sizemode = 3 Then
                Dim scale_factor As Single = Single.Parse(Size.Width / presize.Width)
                Dim bm_src As New Bitmap(PictureBox1.Image)
                Dim bm_dest As New Bitmap(
                    CInt(bm_src.Width * scale_factor),
                    CInt(bm_src.Height * scale_factor))
                Dim gr_dest As Graphics = Graphics.FromImage(bm_dest)

                gr_dest.DrawImage(bm_src, 0, 0,
                                  bm_dest.Width + 1,
                                  bm_dest.Height + 1)
                PictureBox1.Image = bm_dest

            End If
            If Me.Size.Width = PictureBox1.Image.Width + 9 Then
                If Me.Size.Height = PictureBox1.Image.Height + 57 Then
                    ResizeToPhysicalResolutionToolStripMenuItem.Enabled = False
                Else
                    ResizeToPhysicalResolutionToolStripMenuItem.Enabled = True
                End If
            Else
                ResizeToPhysicalResolutionToolStripMenuItem.Enabled = True
            End If
        Catch ex As Exception
            ESOD.Label5.Text = ex.Message
            ESOD.ShowDialog()
        End Try
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image.Save(SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MessageDialog.messageicon = "Info"
        MessageDialog.messagetext = "Image Drawer 1.1b"
        MessageDialog.messagetitle = "About"
        'MessageDialog.ff = Me
        'MessageDialog.sf = composedwindow
        MessageDialog.ShowDialog()
    End Sub

    Private Sub TutorialToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TutorialToolStripMenuItem.Click
        Docs.launchdoc(My.Resources.DrawDocs, "Image Drawer documentation")
    End Sub

    Private Sub Paintbrush_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        Label4.BackColor = Desktop.labelBg.BackColor
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

    Private Sub Paintbrush_Deactivate(sender As System.Object, e As System.EventArgs) Handles MyBase.Deactivate
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
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            If composedwindow.IsDisposed = False Then
                If Not GetActiveWindow <> composedwindow.Handle Then
                    Me.BringToFront()
                End If
            End If
        End If
        rap = False
    End Sub

    Private Sub KillTimer_Tick(sender As System.Object, e As System.EventArgs) Handles KillTimer.Tick
        If LogoffWindow.Visible = True Then
            ExitToolStripMenuItem.PerformClick()
            Exit Sub
        End If
        If Desktop.paintkill.Text = "kill" Then
            ExitToolStripMenuItem.PerformClick()
            Exit Sub
        ElseIf Lock.Visible = True Then
            Me.Hide()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Hide()
        ElseIf LogoffWindow.Visible = True Then
            ExitToolStripMenuItem.PerformClick()
            Exit Sub
        ElseIf Desktop.restorewindow.Text = "Paintbrush" Then
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

    Private Sub ExitToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        tskmgr.ListBox1.Items.Remove("Paintbrush")
        Desktop.paintkill.Text = "kill"
        Desktop.killtimer.Enabled = True
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
        ExitToolStripMenuItem.PerformClick()
    End Sub

    Private Sub GradienthorizontalToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GradienthorizontalToolStripMenuItem.Click
        If GradientToolStripMenuItem.Checked = True Then
            GradientToolStripMenuItem.Checked = False
        End If
        If GradientToolStripMenuItem.Checked = False And GradienthorizontalToolStripMenuItem.Checked = False Then
            secondcolor = pencolor
            Exit Sub
        End If
    End Sub

    Private Sub SecondaryForegroundToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SecondaryForegroundToolStripMenuItem.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            secondcolor = ColorDialog1.Color
        End If
    End Sub

    Private Sub GradientToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GradientToolStripMenuItem.Click
        If GradienthorizontalToolStripMenuItem.Checked = True Then
            GradienthorizontalToolStripMenuItem.Checked = False
        End If
        If GradientToolStripMenuItem.Checked = False And GradienthorizontalToolStripMenuItem.Checked = False Then
            secondcolor = pencolor
            Exit Sub
        End If
    End Sub

    Private Sub AddTextToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddTextToolStripMenuItem.Click
        If clicklistener = False Then
            MessageDialog.messageicon = "Info"
            MessageDialog.messagetype = "OKOnly"
            MessageDialog.messagetext = "Click on a point where you want your text to start"
            MessageDialog.messagetitle = "Image drawer text gradient"
            'MessageDialog.ff = Me
            'MessageDialog.sf = composedwindow
            MessageDialog.ShowDialog()
            clicklistener = True
            Exit Sub
        End If
        clicklistener = False
        Dim g As Graphics
        Dim img As Bitmap = PictureBox1.Image
        g = Graphics.FromImage(img)
        g.CompositingMode = Drawing2D.CompositingMode.SourceCopy
        Dim lackpen As New Drawing2D.LinearGradientBrush(PictureBox1.DisplayRectangle, pencolor, secondcolor, Drawing2D.LinearGradientMode.Horizontal)
        Dim blackpen As New Drawing2D.LinearGradientBrush(PictureBox1.DisplayRectangle, pencolor, secondcolor, Drawing2D.LinearGradientMode.Vertical)
        Dim black As New Drawing.Pen(pencolor)
        If GradienthorizontalToolStripMenuItem.Checked = True Then
            g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
            If fontdlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.TopMost = False
                InputBoxDialog.txt = "Enter text"
                InputBoxDialog.wintitle = "Add text"
                InputBoxDialog.password = False
                InputBoxDialog.ShowDialog()
                input = InputBoxDialog.finalinput
                Me.TopMost = True
                Dim gs As New Point(p.X, p.Y)
                Dim txtsize As New SizeF()
                txtsize = g.MeasureString(input, fontdlg.Font)
                Dim gradientend As New PointF With {
                    .X = txtsize.Width / 2,
                    .Y = txtsize.Height
                }
                Dim grbrush As New System.Drawing.Drawing2D.LinearGradientBrush(gs, gradientend, pencolor, secondcolor)
                g.DrawString(input, fontdlg.Font, grbrush, p.X, p.Y)
            End If
            TextBox1.Text = TextBox1.Text & vbNewLine & "Text;" & input & ";" & fontdlg.Font.FontFamily.ToString() & ";" & fontdlg.Font.Size.ToString() & ";" & p.X.ToString() & ";" & p.Y.ToString() & ";"
            PictureBox1.Image = img
            Exit Sub
        Else
            g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
            If fontdlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.TopMost = False
                InputBoxDialog.txt = "Enter text"
                InputBoxDialog.wintitle = "Add text"
                InputBoxDialog.password = False
                InputBoxDialog.ShowDialog()
                input = InputBoxDialog.finalinput
                Me.TopMost = True
                Dim gs As New Point(p.X + g.MeasureString(input, fontdlg.Font).Width / 2, p.Y)
                Dim txtsize As New SizeF()
                txtsize = g.MeasureString(input, fontdlg.Font)
                Dim gradientend As New PointF With {
                    .X = txtsize.Width,
                    .Y = txtsize.Height
                }
                Dim grbrush As New System.Drawing.Drawing2D.LinearGradientBrush(gs, gradientend, pencolor, secondcolor)
                g.DrawString(input, fontdlg.Font, grbrush, p.X, p.Y)
            End If
            TextBox1.Text = TextBox1.Text & vbNewLine & "Text;" & input & ";" & fontdlg.Font.FontFamily.ToString() & ";" & fontdlg.Font.Size.ToString() & ";" & p.X.ToString() & ";" & p.Y.ToString() & ";"
            PictureBox1.Image = img
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        If clicklistener = True Then
            p = New Point(Windows.Forms.Cursor.Position.X - Me.Location.X - 6, Windows.Forms.Cursor.Position.Y - Me.Location.Y - 45)
            AddTextToolStripMenuItem.PerformClick()
            Exit Sub
        End If
    End Sub

    Private Sub Paintbrush_SizeChanged(sender As System.Object, e As System.EventArgs) Handles MyBase.SizeChanged
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            composedwindow.Size = Me.Size
        End If
    End Sub

    Private Sub Paintbrush_LocationChanged(sender As System.Object, e As System.EventArgs) Handles MyBase.LocationChanged
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            composedwindow.Location = Me.Location
        End If
    End Sub

    Private Sub Label4_BackColorChanged(sender As Object, e As EventArgs) Handles Label4.BackColorChanged
        Label3.BackColor = Label4.BackColor
        Label3.ForeColor = Label4.ForeColor
    End Sub

    Private Sub ViewDesktopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDesktopToolStripMenuItem.Click
        Me.Hide()
        composedwindow.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        ViewDesktopToolStripMenuItem.PerformClick()
    End Sub

    Public Sub Copydrawdata()
        Clipboard.SetText(TextBox1.Text, TextDataFormat.Text)
    End Sub
    Public Sub Pastedrawdata()
        Dim tempsave As String = TextBox1.Text
        TextBox1.Text = Clipboard.GetText(TextDataFormat.Text)
        TextBox1.Text = TextBox1.Text.Replace(vbNewLine, "/")
        ListBox1.Items.AddRange(TextBox1.Text.Split("/"))
        TextBox1.Text = tempsave
        For i As Integer = 0 To ListBox1.Items.Count - 1 Step 1
            If ListBox1.Items(i).ToString() = "" Then Continue For
            Dim l2 As ListBox = New ListBox()
            l2.Items.AddRange(ListBox1.Items(i).ToString().Split(";"))
            Dim type As String = l2.Items(0).ToString()
            Dim X As String = l2.Items(1).ToString()
            Dim Y As String = l2.Items(2).ToString()
            If type = "Text" Then GoTo skip
            Dim brushx As String = l2.Items(3).ToString()
            Dim brushy As Integer = l2.Items(4).ToString()
skip:
            Dim g As Graphics
            Dim img As Bitmap = PictureBox1.Image
            g = Graphics.FromImage(img)
            g.CompositingMode = Drawing2D.CompositingMode.SourceCopy
            Dim lackpen As New Drawing2D.LinearGradientBrush(PictureBox1.DisplayRectangle, pencolor, secondcolor, Drawing2D.LinearGradientMode.Horizontal)
            Dim blackpen As New Drawing2D.LinearGradientBrush(PictureBox1.DisplayRectangle, pencolor, secondcolor, Drawing2D.LinearGradientMode.Vertical)
            Dim black As New Drawing.Pen(pencolor)
            If type = "Line" Then
                g.DrawLine(black, Convert.ToInt32(X) - 1, Convert.ToInt32(Y) - 1, Convert.ToInt32(X) + Convert.ToInt32(brushx), Convert.ToInt32(Y) + brushy)
                Dim papa As String = "Line;" & X.ToString() & ";" & Y.ToString() & ";" & brushx.ToString() & ";" & brushx.ToString() & ";"
                If Not TextBox1.Text.Contains(papa) Then TextBox1.Text = TextBox1.Text & vbNewLine & papa
            ElseIf type = "Circle" Then
                Dim rect As New Rectangle(New Point(X, Y), New Size(brushx, brushy))
                Dim papa As String = "Circle;" & X.ToString() & ";" & Y.ToString() & ";" & brushx.ToString() & ";" & brushx.ToString() & ";"
                If Not TextBox1.Text.Contains(papa) Then TextBox1.Text = TextBox1.Text & vbNewLine & papa
                g.FillEllipse(lackpen, rect)
            ElseIf type = "Square" Then
                Dim rect As New Rectangle(New Point(X, Y), New Size(brushx, brushy))
                Dim papa As String = "Square;" & X.ToString() & ";" & Y.ToString() & ";" & brushx.ToString() & ";" & brushx.ToString() & ";"
                If Not TextBox1.Text.Contains(papa) Then TextBox1.Text = TextBox1.Text & vbNewLine & papa
                g.FillRectangle(lackpen, rect)
            ElseIf type = "Text" Then
                Using fnt As New Font("Segoe UI", 100, FontStyle.Regular, GraphicsUnit.Pixel)
                    TextRenderer.DrawText(g, X, fnt, New Rectangle(0, 0, PictureBox1.Width + 8, PictureBox1.Height),
                                          pencolor,
                                          TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
                End Using
            End If
            PictureBox1.Image = img
        Next
    End Sub

    Private Sub AvatarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvatarToolStripMenuItem.Click
        Size = New Size(155, 190)
    End Sub

    Private Sub GetColorToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PaintBucketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaintBucketToolStripMenuItem.Click
        If flood = False Then
            flood = True
            Exit Sub
        Else
            flood = False
        End If
    End Sub

    Private Sub ShowDrawingHistorydevToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowDrawingHistorydevToolStripMenuItem.Click
        ListBox1.Visible = True
        TextBox1.Visible = True
    End Sub

    Private Sub ResizeToPhysicalResolutionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResizeToPhysicalResolutionToolStripMenuItem.Click
        Me.Size = New Size(PictureBox1.Image.Width + 9, PictureBox1.Image.Height + 57)
        ResizeToPhysicalResolutionToolStripMenuItem.Enabled = False
    End Sub
End Class