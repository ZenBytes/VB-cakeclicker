Public Class Form2

    Public homemade_cakes As Integer

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        Form1.cakes += 1
        homemade_cakes += 1
        Label1.Text = "Home-made Cakes: " & homemade_cakes

    End Sub

End Class