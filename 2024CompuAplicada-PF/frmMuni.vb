Public Class frmMuni
    Dim cod_peto As Integer
    Dim sql As String
    Dim op, cod As Integer
    Dim eje As New OleDb.OleDbCommand
    Dim bucar As OleDb.OleDbDataReader
    Private Sub limpiar()
        txtcodmuni.Clear()
        txtnomuni.Clear()
        txtcodmuni.Focus()
    End Sub
    Private Sub buscar()
        sql = "SELECT * FROM MUNICIPIO WHERE cod_muni=" & txtcodmuni.Text
        conect()
        eje.CommandType = CommandType.Text
        eje.Connection = conexion
        eje.CommandText = sql

        Try

            bucar = eje.ExecuteReader
            If bucar.HasRows Then
                bucar.Read()
                txtnomuni.Text = bucar!nombre
                txtdepto.Text = bucar!cod_depto
            Else
                MsgBox("El codigo no existe ", vbOKOnly + vbInformation, "Buscar")
                op = MsgBox("agreagar nuevo municipio", vbYesNo + vbInformation, "agreagar")
                If op = 6 Then
                    btnagre.Enabled = True
                End If
            End If
        Catch ex As Exception
            MsgBox("Error en la codigo", vbOKOnly + vbCritical, "Buscar")
        End Try
        desconect()
    End Sub
    Private Sub modi()
        sql = "UPDATE MUNICIPIO SET  nombre=" & txtnomuni.Text & " WHERE cod_muni= " & txtcodmuni.Text & ""
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
    Private Sub agre()
        conect()
        sql = "INSERT INTO MUNICIPIO (cod_muni, nombre, cod_depto) VALUES (" & txtcodmuni.Text & ", '" & txtnomuni.Text & "', " & txtdepto.Text & ")"
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
            MsgBox("Error al agregar", vbOKOnly + vbCritical, "Agregar")
        End Try
        desconect()
        limpiar()
    End Sub
    Private Sub eli()
        sql = "DELETE FROM MUNICIPIO WHERE cod_region=" & txtcodmuni.Text
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

    Private Sub btnagre_Click(sender As Object, e As EventArgs) Handles btnagre.Click
        agre()
    End Sub

    Private Sub btnmodi_Click(sender As Object, e As EventArgs) Handles btnmodi.Click
        modi()
    End Sub

    Private Sub btnelim_Click(sender As Object, e As EventArgs) Handles btnelim.Click
        eli()
    End Sub

    Private Sub btnbus_Click(sender As Object, e As EventArgs) Handles btnbus.Click
        buscar()
    End Sub
End Class