Public Class Form4

    Dim score As Integer = 0

    Dim gametimer As Integer = 60

    Dim gamestop As Boolean = False

    Dim highscore As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick



        Basketball.Location = New Point(Basketball.Location.X + 0, Basketball.Location.Y - 10)

        If Basketball.Bounds.IntersectsWith(TopBar.Bounds) Then

            Timer1.Stop()

            Timer2.Start()

        End If

    End Sub

    Private Sub Form4_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.Space

                Timer1.Start()

            Case Keys.Left

                Basketball.Left -= 50

                Basketball.Top += 0

            Case Keys.Right

                Basketball.Left += 50

                Basketball.Top += 0

        End Select

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Score1.Text = score

        Basketball.BringToFront()

        BasketBallanet.BringToFront()

        Timer3.Start()

        Basketball.Location = New Point(500, Basketball.Location.X)

        Basketball.Location = New Point(630, Basketball.Location.Y)

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        For i = 0 To 59

            tmrlabel.Text = (60 - i)

        Next i

        Score1.Text = score

        If Basketball.Bounds.IntersectsWith(BasketBallanet.Bounds) Then

            score += 1

        Else

            score += 0

        End If

        If gametimer = 0 Then

            gametimer += 0

            tmrlabel.Text = "Game Over"

            gamestop = True

        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Basketball.Location = New Point(Basketball.Location.X + 0, Basketball.Location.Y + 10)

        If Basketball.Bounds.IntersectsWith(BottomBar.Bounds) Then

            Timer2.Stop()

        End If

    End Sub

End Class