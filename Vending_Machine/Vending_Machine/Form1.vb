Public Class Form1
    Dim WithEvents CS As New CoinSlot

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CS.insertQuarter()
        TotalLabel.Text = CS.total.ToString("C2")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CS.insertDollars()
        TotalLabel.Text = CS.total.ToString("C2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CS.insertNickles()
        TotalLabel.Text = CS.total.ToString("C2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CS.insertDimes()
        TotalLabel.Text = CS.total.ToString("C2")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CS.CoinReturn()
        TotalLabel.Text = CS.total.ToString("C2")
    End Sub

    Private Sub CS_CoinReturnEvent(D As Integer, Q As Integer, DM As Integer, N As Integer) Handles CS.CoinReturnEvent
        If D > 0 Then
            Dollars.Visible = True
        Else
            Dollars.Visible = False
        End If
        If Q > 0 Then
            Quarters.Visible = True
        Else
            Quarters.Visible = False
        End If
        If N > 0 Then
            Nickles.Visible = True
        Else
            Nickles.Visible = False
        End If
        If DM > 0 Then
            Dimes.Visible = True
        Else
            Dimes.Visible = False
        End If
    End Sub

    Private Sub CS_Dispense(P As Image) Handles CS.dispense
        ProductPictureBox.Image = P
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BuyButton.Click
        Select Case Button6.Text
            Case ProductControl11.ProductID
                CS.buy(ProductControl11)
            Case ProductControl17.ProductID
                CS.buy(ProductControl17)
            Case ProductControl16.ProductID
                CS.buy(ProductControl16)
            Case ProductControl15.ProductID
                CS.buy(ProductControl15)
            Case ProductControl14.ProductID
                CS.buy(ProductControl14)
            Case ProductControl13.ProductID
                CS.buy(ProductControl13)
            Case ProductControl11.ProductID
                CS.buy(ProductControl11)
            Case ProductControl111.ProductID
                CS.buy(ProductControl111)
            Case ProductControl110.ProductID
                CS.buy(ProductControl110)
            Case ProductControl18.ProductID
                CS.buy(ProductControl18)
            Case ProductControl19.ProductID
                CS.buy(ProductControl19)
            Case ProductControl113.ProductID
                CS.buy(ProductControl113)
            Case ProductControl112.ProductID
                CS.buy(ProductControl112)
            Case ProductControl115.ProductID
                CS.buy(ProductControl115)
            Case ProductControl114.ProductID
                CS.buy(ProductControl114)

        End Select
                TotalLabel.Text = CS.total.ToString("C2")
    End Sub
End Class