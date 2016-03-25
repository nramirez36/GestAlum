using GestionAlumnos.BL;
using GestionAlumnos.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using nramirez36; 
namespace Proyecto_GestionAlumnos
{
    public partial class frmTestCalcularEdad : Form
    {
        public frmTestCalcularEdad()
        {
            InitializeComponent();
         
        }
        
        public int Edad()
        {
            //Obtengo la diferencia en años.
            int edad = DateTime.Now.Year - dateTimePicker1.Value.Year;

            //Obtengo la fecha de cumpleaños de este año.
            DateTime nacimientoAhora = dateTimePicker1.Value.AddYears(edad);
            //Le resto un año si la fecha actual es anterior 
            //al día de nacimiento.
            if (DateTime.Now.CompareTo(nacimientoAhora) < 0)
                edad--; 
            return edad;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "La edad es: " + Edad().ToString();
        }
        //string path = System.IO.Path.GetDirectoryName( System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase );

        private void button2_Click(object sender, EventArgs e)
        {
           // nramirez36.Logger.Logger.enviarEmailConError();
            MessageBox.Show("ENVIADO");
        }

        private void button3_Click(object sender, EventArgs e)
        {
           /* if (nramirez36.Logger.Logger.isConnectionAvailable())
            {
                MessageBox.Show("HAY INTERNET");
                nramirez36.Logger.Logger.WriteXMLError("TEST", "TEEST", "PRUEBE", "ESTO ES UNA PRUEBA");
            }

            else
                MessageBox.Show("NO HAY INTERNET");*/
        }

        private void LoadComboProvincias()
        {
            try
            {
                GestorProvincias oGP = new GestorProvincias();
                comboBox1.DataSource = oGP.Listar().ToList();
                comboBox1.DisplayMember = "Descripcion";
                comboBox1.ValueMember = "codProvincia";
                if (comboBox1.Items.Count!=0)
                {
                    int codProvincia = Convert.ToInt32(comboBox1.SelectedValue);
                    LoadComboCiudad(codProvincia);
                }
                else
                {
                    comboBox2.DataSource = null;
                    comboBox3.DataSource = null;
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
                comboBox2.DataSource = oGC.Listar(pCodProvincia).ToList();
                comboBox2.DisplayMember = "Descripcion";
                comboBox2.ValueMember = "codCiudad";
                if (true)
                {
                    int codCiudad = Convert.ToInt32(comboBox2.SelectedValue);
                    LoadComboBarrio(codCiudad);
                }
                else
                {
                    comboBox3.DataSource = null;
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
                comboBox3.DataSource = null;
                GestorBarrios oGB = new GestorBarrios();
                comboBox3.DataSource = oGB.Listar(pCodCiudad).ToList();
                comboBox3.DisplayMember = "Descripcion";
                comboBox3.ValueMember = "codBarrio";
            }
            catch (Exception ex)
            {
                Console.WriteLine("LISTARBARRIO:" + ex.Message);
                throw;
            }
        }

        private void frmTestCalcularEdad_Load(object sender, EventArgs e)
        {
            LoadComboProvincias();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int codProvincia = Convert.ToInt32(comboBox1.SelectedValue);
            LoadComboCiudad(codProvincia);
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int codBarrio = Convert.ToInt32(comboBox2.SelectedValue);
            LoadComboBarrio(codBarrio);
        }

    }
}
