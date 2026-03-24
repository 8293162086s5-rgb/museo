using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class PiezaDAO
    {
        public void Agregar(Pieza pieza)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"INSERT INTO Pieza (Nombre, Descripcion, Epoca, Material, EstadoConservacion, Ubicacion, ValorEstimado)
                                 VALUES (@Nombre, @Descripcion, @Epoca, @Material, @EstadoConservacion, @Ubicacion, @ValorEstimado)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre",             pieza.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion",        pieza.Descripcion        ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Epoca",              pieza.Epoca              ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Material",           pieza.Material           ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@EstadoConservacion", pieza.EstadoConservacion);
                cmd.Parameters.AddWithValue("@Ubicacion",          pieza.Ubicacion          ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@ValorEstimado",      pieza.ValorEstimado);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Pieza> Listar()
        {
            List<Pieza> lista = new List<Pieza>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT IdPieza, Nombre, Descripcion, Epoca, Material, EstadoConservacion, Ubicacion, ValorEstimado FROM Pieza";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Pieza
                    {
                        IdPieza            = Convert.ToInt32(reader["IdPieza"]),
                        Nombre             = reader["Nombre"].ToString(),
                        Descripcion        = reader["Descripcion"].ToString(),
                        Epoca              = reader["Epoca"].ToString(),
                        Material           = reader["Material"].ToString(),
                        EstadoConservacion = reader["EstadoConservacion"].ToString(),
                        Ubicacion          = reader["Ubicacion"].ToString(),
                        ValorEstimado      = Convert.ToDecimal(reader["ValorEstimado"])
                    });
                }
            }
            return lista;
        }

        public void Actualizar(Pieza pieza)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"UPDATE Pieza SET Nombre=@Nombre, Descripcion=@Descripcion, Epoca=@Epoca,
                                 Material=@Material, EstadoConservacion=@EstadoConservacion,
                                 Ubicacion=@Ubicacion, ValorEstimado=@ValorEstimado
                                 WHERE IdPieza=@IdPieza";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdPieza",            pieza.IdPieza);
                cmd.Parameters.AddWithValue("@Nombre",             pieza.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion",        pieza.Descripcion        ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Epoca",              pieza.Epoca              ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Material",           pieza.Material           ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@EstadoConservacion", pieza.EstadoConservacion);
                cmd.Parameters.AddWithValue("@Ubicacion",          pieza.Ubicacion          ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@ValorEstimado",      pieza.ValorEstimado);
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idPieza)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "DELETE FROM Pieza WHERE IdPieza=@IdPieza";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdPieza", idPieza);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
