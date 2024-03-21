﻿Imports System.Net.Security

Public Class CoinSlotvb
    Public Event dispense(p As Image)
    Public Event CoinReturnEvent(d As Integer, q As Integer, dm As Integer, n As Integer)
    Public Property Quarters As Integer
    Public Property Nickles As Integer
    Public Property Dimes As Integer
    Public Property Dollars As Integer
    Dim _total As Decimal
    Public ReadOnly Property total As Decimal
        Get
            _total = Dollars + Quarters * 0.25 + Dimes * 0.1 + Nickles * 0.05
            Return _total
        End Get
    End Property
    Public Sub CoinReturn()
        RaiseEvent CoinReturnEvent(Dollars, Quarters, Dimes, Nickles)
        Dollars = 0
        Quarters = 0
        Dimes = 0
        Nickles = 0
    End Sub
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
    Public Sub spin()
        If total >= 1 Then
            _total = total - 1
            Dollars = 0
            Quarters = 0
            Dimes = 0
            Nickles = _total / 0.05
        End If
    End Sub
End Class