
Public Class Notepad
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim composedwindow As Form = New Form()
    Dim CurLocation, AppLocation As New Point(0, 0)
    Dim Saved As Boolean = False
    Dim Sve As String = ""
    Dim rap As Boolean = False
    Private Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr
    Private Sub MaximizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaximizeToolStripMenuItem.Click
        WindowState = FormWindowState.Maximized
        Label1.Visible = False
        MenuStrip1.Visible = False
        Button1.Visible = True
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            composedwindow.WindowState = FormWindowState.Maximized
        End If
    End Sub

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

    Private Sub MinimizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizeToolStripMenuItem.Click
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.hideanimation(Me, composedwindow)
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

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
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
                composedwindow.Top = Me.Top
                composedwindow.Left = Me.Left
            End If
        End If
    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp
        drag = False
        composedwindow.BringToFront()
        Me.BringToFront()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If Desktop.usertype = "Guest" Then GoTo oclose
        Try
            ListBox1.SelectedIndex = 0
        Catch
            GoTo oclose
        End Try
        Dim data As String
        data = ListBox1.SelectedItem.ToString() & ";"
        For i As Integer = 1 To ListBox1.Items.Count - 1
            ListBox1.SelectedIndex = i
            data = data & ListBox1.SelectedItem.ToString() & ";"
        Next
        My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & Desktop.user & "_notepad.txt", data, False)
oclose:
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            Form1.fadeout_animation(Me, composedwindow)
            Exit Sub
        Else
            Close()
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        RichTextBox1.Font = RichTextBox2.Font
        RichTextBox1.Text = ""
        RichTextBox1.BackColor = Color.White
        RichTextBox1.ForeColor = Color.Black
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        If FontDialog1.ShowDialog = DialogResult.OK Then
            RichTextBox1.SelectionFont = FontDialog1.Font
        Else
            Exit Sub
        End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        MediaPlay.TopMost = False
        New_name_password.TopMost = False
        tskmgr.TopMost = False
        WebBrowser.TopMost = False
        TopMost = False
        PictureViewer.TopMost = False
        Dim fx As FileExplorer = New FileExplorer With {
            .displaytype = "load",
            .filename = ""
        }
        fx.Setfilter("*.rtf", "Rich Text Format")
        fx.Setfilter("*.txt", "Plain Text Documents")
        fx.Setfilter("*.bat;*.cmd", "Batch files")
        fx.TextBox1.Text = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\" & Desktop.user & "\Documents"
        fx.Button1.PerformClick()
        If fx.ShowDialog = DialogResult.OK Then
            If fx.filename.EndsWith(".rtf") Then RichTextBox1.LoadFile(fx.filename)
            If fx.filename.EndsWith(".txt") Or fx.filename.EndsWith(".cmd") Or fx.filename.EndsWith(".bat") Then RichTextBox1.LoadFile(fx.filename, RichTextBoxStreamType.PlainText)
            MediaPlay.TopMost = True
            New_name_password.TopMost = True
            tskmgr.TopMost = True
            WebBrowser.TopMost = True
            TopMost = True
            ListBox1.Items.Add(fx.filename)
            OpenRecentToolStripMenuItem.DropDownItems.Add(fx.filename)
        Else
            MediaPlay.TopMost = True
            New_name_password.TopMost = True
            tskmgr.TopMost = True
            WebBrowser.TopMost = True
            TopMost = True
            PictureViewer.TopMost = True
            Exit Sub
        End If
    End Sub

    Private Sub TextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            RichTextBox1.SelectionColor = ColorDialog1.Color
        Else
            Exit Sub
        End If
    End Sub

    Private Sub BackgroundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            RichTextBox1.BackColor = ColorDialog1.Color
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ToolStripComboBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WindowState = FormWindowState.Normal
        Label1.Visible = True
        MenuStrip1.Visible = True
        Button1.Visible = False
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            composedwindow.WindowState = FormWindowState.Normal
            composedwindow.Location = Me.Location
            composedwindow.Size = Me.Size
        End If
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        If TrackBar1.Value = 0 Then TrackBar1.Value = 1
        RichTextBox1.ZoomFactor = TrackBar1.Value / 100.0
        Label6.Text = (TrackBar1.Value / 100.0).ToString() & "x"
    End Sub

    Private Sub SaveasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveasToolStripMenuItem.Click
        Dim fx As FileExplorer = New FileExplorer With {
            .filename = ""
        }
        fx.Setfilter("*.rtf", "Rich Text Format")
        fx.Setfilter("*.txt", "Plain Text Documents")
        fx.Setfilter("*.bat", "Batch files")
        fx.TextBox1.Text = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\" & Desktop.user & "\Documents"
        fx.Button1.PerformClick()
        fx.displaytype = "save"
        If fx.ShowDialog = DialogResult.OK Then
            RichTextBox1.SaveFile(fx.TextBox1.Text & "\" & fx.FileNameText.Text, RichTextBoxStreamType.RichText)
            Sve = fx.TextBox1.Text & "\" & fx.FileNameText.Text
            Saved = True
        Else
            Exit Sub
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If Not Saved Then
            Dim fx As FileExplorer = New FileExplorer With {
                .filename = ""
            }
            fx.Setfilter("*.rtf", "Rich Text Format")
            fx.Setfilter("*.txt", "Plain Text Documents")
            fx.Setfilter("*.bat", "Batch files")
            fx.TextBox1.Text = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\" & Desktop.user & "\Documents"
            fx.Button1.PerformClick()
            fx.displaytype = "save"
            If fx.ShowDialog = DialogResult.OK Then
                RichTextBox1.SaveFile(fx.TextBox1.Text & "\" & fx.FileNameText.Text, RichTextBoxStreamType.RichText)
                If Sve = "" Then Sve = fx.TextBox1.Text & "\" & fx.FileNameText.Text
            Else
                Exit Sub
            End If
        Else
            Saved = True
            RichTextBox1.SaveFile(Sve, RichTextBoxStreamType.RichText)
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageDialog.composedwindow.BringToFront()
        MessageDialog.messagetitle = "About"
        MessageDialog.messagetext = "Rich Text Notepad 1.0a"
        MessageDialog.messageicon = "Info"
        'MessageDialog.ff = Me
        'MessageDialog.sf = composedwindow
        MessageDialog.ShowDialog()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.hideanimation(Me, composedwindow)
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Hide()
    End Sub

    Private Sub WordWrapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordWrapToolStripMenuItem.Click
        If RichTextBox1.WordWrap = True Then
            RichTextBox1.WordWrap = False
            WordWrapToolStripMenuItem.Checked = False
        Else
            RichTextBox1.WordWrap = True
            WordWrapToolStripMenuItem.Checked = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If Desktop.alldown Then
            'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
            Close()
        End If
    End Sub

    Private Sub Notepad_VisibleChanged(sender As Object, e As System.EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            Form1.Setfont(Me, Label1, Label3)
            Label1.BackColor = Desktop.labelBg.BackColor
            Label1.ForeColor = Desktop.labelFg.BackColor
            Label3.BackColor = Desktop.labelBg.BackColor
            Label3.ForeColor = Desktop.labelFg.BackColor
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then
                Me.BackColor = Desktop.appBg.BackColor
                Me.TransparencyKey = Nothing
                GoTo wow
            Else
                Form1.Translucency(Me, composedwindow, True)
            End If
wow:
            Me.ForeColor = Desktop.appFg.BackColor
        End If
    End Sub

    Private Sub TerminateTimer_Tick(sender As System.Object, e As System.EventArgs) Handles TerminateTimer.Tick
        If LogoffWindow.Visible = True Then
            ExitToolStripMenuItem.PerformClick()
        ElseIf Desktop.NotepadKill.Text = "kill" Then
            ExitToolStripMenuItem.PerformClick()
        ElseIf Lock.Visible = True Then
            Me.Hide()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Hide()
        ElseIf Desktop.restorewindow.Text = "Rich Text Notepad" Then
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

    Private Sub OpenRecentToolStripMenuItem_DropDownItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles OpenRecentToolStripMenuItem.DropDownItemClicked
        If e.ClickedItem.ToString().EndsWith(".rtf") Then
            RichTextBox1.LoadFile(e.ClickedItem.ToString(), RichTextBoxStreamType.RichText)
            Exit Sub
        Else
            RichTextBox1.LoadFile(e.ClickedItem.ToString(), RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Private Sub Notepad_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Opacity = 1.0
        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & Desktop.user & "_notepad.txt") Then
            Dim lolo As String
            lolo = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & Desktop.user & "_notepad.txt")
            ListBox1.Items.AddRange(lolo.Split(";"))
            ListBox1.SelectedIndex = ListBox1.Items.Count - 1
            If Not ListBox1.SelectedItem.ToString() = "" Then OpenRecentToolStripMenuItem.DropDownItems.Add(ListBox1.SelectedItem.ToString())
            For i As Integer = ListBox1.Items.Count - 1 To 0 Step -1
                ListBox1.SelectedIndex = i
                If Not ListBox1.SelectedItem.ToString() = "" Then OpenRecentToolStripMenuItem.DropDownItems.Add(ListBox1.SelectedItem.ToString())
            Next
        End If
    End Sub

    Private Sub FileToolStripMenuItem_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles FileToolStripMenuItem.MouseMove
        If OpenRecentToolStripMenuItem.HasDropDownItems = False Then
            OpenRecentToolStripMenuItem.Visible = False
        Else
            OpenRecentToolStripMenuItem.Visible = True
        End If
    End Sub

    Private Sub Notepad_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
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

    Private Sub Notepad_Deactivate(sender As System.Object, e As System.EventArgs) Handles MyBase.Deactivate
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
        If composedwindow.IsDisposed = False Then
            If Not GetActiveWindow <> composedwindow.Handle Then
                Me.BringToFront()
            End If
        End If
        rap = False
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        tskmgr.ListBox1.Items.Remove("Rich Text Notepad")
        Desktop.NotepadKill.Text = "kill"
        Desktop.killtimer.Enabled = True
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
        ExitToolStripMenuItem.PerformClick()
    End Sub


    Private Sub OpenRecentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenRecentToolStripMenuItem.Click

    End Sub

    Private Sub WYSIWYGSystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WYSIWYGSystemToolStripMenuItem.Click
        If WYSIWYGSystemToolStripMenuItem.Checked = False Then
            RichTextBox1.Location = New Point(0, RichTextBox1.Location.Y)
            RichTextBox1.Size = New Size(Me.Width, RichTextBox1.Height)
            Label2.BackColor = RichTextBox1.BackColor
        ElseIf WYSIWYGSystemToolStripMenuItem.Checked = True Then
            RichTextBox1.Size = New Size(RichTextBox1.Width / 8 * 5, RichTextBox1.Height)
            RichTextBox1.Location = New Point(Me.Width - (RichTextBox1.Width + RichTextBox1.Width / 3), RichTextBox1.Location.Y)
            Label2.BackColor = Color.DimGray

        End If
    End Sub

    Private Sub Label1_DoubleClick(sender As Object, e As EventArgs) Handles Label1.DoubleClick
        MaximizeToolStripMenuItem.PerformClick()
    End Sub

    Private Sub RichTextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles RichTextBox1.KeyUp
        Dim yo() As String = RichTextBox1.Text.Split(" ")
        Label5.Text = yo.Length.ToString() & " word(s), " & RichTextBox1.Lines.Length.ToString() & " line(s), " & RichTextBox1.Text.Length.ToString() & " character(s)"
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        Dim yo() As String = RichTextBox1.Text.Split(" ")
        Label5.Text = yo.Length.ToString() & " word(s), " & RichTextBox1.Lines.Length.ToString() & " line(s), " & RichTextBox1.Text.Length.ToString() & " character(s)"
    End Sub

    Private Sub DocumentationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentationToolStripMenuItem.Click
        Docs.launchdoc(My.Resources.NotepadDocs, "Rich text notepad documentation")
    End Sub
End Class