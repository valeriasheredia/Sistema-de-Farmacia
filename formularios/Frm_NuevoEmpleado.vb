Public Class Frm_NuevoEmpleado
    Dim datacontext As New DataFarmacia

    Private Sub btn_guardar_Click(sender As System.Object, e As System.EventArgs) Handles btn_guardar.Click
        Try
            Dim buscacliente = (From emp In datacontext.Empleado Select emp.nombre_empleado, emp.direccion_empleado, emp.localidad_empleado, emp.cargo_empleado, emp.edad, emp.telefono_empleado, emp.fecha_ingreso Where nombre_empleado = txt_nombre_empleado.Text.ToUpper).Any
            If buscacliente = True Then
                MsgBox("El empleado ingresado ya existe")
                limpiarcontroles()
                Exit Sub
            End If
            If txt_nombre_empleado.Text.Length = 0 Or txt_direccion_empleado.Text.Length = 0 Or txt_localidad_empleado.Text.Length = 0 Or cbo_cargo_empleado.Text.Length = 0 Or txt_telefono_empleado.Text.Length = 0 Then
                MsgBox("Debe completar todos los campos requeridos")
                Exit Sub
            End If
            Dim empleado = New Empleado
            empleado.nombre_empleado = txt_nombre_empleado.Text
            empleado.direccion_empleado = txt_direccion_empleado.Text
            empleado.localidad_empleado = txt_localidad_empleado.Text
            empleado.cargo_empleado = cbo_cargo_empleado.Text
            empleado.edad = txt_edad_empleado.Text
            empleado.telefono_empleado = txt_telefono_empleado.Text
            empleado.fecha_ingreso = dtp_fecha_ingreso.Text

            datacontext.Empleado.InsertOnSubmit(empleado)
            datacontext.SubmitChanges()
            MsgBox("El cliente se ha creado correctamente", vbInformation)
            limpiarcontroles()
        Catch ex As Exception
            MsgBox("El empleado NO fue creado")
            limpiarcontroles()
        End Try
    End Sub

    Sub limpiarcontroles()
        txt_nombre_empleado.Clear()
        txt_direccion_empleado.Clear()
        txt_localidad_empleado.Clear()
        cbo_cargo_empleado.SelectedIndex = -1
        txt_edad_empleado.Clear()
        txt_telefono_empleado.Clear()
        dtp_fecha_ingreso.Text = Now
    End Sub

    Private Sub btn_actualizar_Click(sender As System.Object, e As System.EventArgs) Handles btn_actualizar.Click
        If txt_nombre_empleado.Text.Length = 0 Or txt_direccion_empleado.Text.Length = 0 Or txt_localidad_empleado.Text.Length = 0 Or cbo_cargo_empleado.Text.Length = 0 Or txt_telefono_empleado.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            Dim ActualizarEmpleado = (From P In datacontext.Empleado Where P.id_empleado = (txt_id_empleado.Text.ToUpper)).ToList()(0)
            ActualizarEmpleado.nombre_empleado = txt_nombre_empleado.Text
            ActualizarEmpleado.direccion_empleado = txt_direccion_empleado.Text
            ActualizarEmpleado.localidad_empleado = txt_localidad_empleado.Text
            ActualizarEmpleado.cargo_empleado = cbo_cargo_empleado.Text
            ActualizarEmpleado.edad = txt_edad_empleado.Text
            ActualizarEmpleado.telefono_empleado = txt_telefono_empleado.Text
            ActualizarEmpleado.fecha_ingreso = dtp_fecha_ingreso.Text
            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")
            Me.limpiarcontroles()
            Me.Close()
        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar empleado")
            Me.limpiarcontroles()
            Me.Close()
            Frm_ListaEmpleados.cargargrilla()
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub txt_telefono_empleado_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_telefono_empleado.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class