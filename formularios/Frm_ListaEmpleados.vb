Public Class Frm_ListaEmpleados

    Dim datacontext As New DataFarmacia

    Private Sub btn_modificar_Click(sender As System.Object, e As System.EventArgs) Handles btn_modificar.Click

        If dgv_lista_empleados.SelectedRows.Count > 0 Then
            Frm_NuevoEmpleado.txt_id_empleado.Text = dgv_lista_empleados.Item("id_empleado", dgv_lista_empleados.SelectedRows(0).Index).Value
            Frm_NuevoEmpleado.txt_nombre_empleado.Text = dgv_lista_empleados.Item("nombre_empleado", dgv_lista_empleados.SelectedRows(0).Index).Value
            Frm_NuevoEmpleado.txt_direccion_empleado.Text = dgv_lista_empleados.Item("direccion_empleado", dgv_lista_empleados.SelectedRows(0).Index).Value
            Frm_NuevoEmpleado.txt_localidad_empleado.Text = dgv_lista_empleados.Item("localidad_empleado", dgv_lista_empleados.SelectedRows(0).Index).Value
            Frm_NuevoEmpleado.cbo_cargo_empleado.Text = dgv_lista_empleados.Item("cargo_empleado", dgv_lista_empleados.SelectedRows(0).Index).Value
            Frm_NuevoEmpleado.txt_edad_empleado.Text = dgv_lista_empleados.Item("edad", dgv_lista_empleados.SelectedRows(0).Index).Value
            Frm_NuevoEmpleado.txt_telefono_empleado.Text = dgv_lista_empleados.Item("telefono_empleado", dgv_lista_empleados.SelectedRows(0).Index).Value
            Frm_NuevoEmpleado.dtp_fecha_ingreso.Text = dgv_lista_empleados.Item("fecha_ingreso", dgv_lista_empleados.SelectedRows(0).Index).Value
            Frm_NuevoEmpleado.btn_guardar.Visible = False
            Frm_NuevoEmpleado.Show()
        Else
            MsgBox("Debe seleccionar un empleado")
        End If
    End Sub

    Private Sub rbt_nombre_empleado_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbt_nombre_empleado.CheckedChanged
        txt_buscar_cargo_empleado.Enabled = False
        txt_buscar_cargo_empleado.Clear()
        txt_buscar_nombre_empleado.Enabled = True
    End Sub

    Private Sub txt_buscar_nombre_empleado_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_buscar_nombre_empleado.TextChanged
        Dim buscar As String
        If rbt_nombre_empleado.Checked = True Then

            armargrilla()
            buscar = Me.txt_buscar_nombre_empleado.Text & "*"
            Dim consultaempleado = From U In datacontext.Empleado
                                   Select U.id_empleado, U.nombre_empleado, U.direccion_empleado, U.localidad_empleado, U.cargo_empleado, U.edad, U.telefono_empleado, U.fecha_ingreso
                                   Where nombre_empleado Like buscar.ToString
            dgv_lista_empleados.DataSource = consultaempleado
        End If
    End Sub

    Private Sub rbt_cargo_empleado_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbt_cargo_empleado.CheckedChanged
        txt_buscar_nombre_empleado.Enabled = False
        txt_buscar_nombre_empleado.Clear()
        txt_buscar_cargo_empleado.Enabled = True
    End Sub

    Private Sub txt_buscar_cargo_empleado_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_buscar_cargo_empleado.TextChanged
        Dim buscar As String
        If rbt_cargo_empleado.Checked = True Then
            armargrilla()
            buscar = Me.txt_buscar_cargo_empleado.Text & "*"
            Dim consultaempleado = From U In datacontext.Empleado Select U.id_empleado, U.nombre_empleado, U.direccion_empleado, U.localidad_empleado, U.cargo_empleado, U.edad, U.telefono_empleado, U.fecha_ingreso Where cargo_empleado Like buscar.ToString
            dgv_lista_empleados.DataSource = consultaempleado
        End If
    End Sub

    Private Sub Frm_ListaEmpleados_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        armargrilla()
        cargargrilla()
    End Sub

    Private Sub armargrilla()
        dgv_lista_empleados.Enabled = True
        dgv_lista_empleados.AutoGenerateColumns = False
        dgv_lista_empleados.Columns.Clear()

        dgv_lista_empleados.Columns.Add("id_empleado", "id_empleado")
        dgv_lista_empleados.Columns.Add("nombre_empleado", " Nombre")
        dgv_lista_empleados.Columns.Add("direccion_empleado", "Dirección")
        dgv_lista_empleados.Columns.Add("localidad_empleado", "Localidad")
        dgv_lista_empleados.Columns.Add("cargo_empleado", "Cargo")
        dgv_lista_empleados.Columns.Add("edad", "Edad")
        dgv_lista_empleados.Columns.Add("telefono_empleado", "Teléfono")
        dgv_lista_empleados.Columns.Add("fecha_ingreso", "Fecha de Ingreso")

        dgv_lista_empleados.Columns(0).DataPropertyName = "id_empleado"
        dgv_lista_empleados.Columns(0).Visible = False
        dgv_lista_empleados.Columns(1).DataPropertyName = "nombre_empleado"
        dgv_lista_empleados.Columns(1).Width = 150
        dgv_lista_empleados.Columns(2).DataPropertyName = "direccion_empleado"
        dgv_lista_empleados.Columns(2).Width = 150
        dgv_lista_empleados.Columns(3).DataPropertyName = "localidad_empleado"
        dgv_lista_empleados.Columns(4).DataPropertyName = "cargo_empleado"
        dgv_lista_empleados.Columns(5).DataPropertyName = "edad"
        dgv_lista_empleados.Columns(5).Visible = False
        dgv_lista_empleados.Columns(6).DataPropertyName = "telefono_empleado"
        dgv_lista_empleados.Columns(7).DataPropertyName = "fecha_ingreso"

        dgv_lista_empleados.ClearSelection()
    End Sub

    Public Sub cargargrilla()
        Dim consultaEmpleado = From U In datacontext.Empleado
                               Select U.id_empleado, U.nombre_empleado, U.direccion_empleado, U.localidad_empleado, U.cargo_empleado, U.edad, U.telefono_empleado, U.fecha_ingreso
                               Order By nombre_empleado Ascending
        dgv_lista_empleados.DataSource = consultaEmpleado
    End Sub

    Private Sub btn_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles btn_eliminar.Click

        If dgv_lista_empleados.SelectedRows.Count > 0 Then
            Dim eliminar = (From C In datacontext.Empleado Where C.id_empleado = CInt(dgv_lista_empleados.Item("id_empleado", dgv_lista_empleados.SelectedRows(0).Index).Value)).ToList()(0)

            Select Case MsgBox("Se eliminará el empleado seleccionado, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar empleado")
                Case MsgBoxResult.Yes
                    datacontext.Empleado.DeleteOnSubmit(eliminar)
                    datacontext.SubmitChanges()
                    MsgBox("El empleado ha sido eliminado")
            End Select
        Else
            MsgBox("Debe seleccionar un empleado")
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub dgv_lista_empleados_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_lista_empleados.CellDoubleClick
        Frm_NuevoOrdenPedido.txt_id_empleado_op.Text = dgv_lista_empleados.SelectedCells(0).Value
        Frm_NuevoOrdenPedido.txt_nombre_empleado_op.Text = dgv_lista_empleados.SelectedCells(1).Value
        Frm_NuevoOrdenPedido.txt_cargo_empleado_op.Text = dgv_lista_empleados.SelectedCells(4).Value
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btn_Ver.Click
        If dgv_lista_empleados.SelectedRows.Count > 0 Then
            Frm_NuevoEmpleado.txt_id_empleado.Text = dgv_lista_empleados.Item("id_empleado", dgv_lista_empleados.SelectedRows(0).Index).Value
            Frm_NuevoEmpleado.txt_nombre_empleado.Text = dgv_lista_empleados.Item("nombre_empleado", dgv_lista_empleados.SelectedRows(0).Index).Value
            Frm_NuevoEmpleado.txt_direccion_empleado.Text = dgv_lista_empleados.Item("direccion_empleado", dgv_lista_empleados.SelectedRows(0).Index).Value
            Frm_NuevoEmpleado.txt_localidad_empleado.Text = dgv_lista_empleados.Item("localidad_empleado", dgv_lista_empleados.SelectedRows(0).Index).Value
            Frm_NuevoEmpleado.cbo_cargo_empleado.Text = dgv_lista_empleados.Item("cargo_empleado", dgv_lista_empleados.SelectedRows(0).Index).Value
            Frm_NuevoEmpleado.txt_edad_empleado.Text = dgv_lista_empleados.Item("edad", dgv_lista_empleados.SelectedRows(0).Index).Value
            Frm_NuevoEmpleado.txt_telefono_empleado.Text = dgv_lista_empleados.Item("telefono_empleado", dgv_lista_empleados.SelectedRows(0).Index).Value
            Frm_NuevoEmpleado.dtp_fecha_ingreso.Text = dgv_lista_empleados.Item("fecha_ingreso", dgv_lista_empleados.SelectedRows(0).Index).Value
            Frm_NuevoEmpleado.btn_guardar.Visible = False
            Frm_NuevoEmpleado.btn_actualizar.Visible = False

            Frm_NuevoEmpleado.txt_nombre_empleado.Enabled = False
            Frm_NuevoEmpleado.txt_direccion_empleado.Enabled = False
            Frm_NuevoEmpleado.txt_localidad_empleado.Enabled = False
            Frm_NuevoEmpleado.cbo_cargo_empleado.Enabled = False
            Frm_NuevoEmpleado.txt_telefono_empleado.Enabled = False
            Frm_NuevoEmpleado.txt_edad_empleado.Enabled = False
            Frm_NuevoEmpleado.dtp_fecha_ingreso.Enabled = False
            Frm_NuevoEmpleado.Show()
        Else
            MsgBox("Debe seleccionar un empleado")
        End If
    End Sub
End Class