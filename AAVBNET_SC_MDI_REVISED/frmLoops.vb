Public Class frmLoops

    Private Sub btnForNextLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForNextLoop.Click
        Dim iCounter, iEndValue, iStopValue, iStartValue As Integer
        iStartValue = txtStart.Text
        iCounter = txtStart.Text
        iEndValue = txtEnd.Text
        iStopValue = txtStop.Text


        For iCounter = iStartValue To iEndValue
            lblResults.Text = iCounter
            lblDisplay.Text += lblResults.Text + vbCrLf
            If iCounter = iStopValue Then
                MessageBox.Show("Counter = " & iCounter & " Stop Value: " & iStopValue)
                Exit For
            End If
        Next
        MessageBox.Show("Exited out of the 'For' loop!")
        lblDisplay.Text = ""
    End Sub


    Private Sub btnDoWhileLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoWhileLoop.Click
        Dim iCounter, iEndValue, iStopValue, iStartValue As Integer
        iStartValue = txtStart.Text
        iCounter = iStartValue
        iEndValue = txtEnd.Text
        iStopValue = txtStop.Text

        Do While iCounter < iEndValue

            lblResults.Text = iCounter
            lblDisplay.Text += lblResults.Text + vbCrLf

            If iCounter = iStopValue Then
                MessageBox.Show("Counter = " & iCounter & " Stop Value: " & iStopValue)
                Exit Do
            End If
            iCounter += 1
        Loop
        MessageBox.Show("Exited out of the 'Do While' loop!")
        lblDisplay.Text = ""
    End Sub

    Private Sub btnUntilLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUntilLoop.Click
        Dim iCounter, iEndValue, iStopValue, iStartValue As Integer
        iStartValue = txtStart.Text
        iCounter = iStartValue
        iEndValue = txtEnd.Text
        iStopValue = txtStop.Text

        Do Until iCounter = iEndValue

            lblResults.Text = iCounter
            lblDisplay.Text += lblResults.Text + vbCrLf

            If iCounter = iStopValue Then
                MessageBox.Show("Counter = " & iCounter & " Stop Value: " & iStopValue)
                Exit Do
            End If
            iCounter += 1
        Loop
        MessageBox.Show("Exited out of the 'Until' loop!")
        lblDisplay.Text = ""
    End Sub
    Private Sub btnWhileLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWhileLoop.Click
        Dim iCounter, iEndValue, iStopValue, iStartValue As Integer
        iStartValue = txtStart.Text
        iCounter = iStartValue
        iEndValue = txtEnd.Text
        iStopValue = txtStop.Text

        Do While iCounter < iEndValue

            lblResults.Text = iCounter
            lblDisplay.Text += lblResults.Text + vbCrLf

            If iCounter = iStopValue Then
                MessageBox.Show("Counter = " & iCounter & " Stop Value: " & iStopValue)
                Exit Do
            End If
            iCounter += 1
        Loop
        MessageBox.Show("Exited out of the 'While' loop!")
        lblDisplay.Text = ""
    End Sub
    Private Sub btnForEachLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForEachLoop.Click
        Dim Pets() As String = {"dog", "cat", "bird"}

        Dim MyPet As String
        lblResults.Text = ""
        For Each MyPet In Pets
            lblDisplay.Text &= MyPet & vbCrLf
        Next
    End Sub

    Private Sub btnCalcGrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcGrade.Click
        Dim sResults As String = ""
        Dim iGrade As Integer = Val(txtGrade.Text)

        Select Case iGrade
            Case 100 : sResults = " - A. Perfect Score!"
            Case 90 To 99 : sResults = " - A. Very Good!"
            Case 80 To 89 : sResults = " - B. Nice Job!"
            Case 70 To 79 : sResults = " - C. Try Harder!"
            Case 60 To 69 : sResults = " - D. Bad!"
            Case 0 To 59 : sResults = " - F. Did you even try?"

        End Select
        lblGrade.Text = sResults
    End Sub


    Private Sub btnCalcInt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcInt.Click
        Dim iYears As Integer
        Dim i As Integer
        Dim iPrincipal As Double
        Dim iInt As Double
        Dim iTotal As Double
        iPrincipal = Val(txtPrinciple.Text)
        iYears = Val(txtYears.Text)
        iInt = Val(txtInterestRate.Text)

        For i = 1 To iYears
            iTotal = iPrincipal * Math.Pow(1 + iInt / 100, i)
           
            lblDisplayIntResult.Text &= String.Format("{0:00}. {1:c}", i, iTotal) + vbCrLf
        Next

    End Sub

   
End Class