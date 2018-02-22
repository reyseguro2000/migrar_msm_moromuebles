Public Class base_principal
    Private comando As New Odbc.OdbcCommand
    Private conexion As New Odbc.OdbcConnection
    Private adaptador As New Odbc.OdbcDataAdapter
    Private ds As DataSet
    Private tabla As DataTable
    Public Sub New()
        Try
            conexion.ConnectionString = "DRIVER={MySQL ODBC 5.3 Unicode Driver};SERVER=localhost;DATABASE=maravatio;UID=tony;PWD=xxxx;OPTIONS=&1+2+8+32+2048+16384" '“Server=LocalHost;” & “DataBase=principal;UID=root;PWD=1234;Port=3306”
            'conexion.ConnectionString = "DRIVER={MySQL ODBC 5.3 Unicode Driver};SERVER=radioxxxiguanoxxx.no-ip.biz;DATABASE=msm;UID=tony;PWD=;OPTIONS=&1+2+8+32+2048+16384" '“Server=LocalHost;” & “DataBase=principal;UID=root;PWD=1234;Port=3306”
            conexion.Open()
            comando.Connection = conexion
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, “Error”)
        End Try
    End Sub

    Public Sub dispose()
        conexion.Close()
        conexion.Dispose()
        comando.Dispose()
    End Sub
    Public Sub InsertarSQL(ByVal SentenciaSQL As String)

        comando.CommandText = SentenciaSQL

        comando.ExecuteNonQuery()

    End Sub
    Public Sub llena_tabla(ByVal grilla As DataGridView, ByVal consulta As String)
        comando.CommandText = consulta '"select * from provedores order by nombre"
        adaptador = New Odbc.OdbcDataAdapter
        adaptador.SelectCommand = comando
        tabla = New DataTable
        adaptador.Fill(tabla)
        grilla.DataSource = tabla
    End Sub

    Public Sub llena_combo(ByVal combo As ComboBox, ByVal consulta As String)
        comando.CommandText = consulta '"select * from provedores order by nombre"
        adaptador = New Odbc.OdbcDataAdapter
        adaptador.SelectCommand = comando
        tabla = New DataTable
        adaptador.Fill(tabla)
        combo.DataSource = tabla
    End Sub

    Function busca_cliente(ByVal consulta As String) As DataRow
        Dim existe As DataRow = Nothing

        Try
            adaptador = New Odbc.OdbcDataAdapter(consulta, conexion)
            ds = New DataSet
            adaptador.Fill(ds, "clientes")
            '.Rows(0)
            If ds.Tables("clientes").Rows.Count > 0 Then
                existe = ds.Tables("clientes").Rows(0)
            Else
                existe = ds.Tables("clientes").NewRow
                'existe = existe = ds.Tables(busca_tabla).
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return existe


    End Function

End Class
