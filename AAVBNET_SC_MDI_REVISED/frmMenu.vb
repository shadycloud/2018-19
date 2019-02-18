Public Class frmMenu



    Private Sub tsbGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGreen.Click
        mnuGreen_Click(sender, e)
    End Sub

    Private Sub tsbBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBlue.Click
        mnuBlue_Click(sender, e)
    End Sub

    Private Sub tsbRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRed.Click
        mnuRed_Click(sender, e)
    End Sub

    Private Sub tsbMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbMinimize.Click
        mnuMIN_Click(sender, e)
    End Sub

    Private Sub tsbNormal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNormal.Click
        mnuNORML_Click(sender, e)
    End Sub

    Private Sub tsbMaximize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbMaximize.Click
        mnuMAX_Click(sender, e)
    End Sub

    Private Sub tsbExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExit.Click
        Me.Dispose()
    End Sub



    Private Sub mnuRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRed.Click
        Me.BackColor = Color.Red
    End Sub

    Private Sub mnuBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBlue.Click
        Me.BackColor = Color.Blue
    End Sub

    Private Sub mnuGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGreen.Click
        Me.BackColor = Color.Green
    End Sub

    Private Sub mnuNORML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNORML.Click
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub mnuMIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMIN.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub mnuMAX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMAX.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Me.Dispose()
    End Sub



    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub cmbNames_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNames.SelectedIndexChanged
        lblName.Text = cmbNames.Text
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'Create an integer variable named iIndex'
        Dim iIndex As Integer = cmbNames.Items.IndexOf(txtAdd.Text)
        If iIndex = (-1) Then
            cmbNames.Items.Add(txtAdd.Text)
            txtAdd.Text = ""
        End If
    End Sub



    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub



    
    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

End Class