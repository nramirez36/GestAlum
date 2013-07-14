using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Web;
namespace nramirez36.Logger
{
    public class GestorXML
    {
        //public static bool CrearCarpetaXml(string Ruta)
        //{
        //    bool Respuesta = false;
        //    try
        //    {
        //        //string dir=sy
        //        if (Directory.Exists(Ruta))
        //        {
        //            Respuesta = true;
        //        }
        //        else
        //        {
        //            Directory.CreateDirectory(Ruta);
        //            Respuesta = true;
        //        }
        //        return Respuesta;
        //    }
        //    catch (Exception ex)
        //    {
        //        //logger.Error("Error en CrearCarpetaXml, ClaseXml:" + ex.Message);
        //        return Respuesta;
        //        //No fue posible crear el directorio...
        //    }
        //}
        //public static bool ArchivoExiste(string Ruta)
        //{
        //    bool rta = false;

        //    try
        //    {
        //        XmlTextWriter EscribirRec = new XmlTextWriter("Logs/Error.xml", System.Text.Encoding.UTF8);

        //        EscribirRec.Formatting = Formatting.Indented;
        //        EscribirRec.Indentation = 2;
        //        EscribirRec.WriteStartDocument(false);
        //        EscribirRec.WriteComment("Gestión de Alumnos");

        //        EscribirRec.WriteStartElement("Operación");
        //        EscribirRec.WriteStartElement("Respuestas");

        //        EscribirRec.WriteStartElement("RespuestaExitosa");
        //        EscribirRec.WriteEndElement();

        //        EscribirRec.WriteStartElement("RespuestaFallida");
        //        EscribirRec.WriteEndElement();

        //        EscribirRec.WriteEndElement();
        //        EscribirRec.WriteEndElement();
        //        EscribirRec.WriteEndDocument();
        //        EscribirRec.Close();
        //        rta = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        rta = false;
        //    }

        //    return rta;
        //}
        //private static bool CrearXmlTransacciones()
        //{
        //    bool rta = false;

        //    try
        //    {
        //        XmlTextWriter EscribirRec = new XmlTextWriter("Logs/Error.xml", System.Text.Encoding.UTF8);

        //        EscribirRec.Formatting = Formatting.Indented;
        //        EscribirRec.Indentation = 2;
        //        EscribirRec.WriteStartDocument(false);
        //        EscribirRec.WriteComment("Gestión de Alumnos");

        //        EscribirRec.WriteStartElement("Operación");
        //        EscribirRec.WriteStartElement("Respuestas");

        //        EscribirRec.WriteStartElement("RespuestaExitosa");
        //        EscribirRec.WriteEndElement();

        //        EscribirRec.WriteStartElement("RespuestaFallida");
        //        EscribirRec.WriteEndElement();

        //        EscribirRec.WriteEndElement();
        //        EscribirRec.WriteEndElement();
        //        EscribirRec.WriteEndDocument();
        //        EscribirRec.Close();
        //        rta = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        rta = false;
        //    }

        //    return rta;
        //}
        //                                    //string 
        //public static bool NodoTransacciones(string CodRespuesta, string MensajeRespuesta, string CodProceso, string Proveedor, string Producto, string NombreProducto, string Monto, string Usuario)
        //{
        //    XmlDocument XmlDoc;
        //    XmlNode Raiz;
        //    XmlNode ident;
        //    bool rta = false;

        //    try
        //    {
        //        XmlDoc = new XmlDocument();
        //        XmlDoc.Load("Logs/Error.xml");
        //        Raiz = XmlDoc.DocumentElement;


        //        if (CodRespuesta == "Exitosa")
        //        {
        //            ident = Raiz.FirstChild.FirstChild; // las transacciones quedarán en las exitosas
        //        }
        //        else
        //        {
        //            ident = Raiz.FirstChild.FirstChild.NextSibling; // las transacciones quedarán en las fallidas
        //        }

        //        XmlElement NuevaTransaccion = XmlDoc.CreateElement("Operacion"); //Como vamos a llamar el nuevo nodo
        //        NuevaTransaccion.InnerXml = "<Nombre></Nombre><CodRespuesta></CodRespuesta><MensajeRespuesta></MensajeRespuesta><CodProceso></CodProceso>" +
        //            "<Proveedor></Proveedor><Producto></Producto><NombreProducto></NombreProducto><Monto></Monto><Usuario></Usuario>"; // Este es el contenido que va a tener el nuevo nodo

        //        NuevaTransaccion.AppendChild(XmlDoc.CreateWhitespace("\r\n"));
        //        NuevaTransaccion["Nombre"].InnerText = "transaccion de prueba";
        //        NuevaTransaccion["CodRespuesta"].InnerText = CodRespuesta;
        //        NuevaTransaccion["MensajeRespuesta"].InnerText = MensajeRespuesta;
        //        NuevaTransaccion["CodProceso"].InnerText = CodProceso;
        //        NuevaTransaccion["Proveedor"].InnerText = Proveedor;
        //        NuevaTransaccion["Producto"].InnerText = Producto;
        //        NuevaTransaccion["NombreProducto"].InnerText = NombreProducto;
        //        NuevaTransaccion["Monto"].InnerText = Monto;
        //        NuevaTransaccion["Usuario"].InnerText = Usuario;

        //        ident.InsertAfter(NuevaTransaccion, ident.LastChild);
        //        XmlTextWriter EscribirRec = new XmlTextWriter("ArchivosXml/Transacciones.xml", System.Text.Encoding.UTF8);
        //        XmlDoc.WriteTo(EscribirRec);
        //        EscribirRec.Close();
        //        rta = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        rta = false;
        //        //logger.Error("Error en NodoTransacciones, ClaseXml:" + ex.Message);
        //    }
        //    return rta;
        //}
        //public static void CrearXML()
        //{
        //    int k = 0;
        //    while (k <= 3)
        //    {
        //        if (CrearCarpetaXml("ArchivosXml"))
        //        {
        //            if (ArchivoExiste("ArchivosXml/Transacciones.xml"))
        //            {
        //                NodoTransacciones("Exitosa", "Transaccion Exitsoa", "123", "01", "05", "Atun", "1000", "JLopez");

        //                NodoTransacciones("NoExitosa", "No hay saldo disponible", "123", "01", "05", "Atun", "1000", "JLopez");
        //            }
        //            else
        //            {
        //                CrearXmlTransacciones();
        //            }
        //        }
        //        else
        //        {
        //            //no se creo la carpeta
        //        }

        //        k++;
        //    }
        //}

        public static void WriteXMLError(string FileName, string WindowsSource, string MethodSource, string ErrorText)
        {
            string text = AppDomain.CurrentDomain.BaseDirectory;
            text += "\\ErrorLog\\";
            if (!Directory.Exists(text))
            {
                Directory.CreateDirectory(text);
            }
            FileName = FileName + "_" + DateTime.Now.ToString("dd_MM_yyyy") + ".xml";
            StringBuilder stringBuilder = new StringBuilder();
            if (File.Exists(text + FileName))
            {
                StreamReader streamReader = new StreamReader(text + FileName);
                stringBuilder.Append(streamReader.ReadToEnd());
                streamReader.Close();
                stringBuilder.Replace("</Xml>", "");
            }
            else
            {
                stringBuilder.AppendLine("<Xml>");
            }
            StreamWriter streamWriter = new StreamWriter(text + FileName, false);
            try
            {
                stringBuilder.AppendLine("<Error>");
                stringBuilder.AppendLine("<Fecha>" + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss") + "</Fecha>");
                stringBuilder.AppendLine("<Pantalla>" + WindowsSource + "</Pantalla>");
                stringBuilder.AppendLine("<Metodo>" + MethodSource + "</Metodo>");
                stringBuilder.AppendLine("<Texto>" + ErrorText + "</Texto>");
                stringBuilder.AppendLine("</Error>");
                stringBuilder.AppendLine("</Xml>");
                streamWriter.Write(stringBuilder.ToString());
            }
            catch
            {
            }
            finally
            {
                streamWriter.Close();
                streamWriter.Dispose();
            }
        }
        public static void WriteXMLLog(string FileName, string WindowsSource, string MethodSource, string ErrorText)
        {
            string text = HttpContext.Current.Server.MapPath("");
            text += "\\Log\\";
            if (!Directory.Exists(text))
            {
                Directory.CreateDirectory(text);
            }
            FileName = FileName + "_" + DateTime.Now.ToString("dd_MM_yyyy") + ".xml";
            StringBuilder stringBuilder = new StringBuilder();
            if (File.Exists(text + FileName))
            {
                StreamReader streamReader = new StreamReader(text + FileName);
                stringBuilder.Append(streamReader.ReadToEnd());
                streamReader.Close();
                stringBuilder.Replace("</Xml>", "");
            }
            else
            {
                stringBuilder.AppendLine("<Xml>");
            }
            StreamWriter streamWriter = new StreamWriter(text + FileName, false);
            try
            {
                stringBuilder.AppendLine("<Log>");
                stringBuilder.AppendLine("<Fecha>" + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss") + "</Fecha>");
                stringBuilder.AppendLine("<Pantalla>" + WindowsSource + "</Pantalla>");
                stringBuilder.AppendLine("<Metodo>" + MethodSource + "</Metodo>");
                stringBuilder.AppendLine("<Texto>" + ErrorText + "</Texto>");
                stringBuilder.AppendLine("</Log>");
                stringBuilder.AppendLine("</Xml>");
                streamWriter.Write(stringBuilder.ToString());
            }
            catch
            {
            }
            finally
            {
                streamWriter.Close();
                streamWriter.Dispose();
            }
        }
        public static bool WriteFlatFile(string Name, string strErr)
        {
            string text = HttpContext.Current.Server.MapPath("");
            text += "\\TextLog\\";
            if (!Directory.Exists(text))
            {
                Directory.CreateDirectory(text);
            }
            string str = Name + "_" + DateTime.Now.ToString("dd_MM_yyyy") + ".txt";
            StreamWriter streamWriter = new StreamWriter(text + str, true);
            bool result;
            try
            {
                string value = "Se ha Producido un error el dia: " + DateTime.Today + " La Información del error que se pudo recuperar es la siguiente: ";
                streamWriter.WriteLine("");
                streamWriter.WriteLine(" ----- INICIO ERROR ------------------------------------------------------------------------------------------------------------------------ ");
                streamWriter.WriteLine("");
                streamWriter.WriteLine(value);
                streamWriter.WriteLine("   " + strErr);
                streamWriter.WriteLine("");
                streamWriter.WriteLine(" ----- FINAL  ERROR ------------------------------------------------------------------------------------------------------------------------ ");
                result = true;
            }
            catch
            {
                result = false;
            }
            finally
            {
                streamWriter.Close();
                streamWriter.Dispose();
            }
            return result;
        }
    }

}
