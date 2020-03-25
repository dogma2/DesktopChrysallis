using EEVAPPDsktp.Classes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private void loadDataToForm() {
            DeviceAppDataes entidad;
            // si existe JSON
            if (File.Exists(Publica.FILE_PATH + Publica.FILE_DAPP)) {
                // Lee Archivo JSON
                JObject jsonentidad = JObject.Parse(File.ReadAllText(Publica.FILE_PATH + Publica.FILE_DAPP));
                entidad = jsonentidad.ToObject<DeviceAppDataes>();
                // Asigna datos a formulario
                checkBoxGPS.Checked = entidad.m_set_GPS;
                checkBoxSound.Checked = entidad.m_set_Sound;
                comboBoxLang.SelectedIndex = (int)entidad.m_set_Lang;
                if (entidad.m_set_Update == 0) { textBoxUpdate.Text = "12"; } else { textBoxUpdate.Text = entidad.m_set_Update.ToString(); }
                checkBoxLongAlertAct.Checked = entidad.m_set_LongAlertAct;
                if (entidad.m_set_LongAlert == 0) { textBoxLongAlert.Text = "24"; } else { textBoxLongAlert.Text = entidad.m_set_LongAlert.ToString(); }
                checkBoxShortAlertAct.Checked = entidad.m_set_ShortAlertAct;
                if (entidad.m_set_ShortAlert == 0) { textBoxShortAlert.Text = "2"; } else { textBoxShortAlert.Text = entidad.m_set_ShortAlert.ToString(); }
                if (entidad.m_set_AlertFromHH == 0) { textBoxAlertFromHH.Text = "10"; } else { textBoxAlertFromHH.Text = entidad.m_set_AlertFromHH.ToString(); }
                if (entidad.m_set_AlertFromMM == 0) { textBoxAlertFromMM.Text = "00"; } else { textBoxAlertFromMM.Text = entidad.m_set_AlertFromMM.ToString(); }
                if (entidad.m_set_AlertToHH == 0) { textBoxAlertToHH.Text = "20"; } else { textBoxAlertToHH.Text = entidad.m_set_AlertToHH.ToString(); }
                if (entidad.m_set_AlertToMM == 0) { textBoxAlertToMM.Text = "00"; } else { textBoxAlertToMM.Text = entidad.m_set_AlertToMM.ToString(); }
            }
            isModified = false;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - DATOS FORM a ENTIDAD
        private DeviceAppDataes asignDataFormToEntity() {

            DeviceAppDataes entidad = new DeviceAppDataes();
            if (entidad!=null && esEntero(textBoxUpdate, 1, 72)) { entidad.m_set_Update = int.Parse(textBoxUpdate.Text); } else { entidad = null; }
            if (entidad!=null && esEntero(textBoxLongAlert, 24, 72)) { entidad.m_set_LongAlert = int.Parse(textBoxLongAlert.Text); } else { entidad = null; }
            if (entidad!=null && esEntero(textBoxShortAlert, 0, 23)) { entidad.m_set_ShortAlert = int.Parse(textBoxShortAlert.Text); } else { entidad = null; }
            if (entidad!=null && esEntero(textBoxAlertFromHH, 0, 23)) { entidad.m_set_AlertFromHH = int.Parse(textBoxAlertFromHH.Text); } else { entidad = null; }
            if (entidad!=null && esEntero(textBoxAlertFromMM, 0, 59)) { entidad.m_set_AlertFromMM = int.Parse(textBoxAlertFromMM.Text); } else { entidad = null; }
            if (entidad!=null && esEntero(textBoxAlertToHH, 0, 23)) { entidad.m_set_AlertToHH = int.Parse(textBoxAlertToHH.Text); } else { entidad = null; }
            if (entidad!=null && esEntero(textBoxAlertToMM, 0, 59)) { entidad.m_set_AlertToMM = int.Parse(textBoxAlertToMM.Text); } else { entidad = null; }
            if (entidad!=null) {
                entidad.m_set_GPS = checkBoxGPS.Checked;
                entidad.m_set_Sound = checkBoxSound.Checked;
                entidad.m_set_Lang = (int)comboBoxLang.SelectedIndex;
                entidad.m_set_LongAlertAct = checkBoxLongAlertAct.Checked;
                entidad.m_set_ShortAlertAct = checkBoxShortAlertAct.Checked;
                entidad.m_app_state = false;
                entidad.m_app_cidapp = "";
                entidad.m_app_installdata = new int[] { 0, 0, 0, 0, 0, 0 };
                entidad.m_app_lastupdate = new int[] { 0, 0, 0, 0, 0, 0 };
                entidad.m_user_idCCAA = 0;
                entidad.m_user_idProvincia = 0;
                entidad.m_user_IMEI = "";
                entidad.m_user_email = "";
                entidad.m_user_idsocio = 0;
            }
            return entidad;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ALMACENAR DATOS ENTIDAD
        private void almacenarDatosEntidad() {

            DeviceAppDataes entidad = asignDataFormToEntity();
            if (entidad != null) {
                JObject jsonentidad = (JObject)JToken.FromObject(entidad);
                StreamWriter fichero = File.CreateText(Publica.FILE_PATH + Publica.FILE_DAPP);
                JsonTextWriter jsonwriter = new JsonTextWriter(fichero);
                jsonentidad.WriteTo(jsonwriter);
                jsonwriter.Close();
                MessageBox.Show("Datos almacenados correctamente...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - UPLOAD METHOD
        private void buttonUpLoad_Click(object sender, EventArgs e) {
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            // Evento para publicacion de informacion en servidor, se puede realizar de forma automatica pero se deja asi de momento para desarrollarlo mas tarde
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 



        }
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
    }
}
