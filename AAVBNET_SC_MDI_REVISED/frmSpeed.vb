Public Class frmSpeed

    Private Sub hsbSpeed_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hsbSpeed.Scroll
        lblSpeed.Text = hsbSpeed.Value & " mph"
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub
End Class