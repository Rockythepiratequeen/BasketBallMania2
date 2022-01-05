Public Class Form2

    Private Sub HowToPlay_btn_Click(sender As Object, e As EventArgs) Handles HowToPlay_btn.Click

        TextBox1.Visible = True

        TextBox2.Visible = False

        TextBox3.Visible = False

    End Sub

    Private Sub Controls_btn_Click(sender As Object, e As EventArgs) Handles Controls_btn.Click

        TextBox1.Visible = False

        TextBox2.Visible = True

        TextBox3.Visible = False

    End Sub

    Private Sub HardwareRequired_btn_Click(sender As Object, e As EventArgs) Handles HardwareRequired_btn.Click

        TextBox1.Visible = False

        TextBox2.Visible = False

        TextBox3.Visible = True

    End Sub

    Private Sub Exit_rules_btn_Click(sender As Object, e As EventArgs) Handles Exit_rules_btn.Click

        Me.Close()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Visible = False

        TextBox2.Visible = False

        TextBox3.Visible = False

    End Sub

End Class