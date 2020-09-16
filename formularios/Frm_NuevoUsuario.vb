Public Class frm_nuevo_usuario

    Dim datacontext As New DataFarmacia

    Private Sub frm_nuevo_usuario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_guardar_Click(sender As System.Object, e As System.EventArgs) Handles btn_guardar.Click

        Try
            Dim buscausu = (From usu In datacontext.Usuario Select usu.nombre_usuario Where nombre_usuario = txt_nombre_usuario.Text.ToUpper).Any
            If buscausu = True Then
                MsgBox("El usuario ingresado ya existe")
                limpiarcontroles()
                Exit Sub
            End If
            If txt_nombre_usuario.Text.Length = 0 Or txt_contraseña_usuario.Text.Length = 0 Or cbo_perfil_usuario.Text.Length = 0 Then
                MsgBox("Debe completar todos los campos requeridos")
                Exit Sub
            End If
            If txt_contraseña_usuario.Text <> txt_repetir_contraseña.Text Then
                MsgBox("Las contraseñas no coinciden")
                txt_contraseña_usuario.Clear()
                txt_repetir_contraseña.Clear()
                Exit Sub
            Else
                Dim usu = New Usuario
                usu.nombre_usuario = txt_nombre_usuario.Text
                usu.contraseña_usuario = txt_contraseña_usuario.Text
                usu.perfil_usuario = cbo_perfil_usuario.Text

                datacontext.Usuario.InsertOnSubmit(usu)
                datacontext.SubmitChanges()
                MsgBox("El usuario se ha creado correctamente", vbInformation)
                limpiarcontroles()
                '  Frm_ListaUsuarios.cargargrilla()
            End If
        Catch ex As Exception

            MsgBox("El usuario NO fue creado")
            limpiarcontroles()
        End Try
    End Sub

    Sub limpiarcontroles()
        txt_nombre_usuario.Clear()
        txt_contraseña_usuario.Clear()
        cbo_perfil_usuario.SelectedIndex = -1
        txt_repetir_contraseña.Clear()
    End Sub

    Private Sub btn_actualizar_Click(sender As System.Object, e As System.EventArgs) Handles btn_actualizar.Click

        If txt_contraseña_usuario.Text.Length = 0 Or txt_repetir_contraseña.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        If txt_contraseña_usuario.Text = txt_repetir_contraseña.Text Then
            Try
                Dim Actualizarcontraseña = (From P In datacontext.Usuario Where P.id_usuario = (txt_id_usuario.Text.ToUpper)).ToList()(0)

                Actualizarcontraseña.nombre_usuario = txt_nombre_usuario.Text
                Actualizarcontraseña.contraseña_usuario = txt_contraseña_usuario.Text
                Actualizarcontraseña.perfil_usuario = cbo_perfil_usuario.Text
                datacontext.SubmitChanges()
                MsgBox("Los datos se han modificado correctamente")
                Me.limpiarcontroles()
                Me.Close()
                Frm_ListaUsuarios.cargargrilla()
            Catch ex As Exception
                MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar alumno")
                Me.limpiarcontroles()
                Me.Close()
            End Try
        Else
            MsgBox("Las contraseñas no coinciden")
            txt_contraseña_usuario.Clear()
            txt_repetir_contraseña.Clear()
            Exit Sub
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class
