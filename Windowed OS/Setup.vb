Imports System.IO
Public Class Setup
    'don't even try
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim composedwindow As Form = New Form()
    Private Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
        Form1.Close()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        RichTextBox1.Text = "Local_1"
        Save()
        If Not My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & TextBox1.Text & ".txt") Then
            MessageDialog.messagetitle = "Set up"
            MessageDialog.messagetext = "Setup can't continue: File does not exist"
            MessageDialog.messageicon = "Critical"
            'MessageDialog.ff = Me
            'MessageDialog.sf = composedwindow
            MessageDialog.ShowDialog()
            Exit Sub
        End If
        If RadioButton1.Checked = True Then My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & TextBox1.Text & "_admin.txt", "This account is classified as an Administrator", False)
        If RadioButton2.Checked = True Then My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & TextBox1.Text & "_power.txt", "This account is classified as a Power User", False)
        If RadioButton3.Checked = True Then My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & TextBox1.Text & "_standard.txt", "This account is classified as a Standard User", False)
        If RadioButton4.Checked = True Then My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & TextBox1.Text & "_limited.txt", "This account is classified as a Limited User", False)
        If RadioButton5.Checked = True Then My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & TextBox1.Text & "_guest.txt", "This account is classified as a Guest", False)
        TextBox3.Text = ""
        TextBox2.Text = ""
        TextBox1.Text = ""
    End Sub

    Public Sub Save()
        If Not TextBox3.Text = TextBox2.Text Then
            MessageDialog.messagetitle = "Set up"
            MessageDialog.messagetext = "Error: Passwords do not match"
            MessageDialog.messageicon = "Critical"
            'MessageDialog.ff = Me
            'MessageDialog.sf = composedwindow
            MessageDialog.ShowDialog()
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            If RadioButton1.Checked = True Or RadioButton2.Checked = True Then
                MessageDialog.messagetitle = "Set up"
                MessageDialog.messagetext = "Error: Administrators and power users must have a password"
                MessageDialog.messageicon = "Critical"
                'MessageDialog.ff = Me
                'MessageDialog.sf = composedwindow
                MessageDialog.ShowDialog()
                Exit Sub
            End If
        End If
        Dim passwd As String = Encrypt(TextBox2.Text, TextBox2.Text)
        Dim filecontentx As String
        Dim filecontenty As String
        Dim ailecontentx As String
        Dim ailecontenty As String
        Dim bilecontentx As String
        Dim bilecontenty As String
        Dim cilecontentx As String
        Dim cilecontenty As String
        filecontentx = Desktop.PictureBox2.Location.X.ToString()
        filecontenty = Desktop.PictureBox2.Location.Y.ToString()
        ailecontentx = Desktop.PictureBox3.Location.X.ToString()
        ailecontenty = Desktop.PictureBox3.Location.Y.ToString()
        bilecontentx = Desktop.PictureBox4.Location.X.ToString()
        bilecontenty = Desktop.PictureBox4.Location.Y.ToString()
        cilecontentx = Desktop.PictureBox5.Location.X.ToString()
        cilecontenty = Desktop.PictureBox5.Location.Y.ToString()
        Dim data As String
        If Not RadioButton4.Checked = True Then data = passwd & ";" & filecontentx & ";" & filecontenty & ";" & ailecontentx & ";" & ailecontenty & ";" & bilecontentx & ";" & bilecontenty & ";" & cilecontentx & ";" & cilecontenty & ";" & RichTextBox1.Text & ";"
        If RadioButton4.Checked = True Then data = passwd & ";" & filecontentx & ";" & filecontenty & ";" & ailecontentx & ";" & ailecontenty & ";" & bilecontentx & ";" & bilecontenty & ";" & cilecontentx & ";" & cilecontenty & ";"
        My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & TextBox1.Text & ".txt", data, False)
        Dim backupuser As String = Desktop.user
        Desktop.user = TextBox1.Text
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
    End Sub


    Public Function Encrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim HASH_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = HASH_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(buffer, 0, buffer.Length))
            Return encrypted
        Catch ex As Exception

        End Try
        'exception should only return if there is an encryption error, in any other case
        'it should be fine
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RichTextBox1.Text = "Local_1"
        Save()
        If Not My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & TextBox1.Text & ".txt") Then
            MessageDialog.messagetitle = "Set up"
            MessageDialog.messagetext = "Setup can't continue: File does not exist"
            MessageDialog.messageicon = "Critical"
            'MessageDialog.ff = Me
            'MessageDialog.sf = composedwindow
            MessageDialog.ShowDialog()
            Exit Sub
        End If
        If RadioButton1.Checked = True Then My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & TextBox1.Text & "_admin.txt", "This account is classified as an Administrator", False)
        If RadioButton2.Checked = True Then My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & TextBox1.Text & "_power.txt", "This account is classified as a Power User", False)
        If RadioButton3.Checked = True Then My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & TextBox1.Text & "_standard.txt", "This account is classified as a Standard User", False)
        If RadioButton4.Checked = True Then My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & TextBox1.Text & "_limited.txt", "This account is classified as a Limited User", False)
        If RadioButton5.Checked = True Then My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & TextBox1.Text & "_guest.txt", "This account is classified as a Guest", False)

        TextBox3.Text = ""
        TextBox2.Text = ""
        TextBox1.Text = ""
        SpecifyPanel.Visible = False
        FinishPanel.Visible = True
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar = Chr(13) Then
            Button1.PerformClick()
        End If
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
            composedwindow.Top = Top
            composedwindow.Left = Left
        End If
    End Sub

    Private Sub Label4_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Label4.MouseUp
        drag = False
        composedwindow.BringToFront()
        Me.BringToFront()
    End Sub

    Private Sub Setup_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Label4.BackColor = Desktop.labelBg.BackColor
    End Sub

    Private Sub Setup_VisibleChanged(sender As System.Object, e As System.EventArgs) Handles MyBase.VisibleChanged
        Try
            If Me.Visible = True Then
                Me.BackColor = Desktop.appBg.BackColor
                Me.Opacity = 1.0
                composedwindow.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                composedwindow.Opacity = 0.9
                composedwindow.BackColor = Desktop.appBg.BackColor
                composedwindow.Show()
                composedwindow.Location = Me.Location
                composedwindow.Size = Me.Size
                composedwindow.TopMost = Me.TopMost
                Me.ForeColor = Desktop.appFg.BackColor
                Label2.BackColor = Desktop.appBg.BackColor
                Label2.ForeColor = Desktop.appFg.BackColor
                Label3.BackColor = Desktop.appBg.BackColor
                Label3.ForeColor = Desktop.appFg.BackColor
                Label5.BackColor = Desktop.appBg.BackColor
                Label5.ForeColor = Desktop.appFg.BackColor
                Label4.BackColor = Desktop.labelBg.BackColor
                Label4.ForeColor = Desktop.labelFg.BackColor
            End If
        Catch ex As Exception
            ESOD.Label5.Text = ex.Message
            ESOD.ShowDialog()
        End Try
    End Sub
    Private Sub Setup_Deactivate(sender As Object, e As System.EventArgs) Handles Me.Deactivate
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
                    Me.TopMost = True
                    Me.BringToFront()
                End If
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox2.Select()
        End If
    End Sub

    Private Sub TextBox2_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox3.Select()
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton4.CheckedChanged, RadioButton3.CheckedChanged, RadioButton2.CheckedChanged, RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Label6.Text = "Administrator can change system wide settings and also delete said settings." & vbNewLine & "Administrator account can be customized. They can also access normal system" & vbNewLine & "applications, but they can't access command prompt."
            Exit Sub
        ElseIf RadioButton2.Checked = True Then
            Label6.Text = "Developers are almost identical to administrators, but they can debug and" & vbNewLine & "develop new Windowed OS applications."
            Exit Sub
        ElseIf RadioButton3.Checked = True Then
            Label6.Text = "Standard users can access all normal system applications. They can prsonalize" & vbNewLine & "the desktop to their liking. Standard users can't acccess comand prompt nor" & vbNewLine & "change system wide settings or delete them."
            Exit Sub
        ElseIf RadioButton4.Checked = True Then
            Label6.Text = "Limited user accounts can access all normal system applications. They can not" & vbNewLine & "change any system settings nor delete them. Limited accounts can not acccess" & vbNewLine & "command prompt. Limited user accounts can have settings per application."
            Exit Sub
        ElseIf RadioButton5.Checked = True Then
            Label6.Text = "Guests can access all usual system applications. They can not acccess command" & vbNewLine & "prompt nor change any system settings or delete them. Guest only has temporary" & vbNewLine & "settings (after logging out, settings will be lost)."
            Exit Sub
        End If
    End Sub

    Private Sub Setup_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = 0.0
        Me.TransparencyKey = Desktop.appBg.BackColor
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then
            Me.Opacity = 1.0
            Me.TransparencyKey = Nothing
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        SpecifyPanel.Visible = True
        WelcomePanel.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FinishPanel.Visible = True
        WelcomePanel.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If composedwindow.Visible = True Then composedwindow.Close()
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Close()
    End Sub

    Private Sub SpecifyPanel_Paint(sender As Object, e As PaintEventArgs) Handles SpecifyPanel.Paint

    End Sub

    Private Sub FinishPanel_Paint(sender As Object, e As PaintEventArgs) Handles FinishPanel.Paint

    End Sub
End Class