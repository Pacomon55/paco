Public Class FRMEDAD
    Dim hoy As String = Now.Date.ToString("dd/MM/yyyy")
    Dim fechaNac, fechaHoy, edad As Integer

    Private Sub title_Click(sender As Object, e As EventArgs) Handles lbFechaNac.Click

    End Sub

    Private Sub lbEdad_Click(sender As Object, e As EventArgs) Handles lbEdad.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtFechaNac.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        If Not IsDate(txtFechaNac.Text.Trim) Then
            MsgBox("Por Favor debe Ingresar Una Fecha valida", MsgBoxStyle.Critical, "Error al Calcular")
        Else
            If CDate(txtFechaNac.Text.Trim) > CDate(hoy) Then
                MsgBox("La fecha no puede ser mayor a la de hoy", MsgBoxStyle.Critical, "Error al calcular")
            Else
                fechaNac = CDate(txtFechaNac.Text.Trim).Date.Year
                fechaHoy = CDate(hoy).Date.Year
                edad = fechaHoy - fechaNac

                txtEdad.Text = (edad & " " & "Años")
            End If

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtFechaNac.Text = ""
        txtEdad.Text = ""
    End Sub
End Class
