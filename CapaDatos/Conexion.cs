using System;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        
        private const string Servidor  = @".\SQLEXPRESS";
        private const string BaseDatos = "MuseoDB";

        private static string StringConexion =>
            $"Data Source={Servidor};Initial Catalog={BaseDatos};Integrated Security=True;Connect Timeout=30;";

        private static string StringMaster =>
            $"Data Source={Servidor};Initial Catalog=master;Integrated Security=True;Connect Timeout=30;";

        
        public static void InicializarBaseDatos()
        {
            CrearBaseDatosSiNoExiste();
            CrearTablasSiNoExisten();
            InsertarDatosIniciales();
        }

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(StringConexion);
        }

        
        private static void CrearBaseDatosSiNoExiste()
        {
            using (var conn = new SqlConnection(StringMaster))
            {
                conn.Open();
                string sql = $@"
                    IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = '{BaseDatos}')
                        CREATE DATABASE [{BaseDatos}];";
                new SqlCommand(sql, conn).ExecuteNonQuery();
            }
        }

        
        private static void CrearTablasSiNoExisten()
        {
            using (var conn = new SqlConnection(StringConexion))
            {
                conn.Open();

                string[] tablas = {

                    @"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Usuario')
                    CREATE TABLE Usuario (
                        IdUsuario       INT           IDENTITY(1,1) PRIMARY KEY,
                        NombreUsuario   NVARCHAR(50)  NOT NULL UNIQUE,
                        Contrasena      NVARCHAR(100) NOT NULL,
                        NombreCompleto  NVARCHAR(100) NOT NULL,
                        Rol             NVARCHAR(30)  NOT NULL,
                        Estado          NVARCHAR(10)  NOT NULL DEFAULT 'Activo'
                    )",

                    @"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Empleado')
                    CREATE TABLE Empleado (
                        IdEmpleado   INT           IDENTITY(1,1) PRIMARY KEY,
                        Nombre       NVARCHAR(80)  NOT NULL,
                        Apellido     NVARCHAR(80)  NOT NULL,
                        Cargo        NVARCHAR(80)  NOT NULL,
                        FechaIngreso DATE          NOT NULL,
                        Telefono     NVARCHAR(20)  NULL,
                        Email        NVARCHAR(100) NULL,
                        Estado       NVARCHAR(10)  NOT NULL DEFAULT 'Activo'
                    )",

                    @"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Guia')
                    CREATE TABLE Guia (
                        IdGuia   INT           IDENTITY(1,1) PRIMARY KEY,
                        Nombre   NVARCHAR(80)  NOT NULL,
                        Apellido NVARCHAR(80)  NOT NULL,
                        Telefono NVARCHAR(20)  NULL,
                        Email    NVARCHAR(100) NULL,
                        Idioma   NVARCHAR(50)  NOT NULL,
                        Estado   NVARCHAR(10)  NOT NULL DEFAULT 'Activo'
                    )",

                    @"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Visitante')
                    CREATE TABLE Visitante (
                        IdVisitante        INT           IDENTITY(1,1) PRIMARY KEY,
                        Nombre             NVARCHAR(80)  NOT NULL,
                        Apellido           NVARCHAR(80)  NOT NULL,
                        DocumentoIdentidad NVARCHAR(30)  NOT NULL,
                        Edad               INT           NOT NULL,
                        Genero             NVARCHAR(15)  NOT NULL,
                        Nacionalidad       NVARCHAR(50)  NOT NULL,
                        Email              NVARCHAR(100) NULL
                    )",

                    @"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Exposicion')
                    CREATE TABLE Exposicion (
                        IdExposicion INT           IDENTITY(1,1) PRIMARY KEY,
                        Nombre       NVARCHAR(100) NOT NULL,
                        Descripcion  NVARCHAR(500) NULL,
                        FechaInicio  DATE          NOT NULL,
                        FechaFin     DATE          NOT NULL,
                        Sala         NVARCHAR(50)  NOT NULL,
                        Responsable  NVARCHAR(100) NOT NULL
                    )",

                    @"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Pieza')
                    CREATE TABLE Pieza (
                        IdPieza            INT           IDENTITY(1,1) PRIMARY KEY,
                        Nombre             NVARCHAR(100) NOT NULL,
                        Descripcion        NVARCHAR(500) NULL,
                        Epoca              NVARCHAR(80)  NULL,
                        Material           NVARCHAR(80)  NULL,
                        EstadoConservacion NVARCHAR(30)  NOT NULL,
                        Ubicacion          NVARCHAR(100) NULL,
                        ValorEstimado      DECIMAL(18,2) NOT NULL DEFAULT 0
                    )"
                };

                foreach (var sql in tablas)
                    new SqlCommand(sql, conn).ExecuteNonQuery();
            }
        }

        
        private static void InsertarDatosIniciales()
        {
            using (var conn = new SqlConnection(StringConexion))
            {
                conn.Open();
                string sql = @"
                    IF NOT EXISTS (SELECT 1 FROM Usuario WHERE NombreUsuario = 'admin')
                    INSERT INTO Usuario (NombreUsuario, Contrasena, NombreCompleto, Rol, Estado)
                    VALUES ('admin', 'admin123', 'Administrador del Sistema', 'Admin', 'Activo')";
                new SqlCommand(sql, conn).ExecuteNonQuery();
            }
        }
    }
}
