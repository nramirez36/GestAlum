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
    public partial class frmBuscarAlumnos : Form
    {
        #region Variables
            
        #endregion

        #region Getters And Setters
        
        #endregion

        #region Constructor
            public frmBuscarAlumnos()
            {
                InitializeComponent();
                DesactivarCampos();
                //grpDatosAlumnos.Visible = false;
                //grpDatosDomicilio.Visible = false;
            }
        #endregion

        #region Metodos
            
            private void DesactivarCampos()
            {
                txtAltura.Enabled = false;
                txtApellido.Enabled = false;
                txtCelular.Enabled = false;
                txtDepto.Enabled = false;
                txtDireccion.Enabled = false;
                txtDocumento.Enabled = false;
                txtEdad.Enabled = false;
                txtNacionalidad.Enabled = false;
                txtNombres.Enabled = false;
                txtPiso.Enabled = false;
                txtTelefono.Enabled = false;
                cboBarrio.Enabled = false;
                cboCiudad.Enabled = false;
                cboProvincia.Enabled = false;
                cboTipoDocumento.Enabled = false;
                dtpFechaNacimiento.Enabled = false;
            }
            private void ActivarCampos()
            {
                txtAltura.Enabled = true;
                txtApellido.Enabled = true;
                txtCelular.Enabled = true;
                txtDepto.Enabled = true;
                txtDireccion.Enabled = true;
                txtDocumento.Enabled = true;
                txtEdad.Enabled = true;
                txtNacionalidad.Enabled = true;
                txtNombres.Enabled = true;
                txtPiso.Enabled = true;
                txtTelefono.Enabled = true;
                cboBarrio.Enabled = true;
                cboCiudad.Enabled = true;
                cboProvincia.Enabled = true;
                cboTipoDocumento.Enabled = true;
                dtpFechaNacimiento.Enabled = true;
            }
            private void LoadComboProvincias()
            {
                try
                {
                    GestorProvincias oGP = new GestorProvincias();
                    cboProvincia.DataSource = oGP.Listar().ToList();
                    cboProvincia.DisplayMember = "Descripcion";
                    cboProvincia.ValueMember = "codProvincia";
                    if (cboProvincia.Items.Count != 0)
                    {
                        int codProvincia = Convert.ToInt32(cboProvincia.SelectedValue);
                        LoadComboCiudad(codProvincia);
                    }
                    else
                    {
                        cboProvincia.DataSource = null;
                        cboProvincia.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("LISTARPROVINCIAS:" + ex.Message);
                    throw;
                }
            }
            private void LoadComboCiudad(int pCodProvincia)
            {
                try
                {
                    GestorCiudades oGC = new GestorCiudades();
                    cboCiudad.DataSource = oGC.Listar(pCodProvincia).ToList();
                    cboCiudad.DisplayMember = "Descripcion";
                    cboCiudad.ValueMember = "codCiudad";
                    if (cboCiudad.Items.Count != 0)
                    {
                        int codCiudad = Convert.ToInt32(cboCiudad.SelectedValue);
                        LoadComboBarrio(codCiudad);
                    }
                    else
                    {
                        cboCiudad.DataSource = null;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("LISTARCIUDAD:" + ex.Message);
                    throw;
                }

            }
            private void LoadComboBarrio(int pCodCiudad)
            {
                try
                {
                    cboBarrio.DataSource = null;
                    GestorBarrios oGB = new GestorBarrios();
                    cboBarrio.DataSource = oGB.Listar(pCodCiudad).ToList();
                    cboBarrio.DisplayMember = "Descripcion";
                    cboBarrio.ValueMember = "codBarrio";
                    if (cboBarrio.Items.Count == 0)
                        cboBarrio.DataSource = null;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("LISTARBARRIO:" + ex.Message);
                    throw;
                }
            }
            private void ListarTiposDocumentos()
            {
                try
                {
                    GestorTipoDocumentos oGTP = new GestorTipoDocumentos();
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
        
            private void btnBuscarAlumno_Click(object sender, EventArgs e)
            {
                grpDatosAlumnos.Visible = true;
                grpDatosDomicilio.Visible = true;
                ActivarCampos();
            }
            private void btnAceptar_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        #endregion

            

        
        
    }
}
