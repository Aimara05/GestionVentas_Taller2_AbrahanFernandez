using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
  public class PRODUCTOS
    {

        public int idProducto { set; get; }

        public CATEGORIAS oCategorias { set; get; }
        public MARCAS oMarca { set; get; }

        public string nombreProd { set; get; }
        public string descripcionProd { set; get; }
        public string talle { set; get; }
        public int stock { set; get; }
        public bool estado { set; get; }
        public double precioUni { set; get; }


        





    }
}
