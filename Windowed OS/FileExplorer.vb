Imports System.IO
Public Class FileExplorer
    Dim lvi As ListViewItem
    Dim myIco As Icon
    Dim exts As New List(Of String)
    Dim dir As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\" & Desktop.user
    Public pubdir As String = dir
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Public displaytype As String = "full"
    Public filename As String = "*.*"
    Public filetype As String = "All files"
    Dim filter As String = "*.*"
    Dim clipboard As String = ""
    Dim cpf As String = ""
    Dim cut As Boolean = False
    Dim composedwindow As Form = New Form()
    Dim rap As Boolean = False
    Private Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr
    Dim CurLocation, AppLocation As New Point(0, 0)
    Private Sub FileExplorer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        composedwindow.Opacity = 0.0
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then
            Me.TransparencyKey = Nothing
            Me.Opacity = 1.0
        End If
        If displaytype = "load" Then
            dir = pubdir
            ComboBox2.SelectedIndex = 1
            ComboBox2.SelectedIndex = 0
            ComboBox2.SelectedIndex = 1
            ComboBox2.SelectedIndex = 0
            FileNameText.Text = filter
            FileNameText.Visible = True
            Label1.Visible = False
            fnInfo.Visible = False
            fsInfo.Visible = False
            Label2.Visible = False
            FileNameText.Visible = True
            ComboBox2.Visible = True
            Button2.Visible = True
            Button3.Visible = True
        ElseIf displaytype = "save" Then
            dir = pubdir
            ComboBox2.SelectedIndex = 1
            ComboBox2.SelectedIndex = 0
            ComboBox2.SelectedIndex = 1
            ComboBox2.SelectedIndex = 0
            FileNameText.Text = filter
            FileNameText.Visible = True
            Label1.Visible = False
            fnInfo.Visible = False
            fsInfo.Visible = False
            Label2.Visible = False
            FileNameText.Visible = True
            ComboBox2.Visible = True
            Button2.Visible = True
            Button3.Visible = True
        End If
        If displaytype = "full" Then
            If Not Directory.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\" & Desktop.user & "\Documents") Then
                Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\" & Desktop.user)
                Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\" & Desktop.user & "\Documents")
            End If
            Label1.Visible = True
            fnInfo.Visible = True
            fsInfo.Visible = True
            Label2.Visible = True
            FileNameText.Visible = False
            ComboBox2.Visible = False
            Button2.Visible = False
            Button3.Visible = False
        End If
        TextBox1.Text = dir
        ListView1.View = View.Details
        ComboBox1.SelectedIndex = 0
        Button1.PerformClick()
    End Sub


    Private Sub Sync()
        CurLocation = Cursor.Position
        AppLocation = Size
    End Sub

    Private Sub Label2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label5.MouseDown
        ResizeTimer.Start()
        Sync()
    End Sub

    Private Sub Label2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label5.MouseUp
        ResizeTimer.Stop()
        Sync()
        composedwindow.BringToFront()
        Me.BringToFront()
    End Sub

    Private Sub ResizeTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ResizeTimer.Tick
        Size = AppLocation - CurLocation + Cursor.Position
        composedwindow.Size = Size
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

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Desktop.KillSignal.Text = "File Explorer"
    End Sub

    Private Sub FileExplorer_VisibleChanged(sender As System.Object, e As System.EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible = True Then
            Form1.Setfont(Me, Label4, Label3)
            Label4.BackColor = Desktop.labelBg.BackColor
            Label4.ForeColor = Desktop.labelFg.BackColor
            Label3.BackColor = Label4.BackColor
            Label3.ForeColor = Label4.ForeColor
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.BackColor = Desktop.appBg.BackColor
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.Translucency(Me, composedwindow, True)
            composedwindow.TopMost = True
            composedwindow.BringToFront()
            Me.BringToFront()
            Label5.BackColor = Me.BackColor
            Me.ForeColor = Desktop.appFg.BackColor
        End If
    End Sub

    Private Sub SplitContainer3_SplitterMoved(sender As System.Object, e As System.Windows.Forms.SplitterEventArgs) Handles SplitContainer3.SplitterMoved

    End Sub

    Private Sub TextBox1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            ListView1.View = View.Details
        ElseIf ComboBox1.SelectedIndex = 1 Then
            ListView1.View = View.SmallIcon
        ElseIf ComboBox1.SelectedIndex = 2 Then
            ListView1.View = View.LargeIcon
        ElseIf ComboBox1.SelectedIndex = 3 Then
            ListView1.View = View.List
        ElseIf ComboBox1.SelectedIndex = 4 Then
            ListView1.View = View.Tile
        End If
    End Sub

    Private Sub ListView1_ItemActivate(sender As System.Object, e As System.EventArgs) Handles ListView1.ItemActivate
        If ListView1.SelectedItems(0).SubItems(1).Text = "N/A" Then
            TextBox1.Text = TextBox1.Text & "\" & ListView1.SelectedItems(0).Text
            Button1.PerformClick()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ListView2_ItemActivate(sender As System.Object, e As System.EventArgs) Handles ListView2.ItemActivate
        If ListView2.SelectedItems(0).Text = "My Documents" Then
            TextBox1.Text = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\" & Desktop.user & "\Documents"
            Button1.PerformClick()
        ElseIf ListView2.SelectedItems(0).Text = "Root" Then
            TextBox1.Text = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData
            Button1.PerformClick()
        ElseIf ListView2.SelectedItems(0).Text = "Host Filesystem" Then
            TextBox1.Text = "C:\"
            Button1.PerformClick()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ListView1.Items.Clear()
        dir = TextBox1.Text
        Dim di As New DirectoryInfo(dir)
        Try
            For Each fi As DirectoryInfo In di.EnumerateDirectories("*")
                lvi = New ListViewItem With {
                    .Text = fi.Name
                }
                lvi.SubItems.Add("N/A")
                'lvi.SubItems.Add(((fi.Length / 1024)).ToString("0.00"))
                lvi.SubItems.Add(fi.CreationTime.ToShortDateString)
                FileImages.Images.Add("*", My.Resources.folder)
                ImageList2.Images.Add("*", My.Resources.folder)
                exts.Add(fi.Extension)
                lvi.ImageIndex = 0
                ListView1.Items.Add(lvi)
            Next
        Catch ex As Exception
            MessageDialog.messageicon = "Error"
            MessageDialog.messagetext = ex.Message
            MessageDialog.messagetitle = "Error"
            MessageDialog.messagetype = "OKOnly"
            MessageDialog.ShowDialog()
            Exit Sub
        End Try
        For Each fi As FileInfo In di.EnumerateFiles(filter)
            lvi = New ListViewItem With {
                .Text = fi.Name
            }
            lvi.SubItems.Add(((fi.Length / 1024)).ToString("0.00"))
            lvi.SubItems.Add(fi.CreationTime.ToShortDateString)

            'If exts.Contains(fi.Extension) = False Then
            Try
                myIco = Icon.ExtractAssociatedIcon(fi.FullName)
                FileImages.Images.Add(fi.Extension, myIco)
                ImageList2.Images.Add(fi.Extension, myIco)
                exts.Add(fi.Extension)
            Catch
                FileImages.Images.Add(fi.Extension, My.Resources.docs)
                ImageList2.Images.Add(fi.Extension, My.Resources.docs)
                exts.Add(fi.Extension)
            End Try
            'End If
            If displaytype = "full" Then Label4.Text = "Exploring '" & dir & "'"
            If displaytype = "load" Then Label4.Text = "Load - '" & dir & "'"
            If displaytype = "save" Then Label4.Text = "Save as - '" & dir & "'"
            lvi.ImageKey = fi.Extension
            ListView1.Items.Add(lvi)
        Next
    End Sub

    Private Sub UpToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UpToolStripMenuItem.Click
        Dim LstBox As ListBox = New ListBox()
        LstBox.Items.AddRange(TextBox1.Text.Split("\"))
        TextBox1.Text = ""
        For i = 0 To LstBox.Items.Count - 2
            LstBox.SelectedIndex = i
            If Not i = LstBox.Items.Count - 2 Then
                TextBox1.Text = TextBox1.Text & LstBox.SelectedItem.ToString & "\"
            Else
                TextBox1.Text = TextBox1.Text & LstBox.SelectedItem.ToString
            End If
        Next
        Button1.PerformClick()
    End Sub

    Private Sub ListView1_ItemSelectionChanged(sender As System.Object, e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles ListView1.ItemSelectionChanged
        Try
            If ListView1.SelectedItems(0).SubItems(1).Text = "N/A" Then
                fnInfo.Text = "Name: " & ListView1.SelectedItems(0).Text
                fsInfo.Text = "Size: " & ListView1.SelectedItems(0).SubItems(1).Text
                Label2.Text = "Type: File folder"
                Exit Sub
            Else
                fnInfo.Text = "Name: " & ListView1.SelectedItems(0).Text
                If displaytype = "save" Or displaytype = "load" Then FileNameText.Text = ListView1.SelectedItems(0).Text
                fsInfo.Text = "Size: " & ListView1.SelectedItems(0).SubItems(1).Text
                Label2.Text = "Type: File"
            End If
        Catch
        End Try
    End Sub

    Private Sub ViewDesktopToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewDesktopToolStripMenuItem.Click
        composedwindow.Hide()
        Me.Hide()
    End Sub

    Private Sub FileExplorer_Deactivate(sender As System.Object, e As System.EventArgs) Handles MyBase.Deactivate
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

    Private Sub FileExplorer_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        Label4.BackColor = Desktop.labelBg.BackColor
        Form1.ThemeFix(Me, Label3)
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

    Private Sub TerminateTimer_Tick(sender As System.Object, e As System.EventArgs) Handles TerminateTimer.Tick
        If LogoffWindow.Visible = True Then
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Close()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.fadeout_animation(Me, composedwindow)
        ElseIf Lock.Visible = True Then
            Me.Hide()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Hide()
        ElseIf Desktop.KillSignal.Text = "File Explorer" Then
            'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Close()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.fadeout_animation(Me, composedwindow)
        ElseIf Desktop.restorewindow.Text = "File Explorer" Then
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

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        ExitToolStripMenuItem.PerformClick()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If Label2.Text = "Type: File folder" Then
            TextBox1.Text = TextBox1.Text & "\" & fnInfo.Text.Replace("Name: ", "")
            Button1.PerformClick()
            Exit Sub
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
        If displaytype = "save" Then
            If File.Exists(TextBox1.Text & "\" & FileNameText.Text) Then
                MessageDialog.messageicon = "Warning"
                MessageDialog.messagetitle = "File already exists"
                MessageDialog.messagetext = "This file already exists. Would you like to overwrite this file"
                MessageDialog.messagetype = "YesNo"
                If MessageDialog.ShowDialog = Windows.Forms.DialogResult.No Then
                    Button3.PerformClick()
                    Exit Sub
                Else
                    ExitToolStripMenuItem.PerformClick()
                    Exit Sub
                End If
            End If
        End If
        filename = TextBox1.Text & "\" & FileNameText.Text
        ExitToolStripMenuItem.PerformClick()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        FilterList.SelectedIndex = ComboBox2.SelectedIndex
        filter = FilterList.SelectedItem.ToString()
        Button1.PerformClick()
    End Sub

    Private Sub FilterList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FilterList.SelectedIndexChanged
        DescList.SelectedIndex = FilterList.SelectedIndex
    End Sub

    'adds filters
    Public Sub Setfilter(ByVal f As String, ByVal desc As String)
        FilterList.Items.Add(f)
        DescList.Items.Add(desc)
        ComboBox2.Items.Add(desc & " (" & f & ")")
    End Sub

    Private Sub SplitContainer2_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer2.Panel2.Paint

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageDialog.messageicon = "Info"
        MessageDialog.messagetext = "File Explorer 1.1e"
        MessageDialog.messagetitle = "About"
        MessageDialog.messagetype = "OKOnly"
        composedwindow.TopMost = False
        Me.TopMost = False
        MessageDialog.ShowDialog()
        composedwindow.TopMost = True
        Me.TopMost = True
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        clipboard = TextBox1.Text & "\" & fnInfo.Text.Replace("Name: ", "")
        cpf = fnInfo.Text.Replace("Name: ", "")
        cut = False
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        If clipboard = "" Then
            MessageDialog.messageicon = "Critical"
            MessageDialog.messagetext = "Clipboard is empty"
            MessageDialog.messagetitle = "Can't paste a file"
            MessageDialog.messagetype = "OKOnly"
            composedwindow.TopMost = False
            Me.TopMost = False
            MessageDialog.ShowDialog()
            composedwindow.TopMost = True
            Me.TopMost = True
        End If
        If File.Exists(TextBox1.Text & "\" & cpf) Then
            MessageDialog.messageicon = "Warning"
            MessageDialog.messagetext = "This file already exists. Overwrite?"
            MessageDialog.messagetitle = "Dangerous operation"
            MessageDialog.messagetype = "OKOnly"
            composedwindow.TopMost = False
            Me.TopMost = False
            If MessageDialog.ShowDialog = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If
        File.Copy(clipboard, TextBox1.Text & "\" & cpf, True)
        If cut = True Then
            File.Delete(clipboard)
        End If
        Button1.PerformClick()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        File.Delete(TextBox1.Text & "\" & fnInfo.Text.Replace("Name: ", ""))
        Button1.PerformClick()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.fadeout_animation(Me, composedwindow)
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        clipboard = TextBox1.Text & "\" & fnInfo.Text.Replace("Name: ", "")
        cpf = fnInfo.Text.Replace("Name: ", "")
        cut = True
    End Sub

    Private Sub WaitForAnimation_Tick(sender As Object, e As EventArgs) Handles WaitForAnimation.Tick
        If Form1.dotick = True Then
            Form1.dotick = False
            TerminateTimer.Enabled = True
            WaitForAnimation.Enabled = False
        End If
    End Sub

    Private Sub Label4_BackColorChanged(sender As Object, e As EventArgs) Handles Label4.BackColorChanged
        Label3.BackColor = Label4.BackColor
        Label3.ForeColor = Label4.ForeColor
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        ViewDesktopToolStripMenuItem.PerformClick()
    End Sub
End Class