﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAlumnos.Entities
{
    public class Ciudad
    {
        public int CodCiudad { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int CodProvincia { get; set; }
    }
}
