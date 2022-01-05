Public Class Form1

    Sub PlayLoopingBackgroundSoundFile()

        My.Computer.Audio.Play("BasketBallMania_background", AudioPlayMode.BackgroundLoop)

    End Sub



    Private Sub Rules_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rules_btn.Click

        Dim rules As New Form2

        rules.Show()

    End Sub



    Private Sub Volume_btn_Click(sender As Object, e As EventArgs) Handles Volume_btn.Click

        Dim volume As New Form3

        volume.Show()



    End Sub



    Private Sub Exit_button_Click(sender As Object, e As EventArgs) Handles Exit_btn.Click

        Me.Close()

    End Sub



    Private Sub Start_button_Click(sender As Object, e As EventArgs) Handles Start_btn.Click

        Dim start As New Form4

        start.Show()

    End Sub



End Class