using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class CN_Categoria
    {

        private CD_Categoria objcd_categoria = new CD_Categoria();

        public List<CATEGORIAS> Listar()
        {
            return objcd_categoria.Listar();
        }

        public int Registrar(CATEGORIAS obj, out string mensaje)
        {
            mensaje = string.Empty;



            if (mensaje != string.Empty)
            {
                return 0;
            }
            else
            {

                return objcd_categoria.Registrar(obj, out mensaje);
            }


        }

        public bool Editar(CATEGORIAS obj, out string mensaje)
        {
            mensaje = string.Empty;



            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {

                return objcd_categoria.Editar(obj, out mensaje);
            }
        }

        public bool Eliminar(CATEGORIAS obj, out string mensaje)
        {
            mensaje = string.Empty;

            if(mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_categoria.Eliminar(obj, out mensaje);
            }
            
        }

        public bool Alta(CATEGORIAS obj, out string mensaje)
        {
            mensaje = string.Empty;

            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_categoria.Alta(obj, out mensaje);
            }
            
        }

    }
}
