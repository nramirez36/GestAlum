using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionAlumnos.Entities;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;
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
                oDb.ExecuteNonQuery("InsertarAlumnos", pAlumno.Nombres, pAlumno.Apellidos, pAlumno.DireccionID, pAlumno.TipoDocumentoID, pAlumno.NroDocumento, pAlumno.TelefonoFijo, pAlumno.TelefonoCelular, pAlumno.Nacionalidad, pAlumno.FechaNacimiento, pAlumno.Edad);
                clienteID = int.Parse(oDb.ExecuteScalar("ObtenerUltimoIDAlumnos").ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problemas Al Guardar El Alumno: " + ex.Message);
                throw;
            }
            return clienteID;
        }
        public static int ObtenerUltimoID()
        {
            Database oDb = DatabaseFactory.CreateDatabase("gestionAlumnos");
            int cli = -1;
            try
            {
                cli = int.Parse(oDb.ExecuteScalar("ObtenerUltimoIDAlumnos").ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problemas Al Obtener El Ultimo Número De Alumno: " + ex.Message);
                throw;
            }
            return cli;
        }
        public static Alumno ConsultarAlumno(string pApellido)
        {
            Database oDb = DatabaseFactory.CreateDatabase("gestionAlumnos");
            Alumno oAlu = new Alumno();
            int cli = -1;
            try
            {
                IDataReader oIDR=oDb.ExecuteReader("BuscarAlumno",pApellido); 
                while (oIDR.Read())
                {
                    oAlu.AlumnoID = int.Parse(oIDR.GetValue(0).ToString());
                    oAlu.Nombres = oIDR.GetValue(1).ToString();
                    oAlu.Apellidos = oIDR.GetValue(2).ToString();
                    oAlu.TipoDocumentoID = int.Parse(oIDR.GetValue(3).ToString());
                    oAlu.NroDocumento = int.Parse(oIDR.GetValue(4).ToString());
                    oAlu.TelefonoFijo = oIDR.GetValue(5).ToString();
                    oAlu.TelefonoCelular = oIDR.GetValue(6).ToString();
                    oAlu.Nacionalidad = oIDR.GetValue(7).ToString();
                    oAlu.FechaNacimiento = DateTime.Parse(oIDR.GetValue(8).ToString());
                    oAlu.Edad = int.Parse(oIDR.GetValue(9).ToString());
                }
                return oAlu;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problemas Al Obtener El Alumno: "+ex.Message);
                throw;
            }
        }
        public static IEnumerable<Alumno> BuscarAlumnosPorApellido(string pApellido)
        {
            Database oDb = DatabaseFactory.CreateDatabase("gestionAlumnos");
            try
            {
                return oDb.ExecuteSprocAccessor("BuscarAlumno", MapBuilder<Alumno>.MapAllProperties().Build(),pApellido);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problemas Al Listar Los ALumnos: " + ex.Message);
                throw;
            }
        }
    }
}
