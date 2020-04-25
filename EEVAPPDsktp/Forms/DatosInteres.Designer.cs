namespace EEVAPPDsktp.Forms
{
    partial class DatosInteres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosInteres));
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewListaDatosInteres = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delegacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idprovinciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idccaaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctrlglobalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddelegacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddsktuserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCAADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROVINCIASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dELEGACIONESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dSKTUSERSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceDatosInteres = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.comboBoxDelegacion = new System.Windows.Forms.ComboBox();
            this.bindingSourceDelegaciones = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.groupBoxFiltros = new System.Windows.Forms.GroupBox();
            this.menuStripOpciones = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activadesactivaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaDatosInteres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDatosInteres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDelegaciones)).BeginInit();
            this.groupBoxFiltros.SuspendLayout();
            this.menuStripOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(9, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Lista de Datos de Interés";
            // 
            // dataGridViewListaDatosInteres
            // 
            this.dataGridViewListaDatosInteres.AllowDrop = true;
            this.dataGridViewListaDatosInteres.AllowUserToAddRows = false;
            this.dataGridViewListaDatosInteres.AllowUserToDeleteRows = false;
            this.dataGridViewListaDatosInteres.AutoGenerateColumns = false;
            this.dataGridViewListaDatosInteres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaDatosInteres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.strState,
            this.ciudadDataGridViewTextBoxColumn,
            this.Delegacion,
            this.idDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.cpDataGridViewTextBoxColumn,
            this.idprovinciaDataGridViewTextBoxColumn,
            this.idccaaDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.contactoDataGridViewTextBoxColumn,
            this.ctrlglobalDataGridViewTextBoxColumn,
            this.iddelegacionDataGridViewTextBoxColumn,
            this.iddsktuserDataGridViewTextBoxColumn,
            this.cCAADataGridViewTextBoxColumn,
            this.pROVINCIASDataGridViewTextBoxColumn,
            this.dELEGACIONESDataGridViewTextBoxColumn,
            this.dSKTUSERSDataGridViewTextBoxColumn});
            this.dataGridViewListaDatosInteres.DataSource = this.bindingSourceDatosInteres;
            this.dataGridViewListaDatosInteres.Location = new System.Drawing.Point(12, 145);
            this.dataGridViewListaDatosInteres.MultiSelect = false;
            this.dataGridViewListaDatosInteres.Name = "dataGridViewListaDatosInteres";
            this.dataGridViewListaDatosInteres.ReadOnly = true;
            this.dataGridViewListaDatosInteres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListaDatosInteres.Size = new System.Drawing.Size(950, 277);
            this.dataGridViewListaDatosInteres.TabIndex = 22;
            this.dataGridViewListaDatosInteres.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewListaDatosInteres_CellFormatting);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // strState
            // 
            this.strState.HeaderText = "Estado";
            this.strState.Name = "strState";
            this.strState.ReadOnly = true;
            // 
            // ciudadDataGridViewTextBoxColumn
            // 
            this.ciudadDataGridViewTextBoxColumn.DataPropertyName = "ciudad";
            this.ciudadDataGridViewTextBoxColumn.HeaderText = "Ciudad";
            this.ciudadDataGridViewTextBoxColumn.Name = "ciudadDataGridViewTextBoxColumn";
            this.ciudadDataGridViewTextBoxColumn.ReadOnly = true;
            this.ciudadDataGridViewTextBoxColumn.Width = 200;
            // 
            // Delegacion
            // 
            this.Delegacion.HeaderText = "Delegación";
            this.Delegacion.Name = "Delegacion";
            this.Delegacion.ReadOnly = true;
            this.Delegacion.Width = 200;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Visible = false;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionDataGridViewTextBoxColumn.Visible = false;
            // 
            // cpDataGridViewTextBoxColumn
            // 
            this.cpDataGridViewTextBoxColumn.DataPropertyName = "cp";
            this.cpDataGridViewTextBoxColumn.HeaderText = "cp";
            this.cpDataGridViewTextBoxColumn.Name = "cpDataGridViewTextBoxColumn";
            this.cpDataGridViewTextBoxColumn.ReadOnly = true;
            this.cpDataGridViewTextBoxColumn.Visible = false;
            // 
            // idprovinciaDataGridViewTextBoxColumn
            // 
            this.idprovinciaDataGridViewTextBoxColumn.DataPropertyName = "idprovincia";
            this.idprovinciaDataGridViewTextBoxColumn.HeaderText = "idprovincia";
            this.idprovinciaDataGridViewTextBoxColumn.Name = "idprovinciaDataGridViewTextBoxColumn";
            this.idprovinciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idprovinciaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idccaaDataGridViewTextBoxColumn
            // 
            this.idccaaDataGridViewTextBoxColumn.DataPropertyName = "idccaa";
            this.idccaaDataGridViewTextBoxColumn.HeaderText = "idccaa";
            this.idccaaDataGridViewTextBoxColumn.Name = "idccaaDataGridViewTextBoxColumn";
            this.idccaaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idccaaDataGridViewTextBoxColumn.Visible = false;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonoDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Visible = false;
            // 
            // contactoDataGridViewTextBoxColumn
            // 
            this.contactoDataGridViewTextBoxColumn.DataPropertyName = "contacto";
            this.contactoDataGridViewTextBoxColumn.HeaderText = "contacto";
            this.contactoDataGridViewTextBoxColumn.Name = "contactoDataGridViewTextBoxColumn";
            this.contactoDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactoDataGridViewTextBoxColumn.Visible = false;
            // 
            // ctrlglobalDataGridViewTextBoxColumn
            // 
            this.ctrlglobalDataGridViewTextBoxColumn.DataPropertyName = "ctrlglobal";
            this.ctrlglobalDataGridViewTextBoxColumn.HeaderText = "ctrlglobal";
            this.ctrlglobalDataGridViewTextBoxColumn.Name = "ctrlglobalDataGridViewTextBoxColumn";
            this.ctrlglobalDataGridViewTextBoxColumn.ReadOnly = true;
            this.ctrlglobalDataGridViewTextBoxColumn.Visible = false;
            // 
            // iddelegacionDataGridViewTextBoxColumn
            // 
            this.iddelegacionDataGridViewTextBoxColumn.DataPropertyName = "iddelegacion";
            this.iddelegacionDataGridViewTextBoxColumn.HeaderText = "iddelegacion";
            this.iddelegacionDataGridViewTextBoxColumn.Name = "iddelegacionDataGridViewTextBoxColumn";
            this.iddelegacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.iddelegacionDataGridViewTextBoxColumn.Visible = false;
            // 
            // iddsktuserDataGridViewTextBoxColumn
            // 
            this.iddsktuserDataGridViewTextBoxColumn.DataPropertyName = "iddsktuser";
            this.iddsktuserDataGridViewTextBoxColumn.HeaderText = "iddsktuser";
            this.iddsktuserDataGridViewTextBoxColumn.Name = "iddsktuserDataGridViewTextBoxColumn";
            this.iddsktuserDataGridViewTextBoxColumn.ReadOnly = true;
            this.iddsktuserDataGridViewTextBoxColumn.Visible = false;
            // 
            // cCAADataGridViewTextBoxColumn
            // 
            this.cCAADataGridViewTextBoxColumn.DataPropertyName = "CCAA";
            this.cCAADataGridViewTextBoxColumn.HeaderText = "CCAA";
            this.cCAADataGridViewTextBoxColumn.Name = "cCAADataGridViewTextBoxColumn";
            this.cCAADataGridViewTextBoxColumn.ReadOnly = true;
            this.cCAADataGridViewTextBoxColumn.Visible = false;
            // 
            // pROVINCIASDataGridViewTextBoxColumn
            // 
            this.pROVINCIASDataGridViewTextBoxColumn.DataPropertyName = "PROVINCIAS";
            this.pROVINCIASDataGridViewTextBoxColumn.HeaderText = "PROVINCIAS";
            this.pROVINCIASDataGridViewTextBoxColumn.Name = "pROVINCIASDataGridViewTextBoxColumn";
            this.pROVINCIASDataGridViewTextBoxColumn.ReadOnly = true;
            this.pROVINCIASDataGridViewTextBoxColumn.Visible = false;
            // 
            // dELEGACIONESDataGridViewTextBoxColumn
            // 
            this.dELEGACIONESDataGridViewTextBoxColumn.DataPropertyName = "DELEGACIONES";
            this.dELEGACIONESDataGridViewTextBoxColumn.HeaderText = "DELEGACIONES";
            this.dELEGACIONESDataGridViewTextBoxColumn.Name = "dELEGACIONESDataGridViewTextBoxColumn";
            this.dELEGACIONESDataGridViewTextBoxColumn.ReadOnly = true;
            this.dELEGACIONESDataGridViewTextBoxColumn.Visible = false;
            // 
            // dSKTUSERSDataGridViewTextBoxColumn
            // 
            this.dSKTUSERSDataGridViewTextBoxColumn.DataPropertyName = "DSKTUSERS";
            this.dSKTUSERSDataGridViewTextBoxColumn.HeaderText = "DSKTUSERS";
            this.dSKTUSERSDataGridViewTextBoxColumn.Name = "dSKTUSERSDataGridViewTextBoxColumn";
            this.dSKTUSERSDataGridViewTextBoxColumn.ReadOnly = true;
            this.dSKTUSERSDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingSourceDatosInteres
            // 
            this.bindingSourceDatosInteres.DataSource = typeof(EEVAPPDsktp.DATOSINTERES);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(387, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(533, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ciudad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(729, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Delegación";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(17, 40);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(349, 20);
            this.textBoxNombre.TabIndex = 17;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxFiltroNombre_TextChanged);
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(536, 41);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(170, 20);
            this.textBoxCiudad.TabIndex = 18;
            this.textBoxCiudad.TextChanged += new System.EventHandler(this.textBoxCiudad_TextChanged);
            // 
            // comboBoxDelegacion
            // 
            this.comboBoxDelegacion.DataSource = this.bindingSourceDelegaciones;
            this.comboBoxDelegacion.DisplayMember = "nombre";
            this.comboBoxDelegacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDelegacion.FormattingEnabled = true;
            this.comboBoxDelegacion.Location = new System.Drawing.Point(732, 39);
            this.comboBoxDelegacion.Name = "comboBoxDelegacion";
            this.comboBoxDelegacion.Size = new System.Drawing.Size(200, 21);
            this.comboBoxDelegacion.TabIndex = 13;
            this.comboBoxDelegacion.ValueMember = "id";
            this.comboBoxDelegacion.SelectedIndexChanged += new System.EventHandler(this.comboBoxDelegacion_SelectedIndexChanged);
            // 
            // bindingSourceDelegaciones
            // 
            this.bindingSourceDelegaciones.DataSource = typeof(EEVAPPDsktp.DELEGACIONES);
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Todos",
            "Activos",
            "Inactivos"});
            this.comboBoxEstado.Location = new System.Drawing.Point(390, 40);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEstado.TabIndex = 11;
            this.comboBoxEstado.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstado_SelectedIndexChanged);
            // 
            // groupBoxFiltros
            // 
            this.groupBoxFiltros.Controls.Add(this.comboBoxEstado);
            this.groupBoxFiltros.Controls.Add(this.comboBoxDelegacion);
            this.groupBoxFiltros.Controls.Add(this.textBoxCiudad);
            this.groupBoxFiltros.Controls.Add(this.textBoxNombre);
            this.groupBoxFiltros.Controls.Add(this.label4);
            this.groupBoxFiltros.Controls.Add(this.label3);
            this.groupBoxFiltros.Controls.Add(this.label2);
            this.groupBoxFiltros.Controls.Add(this.label1);
            this.groupBoxFiltros.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxFiltros.Location = new System.Drawing.Point(12, 36);
            this.groupBoxFiltros.Name = "groupBoxFiltros";
            this.groupBoxFiltros.Size = new System.Drawing.Size(950, 79);
            this.groupBoxFiltros.TabIndex = 23;
            this.groupBoxFiltros.TabStop = false;
            this.groupBoxFiltros.Text = "Filtros de busqueda";
            // 
            // menuStripOpciones
            // 
            this.menuStripOpciones.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuStripOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.activadesactivaToolStripMenuItem});
            this.menuStripOpciones.Location = new System.Drawing.Point(0, 0);
            this.menuStripOpciones.Name = "menuStripOpciones";
            this.menuStripOpciones.Size = new System.Drawing.Size(976, 24);
            this.menuStripOpciones.TabIndex = 24;
            this.menuStripOpciones.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.nuevoToolStripMenuItem.Text = "nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.modificarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modificarToolStripMenuItem.Image")));
            this.modificarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.modificarToolStripMenuItem.Text = "modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.eliminarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarToolStripMenuItem.Image")));
            this.eliminarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.eliminarToolStripMenuItem.Text = "eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // activadesactivaToolStripMenuItem
            // 
            this.activadesactivaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.activadesactivaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("activadesactivaToolStripMenuItem.Image")));
            this.activadesactivaToolStripMenuItem.Name = "activadesactivaToolStripMenuItem";
            this.activadesactivaToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.activadesactivaToolStripMenuItem.Text = "activa/desactiva";
            this.activadesactivaToolStripMenuItem.Click += new System.EventHandler(this.activadesactivaToolStripMenuItem_Click);
            // 
            // DatosInteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(976, 434);
            this.Controls.Add(this.menuStripOpciones);
            this.Controls.Add(this.groupBoxFiltros);
            this.Controls.Add(this.dataGridViewListaDatosInteres);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripOpciones;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatosInteres";
            this.Text = "DatosInteres";
            this.Load += new System.EventHandler(this.DatosInteres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaDatosInteres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDatosInteres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDelegaciones)).EndInit();
            this.groupBoxFiltros.ResumeLayout(false);
            this.groupBoxFiltros.PerformLayout();
            this.menuStripOpciones.ResumeLayout(false);
            this.menuStripOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewListaDatosInteres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.ComboBox comboBoxDelegacion;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.GroupBox groupBoxFiltros;
        private System.Windows.Forms.MenuStrip menuStripOpciones;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activadesactivaToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSourceDelegaciones;
        private System.Windows.Forms.BindingSource bindingSourceDatosInteres;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strState;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delegacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprovinciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idccaaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctrlglobalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddelegacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddsktuserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCAADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROVINCIASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dELEGACIONESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dSKTUSERSDataGridViewTextBoxColumn;
    }
}