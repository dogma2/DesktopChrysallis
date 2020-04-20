namespace EEVAPPDsktp.Forms
{
    partial class DetallesEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetallesEvento));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSeleccionarImagen = new System.Windows.Forms.Button();
            this.pictureBoxImagenEvento = new System.Windows.Forms.PictureBox();
            this.labelSalir = new System.Windows.Forms.Label();
            this.groupBoxDocumentos = new System.Windows.Forms.GroupBox();
            this.buttonEliminarDocumento = new System.Windows.Forms.Button();
            this.buttonAgregarDocumento = new System.Windows.Forms.Button();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.checkBoxGlobal = new System.Windows.Forms.CheckBox();
            this.checkBoxActivado = new System.Windows.Forms.CheckBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelGlobal = new System.Windows.Forms.Label();
            this.labelActivo = new System.Windows.Forms.Label();
            this.richTextBoxDescripcion = new System.Windows.Forms.RichTextBox();
            this.richTextBoxIntroduccion = new System.Windows.Forms.RichTextBox();
            this.richTextBoxTransporte = new System.Windows.Forms.RichTextBox();
            this.labelIntroduccion = new System.Windows.Forms.Label();
            this.labelTransporte = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxHoraInicio = new System.Windows.Forms.TextBox();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.labelHoraInicio = new System.Windows.Forms.Label();
            this.labelFechaFin = new System.Windows.Forms.Label();
            this.labelHoraFin = new System.Windows.Forms.Label();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.textBoxCodigoPostal = new System.Windows.Forms.TextBox();
            this.labelCiudad = new System.Windows.Forms.Label();
            this.labelCodigoPostal = new System.Windows.Forms.Label();
            this.labelProvincia = new System.Windows.Forms.Label();
            this.labelComunidadAutonoma = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxContacto = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelPersonaContacto = new System.Windows.Forms.Label();
            this.buttonGuardarEvento = new System.Windows.Forms.Button();
            this.buttonCancelarEvento = new System.Windows.Forms.Button();
            this.textBoxInscritos = new System.Windows.Forms.TextBox();
            this.textBoxAsistentes = new System.Windows.Forms.TextBox();
            this.buttonGestionar = new System.Windows.Forms.Button();
            this.labelInscritos = new System.Windows.Forms.Label();
            this.labelAsistentes = new System.Windows.Forms.Label();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaFin = new System.Windows.Forms.DateTimePicker();
            this.textBoxHoraFin = new System.Windows.Forms.TextBox();
            this.bindingSourceComunidades = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxComunidad = new System.Windows.Forms.ComboBox();
            this.comboBoxProvincia = new System.Windows.Forms.ComboBox();
            this.bindingSourceProvincias = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceDelegaciones = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxDelegacion = new System.Windows.Forms.ComboBox();
            this.labelDelegacion = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenEvento)).BeginInit();
            this.groupBoxDocumentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProvincias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDelegaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSeleccionarImagen);
            this.groupBox1.Controls.Add(this.pictureBoxImagenEvento);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(35, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imágen";
            // 
            // buttonSeleccionarImagen
            // 
            this.buttonSeleccionarImagen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSeleccionarImagen.Location = new System.Drawing.Point(111, 171);
            this.buttonSeleccionarImagen.Name = "buttonSeleccionarImagen";
            this.buttonSeleccionarImagen.Size = new System.Drawing.Size(75, 23);
            this.buttonSeleccionarImagen.TabIndex = 1;
            this.buttonSeleccionarImagen.Text = "Seleccionar";
            this.buttonSeleccionarImagen.UseVisualStyleBackColor = true;
            this.buttonSeleccionarImagen.Click += new System.EventHandler(this.buttonSeleccionarImagen_Click);
            // 
            // pictureBoxImagenEvento
            // 
            this.pictureBoxImagenEvento.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxImagenEvento.Name = "pictureBoxImagenEvento";
            this.pictureBoxImagenEvento.Size = new System.Drawing.Size(179, 146);
            this.pictureBoxImagenEvento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagenEvento.TabIndex = 0;
            this.pictureBoxImagenEvento.TabStop = false;
            // 
            // labelSalir
            // 
            this.labelSalir.AutoSize = true;
            this.labelSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSalir.Location = new System.Drawing.Point(13, 13);
            this.labelSalir.Name = "labelSalir";
            this.labelSalir.Size = new System.Drawing.Size(27, 13);
            this.labelSalir.TabIndex = 1;
            this.labelSalir.Text = "Salir";
            this.labelSalir.Click += new System.EventHandler(this.labelSalir_Click);
            // 
            // groupBoxDocumentos
            // 
            this.groupBoxDocumentos.Controls.Add(this.buttonEliminarDocumento);
            this.groupBoxDocumentos.Controls.Add(this.buttonAgregarDocumento);
            this.groupBoxDocumentos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxDocumentos.Location = new System.Drawing.Point(35, 255);
            this.groupBoxDocumentos.Name = "groupBoxDocumentos";
            this.groupBoxDocumentos.Size = new System.Drawing.Size(192, 204);
            this.groupBoxDocumentos.TabIndex = 2;
            this.groupBoxDocumentos.TabStop = false;
            this.groupBoxDocumentos.Text = "Documentos";
            // 
            // buttonEliminarDocumento
            // 
            this.buttonEliminarDocumento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEliminarDocumento.Location = new System.Drawing.Point(30, 175);
            this.buttonEliminarDocumento.Name = "buttonEliminarDocumento";
            this.buttonEliminarDocumento.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminarDocumento.TabIndex = 3;
            this.buttonEliminarDocumento.Text = "Eliminar";
            this.buttonEliminarDocumento.UseVisualStyleBackColor = true;
            // 
            // buttonAgregarDocumento
            // 
            this.buttonAgregarDocumento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAgregarDocumento.Location = new System.Drawing.Point(111, 175);
            this.buttonAgregarDocumento.Name = "buttonAgregarDocumento";
            this.buttonAgregarDocumento.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregarDocumento.TabIndex = 0;
            this.buttonAgregarDocumento.Text = "Agregar";
            this.buttonAgregarDocumento.UseVisualStyleBackColor = true;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(249, 41);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(673, 20);
            this.textBoxTitulo.TabIndex = 3;
            // 
            // checkBoxGlobal
            // 
            this.checkBoxGlobal.AutoSize = true;
            this.checkBoxGlobal.Location = new System.Drawing.Point(957, 43);
            this.checkBoxGlobal.Name = "checkBoxGlobal";
            this.checkBoxGlobal.Size = new System.Drawing.Size(15, 14);
            this.checkBoxGlobal.TabIndex = 4;
            this.checkBoxGlobal.UseVisualStyleBackColor = true;
            // 
            // checkBoxActivado
            // 
            this.checkBoxActivado.AutoSize = true;
            this.checkBoxActivado.Location = new System.Drawing.Point(999, 43);
            this.checkBoxActivado.Name = "checkBoxActivado";
            this.checkBoxActivado.Size = new System.Drawing.Size(15, 14);
            this.checkBoxActivado.TabIndex = 5;
            this.checkBoxActivado.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBoxActivado.UseVisualStyleBackColor = true;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTitulo.Location = new System.Drawing.Point(246, 25);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(35, 13);
            this.labelTitulo.TabIndex = 6;
            this.labelTitulo.Text = "Título";
            // 
            // labelGlobal
            // 
            this.labelGlobal.AutoSize = true;
            this.labelGlobal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelGlobal.Location = new System.Drawing.Point(945, 27);
            this.labelGlobal.Name = "labelGlobal";
            this.labelGlobal.Size = new System.Drawing.Size(37, 13);
            this.labelGlobal.TabIndex = 7;
            this.labelGlobal.Text = "Global";
            // 
            // labelActivo
            // 
            this.labelActivo.AutoSize = true;
            this.labelActivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelActivo.Location = new System.Drawing.Point(988, 27);
            this.labelActivo.Name = "labelActivo";
            this.labelActivo.Size = new System.Drawing.Size(37, 13);
            this.labelActivo.TabIndex = 8;
            this.labelActivo.Text = "Activo";
            // 
            // richTextBoxDescripcion
            // 
            this.richTextBoxDescripcion.Location = new System.Drawing.Point(249, 91);
            this.richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            this.richTextBoxDescripcion.Size = new System.Drawing.Size(765, 96);
            this.richTextBoxDescripcion.TabIndex = 9;
            this.richTextBoxDescripcion.Text = "";
            // 
            // richTextBoxIntroduccion
            // 
            this.richTextBoxIntroduccion.Location = new System.Drawing.Point(249, 220);
            this.richTextBoxIntroduccion.Name = "richTextBoxIntroduccion";
            this.richTextBoxIntroduccion.Size = new System.Drawing.Size(358, 168);
            this.richTextBoxIntroduccion.TabIndex = 10;
            this.richTextBoxIntroduccion.Text = "";
            // 
            // richTextBoxTransporte
            // 
            this.richTextBoxTransporte.Location = new System.Drawing.Point(644, 220);
            this.richTextBoxTransporte.Name = "richTextBoxTransporte";
            this.richTextBoxTransporte.Size = new System.Drawing.Size(370, 168);
            this.richTextBoxTransporte.TabIndex = 11;
            this.richTextBoxTransporte.Text = "";
            // 
            // labelIntroduccion
            // 
            this.labelIntroduccion.AutoSize = true;
            this.labelIntroduccion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelIntroduccion.Location = new System.Drawing.Point(249, 201);
            this.labelIntroduccion.Name = "labelIntroduccion";
            this.labelIntroduccion.Size = new System.Drawing.Size(66, 13);
            this.labelIntroduccion.TabIndex = 12;
            this.labelIntroduccion.Text = "Introducción";
            // 
            // labelTransporte
            // 
            this.labelTransporte.AutoSize = true;
            this.labelTransporte.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTransporte.Location = new System.Drawing.Point(641, 201);
            this.labelTransporte.Name = "labelTransporte";
            this.labelTransporte.Size = new System.Drawing.Size(85, 13);
            this.labelTransporte.TabIndex = 13;
            this.labelTransporte.Text = "Notas transporte";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDescripcion.Location = new System.Drawing.Point(249, 75);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcion.TabIndex = 14;
            this.labelDescripcion.Text = "Descripción";
            // 
            // textBoxHoraInicio
            // 
            this.textBoxHoraInicio.Location = new System.Drawing.Point(393, 414);
            this.textBoxHoraInicio.Name = "textBoxHoraInicio";
            this.textBoxHoraInicio.Size = new System.Drawing.Size(93, 20);
            this.textBoxHoraInicio.TabIndex = 16;
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFechaInicio.Location = new System.Drawing.Point(249, 398);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(64, 13);
            this.labelFechaInicio.TabIndex = 19;
            this.labelFechaInicio.Text = "Fecha inicio";
            // 
            // labelHoraInicio
            // 
            this.labelHoraInicio.AutoSize = true;
            this.labelHoraInicio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelHoraInicio.Location = new System.Drawing.Point(390, 398);
            this.labelHoraInicio.Name = "labelHoraInicio";
            this.labelHoraInicio.Size = new System.Drawing.Size(57, 13);
            this.labelHoraInicio.TabIndex = 20;
            this.labelHoraInicio.Text = "Hora inicio";
            // 
            // labelFechaFin
            // 
            this.labelFechaFin.AutoSize = true;
            this.labelFechaFin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFechaFin.Location = new System.Drawing.Point(520, 397);
            this.labelFechaFin.Name = "labelFechaFin";
            this.labelFechaFin.Size = new System.Drawing.Size(92, 13);
            this.labelFechaFin.TabIndex = 21;
            this.labelFechaFin.Text = "Fecha finalización";
            // 
            // labelHoraFin
            // 
            this.labelHoraFin.AutoSize = true;
            this.labelHoraFin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelHoraFin.Location = new System.Drawing.Point(662, 397);
            this.labelHoraFin.Name = "labelHoraFin";
            this.labelHoraFin.Size = new System.Drawing.Size(85, 13);
            this.labelHoraFin.TabIndex = 22;
            this.labelHoraFin.Text = "Hora finalización";
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(708, 462);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(198, 20);
            this.textBoxCiudad.TabIndex = 23;
            // 
            // textBoxCodigoPostal
            // 
            this.textBoxCodigoPostal.Location = new System.Drawing.Point(927, 462);
            this.textBoxCodigoPostal.Name = "textBoxCodigoPostal";
            this.textBoxCodigoPostal.Size = new System.Drawing.Size(85, 20);
            this.textBoxCodigoPostal.TabIndex = 24;
            // 
            // labelCiudad
            // 
            this.labelCiudad.AutoSize = true;
            this.labelCiudad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCiudad.Location = new System.Drawing.Point(708, 444);
            this.labelCiudad.Name = "labelCiudad";
            this.labelCiudad.Size = new System.Drawing.Size(40, 13);
            this.labelCiudad.TabIndex = 27;
            this.labelCiudad.Text = "Ciudad";
            // 
            // labelCodigoPostal
            // 
            this.labelCodigoPostal.AutoSize = true;
            this.labelCodigoPostal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCodigoPostal.Location = new System.Drawing.Point(927, 446);
            this.labelCodigoPostal.Name = "labelCodigoPostal";
            this.labelCodigoPostal.Size = new System.Drawing.Size(72, 13);
            this.labelCodigoPostal.TabIndex = 28;
            this.labelCodigoPostal.Text = "Código Postal";
            // 
            // labelProvincia
            // 
            this.labelProvincia.AutoSize = true;
            this.labelProvincia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelProvincia.Location = new System.Drawing.Point(482, 443);
            this.labelProvincia.Name = "labelProvincia";
            this.labelProvincia.Size = new System.Drawing.Size(51, 13);
            this.labelProvincia.TabIndex = 29;
            this.labelProvincia.Text = "Provincia";
            // 
            // labelComunidadAutonoma
            // 
            this.labelComunidadAutonoma.AutoSize = true;
            this.labelComunidadAutonoma.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelComunidadAutonoma.Location = new System.Drawing.Point(246, 444);
            this.labelComunidadAutonoma.Name = "labelComunidadAutonoma";
            this.labelComunidadAutonoma.Size = new System.Drawing.Size(111, 13);
            this.labelComunidadAutonoma.TabIndex = 30;
            this.labelComunidadAutonoma.Text = "Comunidad Autónoma";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(249, 500);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(304, 20);
            this.textBoxEmail.TabIndex = 31;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(571, 500);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(155, 20);
            this.textBoxTelefono.TabIndex = 32;
            // 
            // textBoxContacto
            // 
            this.textBoxContacto.Location = new System.Drawing.Point(746, 500);
            this.textBoxContacto.Name = "textBoxContacto";
            this.textBoxContacto.Size = new System.Drawing.Size(268, 20);
            this.textBoxContacto.TabIndex = 33;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEmail.Location = new System.Drawing.Point(249, 486);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 34;
            this.labelEmail.Text = "Email";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTelefono.Location = new System.Drawing.Point(568, 486);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(49, 13);
            this.labelTelefono.TabIndex = 35;
            this.labelTelefono.Text = "Teléfono";
            // 
            // labelPersonaContacto
            // 
            this.labelPersonaContacto.AutoSize = true;
            this.labelPersonaContacto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPersonaContacto.Location = new System.Drawing.Point(749, 486);
            this.labelPersonaContacto.Name = "labelPersonaContacto";
            this.labelPersonaContacto.Size = new System.Drawing.Size(106, 13);
            this.labelPersonaContacto.TabIndex = 36;
            this.labelPersonaContacto.Text = "Persona de contacto";
            // 
            // buttonGuardarEvento
            // 
            this.buttonGuardarEvento.Location = new System.Drawing.Point(939, 526);
            this.buttonGuardarEvento.Name = "buttonGuardarEvento";
            this.buttonGuardarEvento.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardarEvento.TabIndex = 37;
            this.buttonGuardarEvento.Text = "Guardar";
            this.buttonGuardarEvento.UseVisualStyleBackColor = true;
            this.buttonGuardarEvento.Click += new System.EventHandler(this.buttonGuardarEvento_Click);
            // 
            // buttonCancelarEvento
            // 
            this.buttonCancelarEvento.Location = new System.Drawing.Point(842, 525);
            this.buttonCancelarEvento.Name = "buttonCancelarEvento";
            this.buttonCancelarEvento.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelarEvento.TabIndex = 38;
            this.buttonCancelarEvento.Text = "Cancelar";
            this.buttonCancelarEvento.UseVisualStyleBackColor = true;
            this.buttonCancelarEvento.Click += new System.EventHandler(this.buttonCancelarEvento_Click);
            // 
            // textBoxInscritos
            // 
            this.textBoxInscritos.Location = new System.Drawing.Point(25, 486);
            this.textBoxInscritos.Name = "textBoxInscritos";
            this.textBoxInscritos.Size = new System.Drawing.Size(53, 20);
            this.textBoxInscritos.TabIndex = 39;
            // 
            // textBoxAsistentes
            // 
            this.textBoxAsistentes.Location = new System.Drawing.Point(84, 486);
            this.textBoxAsistentes.Name = "textBoxAsistentes";
            this.textBoxAsistentes.Size = new System.Drawing.Size(62, 20);
            this.textBoxAsistentes.TabIndex = 40;
            // 
            // buttonGestionar
            // 
            this.buttonGestionar.Location = new System.Drawing.Point(152, 483);
            this.buttonGestionar.Name = "buttonGestionar";
            this.buttonGestionar.Size = new System.Drawing.Size(75, 23);
            this.buttonGestionar.TabIndex = 41;
            this.buttonGestionar.Text = "Gestionar";
            this.buttonGestionar.UseVisualStyleBackColor = true;
            // 
            // labelInscritos
            // 
            this.labelInscritos.AutoSize = true;
            this.labelInscritos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelInscritos.Location = new System.Drawing.Point(32, 470);
            this.labelInscritos.Name = "labelInscritos";
            this.labelInscritos.Size = new System.Drawing.Size(46, 13);
            this.labelInscritos.TabIndex = 42;
            this.labelInscritos.Text = "Inscritos";
            // 
            // labelAsistentes
            // 
            this.labelAsistentes.AutoSize = true;
            this.labelAsistentes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAsistentes.Location = new System.Drawing.Point(91, 470);
            this.labelAsistentes.Name = "labelAsistentes";
            this.labelAsistentes.Size = new System.Drawing.Size(55, 13);
            this.labelAsistentes.TabIndex = 43;
            this.labelAsistentes.Text = "Asistentes";
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInicio.Location = new System.Drawing.Point(249, 415);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(123, 20);
            this.dateTimePickerInicio.TabIndex = 44;
            this.dateTimePickerInicio.Value = new System.DateTime(2020, 4, 18, 0, 0, 0, 0);
            // 
            // dateTimePickerFechaFin
            // 
            this.dateTimePickerFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaFin.Location = new System.Drawing.Point(520, 414);
            this.dateTimePickerFechaFin.Name = "dateTimePickerFechaFin";
            this.dateTimePickerFechaFin.Size = new System.Drawing.Size(123, 20);
            this.dateTimePickerFechaFin.TabIndex = 45;
            // 
            // textBoxHoraFin
            // 
            this.textBoxHoraFin.Location = new System.Drawing.Point(662, 414);
            this.textBoxHoraFin.Name = "textBoxHoraFin";
            this.textBoxHoraFin.Size = new System.Drawing.Size(147, 20);
            this.textBoxHoraFin.TabIndex = 18;
            // 
            // bindingSourceComunidades
            // 
            this.bindingSourceComunidades.DataSource = typeof(EEVAPPDsktp.CCAA);
            // 
            // comboBoxComunidad
            // 
            this.comboBoxComunidad.DataSource = this.bindingSourceComunidades;
            this.comboBoxComunidad.DisplayMember = "nombre";
            this.comboBoxComunidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComunidad.FormattingEnabled = true;
            this.comboBoxComunidad.ItemHeight = 13;
            this.comboBoxComunidad.Location = new System.Drawing.Point(249, 462);
            this.comboBoxComunidad.Name = "comboBoxComunidad";
            this.comboBoxComunidad.Size = new System.Drawing.Size(213, 21);
            this.comboBoxComunidad.TabIndex = 46;
            this.comboBoxComunidad.ValueMember = "id";
            this.comboBoxComunidad.SelectedIndexChanged += new System.EventHandler(this.comboBoxComunidad_SelectedIndexChanged);
            // 
            // comboBoxProvincia
            // 
            this.comboBoxProvincia.DataSource = this.bindingSourceProvincias;
            this.comboBoxProvincia.DisplayMember = "nombre";
            this.comboBoxProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProvincia.FormattingEnabled = true;
            this.comboBoxProvincia.Location = new System.Drawing.Point(485, 462);
            this.comboBoxProvincia.Name = "comboBoxProvincia";
            this.comboBoxProvincia.Size = new System.Drawing.Size(207, 21);
            this.comboBoxProvincia.TabIndex = 47;
            this.comboBoxProvincia.ValueMember = "id";
            // 
            // bindingSourceProvincias
            // 
            this.bindingSourceProvincias.DataSource = typeof(EEVAPPDsktp.PROVINCIAS);
            // 
            // bindingSourceDelegaciones
            // 
            this.bindingSourceDelegaciones.DataSource = typeof(EEVAPPDsktp.DELEGACIONES);
            // 
            // comboBoxDelegacion
            // 
            this.comboBoxDelegacion.DataSource = this.bindingSourceDelegaciones;
            this.comboBoxDelegacion.DisplayMember = "nombre";
            this.comboBoxDelegacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDelegacion.FormattingEnabled = true;
            this.comboBoxDelegacion.Location = new System.Drawing.Point(840, 413);
            this.comboBoxDelegacion.Name = "comboBoxDelegacion";
            this.comboBoxDelegacion.Size = new System.Drawing.Size(174, 21);
            this.comboBoxDelegacion.TabIndex = 49;
            this.comboBoxDelegacion.ValueMember = "id";
            // 
            // labelDelegacion
            // 
            this.labelDelegacion.AutoSize = true;
            this.labelDelegacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDelegacion.Location = new System.Drawing.Point(837, 397);
            this.labelDelegacion.Name = "labelDelegacion";
            this.labelDelegacion.Size = new System.Drawing.Size(61, 13);
            this.labelDelegacion.TabIndex = 48;
            this.labelDelegacion.Text = "Delegación";
            // 
            // DetallesEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1048, 569);
            this.Controls.Add(this.comboBoxDelegacion);
            this.Controls.Add(this.labelDelegacion);
            this.Controls.Add(this.comboBoxComunidad);
            this.Controls.Add(this.dateTimePickerFechaFin);
            this.Controls.Add(this.labelComunidadAutonoma);
            this.Controls.Add(this.comboBoxProvincia);
            this.Controls.Add(this.dateTimePickerInicio);
            this.Controls.Add(this.labelProvincia);
            this.Controls.Add(this.labelAsistentes);
            this.Controls.Add(this.labelInscritos);
            this.Controls.Add(this.buttonGestionar);
            this.Controls.Add(this.textBoxAsistentes);
            this.Controls.Add(this.textBoxInscritos);
            this.Controls.Add(this.buttonCancelarEvento);
            this.Controls.Add(this.buttonGuardarEvento);
            this.Controls.Add(this.labelPersonaContacto);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxContacto);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelCodigoPostal);
            this.Controls.Add(this.labelCiudad);
            this.Controls.Add(this.textBoxCodigoPostal);
            this.Controls.Add(this.textBoxCiudad);
            this.Controls.Add(this.labelHoraFin);
            this.Controls.Add(this.labelFechaFin);
            this.Controls.Add(this.labelHoraInicio);
            this.Controls.Add(this.labelFechaInicio);
            this.Controls.Add(this.textBoxHoraFin);
            this.Controls.Add(this.textBoxHoraInicio);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelTransporte);
            this.Controls.Add(this.labelIntroduccion);
            this.Controls.Add(this.richTextBoxTransporte);
            this.Controls.Add(this.richTextBoxIntroduccion);
            this.Controls.Add(this.richTextBoxDescripcion);
            this.Controls.Add(this.labelActivo);
            this.Controls.Add(this.labelGlobal);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.checkBoxActivado);
            this.Controls.Add(this.checkBoxGlobal);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.groupBoxDocumentos);
            this.Controls.Add(this.labelSalir);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetallesEvento";
            this.Text = "EVENTOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DetallesEvento_FormClosing);
            this.Load += new System.EventHandler(this.DetallesEvento_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenEvento)).EndInit();
            this.groupBoxDocumentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProvincias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDelegaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSeleccionarImagen;
        private System.Windows.Forms.PictureBox pictureBoxImagenEvento;
        private System.Windows.Forms.Label labelSalir;
        private System.Windows.Forms.GroupBox groupBoxDocumentos;
        private System.Windows.Forms.Button buttonEliminarDocumento;
        private System.Windows.Forms.Button buttonAgregarDocumento;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.CheckBox checkBoxGlobal;
        private System.Windows.Forms.CheckBox checkBoxActivado;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelGlobal;
        private System.Windows.Forms.Label labelActivo;
        private System.Windows.Forms.RichTextBox richTextBoxDescripcion;
        private System.Windows.Forms.RichTextBox richTextBoxIntroduccion;
        private System.Windows.Forms.RichTextBox richTextBoxTransporte;
        private System.Windows.Forms.Label labelIntroduccion;
        private System.Windows.Forms.Label labelTransporte;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textBoxHoraInicio;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.Label labelHoraInicio;
        private System.Windows.Forms.Label labelFechaFin;
        private System.Windows.Forms.Label labelHoraFin;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.TextBox textBoxCodigoPostal;
        private System.Windows.Forms.Label labelCiudad;
        private System.Windows.Forms.Label labelCodigoPostal;
        private System.Windows.Forms.Label labelProvincia;
        private System.Windows.Forms.Label labelComunidadAutonoma;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxContacto;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelPersonaContacto;
        private System.Windows.Forms.Button buttonGuardarEvento;
        private System.Windows.Forms.Button buttonCancelarEvento;
        private System.Windows.Forms.TextBox textBoxInscritos;
        private System.Windows.Forms.TextBox textBoxAsistentes;
        private System.Windows.Forms.Button buttonGestionar;
        private System.Windows.Forms.Label labelInscritos;
        private System.Windows.Forms.Label labelAsistentes;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFin;
        private System.Windows.Forms.TextBox textBoxHoraFin;
        private System.Windows.Forms.BindingSource bindingSourceComunidades;
        private System.Windows.Forms.ComboBox comboBoxComunidad;
        private System.Windows.Forms.ComboBox comboBoxProvincia;
        private System.Windows.Forms.BindingSource bindingSourceProvincias;
        private System.Windows.Forms.BindingSource bindingSourceDelegaciones;
        private System.Windows.Forms.ComboBox comboBoxDelegacion;
        private System.Windows.Forms.Label labelDelegacion;
    }
}