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

            //validaciones
            if (obj.nombre == "")
            {
                mensaje += "Es necesario que ingrese el nombre del usuario \n";
            }

            if (obj.documento == "")
            {
                mensaje += "Es necesario que ingrese el documento del usuario\n";
            }
            if (obj.usuario == "")
            {
                mensaje += "Es necesario que ingrese el usuario\n";
            }
            if (obj.clave == "")
            {
                mensaje += "Es necesario que ingrese la clave del usuario\n";
            }
            if (obj.direccion == "")
            {
                mensaje += "Es necesario que ingrese la direccion del usuario\n";
            }
            if (obj.telefono == "")
            {
                mensaje += "Es necesario que ingrese el telefono del usuario\n";
            }

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

            //validaciones
            if (obj.nombre == "")
            {
                mensaje += "Es necesario que ingrese el nombre del usuario";
            }

            if (obj.documento == "")
            {
                mensaje += "Es necesario que ingrese el documento del usuario\n";
            }
            if (obj.usuario == "")
            {
                mensaje += "Es necesario que ingrese el usuario\n";
            }
            if (obj.clave == "")
            {
                mensaje += "Es necesario que ingrese la clave del usuario\n";
            }
            if (obj.direccion == "")
            {
                mensaje += "Es necesario que ingrese la direccion del usuario\n";
            }
            if (obj.telefono == "")
            {
                mensaje += "Es necesario que ingrese el telefono del usuario\n";
            }

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

    }
}