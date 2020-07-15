Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Text
Public Class FrmGenera_Orden_Compra
    Private Sub FrmGenera_Orden_Compra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ALMACENDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.ALMACENDataSet.Proveedores)
        'TODO: esta línea de código carga datos en la tabla 'ALMACENDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        ' Me.ProveedoresTableAdapter.Fill(Me.ALMACENDataSet.Proveedores)

        'TODO: esta línea de código carga datos en la tabla 'ALMACENDataSet4.Proveedores' Puede moverla o quitarla según sea necesario.
        ' Me.ProveedoresTableAdapter.Fill(Me.ALMACENDataSet.Proveedores)

        'TODO: esta línea de código carga datos en la tabla 'ALMACENDataSet3.Proveedores' Puede moverla o quitarla según sea necesario.
        ' Me.ProveedoresTableAdapter.Fill(Me.ALMACENDataSet3.Proveedores)
        'TODO: esta línea de código carga datos en la tabla 'ALMACENDataSet2.Proveedores' Puede moverla o quitarla según sea necesario.
        'Me.ProveedoresTableAdapter.Fill(Me.ALMACENDataSet2.Proveedores)
        'TODO: esta línea de código carga datos en la tabla 'ALMACENDataSet11.Proveedores' Puede moverla o quitarla según sea necesario.
        'Me.ProveedoresTableAdapter.Fill(Me.ALMACENDataSet11.Proveedores)
        'TODO: esta línea de código carga datos en la tabla 'ALMACENDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        'Me.ProveedoresTableAdapter.Fill(Me.ALMACENDataSet.Proveedores)
    End Sub
    Public order_bd As SqlCommand
    Private d_table As DataTable
    Private d_adapter As SqlDataAdapter
    Sub buscar_Orden_Compra()
        Dim sqldatagrid_OD As String
        Me.SqlConnection1.Open()
        ''CON FILTRO DE AUTORIZADO
        ''sqldatagrid_OD = ("SELECT Cant_Art,Nombre_Art,No_Factura,No_Compra,Status_Sub_Adm FROM Requerimiento where No_Compra = '" & TB_Orden_Compra.Text & "'" & "AND Status_Sub_Adm='" & "A" & "'")
        sqldatagrid_OD = ("SELECT Cant_Art,Nombre_Art,No_Factura,No_Compra,Status_Sub_Adm FROM Requerimiento where No_Compra = '" & TB_Orden_Compra.Text & "'")
        order_bd = New SqlCommand(sqldatagrid_OD, Me.SqlConnection1)
        order_bd.CommandType = CommandType.Text
        order_bd.ExecuteNonQuery()
        d_adapter = New SqlDataAdapter(order_bd)
        d_table = New DataTable
        d_adapter.Fill(d_table)
        DataGridView1.DataSource = d_table
        Me.SqlConnection1.Close()
        'Call calcular_subtotal_general()
        'Call calcular_total_general()
    End Sub
    Private Sub BtnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMostrar.Click
        Call buscar_Orden_Compra()
    End Sub
    Sub Actualizar_Datos_Proveedor()
        Try
            Dim Actualizar_Proveedores As String
            Me.SqlConnection1.Open()
            Actualizar_Proveedores = MsgBox("Esta seguro de Generar la orden de compra ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Guardar")
            If Actualizar_Proveedores = vbYes Then
                Dim Actualizar_Datos_Proveedores As String = ("UPDATE Requerimiento SET Nombre_Proveedor=@Nombre_Proveedor,Direccion=@Direccion,Telefono=@Telefono where Requerimiento.No_Compra = '" & TB_Orden_Compra.Text & "'")
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
    Private Sub BtnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimir.Click
        Call Actualizar_Datos_Proveedor()
        Dim sqldatagrid_articulo As String
        Me.SqlConnection1.Open()
        'Dim Actualiza_Bono_Hojas As String = ("UPDATE Bono_Hojas SET Resto_hojas=@Resto_hojas where Matricula= '" & TBMatricula.Text & "'")
        sqldatagrid_articulo = ("SELECT * FROM Requerimiento where No_Compra = '" & Val(TB_Orden_Compra.Text) & "'")
        order_bd = New SqlCommand(sqldatagrid_articulo, Me.SqlConnection1)
        order_bd.CommandType = CommandType.Text
        order_bd.ExecuteNonQuery()
        d_adapter = New SqlDataAdapter(order_bd)
        d_table = New DataTable
        d_adapter.Fill(d_table)
        Dim cr As New CROrdenCompra
        'Dim cr As New CR_OrdenCompra2
        cr.SetDataSource(d_table)
        Dim r As New FrmReporteOrdenCompra
        r.CrystalReportViewer1.ReportSource = cr
        r.ShowDialog()
        SqlConnection1.Close()
    End Sub
    Dim sqlbusqueda As String
    Public ORDER_BD_OD As SqlCommand
    Private D2_TABLE_OD As DataTable
    Private D2_ADAPTER_OD As SqlDataAdapter
    Sub cargar_datos_Proveedores()
        Try
            Me.SqlConnection1.Open()
            'sqlbusqueda = ("SELECT * FROM Litigio WHERE " & TBFolioLitigio.Text & "LIKE" & seleccion & "'ORDER BY FOLIO_LITIGIO'")
            'sqlmatricula_resultado.CommandText = ("Select * from solicitud where solicitud.matricula = '" & Frm_Solicitud.TBMatricula.Text & "'" & "and solicitud.Periodo_Escolar = '" & Frm_Solicitud.CBPeriodo.Text & "'" & "AND ID = '" & Frm_Solicitud.TBID.Text & "'")
            sqlbusqueda = ("SELECT * FROM Proveedores WHERE Proveedores.Nombre_Proveedor = '" & Me.CB_NombreProveedor.Text & "'")
            'ds = New System.Data.DataSet()
            ORDER_BD_OD = New SqlCommand(sqlbusqueda, Me.SqlConnection1)
            ORDER_BD_OD.CommandType = CommandType.Text
            ORDER_BD_OD.ExecuteNonQuery()
            D2_ADAPTER_OD = New SqlDataAdapter(ORDER_BD_OD)
            D2_TABLE_OD = New DataTable
            'D_ADAPTER.Fill(ds, "Litigio")
            D2_ADAPTER_OD.Fill(D2_TABLE_OD)
            'DataGridView1.DataSource = D_TABLE_OD
            If D2_TABLE_OD.Rows.Count > 0 Then
                'DateTimePicker1.Text = d_table.Rows(0)("Fecha_Asesoria_L")
                'TBFolioLitigio.Text = D_TABLE_OD.Rows(0)("folio_litigio")
                'TBNombre_Solicitante_Litigio.Text = d_table.Rows(0)("Nombre_Solicitante_L")
                TB_Direccion.Text = D2_TABLE_OD.Rows(0)("Direccion")
                TB_Telefono.Text = D2_TABLE_OD.Rows(0)("Telefono")
                '  BtnActualizar.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlConnection1.Close()
    End Sub
    Private Sub CB_NombreProveedor_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_NombreProveedor.SelectedIndexChanged
        Call cargar_datos_Proveedores()
    End Sub

    'Private Sub FillBy2ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ' Try
    ''Me.ProveedoresTableAdapter.FillBy2(Me.ALMACENDataSet.Proveedores)
    'Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    ' End Try

    '    End Sub
End Class