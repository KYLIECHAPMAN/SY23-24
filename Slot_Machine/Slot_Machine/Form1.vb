Public Class Form1
    Dim CS As New CoinSlotvb
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReelControl1.spin()
        ReelControl2.spin()
        ReelControl3.spin()
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        If ReelControl1.itemvalue = ReelControl2.itemvalue And ReelControl2.itemvalue = ReelControl3.itemvalue Then
            Me.BackColor = Color.Red
        Else
            Me.BackColor = Color.White
        End If
        Label1.Text = ReelControl1.itemvalue
        Label2.Text = ReelControl2.itemvalue
        Label3.Text = ReelControl3.itemvalue
    End Sub

    Private Sub Dollars_Click(sender As Object, e As EventArgs) Handles Dollars.Click
        CS.insertDollars()
        TotalLabel.text = CS.total.ToString("c2")
    End Sub
    Private Sub Quarters_Click(sender As Object, e As EventArgs) Handles Quarters.Click
        CS.insertQuarter()
        TotalLabel.Text = CS.total.ToString("c2")
    End Sub

    Private Sub Dimes_Click(sender As Object, e As EventArgs) Handles Dimes.Click
        CS.insertDimes()
        TotalLabel.Text = CS.total.ToString("c2")
    End Sub

    Private Sub Nickles_Click(sender As Object, e As EventArgs) Handles Nickles.Click
        CS.insertNickles()
        TotalLabel.Text = CS.total.ToString("c2")
    End Sub
End Class