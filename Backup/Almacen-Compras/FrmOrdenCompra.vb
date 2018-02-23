Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Text
Public Class FrmOrdenCompra
    Private Sub FrmOrdenCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ALMACENDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.ALMACENDataSet.Proveedores)
    End Sub
    Dim editar As Boolean = False
    Dim roweditar As Integer
    Dim ideditar As Integer
    Dim sqldatagrid_Orden_Compra As String

    Public order_bd As SqlCommand
    Private d_table As DataTable
    Private d_adapter As SqlDataAdapter
    'Dim adapter_rp As SqlDataAdapter
    Public Seleccion As String
    Dim sqldatos_req As New SqlCommand
    Dim sqldrdatos_req As SqlDataReader
    Dim total_x_cantidad As Integer
    Dim total_con_iva As Integer
    Public calcular_ivaA As Integer
    Dim calcular_ivaB As Integer

    Dim calcula_subtotal_iva As Integer
    Dim total_general_iva As Integer
    'Dim Y As Integer = 100
    Dim conectarme As New OleDbConnection
    Public dataset_rp, dat_rp, DS As New DataSet
    Public adapter_rp, ada_rp, DA As SqlDataAdapter
    Public buscar_folio_rp, buscar_rp As String
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
        'Me.d_table.Clear()
        Call calcular_subtotal_general()
        Call calcular_total_general()
    End Sub
    Sub calcular_subtotal_general()
        Dim calcula_subtotal_registros As Integer = 0
        Try
            Me.SqlConnection1.Open()
            sqldatagrid_Orden_Compra = ("Select * from Requerimiento where Requerimiento.folio = '" & TB_FolioReq.Text & "'")
            order_bd = New SqlCommand(sqldatagrid_Orden_Compra, Me.SqlConnection1)
            order_bd.CommandType = CommandType.Text
            order_bd.ExecuteNonQuery()
            d_adapter = New SqlDataAdapter(order_bd)
            d_table = New DataTable
            Dim COL As Integer = Me.DataGridView1.CurrentCell.ColumnIndex
            For Each ROW As DataGridViewRow In Me.DataGridView1.Rows
                calcula_subtotal_registros += Val(ROW.Cells(8).Value)
            Next
            'd_adapter.Fill(d_table)
            'DataGridView1.DataSource = d_table
            Me.TB_SubTotal_General.Text = (calcula_subtotal_registros.ToString)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlConnection1.Close()
    End Sub
    Sub calcular_total_general()
        Dim calcular_total_general_registros As Integer = 0
        Try
            Me.SqlConnection1.Open()
            sqldatagrid_Orden_Compra = ("Select * from Requerimiento where Requerimiento.folio = '" & TB_FolioReq.Text & "'")
            order_bd = New SqlCommand(sqldatagrid_Orden_Compra, Me.SqlConnection1)
            order_bd.CommandType = CommandType.Text
            order_bd.ExecuteNonQuery()
            d_adapter = New SqlDataAdapter(order_bd)
            d_table = New DataTable
            Dim COL As Integer = Me.DataGridView1.CurrentCell.ColumnIndex
            For Each ROW As DataGridViewRow In Me.DataGridView1.Rows
                'calcula_subtotal_iva += Val(ROW.Cells(8).Value)
                calcular_total_general_registros += Val(ROW.Cells(10).Value)
            Next
            'd_adapter.Fill(d_table)
            'DataGridView1.DataSource = d_table
            'Me.TB_SubTotal_General.Text = (calcula_subtotal_iva.ToString)
            Me.TB_Total_General_Iva.Text = (calcular_total_general_registros.ToString)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlConnection1.Close()
    End Sub

    Private Sub Btn_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Editar.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            'Call activar_datos_ARTICULO()
            'DateTimePicker1.Text = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(1).Value.ToString
            TB_Cantidad_Articulos.Text = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(0).Value.ToString
            TB_NoFactura.Text = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(5).Value.ToString
            TB_NoCompra.Text = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(6).Value.ToString
            TB_PrecioUnitario.Text = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(7).Value.ToString
            TB_Total_Cantidad.Text = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(8).Value.ToString
            CB_IVA.Text = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(9).Value.ToString
            TB_Total_IVA.Text = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(10).Value.ToString
            CB_Entrega.Text = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(11).Value.ToString
            TB_Activo.Text = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(12).Value.ToString
            editar = True
            roweditar = DataGridView1.SelectedRows(0).Index
            Me.TB_NoFactura.Focus()
            'Call activar_datos_ARTICULO()
            'BtnActualizar.Enabled = True
            'BtnGuardar.Enabled = False
            'BtnEliminar.Enabled = True
        Else
            MsgBox("No se ha seleccionado ningun Articulo")
        End If
    End Sub
    Sub Actualizar_Datos_Orden_Compra()
        Try
            Dim Actualizar_Proveedores As String
            Me.SqlConnection1.Open()
            Actualizar_Proveedores = MsgBox("Esta seguro de Actualizar los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Guardar")
            If Actualizar_Proveedores = vbYes Then
                'Dim Actualizar_Datos_Proveedores As String = ("UPDATE Requerimiento SET Cant_Art=@Cant_Art,No_Factura=@No_Factura,No_Compra=@No_Compra,Precio_Unitario=@Precio_Unitario,Total_x_Cantidad=@Total_x_Cantidad,IVA=@IVA,Total_Iva=@Total_Iva,Fecha_Entrega_Pedido=@Fecha_Entrega_Pedido,Status_Entrega=@Status_Entrega where Act= '" & TB_Activo.Text & "'")
                Dim Actualizar_Datos_Proveedores As String = ("UPDATE Requerimiento SET Cant_Art=@Cant_Art,No_Factura=@No_Factura,No_Compra=@No_Compra,Precio_Unitario=@Precio_Unitario,Total_x_Cantidad=@Total_x_Cantidad,IVA=@IVA,Total_Iva=@Total_Iva,Fecha_Entrega_Pedido=@Fecha_Entrega_Pedido,Status_Entrega=@Status_Entrega where Act= '" & TB_Activo.Text & "'" & "and Folio= '" & TB_FolioReq.Text & "'")
                Dim conex2 As New SqlClient.SqlCommand(Actualizar_Datos_Proveedores, Me.SqlConnection1)
                'conex2.Parameters.Add(New SqlParameter("@Cve_Pro", SqlDbType.NVarChar, 2)).Value = Me.TextBoxCveProducto.Text()
                'conex2.Parameters.Add(New SqlParameter("@Cve_Art", SqlDbType.NVarChar, 5)).Value = Me.TextBoxCveArticulo.Text
                'conex2.Parameters.Add(New SqlParameter("@Nombre_Art", SqlDbType.NVarChar, 50)).Value = Me.TextBoxDescripcion.Text
                conex2.Parameters.Add(New SqlParameter("@Cant_Art", SqlDbType.Int, 5)).Value = Val(Me.TB_Cantidad_Articulos.Text)
                conex2.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 7)).Value = Me.TB_NoFactura.Text
                conex2.Parameters.Add(New SqlParameter("@No_Compra", SqlDbType.NChar, 5)).Value = Me.TB_NoCompra.Text
                conex2.Parameters.Add(New SqlParameter("@Precio_Unitario", SqlDbType.Int, 5)).Value = Val(Me.TB_PrecioUnitario.Text)
                conex2.Parameters.Add(New SqlParameter("@Total_x_Cantidad", SqlDbType.Int, 5)).Value = Val(Me.TB_Total_Cantidad.Text)
                conex2.Parameters.Add(New SqlParameter("@IVA", SqlDbType.Int, 4)).Value = Val(Me.CB_IVA.Text)
                conex2.Parameters.Add(New SqlParameter("@Total_Iva", SqlDbType.Int, 5)).Value = Val(Me.TB_Total_IVA.Text)
                conex2.Parameters.Add(New SqlParameter("@Fecha_Entrega_Pedido", SqlDbType.SmallDateTime)).Value = Date.Today
                conex2.Parameters.Add(New SqlParameter("@Status_Entrega", SqlDbType.NChar, 1)).Value = Me.CB_Entrega.Text
                conex2.CommandText = Actualizar_Datos_Proveedores
                conex2.ExecuteNonQuery()
                MsgBox("Datos Actualizados correctamente", , "Guardar")
            End If
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Actualizar_Datos_Proveedor()
        Try
            Dim Actualizar_Proveedores As String
            Me.SqlConnection1.Open()
            Actualizar_Proveedores = MsgBox("Esta seguro de Generar la orden de compra ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Guardar")
            If Actualizar_Proveedores = vbYes Then
                Dim Actualizar_Datos_Proveedores As String = ("UPDATE Requerimiento SET Nombre_Proveedor=@Nombre_Proveedor,Direccion=@Direccion,Telefono=@Telefono where Requerimiento.folio = '" & TB_FolioReq.Text & "'")
                Dim conex2 As New SqlClient.SqlCommand(Actualizar_Datos_Proveedores, Me.SqlConnection1)
                conex2.Parameters.Add(New SqlParameter("@Nombre_Proveedor", SqlDbType.NVarChar, 100)).Value = Me.CB_NombreProveedor.Text()
                conex2.Parameters.Add(New SqlParameter("@Direccion", SqlDbType.NVarChar, 50)).Value = Me.TB_Direccion.Text
                conex2.Parameters.Add(New SqlParameter("@Telefono", SqlDbType.NVarChar, 50)).Value = Me.TB_Telefono.Text
                conex2.ExecuteNonQuery()
                MsgBox("Datos Actualizados correctamente", , "Guardar")
            End If
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
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
        Me.sqldrdatos_req.Close()
        Me.SqlConnection1.Close()
        'Call CargarDatos_articulo_categoria()
    End Sub
    Sub CargarDatos_articulo()
        Me.SqlConnection1.Open()
        sqldatagrid_Orden_Compra = ("SELECT * FROM Articulo order by Cve_Art")
        order_bd = New SqlCommand(sqldatagrid_Orden_Compra, Me.SqlConnection1)
        order_bd.CommandType = CommandType.Text
        order_bd.ExecuteNonQuery()
        d_adapter = New SqlDataAdapter(order_bd)
        d_table = New DataTable
        d_adapter.Fill(d_table)
        DataGridView1.DataSource = d_table
        Me.SqlConnection1.Close()
    End Sub
    Private Sub BtnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMostrar.Click
        Call carga_datos_requerimiento()
        Call buscar_folio()

    End Sub
    Private Sub Btn_Actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Actualizar.Click
        Call Actualizar_Datos_Orden_Compra()
        Call buscar_folio()

    End Sub
    Private Sub TB_PrecioUnitario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_PrecioUnitario.TextChanged
        total_x_cantidad = Val(TB_Cantidad_Articulos.Text) * Val(TB_PrecioUnitario.Text)
        TB_Total_Cantidad.Text = Str(total_x_cantidad)
        'calcular_ivaB = Val(TB_Total_Cantidad.Text) * Val(CB_IVA.Text)
        'MsgBox(calcular_ivaB.ToString)
    End Sub
    Private Sub CB_IVA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_IVA.SelectedIndexChanged
        'TB_Total_General_Iva.Text = CStr(calcular_ivaB)
        calcular_ivaA = Val(TB_Total_Cantidad.Text) * Val(CB_IVA.Text)
        calcula_subtotal_iva = calcular_ivaA / 100
        calcular_ivaB = (calcula_subtotal_iva) + Val(TB_Total_Cantidad.Text)
        TB_Total_IVA.Text = CStr(calcular_ivaB)
        'calcular_ivaB = (calcular_ivaA) + Val(TB_Total_Cantidad.Text)
        'TB_Total_IVA.Text = CStr(calcular_ivaA)
    End Sub
    Sub busqueda_folio_requerimiento()
        Dim CONSQL As New SqlClient.SqlConnection
        CONSQL.ConnectionString = "Data Source=COLMASQLFDC01\FACDYCDES;Initial Catalog=ALMACEN;Integrated Security=True"
        CONSQL.Open()
        Dim DA As New SqlClient.SqlDataAdapter("Select * from Requerimiento where Requerimiento.folio = '" & TB_FolioReq.Text, CONSQL)
        Dim DS As New DataSet
        DA.Fill(DS, "Requerimiento")
        Me.DataGridView1.DataSource = DS.Tables("Requerimiento")
        Me.DataGridView1.DataMember = "Folio"
        Me.SqlConnection1.Close()
    End Sub


    Private Sub BtnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimir.Click
        Call Actualizar_Datos_Proveedor_odc()

        Dim sqldatagrid_articulo As String
        Me.SqlConnection1.Open()
        sqldatagrid_articulo = ("SELECT * FROM Requerimiento where Folio = '" & Val(TB_FolioReq.Text) & "'")
        order_bd = New SqlCommand(sqldatagrid_articulo, Me.SqlConnection1)
        order_bd.CommandType = CommandType.Text
        order_bd.ExecuteNonQuery()
        d_adapter = New SqlDataAdapter(order_bd)
        d_table = New DataTable
        d_adapter.Fill(d_table)
        DataGridView1.DataSource = d_table
        ' 'Me.SqlConnection1.Close()
        Dim cr As New CROrdenCompra
        cr.SetDataSource(d_table)

        Dim r As New FrmReporteOrdenCompra
        r.CrystalReportViewer1.ReportSource = cr
        r.ShowDialog()
        SqlConnection1.Close()
        'r.Close()
        'FrmReporteOrdenCompra.Close()
        'FrmReporteOrdenCompra.Enabled = False

    End Sub

    Dim sqlbusqueda As String
    Public ORDER_BD_OD As SqlCommand
    Private D_TABLE_OD As DataTable
    Private D_ADAPTER_OD As SqlDataAdapter
    'Dim seleccion As Integer
    'Dim cmdbl As New SqlCommandBuilder
    'Dim ds As New DataSet
    Sub bucar_datos_Proveedores()
        Try
            Me.SqlConnection1.Open()
            'sqlbusqueda = ("SELECT * FROM Litigio WHERE " & TBFolioLitigio.Text & "LIKE" & seleccion & "'ORDER BY FOLIO_LITIGIO'")
            'sqlmatricula_resultado.CommandText = ("Select * from solicitud where solicitud.matricula = '" & Frm_Solicitud.TBMatricula.Text & "'" & "and solicitud.Periodo_Escolar = '" & Frm_Solicitud.CBPeriodo.Text & "'" & "AND ID = '" & Frm_Solicitud.TBID.Text & "'")
            sqlbusqueda = ("SELECT * FROM Proveedores WHERE Proveedores.Nombre_Proveedor = '" & Me.CB_NombreProveedor.Text & "'")
            'ds = New System.Data.DataSet()
            ORDER_BD_OD = New SqlCommand(sqlbusqueda, Me.SqlConnection1)
            ORDER_BD_OD.CommandType = CommandType.Text
            ORDER_BD_OD.ExecuteNonQuery()
            D_ADAPTER_OD = New SqlDataAdapter(ORDER_BD_OD)
            D_TABLE_OD = New DataTable
            'D_ADAPTER.Fill(ds, "Litigio")
            D_ADAPTER_OD.Fill(D_TABLE_OD)
            'DataGridView1.DataSource = D_TABLE_OD
            If D_TABLE_OD.Rows.Count > 0 Then
                'DateTimePicker1.Text = d_table.Rows(0)("Fecha_Asesoria_L")
                'TBFolioLitigio.Text = D_TABLE_OD.Rows(0)("folio_litigio")
                'TBNombre_Solicitante_Litigio.Text = d_table.Rows(0)("Nombre_Solicitante_L")
                TB_Direccion.Text = D_TABLE_OD.Rows(0)("Direccion")
                TB_Telefono.Text = D_TABLE_OD.Rows(0)("Telefono")
                '  BtnActualizar.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlConnection1.Close()
    End Sub
    Sub Actualizar_Datos_Proveedor_odc()
        Try
            'Dim Actualizar_Proveedores_od As String
            Me.SqlConnection1.Open()
            'Actualizar_Proveedores_od = MsgBox("Esta seguro de Actualizar los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Guardar")
            'If Actualizar_Proveedores_od = vbYes Then
            Dim Actualizar_Datos_Proveedores_od As String = ("UPDATE Requerimiento SET Nombre_Proveedor=@Nombre_Proveedor,Direccion=@Direccion,Telefono=@Telefono where Folio= '" & TB_FolioReq.Text & "'")
            Dim conex_od As New SqlClient.SqlCommand(Actualizar_Datos_Proveedores_od, Me.SqlConnection1)
            conex_od.Parameters.Add(New SqlParameter("@Nombre_Proveedor", SqlDbType.NVarChar, 50)).Value = Me.CB_NombreProveedor.Text
            conex_od.Parameters.Add(New SqlParameter("@Direccion", SqlDbType.NVarChar, 50)).Value = Me.TB_Direccion.Text
            conex_od.Parameters.Add(New SqlParameter("@Telefono", SqlDbType.NVarChar, 50)).Value = Me.TB_Telefono.Text
            conex_od.CommandText = Actualizar_Datos_Proveedores_od
            conex_od.ExecuteNonQuery()
            'MsgBox("Datos Actualizados correctamente", , "Guardar")
            'End If
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Private Sub CB_NombreProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_NombreProveedor.SelectedIndexChanged
        Call bucar_datos_Proveedores()
    End Sub
End Class