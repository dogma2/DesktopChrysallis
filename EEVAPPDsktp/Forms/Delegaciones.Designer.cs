namespace EEVAPPDsktp.Forms
{
    partial class Delegaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delegaciones));
            this.buttonAlmacenar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxContacto = new System.Windows.Forms.TextBox();
            this.labelContacto = new System.Windows.Forms.Label();
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
            this.checkBoxActivado = new System.Windows.Forms.CheckBox();
            this.labelActivado = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.groupBoxLista = new System.Windows.Forms.GroupBox();
            this.listBoxLista = new System.Windows.Forms.ListBox();
            this.bindingSourceDelegaciones = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProvincias)).BeginInit();
            this.groupBoxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDelegaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAlmacenar
            // 
            this.buttonAlmacenar.Location = new System.Drawing.Point(654, 409);
            this.buttonAlmacenar.Name = "buttonAlmacenar";
            this.buttonAlmacenar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlmacenar.TabIndex = 20;
            this.buttonAlmacenar.Text = "Almacenar";
            this.buttonAlmacenar.UseVisualStyleBackColor = true;
            this.buttonAlmacenar.Click += new System.EventHandler(this.buttonAlmacenar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(276, 409);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 98;
            this.buttonAgregar.Text = "Nuevo";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(32, 409);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 99;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.textBoxId);
            this.groupBoxDatos.Controls.Add(this.textBoxContacto);
            this.groupBoxDatos.Controls.Add(this.labelContacto);
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
            this.groupBoxDatos.Controls.Add(this.checkBoxActivado);
            this.groupBoxDatos.Controls.Add(this.labelActivado);
            this.groupBoxDatos.Controls.Add(this.textBoxTelefono);
            this.groupBoxDatos.Controls.Add(this.labelTelefono);
            this.groupBoxDatos.Controls.Add(this.textBoxNombre);
            this.groupBoxDatos.Controls.Add(this.labelNombre);
            this.groupBoxDatos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxDatos.Location = new System.Drawing.Point(276, 36);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(453, 353);
            this.groupBoxDatos.TabIndex = 0;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos Delegaciones";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(443, 9);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(10, 20);
            this.textBoxId.TabIndex = 0;
            this.textBoxId.Visible = false;
            // 
            // textBoxContacto
            // 
            this.textBoxContacto.Location = new System.Drawing.Point(16, 301);
            this.textBoxContacto.Name = "textBoxContacto";
            this.textBoxContacto.Size = new System.Drawing.Size(420, 20);
            this.textBoxContacto.TabIndex = 11;
            this.textBoxContacto.TextChanged += new System.EventHandler(this.textBoxContacto_TextChanged);
            // 
            // labelContacto
            // 
            this.labelContacto.AutoSize = true;
            this.labelContacto.Location = new System.Drawing.Point(17, 285);
            this.labelContacto.Name = "labelContacto";
            this.labelContacto.Size = new System.Drawing.Size(50, 13);
            this.labelContacto.TabIndex = 0;
            this.labelContacto.Text = "Contacto";
            // 
            // textBoxCodigoPostal
            // 
            this.textBoxCodigoPostal.Location = new System.Drawing.Point(336, 151);
            this.textBoxCodigoPostal.Name = "textBoxCodigoPostal";
            this.textBoxCodigoPostal.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoPostal.TabIndex = 7;
            this.textBoxCodigoPostal.TextChanged += new System.EventHandler(this.textBoxCodigoPostal_TextChanged);
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(16, 151);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(300, 20);
            this.textBoxCiudad.TabIndex = 6;
            this.textBoxCiudad.TextChanged += new System.EventHandler(this.textBoxCiudad_TextChanged);
            // 
            // labelCiudad
            // 
            this.labelCiudad.AutoSize = true;
            this.labelCiudad.Location = new System.Drawing.Point(17, 135);
            this.labelCiudad.Name = "labelCiudad";
            this.labelCiudad.Size = new System.Drawing.Size(40, 13);
            this.labelCiudad.TabIndex = 0;
            this.labelCiudad.Text = "Ciudad";
            // 
            // comboBoxComunidad
            // 
            this.comboBoxComunidad.DataSource = this.bindingSourceComunidades;
            this.comboBoxComunidad.DisplayMember = "nombre";
            this.comboBoxComunidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComunidad.FormattingEnabled = true;
            this.comboBoxComunidad.ItemHeight = 13;
            this.comboBoxComunidad.Location = new System.Drawing.Point(16, 201);
            this.comboBoxComunidad.Name = "comboBoxComunidad";
            this.comboBoxComunidad.Size = new System.Drawing.Size(200, 21);
            this.comboBoxComunidad.TabIndex = 8;
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
            this.labelComunidad.Location = new System.Drawing.Point(15, 185);
            this.labelComunidad.Name = "labelComunidad";
            this.labelComunidad.Size = new System.Drawing.Size(60, 13);
            this.labelComunidad.TabIndex = 0;
            this.labelComunidad.Text = "Comunidad";
            // 
            // comboBoxProvincia
            // 
            this.comboBoxProvincia.DataSource = this.bindingSourceProvincias;
            this.comboBoxProvincia.DisplayMember = "nombre";
            this.comboBoxProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProvincia.FormattingEnabled = true;
            this.comboBoxProvincia.Location = new System.Drawing.Point(236, 201);
            this.comboBoxProvincia.Name = "comboBoxProvincia";
            this.comboBoxProvincia.Size = new System.Drawing.Size(200, 21);
            this.comboBoxProvincia.TabIndex = 9;
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
            this.labelProvincia.Location = new System.Drawing.Point(233, 185);
            this.labelProvincia.Name = "labelProvincia";
            this.labelProvincia.Size = new System.Drawing.Size(51, 13);
            this.labelProvincia.TabIndex = 0;
            this.labelProvincia.Text = "Provincia";
            // 
            // labelCodigoPostal
            // 
            this.labelCodigoPostal.AutoSize = true;
            this.labelCodigoPostal.Location = new System.Drawing.Point(333, 135);
            this.labelCodigoPostal.Name = "labelCodigoPostal";
            this.labelCodigoPostal.Size = new System.Drawing.Size(72, 13);
            this.labelCodigoPostal.TabIndex = 0;
            this.labelCodigoPostal.Text = "Código Postal";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(16, 250);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(420, 20);
            this.textBoxEmail.TabIndex = 10;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(15, 234);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(16, 99);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(420, 20);
            this.textBoxDireccion.TabIndex = 5;
            this.textBoxDireccion.TextChanged += new System.EventHandler(this.textBoxDireccion_TextChanged);
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(13, 82);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(52, 13);
            this.labelDireccion.TabIndex = 0;
            this.labelDireccion.Text = "Direccion";
            // 
            // checkBoxActivado
            // 
            this.checkBoxActivado.AutoSize = true;
            this.checkBoxActivado.Location = new System.Drawing.Point(405, 52);
            this.checkBoxActivado.Name = "checkBoxActivado";
            this.checkBoxActivado.Size = new System.Drawing.Size(15, 14);
            this.checkBoxActivado.TabIndex = 4;
            this.checkBoxActivado.UseVisualStyleBackColor = true;
            this.checkBoxActivado.CheckedChanged += new System.EventHandler(this.checkBoxActivado_CheckedChanged);
            // 
            // labelActivado
            // 
            this.labelActivado.AutoSize = true;
            this.labelActivado.Location = new System.Drawing.Point(387, 32);
            this.labelActivado.Name = "labelActivado";
            this.labelActivado.Size = new System.Drawing.Size(49, 13);
            this.labelActivado.TabIndex = 0;
            this.labelActivado.Text = "Activado";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(206, 49);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(170, 20);
            this.textBoxTelefono.TabIndex = 3;
            this.textBoxTelefono.TextChanged += new System.EventHandler(this.textBoxTelefono_TextChanged);
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(203, 32);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(49, 13);
            this.labelTelefono.TabIndex = 0;
            this.labelTelefono.Text = "Teléfono";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(16, 49);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(170, 20);
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
            // groupBoxLista
            // 
            this.groupBoxLista.Controls.Add(this.listBoxLista);
            this.groupBoxLista.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxLista.Location = new System.Drawing.Point(32, 36);
            this.groupBoxLista.Name = "groupBoxLista";
            this.groupBoxLista.Size = new System.Drawing.Size(216, 353);
            this.groupBoxLista.TabIndex = 0;
            this.groupBoxLista.TabStop = false;
            this.groupBoxLista.Text = "Lista de Delegaciones";
            // 
            // listBoxLista
            // 
            this.listBoxLista.DataSource = this.bindingSourceDelegaciones;
            this.listBoxLista.DisplayMember = "nombre";
            this.listBoxLista.FormattingEnabled = true;
            this.listBoxLista.Location = new System.Drawing.Point(7, 20);
            this.listBoxLista.Name = "listBoxLista";
            this.listBoxLista.Size = new System.Drawing.Size(203, 316);
            this.listBoxLista.TabIndex = 1;
            this.listBoxLista.ValueMember = "id";
            this.listBoxLista.SelectedIndexChanged += new System.EventHandler(this.listBoxLista_SelectedIndexChanged);
            // 
            // bindingSourceDelegaciones
            // 
            this.bindingSourceDelegaciones.DataSource = typeof(EEVAPPDsktp.DELEGACIONES);
            // 
            // Delegaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(767, 456);
            this.Controls.Add(this.buttonAlmacenar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.groupBoxLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Delegaciones";
            this.Text = "Delegaciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Delegaciones_FormClosing);
            this.Load += new System.EventHandler(this.Delegaciones_Load);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProvincias)).EndInit();
            this.groupBoxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDelegaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAlmacenar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.ComboBox comboBoxComunidad;
        private System.Windows.Forms.Label labelComunidad;
        private System.Windows.Forms.ComboBox comboBoxProvincia;
        private System.Windows.Forms.Label labelProvincia;
        private System.Windows.Forms.Label labelCodigoPostal;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.CheckBox checkBoxActivado;
        private System.Windows.Forms.Label labelActivado;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.GroupBox groupBoxLista;
        private System.Windows.Forms.ListBox listBoxLista;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.Label labelCiudad;
        private System.Windows.Forms.TextBox textBoxContacto;
        private System.Windows.Forms.Label labelContacto;
        private System.Windows.Forms.TextBox textBoxCodigoPostal;
        private System.Windows.Forms.BindingSource bindingSourceComunidades;
        private System.Windows.Forms.BindingSource bindingSourceProvincias;
        private System.Windows.Forms.BindingSource bindingSourceDelegaciones;
        private System.Windows.Forms.TextBox textBoxId;
    }
}