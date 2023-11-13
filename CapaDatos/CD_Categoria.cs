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
    public class CD_Categoria
    {


        // Método Listar categorías
        public List<CATEGORIAS> Listar()  //metodo que va ser llamado en la capa de negocio
        {

            List<CATEGORIAS> lista = new List<CATEGORIAS>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select idCateg, descripcion, estadoCateg from CATEGORIAS";
                    

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())  //dr almacena el comando executeReader
                    {
                        while (dr.Read())
                        {
                            lista.Add(new CATEGORIAS()
                            {
                                idCateg = Convert.ToInt32(dr["idCateg"]),
                                descripcion = dr["descripcion"].ToString(),
                                estado = Convert.ToBoolean(dr["estadoCateg"])


                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<CATEGORIAS>();
                }
            }
            return lista;
        }





        //Registrar categorías
        public int Registrar(CATEGORIAS obj, out string mensaje)
        {
            int idcategoriagenerada = 0;
            mensaje = String.Empty;

            try
            {

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("SP_REGISTRARCATEGORIA", oconexion);
                    //parametros de entrada del proc almacenado

                    cmd.Parameters.AddWithValue("descripcion", obj.descripcion);
                    cmd.Parameters.AddWithValue("estadoCateg", obj.estado);
                    //parametros de salida
                    cmd.Parameters.Add("idCategoriaResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    idcategoriagenerada = Convert.ToInt32(cmd.Parameters["idCategoriaResultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                idcategoriagenerada = 0;
                mensaje = ex.Message;
            }

            return idcategoriagenerada;
        }


        //Método editar categorías
        public bool Editar(CATEGORIAS obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = String.Empty;

            try
            {

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {



                    SqlCommand cmd = new SqlCommand("SP_EDITARCATEGORIA", oconexion);
                    //parametros de entrada del proc almacenado
                    cmd.Parameters.AddWithValue("idCateg", obj.idCateg);
                    cmd.Parameters.AddWithValue("descripcion", obj.descripcion);
                    cmd.Parameters.AddWithValue("estadoCateg", obj.estado);
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


        //Método Eliminar categoría
        public bool Eliminar(CATEGORIAS obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = String.Empty;

            try
            {

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {



                    SqlCommand cmd = new SqlCommand("SP_ELIMINARCATEGORIA", oconexion);
                    //parametros de entrada del proc almacenado
                    cmd.Parameters.AddWithValue("idCateg", obj.idCateg);

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

        //Método Alta Usuario
        public bool Alta(CATEGORIAS obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = String.Empty;

            try
            {

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {



                    SqlCommand cmd = new SqlCommand("SP_ALTACATEGORIA", oconexion);
                    //parametros de entrada del proc almacenado
                    cmd.Parameters.AddWithValue("idCateg", obj.idCateg);

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
