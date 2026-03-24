Public Class FrmMenu

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Sistema de Gestión - Museo"
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.FromArgb(245, 245, 245)
    End Sub

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        Dim frm As New FrmEmpleado()
        frm.ShowDialog()
    End Sub

    Private Sub btnGuias_Click(sender As Object, e As EventArgs) Handles btnGuias.Click
        Dim frm As New FrmGuia()
        frm.ShowDialog()
    End Sub

    Private Sub btnVisitantes_Click(sender As Object, e As EventArgs) Handles btnVisitantes.Click
        Dim frm As New FrmVisitante()
        frm.ShowDialog()
    End Sub

    Private Sub btnExposiciones_Click(sender As Object, e As EventArgs) Handles btnExposiciones.Click
        Dim frm As New FrmExposicion()
        frm.ShowDialog()
    End Sub

    Private Sub btnPiezas_Click(sender As Object, e As EventArgs) Handles btnPiezas.Click
        Dim frm As New FrmPieza()
        frm.ShowDialog()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MessageBox.Show("¿Desea salir del sistema?", "Confirmar",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class