Public Class Frm_ListaProveedores

    Dim datacontext As New DataFarmacia

    Private Sub btn_modificar_Click(sender As System.Object, e As System.EventArgs) Handles btn_modificar.Click
        If dgv_lista_proveedores.SelectedRows.Count > 0 Then
            If dgv_lista_proveedores.SelectedRows.Count > 0 Then
                Frm_NuevoProveedor.txt_id_proveedor.Text = dgv_lista_proveedores.Item("id_proveedor", dgv_lista_proveedores.SelectedRows(0).Index).Value
                Frm_NuevoProveedor.txt_nombre_proveedor.Text = dgv_lista_proveedores.Item("nombre_proveedor", dgv_lista_proveedores.SelectedRows(0).Index).Value
                Frm_NuevoProveedor.txt_direccion_proveedor.Text = dgv_lista_proveedores.Item("direccion_proveedor", dgv_lista_proveedores.SelectedRows(0).Index).Value
                Frm_NuevoProveedor.txt_telefono_proveedor.Text = dgv_lista_proveedores.Item("telefono_proveedor", dgv_lista_proveedores.SelectedRows(0).Index).Value
                Frm_NuevoProveedor.txt_nombre_localidad.Text = dgv_lista_proveedores.Item("localidad_proveedor", dgv_lista_proveedores.SelectedRows(0).Index).Value
            End If
            Frm_NuevoProveedor.btn_guardar.Visible = False
            Frm_NuevoProveedor.Show()
        Else
            MsgBox("Debe seleccionar un proveedor")
        End If
    End Sub

    Private Sub Frm_ListaUsuarios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        armargrilla()
        cargargrilla()
    End Sub

    Private Sub armargrilla()
        dgv_lista_proveedores.Enabled = True
        dgv_lista_proveedores.AutoGenerateColumns = False
        dgv_lista_proveedores.Columns.Clear()

        dgv_lista_proveedores.Columns.Add("id_proveedor", "id_proveedor")
        dgv_lista_proveedores.Columns.Add("nombre_proveedor", " Nombre")
        dgv_lista_proveedores.Columns.Add("direccion_proveedor", "Dirección")
        dgv_lista_proveedores.Columns.Add("telefono_proveedor", "Teléfono")
        dgv_lista_proveedores.Columns.Add("localidad_proveedor", "Localidad")

        dgv_lista_proveedores.Columns(0).DataPropertyName = "id_proveedor"
        dgv_lista_proveedores.Columns(0).Visible = False
        dgv_lista_proveedores.Columns(1).DataPropertyName = "nombre_proveedor"
        dgv_lista_proveedores.Columns(1).Width = 150
        dgv_lista_proveedores.Columns(2).DataPropertyName = "direccion_proveedor"
        dgv_lista_proveedores.Columns(2).Width = 150
        dgv_lista_proveedores.Columns(3).DataPropertyName = "telefono_proveedor"
        dgv_lista_proveedores.Columns(4).DataPropertyName = "localidad_proveedor"

        dgv_lista_proveedores.ClearSelection()
    End Sub

    Public Sub cargargrilla()
        Dim consultaProveedor = From U In datacontext.Proveedor
                                Select U.id_proveedor, U.nombre_proveedor, U.direccion_proveedor, U.telefono_proveedor, U.localidad_proveedor
                                Order By nombre_proveedor Ascending
        dgv_lista_proveedores.DataSource = consultaProveedor
    End Sub

    Private Sub btn_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles btn_eliminar.Click
        If dgv_lista_proveedores.SelectedRows.Count > 0 Then
            Dim eliminar = (From C In datacontext.Proveedor Where C.id_proveedor = CInt(dgv_lista_proveedores.Item("id_proveedor", dgv_lista_proveedores.SelectedRows(0).Index).Value)).ToList()(0)

            Select Case MsgBox("Se eliminará el proveedor seleccionado, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar proveedor")
                Case MsgBoxResult.Yes
                    datacontext.Proveedor.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("El proveedor ha sido eliminado")
            End Select
        Else
            MsgBox("Debe seleccionar un proveedor")
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

  
    Private Sub txt_buscar_proveedor_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_buscar_proveedor.TextChanged
        Dim buscar As String
        armargrilla()
        buscar = Me.txt_buscar_proveedor.Text & "*"
        Dim consultaalu = From U In datacontext.Proveedor Select U.id_proveedor, U.nombre_proveedor, U.direccion_proveedor, U.telefono_proveedor, U.localidad_proveedor Where nombre_proveedor Like buscar.ToString
        dgv_lista_proveedores.DataSource = consultaalu

    End Sub

    Private Sub dgv_lista_proveedores_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_lista_proveedores.CellDoubleClick
        Frm_NuevoProducto.txt_id_proveedor_producto.Text = dgv_lista_proveedores.SelectedCells.Item(0).Value
        Frm_NuevoProducto.txt_nombre_proveedor_producto.Text = dgv_lista_proveedores.SelectedCells(1).Value
        Me.Close()
    End Sub

    Private Sub btn_ver_proveedor_Click(sender As System.Object, e As System.EventArgs) Handles btn_ver_proveedor.Click
        If dgv_lista_proveedores.SelectedRows.Count > 0 Then
            Frm_NuevoProveedor.txt_id_proveedor.Text = dgv_lista_proveedores.Item("id_proveedor", dgv_lista_proveedores.SelectedRows(0).Index).Value
            Frm_NuevoProveedor.txt_nombre_proveedor.Text = dgv_lista_proveedores.Item("nombre_proveedor", dgv_lista_proveedores.SelectedRows(0).Index).Value
            Frm_NuevoProveedor.txt_direccion_proveedor.Text = dgv_lista_proveedores.Item("direccion_proveedor", dgv_lista_proveedores.SelectedRows(0).Index).Value
            Frm_NuevoProveedor.txt_telefono_proveedor.Text = dgv_lista_proveedores.Item("telefono_proveedor", dgv_lista_proveedores.SelectedRows(0).Index).Value
            Frm_NuevoProveedor.txt_nombre_localidad.Text = dgv_lista_proveedores.Item("localidad_proveedor", dgv_lista_proveedores.SelectedRows(0).Index).Value

            Frm_NuevoProveedor.btn_guardar.Visible = False
            Frm_NuevoProveedor.btn_actualizar.Visible = False

            Frm_NuevoProveedor.txt_nombre_localidad.Enabled = False
            Frm_NuevoProveedor.txt_nombre_proveedor.Enabled = False
            Frm_NuevoProveedor.txt_telefono_proveedor.Enabled = False
            Frm_NuevoProveedor.txt_direccion_proveedor.Enabled = False
            Frm_NuevoProveedor.Show()
        Else
            MsgBox("Debe seleccionar un proveedor")
        End If
    End Sub
End Class
