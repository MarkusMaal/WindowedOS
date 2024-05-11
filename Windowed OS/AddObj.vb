Public Class AddObj

    Dim drag As Boolean
    Dim mousey As Integer
    Dim mousex As Integer
    Dim CurLocation, AppLocation As New Point(0, 0)
    Dim composedwindow As Form = New Form()
    Dim rap As Boolean = False
    Private Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label4.MouseDown
        drag = True
        mousex = Cursor.Position.X - Left
        mousey = Cursor.Position.Y - Top
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label4.MouseMove
        If drag Then
            Top = Cursor.Position.Y - mousey
            Left = Cursor.Position.X - mousex
            composedwindow.Left = Left
            composedwindow.Top = Top
        End If
    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label4.MouseUp
        drag = False
        composedwindow.BringToFront()
        Me.BringToFront()
    End Sub

    Private Sub Addobj_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
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
                    Me.BringToFront()
                End If
            End If
        End If
        rap = False
    End Sub

    Private Sub AddObj_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Opacity = 1.0
    End Sub

    Private Sub AddObj_VisibleChanged(sender As System.Object, e As System.EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            If Me.Visible = True Then
                Form1.Setfont(Me, Label1)
                Label4.BackColor = Desktop.labelBg.BackColor
                Label4.ForeColor = Desktop.labelFg.BackColor
                If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.BackColor = Desktop.appBg.BackColor
                If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.translucency(Me, composedwindow, True)
                Me.ForeColor = Desktop.appFg.BackColor
            End If
        End If
    End Sub

    Private Sub AddObj_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        Label4.BackColor = Desktop.labelBg.BackColor
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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        voide.ListBox1.Items.Add(TextBox1.Text.Replace("\n", vbNewLine))
        Dim lctx As String
        Dim lcty As String
        Dim lst As ListBox = New ListBox()
        lst.Items.AddRange(MaskedTextBox1.Text.Split("x"))
        lst.SelectedIndex = 0
        lctx = lst.SelectedItem.ToString()
        lst.SelectedIndex = 1
        lcty = lst.SelectedItem.ToString()
        voide.ListBox2.Items.Add(ComboBox1.SelectedItem.ToString() & ";" & lctx & ";" & lcty & ";" & "Value")
        If ComboBox1.SelectedIndex = 0 Then
            Dim Obj As Button = New Button With {
                .Name = TextBox1.Text.Replace("\n", vbNewLine),
                .Location = New Point(Convert.ToInt32(lctx), Convert.ToInt32(lcty)),
                .AutoSize = True,
                .FlatStyle = FlatStyle.Flat,
                .Text = "Value"
            }
            voide.SplitContainer2.Panel1.Controls.Add(Obj)
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Dim Obj As Label = New Label With {
                .Name = TextBox1.Text.Replace("\n", vbNewLine),
                .Location = New Point(Convert.ToInt32(lctx), Convert.ToInt32(lcty)),
                .AutoSize = True,
                .Text = "Value"
            }
            voide.SplitContainer2.Panel1.Controls.Add(Obj)
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Dim Obj As TextBox = New TextBox With {
                .Name = TextBox1.Text.Replace("\n", vbNewLine),
                .Location = New Point(Convert.ToInt32(lctx), Convert.ToInt32(lcty)),
                .AutoSize = True,
                .BorderStyle = BorderStyle.FixedSingle,
                .Text = "Value"
            }
            voide.SplitContainer2.Panel1.Controls.Add(Obj)
        End If
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = False Then Me.Close()
        If Desktop.EnableDesktopCompositionToolStripMenuItem.Checked = True Then Form1.fadeout_animation(Me, composedwindow)

    End Sub
End Class