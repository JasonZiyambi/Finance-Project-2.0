Public Class Account
    Private Sub CmdCTG_Click(sender As Object, e As EventArgs) Handles CmdCTG.Click
        Goals.Show()
        Me.Hide()
    End Sub

    Private Sub CmdReturn_Click(sender As Object, e As EventArgs) Handles CmdReturn.Click
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

    End Sub
End Class