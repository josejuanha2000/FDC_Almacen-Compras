<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGenera_Orden_Compra
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
        Me.components = New System.ComponentModel.Container
        Me.BtnMostrar = New System.Windows.Forms.Button
        Me.TB_Orden_Compra = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.TB_Telefono = New System.Windows.Forms.TextBox
        Me.TB_Direccion = New System.Windows.Forms.TextBox
        Me.CB_NombreProveedor = New System.Windows.Forms.ComboBox
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALMACENDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALMACENDataSet = New Almacen_Compras.ALMACENDataSet
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.BtnImprimir = New System.Windows.Forms.Button
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.ProveedoresTableAdapter = New Almacen_Compras.ALMACENDataSetTableAdapters.ProveedoresTableAdapter
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALMACENDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALMACENDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnMostrar
        '
        Me.BtnMostrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BtnMostrar.Location = New System.Drawing.Point(160, 35)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(47, 23)
        Me.BtnMostrar.TabIndex = 26
        Me.BtnMostrar.Text = "Mostrar"
        Me.BtnMostrar.UseVisualStyleBackColor = False
        '
        'TB_Orden_Compra
        '
        Me.TB_Orden_Compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Orden_Compra.Location = New System.Drawing.Point(54, 35)
        Me.TB_Orden_Compra.Name = "TB_Orden_Compra"
        Me.TB_Orden_Compra.Size = New System.Drawing.Size(100, 20)
        Me.TB_Orden_Compra.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 15)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Orden de Compra" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(81, 136)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 13)
        Me.Label18.TabIndex = 46
        Me.Label18.Text = "Telefono:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(79, 111)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 13)
        Me.Label17.TabIndex = 45
        Me.Label17.Text = "Dirección:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(36, 83)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(99, 13)
        Me.Label16.TabIndex = 44
        Me.Label16.Text = "Nombre Proveedor:"
        '
        'TB_Telefono
        '
        Me.TB_Telefono.Enabled = False
        Me.TB_Telefono.Location = New System.Drawing.Point(141, 133)
        Me.TB_Telefono.Name = "TB_Telefono"
        Me.TB_Telefono.Size = New System.Drawing.Size(293, 20)
        Me.TB_Telefono.TabIndex = 43
        '
        'TB_Direccion
        '
        Me.TB_Direccion.Enabled = False
        Me.TB_Direccion.Location = New System.Drawing.Point(141, 107)
        Me.TB_Direccion.Name = "TB_Direccion"
        Me.TB_Direccion.Size = New System.Drawing.Size(480, 20)
        Me.TB_Direccion.TabIndex = 42
        '
        'CB_NombreProveedor
        '
        Me.CB_NombreProveedor.DataSource = Me.ProveedoresBindingSource
        Me.CB_NombreProveedor.DisplayMember = "Nombre_Proveedor"
        Me.CB_NombreProveedor.FormattingEnabled = True
        Me.CB_NombreProveedor.Location = New System.Drawing.Point(141, 80)
        Me.CB_NombreProveedor.MaxDropDownItems = 20
        Me.CB_NombreProveedor.Name = "CB_NombreProveedor"
        Me.CB_NombreProveedor.Size = New System.Drawing.Size(480, 21)
        Me.CB_NombreProveedor.TabIndex = 41
        Me.CB_NombreProveedor.ValueMember = "Nombre_Proveedor"
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "Proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.ALMACENDataSetBindingSource
        '
        'ALMACENDataSetBindingSource
        '
        Me.ALMACENDataSetBindingSource.DataSource = Me.ALMACENDataSet
        Me.ALMACENDataSetBindingSource.Position = 0
        '
        'ALMACENDataSet
        '
        Me.ALMACENDataSet.DataSetName = "ALMACENDataSet"
        Me.ALMACENDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(35, 183)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(586, 220)
        Me.DataGridView1.TabIndex = 47
        '
        'BtnImprimir
        '
        Me.BtnImprimir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnImprimir.Location = New System.Drawing.Point(247, 429)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(126, 48)
        Me.BtnImprimir.TabIndex = 48
        Me.BtnImprimir.Text = "Generar Orden de Compra"
        Me.BtnImprimir.UseVisualStyleBackColor = False
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=COLMASQLFDC01\FACDYCDES;Initial Catalog=ALMACEN;Integrated Security=T" & _
            "rue"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'FrmGenera_Orden_Compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 521)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TB_Telefono)
        Me.Controls.Add(Me.TB_Direccion)
        Me.Controls.Add(Me.CB_NombreProveedor)
        Me.Controls.Add(Me.BtnMostrar)
        Me.Controls.Add(Me.TB_Orden_Compra)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmGenera_Orden_Compra"
        Me.Text = "FrmGenera_Orden_Compra"
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALMACENDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALMACENDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnMostrar As System.Windows.Forms.Button
    Friend WithEvents TB_Orden_Compra As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TB_Telefono As System.Windows.Forms.TextBox
    Friend WithEvents TB_Direccion As System.Windows.Forms.TextBox
    Friend WithEvents CB_NombreProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BtnImprimir As System.Windows.Forms.Button
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents ALMACENDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ALMACENDataSet As Almacen_Compras.ALMACENDataSet
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresTableAdapter As Almacen_Compras.ALMACENDataSetTableAdapters.ProveedoresTableAdapter
End Class
