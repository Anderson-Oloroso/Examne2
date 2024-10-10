<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<<<<<<< HEAD
Partial Class frmregion
=======
Partial Class frmRegion
>>>>>>> 9ccf9f4442cde4953843b76b0cda09115389871e
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
<<<<<<< HEAD
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
=======
        Me.txtCOD = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnImpri = New System.Windows.Forms.Button()
        Me.btnAGREGAR = New System.Windows.Forms.Button()
        Me.btnSALER = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtNOMBRE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvTotal = New System.Windows.Forms.DataGridView()
        Me.dgvNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCOD
        '
        Me.txtCOD.Location = New System.Drawing.Point(576, 118)
        Me.txtCOD.Name = "txtCOD"
        Me.txtCOD.Size = New System.Drawing.Size(81, 20)
        Me.txtCOD.TabIndex = 82
>>>>>>> 9ccf9f4442cde4953843b76b0cda09115389871e
        '
        'Label1
        '
        Me.Label1.AutoSize = True
<<<<<<< HEAD
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
=======
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(330, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 13)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "INGRESE EL COD_REGION:"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(212, 507)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(94, 39)
        Me.btnLimpiar.TabIndex = 80
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnImpri
        '
        Me.btnImpri.Location = New System.Drawing.Point(212, 97)
        Me.btnImpri.Name = "btnImpri"
        Me.btnImpri.Size = New System.Drawing.Size(74, 81)
        Me.btnImpri.TabIndex = 79
        Me.btnImpri.Text = "IMPRIMIR"
        Me.btnImpri.UseVisualStyleBackColor = True
        '
        'btnAGREGAR
        '
        Me.btnAGREGAR.Location = New System.Drawing.Point(212, 203)
        Me.btnAGREGAR.Name = "btnAGREGAR"
        Me.btnAGREGAR.Size = New System.Drawing.Size(74, 81)
        Me.btnAGREGAR.TabIndex = 78
        Me.btnAGREGAR.Text = "AGREGAR"
        Me.btnAGREGAR.UseVisualStyleBackColor = True
        '
        'btnSALER
        '
        Me.btnSALER.Location = New System.Drawing.Point(212, 313)
        Me.btnSALER.Name = "btnSALER"
        Me.btnSALER.Size = New System.Drawing.Size(74, 81)
        Me.btnSALER.TabIndex = 77
        Me.btnSALER.Text = "SALIR"
        Me.btnSALER.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(212, 420)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(74, 81)
        Me.btnEliminar.TabIndex = 76
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'txtNOMBRE
        '
        Me.txtNOMBRE.Location = New System.Drawing.Point(573, 186)
        Me.txtNOMBRE.Name = "txtNOMBRE"
        Me.txtNOMBRE.Size = New System.Drawing.Size(81, 20)
        Me.txtNOMBRE.TabIndex = 75
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(330, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 13)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "INGRESE El NOMBRE DENLA REGION:"
        '
        'dgvTotal
        '
        Me.dgvTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTotal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvNombre, Me.dgvApellido})
        Me.dgvTotal.Location = New System.Drawing.Point(371, 240)
        Me.dgvTotal.Name = "dgvTotal"
        Me.dgvTotal.Size = New System.Drawing.Size(455, 261)
        Me.dgvTotal.TabIndex = 73
        '
        'dgvNombre
        '
        Me.dgvNombre.HeaderText = "COD_REGION"
        Me.dgvNombre.Name = "dgvNombre"
        Me.dgvNombre.Width = 200
        '
        'dgvApellido
        '
        Me.dgvApellido.HeaderText = "NOMBRE"
        Me.dgvApellido.Name = "dgvApellido"
        Me.dgvApellido.Width = 200
        '
        'frmRegion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 642)
        Me.Controls.Add(Me.txtCOD)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnImpri)
        Me.Controls.Add(Me.btnAGREGAR)
        Me.Controls.Add(Me.btnSALER)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.txtNOMBRE)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvTotal)
        Me.Name = "frmRegion"
        Me.Text = "frmRegion"
        CType(Me.dgvTotal, System.ComponentModel.ISupportInitialize).EndInit()
>>>>>>> 9ccf9f4442cde4953843b76b0cda09115389871e
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

<<<<<<< HEAD
    Friend WithEvents btnelim As Button
    Friend WithEvents btnmodi As Button
    Friend WithEvents btnagre As Button
    Friend WithEvents btnbus As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnomreg As TextBox
    Friend WithEvents txtcodreg As TextBox
=======
    Friend WithEvents txtCOD As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnImpri As Button
    Friend WithEvents btnAGREGAR As Button
    Friend WithEvents btnSALER As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents txtNOMBRE As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvTotal As DataGridView
    Friend WithEvents dgvNombre As DataGridViewTextBoxColumn
    Friend WithEvents dgvApellido As DataGridViewTextBoxColumn
>>>>>>> 9ccf9f4442cde4953843b76b0cda09115389871e
End Class
