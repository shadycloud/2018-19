<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDraw
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDraw))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbExit = New System.Windows.Forms.ToolStripButton()
        Me.tsbRefresh = New System.Windows.Forms.ToolStripButton()
        Me.tsbSetColors = New System.Windows.Forms.ToolStripButton()
        Me.tsbCircles = New System.Windows.Forms.ToolStripButton()
        Me.tsbLines = New System.Windows.Forms.ToolStripButton()
        Me.tsbZongers = New System.Windows.Forms.ToolStripButton()
        Me.tbMin = New System.Windows.Forms.TrackBar()
        Me.tbMax = New System.Windows.Forms.TrackBar()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.txtIncrement = New System.Windows.Forms.TextBox()
        Me.lblIncrement = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnZongers = New System.Windows.Forms.Button()
        Me.btnLines = New System.Windows.Forms.Button()
        Me.btnCircles = New System.Windows.Forms.Button()
        Me.btnSetColor = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.tbMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExit, Me.tsbRefresh, Me.tsbSetColors, Me.tsbCircles, Me.tsbLines, Me.tsbZongers})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1033, 61)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbExit
        '
        Me.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExit.Name = "tsbExit"
        Me.tsbExit.Size = New System.Drawing.Size(29, 58)
        Me.tsbExit.Text = "Exit"
        Me.tsbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'tsbRefresh
        '
        Me.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbRefresh.Image = CType(resources.GetObject("tsbRefresh.Image"), System.Drawing.Image)
        Me.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRefresh.Name = "tsbRefresh"
        Me.tsbRefresh.Size = New System.Drawing.Size(50, 58)
        Me.tsbRefresh.Text = "Refresh"
        '
        'tsbSetColors
        '
        Me.tsbSetColors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbSetColors.Image = CType(resources.GetObject("tsbSetColors.Image"), System.Drawing.Image)
        Me.tsbSetColors.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSetColors.Name = "tsbSetColors"
        Me.tsbSetColors.Size = New System.Drawing.Size(64, 58)
        Me.tsbSetColors.Text = "Set Colors"
        '
        'tsbCircles
        '
        Me.tsbCircles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbCircles.Image = CType(resources.GetObject("tsbCircles.Image"), System.Drawing.Image)
        Me.tsbCircles.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCircles.Name = "tsbCircles"
        Me.tsbCircles.Size = New System.Drawing.Size(46, 58)
        Me.tsbCircles.Text = "Circles"
        '
        'tsbLines
        '
        Me.tsbLines.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbLines.Image = CType(resources.GetObject("tsbLines.Image"), System.Drawing.Image)
        Me.tsbLines.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLines.Name = "tsbLines"
        Me.tsbLines.Size = New System.Drawing.Size(38, 58)
        Me.tsbLines.Text = "Lines"
        '
        'tsbZongers
        '
        Me.tsbZongers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbZongers.Image = CType(resources.GetObject("tsbZongers.Image"), System.Drawing.Image)
        Me.tsbZongers.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbZongers.Name = "tsbZongers"
        Me.tsbZongers.Size = New System.Drawing.Size(54, 58)
        Me.tsbZongers.Text = "Zongers"
        '
        'tbMin
        '
        Me.tbMin.LargeChange = 1
        Me.tbMin.Location = New System.Drawing.Point(498, 33)
        Me.tbMin.Maximum = 100
        Me.tbMin.Name = "tbMin"
        Me.tbMin.Size = New System.Drawing.Size(104, 45)
        Me.tbMin.TabIndex = 1
        Me.tbMin.Value = 10
        '
        'tbMax
        '
        Me.tbMax.LargeChange = 1
        Me.tbMax.Location = New System.Drawing.Point(638, 33)
        Me.tbMax.Maximum = 400
        Me.tbMax.Name = "tbMax"
        Me.tbMax.Size = New System.Drawing.Size(104, 45)
        Me.tbMax.TabIndex = 2
        Me.tbMax.Value = 100
        '
        'txtMin
        '
        Me.txtMin.Location = New System.Drawing.Point(608, 37)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(24, 20)
        Me.txtMin.TabIndex = 3
        Me.txtMin.Text = "10"
        '
        'txtMax
        '
        Me.txtMax.Location = New System.Drawing.Point(748, 37)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(24, 20)
        Me.txtMax.TabIndex = 4
        Me.txtMax.Text = "100"
        '
        'txtIncrement
        '
        Me.txtIncrement.Location = New System.Drawing.Point(826, 37)
        Me.txtIncrement.Name = "txtIncrement"
        Me.txtIncrement.Size = New System.Drawing.Size(100, 20)
        Me.txtIncrement.TabIndex = 5
        Me.txtIncrement.Text = "1"
        '
        'lblIncrement
        '
        Me.lblIncrement.AutoSize = True
        Me.lblIncrement.Location = New System.Drawing.Point(795, 40)
        Me.lblIncrement.Name = "lblIncrement"
        Me.lblIncrement.Size = New System.Drawing.Size(25, 13)
        Me.lblIncrement.TabIndex = 6
        Me.lblIncrement.Text = "Inc:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnZongers)
        Me.Panel1.Controls.Add(Me.lblIncrement)
        Me.Panel1.Controls.Add(Me.btnLines)
        Me.Panel1.Controls.Add(Me.txtIncrement)
        Me.Panel1.Controls.Add(Me.btnCircles)
        Me.Panel1.Controls.Add(Me.txtMax)
        Me.Panel1.Controls.Add(Me.btnSetColor)
        Me.Panel1.Controls.Add(Me.tbMax)
        Me.Panel1.Controls.Add(Me.txtMin)
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.tbMin)
        Me.Panel1.Location = New System.Drawing.Point(0, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(948, 100)
        Me.Panel1.TabIndex = 7
        '
        'btnZongers
        '
        Me.btnZongers.Location = New System.Drawing.Point(417, 33)
        Me.btnZongers.Name = "btnZongers"
        Me.btnZongers.Size = New System.Drawing.Size(75, 23)
        Me.btnZongers.TabIndex = 5
        Me.btnZongers.Text = "Zongers"
        Me.btnZongers.UseVisualStyleBackColor = True
        '
        'btnLines
        '
        Me.btnLines.Location = New System.Drawing.Point(335, 34)
        Me.btnLines.Name = "btnLines"
        Me.btnLines.Size = New System.Drawing.Size(75, 23)
        Me.btnLines.TabIndex = 4
        Me.btnLines.Text = "Lines"
        Me.btnLines.UseVisualStyleBackColor = True
        '
        'btnCircles
        '
        Me.btnCircles.Location = New System.Drawing.Point(253, 33)
        Me.btnCircles.Name = "btnCircles"
        Me.btnCircles.Size = New System.Drawing.Size(75, 23)
        Me.btnCircles.TabIndex = 3
        Me.btnCircles.Text = "Circles"
        Me.btnCircles.UseVisualStyleBackColor = True
        '
        'btnSetColor
        '
        Me.btnSetColor.Location = New System.Drawing.Point(171, 34)
        Me.btnSetColor.Name = "btnSetColor"
        Me.btnSetColor.Size = New System.Drawing.Size(75, 23)
        Me.btnSetColor.TabIndex = 2
        Me.btnSetColor.Text = "Set Colors"
        Me.btnSetColor.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(89, 34)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(7, 34)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmDraw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 733)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmDraw"
        Me.Text = "The Draw Program"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.tbMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSetColors As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCircles As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbLines As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbZongers As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbMin As System.Windows.Forms.TrackBar
    Friend WithEvents tbMax As System.Windows.Forms.TrackBar
    Friend WithEvents txtMin As System.Windows.Forms.TextBox
    Friend WithEvents txtMax As System.Windows.Forms.TextBox
    Friend WithEvents txtIncrement As System.Windows.Forms.TextBox
    Friend WithEvents lblIncrement As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnZongers As System.Windows.Forms.Button
    Friend WithEvents btnLines As System.Windows.Forms.Button
    Friend WithEvents btnCircles As System.Windows.Forms.Button
    Friend WithEvents btnSetColor As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
End Class
