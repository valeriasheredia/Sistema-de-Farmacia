Public Class Frm_ListaClientes
    Dim datacontext As New DataFarmacia

    Private Sub txt_buscar_cliente_ruc_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_buscar_cliente_ruc.TextChanged
        Dim buscar As String
        If rbt_ruc_clientes.Checked = True Then
            armargrilla()
            buscar = Me.txt_buscar_cliente_ruc.Text & "*"
            Dim consultaalu = From U In datacontext.Clientes Select U.id_cliente, U.nombre_cliente, U.direccion_cliente, U.localidad_cliente, U.sexo, U.dni_cliente, U.ruc_cliente, U.telefono_cliente Where ruc_cliente Like buscar.ToString
            dgv_lista_clientes.DataSource = consultaalu
        End If
    End Sub

    Private Sub btn_modificar_Click(sender As System.Object, e As System.EventArgs) Handles btn_modificar.Click

        If dgv_lista_clientes.SelectedRows.Count > 0 Then
            Frm_NuevoCliente.txt_id_cliente.Text = dgv_lista_clientes.Item("id_cliente", dgv_lista_clientes.SelectedRows(0).Index).Value
            Frm_NuevoCliente.txt_nombre_cliente.Text = dgv_lista_clientes.Item("nombre_cliente", dgv_lista_clientes.SelectedRows(0).Index).Value
            Frm_NuevoCliente.txt_direccion_cliente.Text = dgv_lista_clientes.Item("direccion_cliente", dgv_lista_clientes.SelectedRows(0).Index).Value
            Frm_NuevoCliente.txt_localidad_cliente.Text = dgv_lista_clientes.Item("localidad_cliente", dgv_lista_clientes.SelectedRows(0).Index).Value
            Frm_NuevoCliente.cbo_Sexo.Text = dgv_lista_clientes.Item("sexo", dgv_lista_clientes.SelectedRows(0).Index).Value
            Frm_NuevoCliente.txt_Dni_Cliente.Text = dgv_lista_clientes.Item("dni_cliente", dgv_lista_clientes.SelectedRows(0).Index).Value
            Frm_NuevoCliente.txt_Ruc_Cliente.Text = dgv_lista_clientes.Item("ruc_cliente", dgv_lista_clientes.SelectedRows(0).Index).Value
            Frm_NuevoCliente.txt_telefono_cliente.Text = dgv_lista_clientes.Item("telefono_cliente", dgv_lista_clientes.SelectedRows(0).Index).Value

            Frm_NuevoCliente.btn_guardar.Visible = False
            Frm_NuevoCliente.Show()
            Frm_NuevoCliente.txt_Ruc_Cliente.Focus()
        Else
            MsgBox("Debe seleccionar un cliente")
        End If
    End Sub

    Private Sub Frm_ListaUsuarios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        armargrilla()
        cargargrilla()
    End Sub

    Private Sub armargrilla()
        dgv_lista_clientes.Enabled = True
        dgv_lista_clientes.AutoGenerateColumns = False
        dgv_lista_clientes.Columns.Clear()

        dgv_lista_clientes.Columns.Add("id_cliente", "id_cliente")
        dgv_lista_clientes.Columns.Add("nombre_cliente", " Nombre")
        dgv_lista_clientes.Columns.Add("direccion_cliente", "Dirección")
        dgv_lista_clientes.Columns.Add("localidad_cliente", "Localidad")
        dgv_lista_clientes.Columns.Add("sexo", "Sexo")
        dgv_lista_clientes.Columns.Add("dni_cliente", "Dni")
        dgv_lista_clientes.Columns.Add("ruc_cliente", "Ruc")
        dgv_lista_clientes.Columns.Add("telefono_cliente", "Teléfono")

        dgv_lista_clientes.Columns(0).DataPropertyName = "id_cliente"
        dgv_lista_clientes.Columns(0).Visible = False
        dgv_lista_clientes.Columns(1).DataPropertyName = "nombre_cliente"
        dgv_lista_clientes.Columns(1).Width = 150
        dgv_lista_clientes.Columns(2).DataPropertyName = "direccion_cliente"
        dgv_lista_clientes.Columns(2).Width = 150
        dgv_lista_clientes.Columns(3).DataPropertyName = "localidad_cliente"
        dgv_lista_clientes.Columns(4).DataPropertyName = "sexo"
        dgv_lista_clientes.Columns(5).DataPropertyName = "dni_cliente"
        dgv_lista_clientes.Columns(6).DataPropertyName = "ruc_cliente"
        dgv_lista_clientes.Columns(7).DataPropertyName = "telefono_cliente"

        dgv_lista_clientes.ClearSelection()
    End Sub

    Public Sub cargargrilla()
        Dim consultaCliente = From U In datacontext.Clientes
                              Select U.id_cliente, U.nombre_cliente, U.direccion_cliente, U.localidad_cliente, U.sexo, U.dni_cliente, U.ruc_cliente, U.telefono_cliente
                              Order By nombre_cliente Ascending
        dgv_lista_clientes.DataSource = consultaCliente
    End Sub

    Private Sub btn_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles btn_eliminar.Click
        If dgv_lista_clientes.SelectedRows.Count > 0 Then

            Dim eliminar = (From C In datacontext.Clientes Where C.id_cliente = CInt(dgv_lista_clientes.Item("id_cliente", dgv_lista_clientes.SelectedRows(0).Index).Value)).ToList()(0)

            Select Case MsgBox("Se eliminará el cliente seleccionado, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar cliente")
                Case MsgBoxResult.Yes
                    datacontext.Clientes.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("El cliente ha sido eliminado")
            End Select
        Else
            MsgBox("Debe seleccionar un cliente")
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub rbt_ruc_clientes_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbt_ruc_clientes.CheckedChanged
        txt_buscar_cliente_dni.Enabled = False
        txt_buscar_cliente_dni.Clear()
        txt_buscar_cliente_ruc.Enabled = True
    End Sub

    Private Sub rbt_dni_cliente_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbt_dni_cliente.CheckedChanged
        txt_buscar_cliente_ruc.Enabled = False
        txt_buscar_cliente_ruc.Clear()
        txt_buscar_cliente_dni.Enabled = True
    End Sub

    Private Sub txt_buscar_cliente_dni_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_buscar_cliente_dni.TextChanged
        Dim buscar As String
        If rbt_dni_cliente.Checked = True Then
            armargrilla()
            buscar = Me.txt_buscar_cliente_dni.Text & "*"
            Dim consultaalu = From U In datacontext.Clientes Select U.id_cliente, U.nombre_cliente, U.direccion_cliente, U.localidad_cliente, U.sexo, U.dni_cliente, U.ruc_cliente, U.telefono_cliente Where dni_cliente Like buscar.ToString
            dgv_lista_clientes.DataSource = consultaalu
        End If
    End Sub

    Private Sub dgv_lista_clientes_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_lista_clientes.CellDoubleClick
        Frm_NuevoOrdenPedido.txt_id_cliente_op.Text = dgv_lista_clientes.SelectedCells(0).Value
        Frm_NuevoOrdenPedido.txt_nombre_cliente_op.Text = dgv_lista_clientes.SelectedCells(1).Value
        Frm_NuevoOrdenPedido.txt_direccion_cliente_op.Text = dgv_lista_clientes.SelectedCells(2).Value
        Frm_NuevoOrdenPedido.txt_ruc_cliente_op.Text = dgv_lista_clientes.SelectedCells(6).Value
        Frm_NuevoOrdenPedido.txt_telefono_cliente_op.Text = dgv_lista_clientes.SelectedCells(7).Value
        Me.Close()

    End Sub

    Private Sub btn_Ver_Cliente_Click(sender As System.Object, e As System.EventArgs) Handles btn_Ver_Cliente.Click
        If dgv_lista_clientes.SelectedRows.Count > 0 Then
            Frm_NuevoCliente.txt_id_cliente.Text = dgv_lista_clientes.Item("id_cliente", dgv_lista_clientes.SelectedRows(0).Index).Value
            Frm_NuevoCliente.txt_nombre_cliente.Text = dgv_lista_clientes.Item("nombre_cliente", dgv_lista_clientes.SelectedRows(0).Index).Value
            Frm_NuevoCliente.txt_direccion_cliente.Text = dgv_lista_clientes.Item("direccion_cliente", dgv_lista_clientes.SelectedRows(0).Index).Value
            Frm_NuevoCliente.txt_localidad_cliente.Text = dgv_lista_clientes.Item("localidad_cliente", dgv_lista_clientes.SelectedRows(0).Index).Value
            Frm_NuevoCliente.cbo_Sexo.Text = dgv_lista_clientes.Item("sexo", dgv_lista_clientes.SelectedRows(0).Index).Value
            Frm_NuevoCliente.txt_Dni_Cliente.Text = dgv_lista_clientes.Item("dni_cliente", dgv_lista_clientes.SelectedRows(0).Index).Value
            Frm_NuevoCliente.txt_Ruc_Cliente.Text = dgv_lista_clientes.Item("ruc_cliente", dgv_lista_clientes.SelectedRows(0).Index).Value
            Frm_NuevoCliente.txt_telefono_cliente.Text = dgv_lista_clientes.Item("telefono_cliente", dgv_lista_clientes.SelectedRows(0).Index).Value

            Frm_NuevoCliente.btn_guardar.Visible = False
            Frm_NuevoCliente.btn_actualizar.Visible = False
            Frm_NuevoCliente.txt_nombre_cliente.Enabled = False
            Frm_NuevoCliente.txt_Ruc_Cliente.Enabled = False
            Frm_NuevoCliente.txt_telefono_cliente.Enabled = False
            Frm_NuevoCliente.txt_localidad_cliente.Enabled = False
            Frm_NuevoCliente.txt_direccion_cliente.Enabled = False
            Frm_NuevoCliente.txt_Dni_Cliente.Enabled = False
            Frm_NuevoCliente.cbo_Sexo.Enabled = False
            Frm_NuevoCliente.Show()
        Else
            MsgBox("Debe seleccionar un cliente")
        End If
    End Sub
End Class