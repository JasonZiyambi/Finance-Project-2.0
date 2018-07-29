Module UserStructure
    Structure Record
        Dim Username As String
        Dim Password As String
        Dim RateofPay As Double
        Dim HoursPerWeek As Double
        Dim AmountOfWeeks As Integer
        Dim Expenditure As Double
        Dim CurrentBalance As Double
    End Structure

    Public NumofUsers As Integer = 0
    Public UserData(1000) As Record
    Public filename As String = "C:\Users\adams\Desktop\Data.txt"

End Module
