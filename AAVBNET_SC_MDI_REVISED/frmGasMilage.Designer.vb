<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGasMilage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGasMilage))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDefault = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtStartMilage = New System.Windows.Forms.TextBox()
        Me.txtEndMilage = New System.Windows.Forms.TextBox()
        Me.txtGallons = New System.Windows.Forms.TextBox()
        Me.txtMilage = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblGPM = New System.Windows.Forms.Label()
        Me.scrollStartMilage = New System.Windows.Forms.HScrollBar()
        Me.scrollEndMilage = New System.Windows.Forms.HScrollBar()
        Me.scrollGallons = New System.Windows.Forms.HScrollBar()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-610, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(254, 209)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(623, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&Start Milage"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(623, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&End Milage"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(623, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "&Gallons"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(623, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "&Milage"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(532, 23)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 5
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(532, 53)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDefault
        '
        Me.btnDefault.Location = New System.Drawing.Point(532, 85)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Size = New System.Drawing.Size(75, 23)
        Me.btnDefault.TabIndex = 7
        Me.btnDefault.Text = "&Default"
        Me.btnDefault.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(532, 120)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtStartMilage
        '
        Me.txtStartMilage.Location = New System.Drawing.Point(704, 25)
        Me.txtStartMilage.Name = "txtStartMilage"
        Me.txtStartMilage.Size = New System.Drawing.Size(100, 20)
        Me.txtStartMilage.TabIndex = 9
        '
        'txtEndMilage
        '
        Me.txtEndMilage.Location = New System.Drawing.Point(704, 55)
        Me.txtEndMilage.Name = "txtEndMilage"
        Me.txtEndMilage.Size = New System.Drawing.Size(100, 20)
        Me.txtEndMilage.TabIndex = 10
        '
        'txtGallons
        '
        Me.txtGallons.Location = New System.Drawing.Point(704, 89)
        Me.txtGallons.Name = "txtGallons"
        Me.txtGallons.Size = New System.Drawing.Size(100, 20)
        Me.txtGallons.TabIndex = 11
        '
        'txtMilage
        '
        Me.txtMilage.Location = New System.Drawing.Point(704, 122)
        Me.txtMilage.Name = "txtMilage"
        Me.txtMilage.Size = New System.Drawing.Size(100, 20)
        Me.txtMilage.TabIndex = 12
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.AAVBNET_SC.My.Resources.Resources.caddi
        Me.PictureBox2.Location = New System.Drawing.Point(-447, -19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1642, 799)
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'lblGPM
        '
        Me.lblGPM.Location = New System.Drawing.Point(678, 160)
        Me.lblGPM.Name = "lblGPM"
        Me.lblGPM.Size = New System.Drawing.Size(275, 43)
        Me.lblGPM.TabIndex = 14
        '
        'scrollStartMilage
        '
        Me.scrollStartMilage.LargeChange = 20
        Me.scrollStartMilage.Location = New System.Drawing.Point(840, 29)
        Me.scrollStartMilage.Maximum = 32000
        Me.scrollStartMilage.Name = "scrollStartMilage"
        Me.scrollStartMilage.Size = New System.Drawing.Size(80, 17)
        Me.scrollStartMilage.SmallChange = 5
        Me.scrollStartMilage.TabIndex = 15
        '
        'scrollEndMilage
        '
        Me.scrollEndMilage.LargeChange = 20
        Me.scrollEndMilage.Location = New System.Drawing.Point(840, 59)
        Me.scrollEndMilage.Maximum = 32000
        Me.scrollEndMilage.Name = "scrollEndMilage"
        Me.scrollEndMilage.Size = New System.Drawing.Size(80, 17)
        Me.scrollEndMilage.SmallChange = 5
        Me.scrollEndMilage.TabIndex = 16
        '
        'scrollGallons
        '
        Me.scrollGallons.LargeChange = 20
        Me.scrollGallons.Location = New System.Drawing.Point(840, 92)
        Me.scrollGallons.Maximum = 32000
        Me.scrollGallons.Name = "scrollGallons"
        Me.scrollGallons.Size = New System.Drawing.Size(80, 17)
        Me.scrollGallons.SmallChange = 5
        Me.scrollGallons.TabIndex = 17
        '
        'frmGasMilage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 527)
        Me.Controls.Add(Me.scrollGallons)
        Me.Controls.Add(Me.scrollEndMilage)
        Me.Controls.Add(Me.scrollStartMilage)
        Me.Controls.Add(Me.lblGPM)
        Me.Controls.Add(Me.txtMilage)
        Me.Controls.Add(Me.txtGallons)
        Me.Controls.Add(Me.txtEndMilage)
        Me.Controls.Add(Me.txtStartMilage)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDefault)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "frmGasMilage"
        Me.Text = "The Milage Program"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnDefault As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtStartMilage As System.Windows.Forms.TextBox
    Friend WithEvents txtEndMilage As System.Windows.Forms.TextBox
    Friend WithEvents txtGallons As System.Windows.Forms.TextBox
    Friend WithEvents txtMilage As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblGPM As System.Windows.Forms.Label
    Friend WithEvents scrollStartMilage As System.Windows.Forms.HScrollBar
    Friend WithEvents scrollEndMilage As System.Windows.Forms.HScrollBar
    Friend WithEvents scrollGallons As System.Windows.Forms.HScrollBar
End Class
