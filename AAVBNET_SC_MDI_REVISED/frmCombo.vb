Public Class frmCombo

    Private Sub cmbNames_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNames.SelectedIndexChanged
        lblName.Text = cmbNames.Text
    End Sub

    Private Sub frmCombo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbNames.Items.Add("Sam")
        cmbNames.Items.Add("Timmers")
        cmbNames.Items.Add("Carla")
        cmbNames.Items.Add("Margie")
        cmbNames.Items.Add("Bill")
        cmbNames.Items.Add("Shari")
        cmbNames.Items.Add("David")
        cmbNames.Items.Add("Mikie")
        cmbNames.Items.Add("Daniel")
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub
End Class