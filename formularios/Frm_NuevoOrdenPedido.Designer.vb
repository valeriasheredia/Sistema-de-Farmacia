<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_NuevoOrdenPedido
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_total_op = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_id_orden_pedido = New System.Windows.Forms.TextBox()
        Me.dgv_detalle_op = New System.Windows.Forms.DataGridView()
        Me.btn_agregar_producto_op = New System.Windows.Forms.Button()
        Me.btn_quitar_producto_op = New System.Windows.Forms.Button()
        Me.txt_id_detalle_orden_pedido = New System.Windows.Forms.TextBox()
        Me.id_detalle_orden_pedido = New System.Windows.Forms.Label()
        Me.txt_subtotal_op = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_cancelar_op = New System.Windows.Forms.Button()
        Me.btn_guardar_op = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_cargo_empleado_op = New System.Windows.Forms.TextBox()
        Me.txt_nombre_empleado_op = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_id_empleado_op = New System.Windows.Forms.TextBox()
        Me.btn_buscar_empleado_op = New System.Windows.Forms.Button()
        Me.dtp_fecha_pedido = New System.Windows.Forms.DateTimePicker()
        Me.cbo_tipo_pago_op = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_direccion_cliente_op = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_telefono_cliente_op = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_ruc_cliente_op = New System.Windows.Forms.TextBox()
        Me.btn_buscar_cliente_op = New System.Windows.Forms.Button()
        Me.txt_nombre_cliente_op = New System.Windows.Forms.TextBox()
        Me.txt_id_cliente_op = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_descuento_op = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_id_boleta = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.rbt_Factura = New System.Windows.Forms.RadioButton()
        Me.rbt_Boleta = New System.Windows.Forms.RadioButton()
        CType(Me.dgv_detalle_op, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(45, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 16)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Total"
        '
        'txt_total_op
        '
        Me.txt_total_op.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_op.Location = New System.Drawing.Point(9, 129)
        Me.txt_total_op.Name = "txt_total_op"
        Me.txt_total_op.Size = New System.Drawing.Size(112, 22)
        Me.txt_total_op.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(573, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "id_orden_pedido"
        '
        'txt_id_orden_pedido
        '
        Me.txt_id_orden_pedido.Location = New System.Drawing.Point(665, 161)
        Me.txt_id_orden_pedido.Name = "txt_id_orden_pedido"
        Me.txt_id_orden_pedido.Size = New System.Drawing.Size(36, 20)
        Me.txt_id_orden_pedido.TabIndex = 0
        '
        'dgv_detalle_op
        '
        Me.dgv_detalle_op.AllowUserToAddRows = False
        Me.dgv_detalle_op.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_detalle_op.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalle_op.Location = New System.Drawing.Point(26, 63)
        Me.dgv_detalle_op.Name = "dgv_detalle_op"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_detalle_op.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_detalle_op.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_detalle_op.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_detalle_op.Size = New System.Drawing.Size(633, 193)
        Me.dgv_detalle_op.TabIndex = 37
        '
        'btn_agregar_producto_op
        '
        Me.btn_agregar_producto_op.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_agregar_producto_op.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar_producto_op.Location = New System.Drawing.Point(356, 14)
        Me.btn_agregar_producto_op.Name = "btn_agregar_producto_op"
        Me.btn_agregar_producto_op.Size = New System.Drawing.Size(150, 37)
        Me.btn_agregar_producto_op.TabIndex = 38
        Me.btn_agregar_producto_op.Text = "Agregar Producto"
        Me.btn_agregar_producto_op.UseVisualStyleBackColor = False
        '
        'btn_quitar_producto_op
        '
        Me.btn_quitar_producto_op.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_quitar_producto_op.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quitar_producto_op.Location = New System.Drawing.Point(512, 14)
        Me.btn_quitar_producto_op.Name = "btn_quitar_producto_op"
        Me.btn_quitar_producto_op.Size = New System.Drawing.Size(150, 37)
        Me.btn_quitar_producto_op.TabIndex = 38
        Me.btn_quitar_producto_op.Text = "Quitar Producto"
        Me.btn_quitar_producto_op.UseVisualStyleBackColor = False
        '
        'txt_id_detalle_orden_pedido
        '
        Me.txt_id_detalle_orden_pedido.Location = New System.Drawing.Point(844, 161)
        Me.txt_id_detalle_orden_pedido.Name = "txt_id_detalle_orden_pedido"
        Me.txt_id_detalle_orden_pedido.Size = New System.Drawing.Size(36, 20)
        Me.txt_id_detalle_orden_pedido.TabIndex = 39
        '
        'id_detalle_orden_pedido
        '
        Me.id_detalle_orden_pedido.AutoSize = True
        Me.id_detalle_orden_pedido.Location = New System.Drawing.Point(715, 164)
        Me.id_detalle_orden_pedido.Name = "id_detalle_orden_pedido"
        Me.id_detalle_orden_pedido.Size = New System.Drawing.Size(123, 13)
        Me.id_detalle_orden_pedido.TabIndex = 40
        Me.id_detalle_orden_pedido.Text = "id_detalle_orden_pedido"
        '
        'txt_subtotal_op
        '
        Me.txt_subtotal_op.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subtotal_op.Location = New System.Drawing.Point(10, 32)
        Me.txt_subtotal_op.Name = "txt_subtotal_op"
        Me.txt_subtotal_op.Size = New System.Drawing.Size(112, 22)
        Me.txt_subtotal_op.TabIndex = 41
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(29, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 16)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Sub Total"
        '
        'btn_cancelar_op
        '
        Me.btn_cancelar_op.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_cancelar_op.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar_op.Location = New System.Drawing.Point(790, 482)
        Me.btn_cancelar_op.Name = "btn_cancelar_op"
        Me.btn_cancelar_op.Size = New System.Drawing.Size(102, 37)
        Me.btn_cancelar_op.TabIndex = 44
        Me.btn_cancelar_op.Text = "Cancelar"
        Me.btn_cancelar_op.UseVisualStyleBackColor = False
        '
        'btn_guardar_op
        '
        Me.btn_guardar_op.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_guardar_op.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar_op.Location = New System.Drawing.Point(682, 482)
        Me.btn_guardar_op.Name = "btn_guardar_op"
        Me.btn_guardar_op.Size = New System.Drawing.Size(102, 37)
        Me.btn_guardar_op.TabIndex = 43
        Me.btn_guardar_op.Text = "Guardar"
        Me.btn_guardar_op.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txt_cargo_empleado_op)
        Me.GroupBox3.Controls.Add(Me.txt_nombre_empleado_op)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txt_id_empleado_op)
        Me.GroupBox3.Controls.Add(Me.btn_buscar_empleado_op)
        Me.GroupBox3.Location = New System.Drawing.Point(490, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(399, 87)
        Me.GroupBox3.TabIndex = 52
        Me.GroupBox3.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(33, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 16)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Cargo"
        '
        'txt_cargo_empleado_op
        '
        Me.txt_cargo_empleado_op.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cargo_empleado_op.Location = New System.Drawing.Point(85, 59)
        Me.txt_cargo_empleado_op.Name = "txt_cargo_empleado_op"
        Me.txt_cargo_empleado_op.Size = New System.Drawing.Size(236, 22)
        Me.txt_cargo_empleado_op.TabIndex = 45
        '
        'txt_nombre_empleado_op
        '
        Me.txt_nombre_empleado_op.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre_empleado_op.Location = New System.Drawing.Point(122, 19)
        Me.txt_nombre_empleado_op.MaxLength = 10
        Me.txt_nombre_empleado_op.Name = "txt_nombre_empleado_op"
        Me.txt_nombre_empleado_op.Size = New System.Drawing.Size(199, 22)
        Me.txt_nombre_empleado_op.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Empleado"
        '
        'txt_id_empleado_op
        '
        Me.txt_id_empleado_op.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_empleado_op.Location = New System.Drawing.Point(85, 19)
        Me.txt_id_empleado_op.MaxLength = 10
        Me.txt_id_empleado_op.Name = "txt_id_empleado_op"
        Me.txt_id_empleado_op.Size = New System.Drawing.Size(31, 22)
        Me.txt_id_empleado_op.TabIndex = 14
        '
        'btn_buscar_empleado_op
        '
        Me.btn_buscar_empleado_op.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_buscar_empleado_op.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar_empleado_op.Location = New System.Drawing.Point(327, 43)
        Me.btn_buscar_empleado_op.Name = "btn_buscar_empleado_op"
        Me.btn_buscar_empleado_op.Size = New System.Drawing.Size(53, 38)
        Me.btn_buscar_empleado_op.TabIndex = 42
        Me.btn_buscar_empleado_op.Text = "..."
        Me.btn_buscar_empleado_op.UseVisualStyleBackColor = False
        '
        'dtp_fecha_pedido
        '
        Me.dtp_fecha_pedido.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_pedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_pedido.Location = New System.Drawing.Point(129, 173)
        Me.dtp_fecha_pedido.Name = "dtp_fecha_pedido"
        Me.dtp_fecha_pedido.Size = New System.Drawing.Size(150, 22)
        Me.dtp_fecha_pedido.TabIndex = 49
        Me.dtp_fecha_pedido.TabStop = False
        '
        'cbo_tipo_pago_op
        '
        Me.cbo_tipo_pago_op.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_tipo_pago_op.FormattingEnabled = True
        Me.cbo_tipo_pago_op.Items.AddRange(New Object() {"Contado", "Tarj. Crédito", "Tarj. Débito", "Cheque", "Otro"})
        Me.cbo_tipo_pago_op.Location = New System.Drawing.Point(390, 173)
        Me.cbo_tipo_pago_op.Name = "cbo_tipo_pago_op"
        Me.cbo_tipo_pago_op.Size = New System.Drawing.Size(150, 24)
        Me.cbo_tipo_pago_op.TabIndex = 50
        Me.cbo_tipo_pago_op.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_direccion_cliente_op)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txt_telefono_cliente_op)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_ruc_cliente_op)
        Me.GroupBox2.Controls.Add(Me.btn_buscar_cliente_op)
        Me.GroupBox2.Controls.Add(Me.txt_nombre_cliente_op)
        Me.GroupBox2.Controls.Add(Me.txt_id_cliente_op)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(450, 143)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 16)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Dirección"
        '
        'txt_direccion_cliente_op
        '
        Me.txt_direccion_cliente_op.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_direccion_cliente_op.Location = New System.Drawing.Point(104, 94)
        Me.txt_direccion_cliente_op.Name = "txt_direccion_cliente_op"
        Me.txt_direccion_cliente_op.Size = New System.Drawing.Size(280, 22)
        Me.txt_direccion_cliente_op.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(176, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Teléfono"
        '
        'txt_telefono_cliente_op
        '
        Me.txt_telefono_cliente_op.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefono_cliente_op.Location = New System.Drawing.Point(255, 54)
        Me.txt_telefono_cliente_op.Name = "txt_telefono_cliente_op"
        Me.txt_telefono_cliente_op.Size = New System.Drawing.Size(129, 22)
        Me.txt_telefono_cliente_op.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 16)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Ruc"
        '
        'txt_ruc_cliente_op
        '
        Me.txt_ruc_cliente_op.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ruc_cliente_op.Location = New System.Drawing.Point(70, 53)
        Me.txt_ruc_cliente_op.Name = "txt_ruc_cliente_op"
        Me.txt_ruc_cliente_op.Size = New System.Drawing.Size(100, 22)
        Me.txt_ruc_cliente_op.TabIndex = 43
        '
        'btn_buscar_cliente_op
        '
        Me.btn_buscar_cliente_op.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_buscar_cliente_op.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar_cliente_op.Location = New System.Drawing.Point(390, 78)
        Me.btn_buscar_cliente_op.Name = "btn_buscar_cliente_op"
        Me.btn_buscar_cliente_op.Size = New System.Drawing.Size(53, 38)
        Me.btn_buscar_cliente_op.TabIndex = 42
        Me.btn_buscar_cliente_op.Text = "..."
        Me.btn_buscar_cliente_op.UseVisualStyleBackColor = False
        '
        'txt_nombre_cliente_op
        '
        Me.txt_nombre_cliente_op.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre_cliente_op.Location = New System.Drawing.Point(107, 15)
        Me.txt_nombre_cliente_op.MaxLength = 10
        Me.txt_nombre_cliente_op.Name = "txt_nombre_cliente_op"
        Me.txt_nombre_cliente_op.Size = New System.Drawing.Size(277, 22)
        Me.txt_nombre_cliente_op.TabIndex = 37
        Me.txt_nombre_cliente_op.TabStop = False
        '
        'txt_id_cliente_op
        '
        Me.txt_id_cliente_op.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_cliente_op.Location = New System.Drawing.Point(70, 15)
        Me.txt_id_cliente_op.MaxLength = 2
        Me.txt_id_cliente_op.Name = "txt_id_cliente_op"
        Me.txt_id_cliente_op.Size = New System.Drawing.Size(31, 22)
        Me.txt_id_cliente_op.TabIndex = 24
        Me.txt_id_cliente_op.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 16)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Cliente"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(76, 178)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 16)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(285, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Tipo de Pago"
        '
        'txt_descuento_op
        '
        Me.txt_descuento_op.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descuento_op.Location = New System.Drawing.Point(9, 85)
        Me.txt_descuento_op.Name = "txt_descuento_op"
        Me.txt_descuento_op.Size = New System.Drawing.Size(112, 22)
        Me.txt_descuento_op.TabIndex = 54
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(23, 66)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 16)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "Descuento"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_descuento_op)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txt_subtotal_op)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txt_total_op)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(685, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(135, 157)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_id_boleta)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Controls.Add(Me.btn_quitar_producto_op)
        Me.GroupBox4.Controls.Add(Me.btn_agregar_producto_op)
        Me.GroupBox4.Controls.Add(Me.dgv_detalle_op)
        Me.GroupBox4.Location = New System.Drawing.Point(42, 206)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(847, 267)
        Me.GroupBox4.TabIndex = 57
        Me.GroupBox4.TabStop = False
        '
        'txt_id_boleta
        '
        Me.txt_id_boleta.Location = New System.Drawing.Point(773, 13)
        Me.txt_id_boleta.Name = "txt_id_boleta"
        Me.txt_id_boleta.Size = New System.Drawing.Size(36, 20)
        Me.txt_id_boleta.TabIndex = 57
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(719, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 13)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "id_boleta"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.rbt_Factura)
        Me.GroupBox5.Controls.Add(Me.rbt_Boleta)
        Me.GroupBox5.Location = New System.Drawing.Point(490, 109)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(399, 46)
        Me.GroupBox5.TabIndex = 58
        Me.GroupBox5.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(165, 16)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Tipo de Comprobante"
        '
        'rbt_Factura
        '
        Me.rbt_Factura.AutoSize = True
        Me.rbt_Factura.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt_Factura.Location = New System.Drawing.Point(288, 16)
        Me.rbt_Factura.Name = "rbt_Factura"
        Me.rbt_Factura.Size = New System.Drawing.Size(84, 20)
        Me.rbt_Factura.TabIndex = 1
        Me.rbt_Factura.TabStop = True
        Me.rbt_Factura.Text = "Factura"
        Me.rbt_Factura.UseVisualStyleBackColor = True
        '
        'rbt_Boleta
        '
        Me.rbt_Boleta.AutoSize = True
        Me.rbt_Boleta.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt_Boleta.Location = New System.Drawing.Point(209, 16)
        Me.rbt_Boleta.Name = "rbt_Boleta"
        Me.rbt_Boleta.Size = New System.Drawing.Size(73, 20)
        Me.rbt_Boleta.TabIndex = 0
        Me.rbt_Boleta.TabStop = True
        Me.rbt_Boleta.Text = "Boleta"
        Me.rbt_Boleta.UseVisualStyleBackColor = True
        '
        'Frm_NuevoOrdenPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(908, 531)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dtp_fecha_pedido)
        Me.Controls.Add(Me.cbo_tipo_pago_op)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_cancelar_op)
        Me.Controls.Add(Me.btn_guardar_op)
        Me.Controls.Add(Me.txt_id_detalle_orden_pedido)
        Me.Controls.Add(Me.id_detalle_orden_pedido)
        Me.Controls.Add(Me.txt_id_orden_pedido)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "Frm_NuevoOrdenPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva Orden de Pedido"
        CType(Me.dgv_detalle_op, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_total_op As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_id_orden_pedido As System.Windows.Forms.TextBox
    Friend WithEvents dgv_detalle_op As System.Windows.Forms.DataGridView
    Friend WithEvents btn_agregar_producto_op As System.Windows.Forms.Button
    Friend WithEvents btn_quitar_producto_op As System.Windows.Forms.Button
    Friend WithEvents txt_id_detalle_orden_pedido As System.Windows.Forms.TextBox
    Friend WithEvents id_detalle_orden_pedido As System.Windows.Forms.Label
    Friend WithEvents txt_subtotal_op As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar_op As System.Windows.Forms.Button
    Friend WithEvents btn_guardar_op As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_cargo_empleado_op As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_empleado_op As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_id_empleado_op As System.Windows.Forms.TextBox
    Friend WithEvents btn_buscar_empleado_op As System.Windows.Forms.Button
    Friend WithEvents dtp_fecha_pedido As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbo_tipo_pago_op As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_direccion_cliente_op As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_telefono_cliente_op As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_ruc_cliente_op As System.Windows.Forms.TextBox
    Friend WithEvents btn_buscar_cliente_op As System.Windows.Forms.Button
    Friend WithEvents txt_nombre_cliente_op As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_cliente_op As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_descuento_op As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_id_boleta As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rbt_Factura As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_Boleta As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
