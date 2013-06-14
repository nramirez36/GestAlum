using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionAlumnos.Entities;
using GestionAlumnos.BL;
namespace Proyecto_GestionAlumnos
{
    public partial class frmAltaAlumnos : Form
    {
        #region Variables
            
        GestorAlumnos oGA;
            GestorBarrios oGB;
            GestorCiudades oGC;
            GestorDomicilios oGD;
            GestorProvincias oGP;
            GestorTipoDocumentos oGTP;
            
        #endregion
        
        #region Constructor
        
            public frmAltaAlumnos()
            {
                InitializeComponent();
                inicializarDatos();
            }

        #endregion

        #region Metodos
        
            private void inicializarDatos()
            {
                ListarBarrios();
                ListarCiudades();
                ListarProvinicias();
                ListarTiposDocumentos();
            }
            private void ListarBarrios()
            {
                try
                {
                    oGB = new GestorBarrios();
                    cboBarrio.DataSource = oGB.Listar().ToList();
                    cboBarrio.DisplayMember = "Descripcion";
                    cboBarrio.ValueMember = "BarrioID";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("LISTARTIPOSDOCUMENTOS:" + ex.Message);
                    throw;
                }
            }
            private void ListarCiudades()
            {
                try
                {
                    oGC = new GestorCiudades();
                    cboCiudad.DataSource = oGC.Listar().ToList();
                    cboCiudad.DisplayMember = "Descripcion";
                    cboCiudad.ValueMember = "CiudadID";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("LISTARCIUDADES:" + ex.Message);
                    throw;
                }
            }
            private void ListarProvinicias()
            {
                try
                {
                    oGP = new GestorProvincias();
                    cboProvincia.DataSource = oGP.Listar().ToList();
                    cboProvincia.DisplayMember = "Descripcion";
                    cboProvincia.ValueMember = "ProvinciaID";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("LISTARPROVINCIAS:" + ex.Message);
                    throw;
                }
            }
            private void ListarTiposDocumentos()
            {
                try
                {
                    oGTP = new GestorTipoDocumentos();
                    cboTipoDocumento.DataSource = oGTP.Listar().ToList();
                    cboTipoDocumento.DisplayMember = "Descripcion";
                    cboTipoDocumento.ValueMember = "TipoDocumentoID";
                    //cboTipoDocumento.DataBind();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("LISTARTIPOSDOCUMENTOS:" + ex.Message);
                    throw;
                }
            }
    
        #endregion
        
        #region Eventos
            
        #endregion
       

        
    }
}
