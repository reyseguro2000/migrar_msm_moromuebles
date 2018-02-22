Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bt_buscar.Click
        Dim conexion As New base_principal
        ProgressBar1.Value = 1
        ProgressBar1.Maximum = 4

        'conexion.llena_tabla(dg_clientes, "select cli_clave, nombre, calle, noint,noext,colonia,ciudad,telefono,ocupacion,antiguedad, calleoc, nooc, coloc, ciudadoc, esposo, espoc, espantig, espcalle, espno, espcol, espciudad, ref1nom, ref1calle, ref1no, ref1col, ref1ciudad, parentesco, ref2nombre, ref2calle, ref2no, ref2colonia, ref2ciudad, calleanterior, noanterior, colanterior, ciudadanterior, casa, documento, casadatos, calificacion from cli_venta_mar group by cli_clave")
        'Label2.Text = dg_clientes.RowCount
        'ProgressBar1.Value += 1
        'conexion.llena_tabla(dg_credito, "select cli_clave, ruta, fecha, plazo, forma, total, enganche, saldo, vendedor, comicion, venta_clave, fecha_ven, descuento, folio, tipo_desc from cli_venta_mar")
        'Label5.Text = "credito" + dg_credito.RowCount.ToString
        'ProgressBar1.Value += 1
        'conexion.llena_tabla(dg_detalle, "select venta,articulo,serie,cantidad,precio,costo,pro_clave from cli_venta_mar_d")
        'Label4.Text = "detalle " + dg_detalle.RowCount.ToString
        ProgressBar1.Value += 1
        conexion.llena_tabla(dg_pagos, "select venta, ruta, recibo, cantidad, fecha from cli_pagos_mar where fecha>'2015-01-01'")
        Label3.Text = "pagos " + dg_pagos.RowCount.ToString


        'conexion.llena_tabla(dg_clientes, "select * from clientes")
        '' conexion.llena_tabla(dg_ventas, "select * from credito where saldo>0 and bodega='" + Mid(cmb_bodegas.Text, 1, 3) + "'")
        'conexion.llena_tabla(dg_detalle, "select venta,articulo,serie,cantidad,precio,costo,pro_clave from detalle,credito where saldo>0 and bodega='" + Mid(cmb_bodegas.Text, 1, 3) + "'")
        'conexion.llena_tabla(dg_pagos, "pagos.cliente,pagos.venta,pagos.bodega,pagos.ruta,recibo,cantidad,pagos.fecha from pagos, credito where credito.saldo>0 and credito.bodega='" + Mid(cmb_bodegas.Text, 1, 3) + "'")
        conexion.dispose()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New base_principal
        'conexion.llena_combo(cmb_bodegas, "select * from catalogo where tipo='BODEGA'")
        cmb_bodegas.DisplayMember = "lista"
        conexion.dispose()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim conexion As New base_principal
        With dg_clientes
            ProgressBar1.Value = 1
            ProgressBar1.Maximum = .RowCount + 1
            For i As Int16 = 0 To .RowCount - 1
                conexion.InsertarSQL("insert into clientes values(null," + .Item("cli_clave", i).Value.ToString + ",'','" + .Item("nombre", i).Value + "','" + .Item("esposo", i).Value + "','" + .Item("calle", i).Value + "','" + .Item("colonia", i).Value + "','','" + .Item("ciudad", i).Value + "','','" + .Item("casa", i).Value + "','',0,'','" + .Item("telefono", i).Value + "','" + .Item("documento", i).Value + "','" + .Item("casadatos", i).Value + "','" + .Item("ocupacion", i).Value + "'," + .Item("antiguedad", i).Value.ToString + ",'" + .Item("calleoc", i).Value + " " + .Item("nooc", i).Value + "','" + .Item("coloc", i).Value + "','" + .Item("ciudadoc", i).Value + "','" + .Item("ref1nom", i).Value + "','" + .Item("ref1calle", i).Value + " " + .Item("ref1no", i).Value + "','" + .Item("ref1col", i).Value + "','" + .Item("ref1ciudad", i).Value + "','',0,'" + .Item("parentesco", i).Value + "','','" + .Item("calificacion", i).Value + "')")
                ProgressBar1.Value += 1
            Next
        End With
        conexion.dispose()
        '" INSERT INTO clientes values() Where Not EXISTS(SELECT clave FROM clientes WHERE CLAVE="+ dg_clie +" LIMIT 1)"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim conexion As New base_principal
        Dim fila_cliente As DataRow
        With dg_credito
            ProgressBar1.Value = 1
            ProgressBar1.Maximum = .RowCount + 1
            For i As Integer = 0 To .RowCount - 1
                'fila_cliente = conexion.busca_cliente("select clave_i from clientes where clave=" + .Item("cli_clave", i).Value.ToString)
                conexion.InsertarSQL("insert into ventas_camionetas values((select clave_i from clientes where clave=" + .Item("cli_clave", i).Value.ToString + "),'" + .Item("folio", i).Value.ToString + "'," + .Item("ruta", i).Value.ToString + ",'" + .Item("fecha", i).Value + "'," + .Item("plazo", i).Value.ToString + ",'" + .Item("forma", i).Value.ToString + "'," + .Item("total", i).Value.ToString + "," + .Item("enganche", i).Value.ToString + "," + .Item("descuento", i).Value.ToString + ",'" + .Item("tipo_desc", i).Value.ToString + "',0," + .Item("comicion", i).Value.ToString + ",''," + .Item("saldo", i).Value.ToString + ",'" + .Item("venta_clave", i).Value + "')")
                ProgressBar1.Value += 1
            Next
        End With
        conexion.dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim conexion As New base_principal
        With dg_detalle
            ProgressBar1.Value = 1
            ProgressBar1.Maximum = .RowCount + 1
            For i As Integer = 0 To .RowCount - 1
                conexion.InsertarSQL("insert into articulos_ventas values(null,'" + .Item("venta", i).Value + "',''," + .Item("cantidad", i).Value.ToString + ",'" + .Item("pro_clave", i).Value + "'," + .Item("costo", i).Value.ToString + ",'1'," + .Item("precio", i).Value.ToString + ",'" + .Item("articulo", i).Value + "')")
                ProgressBar1.Value += 1
            Next
        End With
        conexion.dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim conexion As New base_principal
        Dim fecha As Date
        Dim fila_cliente As DataRow
        With dg_pagos
            ProgressBar1.Value = 1
            ProgressBar1.Maximum = .RowCount+1
            For i As Integer = 0 To .RowCount - 1
                fecha = .Item("fecha", i).Value
                'fila_cliente = conexion.busca_cliente("select cliente from ventas_camionetas where venta='MOR" + .Item("venta", i).Value.ToString + "'")
                conexion.InsertarSQL("insert into pagos_credito values('" + .Item("recibo", i).Value.ToString + "','" + .Item("venta", i).Value.ToString + "'," + .Item("RUTA", i).Value.ToString + "," + .Item("cantidad", i).Value.ToString + ",'" + Format(fecha, "yyyy-MM-dd HH:mm") + "')")
                'conexion.InsertarSQL("insert into pagos_credito values('" + .Item("recibo", i).Value + "'," + fila_cliente.Item("cliente").ToString + ",'MOR" + .Item("venta", i).Value.ToString + "'," + .Item("RUTA", i).Value.ToString + "," + .Item("cantidad", i).Value.ToString + ",'" + Format(fecha, "yyyy-MM-dd HH:mm") + "')")
                ProgressBar1.Value += 1
            Next
        End With
        conexion.dispose()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ColorDialog1.ShowDialog()
        Me.BackColor = ColorDialog1.Color

    End Sub
End Class
