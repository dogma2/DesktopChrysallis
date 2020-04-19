namespace EEVAPPDsktp.Forms
{
    partial class Eventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eventos));
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.comboBoxDelegacion = new System.Windows.Forms.ComboBox();
            this.dataGridViewEventos = new System.Windows.Forms.DataGridView();
            this.delegacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceEventos = new System.Windows.Forms.BindingSource(this.components);
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelCiudad = new System.Windows.Forms.Label();
            this.labelDelegacion = new System.Windows.Forms.Label();
            this.labelNuevo = new System.Windows.Forms.Label();
            this.labelModificar = new System.Windows.Forms.Label();
            this.labelEliminar = new System.Windows.Forms.Label();
            this.labelSalir = new System.Windows.Forms.Label();
            this.fechainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eVENTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceDelegaciones = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVENTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDelegaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(16, 59);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(308, 20);
            this.textBoxTitulo.TabIndex = 1;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboBoxEstado.Location = new System.Drawing.Point(346, 59);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEstado.TabIndex = 2;
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(491, 60);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(100, 20);
            this.textBoxCiudad.TabIndex = 3;
            // 
            // comboBoxDelegacion
            // 
            this.comboBoxDelegacion.DataSource = this.bindingSourceDelegaciones;
            this.comboBoxDelegacion.DisplayMember = "nombre";
            this.comboBoxDelegacion.FormattingEnabled = true;
            this.comboBoxDelegacion.Location = new System.Drawing.Point(613, 60);
            this.comboBoxDelegacion.Name = "comboBoxDelegacion";
            this.comboBoxDelegacion.Size = new System.Drawing.Size(163, 21);
            this.comboBoxDelegacion.TabIndex = 4;
            this.comboBoxDelegacion.ValueMember = "id";
            // 
            // dataGridViewEventos
            // 
            this.dataGridViewEventos.AllowUserToAddRows = false;
            this.dataGridViewEventos.AutoGenerateColumns = false;
            this.dataGridViewEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechainicioDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.ciudadDataGridViewTextBoxColumn,
            this.delegacion});
            this.dataGridViewEventos.DataSource = this.eVENTOSBindingSource;
            this.dataGridViewEventos.Location = new System.Drawing.Point(13, 87);
            this.dataGridViewEventos.Name = "dataGridViewEventos";
            this.dataGridViewEventos.ReadOnly = true;
            this.dataGridViewEventos.Size = new System.Drawing.Size(775, 351);
            this.dataGridViewEventos.TabIndex = 5;
            // 
            // delegacion
            // 
            this.delegacion.DataPropertyName = "id";
            this.delegacion.HeaderText = "Delegación";
            this.delegacion.Name = "delegacion";
            this.delegacion.ReadOnly = true;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTitulo.Location = new System.Drawing.Point(13, 39);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(77, 13);
            this.labelTitulo.TabIndex = 7;
            this.labelTitulo.Text = "Filtrar por título";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEstado.Location = new System.Drawing.Point(346, 39);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(40, 13);
            this.labelEstado.TabIndex = 8;
            this.labelEstado.Text = "Estado";
            // 
            // labelCiudad
            // 
            this.labelCiudad.AutoSize = true;
            this.labelCiudad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCiudad.Location = new System.Drawing.Point(491, 41);
            this.labelCiudad.Name = "labelCiudad";
            this.labelCiudad.Size = new System.Drawing.Size(85, 13);
            this.labelCiudad.TabIndex = 9;
            this.labelCiudad.Text = "Filtrar por ciudad";
            // 
            // labelDelegacion
            // 
            this.labelDelegacion.AutoSize = true;
            this.labelDelegacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDelegacion.Location = new System.Drawing.Point(613, 39);
            this.labelDelegacion.Name = "labelDelegacion";
            this.labelDelegacion.Size = new System.Drawing.Size(163, 13);
            this.labelDelegacion.TabIndex = 10;
            this.labelDelegacion.Text = "Filtrar por delegación de Chysallis";
            // 
            // labelNuevo
            // 
            this.labelNuevo.AutoSize = true;
            this.labelNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNuevo.Location = new System.Drawing.Point(13, 13);
            this.labelNuevo.Name = "labelNuevo";
            this.labelNuevo.Size = new System.Drawing.Size(39, 13);
            this.labelNuevo.TabIndex = 11;
            this.labelNuevo.Text = "Nuevo";
            this.labelNuevo.Click += new System.EventHandler(this.labelNuevo_Click);
            // 
            // labelModificar
            // 
            this.labelModificar.AutoSize = true;
            this.labelModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelModificar.Location = new System.Drawing.Point(77, 13);
            this.labelModificar.Name = "labelModificar";
            this.labelModificar.Size = new System.Drawing.Size(50, 13);
            this.labelModificar.TabIndex = 12;
            this.labelModificar.Text = "Modificar";
            // 
            // labelEliminar
            // 
            this.labelEliminar.AutoSize = true;
            this.labelEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEliminar.Location = new System.Drawing.Point(149, 12);
            this.labelEliminar.Name = "labelEliminar";
            this.labelEliminar.Size = new System.Drawing.Size(43, 13);
            this.labelEliminar.TabIndex = 13;
            this.labelEliminar.Text = "Eliminar";
            this.labelEliminar.Click += new System.EventHandler(this.labelEliminar_Click);
            // 
            // labelSalir
            // 
            this.labelSalir.AutoSize = true;
            this.labelSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSalir.Location = new System.Drawing.Point(210, 13);
            this.labelSalir.Name = "labelSalir";
            this.labelSalir.Size = new System.Drawing.Size(27, 13);
            this.labelSalir.TabIndex = 14;
            this.labelSalir.Text = "Salir";
            this.labelSalir.Click += new System.EventHandler(this.labelSalir_Click);
            // 
            // fechainicioDataGridViewTextBoxColumn
            // 
            this.fechainicioDataGridViewTextBoxColumn.DataPropertyName = "fechainicio";
            this.fechainicioDataGridViewTextBoxColumn.HeaderText = "Fecha inicio";
            this.fechainicioDataGridViewTextBoxColumn.Name = "fechainicioDataGridViewTextBoxColumn";
            this.fechainicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ciudadDataGridViewTextBoxColumn
            // 
            this.ciudadDataGridViewTextBoxColumn.DataPropertyName = "ciudad";
            this.ciudadDataGridViewTextBoxColumn.HeaderText = "Ciudad";
            this.ciudadDataGridViewTextBoxColumn.Name = "ciudadDataGridViewTextBoxColumn";
            this.ciudadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eVENTOSBindingSource
            // 
            this.eVENTOSBindingSource.DataSource = typeof(EEVAPPDsktp.EVENTOS);
            // 
            // bindingSourceDelegaciones
            // 
            this.bindingSourceDelegaciones.DataSource = typeof(EEVAPPDsktp.DELEGACIONES);
            // 
            // Eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSalir);
            this.Controls.Add(this.labelEliminar);
            this.Controls.Add(this.labelModificar);
            this.Controls.Add(this.labelNuevo);
            this.Controls.Add(this.labelDelegacion);
            this.Controls.Add(this.labelCiudad);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.dataGridViewEventos);
            this.Controls.Add(this.comboBoxDelegacion);
            this.Controls.Add(this.textBoxCiudad);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.textBoxTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Eventos";
            this.Text = "Eventos";
            this.Load += new System.EventHandler(this.Eventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVENTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDelegaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.ComboBox comboBoxDelegacion;
        private System.Windows.Forms.DataGridView dataGridViewEventos;
        private System.Windows.Forms.BindingSource eVENTOSBindingSource;
        private System.Windows.Forms.BindingSource bindingSourceEventos;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelCiudad;
        private System.Windows.Forms.Label labelDelegacion;
        private System.Windows.Forms.Label labelNuevo;
        private System.Windows.Forms.Label labelModificar;
        private System.Windows.Forms.Label labelEliminar;
        private System.Windows.Forms.Label labelSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delegacion;
        private System.Windows.Forms.BindingSource bindingSourceDelegaciones;
    }
}