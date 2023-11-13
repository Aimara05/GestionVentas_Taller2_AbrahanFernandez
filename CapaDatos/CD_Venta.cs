using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Venta
    {

        // este metodo voy a usar para obtener un codigo de factura del tipo "00001 - 00002 - 00003 , etc "
        public int ObtenerCorrelativo()
        {
            int idcorrelativo = 0;

            using(SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) + 1 from VENTAS");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    idcorrelativo = Convert.ToInt32(cmd.ExecuteScalar());


                }
                catch (Exception ex)
                {
                    idcorrelativo = 0;
                }
            }

            return idcorrelativo;

        }


        public bool RestarStock(int idProducto, int cantidad)
        {
            bool respuesta = true;
            string mensaje = string.Empty;


            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update PRODUCTOS set stock = stock - @cantidad where idProducto = @idProducto");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                    mensaje = ex.Message;
                    
                }
            }

            return respuesta;
        }

        public bool SumarStock(int idProducto, int cantidad)
        {
            bool respuesta = true;
            


            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update PRODUCTOS set stock = stock + @cantidad where idProducto = @idProducto");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }

            return respuesta;

        }

        

        public bool Registrar(VENTAS obj, DataTable DetalleVenta, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = String.Empty;

            try
            {
                using(SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("usp_RegistrarVenta", oconexion);
                    cmd.Parameters.AddWithValue("idUsuario", obj.oUsuario.idUsuario);
                    cmd.Parameters.AddWithValue("idCliente", obj.oCliente.idCliente);
                    cmd.Parameters.AddWithValue("idTipoPago", obj.oTipoPago.idTipoPago);
                    cmd.Parameters.AddWithValue("codigoFactura", obj.codigoFactura);
                    cmd.Parameters.AddWithValue("montoTotal", obj.montoTotal);
                    cmd.Parameters.AddWithValue("estadoVenta", obj.estadoVenta);
                    cmd.Parameters.AddWithValue("DetalleVenta", DetalleVenta);

                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();


                }
            }

            catch (Exception ex)
            {
                Respuesta = false;
                Mensaje = ex.Message;
            }

            return Respuesta;
        }

        public List<VENTAS> Listar(USUARIO oUsuario) // seguir trabajando con esto
        {
            List<VENTAS> lista = new List<VENTAS>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {


                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select v.idVenta, v.idUsuario, c.idCliente,c.nombreCliente,c.apellidoCliente, tp.idTipoPago, tp.descripcion, v.codigoFactura, v.fechaReg, v.montoTotal from VENTAS v");
                    query.AppendLine("inner join CLIENTES c on c.idCliente = v.idCliente");
                    query.AppendLine("inner join TIPOPAGO tp on tp.idTipoPago = v.idTipoPago");
                    query.AppendLine("where idUsuario = @idUsuario"); // Cambia a buscar por el código de factura en lugar del ID de usuario

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@idUsuario", oUsuario.idUsuario); // aca poner idusuario.
                    cmd.CommandType = System.Data.CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new VENTAS()
                            {
                                idVenta = int.Parse(dr["idVenta"].ToString()),
                                oUsuario = new USUARIO() { idUsuario = Convert.ToInt32(dr["idUsuario"].ToString()) }, // Ajusta la creación del usuario
                                oCliente = new CLIENTES()
                                {
                                    idCliente = Convert.ToInt32(dr["idCliente"].ToString()),
                                    nombreCliente = dr["nombreCliente"].ToString(),

                                    apellidoCliente = dr["apellidoCliente"].ToString(),

                                },
                                oTipoPago = new TIPOPAGO()
                                {
                                    idTipoPago = Convert.ToInt32(dr["idTipoPago"]),
                                    descripcion = dr["descripcion"].ToString()
                                },
                                codigoFactura = dr["codigoFactura"].ToString(),
                                fechaReg = Convert.ToDateTime(dr["fechaReg"]).ToString("dd/MM/yyyy"), // Formatear la fecha
                                montoTotal = Convert.ToDecimal(dr["montoTotal"].ToString()),
                            });

                        }
                    }
                }

                
                catch (Exception ex)
                {
                    lista = new List<VENTAS>();
                    // Puedes agregar un mensaje de log o manejar la excepción de alguna otra manera si lo necesitas.
                }
            }

            return lista;
        }

        public VENTAS ObtenerVenta(string numero)
        {
            string nombrecompleto = string.Empty;
            VENTAS obj = new VENTAS();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("select v.idVenta, u.documento, u.nombre, u.apellido,");
                    query.AppendLine("c.idCliente, c.documentoCliente, c.apellidoCliente, c.nombreCliente, c.telefono, c.correo,");
                    query.AppendLine("v.codigoFactura, convert(char(10),v.fechaReg,103)[fechaReg],v.montoTotal");
                    query.AppendLine("from VENTAS v");
                    query.AppendLine("inner join USUARIO u on u.idUsuario = v.idUsuario");
                    query.AppendLine("inner join CLIENTES c on c.idCliente = v.idCliente");
                    query.AppendLine("where v.codigoFactura = @numero");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = new VENTAS()
                            {
                                idVenta = int.Parse(dr["idVenta"].ToString()),
                                oUsuario = new USUARIO()
                                {
                                    documento = dr["documento"].ToString(),
                                    nombre = dr["nombre"].ToString(),
                                    apellido = dr["apellido"].ToString()

                                },
                                oCliente = new CLIENTES()
                                {
                                    idCliente = Convert.ToInt32(dr["idCliente"].ToString()),
                                    documentoCliente = dr["documentoCliente"].ToString(),
                                    apellidoCliente = dr["apellidoCliente"].ToString(),
                                    nombreCliente = dr["nombreCliente"].ToString(),
                                    telefono = dr["telefono"].ToString(),
                                    correo = dr["correo"].ToString()
                                },
                                codigoFactura = dr["codigoFactura"].ToString(),
                                fechaReg = dr["fechaReg"].ToString(),
                                montoTotal = Convert.ToDecimal(dr["montoTotal"].ToString()),

                            };
                        }
                    }

                }
                catch (Exception ex)
                {
                    obj = new VENTAS();

                }
            }

            return obj;
        }

        public List<VENTADETALLE> obtenerDetalleVenta(int idVenta)
        {
            List<VENTADETALLE> oLista = new List<VENTADETALLE>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena)) {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.nombreProd, vd.precioVenta, vd.cantidad, vd.subtotal from VENTADETALLE vd");
                    query.AppendLine("inner join PRODUCTOS p on p.idProducto = vd.idProducto");
                    query.AppendLine("where vd.idVenta = @idVenta");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@idVenta", idVenta);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new VENTADETALLE()
                            {
                                oProducto = new PRODUCTOS() { nombreProd = dr["nombreProd"].ToString() },
                                precioVenta = Convert.ToSingle(dr["precioVenta"].ToString()),
                                cantidad = Convert.ToInt32(dr["cantidad"].ToString()),
                                subtotal = Convert.ToSingle(dr["subtotal"])
                            });
                        }
                    }


                }

                catch (Exception ex)
                {
                    oLista = new List<VENTADETALLE>();
                }
            
            } 

            
                
                
                
                
                
                
                
                return oLista;
        }

        



    }
}
