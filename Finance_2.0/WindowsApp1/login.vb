Public Class login
    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        FirstWelcomeMenu.Show()
        Me.Hide()
    End Sub
    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        'If txtUserN.Text <> Nothing AndAlso txtPass.Text <> Nothing Then
        '    For i = 0 To UserData.Length - 1
        '        If txtUserN.Text = UserData(i).Username And txtPass.Text = UserData(i).Password Then
        '            MsgBox("Welcome back " + txtUserN.Text)
        '            MainMenu.Show()
        '            Me.Hide()
        '            Exit For
        '        ElseIf txtUserN.Text = UserData(i).Username And txtPass.Text <> UserData(i).Password Then
        '            MsgBox("Incorrect Password!")
        '            txtPass.Text = Nothing
        '            Exit For
        '        ElseIf i = UserData.Length - 1 Then
        '            MsgBox("Incorrect Username!")
        '            txtUserN.Text = Nothing
        '        End If
        '    Next
        'End If
        FirstWelcomeMenu.LoginScript(txtUserN.Text, txtPass.Text)
    End Sub
End Class