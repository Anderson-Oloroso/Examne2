<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCiudadanos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnImpri = New System.Windows.Forms.Button()
        Me.btnAgre = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtNOMBRE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvTotal = New System.Windows.Forms.DataGridView()
        Me.dgvNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCOD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        CType(Me.dgvTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImpri
        '
        Me.btnImpri.Location = New System.Drawing.Point(51, 95)
        Me.btnImpri.Name = "btnImpri"
        Me.btnImpri.Size = New System.Drawing.Size(176, 81)
        Me.btnImpri.TabIndex = 47
        Me.btnImpri.Text = "IMPRIMIR"
        Me.btnImpri.UseVisualStyleBackColor = True
        '
        'btnAgre
        '
        Me.btnAgre.Location = New System.Drawing.Point(51, 182)
        Me.btnAgre.Name = "btnAgre"
        Me.btnAgre.Size = New System.Drawing.Size(176, 81)
        Me.btnAgre.TabIndex = 46
        Me.btnAgre.Text = "AGREGAR"
        Me.btnAgre.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(51, 269)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(176, 81)
        Me.btnSalir.TabIndex = 45
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(51, 356)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(176, 81)
        Me.btnEliminar.TabIndex = 44
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'txtNOMBRE
        '
        Me.txtNOMBRE.Location = New System.Drawing.Point(712, 156)
        Me.txtNOMBRE.Name = "txtNOMBRE"
        Me.txtNOMBRE.Size = New System.Drawing.Size(183, 20)
        Me.txtNOMBRE.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(453, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "INGRESE EL NOMBRE :"
        '
        'dgvTotal
        '
        Me.dgvTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTotal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvNombre, Me.dgvApellido, Me.dgvCOD})
        Me.dgvTotal.Location = New System.Drawing.Point(261, 290)
        Me.dgvTotal.Name = "dgvTotal"
        Me.dgvTotal.Size = New System.Drawing.Size(801, 261)
        Me.dgvTotal.TabIndex = 36
        '
        'dgvNombre
        '
        Me.dgvNombre.HeaderText = "NOMBRE"
        Me.dgvNombre.Name = "dgvNombre"
        Me.dgvNombre.Width = 200
        '
        'dgvApellido
        '
        Me.dgvApellido.HeaderText = "APELLIDO"
        Me.dgvApellido.Name = "dgvApellido"
        Me.dgvApellido.Width = 200
        '
        'dgvCOD
        '
        Me.dgvCOD.HeaderText = "COD_LUGAR_NACIMIENTO"
        Me.dgvCOD.Name = "dgvCOD"
        Me.dgvCOD.Width = 300
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(51, 469)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(176, 71)
        Me.btnLimpiar.TabIndex = 48
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(453, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "INGRESE El APELLIDO:"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(712, 202)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(183, 20)
        Me.txtApellido.TabIndex = 50
        '
        'frmCiudadanos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1146, 590)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnImpri)
        Me.Controls.Add(Me.btnAgre)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.txtNOMBRE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvTotal)
        Me.Name = "frmCiudadanos"
        Me.Text = "CIUDADANOS"
        CType(Me.dgvTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnImpri As Button
    Friend WithEvents btnAgre As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents txtNOMBRE As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvTotal As DataGridView
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents dgvNombre As DataGridViewTextBoxColumn
    Friend WithEvents dgvApellido As DataGridViewTextBoxColumn
    Friend WithEvents dgvCOD As DataGridViewTextBoxColumn
End Class
