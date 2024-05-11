<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button07 = New System.Windows.Forms.Button()
        Me.Button08 = New System.Windows.Forms.Button()
        Me.Button09 = New System.Windows.Forms.Button()
        Me.Button06 = New System.Windows.Forms.Button()
        Me.Button05 = New System.Windows.Forms.Button()
        Me.Button04 = New System.Windows.Forms.Button()
        Me.Button03 = New System.Windows.Forms.Button()
        Me.Button02 = New System.Windows.Forms.Button()
        Me.Button01 = New System.Windows.Forms.Button()
        Me.ButtonBackspace = New System.Windows.Forms.Button()
        Me.ButtonDot = New System.Windows.Forms.Button()
        Me.Button00 = New System.Windows.Forms.Button()
        Me.ButtonMultiply = New System.Windows.Forms.Button()
        Me.ButtonDivide = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonSubtract = New System.Windows.Forms.Button()
        Me.ButtonPercent = New System.Windows.Forms.Button()
        Me.ButtonEqual = New System.Windows.Forms.Button()
        Me.ButtonPlusMinus = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ButtonPi = New System.Windows.Forms.Button()
        Me.InfoTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DegreesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RadiansToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToMemoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportFromMemoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EndProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDesktopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.KillTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckJustInCase = New System.Windows.Forms.Timer(Me.components)
        Me.DocumentationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Calculator"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!)
        Me.Label2.Location = New System.Drawing.Point(7, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 35)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "0"
        Me.InfoTip.SetToolTip(Me.Label2, "Integer display")
        '
        'Button07
        '
        Me.Button07.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button07.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button07.Location = New System.Drawing.Point(7, 101)
        Me.Button07.Name = "Button07"
        Me.Button07.Size = New System.Drawing.Size(39, 31)
        Me.Button07.TabIndex = 7
        Me.Button07.Text = "&7"
        Me.InfoTip.SetToolTip(Me.Button07, "Seven")
        Me.Button07.UseVisualStyleBackColor = True
        '
        'Button08
        '
        Me.Button08.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button08.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button08.Location = New System.Drawing.Point(52, 101)
        Me.Button08.Name = "Button08"
        Me.Button08.Size = New System.Drawing.Size(39, 31)
        Me.Button08.TabIndex = 8
        Me.Button08.Text = "&8"
        Me.InfoTip.SetToolTip(Me.Button08, "Eight")
        Me.Button08.UseVisualStyleBackColor = True
        '
        'Button09
        '
        Me.Button09.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button09.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button09.Location = New System.Drawing.Point(97, 101)
        Me.Button09.Name = "Button09"
        Me.Button09.Size = New System.Drawing.Size(39, 31)
        Me.Button09.TabIndex = 9
        Me.Button09.Text = "&9"
        Me.InfoTip.SetToolTip(Me.Button09, "Nine")
        Me.Button09.UseVisualStyleBackColor = True
        '
        'Button06
        '
        Me.Button06.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button06.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button06.Location = New System.Drawing.Point(97, 138)
        Me.Button06.Name = "Button06"
        Me.Button06.Size = New System.Drawing.Size(39, 31)
        Me.Button06.TabIndex = 6
        Me.Button06.Text = "&6"
        Me.InfoTip.SetToolTip(Me.Button06, "Six")
        Me.Button06.UseVisualStyleBackColor = True
        '
        'Button05
        '
        Me.Button05.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button05.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button05.Location = New System.Drawing.Point(52, 138)
        Me.Button05.Name = "Button05"
        Me.Button05.Size = New System.Drawing.Size(39, 31)
        Me.Button05.TabIndex = 5
        Me.Button05.Text = "&5"
        Me.InfoTip.SetToolTip(Me.Button05, "Five")
        Me.Button05.UseVisualStyleBackColor = True
        '
        'Button04
        '
        Me.Button04.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button04.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button04.Location = New System.Drawing.Point(7, 138)
        Me.Button04.Name = "Button04"
        Me.Button04.Size = New System.Drawing.Size(39, 31)
        Me.Button04.TabIndex = 4
        Me.Button04.Text = "&4"
        Me.InfoTip.SetToolTip(Me.Button04, "Four")
        Me.Button04.UseVisualStyleBackColor = True
        '
        'Button03
        '
        Me.Button03.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button03.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button03.Location = New System.Drawing.Point(97, 175)
        Me.Button03.Name = "Button03"
        Me.Button03.Size = New System.Drawing.Size(39, 31)
        Me.Button03.TabIndex = 3
        Me.Button03.Text = "&3"
        Me.InfoTip.SetToolTip(Me.Button03, "Three")
        Me.Button03.UseVisualStyleBackColor = True
        '
        'Button02
        '
        Me.Button02.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button02.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button02.Location = New System.Drawing.Point(52, 175)
        Me.Button02.Name = "Button02"
        Me.Button02.Size = New System.Drawing.Size(39, 31)
        Me.Button02.TabIndex = 2
        Me.Button02.Text = "&2"
        Me.InfoTip.SetToolTip(Me.Button02, "Two")
        Me.Button02.UseVisualStyleBackColor = True
        '
        'Button01
        '
        Me.Button01.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button01.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button01.Location = New System.Drawing.Point(7, 175)
        Me.Button01.Name = "Button01"
        Me.Button01.Size = New System.Drawing.Size(39, 31)
        Me.Button01.TabIndex = 1
        Me.Button01.Text = "&1"
        Me.InfoTip.SetToolTip(Me.Button01, "One")
        Me.Button01.UseVisualStyleBackColor = True
        '
        'ButtonBackspace
        '
        Me.ButtonBackspace.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBackspace.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ButtonBackspace.Location = New System.Drawing.Point(278, 51)
        Me.ButtonBackspace.Name = "ButtonBackspace"
        Me.ButtonBackspace.Size = New System.Drawing.Size(39, 35)
        Me.ButtonBackspace.TabIndex = 26
        Me.ButtonBackspace.Text = "<-"
        Me.InfoTip.SetToolTip(Me.ButtonBackspace, "Backspace")
        Me.ButtonBackspace.UseVisualStyleBackColor = True
        '
        'ButtonDot
        '
        Me.ButtonDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ButtonDot.Location = New System.Drawing.Point(97, 212)
        Me.ButtonDot.Name = "ButtonDot"
        Me.ButtonDot.Size = New System.Drawing.Size(39, 31)
        Me.ButtonDot.TabIndex = 10
        Me.ButtonDot.Text = "&."
        Me.InfoTip.SetToolTip(Me.ButtonDot, "Comma/Dot")
        Me.ButtonDot.UseVisualStyleBackColor = True
        '
        'Button00
        '
        Me.Button00.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button00.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button00.Location = New System.Drawing.Point(7, 212)
        Me.Button00.Name = "Button00"
        Me.Button00.Size = New System.Drawing.Size(84, 31)
        Me.Button00.TabIndex = 0
        Me.Button00.Text = "&0"
        Me.InfoTip.SetToolTip(Me.Button00, "Zero")
        Me.Button00.UseVisualStyleBackColor = True
        '
        'ButtonMultiply
        '
        Me.ButtonMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ButtonMultiply.Location = New System.Drawing.Point(142, 101)
        Me.ButtonMultiply.Name = "ButtonMultiply"
        Me.ButtonMultiply.Size = New System.Drawing.Size(39, 31)
        Me.ButtonMultiply.TabIndex = 11
        Me.ButtonMultiply.Text = "&*"
        Me.InfoTip.SetToolTip(Me.ButtonMultiply, "Multiplication")
        Me.ButtonMultiply.UseVisualStyleBackColor = True
        '
        'ButtonDivide
        '
        Me.ButtonDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ButtonDivide.Location = New System.Drawing.Point(142, 138)
        Me.ButtonDivide.Name = "ButtonDivide"
        Me.ButtonDivide.Size = New System.Drawing.Size(39, 31)
        Me.ButtonDivide.TabIndex = 12
        Me.ButtonDivide.Text = "&/"
        Me.InfoTip.SetToolTip(Me.ButtonDivide, "Division")
        Me.ButtonDivide.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        Me.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ButtonAdd.Location = New System.Drawing.Point(142, 175)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(39, 31)
        Me.ButtonAdd.TabIndex = 13
        Me.ButtonAdd.Text = "&+"
        Me.InfoTip.SetToolTip(Me.ButtonAdd, "Addition")
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonSubtract
        '
        Me.ButtonSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSubtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ButtonSubtract.Location = New System.Drawing.Point(142, 212)
        Me.ButtonSubtract.Name = "ButtonSubtract"
        Me.ButtonSubtract.Size = New System.Drawing.Size(39, 31)
        Me.ButtonSubtract.TabIndex = 14
        Me.ButtonSubtract.Text = "&-"
        Me.InfoTip.SetToolTip(Me.ButtonSubtract, "Subtraction")
        Me.ButtonSubtract.UseVisualStyleBackColor = True
        '
        'ButtonPercent
        '
        Me.ButtonPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ButtonPercent.Location = New System.Drawing.Point(187, 101)
        Me.ButtonPercent.Name = "ButtonPercent"
        Me.ButtonPercent.Size = New System.Drawing.Size(39, 31)
        Me.ButtonPercent.TabIndex = 15
        Me.ButtonPercent.Text = "&%"
        Me.InfoTip.SetToolTip(Me.ButtonPercent, "Percentage")
        Me.ButtonPercent.UseVisualStyleBackColor = True
        '
        'ButtonEqual
        '
        Me.ButtonEqual.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEqual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ButtonEqual.ForeColor = System.Drawing.Color.White
        Me.ButtonEqual.Location = New System.Drawing.Point(232, 175)
        Me.ButtonEqual.Name = "ButtonEqual"
        Me.ButtonEqual.Size = New System.Drawing.Size(39, 68)
        Me.ButtonEqual.TabIndex = 25
        Me.ButtonEqual.Text = "&="
        Me.InfoTip.SetToolTip(Me.ButtonEqual, "Equal sign")
        Me.ButtonEqual.UseVisualStyleBackColor = False
        '
        'ButtonPlusMinus
        '
        Me.ButtonPlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPlusMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ButtonPlusMinus.Location = New System.Drawing.Point(187, 138)
        Me.ButtonPlusMinus.Name = "ButtonPlusMinus"
        Me.ButtonPlusMinus.Size = New System.Drawing.Size(39, 31)
        Me.ButtonPlusMinus.TabIndex = 16
        Me.ButtonPlusMinus.Text = "±"
        Me.InfoTip.SetToolTip(Me.ButtonPlusMinus, "Opposite number")
        Me.ButtonPlusMinus.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(232, 101)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 31)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "C"
        Me.InfoTip.SetToolTip(Me.Button1, "Clear")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button2.Location = New System.Drawing.Point(232, 138)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(39, 31)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "sqrt"
        Me.InfoTip.SetToolTip(Me.Button2, "Square root")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button3.Location = New System.Drawing.Point(188, 175)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(39, 31)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "&^"
        Me.InfoTip.SetToolTip(Me.Button3, "Power")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ButtonPi
        '
        Me.ButtonPi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ButtonPi.Location = New System.Drawing.Point(188, 212)
        Me.ButtonPi.Name = "ButtonPi"
        Me.ButtonPi.Size = New System.Drawing.Size(39, 31)
        Me.ButtonPi.TabIndex = 18
        Me.ButtonPi.Text = "π"
        Me.InfoTip.SetToolTip(Me.ButtonPi, "Pi")
        Me.ButtonPi.UseVisualStyleBackColor = True
        '
        'InfoTip
        '
        Me.InfoTip.BackColor = System.Drawing.Color.White
        Me.InfoTip.ForeColor = System.Drawing.Color.Black
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button4.Location = New System.Drawing.Point(277, 101)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(39, 31)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "&cos"
        Me.InfoTip.SetToolTip(Me.Button4, "Cosine")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button5.Location = New System.Drawing.Point(277, 138)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(39, 31)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "&sin"
        Me.InfoTip.SetToolTip(Me.Button5, "Sine")
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button6.Location = New System.Drawing.Point(277, 175)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(39, 31)
        Me.Button6.TabIndex = 22
        Me.Button6.Text = "&tan"
        Me.InfoTip.SetToolTip(Me.Button6, "Tangent")
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button7.Location = New System.Drawing.Point(277, 212)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(39, 31)
        Me.Button7.TabIndex = 23
        Me.Button7.Text = "1/&x"
        Me.InfoTip.SetToolTip(Me.Button7, "1/x function")
        Me.Button7.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatorToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(4, 20)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(258, 24)
        Me.MenuStrip1.TabIndex = 27
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModeToolStripMenuItem, Me.AddToMemoryToolStripMenuItem, Me.ImportFromMemoryToolStripMenuItem, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.OasteToolStripMenuItem, Me.ExitToolStripMenuItem, Me.EndProcessToolStripMenuItem})
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.CalculatorToolStripMenuItem.Text = "Calculator"
        '
        'ModeToolStripMenuItem
        '
        Me.ModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DegreesToolStripMenuItem, Me.RadiansToolStripMenuItem})
        Me.ModeToolStripMenuItem.Name = "ModeToolStripMenuItem"
        Me.ModeToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.ModeToolStripMenuItem.Text = "Chagne mode"
        '
        'DegreesToolStripMenuItem
        '
        Me.DegreesToolStripMenuItem.Checked = True
        Me.DegreesToolStripMenuItem.CheckOnClick = True
        Me.DegreesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DegreesToolStripMenuItem.Name = "DegreesToolStripMenuItem"
        Me.DegreesToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.DegreesToolStripMenuItem.Text = "Degrees"
        '
        'RadiansToolStripMenuItem
        '
        Me.RadiansToolStripMenuItem.CheckOnClick = True
        Me.RadiansToolStripMenuItem.Name = "RadiansToolStripMenuItem"
        Me.RadiansToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.RadiansToolStripMenuItem.Text = "Radians"
        '
        'AddToMemoryToolStripMenuItem
        '
        Me.AddToMemoryToolStripMenuItem.Name = "AddToMemoryToolStripMenuItem"
        Me.AddToMemoryToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.AddToMemoryToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.AddToMemoryToolStripMenuItem.Text = "Add to memory"
        '
        'ImportFromMemoryToolStripMenuItem
        '
        Me.ImportFromMemoryToolStripMenuItem.Name = "ImportFromMemoryToolStripMenuItem"
        Me.ImportFromMemoryToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.ImportFromMemoryToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.ImportFromMemoryToolStripMenuItem.Text = "Import from memory"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'OasteToolStripMenuItem
        '
        Me.OasteToolStripMenuItem.Name = "OasteToolStripMenuItem"
        Me.OasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.OasteToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.OasteToolStripMenuItem.Text = "Paste"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.Windowed_OS.My.Resources.Resources._exit
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.ExitToolStripMenuItem.Text = "Close"
        '
        'EndProcessToolStripMenuItem
        '
        Me.EndProcessToolStripMenuItem.Image = Global.Windowed_OS.My.Resources.Resources._exit
        Me.EndProcessToolStripMenuItem.Name = "EndProcessToolStripMenuItem"
        Me.EndProcessToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.EndProcessToolStripMenuItem.Text = "Exit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewDesktopToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ViewDesktopToolStripMenuItem
        '
        Me.ViewDesktopToolStripMenuItem.Name = "ViewDesktopToolStripMenuItem"
        Me.ViewDesktopToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.ViewDesktopToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ViewDesktopToolStripMenuItem.Text = "View Desktop"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DocumentationToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(188, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 19)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Mode: DEG"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'KillTimer
        '
        Me.KillTimer.Enabled = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DimGray
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(304, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "H"
        '
        'CheckJustInCase
        '
        Me.CheckJustInCase.Enabled = True
        '
        'DocumentationToolStripMenuItem
        '
        Me.DocumentationToolStripMenuItem.Name = "DocumentationToolStripMenuItem"
        Me.DocumentationToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.DocumentationToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.DocumentationToolStripMenuItem.Text = "Documentation"
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(322, 259)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ButtonPi)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonPlusMinus)
        Me.Controls.Add(Me.ButtonEqual)
        Me.Controls.Add(Me.ButtonPercent)
        Me.Controls.Add(Me.ButtonSubtract)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.ButtonDivide)
        Me.Controls.Add(Me.ButtonMultiply)
        Me.Controls.Add(Me.ButtonBackspace)
        Me.Controls.Add(Me.ButtonDot)
        Me.Controls.Add(Me.Button00)
        Me.Controls.Add(Me.Button03)
        Me.Controls.Add(Me.Button02)
        Me.Controls.Add(Me.Button01)
        Me.Controls.Add(Me.Button06)
        Me.Controls.Add(Me.Button05)
        Me.Controls.Add(Me.Button04)
        Me.Controls.Add(Me.Button09)
        Me.Controls.Add(Me.Button08)
        Me.Controls.Add(Me.Button07)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Calculator"
        Me.Opacity = 0.0R
        Me.Text = "Calculator"
        Me.TopMost = True
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button07 As System.Windows.Forms.Button
    Friend WithEvents Button08 As System.Windows.Forms.Button
    Friend WithEvents Button09 As System.Windows.Forms.Button
    Friend WithEvents Button06 As System.Windows.Forms.Button
    Friend WithEvents Button05 As System.Windows.Forms.Button
    Friend WithEvents Button04 As System.Windows.Forms.Button
    Friend WithEvents Button03 As System.Windows.Forms.Button
    Friend WithEvents Button02 As System.Windows.Forms.Button
    Friend WithEvents Button01 As System.Windows.Forms.Button
    Friend WithEvents ButtonBackspace As System.Windows.Forms.Button
    Friend WithEvents ButtonDot As System.Windows.Forms.Button
    Friend WithEvents Button00 As System.Windows.Forms.Button
    Friend WithEvents ButtonMultiply As System.Windows.Forms.Button
    Friend WithEvents ButtonDivide As System.Windows.Forms.Button
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonSubtract As System.Windows.Forms.Button
    Friend WithEvents ButtonPercent As System.Windows.Forms.Button
    Friend WithEvents ButtonEqual As System.Windows.Forms.Button
    Friend WithEvents ButtonPlusMinus As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ButtonPi As System.Windows.Forms.Button
    Friend WithEvents InfoTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DegreesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RadiansToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents KillTimer As System.Windows.Forms.Timer
    Friend WithEvents EndProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewDesktopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AddToMemoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportFromMemoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckJustInCase As System.Windows.Forms.Timer
    Friend WithEvents DocumentationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
