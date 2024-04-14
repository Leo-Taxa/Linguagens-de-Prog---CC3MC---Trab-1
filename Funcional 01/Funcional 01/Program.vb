Imports System

Module Program
    Sub Main(args As String())
        Dim numero = 3
        Dim numero2 = 5

        Console.WriteLine(DobrarNumero(numero))
        Console.WriteLine(DobrarNumero(numero2))

    End Sub
    Function DobrarNumero(ByVal variavel As Integer) As Integer
        Dim dobro = 2 * variavel
        Return dobro
    End Function
End Module
