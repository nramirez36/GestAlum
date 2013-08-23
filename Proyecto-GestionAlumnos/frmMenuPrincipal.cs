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
            #region frmAlumnos
                frmAltaAlumnos frmAltaAlumnos;
                frmBuscarAlumnos frmBuscarAlumnos;
                frmModificarAlumnos frmModificarAlumnos;
                frmBajaAlumnos frmBajaAlumnos;
            #endregion
            #region frmCursos
                frmAltaCursos frmAltaCursos;
                frmBajaCursos frmBajaCursos;
                frmBuscarCursos frmBuscarCursos;
                frmModificarCursos frmModificarCursos;
            #endregion
            #region frmMaterias
                frmAltaMaterias frmAltaMaterias;
                frmBajaMaterias frmBajaMaterias;
                frmModificarMaterias frmModificarMaterias;
                frmBuscarMaterias frmBuscarMaterias;
            #endregion
            #region frmReportes
                
            #endregion
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
            private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
            {
                frmBuscarAlumnos = new frmBuscarAlumnos();
                frmBuscarAlumnos.MdiParent = this;
                frmBuscarAlumnos.Show();
            }
            private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
            {
                frmModificarAlumnos = new frmModificarAlumnos();
                frmModificarAlumnos.MdiParent = this;
                frmModificarAlumnos.Show();
            }
            private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
            {
                frmBajaAlumnos = new frmBajaAlumnos();
                frmBajaAlumnos.MdiParent = this;
                frmBajaAlumnos.Show();
            }
            private void nuevToolStripMenuItem_Click(object sender, EventArgs e)
            {
                frmAltaMaterias = new frmAltaMaterias();
                frmAltaMaterias.MdiParent = this;
                frmAltaMaterias.Show();
            }
            private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
            {
                frmModificarMaterias = new frmModificarMaterias();
                frmModificarMaterias.MdiParent = this;
                frmModificarMaterias.Show();
            }
            private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
            {
                frmModificarMaterias = new frmModificarMaterias();
                frmModificarMaterias.MdiParent = this;
                frmModificarMaterias.Show();
            }
            private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
            {
                frmBuscarMaterias = new frmBuscarMaterias();
                frmBuscarMaterias.MdiParent = this;
                frmBuscarMaterias.Show();
            }
            private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
            {
                frmAltaCursos = new frmAltaCursos();
                frmAltaCursos.MdiParent = this;
                frmAltaCursos.Show();
            }
            private void modificarToolStripMenuItem2_Click(object sender, EventArgs e)
            {
                frmModificarCursos = new frmModificarCursos();
                frmModificarCursos.MdiParent = this;
                frmModificarCursos.Show();
            }
            private void eliminarToolStripMenuItem2_Click(object sender, EventArgs e)
            {
                frmBajaCursos = new frmBajaCursos();
                frmBajaCursos.MdiParent = this;
                frmBajaCursos.Show();
            }
            private void buscarToolStripMenuItem2_Click(object sender, EventArgs e)
            {
                frmBuscarCursos = new frmBuscarCursos();
                frmBuscarCursos.MdiParent = this;
                frmBuscarCursos.Show();
            }
        #endregion                

        #region Test
            private void calcularEdadToolStripMenuItem_Click(object sender, EventArgs e)
            {
                frmTestCalcularEdad frmTestCalcularEdad = new frmTestCalcularEdad();
                frmTestCalcularEdad.MdiParent = this;
                frmTestCalcularEdad.Show();
            }
        #endregion
      
    }
}
