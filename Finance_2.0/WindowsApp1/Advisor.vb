Public Class Advisor



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Advisor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FirstWelcomeMenu.Combobox()
    End Sub

    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        AccountDetails.Show()
        Me.Close()
        ComboBox1.Items.Clear()

    End Sub
End Class