Public Class FRMIVA

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        labIva.Text = "El precio actual es: " & (Val(txtCantidad.Text) * 0.12)



    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click

        txtCantidad.Text = String.Empty
        labIva.Text = String.Empty

    End Sub
End Class