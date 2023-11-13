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
    public class CD_Producto
    {

        // Método Listar
        // Método Listar
        public List<PRODUCTOS> Listar()  //metodo que va ser llamado en la capa de negocio
        {

            List<PRODUCTOS> lista = new List<PRODUCTOS>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    /*string query = "select idUsuario, documento, nombre, apellido, correo, usuario, clave, telefono, direccion, estado,idRol  from USUARIO"; */
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select u.idProducto, u.nombreProd, u.descripcionProd, u.talle, u.stock, u.estado, u.precioUni, r.idCateg, r.descripcion, m.idMarca,m.descripcionMarca from PRODUCTOS u");
                    query.AppendLine("inner join CATEGORIAS r on r.idCateg = u.IdCateg");
                    query.AppendLine("inner join MARCAS m on m.idMarca = u.IdMarca");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())  //dr almacena el comando executeReader
                    {
                        while (dr.Read())
                        {
                            lista.Add(new PRODUCTOS()
                            {
                                idProducto = Convert.ToInt32(dr["idProducto"]),
                               
                                nombreProd = dr["nombreProd"].ToString(),
                                descripcionProd = dr["descripcionProd"].ToString(),
                                talle = dr["talle"].ToString(),
                                stock = Convert.ToInt32(dr["stock"]),
                                estado = Convert.ToBoolean(dr["estado"]),
                                precioUni = Convert.ToDouble(dr["precioUni"]),
                                oCategorias = new CATEGORIAS()
                                {
                                    idCateg = Convert.ToInt32(dr["idCateg"]),
                                    descripcion = dr["descripcion"].ToString()
                                },

                                oMarca = new MARCAS()
                                {
                                    idMarca = Convert.ToInt32(dr["idMarca"]),
                                    descripcionMarca = dr["descripcionMarca"].ToString()
                                }








                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<PRODUCTOS>();
                }
            }
            return lista;
        }




        // Método Registrar productos.
        public int Registrar(PRODUCTOS obj, out string mensaje)
        {
            int idProductogenerado = 0;
            mensaje = String.Empty;

            try
            {

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("SP_REGISTRARPRODUCTO", oconexion);
                    //parametros de entrada del proc almacenado
                    cmd.Parameters.AddWithValue("idCateg", obj.oCategorias.idCateg);
                    cmd.Parameters.AddWithValue("idMarca", obj.oMarca.idMarca);
                    cmd.Parameters.AddWithValue("nombreProd", obj.nombreProd);
                    cmd.Parameters.AddWithValue("descripcionProd", obj.descripcionProd);
                    cmd.Parameters.AddWithValue("talle", obj.talle);
                    cmd.Parameters.AddWithValue("stock", obj.stock);
                    cmd.Parameters.AddWithValue("precioUni", obj.precioUni);
                    //cmd.Parameters.AddWithValue("imagen", obj.imagen);

                    cmd.Parameters.AddWithValue("estado", obj.estado);
                    //parametros de salida
                    cmd.Parameters.Add("idProductoResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    idProductogenerado = Convert.ToInt32(cmd.Parameters["idProductoResultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                idProductogenerado = 0;
                mensaje = ex.Message;
            }

            return idProductogenerado;
        }


        // Método editar productos
        public bool Editar(PRODUCTOS obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = String.Empty;

            try
            {

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {



                    SqlCommand cmd = new SqlCommand("SP_EDITARPRODUCTO", oconexion);
                    //parametros de entrada del proc almacenado
                    cmd.Parameters.AddWithValue("idProducto", obj.idProducto);
                    cmd.Parameters.AddWithValue("idCateg", obj.oCategorias.idCateg);
                    cmd.Parameters.AddWithValue("idMarca", obj.oMarca.idMarca);
                    cmd.Parameters.AddWithValue("nombreProd", obj.nombreProd);
                    cmd.Parameters.AddWithValue("descripcionProd", obj.descripcionProd);
                    cmd.Parameters.AddWithValue("talle", obj.talle);
                    cmd.Parameters.AddWithValue("stock", obj.stock);
                    cmd.Parameters.AddWithValue("precioUni", obj.precioUni);
                   // cmd.Parameters.AddWithValue("imagen", obj.imagen);
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


        // Método Eliminar productos
        public bool Eliminar(PRODUCTOS obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = String.Empty;

            try
            {

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {



                    SqlCommand cmd = new SqlCommand("SP_ELIMINARPRODUCTO", oconexion);
                    //parametros de entrada del proc almacenado
                    cmd.Parameters.AddWithValue("idProducto", obj.idProducto);

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

        //Método Alta Productos
        public bool Alta(PRODUCTOS obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = String.Empty;

            try
            {

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {



                    SqlCommand cmd = new SqlCommand("SP_ALTAPRODUCTO", oconexion);
                    //parametros de entrada del proc almacenado
                    cmd.Parameters.AddWithValue("idProducto", obj.idProducto);

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

