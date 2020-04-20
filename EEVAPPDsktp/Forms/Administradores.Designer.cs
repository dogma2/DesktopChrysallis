namespace EEVAPPDsktp.Forms
{
    partial class Administradores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administradores));
            this.groupBoxLista = new System.Windows.Forms.GroupBox();
            this.listBoxLista = new System.Windows.Forms.ListBox();
            this.bindingSourceAdministradores = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.comboBoxComunidad = new System.Windows.Forms.ComboBox();
            this.bindingSourceComunidades = new System.Windows.Forms.BindingSource(this.components);
            this.labelComunidad = new System.Windows.Forms.Label();
            this.comboBoxProvincia = new System.Windows.Forms.ComboBox();
            this.bindingSourceProvincias = new System.Windows.Forms.BindingSource(this.components);
            this.labelProvincia = new System.Windows.Forms.Label();
            this.comboBoxDelegacion = new System.Windows.Forms.ComboBox();
            this.bindingSourceDelegaciones = new System.Windows.Forms.BindingSource(this.components);
            this.labelDelegacion = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.checkBoxMaster = new System.Windows.Forms.CheckBox();
            this.checkBoxActivado = new System.Windows.Forms.CheckBox();
            this.labelMaster = new System.Windows.Forms.Label();
            this.labelActivado = new System.Windows.Forms.Label();
            this.textBoxClave = new System.Windows.Forms.TextBox();
            this.labelClave = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonAlmacenar = new System.Windows.Forms.Button();
            this.groupBoxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAdministradores)).BeginInit();
            this.groupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProvincias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDelegaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxLista
            // 
            this.groupBoxLista.Controls.Add(this.listBoxLista);
            this.groupBoxLista.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxLista.Location = new System.Drawing.Point(32, 36);
            this.groupBoxLista.Name = "groupBoxLista";
            this.groupBoxLista.Size = new System.Drawing.Size(216, 259);
            this.groupBoxLista.TabIndex = 0;
            this.groupBoxLista.TabStop = false;
            this.groupBoxLista.Text = "Lista de Administradores";
            // 
            // listBoxLista
            // 
            this.listBoxLista.DataSource = this.bindingSourceAdministradores;
            this.listBoxLista.DisplayMember = "nickname";
            this.listBoxLista.FormattingEnabled = true;
            this.listBoxLista.Location = new System.Drawing.Point(7, 20);
            this.listBoxLista.Name = "listBoxLista";
            this.listBoxLista.Size = new System.Drawing.Size(203, 225);
            this.listBoxLista.TabIndex = 1;
            this.listBoxLista.ValueMember = "id";
            this.listBoxLista.SelectedIndexChanged += new System.EventHandler(this.listBoxLista_SelectedIndexChanged);
            // 
            // bindingSourceAdministradores
            // 
            this.bindingSourceAdministradores.DataSource = typeof(EEVAPPDsktp.DSKTUSERS);
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.textBoxId);
            this.groupBoxDatos.Controls.Add(this.comboBoxComunidad);
            this.groupBoxDatos.Controls.Add(this.labelComunidad);
            this.groupBoxDatos.Controls.Add(this.comboBoxProvincia);
            this.groupBoxDatos.Controls.Add(this.labelProvincia);
            this.groupBoxDatos.Controls.Add(this.comboBoxDelegacion);
            this.groupBoxDatos.Controls.Add(this.labelDelegacion);
            this.groupBoxDatos.Controls.Add(this.textBoxEmail);
            this.groupBoxDatos.Controls.Add(this.labelEmail);
            this.groupBoxDatos.Controls.Add(this.textBoxNombre);
            this.groupBoxDatos.Controls.Add(this.labelNombre);
            this.groupBoxDatos.Controls.Add(this.checkBoxMaster);
            this.groupBoxDatos.Controls.Add(this.checkBoxActivado);
            this.groupBoxDatos.Controls.Add(this.labelMaster);
            this.groupBoxDatos.Controls.Add(this.labelActivado);
            this.groupBoxDatos.Controls.Add(this.textBoxClave);
            this.groupBoxDatos.Controls.Add(this.labelClave);
            this.groupBoxDatos.Controls.Add(this.textBoxUsuario);
            this.groupBoxDatos.Controls.Add(this.labelUsuario);
            this.groupBoxDatos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxDatos.Location = new System.Drawing.Point(276, 36);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(453, 259);
            this.groupBoxDatos.TabIndex = 0;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos Administrador";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(443, 9);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(10, 20);
            this.textBoxId.TabIndex = 0;
            this.textBoxId.Visible = false;
            // 
            // comboBoxComunidad
            // 
            this.comboBoxComunidad.DataSource = this.bindingSourceComunidades;
            this.comboBoxComunidad.DisplayMember = "nombre";
            this.comboBoxComunidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComunidad.FormattingEnabled = true;
            this.comboBoxComunidad.Location = new System.Drawing.Point(16, 208);
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
            this.labelComunidad.Location = new System.Drawing.Point(12, 192);
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
            this.comboBoxProvincia.Location = new System.Drawing.Point(238, 208);
            this.comboBoxProvincia.Name = "comboBoxProvincia";
            this.comboBoxProvincia.Size = new System.Drawing.Size(200, 21);
            this.comboBoxProvincia.TabIndex = 10;
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
            this.labelProvincia.Location = new System.Drawing.Point(235, 192);
            this.labelProvincia.Name = "labelProvincia";
            this.labelProvincia.Size = new System.Drawing.Size(51, 13);
            this.labelProvincia.TabIndex = 0;
            this.labelProvincia.Text = "Provincia";
            // 
            // comboBoxDelegacion
            // 
            this.comboBoxDelegacion.DataSource = this.bindingSourceDelegaciones;
            this.comboBoxDelegacion.DisplayMember = "nombre";
            this.comboBoxDelegacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDelegacion.FormattingEnabled = true;
            this.comboBoxDelegacion.Location = new System.Drawing.Point(235, 156);
            this.comboBoxDelegacion.Name = "comboBoxDelegacion";
            this.comboBoxDelegacion.Size = new System.Drawing.Size(200, 21);
            this.comboBoxDelegacion.TabIndex = 8;
            this.comboBoxDelegacion.ValueMember = "id";
            this.comboBoxDelegacion.SelectedIndexChanged += new System.EventHandler(this.comboBoxDelegacion_SelectedIndexChanged);
            // 
            // bindingSourceDelegaciones
            // 
            this.bindingSourceDelegaciones.DataSource = typeof(EEVAPPDsktp.DELEGACIONES);
            // 
            // labelDelegacion
            // 
            this.labelDelegacion.AutoSize = true;
            this.labelDelegacion.Location = new System.Drawing.Point(232, 140);
            this.labelDelegacion.Name = "labelDelegacion";
            this.labelDelegacion.Size = new System.Drawing.Size(61, 13);
            this.labelDelegacion.TabIndex = 0;
            this.labelDelegacion.Text = "Delegación";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(16, 156);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(200, 20);
            this.textBoxEmail.TabIndex = 7;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(13, 139);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(16, 104);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(420, 20);
            this.textBoxNombre.TabIndex = 6;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(13, 87);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // checkBoxMaster
            // 
            this.checkBoxMaster.AutoSize = true;
            this.checkBoxMaster.Location = new System.Drawing.Point(411, 58);
            this.checkBoxMaster.Name = "checkBoxMaster";
            this.checkBoxMaster.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMaster.TabIndex = 5;
            this.checkBoxMaster.UseVisualStyleBackColor = true;
            this.checkBoxMaster.CheckedChanged += new System.EventHandler(this.checkBoxMaster_CheckedChanged);
            // 
            // checkBoxActivado
            // 
            this.checkBoxActivado.AutoSize = true;
            this.checkBoxActivado.Location = new System.Drawing.Point(362, 57);
            this.checkBoxActivado.Name = "checkBoxActivado";
            this.checkBoxActivado.Size = new System.Drawing.Size(15, 14);
            this.checkBoxActivado.TabIndex = 4;
            this.checkBoxActivado.UseVisualStyleBackColor = true;
            this.checkBoxActivado.CheckedChanged += new System.EventHandler(this.checkBoxActivado_CheckedChanged);
            // 
            // labelMaster
            // 
            this.labelMaster.AutoSize = true;
            this.labelMaster.Location = new System.Drawing.Point(399, 37);
            this.labelMaster.Name = "labelMaster";
            this.labelMaster.Size = new System.Drawing.Size(39, 13);
            this.labelMaster.TabIndex = 0;
            this.labelMaster.Text = "Master";
            // 
            // labelActivado
            // 
            this.labelActivado.AutoSize = true;
            this.labelActivado.Location = new System.Drawing.Point(344, 37);
            this.labelActivado.Name = "labelActivado";
            this.labelActivado.Size = new System.Drawing.Size(49, 13);
            this.labelActivado.TabIndex = 0;
            this.labelActivado.Text = "Activado";
            // 
            // textBoxClave
            // 
            this.textBoxClave.Location = new System.Drawing.Point(185, 54);
            this.textBoxClave.Name = "textBoxClave";
            this.textBoxClave.PasswordChar = '*';
            this.textBoxClave.Size = new System.Drawing.Size(150, 20);
            this.textBoxClave.TabIndex = 3;
            this.textBoxClave.TextChanged += new System.EventHandler(this.textBoxClave_TextChanged);
            // 
            // labelClave
            // 
            this.labelClave.AutoSize = true;
            this.labelClave.Location = new System.Drawing.Point(182, 37);
            this.labelClave.Name = "labelClave";
            this.labelClave.Size = new System.Drawing.Size(34, 13);
            this.labelClave.TabIndex = 0;
            this.labelClave.Text = "Clave";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(16, 54);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(150, 20);
            this.textBoxUsuario.TabIndex = 2;
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(13, 37);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(43, 13);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuario";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(32, 316);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 99;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(276, 316);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 98;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonAlmacenar
            // 
            this.buttonAlmacenar.Location = new System.Drawing.Point(654, 316);
            this.buttonAlmacenar.Name = "buttonAlmacenar";
            this.buttonAlmacenar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlmacenar.TabIndex = 20;
            this.buttonAlmacenar.Text = "Almacenar";
            this.buttonAlmacenar.UseVisualStyleBackColor = true;
            this.buttonAlmacenar.Click += new System.EventHandler(this.buttonAlmacenar_Click);
            // 
            // Administradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(764, 365);
            this.Controls.Add(this.buttonAlmacenar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.groupBoxLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Administradores";
            this.Text = "Administradores del sistema";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Administradores_FormClosing);
            this.Load += new System.EventHandler(this.Administradores_Load);
            this.groupBoxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAdministradores)).EndInit();
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProvincias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDelegaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLista;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.ListBox listBoxLista;
        private System.Windows.Forms.ComboBox comboBoxComunidad;
        private System.Windows.Forms.Label labelComunidad;
        private System.Windows.Forms.ComboBox comboBoxProvincia;
        private System.Windows.Forms.Label labelProvincia;
        private System.Windows.Forms.ComboBox comboBoxDelegacion;
        private System.Windows.Forms.Label labelDelegacion;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.CheckBox checkBoxMaster;
        private System.Windows.Forms.CheckBox checkBoxActivado;
        private System.Windows.Forms.Label labelMaster;
        private System.Windows.Forms.Label labelActivado;
        private System.Windows.Forms.TextBox textBoxClave;
        private System.Windows.Forms.Label labelClave;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonAlmacenar;
        private System.Windows.Forms.BindingSource bindingSourceAdministradores;
        private System.Windows.Forms.BindingSource bindingSourceComunidades;
        private System.Windows.Forms.BindingSource bindingSourceProvincias;
        private System.Windows.Forms.BindingSource bindingSourceDelegaciones;
        private System.Windows.Forms.TextBox textBoxId;
    }
}