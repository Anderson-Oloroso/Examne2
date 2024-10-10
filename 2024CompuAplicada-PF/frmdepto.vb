Public Class frmdepto
    Dim cod_peto As Integer
    Dim sql As String
    Dim op, codm As Integer
    Dim eje As New OleDb.OleDbCommand
    Dim bucar As OleDb.OleDbDataReader
    Private Sub limpiar()
        txtcoddept.Clear()
        txtnomdept.Clear()
        txtcoddept.Focus()
    End Sub
    Private Sub buscaregion()
        desconect()
        sql = "SELECT * FROM REGION WHERE cod_region=" & codm
        conect()
        eje.CommandType = CommandType.Text
        eje.Connection = conexion
        eje.CommandText = sql

        Try
            bucar = eje.ExecuteReader
            If bucar.HasRows Then
                bucar.Read()
                cboregion.Text = bucar!nombre
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en la codigo", vbOKOnly + vbCritical, "Buscar")
        End Try
        desconect()
        sql = "SELECT * FROM REGION"
        conect()
        eje.CommandType = CommandType.Text
        eje.Connection = conexion
        eje.CommandText = sql
        Try
            bucar = eje.ExecuteReader
            While bucar.Read
                cboregion.Items.Add(bucar!nombre)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en la codigo", vbOKOnly + vbCritical, "Buscar")
        End Try
    End Sub
    Private Sub buscar()
        sql = "SELECT * FROM DEPARTAMENTO WHERE cod_depto=" & txtcoddept.Text
        conect()
        eje.CommandType = CommandType.Text
        eje.Connection = conexion
        eje.CommandText = sql

        Try

            bucar = eje.ExecuteReader
            If bucar.HasRows Then
                bucar.Read()
                txtnomdept.Text = bucar!nombre
                buscaregion()
            Else
                MsgBox("El codigo no existe ", vbOKOnly + vbInformation, "Buscar")
                op = MsgBox("agreagar nuevo departamento", vbYesNo + vbInformation, "agreagar")
                If op = 6 Then
                    btnagre.Enabled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en la codigo", vbOKOnly + vbCritical, "Buscar")
        End Try
        desconect()
    End Sub
    Private Sub modi()
        sql = "UPDATE DEPARTAMENTO SET  nombre=" & txtnomdept.Text & " WHERE cod_depto= " & txtcoddept.Text & ""
        conect()
        eje.CommandType = CommandType.Text
        eje.Connection = conexion
        eje.CommandText = sql
        Try
            op = MsgBox("Esta seguro de modificar", vbYesNo + vbExclamation, "Modificar")
            If op = 6 Then
                eje.ExecuteNonQuery()
                MsgBox("Datos modicados", vbOKOnly + vbInformation, "Modificar")
                limpiar()
            End If
        Catch ex As Exception
            MsgBox("Error al modificar", vbOKOnly + vbExclamation, "Modificar")
            limpiar()
        End Try
        desconect()
    End Sub
    Private Sub agregarregion()
        desconect()
        sql = "SELECT * FROM MARCAS"
        conect()
        eje.CommandType = CommandType.Text
        eje.Connection = conexion
        eje.CommandText = sql

        Try
            bucar = eje.ExecuteReader
            While bucar.Read
                cboregion.Items.Add(bucar!nombre)
            End While
        Catch ex As Exception
            MsgBox("Error en la codigo", vbOKOnly + vbCritical, "Buscar")
        End Try
        desconect()
    End Sub
    Private Sub agre()
        conect()
        sql = "INSERT INTO DEPARTAMENTO (cod_depto, nombre, cod_region) VALUES (" & txtcoddept.Text & ", '" & txtnomdept.Text & "', " & cboregion.SelectedValue & ")"
        eje.CommandType = CommandType.Text
        eje.Connection = conexion
        eje.CommandText = sql
        Try
            op = MsgBox("¿Estas seguro de agregar esta nueva region?", vbYesNo + vbQuestion, "Agregar")
            If op = 6 Then
                eje.ExecuteNonQuery()
                MsgBox("Datos agregados", vbOKOnly + vbInformation, "Agregar")
                limpiar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error al agregar", vbOKOnly + vbCritical, "Agregar")
        End Try
        desconect()
        limpiar()
    End Sub
    Private Sub eli()
        sql = "DELETE FROM DEPARTAMENTO WHERE cod_depto=" & txtcoddept.Text
        conect()
        eje.CommandType = CommandType.Text
        eje.Connection = conexion
        eje.CommandText = sql
        Try
            op = MsgBox("Esta seguro de eliminar", vbYesNo + vbExclamation, "Eliminar")
            If op = 6 Then
                eje.ExecuteNonQuery()
                MsgBox("Datos eliminados", vbOKOnly + vbInformation, "Eliminar")
                limpiar()
            End If
        Catch ex As Exception
            MsgBox("Error al eliminar", vbOKOnly + vbExclamation, "Eliminar")
            limpiar()
        End Try
        desconect()
    End Sub
    Private Sub btnbus_Click(sender As Object, e As EventArgs) Handles btnbus.Click
        buscar()
    End Sub

    Private Sub btnagre_Click(sender As Object, e As EventArgs) Handles btnagre.Click
        agre()
    End Sub

    Private Sub btnmodi_Click(sender As Object, e As EventArgs) Handles btnmodi.Click
        modi()
    End Sub

    Private Sub btnelim_Click(sender As Object, e As EventArgs) Handles btnelim.Click
        eli()
    End Sub
End Class