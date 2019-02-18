Public Class frmGasMilage

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click

        Dim StartMilage As Integer
        Dim EndMilage As Integer
        Dim Gallons As Integer
        Dim IntMilage As Integer

        StartMilage = 0.0
        EndMilage = 0.0
        Gallons = 0.0
        IntMilage = 0.0

        If (txtStartMilage.Text = "") Or (txtEndMilage.Text = "") Or (txtGallons.Text = "") Or (txtGallons.Text = 0) Then
            MessageBox.Show(" You must enter values to calculate the gas milage. ")
            Exit Sub
        Else
            StartMilage = Convert.ToInt32(txtStartMilage.Text)
            EndMilage = Convert.ToInt32(txtEndMilage.Text)
            Gallons = Convert.ToInt32(txtGallons.Text)

        End If
        IntMilage = (EndMilage - StartMilage) / Gallons
        txtMilage.Text = IntMilage



        lblGPM.Text = IntMilage.ToString()
        lblGPM.Text = "Starting milage is " + txtStartMilage.Text + "." & vbCrLf
        lblGPM.Text += "Ending milage is " + txtEndMilage.Text + "." & vbCrLf
        lblGPM.Text += "This calculates to " + txtMilage.Text + " miles per gallon."

    End Sub


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub

    Private Sub btnDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDefault.Click

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtStartMilage.Text = ""
        txtEndMilage.Text = ""
        txtGallons.Text = ""
        lblGPM.Text = ""
    End Sub
    Private Sub scrollStartMilage_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles scrollStartMilage.Scroll
        txtStartMilage.Text = scrollStartMilage.Value
    End Sub
    Private Sub scrollEndMilage_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles scrollEndMilage.Scroll
        txtEndMilage.Text = scrollEndMilage.Value
    End Sub
    Private Sub scrollGallons_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles scrollGallons.Scroll
        txtGallons.Text = scrollGallons.Value
    End Sub
End Class