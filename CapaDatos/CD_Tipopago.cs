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
    public class CD_Tipopago
    {
        public List<TIPOPAGO> Listar()
        {
            List<TIPOPAGO> lista = new List<TIPOPAGO>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select idTipoPago,descripcion from TIPOPAGO");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new TIPOPAGO()
                            {
                                idTipoPago = Convert.ToInt32(dr["idTipoPago"]),
                                descripcion = dr["descripcion"].ToString()
                            });


                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<TIPOPAGO>();
                }
            }

            return lista;
        }
    }
}
