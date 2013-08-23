using System;
using System.Collections.Generic;

namespace TEST.Models
{
    public partial class Domicilio
    {
        public Domicilio()
        {
            this.Alumnos = new List<Alumno>();
        }

        public int direccionID { get; set; }
        public string calle { get; set; }
        public string altura { get; set; }
        public string depto { get; set; }
        public string piso { get; set; }
        public int barrioID { get; set; }
        public int ciudadID { get; set; }
        public int provinciaID { get; set; }
        public virtual ICollection<Alumno> Alumnos { get; set; }
        public virtual Barrio Barrio { get; set; }
        public virtual Ciudade Ciudade { get; set; }
        public virtual Provincia Provincia { get; set; }
    }
}
