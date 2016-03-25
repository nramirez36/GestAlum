namespace Proyecto_GestionAlumnos
{
    partial class frmBuscarAlumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBuscarAlumnos = new System.Windows.Forms.GroupBox();
            this.btnBuscarAlumno = new System.Windows.Forms.Button();
            this.txtBuscarApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grpDatosAlumnos = new System.Windows.Forms.GroupBox();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grpDatosDomicilio = new System.Windows.Forms.GroupBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtPiso = new System.Windows.Forms.MaskedTextBox();
            this.txtAltura = new System.Windows.Forms.MaskedTextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.cboBarrio = new System.Windows.Forms.ComboBox();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.cboCiudad = new System.Windows.Forms.ComboBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblDepto = new System.Windows.Forms.Label();
            this.txtDepto = new System.Windows.Forms.TextBox();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.grpBuscarAlumnos.SuspendLayout();
            this.grpDatosAlumnos.SuspendLayout();
            this.grpDatosDomicilio.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBuscarAlumnos
            // 
            this.grpBuscarAlumnos.Controls.Add(this.btnBuscarAlumno);
            this.grpBuscarAlumnos.Controls.Add(this.txtBuscarApellido);
            this.grpBuscarAlumnos.Controls.Add(this.label1);
            this.grpBuscarAlumnos.Location = new System.Drawing.Point(13, 13);
            this.grpBuscarAlumnos.Name = "grpBuscarAlumnos";
            this.grpBuscarAlumnos.Size = new System.Drawing.Size(636, 57);
            this.grpBuscarAlumnos.TabIndex = 0;
            this.grpBuscarAlumnos.TabStop = false;
            this.grpBuscarAlumnos.Text = "Buscar Alumnos";
            // 
            // btnBuscarAlumno
            // 
            this.btnBuscarAlumno.Location = new System.Drawing.Point(529, 20);
            this.btnBuscarAlumno.Name = "btnBuscarAlumno";
            this.btnBuscarAlumno.Size = new System.Drawing.Size(101, 23);
            this.btnBuscarAlumno.TabIndex = 2;
            this.btnBuscarAlumno.Text = "Buscar";
            this.btnBuscarAlumno.UseVisualStyleBackColor = true;
            this.btnBuscarAlumno.Click += new System.EventHandler(this.btnBuscarAlumno_Click);
            // 
            // txtBuscarApellido
            // 
            this.txtBuscarApellido.Location = new System.Drawing.Point(120, 20);
            this.txtBuscarApellido.Name = "txtBuscarApellido";
            this.txtBuscarApellido.Size = new System.Drawing.Size(403, 20);
            this.txtBuscarApellido.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese DNI:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(574, 458);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // grpDatosAlumnos
            // 
            this.grpDatosAlumnos.Controls.Add(this.txtNacionalidad);
            this.grpDatosAlumnos.Controls.Add(this.lblNacionalidad);
            this.grpDatosAlumnos.Controls.Add(this.txtEdad);
            this.grpDatosAlumnos.Controls.Add(this.lblEdad);
            this.grpDatosAlumnos.Controls.Add(this.txtDocumento);
            this.grpDatosAlumnos.Controls.Add(this.lblDocumento);
            this.grpDatosAlumnos.Controls.Add(this.cboTipoDocumento);
            this.grpDatosAlumnos.Controls.Add(this.lblTipoDocumento);
            this.grpDatosAlumnos.Controls.Add(this.dtpFechaNacimiento);
            this.grpDatosAlumnos.Controls.Add(this.lblFechaNacimiento);
            this.grpDatosAlumnos.Controls.Add(this.txtApellido);
            this.grpDatosAlumnos.Controls.Add(this.lblApellidos);
            this.grpDatosAlumnos.Controls.Add(this.txtNombres);
            this.grpDatosAlumnos.Controls.Add(this.lblNombre);
            this.grpDatosAlumnos.Location = new System.Drawing.Point(13, 76);
            this.grpDatosAlumnos.Name = "grpDatosAlumnos";
            this.grpDatosAlumnos.Size = new System.Drawing.Size(636, 166);
            this.grpDatosAlumnos.TabIndex = 2;
            this.grpDatosAlumnos.TabStop = false;
            this.grpDatosAlumnos.Text = "Datos del Alumno";
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(121, 119);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(200, 20);
            this.txtNacionalidad.TabIndex = 13;
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(7, 122);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(72, 13);
            this.lblNacionalidad.TabIndex = 12;
            this.lblNacionalidad.Text = "Nacionalidad:";
            // 
            // txtEdad
            // 
            this.txtEdad.Enabled = false;
            this.txtEdad.Location = new System.Drawing.Point(421, 56);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(104, 20);
            this.txtEdad.TabIndex = 7;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(350, 59);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 6;
            this.lblEdad.Text = "Edad:";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(421, 84);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(104, 20);
            this.txtDocumento.TabIndex = 11;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(350, 87);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(65, 13);
            this.lblDocumento.TabIndex = 10;
            this.lblDocumento.Text = "Documento:";
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(121, 86);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(121, 21);
            this.cboTipoDocumento.TabIndex = 9;
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(6, 90);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(89, 13);
            this.lblTipoDocumento.TabIndex = 8;
            this.lblTipoDocumento.Text = "Tipo Documento:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(121, 56);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 5;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(7, 62);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(108, 13);
            this.lblFechaNacimiento.TabIndex = 4;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(421, 27);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(211, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(350, 30);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(52, 13);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(121, 27);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(200, 20);
            this.txtNombres.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(52, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombres:";
            // 
            // grpDatosDomicilio
            // 
            this.grpDatosDomicilio.Controls.Add(this.txtCelular);
            this.grpDatosDomicilio.Controls.Add(this.txtTelefono);
            this.grpDatosDomicilio.Controls.Add(this.txtPiso);
            this.grpDatosDomicilio.Controls.Add(this.txtAltura);
            this.grpDatosDomicilio.Controls.Add(this.lblAltura);
            this.grpDatosDomicilio.Controls.Add(this.cboBarrio);
            this.grpDatosDomicilio.Controls.Add(this.cboProvincia);
            this.grpDatosDomicilio.Controls.Add(this.cboCiudad);
            this.grpDatosDomicilio.Controls.Add(this.lblProvincia);
            this.grpDatosDomicilio.Controls.Add(this.lblDepto);
            this.grpDatosDomicilio.Controls.Add(this.txtDepto);
            this.grpDatosDomicilio.Controls.Add(this.lblPiso);
            this.grpDatosDomicilio.Controls.Add(this.lblCelular);
            this.grpDatosDomicilio.Controls.Add(this.lblTelefono);
            this.grpDatosDomicilio.Controls.Add(this.lblCiudad);
            this.grpDatosDomicilio.Controls.Add(this.lblBarrio);
            this.grpDatosDomicilio.Controls.Add(this.txtDireccion);
            this.grpDatosDomicilio.Controls.Add(this.lblDireccion);
            this.grpDatosDomicilio.Location = new System.Drawing.Point(12, 248);
            this.grpDatosDomicilio.Name = "grpDatosDomicilio";
            this.grpDatosDomicilio.Size = new System.Drawing.Size(637, 204);
            this.grpDatosDomicilio.TabIndex = 14;
            this.grpDatosDomicilio.TabStop = false;
            this.grpDatosDomicilio.Text = "Datos del Domicilio";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(421, 166);
            this.txtCelular.Mask = "0000-000-000000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(104, 20);
            this.txtCelular.TabIndex = 17;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(121, 166);
            this.txtTelefono.Mask = "0000-000-000000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(121, 20);
            this.txtTelefono.TabIndex = 15;
            // 
            // txtPiso
            // 
            this.txtPiso.BeepOnError = true;
            this.txtPiso.Location = new System.Drawing.Point(121, 71);
            this.txtPiso.Mask = "99999";
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(100, 20);
            this.txtPiso.TabIndex = 5;
            this.txtPiso.ValidatingType = typeof(int);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(421, 33);
            this.txtAltura.Mask = "99999";
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(104, 20);
            this.txtAltura.TabIndex = 3;
            this.txtAltura.ValidatingType = typeof(int);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(350, 36);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(37, 13);
            this.lblAltura.TabIndex = 2;
            this.lblAltura.Text = "Altura:";
            // 
            // cboBarrio
            // 
            this.cboBarrio.FormattingEnabled = true;
            this.cboBarrio.Location = new System.Drawing.Point(421, 126);
            this.cboBarrio.Name = "cboBarrio";
            this.cboBarrio.Size = new System.Drawing.Size(200, 21);
            this.cboBarrio.TabIndex = 13;
            // 
            // cboProvincia
            // 
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(121, 104);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(200, 21);
            this.cboProvincia.TabIndex = 9;
            // 
            // cboCiudad
            // 
            this.cboCiudad.FormattingEnabled = true;
            this.cboCiudad.Location = new System.Drawing.Point(121, 131);
            this.cboCiudad.Name = "cboCiudad";
            this.cboCiudad.Size = new System.Drawing.Size(200, 21);
            this.cboCiudad.TabIndex = 11;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(7, 104);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 8;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblDepto
            // 
            this.lblDepto.AutoSize = true;
            this.lblDepto.Location = new System.Drawing.Point(352, 74);
            this.lblDepto.Name = "lblDepto";
            this.lblDepto.Size = new System.Drawing.Size(39, 13);
            this.lblDepto.TabIndex = 6;
            this.lblDepto.Text = "Depto:";
            // 
            // txtDepto
            // 
            this.txtDepto.Location = new System.Drawing.Point(421, 71);
            this.txtDepto.Name = "txtDepto";
            this.txtDepto.Size = new System.Drawing.Size(104, 20);
            this.txtDepto.TabIndex = 7;
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(7, 74);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(30, 13);
            this.lblPiso.TabIndex = 4;
            this.lblPiso.Text = "Piso:";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(352, 169);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(42, 13);
            this.lblCelular.TabIndex = 16;
            this.lblCelular.Text = "Celular:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(7, 169);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 14;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(7, 134);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(43, 13);
            this.lblCiudad.TabIndex = 10;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(350, 134);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(37, 13);
            this.lblBarrio.TabIndex = 12;
            this.lblBarrio.Text = "Barrio:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(121, 33);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(200, 20);
            this.txtDireccion.TabIndex = 1;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(7, 36);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 0;
            this.lblDireccion.Text = "Dirección:";
            // 
            // frmBuscarAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 486);
            this.Controls.Add(this.grpDatosDomicilio);
            this.Controls.Add(this.grpDatosAlumnos);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grpBuscarAlumnos);
            this.Name = "frmBuscarAlumnos";
            this.Text = "Gestión de Alumnos";
            this.grpBuscarAlumnos.ResumeLayout(false);
            this.grpBuscarAlumnos.PerformLayout();
            this.grpDatosAlumnos.ResumeLayout(false);
            this.grpDatosAlumnos.PerformLayout();
            this.grpDatosDomicilio.ResumeLayout(false);
            this.grpDatosDomicilio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBuscarAlumnos;
        private System.Windows.Forms.Button btnBuscarAlumno;
        private System.Windows.Forms.TextBox txtBuscarApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox grpDatosAlumnos;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grpDatosDomicilio;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.MaskedTextBox txtPiso;
        private System.Windows.Forms.MaskedTextBox txtAltura;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.ComboBox cboBarrio;
        private System.Windows.Forms.ComboBox cboProvincia;
        private System.Windows.Forms.ComboBox cboCiudad;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblDepto;
        private System.Windows.Forms.TextBox txtDepto;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
    }
}