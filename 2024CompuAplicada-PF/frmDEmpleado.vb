Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frmDEmpleado
    Dim sql, r As String
    Dim o As Integer

    Public Function TamCol(ByVal dgv As DataGridView) As Single()
        Dim valores As Single() = New Single(dgv.ColumnCount - 1) {}
        For i As Integer = 0 To dgv.ColumnCount - 1
            valores(i) = CSng(dgv.Columns(i).Width)
        Next
        Return valores
    End Function

    Public Function ExportarPDF(ByVal Doc As Document)
        Dim DTabla As New PdfPTable(dgvEmpleados.ColumnCount)
        DTabla.DefaultCell.Padding = 3
        Dim TamEncabezado As Single() = TamCol(dgvEmpleados)
        DTabla.SetWidths(TamEncabezado)
        DTabla.WidthPercentage = 100
        DTabla.DefaultCell.BorderWidth = 2
        DTabla.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        Dim PrinEncab As New Paragraph("Datos de empleados", New Font(Font.Name = "Tahoma", 20, Font.Bold))
        PrinEncab.Alignment = Element.ALIGN_CENTER
        For i As Integer = 0 To dgvEmpleados.ColumnCount - 1
            DTabla.AddCell(dgvEmpleados.Columns(i).HeaderText)
        Next
        DTabla.HeaderRows = 1
        DTabla.DefaultCell.BorderWidth = 1

        For i As Integer = 0 To dgvEmpleados.RowCount - 2
            For j As Integer = 0 To dgvEmpleados.ColumnCount - 1
                DTabla.AddCell(dgvEmpleados(j, i).Value.ToString())
            Next
            DTabla.CompleteRow()
        Next
        Doc.Add(PrinEncab)
        Doc.Add(New Chunk(" "))
        Doc.Add(New Chunk(" "))
        Doc.Add(DTabla)
    End Function

    Private Sub BusCuentas()

        sql = "SELECT * FROM CEMPLEADO"
        conect()
        ejecutar.CommandType = CommandType.Text
        ejecutar.Connection = conexion
        ejecutar.CommandText = sql

        Try
            buscar = ejecutar.ExecuteReader
            While buscar.Read
                dgvEmpleados.Rows.Add(buscar!cod_empleado, buscar!nombre_empleado, buscar!apellido, buscar!telefono, buscar!contrasenia, buscar!nombre, buscar!cod_tipocuenta)
            End While
        Catch ex As Exception
            MsgBox("Error en la búsqueda: " & ex.Message, vbCritical + vbOKOnly, "Error Busqueda")
        End Try

        desconect()
    End Sub
    Private Sub eliminar()
        conect()
        r = InputBox("Ingrese el Codigo del tipo de cuenta que desea eliminar", "Tipo de cuenta")
        If r <> "" Then
            o = MsgBox("Estás seguro que quieres eliminar estos dato?", vbYesNo + vbQuestion, "Eliminar")
            If o = 6 Then
                sql = "DELETE* FROM EMPLEADO WHERE cod_empleado= " & r

                ejecutar.CommandType = CommandType.Text
                ejecutar.Connection = conexion
                ejecutar.CommandText = sql
            Else

            End If
        Else
            MsgBox("Ingrese la clave de  la cuenta que desea elimiar", vbOKOnly + vbExclamation, "Eliminar")
        End If
        Try
            ejecutar.ExecuteNonQuery()
            MsgBox("Datos eliminados correctamente", vbCritical + vbOKOnly, "Eliminar")
        Catch ex As Exception
            MsgBox("Error en la eliminación: " & ex.Message, vbCritical + vbOKOnly, "Eliminar")
        End Try

        desconect()
    End Sub

    Private Sub frmTipoCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BusCuentas()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            Dim Documento As New Document(PageSize.LETTER.Rotate(), 10, 10, 10, 10)
            Dim NArchivo As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Tipos de Cuentas.pdf"
            Dim archivo As New FileStream(NArchivo, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite)
            PdfWriter.GetInstance(Documento, archivo)
            Documento.Open()
            ExportarPDF(Documento)
            Documento.Close()
            Process.Start(NArchivo)
            MsgBox("Archivo creado", vbOKOnly + vbInformation, "Exportar a PDF")
        Catch ex As Exception
            MsgBox("Error al crear el archivo: " & ex.Message, vbOKOnly + vbCritical, "Error al exportar a PDF")
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        frmAct2.Show()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        frmAgrEmpl.Show()
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        eliminar()
    End Sub
End Class