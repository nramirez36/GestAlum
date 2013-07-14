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
namespace GestionAlumnos.DL
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
            }
        #endregion

        #region Eventos
        
        #endregion

        
        
    }
}
