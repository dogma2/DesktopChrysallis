using EEVAPPDsktp.Classes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
// EEVAPP Project - configuracion Inicial App: gestiona datos ConfiguracionInicial en archivo JSON en servidor
// PROYECTO - 2º Proyecto DAM2T
// DOGMA2 - 21/03/2020 - CEP
// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

namespace EEVAPPDsktp.Forms {

    public partial class ConfiguracionInicial : Form {
        public bool isModified = false;

        public ConfiguracionInicial() {
            InitializeComponent();
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ONLOAD
        private void ConfiguracionInicial_Load(object sender, EventArgs e) {
            // control si tiene acceso a ver/modificar formulario
            if (!Publica.master)
            {
                MessageBox.Show("No tiene autorizacion para acceder a esta opcion.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
            }
            else
            {
                loadDataToForm();
            }
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - BOTON ALMACENAR
        private void buttonAlmacenar_Click(object sender, EventArgs e) {
            almacenarDatosEntidad();
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - DATOS ENTIDAD a FORM
        private void loadDataToForm()
        {
            DeviceAppDataes entidad = null;
            // Lee Archivo JSON desde servidor
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://api.eevapp.es/api/UPCONFIG");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            try
            {
                StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream());
                string result = (String)streamReader.ReadToEnd();
                JObject jsonentidad = JObject.Parse(result);
                entidad = jsonentidad.ToObject<DeviceAppDataes>();
            }
            catch (Exception ex) { Debug.Write(ex.ToString()); }
            // Asigna datos a formulario
            if (entidad != null) { if (entidad.m_GPS == 1) { checkBoxGPS.Checked = true; } }
            if (entidad != null) { if (entidad.m_Sound == 1) { checkBoxSound.Checked = true; } }
            if (entidad != null) { comboBoxLang.SelectedIndex = (int)entidad.m_Lang; }
            if (entidad != null) { textBoxUpdate.Text = entidad.m_Update.ToString(); } else { textBoxUpdate.Text = "12"; }
            if (entidad != null) { if (entidad.m_LongAlertAct == 1) { checkBoxLongAlertAct.Checked = true; } }
            if (entidad != null) { textBoxLongAlert.Text = entidad.m_LongAlert.ToString(); } else { textBoxLongAlert.Text = "24"; }
            if (entidad != null) { if (entidad.m_ShortAlertAct == 1) { checkBoxShortAlertAct.Checked = true; } }
            if (entidad != null) { textBoxShortAlert.Text = entidad.m_ShortAlert.ToString(); } else { textBoxShortAlert.Text = "2"; }
            if (entidad != null) { textBoxAlertFromHH.Text = entidad.m_AlertFromHH.ToString(); } else { textBoxAlertFromHH.Text = "10"; }
            if (entidad != null) { textBoxAlertFromMM.Text = entidad.m_AlertFromMM.ToString(); } else { textBoxAlertFromMM.Text = "00"; }
            if (entidad != null) { textBoxAlertToHH.Text = entidad.m_AlertToHH.ToString(); } else { textBoxAlertToHH.Text = "20"; }
            if (entidad != null) { textBoxAlertToMM.Text = entidad.m_AlertToMM.ToString(); } else { textBoxAlertToMM.Text = "00"; }
            isModified = false;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - DATOS FORM a ENTIDAD
        private DeviceAppDataes asignDataFormToEntity()
        {
            DeviceAppDataes entidad = new DeviceAppDataes();
            if (entidad!=null && esEntero(textBoxUpdate, 1, 72)) { entidad.m_Update = int.Parse(textBoxUpdate.Text); } else { entidad = null; }
            if (entidad!=null && esEntero(textBoxLongAlert, 24, 72)) { entidad.m_LongAlert = int.Parse(textBoxLongAlert.Text); } else { entidad = null; }
            if (entidad!=null && esEntero(textBoxShortAlert, 0, 23)) { entidad.m_ShortAlert = int.Parse(textBoxShortAlert.Text); } else { entidad = null; }
            if (entidad!=null && esEntero(textBoxAlertFromHH, 0, 23)) { entidad.m_AlertFromHH = int.Parse(textBoxAlertFromHH.Text); } else { entidad = null; }
            if (entidad!=null && esEntero(textBoxAlertFromMM, 0, 59)) { entidad.m_AlertFromMM = int.Parse(textBoxAlertFromMM.Text); } else { entidad = null; }
            if (entidad!=null && esEntero(textBoxAlertToHH, 0, 23)) { entidad.m_AlertToHH = int.Parse(textBoxAlertToHH.Text); } else { entidad = null; }
            if (entidad!=null && esEntero(textBoxAlertToMM, 0, 59)) { entidad.m_AlertToMM = int.Parse(textBoxAlertToMM.Text); } else { entidad = null; }
            if (entidad!=null) {
                if (checkBoxGPS.Checked == true) { entidad.m_GPS = 1; } else { entidad.m_GPS = 0; }
                if (checkBoxSound.Checked == true) { entidad.m_Sound = 1; } else { entidad.m_Sound = 0; }
                entidad.m_Lang = (int)comboBoxLang.SelectedIndex;
                if (checkBoxLongAlertAct.Checked == true) { entidad.m_LongAlertAct = 1; } else { entidad.m_LongAlertAct = 0; }
                if (checkBoxShortAlertAct.Checked == true) { entidad.m_ShortAlertAct = 1; } else { entidad.m_ShortAlertAct = 0; }
            }
            return entidad;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ALMACENAR DATOS ENTIDAD
        private void almacenarDatosEntidad()
        {
            DeviceAppDataes entidad = asignDataFormToEntity();
            if (entidad != null) {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://api.eevapp.es/api/UPCONFIG");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = WebRequestMethods.Http.Post;
                try
                {
                    JObject jsonentidad = (JObject)JToken.FromObject(entidad);
                    StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream());
                    streamWriter.Write(jsonentidad);
                    streamWriter.Close();
                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    MessageBox.Show("Datos almacenados correctamente...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } catch(Exception ex) { Debug.WriteLine(ex.ToString()); }

            }
            isModified = false;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - CONTROL on EXIT WITHOUT SAVE
        private void ConfiguracionInicial_FormClosing(object sender, FormClosingEventArgs e) {
            if (isModified) {
                String mnsj = "Se ha modificado contenido y no ha sido grabado, desea guardar la información ??";
                DialogResult isOK = MessageBox.Show(mnsj, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (isOK == DialogResult.Yes) { almacenarDatosEntidad(); }
            }
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - CONTROL EN CONTENIDO MODIFICADO
        private void checkBoxGPS_CheckedChanged(object sender, EventArgs e) { isModified = true; }
        private void checkBoxSound_CheckedChanged(object sender, EventArgs e) { isModified = true; }
        private void comboBoxLang_SelectedIndexChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxUpdate_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void checkBoxLongAlertAct_CheckedChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxLongAlert_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void checkBoxShortAlertAct_CheckedChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxShortAlert_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxAlertFromHH_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxAlertFromMM_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxAlertToHH_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxAlertToMM_TextChanged(object sender, EventArgs e) { isModified = true; }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - CONTROL INTVAL
        private bool esEntero(TextBox caja, int desde, int hasta) {
            int aux; bool isOK = false;
            if (int.TryParse(caja.Text, out aux) && aux >= desde && aux <= hasta) {
                isOK = true;
            }
            else {
                MessageBox.Show("El valor debe indicarse entre "+desde+" y "+hasta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                caja.Focus(); }
            return isOK;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
    }
}
