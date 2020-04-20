namespace EEVAPPDsktp
{
    partial class MainStartForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainStartForm));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemEventos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDatosInteres = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSocios = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDelegaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAdministradores = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDatosAsociacion = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTraducciones = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemConfiguracionInicial = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEevapp = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDogma2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.eevappLogo = new System.Windows.Forms.PictureBox();
            this.asociaciationLogo = new System.Windows.Forms.PictureBox();
            this.eevappDataURL = new System.Windows.Forms.Label();
            this.eevappDataEmail = new System.Windows.Forms.Label();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxClave = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.labelClave = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eevappLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asociaciationLogo)).BeginInit();
            this.groupBoxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Enabled = false;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEventos,
            this.toolStripMenuItemDatosInteres,
            this.toolStripMenuItemSocios,
            this.administraciónToolStripMenuItem,
            this.configuracioToolStripMenuItem,
            this.toolStripMenuItemAboutUs,
            this.toolStripMenuItemSalir});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(834, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // toolStripMenuItemEventos
            // 
            this.toolStripMenuItemEventos.Name = "toolStripMenuItemEventos";
            this.toolStripMenuItemEventos.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.toolStripMenuItemEventos.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItemEventos.Text = "Eventos";
            this.toolStripMenuItemEventos.Click += new System.EventHandler(this.toolStripMenuItemEventos_Click);
            // 
            // toolStripMenuItemDatosInteres
            // 
            this.toolStripMenuItemDatosInteres.Name = "toolStripMenuItemDatosInteres";
            this.toolStripMenuItemDatosInteres.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.toolStripMenuItemDatosInteres.Size = new System.Drawing.Size(87, 20);
            this.toolStripMenuItemDatosInteres.Text = "Datos Interés";
            this.toolStripMenuItemDatosInteres.Click += new System.EventHandler(this.toolStripMenuItemDatosInteres_Click);
            // 
            // toolStripMenuItemSocios
            // 
            this.toolStripMenuItemSocios.Name = "toolStripMenuItemSocios";
            this.toolStripMenuItemSocios.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItemSocios.Size = new System.Drawing.Size(53, 20);
            this.toolStripMenuItemSocios.Text = "Socios";
            this.toolStripMenuItemSocios.Click += new System.EventHandler(this.toolStripMenuItemSocios_Click);
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDelegaciones,
            this.toolStripMenuItemAdministradores,
            this.toolStripMenuItemDatosAsociacion});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administraciónToolStripMenuItem.Text = "Administración";
            // 
            // toolStripMenuItemDelegaciones
            // 
            this.toolStripMenuItemDelegaciones.Name = "toolStripMenuItemDelegaciones";
            this.toolStripMenuItemDelegaciones.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.toolStripMenuItemDelegaciones.Size = new System.Drawing.Size(208, 22);
            this.toolStripMenuItemDelegaciones.Text = "Delegaciones";
            this.toolStripMenuItemDelegaciones.Click += new System.EventHandler(this.toolStripMenuItemDelegaciones_Click);
            // 
            // toolStripMenuItemAdministradores
            // 
            this.toolStripMenuItemAdministradores.Name = "toolStripMenuItemAdministradores";
            this.toolStripMenuItemAdministradores.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.toolStripMenuItemAdministradores.Size = new System.Drawing.Size(208, 22);
            this.toolStripMenuItemAdministradores.Text = "Administradores";
            this.toolStripMenuItemAdministradores.Click += new System.EventHandler(this.toolStripMenuItemAdministradores_Click);
            // 
            // toolStripMenuItemDatosAsociacion
            // 
            this.toolStripMenuItemDatosAsociacion.Name = "toolStripMenuItemDatosAsociacion";
            this.toolStripMenuItemDatosAsociacion.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.toolStripMenuItemDatosAsociacion.Size = new System.Drawing.Size(208, 22);
            this.toolStripMenuItemDatosAsociacion.Text = "Datos Asociación";
            this.toolStripMenuItemDatosAsociacion.Click += new System.EventHandler(this.toolStripMenuItemDatosAsociacion_Click);
            // 
            // configuracioToolStripMenuItem
            // 
            this.configuracioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemTraducciones,
            this.toolStripMenuItemConfiguracionInicial});
            this.configuracioToolStripMenuItem.Name = "configuracioToolStripMenuItem";
            this.configuracioToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.configuracioToolStripMenuItem.Text = "Configuración APP";
            // 
            // toolStripMenuItemTraducciones
            // 
            this.toolStripMenuItemTraducciones.Name = "toolStripMenuItemTraducciones";
            this.toolStripMenuItemTraducciones.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.toolStripMenuItemTraducciones.Size = new System.Drawing.Size(221, 22);
            this.toolStripMenuItemTraducciones.Text = "Traducciones";
            this.toolStripMenuItemTraducciones.Click += new System.EventHandler(this.toolStripMenuItemTraducciones_Click);
            // 
            // toolStripMenuItemConfiguracionInicial
            // 
            this.toolStripMenuItemConfiguracionInicial.Name = "toolStripMenuItemConfiguracionInicial";
            this.toolStripMenuItemConfiguracionInicial.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.toolStripMenuItemConfiguracionInicial.Size = new System.Drawing.Size(221, 22);
            this.toolStripMenuItemConfiguracionInicial.Text = "Configuración Inicial";
            this.toolStripMenuItemConfiguracionInicial.Click += new System.EventHandler(this.toolStripMenuItemConfiguracionInicial_Click);
            // 
            // toolStripMenuItemAboutUs
            // 
            this.toolStripMenuItemAboutUs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEevapp,
            this.ToolStripMenuItemDogma2});
            this.toolStripMenuItemAboutUs.Name = "toolStripMenuItemAboutUs";
            this.toolStripMenuItemAboutUs.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItemAboutUs.Text = "?";
            // 
            // toolStripMenuItemEevapp
            // 
            this.toolStripMenuItemEevapp.Name = "toolStripMenuItemEevapp";
            this.toolStripMenuItemEevapp.Size = new System.Drawing.Size(164, 22);
            this.toolStripMenuItemEevapp.Text = "Proyecto EEVAPP";
            this.toolStripMenuItemEevapp.Click += new System.EventHandler(this.toolStripMenuItemEevapp_Click);
            // 
            // ToolStripMenuItemDogma2
            // 
            this.ToolStripMenuItemDogma2.Name = "ToolStripMenuItemDogma2";
            this.ToolStripMenuItemDogma2.Size = new System.Drawing.Size(164, 22);
            this.ToolStripMenuItemDogma2.Text = "Grupo DOGMA2";
            this.ToolStripMenuItemDogma2.Click += new System.EventHandler(this.ToolStripMenuItemDogma2_Click);
            // 
            // toolStripMenuItemSalir
            // 
            this.toolStripMenuItemSalir.Name = "toolStripMenuItemSalir";
            this.toolStripMenuItemSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItemSalir.Size = new System.Drawing.Size(41, 20);
            this.toolStripMenuItemSalir.Text = "Salir";
            this.toolStripMenuItemSalir.Click += new System.EventHandler(this.toolStripMenuItemSalir_Click);
            // 
            // eevappLogo
            // 
            this.eevappLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.eevappLogo.BackColor = System.Drawing.Color.Transparent;
            this.eevappLogo.Image = ((System.Drawing.Image)(resources.GetObject("eevappLogo.Image")));
            this.eevappLogo.Location = new System.Drawing.Point(673, 412);
            this.eevappLogo.Name = "eevappLogo";
            this.eevappLogo.Size = new System.Drawing.Size(146, 41);
            this.eevappLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eevappLogo.TabIndex = 1;
            this.eevappLogo.TabStop = false;
            // 
            // asociaciationLogo
            // 
            this.asociaciationLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.asociaciationLogo.BackColor = System.Drawing.Color.Transparent;
            this.asociaciationLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("asociaciationLogo.ErrorImage")));
            this.asociaciationLogo.Image = ((System.Drawing.Image)(resources.GetObject("asociaciationLogo.Image")));
            this.asociaciationLogo.Location = new System.Drawing.Point(223, 108);
            this.asociaciationLogo.Name = "asociaciationLogo";
            this.asociaciationLogo.Size = new System.Drawing.Size(362, 256);
            this.asociaciationLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.asociaciationLogo.TabIndex = 2;
            this.asociaciationLogo.TabStop = false;
            // 
            // eevappDataURL
            // 
            this.eevappDataURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eevappDataURL.AutoSize = true;
            this.eevappDataURL.BackColor = System.Drawing.Color.Transparent;
            this.eevappDataURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eevappDataURL.ForeColor = System.Drawing.Color.White;
            this.eevappDataURL.Location = new System.Drawing.Point(22, 417);
            this.eevappDataURL.Name = "eevappDataURL";
            this.eevappDataURL.Size = new System.Drawing.Size(115, 15);
            this.eevappDataURL.TabIndex = 3;
            this.eevappDataURL.Text = "https://eevapp.es";
            this.eevappDataURL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // eevappDataEmail
            // 
            this.eevappDataEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eevappDataEmail.AutoSize = true;
            this.eevappDataEmail.BackColor = System.Drawing.Color.Transparent;
            this.eevappDataEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eevappDataEmail.ForeColor = System.Drawing.Color.White;
            this.eevappDataEmail.Location = new System.Drawing.Point(22, 434);
            this.eevappDataEmail.Name = "eevappDataEmail";
            this.eevappDataEmail.Size = new System.Drawing.Size(109, 15);
            this.eevappDataEmail.TabIndex = 5;
            this.eevappDataEmail.Text = "info@eevapp.es";
            this.eevappDataEmail.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLogin.BackColor = System.Drawing.Color.OliveDrab;
            this.groupBoxLogin.Controls.Add(this.buttonIngresar);
            this.groupBoxLogin.Controls.Add(this.buttonCancelar);
            this.groupBoxLogin.Controls.Add(this.textBoxClave);
            this.groupBoxLogin.Controls.Add(this.textBoxUsuario);
            this.groupBoxLogin.Controls.Add(this.labelClave);
            this.groupBoxLogin.Controls.Add(this.labelUsuario);
            this.groupBoxLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxLogin.Location = new System.Drawing.Point(545, 52);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(263, 149);
            this.groupBoxLogin.TabIndex = 6;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Login";
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonIngresar.Location = new System.Drawing.Point(168, 106);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(75, 23);
            this.buttonIngresar.TabIndex = 11;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCancelar.Location = new System.Drawing.Point(20, 106);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBoxClave
            // 
            this.textBoxClave.Location = new System.Drawing.Point(93, 67);
            this.textBoxClave.Name = "textBoxClave";
            this.textBoxClave.PasswordChar = '*';
            this.textBoxClave.Size = new System.Drawing.Size(150, 20);
            this.textBoxClave.TabIndex = 9;
            this.textBoxClave.Text = "P!nt@lo20#20";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(93, 29);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(150, 20);
            this.textBoxUsuario.TabIndex = 8;
            this.textBoxUsuario.Text = "SuperAdmin";
            // 
            // labelClave
            // 
            this.labelClave.AutoSize = true;
            this.labelClave.Location = new System.Drawing.Point(17, 70);
            this.labelClave.Name = "labelClave";
            this.labelClave.Size = new System.Drawing.Size(61, 13);
            this.labelClave.TabIndex = 7;
            this.labelClave.Text = "Contraseña";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(17, 32);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(43, 13);
            this.labelUsuario.TabIndex = 6;
            this.labelUsuario.Text = "Usuario";
            // 
            // MainStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 470);
            this.Controls.Add(this.groupBoxLogin);
            this.Controls.Add(this.eevappDataEmail);
            this.Controls.Add(this.eevappDataURL);
            this.Controls.Add(this.asociaciationLogo);
            this.Controls.Add(this.eevappLogo);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainStartForm";
            this.Text = "Chrysallys Events Manager App (eevapp)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eevappLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asociaciationLogo)).EndInit();
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEventos;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDatosInteres;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSocios;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelegaciones;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdministradores;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDatosAsociacion;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTraducciones;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemConfiguracionInicial;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSalir;
        private System.Windows.Forms.PictureBox eevappLogo;
        private System.Windows.Forms.PictureBox asociaciationLogo;
        private System.Windows.Forms.Label eevappDataURL;
        private System.Windows.Forms.Label eevappDataEmail;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAboutUs;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEevapp;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDogma2;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxClave;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label labelClave;
        private System.Windows.Forms.Label labelUsuario;
    }
}

