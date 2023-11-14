using System;
using CapaEntidad;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Reporte
    {

        

        public List<REPORTEVENTA> Venta(string fechainicio, string fechafin)
        {
            List<REPORTEVENTA> lista = new List<REPORTEVENTA>();
            
            using(SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("sp_ReporteVentas", oconexion);
                    cmd.Parameters.AddWithValue("fechainicio", fechainicio);
                    cmd.Parameters.AddWithValue("fechafin", fechafin);
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new REPORTEVENTA()
                            {                                
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                                codigoFactura = dr["codigoFactura"].ToString(),
                                montoTotal = dr["montoTotal"].ToString(),
                                TipoPago = dr["TipoPago"].ToString(),
                                UsuarioNombre = dr["UsuarioNombre"].ToString(),
                                UsuarioApellido = dr["UsuarioApellido"].ToString(),
                                DniUsuario = dr["DniUsuario"].ToString(),
                                nombreCliente = dr["nombreCliente"].ToString(),
                                apellidoCliente = dr["apellidoCliente"].ToString(),
                                documentoCliente = dr["documentoCliente"].ToString(),


    });
                        }
                    }


                }catch  (Exception ex)
                {
                    lista = new List<REPORTEVENTA>();
                }
            }

            return lista;
        }

        /*Productos más vendidos en relación a la fecha: */
        public DataTable ObtenerProductosMasVendidos(string fechaInicio, string fechaFin)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();


                    using (SqlCommand cmd = new SqlCommand("sp_prodmasvendidos", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregamos los parámetros al comando
                        cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@FechaFin", fechaFin);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return dataTable;
        }


        /* Montos totales recaudados por cada producto: */
        public DataTable ObtenerMontosProdTotales(string fechaInicio, string fechaFin)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();


                    using (SqlCommand cmd = new SqlCommand("sp_prodmontos", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;


                        cmd.Parameters.AddWithValue("@fechainicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@fechafin", fechaFin);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return dataTable;
        }


        /* Vendedores que realizaron más ventas (cantidad de venta por vendedor */
        public DataTable ObtenerVentasPorVendedor(string fechaInicio, string fechaFin)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();

                    // Utilizamos el nombre del procedimiento almacenado en lugar de la consulta SQL
                    using (SqlCommand cmd = new SqlCommand("sp_ventascantidad", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregamos los parámetros al comando
                        cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@FechaFin", fechaFin);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return dataTable;
        }


        /* Montos totales generados por cada vendedor en relación a la venta*/
        public DataTable ObtenerMontosPorVendedor(string fechaInicio, string fechaFin)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();

                    // Utilizamos el nombre del procedimiento almacenado en lugar de la consulta SQL
                    using (SqlCommand cmd = new SqlCommand("sp_montosvendedor", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregamos los parámetros al comando
                        cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@FechaFin", fechaFin);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return dataTable;
        }

    }
}
