using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionAlumnos.Entities;
using GestionAlumnos.DL;
namespace GestionAlumnos.BL
{
    public class GestorAlumnos
    {
        public int Insertar(Alumno pAlumno)
        {
            return Alumnos.Insertar(pAlumno);
        }
        public IEnumerable<Alumno> Listar()
        {
            return Alumnos.Listar();
        }
        public bool Modificar(Alumno pAlumno)
        {
            return Alumnos.Actualizar(pAlumno);
        }
        public bool Eliminar(int id)
        {
            return Alumnos.Eliminar(id);
        }
        public int ObtenerID()
        {
            return Alumnos.ObtenerUltimoID();
        }
        public IEnumerable<Alumno> ConsultarAlumnos(int pDocumento)
        {
            return Alumnos.BuscarAlumnosPorDocumento(pDocumento);
        }
    }
}
