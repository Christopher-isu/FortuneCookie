'ChristopherZ
'Spring 2025
'RCET2265
'Fortune Cookie
'https://github.com/Christopher-isu/FortuneCookie.git

Option Explicit On 'forces all variables to be declared
Option Strict On 'forces all data types to match

Module FortuneCookie


    Sub Main()
        Dim fruits As New List(Of String) From {
        "Schematics, Understand You Must: Like a map, a schematic is. Guidance through the circuit, it gives. Read and comprehend, thoroughly you must.",
        "Ohm's Law Never Lies: Trust it, you must. Like the gravity of electrical engineering, always there, it is.",
        "Kirchhoff's Current Law: Flow, the current does. In and out, balanced it must be. Like the force, harmony it seeks.",
        "Kirchhoff's Voltage Law: Around the loop, the voltage travels. Zero, the sum must be. Balance in the force, it signifies.",
        "Impedance Matching, Balance It Brings: Power transfer maximum it ensures. Efficiency in circuits, enhance it does."
    }   'list of wisdoms

        ' Display a random quote
        Dim index As Integer = RandomNumberBetween(0, fruits.Count - 1) 'generate a random number between 0 and the number of wisdoms in the list
        Console.WriteLine(fruits(index)) '  display the quote that corresponds to the random number generated
    End Sub

    Function RandomNumberBetween(min As Integer, max As Integer) As Integer 'function to generate a random number
        Randomize() 'initialize random number generator
        Static rnd As New Random() 'create a new random number 
        Return rnd.Next(min, max + 1)   'return a random number between the min and max values
    End Function
End Module
