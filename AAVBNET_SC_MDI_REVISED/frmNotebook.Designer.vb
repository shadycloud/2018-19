<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotebook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotebook))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DialogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbortRetryIgnore = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuYesNo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRetryCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuGetString = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGetNumber = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGetDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuGetMonth = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFont = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnTBFore = New System.Windows.Forms.ToolStripButton()
        Me.btnTBBack = New System.Windows.Forms.ToolStripButton()
        Me.btnfrmBack = New System.Windows.Forms.ToolStripButton()
        Me.btnOpen = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnFont = New System.Windows.Forms.ToolStripButton()
        Me.txtNotebook = New System.Windows.Forms.TextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.notepadPrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DialogsToolStripMenuItem, Me.CommonToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1222, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DialogsToolStripMenuItem
        '
        Me.DialogsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCancel, Me.mnuAbortRetryIgnore, Me.mnuYesNo, Me.mnuRetryCancel, Me.ToolStripSeparator1, Me.mnuGetString, Me.mnuGetNumber, Me.mnuGetDate, Me.ToolStripSeparator2, Me.mnuGetMonth, Me.ToolStripSeparator3, Me.mnuExit})
        Me.DialogsToolStripMenuItem.Name = "DialogsToolStripMenuItem"
        Me.DialogsToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.DialogsToolStripMenuItem.Text = "Dialogs"
        '
        'mnuCancel
        '
        Me.mnuCancel.Name = "mnuCancel"
        Me.mnuCancel.Size = New System.Drawing.Size(212, 22)
        Me.mnuCancel.Text = "OK-Cancel Dialog"
        '
        'mnuAbortRetryIgnore
        '
        Me.mnuAbortRetryIgnore.Name = "mnuAbortRetryIgnore"
        Me.mnuAbortRetryIgnore.Size = New System.Drawing.Size(212, 22)
        Me.mnuAbortRetryIgnore.Text = "Abort-Retry-Ignore Dialog"
        '
        'mnuYesNo
        '
        Me.mnuYesNo.Name = "mnuYesNo"
        Me.mnuYesNo.Size = New System.Drawing.Size(212, 22)
        Me.mnuYesNo.Text = "Yes-No-Cancel Dialog"
        '
        'mnuRetryCancel
        '
        Me.mnuRetryCancel.Name = "mnuRetryCancel"
        Me.mnuRetryCancel.Size = New System.Drawing.Size(212, 22)
        Me.mnuRetryCancel.Text = "Retry-Cancel Dialog "
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(209, 6)
        '
        'mnuGetString
        '
        Me.mnuGetString.Name = "mnuGetString"
        Me.mnuGetString.Size = New System.Drawing.Size(212, 22)
        Me.mnuGetString.Text = "Get a String"
        '
        'mnuGetNumber
        '
        Me.mnuGetNumber.Name = "mnuGetNumber"
        Me.mnuGetNumber.Size = New System.Drawing.Size(212, 22)
        Me.mnuGetNumber.Text = "Get a Number"
        '
        'mnuGetDate
        '
        Me.mnuGetDate.Name = "mnuGetDate"
        Me.mnuGetDate.Size = New System.Drawing.Size(212, 22)
        Me.mnuGetDate.Text = "Get a Date"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(209, 6)
        '
        'mnuGetMonth
        '
        Me.mnuGetMonth.Name = "mnuGetMonth"
        Me.mnuGetMonth.Size = New System.Drawing.Size(212, 22)
        Me.mnuGetMonth.Text = "Get a Month"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(209, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(212, 22)
        Me.mnuExit.Text = "Exit"
        '
        'CommonToolStripMenuItem
        '
        Me.CommonToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColor, Me.mnuFont, Me.mnuOpen, Me.mnuSave, Me.mnuPrint})
        Me.CommonToolStripMenuItem.Name = "CommonToolStripMenuItem"
        Me.CommonToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.CommonToolStripMenuItem.Text = "Common"
        '
        'mnuColor
        '
        Me.mnuColor.Name = "mnuColor"
        Me.mnuColor.Size = New System.Drawing.Size(103, 22)
        Me.mnuColor.Text = "Color"
        '
        'mnuFont
        '
        Me.mnuFont.Name = "mnuFont"
        Me.mnuFont.Size = New System.Drawing.Size(103, 22)
        Me.mnuFont.Text = "Font"
        '
        'mnuOpen
        '
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.Size = New System.Drawing.Size(103, 22)
        Me.mnuOpen.Text = "Open"
        '
        'mnuSave
        '
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(103, 22)
        Me.mnuSave.Text = "Save"
        '
        'mnuPrint
        '
        Me.mnuPrint.Name = "mnuPrint"
        Me.mnuPrint.Size = New System.Drawing.Size(103, 22)
        Me.mnuPrint.Text = "Print"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnTBFore, Me.btnTBBack, Me.btnfrmBack, Me.btnOpen, Me.btnSave, Me.btnPrint, Me.btnFont})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1222, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnTBFore
        '
        Me.btnTBFore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnTBFore.Image = CType(resources.GetObject("btnTBFore.Image"), System.Drawing.Image)
        Me.btnTBFore.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTBFore.Name = "btnTBFore"
        Me.btnTBFore.Size = New System.Drawing.Size(53, 22)
        Me.btnTBFore.Text = "TB-Fore"
        '
        'btnTBBack
        '
        Me.btnTBBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnTBBack.Image = CType(resources.GetObject("btnTBBack.Image"), System.Drawing.Image)
        Me.btnTBBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTBBack.Name = "btnTBBack"
        Me.btnTBBack.Size = New System.Drawing.Size(55, 22)
        Me.btnTBBack.Text = "TB-Back"
        '
        'btnfrmBack
        '
        Me.btnfrmBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnfrmBack.Image = CType(resources.GetObject("btnfrmBack.Image"), System.Drawing.Image)
        Me.btnfrmBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnfrmBack.Name = "btnfrmBack"
        Me.btnfrmBack.Size = New System.Drawing.Size(62, 22)
        Me.btnfrmBack.Text = "Frm-Back"
        '
        'btnOpen
        '
        Me.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnOpen.Image = CType(resources.GetObject("btnOpen.Image"), System.Drawing.Image)
        Me.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(23, 22)
        Me.btnOpen.Text = "ToolStripButton1"
        Me.btnOpen.ToolTipText = "Open"
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(23, 22)
        Me.btnSave.Text = "ToolStripButton1"
        Me.btnSave.ToolTipText = "Save"
        '
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(23, 22)
        Me.btnPrint.Text = "ToolStripButton1"
        Me.btnPrint.ToolTipText = "Print"
        '
        'btnFont
        '
        Me.btnFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFont.Image = CType(resources.GetObject("btnFont.Image"), System.Drawing.Image)
        Me.btnFont.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFont.Name = "btnFont"
        Me.btnFont.Size = New System.Drawing.Size(23, 22)
        Me.btnFont.Text = "ToolStripButton1"
        Me.btnFont.ToolTipText = "Font"
        '
        'txtNotebook
        '
        Me.txtNotebook.Location = New System.Drawing.Point(12, 64)
        Me.txtNotebook.Multiline = True
        Me.txtNotebook.Name = "txtNotebook"
        Me.txtNotebook.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotebook.Size = New System.Drawing.Size(1195, 668)
        Me.txtNotebook.TabIndex = 2
        '
        'PrintDialog1
        '
        Me.PrintDialog1.AllowSelection = True
        Me.PrintDialog1.AllowSomePages = True
        Me.PrintDialog1.UseEXDialog = True
        '
        'notepadPrintDocument
        '
        '
        'frmNotebook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1222, 781)
        Me.Controls.Add(Me.txtNotebook)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmNotebook"
        Me.Text = "The Notebook Program"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DialogsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAbortRetryIgnore As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuYesNo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CommonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRetryCancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGetString As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGetNumber As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGetDate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGetMonth As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuColor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFont As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnTBFore As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnTBBack As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnfrmBack As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnFont As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtNotebook As System.Windows.Forms.TextBox
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents notepadPrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
