Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Public Class FrmReporteOrdenCompra

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim REPORTE_OC As New CROrdenCompra
        'CrystalReportViewer1.ReportSource = REPORTE_OC
        'CrystalReportViewer1.RefreshReport()
        Close()
    End Sub

    Private Sub FrmReporteOrdenCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim parametro As New ParameterField()
        'Dim mydiscreta As New ParameterDiscreteValue()
        'mydiscreta.Value = CInt(ComboBox1.Text)

        'CrystalReportViewer1.ParameterFieldInfo = mydiscreta.Value
        'Dim info As New FrmReporteOrdenCompra
        'CrystalReportViewer1.ReportSource = info


    End Sub

    'Private Sub BtnGeneraReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGeneraReporte.Click

    '    'Dim parametro As New ParameterField()
    '    'Dim mydiscreta As New ParameterDiscreteValue
    '    'mydiscreta.Value = ComboBox1.ToString
    '    ''parametro.CurrentValues.Add(mydiscreta)

    '    'CrystalReportViewer1.ParameterFieldInfo = (mydiscreta.Value)
    '   'Dim info As New FrmReporteOrdenCompra
    '  'CrystalReportViewer1.ReportSource = info

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    ' Dim parametros As ParameterFields = New ParameterFields()
    ' Dim proveedor As ParameterField = New ParameterField()
    ' Dim mydiscretevalue1 As ParameterDiscreteValue = New ParameterDiscreteValue()
    '     proveedor.ParameterFieldName = "Proveedor"

    '        proveedor.CurrentValues.Add(mydiscretevalue1)

    '       mydiscretevalue1.Value = CB_Proveedor.Text
    '      parametros.Add(proveedor)
    ' 'CrystalReportViewer1.ParameterFieldInfo = parametros
    '    CrystalReportViewer1.ReportSource = parametros
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''Dim dato1 As New ParameterValues
    ''Dim pvisualizar As New ParameterDiscreteValue
    ''Dim cr1 As New FrmReporteOrdenCompra
    ''pvisualizar.Value = CB_Proveedor.Text
    ''dato1.Add(pvisualizar)

    '        CrystalReportViewer1.ReportSource = cr1

    'End Sub

    Private Sub CrystalReportViewer1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        '    If DialogResult.Cancel = True Then
        ' Close()
        ' End If
        'If AcceptButton.DialogResult = Windows.Forms.DialogResult.OK Then
        ' CrystalReportViewer1.Enabled = False
        ' End If

    End Sub

End Class