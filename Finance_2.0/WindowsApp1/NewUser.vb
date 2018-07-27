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
        Dim File = My.Computer.FileSystem.OpenTextFileWriter(filename, False)   'open the file
        For i As Integer = 0 To UserData.Length - 1   'loop through all the records
            With UserData(i)
                If .Username <> Nothing Then  'only save this student if not zero'd (deleted)
                    Dim oneline As String = .Username + sep + .Password + Nrecord
                    File.WriteLine(oneline)   'write the line to file
                End If
            End With
        Next
        File.Close()    'remember to close the file when writing is finished
        MsgBox("Welcome!")
    End Sub


End Class