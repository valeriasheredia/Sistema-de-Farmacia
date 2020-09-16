Public Class Frm_ListaCategorias
    Dim datacontext As New DataFarmacia

    Private Sub btn_modificar_Click(sender As System.Object, e As System.EventArgs) Handles btn_modificar.Click

        If dgv_lista_categoria.SelectedRows.Count > 0 Then
            Frm_NuevaCategoria.txt_id_categoria.Text = dgv_lista_categoria.Item("id_categoria", dgv_lista_categoria.SelectedRows(0).Index).Value
            Frm_NuevaCategoria.txt_nombre_categoria.Text = dgv_lista_categoria.Item("nombre_categoria", dgv_lista_categoria.SelectedRows(0).Index).Value

            Frm_NuevaCategoria.btn_guardar.Visible = False
            Frm_NuevaCategoria.txt_id_categoria.Visible = False
            Frm_NuevaCategoria.Label1.Visible = False
            Frm_NuevaCategoria.Show()
        Else
            MsgBox("Debe seleccionar una categoría")
        End If
    End Sub

    Private Sub btn_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles btn_eliminar.Click

        If dgv_lista_categoria.SelectedRows.Count > 0 Then
            Dim eliminar = (From C In datacontext.Categoria Where C.id_categoria = CInt(dgv_lista_categoria.Item("id_categoria", dgv_lista_categoria.SelectedRows(0).Index).Value)).ToList()(0)
            Select Case MsgBox("Se eliminará la categoría seleccionada, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar categoría")
                Case MsgBoxResult.Yes
                    datacontext.Categoria.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("La categoría ha sido eliminada")
                    Me.cargargrilla()
            End Select
        Else
            MsgBox("Debe seleccionar una categoría")
        End If
    End Sub

    Private Sub Frm_ListaCategorias_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        armargrilla()
        cargargrilla()
    End Sub

    Private Sub armargrilla()
        dgv_lista_categoria.Enabled = True
        dgv_lista_categoria.AutoGenerateColumns = False
        dgv_lista_categoria.Columns.Clear()

        dgv_lista_categoria.Columns.Add("id_categoria", "Id_Categoria")
        dgv_lista_categoria.Columns.Add("nombre_categoria", "Nombre")

        dgv_lista_categoria.Columns(0).DataPropertyName = "id_categoria"
        dgv_lista_categoria.Columns(0).Visible = False
        dgv_lista_categoria.Columns(1).DataPropertyName = "nombre_categoria"
        dgv_lista_categoria.Columns(1).Width = 250
        dgv_lista_categoria.ClearSelection()
    End Sub

    Public Sub cargargrilla()
        Dim consultaCategoria = From U In datacontext.Categoria Select U.id_categoria, U.nombre_categoria Order By nombre_categoria Ascending
        dgv_lista_categoria.DataSource = consultaCategoria
    End Sub

    Private Sub btn_cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub txt_buscar_nombre_categoria_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_buscar_nombre_categoria.TextChanged
        Dim buscar As String
        armargrilla()
        buscar = Me.txt_buscar_nombre_categoria.Text & "*"
        Dim consultaalu = From U In datacontext.Categoria Select U.id_categoria, U.nombre_categoria Where nombre_categoria Like buscar.ToString
        dgv_lista_categoria.DataSource = consultaalu

    End Sub


    Private Sub dgv_lista_categoria_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_lista_categoria.CellDoubleClick
        Frm_NuevoProducto.txt_id_categoria_producto.Text = dgv_lista_categoria.SelectedCells.Item(0).Value
        Frm_NuevoProducto.txt_nombre_categoria_producto.Text = dgv_lista_categoria.SelectedCells(1).Value
        Me.Close()
    End Sub
End Class