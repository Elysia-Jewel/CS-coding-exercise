Imports System

Module Program
    Sub Main(args As String())
        Dim list(9) As Integer
        Dim largest As Integer
        Dim temp As Integer
        For x = 0 To 9
            Console.Write("Enter a number: ")
            list(x) = Console.ReadLine()
        Next
        Console.Write("The numbers entered are: ")
        For x = 0 To 8
            Console.Write(list(x) & ", ")
        Next
        Console.WriteLine(list(9))
        For x = 0 To 9
            For y = 0 To (8 - x)
                If list(y) > list(y + 1) Then
                    temp = list(y + 1)
                    list(y + 1) = list(y)
                    list(y) = temp
                End If
            Next y
        Next x
        largest = list(9)
        Console.WriteLine("The largest number among them is: " & largest)
        For x = 0 To 9
            Console.WriteLine(list(x))
        Next
    End Sub
End Module
