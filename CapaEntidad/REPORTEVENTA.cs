using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class REPORTEVENTA
    {

        public string FechaRegistro { get; set; }
        public string codigoFactura { get; set; }
        public string montoTotal { get; set; }
        public string TipoPago { get; set; }
        public string UsuarioNombre { get; set; }
        public string UsuarioApellido { get; set; }
        public string DniUsuario { get; set; }
        public string nombreCliente { get; set; }
        public string apellidoCliente { get; set; }
        public string documentoCliente { get; set; }
        public string idProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Categoria { get; set; }
        public string Marca { get; set; }
        public string precioVenta { get; set; }
        public string cantidad { get; set; }
        public string subtotal { get; set; }
    }
}
