Public Class GlobalSysConfig
    'enable sound
    Dim es As String
    'global label bg
    Dim glb As String = "Color [DimGray]"
    'global label fg
    Dim glf As String = "Color [White]"
    'global window bg
    Dim gwb As String = "Color [WhiteSmoke]"
    'global window fg
    Dim gwf As String = "Color [Black]"
    'enable desktop composition
    Dim edc As String = "False"

    'enable usernames on login
    Dim eul As String = "True"
    'enable switch button
    Dim esb As String = "True"
    'enable shutdown/restart on login
    Dim esr As String = "True"
    'user background memory
    Dim ubm As String = "True"
    'enable autologin button
    Dim eab As String = "True"
    'enable live mode
    Dim elm As String = "False"
    'welcome message
    Dim wm As String = ""

    'enable loadwindow
    Dim elw As String
    'enable bootscreen
    Dim ebs As String
    'datetime loginscreen
    Dim dtl As String
    Dim mousex As Integer
    Dim mousey As Integer
    Dim drag As Boolean
    Dim composedwindow As Form = New Form()
    Dim rap As Boolean = False
    Private Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr

    Private Sub GlobalSysConfig_Deactivate(sender As Object, e As System.EventArgs) Handles Me.Deactivate
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

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Left
        mousey = Cursor.Position.Y - Top
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
        If drag Then
            Top = Cursor.Position.Y - mousey
            Left = Cursor.Position.X - mousex
            composedwindow.Left = Me.Left
            composedwindow.Top = Me.Top
        End If
    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp
        drag = False
        composedwindow.BringToFront()
        Me.BringToFront()
    End Sub
    Private Sub CheckBox3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            es = "True"
        ElseIf CheckBox3.Checked = False Then
            es = "False"
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            dtl = "True"
        ElseIf CheckBox4.Checked = False Then
            dtl = "False"
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            elw = "True"
        ElseIf CheckBox1.Checked = False Then
            elw = "False"
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            ebs = "True"
        ElseIf CheckBox2.Checked = False Then
            ebs = "False"
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        gwb = Desktop.appBg.BackColor.ToString()
        gwf = Desktop.appFg.BackColor.ToString()
        glb = Desktop.labelBg.BackColor.ToString()
        glf = Desktop.labelFg.BackColor.ToString()
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            edc = "True"
        ElseIf Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then
            edc = "False"
        End If
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        BsBgDialog.FileName = "def"
        PictureBox1.BackgroundImage = My.Resources.startup1
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then
            Me.Close()
        Else
            Form1.fadeout_animation(Me, composedwindow)
        End If
    End Sub

    Private Sub GlobalSysConfig_VisibleChanged(sender As Object, e As System.EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            Form1.Setfont(Me, Label1)
            Label1.BackColor = Desktop.labelBg.BackColor
            Label1.ForeColor = Desktop.labelFg.BackColor
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then
                Me.BackColor = Desktop.appBg.BackColor
            Else
                Form1.Translucency(Me, composedwindow, True)
            End If
            Me.ForeColor = Desktop.appFg.BackColor
        End If
    End Sub

    Private Sub GlobalSysConfig_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
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

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim data As String
        data = es & ";" & glb & ";" & glf & ";" & gwb & ";" & gwf & ";" & elw & ";" & ebs & ";" & dtl & ";" & BsBgDialog.FileName & ";" & GDBDialog.FileName & ";" & edc.ToString() & ";" & eul.ToString() & ";" & esb.ToString() & ";" & esr.ToString() & ";" & ubm.ToString() & ";" & eab.ToString() & ";" & elm.ToString() & ";" & wm & ";"
        My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\system.cfg", data, False)
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then
            Me.Close()
        Else
            Form1.fadeout_animation(Me, composedwindow)
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.TopMost = False
        If BsBgDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.BackgroundImage = Image.FromFile(BsBgDialog.FileName)
        End If
        Me.TopMost = True
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.TopMost = False
        GDBDialog.ShowDialog()
        Me.TopMost = True
    End Sub

    Private Sub GlobalSysConfig_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Opacity = 1.0
        If Form1.es = True Then es = "True"
        If Form1.es = False Then es = "False"
        If es = "False" Then CheckBox3.Checked = False
        If Form1.elw = True Then elw = "True"
        If Form1.elw = False Then elw = "False"
        If elw = "False" Then CheckBox1.Checked = False
        If Form1.dtl = True Then dtl = "True"
        If Form1.dtl = False Then dtl = "False"
        If dtl = "False" Then CheckBox4.Checked = False
        If Form1.ebs = True Then ebs = "True"
        If Form1.ebs = False Then ebs = "False"
        If ebs = "False" Then CheckBox1.Checked = False
        If Form1.esr = True Then esr = "True"
        If Form1.esr = False Then esr = "False"
        If esr = "False" Then CheckBox7.Checked = False
        If Form1.eul = True Then eul = "True"
        If Form1.eul = False Then eul = "False"
        If eul = "False" Then CheckBox5.Checked = False
        If Form1.esb = True Then esb = "True"
        If Form1.esb = False Then esb = "False"
        If esb = "False" Then CheckBox6.Checked = False
        If Form1.ubm = True Then ubm = "True"
        If Form1.ubm = False Then ubm = "False"
        If ubm = "False" Then CheckBox8.Checked = False
        If Form1.eab = True Then eab = "True"
        If Form1.eab = False Then eab = "False"
        If eab = "False" Then CheckBox9.Checked = False
        If Form1.wm = "" Then CheckBox10.Checked = False
        If Form1.wm = "" Then TextBox1.Enabled = False
        If Not Form1.wm = "" Then CheckBox10.Checked = True
        If Not Form1.wm = "" Then TextBox1.Enabled = True
        If Not Form1.wm = "" Then TextBox1.Text = Form1.wm
        wm = Form1.wm
        If Form1.elm = True Then elm = "True"
        If Form1.elm = False Then elm = "False"
        If elm = "True" Then CheckBox11.Checked = True
        glb = Form1.labelBg.BackColor.ToString()
        glf = Form1.labelFg.BackColor.ToString()
        gwb = Form1.appBg.BackColor.ToString()
        gwf = Form1.appFg.BackColor.ToString()
        If Form1.edc = True Then edc = "True"
        If Form1.edc = False Then edc = "False"
        GDBDialog.FileName = Form1.bi
        If Not Form1.bsi = "def" Then
            BsBgDialog.FileName = Form1.bsi
            PictureBox1.BackgroundImage = Image.FromFile(BsBgDialog.FileName)
        End If
    End Sub

    Private Sub TerminateTimer_Tick(sender As Object, e As EventArgs) Handles TerminateTimer.Tick
        If LogoffWindow.Visible = True Then
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Close()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.fadeout_animation(Me, composedwindow)
        ElseIf Desktop.commandkill.Text = "kill" Then
            'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Close()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.fadeout_animation(Me, composedwindow)
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
        If Me.Visible = True Then
            If CustomizationCenter.ApplyTheme.Enabled = True Then
                composedwindow.Hide()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            eul = "True"
            Exit Sub
        Else
            eul = "False"
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            esb = "True"
            Exit Sub
        Else
            esb = "False"
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            esr = "True"
            Exit Sub
        Else
            esr = "False"
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked = True Then
            eab = "True"
            Exit Sub
        Else
            eab = "False"
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked = True Then
            TextBox1.Enabled = True
            TextBox1.Text = "This message will be displayed when the system starts up"
            Exit Sub
        Else
            TextBox1.Text = ""
            TextBox1.Enabled = False
            Exit Sub
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.Checked = True Then
            elm = "True"
            Exit Sub
        Else
            elm = "False"
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        wm = TextBox1.Text
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked = True Then
            ubm = "True"
            Exit Sub
        Else
            ubm = "False"
        End If
    End Sub
End Class