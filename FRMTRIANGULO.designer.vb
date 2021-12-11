<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMTRIANGULO
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
        Me.titleDatos = New System.Windows.Forms.Label()
        Me.lbBase = New System.Windows.Forms.Label()
        Me.lbAltura = New System.Windows.Forms.Label()
        Me.txtBase = New System.Windows.Forms.TextBox()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.lbResult = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnReiniciar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Location = New System.Drawing.Point(11, 32)
        Me.title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(330, 16)
        Me.title.TabIndex = 0
        Me.title.Text = "Programa para calcular el área de un triángulo"
        '
        'titleDatos
        '
        Me.titleDatos.AutoSize = True
        Me.titleDatos.Location = New System.Drawing.Point(104, 75)
        Me.titleDatos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.titleDatos.Name = "titleDatos"
        Me.titleDatos.Size = New System.Drawing.Size(131, 16)
        Me.titleDatos.TabIndex = 1
        Me.titleDatos.Text = "Ingese los datos :"
        '
        'lbBase
        '
        Me.lbBase.AutoSize = True
        Me.lbBase.Location = New System.Drawing.Point(101, 124)
        Me.lbBase.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbBase.Name = "lbBase"
        Me.lbBase.Size = New System.Drawing.Size(60, 16)
        Me.lbBase.TabIndex = 2
        Me.lbBase.Text = "BASE : "
        '
        'lbAltura
        '
        Me.lbAltura.AutoSize = True
        Me.lbAltura.Location = New System.Drawing.Point(85, 154)
        Me.lbAltura.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbAltura.Name = "lbAltura"
        Me.lbAltura.Size = New System.Drawing.Size(76, 16)
        Me.lbAltura.TabIndex = 3
        Me.lbAltura.Text = "ALTURA :"
        '
        'txtBase
        '
        Me.txtBase.Location = New System.Drawing.Point(168, 118)
        Me.txtBase.Name = "txtBase"
        Me.txtBase.Size = New System.Drawing.Size(89, 22)
        Me.txtBase.TabIndex = 4
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(168, 151)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(89, 22)
        Me.txtAltura.TabIndex = 5
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(168, 189)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(89, 22)
        Me.txtResult.TabIndex = 6
        '
        'lbResult
        '
        Me.lbResult.AutoSize = True
        Me.lbResult.Location = New System.Drawing.Point(53, 192)
        Me.lbResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbResult.Name = "lbResult"
        Me.lbResult.Size = New System.Drawing.Size(108, 16)
        Me.lbResult.TabIndex = 7
        Me.lbResult.Text = "RESULTADO :"
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(76, 244)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(85, 31)
        Me.btnCalcular.TabIndex = 8
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnReiniciar
        '
        Me.btnReiniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReiniciar.Location = New System.Drawing.Point(183, 244)
        Me.btnReiniciar.Name = "btnReiniciar"
        Me.btnReiniciar.Size = New System.Drawing.Size(85, 31)
        Me.btnReiniciar.TabIndex = 9
        Me.btnReiniciar.Text = "Reiniciar"
        Me.btnReiniciar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(130, 296)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(85, 31)
        Me.btnCerrar.TabIndex = 10
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'FRMTRIANGULO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(354, 354)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnReiniciar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.lbResult)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtAltura)
        Me.Controls.Add(Me.txtBase)
        Me.Controls.Add(Me.lbAltura)
        Me.Controls.Add(Me.lbBase)
        Me.Controls.Add(Me.titleDatos)
        Me.Controls.Add(Me.title)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMTRIANGULO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ejercicio 1.1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents title As System.Windows.Forms.Label
    Friend WithEvents titleDatos As System.Windows.Forms.Label
    Friend WithEvents lbBase As System.Windows.Forms.Label
    Friend WithEvents lbAltura As System.Windows.Forms.Label
    Friend WithEvents txtBase As System.Windows.Forms.TextBox
    Friend WithEvents txtAltura As System.Windows.Forms.TextBox
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents lbResult As System.Windows.Forms.Label
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents btnReiniciar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button

End Class
