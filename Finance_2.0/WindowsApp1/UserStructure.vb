Module UserStructure
    Structure Record
        Dim Username As String
        Dim Password As String
    End Structure

    Public NumofUsers As Integer = 0
    Public UserData(1000) As Record
    Public filename As String = "User Data.txt"

End Module
