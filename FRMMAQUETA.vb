Public Class FRMMAQUETA
    Private memoria1 As Double = 0.0
    Private memoria2 As Double = 0.0
    Private signo As String

    Private Sub Ejercio1Calculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btncero_Click(sender As Object, e As EventArgs) Handles btncero.Click
        txtpantalla.Text = txtpantalla.Text & "0"

    End Sub

    Private Sub btnuno_Click(sender As Object, e As EventArgs) Handles btnuno.Click
        txtpantalla.Text = txtpantalla.Text & "1"
    End Sub

    Private Sub btndos_Click(sender As Object, e As EventArgs) Handles btndos.Click
        txtpantalla.Text = txtpantalla.Text & "2"
    End Sub

    Private Sub btntres_Click(sender As Object, e As EventArgs) Handles btntres.Click
        txtpantalla.Text = txtpantalla.Text & "3"
    End Sub

    Private Sub btncuatro_Click(sender As Object, e As EventArgs) Handles btncuatro.Click
        txtpantalla.Text = txtpantalla.Text & "4"
    End Sub

    Private Sub btncinco_Click(sender As Object, e As EventArgs) Handles btncinco.Click
        txtpantalla.Text = txtpantalla.Text & "5"
    End Sub

    Private Sub btnseis_Click(sender As Object, e As EventArgs) Handles btnseis.Click
        txtpantalla.Text = txtpantalla.Text & "6"
    End Sub

    Private Sub btnsiete_Click(sender As Object, e As EventArgs) Handles btnsiete.Click
        txtpantalla.Text = txtpantalla.Text & "7"
    End Sub

    Private Sub btnocho_Click(sender As Object, e As EventArgs) Handles btnocho.Click
        txtpantalla.Text = txtpantalla.Text & "8"
    End Sub

    Private Sub btnnueve_Click(sender As Object, e As EventArgs) Handles btnnueve.Click
        txtpantalla.Text = txtpantalla.Text & "9"
    End Sub

    Private Sub btnmas_Click(sender As Object, e As EventArgs) Handles btnmas.Click
        Try
            If txtpantalla.Text <> "" Then
                memoria1 = Val(txtpantalla.Text)
                signo = "+"
                txtpantalla.Clear()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnmenos_Click(sender As Object, e As EventArgs) Handles btnmenos.Click
        Try
            If txtpantalla.Text <> "" Then
                memoria1 = Val(txtpantalla.Text)
                signo = "-"
                txtpantalla.Clear()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnmultiplicacion_Click(sender As Object, e As EventArgs) Handles btnmultiplicacion.Click
        Try
            If txtpantalla.Text <> "" Then
                memoria1 = Val(txtpantalla.Text)
                signo = "*"
                txtpantalla.Clear()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btndivision_Click(sender As Object, e As EventArgs) Handles btndivision.Click
        Try
            If txtpantalla.Text <> "" Then
                memoria1 = Val(txtpantalla.Text)
                signo = "/"
                txtpantalla.Clear()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnraiz_Click(sender As Object, e As EventArgs) Handles btnraiz.Click
        Try
            If txtpantalla.Text <> "" Then
                memoria1 = Val(txtpantalla.Text)
                signo = "raiz"
                txtpantalla.Clear()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnpotencia_Click(sender As Object, e As EventArgs) Handles btnpotencia.Click
        Try
            If txtpantalla.Text <> "" Then
                memoria1 = Val(txtpantalla.Text)
                signo = "exponente"
                txtpantalla.Clear()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnporcentaje_Click(sender As Object, e As EventArgs) Handles btnporcentaje.Click
        Try
            If txtpantalla.Text <> "" Then
                memoria1 = Val(txtpantalla.Text)
                signo = "%"
                txtpantalla.Clear()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnborrartodo_Click(sender As Object, e As EventArgs) Handles btnborrartodo.Click
        txtpantalla.Clear()
        memoria1 = 0.0
        memoria2 = 0.0
        signo = String.Empty
    End Sub

    Private Sub btnborrarderecha_Click(sender As Object, e As EventArgs) Handles btnborrarderecha.Click
        Try
            Dim largo As Integer
            If txtpantalla.Text <> "" Then
                largo = txtpantalla.Text.Length
                txtpantalla.Text = Mid(txtpantalla.Text, 1, largo - 1)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnmasmenos_Click(sender As Object, e As EventArgs) Handles btnmasmenos.Click
        Try
            If txtpantalla.Text <> "" Then
                txtpantalla.Text = txtpantalla.Text * (-1)
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btninversa_Click(sender As Object, e As EventArgs) Handles btninversa.Click
        Try
            If txtpantalla.Text <> "" Then
                txtpantalla.Text = 1 / (txtpantalla.Text)
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnpunto_Click(sender As Object, e As EventArgs) Handles btnpunto.Click
        If txtpantalla.Text = "" Then
            txtpantalla.Text = "0."
        ElseIf existepunto(txtpantalla.Text) = False Then
            txtpantalla.Text = txtpantalla.Text & "."


        End If
    End Sub


    Private Function existepunto(ByVal cadena As String) As Boolean
        Dim largo As Integer
        Dim respuesta As Boolean = False

        largo = cadena.Length

        For i As Integer = 1 To largo Step 1
            If Mid(cadena, i, 1) = "." Then
                respuesta = True
            End If
        Next
        Return respuesta

    End Function

    Private Sub btnigual_Click(sender As Object, e As EventArgs) Handles btnigual.Click
        Try
            If txtpantalla.Text <> "" And memoria1 <> 0.0 Then
                memoria2 = txtpantalla.Text
                calculadora()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub calculadora()
        Select Case signo
            Case "+"
                txtpantalla.Text = memoria1 + memoria2
            Case "-"
                txtpantalla.Text = memoria1 - memoria2
            Case "*"
                txtpantalla.Text = memoria1 * memoria2
            Case "/"
                txtpantalla.Text = memoria1 / memoria2
            Case "raiz"
                txtpantalla.Text = memoria1 ^ (1 / memoria2) 'alt 94
            Case "exponente"
                txtpantalla.Text = memoria1 ^ memoria2
            Case "%"
                txtpantalla.Text = memoria1 * memoria2 / 100
            Case Else
                MsgBox("Error")





        End Select
    End Sub
End Class