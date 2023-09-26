using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
  public class PRODUCTOS
    {

        public int idProd { set; get; }
        // public int idRol { set; get; } 
  
        public string codProd { set; get; }
        public string nombre { set; get; }
        public string descripcion { set; get; }
        public CATEGORIAS oCategoria { set; get; }
        public int stock { set; get; }
        public decimal precioVenta { set; get; }
        public bool estado { set; get; }
        public string fechaCreacion { set; get; }

    }
}
