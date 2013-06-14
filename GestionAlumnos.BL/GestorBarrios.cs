using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionAlumnos.Entities;
using GestionAlumnos.DL;
namespace GestionAlumnos.BL
{
    public class GestorBarrios
    {
        public int Insertar(Barrio pBarrio)
        {
            return Barrios.Insertar(pBarrio);
        }
        public IEnumerable<Barrio> Listar()
        {
            return Barrios.Listar();
        }
        public bool Modificar(Barrio pBarrio)
        {
            return Barrios.Actualizar(pBarrio);
        }
        public bool Eliminar(int id)
        {
            return Barrios.Eliminar(id);
        }
    }
}
