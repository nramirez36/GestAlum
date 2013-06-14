using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAlumnos.Entities
{
    public class Domicilio
    {
        public int DireccionID { get; set; }
        public string Calle { get; set; }
        public string Altura { get; set; }
        public string Depto { get; set; }
        public string Piso { get; set; }
        public int BarrioID { get; set; }
        public int CiudadID { get; set; }
        public int ProvinciaID { get; set; }
    }
}
