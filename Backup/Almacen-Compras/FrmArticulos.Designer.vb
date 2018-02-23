<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArticulos
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
        Me.CBProducto = New System.Windows.Forms.ComboBox
        Me.LabelProducto = New System.Windows.Forms.Label
        Me.TextBoxCodigo = New System.Windows.Forms.TextBox
        Me.TextBoxCveProducto = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBoxDescripcion = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBoxCveArticulo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBoxCantidadArticulo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBoxCantidadMinima = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBoxPrecio = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.BtnEliminar = New System.Windows.Forms.Button
        Me.BtnEditar = New System.Windows.Forms.Button
        Me.BtnNuevo = New System.Windows.Forms.Button
        Me.BtnActualizar = New System.Windows.Forms.Button
        Me.BtnGuardar = New System.Windows.Forms.Button
        Me.BtnTODOS = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'CBProducto
        '
        Me.CBProducto.FormattingEnabled = True
        Me.CBProducto.Location = New System.Drawing.Point(28, 31)
        Me.CBProducto.Name = "CBProducto"
        Me.CBProducto.Size = New System.Drawing.Size(246, 21)
        Me.CBProducto.TabIndex = 0
        '
        'LabelProducto
        '
        Me.LabelProducto.AutoSize = True
        Me.LabelProducto.Location = New System.Drawing.Point(88, 126)
        Me.LabelProducto.Name = "LabelProducto"
        Me.LabelProducto.Size = New System.Drawing.Size(43, 13)
        Me.LabelProducto.TabIndex = 1
        Me.LabelProducto.Text = "Codigo:"
        '
        'TextBoxCodigo
        '
        Me.TextBoxCodigo.Enabled = False
        Me.TextBoxCodigo.Location = New System.Drawing.Point(143, 123)
        Me.TextBoxCodigo.Name = "TextBoxCodigo"
        Me.TextBoxCodigo.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxCodigo.TabIndex = 2
        '
        'TextBoxCveProducto
        '
        Me.TextBoxCveProducto.Enabled = False
        Me.TextBoxCveProducto.Location = New System.Drawing.Point(143, 152)
        Me.TextBoxCveProducto.Name = "TextBoxCveProducto"
        Me.TextBoxCveProducto.Size = New System.Drawing.Size(92, 20)
        Me.TextBoxCveProducto.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Clave Productos:"
        '
        'TextBoxDescripcion
        '
        Me.TextBoxDescripcion.Enabled = False
        Me.TextBoxDescripcion.Location = New System.Drawing.Point(143, 215)
        Me.TextBoxDescripcion.Name = "TextBoxDescripcion"
        Me.TextBoxDescripcion.Size = New System.Drawing.Size(297, 20)
        Me.TextBoxDescripcion.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Descripción:"
        '
        'TextBoxCveArticulo
        '
        Me.TextBoxCveArticulo.Enabled = False
        Me.TextBoxCveArticulo.Location = New System.Drawing.Point(143, 189)
        Me.TextBoxCveArticulo.Name = "TextBoxCveArticulo"
        Me.TextBoxCveArticulo.Size = New System.Drawing.Size(92, 20)
        Me.TextBoxCveArticulo.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Clave Articulo:"
        '
        'TextBoxCantidadArticulo
        '
        Me.TextBoxCantidadArticulo.Enabled = False
        Me.TextBoxCantidadArticulo.Location = New System.Drawing.Point(143, 242)
        Me.TextBoxCantidadArticulo.Name = "TextBoxCantidadArticulo"
        Me.TextBoxCantidadArticulo.Size = New System.Drawing.Size(42, 20)
        Me.TextBoxCantidadArticulo.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Cantidad Articulo:"
        '
        'TextBoxCantidadMinima
        '
        Me.TextBoxCantidadMinima.Enabled = False
        Me.TextBoxCantidadMinima.Location = New System.Drawing.Point(143, 274)
        Me.TextBoxCantidadMinima.Name = "TextBoxCantidadMinima"
        Me.TextBoxCantidadMinima.Size = New System.Drawing.Size(189, 20)
        Me.TextBoxCantidadMinima.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 276)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Cantidad Minima:"
        '
        'TextBoxPrecio
        '
        Me.TextBoxPrecio.Enabled = False
        Me.TextBoxPrecio.Location = New System.Drawing.Point(143, 305)
        Me.TextBoxPrecio.Name = "TextBoxPrecio"
        Me.TextBoxPrecio.Size = New System.Drawing.Size(122, 20)
        Me.TextBoxPrecio.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(91, 305)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Precio:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CBProducto)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(458, 72)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccione Categoria: de Articulo:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 363)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(774, 353)
        Me.DataGridView1.TabIndex = 17
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=COLMASQLFDC01\FACDYCDES;Initial Catalog=ALMACEN;Integrated Security=T" & _
            "rue"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BtnEliminar.Enabled = False
        Me.BtnEliminar.Location = New System.Drawing.Point(549, 229)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(74, 36)
        Me.BtnEliminar.TabIndex = 34
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BtnEditar.Location = New System.Drawing.Point(667, 315)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(74, 35)
        Me.BtnEditar.TabIndex = 33
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BtnNuevo.Location = New System.Drawing.Point(549, 175)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(74, 34)
        Me.BtnNuevo.TabIndex = 32
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BtnActualizar.Enabled = False
        Me.BtnActualizar.Location = New System.Drawing.Point(667, 229)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(74, 36)
        Me.BtnActualizar.TabIndex = 31
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BtnGuardar.Enabled = False
        Me.BtnGuardar.Location = New System.Drawing.Point(667, 175)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(74, 34)
        Me.BtnGuardar.TabIndex = 30
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnTODOS
        '
        Me.BtnTODOS.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BtnTODOS.Location = New System.Drawing.Point(549, 315)
        Me.BtnTODOS.Name = "BtnTODOS"
        Me.BtnTODOS.Size = New System.Drawing.Size(74, 35)
        Me.BtnTODOS.TabIndex = 29
        Me.BtnTODOS.Text = "Todos"
        Me.BtnTODOS.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBoxBuscar)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(525, 37)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(235, 92)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Buscar Por:"
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.Location = New System.Drawing.Point(10, 56)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(218, 20)
        Me.TextBoxBuscar.TabIndex = 24
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Cve_Art", "Nombre_Art"})
        Me.ComboBox1.Location = New System.Drawing.Point(50, 24)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(146, 21)
        Me.ComboBox1.TabIndex = 23
        Me.ComboBox1.Text = "Nombre_Art"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(18, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 246)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Articulo:"
        '
        'FrmArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(826, 748)
        Me.Controls.Add(Me.TextBoxDescripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxCveArticulo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnTODOS)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBoxPrecio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxCantidadMinima)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxCantidadArticulo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxCveProducto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxCodigo)
        Me.Controls.Add(Me.LabelProducto)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmArticulos"
        Me.Text = "Registro de Articulos"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CBProducto As System.Windows.Forms.ComboBox
    Friend WithEvents LabelProducto As System.Windows.Forms.Label
    Friend WithEvents TextBoxCodigo As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCveProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCveArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCantidadArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCantidadMinima As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnTODOS As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxBuscar As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
