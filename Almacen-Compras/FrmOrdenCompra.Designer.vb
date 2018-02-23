<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrdenCompra
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_FolioReq = New System.Windows.Forms.TextBox()
        Me.TB_Departamento = New System.Windows.Forms.TextBox()
        Me.TB_Titular = New System.Windows.Forms.TextBox()
        Me.DateTimePickerFechaRegistroReq = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TB_NoCompra = New System.Windows.Forms.TextBox()
        Me.TB_NoFactura = New System.Windows.Forms.TextBox()
        Me.TB_PrecioUnitario = New System.Windows.Forms.TextBox()
        Me.TB_Total_Cantidad = New System.Windows.Forms.TextBox()
        Me.TB_Total_IVA = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TB_SubTotal_General = New System.Windows.Forms.TextBox()
        Me.TB_Total_General_Iva = New System.Windows.Forms.TextBox()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.TB_Cantidad_Articulos = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Btn_Editar = New System.Windows.Forms.Button()
        Me.CB_Entrega = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Btn_Actualizar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TB_Activo = New System.Windows.Forms.TextBox()
        Me.CB_IVA = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.CB_NombreProveedor = New System.Windows.Forms.ComboBox()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALMACENDataSet = New Almacen_Compras.ALMACENDataSet()
        Me.TB_Direccion = New System.Windows.Forms.TextBox()
        Me.TB_Telefono = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ProveedoresTableAdapter = New Almacen_Compras.ALMACENDataSetTableAdapters.ProveedoresTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALMACENDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Folio Req:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(264, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Departamento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(552, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Titular:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(753, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha de Registro:"
        '
        'TB_FolioReq
        '
        Me.TB_FolioReq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_FolioReq.Location = New System.Drawing.Point(27, 64)
        Me.TB_FolioReq.Name = "TB_FolioReq"
        Me.TB_FolioReq.Size = New System.Drawing.Size(100, 20)
        Me.TB_FolioReq.TabIndex = 4
        '
        'TB_Departamento
        '
        Me.TB_Departamento.Enabled = False
        Me.TB_Departamento.Location = New System.Drawing.Point(196, 63)
        Me.TB_Departamento.Name = "TB_Departamento"
        Me.TB_Departamento.Size = New System.Drawing.Size(240, 20)
        Me.TB_Departamento.TabIndex = 5
        '
        'TB_Titular
        '
        Me.TB_Titular.Enabled = False
        Me.TB_Titular.Location = New System.Drawing.Point(442, 63)
        Me.TB_Titular.Name = "TB_Titular"
        Me.TB_Titular.Size = New System.Drawing.Size(252, 20)
        Me.TB_Titular.TabIndex = 6
        '
        'DateTimePickerFechaRegistroReq
        '
        Me.DateTimePickerFechaRegistroReq.Enabled = False
        Me.DateTimePickerFechaRegistroReq.Location = New System.Drawing.Point(709, 63)
        Me.DateTimePickerFechaRegistroReq.Name = "DateTimePickerFechaRegistroReq"
        Me.DateTimePickerFechaRegistroReq.Size = New System.Drawing.Size(228, 20)
        Me.DateTimePickerFechaRegistroReq.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(209, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "No de compra:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(104, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "No de Fac:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(486, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Precio Uni:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(719, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 15)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Iva:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(601, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 15)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Total:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(790, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 15)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Total+Iva"
        '
        'TB_NoCompra
        '
        Me.TB_NoCompra.Location = New System.Drawing.Point(210, 126)
        Me.TB_NoCompra.Name = "TB_NoCompra"
        Me.TB_NoCompra.Size = New System.Drawing.Size(100, 20)
        Me.TB_NoCompra.TabIndex = 9
        '
        'TB_NoFactura
        '
        Me.TB_NoFactura.Location = New System.Drawing.Point(93, 126)
        Me.TB_NoFactura.Name = "TB_NoFactura"
        Me.TB_NoFactura.Size = New System.Drawing.Size(100, 20)
        Me.TB_NoFactura.TabIndex = 8
        '
        'TB_PrecioUnitario
        '
        Me.TB_PrecioUnitario.Location = New System.Drawing.Point(475, 126)
        Me.TB_PrecioUnitario.Name = "TB_PrecioUnitario"
        Me.TB_PrecioUnitario.Size = New System.Drawing.Size(100, 20)
        Me.TB_PrecioUnitario.TabIndex = 11
        '
        'TB_Total_Cantidad
        '
        Me.TB_Total_Cantidad.Enabled = False
        Me.TB_Total_Cantidad.Location = New System.Drawing.Point(579, 126)
        Me.TB_Total_Cantidad.Name = "TB_Total_Cantidad"
        Me.TB_Total_Cantidad.Size = New System.Drawing.Size(100, 20)
        Me.TB_Total_Cantidad.TabIndex = 12
        '
        'TB_Total_IVA
        '
        Me.TB_Total_IVA.Location = New System.Drawing.Point(777, 126)
        Me.TB_Total_IVA.Name = "TB_Total_IVA"
        Me.TB_Total_IVA.Size = New System.Drawing.Size(100, 20)
        Me.TB_Total_IVA.TabIndex = 14
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 152)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(953, 319)
        Me.DataGridView1.TabIndex = 20
        '
        'TB_SubTotal_General
        '
        Me.TB_SubTotal_General.Enabled = False
        Me.TB_SubTotal_General.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_SubTotal_General.Location = New System.Drawing.Point(626, 477)
        Me.TB_SubTotal_General.Multiline = True
        Me.TB_SubTotal_General.Name = "TB_SubTotal_General"
        Me.TB_SubTotal_General.Size = New System.Drawing.Size(100, 28)
        Me.TB_SubTotal_General.TabIndex = 15
        '
        'TB_Total_General_Iva
        '
        Me.TB_Total_General_Iva.Enabled = False
        Me.TB_Total_General_Iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Total_General_Iva.Location = New System.Drawing.Point(856, 477)
        Me.TB_Total_General_Iva.Multiline = True
        Me.TB_Total_General_Iva.Name = "TB_Total_General_Iva"
        Me.TB_Total_General_Iva.Size = New System.Drawing.Size(100, 28)
        Me.TB_Total_General_Iva.TabIndex = 16
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=COLMASQLFDC01\FACDYCDES;Initial Catalog=ALMACEN;Integrated Security=T" & _
    "rue"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'BtnMostrar
        '
        Me.BtnMostrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BtnMostrar.Location = New System.Drawing.Point(133, 63)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(47, 23)
        Me.BtnMostrar.TabIndex = 23
        Me.BtnMostrar.Text = "Mostrar"
        Me.BtnMostrar.UseVisualStyleBackColor = False
        '
        'TB_Cantidad_Articulos
        '
        Me.TB_Cantidad_Articulos.Location = New System.Drawing.Point(402, 126)
        Me.TB_Cantidad_Articulos.Name = "TB_Cantidad_Articulos"
        Me.TB_Cantidad_Articulos.Size = New System.Drawing.Size(67, 20)
        Me.TB_Cantidad_Articulos.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(401, 108)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 15)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Cantidad:"
        '
        'Btn_Editar
        '
        Me.Btn_Editar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btn_Editar.Location = New System.Drawing.Point(39, 477)
        Me.Btn_Editar.Name = "Btn_Editar"
        Me.Btn_Editar.Size = New System.Drawing.Size(88, 37)
        Me.Btn_Editar.TabIndex = 26
        Me.Btn_Editar.Text = "Editar"
        Me.Btn_Editar.UseVisualStyleBackColor = False
        '
        'CB_Entrega
        '
        Me.CB_Entrega.FormattingEnabled = True
        Me.CB_Entrega.Items.AddRange(New Object() {"S", "N"})
        Me.CB_Entrega.Location = New System.Drawing.Point(907, 125)
        Me.CB_Entrega.Name = "CB_Entrega"
        Me.CB_Entrega.Size = New System.Drawing.Size(49, 21)
        Me.CB_Entrega.TabIndex = 27
        Me.CB_Entrega.Text = "S"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(904, 107)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 15)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Entrega:"
        '
        'Btn_Actualizar
        '
        Me.Btn_Actualizar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Btn_Actualizar.Location = New System.Drawing.Point(210, 478)
        Me.Btn_Actualizar.Name = "Btn_Actualizar"
        Me.Btn_Actualizar.Size = New System.Drawing.Size(88, 36)
        Me.Btn_Actualizar.TabIndex = 29
        Me.Btn_Actualizar.Text = "Actualizar"
        Me.Btn_Actualizar.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(24, 107)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 15)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Activo:"
        '
        'TB_Activo
        '
        Me.TB_Activo.Enabled = False
        Me.TB_Activo.Location = New System.Drawing.Point(25, 125)
        Me.TB_Activo.Name = "TB_Activo"
        Me.TB_Activo.Size = New System.Drawing.Size(38, 20)
        Me.TB_Activo.TabIndex = 30
        '
        'CB_IVA
        '
        Me.CB_IVA.FormattingEnabled = True
        Me.CB_IVA.Items.AddRange(New Object() {"16", "15", "14", "13", "12", "11", "10", "09", "08", "07", "06", "05", "04", "03", ".02", ".01", ".00"})
        Me.CB_IVA.Location = New System.Drawing.Point(701, 126)
        Me.CB_IVA.Name = "CB_IVA"
        Me.CB_IVA.Size = New System.Drawing.Size(63, 21)
        Me.CB_IVA.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(531, 483)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 15)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Sub-Total :  $"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(740, 482)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(114, 15)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Total General:  $"
        '
        'BtnImprimir
        '
        Me.BtnImprimir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnImprimir.Location = New System.Drawing.Point(722, 633)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(126, 48)
        Me.BtnImprimir.TabIndex = 34
        Me.BtnImprimir.Text = "Generar Orden de Compra"
        Me.BtnImprimir.UseVisualStyleBackColor = False
        '
        'CB_NombreProveedor
        '
        Me.CB_NombreProveedor.DataSource = Me.ProveedoresBindingSource
        Me.CB_NombreProveedor.DisplayMember = "Nombre_Proveedor"
        Me.CB_NombreProveedor.FormattingEnabled = True
        Me.CB_NombreProveedor.Location = New System.Drawing.Point(146, 554)
        Me.CB_NombreProveedor.Name = "CB_NombreProveedor"
        Me.CB_NombreProveedor.Size = New System.Drawing.Size(480, 21)
        Me.CB_NombreProveedor.TabIndex = 35
        Me.CB_NombreProveedor.ValueMember = "Nombre_Proveedor"
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "Proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.ALMACENDataSet
        '
        'ALMACENDataSet
        '
        Me.ALMACENDataSet.DataSetName = "ALMACENDataSet"
        Me.ALMACENDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TB_Direccion
        '
        Me.TB_Direccion.Enabled = False
        Me.TB_Direccion.Location = New System.Drawing.Point(146, 581)
        Me.TB_Direccion.Name = "TB_Direccion"
        Me.TB_Direccion.Size = New System.Drawing.Size(480, 20)
        Me.TB_Direccion.TabIndex = 36
        '
        'TB_Telefono
        '
        Me.TB_Telefono.Enabled = False
        Me.TB_Telefono.Location = New System.Drawing.Point(146, 607)
        Me.TB_Telefono.Name = "TB_Telefono"
        Me.TB_Telefono.Size = New System.Drawing.Size(293, 20)
        Me.TB_Telefono.TabIndex = 37
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(41, 557)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(99, 13)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "Nombre Proveedor:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(84, 585)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 13)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "Dirección:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(86, 610)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 13)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "Telefono:"
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'FrmOrdenCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(1014, 693)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TB_Telefono)
        Me.Controls.Add(Me.TB_Direccion)
        Me.Controls.Add(Me.CB_NombreProveedor)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.CB_IVA)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TB_Activo)
        Me.Controls.Add(Me.Btn_Actualizar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.CB_Entrega)
        Me.Controls.Add(Me.Btn_Editar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TB_Cantidad_Articulos)
        Me.Controls.Add(Me.BtnMostrar)
        Me.Controls.Add(Me.TB_Total_General_Iva)
        Me.Controls.Add(Me.TB_SubTotal_General)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TB_Total_IVA)
        Me.Controls.Add(Me.TB_Total_Cantidad)
        Me.Controls.Add(Me.TB_PrecioUnitario)
        Me.Controls.Add(Me.TB_NoFactura)
        Me.Controls.Add(Me.TB_NoCompra)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateTimePickerFechaRegistroReq)
        Me.Controls.Add(Me.TB_Titular)
        Me.Controls.Add(Me.TB_Departamento)
        Me.Controls.Add(Me.TB_FolioReq)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmOrdenCompra"
        Me.Text = "Orden de Compra"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALMACENDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TB_FolioReq As System.Windows.Forms.TextBox
    Friend WithEvents TB_Departamento As System.Windows.Forms.TextBox
    Friend WithEvents TB_Titular As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePickerFechaRegistroReq As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TB_NoCompra As System.Windows.Forms.TextBox
    Friend WithEvents TB_NoFactura As System.Windows.Forms.TextBox
    Friend WithEvents TB_PrecioUnitario As System.Windows.Forms.TextBox
    Friend WithEvents TB_Total_Cantidad As System.Windows.Forms.TextBox
    Friend WithEvents TB_Total_IVA As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TB_SubTotal_General As System.Windows.Forms.TextBox
    Friend WithEvents TB_Total_General_Iva As System.Windows.Forms.TextBox
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents BtnMostrar As System.Windows.Forms.Button
    Friend WithEvents TB_Cantidad_Articulos As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Btn_Editar As System.Windows.Forms.Button
    Friend WithEvents CB_Entrega As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Btn_Actualizar As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TB_Activo As System.Windows.Forms.TextBox
    Friend WithEvents CB_IVA As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents BtnImprimir As System.Windows.Forms.Button
    Friend WithEvents CB_NombreProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents TB_Direccion As System.Windows.Forms.TextBox
    Friend WithEvents TB_Telefono As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents ALMACENDataSet As Almacen_Compras.ALMACENDataSet
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresTableAdapter As Almacen_Compras.ALMACENDataSetTableAdapters.ProveedoresTableAdapter
End Class
