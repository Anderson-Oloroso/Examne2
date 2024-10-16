﻿Imports System.Windows.Forms

Public Class mdiAdministrador

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripButton.Click
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        frmDEmpleado.MdiParent = Me
        frmDEmpleado.Show()
        frmDTCuenta.Close()
        frmAgrEmpl.MdiParent = Me
        frmAct2.MdiParent = Me
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Dim bot As Integer
        bot = MsgBox("¿Estás seguro que quieres cerrar sesión?", vbYesNo + vbQuestion, "Cerrar sesión")
        If bot = 6 Then
            Me.Close()
            frmMenuPrincipal.Show()
        End If
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Dim bot As Integer
        bot = MsgBox("¿Estás seguro que quieres salir definitivamente?", vbYesNo + vbQuestion, "Salir")
        If bot = 6 Then
            Me.Close()
        End If
    End Sub

    Private Sub TipoCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoCuentaToolStripMenuItem.Click
        frmDTCuenta.MdiParent = Me
        frmDTCuenta.Show()
        frmDEmpleado.MdiParent = Me
        frmDEmpleado.Show()
        frmActualizar.MdiParent = Me
        frmAgregarC.MdiParent = Me
    End Sub

    Private Sub SalirToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem2.Click
        Dim bot As Integer
        bot = MsgBox("¿Estás seguro que quieres salir definitivamente?", vbYesNo + vbQuestion, "Salir")
        If bot = 6 Then
            Me.Close()
        End If
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Dim bot As Integer
        bot = MsgBox("¿Estás seguro que quieres cerrar sesión?", vbYesNo + vbQuestion, "Cerrar sesión")
        If bot = 6 Then
            Me.Close()
            frmMenuPrincipal.Show()
        End If
    End Sub

    Private Sub mdiAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
