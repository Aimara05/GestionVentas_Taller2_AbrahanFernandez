using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class CN_Cliente
    {
        private CD_Cliente objcd_cliente = new CD_Cliente();

        public List<CLIENTES> Listar()
        {
            return objcd_cliente.Listar();
        }

        public int Registrar(CLIENTES obj, out string mensaje)
        {
            mensaje = string.Empty;



            if (mensaje != string.Empty)
            {
                return 0;
            }
            else
            {

                return objcd_cliente.Registrar(obj, out mensaje);
            }


        }

        public bool Editar(CLIENTES obj, out string mensaje)
        {
            mensaje = string.Empty;



            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {

                return objcd_cliente.Editar(obj, out mensaje);
            }
        }

        public bool Eliminar(CLIENTES obj, out string mensaje)
        {
            return objcd_cliente.Eliminar(obj, out mensaje);
        }

        public bool Alta(CLIENTES obj, out string mensaje)
        {
            return objcd_cliente.Alta(obj, out mensaje);
        }
    }
}
