Imports CapaNegocio
Imports CapaNegocio.CapaNegocio
Imports CapaDatos

Public Class FrmLogin

    Dim bl As New UsuarioBL()
    Dim intentos As Integer = 0
    Dim maxIntentos As Integer = 3

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Crea la base de datos y las tablas si no existen
        Try
            Conexion.InicializarBaseDatos()
        Catch ex As Exception
            MessageBox.Show(
                "Error al inicializar la base de datos:" & Environment.NewLine & Environment.NewLine &
                ex.Message & Environment.NewLine & Environment.NewLine &
                "Verifica que SQL Server esté corriendo." & Environment.NewLine &
                "Instancia configurada: .\SQLEXPRESS",
                "Error de Base de Datos",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End Try

        txtUsuario.Focus()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        ValidarLogin()
    End Sub

    Private Sub txtContrasena_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContrasena.KeyDown
        If e.KeyCode = Keys.Enter Then ValidarLogin()
    End Sub

    Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then txtContrasena.Focus()
    End Sub

    Private Sub ValidarLogin()
        Try
            Dim usuario = bl.Login(txtUsuario.Text.Trim(), txtContrasena.Text.Trim())

            If usuario IsNot Nothing Then
                Dim menu As New FrmMenu()
                Me.Hide()
                menu.ShowDialog()
                Me.Close()
            Else
                intentos += 1
                Dim restantes As Integer = maxIntentos - intentos

                If intentos >= maxIntentos Then
                    MessageBox.Show("Ha superado el número máximo de intentos." & Environment.NewLine &
                                    "El sistema se cerrará.", "Acceso bloqueado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Application.Exit()
                Else
                    MessageBox.Show("Usuario o contraseña incorrectos." & Environment.NewLine &
                                    $"Le quedan {restantes} intento(s).", "Acceso denegado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtContrasena.Clear()
                    txtContrasena.Focus()
                    ActualizarIntentos()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ActualizarIntentos()
        lblIntentos.Text = $"Intentos fallidos: {intentos} / {maxIntentos}"
        lblIntentos.ForeColor = If(intentos = 2, Color.Red, Color.OrangeRed)
        lblIntentos.Visible = True
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Application.Exit()
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'FrmLogin
        '
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Name = "FrmLogin"
        Me.ResumeLayout(False)

    End Sub

    Private Sub FrmLogin_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
