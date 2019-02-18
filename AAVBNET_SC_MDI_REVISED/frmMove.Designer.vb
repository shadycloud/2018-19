<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMove
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMove))
        Me.rbBell = New System.Windows.Forms.RadioButton()
        Me.rbClock = New System.Windows.Forms.RadioButton()
        Me.rbCup = New System.Windows.Forms.RadioButton()
        Me.pbClock = New System.Windows.Forms.PictureBox()
        Me.pbCup = New System.Windows.Forms.PictureBox()
        Me.pbBell = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.pbClock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBell, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbBell
        '
        Me.rbBell.AutoSize = True
        Me.rbBell.Location = New System.Drawing.Point(60, 178)
        Me.rbBell.Name = "rbBell"
        Me.rbBell.Size = New System.Drawing.Size(42, 17)
        Me.rbBell.TabIndex = 0
        Me.rbBell.Text = "Bell"
        Me.rbBell.UseVisualStyleBackColor = True
        '
        'rbClock
        '
        Me.rbClock.AutoSize = True
        Me.rbClock.Location = New System.Drawing.Point(60, 155)
        Me.rbClock.Name = "rbClock"
        Me.rbClock.Size = New System.Drawing.Size(52, 17)
        Me.rbClock.TabIndex = 1
        Me.rbClock.Text = "Clock"
        Me.rbClock.UseVisualStyleBackColor = True
        '
        'rbCup
        '
        Me.rbCup.AutoSize = True
        Me.rbCup.Checked = True
        Me.rbCup.Location = New System.Drawing.Point(60, 132)
        Me.rbCup.Name = "rbCup"
        Me.rbCup.Size = New System.Drawing.Size(44, 17)
        Me.rbCup.TabIndex = 2
        Me.rbCup.TabStop = True
        Me.rbCup.Text = "Cup"
        Me.rbCup.UseVisualStyleBackColor = True
        '
        'pbClock
        '
        Me.pbClock.Image = CType(resources.GetObject("pbClock.Image"), System.Drawing.Image)
        Me.pbClock.Location = New System.Drawing.Point(76, 23)
        Me.pbClock.Name = "pbClock"
        Me.pbClock.Size = New System.Drawing.Size(24, 22)
        Me.pbClock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbClock.TabIndex = 3
        Me.pbClock.TabStop = False
        '
        'pbCup
        '
        Me.pbCup.Image = CType(resources.GetObject("pbCup.Image"), System.Drawing.Image)
        Me.pbCup.Location = New System.Drawing.Point(124, 23)
        Me.pbCup.Name = "pbCup"
        Me.pbCup.Size = New System.Drawing.Size(24, 22)
        Me.pbCup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbCup.TabIndex = 4
        Me.pbCup.TabStop = False
        '
        'pbBell
        '
        Me.pbBell.Image = CType(resources.GetObject("pbBell.Image"), System.Drawing.Image)
        Me.pbBell.Location = New System.Drawing.Point(167, 23)
        Me.pbBell.Name = "pbBell"
        Me.pbBell.Size = New System.Drawing.Size(24, 22)
        Me.pbBell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbBell.TabIndex = 5
        Me.pbBell.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(60, 215)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(168, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMove
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.pbBell)
        Me.Controls.Add(Me.pbCup)
        Me.Controls.Add(Me.pbClock)
        Me.Controls.Add(Me.rbCup)
        Me.Controls.Add(Me.rbClock)
        Me.Controls.Add(Me.rbBell)
        Me.Name = "frmMove"
        Me.Text = "The Move Program"
        CType(Me.pbClock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBell, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbBell As System.Windows.Forms.RadioButton
    Friend WithEvents rbClock As System.Windows.Forms.RadioButton
    Friend WithEvents rbCup As System.Windows.Forms.RadioButton
    Friend WithEvents pbClock As System.Windows.Forms.PictureBox
    Friend WithEvents pbCup As System.Windows.Forms.PictureBox
    Friend WithEvents pbBell As System.Windows.Forms.PictureBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
