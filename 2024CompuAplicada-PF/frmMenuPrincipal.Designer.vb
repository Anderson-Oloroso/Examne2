<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenuPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AAdministradorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncargadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msusario = New System.Windows.Forms.ToolStripContainer()
        Me.MenuStrip1.SuspendLayout()
        Me.msusario.TopToolStripPanel.SuspendLayout()
        Me.msusario.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SpringGreen
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(282, 38)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AAdministradorToolStripMenuItem, Me.EncargadoToolStripMenuItem, Me.OperadorToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Font = New System.Drawing.Font("Algerian", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(165, 34)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios:"
        '
        'AAdministradorToolStripMenuItem
        '
        Me.AAdministradorToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.AAdministradorToolStripMenuItem.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AAdministradorToolStripMenuItem.Name = "AAdministradorToolStripMenuItem"
        Me.AAdministradorToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.AAdministradorToolStripMenuItem.Text = "Administrador"
        '
        'EncargadoToolStripMenuItem
        '
        Me.EncargadoToolStripMenuItem.BackColor = System.Drawing.Color.DodgerBlue
        Me.EncargadoToolStripMenuItem.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EncargadoToolStripMenuItem.Name = "EncargadoToolStripMenuItem"
        Me.EncargadoToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.EncargadoToolStripMenuItem.Text = "Encargado"
        '
        'OperadorToolStripMenuItem
        '
        Me.OperadorToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.OperadorToolStripMenuItem.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OperadorToolStripMenuItem.Name = "OperadorToolStripMenuItem"
        Me.OperadorToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.OperadorToolStripMenuItem.Text = "Operador"
        '
        'msusario
        '
        '
        'msusario.BottomToolStripPanel
        '
        Me.msusario.BottomToolStripPanel.BackColor = System.Drawing.Color.SteelBlue
        '
        'msusario.ContentPanel
        '
        Me.msusario.ContentPanel.BackColor = System.Drawing.Color.LightBlue
        Me.msusario.ContentPanel.Size = New System.Drawing.Size(282, 187)
        Me.msusario.Location = New System.Drawing.Point(50, 34)
        Me.msusario.Margin = New System.Windows.Forms.Padding(5)
        Me.msusario.Name = "msusario"
        Me.msusario.Size = New System.Drawing.Size(282, 225)
        Me.msusario.TabIndex = 2
        Me.msusario.Text = "ToolStripContainer1"
        '
        'msusario.TopToolStripPanel
        '
        Me.msusario.TopToolStripPanel.Controls.Add(Me.MenuStrip1)
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 299)
        Me.Controls.Add(Me.msusario)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMenuPrincipal"
        Me.Text = "Menú"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.msusario.TopToolStripPanel.ResumeLayout(False)
        Me.msusario.TopToolStripPanel.PerformLayout()
        Me.msusario.ResumeLayout(False)
        Me.msusario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents msusario As ToolStripContainer
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AAdministradorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncargadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OperadorToolStripMenuItem As ToolStripMenuItem
End Class
