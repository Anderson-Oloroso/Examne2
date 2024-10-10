Public Class frmAgregarC
    Dim sql As String
    Dim nombre, descrip As String
    Dim cod As Integer

    Private Sub limpiar()
        TxtCodigo.Clear()
        TxtNombre.Clear()
        TxtDescripcion.Clear()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        guardar()
    End Sub

    Private Sub guardar()
        conect()
        If TxtCodigo.Text <> "" And TxtNombre.Text <> "" Then
            cod = TxtCodigo.Text
            nombre = TxtNombre.Text
        Else
            MsgBox("Es obligatorio rellenar todos los campos con el tipo correcto de datos", vbOKOnly + vbExclamation, "Planes")
            limpiar()
        End If
        If TxtDescripcion.Text <> "" Then
            descrip = TxtDescripcion.Text
        Else
            MsgBox("Es obligatorio rellenar todos los campos con el tipo correcto de datos", vbOKOnly + vbExclamation, "Planes")
            limpiar()
        End If


        Try
            sql = "INSERT INTO TIPOCUENTA VALUES(" & cod & ",'" & nombre & "','" & descrip & "')"

            ejecutar.CommandType = CommandType.Text
            ejecutar.Connection = conexion
            ejecutar.CommandText = sql

            ejecutar.ExecuteNonQuery()

            MsgBox("Datos guardados correctamente", vbOKOnly + vbInformation, "Planes")
        Catch ex As Exception
            MsgBox("Error al guardar los datos: " & ex.Message, vbOKOnly + vbCritical, "Planes")
        End Try

        desconect()
    End Sub
End Class