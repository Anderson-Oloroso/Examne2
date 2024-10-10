

    Imports iTextSharp.text
    Imports iTextSharp.text.pdf
    Imports System.IO


    Public Class frmDepartamento
        Dim sql, sql1, sql2, nomb, munic As String
        Dim ejecutar As New OleDb.OleDbCommand
        Dim buscar As OleDb.OleDbDataReader
        Public Function tamanioColum(ByVal dgv As DataGridView) As Single()
            Dim valores As Single() = New Single(dgv.ColumnCount - 1) {}
            For i As Integer = 0 To dgv.ColumnCount - 1
                valores(i) = CSng(dgv.Columns(i).Width)
            Next
            Return valores
        End Function
        Public Sub ExportarPDF(ByVal documento As Document)
            'crear el numero de columnas
            Dim datosTabla As New PdfPTable(dgvTotal.ColumnCount)
            'crea el relleno de las celdas
            datosTabla.DefaultCell.Padding = 3
            'asignar el tamanio de las columnas
            Dim anchoEncabezado As Single() = tamanioColum(dgvTotal)
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
            For i As Integer = 0 To dgvTotal.ColumnCount - 1
                datosTabla.AddCell(dgvTotal.Columns(i).HeaderText)
            Next
            datosTabla.HeaderRows = 1
            datosTabla.DefaultCell.BorderWidth = 1
            'se generan las columnas del datagridview rellenar con los registros 

            For i As Integer = 0 To dgvTotal.RowCount - 2
                For j As Integer = 0 To dgvTotal.ColumnCount - 1
                    datosTabla.AddCell(dgvTotal(j, i).Value.ToString())
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















        Private Sub eliminar()

        conect()
        If txtMunicipio.Text <> "" And txtDepartamento.Text <> "" Then
            nomb = txtMunicipio.Text
            munic = txtDepartamento.Text
        Else
            MsgBox("Es obligatorio rellenar todos los campos con el tipo correcto de datos", vbOKOnly + vbExclamation, "Planes")
                limpiar()
            End If

            Try
            sql = "DELETE FROM DEPARTAMENTO WHERE nombre = '" & txtMunicipio.Text.Replace("'", "''") & "' AND COD_MUNIC = '" & txtDepartamento.Text.Replace("'", "''") & "'"


            ejecutar.CommandType = CommandType.Text
            ejecutar.Connection = conexion
            ejecutar.CommandText = sql

                ejecutar.ExecuteReader()

                MsgBox("Datos eliminados correctamente", vbOKOnly + vbInformation, "Eliminar plan")
            Catch ex As Exception
                MsgBox("Error al eliminar los datos: " & ex.Message, vbOKOnly + vbCritical, "Eliminar plan")
            End Try

        desconect()

    End Sub

        Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
            eliminar()
        End Sub




        Private Sub limpiar()

        txtDepartamento.Clear()
        txtDepartamento.Clear()
        txtMunicipio.Clear()
            dgvTotal.ClearSelection()
        End Sub


        Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
            limpiar()
        End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        agregar()
    End Sub

    Private Sub btnSalei_Click(sender As Object, e As EventArgs) Handles btnSalei.Click
        Close()
    End Sub

    Private Sub btnImpri_Click(sender As Object, e As EventArgs) Handles btnImpri.Click
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

    Private Sub agregar()
        conect()
        If txtDepartamento.Text <> "" And txtMunicipio.Text <> "" Then
            nomb = txtMunicipio.Text

            munic = txtDepartamento.Text
        Else
            MsgBox("Es obligatorio rellenar todos los campos con el tipo correcto de datos", vbOKOnly + vbExclamation, "Planes")
                limpiar()
            End If



            Try
            sql = "INSERT INTO MUNICIPIO VALUES('" & nomb & "','" & munic & "')"

            ejecutar.CommandType = CommandType.Text
            ejecutar.Connection = conexion
            ejecutar.CommandText = sql

                ejecutar.ExecuteReader()

                MsgBox("Datos guardados correctamente", vbOKOnly + vbInformation, "Planes")
            Catch ex As Exception
                MsgBox("Error al guardar los datos: " & ex.Message, vbOKOnly + vbCritical, "Planes")
            End Try

        desconect()
    End Sub








        Private Sub departamento()
            sql = "SELECT * FROM departamento"

        conect()
        ejecutar.CommandType = CommandType.Text
        ejecutar.Connection = conexion
        ejecutar.CommandText = sql
            Try
                buscar = ejecutar.ExecuteReader()
                While buscar.Read()
                    dgvTotal.Rows.Add(buscar!cod_depto, buscar!nombre)
                End While
            Catch ex As Exception
                MsgBox("ERROR EN LA BUSQUEDA: " & ex.Message, vbOKOnly + vbCritical, "ERROR EN LA BUSQUEDA.")
            Finally
            desconect()
        End Try
        End Sub







        Private Sub frmTipocuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            departamento()


            BackColor = Color.Blue
        End Sub











    End Class
