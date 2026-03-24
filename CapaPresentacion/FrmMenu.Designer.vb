<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenu
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblSubtitulo = New System.Windows.Forms.Label()
        Me.pnlBotones = New System.Windows.Forms.Panel()
        Me.btnEmpleados = New System.Windows.Forms.Button()
        Me.btnGuias = New System.Windows.Forms.Button()
        Me.btnVisitantes = New System.Windows.Forms.Button()
        Me.btnExposiciones = New System.Windows.Forms.Button()
        Me.btnPiezas = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.pnlTitulo.SuspendLayout()
        Me.pnlBotones.SuspendLayout()
        Me.SuspendLayout()

        ' pnlTitulo
        Me.pnlTitulo.BackColor = Color.FromArgb(30, 60, 114)
        Me.pnlTitulo.Controls.Add(Me.lblSubtitulo)
        Me.pnlTitulo.Controls.Add(Me.lblTitulo)
        Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitulo.Height = 100

        ' lblTitulo
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 24, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.ForeColor = Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(30, 15)
        Me.lblTitulo.Size = New System.Drawing.Size(700, 45)
        Me.lblTitulo.Text = "🏛  Sistema de Gestión del Museo"

        ' lblSubtitulo
        Me.lblSubtitulo.Font = New System.Drawing.Font("Segoe UI", 11)
        Me.lblSubtitulo.ForeColor = Color.FromArgb(180, 210, 255)
        Me.lblSubtitulo.Location = New System.Drawing.Point(34, 60)
        Me.lblSubtitulo.Size = New System.Drawing.Size(500, 25)
        Me.lblSubtitulo.Text = "Seleccione un módulo para continuar"

        ' pnlBotones
        Me.pnlBotones.Anchor = AnchorStyles.None
        Me.pnlBotones.Location = New System.Drawing.Point(150, 150)
        Me.pnlBotones.Size = New System.Drawing.Size(700, 320)
        Me.pnlBotones.Controls.Add(Me.btnEmpleados)
        Me.pnlBotones.Controls.Add(Me.btnGuias)
        Me.pnlBotones.Controls.Add(Me.btnVisitantes)
        Me.pnlBotones.Controls.Add(Me.btnExposiciones)
        Me.pnlBotones.Controls.Add(Me.btnPiezas)
        Me.pnlBotones.Controls.Add(Me.btnSalir)

        ' Estilo compartido de botones
        Dim btnSize As New System.Drawing.Size(200, 120)
        Dim btnFont As New System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold)

        ' btnEmpleados
        Me.btnEmpleados.Size = btnSize
        Me.btnEmpleados.Location = New System.Drawing.Point(0, 0)
        Me.btnEmpleados.Text = "👤  Empleados"
        Me.btnEmpleados.Font = btnFont
        Me.btnEmpleados.BackColor = Color.FromArgb(30, 136, 229)
        Me.btnEmpleados.ForeColor = Color.White
        Me.btnEmpleados.FlatStyle = FlatStyle.Flat
        Me.btnEmpleados.FlatAppearance.BorderSize = 0
        Me.btnEmpleados.Cursor = Cursors.Hand

        ' btnGuias
        Me.btnGuias.Size = btnSize
        Me.btnGuias.Location = New System.Drawing.Point(250, 0)
        Me.btnGuias.Text = "🧭  Guías"
        Me.btnGuias.Font = btnFont
        Me.btnGuias.BackColor = Color.FromArgb(67, 160, 71)
        Me.btnGuias.ForeColor = Color.White
        Me.btnGuias.FlatStyle = FlatStyle.Flat
        Me.btnGuias.FlatAppearance.BorderSize = 0
        Me.btnGuias.Cursor = Cursors.Hand

        ' btnVisitantes
        Me.btnVisitantes.Size = btnSize
        Me.btnVisitantes.Location = New System.Drawing.Point(500, 0)
        Me.btnVisitantes.Text = "👥  Visitantes"
        Me.btnVisitantes.Font = btnFont
        Me.btnVisitantes.BackColor = Color.FromArgb(251, 140, 0)
        Me.btnVisitantes.ForeColor = Color.White
        Me.btnVisitantes.FlatStyle = FlatStyle.Flat
        Me.btnVisitantes.FlatAppearance.BorderSize = 0
        Me.btnVisitantes.Cursor = Cursors.Hand

        ' btnExposiciones
        Me.btnExposiciones.Size = btnSize
        Me.btnExposiciones.Location = New System.Drawing.Point(0, 170)
        Me.btnExposiciones.Text = "🖼  Exposiciones"
        Me.btnExposiciones.Font = btnFont
        Me.btnExposiciones.BackColor = Color.FromArgb(142, 36, 170)
        Me.btnExposiciones.ForeColor = Color.White
        Me.btnExposiciones.FlatStyle = FlatStyle.Flat
        Me.btnExposiciones.FlatAppearance.BorderSize = 0
        Me.btnExposiciones.Cursor = Cursors.Hand

        ' btnPiezas
        Me.btnPiezas.Size = btnSize
        Me.btnPiezas.Location = New System.Drawing.Point(250, 170)
        Me.btnPiezas.Text = "🏺  Piezas"
        Me.btnPiezas.Font = btnFont
        Me.btnPiezas.BackColor = Color.FromArgb(0, 131, 143)
        Me.btnPiezas.ForeColor = Color.White
        Me.btnPiezas.FlatStyle = FlatStyle.Flat
        Me.btnPiezas.FlatAppearance.BorderSize = 0
        Me.btnPiezas.Cursor = Cursors.Hand

        ' btnSalir
        Me.btnSalir.Size = btnSize
        Me.btnSalir.Location = New System.Drawing.Point(500, 170)
        Me.btnSalir.Text = "🚪  Salir"
        Me.btnSalir.Font = btnFont
        Me.btnSalir.BackColor = Color.FromArgb(211, 47, 47)
        Me.btnSalir.ForeColor = Color.White
        Me.btnSalir.FlatStyle = FlatStyle.Flat
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.Cursor = Cursors.Hand

        ' FrmMenu
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.pnlBotones)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Name = "FrmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Gestión - Museo"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlBotones.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTitulo As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblSubtitulo As System.Windows.Forms.Label
    Friend WithEvents pnlBotones As System.Windows.Forms.Panel
    Friend WithEvents btnEmpleados As System.Windows.Forms.Button
    Friend WithEvents btnGuias As System.Windows.Forms.Button
    Friend WithEvents btnVisitantes As System.Windows.Forms.Button
    Friend WithEvents btnExposiciones As System.Windows.Forms.Button
    Friend WithEvents btnPiezas As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button

End Class
