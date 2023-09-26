using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class USUARIO
    {
        public int idUsuario { set; get; }
        // public int idRol { set; get; } 
        public ROL oRol { set; get; }
        public string documento { set; get; }
        public string nombre { set; get; }
        public string apellido { set; get; }
        public string correo { set; get; }
        public string usuario { set; get; }
        public string clave { set; get; }
        public string telefono { set; get; }
        public string direccion { set; get; }
        public bool estado { set; get; }
        public string fechaCreacion { set; get; }

       
    }
}
