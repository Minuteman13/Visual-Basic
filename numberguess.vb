
    Dim userNumber As Integer
    Dim numberCounter As Integer = 0

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click

        numberCounter = numberCounter + 1

        labelWrongNumberCounter.Text = numberCounter

        userNumber = Val(userInput.Text)

        If userNumber = 13 Then

            labelResultWinner.Visible = True

        ElseIf userNumber >= 0 And userNumber < 13 Then

            labelResultLoser.Text = "Too Low Try Again"
            labelResultLoser.Visible = True

        ElseIf userNumber > 13 And userNumber <= 60 Then

            labelResultLoser.Text = "Your guess is too high, Try Again"
            labelResultLoser.Visible = True

        ElseIf userNumber > 60 And userNumber < 101 Then

            labelResultLoser.Text = "Get off your high horse, that's too high!"
            labelResultLoser.Visible = True

        Else
            labelResultLoser.Text = "You're out of this world! Get back here!"
            labelResultLoser.Visible = True

        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        If userNumber = 13 Then
            labelWrongNumberCounter.Text = 0
            numberCounter = 0
        End If

        userInput.Text = ""

        labelResultWinner.Visible = False
        labelResultLoser.Visible = False

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        labelResultWinner.Visible = False
        labelResultLoser.Visible = False
    End Sub
