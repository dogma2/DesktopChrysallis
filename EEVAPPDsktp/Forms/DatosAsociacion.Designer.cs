namespace EEVAPPDsktp.Forms
{
    partial class DatosAsociacion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosAsociacion));
            this.buttonAlmacenar = new System.Windows.Forms.Button();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.textBoxRGPD = new System.Windows.Forms.TextBox();
            this.labelRGPD = new System.Windows.Forms.Label();
            this.textBoxCIF = new System.Windows.Forms.TextBox();
            this.labelCIF = new System.Windows.Forms.Label();
            this.textBoxWeb = new System.Windows.Forms.TextBox();
            this.labelWeb = new System.Windows.Forms.Label();
            this.textBoxCodigoPostal = new System.Windows.Forms.TextBox();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.labelCiudad = new System.Windows.Forms.Label();
            this.comboBoxComunidad = new System.Windows.Forms.ComboBox();
            this.bindingSourceComunidades = new System.Windows.Forms.BindingSource(this.components);
            this.labelComunidad = new System.Windows.Forms.Label();
            this.comboBoxProvincia = new System.Windows.Forms.ComboBox();
            this.bindingSourceProvincias = new System.Windows.Forms.BindingSource(this.components);
            this.labelProvincia = new System.Windows.Forms.Label();
            this.labelCodigoPostal = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.buttonUpLoad = new System.Windows.Forms.Button();
            this.groupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProvincias)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAlmacenar
            // 
            this.buttonAlmacenar.Location = new System.Drawing.Point(853, 461);
            this.buttonAlmacenar.Name = "buttonAlmacenar";
            this.buttonAlmacenar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlmacenar.TabIndex = 102;
            this.buttonAlmacenar.Text = "Almacenar";
            this.buttonAlmacenar.UseVisualStyleBackColor = true;
            this.buttonAlmacenar.Click += new System.EventHandler(this.buttonAlmacenar_Click);
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.textBoxRGPD);
            this.groupBoxDatos.Controls.Add(this.labelRGPD);
            this.groupBoxDatos.Controls.Add(this.textBoxCIF);
            this.groupBoxDatos.Controls.Add(this.labelCIF);
            this.groupBoxDatos.Controls.Add(this.textBoxWeb);
            this.groupBoxDatos.Controls.Add(this.labelWeb);
            this.groupBoxDatos.Controls.Add(this.textBoxCodigoPostal);
            this.groupBoxDatos.Controls.Add(this.textBoxCiudad);
            this.groupBoxDatos.Controls.Add(this.labelCiudad);
            this.groupBoxDatos.Controls.Add(this.comboBoxComunidad);
            this.groupBoxDatos.Controls.Add(this.labelComunidad);
            this.groupBoxDatos.Controls.Add(this.comboBoxProvincia);
            this.groupBoxDatos.Controls.Add(this.labelProvincia);
            this.groupBoxDatos.Controls.Add(this.labelCodigoPostal);
            this.groupBoxDatos.Controls.Add(this.textBoxEmail);
            this.groupBoxDatos.Controls.Add(this.labelEmail);
            this.groupBoxDatos.Controls.Add(this.textBoxDireccion);
            this.groupBoxDatos.Controls.Add(this.labelDireccion);
            this.groupBoxDatos.Controls.Add(this.textBoxTelefono);
            this.groupBoxDatos.Controls.Add(this.labelTelefono);
            this.groupBoxDatos.Controls.Add(this.textBoxNombre);
            this.groupBoxDatos.Controls.Add(this.labelNombre);
            this.groupBoxDatos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxDatos.Location = new System.Drawing.Point(36, 27);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(892, 415);
            this.groupBoxDatos.TabIndex = 100;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos Asociación";
            // 
            // textBoxRGPD
            // 
            this.textBoxRGPD.Location = new System.Drawing.Point(455, 49);
            this.textBoxRGPD.Multiline = true;
            this.textBoxRGPD.Name = "textBoxRGPD";
            this.textBoxRGPD.Size = new System.Drawing.Size(420, 330);
            this.textBoxRGPD.TabIndex = 15;
            this.textBoxRGPD.TextChanged += new System.EventHandler(this.textBoxRGPD_TextChanged);
            // 
            // labelRGPD
            // 
            this.labelRGPD.AutoSize = true;
            this.labelRGPD.Location = new System.Drawing.Point(452, 32);
            this.labelRGPD.Name = "labelRGPD";
            this.labelRGPD.Size = new System.Drawing.Size(289, 13);
            this.labelRGPD.TabIndex = 14;
            this.labelRGPD.Text = "Texto RGPD (Reglamento General de Proteccion de Datos)";
            // 
            // textBoxCIF
            // 
            this.textBoxCIF.Location = new System.Drawing.Point(16, 103);
            this.textBoxCIF.Name = "textBoxCIF";
            this.textBoxCIF.Size = new System.Drawing.Size(200, 20);
            this.textBoxCIF.TabIndex = 13;
            this.textBoxCIF.TextChanged += new System.EventHandler(this.textBoxCIF_TextChanged);
            // 
            // labelCIF
            // 
            this.labelCIF.AutoSize = true;
            this.labelCIF.Location = new System.Drawing.Point(13, 86);
            this.labelCIF.Name = "labelCIF";
            this.labelCIF.Size = new System.Drawing.Size(23, 13);
            this.labelCIF.TabIndex = 12;
            this.labelCIF.Text = "CIF";
            // 
            // textBoxWeb
            // 
            this.textBoxWeb.Location = new System.Drawing.Point(16, 359);
            this.textBoxWeb.Name = "textBoxWeb";
            this.textBoxWeb.Size = new System.Drawing.Size(420, 20);
            this.textBoxWeb.TabIndex = 11;
            this.textBoxWeb.TextChanged += new System.EventHandler(this.textBoxWeb_TextChanged);
            // 
            // labelWeb
            // 
            this.labelWeb.AutoSize = true;
            this.labelWeb.Location = new System.Drawing.Point(13, 342);
            this.labelWeb.Name = "labelWeb";
            this.labelWeb.Size = new System.Drawing.Size(53, 13);
            this.labelWeb.TabIndex = 0;
            this.labelWeb.Text = "Sitio Web";
            // 
            // textBoxCodigoPostal
            // 
            this.textBoxCodigoPostal.Location = new System.Drawing.Point(336, 209);
            this.textBoxCodigoPostal.Name = "textBoxCodigoPostal";
            this.textBoxCodigoPostal.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoPostal.TabIndex = 7;
            this.textBoxCodigoPostal.TextChanged += new System.EventHandler(this.textBoxCodigoPostal_TextChanged);
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(16, 209);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(300, 20);
            this.textBoxCiudad.TabIndex = 6;
            this.textBoxCiudad.TextChanged += new System.EventHandler(this.textBoxCiudad_TextChanged);
            // 
            // labelCiudad
            // 
            this.labelCiudad.AutoSize = true;
            this.labelCiudad.Location = new System.Drawing.Point(13, 192);
            this.labelCiudad.Name = "labelCiudad";
            this.labelCiudad.Size = new System.Drawing.Size(40, 13);
            this.labelCiudad.TabIndex = 0;
            this.labelCiudad.Text = "Ciudad";
            // 
            // comboBoxComunidad
            // 
            this.comboBoxComunidad.DataSource = this.bindingSourceComunidades;
            this.comboBoxComunidad.DisplayMember = "nombre";
            this.comboBoxComunidad.FormattingEnabled = true;
            this.comboBoxComunidad.Location = new System.Drawing.Point(16, 260);
            this.comboBoxComunidad.Name = "comboBoxComunidad";
            this.comboBoxComunidad.Size = new System.Drawing.Size(200, 21);
            this.comboBoxComunidad.TabIndex = 9;
            this.comboBoxComunidad.ValueMember = "id";
            this.comboBoxComunidad.SelectedIndexChanged += new System.EventHandler(this.comboBoxComunidad_SelectedIndexChanged);
            // 
            // bindingSourceComunidades
            // 
            this.bindingSourceComunidades.DataSource = typeof(EEVAPPDsktp.CCAA);
            // 
            // labelComunidad
            // 
            this.labelComunidad.AutoSize = true;
            this.labelComunidad.Location = new System.Drawing.Point(12, 244);
            this.labelComunidad.Name = "labelComunidad";
            this.labelComunidad.Size = new System.Drawing.Size(60, 13);
            this.labelComunidad.TabIndex = 0;
            this.labelComunidad.Text = "Comunidad";
            // 
            // comboBoxProvincia
            // 
            this.comboBoxProvincia.DataSource = this.bindingSourceProvincias;
            this.comboBoxProvincia.DisplayMember = "nombre";
            this.comboBoxProvincia.FormattingEnabled = true;
            this.comboBoxProvincia.Location = new System.Drawing.Point(236, 260);
            this.comboBoxProvincia.Name = "comboBoxProvincia";
            this.comboBoxProvincia.Size = new System.Drawing.Size(200, 21);
            this.comboBoxProvincia.TabIndex = 8;
            this.comboBoxProvincia.ValueMember = "id";
            this.comboBoxProvincia.SelectedIndexChanged += new System.EventHandler(this.comboBoxProvincia_SelectedIndexChanged);
            // 
            // bindingSourceProvincias
            // 
            this.bindingSourceProvincias.DataSource = typeof(EEVAPPDsktp.PROVINCIAS);
            // 
            // labelProvincia
            // 
            this.labelProvincia.AutoSize = true;
            this.labelProvincia.Location = new System.Drawing.Point(233, 244);
            this.labelProvincia.Name = "labelProvincia";
            this.labelProvincia.Size = new System.Drawing.Size(51, 13);
            this.labelProvincia.TabIndex = 0;
            this.labelProvincia.Text = "Provincia";
            // 
            // labelCodigoPostal
            // 
            this.labelCodigoPostal.AutoSize = true;
            this.labelCodigoPostal.Location = new System.Drawing.Point(332, 193);
            this.labelCodigoPostal.Name = "labelCodigoPostal";
            this.labelCodigoPostal.Size = new System.Drawing.Size(72, 13);
            this.labelCodigoPostal.TabIndex = 0;
            this.labelCodigoPostal.Text = "Código Postal";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(16, 308);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(420, 20);
            this.textBoxEmail.TabIndex = 10;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(13, 291);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(16, 157);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(420, 20);
            this.textBoxDireccion.TabIndex = 5;
            this.textBoxDireccion.TextChanged += new System.EventHandler(this.textBoxDireccion_TextChanged);
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(13, 140);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(52, 13);
            this.labelDireccion.TabIndex = 0;
            this.labelDireccion.Text = "Direccion";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(235, 103);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(200, 20);
            this.textBoxTelefono.TabIndex = 3;
            this.textBoxTelefono.TextChanged += new System.EventHandler(this.textBoxTelefono_TextChanged);
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(232, 86);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(49, 13);
            this.labelTelefono.TabIndex = 0;
            this.labelTelefono.Text = "Teléfono";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(16, 49);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(420, 20);
            this.textBoxNombre.TabIndex = 2;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(13, 32);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // buttonUpLoad
            // 
            this.buttonUpLoad.Location = new System.Drawing.Point(36, 461);
            this.buttonUpLoad.Name = "buttonUpLoad";
            this.buttonUpLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonUpLoad.TabIndex = 99;
            this.buttonUpLoad.Text = "Actualizar";
            this.buttonUpLoad.UseVisualStyleBackColor = true;
            this.buttonUpLoad.Click += new System.EventHandler(this.buttonUpLoad_Click);
            // 
            // DatosAsociacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(958, 505);
            this.Controls.Add(this.buttonUpLoad);
            this.Controls.Add(this.buttonAlmacenar);
            this.Controls.Add(this.groupBoxDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatosAsociacion";
            this.Text = "Datos Asociación";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DatosAsociacion_FormClosing);
            this.Load += new System.EventHandler(this.DatosAsociacion_Load);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProvincias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAlmacenar;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.TextBox textBoxRGPD;
        private System.Windows.Forms.Label labelRGPD;
        private System.Windows.Forms.TextBox textBoxCIF;
        private System.Windows.Forms.Label labelCIF;
        private System.Windows.Forms.TextBox textBoxWeb;
        private System.Windows.Forms.Label labelWeb;
        private System.Windows.Forms.TextBox textBoxCodigoPostal;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.Label labelCiudad;
        private System.Windows.Forms.ComboBox comboBoxComunidad;
        private System.Windows.Forms.Label labelComunidad;
        private System.Windows.Forms.ComboBox comboBoxProvincia;
        private System.Windows.Forms.Label labelProvincia;
        private System.Windows.Forms.Label labelCodigoPostal;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.BindingSource bindingSourceComunidades;
        private System.Windows.Forms.BindingSource bindingSourceProvincias;
        private System.Windows.Forms.Button buttonUpLoad;
    }
}