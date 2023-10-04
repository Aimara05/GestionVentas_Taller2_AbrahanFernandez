using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using CapaDatos;
using System.Collections;

namespace CapaDatos
{
    public class CD_Usuario
    {


       // Método Listar
        public List<USUARIO> Listar()  //metodo que va ser llamado en la capa de negocio
        {

            List<USUARIO> lista = new List<USUARIO>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    /*string query = "select idUsuario, documento, nombre, apellido, correo, usuario, clave, telefono, direccion, estado,idRol  from USUARIO"; */
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select u.idUsuario, u.documento, u.nombre, u.apellido, u.correo, u.usuario, u.clave, u.telefono, u.direccion, u.estado, u.fechaCreacion, r.idRol, r.descripcion from USUARIO u");
                    query.AppendLine("inner join ROL r on r.idRol = u.IdRol");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())  //dr almacena el comando executeReader
                    {
                        while (dr.Read())
                        {
                            lista.Add(new USUARIO()
                            {
                                idUsuario = Convert.ToInt32(dr["idUsuario"]),
                                documento = dr["documento"].ToString(),
                                nombre = dr["nombre"].ToString(),
                                apellido = dr["apellido"].ToString(),
                                correo = dr["correo"].ToString(),
                                usuario = dr["usuario"].ToString(),
                                clave = dr["clave"].ToString(),
                                telefono = dr["telefono"].ToString(),
                                direccion = dr["direccion"].ToString(),
                                estado = Convert.ToBoolean(dr["estado"]),
                               oRol= new ROL() { idRol= Convert.ToInt32(dr["idRol"]), 
                               descripcion = dr["descripcion"].ToString()
                               }

                            });
                        }
                        }
                
                }
                catch(Exception ex) {
                    lista = new List<USUARIO>();
                }
            }
            return lista;
        } 





        //Registrar
         public int Registrar(USUARIO obj, out string mensaje)
         {
             int idusuariogenerado = 0;
             mensaje = String.Empty;

             try
             {

                 using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                 {

                     SqlCommand cmd = new SqlCommand("SP_REGISTRARUSUARIO", oconexion);
                     //parametros de entrada del proc almacenado
                     cmd.Parameters.AddWithValue("idRol", obj.oRol.idRol);
                     cmd.Parameters.AddWithValue("documento", obj.documento);
                     cmd.Parameters.AddWithValue("nombre", obj.nombre);
                     cmd.Parameters.AddWithValue("apellido", obj.apellido);
                     cmd.Parameters.AddWithValue("correo", obj.correo);
                     cmd.Parameters.AddWithValue("usuario", obj.usuario);
                     cmd.Parameters.AddWithValue("clave", obj.clave);
                     cmd.Parameters.AddWithValue("telefono", obj.telefono);
                     cmd.Parameters.AddWithValue("direccion", obj.direccion);
                     cmd.Parameters.AddWithValue("estado", obj.estado);
                     //parametros de salida
                     cmd.Parameters.Add("idUsuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                     cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                     cmd.CommandType = CommandType.StoredProcedure;

                     oconexion.Open();

                     cmd.ExecuteNonQuery();

                     idusuariogenerado = Convert.ToInt32(cmd.Parameters["idUsuarioResultado"].Value);
                     mensaje = cmd.Parameters["mensaje"].Value.ToString();
                 }

             }
             catch (Exception ex)
             {
                 idusuariogenerado = 0;
                 mensaje = ex.Message;
             }

             return idusuariogenerado;
         }


        //Método editar
         public bool Editar(USUARIO obj, out string mensaje)
         {
             bool respuesta = false;
             mensaje = String.Empty;

             try
             {

                 using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                 {



                     SqlCommand cmd = new SqlCommand("SP_EDITARUSUARIO", oconexion);
                     //parametros de entrada del proc almacenado
                     cmd.Parameters.AddWithValue("idUsuario", obj.idUsuario);
                     cmd.Parameters.AddWithValue("idRol", obj.oRol.idRol);
                     cmd.Parameters.AddWithValue("documento", obj.documento);
                     cmd.Parameters.AddWithValue("nombre", obj.nombre);
                     cmd.Parameters.AddWithValue("apellido", obj.apellido);
                     cmd.Parameters.AddWithValue("correo", obj.correo);
                     cmd.Parameters.AddWithValue("usuario", obj.usuario);
                     cmd.Parameters.AddWithValue("clave", obj.clave);
                     cmd.Parameters.AddWithValue("telefono", obj.telefono);
                     cmd.Parameters.AddWithValue("direccion", obj.direccion);
                     cmd.Parameters.AddWithValue("estado", obj.estado);
                     //parametros de salida
                     cmd.Parameters.Add("respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                     cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                     cmd.CommandType = CommandType.StoredProcedure;

                     oconexion.Open();

                     cmd.ExecuteNonQuery();

                     respuesta = Convert.ToBoolean(cmd.Parameters["respuesta"].Value);
                     mensaje = cmd.Parameters["mensaje"].Value.ToString();
                 }

             }
             catch (Exception ex)
             {
                 respuesta = false;
                 mensaje = ex.Message;
             }

             return respuesta;
         }


        //Método Eliminar
         public bool Eliminar(USUARIO obj, out string mensaje)
         {
             bool respuesta = false;
             mensaje = String.Empty;

             try
             {

                 using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                 {



                     SqlCommand cmd = new SqlCommand("SP_ELIMINARUSUARIO", oconexion);
                     //parametros de entrada del proc almacenado
                     cmd.Parameters.AddWithValue("idUsuario", obj.idUsuario);

                     //parametros de salida
                     cmd.Parameters.Add("respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                     cmd.Parameters.Add("mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;

                     cmd.CommandType = CommandType.StoredProcedure;

                     oconexion.Open();

                     cmd.ExecuteNonQuery();

                     respuesta = Convert.ToBoolean(cmd.Parameters["respuesta"].Value);
                     mensaje = cmd.Parameters["mensaje"].Value.ToString();
                 }

             }
             catch (Exception ex)
             {
                 respuesta = false;
                 mensaje = ex.Message;
             }

             return respuesta;

             }

        //Método Alta Usuario
        public bool Alta(USUARIO obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = String.Empty;

            try
            {

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {



                    SqlCommand cmd = new SqlCommand("SP_ALTAUSUARIO", oconexion);
                    //parametros de entrada del proc almacenado
                    cmd.Parameters.AddWithValue("idUsuario", obj.idUsuario);

                    //parametros de salida
                    cmd.Parameters.Add("respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["respuesta"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();


                }

            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message;
            }

            return respuesta;

        }


    }


}
    
