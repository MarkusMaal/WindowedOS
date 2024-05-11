Public Class WebBrowser
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim CurLocation, AppLocation As New Point(0, 0)
    Dim rap As Boolean = False
    Dim homepage As String = "http://www.google.com"
    ReadOnly composedwindow As Form = New Form()
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
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
        If Not Desktop.usertype = "Guest" Then
            Try
                ListBox1.SelectedIndex = 0
            Catch
                GoTo oclose
            End Try
            Dim data As String = homepage & ";"
            data = data & ListBox1.SelectedItem.ToString() & ";"
            For i As Integer = 1 To ListBox1.Items.Count - 1
                ListBox1.SelectedIndex = i
                data = data & ListBox1.SelectedItem.ToString() & ";"
            Next
            My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & Desktop.user & "_browser.txt", data, False)
oclose:
        End If
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then
            Close()
        Else
            Form1.fadeout_animation(Me, composedwindow)
        End If
    End Sub

    Private Sub GoBackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoBackToolStripMenuItem.Click
        If WebBrowser1.CanGoBack = True Then
            WebBrowser1.GoBack()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub GoForwardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoForwardToolStripMenuItem.Click
        If WebBrowser1.CanGoForward = True Then
            WebBrowser1.GoForward()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub StopNavigationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopNavigationToolStripMenuItem.Click
        WebBrowser1.Stop()
    End Sub

    Private Sub HomePageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomePageToolStripMenuItem.Click
        WebBrowser1.Navigate(homepage)
    End Sub

    Private Sub FullScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FullScreenToolStripMenuItem.Click
        composedwindow.WindowState = FormWindowState.Maximized
        MenuStrip1.Visible = False
        WindowState = FormWindowState.Maximized
        Button2.Visible = True
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
    End Sub

    Private Sub ShowDesktopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowDesktopToolStripMenuItem.Click
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.hideanimation(Me, composedwindow)
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Hide()
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

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageDialog.messagetitle = "About"
        MessageDialog.messagetext = "Web Explorer 1.0a"
        MessageDialog.messageicon = "Info"
        'MessageDialog.ff = Me
        'MessageDialog.sf = composedwindow
        MessageDialog.ShowDialog()
    End Sub

    Private Sub WebBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Opacity = 1.0
        If Not Desktop.usertype = "Guest" Then
            If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & Desktop.user & "_browser.txt") Then
                Dim lst As String = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & Desktop.user & "_browser.txt")
                Dim lstbox As ListBox
                lstbox = New ListBox
                lstbox.Items.AddRange(lst.Split(";"))
                lstbox.SelectedIndex = 0
                homepage = lstbox.SelectedItem
                WebBrowser1.Navigate(homepage)
                lstbox.SelectedIndex = lstbox.Items.Count - 1
                If Not lstbox.SelectedItem = "" Then HistoryToolStripMenuItem.DropDownItems.Add(lstbox.SelectedItem)
                For i As Integer = ListBox1.Items.Count - 1 To 1 Step -1
                    lstbox.SelectedIndex = i
                    If Not lstbox.SelectedItem.ToString() = "" Then HistoryToolStripMenuItem.DropDownItems.Add(lstbox.SelectedItem)
                Next
            End If
        End If
        WebBrowser1.Navigate(homepage)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MenuStrip1.Visible = True
        composedwindow.WindowState = FormWindowState.Normal
        WindowState = FormWindowState.Normal
        Button2.Visible = False
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs)
        Label1.Text = "Web Explorer - " & WebBrowser1.DocumentTitle
        TextBox1.Text = WebBrowser1.Url.AbsoluteUri
        HistoryToolStripMenuItem.DropDownItems.Add(WebBrowser1.Url.AbsoluteUri)
        ListBox1.Items.Add(WebBrowser1.Url.AbsoluteUri)
    End Sub

    Private Sub Label2_MouseMove(sender As Object, e As MouseEventArgs) Handles Label2.MouseMove

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.hideanimation(Me, composedwindow)
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub WebBrowser1_Navigating(ByVal sender As Object, ByVal e As WebBrowserNavigatingEventArgs)
        Label1.Text = "Web Explorer - Loading..."
    End Sub

    Private Sub WebBrowser1_Navigated(ByVal sender As Object, ByVal e As WebBrowserNavigatedEventArgs)
        Label1.Text = "Web Explorer - Finalizing document..."

    End Sub

    Private Sub LoadTimer_Tick(sender As Object, e As EventArgs) Handles LoadTimer.Tick
        Label1.Text = "Web Explorer - " & WebBrowser1.DocumentTitle
    End Sub

    Private Sub WebBrowser1_ProgressChanged(ByVal sender As Object, ByVal e As WebBrowserProgressChangedEventArgs)
        Try
            ProgressBar1.Value = e.CurrentProgress
        Catch ex As Exception
            ProgressBar1.Value = 100
        End Try
        If ProgressBar1.Value = 100 Then
            Label1.Text = "Web Explorer - " & WebBrowser1.DocumentTitle
            Exit Sub
        End If
        Label1.Text = "Web Explorer - Loading... (" & ProgressBar1.Value & "% complite)"
    End Sub

    Private Sub WebBrowser_VisibleChanged(sender As Object, e As System.EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            Form1.Setfont(Me, Label1, Label3)
            Label1.BackColor = Desktop.labelBg.BackColor
            Label1.ForeColor = Desktop.labelFg.BackColor
            Label3.BackColor = Desktop.labelBg.BackColor
            Label3.ForeColor = Desktop.labelFg.BackColor
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then
                Me.BackColor = Desktop.appBg.BackColor
            Else
                Form1.translucency(Me, composedwindow, True)
            End If
            Me.ForeColor = Desktop.appFg.BackColor
            TextBox1.BackColor = Desktop.appBg.BackColor
            TextBox1.ForeColor = Desktop.appFg.BackColor
            Label2.BackColor = Me.BackColor
            Button1.BackColor = Me.BackColor
            Button2.BackColor = Me.BackColor
        End If
    End Sub

    Private Sub TerminateTimer_Tick(sender As System.Object, e As System.EventArgs) Handles TerminateTimer.Tick
        If Desktop.WebBrowserKill.Text = "kill" Then
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Close()
            Me.Close()
        ElseIf LogoffWindow.Visible = True Then
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Close()
            Me.Close()
        ElseIf Lock.Visible = True Then
            Me.Hide()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Hide()
        ElseIf Desktop.restorewindow.Text = "Web Explorer" Then
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
            Form1.fadeout_animation(Me, composedwindow)
        End If
        If Me.Visible = True Then
            If CustomizationCenter.ApplyTheme.Enabled = True Then
                composedwindow.Hide()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub WebBrowser_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
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

    Private Sub WebBrowser_Deactivate(sender As System.Object, e As System.EventArgs) Handles MyBase.Deactivate
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

    Private Sub ExitToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        tskmgr.ListBox1.Items.Remove("Web Explorer")
        Desktop.WebBrowserKill.Text = "kill"
        Desktop.killtimer.Enabled = True
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
        ExitToolStripMenuItem.PerformClick()
    End Sub

    Private Sub EditToolStripMenuItem_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles EditToolStripMenuItem.MouseMove
        If HistoryToolStripMenuItem.HasDropDownItems = False Then
            HistoryToolStripMenuItem.Visible = False
        Else
            HistoryToolStripMenuItem.Visible = True
        End If
    End Sub

    Private Sub HistoryToolStripMenuItem_DropDownItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles HistoryToolStripMenuItem.DropDownItemClicked
        WebBrowser1.Navigate(e.ClickedItem.Text)
    End Sub

    Private Sub SetAsHomepageToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SetAsHomepageToolStripMenuItem.Click
        homepage = WebBrowser1.Url.AbsoluteUri
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class