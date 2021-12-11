Public Class frmIMC

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReinicio.Click
        txtAltura.Text = ""
        txtPeso.Text = ""
        txtResultado.Text = ""
        lbMensaje.Text = ""
    End Sub

    Private Sub lbAltura_Click(sender As Object, e As EventArgs) Handles lbAltura.Click

    End Sub

    Private Sub frmIMC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        Dim num1, num2 As Decimal
        Dim resul As Double
        num1 = txtPeso.Text
        num2 = txtAltura.Text

        resul = (num1) / (num2) ^ 2
        txtResultado.Text = resul

        If resul < 18.49 Then
            lbMensaje.Text = "Su IMC es Infrapeso"
        ElseIf resul >= 18.5 And resul <= 24.99 Then
            lbMensaje.Text = "Su IMC es Peso Normal"
        ElseIf resul >= 25.0 And resul <= 29.99 Then
            lbMensaje.Text = "Su IMC es Sobrepeso"
        Else
            lbMensaje.Text = "Su IMC es Obeso"
        End If

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class
