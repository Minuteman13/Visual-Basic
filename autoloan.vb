 'Chapter 4:     Automobile Loan Calculator
    'Programmer:    Daniel Minuto
    'Date:          12/1/15
    'Purpose:       This program calculates the monthly payment for
    '               a loan based on loan amount, interest rate, and 
    '               length of loan
    Dim globalMonths As Double = 60.0
    Const maxLoanAmountAllowed As Integer = 25000
    Const maxLowCreditAllowed As Double = 5000

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        numLoanAmount.Value = 0.0
        numInterestRate.Value = 5.0
        btn5Years.Checked = True
        txtMonthlyPayment.Text = "$0.00"
        cmbCreditRating.SelectedIndex = -1
    End Sub

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click

        Dim dblRate, dblMonths, dblPayment As Double
        Dim dblLoanAmount As Double, strPayment As String
        Dim dblAdjustedRate As Double, strErrorMesage As String

        dblLoanAmount = Convert.ToDouble(numLoanAmount.Value)

        dblRate = (Convert.ToDouble(numInterestRate.Value) / 100) / 12

        If cmbCreditRating.Text = " " Then
            MessageBox.Show("Please enter the customer's credit rating in the credit rating box.", "No Credit Rating")
            cmbCreditRating.Focus()
            Exit Sub

        End If

        Select Case cmbCreditRating.SelectedIndex
            Case 0
                dblAdjustedRate = dblRate
            Case 1
                dblAdjustedRate = dblRate * 1.1
            Case 2
                dblAdjustedRate = dblRate * 1.15
            Case 3
                dblAdjustedRate = dblRate * 1.17
            Case 4
                dblAdjustedRate = dblRate * 1.25
        End Select
        dblPayment = Pmt(dblAdjustedRate, globalMonths, -dblLoanAmount)
        strPayment = Format$(dblPayment, "Currency")
        txtMonthlyPayment.Text = strPayment
    End Sub

    Private Sub btn3Years_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3Years.CheckedChanged
        globalMonths = 36
    End Sub

    Private Sub btn5Years_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5Years.CheckedChanged
        globalMonths = 60
    End Sub

    Private Sub btn7Years_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7Years.CheckedChanged
        globalMonths = 84
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        numLoanAmount.Maximum = maxLoanAmountAllowed
    End Sub
End Class
