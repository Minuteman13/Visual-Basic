 Dim userSales As Integer
    Dim userComm As Integer

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click

        If TextBoxSales.Text > 40000 Then
            userSales = TextBoxSales.Text
            userComm = userSales * 0.14
            lblUserCommission.Text = "Based on your sales of $" & userSales & ", your commission is $" & userComm

        ElseIf TextBoxSales.Text <= 40000 And TextBoxSales.Text > 25000 Then
            userSales = TextBoxSales.Text
            userComm = userSales * 0.09
            lblUserCommission.Text = "Based on your sales of $" & userSales & ", your commission is $" & userComm

        ElseIf TextBoxSales.Text <= 25000 And TextBoxSales.Text > 10000 Then
            userSales = TextBoxSales.Text
            userComm = userSales * 0.07
            lblUserCommission.Text = "Based on your sales of $" & userSales & ", your commission is $" & userComm

        Else
            lblUserCommission.Text = "Based on your sales of $" & userSales & ", your commission is $0.00 and You're Fired!"

        End If
    End Sub


    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        userSales = 0
        userComm = 0
        TextBoxSales.Text = " "
        lblUserCommission.Text = "User Commision Report"

    End Sub
