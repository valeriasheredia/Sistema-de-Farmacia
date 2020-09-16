<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ListaProductos
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtp_fecha_vencimiento_producto = New System.Windows.Forms.DateTimePicker()
        Me.rbt_fecha_vencimiento = New System.Windows.Forms.RadioButton()
        Me.rbt_nombre_producto = New System.Windows.Forms.RadioButton()
        Me.txt_buscar_nombre_producto = New System.Windows.Forms.TextBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.dgv_lista_productos = New System.Windows.Forms.DataGridView()
        Me.txt_buscar_cliente_ruc = New System.Windows.Forms.TextBox()
        Me.btn_Agregar_Carrito = New System.Windows.Forms.Button()
        Me.btn_Ver = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_lista_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtp_fecha_vencimiento_producto)
        Me.GroupBox1.Controls.Add(Me.rbt_fecha_vencimiento)
        Me.GroupBox1.Controls.Add(Me.rbt_nombre_producto)
        Me.GroupBox1.Controls.Add(Me.txt_buscar_nombre_producto)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(25, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 74)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'dtp_fecha_vencimiento_producto
        '
        Me.dtp_fecha_vencimiento_producto.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_vencimiento_producto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_vencimiento_producto.Location = New System.Drawing.Point(198, 46)
        Me.dtp_fecha_vencimiento_producto.Name = "dtp_fecha_vencimiento_producto"
        Me.dtp_fecha_vencimiento_producto.Size = New System.Drawing.Size(140, 22)
        Me.dtp_fecha_vencimiento_producto.TabIndex = 4
        '
        'rbt_fecha_vencimiento
        '
        Me.rbt_fecha_vencimiento.AutoSize = True
        Me.rbt_fecha_vencimiento.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt_fecha_vencimiento.Location = New System.Drawing.Point(24, 46)
        Me.rbt_fecha_vencimiento.Name = "rbt_fecha_vencimiento"
        Me.rbt_fecha_vencimiento.Size = New System.Drawing.Size(168, 20)
        Me.rbt_fecha_vencimiento.TabIndex = 3
        Me.rbt_fecha_vencimiento.TabStop = True
        Me.rbt_fecha_vencimiento.Text = "Fecha Vencimiento"
        Me.rbt_fecha_vencimiento.UseVisualStyleBackColor = True
        '
        'rbt_nombre_producto
        '
        Me.rbt_nombre_producto.AutoSize = True
        Me.rbt_nombre_producto.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt_nombre_producto.Location = New System.Drawing.Point(107, 19)
        Me.rbt_nombre_producto.Name = "rbt_nombre_producto"
        Me.rbt_nombre_producto.Size = New System.Drawing.Size(85, 20)
        Me.rbt_nombre_producto.TabIndex = 2
        Me.rbt_nombre_producto.TabStop = True
        Me.rbt_nombre_producto.Text = "Nombre"
        Me.rbt_nombre_producto.UseVisualStyleBackColor = True
        '
        'txt_buscar_nombre_producto
        '
        Me.txt_buscar_nombre_producto.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_buscar_nombre_producto.Location = New System.Drawing.Point(198, 18)
        Me.txt_buscar_nombre_producto.Name = "txt_buscar_nombre_producto"
        Me.txt_buscar_nombre_producto.Size = New System.Drawing.Size(140, 22)
        Me.txt_buscar_nombre_producto.TabIndex = 0
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_cancelar.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Location = New System.Drawing.Point(586, 339)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(100, 40)
        Me.btn_cancelar.TabIndex = 34
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_eliminar.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.Location = New System.Drawing.Point(480, 339)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(100, 40)
        Me.btn_eliminar.TabIndex = 33
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_modificar
        '
        Me.btn_modificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_modificar.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar.Location = New System.Drawing.Point(374, 339)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(100, 40)
        Me.btn_modificar.TabIndex = 32
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = False
        '
        'dgv_lista_productos
        '
        Me.dgv_lista_productos.AllowUserToAddRows = False
        Me.dgv_lista_productos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_lista_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_lista_productos.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_lista_productos.Location = New System.Drawing.Point(25, 114)
        Me.dgv_lista_productos.Name = "dgv_lista_productos"
        Me.dgv_lista_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_lista_productos.Size = New System.Drawing.Size(661, 207)
        Me.dgv_lista_productos.TabIndex = 31
        '
        'txt_buscar_cliente_ruc
        '
        Me.txt_buscar_cliente_ruc.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_buscar_cliente_ruc.Location = New System.Drawing.Point(198, 18)
        Me.txt_buscar_cliente_ruc.Name = "txt_buscar_cliente_ruc"
        Me.txt_buscar_cliente_ruc.Size = New System.Drawing.Size(140, 22)
        Me.txt_buscar_cliente_ruc.TabIndex = 0
        '
        'btn_Agregar_Carrito
        '
        Me.btn_Agregar_Carrito.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_Agregar_Carrito.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Agregar_Carrito.Location = New System.Drawing.Point(25, 339)
        Me.btn_Agregar_Carrito.Name = "btn_Agregar_Carrito"
        Me.btn_Agregar_Carrito.Size = New System.Drawing.Size(144, 40)
        Me.btn_Agregar_Carrito.TabIndex = 48
        Me.btn_Agregar_Carrito.Text = "Agregar al Carrito"
        Me.btn_Agregar_Carrito.UseVisualStyleBackColor = False
        '
        'btn_Ver
        '
        Me.btn_Ver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_Ver.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Ver.Location = New System.Drawing.Point(268, 339)
        Me.btn_Ver.Name = "btn_Ver"
        Me.btn_Ver.Size = New System.Drawing.Size(100, 40)
        Me.btn_Ver.TabIndex = 49
        Me.btn_Ver.Text = "Ver"
        Me.btn_Ver.UseVisualStyleBackColor = False
        '
        'Frm_ListaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(709, 396)
        Me.Controls.Add(Me.btn_Ver)
        Me.Controls.Add(Me.btn_Agregar_Carrito)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.dgv_lista_productos)
        Me.Name = "Frm_ListaProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Productos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_lista_productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbt_fecha_vencimiento As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_nombre_producto As System.Windows.Forms.RadioButton
    Friend WithEvents txt_buscar_nombre_producto As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents dgv_lista_productos As System.Windows.Forms.DataGridView
    Friend WithEvents dtp_fecha_vencimiento_producto As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_buscar_cliente_ruc As System.Windows.Forms.TextBox
    Friend WithEvents btn_Agregar_Carrito As System.Windows.Forms.Button
    Friend WithEvents btn_Ver As System.Windows.Forms.Button
End Class
