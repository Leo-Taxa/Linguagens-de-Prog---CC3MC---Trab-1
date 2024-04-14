Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        'Fim do Pograma"
        Me.Close()
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        'Mostra uma caixa de mensagem para o usuario
        MessageBox.Show("Olá, " & txtnome.Text & ". Bem vindo ao Visual Basic.", "Mensagem ao Usuario")
    End Sub
End Class
