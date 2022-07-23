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
    public static class NodoDatos
    {
        public static NodoEntidad Nuevo(NodoEntidad nodoEntidad)
        {
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.conecionBD);
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"INSERT INTO [dbo].[Nodo]
                                           ([TipoIdentificacion]
                                           ,[NumeroIdentificacion]
                                           ,[RazonSocial]
                                           ,[Representante]
                                           ,[Direccion]
                                           ,[Telefono]
                                           ,[Celular]
                                           ,[Password]
                                           ,[Latitud]
                                           ,[Longitud])
                                     VALUES
                                            (@TipoIdentificacion, @NumeroIdentificacion,@RazonSocial,@Representante,@Direccion, @Telefono,@Celular, @Password, @Latitud, @Longitud);
                                     SELECT SCOPE_IDENTITY()";
                cmd.Parameters.AddWithValue("@TipoIdentificacion", nodoEntidad.TipoIdentificacion);
                cmd.Parameters.AddWithValue("@NumeroIdentificacion", nodoEntidad.NumeroIdentificacion);
                cmd.Parameters.AddWithValue("@RazonSocial", nodoEntidad.RazonSocial);
                cmd.Parameters.AddWithValue("@Representante", nodoEntidad.Representante);
                cmd.Parameters.AddWithValue("@Direccion", nodoEntidad.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", nodoEntidad.Telefono);
                cmd.Parameters.AddWithValue("@Celular", nodoEntidad.Celular);
                cmd.Parameters.AddWithValue("@Password", nodoEntidad.Password);
                cmd.Parameters.AddWithValue("@Latitud", nodoEntidad.Latitud);
                cmd.Parameters.AddWithValue("@Longitud", nodoEntidad.Longitud);
                int Id = Convert.ToInt32(cmd.ExecuteScalar());
                nodoEntidad.Id = Id;
                connection.Close();
                return nodoEntidad;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public static NodoEntidad Actualizar(NodoEntidad nodoEntidad)
        {
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.conecionBD);
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"UPDATE [dbo].[Nodo]
                                       SET [TipoIdentificacion] = @TipoIdentificacion
                                          ,[NumeroIdentificacion] = @NumeroIdentificacion
                                          ,[RazonSocial] = @RazonSocial
                                          ,[Representante] = @Representante
                                          ,[Direccion] = @Direccion
                                          ,[Telefono] = @Telefono
                                          ,[Celular] = @Celular
                                          ,[Password] = @Password
                                          ,[Latitud] = @Latitud
                                          ,[Longitud] = @Longitud
                                     WHERE Id=@Id";
                cmd.Parameters.AddWithValue("@TipoIdentificacion", nodoEntidad.TipoIdentificacion);
                cmd.Parameters.AddWithValue("@NumeroIdentificacion", nodoEntidad.NumeroIdentificacion);
                cmd.Parameters.AddWithValue("@RazonSocial", nodoEntidad.RazonSocial);
                cmd.Parameters.AddWithValue("@Representante", nodoEntidad.Representante);
                cmd.Parameters.AddWithValue("@Direccion", nodoEntidad.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", nodoEntidad.Telefono);
                cmd.Parameters.AddWithValue("@Celular", nodoEntidad.Celular);
                cmd.Parameters.AddWithValue("@Password", nodoEntidad.Password);
                cmd.Parameters.AddWithValue("@Latitud", nodoEntidad.Latitud);
                cmd.Parameters.AddWithValue("@Longitud", nodoEntidad.Longitud);
                cmd.Parameters.AddWithValue("@Id", nodoEntidad.Id);
                cmd.ExecuteScalar();
           
                connection.Close();
                return nodoEntidad;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<NodoEntidad> DevolverListadoNodos()
        {
            try
            {
                List<NodoEntidad> listaNodos = new List<NodoEntidad>();
                SqlConnection coneccion = new SqlConnection(Properties.Settings.Default.conecionBD);
                coneccion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = coneccion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [Id]
                                      ,[TipoIdentificacion]
                                      ,[NumeroIdentificacion]
                                      ,[RazonSocial]
                                      ,[Representante]
                                      ,[Direccion]
                                      ,[Telefono]
                                      ,[Celular]
                                      ,[Password]
                                      ,[Latitud]
                                      ,[Longitud]
                                  FROM [dbo].[Nodo]";
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        NodoEntidad nodoEntidad = new NodoEntidad();
                        nodoEntidad.Id= Convert.ToInt32(dr["Id"].ToString());
                        nodoEntidad.TipoIdentificacion =dr["TipoIdentificacion"].ToString();
                        nodoEntidad.NumeroIdentificacion = dr["NumeroIdentificacion"].ToString();
                        nodoEntidad.RazonSocial = dr["RazonSocial"].ToString();
                        nodoEntidad.Representante = dr["Representante"].ToString();
                        nodoEntidad.Direccion = dr["Direccion"].ToString();
                        nodoEntidad.Telefono = dr["Telefono"].ToString();
                        nodoEntidad.Celular = dr["Celular"].ToString();
                        nodoEntidad.Password = dr["Password"].ToString();
                        nodoEntidad.Latitud = Convert.ToDecimal(dr["Latitud"].ToString());
                        nodoEntidad.Longitud = Convert.ToDecimal(dr["Longitud"].ToString());

                        listaNodos.Add(nodoEntidad);
                    }
                }
                coneccion.Close();
                return listaNodos;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public static NodoEntidad DevolverNodoPorId(int Id)
        {
            try
            {
                NodoEntidad nodoEntidad = new NodoEntidad();
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.conecionBD);
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [Id]
                                      ,[TipoIdentificacion]
                                      ,[NumeroIdentificacion]
                                      ,[RazonSocial]
                                      ,[Representante]
                                      ,[Direccion]
                                      ,[Telefono]
                                      ,[Celular]
                                      ,[Password]
                                      ,[Latitud]
                                      ,[Longitud]
                                  FROM [dbo].[Nodo]
                                    WHERE Id=@Id";
                cmd.Parameters.AddWithValue("@Id",Id);
                using (var dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    if (dr.HasRows)
                    {
                        nodoEntidad.Id = Convert.ToInt32(dr["Id"].ToString());
                        nodoEntidad.TipoIdentificacion = dr["TipoIdentificacion"].ToString();
                        nodoEntidad.NumeroIdentificacion = dr["NumeroIdentificacion"].ToString();
                        nodoEntidad.RazonSocial = dr["RazonSocial"].ToString();
                        nodoEntidad.Representante = dr["Representante"].ToString();
                        nodoEntidad.Direccion = dr["Direccion"].ToString();
                        nodoEntidad.Telefono = dr["Telefono"].ToString();
                        nodoEntidad.Celular = dr["Celular"].ToString();
                        nodoEntidad.Password = dr["Password"].ToString();
                        nodoEntidad.Latitud = Convert.ToDecimal(dr["Latitud"].ToString());
                        nodoEntidad.Longitud = Convert.ToDecimal(dr["Longitud"].ToString());
                    }
                }
                connection.Close();
                return nodoEntidad;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static NodoEntidad DevolverNodoPorLoggin(string user, string pass)
        {
            try
            {
                NodoEntidad nodoEntidad = new NodoEntidad();
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.conecionBD);
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [Id]
                                      ,[TipoIdentificacion]
                                      ,[NumeroIdentificacion]
                                      ,[RazonSocial]
                                      ,[Representante]
                                      ,[Direccion]
                                      ,[Telefono]
                                      ,[Celular]
                                      ,[Password]
                                      ,[Latitud]
                                      ,[Longitud]
                                  FROM [dbo].[Nodo]
                                    WHERE NumeroIdentificacion=@NumeroIdentificacion and Password=@pass";
                cmd.Parameters.AddWithValue("@NumeroIdentificacion", user);
                cmd.Parameters.AddWithValue("@pass", pass);
                using (var dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    if (dr.HasRows)
                    {
                        nodoEntidad.Id = Convert.ToInt32(dr["Id"].ToString());
                        nodoEntidad.TipoIdentificacion = dr["TipoIdentificacion"].ToString();
                        nodoEntidad.NumeroIdentificacion = dr["NumeroIdentificacion"].ToString();
                        nodoEntidad.RazonSocial = dr["RazonSocial"].ToString();
                        nodoEntidad.Representante = dr["Representante"].ToString();
                        nodoEntidad.Direccion = dr["Direccion"].ToString();
                        nodoEntidad.Telefono = dr["Telefono"].ToString();
                        nodoEntidad.Celular = dr["Celular"].ToString();
                        nodoEntidad.Password = dr["Password"].ToString();
                        nodoEntidad.Latitud = Convert.ToDecimal(dr["Latitud"].ToString());
                        nodoEntidad.Longitud = Convert.ToDecimal(dr["Longitud"].ToString());
                    }
                }
                connection.Close();
                return nodoEntidad;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static NodoEntidad DevolverNodoPorUsuario(string user)
        {
            try
            {
                NodoEntidad nodoEntidad = new NodoEntidad();
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.conecionBD);
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [Id]
                                      ,[TipoIdentificacion]
                                      ,[NumeroIdentificacion]
                                      ,[RazonSocial]
                                      ,[Representante]
                                      ,[Direccion]
                                      ,[Telefono]
                                      ,[Celular]
                                      ,[Password]
                                      ,[Latitud]
                                      ,[Longitud]
                                  FROM [dbo].[Nodo]
                                    WHERE NumeroIdentificacion=@NumeroIdentificacion ";
                cmd.Parameters.AddWithValue("@NumeroIdentificacion", user);
                using (var dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    if (dr.HasRows)
                    {
                        nodoEntidad.Id = Convert.ToInt32(dr["Id"].ToString());
                        nodoEntidad.TipoIdentificacion = dr["TipoIdentificacion"].ToString();
                        nodoEntidad.NumeroIdentificacion = dr["NumeroIdentificacion"].ToString();
                        nodoEntidad.RazonSocial = dr["RazonSocial"].ToString();
                        nodoEntidad.Representante = dr["Representante"].ToString();
                        nodoEntidad.Direccion = dr["Direccion"].ToString();
                        nodoEntidad.Telefono = dr["Telefono"].ToString();
                        nodoEntidad.Celular = dr["Celular"].ToString();
                        nodoEntidad.Password = dr["Password"].ToString();
                        nodoEntidad.Latitud = Convert.ToDecimal(dr["Latitud"].ToString());
                        nodoEntidad.Longitud = Convert.ToDecimal(dr["Longitud"].ToString());
                    }
                }
                connection.Close();
                return nodoEntidad;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static bool EliminarNodo(int Id)
        {
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.conecionBD);
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"DELETE FROM [dbo].[Nodo] WHERE Id=@id";
                cmd.Parameters.AddWithValue("@id", Id);
                var filasAfectadas = Convert.ToInt32(cmd.ExecuteNonQuery());
                connection.Close();
                if (filasAfectadas>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
