Public Class NewUser
    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        FirstWelcomeMenu.Show()

        Me.Hide()
    End Sub

    Private Sub cmdCreateUser_Click(sender As Object, e As EventArgs) Handles cmdCreateUser.Click
        If txtPass.Text = txtConfirmP.Text Then
            With UserData(NumofUsers)    'Puts values from all textboxes into the record elements
                .Username = txtUserN.Text
                .Password = txtPass.Text
            End With
            NumofUsers += 1    ' increments the number of records
            txtUserN.Text = ""      ' clears all the textboxes ready for another new student
            txtPass.Text = ""
            txtConfirmP.Text = ""
            savetofile()
            Me.Hide()
            MainMenu.Show()
        Else
            MsgBox("Please Ensure Passwords Match")
        End If

    End Sub
    Private Sub savetofile()
        Dim sep As String = ","
        Dim Nrecord As String = ";"
        Dim File = My.Computer.FileSystem.OpenTextFileWriter(filename, False)
        For i As Integer = 0 To UserData.Length - 1
            With UserData(i)
                If .Username <> Nothing Then
                    Dim oneline As String = .Username + sep + .Password + Nrecord
                    File.Write(oneline)
                End If
            End With
        Next
        File.Close()
        MsgBox("Welcome!")
    End Sub


End Class