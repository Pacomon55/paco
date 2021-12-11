Public Class FRMINICIOSESION

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Dim user As String
        user = txtUser.Text

        MsgBox("Bienvenido" & " " & user, MsgBoxStyle.Information, "Bienvenido")
    End Sub
End Class
