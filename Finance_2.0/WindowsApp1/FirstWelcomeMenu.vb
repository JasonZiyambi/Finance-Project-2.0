Public Class FirstWelcomeMenu
    Sub LoadFromFile()
        Dim sep As String = ","
        Dim File = My.Computer.FileSystem.ReadAllText(filename)
        NumofUsers = 0

        'Dim oneline As String = File.ReadLine()
        Dim Record() As String = File.Split(";")
        For NumofUsers = 0 To Record.Length - 1
            If Record(NumofUsers) <> Nothing Then
                Dim items() As String = Record(NumofUsers).Split(",")
                With UserData(NumofUsers)
                    .Username = items(0)
                    .Password = items(1)
                End With
                NumofUsers += 1
            End If
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadFromFile()
        For i = 0 To UserData.Length - 1

start:
            Dim username = InputBox("Enter username")
            If username = "" Then
                MsgBox("Enter Username")
                GoTo start
            ElseIf username <> UserData(i).Username Then

                MsgBox("User not found!")
                GoTo start
            ElseIf username = UserData(i).Username Then
                GoTo Start2

            End If

Start2:
            Dim Pass = InputBox("Enter Password")
            If Pass = UserData(i).Password Then
                MsgBox("Welcome back " + username)
                GoTo Start3
            ElseIf Pass = "" Then
                MsgBox("Enter a password")
                GoTo Start2
            ElseIf Pass <> UserData(i).Password Then
                MsgBox("Incorrect password")
                GoTo Start2

            End If

        Next
Start3:
        Me.Hide()
        MainMenu.Show()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LoadFromFile()
        NewUser.Show()
        Me.Hide()
    End Sub
End Class
