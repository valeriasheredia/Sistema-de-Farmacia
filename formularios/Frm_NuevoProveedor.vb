Public Class Frm_NuevoProveedor

    Dim datacontext As New DataFarmacia

    Private Sub btn_guardar_Click(sender As System.Object, e As System.EventArgs) Handles btn_guardar.Click
        Try
            Dim buscaprov = (From proveedor In datacontext.Proveedor Select proveedor.nombre_proveedor, proveedor.direccion_proveedor, proveedor.telefono_proveedor, proveedor.localidad_proveedor Where nombre_proveedor = txt_nombre_proveedor.Text.ToUpper).Any
            If buscaprov = True Then
                MsgBox("El proveedor ingresado ya existe")
                limpiarcontroles()
                Exit Sub
            End If
            If txt_nombre_proveedor.Text.Length = 0 Or txt_direccion_proveedor.Text.Length = 0 Or txt_telefono_proveedor.Text.Length = 0 Or txt_nombre_localidad.Text.Length = 0 Then
                MsgBox("Debe completar todos los campos requeridos")
                Exit Sub
            End If
            Dim usu = New Proveedor
            usu.nombre_proveedor = txt_nombre_proveedor.Text
            usu.direccion_proveedor = txt_direccion_proveedor.Text
            usu.telefono_proveedor = txt_telefono_proveedor.Text
            usu.localidad_proveedor = txt_nombre_localidad.Text
            datacontext.Proveedor.InsertOnSubmit(usu)
                datacontext.SubmitChanges()
            MsgBox("El proveedor se ha creado correctamente", vbInformation)
                limpiarcontroles()
        Catch ex As Exception
            MsgBox("El Proveedor NO fue creado")
            limpiarcontroles()
        End Try
    End Sub

    Sub limpiarcontroles()
        txt_nombre_proveedor.Clear()
        txt_direccion_proveedor.Clear()
        txt_telefono_proveedor.Clear()
        txt_nombre_localidad.Clear()
    End Sub

    Private Sub btn_actualizar_Click(sender As System.Object, e As System.EventArgs) Handles btn_actualizar.Click
        If txt_nombre_proveedor.Text.Length = 0 Or txt_direccion_proveedor.Text.Length = 0 Or txt_telefono_proveedor.Text.Length = 0 Or txt_nombre_localidad.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            Dim ActualizarProveedor = (From P In datacontext.Proveedor Where P.id_proveedor = (txt_id_proveedor.Text.ToUpper)).ToList()(0)
            ActualizarProveedor.nombre_proveedor = txt_nombre_proveedor.Text
            ActualizarProveedor.direccion_proveedor = txt_direccion_proveedor.Text
            ActualizarProveedor.telefono_proveedor = txt_telefono_proveedor.Text
            ActualizarProveedor.localidad_proveedor = txt_nombre_localidad.Text
            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")
            Me.limpiarcontroles()
            Me.Close()
            Frm_ListaProveedores.cargargrilla()
        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar proveedor")
            Me.limpiarcontroles()
            Me.Close()
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub txt_telefono_proveedor_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_telefono_proveedor.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class