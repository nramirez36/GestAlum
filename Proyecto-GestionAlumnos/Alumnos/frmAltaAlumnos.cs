﻿using System;
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
            int idDomicilio;
        #endregion

        #region Getters And Setters

            #region Domicilio

                public int pDireccionID { get; set; }    
                public string pCalle { get; set; }
                public string pAltura { get; set; }
                public string pDepto { get; set; }
                public string pPiso { get; set; }
                public int pBarrioID { get; set; }
                public int pCiudadID { get; set; }
                public int pProvinciaID { get; set; }
                
            #endregion
            #region Alumno
                public string pNombres { get; set; }
                public string pApellidos { get; set; }
                public int pTipoDocumentoID { get; set; }
                public int pNroDocumento { get; set; }
                public string pTelefonoFijo { get; set; }
                public string pTelefonoCelular { get; set; }
                public string pNacionalidad { get; set; }
                public DateTime pFechaNacimiento { get; set; }
                public int pEdad { get; set; }
            #endregion

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
                LoadComboProvincias();
                ListarTiposDocumentos();
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
                    if (cboCiudad.Items.Count!=0)
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
            private void leerDatosDomicilio()
            {
                try
                {
                    pCalle = txtDireccion.Text.ToString();
                    pAltura = txtAltura.Text.ToString();
                    pBarrioID =int.Parse( cboBarrio.SelectedValue.ToString());
                    pCiudadID = int.Parse(cboCiudad.SelectedValue.ToString());
                    pProvinciaID = int.Parse(cboProvincia.SelectedValue.ToString());
                    if (txtPiso.Text == "")
                        txtPiso.Text = "-";
                    pPiso = txtPiso.Text.ToString();
                    if (txtDepto.Text == "")
                        txtDepto.Text = "-";
                    pDepto = txtDepto.Text.ToString();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("leerDatosDomicilio:" + ex.Message);
                    throw;
                }
            }
            private void leerDatosAlumnos()
            {
                try
                {
                    pNombres = txtNombres.Text.ToString();
                    pApellidos = txtApellido.Text.ToString();
                    pTipoDocumentoID = int.Parse(cboTipoDocumento.SelectedValue.ToString());
                    pNroDocumento = int.Parse(txtDocumento.Text.ToString());
                    pFechaNacimiento =dtpFechaNacimiento.Value;
                    pEdad = int.Parse(txtEdad.Text.ToString());
                    pNacionalidad = txtNacionalidad.Text.ToString();
                    pTelefonoCelular = txtCelular.Text.ToString();
                    pTelefonoFijo = txtTelefono.Text.ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("leerDatosAlumnos:" + ex.Message);
                    throw;
                }
            }
            private bool registrarDomicilio()
            {
                bool resRegistro=false;
                int idDom=-1;
                try
                {
                    leerDatosDomicilio();
                    Domicilio oDom = new Domicilio();
                    oDom.Calle = pCalle;
                    oDom.Altura = pAltura;
                    oDom.BarrioID = pBarrioID;
                    oDom.CiudadID = pCiudadID;
                    oDom.ProvinciaID = pProvinciaID;
                    oDom.Depto = pDepto;
                    oDom.Piso = pPiso;
                    oGD = new GestorDomicilios();
                    idDom = oGD.Insertar(oDom);
                    if (idDom < 1)
                        idDom = oGD.ObtenerID();
                    idDomicilio = idDom;
                    resRegistro = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Problema al Registrar el Domiclio:" + ex.Message);
                    throw;
                }
                return resRegistro;
            }
            private bool registrarAlumno()
            {
                bool resRegistro = false;
                int idAlum = -1;
                try
                {
                    leerDatosAlumnos();
                    Alumno oAlu = new Alumno();
                    oAlu.Apellidos = pApellidos;
                    oAlu.Nombres = pNombres;
                    oAlu.NroDocumento = pNroDocumento;
                    oAlu.Edad = pEdad;
                    oAlu.FechaNacimiento = pFechaNacimiento;
                    oAlu.Nacionalidad = pNacionalidad;
                    oAlu.TelefonoCelular = pTelefonoCelular;
                    oAlu.TelefonoFijo = pTelefonoFijo;
                    oAlu.TipoDocumentoID = pTipoDocumentoID;
                    oAlu.DireccionID = idDomicilio;
                    oGA = new GestorAlumnos();
                    idAlum = oGA.Insertar(oAlu);
                    if (idAlum < 1)
                        idAlum = oGA.ObtenerID();
                    resRegistro = true;
                }
                catch (Exception ex) 
                {
                    Console.WriteLine("Problema al Registrar el Alumno:" + ex.Message);
                    throw;
                }
                return resRegistro;
            }
            public int Edad()
            {
                //Obtengo la diferencia en años.
                int edad = DateTime.Now.Year - dtpFechaNacimiento.Value.Year;

                //Obtengo la fecha de cumpleaños de este año.
                DateTime nacimientoAhora = dtpFechaNacimiento.Value.AddYears(edad);
                //Le resto un año si la fecha actual es anterior 
                //al día de nacimiento.
                if (DateTime.Now.CompareTo(nacimientoAhora) < 0)
                    edad--;
                return edad;
            }
        #endregion 
        
        #region Eventos
            
            private void btnAlta_Click(object sender, EventArgs e)
            {
                try
                {
                    if (registrarDomicilio())
                    {
                        //txtNacionalidad.Text = "ANDUVO";
                        registrarAlumno();
                        MessageBox.Show("El Alumno Se Registro Correctamente");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Problema al Registrar el Alumno:" + ex.Message);
                    throw;
                }
            }
            private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
            {
                txtEdad.Text = Edad().ToString();
            }
            private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
            {
                int codProvincia = Convert.ToInt32(cboProvincia.SelectedValue);
                LoadComboCiudad(codProvincia);
            }
            private void cboCiudad_SelectionChangeCommitted(object sender, EventArgs e)
            {
                int codBarrio = Convert.ToInt32(cboCiudad.SelectedValue);
                LoadComboBarrio(codBarrio);
            }
        #endregion    

    }
}
