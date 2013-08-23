using System;
using System.Collections.Generic;

namespace TEST.Models
{
    public partial class Alumno
    {
        public int alumnoID { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public int direccionID { get; set; }
        public int tipoDocumentoID { get; set; }
        public int nroDocumento { get; set; }
        public string telefonoFijo { get; set; }
        public string telefonoCelular { get; set; }
        public string nacionalidad { get; set; }
        public System.DateTime fechaNacimiento { get; set; }
        public int edad { get; set; }
        public virtual Domicilio Domicilio { get; set; }
        public virtual TiposDocumento TiposDocumento { get; set; }
    }
}
