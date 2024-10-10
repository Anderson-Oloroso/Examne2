<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdepto
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
        Me.btnelim = New System.Windows.Forms.Button()
        Me.btnmodi = New System.Windows.Forms.Button()
        Me.btnagre = New System.Windows.Forms.Button()
        Me.btnbus = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnomdept = New System.Windows.Forms.TextBox()
        Me.txtcoddept = New System.Windows.Forms.TextBox()
        Me.cboregion = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Region"
        '
        'btnelim
        '
        Me.btnelim.Location = New System.Drawing.Point(309, 182)
        Me.btnelim.Name = "btnelim"
        Me.btnelim.Size = New System.Drawing.Size(75, 23)
        Me.btnelim.TabIndex = 25
        Me.btnelim.Text = "Eliminar"
        Me.btnelim.UseVisualStyleBackColor = True
        '
        'btnmodi
        '
        Me.btnmodi.Location = New System.Drawing.Point(228, 182)
        Me.btnmodi.Name = "btnmodi"
        Me.btnmodi.Size = New System.Drawing.Size(75, 23)
        Me.btnmodi.TabIndex = 24
        Me.btnmodi.Text = "Modificar"
        Me.btnmodi.UseVisualStyleBackColor = True
        '
        'btnagre
        '
        Me.btnagre.Location = New System.Drawing.Point(138, 182)
        Me.btnagre.Name = "btnagre"
        Me.btnagre.Size = New System.Drawing.Size(75, 23)
        Me.btnagre.TabIndex = 23
        Me.btnagre.Text = "Agregar"
        Me.btnagre.UseVisualStyleBackColor = True
        '
        'btnbus
        '
        Me.btnbus.Location = New System.Drawing.Point(47, 182)
        Me.btnbus.Name = "btnbus"
        Me.btnbus.Size = New System.Drawing.Size(75, 23)
        Me.btnbus.TabIndex = 22
        Me.btnbus.Text = "Buscar"
        Me.btnbus.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Departamento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Codigo Depto"
        '
        'txtnomdept
        '
        Me.txtnomdept.Location = New System.Drawing.Point(233, 75)
        Me.txtnomdept.Name = "txtnomdept"
        Me.txtnomdept.Size = New System.Drawing.Size(100, 20)
        Me.txtnomdept.TabIndex = 19
        '
        'txtcoddept
        '
        Me.txtcoddept.Location = New System.Drawing.Point(233, 36)
        Me.txtcoddept.Name = "txtcoddept"
        Me.txtcoddept.Size = New System.Drawing.Size(100, 20)
        Me.txtcoddept.TabIndex = 18
        '
        'cboregion
        '
        Me.cboregion.FormattingEnabled = True
        Me.cboregion.Location = New System.Drawing.Point(212, 116)
        Me.cboregion.Name = "cboregion"
        Me.cboregion.Size = New System.Drawing.Size(121, 21)
        Me.cboregion.TabIndex = 28
        '
        'frmdepto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 240)
        Me.Controls.Add(Me.cboregion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnelim)
        Me.Controls.Add(Me.btnmodi)
        Me.Controls.Add(Me.btnagre)
        Me.Controls.Add(Me.btnbus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnomdept)
        Me.Controls.Add(Me.txtcoddept)
        Me.Name = "frmdepto"
        Me.Text = "Departamento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents btnelim As Button
    Friend WithEvents btnmodi As Button
    Friend WithEvents btnagre As Button
    Friend WithEvents btnbus As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnomdept As TextBox
    Friend WithEvents txtcoddept As TextBox
    Friend WithEvents cboregion As ComboBox
End Class
