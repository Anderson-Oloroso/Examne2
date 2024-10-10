Module modConexion
    Public conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CIUDADANOS.accdb")
    Public ejecutar As New OleDb.OleDbCommand
    Public buscar As OleDb.OleDbDataReader
    Public Sub conect()
        Try
            'MsgBox("Abierto")
            conexion.Open()
        Catch ex As Exception
            MsgBox("Error en la conexión" & ex.Message, vbOKOnly + vbCritical, "Error en la conexión")
        End Try
    End Sub

    Public Sub desconect()
        Try
            'MsgBox("Cerrado")
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error en la desconexión" & ex.Message, vbOKOnly + vbCritical, "Error en la desconexión")
        End Try
    End Sub

End Module
