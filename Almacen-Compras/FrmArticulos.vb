Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Text
Public Class FrmArticulos
    Private Sub FrmArticulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call cargar_productos()
        Call CargarDatos_articulo()
    End Sub
    Dim editar As Boolean = False
    Dim roweditar As Integer
    Dim ideditar As Integer
    Dim sqldatagrid_articulo As String
    Public order_bd As SqlCommand
    Private d_table As DataTable
    Private d_adapter As SqlDataAdapter
    Public Seleccion As String
    Dim SW As Integer = 0
    Dim sqlbusqueda_articulo As String
    Dim sqlproducto As New SqlCommand
    Dim sqldrproducto As SqlDataReader
    Public clave_producto As String
    Sub cargar_productos()
        Try
            Me.SqlConnection1.Open()
            sqlproducto.CommandType = CommandType.Text
            sqlproducto.CommandText = ("select *  from Producto")
            sqlproducto.Connection = Me.SqlConnection1
            sqldrproducto = sqlproducto.ExecuteReader()
            While sqldrproducto.Read = True
                CBProducto.Items.Add(sqldrproducto.Item(2))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqldrproducto.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub carga_clave_producto()
        Try
            Me.SqlConnection1.Open()
            sqlproducto.CommandType = CommandType.Text
            sqlproducto.CommandText = ("Select * from Producto where Producto.Nombre_pro =  '" & CBProducto.Text & "'")
            'sqlproducto.CommandText = ("select *  from Producto")
            sqlproducto.Connection = Me.SqlConnection1
            sqldrproducto = sqlproducto.ExecuteReader()
            sqldrproducto.Read()
            TextBoxCveProducto.Text = sqldrproducto("Cve_Pro").ToString
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqldrproducto.Close()
        Me.SqlConnection1.Close()
        Call CargarDatos_articulo_categoria()
    End Sub
    Sub CargarDatos_articulo_categoria()
        Me.SqlConnection1.Open()
        'sqldatagrid_articulo = ("SELECT * FROM Articulo order by Cve_Art")
        sqldatagrid_articulo = ("SELECT * FROM Articulo where Cve_Pro = '" & TextBoxCveProducto.Text & "'order by cve_art desc")
        order_bd = New SqlCommand(sqldatagrid_articulo, Me.SqlConnection1)
        order_bd.CommandType = CommandType.Text
        order_bd.ExecuteNonQuery()
        d_adapter = New SqlDataAdapter(order_bd)
        d_table = New DataTable
        d_adapter.Fill(d_table)
        DataGridView1.DataSource = d_table
        Me.SqlConnection1.Close()
    End Sub
    Sub CargarDatos_articulo()
        Me.SqlConnection1.Open()
        sqldatagrid_articulo = ("SELECT * FROM Articulo order by Cve_Art")
        order_bd = New SqlCommand(sqldatagrid_articulo, Me.SqlConnection1)
        order_bd.CommandType = CommandType.Text
        order_bd.ExecuteNonQuery()
        d_adapter = New SqlDataAdapter(order_bd)
        d_table = New DataTable
        d_adapter.Fill(d_table)
        DataGridView1.DataSource = d_table
        Me.SqlConnection1.Close()
    End Sub
    Private Sub CBProducto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBProducto.SelectedIndexChanged
        Call carga_clave_producto()
    End Sub
    Sub Agregar_Articulo()
        Dim agregardatos_Articulo As String
        agregardatos_Articulo = MsgBox("Esta seguro de Guardar los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Guardar")
        Try
            If agregardatos_Articulo = vbYes Then
                Me.SqlConnection1.Open()
                Dim Insdatos_proveedor As String = "INSERT INTO Articulo (Codigo,Cve_Pro,Cve_Art,Nombre_Art,Cant_Art,Cant_Min,Precio_Articulo) values(@Codigo,@Cve_Pro,@Cve_Art,@Nombre_Art,@Cant_Art,@Cant_Min,@Precio_Articulo)"
                'Dim Insdatosa As String = "INSERT INTO Litigio (Nombre_Solicitante_L) values(@Nombre_Solicitante_L)"
                Dim conex1 As New SqlClient.SqlCommand(Insdatos_proveedor, Me.SqlConnection1)
                conex1.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.NVarChar, 20)).Value = Me.TextBoxCodigo.Text
                conex1.Parameters.Add(New SqlParameter("@Cve_Pro", SqlDbType.NVarChar, 2)).Value = Me.TextBoxCveProducto.Text
                conex1.Parameters.Add(New SqlParameter("@Cve_Art", SqlDbType.NVarChar, 5)).Value = Me.TextBoxCveArticulo.Text
                conex1.Parameters.Add(New SqlParameter("@Nombre_Art", SqlDbType.NVarChar, 50)).Value = Me.TextBoxDescripcion.Text
                conex1.Parameters.Add(New SqlParameter("@Cant_Art", SqlDbType.Int, 5)).Value = Me.TextBoxCantidadArticulo.Text
                conex1.Parameters.Add(New SqlParameter("@Cant_Min", SqlDbType.Int, 5)).Value = Me.TextBoxCantidadMinima.Text
                conex1.Parameters.Add(New SqlParameter("@Precio_Articulo", SqlDbType.Int, 5)).Value = Me.TextBoxPrecio.Text
                conex1.CommandText = Insdatos_proveedor
                conex1.ExecuteNonQuery()
                MsgBox("Datos guardados correctamente", , "Guardar")
            End If
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
        Me.SqlConnection1.Close()
    End Sub
    Sub Actualizar_Datos_Articulo()
        Try
            Dim Actualizar_Proveedores As String
            Me.SqlConnection1.Open()
            Actualizar_Proveedores = MsgBox("Esta seguro de Actualizar los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Guardar")
            If Actualizar_Proveedores = vbYes Then
                'Dim Actualizar_Datos_Litigio As String = ("UPDATE Solicitud SET Aprobo=@Aprobo,Reprobo=@Reprobo,No_presento=@No_presento,Motivo=@Motivo,Calificacion=@Calificacion,Fecha_Publicacion=@Fecha_Publicacion,Maestro_Revision=@Maestro_Revision,Fecha_Examen=@Fecha_Examen,Fecha_Sig_Oport=@Fecha_Sig_Oport,Fecha_Revision=@Fecha_Revision,Alumno_asistio_Modificacion=@Alumno_asistio_Modificacion,Alumno_Asistio_Acuerdo_NoModificacion=@Alumno_Asistio_Acuerdo_NoModificacion,Alumno_NoAsiste_Desacuerdo=@Alumno_NoAsiste_Desacuerdo,Observaciones=@Observaciones where Matricula= '" & TBMatricula.Text & "'" & "and solicitud.Periodo_Escolar = '" & Frm_Solicitud.CBPeriodo.Text & "'" & "and ID = '" & Frm_Solicitud.TBID.Text & "'")
                Dim Actualizar_Datos_Proveedores As String = ("UPDATE Articulo SET Codigo=@Codigo,Cve_Pro=@Cve_Pro,Cve_Art=@Cve_Art,Nombre_Art=@Nombre_Art,Cant_Art=@Cant_Art,Cant_Min=@Cant_Min,Precio_Articulo=@Precio_Articulo where Cve_Art= '" & TextBoxCveArticulo.Text & "'")
                Dim conex2 As New SqlClient.SqlCommand(Actualizar_Datos_Proveedores, Me.SqlConnection1)
                conex2.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.NVarChar, 20)).Value = Me.TextBoxCodigo.Text
                conex2.Parameters.Add(New SqlParameter("@Cve_Pro", SqlDbType.NVarChar, 2)).Value = Me.TextBoxCveProducto.Text()
                conex2.Parameters.Add(New SqlParameter("@Cve_Art", SqlDbType.NVarChar, 5)).Value = Me.TextBoxCveArticulo.Text
                conex2.Parameters.Add(New SqlParameter("@Nombre_Art", SqlDbType.NVarChar, 50)).Value = Me.TextBoxDescripcion.Text
                conex2.Parameters.Add(New SqlParameter("@Cant_Art", SqlDbType.Int, 5)).Value = Val(Me.TextBoxCantidadArticulo.Text)
                conex2.Parameters.Add(New SqlParameter("@Cant_Min", SqlDbType.Int, 5)).Value = Val(Me.TextBoxCantidadMinima.Text)
                conex2.Parameters.Add(New SqlParameter("@Precio_Articulo", SqlDbType.Int, 5)).Value = Val(Me.TextBoxPrecio.Text)
                'conex2.Parameters.Add(New SqlParameter("@Fecha_Activacion", SqlDbType.SmallDateTime)).Value = DateTimePicker1.Text
                conex2.CommandText = Actualizar_Datos_Proveedores
                conex2.ExecuteNonQuery()
                MsgBox("Datos Actualizados correctamente", , "Guardar")
            End If
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub consulta_articulos()
        Try
            Me.SqlConnection1.Open()
            If Seleccion <> "todos" And SW = 1 Then
                sqlbusqueda_articulo = "SELECT * FROM Articulo WHERE NOMBRE_ART LIKE'" & Seleccion & "'order by Nombre_Art"
            Else
                If Seleccion <> "todos" And SW = 2 Then
                    sqlbusqueda_articulo = "SELECT * FROM Articulo WHERE CVE_ART LIKE'" & Seleccion & "'order by Cve_art"
                Else
                    sqlbusqueda_articulo = "Select * FROM Articulo ORDER BY Cve_Art"
                End If
            End If
            order_bd = New SqlCommand(sqlbusqueda_articulo, Me.SqlConnection1)
            order_bd.CommandType = CommandType.Text
            order_bd.ExecuteNonQuery()
            d_adapter = New SqlDataAdapter(order_bd)
            d_table = New DataTable
            d_adapter.Fill(d_table)
            DataGridView1.DataSource = d_table
            If d_table.Rows.Count = 0 Then
                MsgBox("Articulo no existe")
                Me.SqlConnection1.Close()
                Call CargarDatos_articulo()
            End If
            'TextBoxCodigo.Text = d_table.Rows(0)("Codigo")
            If IsDBNull(d_table.Rows(0)("Codigo")) Then
                TextBoxCodigo.Text = " "
            Else
                TextBoxCodigo.Text = d_table.Rows(0)("Codigo")
            End If
            TextBoxCveArticulo.Text = d_table.Rows(0)("Cve_Art")
            TextBoxCveProducto.Text = d_table.Rows(0)("Cve_Pro")
            TextBoxDescripcion.Text = d_table.Rows(0)("Nombre_Art")
            If IsDBNull(d_table.Rows(0)("Cant_Art")) Then
                TextBoxCantidadArticulo.Text = " "
            Else
                TextBoxCantidadArticulo.Text = d_table.Rows(0)("Cant_Art")
            End If
            If IsDBNull(d_table.Rows(0)("Cant_Min")) Then
                TextBoxCantidadMinima.Text = " "
            Else
                TextBoxCantidadMinima.Text = d_table.Rows(0)("Cant_Min")
            End If
            If IsDBNull(d_table.Rows(0)("Precio_Articulo")) Then
                TextBoxPrecio.Text = " "
            Else
                TextBoxPrecio.Text = d_table.Rows(0)("Precio_Articulo")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlConnection1.Close()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Call Agregar_Articulo()
        Call CargarDatos_articulo()
        DataGridView1.Refresh()
        Call limpiar_datos_ARTICULO()
        Me.TextBoxCveArticulo.Focus()
    End Sub
    Sub limpiar_datos_ARTICULO()
        Me.TextBoxCodigo.Text = ""
        Me.TextBoxCveProducto.Text = ""
        Me.TextBoxCveArticulo.Text = ""
        Me.TextBoxDescripcion.Text = ""
        Me.TextBoxCantidadArticulo.Text = ""
        Me.TextBoxCantidadMinima.Text = ""
        Me.TextBoxCantidadArticulo.Text = ""
        Me.TextBoxPrecio.Text = ""
        'Me.DateTimePicker1.Text = ""
    End Sub
    Sub activar_datos_ARTICULO()
        Me.TextBoxCodigo.Enabled = True
        Me.TextBoxCveProducto.Enabled = True
        Me.TextBoxCveArticulo.Enabled = True
        Me.TextBoxDescripcion.Enabled = True
        Me.TextBoxCantidadArticulo.Enabled = True
        Me.TextBoxCantidadMinima.Enabled = True
        Me.TextBoxCantidadArticulo.Enabled = True
        Me.TextBoxPrecio.Enabled = True
    End Sub
    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Call CargarDatos_articulo()
        Call activar_datos_ARTICULO()
        Me.BtnGuardar.Enabled = True
        Me.BtnActualizar.Enabled = False
        Me.BtnEliminar.Enabled = False
        ' Me.TextBoxClaveProveedor.Enabled = True
        Call limpiar_datos_ARTICULO()
        TextBoxDescripcion.Focus()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Nombre_Art" Then
            SW = 1
        Else
            SW = 2
        End If
    End Sub

    Private Sub TextBoxBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxBuscar.TextChanged
        Seleccion = Me.TextBoxBuscar.Text
        Seleccion = "%" & Seleccion & "%"
        Call consulta_articulos()

        Me.BtnActualizar.Enabled = True
        Me.TextBoxCveProducto.Enabled = False
        Me.BtnGuardar.Enabled = False
    End Sub
    Private Sub BtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditar.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            'Call activar_datos_ARTICULO()
            'DateTimePicker1.Text = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(1).Value.ToString
            TextBoxCodigo.Text = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(0).Value.ToString
            TextBoxCveProducto.Text = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(1).Value.ToString
            TextBoxCveArticulo.Text = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(2).Value.ToString
            TextBoxDescripcion.Text = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(3).Value.ToString
            TextBoxCantidadArticulo.Text = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(4).Value.ToString
            TextBoxCantidadMinima.Text = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(5).Value.ToString
            TextBoxPrecio.Text = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(6).Value.ToString
            'DateTimePicker1.Text = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(7).Value.ToString
            editar = True
            roweditar = DataGridView1.SelectedRows(0).Index
            'ideditar = CInt(DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(0).Value)
            Call activar_datos_ARTICULO()
            BtnActualizar.Enabled = True
            BtnGuardar.Enabled = False
            BtnEliminar.Enabled = True
        Else
            MsgBox("No se ha seleccionado ningun Articulo")
        End If
    End Sub
    Private Sub BtnTODOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTODOS.Click
        Seleccion = "todos"
        Call CargarDatos_articulo()
        Me.BtnActualizar.Enabled = True
    End Sub
    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        Call Actualizar_Datos_Articulo()
        Call limpiar_datos_ARTICULO()
        Call CargarDatos_articulo()
        DataGridView1.Refresh()
        BtnEliminar.Enabled = False
        BtnActualizar.Enabled = False
        BtnGuardar.Enabled = False
        Me.TextBoxDescripcion.Focus()
    End Sub
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Try
            Dim elimina As String
            Me.SqlConnection1.Open()
            elimina = MsgBox("Esta seguro de ELIMINAR  los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Guardar")
            If elimina = vbYes Then
                'Dim insal As String = ("INSERT into talumno (matricula,nombre)" & "values(" & TBMatricula.Text & "," & TBNombre.Text & ",")
                Dim DEL_Proveedor As String = ("DELETE FROM Articulo WHERE Cve_Art ='" & TextBoxCveArticulo.Text & "'")
                Dim conex1 As New SqlClient.SqlCommand(DEL_Proveedor, Me.SqlConnection1)
                conex1.CommandText = DEL_Proveedor
                conex1.ExecuteNonQuery()
                MsgBox("Datos ELIMINADOS", , "Eliminar")
                Me.SqlConnection1.Close()
                Call CargarDatos_articulo()
                Call limpiar_datos_ARTICULO()
                BtnEliminar.Enabled = False
            Else
                Me.SqlConnection1.Close()
                'Call CargarDatos_proveedores()
            End If
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
End Class