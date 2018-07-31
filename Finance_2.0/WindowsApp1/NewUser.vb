Public Class NewUser
    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        FirstWelcomeMenu.Show()

        Me.Hide()
    End Sub

    Private Sub cmdCreateUser_Click(sender As Object, e As EventArgs) Handles cmdCreateUser.Click
        If txtPass.Text = txtConfirmP.Text Then
            'With UserData(NumofUsers)    
            '    .Username = txtUserN.Text
            '    .Password = txtPass.Text
            'End With
            'NumofUsers += 1
            FirstWelcomeMenu.createaccount(txtUserN.Text, txtPass.Text)
            txtUserN.Text = ""
            txtPass.Text = ""
            txtConfirmP.Text = ""

            Me.Hide()
            MainMenu.Show()
        Else
            MsgBox("Please Ensure Passwords Match")
        End If

    End Sub
    'Private Sub savetofile()
    '    Dim sep As String = ","
    '    Dim Nrecord As String = ";"
    '    Dim File = My.Computer.FileSystem.OpenTextFileWriter(filename, False
    '    For i As Integer = 0 To UserData.Length - 1
    '        With UserData(i)
    '            If .Username <> Nothing Then
    '                Dim oneline As String = .Username + sep + .Password + Nrecord
    '                File.Write(oneline)
    '            End If
    '        End With
    '    Next
    '    File.Close()
    '    MsgBox("Welcome!")
    'End Sub
    'account(1).savetofile
End Class