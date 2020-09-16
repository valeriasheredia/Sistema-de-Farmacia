<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_NuevoProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_NuevoProducto))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_Confirmar_Pedido = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_cantidad_productos = New System.Windows.Forms.TextBox()
        Me.btn_buscar_presentacion = New System.Windows.Forms.Button()
        Me.btn_buscar_proveedor = New System.Windows.Forms.Button()
        Me.btn_buscar_categoria = New System.Windows.Forms.Button()
        Me.txt_nombre_presentacion_producto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_id_presentacion_producto = New System.Windows.Forms.TextBox()
        Me.txt_nombre_proveedor_producto = New System.Windows.Forms.TextBox()
        Me.txt_nombre_categoria_producto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_precio_venta_producto = New System.Windows.Forms.TextBox()
        Me.dtp_fecha_vencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_id_categoria_producto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_stock_producto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_id_proveedor_producto = New System.Windows.Forms.TextBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_precio_compra_producto = New System.Windows.Forms.TextBox()
        Me.txt_nombre_producto = New System.Windows.Forms.TextBox()
        Me.txt_id_producto = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btn_buscar_presentacion)
        Me.GroupBox1.Controls.Add(Me.btn_buscar_proveedor)
        Me.GroupBox1.Controls.Add(Me.btn_buscar_categoria)
        Me.GroupBox1.Controls.Add(Me.txt_nombre_presentacion_producto)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_id_presentacion_producto)
        Me.GroupBox1.Controls.Add(Me.txt_nombre_proveedor_producto)
        Me.GroupBox1.Controls.Add(Me.txt_nombre_categoria_producto)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_precio_venta_producto)
        Me.GroupBox1.Controls.Add(Me.dtp_fecha_vencimiento)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txt_id_categoria_producto)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txt_stock_producto)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_id_proveedor_producto)
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.btn_actualizar)
        Me.GroupBox1.Controls.Add(Me.btn_guardar)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_precio_compra_producto)
        Me.GroupBox1.Controls.Add(Me.txt_nombre_producto)
        Me.GroupBox1.Controls.Add(Me.txt_id_producto)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(775, 357)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_Confirmar_Pedido)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_cantidad_productos)
        Me.GroupBox2.Location = New System.Drawing.Point(44, 205)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(183, 146)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        '
        'btn_Confirmar_Pedido
        '
        Me.btn_Confirmar_Pedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_Confirmar_Pedido.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Confirmar_Pedido.Location = New System.Drawing.Point(20, 95)
        Me.btn_Confirmar_Pedido.Name = "btn_Confirmar_Pedido"
        Me.btn_Confirmar_Pedido.Size = New System.Drawing.Size(144, 40)
        Me.btn_Confirmar_Pedido.TabIndex = 48
        Me.btn_Confirmar_Pedido.Text = "Confirmar Pedido"
        Me.btn_Confirmar_Pedido.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(53, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 16)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Cantidad"
        '
        'txt_cantidad_productos
        '
        Me.txt_cantidad_productos.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantidad_productos.Location = New System.Drawing.Point(56, 38)
        Me.txt_cantidad_productos.Multiline = True
        Me.txt_cantidad_productos.Name = "txt_cantidad_productos"
        Me.txt_cantidad_productos.Size = New System.Drawing.Size(68, 46)
        Me.txt_cantidad_productos.TabIndex = 43
        Me.txt_cantidad_productos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_buscar_presentacion
        '
        Me.btn_buscar_presentacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_buscar_presentacion.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar_presentacion.Location = New System.Drawing.Point(704, 248)
        Me.btn_buscar_presentacion.Name = "btn_buscar_presentacion"
        Me.btn_buscar_presentacion.Size = New System.Drawing.Size(53, 30)
        Me.btn_buscar_presentacion.TabIndex = 42
        Me.btn_buscar_presentacion.Text = "..."
        Me.btn_buscar_presentacion.UseVisualStyleBackColor = False
        '
        'btn_buscar_proveedor
        '
        Me.btn_buscar_proveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_buscar_proveedor.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar_proveedor.Location = New System.Drawing.Point(704, 210)
        Me.btn_buscar_proveedor.Name = "btn_buscar_proveedor"
        Me.btn_buscar_proveedor.Size = New System.Drawing.Size(53, 30)
        Me.btn_buscar_proveedor.TabIndex = 42
        Me.btn_buscar_proveedor.Text = "..."
        Me.btn_buscar_proveedor.UseVisualStyleBackColor = False
        '
        'btn_buscar_categoria
        '
        Me.btn_buscar_categoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_buscar_categoria.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar_categoria.Location = New System.Drawing.Point(704, 165)
        Me.btn_buscar_categoria.Name = "btn_buscar_categoria"
        Me.btn_buscar_categoria.Size = New System.Drawing.Size(53, 30)
        Me.btn_buscar_categoria.TabIndex = 42
        Me.btn_buscar_categoria.Text = "..."
        Me.btn_buscar_categoria.UseVisualStyleBackColor = False
        '
        'txt_nombre_presentacion_producto
        '
        Me.txt_nombre_presentacion_producto.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre_presentacion_producto.Location = New System.Drawing.Point(434, 252)
        Me.txt_nombre_presentacion_producto.MaxLength = 10
        Me.txt_nombre_presentacion_producto.Name = "txt_nombre_presentacion_producto"
        Me.txt_nombre_presentacion_producto.Size = New System.Drawing.Size(264, 22)
        Me.txt_nombre_presentacion_producto.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(266, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 16)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Presentación"
        '
        'txt_id_presentacion_producto
        '
        Me.txt_id_presentacion_producto.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_presentacion_producto.Location = New System.Drawing.Point(375, 252)
        Me.txt_id_presentacion_producto.MaxLength = 10
        Me.txt_id_presentacion_producto.Name = "txt_id_presentacion_producto"
        Me.txt_id_presentacion_producto.Size = New System.Drawing.Size(53, 22)
        Me.txt_id_presentacion_producto.TabIndex = 39
        '
        'txt_nombre_proveedor_producto
        '
        Me.txt_nombre_proveedor_producto.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre_proveedor_producto.Location = New System.Drawing.Point(434, 214)
        Me.txt_nombre_proveedor_producto.MaxLength = 10
        Me.txt_nombre_proveedor_producto.Name = "txt_nombre_proveedor_producto"
        Me.txt_nombre_proveedor_producto.Size = New System.Drawing.Size(264, 22)
        Me.txt_nombre_proveedor_producto.TabIndex = 38
        '
        'txt_nombre_categoria_producto
        '
        Me.txt_nombre_categoria_producto.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre_categoria_producto.Location = New System.Drawing.Point(434, 169)
        Me.txt_nombre_categoria_producto.MaxLength = 10
        Me.txt_nombre_categoria_producto.Name = "txt_nombre_categoria_producto"
        Me.txt_nombre_categoria_producto.Size = New System.Drawing.Size(264, 22)
        Me.txt_nombre_categoria_producto.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(539, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 16)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Precio Venta"
        '
        'txt_precio_venta_producto
        '
        Me.txt_precio_venta_producto.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precio_venta_producto.Location = New System.Drawing.Point(645, 75)
        Me.txt_precio_venta_producto.Name = "txt_precio_venta_producto"
        Me.txt_precio_venta_producto.Size = New System.Drawing.Size(112, 22)
        Me.txt_precio_venta_producto.TabIndex = 35
        '
        'dtp_fecha_vencimiento
        '
        Me.dtp_fecha_vencimiento.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_vencimiento.Location = New System.Drawing.Point(467, 122)
        Me.dtp_fecha_vencimiento.Name = "dtp_fecha_vencimiento"
        Me.dtp_fecha_vencimiento.Size = New System.Drawing.Size(135, 22)
        Me.dtp_fecha_vencimiento.TabIndex = 33
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(292, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(169, 16)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Fecha de Vencimiento"
        '
        'txt_id_categoria_producto
        '
        Me.txt_id_categoria_producto.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_categoria_producto.Location = New System.Drawing.Point(375, 169)
        Me.txt_id_categoria_producto.MaxLength = 2
        Me.txt_id_categoria_producto.Name = "txt_id_categoria_producto"
        Me.txt_id_categoria_producto.Size = New System.Drawing.Size(53, 22)
        Me.txt_id_categoria_producto.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(292, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 16)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Categoría"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(23, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(230, 154)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'txt_stock_producto
        '
        Me.txt_stock_producto.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_stock_producto.Location = New System.Drawing.Point(677, 122)
        Me.txt_stock_producto.Name = "txt_stock_producto"
        Me.txt_stock_producto.Size = New System.Drawing.Size(80, 22)
        Me.txt_stock_producto.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(286, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Proveedor"
        '
        'txt_id_proveedor_producto
        '
        Me.txt_id_proveedor_producto.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_proveedor_producto.Location = New System.Drawing.Point(375, 214)
        Me.txt_id_proveedor_producto.MaxLength = 10
        Me.txt_id_proveedor_producto.Name = "txt_id_proveedor_producto"
        Me.txt_id_proveedor_producto.Size = New System.Drawing.Size(53, 22)
        Me.txt_id_proveedor_producto.TabIndex = 14
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_cancelar.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Location = New System.Drawing.Point(657, 299)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(100, 40)
        Me.btn_cancelar.TabIndex = 13
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_actualizar
        '
        Me.btn_actualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_actualizar.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_actualizar.Location = New System.Drawing.Point(551, 299)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(100, 40)
        Me.btn_actualizar.TabIndex = 12
        Me.btn_actualizar.Text = "Actualizar"
        Me.btn_actualizar.UseVisualStyleBackColor = False
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_guardar.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.Location = New System.Drawing.Point(445, 299)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(100, 40)
        Me.btn_guardar.TabIndex = 11
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(623, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Stock"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(278, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Precio Compra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(289, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(278, 299)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "id_producto"
        Me.Label1.Visible = False
        '
        'txt_precio_compra_producto
        '
        Me.txt_precio_compra_producto.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precio_compra_producto.Location = New System.Drawing.Point(399, 75)
        Me.txt_precio_compra_producto.Name = "txt_precio_compra_producto"
        Me.txt_precio_compra_producto.Size = New System.Drawing.Size(112, 22)
        Me.txt_precio_compra_producto.TabIndex = 2
        '
        'txt_nombre_producto
        '
        Me.txt_nombre_producto.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre_producto.Location = New System.Drawing.Point(363, 28)
        Me.txt_nombre_producto.Name = "txt_nombre_producto"
        Me.txt_nombre_producto.Size = New System.Drawing.Size(394, 22)
        Me.txt_nombre_producto.TabIndex = 1
        '
        'txt_id_producto
        '
        Me.txt_id_producto.Location = New System.Drawing.Point(345, 294)
        Me.txt_id_producto.Name = "txt_id_producto"
        Me.txt_id_producto.Size = New System.Drawing.Size(36, 20)
        Me.txt_id_producto.TabIndex = 0
        Me.txt_id_producto.Visible = False
        '
        'Frm_NuevoProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(802, 385)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_NuevoProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Producto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_fecha_vencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_id_categoria_producto As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_stock_producto As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_id_proveedor_producto As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_actualizar As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_precio_compra_producto As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_producto As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_producto As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_precio_venta_producto As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_presentacion_producto As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_id_presentacion_producto As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_proveedor_producto As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_categoria_producto As System.Windows.Forms.TextBox
    Friend WithEvents btn_buscar_presentacion As System.Windows.Forms.Button
    Friend WithEvents btn_buscar_proveedor As System.Windows.Forms.Button
    Friend WithEvents btn_buscar_categoria As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_cantidad_productos As System.Windows.Forms.TextBox
    Friend WithEvents btn_Confirmar_Pedido As System.Windows.Forms.Button
End Class
