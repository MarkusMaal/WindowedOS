Public Class CustomizationCenter
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim composedwindow As Form = New Form()
    Dim loaded As Boolean = False
    Dim rap As Boolean = False
    Dim changebg As Boolean = False
    Dim themechanged As Boolean = True
    Dim layoutchanged As Boolean = False
    Private Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr
    Private Sub BottomLeft_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles BottomLeftButton.CheckedChanged

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ThemeChangerDialog.Color = Desktop.appBg.BackColor
        If ThemeChangerDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            themechanged = True
            WindowBackground.BackColor = ThemeChangerDialog.Color
            Button8.Text = "Cancel"
            Button7.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        ThemeChangerDialog.Color = Desktop.appFg.BackColor
        If ThemeChangerDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            themechanged = True
            WindowBackground.ForeColor = ThemeChangerDialog.Color
            WindowText.ForeColor = ThemeChangerDialog.Color
            WindowButton.ForeColor = ThemeChangerDialog.Color
            Button8.Text = "Cancel"
            Button7.Enabled = True
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        ThemeChangerDialog.Color = Desktop.labelBg.BackColor
        If ThemeChangerDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            themechanged = True
            WindowTitle.BackColor = ThemeChangerDialog.Color
            Button8.Text = "Cancel"
            Button7.Enabled = True
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        ThemeChangerDialog.Color = Desktop.labelFg.BackColor
        If ThemeChangerDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            themechanged = True
            WindowTitle.ForeColor = ThemeChangerDialog.Color
            Button8.Text = "Cancel"
            Button7.Enabled = True
        End If
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then
            Me.Close()
            Exit Sub
        Else
            Form1.fadeout_animation(Me, composedwindow)
        End If
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        WindowTitle.BackColor = Color.DimGray
        WindowTitle.ForeColor = Color.White
        WindowBackground.BackColor = Color.WhiteSmoke
        WindowBackground.ForeColor = Color.Black
        WindowText.ForeColor = Color.Black
        WindowButton.ForeColor = Color.Black
        TopLeft.Checked = False
        TopBtn.Checked = False
        TopRight.Checked = False
        LeftBtn.Checked = False
        None.Checked = False
        RightBtn.Checked = False
        BottomLeft.Checked = False
        BottomBtn.Checked = False
        BottomRight.Checked = True
        TopLeftButton.Checked = False
        TopButton.Checked = False
        TopRightButton.Checked = False
        LeftButton.Checked = False
        NoneButton.Checked = False
        RightButton.Checked = False
        BottomLeftButton.Checked = True
        BottomButton.Checked = False
        BottomRightButton.Checked = False
        MainFont.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
        TitleFont.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
        MessageFont.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Regular)
        Button8.Text = "Cancel"
        Button7.Enabled = True
    End Sub
    Private Sub CustomizationCenter_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PictureBox1.BackgroundImage = Desktop.BackgroundImage
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Opacity = 1.0
        BottomRight.Checked = False
        BottomLeftButton.Checked = False
        If Desktop.Label2.Anchor = AnchorStyles.Bottom + AnchorStyles.Left Then BottomLeft.Checked = True
        If Desktop.Label2.Anchor = AnchorStyles.Bottom Then BottomBtn.Checked = True
        If Desktop.Label2.Anchor = AnchorStyles.Bottom + AnchorStyles.Right Then BottomRight.Checked = True
        If Desktop.Label2.Anchor = AnchorStyles.Left Then LeftBtn.Checked = True
        If Desktop.Label2.Anchor = AnchorStyles.None Then None.Checked = True
        If Desktop.Label2.Anchor = AnchorStyles.Right Then RightBtn.Checked = True
        If Desktop.Label2.Anchor = AnchorStyles.Top + AnchorStyles.Left Then TopLeft.Checked = True
        If Desktop.Label2.Anchor = AnchorStyles.Top Then TopBtn.Checked = True
        If Desktop.Label2.Anchor = AnchorStyles.Top + AnchorStyles.Right Then TopRight.Checked = True
        If Desktop.MenuStrip1.Anchor = AnchorStyles.Bottom + AnchorStyles.Left Then BottomLeftButton.Checked = True
        If Desktop.MenuStrip1.Anchor = AnchorStyles.Bottom Then BottomButton.Checked = True
        If Desktop.MenuStrip1.Anchor = AnchorStyles.Bottom + AnchorStyles.Right Then BottomRightButton.Checked = True
        If Desktop.MenuStrip1.Anchor = AnchorStyles.Left Then LeftButton.Checked = True
        If Desktop.MenuStrip1.Anchor = AnchorStyles.None Then NoneButton.Checked = True
        If Desktop.MenuStrip1.Anchor = AnchorStyles.Right Then RightButton.Checked = True
        If Desktop.MenuStrip1.Anchor = AnchorStyles.Top + AnchorStyles.Left Then TopLeftButton.Checked = True
        If Desktop.MenuStrip1.Anchor = AnchorStyles.Top Then TopButton.Checked = True
        If Desktop.MenuStrip1.Anchor = AnchorStyles.Top + AnchorStyles.Right Then TopRightButton.Checked = True
        If Not Desktop.Label2.BackColor = Color.Transparent Then CheckBox2.Checked = True
        If Not Desktop.MenuStrip1.Dock = DockStyle.None Then
            CheckBox1.Checked = True
            If Desktop.MenuStrip1.Dock = DockStyle.Bottom Then BottomButton.Checked = True
            If Desktop.MenuStrip1.Dock = DockStyle.Fill Then NoneButton.Checked = True
            If Desktop.MenuStrip1.Dock = DockStyle.Top Then TopButton.Checked = True
            If Desktop.MenuStrip1.Dock = DockStyle.Left Then LeftButton.Checked = True
            If Desktop.MenuStrip1.Dock = DockStyle.Right Then RightButton.Checked = True
        End If
        Button8.Text = "Close"
        Button7.Enabled = False
    End Sub

    Private Sub CustomizationCenter_VisibleChanged(sender As Object, e As System.EventArgs) Handles Me.VisibleChanged
        Try
            If Me.Visible = True Then
                Label1.BackColor = Desktop.labelBg.BackColor
                WindowTitle.BackColor = Desktop.labelBg.BackColor
                Label1.ForeColor = Desktop.labelFg.BackColor
                WindowTitle.ForeColor = Desktop.labelFg.BackColor
                Form1.Setfont(Me, Label1)
                If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then
                    Me.BackColor = Desktop.appBg.BackColor
                Else
                    If loaded = False Then
                        Me.Opacity = 0.0
                        Form1.Translucency(Me, composedwindow, True)
                    Else
                        Form1.Translucency(Me, composedwindow, False)
                    End If
                End If
                Me.ForeColor = Desktop.appFg.BackColor
                WindowText.ForeColor = Desktop.appFg.BackColor
                WindowButton.ForeColor = Desktop.appFg.BackColor
                WindowBackground.BackColor = Desktop.appBg.BackColor
                WindowBackground.ForeColor = Desktop.appFg.BackColor
                loaded = True
                For i As Integer = 0 To ComboBox1.Items.Count - 1
                    ComboBox1.SelectedIndex = i
                    If Me.BackColor = WindowBackground.BackColor Then
                        If Me.ForeColor = WindowBackground.ForeColor Then
                            If Label1.ForeColor = WindowTitle.ForeColor Then
                                If Label1.BackColor = WindowTitle.BackColor Then
                                    Button8.Text = "Close"
                                    Exit For
                                End If
                            End If
                        End If
                    End If
                Next
                If Button8.Text = "Cancel" Then
                    WindowBackground.BackColor = Me.BackColor
                    WindowBackground.ForeColor = Me.ForeColor
                    WindowButton.ForeColor = Me.ForeColor
                    WindowText.ForeColor = Me.ForeColor
                    WindowTitle.BackColor = Desktop.labelBg.BackColor
                    WindowTitle.ForeColor = Desktop.labelFg.BackColor
                    ComboBox1.Text = "(custom)"
                    Button8.Text = "Close"
                End If
            End If
        Catch ex As Exception
            ESOD.Label5.Text = ex.Message
            ESOD.ShowDialog()
        End Try
    End Sub

    Private Sub Label1_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Left
        mousey = Cursor.Position.Y - Top
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseMove
        If drag Then
            Top = Cursor.Position.Y - mousey
            Left = Cursor.Position.X - mousex
            composedwindow.Left = Me.Left
            composedwindow.Top = Me.Top
        End If
    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseUp
        drag = False
        composedwindow.BringToFront()
        Me.BringToFront()
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Wait.Label1.BackColor = WindowBackground.BackColor
        Wait.Label1.ForeColor = WindowText.ForeColor
        Wait.Label1.Font = WindowText.Font
        Wait.Show()
        loaded = False
        Desktop.WindowState = FormWindowState.Normal
        Desktop.restorealltimer.Enabled = True
        'sets the menu bar position in DE
        'checkbox1 - "Docked" checkbox
        If CheckBox1.Checked = False Then
            If TopLeftButton.Checked = True Then
                Desktop.MenuStrip1.Location = New Point(1, 1)
                Desktop.MenuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow
                Desktop.MenuStrip1.Anchor = AnchorStyles.Top + AnchorStyles.Left
            ElseIf TopButton.Checked = True Then
                Desktop.MenuStrip1.Location = New Point(230, 1)
                Desktop.MenuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow
                Desktop.MenuStrip1.Dock = DockStyle.Top
                Desktop.MenuStrip1.Anchor = AnchorStyles.Top
            ElseIf TopRightButton.Checked = True Then
                Desktop.MenuStrip1.Location = New Point(472, 1)
                Desktop.MenuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow
                Desktop.MenuStrip1.Anchor = AnchorStyles.Top + AnchorStyles.Right
            ElseIf LeftButton.Checked = True Then
                Desktop.MenuStrip1.Location = New Point(1, 197)
                Desktop.MenuStrip1.Anchor = AnchorStyles.Left
                Desktop.MenuStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow
            ElseIf NoneButton.Checked = True Then
                Desktop.MenuStrip1.Location = New Point(229, 202)
                Desktop.MenuStrip1.Anchor = AnchorStyles.None
                Desktop.MenuStrip1.LayoutStyle = ToolStripLayoutStyle.Flow
            ElseIf RightButton.Checked = True Then
                Desktop.MenuStrip1.Location = New Point(492, 202)
                Desktop.MenuStrip1.Anchor = AnchorStyles.Right
                Desktop.MenuStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow
            ElseIf BottomLeftButton.Checked = True Then
                Desktop.MenuStrip1.Location = New Point(0, 400)
                Desktop.MenuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow
                Desktop.MenuStrip1.Anchor = AnchorStyles.Bottom + AnchorStyles.Left
            ElseIf BottomButton.Checked = True Then
                Desktop.MenuStrip1.Location = New Point(238, 400)
                Desktop.MenuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow
                Desktop.MenuStrip1.Anchor = AnchorStyles.Bottom
            ElseIf BottomRightButton.Checked = True Then
                Desktop.MenuStrip1.Location = New Point(472, 400)
                Desktop.MenuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow
                Desktop.MenuStrip1.Anchor = AnchorStyles.Bottom + AnchorStyles.Right
            End If
        ElseIf CheckBox1.Checked = True Then
            Desktop.MenuStrip1.Anchor = AnchorStyles.Top + AnchorStyles.Left
            If TopButton.Checked = True Then
                Desktop.MenuStrip1.Location = New Point(230, 1)
                Desktop.MenuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow
                Desktop.MenuStrip1.Dock = DockStyle.Top
            ElseIf LeftButton.Checked = True Then
                Desktop.MenuStrip1.Location = New Point(1, 197)
                Desktop.MenuStrip1.Dock = DockStyle.Left
                Desktop.MenuStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow
            ElseIf NoneButton.Checked = True Then
                Desktop.MenuStrip1.Location = New Point(229, 202)
                Desktop.MenuStrip1.Dock = DockStyle.Fill
                Desktop.MenuStrip1.LayoutStyle = ToolStripLayoutStyle.Flow
            ElseIf RightButton.Checked = True Then
                Desktop.MenuStrip1.Location = New Point(492, 202)
                Desktop.MenuStrip1.Dock = DockStyle.Right
                Desktop.MenuStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow
            ElseIf BottomButton.Checked = True Then
                Desktop.MenuStrip1.Location = New Point(238, 400)
                Desktop.MenuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow
                Desktop.MenuStrip1.Dock = DockStyle.Bottom
            End If
        End If
        'ccc anchor
        If BottomRight.Checked = True Then
            Desktop.Label1.Location = New Point(631, 410)
            Desktop.Label2.Location = New Point(631, 398)
            Desktop.Label1.TextAlign = ContentAlignment.BottomRight
            Desktop.Label2.TextAlign = ContentAlignment.BottomRight
            Desktop.Label1.Anchor = AnchorStyles.Bottom + AnchorStyles.Right
            Desktop.Label2.Anchor = AnchorStyles.Bottom + AnchorStyles.Right
        ElseIf BottomBtn.Checked = True Then
            Desktop.Label1.Location = New Point(319, 410)
            Desktop.Label2.Location = New Point(319, 398)
            Desktop.Label1.TextAlign = ContentAlignment.BottomCenter
            Desktop.Label2.TextAlign = ContentAlignment.BottomCenter
            Desktop.Label1.Anchor = AnchorStyles.Bottom
            Desktop.Label2.Anchor = AnchorStyles.Bottom
        ElseIf BottomLeft.Checked = True Then
            Desktop.Label1.Location = New Point(2, 410)
            Desktop.Label2.Location = New Point(2, 398)
            Desktop.Label1.TextAlign = ContentAlignment.BottomLeft
            Desktop.Label2.TextAlign = ContentAlignment.BottomLeft
            Desktop.Label1.Anchor = AnchorStyles.Bottom + AnchorStyles.Left
            Desktop.Label2.Anchor = AnchorStyles.Bottom + AnchorStyles.Left
        ElseIf LeftBtn.Checked = True Then
            Desktop.Label1.Location = New Point(2, 218)
            Desktop.Label2.Location = New Point(2, 206)
            Desktop.Label1.TextAlign = ContentAlignment.MiddleLeft
            Desktop.Label2.TextAlign = ContentAlignment.MiddleLeft
            Desktop.Label1.Anchor = AnchorStyles.Left
            Desktop.Label2.Anchor = AnchorStyles.Left
        ElseIf None.Checked = True Then
            Desktop.Label1.Location = New Point(309, 218)
            Desktop.Label2.Location = New Point(309, 206)
            Desktop.Label1.TextAlign = ContentAlignment.MiddleCenter
            Desktop.Label2.TextAlign = ContentAlignment.MiddleCenter
            Desktop.Label1.Anchor = AnchorStyles.None
            Desktop.Label2.Anchor = AnchorStyles.None
        ElseIf RightBtn.Checked = True Then
            Desktop.Label1.Location = New Point(631, 218)
            Desktop.Label2.Location = New Point(631, 206)
            Desktop.Label1.TextAlign = ContentAlignment.MiddleRight
            Desktop.Label2.TextAlign = ContentAlignment.MiddleRight
            Desktop.Label1.Anchor = AnchorStyles.Right
            Desktop.Label2.Anchor = AnchorStyles.Right
        ElseIf TopLeft.Checked = True Then
            Desktop.Label1.Location = New Point(4, 16)
            Desktop.Label2.Location = New Point(4, 4)
            Desktop.Label1.TextAlign = ContentAlignment.TopLeft
            Desktop.Label2.TextAlign = ContentAlignment.TopLeft
            Desktop.Label1.Anchor = AnchorStyles.Top + AnchorStyles.Left
            Desktop.Label2.Anchor = AnchorStyles.Top + AnchorStyles.Left
        ElseIf TopBtn.Checked = True Then
            Desktop.Label1.Location = New Point(301, 21)
            Desktop.Label2.Location = New Point(301, 9)
            Desktop.Label1.TextAlign = ContentAlignment.TopCenter
            Desktop.Label2.TextAlign = ContentAlignment.TopCenter
            Desktop.Label1.Anchor = AnchorStyles.Top
            Desktop.Label2.Anchor = AnchorStyles.Top
        ElseIf TopRight.Checked = True Then
            Desktop.Label1.Location = New Point(630, 15)
            Desktop.Label2.Location = New Point(630, 3)
            Desktop.Label1.TextAlign = ContentAlignment.TopRight
            Desktop.Label2.TextAlign = ContentAlignment.TopRight
            Desktop.Label1.Anchor = AnchorStyles.Top + AnchorStyles.Right
            Desktop.Label2.Anchor = AnchorStyles.Top + AnchorStyles.Right
        End If
        'CCC background
        If CheckBox2.Checked = True Then
            Dim inversed As Color = Color.FromArgb(Not Desktop.Label2.ForeColor.R, Not Desktop.Label2.ForeColor.G, Not Desktop.Label2.ForeColor.B)
            Desktop.Label1.BackColor = inversed
            Desktop.Label2.BackColor = inversed
            Desktop.Label3.BackColor = inversed
            Desktop.Label4.BackColor = inversed
        ElseIf CheckBox2.Checked = False Then
            Desktop.Label1.BackColor = Color.Transparent
            Desktop.Label2.BackColor = Color.Transparent
            Desktop.Label3.BackColor = Color.Transparent
            Desktop.Label4.BackColor = Color.Transparent
        End If
        'Window colors
        Desktop.labelBg.BackColor = WindowTitle.BackColor
        Desktop.labelFg.BackColor = WindowTitle.ForeColor
        Desktop.appBg.BackColor = WindowBackground.BackColor
        Desktop.appFg.BackColor = WindowBackground.ForeColor
        Desktop.MenuStrip1.BackColor = Desktop.labelBg.BackColor
        Desktop.MenuStrip1.ForeColor = Desktop.labelFg.BackColor
        Button2.BackColor = WindowBackground.BackColor
        Button3.BackColor = WindowBackground.BackColor
        Button4.BackColor = WindowBackground.BackColor
        Button5.BackColor = WindowBackground.BackColor
        Button6.BackColor = WindowBackground.BackColor
        Button7.BackColor = WindowBackground.BackColor
        Button8.BackColor = WindowBackground.BackColor
        Button9.BackColor = WindowBackground.BackColor
        If Desktop.MenuStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow Then
            Desktop.PowerToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image
            Desktop.ViewToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image
            Desktop.ProgramsToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image
            Desktop.SettingsToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image
            Desktop.AboutToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image
        Else
            Desktop.PowerToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text
            Desktop.ViewToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text
            Desktop.ProgramsToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text
            Desktop.SettingsToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text
            Desktop.AboutToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text
        End If
        'apply desktop background
        If changebg Then
            Desktop.BackgroundImage = Nothing
            Dim num As String = DateTime.Today.DayOfYear & DateTime.Today.Year & DateTime.Today.TimeOfDay.Hours & DateTime.Today.TimeOfDay.Minutes & DateTime.Today.TimeOfDay.Seconds & DateTime.Today.TimeOfDay.Milliseconds
            Try
                PictureBox1.BackgroundImage.Save(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & Desktop.user & "_bg" & num & ".png", Imaging.ImageFormat.Png)
                Desktop.BackgroundImage = Image.FromFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & Desktop.user & "_bg" & num & ".png")
            Catch
            End Try
            If ListBox1.SelectedIndex = 2 Then
                Desktop.OpenFileDialog1.FileName = "Local_3"
            Else
                Desktop.OpenFileDialog1.FileName = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & Desktop.user & "_bg.png"
            End If
        End If
        'apply font theme
        Desktop.Font = MainFont.Font
        Desktop.appFg.Font = MainFont.Font
        Desktop.labelFg.Font = TitleFont.Font
        Desktop.msgfont.Font = MessageFont.Font
        MessageDialog.Font = MainFont.Font
        MessageDialog.Label1.Font = TitleFont.Font
        MessageDialog.Label2.Font = MessageFont.Font
        InputBoxDialog.Font = MainFont.Font
        InputBoxDialog.Label4.Font = TitleFont.Font
        InputBoxDialog.Label1.Font = MessageFont.Font
        Me.Font = MainFont.Font
        Label1.Font = TitleFont.Font
        If System.IO.File.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & Desktop.user & "_fonts.txt") Then System.IO.File.Delete(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & Desktop.user & "_fonts.txt")
        System.IO.File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & Desktop.user & "_fonts.txt", MainFont.Font.Name & ";" & MainFont.Font.Size & ";" & MainFont.Font.Bold.ToString() & ";" & MainFont.Font.Italic.ToString() & ";" & MainFont.Font.Underline & "::" & TitleFont.Font.Name & ";" & TitleFont.Font.Size.ToString() & ";" & TitleFont.Font.Bold.ToString() & ";" & TitleFont.Font.Italic.ToString() & ";" & TitleFont.Font.Underline.ToString() & "::" & MessageFont.Font.Name.ToString() & ";" & MessageFont.Font.Size.ToString() & ";" & MessageFont.Font.Bold.ToString() & ";" & MessageFont.Font.Italic.ToString() & ";" & MessageFont.Font.Underline.ToString() & "::", System.Text.Encoding.ASCII)
        'restores the desktop
        Desktop.WindowState = FormWindowState.Maximized
        'apply function applies the theme
        apply()
        Desktop.RethemeWindowsToolStripMenuItem.PerformClick()
        'modifies the cancel button to say "Close" instead
        Button8.Text = "Close"
        Button7.Enabled = False
        ApplyTheme.Enabled = True
        'shows CustomizationCenter window again
        Me.Show()
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Button9.PerformClick()
        ApplyTheme.Enabled = True
        loaded = True
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then
            Me.Close()
            Exit Sub
        Else
            composedwindow.Close()
            Me.Close()
            Exit Sub
        End If
    End Sub

    Private Sub apply()
        If Visible = True Then
            Me.Visible = False
            Me.Visible = True
        End If
        If Desktop.Visible = True Then
            Desktop.Visible = False
            Desktop.Visible = True
        End If
        If CMD.Visible = True Then
            CMD.Visible = False
            CMD.Visible = True
        End If
        If MediaPlay.Visible = True Then
            MediaPlay.Visible = False
            MediaPlay.Visible = True
        End If
        If Notepad.Visible = True Then
            Notepad.Visible = False
            Notepad.Visible = True
        End If
        If PictureViewer.Visible = True Then
            PictureViewer.Visible = False
            PictureViewer.Visible = True
        End If
        If TicTacToe.Visible = True Then
            TicTacToe.Visible = False
            TicTacToe.Visible = True
        End If
        If tskmgr.Visible = True Then
            tskmgr.Visible = False
            tskmgr.Visible = True
        End If
        If WebBrowser.Visible = True Then
            WebBrowser.Visible = False
            WebBrowser.Visible = True
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim backupindex As Integer = ComboBox1.SelectedIndex
        themechanged = True
        If ComboBox1.SelectedIndex = 0 Then
            WindowBackground.BackColor = Color.WhiteSmoke
            WindowBackground.ForeColor = Color.Black
            WindowText.ForeColor = Color.Black
            WindowButton.ForeColor = Color.Black
            WindowTitle.BackColor = Color.DimGray
            WindowTitle.ForeColor = Color.White
        ElseIf ComboBox1.SelectedIndex = 1 Then
            WindowBackground.BackColor = Color.Orange
            WindowBackground.ForeColor = Color.White
            WindowText.ForeColor = Color.White
            WindowButton.ForeColor = Color.White
            WindowTitle.BackColor = Color.DarkOrange
            WindowTitle.ForeColor = Color.White
        ElseIf ComboBox1.SelectedIndex = 2 Then
            WindowBackground.BackColor = Color.DodgerBlue
            WindowBackground.ForeColor = Color.White
            WindowText.ForeColor = Color.White
            WindowButton.ForeColor = Color.White
            WindowTitle.BackColor = Color.Blue
            WindowTitle.ForeColor = Color.White
        ElseIf ComboBox1.SelectedIndex = 3 Then
            WindowBackground.BackColor = Color.WhiteSmoke
            WindowBackground.ForeColor = Color.Black
            WindowText.ForeColor = Color.Black
            WindowButton.ForeColor = Color.Black
            WindowTitle.BackColor = Color.Indigo
            WindowTitle.ForeColor = Color.White
        ElseIf ComboBox1.SelectedIndex = 4 Then
            WindowBackground.BackColor = Color.FromArgb(64, 64, 64)
            WindowBackground.ForeColor = Color.NavajoWhite
            WindowText.ForeColor = Color.NavajoWhite
            WindowButton.ForeColor = Color.NavajoWhite
            WindowTitle.BackColor = Color.SlateBlue
            WindowTitle.ForeColor = Color.Yellow
        ElseIf ComboBox1.SelectedIndex = 5 Then
            WindowBackground.BackColor = Color.FromArgb(36, 36, 192)
            WindowBackground.ForeColor = Color.White
            WindowText.ForeColor = Color.White
            WindowButton.ForeColor = Color.White
            WindowTitle.BackColor = Color.DarkBlue
            WindowTitle.ForeColor = Color.WhiteSmoke
        ElseIf ComboBox1.SelectedIndex = 6 Then
            WindowBackground.BackColor = Color.Khaki
            WindowBackground.ForeColor = Color.Black
            WindowText.ForeColor = Color.Black
            WindowButton.ForeColor = Color.Black
            WindowTitle.BackColor = Color.RoyalBlue
            WindowTitle.ForeColor = Color.White
        ElseIf ComboBox1.SelectedIndex = 7 Then
            WindowBackground.BackColor = Color.Snow
            WindowBackground.ForeColor = Color.MidnightBlue
            WindowText.ForeColor = Color.MidnightBlue
            WindowButton.ForeColor = Color.MidnightBlue
            WindowTitle.BackColor = Color.LightBlue
            WindowTitle.ForeColor = Color.Black
        ElseIf ComboBox1.SelectedIndex = 8 Then
            WindowBackground.BackColor = Color.FromArgb(64, 64, 64)
            WindowBackground.ForeColor = Color.Cyan
            WindowText.ForeColor = Color.Cyan
            WindowButton.ForeColor = Color.Cyan
            WindowTitle.BackColor = Color.Aqua
            WindowTitle.ForeColor = Color.Black
        ElseIf ComboBox1.SelectedIndex = 9 Then
            WindowBackground.BackColor = Color.Plum
            WindowBackground.ForeColor = Color.Indigo
            WindowText.ForeColor = Color.Indigo
            WindowButton.ForeColor = Color.Indigo
            WindowTitle.BackColor = Color.SpringGreen
            WindowTitle.ForeColor = Color.DarkCyan
        ElseIf ComboBox1.SelectedIndex = 10 Then
            WindowBackground.BackColor = Color.Black
            WindowBackground.ForeColor = Color.DarkGray
            WindowText.ForeColor = Color.DarkGray
            WindowButton.ForeColor = Color.DarkGray
            WindowTitle.BackColor = Color.FromArgb(64, 64, 64)
            WindowTitle.ForeColor = Color.Gray
        ElseIf ComboBox1.SelectedIndex = 11 Then
            WindowBackground.BackColor = Color.DarkGreen
            WindowBackground.ForeColor = Color.LawnGreen
            WindowText.ForeColor = Color.LawnGreen
            WindowButton.ForeColor = Color.LawnGreen
            WindowTitle.BackColor = Color.FromArgb(0, 192, 0)
            WindowTitle.ForeColor = Color.White
        ElseIf ComboBox1.SelectedIndex = 12 Then
            WindowBackground.BackColor = Color.Goldenrod
            WindowBackground.ForeColor = Color.Yellow
            WindowText.ForeColor = Color.Yellow
            WindowButton.ForeColor = Color.Yellow
            WindowTitle.BackColor = Color.Gold
            WindowTitle.ForeColor = Color.DarkGoldenrod
        ElseIf ComboBox1.SelectedIndex = 13 Then
            WindowBackground.BackColor = Color.BlueViolet
            WindowBackground.ForeColor = Color.White
            WindowText.ForeColor = Color.White
            WindowButton.ForeColor = Color.White
            WindowTitle.BackColor = Color.MediumSlateBlue
            WindowTitle.ForeColor = Color.Thistle
        ElseIf ComboBox1.SelectedIndex = 14 Then
            WindowBackground.BackColor = Color.FromArgb(0, 0, 64)
            WindowBackground.ForeColor = Color.Gainsboro
            WindowText.ForeColor = Color.Gainsboro
            WindowButton.ForeColor = Color.Gainsboro
            WindowTitle.BackColor = Color.Navy
            WindowTitle.ForeColor = Color.White
        ElseIf ComboBox1.SelectedIndex = 15 Then
            WindowBackground.BackColor = Color.Chocolate
            WindowBackground.ForeColor = Color.PeachPuff
            WindowText.ForeColor = Color.PeachPuff
            WindowButton.ForeColor = Color.PeachPuff
            WindowTitle.BackColor = Color.Sienna
            WindowTitle.ForeColor = Color.Peru
        ElseIf ComboBox1.SelectedIndex = 16 Then
            WindowBackground.BackColor = Color.White
            WindowBackground.ForeColor = Color.Black
            WindowText.ForeColor = Color.Black
            WindowButton.ForeColor = Color.Black
            WindowTitle.BackColor = Color.Black
            WindowTitle.ForeColor = Color.White
        ElseIf ComboBox1.SelectedIndex = 17 Then
            WindowBackground.BackColor = Color.Black
            WindowBackground.ForeColor = Color.Yellow
            WindowText.ForeColor = Color.Yellow
            WindowButton.ForeColor = Color.Yellow
            WindowTitle.BackColor = Color.Lime
            WindowTitle.ForeColor = Color.Blue
        ElseIf ComboBox1.SelectedIndex = 18 Then
            WindowBackground.BackColor = Color.Black
            WindowBackground.ForeColor = Color.Fuchsia
            WindowText.ForeColor = Color.Fuchsia
            WindowButton.ForeColor = Color.Fuchsia
            WindowTitle.BackColor = Color.Teal
            WindowTitle.ForeColor = Color.Yellow
        ElseIf ComboBox1.SelectedIndex = 19 Then
            WindowBackground.BackColor = SystemColors.Window
            WindowBackground.ForeColor = SystemColors.WindowText
            WindowText.ForeColor = SystemColors.WindowText
            WindowButton.ForeColor = SystemColors.WindowText
            WindowTitle.BackColor = SystemColors.ActiveCaption
            WindowTitle.ForeColor = SystemColors.ActiveCaptionText
        End If
        If ComboBox1.SelectedIndex = backupindex Then
            themechanged = False
        End If
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            Me.TransparencyKey = WindowBackground.BackColor
            composedwindow.BackColor = WindowBackground.BackColor
        End If
        Button8.Text = "Cancel"
        Button7.Enabled = True
    End Sub

    Private Sub TerminateTimer_Tick(sender As System.Object, e As System.EventArgs) Handles TerminateTimer.Tick
        If LogoffWindow.Visible = True Then
            Me.Close()
        ElseIf Lock.Visible = True Then
            Me.Hide()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Hide()
        End If
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            If composedwindow.IsDisposed = False Then
                If Not GetActiveWindow <> composedwindow.Handle Then
                    Me.BringToFront()
                End If
            End If
        End If
    End Sub

    Private Sub CustomizationCenter_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        Label1.BackColor = Desktop.labelBg.BackColor
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

    Private Sub CustomizationCenter_Deactivate(sender As System.Object, e As System.EventArgs) Handles MyBase.Deactivate
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
        rap = False
    End Sub
    
    Private Sub BottomRight_Click(sender As System.Object, e As System.EventArgs) Handles TopRight.Click, TopLeft.Click, TopBtn.Click, RightBtn.Click, None.Click, LeftBtn.Click, BottomRight.Click, BottomLeft.Click, BottomBtn.Click
        Button8.Text = "Cancel"
        Button7.Enabled = True
    End Sub

    Private Sub BottomRightButton_Click(sender As System.Object, e As System.EventArgs) Handles TopRightButton.Click, TopLeftButton.Click, TopButton.Click, RightButton.Click, NoneButton.Click, LeftButton.Click, BottomRightButton.Click, BottomLeftButton.Click, BottomButton.Click
        Button8.Text = "Cancel"
        Button7.Enabled = True
    End Sub

    Private Sub ApplyTheme_Tick(sender As Object, e As EventArgs) Handles ApplyTheme.Tick
        Dim j As Integer = tskmgr.ListBox1.SelectedIndex
        For i As Integer = 0 To tskmgr.ListBox1.Items.Count - 1
            tskmgr.ListBox1.SelectedIndex = i
            If Not tskmgr.ListBox1.SelectedItem.ToString() = "Tasks and resources" Then
                If Not tskmgr.ListBox1.SelectedItem.ToString() = "System I/O Framework" Then
                    If Not tskmgr.ListBox1.SelectedItem.ToString() = "Windowed Desktop Environment" Then
                        tskmgr.Button1.PerformClick()
                    End If
                End If
            End If
        Next
        tskmgr.ListBox1.SelectedIndex = j
        ApplyTheme.Enabled = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            If BottomLeftButton.Checked = True Then
                BottomLeftButton.Checked = False
                BottomButton.Checked = True
            ElseIf BottomRightButton.Checked = True Then
                BottomLeftButton.Checked = False
                BottomButton.Checked = True
            ElseIf TopRightButton.Checked = True Then
                TopRightButton.Checked = False
                TopButton.Checked = True
            ElseIf TopLeftButton.Checked = True Then
                TopLeftButton.Checked = False
                TopButton.Checked = True
            End If
            TopLeftButton.Enabled = False
            TopRightButton.Enabled = False
            BottomLeftButton.Enabled = False
            BottomRightButton.Enabled = False
            Exit Sub
        Else
            TopLeftButton.Enabled = True
            TopRightButton.Enabled = True
            BottomLeftButton.Enabled = True
            BottomRightButton.Enabled = True
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        ListBox1.ClearSelected()
        If BackgroundImageDialog.ShowDialog() = DialogResult.OK Then
            changebg = True
            PictureBox1.BackgroundImage = Nothing
            PictureBox1.BackgroundImage = Image.FromFile(BackgroundImageDialog.FileName)
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        ListBox1.ClearSelected()
        If SolidColorDialog.ShowDialog() = DialogResult.OK Then
            changebg = True
            PictureBox1.BackgroundImage = Nothing
            PictureBox1.BackgroundImage = New Bitmap(PictureBox1.Width, PictureBox1.Height)
            Dim g As Graphics
            Dim img As Bitmap = PictureBox1.BackgroundImage
            g = Graphics.FromImage(img)
            g.CompositingMode = Drawing2D.CompositingMode.SourceOver
            Dim bc As New Drawing.SolidBrush(SolidColorDialog.Color)
            g.FillRectangle(bc, 0, 0, My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
            PictureBox1.BackgroundImage = img
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SystemFontDialog.Font = MainFont.Font
        If SystemFontDialog.ShowDialog() = DialogResult.OK Then
            MainFont.Font = SystemFontDialog.Font
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        SystemFontDialog.Font = TitleFont.Font
        If SystemFontDialog.ShowDialog() = DialogResult.OK Then
            TitleFont.Font = SystemFontDialog.Font
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        SystemFontDialog.Font = MessageFont.Font
        If SystemFontDialog.ShowDialog() = DialogResult.OK Then
            MessageFont.Font = SystemFontDialog.Font
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        PictureBox1.BackgroundImage = Nothing
        changebg = True
        If ListBox1.SelectedIndex = 0 Then PictureBox1.BackgroundImage = My.Resources.f22272576
        If ListBox1.SelectedIndex = 1 Then PictureBox1.BackgroundImage = My.Resources.f16929280
        If ListBox1.SelectedIndex = 2 Then PictureBox1.BackgroundImage = My.Resources.startup1
    End Sub

    Private Sub MainFont_FontChanged(sender As Object, e As EventArgs) Handles MainFont.FontChanged
        WindowButton.Font = MainFont.Font
    End Sub

    Private Sub TitleFont_FontChanged(sender As Object, e As EventArgs) Handles TitleFont.FontChanged
        WindowTitle.Font = TitleFont.Font
    End Sub

    Private Sub MessageFont_FontChanged(sender As Object, e As EventArgs) Handles MessageFont.FontChanged
        WindowText.Font = MessageFont.Font
    End Sub

    Private Sub CustomizationCenter_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F7 Then
            MainFont.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
            TitleFont.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
            MessageFont.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Regular)
            Button7.PerformClick()
        End If
    End Sub

    Private Sub Button7_KeyDown(sender As Object, e As KeyEventArgs) Handles Button8.KeyDown, Button7.KeyDown
        If e.KeyCode = Keys.F7 Then
            MainFont.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
            TitleFont.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
            MessageFont.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Regular)
            Button7.PerformClick()
        End If
    End Sub
End Class