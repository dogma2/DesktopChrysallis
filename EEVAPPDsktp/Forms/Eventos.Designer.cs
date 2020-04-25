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
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.dataGridViewEventos = new System.Windows.Forms.DataGridView();
            this.bindingSourceEventos = new System.Windows.Forms.BindingSource(this.components);
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelCiudad = new System.Windows.Forms.Label();
            this.menuStripOpciones = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activadesactivaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxFiltros = new System.Windows.Forms.GroupBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.labelLangText = new System.Windows.Forms.Label();
            this.comboBoxDelegacion = new System.Windows.Forms.ComboBox();
            this.bindingSourceDelegaciones = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fechainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delegacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddelegacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cideventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.introDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechafinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horafinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.notaseventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notastransporteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idccaaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idprovinciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordgpsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctrlglobalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddelegacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddsktuserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigopostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aSISTENTESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCAADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCUMENTOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROVINCIASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dELEGACIONESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dSKTUSERSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEventos)).BeginInit();
            this.menuStripOpciones.SuspendLayout();
            this.groupBoxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDelegaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(15, 40);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(349, 20);
            this.textBoxTitulo.TabIndex = 1;
            this.textBoxTitulo.TextChanged += new System.EventHandler(this.textBoxTitulo_TextChanged);
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(541, 40);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(165, 20);
            this.textBoxCiudad.TabIndex = 3;
            this.textBoxCiudad.TextChanged += new System.EventHandler(this.textBoxCiudad_TextChanged);
            // 
            // dataGridViewEventos
            // 
            this.dataGridViewEventos.AllowDrop = true;
            this.dataGridViewEventos.AllowUserToAddRows = false;
            this.dataGridViewEventos.AllowUserToDeleteRows = false;
            this.dataGridViewEventos.AutoGenerateColumns = false;
            this.dataGridViewEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechainicioDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.strState,
            this.ciudadDataGridViewTextBoxColumn,
            this.delegacion,
            this.iddelegacion,
            this.idDataGridViewTextBoxColumn,
            this.cideventoDataGridViewTextBoxColumn,
            this.introDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.horainicioDataGridViewTextBoxColumn,
            this.fechafinDataGridViewTextBoxColumn,
            this.horafinDataGridViewTextBoxColumn,
            this.imagenDataGridViewImageColumn,
            this.notaseventoDataGridViewTextBoxColumn,
            this.notastransporteDataGridViewTextBoxColumn,
            this.idccaaDataGridViewTextBoxColumn,
            this.idprovinciaDataGridViewTextBoxColumn,
            this.coordgpsDataGridViewTextBoxColumn,
            this.ctrlglobalDataGridViewTextBoxColumn,
            this.iddelegacionDataGridViewTextBoxColumn,
            this.iddsktuserDataGridViewTextBoxColumn,
            this.codigopostalDataGridViewTextBoxColumn,
            this.responsableDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.aSISTENTESDataGridViewTextBoxColumn,
            this.cCAADataGridViewTextBoxColumn,
            this.dOCUMENTOSDataGridViewTextBoxColumn,
            this.pROVINCIASDataGridViewTextBoxColumn,
            this.dELEGACIONESDataGridViewTextBoxColumn,
            this.dSKTUSERSDataGridViewTextBoxColumn});
            this.dataGridViewEventos.DataSource = this.bindingSourceEventos;
            this.dataGridViewEventos.Location = new System.Drawing.Point(12, 145);
            this.dataGridViewEventos.Name = "dataGridViewEventos";
            this.dataGridViewEventos.ReadOnly = true;
            this.dataGridViewEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEventos.Size = new System.Drawing.Size(950, 274);
            this.dataGridViewEventos.TabIndex = 5;
            this.dataGridViewEventos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewEventos_CellFormatting);
            // 
            // bindingSourceEventos
            // 
            this.bindingSourceEventos.DataSource = typeof(EEVAPPDsktp.EVENTOS);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTitulo.Location = new System.Drawing.Point(12, 25);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(77, 13);
            this.labelTitulo.TabIndex = 7;
            this.labelTitulo.Text = "Filtrar por título";
            // 
            // labelCiudad
            // 
            this.labelCiudad.AutoSize = true;
            this.labelCiudad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCiudad.Location = new System.Drawing.Point(538, 25);
            this.labelCiudad.Name = "labelCiudad";
            this.labelCiudad.Size = new System.Drawing.Size(85, 13);
            this.labelCiudad.TabIndex = 9;
            this.labelCiudad.Text = "Filtrar por ciudad";
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
            this.menuStripOpciones.Size = new System.Drawing.Size(974, 24);
            this.menuStripOpciones.TabIndex = 25;
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
            // groupBoxFiltros
            // 
            this.groupBoxFiltros.Controls.Add(this.comboBoxEstado);
            this.groupBoxFiltros.Controls.Add(this.labelLangText);
            this.groupBoxFiltros.Controls.Add(this.comboBoxDelegacion);
            this.groupBoxFiltros.Controls.Add(this.label1);
            this.groupBoxFiltros.Controls.Add(this.textBoxTitulo);
            this.groupBoxFiltros.Controls.Add(this.labelTitulo);
            this.groupBoxFiltros.Controls.Add(this.labelCiudad);
            this.groupBoxFiltros.Controls.Add(this.textBoxCiudad);
            this.groupBoxFiltros.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxFiltros.Location = new System.Drawing.Point(12, 37);
            this.groupBoxFiltros.Name = "groupBoxFiltros";
            this.groupBoxFiltros.Size = new System.Drawing.Size(950, 77);
            this.groupBoxFiltros.TabIndex = 26;
            this.groupBoxFiltros.TabStop = false;
            this.groupBoxFiltros.Text = "Filtros de busqueda";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Todos",
            "Activos",
            "Inactivos"});
            this.comboBoxEstado.Location = new System.Drawing.Point(392, 41);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEstado.TabIndex = 11;
            this.comboBoxEstado.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstado_SelectedIndexChanged);
            // 
            // labelLangText
            // 
            this.labelLangText.AutoSize = true;
            this.labelLangText.Location = new System.Drawing.Point(389, 25);
            this.labelLangText.Name = "labelLangText";
            this.labelLangText.Size = new System.Drawing.Size(86, 13);
            this.labelLangText.TabIndex = 0;
            this.labelLangText.Text = "Filtrar por Estado";
            // 
            // comboBoxDelegacion
            // 
            this.comboBoxDelegacion.DataSource = this.bindingSourceDelegaciones;
            this.comboBoxDelegacion.DisplayMember = "nombre";
            this.comboBoxDelegacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDelegacion.FormattingEnabled = true;
            this.comboBoxDelegacion.Location = new System.Drawing.Point(734, 40);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(731, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delegación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(9, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Lista de Eventos";
            // 
            // fechainicioDataGridViewTextBoxColumn
            // 
            this.fechainicioDataGridViewTextBoxColumn.DataPropertyName = "fechainicio";
            this.fechainicioDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechainicioDataGridViewTextBoxColumn.Name = "fechainicioDataGridViewTextBoxColumn";
            this.fechainicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Título";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
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
            // delegacion
            // 
            this.delegacion.HeaderText = "Delegación";
            this.delegacion.Name = "delegacion";
            this.delegacion.ReadOnly = true;
            // 
            // iddelegacion
            // 
            this.iddelegacion.DataPropertyName = "id";
            this.iddelegacion.HeaderText = "iddelegacion";
            this.iddelegacion.Name = "iddelegacion";
            this.iddelegacion.ReadOnly = true;
            this.iddelegacion.Visible = false;
            this.iddelegacion.Width = 181;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // cideventoDataGridViewTextBoxColumn
            // 
            this.cideventoDataGridViewTextBoxColumn.DataPropertyName = "cidevento";
            this.cideventoDataGridViewTextBoxColumn.HeaderText = "cidevento";
            this.cideventoDataGridViewTextBoxColumn.Name = "cideventoDataGridViewTextBoxColumn";
            this.cideventoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cideventoDataGridViewTextBoxColumn.Visible = false;
            // 
            // introDataGridViewTextBoxColumn
            // 
            this.introDataGridViewTextBoxColumn.DataPropertyName = "intro";
            this.introDataGridViewTextBoxColumn.HeaderText = "intro";
            this.introDataGridViewTextBoxColumn.Name = "introDataGridViewTextBoxColumn";
            this.introDataGridViewTextBoxColumn.ReadOnly = true;
            this.introDataGridViewTextBoxColumn.Visible = false;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Visible = false;
            // 
            // horainicioDataGridViewTextBoxColumn
            // 
            this.horainicioDataGridViewTextBoxColumn.DataPropertyName = "horainicio";
            this.horainicioDataGridViewTextBoxColumn.HeaderText = "horainicio";
            this.horainicioDataGridViewTextBoxColumn.Name = "horainicioDataGridViewTextBoxColumn";
            this.horainicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.horainicioDataGridViewTextBoxColumn.Visible = false;
            // 
            // fechafinDataGridViewTextBoxColumn
            // 
            this.fechafinDataGridViewTextBoxColumn.DataPropertyName = "fechafin";
            this.fechafinDataGridViewTextBoxColumn.HeaderText = "fechafin";
            this.fechafinDataGridViewTextBoxColumn.Name = "fechafinDataGridViewTextBoxColumn";
            this.fechafinDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechafinDataGridViewTextBoxColumn.Visible = false;
            // 
            // horafinDataGridViewTextBoxColumn
            // 
            this.horafinDataGridViewTextBoxColumn.DataPropertyName = "horafin";
            this.horafinDataGridViewTextBoxColumn.HeaderText = "horafin";
            this.horafinDataGridViewTextBoxColumn.Name = "horafinDataGridViewTextBoxColumn";
            this.horafinDataGridViewTextBoxColumn.ReadOnly = true;
            this.horafinDataGridViewTextBoxColumn.Visible = false;
            // 
            // imagenDataGridViewImageColumn
            // 
            this.imagenDataGridViewImageColumn.DataPropertyName = "imagen";
            this.imagenDataGridViewImageColumn.HeaderText = "imagen";
            this.imagenDataGridViewImageColumn.Name = "imagenDataGridViewImageColumn";
            this.imagenDataGridViewImageColumn.ReadOnly = true;
            this.imagenDataGridViewImageColumn.Visible = false;
            // 
            // notaseventoDataGridViewTextBoxColumn
            // 
            this.notaseventoDataGridViewTextBoxColumn.DataPropertyName = "notasevento";
            this.notaseventoDataGridViewTextBoxColumn.HeaderText = "notasevento";
            this.notaseventoDataGridViewTextBoxColumn.Name = "notaseventoDataGridViewTextBoxColumn";
            this.notaseventoDataGridViewTextBoxColumn.ReadOnly = true;
            this.notaseventoDataGridViewTextBoxColumn.Visible = false;
            // 
            // notastransporteDataGridViewTextBoxColumn
            // 
            this.notastransporteDataGridViewTextBoxColumn.DataPropertyName = "notastransporte";
            this.notastransporteDataGridViewTextBoxColumn.HeaderText = "notastransporte";
            this.notastransporteDataGridViewTextBoxColumn.Name = "notastransporteDataGridViewTextBoxColumn";
            this.notastransporteDataGridViewTextBoxColumn.ReadOnly = true;
            this.notastransporteDataGridViewTextBoxColumn.Visible = false;
            // 
            // idccaaDataGridViewTextBoxColumn
            // 
            this.idccaaDataGridViewTextBoxColumn.DataPropertyName = "idccaa";
            this.idccaaDataGridViewTextBoxColumn.HeaderText = "idccaa";
            this.idccaaDataGridViewTextBoxColumn.Name = "idccaaDataGridViewTextBoxColumn";
            this.idccaaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idccaaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idprovinciaDataGridViewTextBoxColumn
            // 
            this.idprovinciaDataGridViewTextBoxColumn.DataPropertyName = "idprovincia";
            this.idprovinciaDataGridViewTextBoxColumn.HeaderText = "idprovincia";
            this.idprovinciaDataGridViewTextBoxColumn.Name = "idprovinciaDataGridViewTextBoxColumn";
            this.idprovinciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idprovinciaDataGridViewTextBoxColumn.Visible = false;
            // 
            // coordgpsDataGridViewTextBoxColumn
            // 
            this.coordgpsDataGridViewTextBoxColumn.DataPropertyName = "coordgps";
            this.coordgpsDataGridViewTextBoxColumn.HeaderText = "coordgps";
            this.coordgpsDataGridViewTextBoxColumn.Name = "coordgpsDataGridViewTextBoxColumn";
            this.coordgpsDataGridViewTextBoxColumn.ReadOnly = true;
            this.coordgpsDataGridViewTextBoxColumn.Visible = false;
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
            // codigopostalDataGridViewTextBoxColumn
            // 
            this.codigopostalDataGridViewTextBoxColumn.DataPropertyName = "codigopostal";
            this.codigopostalDataGridViewTextBoxColumn.HeaderText = "codigopostal";
            this.codigopostalDataGridViewTextBoxColumn.Name = "codigopostalDataGridViewTextBoxColumn";
            this.codigopostalDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigopostalDataGridViewTextBoxColumn.Visible = false;
            // 
            // responsableDataGridViewTextBoxColumn
            // 
            this.responsableDataGridViewTextBoxColumn.DataPropertyName = "responsable";
            this.responsableDataGridViewTextBoxColumn.HeaderText = "responsable";
            this.responsableDataGridViewTextBoxColumn.Name = "responsableDataGridViewTextBoxColumn";
            this.responsableDataGridViewTextBoxColumn.ReadOnly = true;
            this.responsableDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Visible = false;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonoDataGridViewTextBoxColumn.Visible = false;
            // 
            // aSISTENTESDataGridViewTextBoxColumn
            // 
            this.aSISTENTESDataGridViewTextBoxColumn.DataPropertyName = "ASISTENTES";
            this.aSISTENTESDataGridViewTextBoxColumn.HeaderText = "ASISTENTES";
            this.aSISTENTESDataGridViewTextBoxColumn.Name = "aSISTENTESDataGridViewTextBoxColumn";
            this.aSISTENTESDataGridViewTextBoxColumn.ReadOnly = true;
            this.aSISTENTESDataGridViewTextBoxColumn.Visible = false;
            // 
            // cCAADataGridViewTextBoxColumn
            // 
            this.cCAADataGridViewTextBoxColumn.DataPropertyName = "CCAA";
            this.cCAADataGridViewTextBoxColumn.HeaderText = "CCAA";
            this.cCAADataGridViewTextBoxColumn.Name = "cCAADataGridViewTextBoxColumn";
            this.cCAADataGridViewTextBoxColumn.ReadOnly = true;
            this.cCAADataGridViewTextBoxColumn.Visible = false;
            // 
            // dOCUMENTOSDataGridViewTextBoxColumn
            // 
            this.dOCUMENTOSDataGridViewTextBoxColumn.DataPropertyName = "DOCUMENTOS";
            this.dOCUMENTOSDataGridViewTextBoxColumn.HeaderText = "DOCUMENTOS";
            this.dOCUMENTOSDataGridViewTextBoxColumn.Name = "dOCUMENTOSDataGridViewTextBoxColumn";
            this.dOCUMENTOSDataGridViewTextBoxColumn.ReadOnly = true;
            this.dOCUMENTOSDataGridViewTextBoxColumn.Visible = false;
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
            // Eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(974, 431);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBoxFiltros);
            this.Controls.Add(this.menuStripOpciones);
            this.Controls.Add(this.dataGridViewEventos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripOpciones;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Eventos";
            this.Text = "Eventos";
            this.Load += new System.EventHandler(this.Eventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEventos)).EndInit();
            this.menuStripOpciones.ResumeLayout(false);
            this.menuStripOpciones.PerformLayout();
            this.groupBoxFiltros.ResumeLayout(false);
            this.groupBoxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDelegaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.DataGridView dataGridViewEventos;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelCiudad;
        private System.Windows.Forms.MenuStrip menuStripOpciones;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activadesactivaToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxFiltros;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label labelLangText;
        private System.Windows.Forms.ComboBox comboBoxDelegacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bindingSourceDelegaciones;
        private System.Windows.Forms.BindingSource bindingSourceEventos;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strState;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delegacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddelegacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cideventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn introDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechafinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horafinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagenDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaseventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notastransporteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idccaaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprovinciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coordgpsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctrlglobalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddelegacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddsktuserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigopostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSISTENTESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCAADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCUMENTOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROVINCIASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dELEGACIONESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dSKTUSERSDataGridViewTextBoxColumn;
    }
}