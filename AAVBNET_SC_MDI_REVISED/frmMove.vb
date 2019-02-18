Public Class frmMove
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub
    Private Sub frmMove_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        If rbClock.Checked = True Then pbClock.Left = e.X : pbClock.Top = e.Y
        If rbCup.Checked = True Then pbCup.Left = e.X : pbCup.Top = e.Y
        If rbBell.Checked = True Then pbBell.Left = e.X : pbBell.Top = e.Y
    End Sub
    Private Sub pbClock_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbClock.MouseMove
        Static mouseMoveX As Single, mouseMoveY As Single
        If e.Button = 0 Then
            mouseMoveX = e.X
            mouseMoveY = e.Y
        Else
            pbClock.Left = pbClock.Left + (e.X - mouseMoveX)
            pbClock.Top = pbClock.Top + (e.Y - mouseMoveY)
        End If
    End Sub
    Private Sub pbCup_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbCup.MouseMove
        Static mouseMoveX As Single, mouseMoveY As Single
        If e.Button = 0 Then
            mouseMoveX = e.X
            mouseMoveY = e.Y
        Else
            pbCup.Left = pbCup.Left + (e.X - mouseMoveX)
            pbCup.Top = pbCup.Top + (e.Y - mouseMoveY)
        End If
    End Sub
    Private Sub pbBell_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbBell.MouseMove
        Static mouseMoveX As Single, mouseMoveY As Single
        If e.Button = 0 Then
            mouseMoveX = e.X
            mouseMoveY = e.Y
        Else
            pbBell.Left = pbBell.Left + (e.X - mouseMoveX)
            pbBell.Top = pbBell.Top + (e.Y - mouseMoveY)
        End If
    End Sub

    Private Sub pbCup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbCup.Click

    End Sub
End Class