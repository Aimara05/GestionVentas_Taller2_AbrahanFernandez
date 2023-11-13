using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class CN_Tipopago
    {
        private CD_Tipopago objcd_tipopago = new CD_Tipopago();

        public List<TIPOPAGO> Listar()
        {
            return objcd_tipopago.Listar();
        }
    }
}
