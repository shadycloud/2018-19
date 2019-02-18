<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHello
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
        Me.btnHello = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblHello = New System.Windows.Forms.Label()
        Me.txtHello = New System.Windows.Forms.TextBox()
        Me.lblTop = New System.Windows.Forms.Label()
        Me.lblLeft = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.FlatAppearance.BorderSize = 5
        Me.btnExit.Location = New System.Drawing.Point(25, 118)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(225, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnHello
        '
        Me.btnHello.FlatAppearance.BorderSize = 5
        Me.btnHello.Location = New System.Drawing.Point(25, 89)
        Me.btnHello.Name = "btnHello"
        Me.btnHello.Size = New System.Drawing.Size(75, 23)
        Me.btnHello.TabIndex = 1
        Me.btnHello.Text = "&Hello"
        Me.btnHello.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.FlatAppearance.BorderSize = 5
        Me.btnPrint.Location = New System.Drawing.Point(100, 89)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.FlatAppearance.BorderSize = 5
        Me.btnClear.Location = New System.Drawing.Point(175, 89)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblHello
        '
        Me.lblHello.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHello.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHello.Location = New System.Drawing.Point(25, 14)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(225, 46)
        Me.lblHello.TabIndex = 4
        Me.lblHello.Text = "  Click on a Button"
        Me.lblHello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtHello
        '
        Me.txtHello.Location = New System.Drawing.Point(25, 63)
        Me.txtHello.Name = "txtHello"
        Me.txtHello.Size = New System.Drawing.Size(225, 20)
        Me.txtHello.TabIndex = 5
        '
        'lblTop
        '
        Me.lblTop.AutoSize = True
        Me.lblTop.Location = New System.Drawing.Point(22, 155)
        Me.lblTop.Name = "lblTop"
        Me.lblTop.Size = New System.Drawing.Size(0, 13)
        Me.lblTop.TabIndex = 6
        '
        'lblLeft
        '
        Me.lblLeft.Location = New System.Drawing.Point(22, 179)
        Me.lblLeft.Name = "lblLeft"
        Me.lblLeft.Size = New System.Drawing.Size(100, 23)
        Me.lblLeft.TabIndex = 7
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(22, 202)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(0, 13)
        Me.lblHeight.TabIndex = 8
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(22, 227)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(0, 13)
        Me.lblWidth.TabIndex = 9
        '
        'frmHello
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 288)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.lblLeft)
        Me.Controls.Add(Me.lblTop)
        Me.Controls.Add(Me.txtHello)
        Me.Controls.Add(Me.lblHello)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnHello)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "frmHello"
        Me.Text = "The Hello Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnHello As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblHello As System.Windows.Forms.Label
    Friend WithEvents txtHello As System.Windows.Forms.TextBox
    Friend WithEvents lblTop As System.Windows.Forms.Label
    Friend WithEvents lblLeft As System.Windows.Forms.Label
    Friend WithEvents lblHeight As System.Windows.Forms.Label
    Friend WithEvents lblWidth As System.Windows.Forms.Label
End Class
