<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImpimuni
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
        Me.cbodepto = New System.Windows.Forms.ComboBox()
        Me.dgvimpri = New System.Windows.Forms.DataGridView()
        Me.dgvcodmuni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvnombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcoddepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnimpri = New System.Windows.Forms.Button()
        CType(Me.dgvimpri, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(189, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Departamento"
        '
        'cbodepto
        '
        Me.cbodepto.FormattingEnabled = True
        Me.cbodepto.Items.AddRange(New Object() {"Guatemala", "El Progreso", "Sacatepéquez", "Chimaltenango", "Escuintla", "Santa Rosa", "Sololá", "Totonicapán", "Quetzaltenango", "Suchitepéquez", "Retalhuleu", "San Marcos", "Huehuetenango", "Quiché", "Baja Verapaz", "Alta Verapaz", "Petén", "Izabal", "Zacapa", "Chiquimula", "Jalapa", "Jutiapa"})
        Me.cbodepto.Location = New System.Drawing.Point(316, 31)
        Me.cbodepto.Name = "cbodepto"
        Me.cbodepto.Size = New System.Drawing.Size(121, 21)
        Me.cbodepto.TabIndex = 4
        '
        'dgvimpri
        '
        Me.dgvimpri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvimpri.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvcodmuni, Me.dgvnombre, Me.dgvcoddepto})
        Me.dgvimpri.Location = New System.Drawing.Point(33, 68)
        Me.dgvimpri.Name = "dgvimpri"
        Me.dgvimpri.Size = New System.Drawing.Size(599, 264)
        Me.dgvimpri.TabIndex = 3
        '
        'dgvcodmuni
        '
        Me.dgvcodmuni.HeaderText = "Cod_Muni"
        Me.dgvcodmuni.Name = "dgvcodmuni"
        Me.dgvcodmuni.Width = 50
        '
        'dgvnombre
        '
        Me.dgvnombre.HeaderText = "Nombre"
        Me.dgvnombre.Name = "dgvnombre"
        Me.dgvnombre.Width = 300
        '
        'dgvcoddepto
        '
        Me.dgvcoddepto.HeaderText = "Departamento"
        Me.dgvcoddepto.Name = "dgvcoddepto"
        Me.dgvcoddepto.Width = 200
        '
        'btnimpri
        '
        Me.btnimpri.Location = New System.Drawing.Point(297, 346)
        Me.btnimpri.Name = "btnimpri"
        Me.btnimpri.Size = New System.Drawing.Size(75, 23)
        Me.btnimpri.TabIndex = 6
        Me.btnimpri.Text = "Imprimir"
        Me.btnimpri.UseVisualStyleBackColor = True
        '
        'frmImpimuni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 378)
        Me.Controls.Add(Me.btnimpri)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbodepto)
        Me.Controls.Add(Me.dgvimpri)
        Me.Name = "frmImpimuni"
        Me.Text = "frmImpimuni"
        CType(Me.dgvimpri, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbodepto As ComboBox
    Friend WithEvents dgvimpri As DataGridView
    Friend WithEvents dgvcodmuni As DataGridViewTextBoxColumn
    Friend WithEvents dgvnombre As DataGridViewTextBoxColumn
    Friend WithEvents dgvcoddepto As DataGridViewTextBoxColumn
    Friend WithEvents btnimpri As Button
End Class
