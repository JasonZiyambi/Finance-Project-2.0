Public Class FirstWelcomeMenu
    Private Account(1000) As Account
    Public AccountNumber As Integer

    Private goals(1000) As record
    Structure record
        Dim Username As String
        Dim name As String
        Dim Price As Double
    End Structure
    Dim Gname As New List(Of String)
    Dim Price As New List(Of Double)


    'Sub settingarraytonothing()
    '    For i = 0 To 10000
    '        Goals(i).name = Nothing
    '        Goals(i).Price = Nothing
    '    Next

    'End Sub

    Sub LoadFromFile()
        Dim file2 = My.Computer.FileSystem.ReadAllText(filename2), Record2() As String = file2.Split(";")
        For NumofUsers = 0 To Record2.Length - 1
            If Record2(NumofUsers) <> Nothing Then
                Dim items() As String = Record2(NumofUsers).Split(",")
                goals(NumofUsers).Username = items(0)
                goals(NumofUsers).name = items(1)
                goals(NumofUsers).Price = items(2)
            End If
        Next

        Dim sep As String = ","
        Dim File = My.Computer.FileSystem.ReadAllText(filename), Record() As String = File.Split(";")
        For NumofUsers = 0 To Record.Length - 1
            If Record(NumofUsers) <> Nothing Then
                Dim items() As String = Record(NumofUsers).Split(",")
                For i = 0 To 1000
                    If goals(i).Username = items(0) Then
                        Gname.Add(goals(i).name)
                        Price.Add(goals(i).Price)
                    End If
                Next
                Account(NumofUsers) = New Account(items(0), items(1), items(2), items(3), items(4), items(5), items(6), Gname, Price)
            End If
            Gname.Clear()
            Price.Clear()
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
    'Function checkifUsernameisUsed(input)
    '    Dim errorcount As Integer = 0
    '    For i = 0 To Account.Length - 1
    '        If input = Account(i).GetUsername Then
    '        Else
    '            errorcount += 1
    '        End If
    '    Next
    '    If errorcount = 1000 Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function


    Sub createaccount(ByVal username As String, ByVal password As String)
        For i = 0 To 1000
            GName(i) = Nothing
            Price(i) = Nothing
        Next
        Account(amountofaccounts()) = New Account(username, password, 0, 0, 0, 0, 0, GName, Price)
        'If checkifUsernameisUsed(NewUser.txtUserN.Text) = True Then
        '    MsgBox("That Username is already in use")

        'End If
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
    Sub SavetoGoalfile()
        Dim data As String = Nothing
        For accountNo = 0 To amountofaccounts() - 1
            For i As Integer = 0 To 1000
                Try
                    If Account(accountNo).GoalOutput(i) <> Account(accountNo).GetUsername & ",,0;" Then
                        Dim oneline As String = Account(accountNo).GoalOutput(i)
                        data = data & oneline
                        'MsgBox(oneline)
                    End If
                Catch
                    Exit For
                End Try
            Next

        Next
        Dim File = My.Computer.FileSystem.OpenTextFileWriter(filename2, False)
        File.Write(Data)
        File.Close()
    End Sub
    Sub createGoal(ByVal name As String, ByVal Price As String)
        Account(AccountNumber).AddGoal(name, Price)
        SavetoGoalfile()
    End Sub



    Sub Combobox()
        For i = 0 To Account(AccountNumber).getgoalsmaxlength()
            If Account(AccountNumber).goalname(i) <> Nothing Then
                Advisor.ComboBox1.Items.Add(Account(AccountNumber).goalname(i))
            End If

        Next
    End Sub

    Sub comboboxchanged(ByVal name As String)
        For i = 0 To Account(AccountNumber).getgoalsmaxlength
            If Account(AccountNumber).goalname(i) = name Then
                Advisor.txtAmount.Text = Account(AccountNumber).goalprice(i)
            End If
        Next
    End Sub

End Class
