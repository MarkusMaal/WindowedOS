Public Class MessageDialog
    Public messagetext = ""
    Public messagetitle = ""
    Public messageicon = ""
    Public messagetype = "OKOnly"
    Dim drag As Boolean
    Dim mousey As Integer
    Dim mousex As Integer
    Public composedwindow As Form = New Form()
    Private Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr

    Private Sub MessageDialog_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.TransparencyKey = Nothing
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Opacity = 1.0
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.translucency(Me, composedwindow, True)
        If Desktop.labelBg.BackColor = Nothing Then Desktop.labelBg.BackColor = Form1.labelBg.BackColor
        If Desktop.labelFg.BackColor = Nothing Then Desktop.labelFg.BackColor = Form1.labelFg.BackColor
        If Desktop.appBg.BackColor = Nothing Then Desktop.appBg.BackColor = Form1.appBg.BackColor
        If Desktop.appFg.BackColor = Nothing Then Desktop.appFg.BackColor = Form1.appFg.BackColor
        Label1.BackColor = Desktop.labelBg.BackColor
        Label1.ForeColor = Desktop.labelFg.BackColor
        Me.BackColor = Desktop.appBg.BackColor
        Me.ForeColor = Desktop.appFg.BackColor
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            Dim red As Integer = Me.BackColor.R
            Dim green As Integer = Me.BackColor.G
            Dim blue As Integer = Me.BackColor.B
            red = red - 1
            green = green - 1
            blue = blue - 1
            If red < 0 Then red = 0
            If green < 0 Then green = 0
            If blue < 0 Then blue = 0
            Button1.BackColor = Color.FromArgb(red, green, blue)
            Button2.BackColor = Button1.BackColor
            Button3.BackColor = Button1.BackColor
            Me.TransparencyKey = Desktop.appBg.BackColor
        End If
        Label2.Text = messagetext.ToString()
        Label1.Text = messagetitle.ToString()
        If messagetype = "OKOnly" Then
            Button2.Visible = False
            Button3.Visible = False
            Button1.Visible = True
            GoTo displaymsg
        ElseIf messagetype = "YesNo" Then
            Button2.Visible = True
            Button3.Visible = True
            Button1.Visible = False
            GoTo displaymsg
        Else
            Button2.Visible = False
            Button3.Visible = False
            Button1.Visible = True
            GoTo displaymsg
        End If

displaymsg:
        If messageicon = "Critical" Then
            apiImage.BackgroundImage = My.Resources._error
            Label2.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Point)
            If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_error, AudioPlayMode.Background)
            Exit Sub
        ElseIf messageicon = "Info" Then
            apiImage.BackgroundImage = My.Resources.info
            Label2.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Point)
            If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_ding, AudioPlayMode.Background)
            Exit Sub
        ElseIf messageicon = "Special" Then
            apiImage.BackgroundImage = My.Resources.colors
            Label2.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Point)
            If Form1.es = True Then My.Computer.Audio.Play(My.Resources.startup9, AudioPlayMode.Background)
            Exit Sub
        ElseIf messageicon = "Warning" Then
            apiImage.BackgroundImage = My.Resources.warning
            Label2.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Point)
            If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_exclamation, AudioPlayMode.Background)
            Exit Sub
        ElseIf messageicon = "Help" Then
            apiImage.BackgroundImage = My.Resources.question
            Label2.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular, GraphicsUnit.Point)
            If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_ding, AudioPlayMode.Background)
            Exit Sub
        Else
            apiImage.BackgroundImage = Nothing
            Label2.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Point)
            If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_ding, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'ff.TopMost = True
        'sf.TopMost = True
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Form1.dr = Windows.Forms.DialogResult.OK
        End If
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.fadeout_animation(Me, composedwindow)
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
            composedwindow.Top = Me.Top
            composedwindow.Left = Me.Left
        End If
    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp
        drag = False
        Me.BringToFront()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        'ff.TopMost = True
        'sf.TopMost = True
        composedwindow.Opacity = 0.0
        Me.Opacity = 0.0
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        Else
            Form1.dr = Windows.Forms.DialogResult.Yes
        End If
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.fadeout_animation(Me, composedwindow)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        'ff.TopMost = True
        'sf.TopMost = True
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then
            Me.DialogResult = Windows.Forms.DialogResult.No
        Else
            Form1.dr = Windows.Forms.DialogResult.No
        End If
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.fadeout_animation(Me, composedwindow)
    End Sub

    Private Sub MessageDialog_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible = True Then
            Label2.Font = Desktop.msgfont.Font
        End If
    End Sub
End Class