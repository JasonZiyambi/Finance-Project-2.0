Public Class MainMenu
    Private Sub cmdLogout_Click(sender As Object, e As EventArgs) Handles cmdLogout.Click
        FirstWelcomeMenu.Show()
        Me.Close()
        cmdAdvisor.Visible = False
        cmdProjections.Visible = False
        cmdAnalysis.Visible = False
    End Sub

    Private Sub CmdAccount_Click(sender As Object, e As EventArgs) Handles CmdAccount.Click
        AccountDetails.Show()
        Me.Hide()
    End Sub

    Private Sub cmdAdvisor_Click(sender As Object, e As EventArgs) Handles cmdAdvisor.Click
        Advisor.Show()
        Me.Hide()
    End Sub
End Class