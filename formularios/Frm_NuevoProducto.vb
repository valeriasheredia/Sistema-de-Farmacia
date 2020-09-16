Public Class Frm_NuevoProducto

    Dim datacontext As New DataFarmacia

    Private Sub btn_guardar_Click(sender As System.Object, e As System.EventArgs) Handles btn_guardar.Click
        Try
            Dim buscacliente = (From prod In datacontext.Producto
                                Join cat In datacontext.Categoria
                                On prod.id_categoria Equals cat.id_categoria
                                Join pres In datacontext.Presentacion
                                On prod.id_presentacion Equals pres.id_presentacion
                                Join prov In datacontext.Proveedor
                                On prod.id_proveedor Equals prov.id_proveedor
                                Select prod.nombre_producto, prod.precio_compra, prod.precio_venta, prod.fecha_vencimiento,
                                prod.stock, prod.id_categoria, cat.nombre_categoria, prod.id_proveedor,
                                prov.nombre_proveedor, prod.id_presentacion, pres.nombre_presentacion
                                Where nombre_producto = txt_nombre_producto.Text.ToUpper).Any
            If buscacliente = True Then
                MsgBox("El producto ingresado ya existe")
                limpiarcontroles()
                Exit Sub
            End If
            If txt_nombre_producto.Text.Length = 0 _
                Or txt_precio_compra_producto.Text.Length = 0 _
                Or txt_precio_venta_producto.Text.Length = 0 _
                Or txt_stock_producto.Text.Length = 0 Then

                MsgBox("Debe completar todos los campos requeridos")
                Exit Sub
            End If
            Dim producto = New Producto
            producto.nombre_producto = txt_nombre_producto.Text
            producto.precio_venta = txt_precio_venta_producto.Text
            producto.precio_compra = txt_precio_compra_producto.Text
            producto.fecha_vencimiento = dtp_fecha_vencimiento.Text
            producto.stock = txt_stock_producto.Text
            producto.id_categoria = txt_id_categoria_producto.Text
            producto.id_proveedor = txt_id_proveedor_producto.Text
            producto.id_presentacion = txt_id_presentacion_producto.Text

            datacontext.Producto.InsertOnSubmit(producto)
            datacontext.SubmitChanges()
            MsgBox("El producto se ha creado correctamente", vbInformation)
            limpiarcontroles()
        Catch ex As Exception
            MsgBox("El producto NO fue creado")
            limpiarcontroles()
        End Try
    End Sub

    Sub limpiarcontroles()
        txt_nombre_producto.Clear()
        txt_precio_venta_producto.Clear()
        txt_precio_compra_producto.Clear()
        dtp_fecha_vencimiento.Text = Now
        txt_stock_producto.Clear()
        txt_id_categoria_producto.Clear()
        txt_nombre_categoria_producto.Clear()
        txt_id_proveedor_producto.Clear()
        txt_nombre_proveedor_producto.Clear()
        txt_id_presentacion_producto.Clear()
        txt_nombre_presentacion_producto.Clear()
    End Sub

    Private Sub btn_buscar_categoria_Click(sender As System.Object, e As System.EventArgs) Handles btn_buscar_categoria.Click
        Frm_ListaCategorias.Text = "Seleccionar Categoría"
        Frm_ListaCategorias.Show()
    End Sub

    Private Sub btn_buscar_proveedor_Click(sender As System.Object, e As System.EventArgs) Handles btn_buscar_proveedor.Click
        Frm_ListaProveedores.Text = "Seleccionar Proveedor"
        Frm_ListaProveedores.Show()
    End Sub

    Private Sub btn_buscar_presentacion_Click(sender As System.Object, e As System.EventArgs) Handles btn_buscar_presentacion.Click
        Frm_ListaPresentacion.Text = "Seleccionar Presentación"
        Frm_ListaPresentacion.Show()
    End Sub

    Private Sub btn_actualizar_Click(sender As System.Object, e As System.EventArgs) Handles btn_actualizar.Click
        If txt_nombre_producto.Text.Length = 0 _
                 Or txt_precio_compra_producto.Text.Length = 0 _
                 Or txt_precio_venta_producto.Text.Length = 0 _
                 Or txt_stock_producto.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            Dim ActualizarProducto = (From P In datacontext.Producto Where P.id_producto = (txt_id_producto.Text.ToUpper)).ToList()(0)
            ActualizarProducto.nombre_producto = txt_nombre_producto.Text
            ActualizarProducto.precio_venta = txt_precio_venta_producto.Text
            ActualizarProducto.precio_compra = txt_precio_compra_producto.Text
            ActualizarProducto.fecha_vencimiento = dtp_fecha_vencimiento.Text
            ActualizarProducto.stock = txt_stock_producto.Text
            ActualizarProducto.id_categoria = txt_id_categoria_producto.Text
            ActualizarProducto.id_proveedor = txt_id_proveedor_producto.Text
            ActualizarProducto.id_presentacion = txt_id_presentacion_producto.Text

            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")
            Me.limpiarcontroles()
            Me.Close()
            Frm_ListaProductos.cargargrilla()
        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar empleado")
            Me.limpiarcontroles()
            Me.Close()
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Frm_NuevoProducto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub DeshabilitarControles()
        txt_nombre_producto.Enabled = False
        txt_precio_compra_producto.Enabled = False
        txt_precio_venta_producto.Enabled = False
        dtp_fecha_vencimiento.Enabled = False
        txt_stock_producto.Enabled = False
        txt_id_categoria_producto.Enabled = False
        txt_nombre_categoria_producto.Enabled = False
        btn_buscar_categoria.Enabled = False
        txt_id_proveedor_producto.Enabled = False
        txt_nombre_proveedor_producto.Enabled = False
        btn_buscar_proveedor.Enabled = False
        txt_id_presentacion_producto.Enabled = False
        txt_nombre_presentacion_producto.Enabled = False
        btn_buscar_presentacion.Enabled = False
        btn_guardar.Visible = False
        btn_actualizar.Visible = False
    End Sub

    Private Sub btn_Confirmar_Pedido_Click(sender As System.Object, e As System.EventArgs) Handles btn_Confirmar_Pedido.Click
        If txt_cantidad_productos.Text = "" Then
            MsgBox("Ingrese la cantidad de productos")
            txt_cantidad_productos.Focus()
            Exit Sub
        End If

        If CInt(txt_cantidad_productos.Text) > CInt(txt_stock_producto.Text) Then
            MsgBox("La cantidad de productos que desea vender excede al stock disponble")
            txt_cantidad_productos.Clear()
            Exit Sub
        End If

        'CARGA EL DGV DE ORDENPEDIDO
        Dim id_producto, cantidad As Integer
        Dim descripcion_producto As String
        Dim precio_venta As Double

        id_producto = txt_id_producto.Text
        descripcion_producto = txt_nombre_producto.Text
        precio_venta = txt_precio_venta_producto.Text
        cantidad = txt_cantidad_productos.Text
        Frm_NuevoOrdenPedido.dgv_detalle_op.Rows.Add(id_producto, cantidad, descripcion_producto, precio_venta)

        PrecioCantidad()
        '  CantidadProductos()
        Subtotal()
        '  FRM_VENTAS.TB_VENTA_DESCUENTO.Clear()
        '  FRM_VENTAS.TB_VENTA_TOTAL.Clear()
        Frm_ListaProductos.Close()
        Me.Hide()
        txt_cantidad_productos.Clear()
        Frm_NuevoOrdenPedido.dgv_detalle_op.ClearSelection()
           End Sub

    'SUMA LA CANTIDAD DE PRODUCTOS DE LA VENTA
    'Public Sub CantidadProductos()
    '    Dim Cantidad_venta As Integer = 0
    '    Dim iCantidad_Venta As Integer = FRM_VENTAS.DGV_VENTAS_BUSCAR.Rows.Count
    '    Dim c As Integer
    '    For c = 0 To iCantidad_Venta - 1
    '        Cantidad_venta = Cantidad_venta + Integer.Parse(FRM_VENTAS.DGV_VENTAS_BUSCAR(1, c).Value)
    '    Next
    '    FRM_VENTAS.LBL_VENTA_CANT_PROD.Text = Format(Cantidad_venta)
    'End Sub

    'CALCULA PRECIO DE VENTA * LA CANTIDAD DE PRODUCTOS
    Private Sub PrecioCantidad()
        Dim total As Double = 0
        Dim ATotal As Integer = Frm_NuevoOrdenPedido.dgv_detalle_op.Rows.Count
        Dim A As Integer
        For A = 0 To ATotal - 1
            total = Frm_NuevoOrdenPedido.dgv_detalle_op(3, A).Value * Double.Parse(Frm_NuevoOrdenPedido.dgv_detalle_op(1, A).Value)
            Frm_NuevoOrdenPedido.dgv_detalle_op.Rows(A).Cells(4).Value = Format(total)
        Next
        Frm_NuevoOrdenPedido.txt_subtotal_op.Text = Format(total)
    End Sub

    ' CALCULA(SUBTOTAL)
    Public Sub Subtotal()
        Dim suma As Double = 0
        Dim ATot As Integer = Frm_NuevoOrdenPedido.dgv_detalle_op.Rows.Count
        Dim Aa As Integer
        For Aa = 0 To ATot - 1
            suma = suma + Frm_NuevoOrdenPedido.dgv_detalle_op.Rows(Aa).Cells(4).Value
        Next
        If Not String.IsNullOrEmpty(Frm_NuevoOrdenPedido.txt_subtotal_op.Text) Then
            Frm_NuevoOrdenPedido.txt_subtotal_op.Text = Format(suma)
        End If
    End Sub

    Private Sub txt_precio_compra_producto_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_precio_compra_producto.KeyPress
        NumerosyDecimal(txt_precio_compra_producto, e)
    End Sub


    Public Sub NumerosyDecimal(ByVal CajaTexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "," And Not CajaTexto.Text.IndexOf(",") Then
            e.Handled = True
        ElseIf e.KeyChar = "," Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_precio_venta_producto_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_precio_venta_producto.KeyPress
        NumerosyDecimal(txt_precio_venta_producto, e)
    End Sub

    Private Sub txt_cantidad_productos_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cantidad_productos.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_stock_producto_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_stock_producto.KeyPress
        NumerosyDecimal(txt_stock_producto, e)
    End Sub

End Class