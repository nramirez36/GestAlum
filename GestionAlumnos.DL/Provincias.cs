using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using GestionAlumnos.Entities;
namespace GestionAlumnos.UI
{
    public class Provincias
    {
        public static IEnumerable<Provincia> Listar()
        {
            Database odb = DatabaseFactory.CreateDatabase("gestionAlumnos");
            try
            {
                return odb.ExecuteSprocAccessor("ListarProvincia", MapBuilder<Provincia>.MapAllProperties().Build());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problemas Al Listar Las Provincias: " + ex.Message);
                throw;
            }
        }
        public static bool Eliminar(int id)
        {
            Database oDb = DatabaseFactory.CreateDatabase("gestionAlumnos");
            int result;
            try
            {
                result = oDb.ExecuteNonQuery("EliminarProvincia", id);
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
                Console.WriteLine("Problema Al Eliminar La Provincia: " + ex.Message);
                throw;
            }
        }
        public static bool Actualizar(Provincia pProvincia)
        {
            Database oDb = DatabaseFactory.CreateDatabase("gestionAlumnos");
            int result;
            try
            {
                result = oDb.ExecuteNonQuery("ModificarProvincia", pProvincia.Descripcion, pProvincia.ProvinciaID);
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
                Console.WriteLine("Problemas Al Modificar La Provincia: " + ex.Message);
                throw;
            }
        }
        public static int Insertar(Provincia pProvincia)
        {
            Database oDb = DatabaseFactory.CreateDatabase("gestionAlumnos");
            int clienteID = -1;
            try
            {
                clienteID = int.Parse(oDb.ExecuteScalar("InsertarProvincia", pProvincia.Descripcion).ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problemas Al Guardar La Provincia: " + ex.Message);
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
                cli = int.Parse(oDb.ExecuteScalar("ObtenerUltimoIDProvincias").ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problemas Al Obtener El Ultimo Número De Provincia: " + ex.Message);
                throw;
            }
            return cli;
        }
    }
}
