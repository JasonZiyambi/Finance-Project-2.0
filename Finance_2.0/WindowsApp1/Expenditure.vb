Public Class Expenditure
    Private Sub cmdsave_Click(sender As Object, e As EventArgs) Handles cmdsave.Click
        FirstWelcomeMenu.createTransaction(CInt(txtExp.Text) - (CInt(txtExp.Text) * 2))
        txtExp.Text = ""
    End Sub

    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        AccountDetails.Show()
        Me.Close()
    End Sub
End Class