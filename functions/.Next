Imports System

Module Program
    Sub Main(args As String())
        Dim point, move, goal As Integer
        Dim random As New Random
        Do Until point >= 10
            move = random.Next(0, 2)
            If move = 0 Then
                point = point + 3
                goal = goal + 1
            Else
                point = point - 1
            End If
        Loop
        Console.WriteLine("Total points: " & point)
        Console.WriteLine("Number of goals: " & goal)
    End Sub
End Module
