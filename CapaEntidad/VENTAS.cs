using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class VENTAS
    {
        public int idVenta { get; set; }
        public USUARIO oUsuario { get; set; }
        public CLIENTES oCliente { get; set; }
        public TIPOPAGO oTipoPago { get; set; }
        public string codigoFactura { get; set; }
        public decimal montoTotal { get; set; }
        public string fechaReg { get; set; }

        public List<VENTADETALLE> oDetalle_Venta { get; set; }
        public bool estadoVenta { get; set; }

    }
}
