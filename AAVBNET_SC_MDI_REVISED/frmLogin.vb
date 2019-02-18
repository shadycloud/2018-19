'Public Class frmLogin



'    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
'        Me.Dispose()
'    End Sub

'Private Sub btnVerify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerify.Click
'    If txtUserId.Text Or txtUserPassword.Text = "" Then
'        MessageBox.Show("You must enter User Id and Password!")
'    End If
'    'If txtUserId.Text and txtUserPassword.Text != "" Then 
'    '    OpenUserInfo()
'    '    'Compare InUserId and InUserPassword with SaveUserInfo
'    'End If
'    If MyLogin.VerifyLogin() = True Then
'        MessageBox.Show("Login verified.")
'    End If
'    If MyLogin.VerifyLogin() = False Then
'        MessageBox.Show("Login NOT verified!")
'    End If


'    End Sub

'    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
'        If txtUserId.Text Or txtUserPassword.Text = "" Then
'            MessageBox.Show("You must enter User Id and Password!")
'        End If
'        If MyLogin.RegisterLogin() = True Then
'            MessageBox.Show("Login registered.")
'        End If
'        If MyLogin.RegisterLogin() = False Then
'            MessageBox.Show("Login NOT registered!")
'        End If
'    End Sub
'End Class