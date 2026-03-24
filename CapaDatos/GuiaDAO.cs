using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class GuiaDAO
    {
        public void Agregar(Guia guia)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"INSERT INTO Guia (Nombre, Apellido, Telefono, Email, Idioma, Estado)
                                 VALUES (@Nombre, @Apellido, @Telefono, @Email, @Idioma, @Estado)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre",   guia.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", guia.Apellido);
                cmd.Parameters.AddWithValue("@Telefono", guia.Telefono ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Email",    guia.Email    ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Idioma",   guia.Idioma);
                cmd.Parameters.AddWithValue("@Estado",   guia.Estado);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Guia> Listar()
        {
            List<Guia> lista = new List<Guia>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT IdGuia, Nombre, Apellido, Telefono, Email, Idioma, Estado FROM Guia";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Guia
                    {
                        IdGuia   = Convert.ToInt32(reader["IdGuia"]),
                        Nombre   = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        Email    = reader["Email"].ToString(),
                        Idioma   = reader["Idioma"].ToString(),
                        Estado   = reader["Estado"].ToString()
                    });
                }
            }
            return lista;
        }

        public void Actualizar(Guia guia)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"UPDATE Guia SET Nombre=@Nombre, Apellido=@Apellido, Telefono=@Telefono,
                                 Email=@Email, Idioma=@Idioma, Estado=@Estado WHERE IdGuia=@IdGuia";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdGuia",   guia.IdGuia);
                cmd.Parameters.AddWithValue("@Nombre",   guia.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", guia.Apellido);
                cmd.Parameters.AddWithValue("@Telefono", guia.Telefono ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Email",    guia.Email    ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Idioma",   guia.Idioma);
                cmd.Parameters.AddWithValue("@Estado",   guia.Estado);
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idGuia)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "DELETE FROM Guia WHERE IdGuia=@IdGuia";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdGuia", idGuia);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
