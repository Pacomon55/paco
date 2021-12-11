<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMCONTVOCAL
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbtexto = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtpalabra = New System.Windows.Forms.TextBox()
        Me.lbVocales = New System.Windows.Forms.Label()
        Me.txtCarac = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtVocal = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbtexto
        '
        Me.lbtexto.AutoSize = True
        Me.lbtexto.Location = New System.Drawing.Point(41, 51)
        Me.lbtexto.Name = "lbtexto"
        Me.lbtexto.Size = New System.Drawing.Size(85, 13)
        Me.lbtexto.TabIndex = 0
        Me.lbtexto.Text = "Cadena de texto"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(44, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(499, 25)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Evaluar Caracteres"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtpalabra
        '
        Me.txtpalabra.Location = New System.Drawing.Point(44, 67)
        Me.txtpalabra.Name = "txtpalabra"
        Me.txtpalabra.Size = New System.Drawing.Size(499, 20)
        Me.txtpalabra.TabIndex = 2
        '
        'lbVocales
        '
        Me.lbVocales.AutoSize = True
        Me.lbVocales.Location = New System.Drawing.Point(41, 140)
        Me.lbVocales.Name = "lbVocales"
        Me.lbVocales.Size = New System.Drawing.Size(118, 13)
        Me.lbVocales.TabIndex = 3
        Me.lbVocales.Text = "Cantidad de Caracteres"
        '
        'txtCarac
        '
        Me.txtCarac.Location = New System.Drawing.Point(174, 137)
        Me.txtCarac.Name = "txtCarac"
        Me.txtCarac.ReadOnly = True
        Me.txtCarac.Size = New System.Drawing.Size(52, 20)
        Me.txtCarac.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(249, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cantidades de vocales"
        '
        'txtVocal
        '
        Me.txtVocal.Location = New System.Drawing.Point(370, 137)
        Me.txtVocal.Name = "txtVocal"
        Me.txtVocal.ReadOnly = True
        Me.txtVocal.Size = New System.Drawing.Size(52, 20)
        Me.txtVocal.TabIndex = 6
        '
        'FRMCONTVOCAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 211)
        Me.Controls.Add(Me.txtVocal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCarac)
        Me.Controls.Add(Me.lbVocales)
        Me.Controls.Add(Me.txtpalabra)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbtexto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMCONTVOCAL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ejercicio 1.9"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbtexto As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtpalabra As System.Windows.Forms.TextBox
    Friend WithEvents lbVocales As System.Windows.Forms.Label
    Friend WithEvents txtCarac As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtVocal As System.Windows.Forms.TextBox

End Class
