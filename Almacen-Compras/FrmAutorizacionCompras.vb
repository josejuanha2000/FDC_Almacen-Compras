Imports System.Data
Imports System.IO
Imports System.Text
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Public Class FrmAutorizacionCompras
    Dim CTArt1 As New SqlCommand
    Dim CTArt2 As New SqlCommand
    Dim CTArt3 As New SqlCommand
    Dim CTArt4 As New SqlCommand
    Dim CTArt5 As New SqlCommand
    Dim CTArt6 As New SqlCommand
    Dim CTArt7 As New SqlCommand
    Dim CTArt8 As New SqlCommand
    Dim CTArt9 As New SqlCommand
    Dim CTArt10 As New SqlCommand

    Dim CTBTArt1 As New SqlCommand
    Dim CTBTArt2 As New SqlCommand
    Dim CTBTArt3 As New SqlCommand
    Dim CTBTArt4 As New SqlCommand
    Dim CTBTArt5 As New SqlCommand
    Dim CTBTArt6 As New SqlCommand
    Dim CTBTArt7 As New SqlCommand
    Dim CTBTArt8 As New SqlCommand
    Dim CTBTArt9 As New SqlCommand
    Dim CTBTArt10 As New SqlCommand

    Dim DAARTICULO1 As SqlDataReader
    Dim DAARTICULO2 As SqlDataReader
    Dim DAARTICULO3 As SqlDataReader
    Dim DAARTICULO4 As SqlDataReader
    Dim DAARTICULO5 As SqlDataReader
    Dim DAARTICULO6 As SqlDataReader
    Dim DAARTICULO7 As SqlDataReader
    Dim DAARTICULO8 As SqlDataReader
    Dim DAARTICULO9 As SqlDataReader
    Dim DAARTICULO10 As SqlDataReader

    Dim sqlfolio As New SqlCommand
    Dim sqldrfolio As SqlDataReader
    Dim Records As String
    Private Sub FrmAutorizacionCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call carga_folio()

    End Sub
    Sub carga_folio()
        Try
            Me.SqlConnection1.Open()
            sqlfolio.CommandType = CommandType.Text
            sqlfolio.CommandText = ("select distinct folio  from requerimiento  where requerimiento.Status_Sub_Adm  =   'P' order by folio asc")
            '& "AND Status_Titular='" & "S" & "'")
            'sqlfolio.CommandText = ("Select Folio,Nombre_art,Fecha_Cap_Req,Cant_Art,Justificacion,Status_Titular from Requerimiento where requerimiento.Folio =  '" & TBFolio.Text & "'" & "AND Status_Titular =  '" & "N" & "'")
            sqlfolio.Connection = Me.SqlConnection1
            sqldrfolio = sqlfolio.ExecuteReader()
            While sqldrfolio.Read = True
                'CBFolioSDA.Text = sqldrfolio("FOLIO")
                CBFolio.Items.Add(sqldrfolio.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqldrfolio.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub buscar_folio()
        Try
            Me.SqlConnection1.Open()
            BtnAutoriza.Enabled = False
            sqlfolio.CommandType = CommandType.Text
            sqlfolio.CommandText = ("Select Depto,Titular_Depto,Folio,Nombre_art,Fecha_Cap_Req,Cant_Art,Justificacion,Status_Titular,Status_Sub_Adm,Act from Requerimiento where requerimiento.Folio =  '" & CBFolio.Text & "'")
            sqlfolio.Connection = Me.SqlConnection1
            sqldrfolio = sqlfolio.ExecuteReader()
            While (sqldrfolio.Read())
                TBDepto.Text = sqldrfolio("Depto")
                TBTitular.Text = sqldrfolio("Titular_Depto")
                DateTimePicker2.Text = sqldrfolio("Fecha_Cap_Req")
                If sqldrfolio("Status_Sub_Adm") = "P" Then
                    BtnAutoriza.Enabled = True
                    BtnRechaza.Enabled = True
                Else
                    BtnAutoriza.Enabled = True
                    BtnRechaza.Enabled = True
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlConnection1.Close()
        sqldrfolio.Close()
    End Sub
    Sub cargar_Art1()
        Try
            Me.SqlConnection1.Open()
            CBA1.Items.Clear()
            CTArt1.CommandType = CommandType.Text
            'CTArt2.CommandText = ("Select Nombre_art,Cve_Art,Cve_Pro from Articulo where Articulo.Cve_pro =  '" & TBCpro.Text & "'order by Nombre_Art Asc")
            CTArt1.CommandText = ("Select Cve_Art,Nombre_art,Justificacion,Cant_Art,Precio_Unitario,Status_Titular,Status_Sub_Adm from Requerimiento where Requerimiento.Folio =  '" & CBFolio.Text & "'" & "and Act='" & 1 & "'")
            CTArt1.Connection = Me.SqlConnection1
            DAARTICULO1 = CTArt1.ExecuteReader()
            If DAARTICULO1.Read() Then
                'While DAARTICULO2.Read = True
                'CBA2.Items.Add(DAARTICULO2.Item(0))
                'End While
                'Label21.Text = DAARTICULO1("Cve_Art")
                CBA1.Text = DAARTICULO1("Nombre_Art")
                TB1.Text = DAARTICULO1("Justificacion")
                NUpDown1.Text = DAARTICULO1("Cant_Art")
                NumericUpDown1.Text = DAARTICULO1("Precio_Unitario")

                Label21.Text = DAARTICULO1("Status_Sub_Adm") 'DESPLIEGA STATUS 
                If DAARTICULO1("Status_Titular") = "A" Then
                    CheckBox1.Checked = True
                    NUpDown1.Enabled = True
                    ChBSDA1.Enabled = True
                Else
                    CheckBox1.Checked = False
                    NUpDown1.Enabled = False
                End If
                If DAARTICULO1("Status_Sub_Adm") = "A" Then
                    Label21.ForeColor = Color.Green
                    ChBSDA1.Checked = True
                Else
                    If DAARTICULO1("Status_Sub_Adm") = "R" Then
                        Label21.ForeColor = Color.Red
                    Else
                        Label21.ForeColor = Color.Orange
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO1.Close()
        Me.SqlConnection1.Close()
    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        'Call limpiar_formulario()
        Call buscar_folio()
        Call cargar_Art1()
        'Call cargar_Art2()
        'Call cargar_Art3()
        'Call cargar_Art4()
        'Call cargar_Art5()
        'Call cargar_Art6()
        'Call cargar_Art7()
        'Call cargar_Art8()
        'Call cargar_Art9()
        'Call cargar_Art10()
    End Sub
End Class