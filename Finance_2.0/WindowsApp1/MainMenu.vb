﻿Public Class MainMenu
    Private Sub cmdLogout_Click(sender As Object, e As EventArgs) Handles cmdLogout.Click
        FirstWelcomeMenu.Show()
        Me.Hide()
    End Sub

    Private Sub CmdAccount_Click(sender As Object, e As EventArgs) Handles CmdAccount.Click
        Account.Show()
        Me.Hide()
    End Sub
End Class