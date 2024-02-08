Public Class Form1
    Dim cs As New CoinSlot

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.insertQuarter()
        Label1.Text = cs.total
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cs.insertNickles()
        Label1.Text = cs.total
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cs.insertDimes()
        Label1.Text = cs.total
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cs.insertDollars()
        Label1.Text = cs.total
    End Sub
End Class
