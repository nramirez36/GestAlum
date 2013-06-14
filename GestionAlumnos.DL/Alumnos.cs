using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionAlumnos.Entities;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
namespace GestionAlumnos.DL
{
    public class Alumnos
    {
        public static IEnumerable<Alumno> Listar()
        {
            Database odb = DatabaseFactory.CreateDatabase("gestionAlumnos");
            try
            {
                return odb.ExecuteSprocAccessor("ListarAlumnos", MapBuilder<Alumno>.MapAllProperties().Build());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problemas Al Listar Los Alumnos: " + ex.Message);
                throw;
            }
        }
        public static bool Eliminar(int id)
        {
            Database oDb = DatabaseFactory.CreateDatabase("gestionAlumnos");
            int result;
            try
            {
                result = oDb.ExecuteNonQuery("EliminarAlumnos", id);
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problema Al Eliminar El Alumno: " + ex.Message);
                throw;
            }
        }
        public static bool Actualizar(Alumno pAlumno)
        {
            Database oDb = DatabaseFactory.CreateDatabase("gestionAlumnos");
            int result;
            try
            {
                result = oDb.ExecuteNonQuery("ModificarAlumnos", pAlumno.Nombres, pAlumno.Apellidos, pAlumno.DireccionID, pAlumno.TipoDocumentoID, pAlumno.NroDocumento, pAlumno.TelefonoFijo, pAlumno.TelefonoCelular, pAlumno.Nacionalidad, pAlumno.FechaNacimiento, pAlumno.Edad, pAlumno.AlumnoID);
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problemas Al Modificar El Alumno: " + ex.Message);
                throw;
            }
        }
        public static int Insertar(Alumno pAlumno)
        {
            Database oDb = DatabaseFactory.CreateDatabase("gestionAlumnos");
            int clienteID = -1;
            try
            {
                clienteID = int.Parse(oDb.ExecuteScalar("InsertarAlumnos", pAlumno.Nombres, pAlumno.Apellidos, pAlumno.DireccionID, pAlumno.TipoDocumentoID, pAlumno.NroDocumento, pAlumno.TelefonoFijo, pAlumno.TelefonoCelular, pAlumno.Nacionalidad, pAlumno.FechaNacimiento, pAlumno.Edad).ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problemas Al Guardar El Alumno: " + ex.Message);
                throw;
            }
            return clienteID;
        }
    }
}
