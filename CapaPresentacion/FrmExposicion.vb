Imports CapaEntidades
Imports CapaNegocio
Imports CapaNegocio.CapaNegocio

Public Class FrmExposicion

    Dim bl As New ExposicionBL()
    Dim modoEdicion As Boolean = False
    Dim idSeleccionado As Integer = 0

    Private Sub FrmExposicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarSalas()
        CargarTabla()
        ModoNuevo()
    End Sub

    Private Sub CargarSalas()
        cboSala.Items.Clear()
        cboSala.Items.AddRange({"Sala A", "Sala B", "Sala C", "Sala D", "Sala Principal", "Galería"})
        cboSala.SelectedIndex = 0
    End Sub

    Private Sub CargarTabla()
        Try
            dgvExposiciones.DataSource = bl.Listar()
        Catch ex As Exception
            MessageBox.Show("Error al cargar exposiciones: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ModoNuevo()
        modoEdicion = False
        idSeleccionado = 0
        txtNombre.Clear()
        txtDescripcion.Clear()
        txtResponsable.Clear()
        dtpFechaInicio.Value = Date.Today
        dtpFechaFin.Value = Date.Today.AddMonths(1)
        cboSala.SelectedIndex = 0
        btnGuardar.Text = "💾  Guardar"
        btnCancelar.Visible = False
        txtNombre.Focus()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoNuevo()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim expo As New Exposicion With {
                .Nombre = txtNombre.Text.Trim(),
                .Descripcion = txtDescripcion.Text.Trim(),
                .FechaInicio = dtpFechaInicio.Value,
                .FechaFin = dtpFechaFin.Value,
                .Sala = cboSala.Text,
                .Responsable = txtResponsable.Text.Trim()
            }
            If modoEdicion Then
                expo.IdExposicion = idSeleccionado
                bl.Actualizar(expo)
                MessageBox.Show("Exposición actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                bl.Agregar(expo)
                MessageBox.Show("Exposición registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            CargarTabla()
            ModoNuevo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvExposiciones.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione una exposición para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim fila = dgvExposiciones.SelectedRows(0)
        modoEdicion = True
        idSeleccionado = Convert.ToInt32(fila.Cells("IdExposicion").Value)
        txtNombre.Text = fila.Cells("Nombre").Value.ToString()
        txtDescripcion.Text = fila.Cells("Descripcion").Value.ToString()
        dtpFechaInicio.Value = Convert.ToDateTime(fila.Cells("FechaInicio").Value)
        dtpFechaFin.Value = Convert.ToDateTime(fila.Cells("FechaFin").Value)
        cboSala.Text = fila.Cells("Sala").Value.ToString()
        txtResponsable.Text = fila.Cells("Responsable").Value.ToString()
        btnGuardar.Text = "✏️  Actualizar"
        btnCancelar.Visible = True
        txtNombre.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvExposiciones.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione una exposición para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim id = Convert.ToInt32(dgvExposiciones.SelectedRows(0).Cells("IdExposicion").Value)
        If MessageBox.Show("¿Desea eliminar esta exposición?", "Confirmar",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                bl.Eliminar(id)
                MessageBox.Show("Exposición eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarTabla()
                ModoNuevo()
            Catch ex As Exception
                MessageBox.Show("Error al eliminar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ModoNuevo()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Try
            Dim filtro = bl.Listar().FindAll(Function(x) x.Nombre.ToLower().Contains(txtBuscar.Text.ToLower()))
            dgvExposiciones.DataSource = filtro
        Catch ex As Exception
        End Try
    End Sub

End Class