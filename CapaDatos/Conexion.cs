using System;
using System.Data.SqlClient;
using System.IO;

namespace CapaDatos
{
    public class Conexion
    {
        // Ruta relativa: busca museo2.mdf en la misma carpeta del ejecutable
        // Funciona en cualquier PC sin cambiar nada
        private static string GetConnectionString()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string dbPath = Path.Combine(baseDir, "museo2.mdf");

            return $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security=True;Connect Timeout=30";
        }

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(GetConnectionString());
        }
    }
}
