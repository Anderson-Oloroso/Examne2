Public Class frmAgrEmpl
    Dim sql, nombre, apellido, contras As String
    Dim cod, telefono, tCuenta As Integer

    Private Sub frmAgrEmpl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TxtCodigo.Clear()
        TxtNombre.Clear()
        txtApellido.Clear()
        txtTel.Clear()
        txtContras.Clear()
        cboTcuenta.Items.Clear()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        guardar()
    End Sub

    Private Sub guardar()
        conect()
        If TxtCodigo.Text <> "" And TxtNombre.Text <> "" And txtApellido.Text <> "" And txtTel.Text And txtContras.Text <> "" Then
            If cboTcuenta.SelectedItem <> Nothing Then
                cod = TxtCodigo.Text
                nombre = TxtNombre.Text
                apellido = txtApellido.Text
                telefono = txtTel.Text
                contras = txtContras.Text
                tCuenta = cboTcuenta.SelectedItem
            End If
        Else
            MsgBox("Es obligatorio rellenar todos los campos con el tipo correcto de datos", vbOKOnly + vbExclamation, "Planes")
            limpiar()
        End If
        sql = "INSERT INTO EMPLEADO VALUES(" & cod & ",'" & nombre & "','" & apellido & "'," & telefono & ",'" & contras & "'," & tCuenta & ")"

        ejecutar.CommandType = CommandType.Text
        ejecutar.Connection = conexion
        ejecutar.CommandText = sql
        Try
            ejecutar.ExecuteNonQuery()

            MsgBox("Datos guardados correctamente", vbOKOnly + vbInformation, "Planes")
        Catch ex As Exception
            MsgBox("Error al guardar los datos: " & ex.Message, vbOKOnly + vbCritical, "Planes")
        End Try

        desconect()
    End Sub
End Class