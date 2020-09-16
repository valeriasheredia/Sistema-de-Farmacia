Public Class Frm_ListaPresentacion
    Dim datacontext As New DataFarmacia

    Private Sub Frm_ListaPresentacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_modificar_Click(sender As System.Object, e As System.EventArgs) Handles btn_modificar.Click

        If dgv_lista_presentacion.SelectedRows.Count > 0 Then
            Frm_NuevaPresentacion.txt_id_presentacion.Text = dgv_lista_presentacion.Item("id_presentacion", dgv_lista_presentacion.SelectedRows(0).Index).Value
            Frm_NuevaPresentacion.txt_nombre_presentacion.Text = dgv_lista_presentacion.Item("nombre_presentacion", dgv_lista_presentacion.SelectedRows(0).Index).Value
            Frm_NuevaPresentacion.btn_guardar.Enabled = False
            Frm_NuevaPresentacion.Show()
        Else
            MsgBox("Debe seleccionar una presentación")
        End If
    End Sub

    Private Sub btn_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles btn_eliminar.Click
        If dgv_lista_presentacion.SelectedRows.Count > 0 Then
            Dim eliminar = (From C In datacontext.Presentacion Where C.id_presentacion = CInt(dgv_lista_presentacion.Item("id_presentacion", dgv_lista_presentacion.SelectedRows(0).Index).Value)).ToList()(0)

            Select Case MsgBox("Se eliminará la presentación seleccionada, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar presentación")
                Case MsgBoxResult.Yes
                    datacontext.Presentacion.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("La presentación ha sido eliminada")
                    Me.cargargrilla()
            End Select
        Else
            MsgBox("Debe seleccionar una presentación")
        End If
    End Sub

    Private Sub Frm_ListaCategorias_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        armargrilla()
        cargargrilla()
    End Sub

    Private Sub armargrilla()
        dgv_lista_presentacion.Enabled = True
        dgv_lista_presentacion.AutoGenerateColumns = False
        dgv_lista_presentacion.Columns.Clear()

        dgv_lista_presentacion.Columns.Add("id_presentacion", "id_presentacion")
        dgv_lista_presentacion.Columns.Add("nombre_presentacion", "Nombre")

        dgv_lista_presentacion.Columns(0).DataPropertyName = "id_presentacion"
        dgv_lista_presentacion.Columns(0).Visible = False
        dgv_lista_presentacion.Columns(1).DataPropertyName = "nombre_presentacion"
        dgv_lista_presentacion.Columns(1).Width = 250
        dgv_lista_presentacion.ClearSelection()
    End Sub

    Public Sub cargargrilla()
        Dim consultaPresentacion = From U In datacontext.Presentacion
                                   Select U.id_presentacion, U.nombre_presentacion
                                   Order By nombre_presentacion Ascending
        dgv_lista_presentacion.DataSource = consultaPresentacion
    End Sub

    Private Sub btn_cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub txt_buscar_nombre_presentacion_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_buscar_nombre_presentacion.TextChanged
        Dim buscar As String
        armargrilla()
        buscar = Me.txt_buscar_nombre_presentacion.Text & "*"
        Dim consultaalu = From U In datacontext.Presentacion Select U.id_presentacion, U.nombre_presentacion Where nombre_presentacion Like buscar.ToString
        dgv_lista_presentacion.DataSource = consultaalu
    End Sub


    Private Sub dgv_lista_presentacion_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_lista_presentacion.CellDoubleClick
        Frm_NuevoProducto.txt_id_presentacion_producto.Text = dgv_lista_presentacion.SelectedCells.Item(0).Value
        Frm_NuevoProducto.txt_nombre_presentacion_producto.Text = dgv_lista_presentacion.SelectedCells(1).Value
        Me.Close()
    End Sub
End Class