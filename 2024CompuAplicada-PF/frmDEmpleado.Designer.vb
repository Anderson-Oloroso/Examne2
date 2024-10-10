<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDEmpleado
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
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.dgvcCTCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcDescrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcTel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcContrase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcTCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcCod_Cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(1153, 70)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 7
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(1153, 99)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 8
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(1153, 262)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 9
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(1153, 41)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 10
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(1153, 12)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 11
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.AllowUserToAddRows = False
        Me.dgvEmpleados.AllowUserToDeleteRows = False
        Me.dgvEmpleados.AllowUserToOrderColumns = True
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvcCTCuenta, Me.dgvcNombre, Me.dgvcDescrip, Me.dgvcTel, Me.dgvcContrase, Me.dgvcTCuenta, Me.dgvcCod_Cuenta})
        Me.dgvEmpleados.Location = New System.Drawing.Point(12, 12)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.ReadOnly = True
        Me.dgvEmpleados.Size = New System.Drawing.Size(1135, 300)
        Me.dgvEmpleados.TabIndex = 6
        '
        'dgvcCTCuenta
        '
        Me.dgvcCTCuenta.HeaderText = "Cod. Empleado"
        Me.dgvcCTCuenta.Name = "dgvcCTCuenta"
        Me.dgvcCTCuenta.ReadOnly = True
        Me.dgvcCTCuenta.Width = 90
        '
        'dgvcNombre
        '
        Me.dgvcNombre.HeaderText = "Nombre"
        Me.dgvcNombre.Name = "dgvcNombre"
        Me.dgvcNombre.ReadOnly = True
        Me.dgvcNombre.Width = 200
        '
        'dgvcDescrip
        '
        Me.dgvcDescrip.HeaderText = "Apellido"
        Me.dgvcDescrip.Name = "dgvcDescrip"
        Me.dgvcDescrip.ReadOnly = True
        Me.dgvcDescrip.Width = 250
        '
        'dgvcTel
        '
        Me.dgvcTel.HeaderText = "Teléfono"
        Me.dgvcTel.Name = "dgvcTel"
        Me.dgvcTel.ReadOnly = True
        Me.dgvcTel.Width = 150
        '
        'dgvcContrase
        '
        Me.dgvcContrase.HeaderText = "Contraseña"
        Me.dgvcContrase.Name = "dgvcContrase"
        Me.dgvcContrase.ReadOnly = True
        Me.dgvcContrase.Width = 150
        '
        'dgvcTCuenta
        '
        Me.dgvcTCuenta.HeaderText = "Tipo Cuenta"
        Me.dgvcTCuenta.Name = "dgvcTCuenta"
        Me.dgvcTCuenta.ReadOnly = True
        Me.dgvcTCuenta.Width = 150
        '
        'dgvcCod_Cuenta
        '
        Me.dgvcCod_Cuenta.HeaderText = "Cod_Cuenta"
        Me.dgvcCod_Cuenta.Name = "dgvcCod_Cuenta"
        Me.dgvcCod_Cuenta.ReadOnly = True
        Me.dgvcCod_Cuenta.Width = 80
        '
        'frmDEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1240, 332)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvEmpleados)
        Me.Name = "frmDEmpleado"
        Me.Text = "frmEmpleado"
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents dgvEmpleados As DataGridView
    Friend WithEvents dgvcCTCuenta As DataGridViewTextBoxColumn
    Friend WithEvents dgvcNombre As DataGridViewTextBoxColumn
    Friend WithEvents dgvcDescrip As DataGridViewTextBoxColumn
    Friend WithEvents dgvcTel As DataGridViewTextBoxColumn
    Friend WithEvents dgvcContrase As DataGridViewTextBoxColumn
    Friend WithEvents dgvcTCuenta As DataGridViewTextBoxColumn
    Friend WithEvents dgvcCod_Cuenta As DataGridViewTextBoxColumn
End Class
