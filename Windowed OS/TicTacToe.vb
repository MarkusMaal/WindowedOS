Public Class TicTacToe
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim random As String = 1
    Dim dev As Boolean = False
    Dim rap As Boolean = False
    Dim composedwindow As Form = New Form()
    Private Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr

    Public Sub CheckIfComputerWins()
        If Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O" _
        Or Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O" _
        Or Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O" _
        Or Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O" _
        Or Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O" _
        Or Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O" _
        Or Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O" _
        Or Button7.Text = "O" And Button5.Text = "O" And Button3.Text = "O" Then
            MessageDialog.messagetitle = "Tic Tac Toe game"
            MessageDialog.messagetext = "Computer won"
            MessageDialog.messageicon = "Info"
            'MessageDialog.ff = Me
            'MessageDialog.sf = composedwindow
            MessageDialog.ShowDialog()
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            Exit Sub
        ElseIf Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" _
        Or Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" _
        Or Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" _
        Or Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X" _
        Or Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X" _
        Or Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X" _
        Or Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" _
        Or Button7.Text = "X" And Button5.Text = "X" And Button3.Text = "X" Then
            MessageDialog.messagetitle = "Tic Tac Toe game"
            MessageDialog.messagetext = "You win"
            MessageDialog.messageicon = "Info"
            'MessageDialog.ff = Me
            'MessageDialog.sf = composedwindow
            MessageDialog.ShowDialog()
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            Exit Sub
        End If
        If Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then
            MessageDialog.messagetitle = "Tic Tac Toe game"
            MessageDialog.messagetext = "It's a tie"
            MessageDialog.messageicon = "Info"
            'MessageDialog.ff = Me
            'MessageDialog.sf = composedwindow
            MessageDialog.ShowDialog()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles Button1.Click
        sender.Text = "X"
        sender.Enabled = False
        CheckIfComputerWins()
        If Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then Exit Sub
        Dim rnd As Random = New Random()
        Dim rv As Integer
        rv = rnd.Next(5)
        PlaceOCPU(rv)
        disablecomputerbuttons()
fninow:
        CheckIfComputerWins()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles Button2.Click
        sender.Text = "X"
        sender.Enabled = False
        CheckIfComputerWins()
        If Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then Exit Sub
        Dim rnd As Random = New Random()
        Dim rv As Integer
        rv = rnd.Next(5)
        PlaceOCPU(rv)
        disablecomputerbuttons()
fninow:
        CheckIfComputerWins()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles Button3.Click
        sender.Text = "X"
        sender.Enabled = False
        CheckIfComputerWins()
        If Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then Exit Sub
        Dim rnd As Random = New Random()
        Dim rv As Integer
        rv = rnd.Next(5)
        PlaceOCPU(rv)
        disablecomputerbuttons()
fninow:
        CheckIfComputerWins()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles Button4.Click
        sender.Text = "X"
        sender.Enabled = False
        ''Label1.Text = sender.name
        ''Label1.Text = 'Label1.Text.Replace("Button", "")
        CheckIfComputerWins()
        If Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then Exit Sub
        Dim rnd As Random = New Random()
        Dim rv As Integer
        rv = rnd.Next(5)
        PlaceOCPU(rv)
        disablecomputerbuttons()
fninow:
        'Label2.Text = random
        CheckIfComputerWins()
        'Label1.Text = 1
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles Button5.Click
        sender.Text = "X"
        sender.Enabled = False
        'Label1.Text = sender.name
        'Label1.Text = 'Label1.Text.Replace("Button", "")
        CheckIfComputerWins()
        If Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then Exit Sub
        Dim rnd As Random = New Random()
        Dim rv As Integer
        rv = rnd.Next(5)
        PlaceOCPU(rv)
        disablecomputerbuttons()
fninow:
        'Label2.Text = random
        CheckIfComputerWins()
        'Label1.Text = 1
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles Button6.Click
        sender.Text = "X"
        sender.Enabled = False
        'Label1.Text = sender.name
        'Label1.Text = 'Label1.Text.Replace("Button", "")
        CheckIfComputerWins()
        If Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then Exit Sub
        Dim rnd As Random = New Random()
        Dim rv As Integer
        rv = rnd.Next(5)
        PlaceOCPU(rv)
        disablecomputerbuttons()
fninow:
        'Label2.Text = random
        CheckIfComputerWins()
        'Label1.Text = 1
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles Button7.Click
        sender.Text = "X"
        sender.Enabled = False
        'Label1.Text = sender.name
        'Label1.Text = 'Label1.Text.Replace("Button", "")
        CheckIfComputerWins()
        If Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then Exit Sub
        Dim rnd As Random = New Random()
        Dim rv As Integer
        rv = rnd.Next(5)
        PlaceOCPU(rv)
        disablecomputerbuttons()
fninow:
        'Label2.Text = random
        CheckIfComputerWins()
        'Label1.Text = 1
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles Button8.Click
        sender.Text = "X"
        sender.Enabled = False
        'Label1.Text = sender.name
        'Label1.Text = 'Label1.Text.Replace("Button", "")
        CheckIfComputerWins()
        If Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then Exit Sub
        Dim rnd As Random = New Random()
        Dim rv As Integer
        rv = rnd.Next(5)
        PlaceOCPU(rv)
        disablecomputerbuttons()
fninow:
        'Label2.Text = random
        CheckIfComputerWins()
        'Label1.Text = 1
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles Button9.Click
        sender.Text = "X"
        sender.Enabled = False
        'Label1.Text = sender.name
        'Label1.Text = 'Label1.Text.Replace("Button", "")
        CheckIfComputerWins()
        If Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then Exit Sub
        Dim rnd As Random = New Random()
        Dim rv As Integer
        rv = rnd.Next(5)
        PlaceOCPU(rv)
        disablecomputerbuttons()
fninow:
        'Label2.Text = random
        CheckIfComputerWins()
        'Label1.Text = 1
    End Sub

    Sub disablecomputerbuttons()
        If Button1.Text = "O" Then Button1.Enabled = False
        If Button2.Text = "O" Then Button2.Enabled = False
        If Button3.Text = "O" Then Button3.Enabled = False
        If Button4.Text = "O" Then Button4.Enabled = False
        If Button5.Text = "O" Then Button5.Enabled = False
        If Button6.Text = "O" Then Button6.Enabled = False
        If Button7.Text = "O" Then Button7.Enabled = False
        If Button8.Text = "O" Then Button8.Enabled = False
        If Button9.Text = "O" Then Button9.Enabled = False
    End Sub

    Private Sub PlaceOCPU(ByVal randomval As Integer)
        ' first protect will decrease difficulty
        'check opportunities to win
        If Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "" Then
            Button8.Text = "O"
            Exit Sub
        ElseIf Button2.Text = "" And Button5.Text = "O" And Button8.Text = "O" Then
            Button2.Text = "O"
            Exit Sub
        ElseIf Button2.Text = "O" And Button5.Text = "" And Button8.Text = "O" Then
            Button5.Text = "O"
            Exit Sub
        ElseIf Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "" Then
            Button9.Text = "O"
            Exit Sub
        ElseIf Button1.Text = "" And Button5.Text = "O" And Button9.Text = "O" Then
            Button1.Text = "O"
            Exit Sub
        ElseIf Button1.Text = "O" And Button5.Text = "" And Button9.Text = "O" Then
            Button5.Text = "O"
            Exit Sub
        ElseIf Button3.Text = "O" And Button5.Text = "" And Button7.Text = "O" Then
            Button5.Text = "O"
            Exit Sub
        ElseIf Button3.Text = "" And Button5.Text = "O" And Button7.Text = "O" Then
            Button3.Text = "O"
            Exit Sub
        ElseIf Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "" Then
            Button7.Text = "O"
            Exit Sub
        ElseIf Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "" Then
            Button7.Text = "O"
            Exit Sub
        ElseIf Button1.Text = "O" And Button4.Text = "" And Button7.Text = "O" Then
            Button4.Text = "O"
            Exit Sub
        ElseIf Button1.Text = "" And Button4.Text = "O" And Button7.Text = "O" Then
            Button1.Text = "O"
            Exit Sub
        ElseIf Button3.Text = "" And Button6.Text = "O" And Button9.Text = "O" Then
            Button3.Text = "O"
            Exit Sub
        ElseIf Button3.Text = "O" And Button6.Text = "" And Button9.Text = "O" Then
            Button6.Text = "O"
            Exit Sub
        ElseIf Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "" Then
            Button9.Text = "O"
            Exit Sub
        ElseIf Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "" Then
            Button3.Text = "O"
            Exit Sub
        ElseIf Button1.Text = "" And Button2.Text = "O" And Button3.Text = "O" Then
            Button1.Text = "O"
            Exit Sub
        ElseIf Button1.Text = "O" And Button2.Text = "" And Button3.Text = "O" Then
            Button2.Text = "O"
            Exit Sub
        ElseIf Button4.Text = "O" And Button5.Text = "" And Button6.Text = "O" Then
            Button5.Text = "O"
            Exit Sub
        ElseIf Button4.Text = "" And Button5.Text = "O" And Button6.Text = "O" Then
            Button4.Text = "O"
            Exit Sub
        ElseIf Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "" Then
            Button6.Text = "O"
            Exit Sub
        ElseIf Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "" Then
            Button9.Text = "O"
            Exit Sub
        ElseIf Button7.Text = "" And Button8.Text = "O" And Button9.Text = "O" Then
            Button7.Text = "O"
            Exit Sub
        ElseIf Button7.Text = "O" And Button8.Text = "" And Button9.Text = "O" Then
            Button8.Text = "O"
            Exit Sub
            'check last chance to not lose
        ElseIf Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "" Then
            Button8.Text = "O"
            Exit Sub
        ElseIf Button2.Text = "" And Button5.Text = "X" And Button8.Text = "X" Then
            Button2.Text = "O"
            Exit Sub
        ElseIf Button2.Text = "X" And Button5.Text = "" And Button8.Text = "X" Then
            Button5.Text = "O"
            Exit Sub
        ElseIf Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "" Then
            Button9.Text = "O"
            Exit Sub
        ElseIf Button1.Text = "" And Button5.Text = "X" And Button9.Text = "X" Then
            Button1.Text = "O"
            Exit Sub
        ElseIf Button1.Text = "X" And Button5.Text = "" And Button9.Text = "X" Then
            Button5.Text = "O"
            Exit Sub
        ElseIf Button3.Text = "X" And Button5.Text = "" And Button7.Text = "X" Then
            Button5.Text = "O"
            Exit Sub
        ElseIf Button3.Text = "" And Button5.Text = "X" And Button7.Text = "X" Then
            Button3.Text = "O"
            Exit Sub
        ElseIf Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "" Then
            Button7.Text = "O"
            Exit Sub
        ElseIf Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "" Then
            Button7.Text = "O"
            Exit Sub
        ElseIf Button1.Text = "X" And Button4.Text = "" And Button7.Text = "X" Then
            Button4.Text = "O"
            Exit Sub
        ElseIf Button1.Text = "" And Button4.Text = "X" And Button7.Text = "X" Then
            Button1.Text = "O"
            Exit Sub
        ElseIf Button3.Text = "" And Button6.Text = "X" And Button9.Text = "X" Then
            Button3.Text = "O"
            Exit Sub
        ElseIf Button3.Text = "X" And Button6.Text = "" And Button9.Text = "X" Then
            Button6.Text = "O"
            Exit Sub
        ElseIf Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "" Then
            Button9.Text = "O"
            Exit Sub
        ElseIf Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "" Then
            Button3.Text = "O"
            Exit Sub
        ElseIf Button1.Text = "" And Button2.Text = "X" And Button3.Text = "X" Then
            Button1.Text = "O"
            Exit Sub
        ElseIf Button1.Text = "X" And Button2.Text = "" And Button3.Text = "X" Then
            Button2.Text = "O"
            Exit Sub
        ElseIf Button4.Text = "X" And Button5.Text = "" And Button6.Text = "X" Then
            Button5.Text = "O"
            Exit Sub
        ElseIf Button4.Text = "" And Button5.Text = "X" And Button6.Text = "X" Then
            Button4.Text = "O"
            Exit Sub
        ElseIf Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "" Then
            Button6.Text = "O"
            Exit Sub
        ElseIf Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "" Then
            Button9.Text = "O"
            Exit Sub
        ElseIf Button7.Text = "" And Button8.Text = "X" And Button9.Text = "X" Then
            Button7.Text = "O"
            Exit Sub
        ElseIf Button7.Text = "X" And Button8.Text = "" And Button9.Text = "X" Then
            Button8.Text = "O"
            Exit Sub
        End If
        'fixing a glitch
        If Button5.Text = "X" And Button3.Text = "X" And Button1.Text = "" Then
            Button1.Text = "O"
            Exit Sub
        End If
        'making sure to move with first player move
        If Button1.Text = "X" Then
            If Button2.Text = "" Then
                If Button4.Text = "" Then
                    If Button5.Text = "" Then
                        Button5.Text = "O"
                        Exit Sub
                    Else
                        Button4.Text = "O"
                        Exit Sub
                    End If
                Else
                    Button2.Text = "O"
                    Exit Sub
                End If
            End If
        End If
        If Button2.Text = "X" Then
            If Button1.Text = "" Then
                If Button3.Text = "" Then
                    If Button5.Text = "" Then
                        Button5.Text = "O"
                        Exit Sub
                    Else
                        Button3.Text = "O"
                        Exit Sub
                    End If
                Else
                    Button1.Text = "O"
                    Exit Sub
                End If
            End If
        End If
        If Button3.Text = "X" Then
            If Button2.Text = "" Then
                If Button6.Text = "" Then
                    If Button5.Text = "" Then
                        Button5.Text = "O"
                        Exit Sub
                    Else
                        Button6.Text = "O"
                        Exit Sub
                    End If
                Else
                    Button2.Text = "O"
                    Exit Sub
                End If
            End If
        End If
        If Button4.Text = "X" Then
            If Button1.Text = "" Then
                If Button7.Text = "" Then
                    If Button5.Text = "" Then
                        Button5.Text = "O"
                        Exit Sub
                    Else
                        Button7.Text = "O"
                        Exit Sub
                    End If
                Else
                    Button1.Text = "O"
                    Exit Sub
                End If
            End If
        End If
        If Button5.Text = "X" Then
            If Button2.Text = "" Then
                If Button4.Text = "" Then
                    If Button6.Text = "" Then
                        Button6.Text = "O"
                        Exit Sub
                    Else
                        Button4.Text = "O"
                        Exit Sub
                    End If
                Else
                    Button2.Text = "O"
                    Exit Sub
                End If
            End If
        End If
        If Button6.Text = "X" Then
            If Button5.Text = "" Then
                If Button4.Text = "" Then
                    If Button6.Text = "" Then
                        Button6.Text = "O"
                        Exit Sub
                    Else
                        Button4.Text = "O"
                        Exit Sub
                    End If
                Else
                    Button5.Text = "O"
                    Exit Sub
                End If
            End If
        End If
        If Button7.Text = "X" Then
            If Button4.Text = "" Then
                If Button8.Text = "" Then
                    If Button5.Text = "" Then
                        Button5.Text = "O"
                        Exit Sub
                    Else
                        Button8.Text = "O"
                        Exit Sub
                    End If
                Else
                    Button4.Text = "O"
                    Exit Sub
                End If
            End If
        End If
        If Button8.Text = "X" Then
            If Button9.Text = "" Then
                If Button7.Text = "" Then
                    If Button5.Text = "" Then
                        Button5.Text = "O"
                        Exit Sub
                    Else
                        Button7.Text = "O"
                        Exit Sub
                    End If
                Else
                    Button9.Text = "O"
                    Exit Sub
                End If
            End If
        End If
        If Button9.Text = "X" Then
            If Button8.Text = "" Then
                If Button6.Text = "" Then
                    If Button5.Text = "" Then
                        Button5.Text = "O"
                        Exit Sub
                    Else
                        Button6.Text = "O"
                        Exit Sub
                    End If
                Else
                    Button8.Text = "O"
                    Exit Sub
                End If
            End If
        End If
        'if X placed there, then place O there (8 possibilities)
        If Button5.Text = "X" And Button2.Text = "" And Button4.Text = "" And Button6.Text = "" And Button8.Text = "" Then
            If randomval = 1 Then
                Button2.Text = "O"
            ElseIf randomval = 2 Then
                Button4.Text = "O"
            ElseIf randomval = 3 Then
                Button6.Text = "O"
            ElseIf randomval >= 4 Then
                Button8.Text = "O"
            Else
                GoTo forceplace
            End If
            Exit Sub
        ElseIf Button5.Text = "X" And Button2.Text = "" And Button4.Text = "" And Button6.Text = "" Then
            If randomval = 1 Then
                Button2.Text = "O"
            ElseIf randomval = 2 Then
                Button4.Text = "O"
            ElseIf randomval >= 3 Then
                Button6.Text = "O"
            Else
                GoTo forceplace
            End If
            Exit Sub
        ElseIf Button1.Text = "X" And Button2.Text = "" And Button4.Text = "" And Button5.Text = "" Then
            If randomval = 1 Then
                Button2.Text = "O"
            ElseIf randomval = 2 Then
                Button4.Text = "O"
            ElseIf randomval >= 3 Then
                Button5.Text = "O"
            Else
                GoTo forceplace
            End If
            Exit Sub
        ElseIf Button2.Text = "X" And Button1.Text = "" And Button3.Text = "" And Button5.Text = "" Then
            If randomval = 1 Then
                Button1.Text = "O"
            ElseIf randomval = 2 Then
                Button3.Text = "O"
            ElseIf randomval >= 3 Then
                Button5.Text = "O"
            Else
                GoTo forceplace
            End If
            Exit Sub
        ElseIf Button3.Text = "X" And Button2.Text = "" And Button5.Text = "" And Button6.Text = "" Then
            If randomval = 1 Then
                Button2.Text = "O"
            ElseIf randomval = 2 Then
                Button5.Text = "O"
            ElseIf randomval >= 3 Then
                Button6.Text = "O"
            Else
                GoTo forceplace
            End If
            Exit Sub
        ElseIf Button4.Text = "X" And Button1.Text = "" And Button5.Text = "" And Button7.Text = "" Then
            If randomval = 1 Then
                Button1.Text = "O"
            ElseIf randomval = 2 Then
                Button5.Text = "O"
            ElseIf randomval >= 3 Then
                Button7.Text = "O"
            Else
                GoTo forceplace
            End If
            Exit Sub
        ElseIf Button6.Text = "X" And Button5.Text = "" And Button3.Text = "" And Button9.Text = "" Then
            If randomval = 1 Then
                Button5.Text = "O"
            ElseIf randomval = 2 Then
                Button3.Text = "O"
            ElseIf randomval >= 3 Then
                Button9.Text = "O"
            Else
                GoTo forceplace
            End If
            Exit Sub
        ElseIf Button7.Text = "X" And Button5.Text = "" And Button4.Text = "" And Button8.Text = "" Then
            If randomval = 1 Then
                Button8.Text = "O"
            ElseIf randomval = 2 Then
                Button4.Text = "O"
            ElseIf randomval >= 3 Then
                Button5.Text = "O"
            Else
                GoTo forceplace
            End If
            Exit Sub
        ElseIf Button8.Text = "X" And Button5.Text = "" And Button7.Text = "" And Button9.Text = "" Then
            If randomval = 1 Then
                Button5.Text = "O"
            ElseIf randomval = 2 Then
                Button7.Text = "O"
            ElseIf randomval >= 3 Then
                Button9.Text = "O"
            Else
                GoTo forceplace
            End If
            Exit Sub
        ElseIf Button8.Text = "X" And Button7.Text = "" And Button9.Text = "" Then
            If randomval = 1 Then
                Button7.Text = "O"
            ElseIf randomval >= 2 Then
                Button9.Text = "O"
            Else
                GoTo forceplace
            End If
            Exit Sub
        ElseIf Button9.Text = "X" And Button6.Text = "" And Button8.Text = "" And Button5.Text = "" Then
            If randomval = 1 Then
                Button6.Text = "O"
            ElseIf randomval = 2 Then
                Button8.Text = "O"
            ElseIf randomval >= 3 Then
                Button5.Text = "O"
            Else
                GoTo forceplace
            End If
            Exit Sub
            'trying to defend
        ElseIf Button1.Text = "X" And Button2.Text = "" Then
            Button2.Text = "O"
            Exit Sub
        ElseIf Button1.Text = "X" And Button4.Text = "" Then
            Button4.Text = "O"
            Exit Sub
        ElseIf Button1.Text = "X" And Button5.Text = "" Then
            Button4.Text = "O"
            Exit Sub
        ElseIf Button2.Text = "X" And Button1.Text = "" Then
            Button1.Text = "O"
            Exit Sub
        ElseIf Button2.Text = "X" And Button3.Text = "" Then
            Button3.Text = "O"
            Exit Sub
        ElseIf Button2.Text = "X" And Button5.Text = "" Then
            Button5.Text = "O"
            Exit Sub
        ElseIf Button3.Text = "X" And Button2.Text = "" Then
            Button2.Text = "O"
            Exit Sub
        ElseIf Button3.Text = "X" And Button5.Text = "" Then
            Button5.Text = "O"
            Exit Sub
        ElseIf Button3.Text = "X" And Button6.Text = "" Then
            Button6.Text = "O"
            Exit Sub
        ElseIf Button4.Text = "X" And Button5.Text = "" Then
            Button5.Text = "O"
            Exit Sub
        ElseIf Button4.Text = "X" And Button1.Text = "" Then
            Button1.Text = "O"
            Exit Sub
        ElseIf Button4.Text = "X" And Button7.Text = "" Then
            Button7.Text = "O"
            Exit Sub
        ElseIf Button5.Text = "X" And Button2.Text = "" Then
            Button2.Text = "O"
            Exit Sub
        ElseIf Button5.Text = "X" And Button4.Text = "" Then
            Button4.Text = "O"
            Exit Sub
        ElseIf Button5.Text = "X" And Button6.Text = "" Then
            Button6.Text = "O"
            Exit Sub
        ElseIf Button5.Text = "X" And Button8.Text = "" Then
            Button8.Text = "O"
            Exit Sub
        ElseIf Button6.Text = "X" And Button5.Text = "" Then
            Button5.Text = "O"
            Exit Sub
        ElseIf Button6.Text = "X" And Button3.Text = "" Then
            Button3.Text = "O"
            Exit Sub
        ElseIf Button6.Text = "X" And Button9.Text = "" Then
            Button9.Text = "O"
            Exit Sub
        ElseIf Button7.Text = "X" And Button8.Text = "" Then
            Button8.Text = "O"
            Exit Sub
        ElseIf Button7.Text = "X" And Button4.Text = "" Then
            Button4.Text = "O"
            Exit Sub
        ElseIf Button7.Text = "X" And Button5.Text = "" Then
            Button5.Text = "O"
            Exit Sub
        ElseIf Button8.Text = "X" And Button5.Text = "" Then
            Button5.Text = "O"
            Exit Sub
        ElseIf Button8.Text = "X" And Button7.Text = "" Then
            Button7.Text = "O"
            Exit Sub
        ElseIf Button8.Text = "X" And Button9.Text = "" Then
            Button9.Text = "O"
            Exit Sub
        ElseIf Button9.Text = "X" And Button8.Text = "" Then
            Button8.Text = "O"
            Exit Sub
        ElseIf Button9.Text = "X" And Button6.Text = "" Then
            Button6.Text = "O"
            Exit Sub
        ElseIf Button9.Text = "X" And Button5.Text = "" Then
            Button5.Text = "O"
            Exit Sub
            'trying to win
        ElseIf Button1.Text = "O" And Button2.Text = "" Then
            Button2.Text = "O"
            Exit Sub
        ElseIf Button1.Text = "O" And Button4.Text = "" Then
            Button4.Text = "O"
            Exit Sub
        ElseIf Button1.Text = "O" And Button5.Text = "" Then
            Button4.Text = "O"
            Exit Sub
        ElseIf Button2.Text = "O" And Button1.Text = "" Then
            Button1.Text = "O"
            Exit Sub
        ElseIf Button2.Text = "O" And Button3.Text = "" Then
            Button3.Text = "O"
            Exit Sub
        ElseIf Button2.Text = "O" And Button5.Text = "" Then
            Button5.Text = "O"
            Exit Sub
        ElseIf Button3.Text = "O" And Button2.Text = "" Then
            Button2.Text = "O"
            Exit Sub
        ElseIf Button3.Text = "O" And Button5.Text = "" Then
            Button5.Text = "O"
            Exit Sub
        ElseIf Button3.Text = "O" And Button6.Text = "" Then
            Button6.Text = "O"
            Exit Sub
        ElseIf Button4.Text = "O" And Button5.Text = "" Then
            Button5.Text = "O"
            Exit Sub
        ElseIf Button4.Text = "O" And Button1.Text = "" Then
            Button1.Text = "O"
            Exit Sub
        ElseIf Button4.Text = "O" And Button7.Text = "" Then
            Button7.Text = "O"
            Exit Sub
        ElseIf Button5.Text = "O" And Button2.Text = "" Then
            Button2.Text = "O"
            Exit Sub
        ElseIf Button5.Text = "O" And Button4.Text = "" Then
            Button4.Text = "O"
            Exit Sub
        ElseIf Button5.Text = "O" And Button6.Text = "" Then
            Button6.Text = "O"
            Exit Sub
        ElseIf Button5.Text = "O" And Button8.Text = "" Then
            Button8.Text = "O"
            Exit Sub
        ElseIf Button6.Text = "O" And Button5.Text = "" Then
            Button5.Text = "O"
            Exit Sub
        ElseIf Button6.Text = "O" And Button3.Text = "" Then
            Button3.Text = "O"
            Exit Sub
        ElseIf Button6.Text = "O" And Button9.Text = "" Then
            Button9.Text = "O"
            Exit Sub
        ElseIf Button7.Text = "O" And Button8.Text = "" Then
            Button8.Text = "O"
            Exit Sub
        ElseIf Button7.Text = "O" And Button4.Text = "" Then
            Button4.Text = "O"
            Exit Sub
        ElseIf Button7.Text = "O" And Button5.Text = "" Then
            Button5.Text = "O"
            Exit Sub
        ElseIf Button8.Text = "O" And Button5.Text = "" Then
            Button5.Text = "O"
            Exit Sub
        ElseIf Button8.Text = "O" And Button7.Text = "" Then
            Button7.Text = "O"
            Exit Sub
        ElseIf Button8.Text = "O" And Button9.Text = "" Then
            Button9.Text = "O"
            Exit Sub
        ElseIf Button9.Text = "O" And Button8.Text = "" Then
            Button8.Text = "O"
            Exit Sub
        ElseIf Button9.Text = "O" And Button6.Text = "" Then
            Button6.Text = "O"
            Exit Sub
        ElseIf Button9.Text = "O" And Button5.Text = "" Then
            Button5.Text = "O"
            Exit Sub
            'if no other choice, places O on the last empty spot
forceplace:
        ElseIf Button5.Text = "" Then
            Button5.Text = "O"
            Exit Sub
        ElseIf Button2.Text = "" Then
            Button2.Text = "O"
            Exit Sub
        ElseIf Button3.Text = "" Then
            Button3.Text = "O"
            Exit Sub
        ElseIf Button4.Text = "" Then
            Button4.Text = "O"
            Exit Sub
        ElseIf Button1.Text = "" Then
            Button1.Text = "O"
            Exit Sub
        ElseIf Button6.Text = "" Then
            Button6.Text = "O"
            Exit Sub
        ElseIf Button7.Text = "" Then
            Button7.Text = "O"
            Exit Sub
        ElseIf Button8.Text = "" Then
            Button8.Text = "O"
            Exit Sub
        ElseIf Button9.Text = "" Then
            Button9.Text = "O"
            Exit Sub
        End If
    End Sub
    Private Sub RestartComputerFirstMenuStripItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        random += 1
        If random > 9 Then
            random = 1
        ElseIf random < 1 Then
            random = 1
        End If
        Button5.Text = "O"
        'Label1.Text = 5
        Button5.Enabled = False
    End Sub
    Private Sub RestartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartToolStripMenuItem.Click
        Button1.Text = ""
        Button1.Enabled = True
        Button2.Text = ""
        Button2.Enabled = True
        Button3.Text = ""
        Button3.Enabled = True
        Button4.Text = ""
        Button4.Enabled = True
        Button5.Text = ""
        Button5.Enabled = True
        Button6.Text = ""
        Button6.Enabled = True
        Button7.Text = ""
        Button7.Enabled = True
        Button8.Text = ""
        Button8.Enabled = True
        Button9.Text = ""
        Button9.Enabled = True
    End Sub

    Private Sub ViewDesktopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDesktopToolStripMenuItem.Click
        Hide()
        composedwindow.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Hide()
        composedwindow.Hide()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageDialog.messagetitle = "About"
        MessageDialog.messagetext = "Tic Tac Toe version 1.0b"
        MessageDialog.messageicon = "Info"
        'MessageDialog.ff = Me
        'MessageDialog.sf = composedwindow
        MessageDialog.ShowDialog()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        tskmgr.ListBox1.Items.Remove("TicTacToe game")
        'If Form1.es = True Then My.Computer.Audio.Play(My.Resources.windowed_close, AudioPlayMode.Background)
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Close()
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            Form1.fadeout_animation(Me, composedwindow)
        End If
    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label4.MouseDown
        drag = True
        mousex = Cursor.Position.X - Left
        mousey = Cursor.Position.Y - Top
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label4.MouseMove
        If drag Then
            Top = Cursor.Position.Y - mousey
            Left = Cursor.Position.X - mousex
            composedwindow.Top = Top
            composedwindow.Left = Left
        End If
    End Sub

    Private Sub GameplayRulesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GameplayRulesToolStripMenuItem.Click
        MessageDialog.messagetitle = "Help"
        MessageDialog.messagetext = "Click on a box to place a X." & vbNewLine & "After that opponent does that too." & vbNewLine & "Goal is to get a line of X's horizontally," & vbNewLine & "vertically or diagonally."
        MessageDialog.messageicon = "Help"
        'MessageDialog.ff = Me
        'MessageDialog.sf = composedwindow
        MessageDialog.ShowDialog()
    End Sub

    Private Sub TicTacToe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tskmgr.ListBox1.Items.Add("TicTacToe game")
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Opacity = 1.0
    End Sub

    Private Sub TicTacToe_VisibleChanged(sender As Object, e As System.EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            Form1.Setfont(Me, Label4, Label3)
            Label3.BackColor = Desktop.labelBg.BackColor
            Label3.ForeColor = Desktop.labelFg.BackColor
            Label4.BackColor = Desktop.labelBg.BackColor
            Label4.ForeColor = Desktop.labelFg.BackColor
            Button1.ForeColor = Desktop.appFg.BackColor
            Button2.ForeColor = Desktop.appFg.BackColor
            Button3.ForeColor = Desktop.appFg.BackColor
            Button4.ForeColor = Desktop.appFg.BackColor
            Button5.ForeColor = Desktop.appFg.BackColor
            Button6.ForeColor = Desktop.appFg.BackColor
            Button7.ForeColor = Desktop.appFg.BackColor
            Button8.ForeColor = Desktop.appFg.BackColor
            Button9.ForeColor = Desktop.appFg.BackColor
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.BackColor = Desktop.appBg.BackColor
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
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
                Form1.translucency(Me, composedwindow, True)
            End If
            Me.ForeColor = Desktop.appFg.BackColor
        End If
    End Sub

    Private Sub TerminateTimer_Tick(sender As System.Object, e As System.EventArgs) Handles TerminateTimer.Tick
        If LogoffWindow.Visible = True Then
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Close()
            Me.Close()
        ElseIf Desktop.restorewindow.Text = "TicTacToe game" Then
            Me.Opacity = 1.0
            composedwindow.Opacity = 0.9
            Me.Show()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Show()
        ElseIf Lock.Visible = True Then
            Me.Hide()
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then composedwindow.Hide()
        End If
            If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Exit Sub
            If Form1.FadeInTimer.Enabled = True Then Exit Sub
            If Not Me.Opacity = 1.0 Or Me.Opacity = 0.0 Then
                Form1.fadeout_animation(Me, composedwindow)
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
    End Sub

    Private Sub TicTacToe_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        Label4.BackColor = Desktop.labelBg.BackColor
        Label3.BackColor = Desktop.labelBg.BackColor
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

    Private Sub TicTacToe_Deactivate(sender As System.Object, e As System.EventArgs) Handles MyBase.Deactivate
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
        Label3.BackColor = col
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then
            If composedwindow.IsDisposed = False Then
                If Not GetActiveWindow <> composedwindow.Handle Then
                    composedwindow.BringToFront()
                    Me.BringToFront()
                End If
            End If
        End If
        rap = False
    End Sub

    Private Sub TicTacToe_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Control + Keys.NumPad1 Then
            dev = True
        End If
    End Sub

    Private Sub RestartcomputerFirstToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RestartcomputerFirstToolStripMenuItem.Click
        Button1.Text = ""
        Button1.Enabled = True
        Button2.Text = ""
        Button2.Enabled = True
        Button3.Text = ""
        Button3.Enabled = True
        Button4.Text = ""
        Button4.Enabled = True
        Button5.Text = ""
        Button5.Enabled = True
        Button6.Text = ""
        Button6.Enabled = True
        Button7.Text = ""
        Button7.Enabled = True
        Button8.Text = ""
        Button8.Enabled = True
        Button9.Text = ""
        Button9.Enabled = True
        Dim rnd As Random = New Random()
        Dim i As Integer
        i = rnd.Next(9)
        If i = 1 Then Button1.Text = "O"
        If i = 2 Then Button2.Text = "O"
        If i = 3 Then Button3.Text = "O"
        If i = 4 Then Button4.Text = "O"
        If i = 5 Then Button5.Text = "O"
        If i = 6 Then Button6.Text = "O"
        If i = 7 Then Button7.Text = "O"
        If i = 8 Then Button8.Text = "O"
        If i = 9 Then Button9.Text = "O"
        If Button1.Text = "" And Button2.Text = "" And Button3.Text = "" And Button4.Text = "" And Button5.Text = "" And Button6.Text = "" And Button7.Text = "" And Button8.Text = "" And Button9.Text = "" Then Button5.Text = "O"
        disablecomputerbuttons()
    End Sub

    Private Sub Button5_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles Button5.KeyDown
        If e.KeyCode = Keys.Down Then
            If Button8.CanSelect = True Then Button8.Select()
        ElseIf e.KeyCode = Keys.Up Then
            If Button2.CanSelect = True Then Button2.Select()
        ElseIf e.KeyCode = Keys.Left Then
            If Button4.CanSelect = True Then Button4.Select()
        ElseIf e.KeyCode = Keys.Right Then
            If Button6.CanSelect = True Then Button6.Select()
        End If
    End Sub

    Private Sub Button4_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles Button4.KeyDown
        If e.KeyCode = Keys.Down Then
            If Button7.CanSelect = True Then Button7.Select()
        ElseIf e.KeyCode = Keys.Up Then
            If Button1.CanSelect = True Then Button1.Select()
        ElseIf e.KeyCode = Keys.Right Then
            If Button5.CanSelect = True Then Button5.Select()
        End If
    End Sub

    Private Sub Button6_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles Button6.KeyDown
        If e.KeyCode = Keys.Down Then
            If Button9.CanSelect = True Then Button9.Select()
        ElseIf e.KeyCode = Keys.Up Then
            If Button3.CanSelect = True Then Button3.Select()
        ElseIf e.KeyCode = Keys.Left Then
            If Button5.CanSelect = True Then Button5.Select()
        End If
    End Sub

    Private Sub Button1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles Button1.KeyDown
        If e.KeyCode = Keys.Down Then
            If Button4.CanSelect = True Then Button4.Select()
        ElseIf e.KeyCode = Keys.Right Then
            If Button2.CanSelect = True Then Button2.Select()
        End If
    End Sub

    Private Sub Button2_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles Button2.KeyDown
        If e.KeyCode = Keys.Down Then
            If Button5.CanSelect = True Then Button5.Select()
        ElseIf e.KeyCode = Keys.Left Then
            If Button1.CanSelect = True Then Button1.Select()
        ElseIf e.KeyCode = Keys.Right Then
            If Button3.CanSelect = True Then Button3.Select()
        End If
    End Sub

    Private Sub Button3_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles Button3.KeyDown
        If e.KeyCode = Keys.Down Then
            If Button6.CanSelect = True Then Button6.Select()
        ElseIf e.KeyCode = Keys.Left Then
            If Button2.CanSelect = True Then Button2.Select()
        End If
    End Sub

    Private Sub Button7_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles Button7.KeyDown
        If e.KeyCode = Keys.Up Then
            If Button4.CanSelect = True Then Button4.Select()
        ElseIf e.KeyCode = Keys.Right Then
            If Button8.CanSelect = True Then Button8.Select()
        End If
    End Sub

    Private Sub Button8_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles Button8.KeyDown
        If e.KeyCode = Keys.Up Then
            If Button5.CanSelect = True Then Button5.Select()
        ElseIf e.KeyCode = Keys.Left Then
            If Button7.CanSelect = True Then Button7.Select()
        ElseIf e.KeyCode = Keys.Right Then
            If Button9.CanSelect = True Then Button9.Select()
        End If
    End Sub

    Private Sub Button9_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles Button9.KeyDown
        If e.KeyCode = Keys.Up Then
            If Button6.CanSelect = True Then Button6.Select()
        ElseIf e.KeyCode = Keys.Left Then
            If Button8.CanSelect = True Then Button8.Select()
        End If
    End Sub

    Private Sub Label4_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Label4.MouseUp
        drag = False
        composedwindow.BringToFront()
        Me.BringToFront()
    End Sub
End Class