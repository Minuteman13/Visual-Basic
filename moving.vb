Dim R, L, U, D As Boolean
    Dim score As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        R = True
        L = False
        U = True
        D = False

        Me.BackColor = Color.Black

        lblBall1.Width = 50
        lblBall1.Height = 50
        lblBall1.Text = ""
        lblBall1.BackColor = Color.Green

        lblBall2.Width = 140
        lblBall2.Height = 140
        lblBall2.Text = ""
        lblBall2.BackColor = Color.Blue

        lblBall3.Width = 210
        lblBall3.Height = 190
        lblBall3.Text = ""
        lblball3.BackColor = Color.Red

    End Sub

    Private Sub tmrMoveBall1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMoveBall1.Tick

        If R = True Then
            lblBall1.Left = lblBall1.Left + 10
            If lblBall1.Left > Form1.ActiveForm.Width Then
                R = False
                L = True
            End If
        End If

        If L = True Then
            lblBall1.Left = lblBall1.Left - 10
            If lblBall1.Left < 0 Then
                L = False
                R = True
            End If
        End If

        If U = True Then
            lblBall1.Top = lblBall1.Top - 10
            If lblBall1.Top < 0 Then
                U = False
                D = True
            End If
        End If

        If D = True Then
            lblBall1.Top = lblBall1.Top + 10
            If lblBall1.Top > Form1.ActiveForm.Height Then
                D = False
                U = True
            End If
        End If

    End Sub

    Private Sub lblBall2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBall2.Click
        lblBall2.Left = CInt(Rnd() * Form1.ActiveForm.Width)
        lblBall2.Top = CInt(Rnd() * Form1.ActiveForm.Height)

    End Sub

    Private Sub lblBall1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBall1.Click
        tmrMoveBall1.Enabled = True

    End Sub
    Private Sub lblBall3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBall3.Click
        score = score + 1
        lblBall3.Text = "Score: " & score

        If score = 10 Then
            tmrMoveBall3.Enabled = False
            tmrMoveBall1.Enabled = False
            MsgBox("WINNER")
        End If

    End Sub

    Private Sub tmrMoveBall3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMoveBall3.Tick
        lblBall3.Left = CInt(Rnd() * Form1.ActiveForm.Width)
        lblBall3.Top = CInt(Rnd() * Form1.ActiveForm.Height)
    End Sub
