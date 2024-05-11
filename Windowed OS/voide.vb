Public Class voide
    Dim drag As Boolean
    Dim mousey As Integer
    Dim mousex As Integer
    Dim CurLocation, AppLocation As New Point(0, 0)
    Dim composedwindow As Form = New Form()
    Dim rap As Boolean = False
    Dim ofd As SaveFileDialog = New SaveFileDialog()
    Public hideopen As Boolean = False
    Public dopf As OpenFileDialog = New OpenFileDialog()
    Private Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr
    'standard code for theming
    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label4.MouseDown
        drag = True
        mousex = Cursor.Position.X - Left
        mousey = Cursor.Position.Y - Top
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label4.MouseMove
        If drag Then
            Top = Cursor.Position.Y - mousey
            Left = Cursor.Position.X - mousex
            composedwindow.Left = Left
            composedwindow.Top = Top
        End If
    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label4.MouseUp
        drag = False
        composedwindow.BringToFront()
        Me.BringToFront()
    End Sub

    Private Sub Voide_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
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
    Private Sub TerminateTimer_Tick(sender As System.Object, e As System.EventArgs) Handles TerminateTimer.Tick
        If LogoffWindow.Visible = True Then
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Close()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.fadeout_animation(Me, composedwindow)
        ElseIf Lock.Visible = True Then
            Me.Hide()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Hide()
        ElseIf Desktop.restorewindow.Text = "Voide IDE" Then
            Me.Opacity = 1.0
            composedwindow.Opacity = 0.9
            Me.Show()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Show()
        ElseIf Desktop.KillSignal.Text = "Voide IDE" Then
            'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Close()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.fadeout_animation(Me, composedwindow)
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

    Private Sub Voide_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
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

    Private Sub Voide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Opacity = 1.0
        ComboBox1.SelectedIndex = ComboBox1.Items.Count - 1
        ComboBox2.SelectedIndex = 6
    End Sub

    Private Sub Voide_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible = True Then
            Form1.Setfont(Me, Label4, Label12)
            Label4.BackColor = Desktop.labelBg.BackColor
            Label4.ForeColor = Desktop.labelFg.BackColor
            Label12.BackColor = Label4.BackColor
            Label12.ForeColor = Label4.ForeColor
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.BackColor = Desktop.appBg.BackColor
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.translucency(Me, composedwindow, True)
            Me.ForeColor = Desktop.appFg.BackColor
            FlowLayoutPanel1.BackColor = Me.BackColor
            FlowLayoutPanel2.BackColor = Me.BackColor
            TabPage3.BackColor = Me.BackColor
            MainForm.BackColor = Desktop.labelBg.BackColor
            MainForm.ForeColor = Desktop.labelFg.BackColor
            SplitContainer2.Panel1.BackColor = Desktop.appBg.BackColor
            SplitContainer2.Panel1.ForeColor = Desktop.appFg.BackColor
            Label5.BackColor = Me.BackColor
            'If Desktop.dev = True Then ListBox2.Visible = True
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.fadeout_animation(Me, composedwindow)
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Close()
    End Sub

    Private Sub SaveProjectToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SaveProjectToolStripMenuItem2.Click
        ofd.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\" & Desktop.user
        ofd.Filter = "Windowed Packaging Format|*.wpk"
        If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim code As String
            code = "$CODE:0.0" & "_"
            code = code & TextBox1.Text.Replace("_", "{underscore}")
            code = code & "_" & "$DESIGN:0.0" & "_"
            For i As Integer = 0 To ListBox1.Items.Count - 1
                ListBox1.SelectedIndex = i
                code = code & ListBox1.SelectedItem.ToString() & ";" & ListBox2.SelectedItem.ToString() & "_"
            Next
            code = code & "_" & "$PACKAGE:0.0" & "_"
            code = code & "Name=" & TextBox2.Text & "_"
            code = code & "Description=" & TextBox3.Text & "_"
            If iconlabel.Text.StartsWith("system_") Then
                code = code & "Icon=system-" & ComboBox1.Text
            Else
                code = code & "Icon=" & iconlabel.Text
            End If
            code = code & "_" & "Category=" & ComboBox2.Text & "_"
            code = code & "PermissionControl="
            If powerchk.Checked = True Then code = code & "power"
            If adminchk.Checked = True Then code = code & "admin"
            If standardchk.Checked = True Then code = code & "standard"
            If limitedchk.Checked = True Then code = code & "limited"
            If guestchk.Checked = True Then code = code & "guest"
            My.Computer.FileSystem.WriteAllText(ofd.FileName, code, False)
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox2.SelectedIndex = ListBox1.SelectedIndex
        Dim djbox As ListBox = New ListBox()
        Try
            djbox.Items.AddRange(ListBox2.SelectedItem.ToString().Split(";"))
        Catch
            Label10.Text = "Selected object: Nothing (none)"
            Exit Sub
        End Try
        djbox.SelectedIndex = 0
        Dim objtype As String
        objtype = djbox.SelectedItem.ToString()
        Label10.Text = "Selected object: " & ListBox1.SelectedItem.ToString() & " (" & objtype & ")"
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If Not ListBox1.SelectedItem = "MainForm" Or ListBox1.SelectedItem = "MenuBar" Then
            For Each o As Control In SplitContainer2.Panel1.Controls
                If o.Name = ListBox1.SelectedItem.ToString() Then
                    SplitContainer2.Panel1.Controls.Remove(o)
                End If
            Next
            ListBox2.Items.Remove(ListBox2.SelectedItem.ToString())
            ListBox1.Items.Remove(ListBox1.SelectedItem.ToString())
        Else
        MessageDialog.messageicon = "Critical"
        MessageDialog.messagetext = "This object cannot be removed"
        MessageDialog.messagetitle = "Object deletion error"
        MessageDialog.messagetype = "OKOnly"
        MessageDialog.ShowDialog()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        composedwindow.TopMost = False
        Me.TopMost = False
        AddObj.ShowDialog()
        composedwindow.TopMost = True
        Me.TopMost = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim fx As FileExplorer = New FileExplorer With {
            .displaytype = "load",
            .filename = ""
        }
        fx.Setfilter("*.png", "Portable Network Graphics")
        fx.Setfilter("*.bmp", "Bitmaps")
        fx.Setfilter("*.gif", "Graphics Interchangable Format")
        fx.Setfilter("*.ico", "Windows Icon")
        fx.TextBox1.Text = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        fx.Button1.PerformClick()
        If fx.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(fx.TextBox1.Text & "\" & fx.FileNameText.Text)
            iconlabel.Text = fx.TextBox1.Text & "\" & fx.FileNameText.Text
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem.ToString() = "calc" Then
            PictureBox1.Image = My.Resources.calc
            iconlabel.Text = "system_calc"
        ElseIf ComboBox1.SelectedItem.ToString() = "calc1" Then
            PictureBox1.Image = My.Resources.calc1
            iconlabel.Text = "system_calc1"
        ElseIf ComboBox1.SelectedItem.ToString() = "canvas" Then
            PictureBox1.Image = My.Resources.canvas
            iconlabel.Text = "system_canvas"
        ElseIf ComboBox1.SelectedItem.ToString() = "cmd" Then
            PictureBox1.Image = My.Resources.cmd
            iconlabel.Text = "system_cmd"
        ElseIf ComboBox1.SelectedItem.ToString() = "colors" Then
            PictureBox1.Image = My.Resources.colors
            iconlabel.Text = "system_colors"
        ElseIf ComboBox1.SelectedItem.ToString() = "copy" Then
            PictureBox1.Image = My.Resources.copy
            iconlabel.Text = "system_copy"
        ElseIf ComboBox1.SelectedItem.ToString() = "cut" Then
            PictureBox1.Image = My.Resources.cut
            iconlabel.Text = "system_cut"
        ElseIf ComboBox1.SelectedItem.ToString() = "docs" Then
            PictureBox1.Image = My.Resources.docs
            iconlabel.Text = "system_docs"
        ElseIf ComboBox1.SelectedItem.ToString() = "draw" Then
            PictureBox1.Image = My.Resources.draw
            iconlabel.Text = "system_draw"
        ElseIf ComboBox1.SelectedItem.ToString() = "error" Then
            PictureBox1.Image = My.Resources._error
            iconlabel.Text = "system_error"
        ElseIf ComboBox1.SelectedItem.ToString() = "exit" Then
            PictureBox1.Image = My.Resources._exit
            iconlabel.Text = "system_exit"
        ElseIf ComboBox1.SelectedItem.ToString() = "fonts" Then
            PictureBox1.Image = My.Resources.fonts
            iconlabel.Text = "system_fonts"
        ElseIf ComboBox1.SelectedItem.ToString() = "help" Then
            PictureBox1.Image = My.Resources.help
            iconlabel.Text = "system_help"
        ElseIf ComboBox1.SelectedItem.ToString() = "info" Then
            PictureBox1.Image = My.Resources.info
            iconlabel.Text = "system_info"
        ElseIf ComboBox1.SelectedItem.ToString() = "load" Then
            PictureBox1.Image = My.Resources.load
            iconlabel.Text = "system_load"
        ElseIf ComboBox1.SelectedItem.ToString() = "media_player" Then
            PictureBox1.Image = My.Resources.media_player
            iconlabel.Text = "system_media_player"
        ElseIf ComboBox1.SelectedItem.ToString() = "new" Then
            PictureBox1.Image = My.Resources._new
            iconlabel.Text = "system_new"
        ElseIf ComboBox1.SelectedItem.ToString() = "notepad" Then
            PictureBox1.Image = My.Resources.notepad
            iconlabel.Text = "system_notepad"
        ElseIf ComboBox1.SelectedItem.ToString() = "paste" Then
            PictureBox1.Image = My.Resources.paste
            iconlabel.Text = "system_paste"
        ElseIf ComboBox1.SelectedItem.ToString() = "pictureviewer" Then
            PictureBox1.Image = My.Resources.pictureviewer
            iconlabel.Text = "system_pictureviewer"
        ElseIf ComboBox1.SelectedItem.ToString() = "question" Then
            PictureBox1.Image = My.Resources.question
            iconlabel.Text = "system_question"
        ElseIf ComboBox1.SelectedItem.ToString() = "save" Then
            PictureBox1.Image = My.Resources.save
            iconlabel.Text = "system_save"
        ElseIf ComboBox1.SelectedItem.ToString() = "scoreboard" Then
            PictureBox1.Image = My.Resources.scoreboard
            iconlabel.Text = "system_scoreboard"
        ElseIf ComboBox1.SelectedItem.ToString() = "shutdown" Then
            PictureBox1.Image = My.Resources.shutdown
            iconlabel.Text = "system_shutdown"
        ElseIf ComboBox1.SelectedItem.ToString() = "texture" Then
            PictureBox1.Image = My.Resources.texture
            iconlabel.Text = "system_texture"
        ElseIf ComboBox1.SelectedItem.ToString() = "ttt" Then
            PictureBox1.Image = My.Resources.ttt
            iconlabel.Text = "system_ttt"
        ElseIf ComboBox1.SelectedItem.ToString() = "warning" Then
            PictureBox1.Image = My.Resources.warning
            iconlabel.Text = "system_warning"
        ElseIf ComboBox1.SelectedItem.ToString() = "web_explorer" Then
            PictureBox1.Image = My.Resources.web_explorer
            iconlabel.Text = "system_web_explorer"
        ElseIf ComboBox1.SelectedItem.ToString() = "unknown" Then
            PictureBox1.Image = My.Resources.unknown
            iconlabel.Text = "system_unknown"
        End If
    End Sub

    Private Sub TabControl1_ParentChanged(sender As Object, e As EventArgs) Handles TabControl1.ParentChanged
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        InputBoxDialog.txt = "Modify object values"
        InputBoxDialog.wintitle = "Edit object"
        InputBoxDialog.TextBox1.Text = ListBox2.SelectedItem.ToString()
        InputBoxDialog.ShowDialog()
        Dim lst As ListBox = New ListBox()
        lst.Items.AddRange(InputBoxDialog.finalinput.ToString().Split(";"))
        For Each o As Control In SplitContainer2.Panel1.Controls
            If o.Name = ListBox1.SelectedItem.ToString() Then
                lst.SelectedIndex = 0
                'voide.ListBox2.Items.Add(ComboBox1.SelectedItem.ToString() & ";" & lctx & ";" & lcty & ";" & "Value")
                If lst.SelectedItem.ToString() = "Button" Then
                    lst.SelectedIndex = 1
                    Dim x As Integer = lst.SelectedItem.ToString()
                    lst.SelectedIndex = 2
                    Dim y As Integer = lst.SelectedItem.ToString()
                    o.Location = New Point(x, y)
                    lst.SelectedIndex = 3
                    o.Text = lst.SelectedItem.ToString()
                ElseIf lst.SelectedItem.ToString() = "Label" Then
                    lst.SelectedIndex = 1
                    Dim x As Integer = lst.SelectedItem.ToString()
                    lst.SelectedIndex = 2
                    Dim y As Integer = lst.SelectedItem.ToString()
                    o.Location = New Point(x, y)
                    lst.SelectedIndex = 3
                    o.Text = lst.SelectedItem.ToString()
                ElseIf lst.SelectedItem.ToString() = "TextBox" Then
                    lst.SelectedIndex = 1
                    Dim x As Integer = lst.SelectedItem.ToString()
                    lst.SelectedIndex = 2
                    Dim y As Integer = lst.SelectedItem.ToString()
                    o.Location = New Point(x, y)
                    lst.SelectedIndex = 3
                    o.Text = lst.SelectedItem.ToString()
                ElseIf lst.SelectedItem.ToString() = "Menu" Then
                    For i As Integer = 1 To lst.Items.Count - 1
                        MenuBar.Items.Clear()
                        lst.SelectedIndex = 1
                        Dim lst2 As ListBox = New ListBox()
                        lst2.Items.AddRange(lst.SelectedItem.ToString().Split(":"))
                        For j As Integer = 0 To lst2.Items.Count - 1
                            lst2.SelectedIndex = j
                            MenuBar.Items.Add(lst2.SelectedItem.ToString())
                        Next
                    Next
                End If
            End If
        Next
        Dim ns As String = ListBox1.SelectedItem.ToString()
        ListBox2.Items.Remove(ListBox2.SelectedItem.ToString())
        ListBox1.Items.Remove(ListBox1.SelectedItem.ToString())
        ListBox2.Items.Add(InputBoxDialog.finalinput.ToString())
        ListBox1.Items.Add(ns)
        ListBox1.SelectedIndex = ListBox1.Items.Count - 1
    End Sub

    Private Sub ExecuteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExecuteToolStripMenuItem.Click
        Dim cust As Custom = New Custom()
        For i As Integer = 0 To ListBox1.Items.Count - 1
            ListBox1.SelectedIndex = i
            Dim lst As ListBox = New ListBox()
            lst.Items.AddRange(ListBox2.SelectedItem.ToString().Split(";"))
            lst.SelectedIndex = 0
            If lst.SelectedItem.ToString() = "Button" Then
                Dim btn As Button = New Button With {
                    .Name = ListBox1.SelectedItem.ToString(),
                    .AutoSize = True,
                    .FlatStyle = FlatStyle.Flat
                }
                lst.SelectedIndex = 1
                Dim x As Integer
                x = lst.SelectedItem.ToString()
                lst.SelectedIndex = 2
                Dim y As Integer
                y = lst.SelectedItem.ToString()
                btn.Location = New Point(x, y)
                lst.SelectedIndex = 3
                btn.Text = lst.SelectedItem.ToString()
                cust.Controls.Add(btn)
            ElseIf lst.SelectedItem.ToString() = "Label" Then
                Dim btn As Label = New Label With {
                    .Name = ListBox1.SelectedItem.ToString(),
                    .AutoSize = True
                }
                lst.SelectedIndex = 1
                Dim x As Integer
                x = lst.SelectedItem.ToString()
                lst.SelectedIndex = 2
                Dim y As Integer
                y = lst.SelectedItem.ToString()
                btn.Location = New Point(x, y)
                lst.SelectedIndex = 3
                btn.Text = lst.SelectedItem.ToString()
                cust.Controls.Add(btn)
            ElseIf lst.SelectedItem.ToString() = "TextBox" Then
                Dim btn As TextBox = New TextBox With {
                    .Name = ListBox1.SelectedItem.ToString(),
                    .AutoSize = True,
                    .BorderStyle = BorderStyle.FixedSingle
                }
                lst.SelectedIndex = 1
                Dim x As Integer
                x = lst.SelectedItem.ToString()
                lst.SelectedIndex = 2
                Dim y As Integer
                y = lst.SelectedItem.ToString()
                btn.Location = New Point(x, y)
                lst.SelectedIndex = 3
                btn.Text = lst.SelectedItem.ToString()
                cust.Controls.Add(btn)
            ElseIf lst.SelectedItem.ToString() = "Form" Then
                lst.SelectedIndex = 1
                cust.MainForm.Text = lst.SelectedItem.ToString()
                lst.SelectedIndex = 2
                Dim x As Integer
                x = lst.SelectedItem.ToString()
                lst.SelectedIndex = 3
                Dim y As Integer
                y = lst.SelectedItem.ToString()
                cust.Size = New Size(x, y)
            ElseIf lst.SelectedItem.ToString() = "Menu" Then
                cust.MenuBar.Visible = True
            End If
        Next
        cust.s_sv.Text = TextBox1.Text.Replace(vbNewLine, "")
        cust.s_sv.Text = cust.s_sv.Text.Replace("   ", "")
        'Try
        cust.appname = Label8.Text
            Label8.Text = "Icon: "
            cust.Show()
        'Catch ex As Exception
        'MessageDialog.messagetext = ex.Message
        'MessageDialog.ShowDialog()
        'End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    End Sub

    Private Sub Button4_MouseClick(sender As Object, e As MouseEventArgs) Handles Button4.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            TextBox1.Text = TextBox1.Text & vbNewLine & ListBox1.SelectedItem.ToString() & " - Listener.MouseMove*" & vbNewLine & vbNewLine & "::"
            TabControl1.SelectedIndex = 0
        ElseIf e.Button = Windows.Forms.MouseButtons.Left Then
            TextBox1.Text = TextBox1.Text & vbNewLine & ListBox1.SelectedItem.ToString() & " - Listener.Click*" & vbNewLine & vbNewLine & "::"
            TabControl1.SelectedIndex = 0
        End If
    End Sub

    Private Sub OpenProjectToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles OpenProjectToolStripMenuItem2.Click
        If hideopen = True Then
            Dim str As String = dopf.FileName
            str = My.Computer.FileSystem.ReadAllText(str)
            Dim lst As ListBox = New ListBox()
            str = str.Replace("DESIGN:0.0", "")
            str = str.Replace("CODE:0.0", "")
            str = str.Replace("PACKAGE:0.0", "")
            lst.Items.AddRange(str.Split("$"))
            lst.SelectedIndex = 1
            TextBox1.Text = lst.SelectedItem.ToString()
            TextBox1.Text = TextBox1.Text.Replace("{underscore}", "_")
            ListBox2.Items.Clear()
            ListBox1.Items.Clear()
            lst.SelectedIndex = 1
            Dim lst2 As ListBox = New ListBox()
            lst2.Items.AddRange(lst.SelectedItem.ToString().Split("_"))
            TextBox1.Text = ""
            For i As Integer = 1 To lst2.Items.Count - 2
                lst2.SelectedIndex = i
                TextBox1.Text = TextBox1.Text & vbNewLine & lst2.SelectedItem.ToString()
                TextBox1.Text = TextBox1.Text.Replace("{underscore}", "_")
            Next
            lst.SelectedIndex = 2
            lst2.Items.Clear()
            lst2.Items.AddRange(lst.SelectedItem.ToString().Split("_"))
            Dim lst3 As ListBox = New ListBox()
            For i As Integer = 1 To lst2.Items.Count - 1
                lst2.SelectedIndex = i
                lst3.Items.Clear()
                lst3.Items.AddRange(lst2.SelectedItem.ToString().Split(";"))
                Try
                    lst3.SelectedIndex = 1
                Catch
                    lst3.SelectedIndex = 0
                End Try
                Dim rts As String = lst3.SelectedItem.ToString()
                If rts = "Button" Then
                    lst3.SelectedIndex = 0
                    Dim obj As Button = New Button With {
                        .Name = lst3.SelectedItem.ToString()
                    }
                    ListBox1.Items.Add(lst3.SelectedItem.ToString())
                    lst3.SelectedIndex = 2
                    Dim lx As Integer = lst3.SelectedItem.ToString()
                    lst3.SelectedIndex = 3
                    Dim ly As Integer = lst3.SelectedItem.ToString()
                    obj.Location = New Point(Convert.ToInt32(lx), Convert.ToInt32(ly))
                    obj.AutoSize = True
                    obj.FlatStyle = FlatStyle.Flat
                    lst3.SelectedIndex = 4
                    obj.Text = lst3.SelectedItem.ToString()
                    ListBox2.Items.Add("Button;" & lx & ";" & ly & ";" & obj.Text)
                    SplitContainer2.Panel1.Controls.Add(obj)
                ElseIf rts = "Label" Then
                    lst3.SelectedIndex = 0
                    Dim obj As Label = New Label With {
                        .Name = lst3.SelectedItem.ToString()
                    }
                    ListBox1.Items.Add(lst3.SelectedItem.ToString())
                    lst3.SelectedIndex = 2
                    Dim lx As Integer = lst3.SelectedItem.ToString()
                    lst3.SelectedIndex = 3
                    Dim ly As Integer = lst3.SelectedItem.ToString()
                    obj.Location = New Point(Convert.ToInt32(lx), Convert.ToInt32(ly))
                    obj.AutoSize = True
                    lst3.SelectedIndex = 4
                    obj.Text = lst3.SelectedItem.ToString()
                    ListBox2.Items.Add("Label;" & lx & ";" & ly & ";" & obj.Text)
                    SplitContainer2.Panel1.Controls.Add(obj)
                ElseIf rts = "TextBox" Then
                    lst3.SelectedIndex = 0
                    Dim obj As TextBox = New TextBox With {
                        .Name = lst3.SelectedItem.ToString()
                    }
                    ListBox1.Items.Add(lst3.SelectedItem.ToString())
                    lst3.SelectedIndex = 2
                    Dim lx As Integer = lst3.SelectedItem.ToString()
                    lst3.SelectedIndex = 3
                    Dim ly As Integer = lst3.SelectedItem.ToString()
                    obj.Location = New Point(Convert.ToInt32(lx), Convert.ToInt32(ly))
                    obj.AutoSize = True
                    obj.BorderStyle = BorderStyle.FixedSingle
                    lst3.SelectedIndex = 4
                    obj.Text = lst3.SelectedItem.ToString()
                    ListBox2.Items.Add("TextBox;" & lx & ";" & ly & ";" & obj.Text)
                    SplitContainer2.Panel1.Controls.Add(obj)
                ElseIf rts = "Menu" Then
                    MenuBar.Visible = True
                    lst3.SelectedIndex = 0
                    ListBox1.Items.Add(lst3.SelectedItem.ToString())
                    Dim nonii As String = ""
                    For h As Integer = 1 To lst3.Items.Count - 1
                        lst3.SelectedIndex = h
                        nonii = nonii & lst3.SelectedItem.ToString() & ";"
                    Next
                    ListBox2.Items.Add(nonii)
                Else
                    lst3.SelectedIndex = 0
                    If lst3.SelectedItem.ToString() = "" Then GoTo waitno2
                    ListBox1.Items.Add(lst3.SelectedItem.ToString())
                    Dim nonii As String = ""
                    For h As Integer = 1 To lst3.Items.Count - 1
                        lst3.SelectedIndex = h
                        nonii = nonii & lst3.SelectedItem.ToString() & ";"
                    Next
                    ListBox2.Items.Add(nonii)
                End If
waitno2:
            Next
            lst.SelectedIndex = 3
            lst2.Items.Clear()
            lst2.Items.AddRange(lst.SelectedItem.ToString().Split("_"))
            lst2.SelectedIndex = 1
            TextBox2.Text = lst2.SelectedItem.ToString().Replace("Name=", "")
            lst2.SelectedIndex = 2
            TextBox3.Text = lst2.SelectedItem.ToString().Replace("Description=", "")
            lst2.SelectedIndex = 3
            Dim ico As String = lst2.SelectedItem.ToString().Replace("Icon=", "")
            If ico.Contains("system") = True Then
                ico = ico.Replace("system-", "")
                iconlabel.Text = "system_" & ico
                For i As Integer = 0 To ComboBox1.Items.Count - 1
                    ComboBox1.SelectedIndex = i
                    If ComboBox1.SelectedItem.ToString() = ico Then
                        If ComboBox1.SelectedItem.ToString() = "calc" Then
                            PictureBox1.Image = My.Resources.calc
                            iconlabel.Text = "system_calc"
                        ElseIf ComboBox1.SelectedItem.ToString() = "calc1" Then
                            PictureBox1.Image = My.Resources.calc1
                            iconlabel.Text = "system_calc1"
                        ElseIf ComboBox1.SelectedItem.ToString() = "canvas" Then
                            PictureBox1.Image = My.Resources.canvas
                            iconlabel.Text = "system_canvas"
                        ElseIf ComboBox1.SelectedItem.ToString() = "cmd" Then
                            PictureBox1.Image = My.Resources.cmd
                            iconlabel.Text = "system_cmd"
                        ElseIf ComboBox1.SelectedItem.ToString() = "colors" Then
                            PictureBox1.Image = My.Resources.colors
                            iconlabel.Text = "system_colors"
                        ElseIf ComboBox1.SelectedItem.ToString() = "copy" Then
                            PictureBox1.Image = My.Resources.copy
                            iconlabel.Text = "system_copy"
                        ElseIf ComboBox1.SelectedItem.ToString() = "cut" Then
                            PictureBox1.Image = My.Resources.cut
                            iconlabel.Text = "system_cut"
                        ElseIf ComboBox1.SelectedItem.ToString() = "docs" Then
                            PictureBox1.Image = My.Resources.docs
                            iconlabel.Text = "system_docs"
                        ElseIf ComboBox1.SelectedItem.ToString() = "draw" Then
                            PictureBox1.Image = My.Resources.draw
                            iconlabel.Text = "system_draw"
                        ElseIf ComboBox1.SelectedItem.ToString() = "error" Then
                            PictureBox1.Image = My.Resources._error
                            iconlabel.Text = "system_error"
                        ElseIf ComboBox1.SelectedItem.ToString() = "exit" Then
                            PictureBox1.Image = My.Resources._exit
                            iconlabel.Text = "system_exit"
                        ElseIf ComboBox1.SelectedItem.ToString() = "fonts" Then
                            PictureBox1.Image = My.Resources.fonts
                            iconlabel.Text = "system_fonts"
                        ElseIf ComboBox1.SelectedItem.ToString() = "help" Then
                            PictureBox1.Image = My.Resources.help
                            iconlabel.Text = "system_help"
                        ElseIf ComboBox1.SelectedItem.ToString() = "info" Then
                            PictureBox1.Image = My.Resources.info
                            iconlabel.Text = "system_info"
                        ElseIf ComboBox1.SelectedItem.ToString() = "load" Then
                            PictureBox1.Image = My.Resources.load
                            iconlabel.Text = "system_load"
                        ElseIf ComboBox1.SelectedItem.ToString() = "media_player" Then
                            PictureBox1.Image = My.Resources.media_player
                            iconlabel.Text = "system_media_player"
                        ElseIf ComboBox1.SelectedItem.ToString() = "new" Then
                            PictureBox1.Image = My.Resources._new
                            iconlabel.Text = "system_new"
                        ElseIf ComboBox1.SelectedItem.ToString() = "notepad" Then
                            PictureBox1.Image = My.Resources.notepad
                            iconlabel.Text = "system_notepad"
                        ElseIf ComboBox1.SelectedItem.ToString() = "paste" Then
                            PictureBox1.Image = My.Resources.paste
                            iconlabel.Text = "system_paste"
                        ElseIf ComboBox1.SelectedItem.ToString() = "pictureviewer" Then
                            PictureBox1.Image = My.Resources.pictureviewer
                            iconlabel.Text = "system_pictureviewer"
                        ElseIf ComboBox1.SelectedItem.ToString() = "question" Then
                            PictureBox1.Image = My.Resources.question
                            iconlabel.Text = "system_question"
                        ElseIf ComboBox1.SelectedItem.ToString() = "save" Then
                            PictureBox1.Image = My.Resources.save
                            iconlabel.Text = "system_save"
                        ElseIf ComboBox1.SelectedItem.ToString() = "scoreboard" Then
                            PictureBox1.Image = My.Resources.scoreboard
                            iconlabel.Text = "system_scoreboard"
                        ElseIf ComboBox1.SelectedItem.ToString() = "shutdown" Then
                            PictureBox1.Image = My.Resources.shutdown
                            iconlabel.Text = "system_shutdown"
                        ElseIf ComboBox1.SelectedItem.ToString() = "texture" Then
                            PictureBox1.Image = My.Resources.texture
                            iconlabel.Text = "system_texture"
                        ElseIf ComboBox1.SelectedItem.ToString() = "ttt" Then
                            PictureBox1.Image = My.Resources.ttt
                            iconlabel.Text = "system_ttt"
                        ElseIf ComboBox1.SelectedItem.ToString() = "warning" Then
                            PictureBox1.Image = My.Resources.warning
                            iconlabel.Text = "system_warning"
                        ElseIf ComboBox1.SelectedItem.ToString() = "web_explorer" Then
                            PictureBox1.Image = My.Resources.web_explorer
                            iconlabel.Text = "system_web_explorer"
                        ElseIf ComboBox1.SelectedItem.ToString() = "unknown" Then
                            PictureBox1.Image = My.Resources.unknown
                            iconlabel.Text = "system_unknown"
                        End If
                        Exit For
                    End If
                Next
            ElseIf ico.Contains("system-") = False Then
                iconlabel.Text = ico
                PictureBox1.Image = Image.FromFile(iconlabel.Text)
            End If
            lst2.SelectedIndex = 4
            Dim cat As String = lst2.SelectedItem.ToString().Replace("Category=", "")
            For i As Integer = 0 To ComboBox2.Items.Count - 1
                ComboBox2.SelectedIndex = i
                If ComboBox2.SelectedItem.ToString() = cat Then
                    Exit For
                End If
            Next
            lst2.SelectedIndex = 5
            Dim per As String = lst2.SelectedItem.ToString().Replace("PermissionControl=", "")
            powerchk.Checked = False
            adminchk.Checked = False
            standardchk.Checked = False
            limitedchk.Checked = False
            guestchk.Checked = False
            If per.Contains("power") = True Then powerchk.Checked = True
            If per.Contains("admin") = True Then adminchk.Checked = True
            If per.Contains("standard") = True Then standardchk.Checked = True
            If per.Contains("limited") = True Then limitedchk.Checked = True
            If per.Contains("guest") = True Then guestchk.Checked = True
            Exit Sub
        End If
        dopf.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\" & Desktop.user
        dopf.Filter = "Windowed Packaging Format|*.wpk"
        If dopf.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim str As String = dopf.FileName
            str = My.Computer.FileSystem.ReadAllText(str)
            Dim lst As ListBox = New ListBox()
            str = str.Replace("DESIGN:0.0", "")
            str = str.Replace("CODE:0.0", "")
            str = str.Replace("PACKAGE:0.0", "")
            lst.Items.AddRange(str.Split("$"))
            lst.SelectedIndex = 1
            TextBox1.Text = lst.SelectedItem.ToString()
            TextBox1.Text = TextBox1.Text.Replace("{underscore}", "_")
            ListBox2.Items.Clear()
            ListBox1.Items.Clear()
            lst.SelectedIndex = 1
            Dim lst2 As ListBox = New ListBox()
            lst2.Items.AddRange(lst.SelectedItem.ToString().Split("_"))
            TextBox1.Text = ""
            For i As Integer = 1 To lst2.Items.Count - 2
                lst2.SelectedIndex = i
                TextBox1.Text = TextBox1.Text & vbNewLine & lst2.SelectedItem.ToString()
                TextBox1.Text = TextBox1.Text.Replace("{underscore}", "_")
            Next
            lst.SelectedIndex = 2
            lst2.Items.Clear()
            lst2.Items.AddRange(lst.SelectedItem.ToString().Split("_"))
            Dim lst3 As ListBox = New ListBox()
            For i As Integer = 1 To lst2.Items.Count - 1
                lst2.SelectedIndex = i
                lst3.Items.Clear()
                lst3.Items.AddRange(lst2.SelectedItem.ToString().Split(";"))
                Try
                    lst3.SelectedIndex = 1
                Catch
                    lst3.SelectedIndex = 0
                End Try
                Dim rts As String = lst3.SelectedItem.ToString()
                If rts = "Button" Then
                    lst3.SelectedIndex = 0
                    Dim obj As Button = New Button With {
                        .Name = lst3.SelectedItem.ToString()
                    }
                    ListBox1.Items.Add(lst3.SelectedItem.ToString())
                    lst3.SelectedIndex = 2
                    Dim lx As Integer = lst3.SelectedItem.ToString()
                    lst3.SelectedIndex = 3
                    Dim ly As Integer = lst3.SelectedItem.ToString()
                    obj.Location = New Point(Convert.ToInt32(lx), Convert.ToInt32(ly))
                    obj.AutoSize = True
                    obj.FlatStyle = FlatStyle.Flat
                    lst3.SelectedIndex = 4
                    obj.Text = lst3.SelectedItem.ToString()
                    ListBox2.Items.Add("Button;" & lx & ";" & ly & ";" & obj.Text)
                    SplitContainer2.Panel1.Controls.Add(obj)
                ElseIf rts = "Label" Then
                    lst3.SelectedIndex = 0
                    Dim obj As Label = New Label With {
                        .Name = lst3.SelectedItem.ToString()
                    }
                    ListBox1.Items.Add(lst3.SelectedItem.ToString())
                    lst3.SelectedIndex = 2
                    Dim lx As Integer = lst3.SelectedItem.ToString()
                    lst3.SelectedIndex = 3
                    Dim ly As Integer = lst3.SelectedItem.ToString()
                    obj.Location = New Point(Convert.ToInt32(lx), Convert.ToInt32(ly))
                    obj.AutoSize = True
                    lst3.SelectedIndex = 4
                    obj.Text = lst3.SelectedItem.ToString()
                    ListBox2.Items.Add("Label;" & lx & ";" & ly & ";" & obj.Text)
                    SplitContainer2.Panel1.Controls.Add(obj)
                ElseIf rts = "TextBox" Then
                    lst3.SelectedIndex = 0
                    Dim obj As TextBox = New TextBox With {
                        .Name = lst3.SelectedItem.ToString()
                    }
                    ListBox1.Items.Add(lst3.SelectedItem.ToString())
                    lst3.SelectedIndex = 2
                    Dim lx As Integer = lst3.SelectedItem.ToString()
                    lst3.SelectedIndex = 3
                    Dim ly As Integer = lst3.SelectedItem.ToString()
                    obj.Location = New Point(Convert.ToInt32(lx), Convert.ToInt32(ly))
                    obj.AutoSize = True
                    obj.BorderStyle = BorderStyle.FixedSingle
                    lst3.SelectedIndex = 4
                    obj.Text = lst3.SelectedItem.ToString()
                    ListBox2.Items.Add("TextBox;" & lx & ";" & ly & ";" & obj.Text)
                    SplitContainer2.Panel1.Controls.Add(obj)
                ElseIf rts = "Menu" Then
                    MenuBar.Visible = True
                    lst3.SelectedIndex = 0
                    ListBox1.Items.Add(lst3.SelectedItem.ToString())
                    Dim nonii As String = ""
                    For h As Integer = 1 To lst3.Items.Count - 1
                        lst3.SelectedIndex = h
                        nonii = nonii & lst3.SelectedItem.ToString() & ";"
                    Next
                    ListBox2.Items.Add(nonii)
                Else
                    lst3.SelectedIndex = 0
                    If lst3.SelectedItem.ToString() = "" Then GoTo waitno
                    ListBox1.Items.Add(lst3.SelectedItem.ToString())
                    Dim nonii As String = ""
                    For h As Integer = 1 To lst3.Items.Count - 1
                        lst3.SelectedIndex = h
                        nonii = nonii & lst3.SelectedItem.ToString() & ";"
                    Next
                    ListBox2.Items.Add(nonii)
                End If
waitno:
            Next
            lst.SelectedIndex = 3
            lst2.Items.Clear()
            lst2.Items.AddRange(lst.SelectedItem.ToString().Split("_"))
            lst2.SelectedIndex = 1
            TextBox2.Text = lst2.SelectedItem.ToString().Replace("Name=", "")
            lst2.SelectedIndex = 2
            TextBox3.Text = lst2.SelectedItem.ToString().Replace("Description=", "")
            lst2.SelectedIndex = 3
            TextBox1.Text = TextBox1.Text.Replace("{underscore}", "_")
            Dim ico As String = lst2.SelectedItem.ToString().Replace("Icon=", "")
            If ico.Contains("system") = True Then
                ico = ico.Replace("system-", "")
                iconlabel.Text = "system_" & ico
                For i As Integer = 0 To ComboBox1.Items.Count - 1
                    ComboBox1.SelectedIndex = i
                    If ComboBox1.SelectedItem.ToString() = ico Then
                        If ComboBox1.SelectedItem.ToString() = "calc" Then
                            PictureBox1.Image = My.Resources.calc
                            iconlabel.Text = "system_calc"
                        ElseIf ComboBox1.SelectedItem.ToString() = "calc1" Then
                            PictureBox1.Image = My.Resources.calc1
                            iconlabel.Text = "system_calc1"
                        ElseIf ComboBox1.SelectedItem.ToString() = "canvas" Then
                            PictureBox1.Image = My.Resources.canvas
                            iconlabel.Text = "system_canvas"
                        ElseIf ComboBox1.SelectedItem.ToString() = "cmd" Then
                            PictureBox1.Image = My.Resources.cmd
                            iconlabel.Text = "system_cmd"
                        ElseIf ComboBox1.SelectedItem.ToString() = "colors" Then
                            PictureBox1.Image = My.Resources.colors
                            iconlabel.Text = "system_colors"
                        ElseIf ComboBox1.SelectedItem.ToString() = "copy" Then
                            PictureBox1.Image = My.Resources.copy
                            iconlabel.Text = "system_copy"
                        ElseIf ComboBox1.SelectedItem.ToString() = "cut" Then
                            PictureBox1.Image = My.Resources.cut
                            iconlabel.Text = "system_cut"
                        ElseIf ComboBox1.SelectedItem.ToString() = "docs" Then
                            PictureBox1.Image = My.Resources.docs
                            iconlabel.Text = "system_docs"
                        ElseIf ComboBox1.SelectedItem.ToString() = "draw" Then
                            PictureBox1.Image = My.Resources.draw
                            iconlabel.Text = "system_draw"
                        ElseIf ComboBox1.SelectedItem.ToString() = "error" Then
                            PictureBox1.Image = My.Resources._error
                            iconlabel.Text = "system_error"
                        ElseIf ComboBox1.SelectedItem.ToString() = "exit" Then
                            PictureBox1.Image = My.Resources._exit
                            iconlabel.Text = "system_exit"
                        ElseIf ComboBox1.SelectedItem.ToString() = "fonts" Then
                            PictureBox1.Image = My.Resources.fonts
                            iconlabel.Text = "system_fonts"
                        ElseIf ComboBox1.SelectedItem.ToString() = "help" Then
                            PictureBox1.Image = My.Resources.help
                            iconlabel.Text = "system_help"
                        ElseIf ComboBox1.SelectedItem.ToString() = "info" Then
                            PictureBox1.Image = My.Resources.info
                            iconlabel.Text = "system_info"
                        ElseIf ComboBox1.SelectedItem.ToString() = "load" Then
                            PictureBox1.Image = My.Resources.load
                            iconlabel.Text = "system_load"
                        ElseIf ComboBox1.SelectedItem.ToString() = "media_player" Then
                            PictureBox1.Image = My.Resources.media_player
                            iconlabel.Text = "system_media_player"
                        ElseIf ComboBox1.SelectedItem.ToString() = "new" Then
                            PictureBox1.Image = My.Resources._new
                            iconlabel.Text = "system_new"
                        ElseIf ComboBox1.SelectedItem.ToString() = "notepad" Then
                            PictureBox1.Image = My.Resources.notepad
                            iconlabel.Text = "system_notepad"
                        ElseIf ComboBox1.SelectedItem.ToString() = "paste" Then
                            PictureBox1.Image = My.Resources.paste
                            iconlabel.Text = "system_paste"
                        ElseIf ComboBox1.SelectedItem.ToString() = "pictureviewer" Then
                            PictureBox1.Image = My.Resources.pictureviewer
                            iconlabel.Text = "system_pictureviewer"
                        ElseIf ComboBox1.SelectedItem.ToString() = "question" Then
                            PictureBox1.Image = My.Resources.question
                            iconlabel.Text = "system_question"
                        ElseIf ComboBox1.SelectedItem.ToString() = "save" Then
                            PictureBox1.Image = My.Resources.save
                            iconlabel.Text = "system_save"
                        ElseIf ComboBox1.SelectedItem.ToString() = "scoreboard" Then
                            PictureBox1.Image = My.Resources.scoreboard
                            iconlabel.Text = "system_scoreboard"
                        ElseIf ComboBox1.SelectedItem.ToString() = "shutdown" Then
                            PictureBox1.Image = My.Resources.shutdown
                            iconlabel.Text = "system_shutdown"
                        ElseIf ComboBox1.SelectedItem.ToString() = "texture" Then
                            PictureBox1.Image = My.Resources.texture
                            iconlabel.Text = "system_texture"
                        ElseIf ComboBox1.SelectedItem.ToString() = "ttt" Then
                            PictureBox1.Image = My.Resources.ttt
                            iconlabel.Text = "system_ttt"
                        ElseIf ComboBox1.SelectedItem.ToString() = "warning" Then
                            PictureBox1.Image = My.Resources.warning
                            iconlabel.Text = "system_warning"
                        ElseIf ComboBox1.SelectedItem.ToString() = "web_explorer" Then
                            PictureBox1.Image = My.Resources.web_explorer
                            iconlabel.Text = "system_web_explorer"
                        ElseIf ComboBox1.SelectedItem.ToString() = "unknown" Then
                            PictureBox1.Image = My.Resources.unknown
                            iconlabel.Text = "system_unknown"
                        End If
                        Exit For
                    End If
                Next
            ElseIf ico.Contains("system-") = False Then
                iconlabel.Text = ico
                PictureBox1.Image = Image.FromFile(iconlabel.Text)
            End If
            lst2.SelectedIndex = 4
            Dim cat As String = lst2.SelectedItem.ToString().Replace("Category=", "")
            For i As Integer = 0 To ComboBox2.Items.Count - 1
                ComboBox2.SelectedIndex = i
                If ComboBox2.SelectedItem.ToString() = cat Then
                    Exit For
                End If
            Next
            lst2.SelectedIndex = 5
            Dim per As String = lst2.SelectedItem.ToString().Replace("PermissionControl=", "")
            powerchk.Checked = False
            adminchk.Checked = False
            standardchk.Checked = False
            limitedchk.Checked = False
            guestchk.Checked = False
            If per.Contains("power") = True Then powerchk.Checked = True
            If per.Contains("admin") = True Then adminchk.Checked = True
            If per.Contains("standard") = True Then standardchk.Checked = True
            If per.Contains("limited") = True Then limitedchk.Checked = True
            If per.Contains("guest") = True Then guestchk.Checked = True
            Label4.Text = "Voide IDE - " & dopf.SafeFileName.ToString()
        End If
    End Sub

    Private Sub InstallToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstallToolStripMenuItem.Click
        SaveProjectToolStripMenuItem2.PerformClick()
        My.Computer.FileSystem.CopyFile(ofd.FileName, My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Programs\" & TextBox2.Text & ".wpk")
    End Sub

    Private Sub ViewDesktopToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewDesktopToolStripMenuItem1.Click
        Me.Hide()
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            composedwindow.Hide()
        End If
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        ViewDesktopToolStripMenuItem1.PerformClick()
    End Sub

    Private Sub Label4_BackColorChanged(sender As Object, e As EventArgs) Handles Label4.BackColorChanged
        Label12.BackColor = Label4.BackColor
        Label12.ForeColor = Label4.ForeColor
    End Sub
End Class