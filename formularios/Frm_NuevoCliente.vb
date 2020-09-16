Public Class Frm_NuevoCliente
    Dim datacontext As New DataFarmacia

    Private Sub Frm_NuevoCliente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label1.Visible = False
        txt_id_cliente.Visible = False
    End Sub

    Private Sub btn_guardar_Click(sender As System.Object, e As System.EventArgs) Handles btn_guardar.Click
        Try
            Dim buscacliente = (From cli In datacontext.Clientes Select cli.nombre_cliente, cli.direccion_cliente, cli.sexo, cli.ruc_cliente, cli.telefono_cliente Where ruc_cliente = txt_Ruc_Cliente.Text.ToUpper).Any
            If buscacliente = True Then
                MsgBox("El cliente ingresado ya existe")
                limpiarcontroles()
                Exit Sub
            End If
            If txt_nombre_cliente.Text.Length = 0 Or txt_direccion_cliente.Text.Length = 0 Or txt_localidad_cliente.Text.Length = 0 Or cbo_Sexo.Text.Length = 0 Or txt_Ruc_Cliente.Text.Length = 0 Or txt_telefono_cliente.Text.Length = 0 Then
                MsgBox("Debe completar todos los campos requeridos")
                Exit Sub
            End If
            Dim clie = New Clientes
            clie.nombre_cliente = txt_nombre_cliente.Text
            clie.direccion_cliente = txt_direccion_cliente.Text
            clie.localidad_cliente = txt_localidad_cliente.Text
            clie.sexo = cbo_Sexo.Text
            clie.dni_cliente = txt_Dni_Cliente.Text
            clie.ruc_cliente = txt_Ruc_Cliente.Text
            clie.telefono_cliente = txt_telefono_cliente.Text

            datacontext.Clientes.InsertOnSubmit(clie)
            datacontext.SubmitChanges()
            MsgBox("El cliente se ha creado correctamente", vbInformation)
            limpiarcontroles()
        Catch ex As Exception
            MsgBox("El cliente NO fue creado")
            limpiarcontroles()
        End Try
    End Sub

    Sub limpiarcontroles()
        txt_nombre_cliente.Clear()
        txt_direccion_cliente.Clear()
        txt_localidad_cliente.Clear()
        txt_localidad_cliente.Clear()
        ' cbo_Sexo.SelectedIndex = -1
        txt_Dni_Cliente.Clear()
        txt_Ruc_Cliente.Clear()
        txt_telefono_cliente.Clear()
    End Sub

    Private Sub btn_actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_actualizar.Click
        If txt_nombre_cliente.Text.Length = 0 Or txt_direccion_cliente.Text.Length = 0 Or txt_localidad_cliente.Text.Length = 0 Or txt_Ruc_Cliente.Text.Length = 0 Or txt_telefono_cliente.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            Dim ActualizarCliente = (From P In datacontext.Clientes Where P.id_cliente = (txt_id_cliente.Text.ToUpper)).ToList()(0)
            ActualizarCliente.nombre_cliente = txt_nombre_cliente.Text
            ActualizarCliente.direccion_cliente = txt_direccion_cliente.Text
            ActualizarCliente.localidad_cliente = txt_localidad_cliente.Text
            ActualizarCliente.dni_cliente = txt_Dni_Cliente.Text
            ActualizarCliente.sexo = cbo_Sexo.Text
            ActualizarCliente.ruc_cliente = txt_Ruc_Cliente.Text
            ActualizarCliente.telefono_cliente = txt_telefono_cliente.Text
            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")
            Me.limpiarcontroles()
            Me.Close()
        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar cliente")
            Me.limpiarcontroles()
            Me.Close()
            Frm_ListaClientes.cargargrilla()
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub txt_telefono_cliente_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_telefono_cliente.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Dni_Cliente_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Dni_Cliente.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class