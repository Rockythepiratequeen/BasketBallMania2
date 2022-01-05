Public Class Form3



    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        TrackBar1.Minimum = 0



        TrackBar1.Maximum = 100



        If TrackBar1.Value < TrackBar1.Maximum Then



            TrackBar1.Value += 1



        Else



            TrackBar1.Value = TrackBar1.Minimum



        End If



    End Sub



    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll



        Dim vol As UInteger = CUInt((UShort.MaxValue / 100) * TrackBar1.Value)



        Label1.Text = TrackBar1.Value.ToString



    End Sub



    Private Sub Exit_volume_btn_Click(sender As Object, e As EventArgs) Handles Exit_volume_btn.Click



        Me.Close()



    End Sub



End Class