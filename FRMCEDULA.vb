Public Class FRMCEDULA

    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click

        Dim cedula, confirmacion, accion As Long

        cedula = Val(txtCedula.Text)

        confirmacion = Val(txtConfirmacion.Text)

        accion = Val(lbtxtcorrect.Text)


        If (confirmacion = cedula) Then

            lbtxtcorrect.Text = "Correcto"

        ElseIf (confirmacion <> cedula) Then

            lbtxtcorrect.Text = "Incorecta"


        End If




    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

        txtCedula.Text = String.Empty
        txtConfirmacion.Text = String.Empty
        lbtxtcorrect.Text = String.Empty


    End Sub

    Private Sub txtAccion_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FRMCEDULA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class