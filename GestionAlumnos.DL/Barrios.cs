using GestionAlumnos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
namespace GestionAlumnos.UI
{
    public class Barrios
    {
        public static IEnumerable<Barrio> Listar()
        {
            Database odb = DatabaseFactory.CreateDatabase("gestionAlumnos");
            try
            {
                return odb.ExecuteSprocAccessor("ListarBarrios", MapBuilder<Barrio>.MapAllProperties().Build());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problemas Al Listar Los Barrios: " + ex.Message);
                throw;
            }
        }
        public static bool Eliminar(int id)
        {
            Database oDb = DatabaseFactory.CreateDatabase("gestionAlumnos");
            int result;
            try
            {
                result = oDb.ExecuteNonQuery("EliminarBarrios", id);
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
                Console.WriteLine("Problema Al Eliminar El Barrio: " + ex.Message);
                throw;
            }
        }
        public static bool Actualizar(Barrio pBarrio)
        {
            Database oDb = DatabaseFactory.CreateDatabase("gestionAlumnos");
            int result;
            try
            {
                result = oDb.ExecuteNonQuery("ModificarBarrios", pBarrio.Descripcion, pBarrio.BarrioID);
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
                Console.WriteLine("Problemas Al Modificar El Barrio: " + ex.Message);
                throw;
            }
        }
        public static int Insertar(Barrio pBarrio)
        {
            Database oDb = DatabaseFactory.CreateDatabase("gestionAlumnos");
            int clienteID = -1;
            try
            {
                clienteID = int.Parse(oDb.ExecuteScalar("InsertarBarrios", pBarrio.Descripcion, pBarrio.BarrioID).ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problemas Al Guardar El Barrio: " + ex.Message);
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
                cli = int.Parse(oDb.ExecuteScalar("ObtenerUltimoIDBarrio").ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problemas Al Obtener El Ultimo Número De Barrio: " + ex.Message);
                throw;
            }
            return cli;
        }
    }
}
