namespace EEVAPPDsktp.Forms
{
    partial class SociosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SociosForm));
            this.buttonAlmacenar = new System.Windows.Forms.Button();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.dateTimePickerFechaEstado = new System.Windows.Forms.DateTimePicker();
            this.labelFechaEstado = new System.Windows.Forms.Label();
            this.comboBoxDelegacion = new System.Windows.Forms.ComboBox();
            this.bindingSourceDelegaciones = new System.Windows.Forms.BindingSource(this.components);
            this.labelDelegacion = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxNotaEstado = new System.Windows.Forms.TextBox();
            this.labelNotaEstado = new System.Windows.Forms.Label();
            this.checkBoxActivado = new System.Windows.Forms.CheckBox();
            this.labelActivado = new System.Windows.Forms.Label();
            this.textBoxCodigoUsuario = new System.Windows.Forms.TextBox();
            this.labelCodigoUsuario = new System.Windows.Forms.Label();
            this.groupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDelegaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAlmacenar
            // 
            this.buttonAlmacenar.Location = new System.Drawing.Point(674, 168);
            this.buttonAlmacenar.Name = "buttonAlmacenar";
            this.buttonAlmacenar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlmacenar.TabIndex = 99;
            this.buttonAlmacenar.Text = "Almacenar";
            this.buttonAlmacenar.UseVisualStyleBackColor = true;
            this.buttonAlmacenar.Click += new System.EventHandler(this.buttonAlmacenar_Click);
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.dateTimePickerFechaEstado);
            this.groupBoxDatos.Controls.Add(this.labelFechaEstado);
            this.groupBoxDatos.Controls.Add(this.comboBoxDelegacion);
            this.groupBoxDatos.Controls.Add(this.labelDelegacion);
            this.groupBoxDatos.Controls.Add(this.textBoxEmail);
            this.groupBoxDatos.Controls.Add(this.labelEmail);
            this.groupBoxDatos.Controls.Add(this.textBoxNotaEstado);
            this.groupBoxDatos.Controls.Add(this.labelNotaEstado);
            this.groupBoxDatos.Controls.Add(this.checkBoxActivado);
            this.groupBoxDatos.Controls.Add(this.labelActivado);
            this.groupBoxDatos.Controls.Add(this.textBoxCodigoUsuario);
            this.groupBoxDatos.Controls.Add(this.labelCodigoUsuario);
            this.groupBoxDatos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxDatos.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(737, 141);
            this.groupBoxDatos.TabIndex = 0;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos Socio";
            // 
            // dateTimePickerFechaEstado
            // 
            this.dateTimePickerFechaEstado.Location = new System.Drawing.Point(18, 101);
            this.dateTimePickerFechaEstado.Name = "dateTimePickerFechaEstado";
            this.dateTimePickerFechaEstado.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaEstado.TabIndex = 14;
            this.dateTimePickerFechaEstado.ValueChanged += new System.EventHandler(this.dateTimePickerFechaEstado_ValueChanged);
            // 
            // labelFechaEstado
            // 
            this.labelFechaEstado.AutoSize = true;
            this.labelFechaEstado.Location = new System.Drawing.Point(14, 84);
            this.labelFechaEstado.Name = "labelFechaEstado";
            this.labelFechaEstado.Size = new System.Drawing.Size(88, 13);
            this.labelFechaEstado.TabIndex = 0;
            this.labelFechaEstado.Text = "Fecha de Estado";
            // 
            // comboBoxDelegacion
            // 
            this.comboBoxDelegacion.DataSource = this.bindingSourceDelegaciones;
            this.comboBoxDelegacion.DisplayMember = "nombre";
            this.comboBoxDelegacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDelegacion.FormattingEnabled = true;
            this.comboBoxDelegacion.Location = new System.Drawing.Point(456, 45);
            this.comboBoxDelegacion.Name = "comboBoxDelegacion";
            this.comboBoxDelegacion.Size = new System.Drawing.Size(197, 21);
            this.comboBoxDelegacion.TabIndex = 12;
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
            this.labelDelegacion.Location = new System.Drawing.Point(453, 29);
            this.labelDelegacion.Name = "labelDelegacion";
            this.labelDelegacion.Size = new System.Drawing.Size(61, 13);
            this.labelDelegacion.TabIndex = 0;
            this.labelDelegacion.Text = "Delegación";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(137, 45);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(297, 20);
            this.textBoxEmail.TabIndex = 11;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(134, 28);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email";
            // 
            // textBoxNotaEstado
            // 
            this.textBoxNotaEstado.Location = new System.Drawing.Point(238, 101);
            this.textBoxNotaEstado.Name = "textBoxNotaEstado";
            this.textBoxNotaEstado.Size = new System.Drawing.Size(483, 20);
            this.textBoxNotaEstado.TabIndex = 15;
            this.textBoxNotaEstado.TextChanged += new System.EventHandler(this.textBoxNotaEstado_TextChanged);
            // 
            // labelNotaEstado
            // 
            this.labelNotaEstado.AutoSize = true;
            this.labelNotaEstado.Location = new System.Drawing.Point(235, 84);
            this.labelNotaEstado.Name = "labelNotaEstado";
            this.labelNotaEstado.Size = new System.Drawing.Size(81, 13);
            this.labelNotaEstado.TabIndex = 0;
            this.labelNotaEstado.Text = "Nota de Estado";
            // 
            // checkBoxActivado
            // 
            this.checkBoxActivado.AutoSize = true;
            this.checkBoxActivado.Location = new System.Drawing.Point(690, 49);
            this.checkBoxActivado.Name = "checkBoxActivado";
            this.checkBoxActivado.Size = new System.Drawing.Size(15, 14);
            this.checkBoxActivado.TabIndex = 13;
            this.checkBoxActivado.UseVisualStyleBackColor = true;
            this.checkBoxActivado.CheckedChanged += new System.EventHandler(this.checkBoxActivado_CheckedChanged);
            // 
            // labelActivado
            // 
            this.labelActivado.AutoSize = true;
            this.labelActivado.Location = new System.Drawing.Point(672, 29);
            this.labelActivado.Name = "labelActivado";
            this.labelActivado.Size = new System.Drawing.Size(49, 13);
            this.labelActivado.TabIndex = 0;
            this.labelActivado.Text = "Activado";
            // 
            // textBoxCodigoUsuario
            // 
            this.textBoxCodigoUsuario.Location = new System.Drawing.Point(18, 45);
            this.textBoxCodigoUsuario.Name = "textBoxCodigoUsuario";
            this.textBoxCodigoUsuario.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoUsuario.TabIndex = 10;
            this.textBoxCodigoUsuario.TextChanged += new System.EventHandler(this.textBoxCodigoUsuario_TextChanged);
            // 
            // labelCodigoUsuario
            // 
            this.labelCodigoUsuario.AutoSize = true;
            this.labelCodigoUsuario.Location = new System.Drawing.Point(15, 28);
            this.labelCodigoUsuario.Name = "labelCodigoUsuario";
            this.labelCodigoUsuario.Size = new System.Drawing.Size(94, 13);
            this.labelCodigoUsuario.TabIndex = 0;
            this.labelCodigoUsuario.Text = "Código de Usuario";
            // 
            // SociosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(762, 207);
            this.Controls.Add(this.buttonAlmacenar);
            this.Controls.Add(this.groupBoxDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SociosForm";
            this.Text = "SociosForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SociosForm_FormClosed);
            this.Load += new System.EventHandler(this.SociosForm_Load);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDelegaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAlmacenar;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.Label labelFechaEstado;
        private System.Windows.Forms.ComboBox comboBoxDelegacion;
        private System.Windows.Forms.Label labelDelegacion;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxNotaEstado;
        private System.Windows.Forms.Label labelNotaEstado;
        private System.Windows.Forms.CheckBox checkBoxActivado;
        private System.Windows.Forms.Label labelActivado;
        private System.Windows.Forms.TextBox textBoxCodigoUsuario;
        private System.Windows.Forms.Label labelCodigoUsuario;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaEstado;
        private System.Windows.Forms.BindingSource bindingSourceDelegaciones;
    }
}