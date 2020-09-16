<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Ingreso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Ingreso))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_contraseña_usuario = New System.Windows.Forms.TextBox()
        Me.txt_nombre_usuario = New System.Windows.Forms.TextBox()
        Me.BTN_INGR_CANCELAR = New System.Windows.Forms.Button()
        Me.BTN_INGR_ACEPTAR = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(161, 142)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txt_contraseña_usuario
        '
        Me.txt_contraseña_usuario.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contraseña_usuario.Location = New System.Drawing.Point(299, 83)
        Me.txt_contraseña_usuario.Name = "txt_contraseña_usuario"
        Me.txt_contraseña_usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_contraseña_usuario.Size = New System.Drawing.Size(155, 22)
        Me.txt_contraseña_usuario.TabIndex = 10
        '
        'txt_nombre_usuario
        '
        Me.txt_nombre_usuario.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre_usuario.Location = New System.Drawing.Point(299, 44)
        Me.txt_nombre_usuario.Name = "txt_nombre_usuario"
        Me.txt_nombre_usuario.Size = New System.Drawing.Size(155, 22)
        Me.txt_nombre_usuario.TabIndex = 8
        '
        'BTN_INGR_CANCELAR
        '
        Me.BTN_INGR_CANCELAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_INGR_CANCELAR.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_INGR_CANCELAR.Location = New System.Drawing.Point(354, 122)
        Me.BTN_INGR_CANCELAR.Name = "BTN_INGR_CANCELAR"
        Me.BTN_INGR_CANCELAR.Size = New System.Drawing.Size(100, 40)
        Me.BTN_INGR_CANCELAR.TabIndex = 12
        Me.BTN_INGR_CANCELAR.Text = "Salir"
        Me.BTN_INGR_CANCELAR.UseVisualStyleBackColor = False
        '
        'BTN_INGR_ACEPTAR
        '
        Me.BTN_INGR_ACEPTAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_INGR_ACEPTAR.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_INGR_ACEPTAR.Location = New System.Drawing.Point(248, 122)
        Me.BTN_INGR_ACEPTAR.Name = "BTN_INGR_ACEPTAR"
        Me.BTN_INGR_ACEPTAR.Size = New System.Drawing.Size(100, 40)
        Me.BTN_INGR_ACEPTAR.TabIndex = 11
        Me.BTN_INGR_ACEPTAR.Text = "Ingresar"
        Me.BTN_INGR_ACEPTAR.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(201, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(227, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Usuario"
        '
        'Frm_Ingreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(468, 183)
        Me.Controls.Add(Me.txt_contraseña_usuario)
        Me.Controls.Add(Me.txt_nombre_usuario)
        Me.Controls.Add(Me.BTN_INGR_CANCELAR)
        Me.Controls.Add(Me.BTN_INGR_ACEPTAR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Frm_Ingreso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso al Sistema"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_contraseña_usuario As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_usuario As System.Windows.Forms.TextBox
    Friend WithEvents BTN_INGR_CANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTN_INGR_ACEPTAR As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
