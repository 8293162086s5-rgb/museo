Imports CapaEntidades
Imports CapaNegocio
Imports CapaNegocio.CapaNegocio

Public Class FrmGuia

    Dim bl As New GuiaBL()
    Dim modoEdicion As Boolean = False
    Dim idSeleccionado As Integer = 0

    Private Sub FrmGuia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarIdiomas()
        CargarEstados()
        CargarTabla()
        ModoNuevo()
    End Sub

    Private Sub CargarIdiomas()
        cboIdioma.Items.Clear()
        cboIdioma.Items.AddRange({"Español", "Inglés", "Francés", "Español / Inglés", "Español / Francés", "Otro"})
        cboIdioma.SelectedIndex = 0
    End Sub

    Private Sub CargarEstados()
        cboEstado.Items.Clear()
        cboEstado.Items.Add("Activo")
        cboEstado.Items.Add("Inactivo")
        cboEstado.SelectedIndex = 0
    End Sub

    Private Sub CargarTabla()
        Try
            dgvGuias.DataSource = bl.Listar()
        Catch ex As Exception
            MessageBox.Show("Error al cargar guías: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ModoNuevo()
        modoEdicion = False
        idSeleccionado = 0
        txtNombre.Clear()
        txtApellido.Clear()
        txtTelefono.Clear()
        txtEmail.Clear()
        cboIdioma.SelectedIndex = 0
        cboEstado.SelectedIndex = 0
        btnGuardar.Text = "💾  Guardar"
        btnCancelar.Visible = False
        txtNombre.Focus()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoNuevo()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim guia As New Guia With {
                .Nombre = txtNombre.Text.Trim(),
                .Apellido = txtApellido.Text.Trim(),
                .Telefono = txtTelefono.Text.Trim(),
                .Email = txtEmail.Text.Trim(),
                .Idioma = cboIdioma.Text,
                .Estado = cboEstado.Text
            }
            If modoEdicion Then
                guia.IdGuia = idSeleccionado
                bl.Actualizar(guia)
                MessageBox.Show("Guía actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                bl.Agregar(guia)
                MessageBox.Show("Guía registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            CargarTabla()
            ModoNuevo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvGuias.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un guía para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim fila = dgvGuias.SelectedRows(0)
        modoEdicion = True
        idSeleccionado = Convert.ToInt32(fila.Cells("IdGuia").Value)
        txtNombre.Text = fila.Cells("Nombre").Value.ToString()
        txtApellido.Text = fila.Cells("Apellido").Value.ToString()
        txtTelefono.Text = fila.Cells("Telefono").Value.ToString()
        txtEmail.Text = fila.Cells("Email").Value.ToString()
        cboIdioma.Text = fila.Cells("Idioma").Value.ToString()
        cboEstado.Text = fila.Cells("Estado").Value.ToString()
        btnGuardar.Text = "✏️  Actualizar"
        btnCancelar.Visible = True
        txtNombre.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvGuias.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un guía para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim id = Convert.ToInt32(dgvGuias.SelectedRows(0).Cells("IdGuia").Value)
        Dim nombre = dgvGuias.SelectedRows(0).Cells("Nombre").Value.ToString()
        If MessageBox.Show($"¿Desea eliminar al guía '{nombre}'?", "Confirmar",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                bl.Eliminar(id)
                MessageBox.Show("Guía eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            Dim filtro = bl.Listar().FindAll(Function(x) x.Nombre.ToLower().Contains(txtBuscar.Text.ToLower()) OrElse
                                                          x.Apellido.ToLower().Contains(txtBuscar.Text.ToLower()))
            dgvGuias.DataSource = filtro
        Catch ex As Exception
        End Try
    End Sub

End Class
