Imports System.Data
Imports System.IO
Imports System.Text
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Public Class FrmRequerimientos
    Inherits System.Windows.Forms.Form
    Private Sub FrmRequerimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
    Public order_bd As SqlCommand
    Private d_table As DataTable
    Private d_adapter As SqlDataAdapter

    Public order_bd2 As SqlCommand
    Private d_table2 As DataTable
    Private d_adapter2 As SqlDataAdapter

    Dim sqldatagrid_REQ As String
    Dim sqldatos_req As New SqlCommand
    Dim sqldrdatos_req As SqlDataReader
    Dim total_x_cantidad As Integer
    Dim total_con_iva As Integer
    Sub buscar_folio()
        Dim sqldatagrid_articulo As String
        Me.SqlConnection1.Open()
        'sqldatagrid_articulo = ("SELECT Folio,Nombre_Art,Fecha_Cap_Req,Cant_Art,Justificacion,Status_Titular,Act FROM Requerimiento where Folio = '" & TB_FolioReq.Text & "'order by cve_art desc")
        sqldatagrid_articulo = ("SELECT Cant_Art,Nombre_Art,Justificacion,Status_Titular,Status_Sub_Adm,No_Factura,No_Compra,Precio_Unitario,Total_x_Cantidad,IVA,Total_IVA,Status_Entrega,Act FROM Requerimiento where Folio = '" & TB_FolioReq.Text & "'")
        order_bd = New SqlCommand(sqldatagrid_articulo, Me.SqlConnection1)
        order_bd.CommandType = CommandType.Text
        order_bd.ExecuteNonQuery()
        d_adapter = New SqlDataAdapter(order_bd)
        d_table = New DataTable
        d_adapter.Fill(d_table)
        DataGridView1.DataSource = d_table
        Me.SqlConnection1.Close()
        Call calcular_subtotal_general()
        Call calcular_total_general()
    End Sub
    Sub calcular_subtotal_general()
        Dim calcula_subtotal_iva As Integer = 0
        Try
            Me.SqlConnection1.Open()
            sqldatagrid_REQ = ("Select * from Requerimiento where Requerimiento.folio = '" & TB_FolioReq.Text & "'")
            order_bd = New SqlCommand(sqldatagrid_REQ, Me.SqlConnection1)
            order_bd.CommandType = CommandType.Text
            order_bd.ExecuteNonQuery()
            d_adapter = New SqlDataAdapter(order_bd)
            d_table = New DataTable
            Dim COL As Integer = Me.DataGridView1.CurrentCell.ColumnIndex
            For Each ROW As DataGridViewRow In Me.DataGridView1.Rows
                calcula_subtotal_iva += Val(ROW.Cells(8).Value)
            Next
            Me.TB_SubTotal_General.Text = (calcula_subtotal_iva.ToString)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlConnection1.Close()
    End Sub
    Sub calcular_total_general()
        Dim calcular_total_general_iva As Integer = 0
        Try
            Me.SqlConnection1.Open()
            sqldatagrid_REQ = ("Select * from Requerimiento where Requerimiento.folio = '" & TB_FolioReq.Text & "'")
            order_bd2 = New SqlCommand(sqldatagrid_REQ, Me.SqlConnection1)
            order_bd2.CommandType = CommandType.Text
            order_bd2.ExecuteNonQuery()
            d_adapter2 = New SqlDataAdapter(order_bd)
            d_table2 = New DataTable
            Dim COL As Integer = Me.DataGridView1.CurrentCell.ColumnIndex
            For Each ROW As DataGridViewRow In Me.DataGridView1.Rows
                'calcula_subtotal_iva += Val(ROW.Cells(8).Value)
                calcular_total_general_iva += Val(ROW.Cells(10).Value)
            Next
            'd_adapter.Fill(d_table)
            'DataGridView1.DataSource = d_table
            'Me.TB_SubTotal_General.Text = (calcula_subtotal_iva.ToString)
            Me.TB_Total_General_Iva.Text = (calcular_total_general_iva.ToString)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlConnection1.Close()
    End Sub
    Sub carga_datos_requerimiento()
        Try
            Me.SqlConnection1.Open()
            sqldatos_req.CommandType = CommandType.Text
            'sqldatos_req.CommandText = ("Select * from Requerimiento where Requerimiento.folio ='" & TB_FolioReq.Text & "'")
            sqldatos_req.CommandText = ("Select * from Requerimiento where Requerimiento.folio = '" & TB_FolioReq.Text & "'")
            sqldatos_req.Connection = Me.SqlConnection1
            sqldrdatos_req = sqldatos_req.ExecuteReader()
            sqldrdatos_req.Read()
            TB_Departamento.Text = sqldrdatos_req("Depto").ToString
            TB_Titular.Text = sqldrdatos_req("Titular_Depto").ToString
            DateTimePickerFechaRegistroReq.Text = sqldrdatos_req("Fecha_Cap_Req").ToString
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqldrdatos_req.Close()
        Me.SqlConnection1.Close()
        'Call CargarDatos_articulo_categoria()
    End Sub
    Private Sub BtnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMostrar.Click
        Call buscar_folio()
        Call carga_datos_requerimiento()
    End Sub
    Private Sub BtnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimir.Click
        Dim sqldatagrid_articulo As String
        Me.SqlConnection1.Open()
        'sqldatagrid_articulo = ("SELECT Cant_Art,Nombre_Art,Justificacion,Precio_Unitario,Total_x_Cantidad,IVA,Total_IVA FROM Requerimiento where Requerimiento.Folio = '" & Val(TB_FolioReq.Text) & "'")
        sqldatagrid_articulo = ("SELECT * FROM Requerimiento where Requerimiento.Folio = '" & Val(TB_FolioReq.Text) & "'")
        order_bd = New SqlCommand(sqldatagrid_articulo, Me.SqlConnection1)
        order_bd.CommandType = CommandType.Text
        order_bd.ExecuteNonQuery()
        d_adapter = New SqlDataAdapter(order_bd)
        d_table = New DataTable
        d_adapter.Fill(d_table)
        DataGridView1.DataSource = d_table
        ' 'Me.SqlConnection1.Close()
        Dim cr As New CR_Requerimiento
        cr.SetDataSource(d_table)
        Dim r As New FrmReporteRequerimiento
        r.CrystalReportViewer2.ReportSource = cr
        r.ShowDialog()
        Me.SqlConnection1.Close()
        'r.CrystalReportViewer2.Visible = False
    End Sub
End Class