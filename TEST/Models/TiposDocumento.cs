using System;
using System.Collections.Generic;

namespace TEST.Models
{
    public partial class TiposDocumento
    {
        public TiposDocumento()
        {
            this.Alumnos = new List<Alumno>();
        }

        public int tipoDocumentoID { get; set; }
        public string descripcion { get; set; }
        public virtual ICollection<Alumno> Alumnos { get; set; }
    }
}
