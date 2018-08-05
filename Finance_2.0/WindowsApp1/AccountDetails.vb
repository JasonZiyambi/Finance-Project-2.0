Public Class AccountDetails
    Private Sub CmdCTG_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CmdReturn_Click(sender As Object, e As EventArgs) Handles CmdReturn.Click
        MainMenu.Show()
        Me.Close()

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtROP.Text = 0 AndAlso txtHPW.Text = 0 AndAlso txtAOW.Text = 0 Then
            MsgBox("Enter All values")
        Else
            CmdReturn.Enabled = True
            FirstWelcomeMenu.setvalues(txtROP.Text, txtHPW.Text, txtAOW.Text, txtBalance.Text)
            MsgBox("Saved!")
            MainMenu.Label3.Visible = True
            MainMenu.Label3.Text = "£" + txtBalance.Text
            Label5.Visible = False
            txtBalance.Visible = False
        End If
    End Sub

    Private Sub AccountDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FirstWelcomeMenu.accountdetailslabel()
    End Sub

End Class