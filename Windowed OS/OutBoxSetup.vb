Imports System.IO
Public Class OutBoxSetup
    Dim cust As Boolean = False
    Dim user1_img As String = "Local_3"
    Dim user2_img As String = "Local_3"
    Dim user3_img As String = "Local_3"
    Dim user1_enable As Boolean = True
    Dim user2_enable As Boolean = False
    Dim user3_enable As Boolean = False
    Dim user1_scheme As Integer = 0
    Dim user2_scheme As Integer = 0
    Dim user3_scheme As Integer = 0
    Dim currentconfiguration As Integer = 1
    Dim restartvalue As Integer = 11
    Dim user1_theme As Color() = {Color.WhiteSmoke, Color.Black, Color.DimGray, Color.White}
    Dim user2_theme As Color() = {Color.WhiteSmoke, Color.Black, Color.DimGray, Color.White}
    Dim user3_theme As Color() = {Color.WhiteSmoke, Color.Black, Color.DimGray, Color.White}
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Section1_1.Visible Then
            Section1_1.Visible = False
            Section1_2.Visible = True
            UpdateBox.SelectedIndex = 0
            ProgressBar1.Value = 33
            Button4.Visible = True
            Exit Sub
        ElseIf Section1_2.Visible Then
            Section1_2.Visible = False
            Section1_3.Visible = True
            ProgressBar1.Value = 66
            Exit Sub
        ElseIf Section1_3.Visible Then
            Panel1.Visible = False
            Section1_3.Visible = False
            ProgressBar1.Value = 100
            ProgressBar1.Enabled = False
            Label3.ForeColor = Color.LightGray
            Label4.ForeColor = Color.LightGray
            Label5.ForeColor = Color.White
            Label6.ForeColor = Color.White
            ProgressBar2.Enabled = True
            Panel2.Visible = True
            User1_Type.SelectedIndex = 0
            Exit Sub
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Section1_2.Visible Then
            Section1_1.Visible = True
            Section1_2.Visible = False
            Button4.Visible = False
            ProgressBar1.Value = 0
            Exit Sub
        ElseIf Section1_3.Visible Then
            Section1_3.Visible = False
            Section1_2.Visible = True
            ProgressBar1.Value = 33
            Exit Sub
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        HideStuff()
        Label1.Text = "Shutting down..."
        Button2.Enabled = False
        Button1.Enabled = False
        ShutDown.restart = False
        ShutDown.Show()
    End Sub

    Sub HideStuff()
        Panel1.Visible = False
        Panel2.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        HideStuff()
        Label1.Text = "Restarting..."
        Button2.Enabled = False
        Button1.Enabled = False
        ShutDown.restart = True
        ShutDown.Show()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        user2_enable = CheckBox2.Checked
        If CheckBox2.Checked Then
            User2_Name.Enabled = True
            User2_Password.Enabled = True
            User2_Type.Enabled = True
            User2_Type.SelectedIndex = 1
        ElseIf Not CheckBox2.Checked Then
            User2_Name.Enabled = False
            User2_Password.Enabled = False
            User2_Type.Enabled = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        user3_enable = CheckBox3.Checked
        If CheckBox3.Checked Then
            User3_Name.Enabled = True
            User3_Password.Enabled = True
            User3_Type.Enabled = True
            User3_Type.SelectedIndex = 1
        ElseIf Not CheckBox3.Checked Then
            User3_Name.Enabled = False
            User3_Password.Enabled = False
            User3_Type.Enabled = False
        End If
    End Sub

    Private Sub LoadWindow_CheckedChanged(sender As Object, e As EventArgs) Handles LoadWindow.CheckedChanged
        Form1.elw = LoadWindow.Checked
    End Sub

    Private Sub SystemBoot_CheckedChanged(sender As Object, e As EventArgs) Handles SystemBoot.CheckedChanged
        Form1.ebs = SystemBoot.Checked
    End Sub

    Private Sub UpdateBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UpdateBox.SelectedIndexChanged
        If UpdateBox.SelectedIndex = 0 Then
            Form1.check = "Check"
        ElseIf UpdateBox.SelectedIndex = 1 Then
            Form1.check = "Download"
        ElseIf UpdateBox.SelectedIndex = 2 Then
            Form1.check = "Manual"
        End If
    End Sub

    Private Sub CustomApps_CheckedChanged(sender As Object, e As EventArgs) Handles CustomApps.CheckedChanged
        cust = CustomApps.Checked
    End Sub

    Private Sub TimeDateLogin_CheckedChanged(sender As Object, e As EventArgs) Handles TimeDateLogin.CheckedChanged
        Form1.dtl = TimeDateLogin.Checked
    End Sub

    Private Sub NewLoginTypeBox_CheckedChanged(sender As Object, e As EventArgs) Handles NewLoginTypeBox.CheckedChanged
        Form1.eul = NewLoginTypeBox.Checked
    End Sub

    Private Sub SwitchBox_CheckedChanged(sender As Object, e As EventArgs) Handles SwitchBox.CheckedChanged
        Form1.esb = SwitchBox.Checked
    End Sub

    Private Sub ShutdownBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShutdownBox.CheckedChanged
        Form1.esr = ShutdownBox.Checked
    End Sub

    Private Sub BgLoginBox_CheckedChanged(sender As Object, e As EventArgs) Handles BgLoginBox.CheckedChanged
        Form1.ubm = BgLoginBox.Checked
    End Sub

    Private Sub AutologinBox_CheckedChanged(sender As Object, e As EventArgs) Handles AutologinBox.CheckedChanged
        Form1.eab = AutologinBox.Checked
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Section2_1.Visible Then
            Panel1.Visible = True
            Section1_3.Visible = True
            ProgressBar1.Value = 66
            ProgressBar1.Enabled = True
            Label3.ForeColor = Color.White
            Label4.ForeColor = Color.White
            Label5.ForeColor = Color.LightGray
            Label6.ForeColor = Color.LightGray
            ProgressBar2.Enabled = False
            Panel2.Visible = False
            User1_Type.SelectedIndex = 0
            Exit Sub
        ElseIf Section2_2.Visible Then
            Section2_2.Visible = False
            Section2_1.Visible = True
            ProgressBar2.Increment(-25)
        ElseIf Section2_3.Visible Then
            Section2_3.Visible = False
            Section2_2.Visible = True
            ProgressBar2.Increment(-25)
        ElseIf Section2_4.Visible Then
            Section2_4.Visible = False
            Section2_3.Visible = True
            ProgressBar2.Increment(-25)
        End If
    End Sub

    Private Sub OutBoxSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Timer1.Enabled = False
        Me.BackgroundImage = Form1.BackgroundImage
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If User1_Type.SelectedIndex = 3 Or User1_Type.SelectedIndex = 2 Then
            Button7.Enabled = False
            Exit Sub
        End If
        currentconfiguration = 1
        ComboBox1.SelectedIndex = user1_scheme
        If user1_img = "Local_3" Then
            ComboBox2.SelectedIndex = 0
        ElseIf user1_img = "Local_1" Then
            ComboBox2.SelectedIndex = 1
        ElseIf user1_img = "Local_2" Then
            ComboBox2.SelectedIndex = 2
        Else
            ComboBox2.Text = "Custom"
            PictureBox1.BackgroundImage = Image.FromFile(user1_img)
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedIndex = 0 Then
            If currentconfiguration = 1 Then user1_img = "Local_3"
            If currentconfiguration = 2 Then user2_img = "Local_3"
            If currentconfiguration = 3 Then user3_img = "Local_3"
            PictureBox1.BackgroundImage = My.Resources.startup1
        ElseIf ComboBox2.SelectedIndex = 1 Then
            If currentconfiguration = 1 Then user1_img = "Local_2"
            If currentconfiguration = 2 Then user2_img = "Local_2"
            If currentconfiguration = 3 Then user3_img = "Local_2"
            PictureBox1.BackgroundImage = My.Resources.f22272576
        ElseIf ComboBox2.SelectedIndex = 2 Then
            If currentconfiguration = 1 Then user1_img = "Local_1"
            If currentconfiguration = 2 Then user2_img = "Local_1"
            If currentconfiguration = 3 Then user3_img = "Local_1"
            PictureBox1.BackgroundImage = My.Resources.f16929280
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
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
        If currentconfiguration = 1 Then
            user1_scheme = ComboBox1.SelectedIndex
            user1_theme = {WindowBackground.BackColor, WindowBackground.ForeColor, WindowTitle.BackColor, WindowTitle.ForeColor}
        ElseIf currentconfiguration = 2 Then
            user2_scheme = ComboBox1.SelectedIndex
            user2_theme = {WindowBackground.BackColor, WindowBackground.ForeColor, WindowTitle.BackColor, WindowTitle.ForeColor}
        ElseIf currentconfiguration = 3 Then
            user3_scheme = ComboBox1.SelectedIndex
            user3_theme = {WindowBackground.BackColor, WindowBackground.ForeColor, WindowTitle.BackColor, WindowTitle.ForeColor}
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Section2_1.Visible Then
            Section2_2.Visible = True
            Section2_1.Visible = False
            If User1_Password.Text = "admin" Then
                If User1_Name.Text = "Admin" Then
                    MessageDialog.messageicon = "Warning"
                    MessageDialog.messagetext = "The default password for the main system account is: admin" + vbNewLine + "It is recommended to change this password as soon as possible."
                    MessageDialog.messagetitle = "Default account was left untouched"
                    MessageDialog.messagetype = "OKOnly"
                    MessageDialog.ShowDialog()
                End If
            End If
            Button7.Enabled = user1_enable
            Button8.Enabled = user2_enable
            Button9.Enabled = user3_enable
            Button7.Text = User1_Name.Text
            Button8.Text = User2_Name.Text
            Button9.Text = User3_Name.Text
            ProgressBar2.Increment(25)
        ElseIf Section2_2.Visible Then
            Section2_2.Visible = False
            Section2_3.Visible = True
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("(Disabled)")
            If user1_enable = True Then ComboBox3.Items.Add(User1_Name.Text + " (" + User1_Type.Text + ")")
            If user2_enable = True Then ComboBox3.Items.Add(User2_Name.Text + " (" + User2_Type.Text + ")")
            If user3_enable = True Then ComboBox3.Items.Add(User3_Name.Text + " (" + User3_Type.Text + ")")
            ComboBox3.SelectedIndex = 0
            ProgressBar2.Increment(25)
        ElseIf Section2_3.Visible Then
            Section2_3.Visible = False
            Section2_4.Visible = True
            ProgressBar2.Increment(25)
            ListView1.Items.Clear()
            Dim lvidx As Integer = 0
            If user1_enable Then
                ListView1.Items.Add(User1_Name.Text)
                Dim passwdtest As String = "No"
                If Not User1_Password.Text = "" Then passwdtest = "Yes"
                ListView1.Items(lvidx).SubItems.Add(passwdtest)
                ListView1.Items(lvidx).SubItems.Add(User1_Type.Text)
                If ComboBox3.Text.Split("(")(0).StartsWith(User1_Name.Text) Then
                    ListView1.Items(lvidx).SubItems.Add("Yes")
                Else
                    ListView1.Items(lvidx).SubItems.Add("No")
                End If
                lvidx += 1
            End If
            If user2_enable Then
                ListView1.Items.Add(User2_Name.Text)
                Dim passwdtest As String = "No"
                If Not User2_Password.Text = "" Then passwdtest = "Yes"
                ListView1.Items(lvidx).SubItems.Add(passwdtest)
                ListView1.Items(lvidx).SubItems.Add(User2_Type.Text)
                If ComboBox3.Text.Split("(")(0).StartsWith(User2_Name.Text) Then
                    ListView1.Items(lvidx).SubItems.Add("Yes")
                Else
                    ListView1.Items(lvidx).SubItems.Add("No")
                End If
                lvidx += 1
            End If
            If user3_enable Then
                ListView1.Items.Add(User3_Name.Text)
                Dim passwdtest As String = "No"
                If Not User3_Password.Text = "" Then passwdtest = "Yes"
                ListView1.Items(lvidx).SubItems.Add(passwdtest)
                ListView1.Items(lvidx).SubItems.Add(User3_Type.Text)
                If ComboBox3.Text.Split("(")(0).StartsWith(User3_Name.Text) Then
                    ListView1.Items(lvidx).SubItems.Add("Yes")
                Else
                    ListView1.Items(lvidx).SubItems.Add("No")
                End If
            End If
        ElseIf Section2_4.Visible Then
            Section2_4.Visible = False
            Panel2.Visible = False
            ProgressBar2.Value = ProgressBar2.Maximum
            ProgressBar2.Enabled = False
            Label5.ForeColor = Color.LightGray
            Label6.ForeColor = Color.LightGray
            ProgressBar3.Enabled = True
            Label7.ForeColor = Color.White
            Label8.ForeColor = Color.White
            Button1.Enabled = False
            Button2.Enabled = False
            Panel3.Visible = True
            WaitForUpdateTimer.Enabled = True
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If User2_Type.SelectedIndex = 3 Or User2_Type.SelectedIndex = 2 Then
            Button8.Enabled = False
            Exit Sub
        End If
        currentconfiguration = 2
        ComboBox1.SelectedIndex = user2_scheme
        If user2_img = "Local_3" Then
            ComboBox2.SelectedIndex = 0
        ElseIf user2_img = "Local_1" Then
            ComboBox2.SelectedIndex = 1
        ElseIf user2_img = "Local_2" Then
            ComboBox2.SelectedIndex = 2
        Else
            ComboBox2.Text = "Custom"
            PictureBox1.BackgroundImage = Image.FromFile(user2_img)
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If User3_Type.SelectedIndex = 3 Or User3_Type.SelectedIndex = 2 Then
            Button9.Enabled = False
            Exit Sub
        End If
        currentconfiguration = 3
        ComboBox1.SelectedIndex = user3_scheme
        If user3_img = "Local_3" Then
            ComboBox2.SelectedIndex = 0
        ElseIf user3_img = "Local_1" Then
            ComboBox2.SelectedIndex = 1
        ElseIf user3_img = "Local_2" Then
            ComboBox2.SelectedIndex = 2
        Else
            ComboBox2.Text = "Custom"
            PictureBox1.BackgroundImage = Image.FromFile(user3_img)
        End If
    End Sub

    Private Sub WaitForUpdateTimer_Tick(sender As Object, e As EventArgs) Handles WaitForUpdateTimer.Tick
        If ProgressBar3.Value = 0 Then
            ProgressBar3.Value = 1
            Label33.Text = "Current task: Saving system settings"
            SetupLog.Text += vbNewLine + "Preparing to save system settings"
        ElseIf ProgressBar3.Value = 1 Then
            ProgressBar3.Value = 5
            Dim data As String
            SetupLog.Text += vbNewLine + "Configuring system theme"
            Dim glb As String = Form1.labelBg.BackColor.ToString()
            Dim glf As String = Form1.labelFg.BackColor.ToString()
            Dim gwb As String = Form1.appBg.BackColor.ToString()
            Dim gwf As String = Form1.appFg.BackColor.ToString()
            data = Form1.es & ";" & glb & ";" & glf & ";" & gwb & ";" & gwf & ";" & Form1.elw & ";" & Form1.ebs & ";" & Form1.dtl & ";" & Form1.bsi & ";" & Form1.bi & ";" & Form1.edc.ToString() & ";" & Form1.eul.ToString() & ";" & Form1.esb.ToString() & ";" & Form1.esr.ToString() & ";" & Form1.ubm.ToString() & ";" & Form1.eab.ToString() & ";" & Form1.elm.ToString() & ";" & Form1.wm & ";"
            SetupLog.Text += vbNewLine + "Saving system configuration"
            My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\system.cfg", data, False)
        ElseIf ProgressBar3.Value = 5 Then
            ProgressBar3.Value = 15
            SetupLog.Text += vbNewLine + "Checking if the user enabled custom applications"
            If cust Then Label33.Text = "Current task: Unlocking custom applications"
        ElseIf ProgressBar3.Value = 15 Then
            ProgressBar3.Value = 25
            Label33.Text = "Current task: Saving system update settings"
            If cust = True Then
                SetupLog.Text += vbNewLine + "Unlocking custom application subsystem"
                Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Programs")
                File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Programs\dummy.DAT", "Dummy file", System.Text.Encoding.ASCII)
            End If
        ElseIf ProgressBar3.Value = 25 Then
            ProgressBar3.Value = 35
            If user1_enable Then Label33.Text = "Current task: Creating user account 1"
            SetupLog.Text += vbNewLine + "Writing system update manager settings"
            File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData + "\Windowed\update.cfg", Form1.channel + ";" + Form1.check + ";" + Form1.server)
        ElseIf ProgressBar3.Value = 35 Then
            ProgressBar3.Value = 45

            SetupLog.Text += vbNewLine + "Creating a dummy account to test system I/O"
            Setup.TextBox1.Text = "Dummy"
            Setup.TextBox2.Text = User1_Password.Text
            Setup.TextBox3.Text = User1_Password.Text
            Setup.RadioButton1.Checked = False
            Setup.RadioButton2.Checked = False
            Setup.RadioButton3.Checked = False
            Setup.RadioButton4.Checked = False
            Setup.RadioButton5.Checked = False
            If User1_Type.SelectedIndex = 0 Then Setup.RadioButton1.Checked = True
            If User1_Type.SelectedIndex = 1 Then Setup.RadioButton3.Checked = True
            If User1_Type.SelectedIndex = 2 Then Setup.RadioButton4.Checked = True
            If User1_Type.SelectedIndex = 3 Then Setup.RadioButton5.Checked = True
            If User1_Type.SelectedIndex = 4 Then Setup.RadioButton2.Checked = True
            Setup.Button2.PerformClick()
            Desktop.appBg.BackColor = user1_theme(0)
            Desktop.appFg.BackColor = user1_theme(1)
            Desktop.labelBg.BackColor = user1_theme(2)
            Desktop.labelFg.BackColor = user1_theme(3)
            Desktop.passwd = Setup.Encrypt(User1_Password.Text, User1_Password.Text)
            Desktop.user = "Dummy"
            Desktop.usertype = ""
            If User1_Type.SelectedIndex = 0 Then Desktop.usertype = "Administrator"
            If User1_Type.SelectedIndex = 1 Then Desktop.usertype = "Standard"
            If User1_Type.SelectedIndex = 2 Then Desktop.usertype = "Limited"
            If User1_Type.SelectedIndex = 3 Then Desktop.usertype = "Guest"
            If User1_Type.SelectedIndex = 4 Then Desktop.usertype = "Power"
            Desktop.OpenFileDialog1.FileName = user1_img
            CreateAvatar("Dummy")
            Desktop.Save(user1_img)

            SetupLog.Text += vbNewLine + "Deleting dummy account"
            File.Delete(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData + "\Windowed\Dummy.png")


            SetupLog.Text += vbNewLine + "Creating main system account"
            Setup.TextBox1.Text = User1_Name.Text
            Setup.TextBox2.Text = User1_Password.Text
            Setup.TextBox3.Text = User1_Password.Text
            SetupLog.Text += vbNewLine + "    Specifying account type"
            Setup.RadioButton1.Checked = False
            Setup.RadioButton2.Checked = False
            Setup.RadioButton3.Checked = False
            Setup.RadioButton4.Checked = False
            Setup.RadioButton5.Checked = False
            If User1_Type.SelectedIndex = 0 Then Setup.RadioButton1.Checked = True
            If User1_Type.SelectedIndex = 1 Then Setup.RadioButton3.Checked = True
            If User1_Type.SelectedIndex = 2 Then Setup.RadioButton4.Checked = True
            If User1_Type.SelectedIndex = 3 Then Setup.RadioButton5.Checked = True
            If User1_Type.SelectedIndex = 4 Then Setup.RadioButton2.Checked = True
            Setup.Button2.PerformClick()
            SetupLog.Text += vbNewLine + "    Setting up a virtual environment for user account configuration"
            Desktop.appBg.BackColor = user1_theme(0)
            Desktop.appFg.BackColor = user1_theme(1)
            Desktop.labelBg.BackColor = user1_theme(2)
            Desktop.labelFg.BackColor = user1_theme(3)
            SetupLog.Text += vbNewLine + "    Encrypting password"
            Desktop.passwd = Setup.Encrypt(User1_Password.Text, User1_Password.Text)
            Desktop.user = User1_Name.Text
            Desktop.usertype = ""
            If User1_Type.SelectedIndex = 0 Then Desktop.usertype = "Admin"
            If User1_Type.SelectedIndex = 1 Then Desktop.usertype = "Standard"
            If User1_Type.SelectedIndex = 2 Then Desktop.usertype = "Limited"
            If User1_Type.SelectedIndex = 3 Then Desktop.usertype = "Guest"
            If User1_Type.SelectedIndex = 4 Then Desktop.usertype = "Power"
            Desktop.OpenFileDialog1.FileName = user1_img
            SetupLog.Text += vbNewLine + "    Creating account avatar"
            CreateAvatar(User1_Name.Text)
            SetupLog.Text += vbNewLine + "    Saving main account information"
            Desktop.Save(user1_img)
        ElseIf ProgressBar3.Value = 45 Then
            ProgressBar3.Value = 55
            If user2_enable Then Label33.Text = "Current task: Creating user account 2"
        ElseIf ProgressBar3.Value = 55 Then
            ProgressBar3.Value = 65
            If user2_enable Then
                SetupLog.Text += vbNewLine + "Creating a secondary user account"
                Setup.TextBox1.Text = User2_Name.Text
                Setup.TextBox2.Text = User2_Password.Text
                Setup.TextBox3.Text = User2_Password.Text
                SetupLog.Text += vbNewLine + "    Specifying account type"
                Setup.RadioButton1.Checked = False
                Setup.RadioButton2.Checked = False
                Setup.RadioButton3.Checked = False
                Setup.RadioButton4.Checked = False
                Setup.RadioButton5.Checked = False
                If User2_Type.SelectedIndex = 0 Then Setup.RadioButton1.Checked = True
                If User2_Type.SelectedIndex = 1 Then Setup.RadioButton3.Checked = True
                If User2_Type.SelectedIndex = 2 Then Setup.RadioButton4.Checked = True
                If User2_Type.SelectedIndex = 3 Then Setup.RadioButton5.Checked = True
                If User2_Type.SelectedIndex = 4 Then Setup.RadioButton2.Checked = True
                Setup.Button2.PerformClick()
                SetupLog.Text += vbNewLine + "    Setting up a virtual environment for user account configuration"
                Desktop.appBg.BackColor = user2_theme(0)
                Desktop.appFg.BackColor = user2_theme(1)
                Desktop.labelBg.BackColor = user2_theme(2)
                Desktop.labelFg.BackColor = user2_theme(3)
                SetupLog.Text += vbNewLine + "    Encrypting password"
                Desktop.passwd = Setup.Encrypt(User2_Password.Text, User2_Password.Text)
                Desktop.user = User2_Name.Text
                Desktop.usertype = ""
                If User2_Type.SelectedIndex = 0 Then Desktop.usertype = "Admin"
                If User2_Type.SelectedIndex = 1 Then Desktop.usertype = "Standard"
                If User2_Type.SelectedIndex = 2 Then Desktop.usertype = "Limited"
                If User2_Type.SelectedIndex = 3 Then Desktop.usertype = "Guest"
                If User2_Type.SelectedIndex = 4 Then Desktop.usertype = "Power"
                Desktop.OpenFileDialog1.FileName = user2_img
                SetupLog.Text += vbNewLine + "    Creating account avatar"
                CreateAvatar(User2_Name.Text)
                SetupLog.Text += vbNewLine + "    Saving account 2 information"
                Desktop.Save(user2_img)
            End If

        ElseIf ProgressBar3.Value = 65 Then
            ProgressBar3.Value = 75
            If user3_enable Then Label33.Text = "Current task: Creating user account 3"

        ElseIf ProgressBar3.Value = 75 Then
            ProgressBar3.Value = 85
            If user3_enable Then
                SetupLog.Text += vbNewLine + "Creating a secondary user account"
                Setup.TextBox1.Text = User3_Name.Text
                Setup.TextBox2.Text = User3_Password.Text
                Setup.TextBox3.Text = User3_Password.Text
                SetupLog.Text += vbNewLine + "    Specifying account type"
                Setup.RadioButton1.Checked = False
                Setup.RadioButton2.Checked = False
                Setup.RadioButton3.Checked = False
                Setup.RadioButton4.Checked = False
                Setup.RadioButton5.Checked = False
                If User3_Type.SelectedIndex = 0 Then Setup.RadioButton1.Checked = True
                If User3_Type.SelectedIndex = 1 Then Setup.RadioButton3.Checked = True
                If User3_Type.SelectedIndex = 2 Then Setup.RadioButton4.Checked = True
                If User3_Type.SelectedIndex = 3 Then Setup.RadioButton5.Checked = True
                If User3_Type.SelectedIndex = 4 Then Setup.RadioButton2.Checked = True
                Setup.Button2.PerformClick()
                SetupLog.Text += vbNewLine + "    Setting up a virtual environment for user account configuration"
                Desktop.appBg.BackColor = user3_theme(0)
                Desktop.appFg.BackColor = user3_theme(1)
                Desktop.labelBg.BackColor = user3_theme(2)
                Desktop.labelFg.BackColor = user3_theme(3)
                SetupLog.Text += vbNewLine + "    Encrypting password"
                Desktop.passwd = Setup.Encrypt(User3_Password.Text, User3_Password.Text)
                Desktop.user = User3_Name.Text
                Desktop.usertype = ""
                If User3_Type.SelectedIndex = 0 Then Desktop.usertype = "Admin"
                If User3_Type.SelectedIndex = 1 Then Desktop.usertype = "Standard"
                If User3_Type.SelectedIndex = 2 Then Desktop.usertype = "Limited"
                If User3_Type.SelectedIndex = 3 Then Desktop.usertype = "Guest"
                If User3_Type.SelectedIndex = 4 Then Desktop.usertype = "Power"
                SetupLog.Text += vbNewLine + "    Creating account avatar"
                CreateAvatar(User3_Name.Text)
                SetupLog.Text += vbNewLine + "    Saving account 3 information"
                Desktop.Save(user3_img)
            End If
        ElseIf ProgressBar3.Value = 85 Then
            ProgressBar3.Value = 95
            If user3_enable Then Label33.Text = "Current task: Finishing up..."
        ElseIf ProgressBar3.Value = 95 Then
            SetupLog.Text += vbNewLine + "Writing setup log..."
            SetupLog.Text += vbNewLine + "* Log end *"
            File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData _
                              + "\Windowed\setup.log", SetupLog.Text)
            ProgressBar3.Value = 100
            Button1.Enabled = True
            Button2.Enabled = True
            Panel3.Visible = False
            ProgressBar3.Enabled = False
            Label7.ForeColor = Color.LightGray
            Label8.ForeColor = Color.LightGray
            Panel4.Visible = True
            WaitForUpdateTimer.Enabled = False
            CountDownRestart.Enabled = True
        End If
    End Sub

    Sub CreateAvatar(ByVal username As String)
        Dim backupuser As String = Desktop.user
        Desktop.user = username
        Dim letters() As String = {"Person", "Circle", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
        Dim s As String = Desktop.user.Substring(0, 1)
        Dim ltr As Integer = New Random().Next(0, 1)
        For i As Integer = 2 To letters.Length - 1 Step 1
            If letters(i).ToString() = s Then
                ltr = i
            End If
        Next
        Dim ac As AccountImage = New AccountImage
        ac.ComboBox3.SelectedIndex = ltr
        Dim r As Random = New Random()
        ac.ComboBox1.SelectedIndex = r.Next(0, ac.ComboBox1.Items.Count - 1)
        ac.ComboBox2.SelectedIndex = r.Next(0, ac.ComboBox2.Items.Count - 1)
        Dim img As Image = ac.CombineAvatar(ac.PictureBox1.BackgroundImage, ac.PictureBox1.BackColor)
        ac.PictureBox1.BackColor = Color.Transparent
        ac.PictureBox1.BackgroundImage = Nothing
        ac.PictureBox1.BackgroundImage = img
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & Desktop.user & ".png") Then File.Delete(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & Desktop.user & ".png")
        ac.PictureBox1.BackgroundImage.Save(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & Desktop.user & ".png", Imaging.ImageFormat.Png)
        img.Dispose()
        ac.PictureBox1.BackgroundImage.Dispose()
        ac.Close()
        Desktop.user = backupuser
        Desktop.OpenFileDialog1.FileName = user3_img
        Desktop.Save()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Try
            My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\login.txt")
        Catch
        End Try
        My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\login.txt", ComboBox3.SelectedItem.ToString().Split(" (")(0).ToString() & ";", False)
    End Sub

    Private Sub CountDownRestart_Tick(sender As Object, e As EventArgs) Handles CountDownRestart.Tick
        restartvalue -= 1
        Button2.Text = "Restart (" + restartvalue.ToString() + ")"
        If restartvalue = -1 Then
            Button2.Text = "Restarting..."
            Panel4.Visible = False
            CountDownRestart.Enabled = False
        End If
        If restartvalue = 0 Then
            Button2.PerformClick()
        End If
    End Sub
End Class