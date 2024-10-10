<<<<<<< HEAD
﻿Public Class frmregion
    Dim cod_peto As Integer
    Dim sql As String
    Dim op, cod As Integer
    Dim eje As New OleDb.OleDbCommand
    Dim bucar As OleDb.OleDbDataReader
    Private Sub limpiar()
        txtcodreg.Clear()
        txtnomreg.Clear()
        txtcodreg.Focus()
    End Sub
    Private Sub buscar()
        sql = "SELECT * FROM REGION WHERE cod_region = '" & txtcodreg.Text & "'"
        conect()
        eje.CommandType = CommandType.Text
        eje.Connection = conexion
        eje.CommandText = sql

        Try

            bucar = eje.ExecuteReader
            If bucar.HasRows Then
                bucar.Read()
                txtnomreg.Text = bucar!nombre
            Else
                MsgBox("El codigo no existe ", vbOKOnly + vbInformation, "Buscar")
                op = MsgBox("agreagar nuevo departamento", vbYesNo + vbInformation, "agreagar")
                If op = 6 Then
                    btnagre.Enabled = True
                    txtnomreg.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en la codigo", vbOKOnly + vbCritical, "Buscar")
        End Try
        desconect()
    End Sub
    Private Sub modi()
        sql = "UPDATE REGION SET  nombre=" & txtnomreg.Text & " WHERE codigomarca= " & txtcodreg.Text & ""
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
        sql = "INSERT INTO region (cod_region, nombre) VALUES (" & txtcodreg.Text & ", '" & txtnomreg.Text & "')"
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
        sql = "DELETE FROM REGION WHERE cod_region=" & txtcodreg.Text
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
        limpiar()
    End Sub

    Private Sub btnbus_Click(sender As Object, e As EventArgs) Handles btnbus.Click
        limpiar()
        buscar()
    End Sub

    Private Sub btnmodi_Click(sender As Object, e As EventArgs) Handles btnmodi.Click
        modi()
        limpiar()

    End Sub

    Private Sub btnelim_Click(sender As Object, e As EventArgs) Handles btnelim.Click
        eli()
        limpiar()
    End Sub
End Class
=======
﻿

Imports iTextSharp.text
        Imports iTextSharp.text.pdf
        Imports System.IO


    Public Class frmRegion
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

        Try
            sql = "DELETE FROM REGION  WHERE nombre = '" & txtNOMBRE.Text.Replace("'", "''") & "' AND cod_region = '" & txtCOD.Text.Replace("'", "''") & "'"


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

        txtNOMBRE.Clear()
            txtCOD.Clear()
            dgvTotal.ClearSelection()
        End Sub

    Private Sub btnImpri_Click(sender As Object, e As EventArgs) Handles btnImpri.Click
        Try
            'GENERAR EL DOCUMENTO
            Dim doc As New Document(PageSize.LETTER.Rotate(), 10, 10, 10, 10)
            'guardar derectorio especifico
            Dim nombreArchivo As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\REGIONES.pdf"
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

    Private Sub btnAGREGAR_Click(sender As Object, e As EventArgs) Handles btnAGREGAR.Click
        agregar()
    End Sub

    Private Sub btnSALER_Click(sender As Object, e As EventArgs) Handles btnSALER.Click
        Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub frmRegion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        region()
        BackColor = Color.Blue

    End Sub



    Private Sub agregar()
        conect()




        Try
            sql = "INSERT INTO REGION VALUES('" & nomb & "','" & munic & "')"

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








        Private Sub region()
            sql = "SELECT * FROM region"

        conect()
        ejecutar.CommandType = CommandType.Text
        ejecutar.Connection = conexion
        ejecutar.CommandText = sql
            Try
                buscar = ejecutar.ExecuteReader()
                While buscar.Read()
                    dgvTotal.Rows.Add(buscar!cod_region, buscar!nombre)
                End While
            Catch ex As Exception
                MsgBox("ERROR EN LA BUSQUEDA: " & ex.Message, vbOKOnly + vbCritical, "ERROR EN LA BUSQUEDA.")
            Finally
            desconect()
        End Try
        End Sub









End Class
   
>>>>>>> 9ccf9f4442cde4953843b76b0cda09115389871e
