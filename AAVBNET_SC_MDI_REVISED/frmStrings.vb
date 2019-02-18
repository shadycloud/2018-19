Public Class frmStrings


    Private Sub btnLen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLen.Click
        txtSource1.Text = "Tulsa Community College"
        Dim iLen As Integer
        iLen = Len(txtSource1.Text)
        txtResults.Text = "The Length is: " & iLen


    End Sub

    Private Sub btnTrim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrim.Click
        txtSource2.Text = "    This is a test.    "
        txtResults.Text = Trim(txtSource2.Text)


    End Sub

    Private Sub btnRtrim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRtrim.Click
        txtSource2.Text = "    This is a test.    "
        txtResults.Text = RTrim(txtSource1.Text)

    End Sub


    Private Sub btnLtrim_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLtrim.Click
        txtSource2.Text = "    This is a test.    "
        txtResults.Text = LTrim(txtSource2.Text)

    End Sub
    Private Sub btnInstr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstr.Click
        txtResults.Text = +InStr(txtSource1.Text, "g")

    End Sub

    Private Sub btnReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReplace.Click
        txtResults.Text = Replace(txtSource1.Text, "College", "University")

    End Sub

    Private Sub btnUcase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUcase.Click
        txtResults.Text = "" + UCase(txtSource1.Text)

    End Sub

    Private Sub btnLCase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLCase.Click
        txtResults.Text = "" + LCase(txtSource1.Text)
    End Sub

    Private Sub btnSubStringLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubStringLeft.Click
        txtResults.Text = txtSource1.Text.Substring(0, 5)

    End Sub

    Private Sub btnSubStringMiddle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubStringMiddle.Click
        txtResults.Text = txtSource1.Text.Substring(6, 4)

    End Sub

    Private Sub btnSubStringRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubStringRight.Click
        txtResults.Text = txtSource1.Text.Substring(txtSource1.Text.Length - 7, 7)

    End Sub

    Private Sub btnMid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMid.Click
        txtResults.Text = Mid(txtSource1.Text, 6, 9)

    End Sub

    Private Sub btnStr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStr.Click
        Dim iNumber As Integer = 123
        txtResults.Text = +Str(iNumber)

    End Sub

    Private Sub btnVal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVal.Click
        txtResults.Text = Asc(txtSource3.Text)

    End Sub

    Private Sub btnChr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChr.Click
        txtResults.Text = Chr(txtSource3.Text)

    End Sub

    Private Sub btnAsc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsc.Click
        txtResults.Text = Asc(txtSource4.Text)

    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        txtResults.Text = " " + Mid(txtSource2.Text, 5, 8) + UCase(txtSource1.Text.Substring(0, 5) + " " + txtSource1.Text.Substring(txtSource1.Text.Length - 7, 7))

    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        Dim Mipp As String
        Mipp = Mid(txtSource5.Text, 1, 11)
        txtResults.Text = Replace(Mipp, "ss", "pp") + UCase(Mid(txtSource5.Text, 23, 9))


    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        txtResults.Text = Mid(lblSource.Text, 1, 3) + " " + UCase(Mid(lblSource.Text, 27, 3)) + " " + Mid(lblSource.Text, 35, 10) + " " + (UCase(Mid(lblSource.Text, 62, 1)) + Mid(lblSource.Text, 63, 2)) + " " + Mid(lblSource.Text, 58, 3) + " " + Mid(lblSource.Text, 12, 3) + " " + (UCase(Mid(lblSource.Text, 5, 1)) + Mid(lblSource.Text, 6, 2) + " " + Mid(lblSource.Text, 6, 2) + " " + (UCase(Mid(lblSource.Text, 66, 3)))) + " " + Mid(txtSource1.Text, 17, 7) + "."
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        txtResults.Text = UCase(Chr(83)) + Chr(104) + Chr(97) + Chr(101) + " " + Chr(67) + Chr(108) + Chr(111) + Chr(117) + Chr(100) + " " + Chr(48) + Chr(49) + "/" + Chr(51) + Chr(49) + "/" + Chr(56) + Chr(56)
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        txtResults.Text = txtSource3.Text + txtSource3.Text
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        txtResults.Text = Val(txtSource3.Text) + Val(txtSource3.Text)
    End Sub
End Class
