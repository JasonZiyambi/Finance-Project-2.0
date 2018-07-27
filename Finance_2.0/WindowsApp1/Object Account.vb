Module Object_Account
    Class Account
        Public Goals As String
        Public Prices As Double
        Public RateofPay As Double
        Public HoursPerWeek As Double
        Public AmountOfWeeks As Integer
        Public Expenditure As Double
        Public CurrentBalance As Double

        Public Sub SetRateOfPay(ByVal ROP As Double)
            RateofPay = ROP
        End Sub
        Public Sub SetHoursPerWeek(ByVal HPW As Double)
            HoursPerWeek = HPW
        End Sub
        Public Sub SetAmountOfWeeks(ByVal AOW As Double)
            AmountOfWeeks = AOW
        End Sub
        Public Function MonthlyIncome() As Double
            Return RateofPay * HoursPerWeek * AmountOfWeeks
        End Function
    End Class
End Module
