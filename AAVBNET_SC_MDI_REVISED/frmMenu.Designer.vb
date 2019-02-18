<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.ColorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColorSet = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRed = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBlue = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGreen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbWindowState = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNORML = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMIN = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMAX = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbRed = New System.Windows.Forms.ToolStripButton()
        Me.tsbBlue = New System.Windows.Forms.ToolStripButton()
        Me.tsbGreen = New System.Windows.Forms.ToolStripButton()
        Me.tsbMinimize = New System.Windows.Forms.ToolStripButton()
        Me.tsbNormal = New System.Windows.Forms.ToolStripButton()
        Me.tsbMaximize = New System.Windows.Forms.ToolStripButton()
        Me.tsbExit = New System.Windows.Forms.ToolStripButton()
        Me.cmbNames = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.mnuStrip.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuStrip
        '
        Me.mnuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.mnuStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorsToolStripMenuItem, Me.tsbWindowState})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(441, 24)
        Me.mnuStrip.TabIndex = 0
        Me.mnuStrip.Text = "MenuStrip1"
        '
        'ColorsToolStripMenuItem
        '
        Me.ColorsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColorSet, Me.mnuExit})
        Me.ColorsToolStripMenuItem.Name = "ColorsToolStripMenuItem"
        Me.ColorsToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ColorsToolStripMenuItem.Text = "&Colors"
        '
        'mnuColorSet
        '
        Me.mnuColorSet.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRed, Me.mnuBlue, Me.mnuGreen})
        Me.mnuColorSet.Name = "mnuColorSet"
        Me.mnuColorSet.Size = New System.Drawing.Size(127, 22)
        Me.mnuColorSet.Text = "&Set Colors"
        '
        'mnuRed
        '
        Me.mnuRed.Name = "mnuRed"
        Me.mnuRed.Size = New System.Drawing.Size(105, 22)
        Me.mnuRed.Text = "&Red"
        '
        'mnuBlue
        '
        Me.mnuBlue.Name = "mnuBlue"
        Me.mnuBlue.Size = New System.Drawing.Size(105, 22)
        Me.mnuBlue.Text = "&Blue"
        '
        'mnuGreen
        '
        Me.mnuGreen.Name = "mnuGreen"
        Me.mnuGreen.Size = New System.Drawing.Size(105, 22)
        Me.mnuGreen.Text = "&Green"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(127, 22)
        Me.mnuExit.Text = "E&xit "
        '
        'tsbWindowState
        '
        Me.tsbWindowState.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNORML, Me.mnuMIN, Me.mnuMAX})
        Me.tsbWindowState.Name = "tsbWindowState"
        Me.tsbWindowState.Size = New System.Drawing.Size(92, 20)
        Me.tsbWindowState.Text = "&Window State"
        '
        'mnuNORML
        '
        Me.mnuNORML.Name = "mnuNORML"
        Me.mnuNORML.Size = New System.Drawing.Size(131, 22)
        Me.mnuNORML.Text = "&Normal"
        '
        'mnuMIN
        '
        Me.mnuMIN.Name = "mnuMIN"
        Me.mnuMIN.Size = New System.Drawing.Size(131, 22)
        Me.mnuMIN.Text = "Minimi&zed"
        '
        'mnuMAX
        '
        Me.mnuMAX.Name = "mnuMAX"
        Me.mnuMAX.Size = New System.Drawing.Size(131, 22)
        Me.mnuMAX.Text = "&Maximized"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbRed, Me.tsbBlue, Me.tsbGreen, Me.tsbMinimize, Me.tsbNormal, Me.tsbMaximize, Me.tsbExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(441, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbRed
        '
        Me.tsbRed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRed.Image = CType(resources.GetObject("tsbRed.Image"), System.Drawing.Image)
        Me.tsbRed.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRed.Name = "tsbRed"
        Me.tsbRed.Size = New System.Drawing.Size(23, 22)
        Me.tsbRed.Text = "tsbRed"
        '
        'tsbBlue
        '
        Me.tsbBlue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbBlue.Image = CType(resources.GetObject("tsbBlue.Image"), System.Drawing.Image)
        Me.tsbBlue.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBlue.Name = "tsbBlue"
        Me.tsbBlue.Size = New System.Drawing.Size(23, 22)
        Me.tsbBlue.Text = "ToolStripButton2"
        '
        'tsbGreen
        '
        Me.tsbGreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbGreen.Image = CType(resources.GetObject("tsbGreen.Image"), System.Drawing.Image)
        Me.tsbGreen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGreen.Name = "tsbGreen"
        Me.tsbGreen.Size = New System.Drawing.Size(23, 22)
        Me.tsbGreen.Text = "ToolStripButton1"
        '
        'tsbMinimize
        '
        Me.tsbMinimize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbMinimize.Image = CType(resources.GetObject("tsbMinimize.Image"), System.Drawing.Image)
        Me.tsbMinimize.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbMinimize.Name = "tsbMinimize"
        Me.tsbMinimize.Size = New System.Drawing.Size(23, 22)
        Me.tsbMinimize.Text = "ToolStripButton2"
        '
        'tsbNormal
        '
        Me.tsbNormal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbNormal.Image = CType(resources.GetObject("tsbNormal.Image"), System.Drawing.Image)
        Me.tsbNormal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNormal.Name = "tsbNormal"
        Me.tsbNormal.Size = New System.Drawing.Size(23, 22)
        Me.tsbNormal.Text = "ToolStripButton3"
        '
        'tsbMaximize
        '
        Me.tsbMaximize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbMaximize.Image = CType(resources.GetObject("tsbMaximize.Image"), System.Drawing.Image)
        Me.tsbMaximize.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbMaximize.Name = "tsbMaximize"
        Me.tsbMaximize.Size = New System.Drawing.Size(23, 22)
        Me.tsbMaximize.Text = "ToolStripButton1"
        '
        'tsbExit
        '
        Me.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbExit.Image = CType(resources.GetObject("tsbExit.Image"), System.Drawing.Image)
        Me.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExit.Name = "tsbExit"
        Me.tsbExit.Size = New System.Drawing.Size(23, 22)
        Me.tsbExit.Text = "ToolStripButton1"
        '
        'cmbNames
        '
        Me.cmbNames.FormattingEnabled = True
        Me.cmbNames.Location = New System.Drawing.Point(71, 159)
        Me.cmbNames.Name = "cmbNames"
        Me.cmbNames.Size = New System.Drawing.Size(121, 21)
        Me.cmbNames.Sorted = True
        Me.cmbNames.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(266, 157)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(134, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtAdd
        '
        Me.txtAdd.Location = New System.Drawing.Point(266, 134)
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(134, 20)
        Me.txtAdd.TabIndex = 5
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Location = New System.Drawing.Point(71, 133)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(121, 23)
        Me.lblName.TabIndex = 6
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(54, 284)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(333, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 349)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtAdd)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cmbNames)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.mnuStrip)
        Me.Name = "frmMenu"
        Me.Text = "The Menu/Toolbar Window"
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ColorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuColorSet As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRed As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBlue As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGreen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbWindowState As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNORML As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMAX As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMIN As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGreen As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbRed As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbBlue As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbMaximize As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbMinimize As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbNormal As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbNames As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtAdd As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents tsbExit As System.Windows.Forms.ToolStripButton
End Class
