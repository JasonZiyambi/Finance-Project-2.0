Public Class Goals
    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        Me.Hide()
        AccountDetails.Show()
    End Sub

    Private Sub cmdsave_Click(sender As Object, e As EventArgs) Handles cmdsave.Click
        FirstWelcomeMenu.SetGoals(txtGoal.Text, txtPrice.Text)
        MsgBox("Saved!")

    End Sub



End Class