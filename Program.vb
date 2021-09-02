Imports System

Module Program
    Sub Main(args As String())
        Dim answer As Integer
        Dim random As New Random
        Dim attempt As Integer
        Dim input As Integer
        answer = random.Next(1, 11)
        attempt = 0
        Console.WriteLine(answer)
        Console.WriteLine("Guess a number between 1 to 10.")
        Console.WriteLine("You have 3 chances.")
        While input <> answer
            input = Console.ReadLine()
            attempt = attempt + 1
            If input = answer Then
                Console.WriteLine("You have guesed the correct number.")
            Else
                If attempt = 3 Then
                    Console.WriteLine("You have used up all attempts.")
                    input = answer
                Else
                    Console.WriteLine("Try again. You have " & (3 - attempt) & " chances left.")

                End If

            End If

        End While

    End Sub
End Module
