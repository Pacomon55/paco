<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMCARACTERCOMBOBOX
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPalabra = New System.Windows.Forms.TextBox()
        Me.cbxpalguardadas = New System.Windows.Forms.ComboBox()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese una palabra"
        '
        'TxtPalabra
        '
        Me.TxtPalabra.Location = New System.Drawing.Point(107, 44)
        Me.TxtPalabra.Name = "TxtPalabra"
        Me.TxtPalabra.Size = New System.Drawing.Size(141, 20)
        Me.TxtPalabra.TabIndex = 1
        '
        'cbxpalguardadas
        '
        Me.cbxpalguardadas.FormattingEnabled = True
        Me.cbxpalguardadas.Location = New System.Drawing.Point(107, 99)
        Me.cbxpalguardadas.Name = "cbxpalguardadas"
        Me.cbxpalguardadas.Size = New System.Drawing.Size(141, 21)
        Me.cbxpalguardadas.TabIndex = 2
        '
        'Guardar
        '
        Me.Guardar.Location = New System.Drawing.Point(12, 99)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(75, 23)
        Me.Guardar.TabIndex = 3
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'FRMCARACTERCOMBOBOX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 168)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.cbxpalguardadas)
        Me.Controls.Add(Me.TxtPalabra)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FRMCARACTERCOMBOBOX"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ejercicio 1.7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtPalabra As System.Windows.Forms.TextBox
    Friend WithEvents cbxpalguardadas As System.Windows.Forms.ComboBox
    Friend WithEvents Guardar As System.Windows.Forms.Button
End Class
