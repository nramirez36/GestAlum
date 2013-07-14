namespace Proyecto_GestionAlumnos
{
    partial class frmPantallaPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuGeneral = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porOrdenAlfabeticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularEdadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mnuGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuGeneral
            // 
            this.mnuGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.alumnosToolStripMenuItem,
            this.materiasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudasToolStripMenuItem,
            this.testToolStripMenuItem});
            this.mnuGeneral.Location = new System.Drawing.Point(0, 0);
            this.mnuGeneral.Name = "mnuGeneral";
            this.mnuGeneral.Size = new System.Drawing.Size(1008, 24);
            this.mnuGeneral.TabIndex = 0;
            this.mnuGeneral.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.buscarToolStripMenuItem});
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.materiasToolStripMenuItem.Text = "Materias";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeAlumnosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // listadoDeAlumnosToolStripMenuItem
            // 
            this.listadoDeAlumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porOrdenAlfabeticoToolStripMenuItem,
            this.porDocumentoToolStripMenuItem});
            this.listadoDeAlumnosToolStripMenuItem.Name = "listadoDeAlumnosToolStripMenuItem";
            this.listadoDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.listadoDeAlumnosToolStripMenuItem.Text = "Listado de Alumnos";
            // 
            // porOrdenAlfabeticoToolStripMenuItem
            // 
            this.porOrdenAlfabeticoToolStripMenuItem.Name = "porOrdenAlfabeticoToolStripMenuItem";
            this.porOrdenAlfabeticoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.porOrdenAlfabeticoToolStripMenuItem.Text = "Por Orden Alfabetico";
            // 
            // porDocumentoToolStripMenuItem
            // 
            this.porDocumentoToolStripMenuItem.Name = "porDocumentoToolStripMenuItem";
            this.porDocumentoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.porDocumentoToolStripMenuItem.Text = "Por Documento";
            // 
            // ayudasToolStripMenuItem
            // 
            this.ayudasToolStripMenuItem.Name = "ayudasToolStripMenuItem";
            this.ayudasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudasToolStripMenuItem.Text = "Ayuda";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcularEdadToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // calcularEdadToolStripMenuItem
            // 
            this.calcularEdadToolStripMenuItem.Name = "calcularEdadToolStripMenuItem";
            this.calcularEdadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.calcularEdadToolStripMenuItem.Text = "Calcular edad";
            this.calcularEdadToolStripMenuItem.Click += new System.EventHandler(this.calcularEdadToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 707);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmPantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnuGeneral);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuGeneral;
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Name = "frmPantallaPrincipal";
            this.Text = "Sistema De Gestión De Alumnos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuGeneral.ResumeLayout(false);
            this.mnuGeneral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuGeneral;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porOrdenAlfabeticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porDocumentoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularEdadToolStripMenuItem;
    }
}

