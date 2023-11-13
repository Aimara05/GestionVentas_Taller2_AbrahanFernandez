using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class CD_Cliente
    {
        public List<CLIENTES> Listar()  //metodo que va ser llamado en la cama de negocio
        {

            List<CLIENTES> lista = new List<CLIENTES>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select idCliente,documentoCliente,nombreCliente,apellidoCliente,correo,telefono,estado,fechacreacion from CLIENTES"; 
                  
                   
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())  //dr almacena el comando executeReader
                    {
                        while (dr.Read())
                        {
                            lista.Add(new CLIENTES()
                            {
                                idCliente = Convert.ToInt32(dr["idCliente"]),
                                documentoCliente = dr["documentoCliente"].ToString(),
                                nombreCliente = dr["nombreCliente"].ToString(),
                                apellidoCliente = dr["apellidoCliente"].ToString(),
                                correo = dr["correo"].ToString(),
                               
                                telefono = dr["telefono"].ToString(),
                                
                                estado = Convert.ToBoolean(dr["estado"]),
                                

                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<CLIENTES>();
                }
            }
            return lista;
        }

        //Registrar
        public int Registrar(CLIENTES obj, out string mensaje)
        {
            int idclientegenerado = 0;
            mensaje = String.Empty;

            try
            {

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("SP_REGISTRARCLIENTE", oconexion);
                    //parametros de entrada del proc almacenado
                    
                    cmd.Parameters.AddWithValue("documentoCliente", obj.documentoCliente);
                    cmd.Parameters.AddWithValue("nombreCliente", obj.nombreCliente);
                    cmd.Parameters.AddWithValue("apellidoCliente", obj.apellidoCliente);
                    cmd.Parameters.AddWithValue("correo", obj.correo);                   
                    cmd.Parameters.AddWithValue("telefono", obj.telefono);
                    
                    cmd.Parameters.AddWithValue("estado", obj.estado);
                    //parametros de salida
                    cmd.Parameters.Add("idClienteResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    idclientegenerado = Convert.ToInt32(cmd.Parameters["idClienteResultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                idclientegenerado = 0;
                mensaje = ex.Message;
            }

            return idclientegenerado;
        }

        //Método editar
        public bool Editar(CLIENTES obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = String.Empty;

            try
            {

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {



                    SqlCommand cmd = new SqlCommand("SP_EDITARCLIENTE", oconexion);
                    //parametros de entrada del proc almacenado
                    cmd.Parameters.AddWithValue("idCliente", obj.idCliente);
                    cmd.Parameters.AddWithValue("documentoCliente", obj.documentoCliente);
                    cmd.Parameters.AddWithValue("nombreCliente", obj.nombreCliente);
                    cmd.Parameters.AddWithValue("apellidoCliente", obj.apellidoCliente);
                    cmd.Parameters.AddWithValue("correo", obj.correo);
                    cmd.Parameters.AddWithValue("telefono", obj.telefono);
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

        //metodo baja cliente
        public bool Eliminar(CLIENTES obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = String.Empty;

            try
            {

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {



                    SqlCommand cmd = new SqlCommand("SP_ELIMINARCLIENTE", oconexion);
                    //parametros de entrada del proc almacenado
                    cmd.Parameters.AddWithValue("idCliente", obj.idCliente);

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

        //metodo alta usuario
        public bool Alta(CLIENTES obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = String.Empty;

            try
            {

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {



                    SqlCommand cmd = new SqlCommand("SP_ALTACLIENTE", oconexion);
                    //parametros de entrada del proc almacenado
                    cmd.Parameters.AddWithValue("idCliente", obj.idCliente);

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
