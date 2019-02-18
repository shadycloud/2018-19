Public Class frmButton
    Dim WheelRotated As Integer

    Private Sub frmButton_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Me.MouseWheel, AddressOf frmButton_MouseWheel
    End Sub

    Private Sub frmButton_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown


        If e.Button = Windows.Forms.MouseButtons.Right Then
            ChkRight.Checked = True
            lblWhichButton.Text = "You're pressing the right mouse button"
        End If

        If e.Button = Windows.Forms.MouseButtons.Left Then
            ChkLeft.Checked = True
            lblWhichButton.Text = "You're pressing the left mouse button"
        End If

    End Sub

    Private Sub frmButton_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        ChkLeft.Checked = False
        ChkRight.Checked = False
        lblWhichButton.Text = " "
    End Sub
    Private Sub frmButton_MouseWheel(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel
        WheelRotated = ProgressBar1.Value + (e.Delta() / 3)
        If WheelRotated < 0 Then
            lblWheelRotate.Text = "You can not rotate that far left!"
            Exit Sub
        End If

        If WheelRotated > 1000 Then
            lblWheelRotate.Text = "You can not turn that far right!"
            Exit Sub
        End If
        lblWheelRotate.Text = "Wheel Rotation Value = " & WheelRotated

        ProgressBar1.Value = WheelRotated

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub

    Private Sub frmButton_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        ChkCenter.Checked = False
        ChkLeft.Checked = False
        ChkRight.Checked = False
        lblWhichButton.Text = "Please Click on a Button"
    End Sub
End Class