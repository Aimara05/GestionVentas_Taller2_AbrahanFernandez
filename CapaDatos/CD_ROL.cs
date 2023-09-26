using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Rol
    {
        public List<ROL> Listar()
        {
            List<ROL> lista = new List<ROL>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select idRol,descripcion from ROL");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ROL()
                            {
                                idRol = Convert.ToInt32(dr["idRol"]),
                                descripcion = dr["descripcion"].ToString()
                            });


                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<ROL>();
                }
            }

            return lista;
        }
    }

}
