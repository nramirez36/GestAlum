using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionAlumnos.Entities;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
namespace GestionAlumnos.UI
{
    public class TiposDocumentos
    {
        public static IEnumerable<TipoDocumento> ListarTiposDocumentos()
        {
            Database odb = DatabaseFactory.CreateDatabase("gestionAlumnos");
            try
            {
                return odb.ExecuteSprocAccessor("ListarTiposDocumentos", MapBuilder<TipoDocumento>.MapAllProperties().Build());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problemas Al Listar Los Clientes: " + ex.Message);
                throw;
            }
        }
        public static bool Eliminar(int id)
        {
            Database oDb = DatabaseFactory.CreateDatabase("gestionAlumnos");
            int result;
            try
            {
                result = oDb.ExecuteNonQuery("EliminarTipoDocumento", id);
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
                Console.WriteLine("Problema Al Eliminar El Tipo De Documento: " + ex.Message);
                throw;
            }
        }
        public static bool Actualizar(TipoDocumento pTipoDocumento)
        {
            Database oDb = DatabaseFactory.CreateDatabase("gestionAlumnos");
            int result;
            try
            {
                result = oDb.ExecuteNonQuery("ModificarTipoDocumento", pTipoDocumento.Descripcion, pTipoDocumento.TipoDocumentoID);
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
                Console.WriteLine("Problemas Al Modificar El Tipo De Documento: " + ex.Message);
                throw;
            }
        }
        public static int Insertar(TipoDocumento pTipoDocumento)
        {
            Database oDb = DatabaseFactory.CreateDatabase("gestionAlumnos");
            int clienteID = -1;
            try
            {
                clienteID = int.Parse(oDb.ExecuteScalar("InsertarTipoDocumento", pTipoDocumento.Descripcion).ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problemas Al Guardar El Tipo De Documento: " + ex.Message);
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
                cli = int.Parse(oDb.ExecuteScalar("ObtenerUltimoIDTiposDocumentos").ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problemas Al Obtener El Ultimo Número De Tipo De Documento: " + ex.Message);
                throw;
            }
            return cli;
        }

    }
}
