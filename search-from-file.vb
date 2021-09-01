' reading data from file, then matching

Imports System

Module Program
    Sub Main(args As String())
        Dim LineOfText As String
        Dim input As String
        Dim NumberOfCars As Integer
        Dim CarInfo As System.IO.StreamReader
        CarInfo = New System.IO.StreamReader("C:\Users\Elysia Jewel\OneDrive\Desktop\BuyerCountry.txt")
        Console.Write("Enter a country code: ")
        input = Console.ReadLine()
        Console.WriteLine("List of car code(s) for this country: ")
        While Not CarInfo.EndOfStream()
            LineOfText = CarInfo.ReadLine()
            If Right(LineOfText, 3) = input Then
                NumberOfCars = NumberOfCars + 1
                Console.WriteLine(Left(LineOfText, 3))
            End If

        End While
        Console.WriteLine("The total number of cars for this country is " & NumberOfCars & ".")
        CarInfo.Close()
    End Sub
End Module
