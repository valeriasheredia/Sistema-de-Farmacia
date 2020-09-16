<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ListaEmpleados
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbt_cargo_empleado = New System.Windows.Forms.RadioButton()
        Me.rbt_nombre_empleado = New System.Windows.Forms.RadioButton()
        Me.txt_buscar_cargo_empleado = New System.Windows.Forms.TextBox()
        Me.txt_buscar_nombre_empleado = New System.Windows.Forms.TextBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.dgv_lista_empleados = New System.Windows.Forms.DataGridView()
        Me.btn_Ver = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_lista_empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbt_cargo_empleado)
        Me.GroupBox1.Controls.Add(Me.rbt_nombre_empleado)
        Me.GroupBox1.Controls.Add(Me.txt_buscar_cargo_empleado)
        Me.GroupBox1.Controls.Add(Me.txt_buscar_nombre_empleado)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(28, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(278, 74)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'rbt_cargo_empleado
        '
        Me.rbt_cargo_empleado.AutoSize = True
        Me.rbt_cargo_empleado.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt_cargo_empleado.Location = New System.Drawing.Point(24, 46)
        Me.rbt_cargo_empleado.Name = "rbt_cargo_empleado"
        Me.rbt_cargo_empleado.Size = New System.Drawing.Size(69, 20)
        Me.rbt_cargo_empleado.TabIndex = 3
        Me.rbt_cargo_empleado.TabStop = True
        Me.rbt_cargo_empleado.Text = "Cargo"
        Me.rbt_cargo_empleado.UseVisualStyleBackColor = True
        '
        'rbt_nombre_empleado
        '
        Me.rbt_nombre_empleado.AutoSize = True
        Me.rbt_nombre_empleado.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt_nombre_empleado.Location = New System.Drawing.Point(24, 19)
        Me.rbt_nombre_empleado.Name = "rbt_nombre_empleado"
        Me.rbt_nombre_empleado.Size = New System.Drawing.Size(85, 20)
        Me.rbt_nombre_empleado.TabIndex = 2
        Me.rbt_nombre_empleado.TabStop = True
        Me.rbt_nombre_empleado.Text = "Nombre"
        Me.rbt_nombre_empleado.UseVisualStyleBackColor = True
        '
        'txt_buscar_cargo_empleado
        '
        Me.txt_buscar_cargo_empleado.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_buscar_cargo_empleado.Location = New System.Drawing.Point(115, 45)
        Me.txt_buscar_cargo_empleado.Name = "txt_buscar_cargo_empleado"
        Me.txt_buscar_cargo_empleado.Size = New System.Drawing.Size(140, 22)
        Me.txt_buscar_cargo_empleado.TabIndex = 1
        '
        'txt_buscar_nombre_empleado
        '
        Me.txt_buscar_nombre_empleado.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_buscar_nombre_empleado.Location = New System.Drawing.Point(115, 19)
        Me.txt_buscar_nombre_empleado.Name = "txt_buscar_nombre_empleado"
        Me.txt_buscar_nombre_empleado.Size = New System.Drawing.Size(140, 22)
        Me.txt_buscar_nombre_empleado.TabIndex = 0
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_cancelar.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Location = New System.Drawing.Point(387, 338)
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
        Me.btn_eliminar.Location = New System.Drawing.Point(281, 338)
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
        Me.btn_modificar.Location = New System.Drawing.Point(175, 338)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(100, 40)
        Me.btn_modificar.TabIndex = 32
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = False
        '
        'dgv_lista_empleados
        '
        Me.dgv_lista_empleados.AllowUserToAddRows = False
        Me.dgv_lista_empleados.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_lista_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_lista_empleados.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_lista_empleados.Location = New System.Drawing.Point(28, 113)
        Me.dgv_lista_empleados.Name = "dgv_lista_empleados"
        Me.dgv_lista_empleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_lista_empleados.Size = New System.Drawing.Size(459, 207)
        Me.dgv_lista_empleados.TabIndex = 31
        '
        'btn_Ver
        '
        Me.btn_Ver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_Ver.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Ver.Location = New System.Drawing.Point(69, 338)
        Me.btn_Ver.Name = "btn_Ver"
        Me.btn_Ver.Size = New System.Drawing.Size(100, 40)
        Me.btn_Ver.TabIndex = 36
        Me.btn_Ver.Text = "Ver"
        Me.btn_Ver.UseVisualStyleBackColor = False
        '
        'Frm_ListaEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(512, 398)
        Me.Controls.Add(Me.btn_Ver)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.dgv_lista_empleados)
        Me.Name = "Frm_ListaEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Empleados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_lista_empleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbt_cargo_empleado As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_nombre_empleado As System.Windows.Forms.RadioButton
    Friend WithEvents txt_buscar_cargo_empleado As System.Windows.Forms.TextBox
    Friend WithEvents txt_buscar_nombre_empleado As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents dgv_lista_empleados As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Ver As System.Windows.Forms.Button
End Class
