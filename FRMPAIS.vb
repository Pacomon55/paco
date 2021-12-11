Public Class FRMPAIS
    Dim PAIS As String
    Dim ESTADO As String

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Items.Clear()
        PAIS = ComboBox1.SelectedItem
        If PAIS = "Venezuela" Then
            ComboBox2.Items.Add("Lara")
            ComboBox2.Items.Add("Zulia")
            ComboBox2.Items.Add("Miranda")
        ElseIf PAIS = "Colombia" Then
            ComboBox2.Items.Add("Antioquia")
            ComboBox2.Items.Add("Boyaca")
            ComboBox2.Items.Add("Bolivar")
        ElseIf PAIS = "Chile" Then
            ComboBox2.Items.Add("Valparaiso")
            ComboBox2.Items.Add("Los Rios")
            ComboBox2.Items.Add("Metropolitana")
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox3.Items.Clear()
        ESTADO = ComboBox2.Text
        Select Case PAIS
            Case "Venezuela"
                Select Case ESTADO
                    Case "Lara"
                        ComboBox3.Items.Add("Carora")
                        ComboBox3.Items.Add("Barquisimeto")
                        ComboBox3.Items.Add("Quibor")
                    Case "Zulia"
                        ComboBox3.Items.Add("Maracaibo")
                        ComboBox3.Items.Add("San Francisco")
                        ComboBox3.Items.Add("Cabimas")
                    Case "Miranda"
                        ComboBox3.Items.Add("Ocumare del Tuy")
                        ComboBox3.Items.Add("Guarenas")
                        ComboBox3.Items.Add("Charallave")
                End Select
            Case "Colombia"
                Select Case ESTADO
                    Case "Antioquia"
                        ComboBox3.Items.Add("Medellin")
                        ComboBox3.Items.Add("Bello")
                        ComboBox3.Items.Add("Remedios")
                    Case "Boyaca"
                        ComboBox3.Items.Add("Tunja")
                        ComboBox3.Items.Add("Villa de Leyva")
                        ComboBox3.Items.Add("Paipa")
                    Case "Bolivar"
                        ComboBox3.Items.Add("Cartagena")
                        ComboBox3.Items.Add("Santa Rosa")
                        ComboBox3.Items.Add("Santa Catalina")
                End Select
            Case "Chile"
                Select Case ESTADO
                    Case "Valparaios"
                        ComboBox3.Items.Add("Valparaiso")
                        ComboBox3.Items.Add("San Antonio")
                        ComboBox3.Items.Add("Quillota")
                    Case "Los Rios"
                        ComboBox3.Items.Add("Valdivia")
                        ComboBox3.Items.Add("Ranco")
                    Case "Metropolitana"
                        ComboBox3.Items.Add("Santiago")
                        ComboBox3.Items.Add("Talagante")
                        ComboBox3.Items.Add("Maipo")
                End Select
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("La CIUDAD " + ComboBox3.Text + " Pertenece al ESTADO " + ComboBox2.Text + " Del PAIS " + ComboBox1.Text)
    End Sub
End Class
