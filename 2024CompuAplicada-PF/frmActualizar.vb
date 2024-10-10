Public Class frmActualizar
    Dim sql, descrip, nombreC, aClave, nClave As String

    Private Sub frmActualizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub limpiar()
        txtNombreC.Clear()
        txtDescripcion.Clear()
    End Sub

    Private Sub modificar()
        conect()
        If txtDescripcion.Text <> "" And txtNombreC.Text <> "" And txtNclave.Text <> "" And txtAclave.Text <> "" Then
            nombreC = txtNombreC.Text
            descrip = txtDescripcion.Text
            nClave = txtNclave.Text
            aClave = txtAclave.Text
        Else
            MsgBox("Es obligatorio rellenar todos los campos con el tipo correcto de datos", vbOKOnly + vbExclamation, "Modificar datos")
            limpiar()
        End If
        sql = "UPDATE TIPOCUENTA  SET cod_tipocuenta=" & nClave & ",nombre='" & nombreC & "',descripcion='" & descrip & "' WHERE cod_tipocuenta=" & aClave

        ejecutar.CommandType = CommandType.Text
        ejecutar.Connection = conexion
        ejecutar.CommandText = sql

        Try
            ejecutar.ExecuteNonQuery()

            MsgBox("Datos Actualizados correctamente", vbOKOnly + vbInformation, "Modificar datos")
        Catch ex As Exception
            MsgBox("Error al actualizar los datos: " & ex.Message, vbOKOnly + vbCritical, "Modificar datos")
        End Try
        desconect()

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        modificar()
    End Sub

End Class