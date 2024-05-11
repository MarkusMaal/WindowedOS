Public Class v_splash

    Dim composedwindow As Form = New Form()
    Private Sub v_splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Gets visual theme and saves it to a file for applications to use
        composedwindow.Opacity = 0.0
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.translucency(Me, composedwindow, False)
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Opacity = 1.0
        Dim colorlabelBG As String
        Dim colorlabelFG As String

        Dim colorappBG As String
        Dim colorappFG As String

        colorlabelBG = Desktop.labelBg.BackColor.ToString()
        colorlabelFG = Desktop.labelFg.BackColor.ToString()
        colorappBG = Desktop.appBg.BackColor.ToString()
        colorappFG = Desktop.appFg.BackColor.ToString()

        Dim rawdata As String = colorappBG & ";" & colorappFG & ";" & colorlabelBG & ";" & colorlabelFG & ";"
        If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Programs") Then My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Programs")
        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Programs\theme.txt") Then My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Programs\theme.txt")
        My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Programs\theme.txt", rawdata, False)
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        voide.Show()
        composedwindow.Close()
        Me.Close()
        Timer1.Enabled = False
    End Sub

    Sub abc()
        voide.Show()
    End Sub
End Class