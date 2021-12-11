Public Class menu

    Private Sub ARCHIVOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ARCHIVOToolStripMenuItem.Click

    End Sub

    Private Sub Ejercicio11ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio11ToolStripMenuItem.Click
        Dim edad As New FRMEDAD
        edad.Show()
    End Sub

    Private Sub Ejercicio15InicioDeSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio15InicioDeSesiónToolStripMenuItem.Click
        Dim sesion As New FRMINICIOSESION
        sesion.Show()
    End Sub

    Private Sub Ejercicio11ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio11ToolStripMenuItem1.Click
        Dim triangulo As New FRMTRIANGULO
        triangulo.Show()
    End Sub

    Private Sub Ejercicio12ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio12ToolStripMenuItem.Click
        Dim calImc As New frmIMC
        calImc.Show()
    End Sub

    Private Sub Ejercicio14ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio14ToolStripMenuItem.Click
        Dim menu As New FRMRESTAURANT
        menu.Show()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Ejercicio24LeerCadenaDeCaracteresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio24LeerCadenaDeCaracteresToolStripMenuItem.Click
        Dim caracter As New FRMLEERCARACTER2
        caracter.Show()
    End Sub

    Private Sub Ejercicio25CalcularIvaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio25CalcularIvaToolStripMenuItem.Click
        Dim iva As New FRMIVA
        iva.Show()
    End Sub

    Private Sub Ejercicio27ListaDataGridViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio27ListaDataGridViewToolStripMenuItem.Click
        Dim lista As New FRMDATAGRIDVIEW
        lista.Show()
    End Sub

    Private Sub Ejercicio16ListaDePaisesEnComboBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio16ListaDePaisesEnComboBoxToolStripMenuItem.Click
        Dim pais As New FRMPAIS
        pais.Show()
    End Sub

    Private Sub Ejercicio111MaquetaDeCalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio111MaquetaDeCalculadoraToolStripMenuItem.Click
        Dim cal As New FRMMAQUETA
        cal.Show()
    End Sub

    Private Sub Ejercicio112ConfirmarCedúlaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio112ConfirmarCedúlaToolStripMenuItem.Click
        Dim cedula As New FRMCEDULA
        cedula.Show()
    End Sub

    Private Sub Ejercicio21ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio21ToolStripMenuItem.Click
        Dim grado As New FRMGRADOS
        grado.Show()
    End Sub

    Private Sub Ejercicio22InvertirUnNúmeroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio22InvertirUnNúmeroToolStripMenuItem.Click
        Dim invertir As New FRMINVERTIR
        invertir.Show()
    End Sub

    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Ejercicio17ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio17ToolStripMenuItem.Click
        Dim comboCaracter As New FRMCARACTERCOMBOBOX
        comboCaracter.Show()
    End Sub

    Private Sub Ejercicio19ContarCarcateresYVocalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio19ContarCarcateresYVocalesToolStripMenuItem.Click
        Dim caracvocal As New FRMCONTVOCAL
        caracvocal.Show()
    End Sub
End Class
