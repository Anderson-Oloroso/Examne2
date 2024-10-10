<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMunicipio
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
        Me.txtNOMBRE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnImpri = New System.Windows.Forms.Button()
        Me.btnAGREGAR = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtCOD = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRegion = New System.Windows.Forms.TextBox()
        Me.dgvTotal = New System.Windows.Forms.DataGridView()
        Me.dgvNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSALEI = New System.Windows.Forms.Button()
        CType(Me.dgvTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNOMBRE
        '
        Me.txtNOMBRE.Location = New System.Drawing.Point(397, 198)
        Me.txtNOMBRE.Name = "txtNOMBRE"
        Me.txtNOMBRE.Size = New System.Drawing.Size(81, 20)
        Me.txtNOMBRE.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(151, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "INGRESE El NOMBRE DEL MUNICIPIO:"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(33, 587)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(94, 39)
        Me.btnLimpiar.TabIndex = 60
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnImpri
        '
        Me.btnImpri.Location = New System.Drawing.Point(33, 177)
        Me.btnImpri.Name = "btnImpri"
        Me.btnImpri.Size = New System.Drawing.Size(74, 81)
        Me.btnImpri.TabIndex = 59
        Me.btnImpri.Text = "IMPRIMIR"
        Me.btnImpri.UseVisualStyleBackColor = True
        '
        'btnAGREGAR
        '
        Me.btnAGREGAR.Location = New System.Drawing.Point(33, 283)
        Me.btnAGREGAR.Name = "btnAGREGAR"
        Me.btnAGREGAR.Size = New System.Drawing.Size(74, 81)
        Me.btnAGREGAR.TabIndex = 58
        Me.btnAGREGAR.Text = "AGREGAR"
        Me.btnAGREGAR.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(33, 500)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(74, 81)
        Me.btnEliminar.TabIndex = 56
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'txtCOD
        '
        Me.txtCOD.Location = New System.Drawing.Point(394, 266)
        Me.txtCOD.Name = "txtCOD"
        Me.txtCOD.Size = New System.Drawing.Size(81, 20)
        Me.txtCOD.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(151, 266)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "INGRESE El COD_MUNI:"
        '
        'txtRegion
        '
        Me.txtRegion.Location = New System.Drawing.Point(-325, -133)
        Me.txtRegion.Name = "txtRegion"
        Me.txtRegion.Size = New System.Drawing.Size(183, 20)
        Me.txtRegion.TabIndex = 53
        '
        'dgvTotal
        '
        Me.dgvTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTotal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvNombre, Me.dgvApellido})
        Me.dgvTotal.Location = New System.Drawing.Point(192, 320)
        Me.dgvTotal.Name = "dgvTotal"
        Me.dgvTotal.Size = New System.Drawing.Size(455, 261)
        Me.dgvTotal.TabIndex = 52
        '
        'dgvNombre
        '
        Me.dgvNombre.HeaderText = "COD_MUNI"
        Me.dgvNombre.Name = "dgvNombre"
        Me.dgvNombre.Width = 200
        '
        'dgvApellido
        '
        Me.dgvApellido.HeaderText = "NOMBRE"
        Me.dgvApellido.Name = "dgvApellido"
        Me.dgvApellido.Width = 200
        '
        'btnSALEI
        '
        Me.btnSALEI.Location = New System.Drawing.Point(33, 393)
        Me.btnSALEI.Name = "btnSALEI"
        Me.btnSALEI.Size = New System.Drawing.Size(74, 81)
        Me.btnSALEI.TabIndex = 57
        Me.btnSALEI.Text = "SALIR"
        Me.btnSALEI.UseVisualStyleBackColor = True
        '
        'frmMunicipio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 711)
        Me.Controls.Add(Me.txtNOMBRE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnImpri)
        Me.Controls.Add(Me.btnAGREGAR)
        Me.Controls.Add(Me.btnSALEI)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.txtCOD)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRegion)
        Me.Controls.Add(Me.dgvTotal)
        Me.Name = "frmMunicipio"
        Me.Text = "frmMunicipio"
        CType(Me.dgvTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNOMBRE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnImpri As Button
    Friend WithEvents btnAGREGAR As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents txtCOD As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRegion As TextBox
    Friend WithEvents dgvTotal As DataGridView
    Friend WithEvents dgvNombre As DataGridViewTextBoxColumn
    Friend WithEvents dgvApellido As DataGridViewTextBoxColumn
    Friend WithEvents btnSALEI As Button
End Class
