<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMuni
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdepto = New System.Windows.Forms.TextBox()
        Me.btnelim = New System.Windows.Forms.Button()
        Me.btnmodi = New System.Windows.Forms.Button()
        Me.btnagre = New System.Windows.Forms.Button()
        Me.btnbus = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnomuni = New System.Windows.Forms.TextBox()
        Me.txtcodmuni = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(112, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Departamento"
        '
        'txtdepto
        '
        Me.txtdepto.Location = New System.Drawing.Point(254, 125)
        Me.txtdepto.Name = "txtdepto"
        Me.txtdepto.Size = New System.Drawing.Size(100, 20)
        Me.txtdepto.TabIndex = 36
        '
        'btnelim
        '
        Me.btnelim.Location = New System.Drawing.Point(330, 191)
        Me.btnelim.Name = "btnelim"
        Me.btnelim.Size = New System.Drawing.Size(75, 23)
        Me.btnelim.TabIndex = 35
        Me.btnelim.Text = "Eliminar"
        Me.btnelim.UseVisualStyleBackColor = True
        '
        'btnmodi
        '
        Me.btnmodi.Location = New System.Drawing.Point(249, 191)
        Me.btnmodi.Name = "btnmodi"
        Me.btnmodi.Size = New System.Drawing.Size(75, 23)
        Me.btnmodi.TabIndex = 34
        Me.btnmodi.Text = "Modificar"
        Me.btnmodi.UseVisualStyleBackColor = True
        '
        'btnagre
        '
        Me.btnagre.Location = New System.Drawing.Point(159, 191)
        Me.btnagre.Name = "btnagre"
        Me.btnagre.Size = New System.Drawing.Size(75, 23)
        Me.btnagre.TabIndex = 33
        Me.btnagre.Text = "Agregar"
        Me.btnagre.UseVisualStyleBackColor = True
        '
        'btnbus
        '
        Me.btnbus.Location = New System.Drawing.Point(68, 191)
        Me.btnbus.Name = "btnbus"
        Me.btnbus.Size = New System.Drawing.Size(75, 23)
        Me.btnbus.TabIndex = 32
        Me.btnbus.Text = "Buscar"
        Me.btnbus.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(114, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Codigo Municipio"
        '
        'txtnomuni
        '
        Me.txtnomuni.Location = New System.Drawing.Point(254, 84)
        Me.txtnomuni.Name = "txtnomuni"
        Me.txtnomuni.Size = New System.Drawing.Size(100, 20)
        Me.txtnomuni.TabIndex = 29
        '
        'txtcodmuni
        '
        Me.txtcodmuni.Location = New System.Drawing.Point(254, 45)
        Me.txtcodmuni.Name = "txtcodmuni"
        Me.txtcodmuni.Size = New System.Drawing.Size(100, 20)
        Me.txtcodmuni.TabIndex = 28
        '
        'frmMuni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 259)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtdepto)
        Me.Controls.Add(Me.btnelim)
        Me.Controls.Add(Me.btnmodi)
        Me.Controls.Add(Me.btnagre)
        Me.Controls.Add(Me.btnbus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnomuni)
        Me.Controls.Add(Me.txtcodmuni)
        Me.Name = "frmMuni"
        Me.Text = "Municipio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents txtdepto As TextBox
    Friend WithEvents btnelim As Button
    Friend WithEvents btnmodi As Button
    Friend WithEvents btnagre As Button
    Friend WithEvents btnbus As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnomuni As TextBox
    Friend WithEvents txtcodmuni As TextBox
End Class
