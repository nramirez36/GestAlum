using System;
using System.Collections.Generic;

namespace TEST.Models
{
    public partial class Provincia
    {
        public Provincia()
        {
            this.Ciudades = new List<Ciudade>();
            this.Domicilios = new List<Domicilio>();
        }

        public int codProvincia { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public virtual ICollection<Ciudade> Ciudades { get; set; }
        public virtual ICollection<Domicilio> Domicilios { get; set; }
    }
}
