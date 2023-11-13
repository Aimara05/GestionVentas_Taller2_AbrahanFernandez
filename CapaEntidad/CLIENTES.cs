using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CLIENTES
    {

        public int idCliente { set; get; }
    
       
        public string documentoCliente { set; get; }
        public string nombreCliente { set; get; }
        public string apellidoCliente { set; get; }
        public string correo { set; get; }
       
        public string telefono { set; get; }
       
        public bool estado { set; get; }
        public string fechaCreacion { set; get; }
    }
}
