namespace EEVAPPDsktp.Forms
{
    partial class DatosInteresAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosInteresAdd));
            this.buttonAlmacenar = new System.Windows.Forms.Button();
            this.labelDelegacion = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.checkBoxActivado = new System.Windows.Forms.CheckBox();
            this.labelActivado = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelCodigoUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.textBoxCodigoPostal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPersoa = new System.Windows.Forms.TextBox();
            this.CheckBoxGlobal = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bindingSourceDelegaciones = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceComunidades = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceProvincias = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxDelegacion = new System.Windows.Forms.ComboBox();
            this.comboBoxComunidad = new System.Windows.Forms.ComboBox();
            this.comboBoxProvincia = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDelegaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProvincias)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAlmacenar
            // 
            this.buttonAlmacenar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAlmacenar.Location = new System.Drawing.Point(811, 303);
            this.buttonAlmacenar.Name = "buttonAlmacenar";
            this.buttonAlmacenar.Size = new System.Drawing.Size(96, 28);
            this.buttonAlmacenar.TabIndex = 99;
            this.buttonAlmacenar.Text = "Almacenar";
            this.buttonAlmacenar.UseVisualStyleBackColor = true;
            this.buttonAlmacenar.Click += new System.EventHandler(this.buttonAlmacenar_Click);
            // 
            // labelDelegacion
            // 
            this.labelDelegacion.AutoSize = true;
            this.labelDelegacion.Location = new System.Drawing.Point(513, 196);
            this.labelDelegacion.Name = "labelDelegacion";
            this.labelDelegacion.Size = new System.Drawing.Size(51, 13);
            this.labelDelegacion.TabIndex = 0;
            this.labelDelegacion.Text = "Provincia";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(13, 93);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(894, 96);
            this.textBoxDescripcion.TabIndex = 11;
            this.textBoxDescripcion.TextChanged += new System.EventHandler(this.textBoxDescripcion_TextChanged);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(10, 77);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(63, 13);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Descripción";
            // 
            // checkBoxActivado
            // 
            this.checkBoxActivado.AutoSize = true;
            this.checkBoxActivado.Location = new System.Drawing.Point(873, 47);
            this.checkBoxActivado.Name = "checkBoxActivado";
            this.checkBoxActivado.Size = new System.Drawing.Size(15, 14);
            this.checkBoxActivado.TabIndex = 13;
            this.checkBoxActivado.UseVisualStyleBackColor = true;
            this.checkBoxActivado.CheckedChanged += new System.EventHandler(this.checkBoxActivado_CheckedChanged);
            // 
            // labelActivado
            // 
            this.labelActivado.AutoSize = true;
            this.labelActivado.Location = new System.Drawing.Point(855, 27);
            this.labelActivado.Name = "labelActivado";
            this.labelActivado.Size = new System.Drawing.Size(49, 13);
            this.labelActivado.TabIndex = 0;
            this.labelActivado.Text = "Activado";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(13, 47);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(766, 20);
            this.textBoxNombre.TabIndex = 10;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // labelCodigoUsuario
            // 
            this.labelCodigoUsuario.AutoSize = true;
            this.labelCodigoUsuario.Location = new System.Drawing.Point(10, 31);
            this.labelCodigoUsuario.Name = "labelCodigoUsuario";
            this.labelCodigoUsuario.Size = new System.Drawing.Size(44, 13);
            this.labelCodigoUsuario.TabIndex = 0;
            this.labelCodigoUsuario.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 101;
            this.label1.Text = "Ciudad";
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(13, 213);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(194, 20);
            this.textBoxCiudad.TabIndex = 102;
            this.textBoxCiudad.TextChanged += new System.EventHandler(this.textBoxCiudad_TextChanged);
            // 
            // textBoxCodigoPostal
            // 
            this.textBoxCodigoPostal.Location = new System.Drawing.Point(227, 214);
            this.textBoxCodigoPostal.Name = "textBoxCodigoPostal";
            this.textBoxCodigoPostal.Size = new System.Drawing.Size(69, 20);
            this.textBoxCodigoPostal.TabIndex = 103;
            this.textBoxCodigoPostal.TextChanged += new System.EventHandler(this.textBoxCodigoPostal_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 104;
            this.label2.Text = "Código Postal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 106;
            this.label3.Text = "Comunidad Autonóma";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(13, 259);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(339, 20);
            this.textBoxEmail.TabIndex = 107;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 108;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 110;
            this.label5.Text = "Teléfono";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(377, 259);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(177, 20);
            this.textBoxTelefono.TabIndex = 109;
            this.textBoxTelefono.TextChanged += new System.EventHandler(this.textBoxTelefono_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(573, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 112;
            this.label6.Text = "Persona Contacto";
            // 
            // textBoxPersoa
            // 
            this.textBoxPersoa.Location = new System.Drawing.Point(576, 259);
            this.textBoxPersoa.Name = "textBoxPersoa";
            this.textBoxPersoa.Size = new System.Drawing.Size(331, 20);
            this.textBoxPersoa.TabIndex = 111;
            this.textBoxPersoa.TextChanged += new System.EventHandler(this.textBoxPersoa_TextChanged);
            // 
            // CheckBoxGlobal
            // 
            this.CheckBoxGlobal.AutoSize = true;
            this.CheckBoxGlobal.Location = new System.Drawing.Point(810, 47);
            this.CheckBoxGlobal.Name = "CheckBoxGlobal";
            this.CheckBoxGlobal.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxGlobal.TabIndex = 116;
            this.CheckBoxGlobal.UseVisualStyleBackColor = true;
            this.CheckBoxGlobal.CheckedChanged += new System.EventHandler(this.CheckBoxGlobal_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(798, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 115;
            this.label12.Text = "Global";
            // 
            // bindingSourceDelegaciones
            // 
            this.bindingSourceDelegaciones.DataSource = typeof(EEVAPPDsktp.DELEGACIONES);
            // 
            // bindingSourceComunidades
            // 
            this.bindingSourceComunidades.DataSource = typeof(EEVAPPDsktp.CCAA);
            // 
            // bindingSourceProvincias
            // 
            this.bindingSourceProvincias.DataSource = typeof(EEVAPPDsktp.PROVINCIAS);
            // 
            // comboBoxDelegacion
            // 
            this.comboBoxDelegacion.DataSource = this.bindingSourceDelegaciones;
            this.comboBoxDelegacion.DisplayMember = "nombre";
            this.comboBoxDelegacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDelegacion.FormattingEnabled = true;
            this.comboBoxDelegacion.Location = new System.Drawing.Point(733, 212);
            this.comboBoxDelegacion.Name = "comboBoxDelegacion";
            this.comboBoxDelegacion.Size = new System.Drawing.Size(174, 21);
            this.comboBoxDelegacion.TabIndex = 119;
            this.comboBoxDelegacion.ValueMember = "id";
            // 
            // comboBoxComunidad
            // 
            this.comboBoxComunidad.DataSource = this.bindingSourceComunidades;
            this.comboBoxComunidad.DisplayMember = "nombre";
            this.comboBoxComunidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComunidad.FormattingEnabled = true;
            this.comboBoxComunidad.ItemHeight = 13;
            this.comboBoxComunidad.Location = new System.Drawing.Point(318, 212);
            this.comboBoxComunidad.Name = "comboBoxComunidad";
            this.comboBoxComunidad.Size = new System.Drawing.Size(176, 21);
            this.comboBoxComunidad.TabIndex = 117;
            this.comboBoxComunidad.ValueMember = "id";
            this.comboBoxComunidad.SelectedIndexChanged += new System.EventHandler(this.comboBoxComunidad_SelectedIndexChanged);
            // 
            // comboBoxProvincia
            // 
            this.comboBoxProvincia.DataSource = this.bindingSourceProvincias;
            this.comboBoxProvincia.DisplayMember = "nombre";
            this.comboBoxProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProvincia.FormattingEnabled = true;
            this.comboBoxProvincia.Location = new System.Drawing.Point(516, 212);
            this.comboBoxProvincia.Name = "comboBoxProvincia";
            this.comboBoxProvincia.Size = new System.Drawing.Size(190, 21);
            this.comboBoxProvincia.TabIndex = 118;
            this.comboBoxProvincia.ValueMember = "id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(730, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 120;
            this.label7.Text = "Delegación";
            // 
            // DatosInteresAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(919, 369);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxDelegacion);
            this.Controls.Add(this.comboBoxComunidad);
            this.Controls.Add(this.comboBoxProvincia);
            this.Controls.Add(this.CheckBoxGlobal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPersoa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCodigoPostal);
            this.Controls.Add(this.textBoxCiudad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAlmacenar);
            this.Controls.Add(this.labelDelegacion);
            this.Controls.Add(this.checkBoxActivado);
            this.Controls.Add(this.labelActivado);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.labelCodigoUsuario);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatosInteresAdd";
            this.Text = "Datos Interés";
            this.Load += new System.EventHandler(this.DatosInteresAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDelegaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProvincias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAlmacenar;
        private System.Windows.Forms.Label labelDelegacion;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.CheckBox checkBoxActivado;
        private System.Windows.Forms.Label labelActivado;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelCodigoUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.TextBox textBoxCodigoPostal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPersoa;
        private System.Windows.Forms.CheckBox CheckBoxGlobal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource bindingSourceDelegaciones;
        private System.Windows.Forms.BindingSource bindingSourceComunidades;
        private System.Windows.Forms.BindingSource bindingSourceProvincias;
        private System.Windows.Forms.ComboBox comboBoxDelegacion;
        private System.Windows.Forms.ComboBox comboBoxComunidad;
        private System.Windows.Forms.ComboBox comboBoxProvincia;
        private System.Windows.Forms.Label label7;
    }
}