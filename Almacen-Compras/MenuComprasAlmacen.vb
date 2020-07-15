Public Class MenuComprasAlmacen
    Private Sub ProveedoresToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem2.Click
        FrmProveedores.Show()
    End Sub
    Private Sub ArticulosToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArticulosToolStripMenuItem2.Click
        FrmArticulos.Show()
    End Sub

    Private Sub RequerimientosToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RequerimientosToolStripMenuItem.Click
        FrmRequerimientos.Show()
    End Sub
    Private Sub OrdenDeCompraToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdenDeCompraToolStripMenuItem1.Click

    End Sub
    Private Sub SalirDelSistemaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirDelSistemaToolStripMenuItem1.Click
        Dim salir As String
        'salir = MsgBox("Esta seguro que desea salir?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Salir ?")
        salir = MsgBox("Esta seguro que desea salir?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Salir ?")
        If salir = vbYes Then
            End
        End If
    End Sub
    Private Sub ActualizarDatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarDatosToolStripMenuItem.Click
        FrmOrdenCompra.Show()
    End Sub

    Private Sub GenerarOrdenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarOrdenToolStripMenuItem.Click
        FrmGenera_Orden_Compra.Show()

    End Sub

    Private Sub MenuComprasAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub AutorizarEnSubDirAdministrativaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutorizarEnSubDirAdministrativaToolStripMenuItem.Click
        Dim Proceso As Process = New Process
        Process.Start("V:\COMPRAS\Almacen\Material.exe")
    End Sub

    Private Sub AutorizadosPorDireccionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutorizadosPorDireccionToolStripMenuItem.Click
        Dim Proceso As Process = New Process
        Process.Start("V:\COMPRAS\Direccion\Autorizacion Direccion.exe")
        'FrmReq_Mat_Aut_Direccion.Show()
        'FrmLoginAlmacen.Show()
        'FrmAutorizacionDireccion.Show()

    End Sub

    Private Sub AutorizacionCOMPRASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutorizacionCOMPRASToolStripMenuItem.Click
        FrmAutorizacionCompras.Show()

    End Sub
End Class