Public Class LoginPrompt
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Public composedwindow As Form = New Form()
    Public Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr
    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub LoginButton_Click(sender As System.Object, e As System.EventArgs) Handles LoginButton.Click
        Try
            Desktop.labelBg.BackColor = Form1.labelBg.BackColor
            Desktop.labelFg.BackColor = Form1.labelFg.BackColor
            Desktop.appBg.BackColor = Form1.appBg.BackColor
            Desktop.appFg.BackColor = Form1.appFg.BackColor
            Label1.Text = "Login screen"
            If Not My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & NameField.Text & ".txt") Then
                If NewLogin.Visible = True Then Me.Hide()
                If NewLogin.Visible = True Then composedwindow.Hide()
                MessageDialog.messagetitle = "Login operation failed"
                MessageDialog.messagetext = "Invalid username"
                MessageDialog.messageicon = "Critical"
                'MessageDialog.ff = Me
                'MessageDialog.sf = composedwindow
                MessageDialog.ShowDialog()
                Label1.Text = "Login screen"
                Exit Sub
            Else
                Dim inputpass As String
                inputpass = Login.Encrypt(PassField.Text, PassField.Text)
                Dim gimn As String
                gimn = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & NameField.Text & ".txt")
                Login.ListBox1.Items.Clear()
                Login.ListBox1.Items.AddRange(gimn.Split(";"))
                Login.ListBox1.SelectedIndex = 0
                If Not Login.ListBox1.SelectedItem = inputpass Then
                    If NewLogin.Visible = True Then Me.Hide()
                    If NewLogin.Visible = True Then composedwindow.Hide()
                    MessageDialog.messagetitle = "Login operation failed"
                    MessageDialog.messagetext = "Invalid password"
                    MessageDialog.messageicon = "Critical"
                    'MessageDialog.ff = Me
                    'MessageDialog.sf = composedwindow
                    MessageDialog.ShowDialog()
                    Label1.Text = "Login screen"
                    Exit Sub
                End If
                Desktop.usertype = ""
                If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & NameField.Text & "_admin.txt") Then Desktop.usertype = "Admin"
                If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & NameField.Text & "_power.txt") Then Desktop.usertype = "Power"
                If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & NameField.Text & "_standard.txt") Then Desktop.usertype = "Standard"
                If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & NameField.Text & "_limited.txt") Then Desktop.usertype = "Limited"
                If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & NameField.Text & "_guest.txt") Then Desktop.usertype = "Guest"
                If Desktop.usertype = "" Then
                    MessageDialog.messagetitle = "Login operation failed"
                    MessageDialog.messagetext = "Invalid or unknown user type"
                    MessageDialog.messageicon = "Critical"
                    MessageDialog.ShowDialog()
                    Label1.Text = "Login screen"
                    Exit Sub
                End If
                If Desktop.usertype = "Guest" Then
                    Desktop.user = NameField.Text
                    Desktop.passwd = inputpass
                    If CheckBox1.Checked = True Then
                        My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\login.txt", NameField.Text & ";" & PassField.Text, False)
                    End If
                    NameField.Text = "DefaultUser"
                    PassField.Text = ""
                    Desktop.Show()
                    Try
                        If Not Form1.bi = "Local_1" Then
                            Desktop.BackgroundImage = Image.FromFile(Form1.bi)
                        End If
                    Catch
                    End Try
                    'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
                    If Form1.edc = False Then Close()
                    Close()
                    If Form1.edc = True Then composedwindow.Close()
                    Login.Close()
                End If
                If Desktop.usertype = "Limited" Then
                    Try
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
                        Desktop.user = NameField.Text
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
                        If CheckBox1.Checked = True Then
                            My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\login.txt", NameField.Text & ";" & PassField.Text, False)
                        End If
                        NameField.Text = "DefaultUser"
                        PassField.Text = ""
                        Try
                            If Not Form1.bi = "Local_1" Then
                                Desktop.BackgroundImage = Image.FromFile(Form1.bi)
                            End If
                        Catch
                        End Try
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
                    Desktop.Show()
                    'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
                    If Form1.edc = False Then Close()
                    Close()
                    If Form1.edc = True Then composedwindow.Close()
                    Login.Close()
                End If
                If Desktop.usertype = "Admin" Or Desktop.usertype = "Standard" Or Desktop.usertype = "Power" Then
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
                    Try
                        Login.ListBox1.SelectedIndex = 10
                    Catch
                        Desktop.labelBg.BackColor = Form1.labelBg.BackColor
                        Desktop.labelFg.BackColor = Form1.labelFg.BackColor
                        Desktop.appBg.BackColor = Form1.appBg.BackColor
                        Desktop.appFg.BackColor = Form1.appFg.BackColor
                        GoTo color5
                    End Try
                    If Login.ListBox1.SelectedItem = "" Then
                        Desktop.labelBg.BackColor = Color.DimGray
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
                    Try
                        Login.ListBox1.SelectedIndex = 11
                    Catch
                        Desktop.labelBg.BackColor = Form1.labelBg.BackColor
                        Desktop.labelFg.BackColor = Form1.labelFg.BackColor
                        Desktop.appBg.BackColor = Form1.appBg.BackColor
                        Desktop.appFg.BackColor = Form1.appFg.BackColor
                        GoTo color5
                    End Try
                    If Login.ListBox1.SelectedItem = "" Then
                        Desktop.labelFg.BackColor = Color.White
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
                    Try
                        Login.ListBox1.SelectedIndex = 12
                    Catch
                        Desktop.labelBg.BackColor = Form1.labelBg.BackColor
                        Desktop.labelFg.BackColor = Form1.labelFg.BackColor
                        Desktop.appBg.BackColor = Form1.appBg.BackColor
                        Desktop.appFg.BackColor = Form1.appFg.BackColor
                        GoTo color5
                    End Try
                    If Login.ListBox1.SelectedItem = "" Then
                        Desktop.appBg.BackColor = Color.WhiteSmoke
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
                    Try
                        Login.ListBox1.SelectedIndex = 13
                    Catch
                        Desktop.labelBg.BackColor = Form1.labelBg.BackColor
                        Desktop.labelFg.BackColor = Form1.labelFg.BackColor
                        Desktop.appBg.BackColor = Form1.appBg.BackColor
                        Desktop.appFg.BackColor = Form1.appFg.BackColor
                        GoTo color5
                    End Try
                    If Login.ListBox1.SelectedItem = "" Then
                        Desktop.appFg.BackColor = Color.Black
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
                    Dim dtp As String = Login.ListBox1.SelectedItem.ToString()
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
                    Desktop.WindowState = FormWindowState.Maximized
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
                    Desktop.user = NameField.Text
                    Desktop.passwd = inputpass
                    If CheckBox1.Checked = True Then
                        My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\login.txt", NameField.Text & ";" & PassField.Text, False)
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
                    NameField.Text = "DefaultUser"
                    PassField.Text = ""
                    Desktop.Show()
                    'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_process, AudioPlayMode.Background)
                    If Form1.edc = True Then composedwindow.Close()
                    Login.Close()
                End If
            End If
        Catch ex As Exception
            ESOD.Label5.Text = "Failed to login in: User account may be corrupted!" & vbNewLine & "Error details: " & ex.Message
            Login.Timer1.Enabled = False
            Login.Timer2.Enabled = False
            Login.Timer3.Enabled = False
            Me.Hide()
            ESOD.ShowDialog()
        End Try

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Label1.Text = "Restarting..."
        Login.Timer1.Enabled = False
        Login.Label7.Visible = False
        NameField.Visible = False
        PassField.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        CheckBox1.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        LoginButton.Visible = False
        Login.Timer3.Enabled = False
        ShutDown.restart = True
        Login.Timer2.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Label1.Text = "Shutting down..."
        Login.Timer1.Enabled = False
        Login.Label7.Visible = False
        NameField.Visible = False
        PassField.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        CheckBox1.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        LoginButton.Visible = False
        Login.Timer3.Enabled = False
        Login.Timer2.Enabled = True
    End Sub

    Private Sub PassField_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles PassField.KeyPress
        If e.KeyChar = Chr(13) Then
            LoginButton.PerformClick()
        End If
    End Sub

    Private Sub NameField_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles NameField.KeyPress
        If e.KeyChar = Chr(13) Then
            PassField.Select()
        End If
    End Sub

    Private Sub Label6_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Label6.MouseDown
        drag = True
        mousex = Cursor.Position.X - Left
        mousey = Cursor.Position.Y - Top

    End Sub

    Private Sub Label6_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Label6.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
            composedwindow.Top = Top
            composedwindow.Left = Left
        End If
    End Sub

    Private Sub Label6_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Label6.MouseUp
        drag = False
    End Sub


    Private Sub LoginPrompt_VisibleChanged(sender As Object, e As System.EventArgs) Handles Me.VisibleChanged
        Try
            If Me.Visible = True Then
                Label1.BackColor = Form1.appBg.BackColor
                Label1.ForeColor = Form1.appFg.BackColor
                Label2.BackColor = Form1.appBg.BackColor
                Label2.ForeColor = Form1.appFg.BackColor
                Label3.BackColor = Form1.appBg.BackColor
                Label3.ForeColor = Form1.appFg.BackColor
                CheckBox1.BackColor = Form1.appBg.BackColor
                CheckBox1.ForeColor = Form1.appFg.BackColor
                Button1.BackColor = Form1.appBg.BackColor
                Button1.ForeColor = Form1.appFg.BackColor
                Button2.BackColor = Form1.appBg.BackColor
                Button2.ForeColor = Form1.appFg.BackColor
                Button3.BackColor = Form1.appBg.BackColor
                Button3.ForeColor = Form1.appFg.BackColor
                LoginButton.BackColor = Form1.appBg.BackColor
                LoginButton.ForeColor = Form1.appFg.BackColor
                Label6.BackColor = Form1.labelBg.BackColor
                Label6.ForeColor = Form1.labelFg.BackColor
                composedwindow.BackColor = Form1.appBg.BackColor
                If Form1.edc = False Then Me.BackColor = Form1.appBg.BackColor
                If Form1.edc = False Then Me.TransparencyKey = Nothing
                If Form1.edc = True Then composedwindow.TopMost = True
                If Form1.edc = True Then composedwindow.BringToFront()
                If Form1.edc = True Then Me.BringToFront()
                Desktop.appBg.BackColor = Form1.appBg.BackColor
                If Form1.edc = True Then Form1.translucency(Me, composedwindow, True)
                Me.ForeColor = Form1.appFg.BackColor
            End If
        Catch ex As Exception
            ESOD.Label5.Text = "Unable to apply theme: Theme may be corrupted" & vbNewLine & ex.Message
        End Try
    End Sub

    Private Sub LoginPrompt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Form1.edc = False Then Me.Opacity = 1.0
        If Form1.esb = False Then Button3.Visible = False
        If Form1.esb = True Then Button3.Visible = True
        If Form1.esr = False Then Panel1.Visible = False
        If Form1.esr = True Then Panel1.Visible = True
        If Form1.eab = False Then CheckBox1.Visible = False
        If Form1.eab = True Then CheckBox1.Visible = True
    End Sub

    Private Sub LoginPrompt_Deactivate(sender As System.Object, e As System.EventArgs) Handles MyBase.Deactivate
        If Form1.edc = True Then
            If composedwindow.IsDisposed = False Then
                If Not GetActiveWindow <> composedwindow.Handle Then
                    Me.BringToFront()
                End If
            End If
        End If
    End Sub

    Private Sub LoginPrompt_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Fadeout_animation(Me, composedwindow)
        If NewLogin.Visible = True Then
            If NewLogin.composedwindow.Visible = True Then NewLogin.composedwindow.Close()
            NewLogin.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Login.legacy = False
        If composedwindow.Visible = True Then composedwindow.Close()
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub
End Class