Public Class frmCalculator

    Dim sEquals As String
    Private Sub frmCalculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtMem.Text = ""
        txtResults.Text = ""
        txtVal1.Text = ""
        txtVal2.Text = ""
    End Sub
    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        txtResults.Text = txtResults.Text & "0"
    End Sub
    Private Sub btnDecimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecimal.Click
        txtResults.Text = txtResults.Text & "."
    End Sub
    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        txtResults.Text = txtResults.Text & "1"
    End Sub
    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        txtResults.Text = txtResults.Text & "2"
    End Sub
    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        txtResults.Text = txtResults.Text & "3"
    End Sub
    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        txtResults.Text = txtResults.Text & "4"
    End Sub
    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        txtResults.Text = txtResults.Text & "5"
    End Sub
    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        txtResults.Text = txtResults.Text & "6"
    End Sub
    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        txtResults.Text = txtResults.Text & "7"
    End Sub
    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        txtResults.Text = txtResults.Text & "8"
    End Sub
    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        txtResults.Text = txtResults.Text & "9"
    End Sub
    Private Sub btnMadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMadd.Click

    End Sub
    Private Sub btnMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMod.Click
        txtResults.Text = Val(txtVal1.Text) Mod Val(txtVal2.Text)
    End Sub
    Private Sub btnPercent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPercent.Click
        txtResults.Text = Val(txtVal1.Text) / Val(txtVal2.Text)
    End Sub
    Private Sub btnMax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMax.Click
        txtResults.Text = Math.Max(Val(txtVal1.Text), Val(txtVal2.Text))
    End Sub
    Private Sub btnMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMin.Click
        txtResults.Text = Math.Min(Val(txtVal1.Text), Val(txtVal2.Text))
    End Sub
    Private Sub btnV1copy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnV1copy.Click
        txtVal1.Text = Val(txtResults.Text)
    End Sub
    Private Sub btnV2copy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnV2copy.Click
        txtVal2.Text = Val(txtResults.Text)
    End Sub
    Private Sub btnRclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRclear.Click
        txtResults.Text = " "
    End Sub
    Private Sub btnV1clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnV1clear.Click
        txtVal1.Text = " "
    End Sub
    Private Sub btnV2clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnV2clear.Click
        txtVal2.Text = " "
    End Sub
    Private Sub btnEqual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEqual.Click
        Select Case sEquals
            Case "+" : txtResults.Text = Val(txtVal1.Text) + Val(txtResults.Text)
            Case "-" : txtResults.Text = Val(txtVal1.Text) - Val(txtResults.Text)
            Case "*" : txtResults.Text = Val(txtVal1.Text) * Val(txtResults.Text)
            Case "/" : txtResults.Text = Val(txtVal1.Text) / Val(txtResults.Text)
        End Select
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        sEquals = "+"
        txtVal1.Text = txtResults.Text
        txtResults.Text = ""
    End Sub
    Private Sub btnSubtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubtract.Click
        sEquals = "-"
        txtVal1.Text = txtResults.Text
        txtResults.Text = ""
    End Sub
    Private Sub btnMultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiply.Click
        sEquals = "*"
        txtVal1.Text = txtResults.Text
        txtResults.Text = ""
    End Sub
    Private Sub btnDivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDivide.Click
        sEquals = "/"
        txtVal1.Text = txtResults.Text
        txtResults.Text = ""
    End Sub
    Private Sub btnDequal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDequal.Click
        txtResults.Text /= Val(txtResults.Text)
    End Sub
    Private Sub btnMequal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMequal.Click
        txtResults.Text *= Val(txtResults.Text)
    End Sub
    Private Sub btnSequal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSequal.Click
        txtResults.Text -= Val(txtResults.Text)
    End Sub
    Private Sub btnAequal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAequal.Click
        txtResults.Text += Val(txtResults)
    End Sub
    Private Sub btnSqrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSqrt.Click
        txtResults.Text = Math.Sqrt(Val(txtResults.Text))
    End Sub
End Class