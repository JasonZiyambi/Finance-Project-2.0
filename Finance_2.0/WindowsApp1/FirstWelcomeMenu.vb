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
    Sub loadfromfile2()
        Dim sep As String = ","
        Dim File = My.Computer.FileSystem.ReadAllText(filename2), Record() As String = File.Split(";")
        For Numofgoals = 0 To Record.Length - 1
            'MsgBox(Record(NumofUsers))
            If Record(Numofgoals) <> Nothing Then
                Dim items() As String = Record(Numofgoals).Split(",")
                With GoalData(Numofgoals)
                    .Goal = items(0)
                    .Price = items(1)
                End With
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadFromFile()
        loadfromfile2()
        login.txtUserN.Text = Nothing
        login.txtPass.Text = Nothing
        login.Show()
        Me.Hide()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LoadFromFile()

        NewUser.Show()
        Me.Hide()
    End Sub
End Class
