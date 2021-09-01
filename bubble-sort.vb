Imports System

Module Program
    Sub Main(args As String())
        Dim num(0 To 4) As Integer
        Dim temp As Integer
        For x = 0 To 4
            Console.Write("Enter integer: ")
            num(x) = Console.ReadLine
        Next
        For y = 0 To 5
            For x = 0 To (3 - y)
                If num(x) < num(x + 1) Then
                    temp = num(x)
                    num(x) = num(x + 1)
                    num(x + 1) = temp
                End If
            Next x
        Next y
        Console.WriteLine("After sort: ")
        For x = 0 To 4
            Console.Write(num(x) & " ")
        Next
    End Sub
End Module
