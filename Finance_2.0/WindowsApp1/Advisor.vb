Public Class Advisor



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        '<<<<<<< HEAD
        'For i = 0 To FirstWelcomeMenu.getgoalsmaxlength
        '    If ComboBox1.SelectedItem =  Then
        '        txtAmount.Text = 
        '    End If
        'Next
        '=======
        FirstWelcomeMenu.comboboxchanged(ComboBox1.SelectedItem)
'>>>>>>> fe781e22dd8d7d895a47e86fe02eed5d7a443e1d
    End Sub

    Private Sub Advisor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FirstWelcomeMenu.Combobox()
    End Sub

    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        AccountDetails.Show()
        Me.Close()
        ComboBox1.Items.Clear()

    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub
End Class