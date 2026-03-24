using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class ExposicionDAO
    {
        public void Agregar(Exposicion expo)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"INSERT INTO Exposicion (Nombre, Descripcion, FechaInicio, FechaFin, Sala, Responsable)
                                 VALUES (@Nombre, @Descripcion, @FechaInicio, @FechaFin, @Sala, @Responsable)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre",      expo.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", expo.Descripcion ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaInicio", expo.FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin",    expo.FechaFin);
                cmd.Parameters.AddWithValue("@Sala",        expo.Sala);
                cmd.Parameters.AddWithValue("@Responsable", expo.Responsable);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Exposicion> Listar()
        {
            List<Exposicion> lista = new List<Exposicion>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT IdExposicion, Nombre, Descripcion, FechaInicio, FechaFin, Sala, Responsable FROM Exposicion";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Exposicion
                    {
                        IdExposicion = Convert.ToInt32(reader["IdExposicion"]),
                        Nombre       = reader["Nombre"].ToString(),
                        Descripcion  = reader["Descripcion"].ToString(),
                        FechaInicio  = Convert.ToDateTime(reader["FechaInicio"]),
                        FechaFin     = Convert.ToDateTime(reader["FechaFin"]),
                        Sala         = reader["Sala"].ToString(),
                        Responsable  = reader["Responsable"].ToString()
                    });
                }
            }
            return lista;
        }

        public void Actualizar(Exposicion expo)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"UPDATE Exposicion SET Nombre=@Nombre, Descripcion=@Descripcion,
                                 FechaInicio=@FechaInicio, FechaFin=@FechaFin,
                                 Sala=@Sala, Responsable=@Responsable
                                 WHERE IdExposicion=@IdExposicion";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdExposicion", expo.IdExposicion);
                cmd.Parameters.AddWithValue("@Nombre",       expo.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion",  expo.Descripcion ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaInicio",  expo.FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin",     expo.FechaFin);
                cmd.Parameters.AddWithValue("@Sala",         expo.Sala);
                cmd.Parameters.AddWithValue("@Responsable",  expo.Responsable);
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idExposicion)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "DELETE FROM Exposicion WHERE IdExposicion=@IdExposicion";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdExposicion", idExposicion);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
