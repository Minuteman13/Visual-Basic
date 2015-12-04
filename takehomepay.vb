 Private Sub calculateTakeHomePay()

        Dim dblSocial, dblFed, dblState, dblMedicare, dblWeeklyPay As Double
        Dim dblRetirement, dblInsurance, dblTakeHomePay As Double

        dblWeeklyPay = Convert.ToDouble(SalaryList.Value) / 52.0

        dblSocial = dblWeeklyPay * 0.062
        dblFed = dblWeeklyPay * 0.18
        dblState = dblWeeklyPay * 0.025
        dblMedicare = dblWeeklyPay * 0.0145

        dblRetirement = dblWeeklyPay * (TrackBarValue.Value / 100)

        If radioButtonNone.checked = True Then

            dblInsurance = 0

        ElseIf radioButtonIndivual.Checked = True Then

            dblInsurance = 20.0

        Else

            dblInsurance = 30.0
        End If

        dblTakeHomePay = dblWeeklyPay - dblSocial - dblFed - dblState - dblMedicare - dblRetirement - dblInsurance

        labelTakeHomePay.Text = Format(dblTakeHomePay, "Currency")

    End Sub

    Private Sub SalaryList_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalaryList.ValueChanged

        calculateTakeHomePay()
    End Sub

    Private Sub TrackBarValue_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBarValue.Scroll

        calculateTakeHomePay()
    End Sub

    Private Sub radioButtonNone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioButtonNone.CheckedChanged

        calculateTakeHomePay()
    End Sub

    Private Sub radioButtonIndivual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioButtonIndivual.CheckedChanged

        calculateTakeHomePay()
    End Sub

    Private Sub radioButtonFamily_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioButtonFamily.CheckedChanged

        calculateTakeHomePay()
    End Sub
