Imports System

Module Program
    Function basic(ByVal salary As Double) As Double
        salary = salary * 0.925
        Return salary
    End Function
    Function extra(ByVal ExtraSalary As Double, ByVal rate As Double) As Double
        ExtraSalary = ExtraSalary * rate
        If ExtraSalary > 1000 Then
            ExtraSalary = 1000
        End If
        Return ExtraSalary
    End Function
    Sub analysis(ByVal basic As Double, ByVal extra As Double)
        Dim net As Double
        net = basic + extra
        Console.WriteLine("Your basic salary is: " & basic)
        Console.WriteLine("Your net salary after provident fund deduction is: " & net)
    End Sub
    Sub Main(args As String())
        Dim BasicSalary As Double
        Dim ExtraHours As Integer
        Dim rate As Double
        Console.Write("Please provide the basic salary: ")
        BasicSalary = Console.ReadLine()
        Console.Write("Please provide the no. of extra working hour(s): ")
        ExtraHours = Console.ReadLine()
        Console.Write("Please provide the extra working hour rate: ")
        rate = Console.ReadLine()
        Call analysis(basic(BasicSalary), extra(ExtraHours, rate))
    End Sub
End Module
