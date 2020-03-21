namespace EEVAPPDsktp.Forms
{
    partial class ConfiguracionInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfiguracionInicial));
            this.buttonAlmacenar = new System.Windows.Forms.Button();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.groupLang = new System.Windows.Forms.GroupBox();
            this.comboBoxLang = new System.Windows.Forms.ComboBox();
            this.labelLangText = new System.Windows.Forms.Label();
            this.checkBoxSound = new System.Windows.Forms.CheckBox();
            this.groupBoxAlert = new System.Windows.Forms.GroupBox();
            this.labelAlertFromSep = new System.Windows.Forms.Label();
            this.labelAlertToSep = new System.Windows.Forms.Label();
            this.textBoxAlertToMM = new System.Windows.Forms.TextBox();
            this.textBoxAlertFromMM = new System.Windows.Forms.TextBox();
            this.labelAlertToHs = new System.Windows.Forms.Label();
            this.labelAlertToText = new System.Windows.Forms.Label();
            this.textBoxAlertToHH = new System.Windows.Forms.TextBox();
            this.labelAlertFromHs = new System.Windows.Forms.Label();
            this.labelAlertFromText = new System.Windows.Forms.Label();
            this.textBoxAlertFromHH = new System.Windows.Forms.TextBox();
            this.checkBoxShortAlertAct = new System.Windows.Forms.CheckBox();
            this.checkBoxLongAlertAct = new System.Windows.Forms.CheckBox();
            this.labelShortAlertHs = new System.Windows.Forms.Label();
            this.labelShortAlertText = new System.Windows.Forms.Label();
            this.textBoxShortAlert = new System.Windows.Forms.TextBox();
            this.labelLongAlertHs = new System.Windows.Forms.Label();
            this.labelLongAlertText = new System.Windows.Forms.Label();
            this.textBoxLongAlert = new System.Windows.Forms.TextBox();
            this.groupBoxUpdate = new System.Windows.Forms.GroupBox();
            this.labelUpdateHs = new System.Windows.Forms.Label();
            this.labelUpdateText = new System.Windows.Forms.Label();
            this.textBoxUpdate = new System.Windows.Forms.TextBox();
            this.checkBoxGPS = new System.Windows.Forms.CheckBox();
            this.buttonUpLoad = new System.Windows.Forms.Button();
            this.groupBoxDatos.SuspendLayout();
            this.groupLang.SuspendLayout();
            this.groupBoxAlert.SuspendLayout();
            this.groupBoxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAlmacenar
            // 
            this.buttonAlmacenar.Location = new System.Drawing.Point(231, 500);
            this.buttonAlmacenar.Name = "buttonAlmacenar";
            this.buttonAlmacenar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlmacenar.TabIndex = 30;
            this.buttonAlmacenar.Text = "Almacenar";
            this.buttonAlmacenar.UseVisualStyleBackColor = true;
            this.buttonAlmacenar.Click += new System.EventHandler(this.buttonAlmacenar_Click);
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.groupLang);
            this.groupBoxDatos.Controls.Add(this.checkBoxSound);
            this.groupBoxDatos.Controls.Add(this.groupBoxAlert);
            this.groupBoxDatos.Controls.Add(this.groupBoxUpdate);
            this.groupBoxDatos.Controls.Add(this.checkBoxGPS);
            this.groupBoxDatos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxDatos.Location = new System.Drawing.Point(32, 23);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(274, 464);
            this.groupBoxDatos.TabIndex = 0;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos Configuración";
            // 
            // groupLang
            // 
            this.groupLang.Controls.Add(this.comboBoxLang);
            this.groupLang.Controls.Add(this.labelLangText);
            this.groupLang.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupLang.Location = new System.Drawing.Point(16, 65);
            this.groupLang.Name = "groupLang";
            this.groupLang.Size = new System.Drawing.Size(240, 68);
            this.groupLang.TabIndex = 0;
            this.groupLang.TabStop = false;
            this.groupLang.Text = "Idioma de App";
            // 
            // comboBoxLang
            // 
            this.comboBoxLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLang.FormattingEnabled = true;
            this.comboBoxLang.Items.AddRange(new object[] {
            "Castellano",
            "Catalá",
            "Euskera",
            "Galego"});
            this.comboBoxLang.Location = new System.Drawing.Point(114, 25);
            this.comboBoxLang.Name = "comboBoxLang";
            this.comboBoxLang.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLang.TabIndex = 3;
            this.comboBoxLang.SelectedIndexChanged += new System.EventHandler(this.comboBoxLang_SelectedIndexChanged);
            // 
            // labelLangText
            // 
            this.labelLangText.AutoSize = true;
            this.labelLangText.Location = new System.Drawing.Point(13, 28);
            this.labelLangText.Name = "labelLangText";
            this.labelLangText.Size = new System.Drawing.Size(95, 13);
            this.labelLangText.TabIndex = 0;
            this.labelLangText.Text = "Idioma por defecto";
            // 
            // checkBoxSound
            // 
            this.checkBoxSound.AutoSize = true;
            this.checkBoxSound.Location = new System.Drawing.Point(143, 29);
            this.checkBoxSound.Name = "checkBoxSound";
            this.checkBoxSound.Size = new System.Drawing.Size(113, 17);
            this.checkBoxSound.TabIndex = 2;
            this.checkBoxSound.Text = "SONIDO Activado";
            this.checkBoxSound.UseVisualStyleBackColor = true;
            this.checkBoxSound.CheckedChanged += new System.EventHandler(this.checkBoxSound_CheckedChanged);
            // 
            // groupBoxAlert
            // 
            this.groupBoxAlert.Controls.Add(this.labelAlertFromSep);
            this.groupBoxAlert.Controls.Add(this.labelAlertToSep);
            this.groupBoxAlert.Controls.Add(this.textBoxAlertToMM);
            this.groupBoxAlert.Controls.Add(this.textBoxAlertFromMM);
            this.groupBoxAlert.Controls.Add(this.labelAlertToHs);
            this.groupBoxAlert.Controls.Add(this.labelAlertToText);
            this.groupBoxAlert.Controls.Add(this.textBoxAlertToHH);
            this.groupBoxAlert.Controls.Add(this.labelAlertFromHs);
            this.groupBoxAlert.Controls.Add(this.labelAlertFromText);
            this.groupBoxAlert.Controls.Add(this.textBoxAlertFromHH);
            this.groupBoxAlert.Controls.Add(this.checkBoxShortAlertAct);
            this.groupBoxAlert.Controls.Add(this.checkBoxLongAlertAct);
            this.groupBoxAlert.Controls.Add(this.labelShortAlertHs);
            this.groupBoxAlert.Controls.Add(this.labelShortAlertText);
            this.groupBoxAlert.Controls.Add(this.textBoxShortAlert);
            this.groupBoxAlert.Controls.Add(this.labelLongAlertHs);
            this.groupBoxAlert.Controls.Add(this.labelLongAlertText);
            this.groupBoxAlert.Controls.Add(this.textBoxLongAlert);
            this.groupBoxAlert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxAlert.Location = new System.Drawing.Point(16, 240);
            this.groupBoxAlert.Name = "groupBoxAlert";
            this.groupBoxAlert.Size = new System.Drawing.Size(240, 205);
            this.groupBoxAlert.TabIndex = 0;
            this.groupBoxAlert.TabStop = false;
            this.groupBoxAlert.Text = "Notificaciones";
            // 
            // labelAlertFromSep
            // 
            this.labelAlertFromSep.AutoSize = true;
            this.labelAlertFromSep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlertFromSep.Location = new System.Drawing.Point(159, 124);
            this.labelAlertFromSep.Name = "labelAlertFromSep";
            this.labelAlertFromSep.Size = new System.Drawing.Size(13, 17);
            this.labelAlertFromSep.TabIndex = 0;
            this.labelAlertFromSep.Text = ":";
            // 
            // labelAlertToSep
            // 
            this.labelAlertToSep.AutoSize = true;
            this.labelAlertToSep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlertToSep.Location = new System.Drawing.Point(160, 163);
            this.labelAlertToSep.Name = "labelAlertToSep";
            this.labelAlertToSep.Size = new System.Drawing.Size(13, 17);
            this.labelAlertToSep.TabIndex = 0;
            this.labelAlertToSep.Text = ":";
            // 
            // textBoxAlertToMM
            // 
            this.textBoxAlertToMM.Location = new System.Drawing.Point(172, 163);
            this.textBoxAlertToMM.Name = "textBoxAlertToMM";
            this.textBoxAlertToMM.Size = new System.Drawing.Size(31, 20);
            this.textBoxAlertToMM.TabIndex = 12;
            this.textBoxAlertToMM.TextChanged += new System.EventHandler(this.textBoxAlertToMM_TextChanged);
            // 
            // textBoxAlertFromMM
            // 
            this.textBoxAlertFromMM.Location = new System.Drawing.Point(172, 124);
            this.textBoxAlertFromMM.Name = "textBoxAlertFromMM";
            this.textBoxAlertFromMM.Size = new System.Drawing.Size(31, 20);
            this.textBoxAlertFromMM.TabIndex = 10;
            this.textBoxAlertFromMM.TextChanged += new System.EventHandler(this.textBoxAlertFromMM_TextChanged);
            // 
            // labelAlertToHs
            // 
            this.labelAlertToHs.AutoSize = true;
            this.labelAlertToHs.Location = new System.Drawing.Point(209, 166);
            this.labelAlertToHs.Name = "labelAlertToHs";
            this.labelAlertToHs.Size = new System.Drawing.Size(22, 13);
            this.labelAlertToHs.TabIndex = 0;
            this.labelAlertToHs.Text = "HS";
            // 
            // labelAlertToText
            // 
            this.labelAlertToText.AutoSize = true;
            this.labelAlertToText.Location = new System.Drawing.Point(67, 166);
            this.labelAlertToText.Name = "labelAlertToText";
            this.labelAlertToText.Size = new System.Drawing.Size(49, 13);
            this.labelAlertToText.TabIndex = 0;
            this.labelAlertToText.Text = "hasta las";
            // 
            // textBoxAlertToHH
            // 
            this.textBoxAlertToHH.Location = new System.Drawing.Point(128, 163);
            this.textBoxAlertToHH.Name = "textBoxAlertToHH";
            this.textBoxAlertToHH.Size = new System.Drawing.Size(31, 20);
            this.textBoxAlertToHH.TabIndex = 11;
            this.textBoxAlertToHH.TextChanged += new System.EventHandler(this.textBoxAlertToHH_TextChanged);
            // 
            // labelAlertFromHs
            // 
            this.labelAlertFromHs.AutoSize = true;
            this.labelAlertFromHs.Location = new System.Drawing.Point(209, 127);
            this.labelAlertFromHs.Name = "labelAlertFromHs";
            this.labelAlertFromHs.Size = new System.Drawing.Size(22, 13);
            this.labelAlertFromHs.TabIndex = 0;
            this.labelAlertFromHs.Text = "HS";
            // 
            // labelAlertFromText
            // 
            this.labelAlertFromText.AutoSize = true;
            this.labelAlertFromText.Location = new System.Drawing.Point(13, 127);
            this.labelAlertFromText.Name = "labelAlertFromText";
            this.labelAlertFromText.Size = new System.Drawing.Size(103, 13);
            this.labelAlertFromText.TabIndex = 0;
            this.labelAlertFromText.Text = "Permitidas desde las";
            // 
            // textBoxAlertFromHH
            // 
            this.textBoxAlertFromHH.Location = new System.Drawing.Point(128, 124);
            this.textBoxAlertFromHH.Name = "textBoxAlertFromHH";
            this.textBoxAlertFromHH.Size = new System.Drawing.Size(31, 20);
            this.textBoxAlertFromHH.TabIndex = 9;
            this.textBoxAlertFromHH.TextChanged += new System.EventHandler(this.textBoxAlertFromHH_TextChanged);
            // 
            // checkBoxShortAlertAct
            // 
            this.checkBoxShortAlertAct.AutoSize = true;
            this.checkBoxShortAlertAct.Location = new System.Drawing.Point(16, 76);
            this.checkBoxShortAlertAct.Name = "checkBoxShortAlertAct";
            this.checkBoxShortAlertAct.Size = new System.Drawing.Size(15, 14);
            this.checkBoxShortAlertAct.TabIndex = 7;
            this.checkBoxShortAlertAct.UseVisualStyleBackColor = true;
            this.checkBoxShortAlertAct.CheckedChanged += new System.EventHandler(this.checkBoxShortAlertAct_CheckedChanged);
            // 
            // checkBoxLongAlertAct
            // 
            this.checkBoxLongAlertAct.AutoSize = true;
            this.checkBoxLongAlertAct.Location = new System.Drawing.Point(16, 36);
            this.checkBoxLongAlertAct.Name = "checkBoxLongAlertAct";
            this.checkBoxLongAlertAct.Size = new System.Drawing.Size(15, 14);
            this.checkBoxLongAlertAct.TabIndex = 5;
            this.checkBoxLongAlertAct.UseVisualStyleBackColor = true;
            this.checkBoxLongAlertAct.CheckedChanged += new System.EventHandler(this.checkBoxLongAlertAct_CheckedChanged);
            // 
            // labelShortAlertHs
            // 
            this.labelShortAlertHs.AutoSize = true;
            this.labelShortAlertHs.Location = new System.Drawing.Point(209, 77);
            this.labelShortAlertHs.Name = "labelShortAlertHs";
            this.labelShortAlertHs.Size = new System.Drawing.Size(22, 13);
            this.labelShortAlertHs.TabIndex = 0;
            this.labelShortAlertHs.Text = "HS";
            // 
            // labelShortAlertText
            // 
            this.labelShortAlertText.AutoSize = true;
            this.labelShortAlertText.Location = new System.Drawing.Point(36, 77);
            this.labelShortAlertText.Name = "labelShortAlertText";
            this.labelShortAlertText.Size = new System.Drawing.Size(130, 13);
            this.labelShortAlertText.TabIndex = 0;
            this.labelShortAlertText.Text = "Notificación CORTA cada";
            // 
            // textBoxShortAlert
            // 
            this.textBoxShortAlert.Location = new System.Drawing.Point(173, 74);
            this.textBoxShortAlert.Name = "textBoxShortAlert";
            this.textBoxShortAlert.Size = new System.Drawing.Size(31, 20);
            this.textBoxShortAlert.TabIndex = 8;
            this.textBoxShortAlert.TextChanged += new System.EventHandler(this.textBoxShortAlert_TextChanged);
            // 
            // labelLongAlertHs
            // 
            this.labelLongAlertHs.AutoSize = true;
            this.labelLongAlertHs.Location = new System.Drawing.Point(209, 36);
            this.labelLongAlertHs.Name = "labelLongAlertHs";
            this.labelLongAlertHs.Size = new System.Drawing.Size(22, 13);
            this.labelLongAlertHs.TabIndex = 0;
            this.labelLongAlertHs.Text = "HS";
            // 
            // labelLongAlertText
            // 
            this.labelLongAlertText.AutoSize = true;
            this.labelLongAlertText.Location = new System.Drawing.Point(36, 36);
            this.labelLongAlertText.Name = "labelLongAlertText";
            this.labelLongAlertText.Size = new System.Drawing.Size(129, 13);
            this.labelLongAlertText.TabIndex = 0;
            this.labelLongAlertText.Text = "Notificación LARGA cada";
            // 
            // textBoxLongAlert
            // 
            this.textBoxLongAlert.Location = new System.Drawing.Point(173, 33);
            this.textBoxLongAlert.Name = "textBoxLongAlert";
            this.textBoxLongAlert.Size = new System.Drawing.Size(31, 20);
            this.textBoxLongAlert.TabIndex = 6;
            this.textBoxLongAlert.TextChanged += new System.EventHandler(this.textBoxLongAlert_TextChanged);
            // 
            // groupBoxUpdate
            // 
            this.groupBoxUpdate.Controls.Add(this.labelUpdateHs);
            this.groupBoxUpdate.Controls.Add(this.labelUpdateText);
            this.groupBoxUpdate.Controls.Add(this.textBoxUpdate);
            this.groupBoxUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxUpdate.Location = new System.Drawing.Point(16, 153);
            this.groupBoxUpdate.Name = "groupBoxUpdate";
            this.groupBoxUpdate.Size = new System.Drawing.Size(240, 68);
            this.groupBoxUpdate.TabIndex = 0;
            this.groupBoxUpdate.TabStop = false;
            this.groupBoxUpdate.Text = "Períodos de actialización";
            // 
            // labelUpdateHs
            // 
            this.labelUpdateHs.AutoSize = true;
            this.labelUpdateHs.Location = new System.Drawing.Point(191, 31);
            this.labelUpdateHs.Name = "labelUpdateHs";
            this.labelUpdateHs.Size = new System.Drawing.Size(22, 13);
            this.labelUpdateHs.TabIndex = 0;
            this.labelUpdateHs.Text = "HS";
            // 
            // labelUpdateText
            // 
            this.labelUpdateText.AutoSize = true;
            this.labelUpdateText.Location = new System.Drawing.Point(13, 31);
            this.labelUpdateText.Name = "labelUpdateText";
            this.labelUpdateText.Size = new System.Drawing.Size(137, 13);
            this.labelUpdateText.TabIndex = 0;
            this.labelUpdateText.Text = "Actualizar información cada";
            // 
            // textBoxUpdate
            // 
            this.textBoxUpdate.Location = new System.Drawing.Point(155, 28);
            this.textBoxUpdate.Name = "textBoxUpdate";
            this.textBoxUpdate.Size = new System.Drawing.Size(31, 20);
            this.textBoxUpdate.TabIndex = 4;
            this.textBoxUpdate.TextChanged += new System.EventHandler(this.textBoxUpdate_TextChanged);
            // 
            // checkBoxGPS
            // 
            this.checkBoxGPS.AutoSize = true;
            this.checkBoxGPS.Location = new System.Drawing.Point(16, 29);
            this.checkBoxGPS.Name = "checkBoxGPS";
            this.checkBoxGPS.Size = new System.Drawing.Size(93, 17);
            this.checkBoxGPS.TabIndex = 1;
            this.checkBoxGPS.Text = "GPS Activado";
            this.checkBoxGPS.UseVisualStyleBackColor = true;
            this.checkBoxGPS.CheckedChanged += new System.EventHandler(this.checkBoxGPS_CheckedChanged);
            // 
            // buttonUpLoad
            // 
            this.buttonUpLoad.Location = new System.Drawing.Point(32, 500);
            this.buttonUpLoad.Name = "buttonUpLoad";
            this.buttonUpLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonUpLoad.TabIndex = 99;
            this.buttonUpLoad.Text = "Actualizar";
            this.buttonUpLoad.UseVisualStyleBackColor = true;
            this.buttonUpLoad.Click += new System.EventHandler(this.buttonUpLoad_Click);
            // 
            // ConfiguracionInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(343, 535);
            this.Controls.Add(this.buttonUpLoad);
            this.Controls.Add(this.buttonAlmacenar);
            this.Controls.Add(this.groupBoxDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfiguracionInicial";
            this.Text = "Configuración Inicial de App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfiguracionInicial_FormClosing);
            this.Load += new System.EventHandler(this.ConfiguracionInicial_Load);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            this.groupLang.ResumeLayout(false);
            this.groupLang.PerformLayout();
            this.groupBoxAlert.ResumeLayout(false);
            this.groupBoxAlert.PerformLayout();
            this.groupBoxUpdate.ResumeLayout(false);
            this.groupBoxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAlmacenar;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.CheckBox checkBoxSound;
        private System.Windows.Forms.GroupBox groupBoxAlert;
        private System.Windows.Forms.Label labelAlertFromSep;
        private System.Windows.Forms.Label labelAlertToSep;
        private System.Windows.Forms.TextBox textBoxAlertToMM;
        private System.Windows.Forms.TextBox textBoxAlertFromMM;
        private System.Windows.Forms.Label labelAlertToHs;
        private System.Windows.Forms.Label labelAlertToText;
        private System.Windows.Forms.TextBox textBoxAlertToHH;
        private System.Windows.Forms.Label labelAlertFromHs;
        private System.Windows.Forms.Label labelAlertFromText;
        private System.Windows.Forms.TextBox textBoxAlertFromHH;
        private System.Windows.Forms.CheckBox checkBoxShortAlertAct;
        private System.Windows.Forms.CheckBox checkBoxLongAlertAct;
        private System.Windows.Forms.Label labelShortAlertHs;
        private System.Windows.Forms.Label labelShortAlertText;
        private System.Windows.Forms.TextBox textBoxShortAlert;
        private System.Windows.Forms.Label labelLongAlertHs;
        private System.Windows.Forms.Label labelLongAlertText;
        private System.Windows.Forms.TextBox textBoxLongAlert;
        private System.Windows.Forms.GroupBox groupBoxUpdate;
        private System.Windows.Forms.Label labelUpdateHs;
        private System.Windows.Forms.Label labelUpdateText;
        private System.Windows.Forms.TextBox textBoxUpdate;
        private System.Windows.Forms.CheckBox checkBoxGPS;
        private System.Windows.Forms.GroupBox groupLang;
        private System.Windows.Forms.ComboBox comboBoxLang;
        private System.Windows.Forms.Label labelLangText;
        private System.Windows.Forms.Button buttonUpLoad;
    }
}