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
            this.bindingSourceDelegaciones = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewEventos = new System.Windows.Forms.DataGridView();
            this.bindingSourceEventos = new System.Windows.Forms.BindingSource(this.components);
            this.eVENTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.delegacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDelegaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVENTOSBindingSource)).BeginInit();
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
            // bindingSourceDelegaciones
            // 
            this.bindingSourceDelegaciones.DataSource = typeof(EEVAPPDsktp.DELEGACIONES);
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
            this.delegacion,
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
            this.dataGridViewEventos.Location = new System.Drawing.Point(13, 87);
            this.dataGridViewEventos.Name = "dataGridViewEventos";
            this.dataGridViewEventos.ReadOnly = true;
            this.dataGridViewEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEventos.Size = new System.Drawing.Size(775, 351);
            this.dataGridViewEventos.TabIndex = 5;
            // 
            // bindingSourceEventos
            // 
            this.bindingSourceEventos.DataSource = typeof(EEVAPPDsktp.EVENTOS);
            // 
            // eVENTOSBindingSource
            // 
            this.eVENTOSBindingSource.DataSource = typeof(EEVAPPDsktp.EVENTOS);
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
            this.labelModificar.Click += new System.EventHandler(this.labelModificar_Click);
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
            this.fechainicioDataGridViewTextBoxColumn.HeaderText = "fechainicio";
            this.fechainicioDataGridViewTextBoxColumn.Name = "fechainicioDataGridViewTextBoxColumn";
            this.fechainicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ciudadDataGridViewTextBoxColumn
            // 
            this.ciudadDataGridViewTextBoxColumn.DataPropertyName = "ciudad";
            this.ciudadDataGridViewTextBoxColumn.HeaderText = "ciudad";
            this.ciudadDataGridViewTextBoxColumn.Name = "ciudadDataGridViewTextBoxColumn";
            this.ciudadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // delegacion
            // 
            this.delegacion.DataPropertyName = "id";
            this.delegacion.HeaderText = "Delegación";
            this.delegacion.Name = "delegacion";
            this.delegacion.ReadOnly = true;
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
            this.Activated += new System.EventHandler(this.Eventos_Activated);
            this.Load += new System.EventHandler(this.Eventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDelegaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVENTOSBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource bindingSourceDelegaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delegacion;
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