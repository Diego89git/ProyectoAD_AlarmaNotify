using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesProyect;
using System.Data;
using System.Data.SqlClient;

namespace DatosProyect
{
    public static class IncidenciaDatos
    {
        public static IncidenciaEntidad Nuevo(IncidenciaEntidad incidenciaEntidad) 
        {
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.conecionBD);
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"INSERT INTO [dbo].[Incidencia]
                                           ([IdUsuario]
                                           ,[Fecha]
                                           ,[Mensaje]
                                           ,[Estado]
                                           ,[Longitud]
                                           ,[Latitud])
                                     VALUES (@IdUsuario,@Fecha,@Mensaje,@Estado,@Longitud,@Latitud)
                                        SELECT SCOPE_IDENTITY()";
                cmd.Parameters.AddWithValue("@IdUsuario", incidenciaEntidad.IdUsuario);
                cmd.Parameters.AddWithValue("@Fecha",incidenciaEntidad.Fecha);
                cmd.Parameters.AddWithValue("@Mensaje",incidenciaEntidad.Mensaje);
                cmd.Parameters.AddWithValue("@Estado", incidenciaEntidad.Estado);
                cmd.Parameters.AddWithValue("@Longitud",incidenciaEntidad.Longitud);
                cmd.Parameters.AddWithValue("@Latitud", incidenciaEntidad.Latitud);
                int Id = Convert.ToInt32(cmd.ExecuteScalar());
                incidenciaEntidad.Id = Id;
                connection.Close();
                return incidenciaEntidad;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static IncidenciaEntidad Actualizar(IncidenciaEntidad incidenciaEntidad) 
        {
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.conecionBD);
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"UPDATE [dbo].[Incidencia]
                                       SET [IdUsuario] = @IdUsuario
                                          ,[Fecha] = @Fecha
                                          ,[Mensaje] = @Mensaje
                                          ,[Estado] = @Estado
                                          ,[Longitud] = @Longitud
                                          ,[Latitud] = @Latitud
                                     WHERE Id=@Id";
                cmd.Parameters.AddWithValue("@IdUsuario", incidenciaEntidad.IdUsuario);
                cmd.Parameters.AddWithValue("@Fecha", incidenciaEntidad.Fecha);
                cmd.Parameters.AddWithValue("@Mensaje", incidenciaEntidad.Mensaje);
                cmd.Parameters.AddWithValue("@Estado", incidenciaEntidad.Estado);
                cmd.Parameters.AddWithValue("@Longitud", incidenciaEntidad.Longitud);
                cmd.Parameters.AddWithValue("@Latitud", incidenciaEntidad.Latitud);
                cmd.Parameters.AddWithValue("@Id", incidenciaEntidad.Id);
                cmd.ExecuteNonQuery();
                connection.Close();
                return incidenciaEntidad;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public static List<IncidenciaEntidad> DevolverListadoIncidentes() 
        {
            try
            {
                List<IncidenciaEntidad> listaIncidencias = new List<IncidenciaEntidad>();
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.conecionBD);
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT ic.[Id]
                                      ,ic.[IdUsuario]
	                                  , nd.NumeroIdentificacion+'  '+nd.RazonSocial as Nodo
                                      ,ic.[Fecha]
                                      ,ic.[Mensaje]
                                      ,ic.[Estado]
                                      ,ic.[Longitud]
                                      ,ic.[Latitud]
                                  FROM [dbo].[Incidencia] ic, nodo nd
                                  WHERE ic.IdUsuario=nd.Id";
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        IncidenciaEntidad incidenciaEntidad = new IncidenciaEntidad();
                        incidenciaEntidad.Id = Convert.ToInt32(dr["Id"].ToString());
                        incidenciaEntidad.IdUsuario = Convert.ToInt32(dr["IdUsuario"].ToString());
                        incidenciaEntidad.Nodo = dr["Nodo"].ToString();
                        incidenciaEntidad.Fecha =Convert.ToDateTime(dr["Fecha"].ToString());
                        incidenciaEntidad.Mensaje = dr["Mensaje"].ToString();
                        incidenciaEntidad.Longitud = Convert.ToDecimal(dr["Longitud"].ToString());
                        incidenciaEntidad.Latitud = Convert.ToDecimal(dr["Latitud"].ToString());

                        listaIncidencias.Add(incidenciaEntidad);

                    }
                }
                connection.Close();
                return listaIncidencias;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static IncidenciaEntidad DevolverIncidentePorId(int Id) 
        {
            try
            {
                IncidenciaEntidad incidenciaEntidad = new IncidenciaEntidad();
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.conecionBD);
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT ic.[Id]
                                      ,ic.[IdUsuario]
	                                  , nd.NumeroIdentificacion+'  '+nd.RazonSocial as Nodo
                                      ,ic.[Fecha]
                                      ,ic.[Mensaje]
                                      ,ic.[Estado]
                                      ,ic.[Longitud]
                                      ,ic.[Latitud]
                                  FROM [dbo].[Incidencia] ic, nodo nd
                                  WHERE ic.IdUsuario=nd.Id and ic.Id=@Id";
                cmd.Parameters.AddWithValue("@Id", Id);
                using (var dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    if(dr.HasRows)
                    {
                        incidenciaEntidad.Id = Convert.ToInt32(dr["Id"].ToString());
                        incidenciaEntidad.IdUsuario = Convert.ToInt32(dr["IdUsuario"].ToString());
                        incidenciaEntidad.Nodo = dr["Nodo"].ToString();
                        incidenciaEntidad.Fecha = Convert.ToDateTime(dr["Fecha"].ToString());
                        incidenciaEntidad.Mensaje = dr["Mensaje"].ToString();
                        incidenciaEntidad.Longitud = Convert.ToDecimal(dr["Longitud"].ToString());
                        incidenciaEntidad.Latitud = Convert.ToDecimal(dr["Latitud"].ToString());

                    }
                }
                connection.Close();
                return incidenciaEntidad;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public static bool EliminarIncidente(int Id) 
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conecionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"DELETE FROM [dbo].[Incidencia] WHERE Id=@Id";
                cmd.Parameters.AddWithValue("@Id", Id);
                var filasAfectadas = Convert.ToInt32(cmd.ExecuteNonQuery());
                conexion.Close();
                if (filasAfectadas > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
