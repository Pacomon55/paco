Public Class FRMTRIANGULO

    Private Sub lbAltura_Click(sender As Object, e As EventArgs) Handles lbAltura.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbResult.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtResult.TextChanged

    End Sub

    Private Sub lbBase_Click(sender As Object, e As EventArgs) Handles lbBase.Click

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim num1, num2, result As Double
        num1 = txtBase.Text
        num2 = txtAltura.Text
        result = (num1 * num2) / 2
        txtResult.Text = result

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        txtBase.Text = String.Empty
        txtAltura.Text = String.Empty
        txtResult.Text = String.Empty

    End Sub
End Class
