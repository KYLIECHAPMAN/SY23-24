Public Class CoinSlot
    Public Property Quarters As Integer
    Public Property Nickles As Integer
    Public Property Dimes As Integer
    Public Property Dollars As Integer
    Public ReadOnly Property total As Decimal
        Get
            Return Dollars + Quarters * 0.25 + Dimes * 0.1 + Nickles * 0.05
        End Get
    End Property
    Public Sub insertQuarter()
        Quarters = Quarters + 1
    End Sub
    Public Sub insertNickles()
        Nickles = Nickles + 1
    End Sub
    Public Sub insertDimes()
        Dimes = Dimes + 1
    End Sub
    Public Sub insertDollars()
        Dollars = Dollars + 1
    End Sub
End Class
