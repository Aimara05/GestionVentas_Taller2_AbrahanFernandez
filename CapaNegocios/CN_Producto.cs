using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class CN_Producto
    {
        private CD_Producto objcd_producto = new CD_Producto();

        public List<PRODUCTOS> Listar()
        {
            return objcd_producto.Listar();
        }

              public int Registrar(PRODUCTOS obj, out string mensaje)
           {
               mensaje = string.Empty;



               if (mensaje != string.Empty)
               {
                   return 0;
               }
               else
               {

                   return objcd_producto.Registrar(obj, out mensaje);
               }


           }

           public bool Editar(PRODUCTOS obj, out string mensaje)
           {
               mensaje = string.Empty;



               if (mensaje != string.Empty)
               {
                   return false;
               }
               else
               {

                   return objcd_producto.Editar(obj, out mensaje);
               }
           }

           public bool Eliminar(PRODUCTOS obj, out string mensaje)
           {
               return objcd_producto.Eliminar(obj, out mensaje);
           }

           public bool Alta(PRODUCTOS obj, out string mensaje)
           {
               return objcd_producto.Alta(obj, out mensaje);
           }

    }
}

