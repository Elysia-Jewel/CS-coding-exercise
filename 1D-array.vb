' determining the largeest number from a list of values
' data not given(user input)

Imports System

Module Program
    Sub Main(args As String())
        Dim num(0 To 9) As Integer
        Dim largestNum As Integer
        largestNum = 0
        For x = 0 To 9
            Console.Write("Enter number: ")
            num(x) = Console.ReadLine
            If num(x) > largestNum Then
                largestNum = num(x)
            End If
        Next
        Console.WriteLine("Largest value is " & largestNum)
    End Sub
End Module
