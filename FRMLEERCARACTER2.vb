Public Class FRMLEERCARACTER2

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click

        Dim numero As String

        numero = Val(txtNumero.Text)

        If (numero < 9) Then

            labResultado.Text = "este numero es de 1 digito"
        End If
        If (numero >= 10) Then

            labResultado.Text = "este numero es de 2 digitos"

        End If

        If (numero >= 100) Then

            labResultado.Text = "este numero es de 3 digitos"
        End If

        If (numero >= 1000) Then

            labResultado.Text = "este numero es de 4 digitos"
        End If

        If (numero >= 10000) Then

            labResultado.Text = "este numero es de 5 digitos"
        End If

        If (numero >= 100000) Then

            labResultado.Text = "este numero es de 6 digitos"
        End If

        If (numero >= 1000000) Then

            labResultado.Text = "este numero es de 7 digitos"
        End If




    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click

        txtNumero.Text = String.Empty
        labResultado.Text = String.Empty


    End Sub

    Private Sub FRMLEERCARACTER2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class