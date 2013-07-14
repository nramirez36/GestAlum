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
        string path = System.IO.Path.GetDirectoryName( 
      System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase );
    }
}
