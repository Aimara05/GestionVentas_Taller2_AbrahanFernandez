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
   public class CD_Marca
    {

        public List<MARCAS> Listar()
        {
            List<MARCAS> lista = new List<MARCAS>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select idMarca,descripcionMarca from MARCAS");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new MARCAS()
                            {
                                idMarca = Convert.ToInt32(dr["idMarca"]),
                                descripcionMarca = dr["descripcionMarca"].ToString()
                            });


                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<MARCAS>();
                }
            }

            return lista;
        }
    }
}

