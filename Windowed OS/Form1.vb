'Imports System.Collections.Generic
'Windowed O/S // Codename: KeepCsAway
'\ in front during loads and saves refers to current drive
Public Class Form1
    Public es As Boolean = True
    Public appBg As Label = New Label
    Public appFg As Label = New Label
    Public labelBg As Label = New Label
    Public labelFg As Label = New Label
    Public dtl As Boolean = True
    Public ebs As Boolean = True
    Public elw As Boolean = True
    Public edc As Boolean = False
    Public bsi As String = "def"
    Public bi As String = "Local_1"
    Public fn As Form
    Public sn As Form
    Public cfn As Form
    Public csn As Form
    Public dotick As Boolean = False
    Public updatechecked As Boolean = False
    Public dr As DialogResult = New DialogResult()
    Public check As String = "Check"
    Public channel As String = "Prerelease"
    Public server As String = "http://markustegelane.eu/firmware/windowed_os/prereleases/update.txt"
    Public eul As Boolean = True
    Public esb As Boolean = True
    Public esr As Boolean = True
    Public ubm As Boolean = True
    Public eab As Boolean = True
    Public elm As Boolean = False
    Public wm As String = ""
    Dim factory As Boolean = False
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Try
                tskmgr.Location = New Point(0, 0)
            Catch
                tskmgr.Location = New Point(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
            End Try

            tskmgr.StartPosition = FormStartPosition.Manual
                tskmgr.Opacity = 0.0
                tskmgr.Show()
                tskmgr.Close()
                tskmgr.StartPosition = FormStartPosition.WindowsDefaultLocation
            Catch ex As Exception
                Me.Close()
        End Try
        Try
            If System.IO.File.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData + "\Windowed\update.cfg") Then
                Dim updatecontent As String()
                updatecontent = System.IO.File.ReadAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData + "\Windowed\update.cfg").Split(";")
                channel = updatecontent(0)
                check = updatecontent(1)
                server = updatecontent(2)
            End If
            If LogoffWindow.Visible = True Then LogoffWindow.Close()
            'hides the cursor
            Me.Hide()
            appBg.BackColor = Color.WhiteSmoke
            appFg.BackColor = Color.Black
            labelBg.BackColor = Color.DimGray
            labelFg.ForeColor = Color.White
            If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\system.cfg") Then
                Dim lstbox As ListBox = New ListBox
                Dim fstr As String
                fstr = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\system.cfg")
                lstbox.Items.AddRange(fstr.Split(";"))
                lstbox.SelectedIndex = 0
                If lstbox.SelectedItem = "True" Then es = True
                If lstbox.SelectedItem = "False" Then es = False

                lstbox.SelectedIndex = 1
                If lstbox.SelectedItem = "" Then
                    labelBg.BackColor = Color.DimGray
                    GoTo color2
                End If
                Dim a As String
                a = lstbox.SelectedItem.ToString().Replace("Color [", "")
                a = a.Replace("]", "")
                If Not a.Contains("A=") Then
                    labelBg.BackColor = Color.FromName(a)
                Else
                    Dim colorlist As ListBox = New ListBox()
                    a = a.Replace("A=", "")
                    a = a.Replace("R=", "")
                    a = a.Replace("G=", "")
                    a = a.Replace("B=", "")
                    a = a.Replace(" ", "")
                    colorlist.Items.Clear()
                    colorlist.Items.AddRange(a.Split(","))
                    colorlist.SelectedIndex = 1
                    Dim red As Integer = colorlist.SelectedItem
                    colorlist.SelectedIndex = 2
                    Dim green As Integer = colorlist.SelectedItem
                    colorlist.SelectedIndex = 3
                    Dim blue As Integer = colorlist.SelectedItem
                    labelBg.BackColor = Color.FromArgb(red, green, blue)
                End If
color2:
                lstbox.SelectedIndex = 2
                If lstbox.SelectedItem = "" Then
                    labelFg.BackColor = Color.White
                    GoTo color3
                End If
                a = lstbox.SelectedItem.ToString().Replace("Color [", "")
                a = a.Replace("]", "")
                If Not a.Contains("A=") Then
                    labelFg.BackColor = Color.FromName(a)
                Else
                    Dim colorlist As ListBox = New ListBox()
                    a = a.Replace("A=", "")
                    a = a.Replace("R=", "")
                    a = a.Replace("G=", "")
                    a = a.Replace("B=", "")
                    a = a.Replace(" ", "")
                    colorlist.Items.Clear()
                    colorlist.Items.AddRange(a.Split(","))
                    colorlist.SelectedIndex = 1
                    Dim red As Integer = colorlist.SelectedItem
                    colorlist.SelectedIndex = 2
                    Dim green As Integer = colorlist.SelectedItem
                    colorlist.SelectedIndex = 3
                    Dim blue As Integer = colorlist.SelectedItem
                    labelFg.BackColor = Color.FromArgb(red, green, blue)
                End If
color3:
                lstbox.SelectedIndex = 3
                If lstbox.SelectedItem = "" Then
                    appBg.BackColor = Color.WhiteSmoke
                    GoTo color4
                End If
                a = lstbox.SelectedItem.ToString().Replace("Color [", "")
                a = a.Replace("]", "")
                If Not a.Contains("A=") Then
                    appBg.BackColor = Color.FromName(a)
                Else
                    Dim colorlist As ListBox = New ListBox()
                    a = a.Replace("A=", "")
                    a = a.Replace("R=", "")
                    a = a.Replace("G=", "")
                    a = a.Replace("B=", "")
                    a = a.Replace(" ", "")
                    colorlist.Items.Clear()
                    colorlist.Items.AddRange(a.Split(","))
                    colorlist.SelectedIndex = 1
                    Dim red As Integer = colorlist.SelectedItem
                    colorlist.SelectedIndex = 2
                    Dim green As Integer = colorlist.SelectedItem
                    colorlist.SelectedIndex = 3
                    Dim blue As Integer = colorlist.SelectedItem
                    appBg.BackColor = Color.FromArgb(red, green, blue)
                End If
color4:
                lstbox.SelectedIndex = 4
                If lstbox.SelectedItem = "" Then
                    appFg.BackColor = Color.Black
                    GoTo color5
                End If
                a = lstbox.SelectedItem.ToString().Replace("Color [", "")
                a = a.Replace("]", "")
                If Not a.Contains("A=") Then
                    appFg.BackColor = Color.FromName(a)
                Else
                    Dim colorlist As ListBox = New ListBox()
                    a = a.Replace("A=", "")
                    a = a.Replace("R=", "")
                    a = a.Replace("G=", "")
                    a = a.Replace("B=", "")
                    a = a.Replace(" ", "")
                    colorlist.Items.Clear()
                    colorlist.Items.AddRange(a.Split(","))
                    colorlist.SelectedIndex = 1
                    Dim red As Integer = colorlist.SelectedItem
                    colorlist.SelectedIndex = 2
                    Dim green As Integer = colorlist.SelectedItem
                    colorlist.SelectedIndex = 3
                    Dim blue As Integer = colorlist.SelectedItem
                    appFg.BackColor = Color.FromArgb(red, green, blue)
                End If
color5:
                lstbox.SelectedIndex = 5
                If lstbox.SelectedItem = "True" Then elw = True
                If lstbox.SelectedItem = "False" Then elw = False
                lstbox.SelectedIndex = 6
                If lstbox.SelectedItem = "True" Then ebs = True
                If lstbox.SelectedItem = "False" Then ebs = False
                lstbox.SelectedIndex = 7
                If lstbox.SelectedItem = "True" Then dtl = True
                If lstbox.SelectedItem = "False" Then dtl = False
                lstbox.SelectedIndex = 8
                If lstbox.SelectedItem = "def" Then
                    'sets the background image (depending on the aspect ratio)
                    If My.Computer.Screen.Bounds.Width / My.Computer.Screen.Bounds.Height = 5 / 4 Then
                        Me.BackgroundImage = My.Resources.startup1
                    ElseIf My.Computer.Screen.Bounds.Width / My.Computer.Screen.Bounds.Height = 4 / 3 Then
                        Me.BackgroundImage = My.Resources.startup1
                    ElseIf My.Computer.Screen.Bounds.Width / My.Computer.Screen.Bounds.Height = 16 / 9 Then
                        Me.BackgroundImage = My.Resources.startup3
                    ElseIf My.Computer.Screen.Bounds.Width / My.Computer.Screen.Bounds.Height = 16 / 10 Then
                        Me.BackgroundImage = My.Resources.startup4
                    Else
                        Me.BackgroundImage = My.Resources.startup1
                    End If
                    GoTo gft
                Else
                    bsi = lstbox.SelectedItem.ToString()
                    Me.BackgroundImage = Image.FromFile(lstbox.SelectedItem)
                End If
gft:
                lstbox.SelectedIndex = 9
                bi = lstbox.SelectedItem
                Try
                    lstbox.SelectedIndex = 10
                    If lstbox.SelectedItem.ToString() = "True" Then
                        edc = True
                    ElseIf lstbox.SelectedItem.ToString() = "False" Then
                        edc = False
                    End If
                    If lstbox.Items(11).ToString() = "True" Then
                        eul = True
                    ElseIf lstbox.Items(11).ToString() = "False" Then
                        eul = False
                    End If
                    If lstbox.Items(12).ToString() = "True" Then
                        esb = True
                    ElseIf lstbox.Items(12).ToString() = "False" Then
                        esb = False
                    End If
                    If lstbox.Items(13).ToString() = "True" Then
                        esr = True
                    ElseIf lstbox.Items(13).ToString() = "False" Then
                        esr = False
                    End If
                    If lstbox.Items(14).ToString() = "True" Then
                        ubm = True
                    ElseIf lstbox.Items(14).ToString() = "False" Then
                        ubm = False
                    End If
                    If lstbox.Items(15).ToString() = "True" Then
                        eab = True
                    ElseIf lstbox.Items(15).ToString() = "False" Then
                        eab = False
                    End If
                    If lstbox.Items(16).ToString() = "True" Then
                        elm = True
                    ElseIf lstbox.Items(16).ToString() = "False" Then
                        elm = False
                    End If
                    If lstbox.Items(17).ToString() = "True" Then
                        wm = True
                    ElseIf lstbox.Items(17).ToString() = "False" Then
                        wm = False
                    End If
                Catch ex As Exception
                    GoTo yeawhatcanyoudoaboutit
                End Try
            Else
                If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed") Then
                    My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed")
                    factory = True
                End If
                Me.BackgroundImage = My.Resources.startup1
                My.Computer.FileSystem.WriteAllText("True;Color [DimGray];Color [White];Color [WhiteSmoke];Color [Black];True;True;True;def;Local_1;False;", My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\system.cfg", False)
            End If
yeawhatcanyoudoaboutit:
            If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\recovery.log") Then
                My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\recovery.log")
                Recovery.ShowDialog()
            End If
            If ebs = True Then Me.Show()
            Cursor.Hide()
            If Desktop.dev = True Then dev.Visible = True
            'hidden windowed mode beta test
            If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\FS.txt") Then WindowState = FormWindowState.Maximized
            If Not My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\FS.txt") Then WindowState = FormWindowState.Maximized
            If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\FS.txt") Then FormBorderStyle = FormBorderStyle.Fixed3D
            If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\FS.txt") Then Desktop.FormBorderStyle = FormBorderStyle.Fixed3D
            If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\FS.txt") Then black.FormBorderStyle = FormBorderStyle.Fixed3D
            If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\FS.txt") Then ShutDown.FormBorderStyle = FormBorderStyle.Fixed3D
            black.Show()
            'makes sure that the window is topmost
            Me.TopMost = False
            Me.TopMost = True
        Catch ex As Exception
            Timer1.Enabled = False
            CriticalError.Label5.Text = "System configuration file seems to be corrupted." & vbNewLine & "Error details: " & ex.Message
            CriticalError.ShowDialog()
            Desktop.appBg.BackColor = Color.WhiteSmoke
            Desktop.appFg.BackColor = Color.Black
            Desktop.labelBg.BackColor = Color.DimGray
            Desktop.labelFg.BackColor = Color.White
            MessageDialog.messagetype = "YesNo"
            MessageDialog.messageicon = "Critical"
            MessageDialog.messagetitle = "System configuration file is corrupted"
            MessageDialog.messagetext = "Critical system configuration file seems to be corrupted. Would you like to recreate this file? (any custom system configurations will be lost)"
            If MessageDialog.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                Try
                    My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\system.cfg", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.DeletePermanently)
                Catch
                End Try
                If Not My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\system.cfg") Then
                    MessageDialog.messagetype = "OKOnly"
                    MessageDialog.messageicon = "Info"
                    MessageDialog.messagetitle = "Restoration successful"
                    MessageDialog.messagetext = "Windowed OS will now reboot"
                    MessageDialog.ShowDialog()
                    ShutDown.restart = True
                    ShutDown.Show()
                    Exit Sub
                Else
                    MessageDialog.messagetype = "OKOnly"
                    MessageDialog.messageicon = "Critical"
                    MessageDialog.messagetitle = "Restoration failed"
                    MessageDialog.messagetext = "User did not accept file deletion"
                    MessageDialog.ShowDialog()
                    ShutDown.restart = False
                    ShutDown.Show()
                End If
            Else
                MessageDialog.messagetype = "OKOnly"
                MessageDialog.messageicon = "Info"
                MessageDialog.messagetitle = "System configuration restoration cancelled by the user"
                MessageDialog.messagetext = "As you cancelled the operation, Windowed OS must shut down."
                MessageDialog.ShowDialog()
                ShutDown.Show()
            End If
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        Try
            If elw = True Then
                StartupWindow.Show()
                If elw = True Then StartupWindow.ProgressBar1.Visible = True
            End If
            'system loader
            If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\updated.txt") Then
                If StartupWindow.ProgressBar1.Value = 5 Then
                    Timer1.Enabled = False
                    StartupWindow.Opacity = 1.0
                    If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then StartupWindow.composedwindow.Opacity = 0.9
                    StartupWindow.LogoffWindow.Text = "Cleaning temporary update files..."
                    StartupWindow.ProgressBar1.Visible = False
                    StartupWindow.LogoffTitle.Text = "Finalizing update..."
                    My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\FirmwareUpgrader.exe")
                    Dim s As String = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\locator.txt")
                    s = s.Replace(vbNewLine, "")
                    If Not s = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData Then

                    End If
                    My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\locator.txt")
                    My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\dload.exe")
                    My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\dload.bat")
                    My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\version.txt")
                    My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\wget.exe")
                    My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\updated.txt")
                    If es = True Then My.Computer.Audio.Play(My.Resources.shutdown11, AudioPlayMode.WaitToComplete)
                    Process.Start("Windowed OS.exe")
                    Me.Close()
                Else
                    StartupWindow.ProgressBar1.Increment(1)
                    Exit Sub
                End If
            End If
                If StartupWindow.ProgressBar1.Value = 4 Then
                    StartupWindow.Opacity = 1.0
                    If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then StartupWindow.composedwindow.Opacity = 0.9
                    StartupWindow.LogoffWindow.Text = "Starting up..."
                    If Desktop.Visible = True Then Desktop.Close()
                    'startpoint:
                    StartupWindow.LogoffWindow.Text = "Loading user data..."
                    Desktop.Label1.Text = Now
                    If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed") Then My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed")

                    'kpsg:
                    StartupWindow.LogoffWindow.Text = "Please wait..."
                    If Not My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\locations.txt") Then Timer1.Enabled = False
                If factory Then
                    'My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
                    Cursor.Show()
                    Desktop.labelBg.BackColor = labelBg.BackColor
                    Desktop.labelFg.BackColor = labelFg.BackColor
                    Desktop.appBg.BackColor = appBg.BackColor
                    Desktop.appFg.BackColor = appFg.BackColor
                    StartupWindow.Hide()
                    Timer1.Enabled = False
                    MessageDialog.messageicon = "Special"
                    MessageDialog.messagetext = "Welcome to Windowed OS"
                    MessageDialog.messagetitle = "Out of the box experience"
                    MessageDialog.ShowDialog()
                    OutBoxSetup.ShowDialog()
                    Exit Sub
                End If
                StartupWindow.ProgressBar1.Value = StartupWindow.ProgressBar1.Value + 2
                ElseIf StartupWindow.ProgressBar1.Value = StartupWindow.ProgressBar1.Maximum Then
                    If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\login.txt") Then
                        Dim gimn As String
                        gimn = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\login.txt")
                        Login.ListBox1.Items.Clear()
                        Login.ListBox1.Items.AddRange(gimn.Split(";"))
                        Login.ListBox1.SelectedIndex = 0
                        LoginPrompt.NameField.Text = Login.ListBox1.SelectedItem
                        Login.ListBox1.SelectedIndex = 1
                        LoginPrompt.PassField.Text = Login.ListBox1.SelectedItem
                        Login.ListBox1.Items.Clear()
                        'login button
                        LoginPrompt.Label1.Text = "Logging in"
                        If Not My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & LoginPrompt.NameField.Text & ".txt") Then
                            Timer1.Enabled = False
                            Desktop.labelBg.BackColor = labelBg.BackColor
                            Desktop.labelFg.BackColor = labelFg.BackColor
                            Desktop.appBg.BackColor = appBg.BackColor
                            Desktop.appFg.BackColor = appFg.BackColor
                            MessageDialog.messagetitle = "Windowed OS"
                            MessageDialog.messagetext = "Wrong username"
                            MessageDialog.messageicon = "Critical"
                            MessageDialog.ShowDialog()
                            Login.Show()
                            LoginPrompt.PassField.Text = ""
                            Me.Hide()
                            LoginPrompt.Label1.Text = "Login screen"
                            Exit Sub
                        Else
                            Dim inputpass As String
                            inputpass = Login.Encrypt(LoginPrompt.PassField.Text, LoginPrompt.PassField.Text)
                            Dim gimd As String
                            gimd = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & LoginPrompt.NameField.Text & ".txt")
                            Login.ListBox1.Items.Clear()
                            Login.ListBox1.Items.AddRange(gimd.Split(";"))
                            Login.ListBox1.SelectedIndex = 0

                            If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & LoginPrompt.NameField.Text & "_admin.txt") Then Desktop.usertype = "Admin"
                            If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & LoginPrompt.NameField.Text & "_power.txt") Then Desktop.usertype = "Power"
                            If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & LoginPrompt.NameField.Text & "_standard.txt") Then Desktop.usertype = "Standard"
                            If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & LoginPrompt.NameField.Text & "_limited.txt") Then Desktop.usertype = "Limited"
                            If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & LoginPrompt.NameField.Text & "_guest.txt") Then Desktop.usertype = "Guest"
                            If Desktop.usertype = "" Then
                                Timer1.Enabled = False
                                Desktop.labelBg.BackColor = labelBg.BackColor
                                Desktop.labelFg.BackColor = labelFg.BackColor
                                Desktop.appBg.BackColor = appBg.BackColor
                                Desktop.appFg.BackColor = appFg.BackColor
                                MessageDialog.messagetitle = "Login operation failed"
                                MessageDialog.messagetext = "Invalid or unknown user type"
                                MessageDialog.messageicon = "Critical"
                                MessageDialog.ShowDialog()
                                LoginPrompt.PassField.Text = ""
                                Login.Show()
                                Me.Hide()
                                LoginPrompt.Label1.Text = "Login screen"
                                Exit Sub
                            End If
                            If Desktop.usertype = "Guest" Then
                                Desktop.user = LoginPrompt.NameField.Text
                                Desktop.passwd = inputpass
                                LoginPrompt.NameField.Text = "DefaultUser"
                                LoginPrompt.PassField.Text = ""
                                Desktop.labelBg.BackColor = labelBg.BackColor
                                Desktop.labelFg.BackColor = labelFg.BackColor
                                Desktop.appBg.BackColor = appBg.BackColor
                                Desktop.appFg.BackColor = appFg.BackColor
                                If es = True Then My.Computer.Audio.Play(My.Resources.startup9, AudioPlayMode.Background)
                            If Not bi = "Local_1" Then
                                Desktop.BackgroundImage = Image.FromFile(bi)
                            End If
                            If Not wm = "" Then MsgDialog(wm, "Welcome message", "Info", "OKOnly")
                            Desktop.Show()
                                Hide()
                                Login.Close()
                            End If
                            If Desktop.usertype = "Limited" Then
                                Login.ListBox1.SelectedIndex = 1
                                Dim x As String
                                Dim y As String
                                x = Login.ListBox1.SelectedItem.ToString
                                Login.ListBox1.SelectedIndex = Login.ListBox1.SelectedIndex + 1
                                y = Login.ListBox1.SelectedItem.ToString
                                Desktop.PictureBox2.Top = y
                                Desktop.PictureBox2.Left = x
                                Login.ListBox1.SelectedIndex = Login.ListBox1.SelectedIndex + 1
                                x = Login.ListBox1.SelectedItem.ToString
                                Login.ListBox1.SelectedIndex = Login.ListBox1.SelectedIndex + 1
                                y = Login.ListBox1.SelectedItem.ToString
                                Desktop.PictureBox3.Top = y
                                Desktop.PictureBox3.Left = x
                                Login.ListBox1.SelectedIndex = Login.ListBox1.SelectedIndex + 1
                                x = Login.ListBox1.SelectedItem.ToString
                                Login.ListBox1.SelectedIndex = Login.ListBox1.SelectedIndex + 1
                                y = Login.ListBox1.SelectedItem.ToString
                                Desktop.PictureBox4.Top = y
                                Desktop.PictureBox4.Left = x
                                Login.ListBox1.SelectedIndex = Login.ListBox1.SelectedIndex + 1
                                x = Login.ListBox1.SelectedItem.ToString
                                Login.ListBox1.SelectedIndex = Login.ListBox1.SelectedIndex + 1
                                y = Login.ListBox1.SelectedItem.ToString
                                Desktop.PictureBox5.Top = y
                                Desktop.PictureBox5.Left = x
                                Login.ListBox1.SelectedIndex = Login.ListBox1.SelectedIndex + 1
                                Login.ListBox1.SelectedIndex = 9
                                Desktop.user = LoginPrompt.NameField.Text
                                Desktop.passwd = inputpass

                                Try
                                    Login.ListBox1.SelectedIndex = 9
                                Catch
                                    GoTo skipspast
                                End Try
                                If Login.ListBox1.SelectedItem = "True" Then Desktop.Label2.Visible = True
                                If Login.ListBox1.SelectedItem = "False" Then Desktop.Label2.Visible = False
                                Try
                                    Login.ListBox1.SelectedIndex = 10
                                Catch
                                    GoTo skipspast
                                End Try
                                If Login.ListBox1.SelectedItem = "True" Then Desktop.Label1.Visible = True
                                If Login.ListBox1.SelectedItem = "False" Then Desktop.Label1.Visible = False
                                Try
                                    Login.ListBox1.SelectedIndex = 11
                                Catch ex As Exception
                                    GoTo skipspast
                                End Try
                                Desktop.CPU_Tracker.Interval = Login.ListBox1.SelectedItem
skipspast:
                                Try
                                    Login.ListBox1.SelectedIndex = 12
                                    Desktop.PictureBox6.Left = Login.ListBox1.SelectedItem
                                    Login.ListBox1.SelectedIndex = 13
                                    Desktop.PictureBox6.Top = Login.ListBox1.SelectedItem
                                    Login.ListBox1.SelectedIndex = 14
                                    Desktop.PictureBox7.Left = Login.ListBox1.SelectedItem
                                    Login.ListBox1.SelectedIndex = 15
                                    Desktop.PictureBox7.Top = Login.ListBox1.SelectedItem
                                    Login.ListBox1.SelectedIndex = 16
                                    Desktop.PictureBox8.Left = Login.ListBox1.SelectedItem
                                    Login.ListBox1.SelectedIndex = 17
                                    Desktop.PictureBox8.Top = Login.ListBox1.SelectedItem
                                    Login.ListBox1.SelectedIndex = 18
                                    Desktop.PictureBox9.Left = Login.ListBox1.SelectedItem
                                    Login.ListBox1.SelectedIndex = 19
                                    Desktop.PictureBox9.Top = Login.ListBox1.SelectedItem
                                    Login.ListBox1.SelectedIndex = 20
                                    Desktop.PictureBox10.Left = Login.ListBox1.SelectedItem
                                    Login.ListBox1.SelectedIndex = 21
                                    Desktop.PictureBox10.Top = Login.ListBox1.SelectedItem
                                Catch
                                    GoTo issgh
                                End Try
                                Try
                                    Login.ListBox1.SelectedIndex = 22
                                    If Login.ListBox1.SelectedItem.ToString() = "True" Then Desktop.ShowhideIconsToolStripMenuItem.Checked = True

                                    Try
                                        Login.ListBox1.SelectedIndex = 23
                                    Catch ex As Exception
                                        GoTo issgh
                                    End Try
                                    If Login.ListBox1.SelectedItem = "True" Then Desktop.Label3.Visible = True
                                    If Login.ListBox1.SelectedItem = "True" Then Desktop.Label4.Visible = True
                                    If Login.ListBox1.SelectedItem = "False" Then Desktop.Label3.Visible = False
                                    If Login.ListBox1.SelectedItem = "False" Then Desktop.Label4.Visible = False
                                Catch
                                    GoTo issgh
                                End Try
issgh:
                                LoginPrompt.NameField.Text = "DefaultUser"
                                LoginPrompt.PassField.Text = ""
                                Desktop.labelBg.BackColor = labelBg.BackColor
                                Desktop.labelFg.BackColor = labelFg.BackColor
                                Desktop.appBg.BackColor = appBg.BackColor
                                Desktop.appFg.BackColor = appFg.BackColor
                                If es = True Then My.Computer.Audio.Play(My.Resources.startup9, AudioPlayMode.Background)
                                If Not bi = "Local_1" Then
                                    Desktop.BackgroundImage = Image.FromFile(bi)
                                End If
                            Try
                                Login.ListBox1.SelectedIndex += 1
                                If Login.ListBox1.SelectedItem.ToString() = "True" Then
                                    Dim inversed As Color = Color.FromArgb(Not Desktop.Label2.ForeColor.R, Not Desktop.Label2.ForeColor.G, Not Desktop.Label2.ForeColor.B)
                                    Desktop.Label1.BackColor = inversed
                                    Desktop.Label2.BackColor = inversed
                                    Desktop.Label3.BackColor = inversed
                                    Desktop.Label4.BackColor = inversed
                                Else
                                    Desktop.Label1.BackColor = Color.Transparent
                                    Desktop.Label2.BackColor = Color.Transparent
                                    Desktop.Label3.BackColor = Color.Transparent
                                    Desktop.Label4.BackColor = Color.Transparent
                                End If
                            Catch
                            End Try
                            If Not wm = "" Then MsgDialog(wm, "Welcome message", "Info", "OKOnly")
                            Desktop.Show()
                            Hide()
                            Login.Close()
                        End If
                            If Desktop.usertype = "Admin" Or Desktop.usertype = "Standard" Or Desktop.usertype = "Power" Then
                                Dim x As String
                                Dim y As String
                                Login.ListBox1.SelectedIndex = 1
                                x = Login.ListBox1.SelectedItem.ToString
                                Login.ListBox1.SelectedIndex = Login.ListBox1.SelectedIndex + 1
                                y = Login.ListBox1.SelectedItem.ToString
                                Desktop.PictureBox2.Top = y
                                Desktop.PictureBox2.Left = x
                                Login.ListBox1.SelectedIndex = Login.ListBox1.SelectedIndex + 1
                                x = Login.ListBox1.SelectedItem.ToString
                                Login.ListBox1.SelectedIndex = Login.ListBox1.SelectedIndex + 1
                                y = Login.ListBox1.SelectedItem.ToString
                                Desktop.PictureBox3.Top = y
                                Desktop.PictureBox3.Left = x
                                Login.ListBox1.SelectedIndex = Login.ListBox1.SelectedIndex + 1
                                x = Login.ListBox1.SelectedItem.ToString
                                Login.ListBox1.SelectedIndex = Login.ListBox1.SelectedIndex + 1
                                y = Login.ListBox1.SelectedItem.ToString
                                Desktop.PictureBox4.Top = y
                                Desktop.PictureBox4.Left = x
                                Login.ListBox1.SelectedIndex = Login.ListBox1.SelectedIndex + 1
                                x = Login.ListBox1.SelectedItem.ToString
                                Login.ListBox1.SelectedIndex = Login.ListBox1.SelectedIndex + 1
                                y = Login.ListBox1.SelectedItem.ToString
                                Desktop.PictureBox5.Top = y
                                Desktop.PictureBox5.Left = x
                                Login.ListBox1.SelectedIndex = Login.ListBox1.SelectedIndex + 1
                                Login.ListBox1.SelectedIndex = 9
                                If Login.ListBox1.SelectedItem = "" Then
                                    GoTo defaultp
                                End If
defaultp:
                                Try
                                    Desktop.OpenFileDialog1.FileName = Login.ListBox1.SelectedItem
                                    Desktop.PictureBox1.Load(Desktop.OpenFileDialog1.FileName)
                                Catch ex As Exception
                                    If Login.ListBox1.SelectedItem = "Local_1" Then
                                        Desktop.PictureBox1.Image = My.Resources.f16929280
                                        GoTo skipload
                                    End If
                                    If Login.ListBox1.SelectedItem = "Local_2" Then
                                        Desktop.PictureBox1.Image = My.Resources.f22272576
                                        GoTo skipload
                                    End If
                                    If Login.ListBox1.SelectedItem = "Local_3" Then
                                        If My.Computer.Screen.Bounds.Width / My.Computer.Screen.Bounds.Height = 5 / 4 Then
                                            Desktop.PictureBox1.Image = My.Resources.startup1
                                        ElseIf My.Computer.Screen.Bounds.Width / My.Computer.Screen.Bounds.Height = 4 / 3 Then
                                            Desktop.PictureBox1.Image = My.Resources.startup1
                                        ElseIf My.Computer.Screen.Bounds.Width / My.Computer.Screen.Bounds.Height = 16 / 9 Then
                                            Desktop.PictureBox1.Image = My.Resources.startup3
                                        ElseIf My.Computer.Screen.Bounds.Width / My.Computer.Screen.Bounds.Height = 16 / 10 Then
                                            Desktop.PictureBox1.Image = My.Resources.startup4
                                        Else
                                            Desktop.PictureBox1.Image = My.Resources.startup1
                                        End If
                                        GoTo skipload
                                    End If

                                End Try
skipload:
                                Desktop.BackgroundImage = Desktop.PictureBox1.Image
                                Login.ListBox1.SelectedIndex = 10
                                If Login.ListBox1.SelectedItem = "" Then
                                    Desktop.labelBg.BackColor = labelBg.BackColor
                                    GoTo color2
                                End If
                                Dim a As String
                                a = Login.ListBox1.SelectedItem.ToString().Replace("Color [", "")
                                a = a.Replace("]", "")
                                If Not a.Contains("A=") Then
                                    Desktop.labelBg.BackColor = Color.FromName(a)
                                Else
                                    Dim colorlist As ListBox = New ListBox()
                                    a = a.Replace("A=", "")
                                    a = a.Replace("R=", "")
                                    a = a.Replace("G=", "")
                                    a = a.Replace("B=", "")
                                    a = a.Replace(" ", "")
                                    colorlist.Items.Clear()
                                    colorlist.Items.AddRange(a.Split(","))
                                    colorlist.SelectedIndex = 1
                                    Dim red As Integer = colorlist.SelectedItem
                                    colorlist.SelectedIndex = 2
                                    Dim green As Integer = colorlist.SelectedItem
                                    colorlist.SelectedIndex = 3
                                    Dim blue As Integer = colorlist.SelectedItem
                                    Desktop.labelBg.BackColor = Color.FromArgb(red, green, blue)
                                End If
color2:
                                Login.ListBox1.SelectedIndex = 11
                                If Login.ListBox1.SelectedItem = "" Then
                                    Desktop.labelFg.BackColor = labelFg.BackColor
                                    GoTo color3
                                End If
                                a = Login.ListBox1.SelectedItem.ToString().Replace("Color [", "")
                                a = a.Replace("]", "")
                                If Not a.Contains("A=") Then
                                    Desktop.labelFg.BackColor = Color.FromName(a)
                                Else
                                    Dim colorlist As ListBox = New ListBox()
                                    a = a.Replace("A=", "")
                                    a = a.Replace("R=", "")
                                    a = a.Replace("G=", "")
                                    a = a.Replace("B=", "")
                                    a = a.Replace(" ", "")
                                    colorlist.Items.Clear()
                                    colorlist.Items.AddRange(a.Split(","))
                                    colorlist.SelectedIndex = 1
                                    Dim red As Integer = colorlist.SelectedItem
                                    colorlist.SelectedIndex = 2
                                    Dim green As Integer = colorlist.SelectedItem
                                    colorlist.SelectedIndex = 3
                                    Dim blue As Integer = colorlist.SelectedItem
                                    Desktop.labelFg.BackColor = Color.FromArgb(red, green, blue)
                                End If
color3:
                                Login.ListBox1.SelectedIndex = 12
                                If Login.ListBox1.SelectedItem = "" Then
                                    Desktop.appBg.BackColor = appBg.BackColor
                                    GoTo color4
                                End If
                                a = Login.ListBox1.SelectedItem.ToString().Replace("Color [", "")
                                a = a.Replace("]", "")
                                If Not a.Contains("A=") Then
                                    Desktop.appBg.BackColor = Color.FromName(a)
                                Else
                                    Dim colorlist As ListBox = New ListBox()
                                    a = a.Replace("A=", "")
                                    a = a.Replace("R=", "")
                                    a = a.Replace("G=", "")
                                    a = a.Replace("B=", "")
                                    a = a.Replace(" ", "")
                                    colorlist.Items.Clear()
                                    colorlist.Items.AddRange(a.Split(","))
                                    colorlist.SelectedIndex = 1
                                    Dim red As Integer = colorlist.SelectedItem
                                    colorlist.SelectedIndex = 2
                                    Dim green As Integer = colorlist.SelectedItem
                                    colorlist.SelectedIndex = 3
                                    Dim blue As Integer = colorlist.SelectedItem
                                    Desktop.appBg.BackColor = Color.FromArgb(red, green, blue)
                                End If
color4:
                                Login.ListBox1.SelectedIndex = 13
                                If Login.ListBox1.SelectedItem = "" Then
                                    Desktop.appFg.BackColor = appFg.BackColor
                                    GoTo color5
                                End If
                                a = Login.ListBox1.SelectedItem.ToString().Replace("Color [", "")
                                a = a.Replace("]", "")
                                If Not a.Contains("A=") Then
                                    Desktop.appFg.BackColor = Color.FromName(a)
                                Else
                                    Dim colorlist As ListBox = New ListBox()
                                    a = a.Replace("A=", "")
                                    a = a.Replace("R=", "")
                                    a = a.Replace("G=", "")
                                    a = a.Replace("B=", "")
                                    a = a.Replace(" ", "")
                                    colorlist.Items.Clear()
                                    colorlist.Items.AddRange(a.Split(","))
                                    colorlist.SelectedIndex = 1
                                    Dim red As Integer = colorlist.SelectedItem
                                    colorlist.SelectedIndex = 2
                                    Dim green As Integer = colorlist.SelectedItem
                                    colorlist.SelectedIndex = 3
                                    Dim blue As Integer = colorlist.SelectedItem
                                    Desktop.appFg.BackColor = Color.FromArgb(red, green, blue)
                                End If
color5:
                                CustomizationCenter.BottomRight.Checked = False
                                CustomizationCenter.BottomLeftButton.Checked = False
                                Desktop.WindowState = FormWindowState.Normal
                                Try
                                    Login.ListBox1.SelectedIndex = 14
                                Catch
                                    GoTo skippast
                                End Try
                                Dim dtp = Login.ListBox1.SelectedItem.ToString()
                                If dtp = "TopLeft" Then CustomizationCenter.TopLeft.Checked = True
                                If dtp = "Top" Then CustomizationCenter.TopBtn.Checked = True
                                If dtp = "TopRight" Then CustomizationCenter.TopRight.Checked = True
                                If dtp = "Left" Then CustomizationCenter.LeftBtn.Checked = True
                                If dtp = "None" Then CustomizationCenter.None.Checked = True
                                If dtp = "Right" Then CustomizationCenter.RightBtn.Checked = True
                                If dtp = "BottomLeft" Then CustomizationCenter.BottomLeft.Checked = True
                                If dtp = "Bottom" Then CustomizationCenter.BottomBtn.Checked = True
                                If dtp = "BottomRight" Then CustomizationCenter.BottomRight.Checked = True
                                Try
                                    Login.ListBox1.SelectedIndex = 15
                                Catch
                                    GoTo skippast
                                End Try
                                dtp = Login.ListBox1.SelectedItem.ToString()
                                If dtp = "TopLeft" Then CustomizationCenter.TopLeftButton.Checked = True
                                If dtp = "Top" Then CustomizationCenter.TopButton.Checked = True
                                If dtp = "TopRight" Then CustomizationCenter.TopRightButton.Checked = True
                                If dtp = "Left" Then CustomizationCenter.LeftButton.Checked = True
                                If dtp = "None" Then CustomizationCenter.NoneButton.Checked = True
                                If dtp = "Right" Then CustomizationCenter.RightButton.Checked = True
                                If dtp = "BottomLeft" Then CustomizationCenter.BottomLeftButton.Checked = True
                                If dtp = "Bottom" Then CustomizationCenter.BottomButton.Checked = True
                                If dtp = "BottomRight" Then CustomizationCenter.BottomRightButton.Checked = True
skippast:
                                Try
                                    Login.ListBox1.SelectedIndex = 16
                                Catch
                                    GoTo skipppast
                                End Try
                                If Login.ListBox1.SelectedItem = "True" Then Desktop.Label2.Visible = True
                                If Login.ListBox1.SelectedItem = "False" Then Desktop.Label2.Visible = False
                                Try
                                    Login.ListBox1.SelectedIndex = 17
                                Catch
                                    GoTo skipppast
                                End Try
                                If Login.ListBox1.SelectedItem = "True" Then Desktop.Label1.Visible = True
                                If Login.ListBox1.SelectedItem = "False" Then Desktop.Label1.Visible = False
                                Try
                                    Login.ListBox1.SelectedIndex = 18
                                Catch ex As Exception
                                    GoTo skipppast
                                End Try
                                Desktop.CPU_Tracker.Interval = Login.ListBox1.SelectedItem
skipppast:
                                Try
                                    Login.ListBox1.SelectedIndex = 19
                                    Desktop.PictureBox6.Left = Login.ListBox1.SelectedItem
                                    Login.ListBox1.SelectedIndex = 20
                                    Desktop.PictureBox6.Top = Login.ListBox1.SelectedItem
                                    Login.ListBox1.SelectedIndex = 21
                                    Desktop.PictureBox7.Left = Login.ListBox1.SelectedItem
                                    Login.ListBox1.SelectedIndex = 22
                                    Desktop.PictureBox7.Top = Login.ListBox1.SelectedItem
                                    Login.ListBox1.SelectedIndex = 23
                                    Desktop.PictureBox8.Left = Login.ListBox1.SelectedItem
                                    Login.ListBox1.SelectedIndex = 24
                                    Desktop.PictureBox8.Top = Login.ListBox1.SelectedItem
                                    Login.ListBox1.SelectedIndex = 25
                                    Desktop.PictureBox9.Left = Login.ListBox1.SelectedItem
                                    Login.ListBox1.SelectedIndex = 26
                                    Desktop.PictureBox9.Top = Login.ListBox1.SelectedItem
                                    Login.ListBox1.SelectedIndex = 27
                                    Desktop.PictureBox10.Left = Login.ListBox1.SelectedItem
                                    Login.ListBox1.SelectedIndex = 28
                                    Desktop.PictureBox10.Top = Login.ListBox1.SelectedItem
                                Catch
                                    GoTo aisgh
                                End Try
aisgh:
                                Try
                                    Login.ListBox1.SelectedIndex = 29
                                    If Login.ListBox1.SelectedItem.ToString() = "True" Then Desktop.ShowhideIconsToolStripMenuItem.Checked = True
                                    Try
                                        Login.ListBox1.SelectedIndex = 30
                                        Dim et As String
                                        et = Login.ListBox1.SelectedItem
                                        If et = "True" Then Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True
                                        If et = "False" Then Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False
                                    Catch ex As Exception
                                        Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False
                                        GoTo isgh
                                    End Try
                                    Try
                                        Login.ListBox1.SelectedIndex = 31
                                    Catch ex As Exception
                                        GoTo isgh
                                    End Try
                                    If Login.ListBox1.SelectedItem = "True" Then Desktop.Label3.Visible = True
                                    If Login.ListBox1.SelectedItem = "True" Then Desktop.Label4.Visible = True
                                    If Login.ListBox1.SelectedItem = "False" Then Desktop.Label3.Visible = False
                                    If Login.ListBox1.SelectedItem = "False" Then Desktop.Label4.Visible = False
                                Catch
                                    GoTo isgh
                                End Try
isgh:
                                Desktop.WindowState = FormWindowState.Maximized
                                Desktop.user = LoginPrompt.NameField.Text
                                Desktop.passwd = inputpass
                                LoginPrompt.NameField.Text = "DefaultUser"
                                LoginPrompt.PassField.Text = ""
                                If LoginPrompt.CheckBox1.Checked = True Then
                                    My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\login.txt", LoginPrompt.NameField.Text & ";" & LoginPrompt.PassField.Text, False)
                                End If
                                LoginPrompt.Label1.Text = "Login screen"
                                Cursor.Show()
                                If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Programs") Then
                                    My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Programs")
                                End If
                                Try
                                    Login.ListBox1.SelectedIndex += 1
                                    If Login.ListBox1.SelectedItem.ToString() = "True" Then
                                        Desktop.docked = True
                                    End If
                                    Login.ListBox1.SelectedIndex += 1
                                    If Login.ListBox1.SelectedItem.ToString() = "True" Then
                                        Desktop.inverse = True
                                    End If
                                Catch
                                End Try
                                'My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
                                If es = True Then My.Computer.Audio.Play(My.Resources.startup9, AudioPlayMode.Background)
                                Desktop.Show()
                                Timer1.Enabled = False
                                Hide()
                            End If
                        End If
                        Timer1.Enabled = False
                        Hide()
                        Exit Sub
                    End If
                    'My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
                    If es = True Then My.Computer.Audio.Play(My.Resources.startup9, AudioPlayMode.Background)
                    Login.Show()
                    Timer1.Enabled = False
                    Hide()
                    Exit Sub
                ElseIf StartupWindow.ProgressBar1.Value = 40 Then
                    Cursor.Show()
                    Login.logoff = False
                    StartupWindow.ProgressBar1.Value = StartupWindow.ProgressBar1.Value + 2
                    Exit Sub
                ElseIf StartupWindow.ProgressBar1.Value = 25 Then
                    StartupWindow.LogoffWindow.Text = "Welcome!"
                    StartupWindow.ProgressBar1.Value = StartupWindow.ProgressBar1.Value + 2
                    Exit Sub
                ElseIf StartupWindow.ProgressBar1.Value = 10 Then
                    StartupWindow.ProgressBar1.Value = StartupWindow.ProgressBar1.Value + 2
                    If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\config.rtf") Then
tryrtr:
                        Desktop.RichTextBox1.LoadFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\config.rtf", RichTextBoxStreamType.RichText)
                        If Desktop.RichTextBox1.Text = "" Then
                            ESOD.Label5.Text = "No wallpaper file found"
                            ESOD.ShowDialog()
                        End If
                        If Desktop.RichTextBox1.Text = "Local_1" Then
                            Desktop.PictureBox1.Image = My.Resources.f16929280
                            GoTo resumee
                        End If
                        If Desktop.RichTextBox1.Text = "Local_2" Then

                            Desktop.PictureBox1.Image = My.Resources.f22272576
                            GoTo resumee
                        End If
                        If Desktop.RichTextBox1.Text = "Local_3" Then
                            If My.Computer.Screen.Bounds.Width / My.Computer.Screen.Bounds.Height = 5 / 4 Then
                                Desktop.PictureBox1.Image = My.Resources.startup1
                            ElseIf My.Computer.Screen.Bounds.Width / My.Computer.Screen.Bounds.Height = 4 / 3 Then
                                Desktop.PictureBox1.Image = My.Resources.startup1
                            ElseIf My.Computer.Screen.Bounds.Width / My.Computer.Screen.Bounds.Height = 16 / 9 Then
                                Desktop.PictureBox1.Image = My.Resources.startup3
                            ElseIf My.Computer.Screen.Bounds.Width / My.Computer.Screen.Bounds.Height = 16 / 10 Then
                                Desktop.PictureBox1.Image = My.Resources.startup4
                            Else
                                Desktop.PictureBox1.Image = My.Resources.startup1
                            End If
                            GoTo resumee
                        End If
                        Desktop.OpenFileDialog1.FileName = Desktop.RichTextBox1.Text
                        Desktop.PictureBox1.Load(Desktop.OpenFileDialog1.FileName)
resumee:
                        Desktop.BackgroundImage = Desktop.PictureBox1.Image()
                    Else
                        StartupWindow.LogoffWindow.Text = "Welcome!"
                    End If
                    StartupWindow.ProgressBar1.Value = StartupWindow.ProgressBar1.Value + 2
                    Exit Sub
                ElseIf StartupWindow.ProgressBar1.Value = 4 Then
                    If Not My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\locations.txt") Then
                        Desktop.PictureBox1.Anchor = AnchorStyles.Bottom And AnchorStyles.Left
                        GoTo skipit
                    End If
                    Dim gimn As String
                    gimn = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\locations.txt")
                    TextBox1.Text = gimn
                    ListBox1.Items.Clear()
                    ListBox1.Items.AddRange(TextBox1.Text.Split(";"))
                    ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
                    Dim x As String
                    Dim y As String
                    x = ListBox1.SelectedItem.ToString
                    ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
                    y = ListBox1.SelectedItem.ToString
                    Desktop.PictureBox2.Top = y
                    Desktop.PictureBox2.Left = x
                    ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
                    x = ListBox1.SelectedItem.ToString
                    ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
                    y = ListBox1.SelectedItem.ToString
                    Desktop.PictureBox3.Top = y
                    Desktop.PictureBox3.Left = x
                    ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
                    x = ListBox1.SelectedItem.ToString
                    ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
                    y = ListBox1.SelectedItem.ToString
                    Desktop.PictureBox4.Top = y
                    Desktop.PictureBox4.Left = x
                    ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
                    x = ListBox1.SelectedItem.ToString
                    ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
                    y = ListBox1.SelectedItem.ToString
                    Desktop.PictureBox5.Top = y
                    Desktop.PictureBox5.Left = x
skipit:
                    StartupWindow.ProgressBar1.Value = StartupWindow.ProgressBar1.Value + 2
                Else
                    If StartupWindow.ProgressBar1.Value < 15 Then StartupWindow.ProgressBar1.Value = StartupWindow.ProgressBar1.Value + 1
                    If StartupWindow.ProgressBar1.Value < 15 Then Exit Sub
                    If StartupWindow.ProgressBar1.Value < 25 Then StartupWindow.ProgressBar1.Value = StartupWindow.ProgressBar1.Value + 2
                    If StartupWindow.ProgressBar1.Value < 25 Then Exit Sub
                    If StartupWindow.ProgressBar1.Value > 45 Then StartupWindow.ProgressBar1.Value = StartupWindow.ProgressBar1.Value + 2
                    If StartupWindow.ProgressBar1.Value > 45 Then Exit Sub
                    If StartupWindow.ProgressBar1.Value > 55 Then StartupWindow.ProgressBar1.Value = StartupWindow.ProgressBar1.Value + 1
                    If StartupWindow.ProgressBar1.Value > 55 Then Exit Sub
                    StartupWindow.ProgressBar1.Value = StartupWindow.ProgressBar1.Value + 3
                    Exit Sub
                End If
        Catch ex As Exception
            ESOD.Label5.Text = ex.Message
            ESOD.ShowDialog()
            Timer1.Enabled = True
        End Try
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Delete Then
            Timer1.Enabled = False
            Recovery.ShowDialog()
            Timer1.Enabled = True
        ElseIf e.KeyCode = Keys.W Then
            Process.Start(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed")
            Me.Close()
        End If
    End Sub

    Private Sub Devtimer_Tick(sender As System.Object, e As System.EventArgs) Handles devtimer.Tick
        If Desktop.dev = True Then
            'dev.Location = New Point(dev.Location.X - 2, dev.Location.Y)
            'If dev.Location.X = -88 Then
            'dev.Location = New Point(Me.Width, dev.Location.Y)
            'End If
            'Desktop.devd.Location = dev.Location
            'Login.dev.Location = dev.Location
            devtimer.Enabled = False
        ElseIf Desktop.dev = False Then
            devtimer.Enabled = False
        End If
    End Sub

    Public Sub Forcefadein_animation(ByVal formname As Form, ByVal secondname As Form)
        fn = formname
        sn = secondname
        ForceFadeInTimer.Enabled = True
    End Sub
    Public Sub Fadein_animation(ByVal formname As Form, ByVal secondname As Form)
        fn = formname
        sn = secondname
        FadeInTimer.Enabled = True
    End Sub

    Public Sub Fadeout_animation(ByVal formname As Form, ByVal secondname As Form)
        fn = formname
        sn = secondname
        FadeOutTimer.Enabled = True
    End Sub
    Public Sub Forcefadeout_animation(ByVal formname As Form, ByVal secondname As Form)
        cfn = formname
        csn = secondname
        ForceFadeOutTimer.Enabled = True
    End Sub
    Public Sub Hideanimation(ByVal formname As Form, ByVal secondname As Form)
        formname.Hide()
        secondname.Hide()
    End Sub

    Public Sub ThemeFix(ByVal frm As Form, ByVal obj As Label, Optional composed As Form = Nothing)
        With frm
            .BackColor = Desktop.appBg.BackColor
            .ForeColor = Desktop.appFg.BackColor
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
                .TransparencyKey = Desktop.appBg.BackColor
                Try
                    composed.BackColor = Desktop.appBg.BackColor
                Catch
                End Try
            End If
        End With
        With obj
            .BackColor = Desktop.labelBg.BackColor
            .ForeColor = Desktop.labelBg.BackColor
        End With
        Fadein_animation(frm, composed)
    End Sub
    Public Sub Translucency(ByVal formname As Form, ByVal secondname As Form, ByVal open As Boolean)
        If open Then formname.BackColor = Desktop.appBg.BackColor
        For Each element As Control In formname.Controls
            If TypeOf element Is Button Then
                Dim r As Integer = element.BackColor.R + 5
                Dim g As Integer = element.BackColor.G + 5
                Dim b As Integer = element.BackColor.B + 5
                If r > 255 Then r = r - 10
                If g > 255 Then g = g - 10
                If b > 255 Then b = b - 10
                element.BackColor = Color.FromArgb(r, g, b)
            ElseIf TypeOf element Is GroupBox Then
                For Each el As Control In element.Controls
                    If TypeOf el Is Button Then
                        If Not el.Name = "WindowButton" Then
                            Dim r As Integer = el.BackColor.R + 5
                            Dim g As Integer = el.BackColor.G + 5
                            Dim b As Integer = el.BackColor.B + 5
                            If r > 255 Then r = r - 10
                            If g > 255 Then g = g - 10
                            If b > 255 Then b = b - 10
                            el.BackColor = Color.FromArgb(r, g, b)
                        End If
                    End If
                Next
            ElseIf TypeOf element Is Panel Then
                For Each el As Control In element.Controls
                    If TypeOf el Is Button Then
                        Dim r As Integer = el.BackColor.R + 5
                        Dim g As Integer = el.BackColor.G + 5
                        Dim b As Integer = el.BackColor.B + 5
                        If r > 255 Then r = r - 10
                        If g > 255 Then g = g - 10
                        If b > 255 Then b = b - 10
                        el.BackColor = Color.FromArgb(r, g, b)
                    End If
                Next
            End If
        Next
        formname.TransparencyKey = formname.BackColor
        secondname.AllowTransparency = True
        If open Then secondname.Opacity = 0.0
        secondname.Size = formname.Size
        secondname.TopMost = True
        secondname.BackColor = formname.BackColor
        secondname.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        secondname.ShowInTaskbar = False
        secondname.ShowIcon = False
        Try
            If formname.Modal = False Then
                secondname.Show()
            ElseIf formname.Modal = True Then
                For Each element As Form In My.Application.OpenForms
                    If element.Modal = False Then
                        element.TopMost = False
                    End If
                Next
                secondname.Show()
            End If
        Catch
        End Try
        secondname.Size = formname.Size
        secondname.Location = formname.Location
        Fadein_animation(formname, secondname)
        secondname.TopMost = True
        formname.TopMost = True
        secondname.BringToFront()
        formname.BringToFront()

    End Sub
    Public Sub Utranslucency(ByVal formname As Form, ByVal secondname As Form)
        formname.BackColor = Desktop.appBg.BackColor
        formname.TransparencyKey = Desktop.appBg.BackColor
        secondname.AllowTransparency = True
        secondname.Opacity = 0.0
        secondname.Size = formname.Size
        secondname.TopMost = True
        secondname.BackColor = Desktop.appBg.BackColor
        secondname.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        secondname.ShowInTaskbar = False
        secondname.ShowIcon = False
        Try
            secondname.Show()
        Catch
        End Try
        secondname.Size = formname.Size
        secondname.Location = formname.Location
        Forcefadein_animation(formname, secondname)
    End Sub
    Private Sub FadeInTimer_Tick(sender As System.Object, e As System.EventArgs) Handles FadeInTimer.Tick
        Try
            If fn.Opacity = 1.0 Then
                sn.TopMost = True
                fn.TopMost = True
                sn.BringToFront()
                fn.BringToFront()
                FadeInTimer.Enabled = False
                dotick = True
                Exit Sub
            Else
                If FadeOutTimer.Enabled = True Then FadeOutTimer.Enabled = False
                'fn.Location = New Point(fn.Location.X, fn.Location.Y - 1)
                'sn.Location = New Point(sn.Location.X, sn.Location.Y - 1)
                fn.Opacity = fn.Opacity + 0.125
                sn.Opacity = sn.Opacity + 0.1125
            End If
        Catch
        End Try
    End Sub

    Public Function MsgDialog(ByVal messagetext As String, Optional messagetitle As String = "", Optional messageicon As String = "None", Optional messagetype As String = "OKOnly")
        Dim dlgresult As DialogResult
        With MessageDialog
            .messagetext = messagetext
            .messagetitle = messagetitle
            .messageicon = messageicon
            .messagetype = messagetype
        End With
        dlgresult = MessageDialog.ShowDialog()
        Return dlgresult
    End Function

    Public Function InputDialog(ByVal messagetext As String, Optional messagetitle As String = "", Optional passwd As Boolean = False, Optional placeholdertext As String = "")
        With InputBoxDialog
            .txt = messagetext
            .finalinput = placeholdertext
            .password = passwd
            .wintitle = messagetitle
        End With
        InputBoxDialog.ShowDialog()
        Return InputBoxDialog.finalinput
    End Function

    Private Sub FadeOutTimer_Tick(sender As System.Object, e As System.EventArgs) Handles FadeOutTimer.Tick
        Try
            If fn.Opacity = 0.0 Then
                If fn.Modal = False Then
                    sn.Close()
                    fn.Close()
                ElseIf fn.Modal = True Then
                    For Each element As Form In My.Application.OpenForms
                        If Not element.Name = "Desktop" Then
                            element.TopMost = True
                        End If
                    Next
                    fn.DialogResult = dr
                    sn.Hide()
                End If
                FadeOutTimer.Enabled = False
                Exit Sub
            Else
                If FadeInTimer.Enabled = True Then FadeInTimer.Enabled = False
                'fn.Location = New Point(fn.Location.X, fn.Location.Y + 1)
                'sn.Location = New Point(sn.Location.X, sn.Location.Y + 1)
                fn.Opacity = fn.Opacity - 0.125
                sn.Opacity = sn.Opacity - 0.1125
            End If
        Catch
        End Try
    End Sub
    Private Sub Form1_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub Form1_VisibleChanged(sender As System.Object, e As System.EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible = False Then
            If elw = True Then
                StartupWindow.Close()
            End If
        End If
    End Sub

    Private Sub Form1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress

    End Sub

    Private Sub ForceFadeInTimer_Tick(sender As System.Object, e As System.EventArgs) Handles ForceFadeInTimer.Tick
        If fn.Opacity = 1.0 Then
            ForceFadeInTimer.Enabled = False
            Exit Sub
        Else
            fn.Location = New Point(fn.Location.X, fn.Location.Y - 1)
            sn.Location = New Point(sn.Location.X, sn.Location.Y - 1)
            fn.Opacity = fn.Opacity + 0.125
            sn.Opacity = sn.Opacity + 0.1125
        End If
    End Sub

    Private Sub ForceFadeOutTimer_Tick(sender As System.Object, e As System.EventArgs) Handles ForceFadeOutTimer.Tick
        If cfn.Opacity = 0.0 Then
            csn.Close()
            cfn.Close()
            ForceFadeOutTimer.Enabled = False
            Exit Sub
        Else
            cfn.Location = New Point(cfn.Location.X, cfn.Location.Y + 1)
            csn.Location = New Point(csn.Location.X, csn.Location.Y + 1)
            cfn.Opacity = cfn.Opacity - 0.125
            csn.Opacity = csn.Opacity - 0.1125
        End If
    End Sub

    Private Sub Tt_Tick(sender As System.Object, e As System.EventArgs) Handles tt.Tick
        tt.Enabled = False
        v_splash.abc()
    End Sub

    Public Sub Setfont(ByVal formal As Form, ByVal titlebar As Label, Optional secbar As Label = Nothing)
        formal.Font = Desktop.appFg.Font
        For Each ctrl As Control In formal.Controls
            ctrl.Font = New Font(Desktop.appFg.Font.FontFamily, ctrl.Font.Size, Desktop.appFg.Font.Style)
            If ctrl.Name = titlebar.Name Then
                ctrl.Font = Desktop.labelFg.Font
            End If
            If secbar IsNot Nothing Then
                If ctrl.Name = secbar.Name Then
                    ctrl.Font = Desktop.labelFg.Font
                End If
            End If
        Next
    End Sub
End Class
