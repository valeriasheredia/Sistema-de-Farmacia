Public Class Frm_Ingreso
    Dim datacontext As New DataFarmacia

    Private Sub BTN_INGR_ACEPTAR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_INGR_ACEPTAR.Click
        Try
            Dim Buscausuario = (From I In datacontext.Usuario Where I.nombre_usuario = txt_nombre_usuario.Text And I.contraseña_usuario = txt_contraseña_usuario.Text).ToList()(0)

            If Buscausuario.perfil_usuario = "Administrador" Then

            ElseIf Buscausuario.perfil_usuario = "Operador" Then
                Frm_Menu_Principal.UsuariosToolStripMenuItem.DropDownItems(0).Enabled = False

            ElseIf Buscausuario.perfil_usuario = "Ayudante" Then
                Frm_Menu_Principal.UsuariosToolStripMenuItem.DropDownItems(0).Enabled = False
                Frm_Menu_Principal.UsuariosToolStripMenuItem.DropDownItems(1).Enabled = False
                Frm_Menu_Principal.ListadoDeUsuariosToolStripMenuItem.DropDownItems(1).Enabled = False
                Frm_Menu_Principal.ListadoDeUsuariosToolStripMenuItem.DropDownItems(2).Enabled = False

                Frm_Menu_Principal.EmpleadosToolStripMenuItem.DropDownItems(0).Enabled = False
                Frm_Menu_Principal.EmpleadosToolStripMenuItem.DropDownItems(1).Enabled = True
                Frm_Menu_Principal.ListaDeEmpleadosToolStripMenuItem.DropDownItems(0).Enabled = True
                Frm_Menu_Principal.ListaDeEmpleadosToolStripMenuItem.DropDownItems(1).Enabled = False
                Frm_Menu_Principal.ListaDeEmpleadosToolStripMenuItem.DropDownItems(2).Enabled = False

                Frm_Menu_Principal.ProveedoresToolStripMenuItem.DropDownItems(0).Enabled = False
                Frm_Menu_Principal.ProveedoresToolStripMenuItem.DropDownItems(1).Enabled = True
                Frm_Menu_Principal.ListadoDeProveedoresToolStripMenuItem.DropDownItems(0).Enabled = True
                Frm_Menu_Principal.ListadoDeProveedoresToolStripMenuItem.DropDownItems(1).Enabled = False
                Frm_Menu_Principal.ListadoDeProveedoresToolStripMenuItem.DropDownItems(2).Enabled = False
                Frm_Menu_Principal.ClientesToolStripMenuItem.DropDownItems(0).Enabled = False
                Frm_Menu_Principal.ClientesToolStripMenuItem.DropDownItems(1).Enabled = True
                Frm_Menu_Principal.ListadoDeClientesToolStripMenuItem.DropDownItems(0).Enabled = True
                Frm_Menu_Principal.ListadoDeClientesToolStripMenuItem.DropDownItems(1).Enabled = False
                Frm_Menu_Principal.ListadoDeClientesToolStripMenuItem.DropDownItems(2).Enabled = False


                Frm_Menu_Principal.ProductosToolStripMenuItem.DropDownItems(0).Enabled = False
                Frm_Menu_Principal.ProductosToolStripMenuItem.DropDownItems(1).Enabled = True

                Frm_Menu_Principal.ProductosToolStripMenuItem.DropDownItems(2).Enabled = False
                Frm_Menu_Principal.ProductosToolStripMenuItem.DropDownItems(3).Enabled = False
                Frm_Menu_Principal.ListadoDeProductosToolStripMenuItem.DropDownItems(0).Enabled = True
                Frm_Menu_Principal.ListadoDeProductosToolStripMenuItem.DropDownItems(1).Enabled = False
                Frm_Menu_Principal.ListadoDeProductosToolStripMenuItem.DropDownItems(2).Enabled = False


            End If

            'PASAR USUARIO Y PERFIL A LOS LABEL DEL MENUUU!!!! PARA LUEGO TOMAR EL USUARIO PARA
            'ACTUALIZAR PASS DESDE ADENTRO
            Frm_Menu_Principal.LBL_MENU_PERFIL.Text = Buscausuario.perfil_usuario.ToString
            Frm_Menu_Principal.LBL_MENU_USU.Text = Buscausuario.perfil_usuario.ToString


            Frm_Menu_Principal.Show()
            Me.Finalize()
            Me.Close()
        Catch ex As Exception
            MsgBox("Verifique Usuario y contraseña!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Inicio de sesión")
            txt_nombre_usuario.Select()
            limpiarcontroles()
        End Try
    End Sub

    Public Sub limpiarcontroles()
        txt_nombre_usuario.Clear()
        txt_contraseña_usuario.Clear()

    End Sub

    Private Sub BTN_INGR_CANCELAR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_INGR_CANCELAR.Click
        Me.Close()
        Application.Exit()
        Me.Dispose()
    End Sub

    Private Sub Frm_Ingreso_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txt_nombre_usuario.Focus()
    End Sub
End Class