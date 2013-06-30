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
    public class Ciudades
    { 
        public static IEnumerable<Ciudad> Listar()
        {
            Database odb = DatabaseFactory.CreateDatabase("gestionAlumnos");
            try
            {
                return odb.ExecuteSprocAccessor("ListarCiudad", MapBuilder<Ciudad>.MapAllProperties().Build());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problemas Al Listar Los Ciudad: " + ex.Message);
                throw;
            }
        }
        public static bool Eliminar(int id)
        {
            Database oDb = DatabaseFactory.CreateDatabase("gestionAlumnos");
            int result;
            try
            {
                result = oDb.ExecuteNonQuery("EliminarCiudad", id);
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
                Console.WriteLine("Problema Al Eliminar La Ciudad: " + ex.Message);
                throw;
            }
        }
        public static bool Actualizar(Ciudad pCiudad)
        {
            Database oDb = DatabaseFactory.CreateDatabase("gestionAlumnos");
            int result;
            try
            {
                result = oDb.ExecuteNonQuery("ModificarCiudad", pCiudad.Descripcion, pCiudad.CiudadID);
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
                Console.WriteLine("Problemas Al Modificar La Ciudad: " + ex.Message);
                throw;
            }
        }
        public static int Insertar(Ciudad pCiudad)
        {
            Database oDb = DatabaseFactory.CreateDatabase("gestionAlumnos");
            int clienteID = -1;
            try
            {
                clienteID = int.Parse(oDb.ExecuteScalar("InsertarCiudad", pCiudad.Descripcion, pCiudad.CiudadID).ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problemas Al Guardar La Ciudad: " + ex.Message);
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
                cli = int.Parse(oDb.ExecuteScalar("ObtenerUltimoIDCiudad").ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problemas Al Obtener El Ultimo Número De Ciudad: " + ex.Message);
                throw;
            }
            return cli;
        }
    }
}
