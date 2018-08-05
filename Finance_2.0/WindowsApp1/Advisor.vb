Public Class Advisor



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        'For i = 0 To FirstWelcomeMenu.getgoalsmaxlength
        '    If ComboBox1.SelectedItem =  Then
        '        txtAmount.Text = 
        '    End If
        'Next

        FirstWelcomeMenu.comboboxchanged(ComboBox1.SelectedItem)
    End Sub

    Private Sub Advisor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FirstWelcomeMenu.Combobox()
    End Sub

    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        MainMenu.Show()
        Me.Close()
        ComboBox1.Items.Clear()

    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            MsgBox("Weeks: " & FirstWelcomeMenu.outputtimetaken(CDbl(txtAmount.Text)))
        Catch
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            MsgBox("You need to work " & FirstWelcomeMenu.hoursneeded(CDbl(txtAmount.Text)) & " Hours")
        Catch
        End Try

    End Sub
End Class