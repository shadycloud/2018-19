<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpeed
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
        Me.hsbSpeed = New System.Windows.Forms.HScrollBar()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'hsbSpeed
        '
        Me.hsbSpeed.LargeChange = 30
        Me.hsbSpeed.Location = New System.Drawing.Point(39, 106)
        Me.hsbSpeed.Name = "hsbSpeed"
        Me.hsbSpeed.Size = New System.Drawing.Size(219, 39)
        Me.hsbSpeed.SmallChange = 10
        Me.hsbSpeed.TabIndex = 0
        Me.hsbSpeed.Value = 50
        '
        'lblSpeed
        '
        Me.lblSpeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSpeed.Location = New System.Drawing.Point(39, 54)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(219, 35)
        Me.lblSpeed.TabIndex = 1
        Me.lblSpeed.Text = "50 mph"
        Me.lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(39, 163)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(219, 42)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmSpeed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblSpeed)
        Me.Controls.Add(Me.hsbSpeed)
        Me.Name = "frmSpeed"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Text = "The Speed Program"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents hsbSpeed As System.Windows.Forms.HScrollBar
    Friend WithEvents lblSpeed As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
