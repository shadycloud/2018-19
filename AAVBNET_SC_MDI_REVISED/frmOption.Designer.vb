<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOption
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.chkSound = New System.Windows.Forms.CheckBox()
        Me.chkMouse = New System.Windows.Forms.CheckBox()
        Me.chkColors = New System.Windows.Forms.CheckBox()
        Me.rbLevel1 = New System.Windows.Forms.RadioButton()
        Me.rbLevel2 = New System.Windows.Forms.RadioButton()
        Me.rbLevel3 = New System.Windows.Forms.RadioButton()
        Me.cbGroupBox = New System.Windows.Forms.GroupBox()
        Me.rbGroupBox = New System.Windows.Forms.GroupBox()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblMouse = New System.Windows.Forms.Label()
        Me.lblSound = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.cbGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(13, 276)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(354, 46)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'chkSound
        '
        Me.chkSound.AutoSize = True
        Me.chkSound.Checked = True
        Me.chkSound.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSound.Location = New System.Drawing.Point(20, 129)
        Me.chkSound.Name = "chkSound"
        Me.chkSound.Size = New System.Drawing.Size(57, 17)
        Me.chkSound.TabIndex = 1
        Me.chkSound.Text = "&Sound"
        Me.chkSound.UseVisualStyleBackColor = True
        '
        'chkMouse
        '
        Me.chkMouse.AutoSize = True
        Me.chkMouse.Checked = True
        Me.chkMouse.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMouse.Location = New System.Drawing.Point(19, 89)
        Me.chkMouse.Name = "chkMouse"
        Me.chkMouse.Size = New System.Drawing.Size(58, 17)
        Me.chkMouse.TabIndex = 2
        Me.chkMouse.Text = "&Mouse"
        Me.chkMouse.UseVisualStyleBackColor = True
        '
        'chkColors
        '
        Me.chkColors.AutoSize = True
        Me.chkColors.Checked = True
        Me.chkColors.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkColors.Location = New System.Drawing.Point(19, 51)
        Me.chkColors.Name = "chkColors"
        Me.chkColors.Size = New System.Drawing.Size(55, 17)
        Me.chkColors.TabIndex = 3
        Me.chkColors.Text = "&Colors"
        Me.chkColors.UseVisualStyleBackColor = True
        '
        'rbLevel1
        '
        Me.rbLevel1.AutoSize = True
        Me.rbLevel1.Checked = True
        Me.rbLevel1.Location = New System.Drawing.Point(259, 74)
        Me.rbLevel1.Name = "rbLevel1"
        Me.rbLevel1.Size = New System.Drawing.Size(60, 17)
        Me.rbLevel1.TabIndex = 4
        Me.rbLevel1.TabStop = True
        Me.rbLevel1.Text = "Level &1"
        Me.rbLevel1.UseVisualStyleBackColor = True
        '
        'rbLevel2
        '
        Me.rbLevel2.AutoSize = True
        Me.rbLevel2.Location = New System.Drawing.Point(259, 112)
        Me.rbLevel2.Name = "rbLevel2"
        Me.rbLevel2.Size = New System.Drawing.Size(60, 17)
        Me.rbLevel2.TabIndex = 5
        Me.rbLevel2.TabStop = True
        Me.rbLevel2.Text = "Level &2"
        Me.rbLevel2.UseVisualStyleBackColor = True
        '
        'rbLevel3
        '
        Me.rbLevel3.AutoSize = True
        Me.rbLevel3.Location = New System.Drawing.Point(259, 151)
        Me.rbLevel3.Name = "rbLevel3"
        Me.rbLevel3.Size = New System.Drawing.Size(60, 17)
        Me.rbLevel3.TabIndex = 6
        Me.rbLevel3.TabStop = True
        Me.rbLevel3.Text = "Level &3"
        Me.rbLevel3.UseVisualStyleBackColor = True
        '
        'cbGroupBox
        '
        Me.cbGroupBox.Controls.Add(Me.chkSound)
        Me.cbGroupBox.Controls.Add(Me.chkColors)
        Me.cbGroupBox.Controls.Add(Me.chkMouse)
        Me.cbGroupBox.Location = New System.Drawing.Point(13, 23)
        Me.cbGroupBox.Name = "cbGroupBox"
        Me.cbGroupBox.Size = New System.Drawing.Size(132, 212)
        Me.cbGroupBox.TabIndex = 7
        Me.cbGroupBox.TabStop = False
        Me.cbGroupBox.Text = "Check Boxes"
        '
        'rbGroupBox
        '
        Me.rbGroupBox.Location = New System.Drawing.Point(248, 23)
        Me.rbGroupBox.Name = "rbGroupBox"
        Me.rbGroupBox.Size = New System.Drawing.Size(119, 212)
        Me.rbGroupBox.TabIndex = 8
        Me.rbGroupBox.TabStop = False
        Me.rbGroupBox.Text = "Radio Buttons"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(158, 74)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(56, 13)
        Me.lblColor.TabIndex = 9
        Me.lblColor.Text = "Colors: On"
        '
        'lblMouse
        '
        Me.lblMouse.AutoSize = True
        Me.lblMouse.Location = New System.Drawing.Point(158, 112)
        Me.lblMouse.Name = "lblMouse"
        Me.lblMouse.Size = New System.Drawing.Size(59, 13)
        Me.lblMouse.TabIndex = 10
        Me.lblMouse.Text = "Mouse: On"
        '
        'lblSound
        '
        Me.lblSound.AutoSize = True
        Me.lblSound.Location = New System.Drawing.Point(158, 152)
        Me.lblSound.Name = "lblSound"
        Me.lblSound.Size = New System.Drawing.Size(58, 13)
        Me.lblSound.TabIndex = 11
        Me.lblSound.Text = "Sound: On"
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Location = New System.Drawing.Point(158, 191)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(36, 13)
        Me.lblLevel.TabIndex = 12
        Me.lblLevel.Text = "Level:"
        '
        'frmOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 334)
        Me.Controls.Add(Me.lblLevel)
        Me.Controls.Add(Me.lblSound)
        Me.Controls.Add(Me.lblMouse)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.rbLevel3)
        Me.Controls.Add(Me.rbLevel2)
        Me.Controls.Add(Me.rbLevel1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.cbGroupBox)
        Me.Controls.Add(Me.rbGroupBox)
        Me.Name = "frmOption"
        Me.Text = "The Option Program"
        Me.cbGroupBox.ResumeLayout(False)
        Me.cbGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents chkSound As System.Windows.Forms.CheckBox
    Friend WithEvents chkMouse As System.Windows.Forms.CheckBox
    Friend WithEvents chkColors As System.Windows.Forms.CheckBox
    Friend WithEvents rbLevel1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbLevel2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbLevel3 As System.Windows.Forms.RadioButton
    Friend WithEvents cbGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents rbGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents lblColor As System.Windows.Forms.Label
    Friend WithEvents lblMouse As System.Windows.Forms.Label
    Friend WithEvents lblSound As System.Windows.Forms.Label
    Friend WithEvents lblLevel As System.Windows.Forms.Label
End Class
