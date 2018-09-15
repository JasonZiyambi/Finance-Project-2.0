Public Class Account
#Region "Variables"
    Private goals(1000) As record
    Private transaction(1000) As TransRecord

    Structure TransRecord
        Dim Username As String
        Dim amount As Double
    End Structure
    Structure record
        Dim name As String
        Dim Price As Double
    End Structure

    Private RateofPay As Double
    Private HoursPerWeek As Double
    Private AmountOfWeeks As Integer
    Private Expenditure As Double
    Private income As Double
    Private CurrentBalance As Double
    Private Username As String
    Private Password As String
#End Region
#Region "Constructor"
    Public Sub New(ByVal Username As String, ByVal Password As String, ByVal Rateofpay As Integer, ByVal HoursPerWeek As Integer, AmountOfWeeks As Integer, Expenditure As String, CurrentBalance As Integer, name As List(Of String), price As List(Of Double), Tusernames As List(Of String), Tamounts As List(Of Double))
        ' This call is required by the designer.
        ' InitializeComponent()
        Me.Username = Username
        Me.Password = Password
        Me.RateofPay = Rateofpay
        Me.HoursPerWeek = HoursPerWeek
        Me.AmountOfWeeks = AmountOfWeeks
        Me.Expenditure = Expenditure
        Me.CurrentBalance = CurrentBalance

        For i = 0 To price.Count - 1
            Me.goals(i).Price = price.Item(i)
            Me.goals(i).name = name.Item(i)
        Next

        For i = 0 To Tusernames.Count - 1
            Me.transaction(i).Username = Tusernames.Item(i)
            Me.transaction(i).amount = Tamounts.Item(i)

        Next
    End Sub
#End Region
#Region "Functions"
    Sub SetPassword(ByVal Password As String)
        Me.Password = Password
    End Sub
    Function GetUsername()
        Return Me.Username
    End Function

    Function GetCurrentBalance()
        Return outputCB()
    End Function

    Function CheckPassword(ByVal Password As String)
        If Me.Password = Password Then Return True Else Return False
    End Function

    Sub setCurrentBalance(ByVal CB As Double)
        Me.CurrentBalance = CB
    End Sub

    Sub SetRateOfPay(ByVal ROP As Double)
        Me.RateofPay = ROP
    End Sub
    Sub SetHoursPerWeek(ByVal HPW As Double)
        HoursPerWeek = HPW
    End Sub
    Sub SetAmountOfWeeks(ByVal AOW As Double)
        AmountOfWeeks = AOW
    End Sub
    Function MonthlyIncome() As Double
        Return RateofPay * HoursPerWeek * AmountOfWeeks
    End Function
    Function RecordOutput()
        Return Me.Username & "," & Me.Password & "," & Me.RateofPay & "," & Me.HoursPerWeek & "," & Me.AmountOfWeeks & "," & Me.Expenditure & "," & Me.CurrentBalance & ";"
    End Function
    Function amountofgoals()
        For i = 0 To goals.Length - 1
            If GoalOutput(i) = Me.GetUsername & ",,0;" Then Return i
        Next
        'Return 1000
    End Function
    Sub AddGoal(ByVal name As String, ByVal price As Double)
        Dim Amount As Integer = amountofgoals()
        goals(Amount).name = name
        goals(Amount).Price = price
    End Sub

    Function amountoftransactions()
        For i = 0 To transaction.Length - 1
            If TransOutput(i) = Me.GetUsername & ",0;" Then Return i
        Next
        'Return 1000
    End Function
    Sub Addtransaction(ByVal amount As Double)
        Dim x As Integer = amountoftransactions()
        transaction(x).amount = amount
    End Sub

    Function TransOutput(ByVal transNo As Integer)
        Return Me.GetUsername() & "," & transaction(transNo).amount & ";"
    End Function
    Function GoalOutput(ByVal goalnumber As Integer)
        Return Me.GetUsername & "," & goals(goalnumber).name & "," & goals(goalnumber).Price & ";"
    End Function
    Function getgoalsmaxlength()
        For i = 0 To goals.Length
            If goals(i).name = Nothing Then Return i
        Next
    End Function
    Function goalname(ByVal goal As Integer)
        Return goals(goal).name
    End Function
    Function goalprice(ByVal goal As Integer)
        Return goals(goal).Price
    End Function
    Function ROP()
        Return Me.RateofPay
    End Function
    Function amountofweeksreturn()
        Return Me.AmountOfWeeks
    End Function
    Function amountofhoursreturn()
        Return Me.HoursPerWeek
    End Function
    Function outputCB()
        Dim CurrentBalance As Integer = Nothing
        For i = 0 To amountoftransactions()
            CurrentBalance += transaction(i).amount
        Next
        setCurrentBalance(CurrentBalance)
        Return CurrentBalance
    End Function
    Function transactionoutput(number As Integer)
        Return transaction(number).amount
    End Function
#End Region
End Class
