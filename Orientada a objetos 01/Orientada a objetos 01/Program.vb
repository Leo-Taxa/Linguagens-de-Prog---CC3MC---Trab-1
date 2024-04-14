Imports System

Module Program
    Sub Main(args As String())
        Dim Bolinha As New Cachorro()
        Bolinha.Nome = "Bolinha"
        Bolinha.FazerBarulho()
        Bolinha.Comer()
        Dim Fred As New Gato()
        Fred.Nome = "Fred"
        Fred.FazerBarulho()

    End Sub
End Module
