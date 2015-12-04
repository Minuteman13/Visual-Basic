 Dim dollarValue, euroValue, poundsValue As Double

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        txtDollars.Text = " "
        'numEuroRate.Value = 0
        txtEuros.Text = " "
        'numPoundsRate.Value = 0
        txtPounds.Text = " "
    End Sub

    Private Sub btnConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click

        dollarValue = txtDollars.Text
        euroValue = numEuroRate.Value
        poundsValue = numPoundsRate.Value

        txtEuros.Text = dollarValue * euroValue
        txtPounds.Text = dollarValue * poundsValue
    End Sub
