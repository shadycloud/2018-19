Public Class frmClock

    Private Sub btnClock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClock.Click
     
        If tmrClock.Enabled = True Then
            tmrClock.Enabled = False
            btnClock.Text = "Turn On Clock"
        Else
            If tmrClock.Enabled = False Then
                tmrClock.Enabled = True
            End If
            btnClock.Text = "Turn Off Clock"
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrClock.Tick
        lblClock.Text = "The Time is " + Format$(Now, "hh:mm:ss")
    End Sub

    Private Sub rbTwoSeconds_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTwoSeconds.CheckedChanged
        If rbTwoSeconds.Checked = True Then
            tmrClock.Interval = 2000
        End If
    End Sub

    Private Sub rbOneSecond_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbOneSecond.CheckedChanged
        If rbOneSecond.Checked = True Then
            tmrClock.Interval = 1000
        End If
    End Sub

End Class