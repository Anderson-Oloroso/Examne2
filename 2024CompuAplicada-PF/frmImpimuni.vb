Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class frmImpimuni
    Dim sql As String
    Dim guar As String
    Dim eje As New OleDb.OleDbCommand
    Dim bucar As OleDb.OleDbDataReader
    Private Sub frmImpimuni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cuentas()
        'filtrar()
    End Sub
    'Private Sub filtrar()
    '    sql = "SELECT * FROM municipio WHERE  like=" & cbodepto.SelectedItem & ""
    '    conect()
    '    eje.CommandType = CommandType.Text
    '    eje.Connection = conexion
    '    eje.CommandText = sql

    '    Try
    '        bucar = eje.ExecuteReader
    '        While bucar.Read
    '            dgvimpri.Rows.Add(bucar!cod_muni, bucar!nombre, bucar!cod_depto)
    '        End While
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        MsgBox("Error en la busqueda", vbOKOnly + vbCritical, "Error")
    '    End Try
    '    desconect()
    'End Sub
    Private Sub agregarmarca()
        desconect()
        sql = "SELECT * FROM MARCAS"
        conect()
        eje.CommandType = CommandType.Text
        eje.Connection = conexion
        eje.CommandText = sql

        Try
            bucar = eje.ExecuteReader
            While bucar.Read
                cbodepto.Items.Add(bucar!nombre)
            End While
        Catch ex As Exception
            MsgBox("Error en la codigo", vbOKOnly + vbCritical, "Buscar")
        End Try
        desconect()
    End Sub
    Private Sub depto()

        sql = "SELECT departamento.nombre 
               From municipio inner join departamento
               on municipio.cod_depto=departamento.cod_depto"
        conect()
        eje.CommandType = CommandType.Text
        eje.Connection = conexion
        eje.CommandText = sql

        Try
            bucar = eje.ExecuteReader
            While bucar.Read
                guar = bucar!nombre
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en la busqueda", vbOKOnly + vbCritical, "Error")
        End Try
        desconect()
    End Sub

    Public Function tamanioColum(ByVal dgv As DataGridView) As Single()
        Dim valores As Single() = New Single(dgv.ColumnCount - 1) {}
        For i As Integer = 0 To dgv.ColumnCount - 1
            valores(i) = CSng(dgv.Columns(i).Width)
        Next
        Return valores
    End Function
    Public Sub ExportarPDF(ByVal documento As Document)
        'crear el numero de columnas
        Dim datosTabla As New PdfPTable(dgvimpri.ColumnCount)
        'crea el relleno de las celdas
        datosTabla.DefaultCell.Padding = 3
        'asignar el tamanio de las columnas
        Dim anchoEncabezado As Single() = tamanioColum(dgvimpri)
        datosTabla.SetWidths(anchoEncabezado)
        datosTabla.WidthPercentage = 100
        datosTabla.DefaultCell.BorderWidth = 2
        datosTabla.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        'se crea el encabezado en el PDF
        Dim encabezado As New Paragraph("CIUDADANOS", New Font(Font.Name = "Arial Black", 14, Font.Bold))
        'Dim encabezadoSecundario As New Paragraph(btnImprimir.Text, New Font(Font.Name = "Algerian", 12, Font.Bold))
        'logo del PDF 
        'Dim imagen As iTextSharp.text.Image
        'imagen = iTextSharp.text.Image.GetInstance(My.Computer.FileSystem.CurrentDirectory & "\nombre.extencion")
        'imagen.ScalePercent(12)
        'imagen.SetAbsolutePosition(720, 520)
        'captura de datos 
        For i As Integer = 0 To dgvimpri.ColumnCount - 1
            datosTabla.AddCell(dgvimpri.Columns(i).HeaderText)
        Next
        datosTabla.HeaderRows = 1
        datosTabla.DefaultCell.BorderWidth = 1
        'se generan las columnas del datagridview rellenar con los registros 

        For i As Integer = 0 To dgvimpri.RowCount - 2
            For j As Integer = 0 To dgvimpri.ColumnCount - 1
                datosTabla.AddCell(dgvimpri(j, i).Value.ToString())
            Next
            datosTabla.CompleteRow()
        Next
        'agregar datos al PDF 
        'documento.Add(imagen)
        documento.Add(encabezado)
        'salto de linea
        documento.Add(New Chunk(""))
        'documento .Add(encabezadoSecundario)
        documento.Add(New Chunk(""))
        documento.Add(datosTabla)

    End Sub

    Private Sub btnimpri_Click(sender As Object, e As EventArgs) Handles btnimpri.Click

        Try
            'GENERAR EL DOCUMENTO
            Dim doc As New Document(PageSize.LETTER.Rotate(), 10, 10, 10, 10)
            'guardar derectorio especifico
            Dim nombreArchivo As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\CIUDADANOS.pdf"
            'crear el archivo fisico
            Dim archivo As New FileStream(nombreArchivo, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, archivo)
            doc.Open()
            ExportarPDF(doc)
            doc.Close()
            Process.Start(nombreArchivo)
            MsgBox("Archivo creado. ", vbOKOnly + vbInformation, "Exportar pdf...")
        Catch ex As Exception
            MsgBox("Error al generar pdf.", vbOKOnly + vbCritical, "Error pdf...")
        End Try

    End Sub

    Private Sub cuentas()
        sql = "SELECT * FROM municipio"
        conect()
        eje.CommandType = CommandType.Text
        eje.Connection = conexion
        eje.CommandText = sql

        Try
            bucar = eje.ExecuteReader
            While bucar.Read
                dgvimpri.Rows.Add(bucar!cod_muni, bucar!nombre, bucar!cod_depto)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en la busqueda", vbOKOnly + vbCritical, "Error")
        End Try
        desconect()
    End Sub

End Class