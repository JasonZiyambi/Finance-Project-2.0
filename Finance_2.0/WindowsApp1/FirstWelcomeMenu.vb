Public Class FirstWelcomeMenu
    Sub LoadFromFile()
        Dim sep As String = ","
        Dim File = My.Computer.FileSystem.ReadAllText(filename), Record() As String = File.Split(";")
        For NumofUsers = 0 To Record.Length - 1
            'MsgBox(Record(NumofUsers))
            If Record(NumofUsers) <> Nothing Then
                Dim items() As String = Record(NumofUsers).Split(",")
                With UserData(NumofUsers)
                    .Username = items(0)
                    .Password = items(1)
                End With
            End If
        Next
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadFromFile()
        login.Show()
        Me.Hide()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LoadFromFile()
        NewUser.Show()
        Me.Hide()
    End Sub
End Class
