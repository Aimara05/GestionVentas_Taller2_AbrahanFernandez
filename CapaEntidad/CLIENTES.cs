using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    internal class CLIENTES
    {

        public int idCliente { set; get; }
    
       
        public string documento { set; get; }
        public string nombre { set; get; }
        public string apellido { set; get; }
        public string correo { set; get; }
       
        public string telefono { set; get; }
       
        public bool estado { set; get; }
        public string fechaCreacion { set; get; }
    }
}
