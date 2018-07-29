﻿Public Class FirstWelcomeMenu
    Private Account(1000) As Account
    Public AccountNumber As Integer
    Sub LoadFromFile()
        Dim sep As String = ","
        Dim File = My.Computer.FileSystem.ReadAllText(filename), Record() As String = File.Split(";")
        For NumofUsers = 0 To Record.Length - 1
            If Record(NumofUsers) <> Nothing Then
                Dim items() As String = Record(NumofUsers).Split(",")
                '            With UserData(NumofUsers)
                '                .Username = items(0)
                '                .Password = items(1)
                '                .RateOfPay = items(2)
                '                .HoursPerWeek = items(3)
                '                .AmountOfWeeks = items(4)
                '                .Expenditure = items(5)
                '                .CurrentBalance = items(6)
                '            End With
                Account(NumofUsers) = New Account(items(0), items(1), items(2), items(3), items(4), items(5), items(6))
            End If
        Next

    End Sub
    Sub savetofile()
        Dim Nrecord As String = ";"
        Dim File = My.Computer.FileSystem.OpenTextFileWriter(filename, False)
        For i As Integer = 0 To Account.Length - 1
            Try
                If Account(i).RecordOutput <> Nothing Then
                    Dim oneline As String = Account(i).RecordOutput
                    File.Write(oneline)
                End If
            Catch
                Exit For
            End Try
        Next
        File.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login.txtPass.Text = Nothing
        Login.txtUserN.Text = Nothing

        login.Show()
        Me.Hide()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        NewUser.Show()
        Me.Hide()
    End Sub
    Sub LoginScript(ByVal Username As String, ByVal Password As String)
        For i = 0 To amountofaccounts() - 1
            If Account(i).GetUsername = Username Then
                If Account(i).CheckPassword(Password) = True Then
                    MainMenu.Show()
                    login.Hide()
                    setaccountnumber(i)
                    Exit For
                Else
                    MsgBox("Password Incorrect!")
                    Exit For
                End If
            ElseIf i = amountofaccounts() - 1 Then
                MsgBox("Username Incorrect!")
            End If
        Next
    End Sub

    Sub createaccount(ByVal username As String, ByVal password As String)
        Account(amountofaccounts()) = New Account(username, password, 0, 0, 0, 0, 0)
        savetofile()
    End Sub
    Function amountofaccounts()
        For i = 0 To Account.Length
            If Account(i) Is Nothing Then
                Return i

            End If
        Next

    End Function
    Private Sub FirstWelcomeMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFromFile()
    End Sub
    Sub setaccountnumber(ByVal accountnumber As Integer)
        Me.AccountNumber = accountnumber
    End Sub
    Sub setvalues(ROP, HPW, AOW)
        Account(Me.AccountNumber).SetRateOfPay(ROP)
        Account(Me.AccountNumber).SetHoursPerWeek(HPW)
        Account(Me.AccountNumber).SetAmountOfWeeks(AOW)
        savetofile()
    End Sub
End Class
