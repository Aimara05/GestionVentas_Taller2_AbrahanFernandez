﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using CapaDatos;

namespace CapaNegocios
{
    public class CN_Rol
    {
        private CD_Rol objcd_rol = new CD_Rol();

        public List<ROL> Listar()
        {
            return objcd_rol.Listar();
        }
    }
}
