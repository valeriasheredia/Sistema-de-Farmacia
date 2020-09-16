
Public Class Frm_NuevoOrdenPedido

    Dim datacontex As New DataFarmacia

    Private Sub Frm_NuevoOrdenPedido_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label1.Visible = False
        txt_id_orden_pedido.Visible = False
        id_detalle_orden_pedido.Visible = False
        txt_id_detalle_orden_pedido.Visible = False
        Label14.Visible = False
        txt_id_boleta.Visible = False
        btn_buscar_cliente_op.Focus()
        armargrilla()
    End Sub

    Private Sub btn_buscar_cliente_op_Click_1(sender As System.Object, e As System.EventArgs) Handles btn_buscar_cliente_op.Click
        Frm_ListaClientes.Text = "Seleccionar Cliente"
        Frm_ListaClientes.Show()
    End Sub

    Private Sub btn_buscar_empleado_op_Click_1(sender As System.Object, e As System.EventArgs) Handles btn_buscar_empleado_op.Click
        Frm_ListaEmpleados.Text = "Seleccionar Empleado"
        Frm_ListaEmpleados.Show()
    End Sub

    Private Sub btn_agregar_producto_op_Click(sender As System.Object, e As System.EventArgs) Handles btn_agregar_producto_op.Click
        Frm_ListaProductos.Text = "Seleccionar Producto"
        Frm_ListaProductos.btn_eliminar.Visible = False
        Frm_ListaProductos.btn_modificar.Visible = False
        Frm_ListaProductos.btn_Ver.Visible = False
        Frm_ListaProductos.Show()

    End Sub

    Private Sub armargrilla()
        dgv_detalle_op.Enabled = True
        dgv_detalle_op.AutoGenerateColumns = False
        dgv_detalle_op.Columns.Clear()

        dgv_detalle_op.Columns.Add("id_producto", "ID_PRODUCTO")
        dgv_detalle_op.Columns.Add("cantidad", "CANTIDAD")
        dgv_detalle_op.Columns.Add("nombre_producto", "DESCRIPCION")
        dgv_detalle_op.Columns.Add("precio_venta", "PRECIO UNITARIO")
        dgv_detalle_op.Columns.Add("PRECIO TOTAL", "PRECIO TOTAL")

        dgv_detalle_op.Columns(0).DataPropertyName = "id_producto"
        dgv_detalle_op.Columns(0).Visible = False

        dgv_detalle_op.Columns(1).DataPropertyName = "cantidad"
        dgv_detalle_op.Columns(2).DataPropertyName = "nombre_producto"
        dgv_detalle_op.Columns(2).Width = 200
        dgv_detalle_op.Columns(3).DataPropertyName = "precio_venta"
        dgv_detalle_op.Columns(3).Width = 150
        dgv_detalle_op.Columns(4).Width = 150

        dgv_detalle_op.ClearSelection()
    End Sub

    Private Sub txt_descuento_op_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_descuento_op.KeyPress
        NumerosyDecimal(txt_descuento_op, e)
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

    Private Sub txt_descuento_op_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_descuento_op.TextChanged
        If txt_descuento_op.Text = "" Then
            txt_total_op.Text = txt_subtotal_op.Text
        Else
            Dim vsubtotal As Double = txt_subtotal_op.Text
            Dim vdescuento As Double = txt_descuento_op.Text
            Dim vporcentaje As Double
            Dim vtotal As Double
            vporcentaje = vsubtotal * vdescuento / 100
            vtotal = vsubtotal - vporcentaje
            txt_total_op.Text = vtotal
        End If
    End Sub

    Private Sub btn_quitar_producto_op_Click(sender As System.Object, e As System.EventArgs) Handles btn_quitar_producto_op.Click
        If dgv_detalle_op.Rows.Count = 0 Then
            MsgBox("No existen productos por quitar")
        Else
            dgv_detalle_op.Rows.RemoveAt(dgv_detalle_op.CurrentRow.Index)
            Frm_NuevoProducto.Subtotal() 'ACTUALIZA SUB TOTAL DEL DATAGRIDVIEW AL QUITAR UN PRODUCTO DE LA VENTA
            Exit Sub
        End If
    End Sub

    Private Sub btn_guardar_op_Click(sender As System.Object, e As System.EventArgs) Handles btn_guardar_op.Click
        'VALIDA LA CARGA DE CLIENTE
        If txt_id_cliente_op.Text.Length = 0 Or txt_nombre_cliente_op.Text.Length = 0 Or txt_ruc_cliente_op.Text.Length = 0 Or txt_direccion_cliente_op.Text.Length = 0 Or txt_telefono_cliente_op.Text.Length = 0 Then
            MsgBox("Debe seleccionar un cliente")
            btn_buscar_cliente_op.Focus()
            Exit Sub
        End If

        If txt_id_empleado_op.Text.Length = 0 Or txt_nombre_empleado_op.Text.Length = 0 Or txt_cargo_empleado_op.Text.Length = 0 Then
            MsgBox("Debe seleccionar un empleado")
            btn_buscar_empleado_op.Focus()
            Exit Sub
        End If

        'VALIDA CARGA DE PRODUCTOS PARA LA VENTA
        If dgv_detalle_op.Rows.Count = 0 Then
            MsgBox("Debe ingresar productos a la venta")
            dgv_detalle_op.Focus()
            Exit Sub
        End If

        'VALIDA QUE EL TEXTBOX DE DESCUENTO NO ESTE VACIO PARA PODER CALCULAR EL MONTO FINAL DE LA VENTA
        If txt_descuento_op.Text = "" Then
            MsgBox("Debe ingresar el descuento aplicado a la venta")
            txt_descuento_op.Focus()
            Exit Sub
        End If
        Try
            Dim op = New OrdenPedido

            'GUARDA EN LA TABLA ORDEN_PEDIDO
            txt_id_orden_pedido.Text = op.id_orden_pedido
            op.id_orden_pedido = txt_id_orden_pedido.Text
            op.fecha_pedido = dtp_fecha_pedido.Text
            op.id_cliente = txt_id_cliente_op.Text
            op.id_empleado = txt_id_empleado_op.Text
            op.tipo_pago = cbo_tipo_pago_op.Text
            op.total = txt_total_op.Text

            datacontex.OrdenPedido.InsertOnSubmit(op)
            datacontex.SubmitChanges()

            'GUARDA EN LA TABLA DETALLE_ORDEN_PEDIDO
            For Each rows As DataGridViewRow In Me.dgv_detalle_op.Rows
                Dim dop = New DetalleOrdenPedido
                txt_id_detalle_orden_pedido.Text = dop.id_detalle_orden_pedido
                dop.id_detalle_orden_pedido = txt_id_detalle_orden_pedido.Text
                dop.id_producto = rows.Cells(0).Value
                dop.cantidad = rows.Cells(1).Value
                dop.precio_venta = rows.Cells(3).Value
                dop.importe = 1
                txt_id_orden_pedido.Text = op.id_orden_pedido
                dop.id_orden_pedido = txt_id_orden_pedido.Text

                datacontex.DetalleOrdenPedido.InsertOnSubmit(dop)
                datacontex.SubmitChanges()
            Next

            'GUARDA EN LA TABLA BOLETA
            Dim bol = New Boleta

            txt_id_boleta.Text = bol.id_boleta
            bol.id_boleta = txt_id_boleta.Text
            bol.fecha_boleta = op.fecha_pedido
            bol.fecha_boleta = dtp_fecha_pedido.Text
            bol.id_empleado = txt_id_empleado_op.Text
            bol.id_cliente = txt_id_cliente_op.Text
            bol.id_orden_pedido = txt_id_orden_pedido.Text
            bol.subtotal = txt_subtotal_op.Text
            bol.descuento = txt_descuento_op.Text
            bol.total = txt_total_op.Text

            datacontex.Boleta.InsertOnSubmit(bol)
            datacontex.SubmitChanges()

            MsgBox("La venta fue realizada correctamente", vbInformation)
            'FRM_PRODUCTOS.DisminuirStock()
            'BTN_VENTA_IMPRIMIR.Enabled = True
            btn_guardar_op.Enabled = False

        Catch ex As Exception
            MsgBox("La venta no fue cargada, pongase en contacto con el administrador")
            Exit Sub
        End Try
    End Sub
End Class