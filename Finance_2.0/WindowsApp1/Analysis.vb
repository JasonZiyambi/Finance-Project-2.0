Imports System.Windows.Forms.DataVisualization.Charting
Public Class Analysis
    Dim Balance As New Series
    Dim Income As New Series
    Dim Expenditure As New Series

    Sub chart(Transaction As List(Of Double))

        Try
            Dim expenditureNo As Integer = 1
            Dim incomeNo As Integer = 1
            Dim amount As Integer = 0
            Expenditure.Points.AddXY(0, 0)
            Income.Points.AddXY(0, 0)
            Balance.Points.AddXY(0, 0)

            For i = 0 To Transaction.Count - 1
                If Transaction(i) < 0 Then
                    Expenditure.Points.AddXY(expenditureNo, -Transaction(i))
                    expenditureNo += 1
                Else
                    Income.Points.AddXY(incomeNo, Transaction(i))
                    incomeNo += 1
                End If
                amount += Transaction(i)
                Balance.Points.AddXY(i + 1, amount)

            Next
            Expenditure.BorderWidth = 4
            Income.BorderWidth = 4
            Balance.BorderWidth = 5
            Expenditure.ChartType = SeriesChartType.Line
            Income.ChartType = SeriesChartType.Line
            Balance.ChartType = SeriesChartType.Line
            Chart1.ChartAreas("ChartArea1").AxisX.Minimum = 0
            Balance.Name = "Balance"
            Expenditure.Name = "Expenditure"
            Income.Name = "Income"
            Chart1.Series.Add(Balance)
            Chart1.Series.Add(Expenditure)
            Chart1.Series.Add(Income)
            Income.Enabled = False
            Expenditure.Enabled = False
        Catch
            Me.Close()
        End Try

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Income.Enabled = CheckBox1.Checked
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Expenditure.Enabled = CheckBox2.Checked
    End Sub
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        Balance.Enabled = CheckBox3.Checked
    End Sub
End Class