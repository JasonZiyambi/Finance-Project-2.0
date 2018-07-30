Public Class Account
#Region "Variables"
    Private Goals As String
    Private Prices As Double

    Private RateofPay As Double
    Private HoursPerWeek As Double
    Private AmountOfWeeks As Integer
    Private Expenditure As Double
    Private CurrentBalance As Double
    Private Username As String
    Private Password As String
#End Region
#Region "Constructor"
    Public Sub New(ByVal Username As String, ByVal Password As String, ByVal Rateofpay As String, ByVal HoursPerWeek As String, AmountOfWeeks As String, Expenditure As String, CurrentBalance As String)
        ' This call is required by the designer.
        ' InitializeComponent()
        Me.Username = Username
        Me.Password = Password
        Me.RateofPay = Rateofpay
        Me.HoursPerWeek = HoursPerWeek
        Me.AmountOfWeeks = AmountOfWeeks
        Me.Expenditure = Expenditure
        Me.CurrentBalance = CurrentBalance
    End Sub
    Public Sub New(ByVal Goals As String, ByVal Prices As Double)
        Me.Goals = Goals
        Me.Prices = Prices
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
    Sub SetGoal(ByVal Goal As String)
        Me.Goals = Goal
    End Sub
    Sub setPrice(ByVal Price As Double)
        Me.Prices = Price
    End Sub
    Function RecordOutput()
        Return Me.Username & "," & Me.Password & "," & Me.RateofPay & "," & Me.HoursPerWeek & "," & Me.AmountOfWeeks & "," & Me.Expenditure & "," & Me.CurrentBalance & ";"
    End Function
    Function GoalOutput()
        Return Me.Goals & "," & Me.Prices & ";"
    End Function
#End Region
End Class
