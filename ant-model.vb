Imports System

Module Program
    Sub Main(args As String())
        Dim height, fall, move As Integer
        Dim random As New Random
        height = 0
        fall = 0
        Do Until height >= 5
            move = random.Next(0, 2)
            Select Case move
                Case "0"
                    If height < 4 Then
                        height = height + 2
                        Console.WriteLine("The ant climbed up 2 steps.")
                    Else
                        Console.WriteLine("The ant climbed up 1 steps.")
                    End If

                Case Else
                    If height > 0 Then
                        height = height - 1
                        fall = fall + 1
                        Console.WriteLine("The ant fell by 1 step.")
                    Else
                        Console.WriteLine("The ant cannot fall any further.")
                    End If
            End Select
        Loop
        Console.WriteLine("The ant has reached the top.")
        Console.WriteLine("The ant took " & fall & " fall(s).")
    End Sub
End Module
