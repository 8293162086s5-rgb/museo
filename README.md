# Sistema de Gestión de Museo


## Documentación del Proyecto (Etapas del Ciclo de Vida de un Sistema)

## Índice

- Fase I: Análisis de Sistemas I
  - 1 Estudio del Problema
  - 2 Definición de Objetivos del Sistema
  - 3 Recolección de Información
  - 4 Modelo del Sistema Actual (AS-IS)
  - 5 Modelo del Sistema Propuesto (TO-BE)
  - 6 Requerimientos Funcionales y No Funcionales
    - 6.1 Requerimientos Funcionales
    - 6.2 Requerimientos No Funcionales
  - 7 Diagrama de Casos de Uso
  - 8 Diccionario de Datos

- Fase II: Diseño de Sistemas II
  - 9 Diagramas UML
    - 9.1 Diagrama de Clases
    - 9.2 Diagrama de Actividades
    - 9.3 Diagrama de Secuencia
  - 10 Diseño de Base de Datos (MER y DER)
  - 11 Prototipos de la Interfaz Gráfica
  - 12 Plan de Pruebas Funcionales
  - 13 Manual Técnico
  - 14 Manual de Usuario
   
 # Análisis de Sistemas
 

 ## 1. Estudio del Problema
Estudio del Problema Los museos pequeños y medianos suelen enfrentar procesos manuales desorganizados para gestionar sus colecciones y visitantes. En la institución estudiada (no especificado por tratarse de un caso académico) los registros de piezas, exposiciones y visitas se llevan en papel o en múltiples hojas de cálculo dispersas, sin un sistema unificado. Esto genera duplicación de datos, errores humanos y dificultades para acceder a información histórica rápidamente. Por ejemplo, se ha documentado que reportes de inventario pueden tardar días en prepararse debido a la consolidación manual de datos. La falta de digitalización también limita el análisis estadístico de la afluencia de visitantes y el mantenimiento predictivo de piezas.

Estos problemas impactan directamente en la eficiencia operativa del museo y en la conservación del patrimonio cultural. Al no existir trazabilidad electrónica (auditorías de movimiento de piezas, historial de visitas, etc.), la administración carece de mecanismos para garantizar la seguridad y transparencia de los procesos internos. En síntesis, el problema radica en la ineficiencia y riesgo derivados de la gestión manual de la información museística, lo que motiva la necesidad de un sistema de software que centralice y automatice estas tareas.


 ## 2. Definición de Objetivos del Sistema
El objetivo principal del sistema es digitalizar y centralizar los procesos del museo para mejorar la organización y el control de la información.

Se propone desarrollar una aplicación de escritorio que permita registrar, consultar y controlar todos los datos desde un solo lugar. Esta aplicación tendrá una interfaz fácil de usar y estará organizada en diferentes capas para su correcto funcionamiento.


 ## 3. Recolección de Información
Estudio del Problema Los museos pequeños y medianos suelen enfrentar procesos manuales desorganizados para gestionar sus colecciones y visitantes. En la institución estudiada (no especificado por tratarse de un caso académico) los registros de piezas, exposiciones y visitas se llevan en papel o en múltiples hojas de cálculo dispersas, sin un sistema unificado. Esto genera duplicación de datos, errores humanos y dificultades para acceder a información histórica rápidamente. Por ejemplo, se ha documentado que reportes de inventario pueden tardar días en prepararse debido a la consolidación manual de datos. La falta de digitalización también limita el análisis estadístico de la afluencia de visitantes y el mantenimiento predictivo de piezas.

Estos problemas impactan directamente en la eficiencia operativa del museo y en la conservación del patrimonio cultural. Al no existir trazabilidad electrónica (auditorías de movimiento de piezas, historial de visitas, etc.), la administración carece de mecanismos para garantizar la seguridad y transparencia de los procesos internos. En síntesis, el problema radica en la ineficiencia y riesgo derivados de la gestión manual de la información museística, lo que motiva la necesidad de un sistema de software que centralice y automatice estas tareas.
A partir de esta información se establecieron los trabajos actuales, los cuales sirvieron de base para modelar los procesos del sistema propuesto y garantizar que la solución tecnológica se adaptara a las necesidades reales del museo.


 ## 4. Modelo del Sistema Actual (AS-IS)
Actualmente no existe un sistema automatizado. Todo se realiza de forma manual:

1. El recepcionista registra los visitantes en papel.  
2. Los guías actualizan archivos de Excel después de cada visita.  
3. El administrador recopila toda la información manualmente para generar reportes.  

Este proceso genera errores, pérdida de información y duplicación de datos. Por ejemplo, un mismo visitante puede ser registrado varias veces debido a la falta de control.



 ## 5. Modelo del Sistema Propuesto (TO-BE)
Se propone desarrollar una aplicación de escritorio organizada en tres capas: presentación, negocio y datos.

  ### El sistema permitirá:

1. Gestionar empleados y guías  
2. Registrar visitantes  
3. Administrar piezas y exposiciones  
4. Registrar visitas guiadas  
5. Generar reportes  

Toda la información se almacenará en una base de datos, lo que permitirá evitar duplicaciones y mejorar el acceso a los datos. Además, cada acción quedará registrada, permitiendo llevar un control y seguimiento adecuado.



 ## 6. Requerimientos Funcionales y No Funcionales

  ### 6.1 Requerimientos Funcionales
1. Registrar información completa de las piezas del museo  
2. Administrar exposiciones  
3. Relacionar piezas con exposiciones  
4. Registrar visitantes y guías  
5. Controlar los movimientos de las piezas  
6. Realizar búsquedas de información  
7. Generar reportes  
8. Registrar visitas guiadas  

  ### 6.2 Requerimientos No Funcionales
1. El sistema debe ser una aplicación de escritorio para Windows  
2. Debe ser fácil de usar  
3. La información debe almacenarse de forma segura  
4. Debe requerir usuario y contraseña  
5. Debe ser rápido en las consultas  
6. El código debe permitir mantenimiento y mejoras



## 7. Diagrama de Casos de Uso

  #### 1. Iniciar sesión  
El usuario (administrador o empleado) introduce su usuario y contraseña. El sistema verifica los datos y, si son correctos, permite entrar al sistema mostrando las opciones según el tipo de usuario.

  #### 2. Cambiar sesión  
El usuario puede cerrar su sesión actual para iniciar con otro usuario. El sistema lo lleva nuevamente a la pantalla de inicio de sesión.

  #### 3. Salir del sistema  
El usuario cierra completamente el sistema. La aplicación se detiene.

### Funciones del Administrador

  #### 4. Gestionar empleados  
El administrador puede agregar, modificar o eliminar empleados. Se registran datos como nombre, cargo, teléfono y estado.

  #### 5. Gestionar proveedores  
El administrador puede registrar nuevos proveedores, editar su información o eliminarlos del sistema.

  #### 6. Gestionar contratos  
El administrador maneja los contratos, donde puede registrar información como fechas, tipo de contrato y monto.

  #### 7. Gestionar mantenimiento  
El administrador registra y controla las actividades de mantenimiento del museo, indicando tipo, área, responsable y estado.

  #### 8. Gestionar inventario  
El administrador administra el inventario del museo, donde puede registrar piezas con su código, categoría, ubicación y valor.

  #### 9. Generar reportes  
El administrador puede generar reportes para ver información del sistema como inventario, visitantes o mantenimiento.

### Funciones del Empleado

  #### 10. Gestionar guías  
El empleado registra y actualiza la información de los guías, como nombre, idioma y contacto.

  #### 11. Gestionar visitantes  
El empleado puede registrar y consultar la información de los visitantes.

  #### 12. Gestionar exposiciones  
El empleado administra las exposiciones, incluyendo datos como nombre, fechas y sala.

  #### 13. Gestionar piezas  
El empleado registra y actualiza las piezas del museo.

  #### 14. Gestionar salas  
El empleado administra las salas del museo, como su capacidad y ubicación.

  #### 15. Registrar donaciones  
El empleado registra las donaciones hechas al museo, incluyendo información del donante.

  #### 16. Registrar entradas  
El empleado registra la venta de entradas, indicando tipo, cantidad y método de pago.

  #### 17. Gestionar eventos  
El empleado administra los eventos del museo, incluyendo fechas y detalles.

  #### 18. Gestionar préstamos  
El empleado registra los préstamos de piezas a otras instituciones.

  #### 19. Gestionar reservas  
El empleado administra las reservas de visitas, incluyendo fecha, cantidad de visita y tipo


![Diagrama de casos de uso](Diagramadecasosdeuso.png)




## 8. Diccionario de Datos

### TABLA: CONTRATO
IdContrato (INT, PK): Identificador del contrato
NumeroContrato (VARCHAR): Número del contrato
NombreProveedor (VARCHAR): Nombre del proveedor
Descripcion (VARCHAR): Descripción del contrato
Tipo (VARCHAR): Tipo de contrato
MontoTotal (DECIMAL): Monto total
FechaInicio (DATE): Fecha de inicio
FechaVencimiento (DATE): Fecha de vencimiento
Estado (VARCHAR): Estado del contrato
Observaciones (VARCHAR): Comentarios adicionales



### TABLA: DONACION
IdDonacion (INT, PK): Identificador de la donación
NombreDonante (VARCHAR): Nombre del donante
EmailDonante (VARCHAR): Correo del donante
TelefonoDonante (VARCHAR): Teléfono
Tipo (VARCHAR): Tipo de donación
Descripcion (VARCHAR): Descripción
ValorEstimado (DECIMAL): Valor estimado
FechaDonacion (DATE): Fecha
Estado (VARCHAR): Estado



### TABLA: EMPLEADO
IdEmpleado (PK): Identificador
Nombre: Nombre
Apellido: Apellido
Cargo: Cargo
FechaIngreso: Fecha de ingreso
Telefono: Teléfono
Email: Correo
Estado: Estado



### TABLA: ENTRADA
IdEntrada (INT, PK): Identificador
NombreVisitante (VARCHAR): Nombre del visitante
Tipo (VARCHAR): Tipo de entrada
Precio (DECIMAL): Precio
Cantidad (INT): Cantidad
Fecha (DATE): Fecha
MetodoPago (VARCHAR): Método de pago
Observaciones (VARCHAR): Observaciones



#### TABLA: EVENTO
IdEvento (INT, PK): Identificador
Nombre (VARCHAR): Nombre
Tipo (VARCHAR): Tipo
Responsable (VARCHAR): Responsable
CapacidadMaxima (INT): Capacidad máxima
FechaInicio (DATE): Fecha de inicio
FechaFin (DATE): Fecha de fin
Estado (VARCHAR): Estado
Descripcion (VARCHAR): Descripción




#### TABLA: EXPOSICION
IdExposicion (INT, PK): Identificador
Nombre (VARCHAR): Nombre
Descripcion (VARCHAR): Descripción
FechaInicio (DATE): Fecha de inicio
FechaFin (DATE): Fecha de fin
Sala (VARCHAR): Sala
Responsable (VARCHAR): Responsable



### TABLA: GUIA
IdGuia (INT, PK): Identificador
Nombre (VARCHAR): Nombre
Apellido (VARCHAR): Apellido
Telefono (VARCHAR): Teléfono
Email (VARCHAR): Correo
Idioma (VARCHAR): Idioma
Estado (VARCHAR): Estado


### TABLA: INVENTARIO
IdInventario (INT, PK): Identificador
Nombre (VARCHAR): Nombre
CodigoInventario (VARCHAR): Código
Categoria (VARCHAR): Categoría
Epoca (VARCHAR): Época
Material (VARCHAR): Material
Ubicacion (VARCHAR): Ubicación
ValorEstimado (DECIMAL): Valor estimado
Estado (VARCHAR): Estado
FechaIngreso (DATE): Fecha de ingreso
Descripcion (VARCHAR): Descripción


### TABLA: MANTENIMIENTO
IdMantenimiento (INT, PK): Identificador
TipoMantenimiento (VARCHAR): Tipo
Descripcion (VARCHAR): Descripción
Area (VARCHAR): Área
Responsable (VARCHAR): Responsable
FechaInicio (DATE): Fecha de inicio
FechaFin (DATE): Fecha de fin
Costo (DECIMAL): Costo
Estado (VARCHAR): Estado
Observaciones (VARCHAR): Observaciones


### TABLA: PIEZA
IdPieza (INT, PK): Identificador
Nombre (VARCHAR): Nombre
Descripcion (VARCHAR): Descripción
Epoca (VARCHAR): Época
Material (VARCHAR): Material
EstadoConservacion (VARCHAR): Estado
Ubicacion (VARCHAR): Ubicación
ValorEstimado (DECIMAL): Valor


### TABLA: PRESTAMO
IdPrestamo (INT, PK): Identificador
NombrePieza (VARCHAR): Nombre de la pieza
InstitucionSolicitante (VARCHAR): Institución
Responsable (VARCHAR): Responsable
Contacto (VARCHAR): Contacto
FechaPrestamo (DATE): Fecha préstamo
FechaDevolucion (DATE): Fecha devolución
Estado (VARCHAR): Estado
Condiciones (VARCHAR): Condiciones


### TABLA: PROVEEDOR
IdProveedor (INT, PK): Identificador
RazonSocial (VARCHAR): Nombre
RNC (VARCHAR): Identificación
Contacto (VARCHAR): Contacto
Telefono (VARCHAR): Teléfono
Email (VARCHAR): Correo
Direccion (VARCHAR): Dirección
Categoria (VARCHAR): Categoría
Estado (VARCHAR): Estado
FechaRegistro (DATE): Fecha


### TABLA: REPORTE
IdReporte (INT, PK): Identificador
Titulo (VARCHAR): Título
Tipo (VARCHAR): Tipo
FechaGeneracion (DATE): Fecha
GeneradoPor (VARCHAR): Usuario
PeriodoDesde (DATE): Desde
PeriodoHasta (DATE): Hasta
Descripcion (VARCHAR): Descripción
Estado (VARCHAR): Estado



### TABLA: RESERVA
IdReserva (INT, PK): Identificador
NombreVisitante (VARCHAR): Nombre del visitante
CantidadPersonas (INT): Cantidad
FechaReserva (DATE): Fecha
Hora (DATE): Hora
Tipo (VARCHAR): Tipo
Estado (VARCHAR): Estado
Observaciones (VARCHAR): Observaciones


### TABLA: SALA
IdSala (INT, PK): Identificador
Nombre (VARCHAR): Nombre
Capacidad (INT): Capacidad
Ubicacion (VARCHAR): Ubicación
Tipo (VARCHAR): Tipo
Estado (VARCHAR): Estado
Descripcion (VARCHAR): Descripción


### TABLA: USUARIO
IdUsuario (INT, PK): Identificador
NombreUsuario (VARCHAR): Usuario
Contrasena (VARCHAR): Contraseña
NombreCompleto (VARCHAR): Nombre completo
Rol (VARCHAR): Rol
Estado (VARCHAR): Estado



### TABLA: VISITANTE
IdVisitante (INT, PK): Identificador
Nombre (VARCHAR): Nombre
Apellido (VARCHAR): Apellido
DocumentoIdentidad (VARCHAR): Documento
Edad (INT): Edad
Genero (VARCHAR): Género
Nacionalidad (VARCHAR): Nacionalidad
Email (VARCHAR): Correo



# Fase II: Diseño de Sistemas II

## 9. Diagramas UML

En esta sección se presentan los diagramas UML del sistema, los cuales permiten comprender su estructura, funcionamiento y comportamiento antes de la implementación.

### 9.1 Diagrama de Clases

El diagrama de clases representa la estructura del sistema desde el punto de vista de la programación orientada a objetos.

En este diagrama se muestran las clases principales del sistema, sus atributos, métodos y las relaciones entre ellas.

Este diagrama permite entender cómo se organizará el código del sistema y cómo interactúan sus componentes.

### 9.2 Diagrama de Actividades

El diagrama de actividades representa el flujo de procesos del sistema.

Muestra paso a paso cómo se realiza una operación, en este caso la reserva de un evento y la generación de una entrada.

Incluye decisiones que permiten visualizar diferentes caminos dependiendo de las condiciones del sistema.

### 9.3 Diagrama de Secuencia

El diagrama de secuencia muestra la interacción entre los diferentes componentes del sistema en el tiempo.

En este caso se representa cómo el usuario interactúa con la interfaz, la lógica de negocio, el acceso a datos y la base de datos para realizar una reserva y generar una entrada.

Además, se evidencia el uso de una arquitectura en capas que organiza el sistema de forma estructurada.

---

## 10. Diseño de Base de Datos (MER y DER)

### Descripción del Diseño

La base de datos fue diseñada para organizar la información del sistema de forma clara, utilizando tablas relacionadas mediante claves primarias y foráneas.

### Modelo Entidad-Relación (MER)

El modelo entidad-relación muestra de manera general cómo está organizado el sistema.

Las principales entidades del sistema son:

Usuario, Empleado, Visitante, Guía, Sala, Evento, Exposición, Entrada, Reserva, Pieza, Inventario, Préstamo y Donación.

#### Relaciones principales

- Un visitante puede tener varias entradas y reservas  
- Una reserva pertenece a un evento  
- Un evento se realiza en una sala  
- Una exposición se presenta en una sala  
- Un evento está relacionado con un empleado y un guía  
- Una pieza puede estar en inventario, ser prestada o donada  

### Diagrama Entidad-Relación (DER)

El DER representa la base de datos de forma detallada, mostrando las tablas, sus campos principales y las relaciones entre ellas.

### Estructura de la Base de Datos

#### Entidades

- Usuario  
- Empleado  
- Visitante  
- Guía  
- Sala  
- Evento  
- Exposición  
- Entrada  
- Reserva  
- Pieza  
- Inventario  
- Préstamo  
- Donación  

#### Relaciones

- USUARIO → EMPLEADO (1:1)  
- VISITANTE → ENTRADA (1:N)  
- VISITANTE → RESERVA (1:N)  
- RESERVA → EVENTO (N:1)  
- EVENTO → SALA (N:1)  
- EXPOSICIÓN → SALA (N:1)  
- EVENTO → EMPLEADO (N:1)  
- EVENTO → GUÍA (N:1)  
- PIEZA → INVENTARIO (1:1)  
- PIEZA → PRÉSTAMO (1:N)  
- PIEZA → DONACIÓN (1:N)  
- ENTRADA → EXPOSICIÓN (N:1)  

---

## 11. Prototipos de la Interfaz Gráfica

### Descripción

Los prototipos muestran las pantallas del sistema y cómo el usuario interactúa con ellas.

### Pantalla de Inicio de Sesión

Permite al usuario ingresar al sistema mediante usuario y contraseña.

### Menú Principal del Sistema

Muestra todos los módulos disponibles según el tipo de usuario.

### Módulos del Sistema

- Gestión de Empleados  
- Gestión de Guías  
- Gestión de Visitantes  
- Gestión de Piezas  
- Control de Inventario  
- Gestión de Salas  
- Gestión de Exposiciones  
- Gestión de Eventos  
- Gestión de Reservas  
- Venta de Entradas  
- Registro de Donaciones  
- Préstamos de Piezas  

---

## 12. Plan de Pruebas Funcionales

### Descripción

Se utiliza para verificar que cada módulo funcione correctamente.

### Objetivo

Validar que el sistema cumpla con los requerimientos establecidos.

### Casos de Prueba

- Inicio de sesión  
- Gestión de empleados  
- Gestión de visitantes  
- Gestión de piezas  
- Inventario  
- Reservas  
- Entradas  

---

## 13. Manual Técnico

### Introducción

Describe la estructura interna del sistema y su funcionamiento.

### Arquitectura del Sistema

El sistema está basado en programación orientada a objetos y arquitectura en capas.

### Módulos del Sistema

- Usuarios  
- Visitantes  
- Empleados  
- Guías  
- Salas  
- Exposiciones  
- Eventos  
- Entradas  
- Reservas  
- Piezas  
- Inventario  
- Préstamos  
- Donaciones  

### Base de Datos

- Uso de claves primarias (PK)  
- Uso de claves foráneas (FK)  
- Integridad de datos  
- Eliminación de duplicidad  

---

## 14. Manual de Usuario 

### Introducción

Permite al usuario gestionar la información del sistema de manera sencilla.

### Módulos

- Usuarios  
- Visitantes  
- Empleados  
- Guías  
- Salas  
- Exposiciones  
- Eventos  
- Entradas  
- Reservas  
- Piezas  
- Inventario  
- Préstamos  
- Donaciones  

### Salir del Sistema

El sistema permite cerrar la aplicación de forma segura desde el menú principal.
