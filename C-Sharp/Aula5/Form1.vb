Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        'Mostra uma caixa de mensagem para o usuário'
        MessageBox.Show("Olá," & txtNome.Text & " Bem vindo ao VB 2019.", "Mensagem ao Usuário")
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        'Fim do programa'
        Me.Close()
    End Sub
End Class
