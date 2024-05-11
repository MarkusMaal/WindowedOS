Imports System.Linq.Expressions

Public Class Custom
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim CurLocation, AppLocation As New Point(0, 0)
    Dim composedwindow As Form = New Form()
    Dim rap As Boolean = False
    Public appname As String = "My Program"
    Private Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles MainForm.MouseDown
        drag = True
        mousex = Cursor.Position.X - Left
        mousey = Cursor.Position.Y - Top
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles MainForm.MouseMove
        If drag Then
            Top = Cursor.Position.Y - mousey
            Left = Cursor.Position.X - mousex
            composedwindow.Left = Left
            composedwindow.Top = Top
        End If
    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles MainForm.MouseUp
        drag = False
        composedwindow.BringToFront()
        Me.BringToFront()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.fadeout_animation(Me, composedwindow)
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Close()
    End Sub

    Private Sub Sync()
        CurLocation = Cursor.Position
        AppLocation = Size
    End Sub

    Private Sub Label2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label5.MouseDown
        ResizeTimer.Start()
        Sync()
    End Sub

    Private Sub Label2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label5.MouseUp
        ResizeTimer.Stop()
        Sync()
        composedwindow.BringToFront()
        Me.BringToFront()
    End Sub

    Private Sub ResizeTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ResizeTimer.Tick
        Size = AppLocation - CurLocation + Cursor.Position
        composedwindow.Size = Size
    End Sub
    Private Sub TerminateTimer_Tick(sender As System.Object, e As System.EventArgs) Handles TerminateTimer.Tick
        If LogoffWindow.Visible = True Then
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Close()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.fadeout_animation(Me, composedwindow)
        ElseIf Lock.Visible = True Then
            Me.Hide()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Hide()
        ElseIf Desktop.KillSignal.Text = appname Then
            'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Close()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.fadeout_animation(Me, composedwindow)
        ElseIf Desktop.restorewindow.Text = appname Then
            Me.Opacity = 1.0
            composedwindow.Opacity = 0.9
            Me.Show()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Show()
        End If
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            If composedwindow.IsDisposed = False Then
                If Not GetActiveWindow <> composedwindow.Handle Then
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
    End Sub

    Private Sub Custom_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
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
        MainForm.BackColor = col
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            If composedwindow.IsDisposed = False Then
                If Not GetActiveWindow <> composedwindow.Handle Then
                    Me.BringToFront()
                End If
            End If
        End If
        rap = False
    End Sub

    Private Sub Custom_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        MainForm.BackColor = Desktop.labelBg.BackColor
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

    Private Sub Custom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        Dim lst As ListBox = New ListBox()
            lst.Items.AddRange(s_sv.Text.Split("::"))
            For i As Integer = 0 To lst.Items.Count - 1
                lst.SelectedIndex = i
                If lst.SelectedItem.ToString().Contains("MainForm - Listener.Load*") Then
                    Dim lstt As ListBox = New ListBox()
                    Dim oi As String = lst.SelectedItem.ToString()
                    lstt.Items.AddRange(oi.Split(";"))
                    For j As Integer = 0 To lstt.Items.Count - 1
                        lstt.SelectedIndex = j
                        Dim ss As String = lstt.SelectedItem.ToString().Replace("MainForm - Listener.Load*", "")
                        execute(ss)
                    Next
                End If
            Next
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Opacity = 1.0
            For Each element As Control In Me.Controls
                If TypeOf element Is Button Then
                    AddHandler element.Click, Sub(sender2, eventargs2)
                                                  'Try
                                                  For i As Integer = 0 To lst.Items.Count - 1
                                                          lst.SelectedIndex = i
                                                          If lst.SelectedItem.ToString().StartsWith("\\") Then GoTo skiploops
                                                          If lst.SelectedItem.ToString().StartsWith(element.Name) Then
                                                              If lst.SelectedItem.ToString().Contains("Listener.Click") Then
                                                                  Dim lst2 As ListBox = New ListBox()
                                                                  lst2.Items.AddRange(lst.SelectedItem.ToString().Split("*"))
                                                                  lst2.SelectedIndex = 1
                                                                  Dim ss As String = lst2.SelectedItem.ToString()
                                                                  execute(ss)
                                                                  Exit Sub
                                                              End If
                                                          End If
skiploops:
                                                      Next
                                                      'Catch ex As Exception
                                                  '    throwexception(ex)
                                                  'End Try
                                              End Sub
                    AddHandler element.MouseMove, Sub(sender2, eventargs2)
                                                      Try
                                                          For i As Integer = 0 To lst.Items.Count - 1
                                                              lst.SelectedIndex = i
                                                              If lst.SelectedItem.ToString().StartsWith("\\") Then GoTo skiploops
                                                              If lst.SelectedItem.ToString().StartsWith(element.Name) Then
                                                                  If lst.SelectedItem.ToString().Contains("Listener.MouseMove") Then
                                                                      Dim lst2 As ListBox = New ListBox()
                                                                      lst2.Items.AddRange(lst.SelectedItem.ToString().Split("*"))
                                                                      lst2.SelectedIndex = 1
                                                                      Dim ss As String = lst2.SelectedItem.ToString()
                                                                      execute(ss)
                                                                      Exit Sub
                                                                  End If
                                                              End If
skiploops:
                                                          Next
                                                      Catch ex As Exception
                                                          throwexception(ex)
                                                      End Try
                                                  End Sub
                    AddHandler element.TextChanged, Sub(sender2, eventargs2)
                                                        Try
                                                            For i As Integer = 0 To lst.Items.Count - 1
                                                                lst.SelectedIndex = i
                                                                If lst.SelectedItem.ToString().StartsWith("\\") Then GoTo skiploops
                                                                If lst.SelectedItem.ToString().StartsWith(element.Name) Then
                                                                    If lst.SelectedItem.ToString().Contains("Listener.TextChanged") Then
                                                                        Dim lst2 As ListBox = New ListBox()
                                                                        lst2.Items.AddRange(lst.SelectedItem.ToString().Split("*"))
                                                                        lst2.SelectedIndex = 1
                                                                        Dim ss As String = lst2.SelectedItem.ToString()
                                                                        execute(ss)
                                                                        Exit Sub
                                                                    End If
                                                                End If
skiploops:
                                                            Next
                                                        Catch ex As Exception
                                                            throwexception(ex)
                                                        End Try
                                                    End Sub
                    AddHandler element.VisibleChanged, Sub(sender2, eventargs2)
                                                           Try
                                                               For i As Integer = 0 To lst.Items.Count - 1
                                                                   lst.SelectedIndex = i
                                                                   If lst.SelectedItem.ToString().StartsWith("\\") Then GoTo skiploops
                                                                   If lst.SelectedItem.ToString().StartsWith(element.Name) Then
                                                                       If lst.SelectedItem.ToString().Contains("Listener.VisibleChanged") Then
                                                                           Dim lst2 As ListBox = New ListBox()
                                                                           lst2.Items.AddRange(lst.SelectedItem.ToString().Split("*"))
                                                                           lst2.SelectedIndex = 1
                                                                           Dim ss As String = lst2.SelectedItem.ToString()
                                                                           execute(ss)
                                                                           Exit Sub
                                                                       End If
                                                                   End If
skiploops:
                                                               Next
                                                           Catch ex As Exception
                                                               throwexception(ex)
                                                           End Try
                                                       End Sub
                    AddHandler element.DoubleClick, Sub(sender2, eventargs2)
                                                        Try
                                                            For i As Integer = 0 To lst.Items.Count - 1
                                                                lst.SelectedIndex = i
                                                                If lst.SelectedItem.ToString().StartsWith("\\") Then GoTo skiploops
                                                                If lst.SelectedItem.ToString().StartsWith(element.Name) Then
                                                                    If lst.SelectedItem.ToString().Contains("Listener.DoubleClick") Then
                                                                        Dim lst2 As ListBox = New ListBox()
                                                                        lst2.Items.AddRange(lst.SelectedItem.ToString().Split("*"))
                                                                        lst2.SelectedIndex = 1
                                                                        Dim ss As String = lst2.SelectedItem.ToString()
                                                                        execute(ss)
                                                                        Exit Sub
                                                                    End If
                                                                End If
skiploops:
                                                            Next
                                                        Catch ex As Exception
                                                            throwexception(ex)
                                                        End Try
                                                    End Sub
                    AddHandler element.MouseDown, Sub(sender2, eventargs2)
                                                      Try
                                                          For i As Integer = 0 To lst.Items.Count - 1
                                                              lst.SelectedIndex = i
                                                              If lst.SelectedItem.ToString().StartsWith("\\") Then GoTo skiploops
                                                              If lst.SelectedItem.ToString().StartsWith(element.Name) Then
                                                                  If lst.SelectedItem.ToString().Contains("Listener.MouseDown") Then
                                                                      Dim lst2 As ListBox = New ListBox()
                                                                      lst2.Items.AddRange(lst.SelectedItem.ToString().Split("*"))
                                                                      lst2.SelectedIndex = 1
                                                                      Dim ss As String = lst2.SelectedItem.ToString()
                                                                      execute(ss)
                                                                      Exit Sub
                                                                  End If
                                                              End If
skiploops:
                                                          Next
                                                      Catch ex As Exception
                                                          throwexception(ex)
                                                      End Try
                                                  End Sub
                    AddHandler element.MouseUp, Sub(sender2, eventargs2)
                                                    Try
                                                        For i As Integer = 0 To lst.Items.Count - 1
                                                            lst.SelectedIndex = i
                                                            If lst.SelectedItem.ToString().StartsWith("\\") Then GoTo skiploops
                                                            If lst.SelectedItem.ToString().StartsWith(element.Name) Then
                                                                If lst.SelectedItem.ToString().Contains("Listener.MouseUp") Then
                                                                    Dim lst2 As ListBox = New ListBox()
                                                                    lst2.Items.AddRange(lst.SelectedItem.ToString().Split("*"))
                                                                    lst2.SelectedIndex = 1
                                                                    Dim ss As String = lst2.SelectedItem.ToString()
                                                                    execute(ss)
                                                                    Exit Sub
                                                                End If
                                                            End If
skiploops:
                                                        Next
                                                    Catch ex As Exception
                                                        throwexception(ex)
                                                    End Try
                                                End Sub
                End If
                If TypeOf element Is Label Then
                    AddHandler element.Click, Sub(sender2, eventargs2)
                                                  Try
                                                      For i As Integer = 0 To lst.Items.Count - 1
                                                          lst.SelectedIndex = i
                                                          If lst.SelectedItem.ToString().StartsWith("\\") Then GoTo skiploops
                                                          If lst.SelectedItem.ToString().StartsWith(element.Name) Then
                                                              If lst.SelectedItem.ToString().Contains("Listener.Click") Then
                                                                  Dim lst2 As ListBox = New ListBox()
                                                                  lst2.Items.AddRange(lst.SelectedItem.ToString().Split("*"))
                                                                  lst2.SelectedIndex = 1
                                                                  Dim ss As String = lst2.SelectedItem.ToString()
                                                                  execute(ss)
                                                                  Exit Sub
                                                              End If
                                                          End If
skiploops:
                                                      Next
                                                  Catch ex As Exception
                                                      throwexception(ex)
                                                  End Try
                                              End Sub
                    AddHandler element.VisibleChanged, Sub(sender2, eventargs2)
                                                           Try
                                                               For i As Integer = 0 To lst.Items.Count - 1
                                                                   lst.SelectedIndex = i
                                                                   If lst.SelectedItem.ToString().StartsWith("\\") Then GoTo skiploops
                                                                   If lst.SelectedItem.ToString().StartsWith(element.Name) Then
                                                                       If lst.SelectedItem.ToString().Contains("Listener.VisibleChanged") Then
                                                                           Dim lst2 As ListBox = New ListBox()
                                                                           lst2.Items.AddRange(lst.SelectedItem.ToString().Split("*"))
                                                                           lst2.SelectedIndex = 1
                                                                           Dim ss As String = lst2.SelectedItem.ToString()
                                                                           execute(ss)
                                                                           Exit Sub
                                                                       End If
                                                                   End If
skiploops:
                                                               Next
                                                           Catch ex As Exception
                                                               throwexception(ex)
                                                           End Try
                                                       End Sub
                    AddHandler element.MouseMove, Sub(sender2, eventargs2)
                                                      Try
                                                          For i As Integer = 0 To lst.Items.Count - 1
                                                              lst.SelectedIndex = i
                                                              If lst.SelectedItem.ToString().StartsWith("\\") Then GoTo skiploops
                                                              If lst.SelectedItem.ToString().StartsWith(element.Name) Then
                                                                  If lst.SelectedItem.ToString().Contains("Listener.MouseMove") Then
                                                                      Dim lst2 As ListBox = New ListBox()
                                                                      lst2.Items.AddRange(lst.SelectedItem.ToString().Split("*"))
                                                                      lst2.SelectedIndex = 1
                                                                      Dim ss As String = lst2.SelectedItem.ToString()
                                                                      execute(ss)
                                                                      Exit Sub
                                                                  End If
                                                              End If
skiploops:
                                                          Next
                                                      Catch ex As Exception
                                                          throwexception(ex)
                                                      End Try
                                                  End Sub
                End If
                If TypeOf element Is TextBox Then
                    AddHandler element.Click, Sub(sender2, eventargs2)
                                                  Try
                                                      For i As Integer = 0 To lst.Items.Count - 1
                                                          lst.SelectedIndex = i
                                                          If lst.SelectedItem.ToString().StartsWith("\\") Then GoTo skiploops
                                                          If lst.SelectedItem.ToString().StartsWith(element.Name) Then
                                                              If lst.SelectedItem.ToString().Contains("Listener.Click") Then
                                                                  Dim lst2 As ListBox = New ListBox()
                                                                  lst2.Items.AddRange(lst.SelectedItem.ToString().Split("*"))
                                                                  lst2.SelectedIndex = 1
                                                                  Dim ss As String = lst2.SelectedItem.ToString()
                                                                  execute(ss)
                                                                  Exit Sub
                                                              End If
                                                          End If
skiploops:
                                                      Next
                                                  Catch ex As Exception
                                                      throwexception(ex)
                                                  End Try
                                              End Sub
                    AddHandler element.MouseMove, Sub(sender2, eventargs2)
                                                      Try
                                                          For i As Integer = 0 To lst.Items.Count - 1
                                                              lst.SelectedIndex = i
                                                              If lst.SelectedItem.ToString().StartsWith("\\") Then GoTo skiploops
                                                              If lst.SelectedItem.ToString().StartsWith(element.Name) Then
                                                                  If lst.SelectedItem.ToString().Contains("Listener.MouseMove") Then
                                                                      Dim lst2 As ListBox = New ListBox()
                                                                      lst2.Items.AddRange(lst.SelectedItem.ToString().Split("*"))
                                                                      lst2.SelectedIndex = 1
                                                                      Dim ss As String = lst2.SelectedItem.ToString()
                                                                      execute(ss)
                                                                      Exit Sub
                                                                  End If
                                                              End If
skiploops:
                                                          Next
                                                      Catch ex As Exception
                                                          throwexception(ex)
                                                      End Try
                                                  End Sub
                End If
                AddHandler element.TextChanged, Sub(sender2, eventargs2)
                                                    Try
                                                        For i As Integer = 0 To lst.Items.Count - 1
                                                            lst.SelectedIndex = i
                                                            If lst.SelectedItem.ToString().StartsWith("\\") Then GoTo skiploops
                                                            If lst.SelectedItem.ToString().StartsWith(element.Name) Then
                                                                If lst.SelectedItem.ToString().Contains("Listener.TextChanged") Then
                                                                    Dim lst2 As ListBox = New ListBox()
                                                                    lst2.Items.AddRange(lst.SelectedItem.ToString().Split("*"))
                                                                    lst2.SelectedIndex = 1
                                                                    Dim ss As String = lst2.SelectedItem.ToString()
                                                                    execute(ss)
                                                                    Exit Sub
                                                                End If
                                                            End If
skiploops:
                                                        Next
                                                    Catch ex As Exception
                                                        throwexception(ex)
                                                    End Try
                                                End Sub
                AddHandler element.VisibleChanged, Sub(sender2, eventargs2)
                                                       Try
                                                           For i As Integer = 0 To lst.Items.Count - 1
                                                               lst.SelectedIndex = i
                                                               If lst.SelectedItem.ToString().StartsWith("\\") Then GoTo skiploops
                                                               If lst.SelectedItem.ToString().StartsWith(element.Name) Then
                                                                   If lst.SelectedItem.ToString().Contains("Listener.VisibleChanged") Then
                                                                       Dim lst2 As ListBox = New ListBox()
                                                                       lst2.Items.AddRange(lst.SelectedItem.ToString().Split("*"))
                                                                       lst2.SelectedIndex = 1
                                                                       Dim ss As String = lst2.SelectedItem.ToString()
                                                                       execute(ss)
                                                                       Exit Sub
                                                                   End If
                                                               End If
skiploops:
                                                           Next
                                                       Catch ex As Exception
                                                           throwexception(ex)
                                                       End Try
                                                   End Sub
                AddHandler element.MouseDown, Sub(sender2, eventargs2)
                                                  Try
                                                      For i As Integer = 0 To lst.Items.Count - 1
                                                          lst.SelectedIndex = i
                                                          If lst.SelectedItem.ToString().StartsWith("\\") Then GoTo skiploops
                                                          If lst.SelectedItem.ToString().StartsWith(element.Name) Then
                                                              If lst.SelectedItem.ToString().Contains("Listener.MouseDown") Then
                                                                  Dim lst2 As ListBox = New ListBox()
                                                                  lst2.Items.AddRange(lst.SelectedItem.ToString().Split("*"))
                                                                  lst2.SelectedIndex = 1
                                                                  Dim ss As String = lst2.SelectedItem.ToString()
                                                                  execute(ss)
                                                                  Exit Sub
                                                              End If
                                                          End If
skiploops:
                                                      Next
                                                  Catch ex As Exception
                                                      throwexception(ex)
                                                  End Try
                                              End Sub
                AddHandler element.MouseUp, Sub(sender2, eventargs2)
                                                Try
                                                    For i As Integer = 0 To lst.Items.Count - 1
                                                        lst.SelectedIndex = i
                                                        If lst.SelectedItem.ToString().StartsWith("\\") Then GoTo skiploops
                                                        If lst.SelectedItem.ToString().StartsWith(element.Name) Then
                                                            If lst.SelectedItem.ToString().Contains("Listener.MouseUp") Then
                                                                Dim lst2 As ListBox = New ListBox()
                                                                lst2.Items.AddRange(lst.SelectedItem.ToString().Split("*"))
                                                                lst2.SelectedIndex = 1
                                                                Dim ss As String = lst2.SelectedItem.ToString()
                                                                execute(ss)
                                                                Exit Sub
                                                            End If
                                                        End If
skiploops:
                                                    Next
                                                Catch ex As Exception
                                                    throwexception(ex)
                                                End Try
                                            End Sub
                If TypeOf element Is MenuStrip Then
                    AddHandler element.Click, Sub(sender2, eventargs2)
                                                  Try
                                                      For i As Integer = 0 To lst.Items.Count - 1
                                                          lst.SelectedIndex = i
                                                          If lst.SelectedItem.ToString().StartsWith("\\") Then GoTo skiploops
                                                          If lst.SelectedItem.ToString().StartsWith(element.Name) Then
                                                              If lst.SelectedItem.ToString().Contains("Listener.Click") Then
                                                                  Dim lst2 As ListBox = New ListBox()
                                                                  lst2.Items.AddRange(lst.SelectedItem.ToString().Split("*"))
                                                                  lst2.SelectedIndex = 1
                                                                  Dim ss As String = lst2.SelectedItem.ToString()
                                                                  execute(ss)
                                                                  Exit Sub
                                                              End If
                                                          End If
skiploops:
                                                      Next
                                                  Catch ex As Exception
                                                      throwexception(ex)
                                                  End Try
                                              End Sub
                    AddHandler element.MouseMove, Sub(sender2, eventargs2)
                                                      Try
                                                          For i As Integer = 0 To lst.Items.Count - 1
                                                              lst.SelectedIndex = i
                                                              If lst.SelectedItem.ToString().StartsWith("\\") Then GoTo skiploops
                                                              If lst.SelectedItem.ToString().StartsWith(element.Name) Then
                                                                  If lst.SelectedItem.ToString().Contains("Listener.MouseMove") Then
                                                                      Dim lst2 As ListBox = New ListBox()
                                                                      lst2.Items.AddRange(lst.SelectedItem.ToString().Split("*"))
                                                                      lst2.SelectedIndex = 1
                                                                      Dim ss As String = lst2.SelectedItem.ToString()
                                                                      execute(ss)
                                                                      Exit Sub
                                                                  End If
                                                              End If
skiploops:
                                                          Next
                                                      Catch ex As Exception
                                                          throwexception(ex)
                                                      End Try
                                                  End Sub
                End If
            Next
            'Catch ex As Exception
        '    throwexception(ex)
        'End Try
    End Sub

    Private Sub Custom_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible = True Then
            Form1.Setfont(Me, MainForm, Label3)
            MainForm.BackColor = Desktop.labelBg.BackColor
            MainForm.ForeColor = Desktop.labelFg.BackColor
            Label3.BackColor = MainForm.BackColor
            Label3.ForeColor = MainForm.ForeColor
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.BackColor = Desktop.appBg.BackColor
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.translucency(Me, composedwindow, True)
            Me.ForeColor = Desktop.appFg.BackColor
            Label5.BackColor = Me.BackColor
        End If
    End Sub
    Public Sub custombutton_click(sender As Object, e As EventArgs)

    End Sub

    Function execute(ByVal code As String)
        Try
            Dim lst As ListBox = New ListBox()
            Dim rnd As Random
            rnd = New Random()
            code = code.Replace("Random()", rnd.Next(1000))
            lst.Items.AddRange(code.Split(";"))
            Dim s As String = ""
            Dim i As Integer = 0

            While i < lst.Items.Count
                lst.SelectedIndex = i
                s = lst.SelectedItem.ToString()
                If s.StartsWith("If ") Then
                    s = s.Replace("If ", "")
                    Dim tool As String = "all"
                    If s.StartsWith("none") Then tool = "none"
                    If s.StartsWith("all") Then tool = "all"
                    If s.StartsWith("some") Then tool = "some"
                    s = s.Replace(tool, "")
                    If s.StartsWith("(") Then
                        Dim l2 As ListBox = New ListBox()
                        l2.Items.AddRange(s.Split("("))
                    Else

                    End If
                    Dim lb As ListBox = New ListBox()
                    If s.Contains("==") Then
                        lb.Items.AddRange(s.Split("=="))
                        lb.SelectedIndex = 0
                        Dim condition1 As String = lb.SelectedItem.ToString().Replace("If ", "")
                        lb.SelectedIndex = 2
                        Dim condition2 As String = lb.SelectedItem.ToString()
                        If getval(condition1, condition2) = False Then
                            Do While Not lst.Items(i).ToString() = "End If"
                                i += 1
                                lst.SelectedIndex = i
                            Loop
                        End If
                    ElseIf s.Contains("!=") Then
                        lb.Items.AddRange(s.Split("!="))
                        lb.SelectedIndex = 0
                        Dim condition1 As String = lb.SelectedItem.ToString().Replace("If ", "")
                        lb.SelectedIndex = 1
                        Dim condition2 As String = lb.SelectedItem.ToString().Substring(1)
                        If getval(condition1, condition2) = True Then
                            Do While Not lst.Items(i).ToString() = "End If"
                                i += 1
                                lst.SelectedIndex = i
                            Loop
                        End If
                    ElseIf s.Contains(">") Then
                        lb.Items.AddRange(s.Split(">"))
                        Dim condition1 As String = lb.Items(0).ToString().Replace("If ", "")
                        Dim condition2 As String = lb.Items(1).ToString()
                        If compval(condition1, condition2) = True Then
                            Do While Not lst.Items(i).ToString() = "End If"
                                i += 1
                            Loop
                            i -= 1
                        End If
                    ElseIf s.Contains("<") Then
                        lb.Items.AddRange(s.Split("<"))
                        Dim condition1 As String = lb.Items(1).ToString()
                        Dim condition2 As String = lb.Items(0).ToString().Replace("If ", "")
                        If compval(condition1, condition2) = True Then
                            Do While Not lst.Items(i).ToString() = "End If"
                                i += 1
                            Loop
                            i -= 1
                        End If
                    End If
                End If
                If s.Contains("Math=") Then
                    Dim x As Integer = InStr(s, "_")
                    Dim sbef As String = s.Substring(0, x - 1)
                    Dim y As Integer = InStr(s, "Math=")
                    Dim cutout As String = "Math="
                    Dim saf As String = sbef.Substring(y + cutout.Length - 1)
                    Dim res = New DataTable().Compute(saf, Nothing)
                    Dim tadah As String = res.ToString()
                    s = s.Replace("Math=", "")
                    s = s.Replace("_", "")
                    s = s.Replace(saf, tadah)
                End If
                If s.Contains(".GetValue_") = True Then
                    Dim x As Integer = InStr(s, ".GetValue_")
                    Dim sbef As String = s.Substring(0, x - 1)
                    Dim y As Integer = InStr(s, "~")
                    Dim cutout As String = "~"
                    Dim saf As String = sbef.Substring(y + cutout.Length - 1)
                    Dim wah As String = saf
                    For Each element As Control In Me.Controls
                        If element.Name = saf Then
                            wah = element.Text
                        End If
                    Next
                    s = s.Replace("~", "")
                    s = s.Replace(".GetValue_", "")
                    s = s.Replace(saf, wah)
                End If
                If s.StartsWith("Message") Then
                    s = s.Replace("Message", "")
                    s = s.Replace("(", "")
                    s = s.Replace(")", "")
                    Dim args As ListBox = New ListBox()
                    args.Items.AddRange(s.Split(","))
                    MessageDialog.messagetext = ""
                    MessageDialog.messagetitle = ""
                    MessageDialog.messageicon = ""
                    MessageDialog.messagetype = ""
                    For j As Integer = 0 To args.Items.Count - 1
                        args.SelectedIndex = j
                        If j = 0 Then MessageDialog.messagetext = args.SelectedItem.ToString()
                        If j = 1 Then MessageDialog.messagetitle = args.SelectedItem.ToString()
                        If j = 2 Then MessageDialog.messageicon = args.SelectedItem.ToString()
                        If j = 3 Then MessageDialog.messagetype = args.SelectedItem.ToString()
                    Next
                    MessageDialog.ShowDialog()
                ElseIf s = "Exit()" Then
                    ExitToolStripMenuItem.PerformClick()
                ElseIf s = "Stop()" Then
                    Exit While
                ElseIf s.Contains(".Erase") Then
                    Dim lb As ListBox = New ListBox()
                    lb.Items.AddRange(s.Split("."))
                    lb.SelectedIndex = 0
                    Dim target As String = lb.SelectedItem.ToString()
                    For Each element As Control In Me.Controls
                        If element.Name = target Then
                            element.Dispose()
                            Me.Controls.Remove(element)
                        End If
                    Next
                ElseIf s.Contains(".Visible") Then
                    If s.Contains("False") Then
                        Dim lb As ListBox = New ListBox()
                        lb.Items.AddRange(s.Split("."))
                        lb.SelectedIndex = 0
                        Dim target As String = lb.SelectedItem.ToString()
                        For Each element As Control In Me.Controls
                            If element.Name = target Then
                                element.Visible = False
                            End If
                        Next
                    ElseIf s.Contains("True") Then
                        Dim lb As ListBox = New ListBox()
                        lb.Items.AddRange(s.Split("."))
                        lb.SelectedIndex = 0
                        Dim target As String = lb.SelectedItem.ToString()
                        For Each element As Control In Me.Controls
                            If element.Name = target Then
                                element.Visible = True
                            End If
                        Next
                    End If
                ElseIf s.Contains(".Location") Then
                    Dim lb As ListBox = New ListBox()
                    lb.Items.AddRange(s.Split("="))
                    lb.SelectedIndex = 0
                    Dim c As String = lb.SelectedItem.ToString().Replace(".Location", "")
                    lb.SelectedIndex = 1
                    Dim sa As String = lb.SelectedItem.ToString()
                    Dim oh As ListBox = New ListBox()
                    oh.Items.AddRange(sa.Split("x"))
                    oh.SelectedIndex = 0
                    Dim a As Integer = Convert.ToInt32(oh.SelectedItem.ToString())
                    oh.SelectedIndex = 1
                    Dim b As Integer = Convert.ToInt32(oh.SelectedItem.ToString())
                    For Each element As Control In Me.Controls
                        If element.Name = c Then
                            element.Location = New Point(a, b)
                        End If
                    Next
                ElseIf s.Contains(".Value") And Not s.Contains("<") And Not s.Contains("==") And Not s.Contains(">") Then
                    Dim lb As ListBox = New ListBox()
                    lb.Items.AddRange(s.Split("="))
                    lb.SelectedIndex = 0
                    Dim c As String = lb.SelectedItem.ToString().Replace(".Value", "")
                    lb.SelectedIndex = 1
                    Dim sa As String = lb.SelectedItem.ToString()
                    For Each element As Control In Me.Controls
                        If element.Name = c Then
                            element.Text = sa
                        End If
                    Next
                ElseIf s.Contains(".BG") Then
                    Dim lb As ListBox = New ListBox()
                    lb.Items.AddRange(s.Split("="))
                    lb.SelectedIndex = 0
                    Dim c As String = lb.SelectedItem.ToString().Replace(".BG", "")
                    lb.SelectedIndex = 1
                    Dim sa As String = lb.SelectedItem.ToString()
                    Dim oh As ListBox = New ListBox()
                    oh.Items.AddRange(sa.Split(","))
                    oh.SelectedIndex = 0
                    Dim a As Integer = Convert.ToInt32(oh.SelectedItem.ToString())
                    oh.SelectedIndex = 1
                    Dim b As Integer = Convert.ToInt32(oh.SelectedItem.ToString())
                    oh.SelectedIndex = 2
                    Dim d As Integer = Convert.ToInt32(oh.SelectedItem.ToString())
                    For Each element As Control In Me.Controls
                        If element.Name = c Then
                            element.BackColor = Color.FromArgb(a, b, d)
                        End If
                    Next
                ElseIf s.Contains(".FG") Then
                    Dim lb As ListBox = New ListBox()
                    lb.Items.AddRange(s.Split("="))
                    lb.SelectedIndex = 0
                    Dim c As String = lb.SelectedItem.ToString().Replace(".FG", "")
                    lb.SelectedIndex = 1
                    Dim sa As String = lb.SelectedItem.ToString()
                    Dim oh As ListBox = New ListBox()
                    oh.Items.AddRange(sa.Split(","))
                    oh.SelectedIndex = 0
                    Dim a As Integer = Convert.ToInt32(oh.SelectedItem.ToString())
                    oh.SelectedIndex = 1
                    Dim b As Integer = Convert.ToInt32(oh.SelectedItem.ToString())
                    oh.SelectedIndex = 2
                    Dim d As Integer = Convert.ToInt32(oh.SelectedItem.ToString())
                    For Each element As Control In Me.Controls
                        If element.Name = c Then
                            element.ForeColor = Color.FromArgb(a, b, d)
                        End If
                    Next
                End If
                i += 1
            End While
            Return s
        Catch ex As Exception
            throwexception(ex)
        End Try

    End Function

    Function getval(ByVal condition As String, ByVal scondition As String)
        Dim result As Boolean = False
        If condition.Contains(".Value") Then
            Dim lb As ListBox = New ListBox()
            lb.Items.AddRange(condition.Split("."))
            lb.SelectedIndex = 0
            Dim thing As String = lb.SelectedItem.ToString()
            For Each element As Control In Me.Controls
                If element.Name = thing Then
                    condition = element.Text
                End If
            Next
        Else
            condition = condition
        End If
        If scondition.Contains(".Value") Then
            Dim lb As ListBox = New ListBox()
            lb.Items.AddRange(scondition.Split("."))
            lb.SelectedIndex = 0
            Dim thing As String = lb.SelectedItem.ToString()
            For Each element As Control In Me.Controls
                If element.Name = thing Then
                    scondition = element.Text
                End If
            Next
        Else
            scondition = scondition
        End If
        If condition = scondition Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function
    Function compval(ByVal condition As String, ByVal scondition As String)
        Dim result As Boolean = False
        If condition.Contains(".Value") Then
            Dim lb As ListBox = New ListBox()
            lb.Items.AddRange(condition.Split("."))
            lb.SelectedIndex = 0
            Dim thing As String = lb.SelectedItem.ToString()
            For Each element As Control In Me.Controls
                If element.Name = thing Then
                    condition = element.Text
                End If
            Next
        Else
            condition = condition
        End If
        If scondition.Contains(".Value") Then
            Dim lb As ListBox = New ListBox()
            lb.Items.AddRange(scondition.Split("."))
            lb.SelectedIndex = 0
            Dim thing As String = lb.SelectedItem.ToString()
            For Each element As Control In Me.Controls
                If element.Name = thing Then
                    scondition = element.Text
                End If
            Next
        Else
            scondition = scondition
        End If

        If Integer.Parse(condition) > Integer.Parse(scondition) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function
    Sub throwexception(ByVal ex As Exception)
        ESOD.BackColor = Color.DodgerBlue
        ESOD.ForeColor = Color.White
        ESOD.Label5.Text = "Program error. Details:" & vbNewLine & ex.Message
        ESOD.Label7.Text = "PES: Custom program error"
        If voide.Visible = True Then
            ESOD.BackColor = Color.Green
            ESOD.ForeColor = Color.White
            ESOD.Label5.Text = "Program error. Details:" & vbNewLine & ex.Message
            ESOD.Label7.Text = "DPES: Debugging custom program error"
        End If
        ESOD.ShowDialog()
    End Sub

    Private Sub MainForm_BackColorChanged(sender As Object, e As EventArgs) Handles MainForm.BackColorChanged
        Label3.BackColor = MainForm.BackColor
        Label3.ForeColor = MainForm.ForeColor
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Hide()
        composedwindow.Hide()
    End Sub
End Class