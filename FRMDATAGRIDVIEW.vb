Public Class FRMDATAGRIDVIEW

    Dim lista, CantidadProducto, PrecioUnitario, PrecioTotal As String



    Public Sub CrearDGV()

        DataGridView1.ColumnCount = 5
        DataGridView1.Columns(0).HeaderText = "Lista"
        DataGridView1.Columns(1).HeaderText = "Cantidad de Producto"
        DataGridView1.Columns(2).HeaderText = "Pecio unitario"
        DataGridView1.Columns(3).HeaderText = "Pecio total"




    End Sub




    Private Sub frmEjercicio19_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub

    Private Sub txtAgregar_Click(sender As Object, e As EventArgs) Handles txtAgregar.Click

        lista = TextBox1.Text
        CantidadProducto = Val(TextBox2.Text)
        PrecioUnitario = Val(TextBox3.Text)
        PrecioTotal = Val(TextBox4.Text)

        DataGridView1.Rows.Add(lista, CantidadProducto, PrecioUnitario, PrecioTotal)
        TextBox1.Focus()
        TextBox1.Clear()
        TextBox2.Focus()
        TextBox2.Clear()
        TextBox3.Focus()
        TextBox3.Clear()
        TextBox4.Focus()
        TextBox4.Clear()





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        CrearDGV()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Label8.Text = DataGridView1.CurrentRow.Index
        TextBox1.Focus()
        btnActualizar.Enabled = True
        btnBorrar.Enabled = False


    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value = TextBox1.Text
        DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value = Val(TextBox2.Text)
        DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value = Val(TextBox3.Text)
        DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value = Val(TextBox4.Text)





    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

        DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)



    End Sub
End Class