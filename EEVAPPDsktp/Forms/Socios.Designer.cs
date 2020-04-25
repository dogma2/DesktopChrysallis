namespace EEVAPPDsktp.Forms
{
    partial class Socios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Socios));
            this.groupBoxFiltros = new System.Windows.Forms.GroupBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.labelLangText = new System.Windows.Forms.Label();
            this.comboBoxDelegacion = new System.Windows.Forms.ComboBox();
            this.bindingSourceDelegaciones = new System.Windows.Forms.BindingSource(this.components);
            this.labelDelegacion = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxCodigoSocio = new System.Windows.Forms.TextBox();
            this.labelCodigoSocio = new System.Windows.Forms.Label();
            this.dataGridViewListaSocios = new System.Windows.Forms.DataGridView();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsocioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidapp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imei = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddelegacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddsktuser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASISTENTES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DELEGACIONES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSKTUSERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceSocios = new System.Windows.Forms.BindingSource(this.components);
            this.labelListaSocios = new System.Windows.Forms.Label();
            this.menuStripOpciones = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activadesactivaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDelegaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaSocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSocios)).BeginInit();
            this.menuStripOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFiltros
            // 
            this.groupBoxFiltros.Controls.Add(this.comboBoxEstado);
            this.groupBoxFiltros.Controls.Add(this.labelLangText);
            this.groupBoxFiltros.Controls.Add(this.comboBoxDelegacion);
            this.groupBoxFiltros.Controls.Add(this.labelDelegacion);
            this.groupBoxFiltros.Controls.Add(this.textBoxEmail);
            this.groupBoxFiltros.Controls.Add(this.labelEmail);
            this.groupBoxFiltros.Controls.Add(this.textBoxCodigoSocio);
            this.groupBoxFiltros.Controls.Add(this.labelCodigoSocio);
            this.groupBoxFiltros.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxFiltros.Location = new System.Drawing.Point(12, 36);
            this.groupBoxFiltros.Name = "groupBoxFiltros";
            this.groupBoxFiltros.Size = new System.Drawing.Size(950, 77);
            this.groupBoxFiltros.TabIndex = 1;
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
            this.comboBoxEstado.SelectedIndexChanged += new System.EventHandler(this.comboBoxLang_SelectedIndexChanged);
            // 
            // labelLangText
            // 
            this.labelLangText.AutoSize = true;
            this.labelLangText.Location = new System.Drawing.Point(389, 24);
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
            // labelDelegacion
            // 
            this.labelDelegacion.AutoSize = true;
            this.labelDelegacion.Location = new System.Drawing.Point(731, 24);
            this.labelDelegacion.Name = "labelDelegacion";
            this.labelDelegacion.Size = new System.Drawing.Size(61, 13);
            this.labelDelegacion.TabIndex = 0;
            this.labelDelegacion.Text = "Delegación";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(17, 41);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(351, 20);
            this.textBoxEmail.TabIndex = 10;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(14, 24);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(78, 13);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Filtrar por Email";
            // 
            // textBoxCodigoSocio
            // 
            this.textBoxCodigoSocio.Location = new System.Drawing.Point(538, 41);
            this.textBoxCodigoSocio.Name = "textBoxCodigoSocio";
            this.textBoxCodigoSocio.Size = new System.Drawing.Size(170, 20);
            this.textBoxCodigoSocio.TabIndex = 12;
            this.textBoxCodigoSocio.TextChanged += new System.EventHandler(this.textBoxCodigoSocio_TextChanged);
            // 
            // labelCodigoSocio
            // 
            this.labelCodigoSocio.AutoSize = true;
            this.labelCodigoSocio.Location = new System.Drawing.Point(535, 24);
            this.labelCodigoSocio.Name = "labelCodigoSocio";
            this.labelCodigoSocio.Size = new System.Drawing.Size(131, 13);
            this.labelCodigoSocio.TabIndex = 0;
            this.labelCodigoSocio.Text = "Filtrar por Código de Socio";
            // 
            // dataGridViewListaSocios
            // 
            this.dataGridViewListaSocios.AllowDrop = true;
            this.dataGridViewListaSocios.AllowUserToAddRows = false;
            this.dataGridViewListaSocios.AllowUserToDeleteRows = false;
            this.dataGridViewListaSocios.AutoGenerateColumns = false;
            this.dataGridViewListaSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emailDataGridViewTextBoxColumn,
            this.idsocioDataGridViewTextBoxColumn,
            this.estado,
            this.strState,
            this.id,
            this.cidapp,
            this.email,
            this.imei,
            this.fechaestado,
            this.notaestado,
            this.iddelegacion,
            this.iddsktuser,
            this.ASISTENTES,
            this.DELEGACIONES,
            this.DSKTUSERS});
            this.dataGridViewListaSocios.DataSource = this.bindingSourceSocios;
            this.dataGridViewListaSocios.Location = new System.Drawing.Point(12, 144);
            this.dataGridViewListaSocios.MultiSelect = false;
            this.dataGridViewListaSocios.Name = "dataGridViewListaSocios";
            this.dataGridViewListaSocios.ReadOnly = true;
            this.dataGridViewListaSocios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListaSocios.Size = new System.Drawing.Size(950, 334);
            this.dataGridViewListaSocios.TabIndex = 20;
            this.dataGridViewListaSocios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewListaSocios_CellFormatting);
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idsocioDataGridViewTextBoxColumn
            // 
            this.idsocioDataGridViewTextBoxColumn.DataPropertyName = "idsocio";
            this.idsocioDataGridViewTextBoxColumn.HeaderText = "Codigo de Socio";
            this.idsocioDataGridViewTextBoxColumn.Name = "idsocioDataGridViewTextBoxColumn";
            this.idsocioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idsocioDataGridViewTextBoxColumn.Width = 150;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Visible = false;
            // 
            // strState
            // 
            this.strState.HeaderText = "Estado";
            this.strState.Name = "strState";
            this.strState.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // cidapp
            // 
            this.cidapp.DataPropertyName = "cidapp";
            this.cidapp.HeaderText = "cidapp";
            this.cidapp.Name = "cidapp";
            this.cidapp.ReadOnly = true;
            this.cidapp.Visible = false;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Visible = false;
            // 
            // imei
            // 
            this.imei.DataPropertyName = "imei";
            this.imei.HeaderText = "imei";
            this.imei.Name = "imei";
            this.imei.ReadOnly = true;
            this.imei.Visible = false;
            // 
            // fechaestado
            // 
            this.fechaestado.DataPropertyName = "fechaestado";
            this.fechaestado.HeaderText = "fechaestado";
            this.fechaestado.Name = "fechaestado";
            this.fechaestado.ReadOnly = true;
            this.fechaestado.Visible = false;
            // 
            // notaestado
            // 
            this.notaestado.DataPropertyName = "notaestado";
            this.notaestado.HeaderText = "notaestado";
            this.notaestado.Name = "notaestado";
            this.notaestado.ReadOnly = true;
            this.notaestado.Visible = false;
            // 
            // iddelegacion
            // 
            this.iddelegacion.DataPropertyName = "iddelegacion";
            this.iddelegacion.HeaderText = "iddelegacion";
            this.iddelegacion.Name = "iddelegacion";
            this.iddelegacion.ReadOnly = true;
            this.iddelegacion.Visible = false;
            // 
            // iddsktuser
            // 
            this.iddsktuser.DataPropertyName = "iddsktuser";
            this.iddsktuser.HeaderText = "iddsktuser";
            this.iddsktuser.Name = "iddsktuser";
            this.iddsktuser.ReadOnly = true;
            this.iddsktuser.Visible = false;
            // 
            // ASISTENTES
            // 
            this.ASISTENTES.DataPropertyName = "ASISTENTES";
            this.ASISTENTES.HeaderText = "ASISTENTES";
            this.ASISTENTES.Name = "ASISTENTES";
            this.ASISTENTES.ReadOnly = true;
            this.ASISTENTES.Visible = false;
            // 
            // DELEGACIONES
            // 
            this.DELEGACIONES.DataPropertyName = "DELEGACIONES";
            this.DELEGACIONES.HeaderText = "DELEGACIONES";
            this.DELEGACIONES.Name = "DELEGACIONES";
            this.DELEGACIONES.ReadOnly = true;
            this.DELEGACIONES.Visible = false;
            // 
            // DSKTUSERS
            // 
            this.DSKTUSERS.DataPropertyName = "DSKTUSERS";
            this.DSKTUSERS.HeaderText = "DSKTUSERS";
            this.DSKTUSERS.Name = "DSKTUSERS";
            this.DSKTUSERS.ReadOnly = true;
            this.DSKTUSERS.Visible = false;
            // 
            // bindingSourceSocios
            // 
            this.bindingSourceSocios.DataSource = typeof(EEVAPPDsktp.USUARIOS);
            // 
            // labelListaSocios
            // 
            this.labelListaSocios.AutoSize = true;
            this.labelListaSocios.ForeColor = System.Drawing.Color.White;
            this.labelListaSocios.Location = new System.Drawing.Point(9, 128);
            this.labelListaSocios.Name = "labelListaSocios";
            this.labelListaSocios.Size = new System.Drawing.Size(79, 13);
            this.labelListaSocios.TabIndex = 0;
            this.labelListaSocios.Text = "Lista de Socios";
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
            this.menuStripOpciones.Size = new System.Drawing.Size(975, 24);
            this.menuStripOpciones.TabIndex = 0;
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
            // Socios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(975, 498);
            this.Controls.Add(this.labelListaSocios);
            this.Controls.Add(this.dataGridViewListaSocios);
            this.Controls.Add(this.groupBoxFiltros);
            this.Controls.Add(this.menuStripOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripOpciones;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Socios";
            this.Text = "Socios";
            this.Load += new System.EventHandler(this.Socios_Load);
            this.groupBoxFiltros.ResumeLayout(false);
            this.groupBoxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDelegaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaSocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSocios)).EndInit();
            this.menuStripOpciones.ResumeLayout(false);
            this.menuStripOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFiltros;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxCodigoSocio;
        private System.Windows.Forms.Label labelCodigoSocio;
        private System.Windows.Forms.ComboBox comboBoxDelegacion;
        private System.Windows.Forms.Label labelDelegacion;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label labelLangText;
        private System.Windows.Forms.DataGridView dataGridViewListaSocios;
        private System.Windows.Forms.Label labelListaSocios;
        private System.Windows.Forms.BindingSource bindingSourceDelegaciones;
        private System.Windows.Forms.BindingSource bindingSourceSocios;
        private System.Windows.Forms.MenuStrip menuStripOpciones;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activadesactivaToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsocioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn strState;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidapp;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn imei;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddelegacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddsktuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASISTENTES;
        private System.Windows.Forms.DataGridViewTextBoxColumn DELEGACIONES;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSKTUSERS;
    }
}