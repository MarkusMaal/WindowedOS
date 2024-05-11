Imports System.IO
Public Class NewLogin
    Dim drag As Boolean
    Dim mousex As Integer
    Dim CurLocation, AppLocation As New Point(0, 0)
    Dim mousey As Integer
    Public composedwindow As Form = New Form()
    Public Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr
    Dim lvi As ListViewItem
    ' Dim exts As New List(Of String)
    Private Sub NewLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.BackColor = Form1.appBg.BackColor
        ListView1.ForeColor = Form1.appFg.BackColor
        ComboBox1.SelectedIndex = 0
        If Form1.esb = False Then Button3.Visible = False
        If Form1.esb = True Then Button3.Visible = True
        If Form1.esr = False Then Button1.Visible = False
        If Form1.esr = True Then Button1.Visible = True
        If Form1.esr = False Then Button2.Visible = False
        If Form1.esr = True Then Button2.Visible = True
        If Form1.eab = False Then CheckBox1.Visible = False
        If Form1.eab = True Then CheckBox1.Visible = True
        Dim di As New DirectoryInfo(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData.ToString() & "\Windowed")
        Dim i As Integer = 0
        ListView1.Items.Clear()
        For Each fi As FileInfo In di.EnumerateFiles("*.png")
            If fi.Name.Contains("_bg") Then Continue For
            lvi = New ListViewItem With {
                .Text = fi.Name.Replace(".png", "")
            }
            lvi.SubItems.Add("User account")
            'lvi.SubItems.Add(((fi.Length / 1024)).ToString("0.00"))
            lvi.SubItems.Add("Last accessed: " + fi.LastWriteTime.ToString())
            AccountImages_S.Images.Add(Image.FromFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & lvi.Text & ".png"))
            AccountImage_L.Images.Add(Image.FromFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & lvi.Text & ".png"))
            ' exts.Add(fi.Extension)
            lvi.ImageIndex = i
            i += 1
            ListView1.Items.Add(lvi)
        Next
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

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim usr As String = ListView1.SelectedItems(0).Text.ToString()
        Desktop.labelBg.BackColor = Form1.labelBg.BackColor
        Desktop.labelFg.BackColor = Form1.labelFg.BackColor
        Desktop.appBg.BackColor = Form1.appBg.BackColor
        Desktop.appFg.BackColor = Form1.appFg.BackColor
        Dim gimn As String
        gimn = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & usr & ".txt")
        Dim data() As String
        data = gimn.Split(";")
        Dim pwd As String = ""
        If Not data(0) = "JlnAU+w22tzhFyQmEMDK/g==" Then
            pwd = Form1.InputDialog("Enter password:", "This user account has a password", True)
        End If
        LoginPrompt.Show()
        LoginPrompt.NameField.Text = usr
        LoginPrompt.PassField.Text = pwd
        LoginPrompt.LoginButton.PerformClick()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ShutDown.restart = True
        ListView1.Enabled = False
        FlowLayoutPanel1.Enabled = False
        CheckBox1.Enabled = False
        LoginButton.Enabled = False
        Label6.Text = "Restarting"
        ShutDown.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ShutDown.restart = False
        ListView1.Enabled = False
        FlowLayoutPanel1.Enabled = False
        CheckBox1.Enabled = False
        LoginButton.Enabled = False
        Label6.Text = "Shutting down"
        ShutDown.Show()
    End Sub

    Private Sub Label2_MouseDown(sender As Object, e As MouseEventArgs) Handles Label2.MouseDown
        ResizeTimer.Enabled = True
        Sync()
    End Sub

    Private Sub Label2_MouseUp(sender As Object, e As MouseEventArgs) Handles Label2.MouseUp
        ResizeTimer.Enabled = False
        Sync()
        composedwindow.BringToFront()
        Me.BringToFront()
    End Sub

    Private Sub Sync()
        CurLocation = Cursor.Position
        AppLocation = Size
    End Sub

    Private Sub NewLogin_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        Try
            If Me.Visible = True Then
                Button1.BackColor = Form1.appBg.BackColor
                Button1.ForeColor = Form1.appFg.BackColor
                Button2.BackColor = Form1.appBg.BackColor
                Button2.ForeColor = Form1.appFg.BackColor
                LoginButton.BackColor = Form1.appBg.BackColor
                LoginButton.ForeColor = Form1.appFg.BackColor
                Label6.BackColor = Form1.labelBg.BackColor
                Label6.ForeColor = Form1.labelFg.BackColor
                Label2.BackColor = Form1.appBg.BackColor
                Label2.ForeColor = Form1.appFg.BackColor
                Button3.BackColor = Form1.appBg.BackColor
                Button3.ForeColor = Form1.appFg.BackColor
                composedwindow.BackColor = Form1.appBg.BackColor
                If Form1.edc = False Then Me.BackColor = Form1.appBg.BackColor
                If Form1.edc = False Then Me.TransparencyKey = Nothing
                If Form1.edc = True Then composedwindow.TopMost = True
                If Form1.edc = True Then composedwindow.FormBorderStyle = FormBorderStyle.None
                If Form1.edc = True Then composedwindow.Size = Me.Size
                If Form1.edc = True Then composedwindow.Location = Me.Location
                If Form1.edc = True Then composedwindow.AllowTransparency = True
                If Form1.edc = True Then composedwindow.Opacity = 0.8
                If Form1.edc = True Then Me.TransparencyKey = Form1.appBg.BackColor
                If Form1.edc = True Then composedwindow.Show()
                If Form1.edc = True Then composedwindow.BringToFront()
                If Form1.edc = True Then Me.BringToFront()
                Desktop.appBg.BackColor = Form1.appBg.BackColor
                Me.BackColor = Form1.appBg.BackColor
                Me.Opacity = 1.0
                Me.ForeColor = Form1.appFg.BackColor
            End If
        Catch ex As Exception
            ESOD.Label5.Text = "Unable to apply theme: Theme may be corrupted" & vbNewLine & ex.Message
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Login.legacy = True
        If composedwindow.Visible = True Then composedwindow.Close()
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            ListView1.View = View.LargeIcon
        ElseIf ComboBox1.SelectedIndex = 1 Then
            ListView1.View = View.Details
        ElseIf ComboBox1.SelectedIndex = 2 Then
            ListView1.View = View.Tile
        ElseIf ComboBox1.SelectedIndex = 3 Then
            ListView1.View = View.List
        ElseIf ComboBox1.SelectedIndex = 4 Then
            ListView1.View = View.SmallIcon
        End If
    End Sub

    Private Sub ListView1_ItemActivate(sender As Object, e As EventArgs) Handles ListView1.ItemActivate
        LoginButton.PerformClick()
    End Sub

    Private Sub ResizeTimer_Tick(sender As Object, e As EventArgs) Handles ResizeTimer.Tick
        Size = AppLocation - CurLocation + Cursor.Position
        If composedwindow.Visible = True Then
            composedwindow.Size = Me.Size
        End If
    End Sub
End Class