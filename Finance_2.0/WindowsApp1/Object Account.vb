Public Class Account
#Region "Variables"
    Private goals(1000) As record
    Structure record
        Dim name As String
        Dim Price As Double
    End Structure

    Private RateofPay As Double
    Private HoursPerWeek As Double
    Private AmountOfWeeks As Integer
    Private Expenditure As Double
    Private CurrentBalance As Double
    Private Username As String
    Private Password As String
#End Region
#Region "Constructor"
    Public Sub New(ByVal Username As String, ByVal Password As String, ByVal Rateofpay As String, ByVal HoursPerWeek As String, AmountOfWeeks As String, Expenditure As String, CurrentBalance As String, name As List(Of String), price As List(Of Double))
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

    End Sub
#End Region
#Region "Functions"
    Sub SetPassword(ByVal Password As String)
        Me.Password = Password
    End Sub
    Function GetUsername()
        Return Me.Username
    End Function
    Function CheckPassword(ByVal Password As String)
        If Me.Password = Password Then Return True Else Return False
    End Function

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
    Function GoalOutput(ByVal goalnumber As Integer)
        Return Me.GetUsername & "," & goals(goalnumber).name & "," & goals(goalnumber).Price & ";"
    End Function

    Function goalname(ByVal goal As Integer)
        Return goals(goal).name
    End Function
    Function goalprice(ByVal goal As Integer)
        Return goals(goal).Price
    End Function


#End Region
End Class
