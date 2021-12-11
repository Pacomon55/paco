Public Class FRMCONTVOCAL
    Dim encontrada As String
    Dim contador As Integer
    Dim contar As Integer

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtCarac.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtVocal.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        encontrada = txtpalabra.Text

        contador = Len(encontrada)

        txtCarac.Text = contador

        For i = 1 To contador

            If Mid(encontrada, i, 1) = "a" Or Mid(encontrada, i, 1) = "A" Then

                contar = contar + 1

            End If
            If Mid(encontrada, i, 1) = "e" Or Mid(encontrada, i, 1) = "E" Then

                contar = contar + 1

            End If
            If Mid(encontrada, i, 1) = "i" Or Mid(encontrada, i, 1) = "I" Then

                contar = contar + 1

            End If
            If Mid(encontrada, i, 1) = "o" Or Mid(encontrada, i, 1) = "O" Then

                contar = contar + 1

            End If
            If Mid(encontrada, i, 1) = "u" Or Mid(encontrada, i, 1) = "U" Then

                contar = contar + 1

            End If

            txtVocal.Text = contar

        Next


    End Sub

    Private Sub boxMayus_CheckedChanged(sender As Object, e As EventArgs)


    End Sub
End Class
