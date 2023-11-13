using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class VENTADETALLE
    {
        public int idVentaDetalle {  get; set; }
        public PRODUCTOS oProducto { get; set; }
        public float precioVenta { get; set; }
        public int cantidad { get; set; }
        public float subtotal { get; set; }

        public string fechaReg { get; set; }
        
    }
}
