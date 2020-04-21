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
            this.comboBoxProvincia = new System.Windows.Forms.ComboBox();
            this.bindingSourceDelegaciones = new System.Windows.Forms.BindingSource(this.components);
            this.labelDelegacion = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.checkBoxActivado = new System.Windows.Forms.CheckBox();
            this.labelActivado = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelCodigoUsuario = new System.Windows.Forms.Label();
            this.menuStripOpciones = new System.Windows.Forms.MenuStrip();
            this.SalirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxComunidadA = new System.Windows.Forms.ComboBox();
            this.CheckBoxGlobal = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDelegaciones)).BeginInit();
            this.menuStripOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAlmacenar
            // 
            this.buttonAlmacenar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAlmacenar.Location = new System.Drawing.Point(790, 345);
            this.buttonAlmacenar.Name = "buttonAlmacenar";
            this.buttonAlmacenar.Size = new System.Drawing.Size(96, 28);
            this.buttonAlmacenar.TabIndex = 99;
            this.buttonAlmacenar.Text = "Almacenar";
            this.buttonAlmacenar.UseVisualStyleBackColor = true;
            this.buttonAlmacenar.Click += new System.EventHandler(this.buttonAlmacenar_Click);
            // 
            // comboBoxProvincia
            // 
            this.comboBoxProvincia.DataSource = this.bindingSourceDelegaciones;
            this.comboBoxProvincia.DisplayMember = "nombre";
            this.comboBoxProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProvincia.FormattingEnabled = true;
            this.comboBoxProvincia.Location = new System.Drawing.Point(686, 243);
            this.comboBoxProvincia.Name = "comboBoxProvincia";
            this.comboBoxProvincia.Size = new System.Drawing.Size(198, 21);
            this.comboBoxProvincia.TabIndex = 12;
            this.comboBoxProvincia.ValueMember = "id";
            // 
            // bindingSourceDelegaciones
            // 
            this.bindingSourceDelegaciones.DataSource = typeof(EEVAPPDsktp.DELEGACIONES);
            // 
            // labelDelegacion
            // 
            this.labelDelegacion.AutoSize = true;
            this.labelDelegacion.Location = new System.Drawing.Point(683, 227);
            this.labelDelegacion.Name = "labelDelegacion";
            this.labelDelegacion.Size = new System.Drawing.Size(51, 13);
            this.labelDelegacion.TabIndex = 0;
            this.labelDelegacion.Text = "Provincia";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(33, 113);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(851, 96);
            this.textBoxDescripcion.TabIndex = 11;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(30, 97);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(63, 13);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Descripción";
            // 
            // checkBoxActivado
            // 
            this.checkBoxActivado.AutoSize = true;
            this.checkBoxActivado.Location = new System.Drawing.Point(856, 62);
            this.checkBoxActivado.Name = "checkBoxActivado";
            this.checkBoxActivado.Size = new System.Drawing.Size(15, 14);
            this.checkBoxActivado.TabIndex = 13;
            this.checkBoxActivado.UseVisualStyleBackColor = true;
            // 
            // labelActivado
            // 
            this.labelActivado.AutoSize = true;
            this.labelActivado.Location = new System.Drawing.Point(838, 42);
            this.labelActivado.Name = "labelActivado";
            this.labelActivado.Size = new System.Drawing.Size(49, 13);
            this.labelActivado.TabIndex = 0;
            this.labelActivado.Text = "Activado";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(33, 62);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(780, 20);
            this.textBoxNombre.TabIndex = 10;
            // 
            // labelCodigoUsuario
            // 
            this.labelCodigoUsuario.AutoSize = true;
            this.labelCodigoUsuario.Location = new System.Drawing.Point(30, 46);
            this.labelCodigoUsuario.Name = "labelCodigoUsuario";
            this.labelCodigoUsuario.Size = new System.Drawing.Size(44, 13);
            this.labelCodigoUsuario.TabIndex = 0;
            this.labelCodigoUsuario.Text = "Nombre";
            // 
            // menuStripOpciones
            // 
            this.menuStripOpciones.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuStripOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SalirToolStripMenuItem});
            this.menuStripOpciones.Location = new System.Drawing.Point(0, 0);
            this.menuStripOpciones.Name = "menuStripOpciones";
            this.menuStripOpciones.Size = new System.Drawing.Size(908, 24);
            this.menuStripOpciones.TabIndex = 100;
            this.menuStripOpciones.Text = "menuStrip1";
            // 
            // SalirToolStripMenuItem
            // 
            this.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            //this.SalirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SalirToolStripMenuItem.Image")));
            this.SalirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem";
            this.SalirToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.SalirToolStripMenuItem.Text = "Salir";
            this.SalirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 101;
            this.label1.Text = "Ciudad";
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(33, 245);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(227, 20);
            this.textBoxCiudad.TabIndex = 102;
            // 
            // textBoxCodigoPostal
            // 
            this.textBoxCodigoPostal.Location = new System.Drawing.Point(291, 246);
            this.textBoxCodigoPostal.Name = "textBoxCodigoPostal";
            this.textBoxCodigoPostal.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoPostal.TabIndex = 103;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 104;
            this.label2.Text = "Código Postal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 106;
            this.label3.Text = "Comunidad Autonóma";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(33, 300);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(283, 20);
            this.textBoxEmail.TabIndex = 107;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 108;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 110;
            this.label5.Text = "Teléfono";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(354, 300);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(233, 20);
            this.textBoxTelefono.TabIndex = 109;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(616, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 112;
            this.label6.Text = "Persona Contacto";
            // 
            // textBoxPersoa
            // 
            this.textBoxPersoa.Location = new System.Drawing.Point(619, 300);
            this.textBoxPersoa.Name = "textBoxPersoa";
            this.textBoxPersoa.Size = new System.Drawing.Size(265, 20);
            this.textBoxPersoa.TabIndex = 111;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(665, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 28);
            this.button1.TabIndex = 113;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxComunidadA
            // 
            this.comboBoxComunidadA.DataSource = this.bindingSourceDelegaciones;
            this.comboBoxComunidadA.DisplayMember = "nombre";
            this.comboBoxComunidadA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComunidadA.FormattingEnabled = true;
            this.comboBoxComunidadA.Location = new System.Drawing.Point(423, 244);
            this.comboBoxComunidadA.Name = "comboBoxComunidadA";
            this.comboBoxComunidadA.Size = new System.Drawing.Size(225, 21);
            this.comboBoxComunidadA.TabIndex = 114;
            this.comboBoxComunidadA.ValueMember = "id";
            this.comboBoxComunidadA.SelectedIndexChanged += new System.EventHandler(this.comboBoxComunidadA_SelectedIndexChanged);
            // 
            // CheckBoxGlobal
            // 
            this.CheckBoxGlobal.AutoSize = true;
            this.CheckBoxGlobal.Location = new System.Drawing.Point(594, 357);
            this.CheckBoxGlobal.Name = "CheckBoxGlobal";
            this.CheckBoxGlobal.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxGlobal.TabIndex = 116;
            this.CheckBoxGlobal.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(550, 338);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 115;
            this.label12.Text = "Dato Interes Global";
            // 
            // DatosInteresAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(908, 389);
            this.Controls.Add(this.CheckBoxGlobal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxComunidadA);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.menuStripOpciones);
            this.Controls.Add(this.buttonAlmacenar);
            this.Controls.Add(this.comboBoxProvincia);
            this.Controls.Add(this.labelDelegacion);
            this.Controls.Add(this.checkBoxActivado);
            this.Controls.Add(this.labelActivado);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.labelCodigoUsuario);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatosInteresAdd";
            this.Text = "SociosForm";
            this.Load += new System.EventHandler(this.DatosInteresAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDelegaciones)).EndInit();
            this.menuStripOpciones.ResumeLayout(false);
            this.menuStripOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAlmacenar;
        private System.Windows.Forms.ComboBox comboBoxProvincia;
        private System.Windows.Forms.Label labelDelegacion;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.CheckBox checkBoxActivado;
        private System.Windows.Forms.Label labelActivado;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelCodigoUsuario;
        private System.Windows.Forms.BindingSource bindingSourceDelegaciones;
        private System.Windows.Forms.MenuStrip menuStripOpciones;
        private System.Windows.Forms.ToolStripMenuItem SalirToolStripMenuItem;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxComunidadA;
        private System.Windows.Forms.CheckBox CheckBoxGlobal;
        private System.Windows.Forms.Label label12;
    }
}