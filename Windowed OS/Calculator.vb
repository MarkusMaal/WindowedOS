Imports System.IO
Public Class Calculator
    Dim calculation As Double = 0.0
    Dim sign As String = ""
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim composedwindow As Form = New Form()
    Dim rap As Boolean = False
    Dim memory As Double = 0.0
    Private Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr
    Private Sub Calculator_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            MessageDialog.composedwindow.TopMost = True
            MessageDialog.TopMost = True
        End If
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & Desktop.user & "_calculator.txt") Then
            Dim calcstr As String = File.ReadAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & Desktop.user & "_calculator.txt")
            Dim calarray() As String = calcstr.Split(";")
            memory = Convert.ToDouble(calarray(1).ToString())
            If calarray(0).ToString() = "DEG" Then
                DegreesToolStripMenuItem.PerformClick()
            ElseIf calarray(0).ToString() = "RAD" Then
                RadiansToolStripMenuItem.PerformClick()
            End If
        End If
        If Not memory = 0.0 Then
            Label3.Text = Label3.Text & ", Memory"
        End If
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Opacity = 1.0
        If Not tskmgr.ListBox1.Items.Contains("Calculator") Then tskmgr.ListBox1.Items.Add("Calculator")
    End Sub

    Private Sub Button01_Click(sender As System.Object, e As System.EventArgs) Handles Button01.Click
        If Label2.Text = "0" Then
            Label2.Text = "1"
            Exit Sub
        Else
            Label2.Text = Label2.Text & "1"
        End If
    End Sub

    Private Sub Button02_Click(sender As System.Object, e As System.EventArgs) Handles Button02.Click
        If Label2.Text = "0" Then
            Label2.Text = "2"
            Exit Sub
        Else
            Label2.Text = Label2.Text & "2"
        End If
    End Sub

    Private Sub Button03_Click(sender As System.Object, e As System.EventArgs) Handles Button03.Click
        If Label2.Text = "0" Then
            Label2.Text = "3"
            Exit Sub
        Else
            Label2.Text = Label2.Text & "3"
        End If
    End Sub

    Private Sub Button04_Click(sender As System.Object, e As System.EventArgs) Handles Button04.Click
        If Label2.Text = "0" Then
            Label2.Text = "4"
            Exit Sub
        Else
            Label2.Text = Label2.Text & "4"
        End If
    End Sub

    Private Sub Button05_Click(sender As System.Object, e As System.EventArgs) Handles Button05.Click
        If Label2.Text = "0" Then
            Label2.Text = "5"
            Exit Sub
        Else
            Label2.Text = Label2.Text & "5"
        End If
    End Sub

    Private Sub Button06_Click(sender As System.Object, e As System.EventArgs) Handles Button06.Click
        If Label2.Text = "0" Then
            Label2.Text = "6"
            Exit Sub
        Else
            Label2.Text = Label2.Text & "6"
        End If
    End Sub

    Private Sub Button07_Click(sender As System.Object, e As System.EventArgs) Handles Button07.Click
        If Label2.Text = "0" Then
            Label2.Text = "7"
            Exit Sub
        Else
            Label2.Text = Label2.Text & "7"
        End If
    End Sub

    Private Sub Button08_Click(sender As System.Object, e As System.EventArgs) Handles Button08.Click
        If Label2.Text = "0" Then
            Label2.Text = "8"
            Exit Sub
        Else
            Label2.Text = Label2.Text & "8"
        End If
    End Sub

    Private Sub Button09_Click(sender As System.Object, e As System.EventArgs) Handles Button09.Click
        If Label2.Text = "0" Then
            Label2.Text = "9"
            Exit Sub
        Else
            Label2.Text = Label2.Text & "9"
        End If
    End Sub

    Private Sub Button00_Click(sender As System.Object, e As System.EventArgs) Handles Button00.Click
        If Label2.Text = "0" Then
            Label2.Text = "0"
            Exit Sub
        Else
            Label2.Text = Label2.Text & "0"
        End If
    End Sub

    Private Sub ButtonDot_Click(sender As System.Object, e As System.EventArgs) Handles ButtonDot.Click
        If Label2.Text.Contains(",") Then
            Exit Sub
        ElseIf Label2.Text = "0" Then
            Label2.Text = ","
        Else
            Label2.Text = Label2.Text & ","
        End If
    End Sub

    Private Sub ButtonMultiply_Click(sender As System.Object, e As System.EventArgs) Handles ButtonMultiply.Click
        If sign = "" Then
            calculation = Label2.Text
            sign = "*"
            Label2.Text = "0"
        Else
            'If not label2.text.contains(",") Then Label2.Text = Label2.Text & ",0"
            If sign = "*" Then calculation = calculation * Label2.Text
            If sign = "/" Then calculation = calculation / Label2.Text
            If sign = "+" Then calculation = calculation + Label2.Text
            If sign = "-" Then calculation = calculation - Label2.Text
            If sign = "sqrt" Then calculation = Math.Sqrt(Label2.Text) * calculation
            If sign = "%" Then calculation = calculation / 100.0
            If sign = "^" Then calculation = calculation ^ Label2.Text
            Label2.Text = "0"
            sign = "*"
        End If
    End Sub

    Private Sub ButtonPi_Click(sender As System.Object, e As System.EventArgs) Handles ButtonPi.Click
        Label2.Text = Math.Round(Math.PI, 14, MidpointRounding.ToEven)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If sign = "" Then
            calculation = Label2.Text
            sign = "^"
            Label2.Text = "0"
        Else
            'If not label2.text.contains(",") Then Label2.Text = Label2.Text & ",0"
            If sign = "*" Then calculation = calculation * Label2.Text
            If sign = "/" Then calculation = calculation / Label2.Text
            If sign = "+" Then calculation = calculation + Label2.Text
            If sign = "-" Then calculation = calculation - Label2.Text
            If sign = "sqrt" Then calculation = Math.Sqrt(Label2.Text) * calculation
            If sign = "%" Then calculation = calculation / 100.0
            If sign = "^" Then calculation = calculation ^ Label2.Text
            Label2.Text = "0"
            sign = "^"
        End If
    End Sub

    Private Sub ButtonDivide_Click(sender As System.Object, e As System.EventArgs) Handles ButtonDivide.Click
        If sign = "" Then
            calculation = Label2.Text
            sign = "/"
            Label2.Text = "0"
        Else
            'If not label2.text.contains(",") Then Label2.Text = Label2.Text & ",0"
            If sign = "*" Then calculation = calculation * Label2.Text
            If sign = "/" Then calculation = calculation / Label2.Text
            If sign = "+" Then calculation = calculation + Label2.Text
            If sign = "-" Then calculation = calculation - Label2.Text
            If sign = "sqrt" Then calculation = Math.Sqrt(Label2.Text) * calculation
            If sign = "%" Then calculation = calculation / 100.0
            If sign = "^" Then calculation = calculation ^ Label2.Text
            Label2.Text = "0"
            sign = "/"
        End If
    End Sub

    Private Sub ButtonAdd_Click(sender As System.Object, e As System.EventArgs) Handles ButtonAdd.Click
        If sign = "" Then
            calculation = Label2.Text
            sign = "+"
            Label2.Text = "0"
        Else
            'If not label2.text.contains(",") Then Label2.Text = Label2.Text & ",0"
            If sign = "*" Then calculation = calculation * Label2.Text
            If sign = "/" Then calculation = calculation / Label2.Text
            If sign = "+" Then calculation = calculation + Label2.Text
            If sign = "-" Then calculation = calculation - Label2.Text
            If sign = "sqrt" Then calculation = Math.Sqrt(Label2.Text) * calculation
            If sign = "%" Then calculation = calculation / 100.0
            If sign = "^" Then calculation = calculation ^ Label2.Text
            Label2.Text = "0"
            sign = "+"
        End If
    End Sub

    Private Sub ButtonSubtract_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSubtract.Click
        If sign = "" Then
            calculation = Label2.Text
            sign = "-"
            Label2.Text = "0"
        Else
            'If not label2.text.contains(",") Then Label2.Text = Label2.Text & ",0"
            If sign = "*" Then calculation = calculation * Label2.Text
            If sign = "/" Then calculation = calculation / Label2.Text
            If sign = "+" Then calculation = calculation + Label2.Text
            If sign = "-" Then calculation = calculation - Label2.Text
            If sign = "sqrt" Then calculation = Math.Sqrt(Label2.Text) * calculation
            If sign = "%" Then calculation = calculation / 100.0
            If sign = "^" Then calculation = calculation ^ Label2.Text
            Label2.Text = "0"
            sign = "-"
        End If
    End Sub

    Private Sub ButtonPercent_Click(sender As System.Object, e As System.EventArgs) Handles ButtonPercent.Click
        If sign = "" Then
            calculation = Label2.Text
            sign = "%"
            Label2.Text = "0"
        Else
            'If not label2.text.contains(",") Then Label2.Text = Label2.Text & ",0"
            If sign = "*" Then calculation = calculation * Label2.Text
            If sign = "/" Then calculation = calculation / Label2.Text
            If sign = "+" Then calculation = calculation + Label2.Text
            If sign = "-" Then calculation = calculation - Label2.Text
            If sign = "sqrt" Then calculation = Math.Sqrt(Label2.Text) * calculation
            If sign = "%" Then calculation = calculation / 100.0
            If sign = "^" Then calculation = calculation ^ Label2.Text
            Label2.Text = "0"
            sign = "%"
        End If
    End Sub

    Private Sub ButtonPlusMinus_Click(sender As System.Object, e As System.EventArgs) Handles ButtonPlusMinus.Click
        If Label2.Text.StartsWith("-") Then
            Label2.Text = Label2.Text.Substring(1, Label2.Text.Length - 1)
            Exit Sub
        Else
            Label2.Text = "-" & Label2.Text
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            If Label2.Text.StartsWith("-") Then
                Label2.Text = "?"
                Exit Sub
            End If
            Label2.Text = Math.Sqrt(Label2.Text)
        Catch
            MessageDialog.messageicon = "Error"
            MessageDialog.messagetext = "Math error"
            MessageDialog.messagetitle = "Calculation invalid"
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        calculation = 0.0
        sign = ""
        Label2.Text = 0
    End Sub

    Private Sub ButtonEqual_Click(sender As System.Object, e As System.EventArgs) Handles ButtonEqual.Click
        If Not Label2.Text.Contains(",") Then Label2.Text = Label2.Text & ",0"
        If sign = "*" Then calculation = calculation * Label2.Text
        If sign = "/" Then calculation = calculation / Label2.Text
        If sign = "+" Then calculation = calculation + Label2.Text
        If sign = "-" Then calculation = calculation - Label2.Text
        If sign = "sqrt" Then calculation = Math.Sqrt(Label2.Text) * calculation
        If sign = "%" Then calculation = calculation / 100.0
        If sign = "^" Then calculation = calculation ^ Label2.Text
        Label2.Text = calculation
        sign = ""
    End Sub

    Private Sub ButtonBackspace_Click(sender As System.Object, e As System.EventArgs) Handles ButtonBackspace.Click
        If Not Label2.Text.Length = 1 Then
            Label2.Text = Label2.Text.Substring(0, Label2.Text.Length - 1)
        Else
            Label2.Text = "0"
        End If
    End Sub

    Private Sub Calculator_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
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

    Private Sub Calculator_Deactivate(sender As System.Object, e As System.EventArgs) Handles MyBase.Deactivate
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

    Private Sub Label1_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Left
        mousey = Cursor.Position.Y - Top
        composedwindow.BringToFront()
        Me.BringToFront()
        rap = False
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseMove
        If drag Then
            Top = Cursor.Position.Y - mousey
            Left = Cursor.Position.X - mousex
            composedwindow.Top = Top
            composedwindow.Left = Left
        End If
    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseUp
        drag = False
        composedwindow.BringToFront()
        rap = False
        Me.BringToFront()
    End Sub

    Private Sub Calculator_VisibleChanged(sender As System.Object, e As System.EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible = True Then
            Form1.Setfont(Me, Label1, Label4)
            Label1.BackColor = Desktop.labelBg.BackColor
            Label1.ForeColor = Desktop.labelFg.BackColor
            Label4.BackColor = Label1.BackColor
            Label4.ForeColor = Label1.ForeColor
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then
                Me.BackColor = Desktop.appBg.BackColor
            Else
                Form1.translucency(Me, composedwindow, True)
                For Each element As Control In Me.Controls
                    If TypeOf element Is Button Then
                        Dim r As Integer = Me.BackColor.R + 1
                        Dim g As Integer = Me.BackColor.G + 1
                        Dim b As Integer = Me.BackColor.B + 1
                        If r > 255 Then r = Me.BackColor.R - 1
                        If g > 255 Then g = Me.BackColor.G - 1
                        If b > 255 Then b = Me.BackColor.B - 1
                        element.BackColor = Color.FromArgb(r, g, b)
                    End If
                Next
                Button1.BackColor = Color.Red
                Button1.ForeColor = Color.White
                ButtonEqual.BackColor = Color.DeepSkyBlue
                ButtonEqual.ForeColor = Color.White
            End If
            Me.ForeColor = Desktop.appFg.BackColor
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
        If Not Desktop.usertype = "Guest" Then
            Dim rad As String = "RAD"
            If RadiansToolStripMenuItem.Checked = True Then
                rad = "RAD"
            ElseIf DegreesToolStripMenuItem.Checked = True Then
                rad = "DEG"
            End If
            Dim calstring As String = rad & ";" & memory & ";"
            File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Windowed\" & Desktop.user & "_calculator.txt", calstring)
        End If
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then
            Me.Close()
        Else
            Form1.fadeout_animation(Me, composedwindow)
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MessageDialog.messageicon = "Info"
        MessageDialog.messagetext = "Calculator version 1.0r"
        MessageDialog.messagetitle = "About"
        'MessageDialog.ff = Me
        'MessageDialog.sf = composedwindow
        MessageDialog.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        'If not label2.text.contains(",") Then Label2.Text = Label2.Text & ",0"
        If Label3.Text.StartsWith("Mode: RAD") = True Then
            Label2.Text = Math.Cos(Label2.Text)
        ElseIf Label3.Text.StartsWith("Mode: DEG") = True Then
            Dim temp As Double
            temp = Math.Cos(Label2.Text / (180 / Math.PI))
            temp = Math.Round(temp, 14)
            Label2.Text = temp
            'Label2.Text = Math.Cos(Label2.Text / 57.3)
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        'If not label2.text.contains(",") Then Label2.Text = Label2.Text & ",0"
        If Label3.Text.StartsWith("Mode: RAD") = True Then
            Label2.Text = Math.Sin(Label2.Text)
        ElseIf Label3.Text.StartsWith("Mode: DEG") = True Then
            Dim temp As Double
            temp = Math.Sin(Label2.Text / (180 / Math.PI))
            temp = Math.Round(temp, 14)
            Label2.Text = temp
            'Label2.Text = Math.Sin(Label2.Text / 57.3)
        End If
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        'If not label2.text.contains(",") Then Label2.Text = Label2.Text & ",0"
        If Label3.Text.StartsWith("Mode: RAD") = True Then
            Label2.Text = Math.Tan(Label2.Text)
        ElseIf Label3.Text.StartsWith("Mode: DEG") = True Then
            Dim temp As Double
            temp = Math.Tan(Label2.Text / (180 / Math.PI))
            temp = Math.Round(temp, 14)
            Label2.Text = temp
            'Label2.Text = Math.Tan(Label2.Text / 57.3)
        End If
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        'If not label2.text.contains(",") Then Label2.Text = Label2.Text & ",0"
        If Convert.ToDouble(Label2.Text) = 0.0 Then
            Label2.Text = "?"
            Exit Sub
        End If
        Dim i As Double = 1.0 / Convert.ToDouble(Label2.Text)
        Label2.Text = i
    End Sub

    Private Sub DegreesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DegreesToolStripMenuItem.Click
        If DegreesToolStripMenuItem.Checked = False Then
            RadiansToolStripMenuItem.Checked = True
            Label3.Text = "Mode: RAD"
            If Not memory = 0.0 Then
                Label3.Text = Label3.Text & ", Memory"
            End If
            Exit Sub
        ElseIf DegreesToolStripMenuItem.Checked = True Then
            RadiansToolStripMenuItem.Checked = False
            Label3.Text = "Mode: DEG"
            If Not memory = 0.0 Then
                Label3.Text = Label3.Text & ", Memory"
            End If
            Exit Sub
        End If
    End Sub

    Private Sub RadiansToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RadiansToolStripMenuItem.Click
        If RadiansToolStripMenuItem.Checked = False Then
            DegreesToolStripMenuItem.Checked = True
            Label3.Text = "Mode: DEG"
            If Not memory = 0.0 Then
                Label3.Text = Label3.Text & ", Memory"
            End If
            Exit Sub
        ElseIf RadiansToolStripMenuItem.Checked = True Then
            DegreesToolStripMenuItem.Checked = False
            Label3.Text = "Mode: RAD"
            If Not memory = 0.0 Then
                Label3.Text = Label3.Text & ", Memory"
            End If
            Exit Sub
        End If
    End Sub

    Private Sub KillTimer_Tick(sender As System.Object, e As System.EventArgs) Handles KillTimer.Tick
        If Desktop.calckill.Text = "kill" Then
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Close()
            Me.Close()
        ElseIf LogoffWindow.Visible = True Then
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Close()
            Me.Close()
        ElseIf Lock.Visible = True Then
            Me.Hide()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Hide()
        ElseIf Desktop.restorewindow.Text = "Calculator" Then
            Me.Opacity = 1.0
            composedwindow.Opacity = 0.9
            Me.Show()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Show()
        End If
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            If composedwindow.IsDisposed = False Then
                If Not GetActiveWindow <> composedwindow.Handle Then
                    composedwindow.BringToFront()
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
        If Form1.FadeInTimer.Enabled = True Then Exit Sub
        If Not Me.Opacity = 1.0 Or Me.Opacity = 0.0 Then
            Form1.fadeout_animation(Me, composedwindow)
        End If
    End Sub

    Private Sub EndProcessToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EndProcessToolStripMenuItem.Click
        tskmgr.ListBox1.Items.Remove("Calculator")
        Desktop.calckill.Text = "kill"
        Desktop.killtimer.Enabled = True
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
        ExitToolStripMenuItem.PerformClick()
    End Sub

    Private Sub Calculator_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Delete Then
            Button1.PerformClick()
        ElseIf e.KeyCode = Keys.Enter Then
            ButtonEqual.PerformClick()
        ElseIf e.KeyCode = Keys.Back Then
            ButtonBackspace.PerformClick()
        ElseIf e.KeyCode = Keys.P Then
            ButtonPi.PerformClick()
        ElseIf e.KeyCode = Keys.ControlKey + Keys.C Then
            Clipboard.SetText(Label2.Text)
        ElseIf e.KeyCode = Keys.ControlKey + Keys.X Then
            Label2.Text = "0"
            Clipboard.SetText(Label2.Text)
        ElseIf e.KeyCode = Keys.ControlKey + Keys.V Then
            Label2.Text = Clipboard.GetText.ToString()
        End If
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Clipboard.SetText(Label2.Text)
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CutToolStripMenuItem.Click
        Label2.Text = "0"
        Clipboard.SetText(Label2.Text)
    End Sub

    Private Sub OasteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OasteToolStripMenuItem.Click
        Label2.Text = Clipboard.GetText.ToString()
    End Sub

    Private Sub Calculator_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        If rap = False Then
            composedwindow.BringToFront()
            Me.BringToFront()
            rap = True
        End If
    End Sub

    Private Sub ViewDesktopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDesktopToolStripMenuItem.Click
        Me.Hide()
        composedwindow.Hide()
    End Sub

    Private Sub Label1_BackColorChanged(sender As Object, e As EventArgs) Handles Label1.BackColorChanged
        Label4.BackColor = Label1.BackColor
        Label4.ForeColor = Label1.ForeColor
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        ViewDesktopToolStripMenuItem.PerformClick()
    End Sub

    Private Sub AddToMemoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToMemoryToolStripMenuItem.Click
        memory = memory + Convert.ToDouble(Label2.Text)
        If Not memory = 0.0 Then
            If Not Label3.Text.EndsWith(", Memory") = True Then
                Label3.Text = Label3.Text & ", Memory"
            End If
        Else
            Label3.Text = Label3.Text.Replace(", Memory", "")
        End If
    End Sub

    Private Sub ImportFromMemoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportFromMemoryToolStripMenuItem.Click
        Label2.Text = memory
    End Sub

    Private Sub CheckJustInCase_Tick(sender As Object, e As EventArgs) Handles CheckJustInCase.Tick
        If Label3.Text.EndsWith(", Memory, Memory") = True Then
            Label3.Text = Label3.Text.Replace(", Memory, Memory", ", Memory")
        End If
    End Sub

    Private Sub DocumentationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentationToolStripMenuItem.Click
        Docs.launchdoc(My.Resources.CalculatorDocs, "Calculator documentation")
    End Sub
End Class