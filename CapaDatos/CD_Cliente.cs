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
    {/*
        public List<CLIENTES> Listar()  //metodo que va ser llamado en la cama de negocio
        {

            List<CLIENTES> lista = new List<CLIENTES>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select * from CLIENTES"; 
                  
                   
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
                                documento = dr["documento"].ToString(),
                                nombre = dr["nombre"].ToString(),
                                apellido = dr["apellido"].ToString(),
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

    */}
}
