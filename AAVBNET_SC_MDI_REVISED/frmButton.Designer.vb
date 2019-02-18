<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmButton
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
        Me.lblWhichButton = New System.Windows.Forms.Label()
        Me.ChkLeft = New System.Windows.Forms.CheckBox()
        Me.ChkCenter = New System.Windows.Forms.CheckBox()
        Me.ChkRight = New System.Windows.Forms.CheckBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblWheelRotate = New System.Windows.Forms.Label()
        Me.pbWheelRotation = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'lblWhichButton
        '
        Me.lblWhichButton.Location = New System.Drawing.Point(13, 66)
        Me.lblWhichButton.Name = "lblWhichButton"
        Me.lblWhichButton.Size = New System.Drawing.Size(259, 23)
        Me.lblWhichButton.TabIndex = 0
        Me.lblWhichButton.Text = "Please Click on a Button"
        Me.lblWhichButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChkLeft
        '
        Me.ChkLeft.AutoSize = True
        Me.ChkLeft.Location = New System.Drawing.Point(27, 114)
        Me.ChkLeft.Name = "ChkLeft"
        Me.ChkLeft.Size = New System.Drawing.Size(44, 17)
        Me.ChkLeft.TabIndex = 1
        Me.ChkLeft.Text = "Left"
        Me.ChkLeft.UseVisualStyleBackColor = True
        '
        'ChkCenter
        '
        Me.ChkCenter.AutoSize = True
        Me.ChkCenter.Location = New System.Drawing.Point(114, 114)
        Me.ChkCenter.Name = "ChkCenter"
        Me.ChkCenter.Size = New System.Drawing.Size(57, 17)
        Me.ChkCenter.TabIndex = 2
        Me.ChkCenter.Text = "Center"
        Me.ChkCenter.UseVisualStyleBackColor = True
        '
        'ChkRight
        '
        Me.ChkRight.AutoSize = True
        Me.ChkRight.Location = New System.Drawing.Point(206, 114)
        Me.ChkRight.Name = "ChkRight"
        Me.ChkRight.Size = New System.Drawing.Size(51, 17)
        Me.ChkRight.TabIndex = 3
        Me.ChkRight.Text = "Right"
        Me.ChkRight.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(60, 216)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(177, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblWheelRotate
        '
        Me.lblWheelRotate.Location = New System.Drawing.Point(15, 145)
        Me.lblWheelRotate.Name = "lblWheelRotate"
        Me.lblWheelRotate.Size = New System.Drawing.Size(258, 23)
        Me.lblWheelRotate.TabIndex = 5
        Me.lblWheelRotate.Text = "Progress Bar Value = 0"
        Me.lblWheelRotate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbWheelRotation
        '
        Me.pbWheelRotation.Location = New System.Drawing.Point(49, 171)
        Me.pbWheelRotation.Maximum = 1000
        Me.pbWheelRotation.MaximumSize = New System.Drawing.Size(0, 1000)
        Me.pbWheelRotation.Name = "pbWheelRotation"
        Me.pbWheelRotation.Size = New System.Drawing.Size(0, 23)
        Me.pbWheelRotation.Step = 30
        Me.pbWheelRotation.TabIndex = 6
        Me.pbWheelRotation.Value = 500
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(18, 171)
        Me.ProgressBar1.Maximum = 1000
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(254, 23)
        Me.ProgressBar1.Step = 30
        Me.ProgressBar1.TabIndex = 7
        Me.ProgressBar1.Value = 500
        '
        'frmButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.pbWheelRotation)
        Me.Controls.Add(Me.lblWheelRotate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.ChkRight)
        Me.Controls.Add(Me.ChkCenter)
        Me.Controls.Add(Me.ChkLeft)
        Me.Controls.Add(Me.lblWhichButton)
        Me.Name = "frmButton"
        Me.Text = "The Button Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWhichButton As System.Windows.Forms.Label
    Friend WithEvents ChkLeft As System.Windows.Forms.CheckBox
    Friend WithEvents ChkCenter As System.Windows.Forms.CheckBox
    Friend WithEvents ChkRight As System.Windows.Forms.CheckBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblWheelRotate As System.Windows.Forms.Label
    Friend WithEvents pbWheelRotation As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class
