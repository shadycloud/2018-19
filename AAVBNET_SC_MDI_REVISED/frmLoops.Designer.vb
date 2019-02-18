<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoops
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
        Me.txtStart = New System.Windows.Forms.TextBox()
        Me.txtStop = New System.Windows.Forms.TextBox()
        Me.txtEnd = New System.Windows.Forms.TextBox()
        Me.txtInterestRate = New System.Windows.Forms.TextBox()
        Me.txtYears = New System.Windows.Forms.TextBox()
        Me.txtPrinciple = New System.Windows.Forms.TextBox()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.lblEnterGrade = New System.Windows.Forms.Label()
        Me.btnCalcGrade = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.btnForEachLoop = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblResultText = New System.Windows.Forms.Label()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.lblStopValue = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.btnWhileLoop = New System.Windows.Forms.Button()
        Me.btnUntilLoop = New System.Windows.Forms.Button()
        Me.btnDoWhileLoop = New System.Windows.Forms.Button()
        Me.btnForNextLoop = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblInterestRate = New System.Windows.Forms.Label()
        Me.lblYears = New System.Windows.Forms.Label()
        Me.lblPrinciple = New System.Windows.Forms.Label()
        Me.lblDisplayIntResult = New System.Windows.Forms.Label()
        Me.btnCalcInt = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtStart
        '
        Me.txtStart.Location = New System.Drawing.Point(165, 38)
        Me.txtStart.Name = "txtStart"
        Me.txtStart.Size = New System.Drawing.Size(100, 20)
        Me.txtStart.TabIndex = 0
        '
        'txtStop
        '
        Me.txtStop.Location = New System.Drawing.Point(165, 94)
        Me.txtStop.Name = "txtStop"
        Me.txtStop.Size = New System.Drawing.Size(100, 20)
        Me.txtStop.TabIndex = 1
        '
        'txtEnd
        '
        Me.txtEnd.Location = New System.Drawing.Point(165, 66)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Size = New System.Drawing.Size(100, 20)
        Me.txtEnd.TabIndex = 2
        '
        'txtInterestRate
        '
        Me.txtInterestRate.Location = New System.Drawing.Point(465, 318)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(100, 20)
        Me.txtInterestRate.TabIndex = 3
        Me.txtInterestRate.Text = ".5"
        '
        'txtYears
        '
        Me.txtYears.Location = New System.Drawing.Point(465, 339)
        Me.txtYears.Name = "txtYears"
        Me.txtYears.Size = New System.Drawing.Size(100, 20)
        Me.txtYears.TabIndex = 4
        Me.txtYears.Text = "8"
        '
        'txtPrinciple
        '
        Me.txtPrinciple.Location = New System.Drawing.Point(465, 297)
        Me.txtPrinciple.Name = "txtPrinciple"
        Me.txtPrinciple.Size = New System.Drawing.Size(100, 20)
        Me.txtPrinciple.TabIndex = 5
        Me.txtPrinciple.Text = "10"
        '
        'txtGrade
        '
        Me.txtGrade.Location = New System.Drawing.Point(146, 38)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(100, 20)
        Me.txtGrade.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblGrade)
        Me.GroupBox1.Controls.Add(Me.lblEnterGrade)
        Me.GroupBox1.Controls.Add(Me.btnCalcGrade)
        Me.GroupBox1.Controls.Add(Me.txtGrade)
        Me.GroupBox1.Location = New System.Drawing.Point(319, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 245)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Case"
        '
        'lblGrade
        '
        Me.lblGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrade.Location = New System.Drawing.Point(47, 84)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(199, 46)
        Me.lblGrade.TabIndex = 9
        Me.lblGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEnterGrade
        '
        Me.lblEnterGrade.AutoSize = True
        Me.lblEnterGrade.Location = New System.Drawing.Point(54, 44)
        Me.lblEnterGrade.Name = "lblEnterGrade"
        Me.lblEnterGrade.Size = New System.Drawing.Size(67, 13)
        Me.lblEnterGrade.TabIndex = 8
        Me.lblEnterGrade.Text = "Enter Grade:"
        '
        'btnCalcGrade
        '
        Me.btnCalcGrade.Location = New System.Drawing.Point(79, 164)
        Me.btnCalcGrade.Name = "btnCalcGrade"
        Me.btnCalcGrade.Size = New System.Drawing.Size(135, 23)
        Me.btnCalcGrade.TabIndex = 7
        Me.btnCalcGrade.Text = "Calculate Grade"
        Me.btnCalcGrade.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblDisplay)
        Me.GroupBox2.Controls.Add(Me.btnForEachLoop)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lblResultText)
        Me.GroupBox2.Controls.Add(Me.lblResults)
        Me.GroupBox2.Controls.Add(Me.lblEnd)
        Me.GroupBox2.Controls.Add(Me.lblStopValue)
        Me.GroupBox2.Controls.Add(Me.lblStart)
        Me.GroupBox2.Controls.Add(Me.btnWhileLoop)
        Me.GroupBox2.Controls.Add(Me.btnUntilLoop)
        Me.GroupBox2.Controls.Add(Me.btnDoWhileLoop)
        Me.GroupBox2.Controls.Add(Me.btnForNextLoop)
        Me.GroupBox2.Controls.Add(Me.txtEnd)
        Me.GroupBox2.Controls.Add(Me.txtStart)
        Me.GroupBox2.Controls.Add(Me.txtStop)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(301, 579)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Loops"
        '
        'lblDisplay
        '
        Me.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplay.Location = New System.Drawing.Point(51, 371)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(214, 177)
        Me.lblDisplay.TabIndex = 14
        '
        'btnForEachLoop
        '
        Me.btnForEachLoop.Location = New System.Drawing.Point(51, 322)
        Me.btnForEachLoop.Name = "btnForEachLoop"
        Me.btnForEachLoop.Size = New System.Drawing.Size(153, 23)
        Me.btnForEachLoop.TabIndex = 13
        Me.btnForEachLoop.Text = "For Each Loop"
        Me.btnForEachLoop.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(210, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 87)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "<This will loop at least once!"
        '
        'lblResultText
        '
        Me.lblResultText.AutoSize = True
        Me.lblResultText.Location = New System.Drawing.Point(69, 169)
        Me.lblResultText.Name = "lblResultText"
        Me.lblResultText.Size = New System.Drawing.Size(45, 13)
        Me.lblResultText.TabIndex = 11
        Me.lblResultText.Text = "Results:"
        '
        'lblResults
        '
        Me.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResults.Location = New System.Drawing.Point(128, 162)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(100, 20)
        Me.lblResults.TabIndex = 10
        '
        'lblEnd
        '
        Me.lblEnd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEnd.Location = New System.Drawing.Point(60, 66)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(100, 20)
        Me.lblEnd.TabIndex = 9
        Me.lblEnd.Text = "End:"
        Me.lblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStopValue
        '
        Me.lblStopValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStopValue.Location = New System.Drawing.Point(60, 94)
        Me.lblStopValue.Name = "lblStopValue"
        Me.lblStopValue.Size = New System.Drawing.Size(100, 20)
        Me.lblStopValue.TabIndex = 8
        Me.lblStopValue.Text = "Stop Value:"
        Me.lblStopValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStart
        '
        Me.lblStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStart.Location = New System.Drawing.Point(60, 38)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(100, 20)
        Me.lblStart.TabIndex = 7
        Me.lblStart.Text = "Start:"
        Me.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnWhileLoop
        '
        Me.btnWhileLoop.Location = New System.Drawing.Point(51, 293)
        Me.btnWhileLoop.Name = "btnWhileLoop"
        Me.btnWhileLoop.Size = New System.Drawing.Size(153, 23)
        Me.btnWhileLoop.TabIndex = 6
        Me.btnWhileLoop.Text = "While Loop"
        Me.btnWhileLoop.UseVisualStyleBackColor = True
        '
        'btnUntilLoop
        '
        Me.btnUntilLoop.Location = New System.Drawing.Point(51, 265)
        Me.btnUntilLoop.Name = "btnUntilLoop"
        Me.btnUntilLoop.Size = New System.Drawing.Size(153, 23)
        Me.btnUntilLoop.TabIndex = 5
        Me.btnUntilLoop.Text = "Until Loop"
        Me.btnUntilLoop.UseVisualStyleBackColor = True
        '
        'btnDoWhileLoop
        '
        Me.btnDoWhileLoop.Location = New System.Drawing.Point(51, 237)
        Me.btnDoWhileLoop.Name = "btnDoWhileLoop"
        Me.btnDoWhileLoop.Size = New System.Drawing.Size(153, 23)
        Me.btnDoWhileLoop.TabIndex = 4
        Me.btnDoWhileLoop.Text = "Do While Loop"
        Me.btnDoWhileLoop.UseVisualStyleBackColor = True
        '
        'btnForNextLoop
        '
        Me.btnForNextLoop.Location = New System.Drawing.Point(51, 209)
        Me.btnForNextLoop.Name = "btnForNextLoop"
        Me.btnForNextLoop.Size = New System.Drawing.Size(153, 23)
        Me.btnForNextLoop.TabIndex = 3
        Me.btnForNextLoop.Text = "For Next Loop"
        Me.btnForNextLoop.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblInterestRate)
        Me.GroupBox3.Controls.Add(Me.lblYears)
        Me.GroupBox3.Controls.Add(Me.lblPrinciple)
        Me.GroupBox3.Controls.Add(Me.lblDisplayIntResult)
        Me.GroupBox3.Controls.Add(Me.btnCalcInt)
        Me.GroupBox3.Location = New System.Drawing.Point(319, 263)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(296, 328)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Interest Calculator"
        '
        'lblInterestRate
        '
        Me.lblInterestRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInterestRate.Location = New System.Drawing.Point(40, 55)
        Me.lblInterestRate.Name = "lblInterestRate"
        Me.lblInterestRate.Size = New System.Drawing.Size(100, 20)
        Me.lblInterestRate.TabIndex = 18
        Me.lblInterestRate.Text = "Interest Rate:"
        Me.lblInterestRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblYears
        '
        Me.lblYears.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYears.Location = New System.Drawing.Point(40, 75)
        Me.lblYears.Name = "lblYears"
        Me.lblYears.Size = New System.Drawing.Size(100, 20)
        Me.lblYears.TabIndex = 17
        Me.lblYears.Text = "Years:"
        Me.lblYears.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrinciple
        '
        Me.lblPrinciple.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrinciple.Location = New System.Drawing.Point(40, 35)
        Me.lblPrinciple.Name = "lblPrinciple"
        Me.lblPrinciple.Size = New System.Drawing.Size(100, 20)
        Me.lblPrinciple.TabIndex = 16
        Me.lblPrinciple.Text = "Principle:"
        Me.lblPrinciple.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDisplayIntResult
        '
        Me.lblDisplayIntResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplayIntResult.Location = New System.Drawing.Point(32, 160)
        Me.lblDisplayIntResult.Name = "lblDisplayIntResult"
        Me.lblDisplayIntResult.Size = New System.Drawing.Size(214, 137)
        Me.lblDisplayIntResult.TabIndex = 15
        '
        'btnCalcInt
        '
        Me.btnCalcInt.Location = New System.Drawing.Point(37, 116)
        Me.btnCalcInt.Name = "btnCalcInt"
        Me.btnCalcInt.Size = New System.Drawing.Size(135, 23)
        Me.btnCalcInt.TabIndex = 8
        Me.btnCalcInt.Text = "Calculate Interest"
        Me.btnCalcInt.UseVisualStyleBackColor = True
        '
        'frmLoops
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 600)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtPrinciple)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtYears)
        Me.Controls.Add(Me.txtInterestRate)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "frmLoops"
        Me.Text = "The Loops Program"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtStart As System.Windows.Forms.TextBox
    Friend WithEvents txtStop As System.Windows.Forms.TextBox
    Friend WithEvents txtEnd As System.Windows.Forms.TextBox
    Friend WithEvents txtInterestRate As System.Windows.Forms.TextBox
    Friend WithEvents txtYears As System.Windows.Forms.TextBox
    Friend WithEvents txtPrinciple As System.Windows.Forms.TextBox
    Friend WithEvents txtGrade As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCalcGrade As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblEnd As System.Windows.Forms.Label
    Friend WithEvents lblStopValue As System.Windows.Forms.Label
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents btnWhileLoop As System.Windows.Forms.Button
    Friend WithEvents btnUntilLoop As System.Windows.Forms.Button
    Friend WithEvents btnDoWhileLoop As System.Windows.Forms.Button
    Friend WithEvents btnForNextLoop As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCalcInt As System.Windows.Forms.Button
    Friend WithEvents lblResultText As System.Windows.Forms.Label
    Friend WithEvents lblResults As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnForEachLoop As System.Windows.Forms.Button
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents lblDisplayIntResult As System.Windows.Forms.Label
    Friend WithEvents lblInterestRate As System.Windows.Forms.Label
    Friend WithEvents lblYears As System.Windows.Forms.Label
    Friend WithEvents lblPrinciple As System.Windows.Forms.Label
    Friend WithEvents lblGrade As System.Windows.Forms.Label
    Friend WithEvents lblEnterGrade As System.Windows.Forms.Label
End Class
