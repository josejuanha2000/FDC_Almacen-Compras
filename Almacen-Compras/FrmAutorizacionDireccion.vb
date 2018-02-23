Imports System.Data
Imports System.IO
Imports System.Text
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Public Class FrmAutorizacionDireccion
    Dim sqlCTDV As New SqlCommand
    Dim sqlfolio As New SqlCommand
    Dim sqldr As SqlDataReader
    Dim sqldrfolio As SqlDataReader
    Dim sqlfolioDepto As New SqlCommand
    Dim sqldrfolioDepto As SqlDataReader
    Private Sub FrmAutorizacionDireccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call carga_folio()
        'TBDepto.Text = funcio MenuJefes.TBDepto.Text
        'TBTitular.Text = MenuJefes.TBTitular.Text
        'Label_Id_Depto.Text = FrmAutorizacionDireccion.Id_Depto.Text

    End Sub
    Sub carga_folio()

        Try
            Me.SqlConnection1.Open()
            sqlfolioDepto.CommandType = CommandType.Text
            'sqlfolioDepto.CommandText = ("select distinct folio  from requerimiento  where requerimiento.Status_Sub_Adm  =   'P' order by folio asc")
            'MsgBox(Label_Id_Depto.Text)
            sqlfolioDepto.CommandText = ("select distinct folio  from requerimiento  where requerimiento.Id_Depto  ='" & (Label_Id_Depto.Text) & "'" & "order by folio desc")
            '& "AND Status_Titular='" & "S" & "'")
            'sqlfolio.CommandText = ("Select Folio,Nombre_art,Fecha_Cap_Req,Cant_Art,Justificacion,Status_Titular from Requerimiento where requerimiento.Folio =  '" & TBFolio.Text & "'" & "AND Status_Titular =  '" & "N" & "'")
            sqlfolioDepto.Connection = Me.SqlConnection1
            sqldrfolioDepto = sqlfolioDepto.ExecuteReader()

            While sqldrfolioDepto.Read = True
                'CBFolioSDA.Text = sqldrfolio("FOLIO")
                'If Not IsDBNull(sqldrfolioDepto("Id_Depto")) Then
                CBFolio.Items.Add(sqldrfolioDepto.Item(0))
                'End If
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqldrfolioDepto.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub buscar_folio()
        Try
            Me.SqlConnection1.Open()
            'CBA2.Items.Clear()
            BtnAutoriza.Enabled = False
            ' BtnRechazar.Enabled = False
            ListView1.Items.Clear()
            sqlfolio.CommandType = CommandType.Text
            'sqlfolio.CommandText = ("Select Folio,Nombre_art,Fecha_Cap_Req,Cant_Art,Justificacion from Requerimiento where requerimiento.Folio =  '" & TBFolio.Text & "'")
            'sqlfolio.CommandText = ("Select Folio,Nombre_art,Fecha_Cap_Req,Cant_Art,Justificacion,Status_Titular from Requerimiento where requerimiento.Folio =  '" & TBFolio.Text & "'" & "AND Status_Titular =  '" & "N" & "'")
            sqlfolio.CommandText = ("Select Folio,Nombre_art,Fecha_Cap_Req,Cant_Art,Justificacion,Act,Status_Titular,Fecha_Aut_Titular,Status_Sub_Adm,Fecha_Aut_Sub_Adm from Requerimiento where requerimiento.Folio =  '" & (CBFolio.Text) & "'")
            sqlfolio.Connection = Me.SqlConnection1
            sqldrfolio = sqlfolio.ExecuteReader()
            ' sqldrfolio.Read()
            While (sqldrfolio.Read())
                DateTimePicker1.Text = sqldrfolio("Fecha_Cap_Req")
                If sqldrfolio("Status_Titular") = "P" Then
                    BtnAutoriza.Enabled = True
                End If
                With ListView1.Items.Add(sqldrfolio("folio"))
                    .subitems.add(sqldrfolio("nombre_art"))
                    .subitems.add(sqldrfolio("fecha_Cap_Req"))
                    .subitems.add(sqldrfolio("Cant_Art"))
                    .subitems.add(sqldrfolio("Justificacion"))
                    .subitems.add(sqldrfolio("Act"))
                    .subitems.add(sqldrfolio("Status_Titular"))
                    If Not IsDBNull(sqldrfolio("Fecha_Aut_Titular")) Then
                        .subitems.add(sqldrfolio("Fecha_Aut_Titular"))
                    End If
                    .subitems.add(sqldrfolio("Status_Sub_Adm"))
                    If Not IsDBNull(sqldrfolio("Fecha_Aut_Sub_Adm")) Then
                        .subitems.add(sqldrfolio("Fecha_Aut_Sub_Adm"))
                    End If
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqldrfolio.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub Autorizar_Requerimiento()
        Try
            Dim Autoriza As String
            Me.SqlConnection1.Open()
            Autoriza = MsgBox("Esta seguro de Autorizar el Requerimiento ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Guardar")
            If Autoriza = vbYes Then
                'Dim insal As String = ("INSERT into talumno (matricula,nombre)" & "values(" & TBMatricula.Text & "," & TBNombre.Text & ",")
                Dim insal As String = ("UPDATE  Requerimiento SET Status_Titular=@Status_Titular,Fecha_Aut_Titular=@Fecha_Aut_Titular,Status_Sub_Adm=@Status_Sub_Adm,Fecha_Aut_Sub_Adm=@Fecha_Aut_Sub_Adm,Status_Direccion=@Status_Direccion,Fecha_Aut_Direccion=@Fecha_Aut_Direccion  where  Folio= '" & CBFolio.Text & "'")
                Dim conex1 As New SqlClient.SqlCommand(insal, Me.SqlConnection1)
                conex1.Parameters.Add(New SqlParameter("@Status_Titular", SqlDbType.NVarChar, 1)).Value = "A"
                conex1.Parameters.Add(New SqlParameter("@Fecha_Aut_Titular", SqlDbType.SmallDateTime)).Value = DateTimePicker1.Text

                conex1.Parameters.Add(New SqlParameter("@Status_Sub_Adm", SqlDbType.NVarChar, 1)).Value = "A"
                conex1.Parameters.Add(New SqlParameter("@Fecha_Aut_Sub_Adm", SqlDbType.SmallDateTime)).Value = DateTimePicker1.Text

                conex1.Parameters.Add(New SqlParameter("@Status_Direccion", SqlDbType.NVarChar, 1)).Value = "A"
                conex1.Parameters.Add(New SqlParameter("@Fecha_Aut_Direccion", SqlDbType.SmallDateTime)).Value = DateTimePicker1.Text
                conex1.CommandText = insal
                conex1.ExecuteNonQuery()
                MsgBox("Requerimiento Autorizado correctamente", , "Guardar")
                Me.SqlConnection1.Close()
            End If
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        Call buscar_folio()
    End Sub
    Private Sub BtnAutoriza_Click(sender As Object, e As EventArgs) Handles BtnAutoriza.Click
        Call Autorizar_Requerimiento()
    End Sub
End Class