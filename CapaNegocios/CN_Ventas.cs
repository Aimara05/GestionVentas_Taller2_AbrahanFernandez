using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class CN_Ventas
    {
        private CD_Venta objcd_venta = new CD_Venta();

        public bool RestarStock(int idProducto, int cantidad)
        {
            return objcd_venta.RestarStock(idProducto, cantidad);
        }

        public bool SumarStock(int idProducto, int cantidad)
        {
            return objcd_venta.SumarStock(idProducto, cantidad);
        }

        public int ObtenerCorrelativo()
        {
            return objcd_venta.ObtenerCorrelativo();
        }

        public bool Registrar(VENTAS obj, DataTable DetalleVenta, out string Mensaje)
        {
            return objcd_venta.Registrar(obj, DetalleVenta, out Mensaje);
        }

        public VENTAS ObtenerVenta(String numero)
        {
            VENTAS oVenta = objcd_venta.ObtenerVenta(numero);
            
            if(oVenta.idVenta != 0)
            {
                List<VENTADETALLE> oDetalleVenta = objcd_venta.obtenerDetalleVenta(oVenta.idVenta);
                oVenta.oDetalle_Venta = oDetalleVenta;

            }

            return oVenta;
        }

        public List<VENTAS> Listar(USUARIO oUsuario)
        {
            return objcd_venta.Listar(oUsuario);
        }

    }
}
