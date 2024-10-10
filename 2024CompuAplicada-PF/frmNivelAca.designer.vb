<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNivelAca
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
        Me.txtdescri = New System.Windows.Forms.TextBox()
        Me.btnelim = New System.Windows.Forms.Button()
        Me.btnmodi = New System.Windows.Forms.Button()
        Me.btnagre = New System.Windows.Forms.Button()
        Me.btnbus = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnomnive = New System.Windows.Forms.TextBox()
        Me.txtcodnive = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(107, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Descripción"
        '
        'txtdescri
        '
        Me.txtdescri.Location = New System.Drawing.Point(249, 118)
        Me.txtdescri.Name = "txtdescri"
        Me.txtdescri.Size = New System.Drawing.Size(100, 20)
        Me.txtdescri.TabIndex = 36
        '
        'btnelim
        '
        Me.btnelim.Location = New System.Drawing.Point(325, 184)
        Me.btnelim.Name = "btnelim"
        Me.btnelim.Size = New System.Drawing.Size(75, 23)
        Me.btnelim.TabIndex = 35
        Me.btnelim.Text = "Eliminar"
        Me.btnelim.UseVisualStyleBackColor = True
        '
        'btnmodi
        '
        Me.btnmodi.Location = New System.Drawing.Point(244, 184)
        Me.btnmodi.Name = "btnmodi"
        Me.btnmodi.Size = New System.Drawing.Size(75, 23)
        Me.btnmodi.TabIndex = 34
        Me.btnmodi.Text = "Modificar"
        Me.btnmodi.UseVisualStyleBackColor = True
        '
        'btnagre
        '
        Me.btnagre.Location = New System.Drawing.Point(163, 184)
        Me.btnagre.Name = "btnagre"
        Me.btnagre.Size = New System.Drawing.Size(75, 23)
        Me.btnagre.TabIndex = 33
        Me.btnagre.Text = "Agregar"
        Me.btnagre.UseVisualStyleBackColor = True
        '
        'btnbus
        '
        Me.btnbus.Location = New System.Drawing.Point(63, 184)
        Me.btnbus.Name = "btnbus"
        Me.btnbus.Size = New System.Drawing.Size(75, 23)
        Me.btnbus.TabIndex = 32
        Me.btnbus.Text = "Buscar"
        Me.btnbus.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(107, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Cod_nivel_academico"
        '
        'txtnomnive
        '
        Me.txtnomnive.Location = New System.Drawing.Point(249, 77)
        Me.txtnomnive.Name = "txtnomnive"
        Me.txtnomnive.Size = New System.Drawing.Size(100, 20)
        Me.txtnomnive.TabIndex = 29
        '
        'txtcodnive
        '
        Me.txtcodnive.Location = New System.Drawing.Point(249, 38)
        Me.txtcodnive.Name = "txtcodnive"
        Me.txtcodnive.Size = New System.Drawing.Size(100, 20)
        Me.txtcodnive.TabIndex = 28
        '
        'frmNivelAca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 244)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtdescri)
        Me.Controls.Add(Me.btnelim)
        Me.Controls.Add(Me.btnmodi)
        Me.Controls.Add(Me.btnagre)
        Me.Controls.Add(Me.btnbus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnomnive)
        Me.Controls.Add(Me.txtcodnive)
        Me.Name = "frmNivelAca"
        Me.Text = "Nivel Academico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents txtdescri As TextBox
    Friend WithEvents btnelim As Button
    Friend WithEvents btnmodi As Button
    Friend WithEvents btnagre As Button
    Friend WithEvents btnbus As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnomnive As TextBox
    Friend WithEvents txtcodnive As TextBox
End Class
