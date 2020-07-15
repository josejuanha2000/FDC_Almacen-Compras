<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRequerimientos
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
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.DateTimePickerFechaRegistroReq = New System.Windows.Forms.DateTimePicker()
        Me.TB_Titular = New System.Windows.Forms.TextBox()
        Me.TB_Departamento = New System.Windows.Forms.TextBox()
        Me.TB_FolioReq = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TB_SubTotal_General = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TB_Total_General_Iva = New System.Windows.Forms.TextBox()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=148.234.110.22;Initial Catalog=ALMACEN;User ID=sa;Password=Facdyc2020" &
    ""
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'BtnMostrar
        '
        Me.BtnMostrar.Location = New System.Drawing.Point(93, 51)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(47, 23)
        Me.BtnMostrar.TabIndex = 32
        Me.BtnMostrar.Text = "Mostrar"
        Me.BtnMostrar.UseVisualStyleBackColor = True
        '
        'DateTimePickerFechaRegistroReq
        '
        Me.DateTimePickerFechaRegistroReq.Enabled = False
        Me.DateTimePickerFechaRegistroReq.Location = New System.Drawing.Point(684, 51)
        Me.DateTimePickerFechaRegistroReq.Name = "DateTimePickerFechaRegistroReq"
        Me.DateTimePickerFechaRegistroReq.Size = New System.Drawing.Size(228, 20)
        Me.DateTimePickerFechaRegistroReq.TabIndex = 31
        '
        'TB_Titular
        '
        Me.TB_Titular.Enabled = False
        Me.TB_Titular.Location = New System.Drawing.Point(417, 51)
        Me.TB_Titular.Name = "TB_Titular"
        Me.TB_Titular.Size = New System.Drawing.Size(252, 20)
        Me.TB_Titular.TabIndex = 30
        '
        'TB_Departamento
        '
        Me.TB_Departamento.Enabled = False
        Me.TB_Departamento.Location = New System.Drawing.Point(171, 51)
        Me.TB_Departamento.Name = "TB_Departamento"
        Me.TB_Departamento.Size = New System.Drawing.Size(240, 20)
        Me.TB_Departamento.TabIndex = 29
        '
        'TB_FolioReq
        '
        Me.TB_FolioReq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_FolioReq.Location = New System.Drawing.Point(6, 52)
        Me.TB_FolioReq.Name = "TB_FolioReq"
        Me.TB_FolioReq.Size = New System.Drawing.Size(82, 20)
        Me.TB_FolioReq.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(728, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 15)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Fecha de Registro:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(527, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Titular:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(239, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 15)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Departamento:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 15)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Folio Req:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(733, 440)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(114, 15)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Total General:  $"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(491, 439)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 15)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "Sub-Total :  $"
        '
        'TB_SubTotal_General
        '
        Me.TB_SubTotal_General.Enabled = False
        Me.TB_SubTotal_General.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_SubTotal_General.Location = New System.Drawing.Point(587, 435)
        Me.TB_SubTotal_General.Multiline = True
        Me.TB_SubTotal_General.Name = "TB_SubTotal_General"
        Me.TB_SubTotal_General.Size = New System.Drawing.Size(100, 28)
        Me.TB_SubTotal_General.TabIndex = 34
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(2, 92)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(953, 337)
        Me.DataGridView1.TabIndex = 35
        '
        'TB_Total_General_Iva
        '
        Me.TB_Total_General_Iva.Enabled = False
        Me.TB_Total_General_Iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Total_General_Iva.Location = New System.Drawing.Point(850, 435)
        Me.TB_Total_General_Iva.Multiline = True
        Me.TB_Total_General_Iva.Name = "TB_Total_General_Iva"
        Me.TB_Total_General_Iva.Size = New System.Drawing.Size(100, 28)
        Me.TB_Total_General_Iva.TabIndex = 38
        '
        'BtnImprimir
        '
        Me.BtnImprimir.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BtnImprimir.Location = New System.Drawing.Point(458, 516)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(126, 54)
        Me.BtnImprimir.TabIndex = 39
        Me.BtnImprimir.Text = "Generar Requerimiento de Compra"
        Me.BtnImprimir.UseVisualStyleBackColor = False
        '
        'FrmRequerimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(962, 612)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.TB_Total_General_Iva)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TB_SubTotal_General)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnMostrar)
        Me.Controls.Add(Me.DateTimePickerFechaRegistroReq)
        Me.Controls.Add(Me.TB_Titular)
        Me.Controls.Add(Me.TB_Departamento)
        Me.Controls.Add(Me.TB_FolioReq)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmRequerimientos"
        Me.Text = "Requisicion de Compra"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents BtnMostrar As System.Windows.Forms.Button
    Friend WithEvents DateTimePickerFechaRegistroReq As System.Windows.Forms.DateTimePicker
    Friend WithEvents TB_Titular As System.Windows.Forms.TextBox
    Friend WithEvents TB_Departamento As System.Windows.Forms.TextBox
    Friend WithEvents TB_FolioReq As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TB_SubTotal_General As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TB_Total_General_Iva As System.Windows.Forms.TextBox
    Friend WithEvents BtnImprimir As System.Windows.Forms.Button
End Class
