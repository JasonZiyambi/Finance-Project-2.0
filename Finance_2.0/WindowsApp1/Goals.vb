Public Class Goals
    Private Sub cmdsave_Click(sender As Object, e As EventArgs) Handles cmdsave.Click
        With GoalData(Numofgoals)
            .Goal = txtGoal.Text
            .Price = txtPrice.Text
        End With
        NumofUsers += 1
        txtGoal.Text = ""
        txtPrice.Text = ""
        savetofile()
    End Sub
    Private Sub savetofile()
        Dim sep As String = ","
        Dim Nrecord As String = ";"
        Dim File = My.Computer.FileSystem.OpenTextFileWriter(filename2, False)
        For i As Integer = 0 To GoalData.Length - 1
            With GoalData(i)
                If .Goal <> Nothing Then
                    Dim oneline As String = .Goal & sep & "£" & .Price & sep & login.txtUserN.Text & Nrecord
                    File.WriteLine(oneline)
                    MsgBox("Saved")
                End If
            End With
        Next
        File.Close()
        txtGoal.Text = Nothing
        txtPrice.Text = Nothing

    End Sub

    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        Account.Show()
        Me.Hide()
    End Sub
End Class