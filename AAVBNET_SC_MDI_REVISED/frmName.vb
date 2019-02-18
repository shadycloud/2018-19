Public Class frmName

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim sAddress As String = ""

        sAddress += txtName.Text + " " + txtLast.Text & Chr(10)
        sAddress += txtAddress.Text & Chr(10)
        sAddress = sAddress + txtCity.Text + ", " & txtState.Text + " " + txtZip.Text
        lblMail.Text = sAddress

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Me.Dispose()

    End Sub
End Class