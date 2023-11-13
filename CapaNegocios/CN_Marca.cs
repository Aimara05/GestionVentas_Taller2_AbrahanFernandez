using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
  public class CN_Marca
    {
        private CD_Marca objcd_rol = new CD_Marca();

        public List<MARCAS> Listar()
        {
            return objcd_rol.Listar();
        }
    }
}
