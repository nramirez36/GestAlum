using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using GestionAlumnos.Entities;
namespace GestionAlumnos.DL
{
    public class Domicilios
    {
        public static IEnumerable<Domicilio> Listar()
        {
            Database odb = DatabaseFactory.CreateDatabase("gestionAlumnos");
            try
            {
                return odb.ExecuteSprocAccessor("ListarDomicilio", MapBuilder<Domicilio>.MapAllProperties().Build());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problemas Al Listar Los Domicilios: " + ex.Message);
                throw;
            }
        }
        public static bool Eliminar(int id)
        {
            Database oDb = DatabaseFactory.CreateDatabase("gestionAlumnos");
            int result;
            try
            {
                result = oDb.ExecuteNonQuery("EliminarDomicilios", id);
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
        public static bool Actualizar(Domicilio pDomicilio)
        {
            Database oDb = DatabaseFactory.CreateDatabase("gestionAlumnos");
            int result;
            try
            {
                result = oDb.ExecuteNonQuery("ModificarDomicilios", pDomicilio.ProvinciaID, pDomicilio.CiudadID, pDomicilio.BarrioID, pDomicilio.Piso, pDomicilio.Altura, pDomicilio.Calle, pDomicilio.Depto, pDomicilio.DireccionID);
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
                Console.WriteLine("Problemas Al Modificar El Domicilio: " + ex.Message);
                throw;
            }
        }
        public static int Insertar(Domicilio pDomicilio)
        {
            Database oDb = DatabaseFactory.CreateDatabase("gestionAlumnos");
            int clienteID = -1;
            try
            {
                //clienteID = int.Parse(oDb.ExecuteScalar("InsertarDomicilios", pDomicilio.ProvinciaID, pDomicilio.CiudadID, pDomicilio.BarrioID, pDomicilio.Piso, pDomicilio.Altura, pDomicilio.Calle, pDomicilio.Depto).ToString());
                oDb.ExecuteNonQuery("InsertarDomicilios", pDomicilio.ProvinciaID, pDomicilio.CiudadID, pDomicilio.BarrioID, pDomicilio.Piso, pDomicilio.Altura, pDomicilio.Calle, pDomicilio.Depto);
                clienteID = int.Parse(oDb.ExecuteScalar("ObtenerUltimoIDDomicilio").ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problemas Al Guardar El Domicilio: " + ex.Message);
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
                cli = int.Parse(oDb.ExecuteScalar("ObtenerUltimoIDDomicilio").ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problemas Al Obtener El Ultimo Número De Domicilio: " + ex.Message);
                throw;
            }
            return cli;
        }
    }
}
