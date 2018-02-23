Imports System.Data
Imports System.IO
Imports System.Text
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class FUNCIONES2
    Inherits CONEXION2
    Dim cmd As New SqlCommand
    Public Function validar(ByVal dts As Datos2) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("validar")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@log", dts.fdcusername)
            cmd.Parameters.AddWithValue("@pas", dts.fdcpassword)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then

                FrmAutorizacionDireccion.TBDepto.Text = dr("Departamento")
                FrmAutorizacionDireccion.TBTitular.Text = dr("Titular")
                FrmAutorizacionDireccion.Label_Id_Depto.Text = dr("Id_Depto")

                'FrmMenuCompras.TBDepto.Text = dr("Departamento")
                'FrmMenuCompras.TBTitular.Text = dr("Titular")


                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
End Class
