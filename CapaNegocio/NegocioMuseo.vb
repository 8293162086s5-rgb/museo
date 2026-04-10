Imports CapaEntidades
Imports CapaDatos

Namespace CapaNegocio


    Public Class EmpleadoBL
        Private dao As New EmpleadoDAO()

        Public Sub Agregar(emp As Empleado)
            If String.IsNullOrWhiteSpace(emp.Nombre) Then Throw New Exception("El nombre del empleado es obligatorio.")
            If String.IsNullOrWhiteSpace(emp.Apellido) Then Throw New Exception("El apellido del empleado es obligatorio.")
            If String.IsNullOrWhiteSpace(emp.Cargo) Then Throw New Exception("El cargo del empleado es obligatorio.")
            If emp.FechaIngreso > Date.Today Then Throw New Exception("La fecha de ingreso no puede ser futura.")
            dao.Agregar(emp)
        End Sub

        Public Function Listar() As List(Of Empleado)
            Return dao.Listar()
        End Function

        Public Sub Actualizar(emp As Empleado)
            If String.IsNullOrWhiteSpace(emp.Nombre) Then Throw New Exception("El nombre del empleado es obligatorio.")
            If String.IsNullOrWhiteSpace(emp.Apellido) Then Throw New Exception("El apellido del empleado es obligatorio.")
            dao.Actualizar(emp)
        End Sub

        Public Sub Eliminar(idEmpleado As Integer)
            If idEmpleado <= 0 Then Throw New Exception("ID de empleado inválido.")
            dao.Eliminar(idEmpleado)
        End Sub
    End Class


    Public Class GuiaBL
        Private dao As New GuiaDAO()

        Public Sub Agregar(guia As Guia)
            If String.IsNullOrWhiteSpace(guia.Nombre) Then Throw New Exception("El nombre del guía es obligatorio.")
            If String.IsNullOrWhiteSpace(guia.Apellido) Then Throw New Exception("El apellido del guía es obligatorio.")
            If String.IsNullOrWhiteSpace(guia.Idioma) Then Throw New Exception("El idioma del guía es obligatorio.")
            dao.Agregar(guia)
        End Sub

        Public Function Listar() As List(Of Guia)
            Return dao.Listar()
        End Function

        Public Sub Actualizar(guia As Guia)
            If String.IsNullOrWhiteSpace(guia.Nombre) Then Throw New Exception("El nombre del guía es obligatorio.")
            If String.IsNullOrWhiteSpace(guia.Apellido) Then Throw New Exception("El apellido del guía es obligatorio.")
            dao.Actualizar(guia)
        End Sub

        Public Sub Eliminar(idGuia As Integer)
            If idGuia <= 0 Then Throw New Exception("ID de guía inválido.")
            dao.Eliminar(idGuia)
        End Sub
    End Class


    Public Class VisitanteBL
        Private dao As New VisitanteDAO()

        Public Sub Agregar(vis As Visitante)
            If String.IsNullOrWhiteSpace(vis.Nombre) Then Throw New Exception("El nombre del visitante es obligatorio.")
            If String.IsNullOrWhiteSpace(vis.Apellido) Then Throw New Exception("El apellido del visitante es obligatorio.")
            If String.IsNullOrWhiteSpace(vis.DocumentoIdentidad) Then Throw New Exception("El documento de identidad es obligatorio.")
            If vis.Edad < 0 OrElse vis.Edad > 120 Then Throw New Exception("La edad debe estar entre 0 y 120.")
            dao.Agregar(vis)
        End Sub

        Public Function Listar() As List(Of Visitante)
            Return dao.Listar()
        End Function

        Public Sub Actualizar(vis As Visitante)
            If String.IsNullOrWhiteSpace(vis.Nombre) Then Throw New Exception("El nombre del visitante es obligatorio.")
            If vis.Edad < 0 OrElse vis.Edad > 120 Then Throw New Exception("La edad debe estar entre 0 y 120.")
            dao.Actualizar(vis)
        End Sub

        Public Sub Eliminar(idVisitante As Integer)
            If idVisitante <= 0 Then Throw New Exception("ID de visitante inválido.")
            dao.Eliminar(idVisitante)
        End Sub
    End Class


    Public Class ExposicionBL
        Private dao As New ExposicionDAO()

        Public Sub Agregar(expo As Exposicion)
            If String.IsNullOrWhiteSpace(expo.Nombre) Then Throw New Exception("El nombre de la exposición es obligatorio.")
            If String.IsNullOrWhiteSpace(expo.Sala) Then Throw New Exception("La sala es obligatoria.")
            If expo.FechaFin < expo.FechaInicio Then Throw New Exception("La fecha de fin no puede ser anterior a la fecha de inicio.")
            dao.Agregar(expo)
        End Sub

        Public Function Listar() As List(Of Exposicion)
            Return dao.Listar()
        End Function

        Public Sub Actualizar(expo As Exposicion)
            If String.IsNullOrWhiteSpace(expo.Nombre) Then Throw New Exception("El nombre de la exposición es obligatorio.")
            If expo.FechaFin < expo.FechaInicio Then Throw New Exception("La fecha de fin no puede ser anterior a la fecha de inicio.")
            dao.Actualizar(expo)
        End Sub

        Public Sub Eliminar(idExposicion As Integer)
            If idExposicion <= 0 Then Throw New Exception("ID de exposición inválido.")
            dao.Eliminar(idExposicion)
        End Sub
    End Class


    Public Class PiezaBL
        Private dao As New PiezaDAO()

        Public Sub Agregar(pieza As Pieza)
            If String.IsNullOrWhiteSpace(pieza.Nombre) Then Throw New Exception("El nombre de la pieza es obligatorio.")
            If pieza.ValorEstimado < 0 Then Throw New Exception("El valor estimado no puede ser negativo.")
            dao.Agregar(pieza)
        End Sub

        Public Function Listar() As List(Of Pieza)
            Return dao.Listar()
        End Function

        Public Sub Actualizar(pieza As Pieza)
            If String.IsNullOrWhiteSpace(pieza.Nombre) Then Throw New Exception("El nombre de la pieza es obligatorio.")
            If pieza.ValorEstimado < 0 Then Throw New Exception("El valor estimado no puede ser negativo.")
            dao.Actualizar(pieza)
        End Sub

        Public Sub Eliminar(idPieza As Integer)
            If idPieza <= 0 Then Throw New Exception("ID de pieza inválido.")
            dao.Eliminar(idPieza)
        End Sub
    End Class

End Namespace
