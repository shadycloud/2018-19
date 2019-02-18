Public Class frmOption
    Private Sub chkColors_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkColors.CheckedChanged
        If chkColors.Checked = False Then lblColor.Text = "Colors: Off"
        If chkColors.Checked = True Then lblColor.Text = "Colors: On"
    End Sub
    Private Sub chkMouse_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMouse.CheckedChanged
        If chkMouse.Checked = False Then lblMouse.Text = "Mouse: Off"
        If chkMouse.Checked = True Then lblMouse.Text = "Mouse: On"
    End Sub
    Private Sub chkSound_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSound.CheckedChanged
        If chkSound.Checked = False Then lblSound.Text = "Sound: Off"
        If chkSound.Checked = True Then lblSound.Text = "Sound: On"
    End Sub
    Private Sub rbLevel1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbLevel1.CheckedChanged
        If rbLevel1.Checked = True Then lblLevel.Text = "Level: 1"
    End Sub
    Private Sub rbLevel2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbLevel2.CheckedChanged
        If rbLevel2.Checked = True Then lblLevel.Text = "Level: 2"
    End Sub
    Private Sub rbLevel3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbLevel3.CheckedChanged
        If rbLevel3.Checked = True Then lblLevel.Text = "Level: 3"
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub
End Class