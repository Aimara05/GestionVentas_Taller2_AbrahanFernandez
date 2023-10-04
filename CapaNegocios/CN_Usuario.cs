using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CapaNegocios
{
    public class CN_Usuario
    {
        private CD_Usuario objcd_usuario = new CD_Usuario();

        public List<USUARIO> Listar()
        {
            return objcd_usuario.Listar();
        }

        public int Registrar(USUARIO obj, out string mensaje)
        {
            mensaje = string.Empty;

           

            if (mensaje != string.Empty)
            {
                return 0;
            }
            else
            {

                return objcd_usuario.Registrar(obj, out mensaje);
            }


        }

        public bool Editar(USUARIO obj, out string mensaje)
        {
            mensaje = string.Empty;

          

            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {

                return objcd_usuario.Editar(obj, out mensaje);
            }
        }

        public bool Eliminar(USUARIO obj, out string mensaje)
        {
            return objcd_usuario.Eliminar(obj, out mensaje);
        }

        public bool Alta(USUARIO obj, out string mensaje)
        {
            return objcd_usuario.Alta(obj, out mensaje);
        }

    }
}