Public Class frmHello

    Private Sub btnHello_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHello.Click
        lblHello.Text = "My name is Cloud"
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        lblHello.Text = txtHello.Text
        txtHello.Clear()
        txtHello.Focus()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lblHello.Text = ""
        txtHello.Clear()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub

    Private Sub frmHello_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblHeight.Text = "Height: 327"
        lblWidth.Text = "Width: 281"
    End Sub
End Class