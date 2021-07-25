Public Class Form1
    Private Sub btnAdiciona_Click(sender As Object, e As EventArgs) Handles btnAdiciona.Click
        Dim intNumero As Integer
        intNumero = 27
        intNumero = intNumero + 1
        MessageBox.Show("Valor de IntNumero + 1 = " & intNumero.ToString, "Variáveis")
    End Sub
End Class
