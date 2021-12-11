Public Class FRMINVERTIR

    Dim numero, decena, reserva, inverso As Integer

    Private Sub btninvertir_Click(sender As Object, e As EventArgs) Handles btninvertir.Click

        numero = Val(txtnumero.Text.Trim)
        reserva = numero Mod 10
        decena = numero / 10

        inverso = 10 * reserva + decena

        txtinversion.Text = inverso

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtnumero.Text = ""
        txtnumero.Focus()
        txtinversion.Text = ""
        txtinversion.Focus()

    End Sub
End Class