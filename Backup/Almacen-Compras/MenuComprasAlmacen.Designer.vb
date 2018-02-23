<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuComprasAlmacen
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ArticulosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ProveedoresToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ArticulosToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.OrdenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RequerimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OrdenDeCompraToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirDelSistemaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.OperacionesAlmacenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ArticulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RequerimientosDeCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OrdenDeCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirDelSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.ActualizarDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GenerarOrdenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArticulosToolStripMenuItem1, Me.OrdenToolStripMenuItem, Me.SalirToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(494, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArticulosToolStripMenuItem1
        '
        Me.ArticulosToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedoresToolStripMenuItem2, Me.ArticulosToolStripMenuItem2})
        Me.ArticulosToolStripMenuItem1.Name = "ArticulosToolStripMenuItem1"
        Me.ArticulosToolStripMenuItem1.Size = New System.Drawing.Size(72, 20)
        Me.ArticulosToolStripMenuItem1.Text = "Catalogos"
        '
        'ProveedoresToolStripMenuItem2
        '
        Me.ProveedoresToolStripMenuItem2.Name = "ProveedoresToolStripMenuItem2"
        Me.ProveedoresToolStripMenuItem2.Size = New System.Drawing.Size(139, 22)
        Me.ProveedoresToolStripMenuItem2.Text = "Proveedores"
        '
        'ArticulosToolStripMenuItem2
        '
        Me.ArticulosToolStripMenuItem2.Name = "ArticulosToolStripMenuItem2"
        Me.ArticulosToolStripMenuItem2.Size = New System.Drawing.Size(139, 22)
        Me.ArticulosToolStripMenuItem2.Text = "Articulos"
        '
        'OrdenToolStripMenuItem
        '
        Me.OrdenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RequerimientosToolStripMenuItem, Me.OrdenDeCompraToolStripMenuItem1})
        Me.OrdenToolStripMenuItem.Name = "OrdenToolStripMenuItem"
        Me.OrdenToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.OrdenToolStripMenuItem.Text = "Reportes"
        '
        'RequerimientosToolStripMenuItem
        '
        Me.RequerimientosToolStripMenuItem.Name = "RequerimientosToolStripMenuItem"
        Me.RequerimientosToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.RequerimientosToolStripMenuItem.Text = "Requerimientos"
        '
        'OrdenDeCompraToolStripMenuItem1
        '
        Me.OrdenDeCompraToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActualizarDatosToolStripMenuItem, Me.GenerarOrdenToolStripMenuItem})
        Me.OrdenDeCompraToolStripMenuItem1.Name = "OrdenDeCompraToolStripMenuItem1"
        Me.OrdenDeCompraToolStripMenuItem1.Size = New System.Drawing.Size(169, 22)
        Me.OrdenDeCompraToolStripMenuItem1.Text = "Orden de Compra"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirDelSistemaToolStripMenuItem1})
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'SalirDelSistemaToolStripMenuItem1
        '
        Me.SalirDelSistemaToolStripMenuItem1.Name = "SalirDelSistemaToolStripMenuItem1"
        Me.SalirDelSistemaToolStripMenuItem1.Size = New System.Drawing.Size(159, 22)
        Me.SalirDelSistemaToolStripMenuItem1.Text = "Salir del Sistema"
        '
        'OperacionesAlmacenToolStripMenuItem
        '
        Me.OperacionesAlmacenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArticulosToolStripMenuItem, Me.ProveedoresToolStripMenuItem})
        Me.OperacionesAlmacenToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OperacionesAlmacenToolStripMenuItem.Name = "OperacionesAlmacenToolStripMenuItem"
        Me.OperacionesAlmacenToolStripMenuItem.Size = New System.Drawing.Size(123, 20)
        Me.OperacionesAlmacenToolStripMenuItem.Text = "Catalogos Almacen"
        '
        'ArticulosToolStripMenuItem
        '
        Me.ArticulosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArticulosToolStripMenuItem.Name = "ArticulosToolStripMenuItem"
        Me.ArticulosToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ArticulosToolStripMenuItem.Text = "Articulos"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RequerimientosDeCompraToolStripMenuItem, Me.OrdenDeCompraToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(133, 20)
        Me.ReportesToolStripMenuItem.Text = "Ordenes de compras"
        '
        'RequerimientosDeCompraToolStripMenuItem
        '
        Me.RequerimientosDeCompraToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RequerimientosDeCompraToolStripMenuItem.Name = "RequerimientosDeCompraToolStripMenuItem"
        Me.RequerimientosDeCompraToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.RequerimientosDeCompraToolStripMenuItem.Text = "Requerimientos de Almacen"
        '
        'OrdenDeCompraToolStripMenuItem
        '
        Me.OrdenDeCompraToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrdenDeCompraToolStripMenuItem.Name = "OrdenDeCompraToolStripMenuItem"
        Me.OrdenDeCompraToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.OrdenDeCompraToolStripMenuItem.Text = "Orden de compra"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirDelSistemaToolStripMenuItem})
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'SalirDelSistemaToolStripMenuItem
        '
        Me.SalirDelSistemaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalirDelSistemaToolStripMenuItem.Name = "SalirDelSistemaToolStripMenuItem"
        Me.SalirDelSistemaToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.SalirDelSistemaToolStripMenuItem.Text = "Salir del Sistema"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(315, 297)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Compras y Almacen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ActualizarDatosToolStripMenuItem
        '
        Me.ActualizarDatosToolStripMenuItem.Name = "ActualizarDatosToolStripMenuItem"
        Me.ActualizarDatosToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ActualizarDatosToolStripMenuItem.Text = "Actualizar Datos"
        '
        'GenerarOrdenToolStripMenuItem
        '
        Me.GenerarOrdenToolStripMenuItem.Name = "GenerarOrdenToolStripMenuItem"
        Me.GenerarOrdenToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.GenerarOrdenToolStripMenuItem.Text = "Generar Orden"
        '
        'MenuComprasAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(494, 326)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuComprasAlmacen"
        Me.Text = " "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OperacionesAlmacenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArticulosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RequerimientosDeCompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdenDeCompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirDelSistemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ArticulosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RequerimientosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdenDeCompraToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirDelSistemaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArticulosToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarOrdenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
