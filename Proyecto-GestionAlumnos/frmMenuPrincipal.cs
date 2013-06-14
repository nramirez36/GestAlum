using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_GestionAlumnos
{
    public partial class frmPantallaPrincipal : Form
    {
        #region Variables
            frmAltaAlumnos frmAltaAlumnos;
        #endregion

        #region Constructor
            public frmPantallaPrincipal()
            {
                InitializeComponent();
                
            }
        #endregion

        #region Metodos

        #endregion

        #region Eventos
            private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
            {
                frmAltaAlumnos = new frmAltaAlumnos();
                frmAltaAlumnos.MdiParent = this;
                frmAltaAlumnos.Show();
            }
        #endregion                
    }
}
