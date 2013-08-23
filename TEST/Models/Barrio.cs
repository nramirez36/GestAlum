using System;
using System.Collections.Generic;

namespace TEST.Models
{
    public partial class Barrio
    {
        public Barrio()
        {
            this.Domicilios = new List<Domicilio>();
        }

        public int codBarrio { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int codCiudad { get; set; }
        public virtual Ciudade Ciudade { get; set; }
        public virtual ICollection<Domicilio> Domicilios { get; set; }
    }
}
