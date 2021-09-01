Imports System

Module Program
    Sub Main(args As String())
        Dim username As String
        Dim password As String
        Dim login As Boolean
        login = False
        While False
            Console.Write("Please enter your login name: ")
            username = Console.ReadLine
            For x = 0 To 99
                If username = LoginName(x) Then
                    Console.WriteLine("Please enter your password: ")
                    password = Console.ReadLine
                    If password = LoginPass(x) Then
                        Console.WriteLine("Your login was successful.")
                        login = True
                    Else
                        Console.WriteLine("Wrong password")
                    End If
                Else
                    Console.WriteLine("Login name not found")
                End If
            Next
        End While
    End Sub
End Module
