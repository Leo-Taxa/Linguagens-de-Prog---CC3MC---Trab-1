Public Class Cachorro
    Inherits Animal

    Public Overrides Sub FazerBarulho()
        Console.WriteLine($"{Nome} faz Au au")
    End Sub
End Class
