Public Class Animal
    Public Nome As String
    Public Cor As String
    Public Peso As Double

    Public Sub Comer()
        Console.WriteLine(Nome + " Come")
    End Sub
    Public Overridable Sub FazerBarulho()
        Console.WriteLine("Animal faz barulho")
    End Sub
End Class
