Public Class Login
    Public logoff As Boolean
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim obj As New SecondDisp

    Public legacy = False
    Private Sub LoginButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
    End Function

    Private Sub PassField_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub NameField_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub Login_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If legacy = True Then
            If Desktop.Visible = False Then
                If Not LoginPrompt.Label1.Text = "Shutting down..." Then
                    If Not LoginPrompt.Label1.Text = "Restarting..." Then
                        ShutDown.Show()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Form1.elm = False Then Watermark.Visible = False
        If Form1.eul = True Then legacy = False
        If Form1.eul = False Then legacy = True
        If Not Form1.wm = "" Then Form1.MsgDialog(Form1.wm, "Welcome message", "Info", "OKOnly")
        If black.Visible = False Then black.Show()
        Me.BringToFront()
        If StartupWindow.Visible = True Then StartupWindow.Close()
        If Me.BackgroundImage Is Nothing Then
            Me.BackgroundImage = Form1.BackgroundImage
        End If
        If LogoffWindow.Visible = True Then LogoffWindow.Close()
        If NewLogin.Visible = True Then NewLogin.Close()
        If Desktop.dev = True Then dev.Visible = True
        If logoff = True Then
            logoff = False
            Exit Sub
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Login_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If logoff = True Then
            logoff = False
            Exit Sub
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            ProgressBar1.Value = 0
            If Me.Visible = True Then
                If legacy = True Then
                    If LoginPrompt.Visible = False Then LoginPrompt.ShowDialog()
                Else
                    If NewLogin.Visible = False Then NewLogin.ShowDialog()
                End If
            End If
            Watermark.BackColor = Color.Transparent
        Else
            ProgressBar1.Value = ProgressBar1.Value + 1
        End If
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Timer2.Enabled = False
        ShutDown.Show()
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        If Form1.dtl = False Then
            Timer3.Enabled = False
            Label7.Visible = False
        End If
        Label7.Text = CType(Now, String)
    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Watermark.Click
        Watermark.BackColor = Color.DimGray
        If NewLogin.Visible = False Then NewLogin.ShowDialog()
    End Sub

    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick
        If Form1.edc = False Then Timer4.Enabled = False
        If legacy = True Then
            If Form1.edc = False Then LoginPrompt.TransparencyKey = Nothing
        Else
            If Form1.edc = False Then NewLogin.TransparencyKey = Nothing
        End If
        If Form1.edc = True Then
            If legacy = True Then
                If LoginPrompt.composedwindow.IsDisposed = False Then
                    If Not LoginPrompt.GetActiveWindow <> LoginPrompt.composedwindow.Handle Then
                        LoginPrompt.BringToFront()
                    End If
                End If
            Else
                If NewLogin.composedwindow.IsDisposed = False Then
                    If Not NewLogin.GetActiveWindow <> NewLogin.composedwindow.Handle Then
                        NewLogin.BringToFront()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Login_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible = True Then
            obj.Location = Screen.AllScreens(UBound(Screen.AllScreens)).Bounds.Location
            obj.Show()
        Else
            obj.Hide()
        End If
    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        obj.Close()
    End Sub
End Class