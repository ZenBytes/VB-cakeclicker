Public Class Form3

    Public timeplayedstring As String = String.Format("{0:0#}", Form1.timeplayed Mod 60)

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Label1.Text = "Grandmas: " & Form1.grandmas
        Label2.Text = "Cake Mines: " & Form1.cakemines
        Label3.Text = "Cake Factories: " & Form1.factories
        Label4.Text = "Cake Singularities: " & Form1.singularities
        Label5.Text = "Total Cakes per Minute: " & (30 * Form1.grandmas) + (120 * Form1.cakemines) + (480 * Form1.factories) + (1920 * Form1.singularities)
        Label6.Text = "Time Played: " & Form1.timeplayed \ 60 & ":" & timeplayedstring

    End Sub

End Class