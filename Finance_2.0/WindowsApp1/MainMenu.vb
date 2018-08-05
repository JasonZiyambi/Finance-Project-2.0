Public Class MainMenu
    Private Sub cmdLogout_Click(sender As Object, e As EventArgs) Handles cmdLogout.Click
        FirstWelcomeMenu.Show()
        Me.Close()

    End Sub

    Private Sub CmdAccount_Click(sender As Object, e As EventArgs) Handles CmdAccount.Click
        AccountDetails.Show()
        Me.Hide()
        FirstWelcomeMenu.showaccountdetails()
    End Sub

    Private Sub cmdAdvisor_Click(sender As Object, e As EventArgs) Handles cmdAdvisor.Click
        Advisor.Show()
        Me.Hide()
    End Sub

    Private Sub CmdCTG_Click(sender As Object, e As EventArgs) Handles CmdCTG.Click
        Goals.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class