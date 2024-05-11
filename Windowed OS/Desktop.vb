Imports System.IO
Public Class Desktop
    Dim mousex As Integer
    Dim mousey As Integer
    Dim drag As Boolean
    Dim local As Boolean
    Dim silent As Boolean = True
    'theme engine data
    Public appBg As Label = New Label()
    Public appFg As Label = New Label()
    Public labelBg As Label = New Label()
    Public labelFg As Label = New Label()
    'old variable that indicates wheter of not apps have to close
    Public alldown As Boolean
    'username and encrypted password
    Public user As String
    Public passwd As String
    Public docked As Boolean = False
    'determines user type (ie Admin, Guest, Standard User, etc.)
    Public usertype As String
    'cursor backup position
    Public backupos As Point = New Point(0, 0)
    'developer mode
    Public dev As Boolean = True
    Public inverse As Boolean = False
    Public msgfont As Label = New Label()
    Dim sil As Boolean = True
    Dim restorel As Integer = 0
    Dim lst As ListBox = New ListBox()
    Dim tsklst As ListBox = New ListBox()
    Dim code As String = ""
    Dim alltry As Integer = 0
    Public obj As New SecondDisp
    Private Sub RestartToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try
            'hot reboot
            MenuStrip1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            Label1.Visible = False
            Label2.Visible = False
            LogoffWindow.Show()
            Save()
            Windows.Forms.Cursor.Hide()
            Form1.Show()
            Form1.Label2.Visible = False
            StartupWindow.ProgressBar1.Value = 0
            Form1.Timer1.Enabled = True
            Close()
        Catch ex As Exception
            ESOD.Label5.Text = ex.Message
            ESOD.ShowDialog()
        End Try
    End Sub

    Private Sub ShutDownToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ShutDownToolStripMenuItem.Click
        'calls shutdown function and closes all open programs
        LogoffWindow.Show()
        CPU_Tracker.Enabled = False
        Timer1.Enabled = False
        Label1.Text = ""
        Label2.Text = ""
        If Label3.Visible = True Then Label3.Text = "Good bye, " & user & "!"
        If Label4.Visible = True Then Label4.Text = "Closing apps..."
        LogoffWindow.LogoffTitle.Text = "Ending your session"
        LogoffWindow.Label1.Text = "Shutting down..."
        LoginPrompt.Label1.Text = "Shutting down..."
        MenuStrip1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox7.Visible = False
        PictureBox8.Visible = False
        PictureBox9.Visible = False
        PictureBox10.Visible = False
        Timer2.Enabled = False
        Timer3.Enabled = True
    End Sub

    Private Sub StandByToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StandByToolStripMenuItem.Click
        Sleep.Checked = True
        Lock.Show()
        Me.Hide()
    End Sub

    Private Sub NotepadToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try
            'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
            Notepad.Show()
        Catch ex As Exception
            ESOD.Label5.Text = ex.Message
            ESOD.ShowDialog()
        End Try

    End Sub

    Private Sub NotepadToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles NotepadToolStripMenuItem.Click
        Try
            If tskmgr.ListBox1.Items.Contains("Rich Text Notepad") Then
                'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
                Dim myform As Notepad = New Notepad()
                myform.Show()
            Else
                Notepad.RichTextBox1.Text = ""
                tskmgr.ListBox1.Items.Add("Rich Text Notepad")
                'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
                Notepad.Show()
            End If
        Catch ex As Exception
            ESOD.Label5.Text = ex.Message
            ESOD.ShowDialog()
        End Try
    End Sub

    Private Sub ChangeWallpaperToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ChangeWallpaperToolStripMenuItem.Click

    End Sub

    Private Sub SaveDataToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try
            If Notepad.Visible = True Then
                Notepad.Close()
            End If
            If WebBrowser.Visible = True Then
                WebBrowser.Close()
            End If
            tskmgr.Close()
            If MediaPlay.Visible = True Then
                MediaPlay.Close()
            End If
            OpenFileDialog1.FileName = ""
            OpenFileDialog1.FileName = "Factory_reset_request"
            BackgroundImage = My.Resources.f22272576
            MessageDialog.messagetitle = "Reset settings"
            MessageDialog.messagetext = "Data reset successful"
            MessageDialog.messageicon = "Info"
            MessageDialog.ShowDialog()
            MessageDialog.messagetitle = "Reset settings"
            MessageDialog.messagetext = "System will restart now"
            MessageDialog.messageicon = "Warning"
            MessageDialog.ShowDialog()
            Form1.Show()
            Close()
        Catch ex As Exception
            ESOD.Label5.Text = ex.Message
            ESOD.ShowDialog()
        End Try
    End Sub
    'save function
    'saves user data
    'please do not modify this code (unless you are a developer)
    Sub Save(Optional bg As String = "")
        Try
            If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed") Then My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed")
            If usertype = "Admin" Or usertype = "Power" Or usertype = "Standard" Then
                Dim filecontentx As String
                Dim filecontenty As String
                Dim ailecontentx As String
                Dim ailecontenty As String
                Dim bilecontentx As String
                Dim bilecontenty As String
                Dim cilecontentx As String
                Dim cilecontenty As String
                Dim colorlabelBG As String
                Dim colorlabelFG As String
                Dim colorappBG As String
                Dim colorappfg As String
                Dim dock As String = "False"
                Dim cccbg As String = "False"
                filecontentx = PictureBox2.Location.X.ToString()
                filecontenty = PictureBox2.Location.Y.ToString()
                ailecontentx = PictureBox3.Location.X.ToString()
                ailecontenty = PictureBox3.Location.Y.ToString()
                bilecontentx = PictureBox4.Location.X.ToString()
                bilecontenty = PictureBox4.Location.Y.ToString()
                cilecontentx = PictureBox5.Location.X.ToString()
                cilecontenty = PictureBox5.Location.Y.ToString()
                colorlabelBG = labelBg.BackColor.ToString()
                colorlabelFG = labelFg.BackColor.ToString()
                colorappBG = appBg.BackColor.ToString()
                colorappfg = appFg.BackColor.ToString()
                Dim tdp As String = "BottomRight"
                Dim lp As String = "BottomLeft"
                If Label2.Anchor = AnchorStyles.Bottom + AnchorStyles.Left Then tdp = "BottomLeft"
                If Label2.Anchor = AnchorStyles.Bottom Then tdp = "Bottom"
                If Label2.Anchor = AnchorStyles.Bottom + AnchorStyles.Right Then tdp = "BottomRight"
                If Label2.Anchor = AnchorStyles.Left Then tdp = "Left"
                If Label2.Anchor = AnchorStyles.None Then tdp = "None"
                If Label2.Anchor = AnchorStyles.Right Then tdp = "Right"
                If Label2.Anchor = AnchorStyles.Top + AnchorStyles.Left Then tdp = "TopLeft"
                If Label2.Anchor = AnchorStyles.Top Then tdp = "Top"
                If Label2.Anchor = AnchorStyles.Top + AnchorStyles.Right Then tdp = "TopRight"
                If MenuStrip1.Dock = DockStyle.None Then
                    If MenuStrip1.Anchor = AnchorStyles.Bottom + AnchorStyles.Left Then lp = "BottomLeft"
                    If MenuStrip1.Anchor = AnchorStyles.Bottom Then lp = "Bottom"
                    If MenuStrip1.Anchor = AnchorStyles.Bottom + AnchorStyles.Right Then lp = "BottomRight"
                    If MenuStrip1.Anchor = AnchorStyles.Left Then lp = "Left"
                    If MenuStrip1.Anchor = AnchorStyles.None Then lp = "None"
                    If MenuStrip1.Anchor = AnchorStyles.Right Then lp = "Right"
                    If MenuStrip1.Anchor = AnchorStyles.Top + AnchorStyles.Left Then lp = "TopLeft"
                    If MenuStrip1.Anchor = AnchorStyles.Top Then lp = "Top"
                    If MenuStrip1.Anchor = AnchorStyles.Top + AnchorStyles.Right Then lp = "TopRight"
                ElseIf Not MenuStrip1.Dock = DockStyle.None Then
                    dock = "True"
                    If MenuStrip1.Dock = DockStyle.Bottom Then lp = "Bottom"
                    If MenuStrip1.Dock = DockStyle.Left Then lp = "Left"
                    If MenuStrip1.Dock = DockStyle.None Then lp = "None"
                    If MenuStrip1.Dock = DockStyle.Right Then lp = "Right"
                    If MenuStrip1.Dock = DockStyle.Top Then lp = "Top"
                End If
                Dim cpuvis As String = "True"
                If ShowCPUUsageToolStripMenuItem.Checked = False Then cpuvis = "False"
                Dim timevis As String = "True"
                If ShowDateAndTimeToolStripMenuItem.Checked = False Then timevis = "False"
                Dim updatespeed As String
                updatespeed = CPU_Tracker.Interval.ToString()
                'new icons
                Dim posx5 As String = PictureBox6.Location.X.ToString()
                Dim posy5 As String = PictureBox6.Location.Y.ToString()
                Dim posx6 As String = PictureBox7.Location.X.ToString()
                Dim posy6 As String = PictureBox7.Location.Y.ToString()
                Dim posx7 As String = PictureBox8.Location.X.ToString()
                Dim posy7 As String = PictureBox8.Location.Y.ToString()
                Dim posx8 As String = PictureBox9.Location.X.ToString()
                Dim posy8 As String = PictureBox9.Location.Y.ToString()
                Dim posx9 As String = PictureBox10.Location.X.ToString()
                Dim posy9 As String = PictureBox10.Location.Y.ToString()
                Dim hideicons As String = "False"
                If ShowhideIconsToolStripMenuItem.Checked = True Then hideicons = "True"
                Dim data As String
                If RichTextBox1.Text = "Local_1" Then OpenFileDialog1.FileName = "Local_1"
                If RichTextBox1.Text = "Local_2" Then OpenFileDialog1.FileName = "Local_2"
                If RichTextBox1.Text = "Local_3" Then OpenFileDialog1.FileName = "Local_3"
                Dim et As String
                If EnableDesktopCompositionToolStripMenuItem.Checked = True Then et = "True"
                If EnableDesktopCompositionToolStripMenuItem.Checked = False Then et = "False"
                'et must always be assigned, because boolean must be either true or false
                Dim isg As String = "True"
                If ShowgreetingToolStripMenuItem.Checked = True Then isg = "True"
                If ShowgreetingToolStripMenuItem.Checked = False Then isg = "False"
                If Not Label1.BackColor = Color.Transparent Then cccbg = "True"
                data = ""
                If bg = "" Then
                    data = passwd & ";" & filecontentx & ";" & filecontenty & ";" & ailecontentx & ";" & ailecontenty & ";" & bilecontentx & ";" & bilecontenty & ";" & cilecontentx & ";" & cilecontenty & ";" & OpenFileDialog1.FileName & ";" & colorlabelBG & ";" & colorlabelFG & ";" & colorappBG & ";" & colorappfg & ";" & tdp & ";" & lp & ";" & cpuvis & ";" & timevis & ";" & updatespeed & ";" & posx5 & ";" & posy5 & ";" & posx6 & ";" & posy6 & ";" & posx7 & ";" & posy7 & ";" & posx8 & ";" & posy8 & ";" & posx9 & ";" & posy9 & ";" & hideicons & ";" & et & ";" & isg & ";" & dock & ";" & cccbg & ";"
                Else
                    data = passwd & ";" & filecontentx & ";" & filecontenty & ";" & ailecontentx & ";" & ailecontenty & ";" & bilecontentx & ";" & bilecontenty & ";" & cilecontentx & ";" & cilecontenty & ";" & bg & ";" & colorlabelBG & ";" & colorlabelFG & ";" & colorappBG & ";" & colorappfg & ";" & tdp & ";" & lp & ";" & cpuvis & ";" & timevis & ";" & updatespeed & ";" & posx5 & ";" & posy5 & ";" & posx6 & ";" & posy6 & ";" & posx7 & ";" & posy7 & ";" & posx8 & ";" & posy8 & ";" & posx9 & ";" & posy9 & ";" & hideicons & ";" & et & ";" & isg & ";" & dock & ";" & cccbg & ";"
                End If
                My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & user & ".txt", data, False)
                If usertype = "Power" Then My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & user & "_power.txt", "This user is classified as a Power User.", False)
                If usertype = "Admin" Then My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & user & "_admin.txt", "This user is classified as an Administrator.", False)
                If usertype = "Standard" Then My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & user & "_standard.txt", "This user is classified as a Standard User.", False)
            ElseIf usertype = "Limited" Then
                    Dim filecontentx As String
                    Dim filecontenty As String
                    Dim ailecontentx As String
                    Dim ailecontenty As String
                    Dim bilecontentx As String
                    Dim bilecontenty As String
                    Dim cilecontentx As String
                    Dim cilecontenty As String
                    Dim cccbg As String = "False"
                    filecontentx = PictureBox2.Location.X.ToString()
                    filecontenty = PictureBox2.Location.Y.ToString()
                    ailecontentx = PictureBox3.Location.X.ToString()
                    ailecontenty = PictureBox3.Location.Y.ToString()
                    bilecontentx = PictureBox4.Location.X.ToString()
                    bilecontenty = PictureBox4.Location.Y.ToString()
                    cilecontentx = PictureBox5.Location.X.ToString()
                    cilecontenty = PictureBox5.Location.Y.ToString()
                    Dim cpuvis As String = "True"
                    If ShowCPUUsageToolStripMenuItem.Checked = False Then cpuvis = "False"
                    Dim timevis As String = "True"
                    If ShowDateAndTimeToolStripMenuItem.Checked = False Then timevis = "False"
                    Dim updatespeed As String
                    updatespeed = CPU_Tracker.Interval.ToString()
                    'new icons
                    Dim posx5 As String = PictureBox6.Location.X.ToString()
                    Dim posy5 As String = PictureBox6.Location.Y.ToString()
                    Dim posx6 As String = PictureBox7.Location.X.ToString()
                    Dim posy6 As String = PictureBox7.Location.Y.ToString()
                    Dim posx7 As String = PictureBox8.Location.X.ToString()
                    Dim posy7 As String = PictureBox8.Location.Y.ToString()
                    Dim posx8 As String = PictureBox9.Location.X.ToString()
                    Dim posy8 As String = PictureBox9.Location.Y.ToString()
                    Dim posx9 As String = PictureBox10.Location.X.ToString()
                    Dim posy9 As String = PictureBox10.Location.Y.ToString()
                    Dim hideicons As String = "False"
                    If ShowhideIconsToolStripMenuItem.Checked = True Then hideicons = "True"
                    Dim data As String
                    Dim isg As String = "True"
                    If ShowgreetingToolStripMenuItem.Checked = True Then isg = "True"
                    If ShowgreetingToolStripMenuItem.Checked = False Then isg = "False"
                    If Not Label1.BackColor = Color.Transparent Then cccbg = "True"
                    data = passwd & ";" & filecontentx & ";" & filecontenty & ";" & ailecontentx & ";" & ailecontenty & ";" & bilecontentx & ";" & bilecontenty & ";" & cilecontentx & ";" & cilecontenty & ";" & cpuvis & ";" & timevis & ";" & updatespeed & ";" & posx5 & ";" & posy5 & ";" & posx6 & ";" & posy6 & ";" & posx7 & ";" & posy7 & ";" & posx8 & ";" & posy8 & ";" & posx9 & ";" & posy9 & ";" & hideicons & ";" & cccbg & ";" & isg & ";"
                    My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & user & ".txt", data, False)
                    My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & user & "_limited.txt", "This user is classified as a Limited User.", False)
                ElseIf usertype = "Guest" Then
                    Dim data As String
                data = passwd & ";"
                My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & user & ".txt", data, False)
                My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & user & "_guest.txt", "This user is classified as a Guest.", False)
            End If
        Catch ex As Exception
            MessageDialog.messagetitle = "Data save error"
            MessageDialog.messagetext = ex.Message
            MessageDialog.messageicon = "Critical"
            MessageDialog.ShowDialog()
            ESOD.Label5.Text = ex.Message
            ESOD.ShowDialog()
        End Try
    End Sub

    Private Sub LoadDataToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\config.rtf") Then
            RichTextBox1.LoadFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\config.rtf", RichTextBoxStreamType.RichText)
            OpenFileDialog1.FileName = RichTextBox1.Text
            If RichTextBox1.Text = "" Then Exit Sub
            PictureBox1.Load(OpenFileDialog1.FileName)
            BackgroundImage = PictureBox1.Image
        Else
            MessageDialog.messagetitle = "Data load"
            MessageDialog.messagetext = "Data not found!"
            MessageDialog.messageicon = "Warning"
            MessageDialog.ShowDialog()
            Exit Sub
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub


    Private Sub Desktop_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        If Form1.elm = False Then Watermark.Visible = False
        Try
            If File.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & user & "_fonts.txt") Then
                Dim fonts() As String = File.ReadAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & user & "_fonts.txt").Split("::")
                Dim MainFont() As String = fonts(0).Split(";")
                Dim TitleFont() As String = fonts(1).Split(";")
                Dim MessageFont() As String = fonts(2).Split(";")
                ApplyFont(appFg, MainFont)
                ApplyFont(labelFg, TitleFont)
                ApplyFont(msgfont, MessageFont)
                'special cases where font doesn't apply automatically
                MessageDialog.Font = appFg.Font
                MessageDialog.Label1.Font = labelFg.Font
                MessageDialog.Label2.Font = msgfont.Font
                InputBoxDialog.Font = appFg.Font
                InputBoxDialog.Label4.Font = labelFg.Font
                InputBoxDialog.Label1.Font = msgfont.Font
                Label3.Font = New Font(appFg.Font.FontFamily, 16, appFg.Font.Style)
                Label4.Font = New Font(appFg.Font.FontFamily, 12, appFg.Font.Style)
                Label1.Font = New Font(appFg.Font.FontFamily, appFg.Font.Size, appFg.Font.Style)
                Label2.Font = New Font(appFg.Font.FontFamily, appFg.Font.Size, appFg.Font.Style)
                Watermark.Font = New Font(appFg.Font.FontFamily, appFg.Font.Size, appFg.Font.Style)
                MenuStrip1.Font = New Font(labelFg.Font.FontFamily, labelFg.Font.Size, labelFg.Font.Style)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & ex.StackTrace)
        End Try
        Try
            If usertype = "Power" Then
                'check if development.txt exists
                Try
                    If File.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\development.txt") Then
                        'read data from development.txt
                        Dim fontstr As String = File.ReadAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\development.txt")
                        'create an array that stores all items separated using semicolons
                        Dim fontarray() As String = fontstr.Split(";")
                        'imports font family from array, replaces unneccessary text with nothing
                        Dim fontfamily As String = fontarray(0).ToString().Replace("[FontFamily: Name=", "")
                        fontfamily = fontfamily.Replace("]", "")
                        'imports font size
                        Dim fntsize As Integer = Convert.ToDouble(fontarray(1).ToString())
                        'sets the font
                        voide.TextBox1.Font = New Font(fontfamily, fntsize)
                    End If
                Catch
                End Try
            End If
            If Label3.Visible = False Then ShowgreetingToolStripMenuItem.Checked = False
            For ints As Integer = 4 To 11
                If DateTime.Now.Hour = ints Then
                    Label3.Text = "Good morning, " & user & "!"
                End If
            Next
            For ints As Integer = 12 To 15
                If DateTime.Now.Hour = ints Then
                    Label3.Text = "Good afternoon, " & user & "!"
                End If
            Next
            For ints As Integer = 16 To 23
                If DateTime.Now.Hour = ints Then
                    Label3.Text = "Good evening, " & user & "!"
                End If
            Next
            For ints As Integer = 0 To 3
                If DateTime.Now.Hour = ints Then
                    Label3.Text = "Hello " & user & "!"
                End If
            Next
            tsklst.Items.Clear()
            For l As Integer = 0 To tskmgr.ListBox1.Items.Count - 1
                tskmgr.ListBox1.SelectedIndex = l
                tsklst.Items.Add(tskmgr.ListBox1.SelectedItem)
            Next
            Label4.Text = "Checking for updates..."
            'appBg.BackColor = Color.WhiteSmoke
            'appFg.BackColor = Color.Black
            'labelBg.BackColor = Color.DimGray
            'labelFg.BackColor = Color.White
            If silent = True And Form1.updatechecked = False Then
                CheckForUpdatesToolStripMenuItem.PerformClick()
                Form1.updatechecked = True
            End If
            If dev = False Then ShowEverythingToolStripMenuItem.Visible = False
            If dev = True Then
                SolitaireToolStripMenuItem.Visible = True
                NewLoginToolStripMenuItem.Visible = True
                RethemeWindowsToolStripMenuItem.Visible = True
            End If
            If StartupWindow.Visible = True Then StartupWindow.Close()
            EnableDesktopCompositionToolStripMenuItem.Visible = True
            If usertype = "Standard" Then
                CommandExecuterToolStripMenuItem.Visible = False
                PictureBox6.Visible = False
            ElseIf usertype = "Limited" Or usertype = "Guest" Then
                If Form1.edc = True Then EnableDesktopCompositionToolStripMenuItem.Checked = True
                If Form1.edc = False Then EnableDesktopCompositionToolStripMenuItem.Checked = False
                CommandExecuterToolStripMenuItem.Visible = False
                ChangeWallpaperToolStripMenuItem.Visible = False
                ChangeThemeToolStripMenuItem.Visible = False
                PictureBox6.Visible = False
                EnableDesktopCompositionToolStripMenuItem.Visible = False
            End If
            If Label2.Visible = False Then ShowCPUUsageToolStripMenuItem.Checked = False
            If Label1.Visible = False Then ShowDateAndTimeToolStripMenuItem.Checked = False
            If ShowhideIconsToolStripMenuItem.Checked = True Then
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                PictureBox5.Visible = False
                PictureBox6.Visible = False
                PictureBox7.Visible = False
                PictureBox8.Visible = False
                PictureBox9.Visible = False
                PictureBox10.Visible = False
            End If
            MenuStrip1.BackColor = labelBg.BackColor
            MenuStrip1.ForeColor = labelFg.BackColor
            Me.WindowState = FormWindowState.Normal
            If CustomizationCenter.TopLeftButton.Checked = True Then
                MenuStrip1.Location = New Point(1, 1)
                MenuStrip1.Anchor = AnchorStyles.Top + AnchorStyles.Left
                MenuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow
            ElseIf CustomizationCenter.TopButton.Checked = True Then
                MenuStrip1.Location = New Point(230, 1)
                MenuStrip1.Dock = DockStyle.Top
                MenuStrip1.Anchor = AnchorStyles.Top
                MenuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow
            ElseIf CustomizationCenter.TopRightButton.Checked = True Then
                MenuStrip1.Location = New Point(472, 1)
                MenuStrip1.Anchor = AnchorStyles.Top + AnchorStyles.Right
                MenuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow
            ElseIf CustomizationCenter.LeftButton.Checked = True Then
                MenuStrip1.Location = New Point(1, 197)
                MenuStrip1.Anchor = AnchorStyles.Left
                MenuStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow
            ElseIf CustomizationCenter.NoneButton.Checked = True Then
                MenuStrip1.Location = New Point(229, 202)
                MenuStrip1.Anchor = AnchorStyles.None
                MenuStrip1.LayoutStyle = ToolStripLayoutStyle.Flow
            ElseIf CustomizationCenter.RightButton.Checked = True Then
                MenuStrip1.Location = New Point(502, 202)
                MenuStrip1.Anchor = AnchorStyles.Right
                MenuStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow
            ElseIf CustomizationCenter.BottomLeftButton.Checked = True Then
                MenuStrip1.Location = New Point(0, 400)
                MenuStrip1.Anchor = AnchorStyles.Bottom + AnchorStyles.Left
                MenuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow
            ElseIf CustomizationCenter.BottomButton.Checked = True Then
                MenuStrip1.Location = New Point(238, 400)
                MenuStrip1.Anchor = AnchorStyles.Bottom
                MenuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow
            ElseIf CustomizationCenter.BottomRightButton.Checked = True Then
                MenuStrip1.Location = New Point(472, 400)
                MenuStrip1.Anchor = AnchorStyles.Bottom + AnchorStyles.Right
                MenuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow
            End If
            If CustomizationCenter.BottomRight.Checked = True Then
                Label1.Location = New Point(631, 410)
                Label2.Location = New Point(631, 398)
                Label1.TextAlign = ContentAlignment.BottomRight
                Label2.TextAlign = ContentAlignment.BottomRight
                Label1.Anchor = AnchorStyles.Bottom + AnchorStyles.Right
                Label2.Anchor = AnchorStyles.Bottom + AnchorStyles.Right
            ElseIf CustomizationCenter.BottomBtn.Checked = True Then
                Label1.Location = New Point(319, 410)
                Label2.Location = New Point(319, 398)
                Label1.TextAlign = ContentAlignment.BottomCenter
                Label2.TextAlign = ContentAlignment.BottomCenter
                Label1.Anchor = AnchorStyles.Bottom
                Label2.Anchor = AnchorStyles.Bottom
            ElseIf CustomizationCenter.BottomLeft.Checked = True Then
                Label1.Location = New Point(2, 410)
                Label2.Location = New Point(2, 398)
                Label1.TextAlign = ContentAlignment.BottomLeft
                Label2.TextAlign = ContentAlignment.BottomLeft
                Label1.Anchor = AnchorStyles.Bottom + AnchorStyles.Left
                Label2.Anchor = AnchorStyles.Bottom + AnchorStyles.Left
            ElseIf CustomizationCenter.LeftBtn.Checked = True Then
                Label1.Location = New Point(2, 218)
                Label2.Location = New Point(2, 206)
                Label1.TextAlign = ContentAlignment.MiddleLeft
                Label2.TextAlign = ContentAlignment.MiddleLeft
                Label1.Anchor = AnchorStyles.Left
                Label2.Anchor = AnchorStyles.Left
            ElseIf CustomizationCenter.None.Checked = True Then
                Label1.Location = New Point(309, 218)
                Label2.Location = New Point(309, 206)
                Label1.TextAlign = ContentAlignment.MiddleCenter
                Label2.TextAlign = ContentAlignment.MiddleCenter
                Label1.Anchor = AnchorStyles.None
                Label2.Anchor = AnchorStyles.None
            ElseIf CustomizationCenter.RightBtn.Checked = True Then
                Label1.Location = New Point(631, 218)
                Label2.Location = New Point(631, 206)
                Label1.TextAlign = ContentAlignment.MiddleRight
                Label2.TextAlign = ContentAlignment.MiddleRight
                Label1.Anchor = AnchorStyles.Right
                Label2.Anchor = AnchorStyles.Right
            ElseIf CustomizationCenter.TopLeft.Checked = True Then
                Label1.Location = New Point(4, 16)
                Label2.Location = New Point(4, 4)
                Label1.TextAlign = ContentAlignment.TopLeft
                Label2.TextAlign = ContentAlignment.TopLeft
                Label1.Anchor = AnchorStyles.Top + AnchorStyles.Left
                Label2.Anchor = AnchorStyles.Top + AnchorStyles.Left
            ElseIf CustomizationCenter.TopBtn.Checked = True Then
                Label1.Location = New Point(301, 21)
                Label2.Location = New Point(301, 9)
                Label1.TextAlign = ContentAlignment.TopCenter
                Label2.TextAlign = ContentAlignment.TopCenter
                Label1.Anchor = AnchorStyles.Top
                Label2.Anchor = AnchorStyles.Top
            ElseIf CustomizationCenter.TopRight.Checked = True Then
                Label1.Location = New Point(630, 15)
                Label2.Location = New Point(630, 3)
                Label1.TextAlign = ContentAlignment.TopRight
                Label2.TextAlign = ContentAlignment.TopRight
                Label1.Anchor = AnchorStyles.Top + AnchorStyles.Right
                Label2.Anchor = AnchorStyles.Top + AnchorStyles.Right
            End If
            Me.WindowState = FormWindowState.Maximized
            Cursor.Show()
            If dev = False Then DebugToolStripMenuItem.Visible = False
            If dev = True Then devd.Visible = True
            If dev = True Then MessageBoxTestToolStripMenuItem.Visible = True
            alldown = False
            Timer1.Enabled = True
            MediaPlay.TimeTracker.Enabled = True
            CPU_Tracker.Enabled = True
            lst.Items.Clear()
            If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Programs") Then
                For Each wpk As String In Directory.EnumerateFiles(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Programs")
                    lst.Items.Add(wpk)
                Next
                Label4.Text = "Initializing apps..."
                waitasectimer.Enabled = True
            Else
                sil = False
            End If
            If docked = True Then
                If MenuStrip1.Anchor = AnchorStyles.Bottom + AnchorStyles.Left Then MenuStrip1.Anchor = AnchorStyles.Bottom
                If MenuStrip1.Anchor = AnchorStyles.Bottom + AnchorStyles.Right Then MenuStrip1.Anchor = AnchorStyles.Bottom
                If MenuStrip1.Anchor = AnchorStyles.Top + AnchorStyles.Left Then MenuStrip1.Anchor = AnchorStyles.Top
                If MenuStrip1.Anchor = AnchorStyles.Top + AnchorStyles.Right Then MenuStrip1.Anchor = AnchorStyles.Top
                Dim vua As String = MenuStrip1.Anchor.ToString()
                If vua = "Top" Then
                    MenuStrip1.Anchor = AnchorStyles.Top + AnchorStyles.Left
                    MenuStrip1.Dock = DockStyle.Top
                ElseIf vua = "Left" Then
                    MenuStrip1.Anchor = AnchorStyles.Top + AnchorStyles.Left
                    MenuStrip1.Dock = DockStyle.Left
                ElseIf vua = "Right" Then
                    MenuStrip1.Anchor = AnchorStyles.Top + AnchorStyles.Left
                    MenuStrip1.Dock = DockStyle.Right
                ElseIf vua = "Bottom" Then
                    MenuStrip1.Anchor = AnchorStyles.Top + AnchorStyles.Left
                    MenuStrip1.Dock = DockStyle.Bottom
                Else
                    MenuStrip1.Anchor = AnchorStyles.Top + AnchorStyles.Left
                    MenuStrip1.Dock = DockStyle.Fill
                End If
            End If
            If inverse = True Then
                Dim inversed As Color = Color.FromArgb(Not labelFg.BackColor.R, Not labelFg.BackColor.G, Not labelFg.BackColor.B)
                Label1.BackColor = inversed
                Label2.BackColor = inversed
                Label3.BackColor = inversed
                Label4.BackColor = inversed
            End If
            Label1.ForeColor = labelFg.BackColor
            Label2.ForeColor = labelFg.BackColor
            Label3.ForeColor = labelFg.BackColor
            Label4.ForeColor = labelFg.BackColor
            If MenuStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow Then
                PowerToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image
                ViewToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image
                ProgramsToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image
                SettingsToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image
                AboutToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image
            Else
                PowerToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text
                ViewToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text
                ProgramsToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text
                SettingsToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text
                AboutToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text
            End If

        Catch ex As Exception
            StatusMessageUpdater.Enabled = False
        End Try
    End Sub
    'This simple function applies the font theme to a specified object
    Sub ApplyFont(ByVal ctrl As Label, ByVal lst() As String)
        Try
            Dim mfs As FontStyle = New FontStyle()
            Dim mb As Boolean = ToBoolean(lst(2))
            Dim mi As Boolean = ToBoolean(lst(3))
            Dim mu As Boolean = ToBoolean(lst(4))
            If mb = False Then
                If mi = False Then
                    If mu = False Then
                        mfs = FontStyle.Regular
                    End If
                End If
            End If
            If mb = True Then
                If mi = False Then
                    If mu = False Then
                        mfs = FontStyle.Bold
                    Else
                        mfs = FontStyle.Bold + FontStyle.Underline
                    End If
                Else
                    If mu = False Then
                        mfs = FontStyle.Italic + FontStyle.Bold
                    Else
                        mfs = FontStyle.Italic + FontStyle.Bold + FontStyle.Underline
                    End If
                End If
            End If
            ctrl.Font = New Font(lst(0).ToString(), Convert.ToSingle(lst(1).ToString()), mfs)
        Catch
        End Try
    End Sub
    'Converts a string to a boolean
    Private Function ToBoolean(ByVal str As String)
        Dim bool As Boolean = False
        If str = "True" Then bool = True
        If str = "False" Then bool = False
        Return bool
    End Function
    Sub Outfunction(ByVal lst As ListBox)
        If usertype = "Power" Then VoideIDEToolStripMenuItem.Visible = True
        'If usertype = "Guest" Then InstallAnApplicationToolStripMenuItem.Visible = False
        'If usertype = "Limited" Then InstallAnApplicationToolStripMenuItem.Visible = False
        For i As Integer = 0 To lst.Items.Count - 1
            lst.SelectedIndex = i
            InstallAppDialog.FileName = lst.SelectedItem.ToString()
            'InstallAnApplicationToolStripMenuItem.Visible = True
            InstallAnApplicationToolStripMenuItem.PerformClick()
            'InstallAnApplicationToolStripMenuItem.Visible = False
        Next
        'If VoideIDEToolStripMenuItem.Visible = True Then InstallAnApplicationToolStripMenuItem.Visible = True
    End Sub
    Sub Recalibrate()
        If CustomizationCenter.BottomLeftButton.Checked = False Then
            MenuStrip1.Location = New Point(1, 1)
            MenuStrip1.Anchor = AnchorStyles.Bottom + AnchorStyles.Left
            MenuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow
            Exit Sub
        ElseIf CustomizationCenter.BottomLeftButton.Checked = True Then
            MenuStrip1.Location = New Point(1, 1)
            MenuStrip1.Anchor = AnchorStyles.Bottom + AnchorStyles.Right
            MenuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow
        End If
    End Sub

    Private Sub Desktop_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Click
        If MenuStrip1.Visible = True Then
            MenuStrip1.Visible = False
        Else
            If LogoffWindow.Visible = True Then Exit Sub
            MenuStrip1.Visible = True
        End If
    End Sub

    Private Sub WebBrowserToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles WebBrowserToolStripMenuItem.Click
        If tskmgr.ListBox1.Items.Contains("Web Explorer") Then
            'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
            Dim myform As WebBrowser = New WebBrowser
            myform.Show()
        Else
            tskmgr.ListBox1.Items.Add("Web Explorer")
            'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
            WebBrowser.Show()
            WebBrowser.TextBox1.Text = "http://www.google.com"
            WebBrowser.WebBrowser1.Navigate(WebBrowser.TextBox1.Text)
        End If
    End Sub

    Private Sub MediaPlayerToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MediaPlayerToolStripMenuItem.Click
        If tskmgr.ListBox1.Items.Contains("Media Player") Then
            'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
            Dim myform As MediaPlay = New MediaPlay
            myform.Show()
        Else
            'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
            tskmgr.ListBox1.Items.Add("Media Player")
            MediaPlay.Show()
        End If
    End Sub

    Private Sub WebBrowserToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs)
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
        WebBrowser.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        Label1.Text = CType(Now, String)
    End Sub

    Private Sub Label1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label1.Click
        Dim inversed As Color = Color.FromArgb(Not Label1.ForeColor.R, Not Label1.ForeColor.G, Not Label1.ForeColor.B)
        If Label1.BackColor = Color.Transparent Then
            Label1.BackColor = inversed
            Label2.BackColor = inversed
            CustomizationCenter.CheckBox2.Checked = True
        Else
            Label1.BackColor = Color.Transparent
            Label2.BackColor = Color.Transparent
            CustomizationCenter.CheckBox2.Checked = False
        End If
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AboutToolStripMenuItem1.Click
        MessageDialog.messagetitle = "About"
        MessageDialog.messagetext = "Windowed O/S 1.1f"
        MessageDialog.messageicon = "Info"
        MessageDialog.ShowDialog()
    End Sub

    Private Sub FasterslowPerformanceToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles FasterslowPerformanceToolStripMenuItem.Click
        Timer1.Interval = 100
        CPU_Tracker.Interval = 100
    End Sub

    Private Sub BalanceddefaultToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BalanceddefaultToolStripMenuItem.Click
        Timer1.Interval = 300
        CPU_Tracker.Interval = 300
    End Sub

    Private Sub SlowerfasterPerformanceToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SlowerfasterPerformanceToolStripMenuItem.Click
        Timer1.Interval = 500
        CPU_Tracker.Interval = 500
    End Sub

    Private Sub SlowestinaccurateToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SlowestinaccurateToolStripMenuItem.Click
        Timer1.Interval = 1000
        CPU_Tracker.Interval = 1000
    End Sub

    Private Sub TaskManagerToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TaskManagerToolStripMenuItem.Click
        If tskmgr.Visible = False Then
            'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
            tskmgr.Show()
            Exit Sub
        End If
        If tskmgr.Visible = True Then
            'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
            Dim myform As tskmgr = New tskmgr
            myform.Show()
        End If
    End Sub

    Private Sub MediaPlayerToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs)
        If MediaPlay.Visible = False Then
            'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
            MediaPlay.Show()
        End If
        If MediaPlay.Visible = True Then
            'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
            Dim myform As MediaPlay = New MediaPlay
            myform.Show()
        End If
    End Sub

    Private Sub SuToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SuToolStripMenuItem.Click
        Timer1.Interval = 1
        CPU_Tracker.Interval = 1
    End Sub

    Private Sub CPU_Tracker_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles CPU_Tracker.Tick
        If code = "upupdowndownleftrightleftrightba" Then
            If dev = False Then
                dev = True
                devd.Visible = True
                DebugToolStripMenuItem.Visible = True
                MessageBoxTestToolStripMenuItem.Visible = True
                DevelopmentToolStripMenuItem.Visible = True
                ShowEverythingToolStripMenuItem.Visible = True
                SolitaireToolStripMenuItem.Visible = True
                NewLoginToolStripMenuItem.Visible = True
                RethemeWindowsToolStripMenuItem.Visible = True
                Exit Sub
            ElseIf dev = True Then
                dev = False
                devd.Visible = False
                DebugToolStripMenuItem.Visible = False
                MessageBoxTestToolStripMenuItem.Visible = False
                DevelopmentToolStripMenuItem.Visible = False
                ShowEverythingToolStripMenuItem.Visible = False
                SolitaireToolStripMenuItem.Visible = False
                NewLoginToolStripMenuItem.Visible = False
                RethemeWindowsToolStripMenuItem.Visible = False
                Exit Sub
            End If
        ElseIf code.StartsWith("right") Then
            code = ""
        ElseIf code.StartsWith("left") Then
            code = ""
        ElseIf code.StartsWith("down") Then
            code = ""
        ElseIf code.StartsWith("b") Then
            code = ""
        ElseIf code.StartsWith("a") Then
            code = ""
        End If
        If Me.Visible = True Then
            If LoginPrompt.Visible = True Then
                LoginPrompt.Close()
            End If
            If NewLogin.Visible = True Then
                NewLogin.Close()
            End If
        End If
        Dim CPU_value As Integer
        CPU_value = CInt(CPU.NextValue)
        If CPU_value > 60 Then
            Label2.ForeColor = Color.Red
        Else
            Label2.ForeColor = Label1.ForeColor
        End If
        Label2.Text = "CPU: " & CPU_value.ToString & "%"
        If OfficeToolStripMenuItem.HasDropDownItems = True Then OfficeToolStripMenuItem.Visible = True
        If EducationToolStripMenuItem.HasDropDownItems = True Then EducationToolStripMenuItem.Visible = True
        If GraphicsToolStripMenuItem.HasDropDownItems = True Then GraphicsToolStripMenuItem.Visible = True
        If MiscToolStripMenuItem.HasDropDownItems = True Then MiscToolStripMenuItem.Visible = True
        If UtilitiesToolStripMenuItem.HasDropDownItems = True Then UtilitiesToolStripMenuItem.Visible = True
    End Sub

    Private Sub ChangeUsernamepasswordToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
        New_name_password.Show()
    End Sub

    Private Sub DesktopTextToolStripMenuItem_Click_1(ByVal sender As Object, ByVal e As EventArgs)
        ThemeColorDialog1.Color = Label1.ForeColor
        If ThemeColorDialog1.ShowDialog = DialogResult.OK Then
            Label1.ForeColor = ThemeColorDialog1.Color
            Label2.ForeColor = ThemeColorDialog1.Color
        Else
            Exit Sub
        End If
    End Sub

    Private Sub WindowToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ThemeColorDialog1.Color = Notepad.BackColor
        If ThemeColorDialog1.ShowDialog = DialogResult.OK Then
            appBg.BackColor = ThemeColorDialog1.Color
            Apply()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub WindowTextToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ThemeColorDialog1.Color = Notepad.ForeColor
        If ThemeColorDialog1.ShowDialog = DialogResult.OK Then
            appFg.BackColor = ThemeColorDialog1.Color
            Apply()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub WindowBorderToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ThemeColorDialog1.Color = Notepad.Label1.ForeColor
        If ThemeColorDialog1.ShowDialog = DialogResult.OK Then
            labelFg.BackColor = ThemeColorDialog1.Color
            Apply()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub WindowLabelBGToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ThemeColorDialog1.Color = Notepad.Label1.BackColor
        If ThemeColorDialog1.ShowDialog = DialogResult.OK Then
            labelBg.BackColor = ThemeColorDialog1.Color
            Apply()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ResetToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        labelBg.BackColor = Color.DimGray
        labelFg.BackColor = Color.White
        appBg.BackColor = Color.WhiteSmoke
        appFg.BackColor = Color.Black
        Apply()
    End Sub

    Private Sub PictureViewToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PictureViewToolStripMenuItem.Click
        If tskmgr.ListBox1.Items.Contains("Picture View") Then
            MessageDialog.messagetitle = "Windowed OS"
            MessageDialog.messagetext = "Picture viewer is already open"
            MessageDialog.messageicon = "Warning"
            MessageDialog.ShowDialog()
            Exit Sub
        Else
            'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
            tskmgr.ListBox1.Items.Add("Picture View")
            PictureViewer.Show()
        End If
    End Sub

    Private Sub ShowCPUUsageToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ShowCPUUsageToolStripMenuItem.Click
        If Label2.Visible = True Then
            Label2.Visible = False
            CPU_Tracker.Enabled = False
            ShowCPUUsageToolStripMenuItem.Checked = False
        Else
            Label2.Visible = True
            CPU_Tracker.Enabled = True
            ShowCPUUsageToolStripMenuItem.Checked = True
        End If
    End Sub

    Private Sub ShowDateAndTimeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ShowDateAndTimeToolStripMenuItem.Click
        If Label1.Visible = True Then
            Label1.Visible = False
            Timer1.Enabled = False
            ShowDateAndTimeToolStripMenuItem.Checked = False
        Else
            Label1.Visible = True
            Timer1.Enabled = True
            ShowDateAndTimeToolStripMenuItem.Checked = True
        End If
    End Sub

    Private Sub PictureViewToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs)
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
        PictureViewer.Show()
    End Sub

    Private Sub TicTacToeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TicTacToeToolStripMenuItem.Click
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
        TicTacToe.Show()
    End Sub

    Private Sub TicTacToeToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs)
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
        TicTacToe.Show()
    End Sub

    Private Sub ClickItToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ClickItToolStripMenuItem.Click
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
        ClickIt.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PictureBox2.Click
        PictureBox2.BackColor = Color.Blue
    End Sub

    Private Sub PictureBox2_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox2.MouseMove
        PictureBox2.BackColor = Color.SkyBlue
        PictureBox2.BringToFront()
        If drag Then
            PictureBox2.Top = Cursor.Position.Y - mousey - 20
            PictureBox2.Left = Cursor.Position.X - mousex - 20
        End If
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox2_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles PictureBox2.DoubleClick
        If tskmgr.ListBox1.Items.Contains("Media Player") Then
            Exit Sub
        Else
            'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
            tskmgr.ListBox1.Items.Add("Media Player")
            MediaPlay.Show()
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox3_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox3.MouseMove
        PictureBox3.BackColor = Color.SkyBlue
        PictureBox3.BringToFront()

        If drag Then
            PictureBox3.Top = Cursor.Position.Y - mousey - 20
            PictureBox3.Left = Cursor.Position.X - mousex - 20
        End If
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox3_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles PictureBox3.DoubleClick
        If tskmgr.ListBox1.Items.Contains("Web Explorer") Then
            Exit Sub
        Else
            'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
            tskmgr.ListBox1.Items.Add("Web Explorer")
            WebBrowser.Show()
        End If
    End Sub

    Private Sub PictureBox5_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox5.MouseMove
        PictureBox5.BackColor = Color.SkyBlue
        PictureBox5.BringToFront()

        If drag Then
            PictureBox5.Top = Cursor.Position.Y - mousey - 20
            PictureBox5.Left = Cursor.Position.X - mousex - 20
        End If
    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles PictureBox5.MouseLeave
        PictureBox5.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox5_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles PictureBox5.DoubleClick
        If tskmgr.ListBox1.Items.Contains("Rich Text Notepad") Then
            MessageDialog.messagetitle = "Windowed OS"
            MessageDialog.messagetext = "Notepad is already open"
            MessageDialog.messageicon = "Warning"
            MessageDialog.ShowDialog()
            Exit Sub
        Else
            'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
            Notepad.RichTextBox1.Text = ""
            tskmgr.ListBox1.Items.Add("Rich Text Notepad")
            Notepad.Show()
        End If
    End Sub

    Private Sub PictureBox4_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles PictureBox4.DoubleClick
        If tskmgr.ListBox1.Items.Contains("Picture View") Then
            MessageDialog.messagetitle = "Windowed OS"
            MessageDialog.messagetext = "Picture view is already open"
            MessageDialog.messageicon = "Warning"
            MessageDialog.ShowDialog()
            Exit Sub
        Else
            'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
            tskmgr.ListBox1.Items.Add("Picture View")
            PictureViewer.Show()
        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub PictureBox4_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox4.MouseMove
        PictureBox4.BackColor = Color.SkyBlue
        PictureBox4.BringToFront()
        If drag Then
            PictureBox4.Top = Cursor.Position.Y - mousey - 20
            PictureBox4.Left = Cursor.Position.X - mousex - 20
        End If
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.BackColor = Color.Transparent
    End Sub

    Private Sub ProgramsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ProgramsToolStripMenuItem.Click

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub PictureBox2_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox2.MouseDown
        drag = True
        mousex = PictureBox2.Location.X - PictureBox2.Left
        mousey = PictureBox2.Location.Y - PictureBox2.Top
    End Sub

    Private Sub PictureBox2_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox2.MouseUp
        drag = False
    End Sub

    Private Sub PictureBox3_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox3.MouseDown
        drag = True
        mousex = PictureBox3.Location.X - PictureBox3.Left
        mousey = PictureBox3.Location.Y - PictureBox3.Top
    End Sub

    Private Sub PictureBox3_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox3.MouseUp
        drag = False
    End Sub

    Private Sub PictureBox4_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox4.MouseDown
        drag = True
        mousex = PictureBox4.Location.X - PictureBox4.Left
        mousey = PictureBox4.Location.Y - PictureBox4.Top
    End Sub

    Private Sub PictureBox4_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox4.MouseUp
        drag = False
    End Sub

    Private Sub PictureBox5_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox5.MouseDown
        drag = True
        mousex = PictureBox5.Location.X - PictureBox5.Left
        mousey = PictureBox5.Location.Y - PictureBox5.Top
    End Sub

    Private Sub PictureBox5_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox5.MouseUp
        drag = False
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs)
        PictureBox5.Visible = False
    End Sub

    Private Sub ContextMenuStrip2_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As Object, ByVal e As EventArgs)
        If PictureBox4.BackColor = Color.SkyBlue Then
            PictureBox4.Visible = False
        ElseIf PictureBox5.BackColor = Color.SkyBlue Then
            PictureBox5.Visible = False
        ElseIf PictureBox2.BackColor = Color.SkyBlue Then
            PictureBox2.Visible = False
        ElseIf PictureBox3.BackColor = Color.SkyBlue Then
            PictureBox3.Visible = False
        ElseIf PictureBox6.BackColor = Color.SkyBlue Then
            PictureBox6.Visible = False
        ElseIf PictureBox7.BackColor = Color.SkyBlue Then
            PictureBox7.Visible = False
        ElseIf PictureBox8.BackColor = Color.SkyBlue Then
            PictureBox8.Visible = False
        ElseIf PictureBox9.BackColor = Color.SkyBlue Then
            PictureBox9.Visible = False
        ElseIf PictureBox10.BackColor = Color.SkyBlue Then
            PictureBox10.Visible = False
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As Object, ByVal e As EventArgs)
        PictureBox3.Visible = False
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As Object, ByVal e As EventArgs)
        PictureBox2.Visible = False
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripMenuItem5.Click
        If PictureBox2.Visible = True Then
            PictureBox2.Visible = False
            PictureBox2.Visible = True
        End If
        If PictureBox3.Visible = True Then
            PictureBox3.Visible = False
            PictureBox3.Visible = True
        End If
        If PictureBox4.Visible = True Then
            PictureBox4.Visible = False
            PictureBox4.Visible = True
        End If
        If PictureBox5.Visible = True Then
            PictureBox5.Visible = False
            PictureBox5.Visible = True
        End If
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripMenuItem6.Click
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox7.Visible = False
        PictureBox8.Visible = False
        PictureBox9.Visible = False
        PictureBox10.Visible = False
        MenuStrip1.Visible = False
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        PictureBox4.Visible = True
        PictureBox5.Visible = True
        MenuStrip1.Visible = True
        PictureBox6.Visible = True
        PictureBox7.Visible = True
        PictureBox8.Visible = True
        PictureBox9.Visible = True
        PictureBox10.Visible = True
    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripMenuItem7.Click
        ChangeWallpaperToolStripMenuItem.PerformClick()
    End Sub

    Private Sub Label2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label2.Click
        Dim inversed As Color = Color.FromArgb(Not Label2.ForeColor.R, Not Label2.ForeColor.G, Not Label2.ForeColor.B)
        If Label2.BackColor = Color.Transparent Then
            Label2.BackColor = inversed
            Label1.BackColor = inversed
            CustomizationCenter.CheckBox2.Checked = True
        Else
            Label2.BackColor = Color.Transparent
            Label1.BackColor = Color.Transparent
            CustomizationCenter.CheckBox2.Checked = False
        End If
    End Sub

    Private Sub ViewToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ViewToolStripMenuItem.Click

    End Sub

    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer2.Tick
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            black.Close()
        Else
            ProgressBar1.Increment(50)
        End If
    End Sub

    Private Sub BrowseToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BrowseToolStripMenuItem.Click
        If WebBrowser.Visible = True Then WebBrowser.TopMost = False
        If MediaPlay.Visible = True Then MediaPlay.TopMost = False
        If Notepad.Visible = True Then Notepad.TopMost = False
        If PictureViewer.Visible = True Then PictureViewer.TopMost = False
        If tskmgr.Visible = True Then tskmgr.TopMost = False
        If TicTacToe.Visible = True Then TicTacToe.TopMost = False
        If ClickIt.Visible = True Then ClickIt.TopMost = False
        Try
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                RichTextBox1.Text = RichTextBox1.Text & OpenFileDialog1.FileName
                PictureBox1.Load(OpenFileDialog1.FileName)
                BackgroundImage = PictureBox1.Image
                Save()
                If WebBrowser.Visible = True Then WebBrowser.TopMost = True
                If MediaPlay.Visible = True Then MediaPlay.TopMost = True
                If Notepad.Visible = True Then Notepad.TopMost = True
                If PictureViewer.Visible = True Then PictureViewer.TopMost = True
                If tskmgr.Visible = True Then tskmgr.TopMost = True
                If TicTacToe.Visible = True Then TicTacToe.TopMost = True
                If ClickIt.Visible = True Then ClickIt.TopMost = True
            Else
                Exit Sub
            End If
        Catch ex As Exception
            ESOD.Label5.Text = "Failed to open dialog." & vbNewLine & ex.Message
        End Try

    End Sub

    Private Sub LocalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LocalToolStripMenuItem.Click

    End Sub

    Private Sub FlowersdefaultToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles FlowersdefaultToolStripMenuItem.Click
        If WebBrowser.Visible = True Then WebBrowser.TopMost = False
        If MediaPlay.Visible = True Then MediaPlay.TopMost = False
        If Notepad.Visible = True Then Notepad.TopMost = False
        If PictureViewer.Visible = True Then PictureViewer.TopMost = False
        If tskmgr.Visible = True Then tskmgr.TopMost = False
        If TicTacToe.Visible = True Then TicTacToe.TopMost = False
        If ClickIt.Visible = True Then ClickIt.TopMost = False
        RichTextBox1.Text = "Local_1"
        OpenFileDialog1.FileName = "Local_1"
        PictureBox1.Image = My.Resources.f16929280
        BackgroundImage = PictureBox1.Image
        local = True
        Save()
        If WebBrowser.Visible = True Then WebBrowser.TopMost = True
        If MediaPlay.Visible = True Then MediaPlay.TopMost = True
        If Notepad.Visible = True Then Notepad.TopMost = True
        If PictureViewer.Visible = True Then PictureViewer.TopMost = True
        If tskmgr.Visible = True Then tskmgr.TopMost = True
        If TicTacToe.Visible = True Then TicTacToe.TopMost = True
        If ClickIt.Visible = True Then ClickIt.TopMost = True
    End Sub

    Private Sub BluePurseToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BluePurseToolStripMenuItem.Click
        If WebBrowser.Visible = True Then WebBrowser.TopMost = False
        If MediaPlay.Visible = True Then MediaPlay.TopMost = False
        If Notepad.Visible = True Then Notepad.TopMost = False
        If PictureViewer.Visible = True Then PictureViewer.TopMost = False
        If tskmgr.Visible = True Then tskmgr.TopMost = False
        If TicTacToe.Visible = True Then TicTacToe.TopMost = False
        If ClickIt.Visible = True Then ClickIt.TopMost = False
        RichTextBox1.Text = "Local_2"
        OpenFileDialog1.FileName = "Local_2"
        PictureBox1.Image = My.Resources.f22272576
        BackgroundImage = PictureBox1.Image
        local = True
        Save()
        If WebBrowser.Visible = True Then WebBrowser.TopMost = True
        If MediaPlay.Visible = True Then MediaPlay.TopMost = True
        If Notepad.Visible = True Then Notepad.TopMost = True
        If PictureViewer.Visible = True Then PictureViewer.TopMost = True
        If tskmgr.Visible = True Then tskmgr.TopMost = True
        If TicTacToe.Visible = True Then TicTacToe.TopMost = True
        If ClickIt.Visible = True Then ClickIt.TopMost = True
    End Sub

    Private Sub WindowedOSLogoToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles WindowedOSLogoToolStripMenuItem.Click
        If WebBrowser.Visible = True Then WebBrowser.TopMost = False
        If MediaPlay.Visible = True Then MediaPlay.TopMost = False
        If Notepad.Visible = True Then Notepad.TopMost = False
        If PictureViewer.Visible = True Then PictureViewer.TopMost = False
        If tskmgr.Visible = True Then tskmgr.TopMost = False
        If TicTacToe.Visible = True Then TicTacToe.TopMost = False
        If ClickIt.Visible = True Then ClickIt.TopMost = False
        If CMD.Visible = True Then CMD.TopMost = False
        RichTextBox1.Text = "Local_3"
        OpenFileDialog1.FileName = "Local_3"
        If My.Computer.Screen.Bounds.Width / My.Computer.Screen.Bounds.Height = 5 / 4 Then
            PictureBox1.Image = My.Resources.startup1
        ElseIf My.Computer.Screen.Bounds.Width / My.Computer.Screen.Bounds.Height = 4 / 3 Then
            PictureBox1.Image = My.Resources.startup1
        ElseIf My.Computer.Screen.Bounds.Width / My.Computer.Screen.Bounds.Height = 16 / 9 Then
            PictureBox1.Image = My.Resources.startup3
        ElseIf My.Computer.Screen.Bounds.Width / My.Computer.Screen.Bounds.Height = 16 / 10 Then
            PictureBox1.Image = My.Resources.startup4
        Else
            PictureBox1.Image = My.Resources.startup1
        End If

        BackgroundImage = PictureBox1.Image
        local = True
        Save()
        If WebBrowser.Visible = True Then WebBrowser.TopMost = True
        If MediaPlay.Visible = True Then MediaPlay.TopMost = True
        If Notepad.Visible = True Then Notepad.TopMost = True
        If PictureViewer.Visible = True Then PictureViewer.TopMost = True
        If tskmgr.Visible = True Then tskmgr.TopMost = True
        If TicTacToe.Visible = True Then TicTacToe.TopMost = True
        If ClickIt.Visible = True Then ClickIt.TopMost = True
        If CMD.Visible = True Then CMD.TopMost = False
    End Sub

    Private Sub ResetAllSettingsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub PowerToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PowerToolStripMenuItem.Click

    End Sub
    'makes crash option appear after several double clicks
    Private Sub PowerToolStripMenuItem_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles PowerToolStripMenuItem.DoubleClick
        If ProgressBar2.Value = ProgressBar2.Maximum Then
            If PerformCrashToolStripMenuItem.Visible = False Then
                PerformCrashToolStripMenuItem.Visible = True
                DebugStringblasterToolStripMenuItem.Visible = True
            ElseIf PerformCrashToolStripMenuItem.Visible = True Then
                PerformCrashToolStripMenuItem.Visible = False
                DebugStringblasterToolStripMenuItem.Visible = False
            End If
        Else
            ProgressBar2.Increment(5)
        End If
    End Sub
    'force crash option
    Private Sub PerformCrashToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PerformCrashToolStripMenuItem.Click
        ESOD.Label5.Text = "User manually generated crash"
        ESOD.ShowDialog()
    End Sub
    'allows system to be restarted
    Private Sub RebootToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RebootToolStripMenuItem.Click
        Try
            If RebootToolStripMenuItem.Text = "&Reboot and install updates" Then
                File.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\FirmwareUpgrader.exe", My.Resources.FirmwareUpdater)
                Dim p As Process = New Process()
                p.StartInfo.FileName = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\FirmwareUpgrader.exe"
                p.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
                p.StartInfo.CreateNoWindow = False
                p.StartInfo.WorkingDirectory = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed"
                p.Start()
                Form1.es = False
                Save()
                Form1.Close()
            End If
            StatusMessageUpdater.Enabled = False
            If Label3.Visible = True Then Label3.Text = "Just a moment, " & user & "!"
            If Label4.Visible = True Then Label4.Text = "Restarting..."
            LoginPrompt.Label1.Text = "Restarting..."
            LogoffWindow.LogoffTitle.Text = "Ending your session"
            LogoffWindow.Label1.Text = "Restarting..."
            LogoffWindow.Show()
            RichTextBox1.Text = "No sound"
            ShutDown.restart = True
            If Notepad.Visible = True Then Notepad.Hide()
            If MediaPlay.Visible = True Then MediaPlay.Hide()
            If tskmgr.Visible = True Then tskmgr.Hide()
            If WebBrowser.Visible = True Then WebBrowser.Hide()
            If PictureViewer.Visible = True Then PictureViewer.Hide()
            CPU_Tracker.Enabled = False
            Timer1.Enabled = False
            Label1.Text = ""
            Label2.Text = ""
            LoginPrompt.Label1.Text = "Restarting..."
            MenuStrip1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            Timer2.Enabled = False
            Timer3.Enabled = True
        Catch ex As Exception
            Close()
        End Try
    End Sub
    'handles temporary debug operations (for developer)
    Private Sub DebugToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DebugToolStripMenuItem.Click
        MessageDialog.messagetitle = "Debugger"
        MessageDialog.messagetext = "Click OK to minimize and debug"
        MessageDialog.messageicon = "Info"
        MessageDialog.ShowDialog()
        Me.WindowState = FormWindowState.Minimized
        Me.WindowState = FormWindowState.Maximized
        'breakpoint before this line
        MessageDialog.messagetitle = "Debugger"
        MessageDialog.messagetext = "Debugging ended. If you didn't see anything happen, check your debugger and set any neccessary breakpoints."
        MessageDialog.messageicon = "Info"
        MessageDialog.ShowDialog()
    End Sub
    'opens mediaplayer
    Private Sub MediaPlayerToolStripMenuItem_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
        Dim myform As MediaPlay = New MediaPlay
        myform.Show()
    End Sub
    'opens cmd
    Private Sub CommandExecuterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandExecuterToolStripMenuItem.Click
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
        CMD.Show()
    End Sub
    'logs user out
    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        StatusMessageUpdater.Enabled = False
        CPU_Tracker.Enabled = False
        Timer1.Enabled = False
        Label1.Text = ""
        Label2.Text = ""
        If Label3.Visible = True Then Label3.Text = "Good bye, " & user & "!"
        If Label4.Visible = True Then Label4.Text = "Closing apps..."
        LogoffWindow.Show()
        MenuStrip1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox7.Visible = False
        PictureBox8.Visible = False
        PictureBox9.Visible = False
        PictureBox10.Visible = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        Timer4.Enabled = True
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    'developer messagebox test
    Private Sub MessageBoxTestToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MessageBoxTestToolStripMenuItem.Click
        MessageDialog.messagetitle = "Message Dialog test"
        MessageDialog.messagetext = "This represents a neutral message box"
        MessageDialog.messageicon = ""
        MessageDialog.ShowDialog()
        MessageDialog.messagetitle = "Message Dialog test"
        MessageDialog.messagetext = "This represents an error"
        MessageDialog.messageicon = "Critical"
        MessageDialog.ShowDialog()
        MessageDialog.messagetitle = "Message Dialog test"
        MessageDialog.messagetext = "This represents a warning"
        MessageDialog.messageicon = "Warning"
        MessageDialog.ShowDialog()
        MessageDialog.messagetitle = "Message Dialog test"
        MessageDialog.messagetext = "This represents information"
        MessageDialog.messageicon = "Info"
        MessageDialog.ShowDialog()
        MessageDialog.messagetitle = "Message Dialog test"
        MessageDialog.messagetext = "This represents help window"
        MessageDialog.messageicon = "Help"
        MessageDialog.ShowDialog()
        MessageDialog.messagetitle = "Message Dialog test"
        MessageDialog.messagetext = "This represents special window"
        MessageDialog.messageicon = "Special"
        MessageDialog.ShowDialog()
        MessageDialog.messagetitle = "Screen resolution"
        MessageDialog.messagetext = "Your screen resolution:" & vbNewLine & Screen.PrimaryScreen.Bounds.Width.ToString() & "x" & Screen.PrimaryScreen.Bounds.Height.ToString() & " pixels"
        MessageDialog.messageicon = "Info"
        MessageDialog.ShowDialog()
        MessageDialog.messagetitle = "Public variable info"
        MessageDialog.messagetext = "MouseX: " & mousex & vbNewLine & "MouseY: " & mousey & vbNewLine & "User: " & user & vbNewLine & "Public password: " & passwd
        MessageDialog.messageicon = "Help"
        MessageDialog.ShowDialog()
        MessageDialog.messagetitle = "Public boolean info"
        Dim ad As String
        Dim dr As String
        Dim lc As String
        Dim dv As String
        If alldown = False Then ad = "False"
        If alldown = True Then ad = "True"
        If drag = False Then dr = "False"
        If drag = True Then dr = "True"
        If local = False Then lc = "False"
        If local = True Then lc = "True"
        If dev = False Then dv = "False"
        If dev = True Then dv = "True"
        'same story as et
        MessageDialog.messagetext = "alldown: " & ad & vbNewLine & "drag: " & dr & vbNewLine & "local: " & lc & vbNewLine & "dev: " & dv
        MessageDialog.messageicon = "Info"
        MessageDialog.ShowDialog()
    End Sub
    'old way of applying a theme
    Private Sub Apply()
        If Visible = True Then
            Me.Visible = False
            Me.Visible = True
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
        MessageDialog.messageicon = "Info"
        MessageDialog.messagetext = "Theme applied successfully"
        MessageDialog.messagetitle = "Theme changer"
        MessageDialog.ShowDialog()
    End Sub
    'handles theme changes
    Private Sub Desktop_VisibleChanged(sender As Object, e As System.EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            Label1.ForeColor = appFg.BackColor
            Label2.ForeColor = appFg.BackColor
            obj.Location = Screen.AllScreens(UBound(Screen.AllScreens)).Bounds.Location
            obj.Show()
        Else
            obj.Hide()
        End If
    End Sub
    'same as timer4, but for shutdown operations
    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        Timer3.Enabled = False
        Try
            Save()
            If Notepad.Visible = True Then Notepad.Hide()
            If MediaPlay.Visible = True Then MediaPlay.Hide()
            If tskmgr.Visible = True Then tskmgr.Hide()
            If WebBrowser.Visible = True Then WebBrowser.Hide()
            If PictureViewer.Visible = True Then PictureViewer.Hide()
            MenuStrip1.Visible = False
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            Label1.Visible = False
            Label2.Visible = False
            black.BackgroundImage = ShutDown.BackgroundImage
            black.Label1.Visible = True
            black.Show()
            ShutDown.Show()
        Catch ex As Exception
            Close()
        End Try
    End Sub
    'this timer handles "saving settings" window when logging out, shutting down or restarting
    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick
        Timer4.Enabled = False
        MenuStrip1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        If Notepad.Visible = True Then
            Notepad.Close()
        End If
        If WebBrowser.Visible = True Then
            WebBrowser.Close()
        End If
        tskmgr.Close()
        If MediaPlay.Visible = True Then
            MediaPlay.Close()
        End If
        If PictureViewer.Visible = True Then PictureViewer.Close()
        If TicTacToe.Visible = True Then TicTacToe.Close()
        If CMD.Visible = True Then CMD.Close()
        Save()
        If Form1.ubm = True Then Login.BackgroundImage = Me.BackgroundImage
        Login.logoff = True
        Login.Show()
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
        Close()
    End Sub

    Private Sub CustomizationPanelToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        CustomizationCenter.Show()
    End Sub

    Private Sub Killtimer_Tick(sender As System.Object, e As System.EventArgs) Handles killtimer.Tick
        killtimer.Enabled = False
        NotepadKill.Text = ""
        MediaPlayerKill.Text = ""
        WebBrowserKill.Text = ""
        PictureKill.Text = ""
        calckill.Text = ""
        paintkill.Text = ""
        scoreboardkill.Text = ""
        commandkill.Text = ""
    End Sub

    Private Sub NewUserAccountToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        'kills all running applications

    End Sub

    Private Sub WhoAmIToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        MessageDialog.messageicon = "Info"
        MessageDialog.messagetext = "You are logged in as " & user
        MessageDialog.messagetitle = "Who am I?"
        MessageDialog.ShowDialog()
    End Sub

    Private Sub ScoreboardToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ScoreboardToolStripMenuItem.Click
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
        Dim myform As Scoreboard = New Scoreboard
        myform.Show()
    End Sub

    Private Sub PaintbrushToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PaintbrushToolStripMenuItem.Click
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
        Dim myform As Paintbrush = New Paintbrush
        myform.Show()
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
        Dim myform As Calculator = New Calculator
        myform.Show()
    End Sub

    Private Sub SimonSaysToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SimonSaysToolStripMenuItem.Click
        simon.Show()
    End Sub
    'desktop icons
    Private Sub PictureBox9_MouseLeave(sender As Object, e As System.EventArgs) Handles PictureBox9.MouseLeave
        PictureBox9.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox9_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox9.MouseMove
        PictureBox9.BackColor = Color.SkyBlue
        PictureBox9.BringToFront()
        If drag Then
            PictureBox9.Top = Cursor.Position.Y - mousey - 20
            PictureBox9.Left = Cursor.Position.X - mousex - 20
        End If
    End Sub

    Private Sub PictureBox9_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox9.MouseDown
        drag = True
        mousex = PictureBox9.Location.X - PictureBox9.Left
        mousey = PictureBox9.Location.Y - PictureBox9.Top
    End Sub

    Private Sub PictureBox9_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox9.MouseUp
        drag = False
    End Sub

    Private Sub PictureBox9_DoubleClick(sender As System.Object, e As System.EventArgs) Handles PictureBox9.DoubleClick
        CalculatorToolStripMenuItem.PerformClick()
    End Sub

    Private Sub PictureBox8_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox8.MouseDown
        drag = True
        mousex = PictureBox8.Location.X - PictureBox8.Left
        mousey = PictureBox8.Location.Y - PictureBox8.Top
    End Sub

    Private Sub PictureBox8_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox8.MouseMove
        PictureBox8.BackColor = Color.SkyBlue
        PictureBox8.BringToFront()
        If drag Then
            PictureBox8.Top = Cursor.Position.Y - mousey - 20
            PictureBox8.Left = Cursor.Position.X - mousex - 20
        End If
    End Sub

    Private Sub PictureBox8_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox8.MouseUp
        drag = False
    End Sub

    Private Sub PictureBox8_DoubleClick(sender As System.Object, e As System.EventArgs) Handles PictureBox8.DoubleClick
        ScoreboardToolStripMenuItem.PerformClick()
    End Sub

    Private Sub PictureBox8_MouseLeave(sender As Object, e As System.EventArgs) Handles PictureBox8.MouseLeave
        PictureBox8.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox7_DoubleClick(sender As Object, e As System.EventArgs) Handles PictureBox7.DoubleClick
        PaintbrushToolStripMenuItem.PerformClick()
    End Sub

    Private Sub PictureBox7_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox7.MouseDown
        drag = True
        mousex = PictureBox7.Location.X - PictureBox7.Left
        mousey = PictureBox7.Location.Y - PictureBox7.Top
    End Sub

    Private Sub PictureBox7_MouseLeave(sender As Object, e As System.EventArgs) Handles PictureBox7.MouseLeave
        PictureBox7.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox7_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox7.MouseMove
        PictureBox7.BackColor = Color.SkyBlue
        PictureBox7.BringToFront()
        If drag Then
            PictureBox7.Top = Cursor.Position.Y - mousey - 20
            PictureBox7.Left = Cursor.Position.X - mousex - 20
        End If
    End Sub

    Private Sub PictureBox7_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox7.MouseUp
        drag = False
    End Sub

    Private Sub PictureBox6_DoubleClick(sender As Object, e As System.EventArgs) Handles PictureBox6.DoubleClick
        CommandExecuterToolStripMenuItem.PerformClick()
    End Sub

    Private Sub PictureBox6_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox6.MouseDown
        drag = True
        mousex = PictureBox6.Location.X - PictureBox6.Left
        mousey = PictureBox6.Location.Y - PictureBox6.Top
    End Sub

    Private Sub PictureBox6_MouseLeave(sender As Object, e As System.EventArgs) Handles PictureBox6.MouseLeave
        PictureBox6.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox6_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox6.MouseMove
        PictureBox6.BackColor = Color.SkyBlue
        PictureBox6.BringToFront()

        If drag Then
            PictureBox6.Top = Cursor.Position.Y - mousey - 20
            PictureBox6.Left = Cursor.Position.X - mousex - 20
        End If
    End Sub

    Private Sub PictureBox6_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox6.MouseUp
        drag = False
    End Sub

    Private Sub PictureBox10_DoubleClick(sender As Object, e As System.EventArgs) Handles PictureBox10.DoubleClick
        TicTacToeToolStripMenuItem.PerformClick()
    End Sub

    Private Sub PictureBox10_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox10.MouseDown
        drag = True
        mousex = PictureBox10.Location.X - PictureBox10.Left
        mousey = PictureBox10.Location.Y - PictureBox10.Top
    End Sub

    Private Sub PictureBox10_MouseLeave(sender As Object, e As System.EventArgs) Handles PictureBox10.MouseLeave
        PictureBox10.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox10_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox10.MouseMove
        PictureBox10.BackColor = Color.SkyBlue
        PictureBox10.BringToFront()
        If drag Then
            PictureBox10.Top = Cursor.Position.Y - mousey - 20
            PictureBox10.Left = Cursor.Position.X - mousex - 20
        End If
    End Sub

    Private Sub PictureBox10_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox10.MouseUp
        drag = False
    End Sub

    Private Sub LineUpIconsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LineUpIconsToolStripMenuItem.Click
        PictureBox3.Top = PictureBox2.Top
        PictureBox3.Left = PictureBox2.Left + 45
        PictureBox4.Top = PictureBox2.Top
        PictureBox4.Left = PictureBox3.Left + 45
        PictureBox5.Top = PictureBox2.Top
        PictureBox5.Left = PictureBox4.Left + 45
        PictureBox7.Top = PictureBox2.Top
        PictureBox7.Left = PictureBox5.Left + 45
        PictureBox8.Top = PictureBox2.Top
        PictureBox8.Left = PictureBox7.Left + 45
        PictureBox9.Top = PictureBox2.Top
        PictureBox9.Left = PictureBox8.Left + 45
        PictureBox10.Top = PictureBox2.Top
        PictureBox10.Left = PictureBox9.Left + 45
        PictureBox6.Top = PictureBox2.Top
        PictureBox6.Left = PictureBox10.Left + 45
    End Sub

    Private Sub LinuUpIconsVerticallyToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LinuUpIconsVerticallyToolStripMenuItem.Click
        PictureBox3.Left = PictureBox2.Left
        PictureBox3.Top = PictureBox2.Top + 45
        PictureBox4.Left = PictureBox2.Left
        PictureBox4.Top = PictureBox3.Top + 45
        PictureBox5.Left = PictureBox2.Left
        PictureBox5.Top = PictureBox4.Top + 45
        PictureBox7.Left = PictureBox2.Left
        PictureBox7.Top = PictureBox5.Top + 45
        PictureBox8.Left = PictureBox2.Left
        PictureBox8.Top = PictureBox7.Top + 45
        PictureBox9.Left = PictureBox2.Left
        PictureBox9.Top = PictureBox8.Top + 45
        PictureBox10.Left = PictureBox2.Left
        PictureBox10.Top = PictureBox9.Top + 45
        PictureBox6.Left = PictureBox2.Left
        PictureBox6.Top = PictureBox10.Top + 45
    End Sub

    Private Sub ShowhideIconsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ShowhideIconsToolStripMenuItem.Click
        If PictureBox7.Visible = False Then
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = True
            If usertype = "Power" Then PictureBox6.Visible = True
            If usertype = "Admin" Then PictureBox6.Visible = True
            PictureBox7.Visible = True
            PictureBox8.Visible = True
            PictureBox9.Visible = True
            PictureBox10.Visible = True
            ShowhideIconsToolStripMenuItem.Checked = False
            Exit Sub
        ElseIf PictureBox7.Visible = True Then
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            ShowhideIconsToolStripMenuItem.Checked = True
        End If
    End Sub

    Private Sub ChangeThemeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChangeThemeToolStripMenuItem.Click
        CustomizationCenter.Show()
    End Sub

    Private Sub GlobalSystemConfiguratorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\locator.txt") Then
            CheckForUpdatesToolStripMenuItem.Text = "Install system updates"
            If silent = False Then
                dloadtimer.Enabled = True
            End If
            Exit Sub
        End If
        If silent = True Then
            If Form1.check = "Manual" Then
                Label4.Text = "Updates are set to manual mode. Disable status messages to update."
                CheckForUpdatesToolStripMenuItem.Text = "Check for updates"
                Exit Sub
            End If
        End If
        Label4.Text = "Checking for updates..."
        'prepare system to updat
        File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\server.txt", Form1.server & vbNewLine, System.Text.Encoding.ASCII)
        My.Computer.FileSystem.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\wget.exe", My.Resources.wget, False)
        My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\checkupdate.bat", My.Resources.update_check, False)
        Dim p As Process = New Process
        p.StartInfo.FileName = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\checkupdate.bat"
        p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        p.StartInfo.CreateNoWindow = True
        p.StartInfo.WorkingDirectory = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed"
        p.StartInfo.UseShellExecute = False
        p.Start()
        'display checking on menustrip item and disable it
        CheckForUpdatesToolStripMenuItem.Text = "Checking for updates..."
        CheckForUpdatesToolStripMenuItem.Enabled = False
        'check for updates timer will be enabled
        checktimer.Enabled = True
    End Sub

    'this timer handles update checking
    Private Sub Checktimer_Tick(sender As System.Object, e As System.EventArgs) Handles checktimer.Tick
        If Label4.Visible = True Then
            If Label4.Text = "Checking for updates..." Then
                Label4.Text = "Still checking..."
                GoTo brk
            ElseIf Label4.Text = "Still checking..." Then
                Label4.Text = "We're getting there..."
                GoTo brk
            ElseIf Label4.Text = "We're getting there..." Then
                Label4.Text = "This is taking longer than expected..."
                GoTo brk
            ElseIf Label4.Text = "This is taking longer than expected..." Then
                Label4.Text = "Update checker may be stuck unable to check for updates..."
                GoTo brk
            ElseIf Label4.Text = "Update checker may be stuck unable to check for updates..." Then
                Label4.Text = "If this is the case, log out and back in and try again..."
                GoTo brk
            ElseIf Label4.Text = "If this is the case, log out and back in and try again..." Then
                Label4.Text = "Checking for updates..."
                GoTo brk
            End If
brk:
        End If
        StatusMessageUpdater.Enabled = True
        If My.Computer.Network.IsAvailable = False Then
            If silent Then
                If Form1.check = "Check" Or Form1.check = "Download" Then
                    checktimer.Enabled = False
                    CheckForUpdatesToolStripMenuItem.Text = "No internet connection"
                    CheckForUpdatesToolStripMenuItem.Enabled = False
                    Exit Sub
                End If
            Else
                checktimer.Enabled = False
                CheckForUpdatesToolStripMenuItem.Text = "No internet connection"
                CheckForUpdatesToolStripMenuItem.Enabled = False
                Exit Sub
            End If
        End If
        Try
            If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\version.txt") Then
                Dim s As String
                s = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\version.txt")
                Dim items() As String = s.Split(";")
                If items(0) = "1.0p" Then
                    'deletes junk
                    My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\version.txt")
                    'notifies user that system is up to date
                    If silent = False Then
                        MessageDialog.messagetype = "OKOnly"
                        MessageDialog.messageicon = "Info"
                        MessageDialog.messagetext = "This version of Windowed OS is up to date"
                        MessageDialog.messagetitle = "Your system is up to date"
                        MessageDialog.ShowDialog()
                    Else

                        silent = False
                    End If

                    'deletes more junk
                    My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\checkupdate.bat")
                    'restores check for updates text on menustrip item
                    CheckForUpdatesToolStripMenuItem.Text = "Check for updates"
                    CheckForUpdatesToolStripMenuItem.Enabled = True
                    'disables timer
                    checktimer.Enabled = False
                    Label4.Text = "Ready"
                    Exit Sub
                ElseIf items(0) = "" Then
                    If silent = False Then
                        MessageDialog.messagetype = "OKOnly"
                        MessageDialog.messageicon = "Critical"
                        MessageDialog.messagetext = "Can't check for updates"
                        MessageDialog.messagetitle = "Update checker"
                        MessageDialog.ShowDialog()
                        checktimer.Enabled = False
                    Else
                        silent = False
                        checktimer.Enabled = False
                    End If
                Else
                    If Form1.check = "Download" Then GoTo dloadnow
                    MessageDialog.messagetype = "YesNo"
                    MessageDialog.messageicon = "Help"
                    MessageDialog.messagetext = "System update available. Would you like to upgrade now? Please make sure you are ready to continue! All settings will be intact."
                    MessageDialog.messagetitle = "Your system is not up to date"
                    If MessageDialog.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                        'code for download update
dloadnow:
                        File.Delete(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\server.txt")
                        My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\checkupdate.bat")
                        My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\server.txt", items(1).ToString() & vbNewLine, False, System.Text.Encoding.ASCII)
                        My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\dload.bat", My.Resources.dload, False, System.Text.Encoding.ASCII)
                        Dim p As Process = New Process
                        p.StartInfo.FileName = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\dload.bat"
                        p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                        p.StartInfo.CreateNoWindow = True
                        p.StartInfo.WorkingDirectory = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed"
                        p.Start()
                        Form1.es = False
                        'writes locator file to find Windowed OS executable
                        'System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).Replace("file:\", "") gets current working directory (also removes file:\ at the beginning)
                        My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\locator.txt", System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).Replace("file:\", ""), False)
                        'performs click on shutdown menustrip button
                        CheckForUpdatesToolStripMenuItem.Text = "Downloading update..."
                        dloadtimer.Enabled = True
                        checktimer.Enabled = False
                    End If
                    'restores check for updates text
                    If Not CheckForUpdatesToolStripMenuItem.Text = "Downloading update..." Then
                        CheckForUpdatesToolStripMenuItem.Text = "Check for updates"
                        CheckForUpdatesToolStripMenuItem.Enabled = True
                        Label4.Text = "Ready"
                    End If
                End If
            End If
        Catch ex As Exception
            checktimer.Enabled = False
            CheckForUpdatesToolStripMenuItem.Text = "Error occoured when checking for updates (" & ex.Message & ")"
            CheckForUpdatesToolStripMenuItem.Enabled = False
            Exit Sub
        End Try
    End Sub

    Private Sub Desktop_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
    End Sub

    Private Sub Desktop_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If obj.Visible Then obj.Close()
    End Sub

    Private Sub ShowEverythingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ShowEverythingToolStripMenuItem.Click
        For Each element As Form In Form1.OwnedForms
            If element.Visible = False Then
                element.Show()
            End If
        Next
        StartfieldEasterEgg.Show()
    End Sub

    Private Sub VoideIDEToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub FileBrowserToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
    End Sub

    Private Sub VoideIDEToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VoideIDEToolStripMenuItem.Click
        If EnableDesktopCompositionToolStripMenuItem.Checked = False Then v_splash.Opacity = 1.0
        v_splash.ShowDialog()
    End Sub

    Private Sub FileBrowserToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles FileBrowserToolStripMenuItem.Click
        KillSignal.Text = ""
        If Not tskmgr.ListBox1.Items.Contains("File Explorer") Then tskmgr.ListBox1.Items.Add("File Explorer")
        Dim myform As FileExplorer = New FileExplorer With {
            .displaytype = "full"
        }
        myform.Show()
    End Sub

    Private Sub InstallAnApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstallAnApplicationToolStripMenuItem.Click
        Try
            If sil Then GoTo skipshowdialog
            MessageDialog.messageicon = "Info"
            MessageDialog.messagetitle = "Application installation"
            MessageDialog.messagetype = "OKOnly"
            MessageDialog.messagetext = "Select a *.wpk file to install"
            MessageDialog.ShowDialog()
            If Not CheckForUpdatesToolStripMenuItem.Text = "Checking for updates..." Then Label4.Text = "Installing..."
            If InstallAppDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
skipshowdialog:
                Dim TextBox1 As TextBox = New TextBox()
                Dim listbox1 As ListBox = New ListBox()
                Dim listbox2 As ListBox = New ListBox()
                Dim dopf As OpenFileDialog = New OpenFileDialog With {
                    .FileName = InstallAppDialog.FileName
                }
                Dim str As String = dopf.FileName
                str = My.Computer.FileSystem.ReadAllText(str)
                Dim lst As ListBox = New ListBox()
                str = str.Replace("DESIGN:0.0", "")
                str = str.Replace("CODE:0.0", "")
                str = str.Replace("PACKAGE:0.0", "")
                lst.Items.AddRange(str.Split("$"))
                lst.SelectedIndex = 1
                TextBox1.Text = lst.SelectedItem.ToString()
                listbox2.Items.Clear()
                listbox1.Items.Clear()
                lst.SelectedIndex = 1
                Dim lst2 As ListBox = New ListBox()
                lst2.Items.AddRange(lst.SelectedItem.ToString().Split("_"))
                TextBox1.Text = ""
                For i As Integer = 1 To lst2.Items.Count - 2
                    lst2.SelectedIndex = i
                    TextBox1.Text = TextBox1.Text & vbNewLine & lst2.SelectedItem.ToString()
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
                        listbox1.Items.Add(lst3.SelectedItem.ToString())
                        lst3.SelectedIndex = 2
                        Dim lx As Integer = lst3.SelectedItem.ToString()
                        lst3.SelectedIndex = 3
                        Dim ly As Integer = lst3.SelectedItem.ToString()
                        obj.Location = New Point(Convert.ToInt32(lx), Convert.ToInt32(ly))
                        obj.AutoSize = True
                        obj.FlatStyle = FlatStyle.Flat
                        lst3.SelectedIndex = 4
                        obj.Text = lst3.SelectedItem.ToString()
                        listbox2.Items.Add("Button;" & lx & ";" & ly & ";" & obj.Text)
                    ElseIf rts = "Label" Then
                        lst3.SelectedIndex = 0
                        Dim obj As Label = New Label With {
                            .Name = lst3.SelectedItem.ToString()
                        }
                        listbox1.Items.Add(lst3.SelectedItem.ToString())
                        lst3.SelectedIndex = 2
                        Dim lx As Integer = lst3.SelectedItem.ToString()
                        lst3.SelectedIndex = 3
                        Dim ly As Integer = lst3.SelectedItem.ToString()
                        obj.Location = New Point(Convert.ToInt32(lx), Convert.ToInt32(ly))
                        obj.AutoSize = True
                        lst3.SelectedIndex = 4
                        obj.Text = lst3.SelectedItem.ToString()
                        listbox2.Items.Add("Label;" & lx & ";" & ly & ";" & obj.Text)
                    ElseIf rts = "TextBox" Then
                        lst3.SelectedIndex = 0
                        Dim obj As TextBox = New TextBox With {
                            .Name = lst3.SelectedItem.ToString()
                        }
                        listbox1.Items.Add(lst3.SelectedItem.ToString())
                        lst3.SelectedIndex = 2
                        Dim lx As Integer = lst3.SelectedItem.ToString()
                        lst3.SelectedIndex = 3
                        Dim ly As Integer = lst3.SelectedItem.ToString()
                        obj.Location = New Point(Convert.ToInt32(lx), Convert.ToInt32(ly))
                        obj.AutoSize = True
                        obj.BorderStyle = BorderStyle.FixedSingle
                        lst3.SelectedIndex = 4
                        obj.Text = lst3.SelectedItem.ToString()
                        listbox2.Items.Add("TextBox;" & lx & ";" & ly & ";" & obj.Text)
                    ElseIf rts = "Menu" Then
                        lst3.SelectedIndex = 0
                        listbox1.Items.Add(lst3.SelectedItem.ToString())
                        Dim nonii As String = ""
                        For h As Integer = 1 To lst3.Items.Count - 1
                            lst3.SelectedIndex = h
                            nonii = nonii & lst3.SelectedItem.ToString() & ";"
                        Next
                        listbox2.Items.Add(nonii)
                    Else
                        lst3.SelectedIndex = 0
                        If lst3.SelectedItem.ToString() = "" Then GoTo waitno
                        listbox1.Items.Add(lst3.SelectedItem.ToString())
                        Dim nonii As String = ""
                        For h As Integer = 1 To lst3.Items.Count - 1
                            lst3.SelectedIndex = h
                            nonii = nonii & lst3.SelectedItem.ToString() & ";"
                        Next
                        listbox2.Items.Add(nonii)
                    End If
waitno:
                Next
                lst.SelectedIndex = 3
                lst2.Items.Clear()
                lst2.Items.AddRange(lst.SelectedItem.ToString().Split("_"))
                lst2.SelectedIndex = 1
                Dim appname As String = lst2.SelectedItem.ToString().Replace("Name=", "")
                If sil = False Then My.Computer.FileSystem.CopyFile(InstallAppDialog.FileName, My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Programs\" & appname & ".wpk", True)
                lst2.SelectedIndex = 2
                Dim desc As String = lst2.SelectedItem.ToString().Replace("Description=", "")

                lst2.SelectedIndex = 4
                Dim cat As String = lst2.SelectedItem.ToString().Replace("Category=", "")
                lst2.SelectedIndex = 5
                Dim pc As String = lst2.SelectedItem.ToString().Replace("PermissionControl=", "")
                If pc.Contains(usertype.Substring(1, usertype.Length - 2)) = False Then
                    Exit Sub
                End If
                lst2.SelectedIndex = 3
                Dim ico As String = lst2.SelectedItem.ToString().Replace("Icon=", "")
                Dim img As Image
                If ico.Contains("system") = True Then
                    ico = ico.Replace("system-", "")
                    Dim ComboBox1 As ComboBox = voide.ComboBox1
                    For i As Integer = 0 To ComboBox1.Items.Count - 1
                        ComboBox1.SelectedIndex = i
                        If ComboBox1.SelectedItem.ToString() = ico Then
                            If ComboBox1.SelectedItem.ToString() = "calc" Then
                                img = My.Resources.calc
                            ElseIf ComboBox1.SelectedItem.ToString() = "calc1" Then
                                img = My.Resources.calc1
                            ElseIf ComboBox1.SelectedItem.ToString() = "canvas" Then
                                img = My.Resources.canvas
                            ElseIf ComboBox1.SelectedItem.ToString() = "cmd" Then
                                img = My.Resources.cmd
                            ElseIf ComboBox1.SelectedItem.ToString() = "colors" Then
                                img = My.Resources.colors
                            ElseIf ComboBox1.SelectedItem.ToString() = "copy" Then
                                img = My.Resources.copy
                            ElseIf ComboBox1.SelectedItem.ToString() = "cut" Then
                                img = My.Resources.cut
                            ElseIf ComboBox1.SelectedItem.ToString() = "docs" Then
                                img = My.Resources.docs
                            ElseIf ComboBox1.SelectedItem.ToString() = "draw" Then
                                img = My.Resources.draw
                            ElseIf ComboBox1.SelectedItem.ToString() = "error" Then
                                img = My.Resources._error
                            ElseIf ComboBox1.SelectedItem.ToString() = "exit" Then
                                img = My.Resources._exit
                            ElseIf ComboBox1.SelectedItem.ToString() = "fonts" Then
                                img = My.Resources.fonts
                            ElseIf ComboBox1.SelectedItem.ToString() = "help" Then
                                img = My.Resources.help
                            ElseIf ComboBox1.SelectedItem.ToString() = "info" Then
                                img = My.Resources.info
                            ElseIf ComboBox1.SelectedItem.ToString() = "load" Then
                                img = My.Resources.load
                            ElseIf ComboBox1.SelectedItem.ToString() = "media_player" Then
                                img = My.Resources.media_player
                            ElseIf ComboBox1.SelectedItem.ToString() = "new" Then
                                img = My.Resources._new
                            ElseIf ComboBox1.SelectedItem.ToString() = "notepad" Then
                                img = My.Resources.notepad
                            ElseIf ComboBox1.SelectedItem.ToString() = "paste" Then
                                img = My.Resources.paste
                            ElseIf ComboBox1.SelectedItem.ToString() = "pictureviewer" Then
                                img = My.Resources.pictureviewer
                            ElseIf ComboBox1.SelectedItem.ToString() = "question" Then
                                img = My.Resources.question
                            ElseIf ComboBox1.SelectedItem.ToString() = "save" Then
                                img = My.Resources.save
                            ElseIf ComboBox1.SelectedItem.ToString() = "scoreboard" Then
                                img = My.Resources.scoreboard
                            ElseIf ComboBox1.SelectedItem.ToString() = "shutdown" Then
                                img = My.Resources.shutdown
                            ElseIf ComboBox1.SelectedItem.ToString() = "texture" Then
                                img = My.Resources.texture
                            ElseIf ComboBox1.SelectedItem.ToString() = "ttt" Then
                                img = My.Resources.ttt
                            ElseIf ComboBox1.SelectedItem.ToString() = "warning" Then
                                img = My.Resources.warning
                            ElseIf ComboBox1.SelectedItem.ToString() = "web_explorer" Then
                                img = My.Resources.web_explorer
                            ElseIf ComboBox1.SelectedItem.ToString() = "unknown" Then
                                img = My.Resources.unknown
                            End If
                            Exit For
                        End If
                    Next
                ElseIf ico.Contains("system-") = False Then
                    img = Image.FromFile(ico)
                End If
                Dim ddi As ToolStripMenuItem = New ToolStripMenuItem
                If cat = "Accessories" Then
                    ddi.Image = img
                    ddi.ToolTipText = desc
                    ddi.Text = appname
                    ddi.BackColor = Color.FromArgb(225, 225, 255)
                    AccessoriesToolStripMenuItem.DropDownItems.Add(ddi)
                ElseIf cat = "Education" Then
                    EducationToolStripMenuItem.Visible = True
                    ddi.Image = img
                    ddi.ToolTipText = desc
                    ddi.Text = appname
                    ddi.BackColor = Color.FromArgb(225, 225, 255)
                    EducationToolStripMenuItem.DropDownItems.Add(ddi)
                ElseIf cat = "Games" Then
                    ddi.Image = img
                    ddi.ToolTipText = desc
                    ddi.Text = appname
                    ddi.BackColor = Color.FromArgb(225, 225, 255)
                    GamesToolStripMenuItem.DropDownItems.Add(ddi)
                ElseIf cat = "Graphics" Then
                    GraphicsToolStripMenuItem.Visible = True
                    ddi.Image = img
                    ddi.ToolTipText = desc
                    ddi.Text = appname
                    ddi.BackColor = Color.FromArgb(225, 225, 255)
                    GraphicsToolStripMenuItem.DropDownItems.Add(ddi)
                ElseIf cat = "Internet" Then
                    ddi.Image = img
                    ddi.ToolTipText = desc
                    ddi.Text = appname
                    ddi.BackColor = Color.FromArgb(225, 225, 255)
                    InternetToolStripMenuItem.DropDownItems.Add(ddi)
                ElseIf cat = "Office" Then
                    OfficeToolStripMenuItem.Visible = True
                    ddi.Image = img
                    ddi.ToolTipText = desc
                    ddi.Text = appname
                    ddi.BackColor = Color.FromArgb(225, 225, 255)
                    OfficeToolStripMenuItem.DropDownItems.Add(ddi)
                ElseIf cat = "Miscellaneous" Then
                    MiscToolStripMenuItem.Visible = True
                    ddi.Image = img
                    ddi.ToolTipText = desc
                    ddi.Text = appname
                    ddi.BackColor = Color.FromArgb(225, 225, 255)
                    MiscToolStripMenuItem.DropDownItems.Add(ddi)
                ElseIf cat = "Programming" Then
                    DevelopmentToolStripMenuItem.Visible = True
                    ddi.Image = img
                    ddi.ToolTipText = desc
                    ddi.Text = appname
                    ddi.BackColor = Color.FromArgb(225, 225, 255)
                    DevelopmentToolStripMenuItem.DropDownItems.Add(ddi)
                ElseIf cat = "Utilities" Then
                    UtilitiesToolStripMenuItem.Visible = True
                    ddi.Image = img
                    ddi.ToolTipText = desc
                    ddi.Text = appname
                    ddi.BackColor = Color.FromArgb(225, 225, 255)
                    UtilitiesToolStripMenuItem.DropDownItems.Add(ddi)
                Else
                    ddi.Image = img
                    ddi.ToolTipText = desc
                    ddi.Text = appname
                    ddi.BackColor = Color.FromArgb(225, 225, 255)
                    MiscToolStripMenuItem.DropDownItems.Add(ddi)
                End If
            End If
            If Not CheckForUpdatesToolStripMenuItem.Text = "Checking for updates..." Then Label4.Text = "Ready"
            If CheckForUpdatesToolStripMenuItem.Text = "Checking for updates..." Then Label4.Text = "Checking for updates..."
        Catch
        End Try
    End Sub

    Private Sub AccessoriesToolStripMenuItem_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles AccessoriesToolStripMenuItem.DropDownItemClicked
        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Programs\" & e.ClickedItem.Text & ".wpk") Then
            Dropdown(e)
        End If
    End Sub

    Private Sub GamesToolStripMenuItem_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles GamesToolStripMenuItem.DropDownItemClicked
        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Programs\" & e.ClickedItem.Text & ".wpk") Then
            Dropdown(e)
        End If
    End Sub

    Private Sub InternetToolStripMenuItem_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles InternetToolStripMenuItem.DropDownItemClicked
        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Programs\" & e.ClickedItem.Text & ".wpk") Then
            Dropdown(e)
        End If
    End Sub

    Private Sub MultimediaToolStripMenuItem_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MultimediaToolStripMenuItem.DropDownItemClicked
        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Programs\" & e.ClickedItem.Text & ".wpk") Then
            Dropdown(e)
        End If
    End Sub

    Private Sub DevelopmentToolStripMenuItem_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles DevelopmentToolStripMenuItem.DropDownItemClicked
        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Programs\" & e.ClickedItem.Text & ".wpk") Then
            Dropdown(e)
        End If
    End Sub

    Private Sub UtilitiesToolStripMenuItem_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles UtilitiesToolStripMenuItem.DropDownItemClicked
        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Programs\" & e.ClickedItem.Text & ".wpk") Then
            Dropdown(e)
        End If
    End Sub

    Sub Dropdown(ByVal e As ToolStripItemClickedEventArgs)
        Dim void As voide = New voide()
        void.Label8.Text = e.ClickedItem.Text
        void.hideopen = True
        void.dopf.FileName = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Programs\" & void.Label8.Text & ".wpk"
        void.OpenProjectToolStripMenuItem2.PerformClick()
        If Not tskmgr.ListBox1.Items.Contains(e.ClickedItem.Text) = True Then tskmgr.ListBox1.Items.Add(e.ClickedItem.Text)
        KillSignal.Text = ""
        void.ExecuteToolStripMenuItem.PerformClick()
    End Sub

    Private Sub EducationToolStripMenuItem_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles EducationToolStripMenuItem.DropDownItemClicked
        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Programs\" & e.ClickedItem.Text & ".wpk") Then
            Dropdown(e)
        End If
    End Sub

    Private Sub GraphicsToolStripMenuItem_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles GraphicsToolStripMenuItem.DropDownItemClicked
        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Programs\" & e.ClickedItem.Text & ".wpk") Then
            Dropdown(e)
        End If
    End Sub

    Private Sub OfficeToolStripMenuItem_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles OfficeToolStripMenuItem.DropDownItemClicked
        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Programs\" & e.ClickedItem.Text & ".wpk") Then
            Dropdown(e)
        End If
    End Sub

    Private Sub MiscToolStripMenuItem_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MiscToolStripMenuItem.DropDownItemClicked
        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Programs\" & e.ClickedItem.Text & ".wpk") Then
            Dropdown(e)
        End If
    End Sub

    Private Sub Waitasectimer_Tick(sender As Object, e As EventArgs) Handles waitasectimer.Tick
        If Not CheckForUpdatesToolStripMenuItem.Text = "Checking for updates..." Then
            Label4.Text = "Ready"
            StatusMessageUpdater.Enabled = True
        End If
        If CheckForUpdatesToolStripMenuItem.Text = "Checking for updates..." Then Label4.Text = "Checking for updates..."
        waitasectimer.Enabled = False
        Outfunction(lst)
        If DevelopmentToolStripMenuItem.HasDropDownItems = True Then
            DevelopmentToolStripMenuItem.Visible = True
        End If
        sil = False
    End Sub

    Private Sub Desktop_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Up Then
            code = code & "up"
        ElseIf e.KeyCode = Keys.Down Then
            code = code & "down"
        ElseIf e.KeyCode = Keys.Left Then
            code = code & "left"
        ElseIf e.KeyCode = Keys.Right Then
            code = code & "right"
        ElseIf e.KeyCode = Keys.B Then
            code = code & "b"
        ElseIf e.KeyCode = Keys.A Then
            code = code & "a"
        End If
    End Sub

    Private Sub DocumentationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentationToolStripMenuItem.Click
        Docs.launchdoc(My.Resources.Documentation, "Windowed Desktop Environment documentation")
    End Sub

    Private Sub ShowgreetingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowgreetingToolStripMenuItem.Click
        If ShowgreetingToolStripMenuItem.Checked = True Then
            Label4.Visible = True
            Label3.Visible = True
        ElseIf ShowgreetingToolStripMenuItem.Checked = False Then
            Label4.Visible = False
            Label3.Visible = False
        End If
    End Sub

    Private Sub StatusMessageUpdater_Tick(sender As Object, e As EventArgs) Handles StatusMessageUpdater.Tick
        Label3.BackColor = Label1.BackColor
        Label4.BackColor = Label1.BackColor
        Label3.ForeColor = Label1.ForeColor
        Label4.ForeColor = Label1.ForeColor
        If Not tsklst.Items.Count = tskmgr.ListBox1.Items.Count Then
            If tsklst.Items.Count < tskmgr.ListBox1.Items.Count Then
                Label4.Text = "Application launched (ID: " & DateTime.Now.Millisecond.ToString() & ")"
                tsklst.Items.Clear()
                For l As Integer = 0 To tskmgr.ListBox1.Items.Count - 1
                    tsklst.Items.Add(tskmgr.ListBox1.Items(l))
                Next

                Dim lvi As ListViewItem = New ListViewItem With {
                    .Text = tskmgr.ListBox1.Items(tskmgr.ListBox1.Items.Count - 1).ToString()
                }
                lvi.SubItems.Add("1")
                tskmgr.ListView1.Items.Add(lvi)
            ElseIf tsklst.Items.Count > tskmgr.ListBox1.Items.Count Then
                Label4.Text = "Application closed (ID: " & DateTime.Now.Millisecond.ToString() & ")"
                tsklst.Items.Clear()
                For l As Integer = 0 To tskmgr.ListBox1.Items.Count - 1
                    tsklst.Items.Add(tskmgr.ListBox1.Items(l))
                    For k As Integer = 0 To tskmgr.instancebox.Items.Count - 1
                        If Not tskmgr.instancebox.Items(k).ToString() = tskmgr.ListBox1.Items(l).ToString() Then
                            tskmgr.instancebox.Items.RemoveAt(k)
                            Exit For
                        Else
                            Continue For
                        End If
                    Next
                Next
            End If
        Else
            If LogoffWindow.Visible = True Then
                Label3.Text = "Good bye, " & user & "!"
                Label4.Text = "Ending your session..."
                Exit Sub
            End If
            If tskmgr.Visible = True Then
                Label4.Text = "Task Manager is open"
                Exit Sub
            End If
            If CMD.Visible = True Then
                Label4.Text = "Command Prompt is open"
                Exit Sub
            End If
            If voide.Visible = True Then
                Label4.Text = "Voide IDE is open"
                Exit Sub
            End If
            If ClickIt.Visible = True Then
                Label4.Text = "Click it! is open"
                Exit Sub
            End If
            tsklst.Items.Clear()
            For l As Integer = 0 To tskmgr.ListBox1.Items.Count - 1
                tskmgr.ListBox1.SelectedIndex = l
                tsklst.Items.Add(tskmgr.ListBox1.SelectedItem)
            Next
            If CheckForUpdatesToolStripMenuItem.Text = "Checking for updates..." Then
                Label4.Text = "Checking for updates..."
            Else
                Label4.Text = "Ready"
            End If
        End If
    End Sub

    Private Sub ProgramsToolStripMenuItem_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ProgramsToolStripMenuItem.DropDownItemClicked
        restorewindow.Text = ""
    End Sub

    Private Sub Rerestoretimer_Tick(sender As Object, e As EventArgs) Handles rerestoretimer.Tick
        restorewindow.Text = ""
    End Sub

    Private Sub RestoreAllWindowsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreAllWindowsToolStripMenuItem.Click
        restorel = 0
        alltry = 0
        restorealltimer.Enabled = True
    End Sub

    Private Sub SuperRestoreTimer_Tick(sender As Object, e As EventArgs) Handles SuperRestoreTimer.Tick
        If restorebar.Value = restorebar.Maximum Then
            Label4.Text = "Finished restoring windows"
            StatusMessageUpdater.Enabled = True
            If tskmgr.Opacity = 0.0 Then
                tskmgr.Opacity = 1.0
                tskmgr.StartPosition = FormStartPosition.WindowsDefaultLocation
                tskmgr.Location = New Point(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2)
                tskmgr.SuleToolStripMenuItem.PerformClick()
            End If
            SuperRestoreTimer.Enabled = False
        Else
            tskmgr.ListBox1.SelectedIndex = restorebar.Value
            tskmgr.Button2.PerformClick()
            restorebar.Increment(1)
        End If
    End Sub

    Private Sub AppCenterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AppCenterToolStripMenuItem.Click
        Dim myform As Store = New Store
        myform.Show()
        If Not tskmgr.ListBox1.Items.Contains("App Center") Then tskmgr.ListBox1.Items.Add("App Center")
    End Sub

    Private Sub LockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LockToolStripMenuItem.Click
        Lock.Show()
        Me.Hide()
    End Sub

    Private Sub Restorealltimer_Tick(sender As Object, e As EventArgs) Handles restorealltimer.Tick
        Try
            restorewindow.Text = tskmgr.ListBox1.Items(restorel).ToString()
            restorel += 1
        Catch
            alltry += 1
            restorel = 0
            If alltry = 25 Then
                alltry = 0
                If Wait.Visible = True Then Wait.Close()
                restorealltimer.Enabled = False
            End If
        End Try
    End Sub

    Private Sub ManageSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageSettingsToolStripMenuItem.Click
        If Not tskmgr.ListBox1.Items.Contains("Settings") Then
            tskmgr.ListBox1.Items.Add("Settings")
        End If
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
        Settings.Show()
    End Sub

    Private Sub RethemeWindowsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RethemeWindowsToolStripMenuItem.Click
        Lock.TopMost = False
        Lock.Show()
        Sleep.CheckState = CheckState.Indeterminate
    End Sub

    Private Sub MenuStrip1_MouseDown(sender As Object, e As MouseEventArgs) Handles MenuStrip1.MouseDown
        drag = True
    End Sub
    Private Sub MenuStrip1_MouseMove(sender As Object, e As MouseEventArgs) Handles MenuStrip1.MouseMove
        If drag Then
            'the drag code for menu bar is not implemented yet
        End If
    End Sub

    Private Sub MenuStrip1_MouseUp(sender As Object, e As MouseEventArgs) Handles MenuStrip1.MouseUp
        drag = False
    End Sub

    Private Sub Dloadtimer_Tick(sender As Object, e As EventArgs) Handles dloadtimer.Tick
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\dload.exe") Then
            dloadtimer.Enabled = False
            CheckForUpdatesToolStripMenuItem.Enabled = True
            CheckForUpdatesToolStripMenuItem.Text = "Install system updates"
            MessageDialog.messageicon = "Help"
            MessageDialog.messagetext = "Would you like to install updates now? This will restart the system!"
            MessageDialog.messagetitle = "Updates have been successfully downloaded"
            MessageDialog.messagetype = "YesNo"
            If MessageDialog.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                Dim p As Process
                p.StartInfo.FileName = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\FirmwareUpgrader.exe"
                p.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
                p.StartInfo.CreateNoWindow = False
                p.StartInfo.WorkingDirectory = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed"
                p.Start()
                Form1.es = False
                Save()
                Form1.Close()
            End If
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

    End Sub

    Private Sub PowerToolStripMenuItem_MouseMove(sender As Object, e As MouseEventArgs) Handles PowerToolStripMenuItem.MouseMove
        If CheckForUpdatesToolStripMenuItem.Text = "Install system updates" Then
            RebootToolStripMenuItem.Text = "&Reboot and install updates"
        Else
            RebootToolStripMenuItem.Text = "&Reboot"
        End If
    End Sub

    Private Sub DebugStringblasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DebugStringblasterToolStripMenuItem.Click
        Dim i As Integer = 0
        For Each element As Form In My.Application.OpenForms
            For Each obj As Control In element.Controls
                Try
                    obj.Text = ""
                    ' += 1
                Catch ex As Exception

                End Try
            Next
        Next
    End Sub

    Private Sub NewLoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewLoginToolStripMenuItem.Click
        NewLogin.Show()
    End Sub

    Private Sub SolitaireToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SolitaireToolStripMenuItem.Click
        If Not tskmgr.ListBox1.Items.Contains("Solitaire") Then
            tskmgr.ListBox1.Items.Add("Solitaire")
        End If
        Dim sol As Solitaire = New Solitaire()
        sol.Show()
    End Sub

    Private Sub Desktop_BackgroundImageChanged(sender As Object, e As EventArgs) Handles MyBase.BackgroundImageChanged
        obj.BackgroundImage = Me.BackgroundImage
    End Sub
End Class