'ChristopherZ
'Spring 2025
'RCET2265
'Fortune Cookie
'

Option Explicit On 'forces all variables to be declared
Option Strict On 'forces all data types to match

Module FortuneCookie

    Sub Main()
    Function RandomNumberBetween(min As Integer, max As Integer) As Integer
        Randomize()
        Static rnd As New Random()
        Return rnd.Next(min, max + 1)
    End Function

    End Sub

End Module
