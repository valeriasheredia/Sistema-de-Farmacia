Public Class Frm_ListaUsuarios

    Dim datacontext As New DataFarmacia

    Private Sub btn_modificar_Click(sender As System.Object, e As System.EventArgs) Handles btn_modificar.Click
        If dgv_lista_usuarios.SelectedRows.Count > 0 Then
            frm_nuevo_usuario.Text = "Modificar Usuario"
            If dgv_lista_usuarios.SelectedRows.Count > 0 Then
                frm_nuevo_usuario.txt_id_usuario.Text = dgv_lista_usuarios.Item("id_usuario", dgv_lista_usuarios.SelectedRows(0).Index).Value
                frm_nuevo_usuario.cbo_perfil_usuario.Text = dgv_lista_usuarios.Item("perfil_usuario", dgv_lista_usuarios.SelectedRows(0).Index).Value
                frm_nuevo_usuario.txt_nombre_usuario.Text = dgv_lista_usuarios.Item("nombre_usuario", dgv_lista_usuarios.SelectedRows(0).Index).Value
                frm_nuevo_usuario.txt_contraseña_usuario.Text = dgv_lista_usuarios.Item("contraseña_usuario", dgv_lista_usuarios.SelectedRows(0).Index).Value
            End If
            frm_nuevo_usuario.btn_guardar.Visible = False
            frm_nuevo_usuario.Show()
            Me.Hide()
        Else
            MsgBox("Debe seleccionar un usuario")
        End If
    End Sub

    Private Sub Frm_ListaUsuarios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        armargrilla()
        cargargrilla()
    End Sub

    Private Sub armargrilla()
        dgv_lista_usuarios.Enabled = True
        dgv_lista_usuarios.AutoGenerateColumns = False
        dgv_lista_usuarios.Columns.Clear()

        dgv_lista_usuarios.Columns.Add("id_usuario", "Id_Usuario")
        dgv_lista_usuarios.Columns.Add("nombre_usuario", " Nombre")
        dgv_lista_usuarios.Columns.Add("contraseña_usuario", "Contraseña")
        dgv_lista_usuarios.Columns.Add("perfil_usuario", "Perfil")

        dgv_lista_usuarios.Columns(0).DataPropertyName = "id_usuario"
        dgv_lista_usuarios.Columns(0).Visible = False
        dgv_lista_usuarios.Columns(1).DataPropertyName = "nombre_usuario"
        dgv_lista_usuarios.Columns(2).DataPropertyName = "contraseña_usuario"
        dgv_lista_usuarios.Columns(3).DataPropertyName = "perfil_usuario"

        dgv_lista_usuarios.ClearSelection()
    End Sub

    Public Sub cargargrilla()
        Dim consultausu = From U In datacontext.Usuario
                          Select U.id_usuario, U.nombre_usuario, U.contraseña_usuario, U.perfil_usuario
                          Order By nombre_usuario Ascending
        dgv_lista_usuarios.DataSource = consultausu
    End Sub

    Private Sub btn_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles btn_eliminar.Click
        If dgv_lista_usuarios.SelectedRows.Count > 0 Then
            Dim eliminar = (From C In datacontext.Usuario Where C.id_usuario = CInt(dgv_lista_usuarios.Item("id_usuario", dgv_lista_usuarios.SelectedRows(0).Index).Value)).ToList()(0)

            Select Case MsgBox("Se eliminará el usuario seleccionado, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar usuario")
                Case MsgBoxResult.Yes
                    datacontext.Usuario.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("El usuario ha sido eliminado")
                    Me.cargargrilla()
            End Select
        Else
            MsgBox("Debe seleccionar un usuario")
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub txt_buscar_nombre_usuario_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_buscar_nombre_usuario.TextChanged
        Dim buscar As String
        armargrilla()
        buscar = Me.txt_buscar_nombre_usuario.Text & "*"
        Dim consultaalu = From U In datacontext.Usuario Select U.id_usuario, U.nombre_usuario, U.perfil_usuario, U.contraseña_usuario Where nombre_usuario Like buscar.ToString
        dgv_lista_usuarios.DataSource = consultaalu
    End Sub

    Private Sub btn_Ver_Usuario_Click(sender As System.Object, e As System.EventArgs) Handles btn_Ver_Usuario.Click
        If dgv_lista_usuarios.SelectedRows.Count > 0 Then
            frm_nuevo_usuario.txt_id_usuario.Text = dgv_lista_usuarios.Item("id_usuario", dgv_lista_usuarios.SelectedRows(0).Index).Value
            frm_nuevo_usuario.cbo_perfil_usuario.Text = dgv_lista_usuarios.Item("perfil_usuario", dgv_lista_usuarios.SelectedRows(0).Index).Value
            frm_nuevo_usuario.txt_nombre_usuario.Text = dgv_lista_usuarios.Item("nombre_usuario", dgv_lista_usuarios.SelectedRows(0).Index).Value
            frm_nuevo_usuario.txt_contraseña_usuario.Text = dgv_lista_usuarios.Item("contraseña_usuario", dgv_lista_usuarios.SelectedRows(0).Index).Value

            frm_nuevo_usuario.btn_guardar.Visible = False
            frm_nuevo_usuario.btn_actualizar.Visible = False
            frm_nuevo_usuario.txt_nombre_usuario.Enabled = False
            frm_nuevo_usuario.txt_contraseña_usuario.Enabled = False
            frm_nuevo_usuario.txt_repetir_contraseña.Text = frm_nuevo_usuario.txt_contraseña_usuario.Text
            frm_nuevo_usuario.txt_repetir_contraseña.Enabled = False
            frm_nuevo_usuario.cbo_perfil_usuario.Enabled = False
            frm_nuevo_usuario.Show()
        Else
            MsgBox("Debe seleccionar un usuario")
        End If
    End Sub
End Class