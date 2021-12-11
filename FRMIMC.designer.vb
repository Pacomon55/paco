<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIMC
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
        Me.title = New System.Windows.Forms.Label()
        Me.title2 = New System.Windows.Forms.Label()
        Me.lbAltura = New System.Windows.Forms.Label()
        Me.lbPeso = New System.Windows.Forms.Label()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.btnReinicio = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbMensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(32, 31)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(218, 16)
        Me.title.TabIndex = 0
        Me.title.Text = "Programa para calcular el IMC"
        '
        'title2
        '
        Me.title2.AutoSize = True
        Me.title2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title2.Location = New System.Drawing.Point(66, 74)
        Me.title2.Name = "title2"
        Me.title2.Size = New System.Drawing.Size(136, 16)
        Me.title2.TabIndex = 1
        Me.title2.Text = "Ingrese los datos :"
        '
        'lbAltura
        '
        Me.lbAltura.AutoSize = True
        Me.lbAltura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAltura.Location = New System.Drawing.Point(57, 151)
        Me.lbAltura.Name = "lbAltura"
        Me.lbAltura.Size = New System.Drawing.Size(76, 16)
        Me.lbAltura.TabIndex = 2
        Me.lbAltura.Text = "ALTURA :"
        '
        'lbPeso
        '
        Me.lbPeso.AutoSize = True
        Me.lbPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPeso.Location = New System.Drawing.Point(76, 119)
        Me.lbPeso.Name = "lbPeso"
        Me.lbPeso.Size = New System.Drawing.Size(57, 16)
        Me.lbPeso.TabIndex = 3
        Me.lbPeso.Text = "PESO :"
        '
        'btnCal
        '
        Me.btnCal.Location = New System.Drawing.Point(35, 243)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(79, 28)
        Me.btnCal.TabIndex = 4
        Me.btnCal.Text = "Calcular"
        Me.btnCal.UseVisualStyleBackColor = True
        '
        'btnReinicio
        '
        Me.btnReinicio.Location = New System.Drawing.Point(150, 243)
        Me.btnReinicio.Name = "btnReinicio"
        Me.btnReinicio.Size = New System.Drawing.Size(79, 28)
        Me.btnReinicio.TabIndex = 5
        Me.btnReinicio.Text = "Reiniciar"
        Me.btnReinicio.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(98, 301)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(79, 28)
        Me.btnCerrar.TabIndex = 6
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(141, 118)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(73, 20)
        Me.txtPeso.TabIndex = 7
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(141, 147)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(73, 20)
        Me.txtAltura.TabIndex = 8
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(141, 181)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.ReadOnly = True
        Me.txtResultado.Size = New System.Drawing.Size(73, 20)
        Me.txtResultado.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "RESULTADO :"
        '
        'lbMensaje
        '
        Me.lbMensaje.AutoSize = True
        Me.lbMensaje.Location = New System.Drawing.Point(85, 214)
        Me.lbMensaje.Name = "lbMensaje"
        Me.lbMensaje.Size = New System.Drawing.Size(0, 13)
        Me.lbMensaje.TabIndex = 11
        '
        'frmIMC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(284, 341)
        Me.Controls.Add(Me.lbMensaje)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.txtAltura)
        Me.Controls.Add(Me.txtPeso)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnReinicio)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.lbPeso)
        Me.Controls.Add(Me.lbAltura)
        Me.Controls.Add(Me.title2)
        Me.Controls.Add(Me.title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmIMC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ejercicio 1.2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents title As System.Windows.Forms.Label
    Friend WithEvents title2 As System.Windows.Forms.Label
    Friend WithEvents lbAltura As System.Windows.Forms.Label
    Friend WithEvents lbPeso As System.Windows.Forms.Label
    Friend WithEvents btnCal As System.Windows.Forms.Button
    Friend WithEvents btnReinicio As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
    Friend WithEvents txtAltura As System.Windows.Forms.TextBox
    Friend WithEvents txtResultado As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbMensaje As System.Windows.Forms.Label

End Class
