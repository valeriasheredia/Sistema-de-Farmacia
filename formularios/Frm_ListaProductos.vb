Public Class Frm_ListaProductos
    Dim datacontext As New DataFarmacia

    Private Sub Frm_ListaProductos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        armargrilla()
        cargargrilla()
    End Sub

    Private Sub txt_buscar_cliente_ruc_TextChanged(sender As System.Object, e As System.EventArgs)
        Dim buscar As String
        If rbt_nombre_producto.Checked = True Then
            armargrilla()
            buscar = Me.txt_buscar_nombre_producto.Text & "*"
            Dim consultaalu = From U In datacontext.Clientes Select U.id_cliente, U.nombre_cliente, U.direccion_cliente, U.localidad_cliente, U.sexo, U.dni_cliente, U.ruc_cliente, U.telefono_cliente Where ruc_cliente Like buscar.ToString
            dgv_lista_productos.DataSource = consultaalu
        End If
    End Sub

    Private Sub armargrilla()
        dgv_lista_productos.Enabled = True
        dgv_lista_productos.AutoGenerateColumns = False
        dgv_lista_productos.Columns.Clear()

        dgv_lista_productos.Columns.Add("id_producto", "id_producto")
        dgv_lista_productos.Columns.Add("nombre_producto", " Nombre")
        dgv_lista_productos.Columns.Add("precio_venta", "Precio Venta")
        dgv_lista_productos.Columns.Add("precio_compra", "Precio Compra")
        dgv_lista_productos.Columns.Add("fecha_vencimiento", "Fecha Vencimiento")
        dgv_lista_productos.Columns.Add("stock", "Stock")
        dgv_lista_productos.Columns.Add("id_categoria", "id_categoria")
        dgv_lista_productos.Columns.Add("nombre_categoria", "Categoría")
        dgv_lista_productos.Columns.Add("id_proveedor", "id_proveedor")
        dgv_lista_productos.Columns.Add("nombre_proveedor", "Proveedor")
        dgv_lista_productos.Columns.Add("id_presentacion", "id_presentacion")
        dgv_lista_productos.Columns.Add("nombre_presentacion", "Presentación")

        dgv_lista_productos.Columns(0).DataPropertyName = "id_producto"
        dgv_lista_productos.Columns(0).Visible = False
        dgv_lista_productos.Columns(1).DataPropertyName = "nombre_producto"
        dgv_lista_productos.Columns(1).Width = 150
        dgv_lista_productos.Columns(2).DataPropertyName = "precio_venta"
        dgv_lista_productos.Columns(3).DataPropertyName = "precio_compra"
        dgv_lista_productos.Columns(4).DataPropertyName = "fecha_vencimiento"
        dgv_lista_productos.Columns(5).DataPropertyName = "stock"
        dgv_lista_productos.Columns(6).DataPropertyName = "id_categoria"
        dgv_lista_productos.Columns(6).Visible = False
        dgv_lista_productos.Columns(7).DataPropertyName = "nombre_categoria"
        dgv_lista_productos.Columns(8).DataPropertyName = "id_proveedor"
        dgv_lista_productos.Columns(8).Visible = False
        dgv_lista_productos.Columns(9).DataPropertyName = "nombre_proveedor"
        dgv_lista_productos.Columns(10).DataPropertyName = "id_presentacion"
        dgv_lista_productos.Columns(10).Visible = False
        dgv_lista_productos.Columns(11).DataPropertyName = "nombre_presentacion"

        dgv_lista_productos.ClearSelection()
    End Sub

    Public Sub cargargrilla()
        Dim buscaProducto = (From prod In datacontext.Producto
                                Join cat In datacontext.Categoria
                                On prod.id_categoria Equals cat.id_categoria
                                Join pres In datacontext.Presentacion
                                On prod.id_presentacion Equals pres.id_presentacion
                                Join prov In datacontext.Proveedor
                                On prod.id_proveedor Equals prov.id_proveedor
                                Select prod.id_producto, prod.nombre_producto, prod.precio_compra, prod.precio_venta, prod.fecha_vencimiento,
                                prod.stock, prod.id_categoria, cat.nombre_categoria, prod.id_proveedor,
                                prov.nombre_proveedor, prod.id_presentacion, pres.nombre_presentacion
                                Order By nombre_producto Ascending)

        dgv_lista_productos.DataSource = buscaProducto
    End Sub

    Private Sub txt_buscar_cliente_ruc_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles txt_buscar_nombre_producto.TextChanged
        Dim buscar As String
        If rbt_nombre_producto.Checked = True Then
            armargrilla()
            buscar = Me.txt_buscar_nombre_producto.Text & "*"
            Dim buscaProducto = (From prod In datacontext.Producto
                                Join cat In datacontext.Categoria
                                On prod.id_categoria Equals cat.id_categoria
                                Join pres In datacontext.Presentacion
                                On prod.id_presentacion Equals pres.id_presentacion
                                Join prov In datacontext.Proveedor
                                On prod.id_proveedor Equals prov.id_proveedor
                                Select prod.id_producto, prod.nombre_producto, prod.precio_compra, prod.precio_venta, prod.fecha_vencimiento,
                                prod.stock, prod.id_categoria, cat.nombre_categoria, prod.id_proveedor,
                                prov.nombre_proveedor, prod.id_presentacion, pres.nombre_presentacion
                                Where nombre_producto Like buscar.ToString
                                Order By nombre_producto Ascending)
            dgv_lista_productos.DataSource = buscaProducto
        End If
    End Sub

    Private Sub btn_modificar_Click(sender As System.Object, e As System.EventArgs) Handles btn_modificar.Click
        If dgv_lista_productos.SelectedRows.Count > 0 Then
            If dgv_lista_productos.SelectedRows.Count > 0 Then
                Frm_NuevoProducto.txt_id_producto.Text = dgv_lista_productos.Item("id_producto", dgv_lista_productos.SelectedRows(0).Index).Value
                Frm_NuevoProducto.txt_nombre_producto.Text = dgv_lista_productos.Item("nombre_producto", dgv_lista_productos.SelectedRows(0).Index).Value
                Frm_NuevoProducto.txt_precio_venta_producto.Text = dgv_lista_productos.Item("precio_venta", dgv_lista_productos.SelectedRows(0).Index).Value
                Frm_NuevoProducto.txt_precio_compra_producto.Text = dgv_lista_productos.Item("precio_compra", dgv_lista_productos.SelectedRows(0).Index).Value
                Frm_NuevoProducto.dtp_fecha_vencimiento.Text = dgv_lista_productos.Item("fecha_vencimiento", dgv_lista_productos.SelectedRows(0).Index).Value
                Frm_NuevoProducto.txt_stock_producto.Text = dgv_lista_productos.Item("stock", dgv_lista_productos.SelectedRows(0).Index).Value
                Frm_NuevoProducto.txt_id_categoria_producto.Text = dgv_lista_productos.Item("id_categoria", dgv_lista_productos.SelectedRows(0).Index).Value
                Frm_NuevoProducto.txt_nombre_categoria_producto.Text = dgv_lista_productos.Item("nombre_categoria", dgv_lista_productos.SelectedRows(0).Index).Value
                Frm_NuevoProducto.txt_id_proveedor_producto.Text = dgv_lista_productos.Item("id_proveedor", dgv_lista_productos.SelectedRows(0).Index).Value
                Frm_NuevoProducto.txt_nombre_proveedor_producto.Text = dgv_lista_productos.Item("nombre_proveedor", dgv_lista_productos.SelectedRows(0).Index).Value
                Frm_NuevoProducto.txt_id_presentacion_producto.Text = dgv_lista_productos.Item("id_presentacion", dgv_lista_productos.SelectedRows(0).Index).Value
                Frm_NuevoProducto.txt_nombre_presentacion_producto.Text = dgv_lista_productos.Item("nombre_presentacion", dgv_lista_productos.SelectedRows(0).Index).Value
            End If
            Frm_NuevoProducto.btn_guardar.Visible = False
            Frm_NuevoProducto.GroupBox2.Visible = False
            Frm_NuevoProducto.txt_id_categoria_producto.Enabled = False
            Frm_NuevoProducto.txt_nombre_categoria_producto.Enabled = False
            Frm_NuevoProducto.txt_id_presentacion_producto.Enabled = False
            Frm_NuevoProducto.txt_nombre_presentacion_producto.Enabled = False
            Frm_NuevoProducto.txt_id_proveedor_producto.Enabled = False
            Frm_NuevoProducto.txt_nombre_proveedor_producto.Enabled = False
            Frm_NuevoProducto.txt_stock_producto.Enabled = False
            Frm_NuevoProducto.Show()
        Else
            MsgBox("Debe seleccionar un producto")
        End If
    End Sub

    Private Sub btn_eliminar_Click_1(sender As System.Object, e As System.EventArgs) Handles btn_eliminar.Click

        If dgv_lista_productos.SelectedRows.Count > 0 Then
            Dim eliminar = (From C In datacontext.Producto Where C.id_producto = CInt(dgv_lista_productos.Item("id_producto", dgv_lista_productos.SelectedRows(0).Index).Value)).ToList()(0)

            Select Case MsgBox("Se eliminará el producto seleccionado, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar producto")
                Case MsgBoxResult.Yes
                    datacontext.Producto.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("El producto ha sido eliminado")
            End Select
        Else
            MsgBox("Debe seleccionar un producto")
        End If
    End Sub

    Private Sub btn_cancelar_Click_1(sender As System.Object, e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btn_Agregar_Carrito_Click(sender As System.Object, e As System.EventArgs) Handles btn_Agregar_Carrito.Click
        Frm_NuevoProducto.Text = "Agregar Producto"

        If dgv_lista_productos.SelectedRows.Count > 0 Then
            Frm_NuevoProducto.txt_id_producto.Text = dgv_lista_productos.Item("id_producto", dgv_lista_productos.SelectedRows(0).Index).Value
            Frm_NuevoProducto.txt_nombre_producto.Text = dgv_lista_productos.Item("nombre_producto", dgv_lista_productos.SelectedRows(0).Index).Value
            Frm_NuevoProducto.txt_precio_venta_producto.Text = dgv_lista_productos.Item("precio_venta", dgv_lista_productos.SelectedRows(0).Index).Value
            Frm_NuevoProducto.txt_precio_compra_producto.Text = dgv_lista_productos.Item("precio_compra", dgv_lista_productos.SelectedRows(0).Index).Value
            Frm_NuevoProducto.dtp_fecha_vencimiento.Text = dgv_lista_productos.Item("fecha_vencimiento", dgv_lista_productos.SelectedRows(0).Index).Value
            Frm_NuevoProducto.txt_stock_producto.Text = dgv_lista_productos.Item("stock", dgv_lista_productos.SelectedRows(0).Index).Value
            Frm_NuevoProducto.txt_id_categoria_producto.Text = dgv_lista_productos.Item("id_categoria", dgv_lista_productos.SelectedRows(0).Index).Value
            Frm_NuevoProducto.txt_nombre_categoria_producto.Text = dgv_lista_productos.Item("nombre_categoria", dgv_lista_productos.SelectedRows(0).Index).Value
            Frm_NuevoProducto.txt_id_proveedor_producto.Text = dgv_lista_productos.Item("id_proveedor", dgv_lista_productos.SelectedRows(0).Index).Value
            Frm_NuevoProducto.txt_nombre_proveedor_producto.Text = dgv_lista_productos.Item("nombre_proveedor", dgv_lista_productos.SelectedRows(0).Index).Value
            Frm_NuevoProducto.txt_id_presentacion_producto.Text = dgv_lista_productos.Item("id_presentacion", dgv_lista_productos.SelectedRows(0).Index).Value
            Frm_NuevoProducto.txt_nombre_presentacion_producto.Text = dgv_lista_productos.Item("nombre_presentacion", dgv_lista_productos.SelectedRows(0).Index).Value
        End If
        Frm_NuevoProducto.DeshabilitarControles()
        Frm_NuevoProducto.Show()
    End Sub

    Private Sub btn_Ver_Click(sender As System.Object, e As System.EventArgs) Handles btn_Ver.Click
        If dgv_lista_productos.SelectedRows.Count > 0 Then
            Frm_NuevoProducto.txt_id_producto.Text = dgv_lista_productos.Item("id_producto", dgv_lista_productos.SelectedRows(0).Index).Value
            Frm_NuevoProducto.txt_nombre_producto.Text = dgv_lista_productos.Item("nombre_producto", dgv_lista_productos.SelectedRows(0).Index).Value
            Frm_NuevoProducto.txt_precio_venta_producto.Text = dgv_lista_productos.Item("precio_venta", dgv_lista_productos.SelectedRows(0).Index).Value
            Frm_NuevoProducto.txt_precio_compra_producto.Text = dgv_lista_productos.Item("precio_compra", dgv_lista_productos.SelectedRows(0).Index).Value
            Frm_NuevoProducto.dtp_fecha_vencimiento.Text = dgv_lista_productos.Item("fecha_vencimiento", dgv_lista_productos.SelectedRows(0).Index).Value
            Frm_NuevoProducto.txt_stock_producto.Text = dgv_lista_productos.Item("stock", dgv_lista_productos.SelectedRows(0).Index).Value
            Frm_NuevoProducto.txt_id_categoria_producto.Text = dgv_lista_productos.Item("id_categoria", dgv_lista_productos.SelectedRows(0).Index).Value
            Frm_NuevoProducto.txt_nombre_categoria_producto.Text = dgv_lista_productos.Item("nombre_categoria", dgv_lista_productos.SelectedRows(0).Index).Value
            Frm_NuevoProducto.txt_id_proveedor_producto.Text = dgv_lista_productos.Item("id_proveedor", dgv_lista_productos.SelectedRows(0).Index).Value
            Frm_NuevoProducto.txt_nombre_proveedor_producto.Text = dgv_lista_productos.Item("nombre_proveedor", dgv_lista_productos.SelectedRows(0).Index).Value
            Frm_NuevoProducto.txt_id_presentacion_producto.Text = dgv_lista_productos.Item("id_presentacion", dgv_lista_productos.SelectedRows(0).Index).Value
            Frm_NuevoProducto.txt_nombre_presentacion_producto.Text = dgv_lista_productos.Item("nombre_presentacion", dgv_lista_productos.SelectedRows(0).Index).Value
            Frm_NuevoProducto.btn_guardar.Enabled = False
            Frm_NuevoProducto.DeshabilitarControles()
            Frm_NuevoProducto.GroupBox2.Visible = False
            Frm_NuevoProducto.Show()
        Else
            MsgBox("Debe seleccionar un producto")
        End If
    End Sub

    Private Sub rbt_nombre_producto_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbt_nombre_producto.CheckedChanged
        dtp_fecha_vencimiento_producto.Enabled = False
        txt_buscar_nombre_producto.Enabled = True
    End Sub

    Private Sub rbt_fecha_vencimiento_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbt_fecha_vencimiento.CheckedChanged
        txt_buscar_nombre_producto.Enabled = False
        dtp_fecha_vencimiento_producto.Enabled = True
    End Sub
End Class