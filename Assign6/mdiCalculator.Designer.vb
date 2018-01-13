<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdiCalculator
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
        Me.lstShape = New System.Windows.Forms.ListBox()
        Me.lstFormula = New System.Windows.Forms.ListBox()
        Me.cmdClearAll = New System.Windows.Forms.Button()
        Me.cmdClearEntry = New System.Windows.Forms.Button()
        Me.cmd7 = New System.Windows.Forms.Button()
        Me.cmd8 = New System.Windows.Forms.Button()
        Me.cmd9 = New System.Windows.Forms.Button()
        Me.cmd6 = New System.Windows.Forms.Button()
        Me.cmd5 = New System.Windows.Forms.Button()
        Me.cmd4 = New System.Windows.Forms.Button()
        Me.cmd3 = New System.Windows.Forms.Button()
        Me.cmd2 = New System.Windows.Forms.Button()
        Me.cmd1 = New System.Windows.Forms.Button()
        Me.cmd0 = New System.Windows.Forms.Button()
        Me.cmdDecimal = New System.Windows.Forms.Button()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.lblShape = New System.Windows.Forms.Label()
        Me.lblFormula = New System.Windows.Forms.Label()
        Me.grpConvertAnswer = New System.Windows.Forms.GroupBox()
        Me.optCentimeters = New System.Windows.Forms.RadioButton()
        Me.optInches = New System.Windows.Forms.RadioButton()
        Me.txtRadius = New System.Windows.Forms.TextBox()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.lblRadius = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.txtBase = New System.Windows.Forms.TextBox()
        Me.lblBase = New System.Windows.Forms.Label()
        Me.cmdCalculate = New System.Windows.Forms.Button()
        Me.picMathImage = New System.Windows.Forms.PictureBox()
        Me.lblFinalAnswer = New System.Windows.Forms.Label()
        Me.grpConvertAnswer.SuspendLayout()
        CType(Me.picMathImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstShape
        '
        Me.lstShape.FormattingEnabled = True
        Me.lstShape.Items.AddRange(New Object() {"2D - Rectangle", "2D - Square", "2D - Right Triangle", "2D - Circle", "3D - Cube", "3D - Sphere", "3D - Cylinder", "3D - Cone"})
        Me.lstShape.Location = New System.Drawing.Point(22, 231)
        Me.lstShape.Name = "lstShape"
        Me.lstShape.Size = New System.Drawing.Size(127, 69)
        Me.lstShape.TabIndex = 0
        '
        'lstFormula
        '
        Me.lstFormula.FormattingEnabled = True
        Me.lstFormula.Location = New System.Drawing.Point(22, 351)
        Me.lstFormula.Name = "lstFormula"
        Me.lstFormula.Size = New System.Drawing.Size(127, 69)
        Me.lstFormula.TabIndex = 1
        '
        'cmdClearAll
        '
        Me.cmdClearAll.Location = New System.Drawing.Point(164, 208)
        Me.cmdClearAll.Name = "cmdClearAll"
        Me.cmdClearAll.Size = New System.Drawing.Size(80, 28)
        Me.cmdClearAll.TabIndex = 2
        Me.cmdClearAll.TabStop = False
        Me.cmdClearAll.Text = "C"
        Me.cmdClearAll.UseVisualStyleBackColor = True
        '
        'cmdClearEntry
        '
        Me.cmdClearEntry.Location = New System.Drawing.Point(258, 208)
        Me.cmdClearEntry.Name = "cmdClearEntry"
        Me.cmdClearEntry.Size = New System.Drawing.Size(80, 28)
        Me.cmdClearEntry.TabIndex = 3
        Me.cmdClearEntry.TabStop = False
        Me.cmdClearEntry.Text = "CE"
        Me.cmdClearEntry.UseVisualStyleBackColor = True
        '
        'cmd7
        '
        Me.cmd7.Location = New System.Drawing.Point(164, 242)
        Me.cmd7.Name = "cmd7"
        Me.cmd7.Size = New System.Drawing.Size(54, 40)
        Me.cmd7.TabIndex = 4
        Me.cmd7.TabStop = False
        Me.cmd7.Text = "7"
        Me.cmd7.UseVisualStyleBackColor = True
        '
        'cmd8
        '
        Me.cmd8.Location = New System.Drawing.Point(224, 242)
        Me.cmd8.Name = "cmd8"
        Me.cmd8.Size = New System.Drawing.Size(54, 40)
        Me.cmd8.TabIndex = 5
        Me.cmd8.TabStop = False
        Me.cmd8.Text = "8"
        Me.cmd8.UseVisualStyleBackColor = True
        '
        'cmd9
        '
        Me.cmd9.Location = New System.Drawing.Point(284, 242)
        Me.cmd9.Name = "cmd9"
        Me.cmd9.Size = New System.Drawing.Size(54, 40)
        Me.cmd9.TabIndex = 6
        Me.cmd9.TabStop = False
        Me.cmd9.Text = "9"
        Me.cmd9.UseVisualStyleBackColor = True
        '
        'cmd6
        '
        Me.cmd6.Location = New System.Drawing.Point(284, 288)
        Me.cmd6.Name = "cmd6"
        Me.cmd6.Size = New System.Drawing.Size(54, 40)
        Me.cmd6.TabIndex = 9
        Me.cmd6.TabStop = False
        Me.cmd6.Text = "6"
        Me.cmd6.UseVisualStyleBackColor = True
        '
        'cmd5
        '
        Me.cmd5.Location = New System.Drawing.Point(224, 288)
        Me.cmd5.Name = "cmd5"
        Me.cmd5.Size = New System.Drawing.Size(54, 40)
        Me.cmd5.TabIndex = 8
        Me.cmd5.TabStop = False
        Me.cmd5.Text = "5"
        Me.cmd5.UseVisualStyleBackColor = True
        '
        'cmd4
        '
        Me.cmd4.Location = New System.Drawing.Point(164, 288)
        Me.cmd4.Name = "cmd4"
        Me.cmd4.Size = New System.Drawing.Size(54, 40)
        Me.cmd4.TabIndex = 7
        Me.cmd4.TabStop = False
        Me.cmd4.Text = "4"
        Me.cmd4.UseVisualStyleBackColor = True
        '
        'cmd3
        '
        Me.cmd3.Location = New System.Drawing.Point(284, 334)
        Me.cmd3.Name = "cmd3"
        Me.cmd3.Size = New System.Drawing.Size(54, 40)
        Me.cmd3.TabIndex = 12
        Me.cmd3.TabStop = False
        Me.cmd3.Text = "3"
        Me.cmd3.UseVisualStyleBackColor = True
        '
        'cmd2
        '
        Me.cmd2.Location = New System.Drawing.Point(224, 334)
        Me.cmd2.Name = "cmd2"
        Me.cmd2.Size = New System.Drawing.Size(54, 40)
        Me.cmd2.TabIndex = 11
        Me.cmd2.TabStop = False
        Me.cmd2.Text = "2"
        Me.cmd2.UseVisualStyleBackColor = True
        '
        'cmd1
        '
        Me.cmd1.Location = New System.Drawing.Point(164, 334)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(54, 40)
        Me.cmd1.TabIndex = 10
        Me.cmd1.TabStop = False
        Me.cmd1.Text = "1"
        Me.cmd1.UseVisualStyleBackColor = True
        '
        'cmd0
        '
        Me.cmd0.Location = New System.Drawing.Point(164, 380)
        Me.cmd0.Name = "cmd0"
        Me.cmd0.Size = New System.Drawing.Size(114, 40)
        Me.cmd0.TabIndex = 13
        Me.cmd0.TabStop = False
        Me.cmd0.Text = "0"
        Me.cmd0.UseVisualStyleBackColor = True
        '
        'cmdDecimal
        '
        Me.cmdDecimal.Location = New System.Drawing.Point(284, 380)
        Me.cmdDecimal.Name = "cmdDecimal"
        Me.cmdDecimal.Size = New System.Drawing.Size(54, 40)
        Me.cmdDecimal.TabIndex = 14
        Me.cmdDecimal.TabStop = False
        Me.cmdDecimal.Text = "."
        Me.cmdDecimal.UseVisualStyleBackColor = True
        '
        'txtAnswer
        '
        Me.txtAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.Location = New System.Drawing.Point(160, 98)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.ReadOnly = True
        Me.txtAnswer.Size = New System.Drawing.Size(174, 26)
        Me.txtAnswer.TabIndex = 15
        Me.txtAnswer.Text = "0"
        '
        'lblShape
        '
        Me.lblShape.AutoSize = True
        Me.lblShape.Location = New System.Drawing.Point(22, 216)
        Me.lblShape.Name = "lblShape"
        Me.lblShape.Size = New System.Drawing.Size(41, 13)
        Me.lblShape.TabIndex = 16
        Me.lblShape.Text = "Shape:"
        '
        'lblFormula
        '
        Me.lblFormula.AutoSize = True
        Me.lblFormula.Location = New System.Drawing.Point(22, 336)
        Me.lblFormula.Name = "lblFormula"
        Me.lblFormula.Size = New System.Drawing.Size(47, 13)
        Me.lblFormula.TabIndex = 17
        Me.lblFormula.Text = "Formula:"
        '
        'grpConvertAnswer
        '
        Me.grpConvertAnswer.Controls.Add(Me.optCentimeters)
        Me.grpConvertAnswer.Controls.Add(Me.optInches)
        Me.grpConvertAnswer.Location = New System.Drawing.Point(164, 159)
        Me.grpConvertAnswer.Name = "grpConvertAnswer"
        Me.grpConvertAnswer.Size = New System.Drawing.Size(170, 43)
        Me.grpConvertAnswer.TabIndex = 18
        Me.grpConvertAnswer.TabStop = False
        Me.grpConvertAnswer.Text = "Convert Answer:"
        Me.grpConvertAnswer.Visible = False
        '
        'optCentimeters
        '
        Me.optCentimeters.AutoSize = True
        Me.optCentimeters.Location = New System.Drawing.Point(89, 19)
        Me.optCentimeters.Name = "optCentimeters"
        Me.optCentimeters.Size = New System.Drawing.Size(14, 13)
        Me.optCentimeters.TabIndex = 1
        Me.optCentimeters.TabStop = True
        Me.optCentimeters.UseVisualStyleBackColor = True
        '
        'optInches
        '
        Me.optInches.AutoSize = True
        Me.optInches.Location = New System.Drawing.Point(6, 19)
        Me.optInches.Name = "optInches"
        Me.optInches.Size = New System.Drawing.Size(14, 13)
        Me.optInches.TabIndex = 0
        Me.optInches.TabStop = True
        Me.optInches.UseVisualStyleBackColor = True
        '
        'txtRadius
        '
        Me.txtRadius.Location = New System.Drawing.Point(496, 18)
        Me.txtRadius.Name = "txtRadius"
        Me.txtRadius.Size = New System.Drawing.Size(334, 20)
        Me.txtRadius.TabIndex = 0
        Me.txtRadius.Visible = False
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(496, 98)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(334, 20)
        Me.txtLength.TabIndex = 3
        Me.txtLength.Visible = False
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(496, 124)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(334, 20)
        Me.txtWidth.TabIndex = 4
        Me.txtWidth.Visible = False
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(496, 72)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(334, 20)
        Me.txtHeight.TabIndex = 2
        Me.txtHeight.Visible = False
        '
        'lblRadius
        '
        Me.lblRadius.AutoSize = True
        Me.lblRadius.Location = New System.Drawing.Point(449, 21)
        Me.lblRadius.Name = "lblRadius"
        Me.lblRadius.Size = New System.Drawing.Size(43, 13)
        Me.lblRadius.TabIndex = 23
        Me.lblRadius.Text = "Radius:"
        Me.lblRadius.Visible = False
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(449, 101)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(43, 13)
        Me.lblLength.TabIndex = 24
        Me.lblLength.Text = "Length:"
        Me.lblLength.Visible = False
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(449, 127)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(38, 13)
        Me.lblWidth.TabIndex = 25
        Me.lblWidth.Text = "Width:"
        Me.lblWidth.Visible = False
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(449, 75)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(41, 13)
        Me.lblHeight.TabIndex = 26
        Me.lblHeight.Text = "Height:"
        Me.lblHeight.Visible = False
        '
        'txtBase
        '
        Me.txtBase.Location = New System.Drawing.Point(496, 44)
        Me.txtBase.Name = "txtBase"
        Me.txtBase.Size = New System.Drawing.Size(334, 20)
        Me.txtBase.TabIndex = 1
        Me.txtBase.Visible = False
        '
        'lblBase
        '
        Me.lblBase.AutoSize = True
        Me.lblBase.Location = New System.Drawing.Point(449, 47)
        Me.lblBase.Name = "lblBase"
        Me.lblBase.Size = New System.Drawing.Size(34, 13)
        Me.lblBase.TabIndex = 28
        Me.lblBase.Text = "Base:"
        Me.lblBase.Visible = False
        '
        'cmdCalculate
        '
        Me.cmdCalculate.Location = New System.Drawing.Point(355, 208)
        Me.cmdCalculate.Name = "cmdCalculate"
        Me.cmdCalculate.Size = New System.Drawing.Size(51, 212)
        Me.cmdCalculate.TabIndex = 29
        Me.cmdCalculate.Text = "C" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "l" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "c" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "u" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "l" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "t" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "e" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.cmdCalculate.UseVisualStyleBackColor = True
        '
        'picMathImage
        '
        Me.picMathImage.Location = New System.Drawing.Point(452, 167)
        Me.picMathImage.Name = "picMathImage"
        Me.picMathImage.Size = New System.Drawing.Size(392, 253)
        Me.picMathImage.TabIndex = 30
        Me.picMathImage.TabStop = False
        '
        'lblFinalAnswer
        '
        Me.lblFinalAnswer.AutoSize = True
        Me.lblFinalAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalAnswer.Location = New System.Drawing.Point(86, 102)
        Me.lblFinalAnswer.Name = "lblFinalAnswer"
        Me.lblFinalAnswer.Size = New System.Drawing.Size(68, 18)
        Me.lblFinalAnswer.TabIndex = 31
        Me.lblFinalAnswer.Text = "Answer:"
        Me.lblFinalAnswer.Visible = False
        '
        'mdiCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(882, 448)
        Me.Controls.Add(Me.lblFinalAnswer)
        Me.Controls.Add(Me.picMathImage)
        Me.Controls.Add(Me.cmdCalculate)
        Me.Controls.Add(Me.lblBase)
        Me.Controls.Add(Me.txtBase)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.lblRadius)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.txtRadius)
        Me.Controls.Add(Me.grpConvertAnswer)
        Me.Controls.Add(Me.lblFormula)
        Me.Controls.Add(Me.lblShape)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.cmdDecimal)
        Me.Controls.Add(Me.cmd0)
        Me.Controls.Add(Me.cmd3)
        Me.Controls.Add(Me.cmd2)
        Me.Controls.Add(Me.cmd1)
        Me.Controls.Add(Me.cmd6)
        Me.Controls.Add(Me.cmd5)
        Me.Controls.Add(Me.cmd4)
        Me.Controls.Add(Me.cmd9)
        Me.Controls.Add(Me.cmd8)
        Me.Controls.Add(Me.cmd7)
        Me.Controls.Add(Me.cmdClearEntry)
        Me.Controls.Add(Me.cmdClearAll)
        Me.Controls.Add(Me.lstFormula)
        Me.Controls.Add(Me.lstShape)
        Me.Name = "mdiCalculator"
        Me.Text = "Calculator"
        Me.grpConvertAnswer.ResumeLayout(False)
        Me.grpConvertAnswer.PerformLayout()
        CType(Me.picMathImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstShape As ListBox
    Friend WithEvents lstFormula As ListBox
    Friend WithEvents cmdClearAll As Button
    Friend WithEvents cmdClearEntry As Button
    Friend WithEvents cmd7 As Button
    Friend WithEvents cmd8 As Button
    Friend WithEvents cmd9 As Button
    Friend WithEvents cmd6 As Button
    Friend WithEvents cmd5 As Button
    Friend WithEvents cmd4 As Button
    Friend WithEvents cmd3 As Button
    Friend WithEvents cmd2 As Button
    Friend WithEvents cmd1 As Button
    Friend WithEvents cmd0 As Button
    Friend WithEvents cmdDecimal As Button
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents lblShape As Label
    Friend WithEvents lblFormula As Label
    Friend WithEvents grpConvertAnswer As GroupBox
    Friend WithEvents txtRadius As TextBox
    Friend WithEvents txtLength As TextBox
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents lblRadius As Label
    Friend WithEvents lblLength As Label
    Friend WithEvents lblWidth As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents txtBase As TextBox
    Friend WithEvents lblBase As Label
    Friend WithEvents cmdCalculate As Button
    Friend WithEvents picMathImage As PictureBox
    Friend WithEvents optCentimeters As RadioButton
    Friend WithEvents optInches As RadioButton
    Friend WithEvents lblFinalAnswer As Label
End Class
