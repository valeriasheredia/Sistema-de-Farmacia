<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Menu_Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaCategoríaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeCategoríasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PresentaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaPresentaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDePresentacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenDePedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaOrdenDePedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeOrdenesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.LBL_MENU_PERFIL = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBL_MENU_USU = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.OrdenDePedidosToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesiónToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoUsuarioToolStripMenuItem, Me.ListadoDeUsuariosToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'NuevoUsuarioToolStripMenuItem
        '
        Me.NuevoUsuarioToolStripMenuItem.Name = "NuevoUsuarioToolStripMenuItem"
        Me.NuevoUsuarioToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.NuevoUsuarioToolStripMenuItem.Text = "Nuevo Usuario"
        '
        'ListadoDeUsuariosToolStripMenuItem
        '
        Me.ListadoDeUsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarToolStripMenuItem, Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.ListadoDeUsuariosToolStripMenuItem.Name = "ListadoDeUsuariosToolStripMenuItem"
        Me.ListadoDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ListadoDeUsuariosToolStripMenuItem.Text = "Listado de Usuarios"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoEmpleadoToolStripMenuItem, Me.ListaDeEmpleadosToolStripMenuItem})
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'NuevoEmpleadoToolStripMenuItem
        '
        Me.NuevoEmpleadoToolStripMenuItem.Name = "NuevoEmpleadoToolStripMenuItem"
        Me.NuevoEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.NuevoEmpleadoToolStripMenuItem.Text = "Nuevo Empleado"
        '
        'ListaDeEmpleadosToolStripMenuItem
        '
        Me.ListaDeEmpleadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarToolStripMenuItem3, Me.EditarToolStripMenuItem6, Me.EliminarToolStripMenuItem6})
        Me.ListaDeEmpleadosToolStripMenuItem.Name = "ListaDeEmpleadosToolStripMenuItem"
        Me.ListaDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ListaDeEmpleadosToolStripMenuItem.Text = "Lista de Empleados"
        '
        'ConsultarToolStripMenuItem3
        '
        Me.ConsultarToolStripMenuItem3.Name = "ConsultarToolStripMenuItem3"
        Me.ConsultarToolStripMenuItem3.Size = New System.Drawing.Size(125, 22)
        Me.ConsultarToolStripMenuItem3.Text = "Consultar"
        '
        'EditarToolStripMenuItem6
        '
        Me.EditarToolStripMenuItem6.Name = "EditarToolStripMenuItem6"
        Me.EditarToolStripMenuItem6.Size = New System.Drawing.Size(125, 22)
        Me.EditarToolStripMenuItem6.Text = "Editar"
        '
        'EliminarToolStripMenuItem6
        '
        Me.EliminarToolStripMenuItem6.Name = "EliminarToolStripMenuItem6"
        Me.EliminarToolStripMenuItem6.Size = New System.Drawing.Size(125, 22)
        Me.EliminarToolStripMenuItem6.Text = "Eliminar"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoProveedorToolStripMenuItem, Me.ListadoDeProveedoresToolStripMenuItem})
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'NuevoProveedorToolStripMenuItem
        '
        Me.NuevoProveedorToolStripMenuItem.Name = "NuevoProveedorToolStripMenuItem"
        Me.NuevoProveedorToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.NuevoProveedorToolStripMenuItem.Text = "Nuevo Proveedor"
        '
        'ListadoDeProveedoresToolStripMenuItem
        '
        Me.ListadoDeProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarToolStripMenuItem2, Me.EditarToolStripMenuItem2, Me.EliminarToolStripMenuItem2})
        Me.ListadoDeProveedoresToolStripMenuItem.Name = "ListadoDeProveedoresToolStripMenuItem"
        Me.ListadoDeProveedoresToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ListadoDeProveedoresToolStripMenuItem.Text = "Listado de Proveedores"
        '
        'ConsultarToolStripMenuItem2
        '
        Me.ConsultarToolStripMenuItem2.Name = "ConsultarToolStripMenuItem2"
        Me.ConsultarToolStripMenuItem2.Size = New System.Drawing.Size(125, 22)
        Me.ConsultarToolStripMenuItem2.Text = "Consultar"
        '
        'EditarToolStripMenuItem2
        '
        Me.EditarToolStripMenuItem2.Name = "EditarToolStripMenuItem2"
        Me.EditarToolStripMenuItem2.Size = New System.Drawing.Size(125, 22)
        Me.EditarToolStripMenuItem2.Text = "Editar"
        '
        'EliminarToolStripMenuItem2
        '
        Me.EliminarToolStripMenuItem2.Name = "EliminarToolStripMenuItem2"
        Me.EliminarToolStripMenuItem2.Size = New System.Drawing.Size(125, 22)
        Me.EliminarToolStripMenuItem2.Text = "Eliminar"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoClienteToolStripMenuItem, Me.ListadoDeClientesToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'NuevoClienteToolStripMenuItem
        '
        Me.NuevoClienteToolStripMenuItem.Name = "NuevoClienteToolStripMenuItem"
        Me.NuevoClienteToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.NuevoClienteToolStripMenuItem.Text = "Nuevo Cliente"
        '
        'ListadoDeClientesToolStripMenuItem
        '
        Me.ListadoDeClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarToolStripMenuItem1, Me.EditarToolStripMenuItem1, Me.EliminarToolStripMenuItem1})
        Me.ListadoDeClientesToolStripMenuItem.Name = "ListadoDeClientesToolStripMenuItem"
        Me.ListadoDeClientesToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ListadoDeClientesToolStripMenuItem.Text = "Listado de Clientes"
        '
        'ConsultarToolStripMenuItem1
        '
        Me.ConsultarToolStripMenuItem1.Name = "ConsultarToolStripMenuItem1"
        Me.ConsultarToolStripMenuItem1.Size = New System.Drawing.Size(125, 22)
        Me.ConsultarToolStripMenuItem1.Text = "Consultar"
        '
        'EditarToolStripMenuItem1
        '
        Me.EditarToolStripMenuItem1.Name = "EditarToolStripMenuItem1"
        Me.EditarToolStripMenuItem1.Size = New System.Drawing.Size(125, 22)
        Me.EditarToolStripMenuItem1.Text = "Editar"
        '
        'EliminarToolStripMenuItem1
        '
        Me.EliminarToolStripMenuItem1.Name = "EliminarToolStripMenuItem1"
        Me.EliminarToolStripMenuItem1.Size = New System.Drawing.Size(125, 22)
        Me.EliminarToolStripMenuItem1.Text = "Eliminar"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoProductoToolStripMenuItem, Me.ListadoDeProductosToolStripMenuItem, Me.CategoriasToolStripMenuItem, Me.PresentaciónToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'NuevoProductoToolStripMenuItem
        '
        Me.NuevoProductoToolStripMenuItem.Name = "NuevoProductoToolStripMenuItem"
        Me.NuevoProductoToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.NuevoProductoToolStripMenuItem.Text = "Nuevo Producto"
        '
        'ListadoDeProductosToolStripMenuItem
        '
        Me.ListadoDeProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarToolStripMenuItem5, Me.EditarToolStripMenuItem5, Me.EliminarToolStripMenuItem5})
        Me.ListadoDeProductosToolStripMenuItem.Name = "ListadoDeProductosToolStripMenuItem"
        Me.ListadoDeProductosToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.ListadoDeProductosToolStripMenuItem.Text = "Listado de Productos"
        '
        'ConsultarToolStripMenuItem5
        '
        Me.ConsultarToolStripMenuItem5.Name = "ConsultarToolStripMenuItem5"
        Me.ConsultarToolStripMenuItem5.Size = New System.Drawing.Size(125, 22)
        Me.ConsultarToolStripMenuItem5.Text = "Consultar"
        '
        'EditarToolStripMenuItem5
        '
        Me.EditarToolStripMenuItem5.Name = "EditarToolStripMenuItem5"
        Me.EditarToolStripMenuItem5.Size = New System.Drawing.Size(125, 22)
        Me.EditarToolStripMenuItem5.Text = "Editar"
        '
        'EliminarToolStripMenuItem5
        '
        Me.EliminarToolStripMenuItem5.Name = "EliminarToolStripMenuItem5"
        Me.EliminarToolStripMenuItem5.Size = New System.Drawing.Size(125, 22)
        Me.EliminarToolStripMenuItem5.Text = "Eliminar"
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaCategoríaToolStripMenuItem, Me.ListadoDeCategoríasToolStripMenuItem})
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.CategoriasToolStripMenuItem.Text = "Categorías"
        '
        'NuevaCategoríaToolStripMenuItem
        '
        Me.NuevaCategoríaToolStripMenuItem.Name = "NuevaCategoríaToolStripMenuItem"
        Me.NuevaCategoríaToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.NuevaCategoríaToolStripMenuItem.Text = "Nueva Categoría"
        '
        'ListadoDeCategoríasToolStripMenuItem
        '
        Me.ListadoDeCategoríasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem3, Me.EliminarToolStripMenuItem3})
        Me.ListadoDeCategoríasToolStripMenuItem.Name = "ListadoDeCategoríasToolStripMenuItem"
        Me.ListadoDeCategoríasToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ListadoDeCategoríasToolStripMenuItem.Text = "Listado de Categorías"
        '
        'EditarToolStripMenuItem3
        '
        Me.EditarToolStripMenuItem3.Name = "EditarToolStripMenuItem3"
        Me.EditarToolStripMenuItem3.Size = New System.Drawing.Size(117, 22)
        Me.EditarToolStripMenuItem3.Text = "Editar"
        '
        'EliminarToolStripMenuItem3
        '
        Me.EliminarToolStripMenuItem3.Name = "EliminarToolStripMenuItem3"
        Me.EliminarToolStripMenuItem3.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem3.Text = "Eliminar"
        '
        'PresentaciónToolStripMenuItem
        '
        Me.PresentaciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaPresentaciónToolStripMenuItem, Me.ListadoDePresentacionesToolStripMenuItem})
        Me.PresentaciónToolStripMenuItem.Name = "PresentaciónToolStripMenuItem"
        Me.PresentaciónToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.PresentaciónToolStripMenuItem.Text = "Presentación"
        '
        'NuevaPresentaciónToolStripMenuItem
        '
        Me.NuevaPresentaciónToolStripMenuItem.Name = "NuevaPresentaciónToolStripMenuItem"
        Me.NuevaPresentaciónToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.NuevaPresentaciónToolStripMenuItem.Text = "Nueva Presentación"
        '
        'ListadoDePresentacionesToolStripMenuItem
        '
        Me.ListadoDePresentacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem4, Me.EliminarToolStripMenuItem4})
        Me.ListadoDePresentacionesToolStripMenuItem.Name = "ListadoDePresentacionesToolStripMenuItem"
        Me.ListadoDePresentacionesToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.ListadoDePresentacionesToolStripMenuItem.Text = "Listado de Presentaciones"
        '
        'EditarToolStripMenuItem4
        '
        Me.EditarToolStripMenuItem4.Name = "EditarToolStripMenuItem4"
        Me.EditarToolStripMenuItem4.Size = New System.Drawing.Size(117, 22)
        Me.EditarToolStripMenuItem4.Text = "Editar"
        '
        'EliminarToolStripMenuItem4
        '
        Me.EliminarToolStripMenuItem4.Name = "EliminarToolStripMenuItem4"
        Me.EliminarToolStripMenuItem4.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem4.Text = "Eliminar"
        '
        'OrdenDePedidosToolStripMenuItem
        '
        Me.OrdenDePedidosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaOrdenDePedidoToolStripMenuItem, Me.ListadoDeOrdenesToolStripMenuItem})
        Me.OrdenDePedidosToolStripMenuItem.Name = "OrdenDePedidosToolStripMenuItem"
        Me.OrdenDePedidosToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.OrdenDePedidosToolStripMenuItem.Text = "Orden de Pedidos"
        '
        'NuevaOrdenDePedidoToolStripMenuItem
        '
        Me.NuevaOrdenDePedidoToolStripMenuItem.Name = "NuevaOrdenDePedidoToolStripMenuItem"
        Me.NuevaOrdenDePedidoToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.NuevaOrdenDePedidoToolStripMenuItem.Text = "Nueva Orden de Pedido"
        '
        'ListadoDeOrdenesToolStripMenuItem
        '
        Me.ListadoDeOrdenesToolStripMenuItem.Name = "ListadoDeOrdenesToolStripMenuItem"
        Me.ListadoDeOrdenesToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ListadoDeOrdenesToolStripMenuItem.Text = "Listado de Ordenes"
        '
        'StatusStrip
        '
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'LBL_MENU_PERFIL
        '
        Me.LBL_MENU_PERFIL.AutoSize = True
        Me.LBL_MENU_PERFIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_MENU_PERFIL.Location = New System.Drawing.Point(33, 444)
        Me.LBL_MENU_PERFIL.Name = "LBL_MENU_PERFIL"
        Me.LBL_MENU_PERFIL.Size = New System.Drawing.Size(27, 9)
        Me.LBL_MENU_PERFIL.TabIndex = 12
        Me.LBL_MENU_PERFIL.Text = "Label4"
        Me.LBL_MENU_PERFIL.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 444)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 9)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Perfil:"
        Me.Label2.Visible = False
        '
        'LBL_MENU_USU
        '
        Me.LBL_MENU_USU.AutoSize = True
        Me.LBL_MENU_USU.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_MENU_USU.Location = New System.Drawing.Point(33, 433)
        Me.LBL_MENU_USU.Name = "LBL_MENU_USU"
        Me.LBL_MENU_USU.Size = New System.Drawing.Size(27, 9)
        Me.LBL_MENU_USU.TabIndex = 11
        Me.LBL_MENU_USU.Text = "Label3"
        Me.LBL_MENU_USU.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 433)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 9)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Usuario:"
        Me.Label1.Visible = False
        '
        'Frm_Menu_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.LBL_MENU_PERFIL)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LBL_MENU_USU)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Frm_Menu_Principal"
        Me.Text = "Menu Principal"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoDeUsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoDeClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoDeProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdenDePedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaCategoríaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoDeCategoríasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PresentaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaPresentaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoDePresentacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoDeProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaOrdenDePedidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoDeOrdenesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoEmpleadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaDeEmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LBL_MENU_PERFIL As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LBL_MENU_USU As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
