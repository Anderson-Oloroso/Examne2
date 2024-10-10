<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmregion
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
        Me.btnelim = New System.Windows.Forms.Button()
        Me.btnmodi = New System.Windows.Forms.Button()
        Me.btnagre = New System.Windows.Forms.Button()
        Me.btnbus = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnomreg = New System.Windows.Forms.TextBox()
        Me.txtcodreg = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnelim
        '
        Me.btnelim.Location = New System.Drawing.Point(322, 174)
        Me.btnelim.Name = "btnelim"
        Me.btnelim.Size = New System.Drawing.Size(75, 23)
        Me.btnelim.TabIndex = 15
        Me.btnelim.Text = "Eliminar"
        Me.btnelim.UseVisualStyleBackColor = True
        '
        'btnmodi
        '
        Me.btnmodi.Location = New System.Drawing.Point(241, 174)
        Me.btnmodi.Name = "btnmodi"
        Me.btnmodi.Size = New System.Drawing.Size(75, 23)
        Me.btnmodi.TabIndex = 14
        Me.btnmodi.Text = "Modificar"
        Me.btnmodi.UseVisualStyleBackColor = True
        '
        'btnagre
        '
        Me.btnagre.Location = New System.Drawing.Point(151, 174)
        Me.btnagre.Name = "btnagre"
        Me.btnagre.Size = New System.Drawing.Size(75, 23)
        Me.btnagre.TabIndex = 13
        Me.btnagre.Text = "Agregar"
        Me.btnagre.UseVisualStyleBackColor = True
        '
        'btnbus
        '
        Me.btnbus.Location = New System.Drawing.Point(58, 174)
        Me.btnbus.Name = "btnbus"
        Me.btnbus.Size = New System.Drawing.Size(75, 23)
        Me.btnbus.TabIndex = 12
        Me.btnbus.Text = "Buscar"
        Me.btnbus.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nombre de Region"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(118, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Codigo Región"
        '
        'txtnomreg
        '
        Me.txtnomreg.Location = New System.Drawing.Point(241, 94)
        Me.txtnomreg.Name = "txtnomreg"
        Me.txtnomreg.Size = New System.Drawing.Size(100, 20)
        Me.txtnomreg.TabIndex = 9
        '
        'txtcodreg
        '
        Me.txtcodreg.Location = New System.Drawing.Point(241, 55)
        Me.txtcodreg.Name = "txtcodreg"
        Me.txtcodreg.Size = New System.Drawing.Size(100, 20)
        Me.txtcodreg.TabIndex = 8
        '
        'frmregion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 253)
        Me.Controls.Add(Me.btnelim)
        Me.Controls.Add(Me.btnmodi)
        Me.Controls.Add(Me.btnagre)
        Me.Controls.Add(Me.btnbus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnomreg)
        Me.Controls.Add(Me.txtcodreg)
        Me.Name = "frmregion"
        Me.Text = "Region"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnelim As Button
    Friend WithEvents btnmodi As Button
    Friend WithEvents btnagre As Button
    Friend WithEvents btnbus As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnomreg As TextBox
    Friend WithEvents txtcodreg As TextBox
End Class
