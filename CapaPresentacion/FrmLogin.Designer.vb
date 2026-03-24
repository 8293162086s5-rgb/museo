<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlEncabezado = New Panel()
        Me.lblTitulo = New Label()
        Me.lblSubtitulo = New Label()
        Me.pnlFormulario = New Panel()
        Me.lblUsuario = New Label()
        Me.txtUsuario = New TextBox()
        Me.lblContrasena = New Label()
        Me.txtContrasena = New TextBox()
        Me.lblIntentos = New Label()
        Me.btnIngresar = New Button()
        Me.btnCancelar = New Button()
        Me.SuspendLayout()

        ' pnlEncabezado
        Me.pnlEncabezado.BackColor = Color.FromArgb(30, 60, 114)
        Me.pnlEncabezado.Dock = DockStyle.Top
        Me.pnlEncabezado.Height = 110
        Me.pnlEncabezado.Controls.Add(Me.lblSubtitulo)
        Me.pnlEncabezado.Controls.Add(Me.lblTitulo)

        ' lblTitulo
        Me.lblTitulo.Text = "🏛  Sistema de Gestión del Museo"
        Me.lblTitulo.Font = New Font("Segoe UI", 18, FontStyle.Bold)
        Me.lblTitulo.ForeColor = Color.White
        Me.lblTitulo.Location = New Point(20, 20)
        Me.lblTitulo.Size = New Size(460, 40)

        ' lblSubtitulo
        Me.lblSubtitulo.Text = "Ingrese sus credenciales para continuar"
        Me.lblSubtitulo.Font = New Font("Segoe UI", 10)
        Me.lblSubtitulo.ForeColor = Color.FromArgb(180, 210, 255)
        Me.lblSubtitulo.Location = New Point(24, 65)
        Me.lblSubtitulo.Size = New Size(400, 25)

        ' pnlFormulario
        Me.pnlFormulario.Location = New Point(20, 125)
        Me.pnlFormulario.Size = New Size(460, 230)
        Me.pnlFormulario.BackColor = Color.White
        Me.pnlFormulario.BorderStyle = BorderStyle.FixedSingle

        ' lblUsuario
        Me.lblUsuario.Text = "👤  Usuario"
        Me.lblUsuario.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.lblUsuario.Location = New Point(20, 20)
        Me.lblUsuario.AutoSize = True

        ' txtUsuario
        Me.txtUsuario.Location = New Point(20, 42)
        Me.txtUsuario.Size = New Size(420, 32)
        Me.txtUsuario.Font = New Font("Segoe UI", 12)
        Me.txtUsuario.BorderStyle = BorderStyle.FixedSingle

        ' lblContrasena
        Me.lblContrasena.Text = "🔒  Contraseña"
        Me.lblContrasena.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.lblContrasena.Location = New Point(20, 90)
        Me.lblContrasena.AutoSize = True

        ' txtContrasena
        Me.txtContrasena.Location = New Point(20, 112)
        Me.txtContrasena.Size = New Size(420, 32)
        Me.txtContrasena.Font = New Font("Segoe UI", 12)
        Me.txtContrasena.PasswordChar = "●"
        Me.txtContrasena.BorderStyle = BorderStyle.FixedSingle

        ' lblIntentos
        Me.lblIntentos.Text = ""
        Me.lblIntentos.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.lblIntentos.ForeColor = Color.OrangeRed
        Me.lblIntentos.Location = New Point(20, 158)
        Me.lblIntentos.AutoSize = True
        Me.lblIntentos.Visible = False

        ' btnIngresar
        Me.btnIngresar.Text = "🔓  Ingresar al Sistema"
        Me.btnIngresar.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        Me.btnIngresar.Location = New Point(20, 185)
        Me.btnIngresar.Size = New Size(280, 38)
        Me.btnIngresar.BackColor = Color.FromArgb(30, 60, 114)
        Me.btnIngresar.ForeColor = Color.White
        Me.btnIngresar.FlatStyle = FlatStyle.Flat
        Me.btnIngresar.FlatAppearance.BorderSize = 0
        Me.btnIngresar.Cursor = Cursors.Hand

        ' btnCancelar
        Me.btnCancelar.Text = "❌  Cancelar"
        Me.btnCancelar.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        Me.btnCancelar.Location = New Point(310, 185)
        Me.btnCancelar.Size = New Size(130, 38)
        Me.btnCancelar.BackColor = Color.FromArgb(211, 47, 47)
        Me.btnCancelar.ForeColor = Color.White
        Me.btnCancelar.FlatStyle = FlatStyle.Flat
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.Cursor = Cursors.Hand

        Me.pnlFormulario.Controls.AddRange({Me.lblUsuario, Me.txtUsuario,
                                             Me.lblContrasena, Me.txtContrasena,
                                             Me.lblIntentos, Me.btnIngresar, Me.btnCancelar})

        ' FrmLogin
        Me.ClientSize = New Size(500, 375)
        Me.Controls.AddRange({Me.pnlEncabezado, Me.pnlFormulario})
        Me.Text = "Iniciar Sesión - Museo"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.BackColor = Color.FromArgb(245, 245, 245)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlEncabezado As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblSubtitulo As Label
    Friend WithEvents pnlFormulario As Panel
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lblContrasena As Label
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents lblIntentos As Label
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnCancelar As Button

End Class
