Module GoalsStructure
    Structure Record
        Dim Goal As String
        Dim Price As Double
    End Structure

    Public Numofgoals As Integer = 0
    Public GoalData(1000) As Record
    Public filename2 As String = "Goals.txt"
End Module
