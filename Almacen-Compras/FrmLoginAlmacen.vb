Imports System.Data
Imports System.IO
Imports System.Text
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class FrmLoginAlmacen
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            Dim dts As New Datos2
            Dim func As New FUNCIONES2
            dts.fdcusername = Username.Text
            dts.fdcpassword = Password.Text
            If func.validar(dts) = True Then
                'Call MenuComprasAlmacen.Show()
                Call MenuComprasAlmacen.Show()
                Me.Hide()
            Else
                MsgBox("Login failed")
                Password.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Me.Close()
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
    Private Sub FrmLoginAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class