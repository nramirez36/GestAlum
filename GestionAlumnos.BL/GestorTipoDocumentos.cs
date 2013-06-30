using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionAlumnos.Entities;
using GestionAlumnos.DL;
namespace GestionAlumnos.BL
{
    public class GestorTipoDocumentos
    {
        public int Insertar(TipoDocumento pTipoDocumento)
        {
            return TiposDocumentos.Insertar(pTipoDocumento);
        }
        public IEnumerable<TipoDocumento> Listar()
        {
            return TiposDocumentos.ListarTiposDocumentos();
        }
        public bool Modificar(TipoDocumento pTipoDocumento)
        {
            return TiposDocumentos.Actualizar(pTipoDocumento);
        }
        public bool Eliminar(int id)
        {
            return TiposDocumentos.Eliminar(id);
        }
        public int ObtenerID()
        {
            return TiposDocumentos.ObtenerUltimoID();   
        }
    }
}
