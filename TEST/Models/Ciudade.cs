using System;
using System.Collections.Generic;

namespace TEST.Models
{
    public partial class Ciudade
    {
        public Ciudade()
        {
            this.Barrios = new List<Barrio>();
            this.Domicilios = new List<Domicilio>();
        }

        public int codCiudad { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int codProvincia { get; set; }
        public virtual ICollection<Barrio> Barrios { get; set; }
        public virtual Provincia Provincia { get; set; }
        public virtual ICollection<Domicilio> Domicilios { get; set; }
    }
}
