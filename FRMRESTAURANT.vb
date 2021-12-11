Public Class FRMRESTAURANT


    Private Sub frmEjercicio3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.txtTiempo.Enabled = True


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles txtTiempo.Tick




    End Sub

    Private Sub btnBucarHora_Click(sender As Object, e As EventArgs) Handles btnBucarHora.Click

        Dim hora, accion, desayuno, almuerzo, postre, cena, bebidas As String

        hora = Val(txtHora.Text)
        Format(Now, "HH:mm:ss")

        accion = Val(txtAccion.Text)

        desayuno = Val(txtDesayuno.Text)

        almuerzo = Val(txtAlmuerzo.Text)

        postre = Val(txtMerienda.Text)

        cena = Val(txtCena.Text)

        bebidas = Val(txtBebidas.Text)

        If (hora <= 6 And hora <= 24) Then

            MsgBox("estamos cerrados, nuestros Horarios de atencion son de 7AM a 10PM", MsgBoxStyle.Critical)

        ElseIf (hora >= 7 And hora <= 10) Then

            txtDesayuno.Text = "Arepa" + vbCrLf + "Empanadas" + vbCrLf + "Confley"
            txtBebidas.Text = "Coca-Cola" + vbCrLf + "Pepsi-Cola" + vbCrLf + "Jugos naturales" + vbCrLf + "Cafe"
            txtDesayuno.BackColor = Color.AliceBlue

        ElseIf (hora >= 10 And hora <= 15) Then

            txtAlmuerzo.Text = "Pasta con carne y salsa nopolitana" + vbCrLf + "Pabellon" + vbCrLf + "Pasticho"
            txtBebidas.Text = "Coca-Cola" + vbCrLf + "Pepsi-Cola" + vbCrLf + "Jugos naturales"
            txtAlmuerzo.BackColor = Color.AliceBlue

        ElseIf (hora >= 15 And hora <= 18) Then

            txtMerienda.Text = "Donas" + vbCrLf + "Galletas" + vbCrLf + "Arroz con leche"
            txtBebidas.Text = "Cafe"
            txtMerienda.BackColor = Color.AliceBlue

        ElseIf (hora >= 17 And hora <= 22) Then

            txtCena.Text = "Pizza" + vbCrLf + "Pan de jamon" + vbCrLf + "hallaca"
            txtBebidas.Text = "Coca-Cola" + vbCrLf + "Pepsi-Cola"
            txtCena.BackColor = Color.AliceBlue

        End If



    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

        txtHora.Text = String.Empty
        txtDesayuno.Text = String.Empty
        txtBebidas.Text = String.Empty
        txtAlmuerzo.Text = String.Empty
        txtMerienda.Text = String.Empty
        txtCena.Text = String.Empty


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lbPlatos.Click

    End Sub

    Private Sub lbBebidas_Click(sender As Object, e As EventArgs) Handles lbBebidas.Click

    End Sub
End Class