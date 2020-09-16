Public Class Frm_NuevaPresentacion
    Dim datacontext As New DataFarmacia

    Private Sub Frm_NuevaPresentacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label1.Visible = False
        txt_id_presentacion.Visible = False
    End Sub
    Private Sub btn_guardar_Click(sender As System.Object, e As System.EventArgs) Handles btn_guardar.Click
        Try
            Dim buscapais = (From categoria In datacontext.Presentacion Select categoria.nombre_presentacion Where nombre_presentacion = txt_nombre_presentacion.Text.ToUpper).Any
            If buscapais = True Then
                MsgBox("La presentación ingresada ya existe")
                txt_nombre_presentacion.Clear()
                Exit Sub
            End If
            If txt_nombre_presentacion.Text.Length = 0 Then
                MsgBox("Debe completar todos los campos requeridos")
                Exit Sub
            End If
            Dim present = New Presentacion
            present.nombre_presentacion = txt_nombre_presentacion.Text
            datacontext.Presentacion.InsertOnSubmit(present)
            datacontext.SubmitChanges()
            MsgBox("La presentación se ha creado correctamente", vbInformation)
            txt_nombre_presentacion.Clear()
        Catch ex As Exception
            MsgBox("La presentación NO fue creada")
            txt_nombre_presentacion.Clear()
        End Try
    End Sub

    Private Sub btn_actualizar_Click(sender As System.Object, e As System.EventArgs) Handles btn_actualizar.Click
        If txt_nombre_presentacion.Text.Length = 0 Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            Dim ActualizarPresentacion = (From P In datacontext.Presentacion Where P.id_presentacion = (txt_id_presentacion.Text.ToUpper)).ToList()(0)
            ActualizarPresentacion.nombre_presentacion = txt_nombre_presentacion.Text
            datacontext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")
            txt_nombre_presentacion.Clear()
            Me.Close()
        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar Presentación")
            txt_nombre_presentacion.Clear()
            Me.Close()
            Frm_ListaPresentacion.cargargrilla()
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class