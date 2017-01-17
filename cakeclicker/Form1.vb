Public Class Form1

    Public timeplayed As Integer

    Public cakes As Double = 20000
    Public spentcakes As Double

    Public grandmas As Integer
    Public grandmascost As Integer = 40
    Public cakemines As Integer
    Public cakeminescost As Integer = 200
    Public factories As Integer
    Public factoriescost As Integer = 1000
    Public singularities As Integer
    Public singularitiescost As Integer = 5000

    Function random_int(ByVal small As Integer, ByVal big As Integer) As Integer

        Return Int(Rnd() * (big - small + 1)) + small

    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Form2.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If Form2.Visible = False Then
            Form2.Show()
        Else
            Form2.Hide()
        End If


    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        cakes += 0.5 * grandmas
        cakes += 2 * cakemines
        cakes += 8 * factories
        cakes += 32 * singularities

        timeplayed += 1

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Label1.Text = "Cakes: " & cakes \ 1 - spentcakes 'integer divide allows for the timer to tick each second even though grandmas generate a decimal value each second (30/60 = 0.5)
        Label3.Text = "Total Cakes Baked: " & cakes \ 1

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If cakes - spentcakes >= grandmascost Then
            spentcakes += grandmascost
            grandmas += 1
            grandmascost += 5
            Button1.Text = "Buy: " & grandmascost & " cakes"
        Else
            Dialog1.Label1.Text = "You need " & grandmascost - cakes + spentcakes & " more cakes to buy this!"
            Dialog1.Show()
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If cakes - spentcakes >= cakeminescost Then
            spentcakes += cakeminescost
            cakemines += 1
            cakeminescost += 20
            Button2.Text = "Buy: " & cakeminescost & " cakes"
        Else
            Dialog1.Label1.Text = "You need " & cakeminescost - cakes + spentcakes & " more cakes to buy this!"
            Dialog1.Show()
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        If cakes - spentcakes >= factoriescost Then
            spentcakes += factoriescost
            factories += 1
            factoriescost += 80
            Button4.Text = "Buy: " & factoriescost & " cakes"
        Else
            Dialog1.Label1.Text = "You need " & factoriescost - cakes + spentcakes & " more cakes to buy this!"
            Dialog1.Show()
        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        If cakes - spentcakes >= singularitiescost Then
            spentcakes += singularitiescost
            singularities += 1
            singularitiescost += 320
            Button5.Text = "Buy: " & singularitiescost & " cakes"
        Else
            Dialog1.Label1.Text = "You need " & singularitiescost - cakes + spentcakes & " more cakes to buy this!"
            Dialog1.Show()
        End If

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Form3.Show()

    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick

        Form4.SetDesktopLocation(random_int(1, 600), random_int(1, 600))
        Form4.Show()

    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick

        Form4.Hide()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        Form5.Show()

    End Sub
End Class
