Public Class Frm_NuevaCategoria
    Dim datacontext As New DataFarmacia

    Private Sub btn_guardar_Click(sender As System.Object, e As System.EventArgs) Handles btn_guardar.Click
        Try
            Dim buscapais = (From categoria In datacontext.Categoria Select categoria.nombre_categoria Where nombre_categoria = txt_nombre_categoria.Text.ToUpper).Any
            If buscapais = True Then
                MsgBox("La Categoría ingresada ya existe")
                txt_nombre_categoria.Clear()
                Exit Sub
            End If
            If txt_nombre_categoria.Text.Length = 0 Then
                MsgBox("Debe completar todos los campos requeridos")
                Exit Sub
            End If
            Dim categ = New Categoria
            categ.nombre_categoria = txt_nombre_categoria.Text
            datacontext.Categoria.InsertOnSubmit(categ)
            datacontext.SubmitChanges()
            MsgBox("La categoría se ha creado correctamente", vbInformation)
            txt_nombre_categoria.Clear()
        Catch ex As Exception
            MsgBox("La categoría NO fue creada")
            txt_nombre_categoria.Clear()
        End Try
    End Sub

    Private Sub btn_actualizar_Click(sender As System.Object, e As System.EventArgs) Handles btn_actualizar.Click
        If txt_nombre_categoria.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            Dim ActualizarCategoria = (From P In datacontext.Categoria Where P.id_categoria = (txt_id_categoria.Text.ToUpper)).ToList()(0)
            ActualizarCategoria.nombre_categoria = txt_nombre_categoria.Text
            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")
            txt_nombre_categoria.Clear()
            Me.Close()
        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar Categoría")
            txt_nombre_categoria.Clear()
            Me.Close()
            Frm_ListaCategorias.cargargrilla()
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

End Class