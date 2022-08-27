Imports System

Module Program
    Sub Main(args As String())

        Dim reprobados As Integer
        Dim aprobados As Integer
        Dim notables As Integer
        Dim sobresaliente As Integer

        Console.WriteLine("Entre el nùmero de reprobados ")
        reprobados = Console.ReadLine()

        Console.WriteLine("Entre el nùmero de aprobados ")
        aprobados = Console.ReadLine()

        Console.WriteLine("Entre el nùmero de notables ")
        notables = Console.ReadLine()

        Console.WriteLine("Entre el nùmero de sobresaliente ")
        sobresaliente = Console.ReadLine()

        superados(reprobados, aprobados, notables, sobresaliente)

    End Sub

    Sub superados(ByVal reprobados As Integer, ByVal aprobados As Integer, ByVal notables As Integer, ByVal sobresaliente As Integer)
        Dim superados As Integer
        Dim grantotal As Integer
        Dim totalaprobaron As Integer

        grantotal = reprobados + aprobados + notables + sobresaliente
        totalaprobaron = aprobados + notables + sobresaliente

        superados = (totalaprobaron / grantotal) * 100

        Console.WriteLine("Porcentaje de AProbados = ")
        Console.WriteLine(superados)


    End Sub

End Module
