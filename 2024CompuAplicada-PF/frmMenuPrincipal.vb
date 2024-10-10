Public Class frmMenuPrincipal
    Private Sub frmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AAdministradorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AAdministradorToolStripMenuItem.Click
        mdiAdministrador.Show()
    End Sub

    Private Sub EncargadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncargadoToolStripMenuItem.Click
        mdiEncargado.Show()
    End Sub

    Private Sub OperadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperadorToolStripMenuItem.Click
        mdiOperador.Show()
    End Sub
End Class
