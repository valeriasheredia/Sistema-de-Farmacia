<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ListaClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ListaClientes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbt_dni_cliente = New System.Windows.Forms.RadioButton()
        Me.rbt_ruc_clientes = New System.Windows.Forms.RadioButton()
        Me.txt_buscar_cliente_dni = New System.Windows.Forms.TextBox()
        Me.txt_buscar_cliente_ruc = New System.Windows.Forms.TextBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.dgv_lista_clientes = New System.Windows.Forms.DataGridView()
        Me.btn_Ver_Cliente = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_lista_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbt_dni_cliente)
        Me.GroupBox1.Controls.Add(Me.rbt_ruc_clientes)
        Me.GroupBox1.Controls.Add(Me.txt_buscar_cliente_dni)
        Me.GroupBox1.Controls.Add(Me.txt_buscar_cliente_ruc)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'rbt_dni_cliente
        '
        resources.ApplyResources(Me.rbt_dni_cliente, "rbt_dni_cliente")
        Me.rbt_dni_cliente.Name = "rbt_dni_cliente"
        Me.rbt_dni_cliente.TabStop = True
        Me.rbt_dni_cliente.UseVisualStyleBackColor = True
        '
        'rbt_ruc_clientes
        '
        resources.ApplyResources(Me.rbt_ruc_clientes, "rbt_ruc_clientes")
        Me.rbt_ruc_clientes.Name = "rbt_ruc_clientes"
        Me.rbt_ruc_clientes.TabStop = True
        Me.rbt_ruc_clientes.UseVisualStyleBackColor = True
        '
        'txt_buscar_cliente_dni
        '
        resources.ApplyResources(Me.txt_buscar_cliente_dni, "txt_buscar_cliente_dni")
        Me.txt_buscar_cliente_dni.Name = "txt_buscar_cliente_dni"
        '
        'txt_buscar_cliente_ruc
        '
        resources.ApplyResources(Me.txt_buscar_cliente_ruc, "txt_buscar_cliente_ruc")
        Me.txt_buscar_cliente_ruc.Name = "txt_buscar_cliente_ruc"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btn_cancelar, "btn_cancelar")
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btn_eliminar, "btn_eliminar")
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_modificar
        '
        Me.btn_modificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btn_modificar, "btn_modificar")
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.UseVisualStyleBackColor = False
        '
        'dgv_lista_clientes
        '
        Me.dgv_lista_clientes.AllowUserToAddRows = False
        Me.dgv_lista_clientes.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_lista_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_lista_clientes.DefaultCellStyle = DataGridViewCellStyle1
        resources.ApplyResources(Me.dgv_lista_clientes, "dgv_lista_clientes")
        Me.dgv_lista_clientes.Name = "dgv_lista_clientes"
        Me.dgv_lista_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'btn_Ver_Cliente
        '
        Me.btn_Ver_Cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btn_Ver_Cliente, "btn_Ver_Cliente")
        Me.btn_Ver_Cliente.Name = "btn_Ver_Cliente"
        Me.btn_Ver_Cliente.UseVisualStyleBackColor = False
        '
        'Frm_ListaClientes
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.Controls.Add(Me.btn_Ver_Cliente)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.dgv_lista_clientes)
        Me.Name = "Frm_ListaClientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_lista_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_buscar_cliente_ruc As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents dgv_lista_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents txt_buscar_cliente_dni As System.Windows.Forms.TextBox
    Friend WithEvents rbt_dni_cliente As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_ruc_clientes As System.Windows.Forms.RadioButton
    Friend WithEvents btn_Ver_Cliente As System.Windows.Forms.Button
End Class
