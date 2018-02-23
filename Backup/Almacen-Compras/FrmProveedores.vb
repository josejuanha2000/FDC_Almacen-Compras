Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Text
Public Class FrmProveedores
    Private Sub FrmProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarDatos_proveedores()
    End Sub
    Dim editar As Boolean = False
    Dim roweditar As Integer
    Dim ideditar As Integer
    Dim sqlbusqueda_proveedores As String
    Public order_bd As SqlCommand
    Private d_table As DataTable
    Private d_adapter As SqlDataAdapter
    Public Seleccion As String
    Dim SW As Integer = 0
    Sub Agregar_Proveedor()
        Dim agregardatos_Proveedor As String
        agregardatos_Proveedor = MsgBox("Esta seguro de Guardar los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Guardar")
        Try
            If agregardatos_Proveedor = vbYes Then
                Me.SqlConnection1.Open()
                Dim Insdatos_proveedor As String = "INSERT INTO Proveedores (Cve_Proveedor,Nombre_Proveedor,Giro_Empresa,Contacto,Cargo_Contacto,Direccion,Telefono,Fax,Fecha_Activacion) values(@Cve_Proveedor,@Nombre_Proveedor,@Giro_Empresa,@Contacto,@Cargo_Contacto,@Direccion,@Telefono,@Fax,@Fecha_Activacion)"
                'Dim Insdatosa As String = "INSERT INTO Litigio (Nombre_Solicitante_L) values(@Nombre_Solicitante_L)"
                Dim conex1 As New SqlClient.SqlCommand(Insdatos_proveedor, Me.SqlConnection1)
                conex1.Parameters.Add(New SqlParameter("@Cve_Proveedor", SqlDbType.NVarChar, 10)).Value = Me.TextBoxClaveProveedor.Text
                conex1.Parameters.Add(New SqlParameter("@Nombre_Proveedor", SqlDbType.NVarChar, 50)).Value = Me.TextBoxNombreProveedor.Text
                conex1.Parameters.Add(New SqlParameter("@Giro_Empresa", SqlDbType.NVarChar, 50)).Value = Me.TextBoxGiroEmpresa.Text
                conex1.Parameters.Add(New SqlParameter("@Contacto", SqlDbType.NVarChar, 50)).Value = Me.TextBoxContacto.Text
                conex1.Parameters.Add(New SqlParameter("@Cargo_Contacto", SqlDbType.NVarChar, 50)).Value = Me.TextBoxCargoContacto.Text
                conex1.Parameters.Add(New SqlParameter("@Direccion", SqlDbType.NVarChar, 50)).Value = Me.TextBoxDireccion.Text
                conex1.Parameters.Add(New SqlParameter("@Telefono", SqlDbType.NVarChar, 50)).Value = Me.TextBoxTelefono.Text
                conex1.Parameters.Add(New SqlParameter("@Fax", SqlDbType.NVarChar, 50)).Value = Me.TextBoxFax.Text
                conex1.Parameters.Add(New SqlParameter("@Fecha_Activacion", SqlDbType.SmallDateTime)).Value = DateTimePicker1.Text
                conex1.CommandText = Insdatos_proveedor
                conex1.ExecuteNonQuery()
                MsgBox("Datos guardados correctamente", , "Guardar")
            End If
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
        Me.SqlConnection1.Close()
    End Sub
    Sub Actualizar_Datos_Proveedores()
        Try
            Dim Actualizar_Proveedores As String
            Me.SqlConnection1.Open()
            Actualizar_Proveedores = MsgBox("Esta seguro de Actualizar los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Guardar")
            If Actualizar_Proveedores = vbYes Then
                'Dim Actualizar_Datos_Litigio As String = ("UPDATE Solicitud SET Aprobo=@Aprobo,Reprobo=@Reprobo,No_presento=@No_presento,Motivo=@Motivo,Calificacion=@Calificacion,Fecha_Publicacion=@Fecha_Publicacion,Maestro_Revision=@Maestro_Revision,Fecha_Examen=@Fecha_Examen,Fecha_Sig_Oport=@Fecha_Sig_Oport,Fecha_Revision=@Fecha_Revision,Alumno_asistio_Modificacion=@Alumno_asistio_Modificacion,Alumno_Asistio_Acuerdo_NoModificacion=@Alumno_Asistio_Acuerdo_NoModificacion,Alumno_NoAsiste_Desacuerdo=@Alumno_NoAsiste_Desacuerdo,Observaciones=@Observaciones where Matricula= '" & TBMatricula.Text & "'" & "and solicitud.Periodo_Escolar = '" & Frm_Solicitud.CBPeriodo.Text & "'" & "and ID = '" & Frm_Solicitud.TBID.Text & "'")
                Dim Actualizar_Datos_Proveedores As String = ("UPDATE Proveedores SET Nombre_Proveedor=@Nombre_Proveedor,Giro_Empresa=@Giro_Empresa,Contacto=@Contacto,Cargo_Contacto=@Cargo_Contacto,Direccion=@Direccion,Telefono=@Telefono,Fax=@Fax,Fecha_Activacion=@Fecha_Activacion where Cve_Proveedor= '" & TextBoxClaveProveedor.Text & "'")
                Dim conex2 As New SqlClient.SqlCommand(Actualizar_Datos_Proveedores, Me.SqlConnection1)
                conex2.Parameters.Add(New SqlParameter("@Nombre_Proveedor", SqlDbType.NVarChar, 50)).Value = Me.TextBoxNombreProveedor.Text
                conex2.Parameters.Add(New SqlParameter("@Giro_Empresa", SqlDbType.NVarChar, 50)).Value = Me.TextBoxGiroEmpresa.Text
                conex2.Parameters.Add(New SqlParameter("@Contacto", SqlDbType.NVarChar, 50)).Value = Me.TextBoxContacto.Text
                conex2.Parameters.Add(New SqlParameter("@Cargo_Contacto", SqlDbType.NVarChar, 50)).Value = Me.TextBoxCargoContacto.Text
                conex2.Parameters.Add(New SqlParameter("@Direccion", SqlDbType.NVarChar, 50)).Value = Me.TextBoxDireccion.Text
                conex2.Parameters.Add(New SqlParameter("@Telefono", SqlDbType.NVarChar, 50)).Value = Me.TextBoxTelefono.Text
                conex2.Parameters.Add(New SqlParameter("@Fax", SqlDbType.NVarChar, 50)).Value = Me.TextBoxFax.Text
                conex2.Parameters.Add(New SqlParameter("@Fecha_Activacion", SqlDbType.SmallDateTime)).Value = DateTimePicker1.Text
                conex2.CommandText = Actualizar_Datos_Proveedores
                conex2.ExecuteNonQuery()
                MsgBox("Datos Actualizados correctamente", , "Guardar")
            End If
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub consulta_proveedores()
        Try
            Me.SqlConnection1.Open()
            'sqlbusqueda_proveedores = ("SELECT * FROM Mediacion WHERE Mediacion.Folio_Mediacion = '" & Me.CBFolio_Mediacion.Text & "'")
            'sqlbusqueda_proveedores = ("SELECT * FROM Proveedores order by Nombre_Proveedor ")
            If Seleccion <> "todos" And SW = 1 Then
                'sqlbusqueda_proveedores = "SELECT * FROM Proveedores WHERE" & ComboBox1.Text & "LIKE'" & Seleccion & "'order by Cve_Proveedor"
                'sqlbusqueda_proveedores = "SELECT * FROM Proveedores WHERE " & ComboBox1.Text & "LIKE'" & "%MICRO%" & "'order by Cve_Proveedor"
                sqlbusqueda_proveedores = "SELECT * FROM Proveedores WHERE NOMBRE_PROVEEDOR LIKE'" & Seleccion & "'order by Nombre_Proveedor"
            Else
                If Seleccion <> "todos" And SW = 2 Then
                    sqlbusqueda_proveedores = "SELECT * FROM Proveedores WHERE CVE_PROVEEDOR LIKE'" & Seleccion & "'order by cve_proveedor"
                Else
                    sqlbusqueda_proveedores = "Select * FROM Proveedores ORDER BY Cve_Proveedor"
                    ''sqlbusqueda_proveedores = "SELECT * FROM Proveedores WHERE NOMBRE_PROVEEDOR LIKE'" & "%MICRO%" & "'order by Cve_Proveedor"
                End If
            End If
            order_bd = New SqlCommand(sqlbusqueda_proveedores, Me.SqlConnection1)
            order_bd.CommandType = CommandType.Text
            order_bd.ExecuteNonQuery()
            d_adapter = New SqlDataAdapter(order_bd)
            d_table = New DataTable
            d_adapter.Fill(d_table)
            DataGridView1.DataSource = d_table
            If d_table.Rows.Count = 0 Then
                MsgBox("Proveedor no existe")
                Me.SqlConnection1.Close()
                Call CargarDatos_proveedores()
            End If
            TextBoxClaveProveedor.Text = d_table.Rows(0)("Cve_Proveedor")
            TextBoxNombreProveedor.Text = d_table.Rows(0)("Nombre_Proveedor")
            TextBoxGiroEmpresa.Text = d_table.Rows(0)("Giro_Empresa")
            If IsDBNull(d_table.Rows(0)("Contacto")) Then
                TextBoxContacto.Text = " "
            Else
                TextBoxContacto.Text = d_table.Rows(0)("Contacto")
            End If
            If IsDBNull(d_table.Rows(0)("Cargo_Contacto")) Then
                TextBoxCargoContacto.Text = " "
            Else
                TextBoxCargoContacto.Text = d_table.Rows(0)("Cargo_Contacto")
            End If
            If IsDBNull(d_table.Rows(0)("Direccion")) Then
                TextBoxDireccion.Text = " "
            Else
                TextBoxDireccion.Text = d_table.Rows(0)("Direccion")
            End If
            If IsDBNull(d_table.Rows(0)("Telefono")) Then
                TextBoxTelefono.Text = " "
            Else
                TextBoxTelefono.Text = d_table.Rows(0)("Telefono")
            End If
            If IsDBNull(d_table.Rows(0)("Fax")) Then
                TextBoxFax.Text = " "
            Else
                TextBoxFax.Text = d_table.Rows(0)("Fax")
            End If
            If IsDBNull(d_table.Rows(0)("Fecha_Activacion")) Then
                DateTimePicker1.Text = TimeOfDay
            Else
                DateTimePicker1.Text = d_table.Rows(0)("Fecha_Activacion")
            End If
            'TextBoxContacto.Text = d_table.Rows(0)("Contacto")
            'TextBoxCargoContacto.Text = d_table.Rows(0)("Cargo_Contacto")
            'TextBoxDireccion.Text = d_table.Rows(0)("Direccion")
            'TextBoxTelefono.Text = d_table.Rows(0)("Telefono")
            'TextBoxGiroEmpresa.Text = d_table.Rows(0)("Fax")
            'DateTimePicker1.Text = d_table.Rows(0)("Fecha_Activacion")
            ''TextBoxNombreEmpresa.Text = d_table.Rows(0)("Observaciones")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlConnection1.Close()
    End Sub
    Sub CargarDatos_proveedores()
        Me.SqlConnection1.Open()
        'sqlbusqueda_proveedores = ("SELECT * FROM Mediacion WHERE Mediacion.Folio_Mediacion = '" & Me.CBFolio_Mediacion.Text & "'")
        sqlbusqueda_proveedores = ("SELECT * FROM Proveedores order by Nombre_Proveedor ")
        order_bd = New SqlCommand(sqlbusqueda_proveedores, Me.SqlConnection1)
        order_bd.CommandType = CommandType.Text
        order_bd.ExecuteNonQuery()
        d_adapter = New SqlDataAdapter(order_bd)
        d_table = New DataTable
        d_adapter.Fill(d_table)
        DataGridView1.DataSource = d_table
        Me.SqlConnection1.Close()
    End Sub
    Private Sub TextBoxBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxBuscar.TextChanged
        Seleccion = Me.TextBoxBuscar.Text
        Seleccion = "%" & Seleccion & "%"
        Call consulta_proveedores()
        Me.BtnActualizar.Enabled = True
        Me.TextBoxClaveProveedor.Enabled = False
        Me.BtnGuardar.Enabled = False
    End Sub
    Private Sub BtnTODOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTODOS.Click
        Seleccion = "todos"
        Call CargarDatos_proveedores()
        Me.BtnActualizar.Enabled = True
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Nombre_Proveedor" Then
            SW = 1
        Else
            SW = 2
        End If
    End Sub
    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Call CargarDatos_proveedores()
        Me.BtnGuardar.Enabled = True
        Me.BtnActualizar.Enabled = False
        Me.TextBoxClaveProveedor.Enabled = True
        Call limpiar_datos_provedores()
        TextBoxClaveProveedor.Focus()
    End Sub
    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Call Agregar_Proveedor()
        DataGridView1.Refresh()
        Call limpiar_datos_provedores()
        Me.TextBoxClaveProveedor.Focus()
        'Me.BtnActualizar.Enabled = True
    End Sub
    Sub limpiar_datos_provedores()
        Me.TextBoxClaveProveedor.Text = ""
        Me.TextBoxNombreProveedor.Text = ""
        Me.TextBoxGiroEmpresa.Text = ""
        Me.TextBoxContacto.Text = ""
        Me.TextBoxCargoContacto.Text = ""
        Me.TextBoxDireccion.Text = ""
        Me.TextBoxTelefono.Text = ""
        Me.TextBoxFax.Text = ""
        Me.DateTimePicker1.Text = ""
    End Sub
    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        Call Actualizar_Datos_Proveedores()
        Call limpiar_datos_provedores()
        DataGridView1.Refresh()
        Me.TextBoxClaveProveedor.Focus()
    End Sub

    Private Sub BtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditar.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            'DateTimePicker1.Text = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(1).Value.ToString
            TextBoxClaveProveedor.Text = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(0).Value.ToString
            TextBoxNombreProveedor.Text = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(1).Value.ToString
            TextBoxGiroEmpresa.Text = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(2).Value.ToString
            TextBoxContacto.Text = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(3).Value.ToString
            TextBoxCargoContacto.Text = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(4).Value.ToString
            TextBoxDireccion.Text = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(5).Value.ToString
            TextBoxTelefono.Text = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(6).Value.ToString
            TextBoxFax.Text = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(7).Value.ToString
            DateTimePicker1.Text = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(8).Value.ToString
            Editar = True
            roweditar = DataGridView1.SelectedRows(0).Index
            'ideditar = CInt(DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(0).Value)
            BtnActualizar.Enabled = True
            BtnGuardar.Enabled = False
        Else
            MsgBox("No se ha seleccionado ningun contacto")
        End If
    End Sub
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Try
            Dim elimina As String
            Me.SqlConnection1.Open()
            elimina = MsgBox("Esta seguro de ELIMINAR  los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Guardar")
            If elimina = vbYes Then
                'Dim insal As String = ("INSERT into talumno (matricula,nombre)" & "values(" & TBMatricula.Text & "," & TBNombre.Text & ",")
                Dim DEL_Proveedor As String = ("DELETE FROM Proveedores WHERE Cve_Proveedor =" & TextBoxClaveProveedor.Text)
                Dim conex1 As New SqlClient.SqlCommand(DEL_Proveedor, Me.SqlConnection1)
                conex1.CommandText = DEL_Proveedor
                conex1.ExecuteNonQuery()
                MsgBox("Datos ELIMINADOS", , "Eliminar")
                Me.SqlConnection1.Close()
                Call CargarDatos_proveedores()
                Call limpiar_datos_provedores()
                'Call cargar()
            Else
                Me.SqlConnection1.Close()
                'Call CargarDatos_proveedores()
            End If
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
        'TextBoxClaveProveedor.Focus()
    End Sub
End Class
