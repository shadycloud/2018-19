Imports System.IO
Imports System.Drawing.Printing
Public Class frmNotebook
    Dim SwitchCase As Integer = "1"

    Private Sub mnuCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCancel.Click
        Dim Response As Integer
        Response = MessageBox.Show("This is a message box.", "Message Box Caption", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand)
        Select Case Response
            Case vbOK : MessageBox.Show("You clicked the OK button")
            Case vbCancel : MessageBox.Show("You clicked the Cancel button")

        End Select
    End Sub

    Private Sub mnuAbortRetryIgnore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbortRetryIgnore.Click

        Dim Response As Integer
        Response = MessageBox.Show("This is a message box.", "Message Box Caption", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Hand)
        Select Case Response
            Case vbAbort : MessageBox.Show("You clicked the Abort button")
            Case vbIgnore : MessageBox.Show("You clicked the Ignore button")
            Case vbRetry : MessageBox.Show("You clicked the Retry button")
        End Select
    End Sub

    Private Sub mnuYesNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuYesNo.Click
        Dim Response As Integer
        Response = MessageBox.Show("This is a message box.", "Message Box Caption", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand)
        Select Case Response
            Case vbYes : MessageBox.Show("You clicked the Yes button")
            Case vbNo : MessageBox.Show("You clicked the No button")
            Case vbCancel : MessageBox.Show("You clicked the Cancel button")
        End Select
    End Sub

    Private Sub mnuRetryCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRetryCancel.Click
        Dim Response As Integer
        Response = MessageBox.Show("This is a message box.", "Message Box Caption", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand)
        Select Case Response
            Case vbRetry : MessageBox.Show("You clicked the Retry button")
            Case vbCancel : MessageBox.Show("You clicked the Cancel button")
        End Select
    End Sub

    Private Sub mnuOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpen.Click
        Dim strFilename As String = ""
        Dim openMyFile As OpenFileDialog = New OpenFileDialog()
        With openMyFile
            .DefaultExt = "*.*"
            .FileName = strFilename
            .Filter = "text files ( *.txt)|*.txt|All Files(*.*)|*.*"
            .FilterIndex = 2
            .InitialDirectory = "C:\"
            .Title = "Dialog Open File Dialog"
        End With
        If openMyFile.ShowDialog = DialogResult.OK Then
            strFilename = openMyFile.FileName
            Dim MyStreamReader As StreamReader = New StreamReader(strFilename)
            With MyStreamReader
                txtNotebook.Text = .ReadToEnd
                .Close()
                MyStreamReader = Nothing
            End With
        End If
    End Sub

    Private Sub mnuSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSave.Click
        Dim strFilename As String = ""
        Dim saveMyFile As SaveFileDialog = New SaveFileDialog()
        With saveMyFile
            .DefaultExt = "*.*"
            .FileName = strFilename
            .Filter = "text files ( *.txt)|*.txt|All Files(*.*)|*.*"
            .FilterIndex = 2
            .InitialDirectory = "C:\"
            .Title = "Dialog Save File Dialog"
        End With
        If saveMyFile.ShowDialog = DialogResult.OK Then
            strFilename = saveMyFile.FileName
            Dim MyStreamReader As StreamReader = New StreamReader(strFilename)
            With MyStreamReader
                txtNotebook.Text = .ReadToEnd
                .Close()
                MyStreamReader = Nothing
            End With
        End If
    End Sub

    Private Sub mnuPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrint.Click
        Dim PrintDialogBox As PrintDialog = New PrintDialog()
        notepadPrintDocument.DocumentName = "Text File Print Demo"
        With PrintDialogBox
            .AllowPrintToFile = True
            .AllowSelection = True
            .AllowSomePages = True
            .Document = notepadPrintDocument
        End With
        Dim dialogResult As DialogResult = PrintDialogBox.ShowDialog()
        If (dialogResult = dialogResult.OK) Then
            notepadPrintDocument.Print()
        End If
    End Sub

    Private Sub notepadPrintDocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles notepadPrintDocument.PrintPage
        Dim f As New Font(txtNotebook.Name, txtNotebook.Font.Size, txtNotebook.Font.Style)

        Dim b As New SolidBrush(Color.Black)

        Dim p As New PointF(10, 10)

        e.Graphics.DrawString(txtNotebook.Text, f, b, p)
    End Sub

    Private Sub mnuGetMonth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGetMonth.Click
        Dim frmGetMonth As New frmGetMonth()
        frmGetMonth.ShowDialog()
        If frmGetMonth.Tag = "Cancel" Then
        Else
            txtNotebook.Text += frmGetMonth.Tag
        End If
        frmGetMonth.Dispose()
    End Sub

    Private Sub mmnuGetString_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGetString.Click
        Dim getstring As String
        getstring = InputBox("Enter a string:")
        txtNotebook.Text += getstring
    End Sub

    Private Sub mnuGetNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGetNumber.Click
        Dim getnumber As String
        getnumber = InputBox("Enter Input:")
        If IsNumeric(getnumber) = True Then
            txtNotebook.Text += " " & getnumber
        Else : MessageBox.Show("You did not enter any numbers!")
        End If
    End Sub

    Private Sub mnuGetDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGetDate.Click
        Dim GetDate As New DateTimePicker
        Dim GetDateForm As New Form
        GetDateForm.Controls.Add(GetDate)
        GetDateForm.ShowDialog(Me)
        txtNotebook.Text += GetDate.Value
        GetDateForm.Dispose()
    End Sub

    Private Sub mnuFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFont.Click
        Dim FontBox As FontDialog = New FontDialog()
        FontBox.ShowDialog()
        txtNotebook.Font = FontBox.Font
    End Sub

    Private Sub mnuColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuColor.Click
        Select Case SwitchCase
            Case 1
                Dim ColorBox As ColorDialog = New ColorDialog()
                ColorBox.ShowDialog()
                txtNotebook.ForeColor = ColorBox.Color
            Case 2
                Dim ColorBox As ColorDialog = New ColorDialog()
                ColorBox.ShowDialog()
                txtNotebook.BackColor = ColorBox.Color
            Case 3
                Dim ColorBox As ColorDialog = New ColorDialog()
                ColorBox.ShowDialog()
                Me.BackColor = ColorBox.Color
        End Select
    End Sub

    Private Sub btnTBFore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTBFore.Click
        SwitchCase = "1"
    End Sub

    Private Sub btnTBBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTBBack.Click
        SwitchCase = "2"
    End Sub

    Private Sub btnfrmBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfrmBack.Click
        SwitchCase = "3"
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim strFilename As String = ""
        Dim saveMyFile As SaveFileDialog = New SaveFileDialog()
        With saveMyFile
            .DefaultExt = "*.*"
            .FileName = strFilename
            .Filter = "text files ( *.txt)|*.txt|All Files(*.*)|*.*"
            .FilterIndex = 2
            .InitialDirectory = "C:\"
            .Title = "Dialog  File Dialog"
        End With
        If saveMyFile.ShowDialog = DialogResult.OK Then
            strFilename = saveMyFile.FileName
            Dim MyStreamReader As StreamReader = New StreamReader(strFilename)
            With MyStreamReader
                txtNotebook.Text = .ReadToEnd
                .Close()
                MyStreamReader = Nothing
            End With
        End If
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        Dim strFilename As String = ""
        Dim openMyFile As OpenFileDialog = New OpenFileDialog()
        With openMyFile
            .DefaultExt = "*.*"
            .FileName = strFilename
            .Filter = "text files ( *.txt)|*.txt|All Files(*.*)|*.*"
            .FilterIndex = 2
            .InitialDirectory = "C:\"
            .Title = "Dialog Open File Dialog"
        End With
        If openMyFile.ShowDialog = DialogResult.OK Then
            strFilename = openMyFile.FileName
            Dim MyStreamReader As StreamReader = New StreamReader(strFilename)
            With MyStreamReader
                txtNotebook.Text = .ReadToEnd
                .Close()
                MyStreamReader = Nothing
            End With
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim PrintDialogBox As PrintDialog = New PrintDialog()
        notepadPrintDocument.DocumentName = "Text File Print Demo"
        With PrintDialogBox
            .AllowPrintToFile = True
            .AllowSelection = True
            .AllowSomePages = True
            .Document = notepadPrintDocument
        End With
        Dim dialogResult As DialogResult = PrintDialogBox.ShowDialog()
        If (dialogResult = dialogResult.OK) Then
            notepadPrintDocument.Print()
        End If
    End Sub

    Private Sub btnFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFont.Click
        Dim FontBox As FontDialog = New FontDialog()
        FontBox.ShowDialog()
        txtNotebook.Font = FontBox.Font
    End Sub


End Class


'Dim Response As Integer
'    Response = MessageBox.Show("This is a message box.", "Message Box Caption", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Hand)
'    Select Case Response
'        Case vbAbort : MessageBox.Show("You clicked the Abort button")
'        Case vbIgnore : MessageBox.Show("You clicked the Ignore button")
'        Case vbRetry : MessageBox.Show("You clicked the Retry button")
'    End Select
' End Sub
