﻿namespace EEVAPPDsktp.Forms
{
    partial class ProyectoEevapp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProyectoEevapp));
            this.groupLang = new System.Windows.Forms.GroupBox();
            this.labelResumen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.groupLang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupLang
            // 
            this.groupLang.Controls.Add(this.pictureBoxLogo);
            this.groupLang.Controls.Add(this.labelDescription);
            this.groupLang.Controls.Add(this.label1);
            this.groupLang.Controls.Add(this.labelResumen);
            this.groupLang.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupLang.Location = new System.Drawing.Point(12, 12);
            this.groupLang.Name = "groupLang";
            this.groupLang.Size = new System.Drawing.Size(776, 337);
            this.groupLang.TabIndex = 1;
            this.groupLang.TabStop = false;
            this.groupLang.Text = "El proyecto";
            // 
            // labelResumen
            // 
            this.labelResumen.AutoSize = true;
            this.labelResumen.Location = new System.Drawing.Point(-846, 142);
            this.labelResumen.Name = "labelResumen";
            this.labelResumen.Size = new System.Drawing.Size(7, 13);
            this.labelResumen.TabIndex = 0;
            this.labelResumen.Text = "\r\n";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-251, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.White;
            this.labelDescription.Location = new System.Drawing.Point(15, 34);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(496, 292);
            this.labelDescription.TabIndex = 4;
            this.labelDescription.Text = resources.GetString("labelDescription.Text");
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Image = global::EEVAPPDsktp.Properties.Resources.eevapplogo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(551, 19);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(209, 307);
            this.pictureBoxLogo.TabIndex = 33;
            this.pictureBoxLogo.TabStop = false;
            // 
            // ProyectoEevapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(801, 366);
            this.Controls.Add(this.groupLang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProyectoEevapp";
            this.Text = "Proyecto EEvApp";
            this.groupLang.ResumeLayout(false);
            this.groupLang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupLang;
        private System.Windows.Forms.Label labelResumen;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}