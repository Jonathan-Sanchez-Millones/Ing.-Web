﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABB.Catalogo.Entidades.Core;

namespace ABB.Catalogo.Entidades.Core
{
    public class Usuarios
    {
        public int IdUsuario { get; set; }
        public string CodUsuario { get; set; }
        public string ClaveTxt { get; set; }
        public byte[] Clave { get; set; }
        public string Nombres { get; set; }
        public int IdRol { get; set; }
        //----- Adicional
        public string DesRol { get; set; }

    }

}
