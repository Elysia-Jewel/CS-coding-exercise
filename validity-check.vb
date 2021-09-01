' Conditions:
' - between 6 and 9 characters long
' - uppercase characters for Character 1 to 3
' - numeric characters for Character 4 to 5
' - uppercase characters for remaining characters

' Results:
' - output TRUE if valid, FALSE if otherwise

Imports System

Module Program
    Function ValidateRegistration(ByVal Registration As String) As Boolean
        Dim x, length As Integer
        Dim validate As Boolean
        validate = True
        length = Len(Registration)
        If length <= 9 And length >= 6 Then
            For x = 0 To 2
                If Registration(x) < "A" Or Registration(x) > "Z" Then
                    validate = False
                End If
            Next
            For x = 3 To 4
                If Registration(x) < "0" Or Registration(x) > "9" Then
                    validate = False
                End If
            Next
            For x = 5 To (length - 1)
                If Registration(x) < "A" Or Registration(x) > "Z" Then
                    validate = False
                End If
            Next
        Else
            validate = False
        End If
        Return validate
    End Function
    Sub Main(args As String())
        Dim LicensePlate As String
        Dim validity As Boolean
        Dim Reset As Integer
        Reset = 1
        While Reset = 1
            Console.Write("Please enter your car license plate: ")
            LicensePlate = Console.ReadLine()
            validity = ValidateRegistration(LicensePlate)
            If validity = True Then
                Console.WriteLine("The format is correct.")
            Else
                Console.WriteLine("Wrong format.")
            End If
            Console.WriteLine("Do you wish to continue? 1-Yes 2-No")
            Reset = Console.ReadLine()
        End While

    End Sub
End Module
