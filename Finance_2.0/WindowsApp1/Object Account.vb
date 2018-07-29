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
    Public Sub New(ByVal Username As String, ByVal Password As String)
        ' This call is required by the designer.
        ' InitializeComponent()
        Me.Username = Username
        Me.Password = Password
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
        RateofPay = ROP
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
#End Region
End Class
