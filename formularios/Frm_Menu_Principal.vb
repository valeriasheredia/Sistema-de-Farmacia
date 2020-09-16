Imports System.Windows.Forms

Public Class Frm_Menu_Principal

    Public QUIENLLAMOMODIFICARCLIENTE As Form

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Public formularios As New List(Of Form)

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        'LISTA DE FORMULARIOS ABIERTOS
        Dim fr As Form
        For Each fr In Application.OpenForms
            formularios.Add(fr)
        Next
        'ABRE FORMULARIO DE INICIO DE SESION
        Dim frinicio As New Frm_Ingreso
        frinicio.Show()
        'CIERRRA TODOS LOS FORMS ABIERTOS
        For Each frm As Form In formularios
            frm.Close()
        Next
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
        Application.Exit()
        Me.Dispose()
    End Sub

    Private Sub NuevoUsuarioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevoUsuarioToolStripMenuItem.Click
        frm_nuevo_usuario.Text = "Nuevo Usuario"
        frm_nuevo_usuario.btn_guardar.Location = New Point(394, 194)
        frm_nuevo_usuario.btn_actualizar.Visible = False
        frm_nuevo_usuario.Show()

    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarToolStripMenuItem.Click

        Frm_ListaUsuarios.Text = "Consultar Usuario"
        Frm_ListaUsuarios.btn_Ver_Usuario.Location = New Point(265, 257)
        Frm_ListaUsuarios.btn_eliminar.Visible = False
        Frm_ListaUsuarios.btn_modificar.Visible = False
        Frm_ListaUsuarios.Show()
        Frm_ListaUsuarios.dgv_lista_usuarios.ClearSelection()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditarToolStripMenuItem.Click

        Frm_ListaUsuarios.Text = "Modificar Usuario"
        Frm_ListaUsuarios.btn_modificar.Location = New Point(265, 257)
        Frm_ListaUsuarios.btn_eliminar.Visible = False
        Frm_ListaUsuarios.btn_Ver_Usuario.Visible = False
        Frm_ListaUsuarios.Show()
        Frm_ListaUsuarios.dgv_lista_usuarios.ClearSelection()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarToolStripMenuItem.Click

        Frm_ListaUsuarios.Text = "Eliminar Usuario"
        Frm_ListaUsuarios.btn_eliminar.Location = New Point(265, 257)
        Frm_ListaUsuarios.btn_modificar.Visible = False
        Frm_ListaUsuarios.btn_Ver_Usuario.Visible = False
        Frm_ListaUsuarios.Show()
        Frm_ListaUsuarios.dgv_lista_usuarios.ClearSelection()
    End Sub

    Private Sub NuevoClienteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevoClienteToolStripMenuItem.Click
        Frm_NuevoCliente.Text = "Nuevo Cliente"
        Frm_NuevoCliente.btn_guardar.Location = New Point(420, 306)
        Frm_NuevoCliente.btn_actualizar.Visible = False
        Frm_NuevoCliente.Show()
        Frm_NuevoCliente.txt_Ruc_Cliente.Focus()
    End Sub

    Private Sub EliminarToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles EliminarToolStripMenuItem1.Click
        Frm_ListaClientes.Text = "Eliminar Cliente"
        Frm_ListaClientes.btn_eliminar.Location = New Point(507, 335)
        Frm_ListaClientes.btn_Ver_Cliente.Visible = False
        Frm_ListaClientes.btn_modificar.Visible = False
        Frm_ListaClientes.Show()
        Frm_ListaClientes.dgv_lista_clientes.ClearSelection()
    End Sub

    Private Sub NuevoProveedorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevoProveedorToolStripMenuItem.Click
        Frm_NuevoProveedor.Text = "Nuevo Proveedor"
        Frm_NuevoProveedor.btn_guardar.Location = New Point(414, 193)
        Frm_NuevoProveedor.btn_actualizar.Visible = False
        Frm_NuevoProveedor.Show()
    End Sub

    Private Sub ConsultarToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarToolStripMenuItem2.Click
        Frm_ListaProveedores.Text = "Consultar Proveedor"
        Frm_ListaProveedores.btn_ver_proveedor.Location = New Point(279, 328)
        Frm_ListaProveedores.btn_eliminar.Visible = False
        Frm_ListaProveedores.btn_modificar.Visible = False
        Frm_ListaProveedores.Show()
        Frm_ListaProveedores.dgv_lista_proveedores.ClearSelection()
    End Sub

    Private Sub EditarToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles EditarToolStripMenuItem2.Click
        Frm_ListaProveedores.Text = "Modificar Proveedor"
        Frm_ListaProveedores.btn_modificar.Location = New Point(279, 328)
        Frm_ListaProveedores.btn_eliminar.Visible = False
        Frm_ListaProveedores.btn_ver_proveedor.Visible = False
        Frm_ListaProveedores.Show()
        Frm_ListaProveedores.dgv_lista_proveedores.ClearSelection()
    End Sub

    Private Sub EliminarToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles EliminarToolStripMenuItem2.Click
        Frm_ListaProveedores.Text = "Eliminar Proveedor"
        Frm_ListaProveedores.btn_eliminar.Location = New Point(279, 328)
        Frm_ListaProveedores.btn_modificar.Visible = False
        Frm_ListaProveedores.btn_ver_proveedor.Visible = False
        Frm_ListaProveedores.Show()
        Frm_ListaProveedores.dgv_lista_proveedores.ClearSelection()
    End Sub

    Private Sub NuevaCategoríaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevaCategoríaToolStripMenuItem.Click
        Frm_NuevaCategoria.Text = "Nueva Categoría"
        Frm_NuevaCategoria.btn_guardar.Location = New Point(122, 77)
        Frm_NuevaCategoria.btn_actualizar.Visible = False
        Frm_NuevaCategoria.Label1.Visible = False
        Frm_NuevaCategoria.txt_id_categoria.Visible = False
        Frm_NuevaCategoria.Show()
    End Sub

    Private Sub EditarToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles EditarToolStripMenuItem3.Click
        Frm_ListaCategorias.Text = "Modificar Categoría"
        Frm_ListaCategorias.btn_modificar.Location = New Point(133, 255)
        Frm_ListaCategorias.btn_eliminar.Visible = False
        Frm_ListaCategorias.Show()
        Frm_ListaCategorias.dgv_lista_categoria.ClearSelection()
    End Sub

    Private Sub EliminarToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles EliminarToolStripMenuItem3.Click
        Frm_ListaCategorias.Text = "Eliminar Categoría"
        Frm_ListaCategorias.btn_eliminar.Location = New Point(133, 255)
        Frm_ListaCategorias.btn_modificar.Visible = False
        Frm_ListaCategorias.Show()
        Frm_ListaCategorias.dgv_lista_categoria.ClearSelection()
    End Sub

    Private Sub NuevaPresentaciónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevaPresentaciónToolStripMenuItem.Click
        Frm_NuevaPresentacion.Text = "Nueva Presentación"
        Frm_NuevaPresentacion.btn_guardar.Location = New Point(121, 77)
        Frm_NuevaPresentacion.btn_actualizar.Visible = False
        Frm_NuevaPresentacion.Show()
    End Sub

    Private Sub EditarToolStripMenuItem4_Click(sender As System.Object, e As System.EventArgs) Handles EditarToolStripMenuItem4.Click
        Frm_ListaPresentacion.Text = "Modificar Presentación"
        Frm_ListaPresentacion.btn_modificar.Location = New Point(131, 264)
        Frm_ListaPresentacion.btn_eliminar.Visible = False
        Frm_ListaPresentacion.Show()
        Frm_ListaPresentacion.dgv_lista_presentacion.ClearSelection()
    End Sub

    Private Sub EliminarToolStripMenuItem4_Click(sender As System.Object, e As System.EventArgs) Handles EliminarToolStripMenuItem4.Click
        Frm_ListaPresentacion.Text = "Eliminar Presentación"
        Frm_ListaPresentacion.btn_eliminar.Location = New Point(131, 264)
        Frm_ListaPresentacion.btn_modificar.Visible = False
        Frm_ListaPresentacion.Show()
        Frm_ListaPresentacion.dgv_lista_presentacion.ClearSelection()
    End Sub

    Private Sub EditarToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles EditarToolStripMenuItem1.Click
        Frm_ListaClientes.Text = "Modificar Cliente"
        Frm_ListaClientes.btn_modificar.Location = New Point(507, 335)
        Frm_ListaClientes.btn_eliminar.Visible = False
        Frm_ListaClientes.btn_Ver_Cliente.Visible = False
        Frm_ListaClientes.Show()
        Frm_ListaClientes.dgv_lista_clientes.ClearSelection()
    End Sub

    Private Sub NuevoProductoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevoProductoToolStripMenuItem.Click
        Frm_NuevoProducto.GroupBox2.Visible = False
        Frm_NuevoProducto.btn_guardar.Location = New Point(551, 299)
        Frm_NuevoProducto.btn_actualizar.Visible = False
        Frm_NuevoProducto.txt_id_categoria_producto.Enabled = False
        Frm_NuevoProducto.txt_nombre_categoria_producto.Enabled = False
        Frm_NuevoProducto.txt_id_proveedor_producto.Enabled = False
        Frm_NuevoProducto.txt_nombre_proveedor_producto.Enabled = False
        Frm_NuevoProducto.txt_id_presentacion_producto.Enabled = False
        Frm_NuevoProducto.txt_nombre_presentacion_producto.Enabled = False
        Frm_NuevoProducto.Show()
    End Sub

    Private Sub ConsultarToolStripMenuItem5_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarToolStripMenuItem5.Click
        Frm_ListaProductos.Text = "Consultar Producto"
        Frm_ListaProductos.btn_Ver.Location = New Point(480, 339)
        Frm_ListaProductos.btn_Agregar_Carrito.Visible = False
        Frm_ListaProductos.btn_eliminar.Visible = False
        Frm_ListaProductos.btn_modificar.Visible = False
        Frm_ListaProductos.Show()
        Frm_ListaProductos.dgv_lista_productos.ClearSelection()
    End Sub

    Private Sub EditarToolStripMenuItem5_Click(sender As System.Object, e As System.EventArgs) Handles EditarToolStripMenuItem5.Click
        Frm_ListaProductos.Text = "Modificar Producto"
        Frm_ListaProductos.btn_modificar.Location = New Point(480, 339)
        Frm_ListaProductos.btn_Agregar_Carrito.Visible = False
        Frm_ListaProductos.btn_eliminar.Visible = False
        Frm_ListaProductos.btn_Ver.Visible = False
        Frm_ListaProductos.Show()
        Frm_ListaProductos.dgv_lista_productos.ClearSelection()
    End Sub

    Private Sub EliminarToolStripMenuItem5_Click(sender As System.Object, e As System.EventArgs) Handles EliminarToolStripMenuItem5.Click
        Frm_ListaProductos.Text = "Eliminar Producto"
        Frm_ListaProductos.btn_eliminar.Location = New Point(480, 339)
        Frm_ListaProductos.btn_Agregar_Carrito.Visible = False
        Frm_ListaProductos.btn_modificar.Visible = False
        Frm_ListaProductos.btn_Ver.Visible = False
        Frm_ListaProductos.Show()
        Frm_ListaProductos.dgv_lista_productos.ClearSelection()
    End Sub

    Private Sub ConsultarToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarToolStripMenuItem1.Click
        Frm_ListaClientes.Text = "Consultar Cliente"
        Frm_ListaClientes.btn_Ver_Cliente.Location = New Point(507, 335)
        Frm_ListaClientes.btn_eliminar.Visible = False
        Frm_ListaClientes.btn_modificar.Visible = False
        Frm_ListaClientes.Show()
        Frm_ListaClientes.dgv_lista_clientes.ClearSelection()
    End Sub

    Private Sub NuevaOrdenDePedidoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevaOrdenDePedidoToolStripMenuItem.Click
        Frm_NuevoOrdenPedido.txt_id_cliente_op.Enabled = False
        Frm_NuevoOrdenPedido.txt_nombre_cliente_op.Enabled = False
        Frm_NuevoOrdenPedido.txt_direccion_cliente_op.Enabled = False
        Frm_NuevoOrdenPedido.txt_telefono_cliente_op.Enabled = False
        Frm_NuevoOrdenPedido.txt_ruc_cliente_op.Enabled = False

        Frm_NuevoOrdenPedido.txt_id_empleado_op.Enabled = False
        Frm_NuevoOrdenPedido.txt_nombre_empleado_op.Enabled = False
        Frm_NuevoOrdenPedido.txt_cargo_empleado_op.Enabled = False
        Frm_NuevoOrdenPedido.Show()
    End Sub

    Private Sub NuevoEmpleadoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevoEmpleadoToolStripMenuItem.Click
        Frm_NuevoEmpleado.Text = "Nuevo Empleado"
        Frm_NuevoEmpleado.btn_guardar.Location = New Point(420, 306)
        Frm_NuevoEmpleado.btn_actualizar.Visible = False
        Frm_NuevoEmpleado.Show()
    End Sub

    Private Sub ConsultarToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarToolStripMenuItem3.Click
        Frm_ListaEmpleados.Text = "Consultar Empleado"
        Frm_ListaEmpleados.btn_Ver.Location = New Point(281, 338)
        Frm_ListaEmpleados.btn_eliminar.Visible = False
        Frm_ListaEmpleados.btn_modificar.Visible = False
        Frm_ListaEmpleados.Show()
        Frm_ListaEmpleados.dgv_lista_empleados.ClearSelection()
    End Sub

    Private Sub EditarToolStripMenuItem6_Click(sender As System.Object, e As System.EventArgs) Handles EditarToolStripMenuItem6.Click
        Frm_ListaEmpleados.Text = "Editar Empleado"
        Frm_ListaEmpleados.btn_modificar.Location = New Point(281, 338)
        Frm_ListaEmpleados.btn_eliminar.Visible = False
        Frm_ListaEmpleados.btn_Ver.Visible = False
        Frm_ListaEmpleados.Show()
        Frm_ListaEmpleados.dgv_lista_empleados.ClearSelection()
    End Sub

    Private Sub EliminarToolStripMenuItem6_Click(sender As System.Object, e As System.EventArgs) Handles EliminarToolStripMenuItem6.Click
        Frm_ListaEmpleados.Text = "Eliminar Empleado"
        Frm_ListaEmpleados.btn_eliminar.Location = New Point(281, 338)
        Frm_ListaEmpleados.btn_Ver.Visible = False
        Frm_ListaEmpleados.btn_modificar.Visible = False
        Frm_ListaEmpleados.Show()
        Frm_ListaEmpleados.dgv_lista_empleados.ClearSelection()
    End Sub

End Class
