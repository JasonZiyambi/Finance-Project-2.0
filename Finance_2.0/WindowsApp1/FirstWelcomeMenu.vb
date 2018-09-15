Public Class FirstWelcomeMenu
    Private Account(1000) As Account
    Public AccountNumber As Integer
    Private goals(1000) As record
    Private transactions(1000) As transrecord
    Structure transrecord
        Dim Username As String
        Dim amount As Double
    End Structure
    Structure record
        Dim Username As String
        Dim name As String
        Dim Price As Double
    End Structure
    Dim Gname As New List(Of String)
    Dim Price As New List(Of Double)

    Dim TUsername As New List(Of String)
    Dim Tamount As New List(Of Double)


    'Sub settingarraytonothing()
    '    For i = 0 To 10000
    '        Goals(i).name = Nothing
    '        Goals(i).Price = Nothing
    '    Next

    'End Sub

    Sub LoadFromFile()



        Dim file3 = My.Computer.FileSystem.ReadAllText(Filename3), Record3() As String = file3.Split(";")
        For NumofUsers = 0 To Record3.Length - 1
            If Record3(NumofUsers) <> Nothing Then
                Dim items() As String = Record3(NumofUsers).Split(",")
                transactions(NumofUsers).Username = items(0)
                transactions(NumofUsers).amount = items(1)
            End If
        Next


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
                For i = 0 To goals.Length - 1
                    If goals(i).Username = items(0) Then
                        Gname.Add(goals(i).name)
                        Price.Add(goals(i).Price)
                    End If
                Next
                For i = 0 To transactions.Length - 1
                    If transactions(i).Username = items(0) Then
                        TUsername.Add(transactions(i).Username)
                        Tamount.Add(transactions(i).amount)
                    End If
                Next
                Account(NumofUsers) = New Account(items(0), items(1), items(2), items(3), items(4), items(5), items(6), Gname, Price, TUsername, Tamount)
            End If
            Gname.Clear()
            Price.Clear()

            TUsername.Clear()
            Tamount.Clear()
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
                    'MainMenu.Show()
                    login.Hide()
                    setaccountnumber(i)
                    setCB()
                    If Account(AccountNumber).ROP() = 0 AndAlso Account(AccountNumber).amountofweeksreturn() = 0 AndAlso Account(AccountNumber).amountofhoursreturn() = 0 Then
                        AccountDetails.Show()
                        AccountDetails.CmdReturn.Enabled = False
                        showaccountdetails()
                    Else
                        MainMenu.Show()
                    End If
                    Exit For
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
        'For i = 0 To 1000
        '    GName(i) = Nothing
        '    Price(i) = Nothing
        'Next
        Account(amountofaccounts()) = New Account(username, password, 0, 0, 0, 0, 0, Gname, Price, TUsername, Tamount)
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
    Sub setvalues(ROP, HPW, AOW, CB)
        Account(Me.AccountNumber).SetRateOfPay(ROP)
        Account(Me.AccountNumber).SetHoursPerWeek(HPW)
        Account(Me.AccountNumber).SetAmountOfWeeks(AOW)
        Account(Me.AccountNumber).setCurrentBalance(CB)
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

    Sub createTransaction(ByVal Price As String)
        Account(AccountNumber).Addtransaction(Price)

        SavetoTransactionfile()
    End Sub


    Sub SavetoTransactionfile()
        Dim data As String = Nothing
        For accountNo = 0 To amountofaccounts() - 1
            For i As Integer = 0 To 1000
                Try
                    If Account(accountNo).TransOutput(i) <> Account(accountNo).GetUsername & ",0;" Then
                        Dim oneline As String = Account(accountNo).TransOutput(i)
                        data = data & oneline
                        MsgBox(oneline)

                    End If
                Catch
                    Exit For
                End Try
            Next

        Next
        Dim File = My.Computer.FileSystem.OpenTextFileWriter(Filename3, False)
        File.Write(data)
        File.Close()
        'MainMenu.Label3.Text = "£" & Account(AccountNumber).GetCurrentBalance() + 
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

    Sub accountdetailslabel()
        AccountDetails.Label4.Text = "Welcome: " + Account(AccountNumber).GetUsername
    End Sub
    Function outputtimetaken(ByVal price)
        Return Math.Round((price / Account(AccountNumber).MonthlyIncome) * 4, 1)
    End Function
    Function hoursneeded(ByVal price As Integer)
        Return Math.Round(price / Account(AccountNumber).ROP, 1)
    End Function

    Sub setCB()
        MainMenu.Label3.Text = "£" & Account(AccountNumber).GetCurrentBalance()
    End Sub
    Sub showaccountdetails()
        AccountDetails.txtROP.Text = Account(AccountNumber).ROP
        AccountDetails.txtHPW.Text = Account(AccountNumber).amountofhoursreturn
        AccountDetails.txtAOW.Text = Account(AccountNumber).amountofweeksreturn
        AccountDetails.txtBalance.Text = Account(AccountNumber).GetCurrentBalance()
    End Sub

    Sub createchart()

        Dim transactionlist As New List(Of Double)
        For i = 0 To Account(AccountNumber).amountoftransactions - 1
            transactionlist.Add(Account(AccountNumber).transactionoutput(i))
        Next

        Analysis.chart(transactionlist)
        Analysis.Show()
    End Sub
End Class
