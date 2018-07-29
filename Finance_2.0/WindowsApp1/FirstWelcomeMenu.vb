Public Class FirstWelcomeMenu
    Private Account(1000) As Account
    Sub LoadFromFile()
        Dim sep As String = ","
        Dim File = My.Computer.FileSystem.ReadAllText(filename), Record() As String = File.Split(";")
        For NumofUsers = 0 To Record.Length - 1
            If Record(NumofUsers) <> Nothing Then
                Dim items() As String = Record(NumofUsers).Split(",")
                With UserData(NumofUsers)
                    .Username = items(0)
                    .Password = items(1)
                    .RateOfPay = items(2)
                    .HoursPerWeek = items(3)
                    .AmountOfWeeks = items(4)
                    .Expenditure = items(5)
                    .CurrentBalance = items(6)
                End With
                Account(NumofUsers) = New Account(UserData(NumofUsers).Username, UserData(NumofUsers).Password)

            End If
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login.txtPass.Text = Nothing
        Login.txtUserN.Text = Nothing
        LoadFromFile()
        Login.Show()
        Me.Hide()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LoadFromFile()
        NewUser.Show()
        Me.Hide()
    End Sub
    Sub LoginScript(ByVal Username As String, ByVal Password As String)
        For i = 0 To Account.Length
            If Account(i).GetUsername = Username Then
                If Account(i).CheckPassword(Password) = True Then
                    MainMenu.Show()
                    Me.Hide()
                    Exit For
                Else
                    MsgBox("Password Incorrect!")
                End If
            End If
        Next
    End Sub

    Private Sub AccountDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Private Account() As Account
        '
    End Sub
End Class
