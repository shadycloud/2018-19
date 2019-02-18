<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClock
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
        Me.btnClock = New System.Windows.Forms.Button()
        Me.tmrClock = New System.Windows.Forms.Timer(Me.components)
        Me.lblClock = New System.Windows.Forms.Label()
        Me.rbTwoSeconds = New System.Windows.Forms.RadioButton()
        Me.rbOneSecond = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'btnClock
        '
        Me.btnClock.Location = New System.Drawing.Point(76, 170)
        Me.btnClock.Name = "btnClock"
        Me.btnClock.Size = New System.Drawing.Size(131, 23)
        Me.btnClock.TabIndex = 0
        Me.btnClock.Text = "Turn On Clock"
        Me.btnClock.UseVisualStyleBackColor = True
        '
        'tmrClock
        '
        Me.tmrClock.Interval = 1000
        '
        'lblClock
        '
        Me.lblClock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClock.Location = New System.Drawing.Point(12, 9)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(260, 118)
        Me.lblClock.TabIndex = 1
        '
        'rbTwoSeconds
        '
        Me.rbTwoSeconds.AutoSize = True
        Me.rbTwoSeconds.Location = New System.Drawing.Point(100, 231)
        Me.rbTwoSeconds.Name = "rbTwoSeconds"
        Me.rbTwoSeconds.Size = New System.Drawing.Size(91, 17)
        Me.rbTwoSeconds.TabIndex = 2
        Me.rbTwoSeconds.TabStop = True
        Me.rbTwoSeconds.Text = "Two Seconds"
        Me.rbTwoSeconds.UseVisualStyleBackColor = True
        '
        'rbOneSecond
        '
        Me.rbOneSecond.AutoSize = True
        Me.rbOneSecond.Checked = True
        Me.rbOneSecond.Location = New System.Drawing.Point(100, 208)
        Me.rbOneSecond.Name = "rbOneSecond"
        Me.rbOneSecond.Size = New System.Drawing.Size(85, 17)
        Me.rbOneSecond.TabIndex = 3
        Me.rbOneSecond.TabStop = True
        Me.rbOneSecond.Text = "One Second"
        Me.rbOneSecond.UseVisualStyleBackColor = True
        '
        'frmClock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.rbOneSecond)
        Me.Controls.Add(Me.rbTwoSeconds)
        Me.Controls.Add(Me.lblClock)
        Me.Controls.Add(Me.btnClock)
        Me.Name = "frmClock"
        Me.Text = "The Clock Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClock As System.Windows.Forms.Button
    Friend WithEvents tmrClock As System.Windows.Forms.Timer
    Friend WithEvents lblClock As System.Windows.Forms.Label
    Friend WithEvents rbTwoSeconds As System.Windows.Forms.RadioButton
    Friend WithEvents rbOneSecond As System.Windows.Forms.RadioButton
End Class
