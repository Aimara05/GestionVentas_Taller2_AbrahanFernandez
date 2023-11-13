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
    public class CN_Reporte
    {
        private CD_Reporte objcd_reporte = new CD_Reporte();

        public List<REPORTEVENTA> Venta(string fechainicio, string fechafin)
        {
            return objcd_reporte.Venta(fechainicio, fechafin);
        }

        public DataTable ObtenerProductosMasVendidos(string fechaInicio, string fechaFin)
        {
            return objcd_reporte.ObtenerProductosMasVendidos(fechaInicio, fechaFin);
        }

        public DataTable ObtenerMontosProdTotales(string fechaInicio, string fechaFin)
        {
            return objcd_reporte.ObtenerMontosProdTotales(fechaInicio, fechaFin);
        }

        public DataTable ObtenerVentasPorVendedor(string fechaInicio, string fechaFin)
        {
            return objcd_reporte.ObtenerVentasPorVendedor(fechaInicio, fechaFin);
        }

        public DataTable ObtenerMontosPorVendedor(string fechaInicio, string fechaFin)
        {
            return objcd_reporte.ObtenerMontosPorVendedor(fechaInicio, fechaFin);
        }
    }
}
