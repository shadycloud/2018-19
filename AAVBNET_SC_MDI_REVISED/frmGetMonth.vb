Public Class frmGetMonth

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If rbJan.Checked = True Then
            Dim January As String = ""
            Me.Tag = January
        End If
        If rbFeb.Checked = True Then
            Dim February As String = ""
            Me.Tag = February
        End If
        If rbMar.Checked = True Then
            Dim March As String = ""
            Me.Tag = March
        End If
        If rbApr.Checked = True Then
            Dim April As String = ""
            Me.Tag = April
        End If
        If rbMay.Checked = True Then
            Dim May As String = ""
            Me.Tag = May
        End If
        If rbJun.Checked = True Then
            Dim June As String = ""
            Me.Tag = June
        End If
        If rbJul.Checked = True Then
            Dim July As String = ""
            Me.Tag = July
        End If
        If rbAug.Checked = True Then
            Dim August As String = ""
            Me.Tag = August
        End If
        If rbSep.Checked = True Then
            Dim September As String = ""
            Me.Tag = September
        End If
        If rbOct.Checked = True Then
            Dim October As String = ""
            Me.Tag = October
        End If
        If rbNov.Checked = True Then
            Dim November As String = ""
            Me.Tag = November
        End If
        If rbDec.Checked = True Then
            Dim December As String = ""
            Me.Tag = December
        End If
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Hide()
        Me.Tag = "Cancel"
    End Sub
End Class