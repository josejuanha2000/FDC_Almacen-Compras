Public Class FrmMenuCompras
    Dim Proceso As Process = New Process
    Private Sub BtnNuevoReq_Click(sender As Object, e As EventArgs) Handles BtnNuevoReq.Click
        Dim Proceso As Process = New Process
        Process.Start("F:\CETIA\Almacen\ALMACEN.exe")

    End Sub
End Class