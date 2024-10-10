Public Class frmAct2
    Dim sql, nombreE, apellido, contras As String
    Dim codtipoC, tel, aClave, nClave As Integer

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        modificar()
    End Sub

    Private Sub frmActualizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conect()
        sql = "SELECT cod_tipocuenta FROM TIPOCUENTA"
        ejecutar.CommandType = CommandType.Text
        ejecutar.Connection = conexion
        ejecutar.CommandText = sql
        Try
            buscar = ejecutar.ExecuteReader
            While buscar.Read
                cboTcuenta.Items.Add(buscar!cod_tipocuenta)
            End While
        Catch ex As Exception
            MsgBox("Error al rellenar ComboBox: " & ex.Message, vbOKOnly + vbCritical, "ComboBox")
        End Try
        desconect()
    End Sub

    Private Sub limpiar()
        txtAclave.Clear()
        txtNclave.Clear()
        TxtNombre.Clear()
        txtApellido.Clear()
        txtContras.Clear()
        txtTel.Clear()
        cboTcuenta.Items.Clear()
    End Sub

    Private Sub modificar()
        conect()
        nombreE = TxtNombre.Text
        apellido = txtApellido.Text
        tel = txtTel.Text
        contras = txtContras.Text
        aClave = txtAclave.Text
        nClave = txtNclave.Text
        codtipoC = cboTcuenta.SelectedItem
        sql = "UPDATE EMPLEADO  SET cod_empleado=" & nClave & ",nombre='" & nombreE & "',apellido='" & apellido & "',telefono=" & tel & ",contrasenia='" & contras & "',cod_tipocuenta=" & codtipoC & "  WHERE cod_tipocuenta=" & aClave

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


End Class