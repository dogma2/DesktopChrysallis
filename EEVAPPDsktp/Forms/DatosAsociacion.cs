﻿using EEVAPPDsktp.Classes;
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
// EEVAPP Project - Datos Asociaciones: gestiona datos DatosAsociacion en archivo JSON en servidor
// PROYECTO - 2º Proyecto DAM2T
// DOGMA2 - 21/03/2020 - CEP
// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

namespace EEVAPPDsktp.Forms
{
    public partial class DatosAsociacion : Form
    {
        public bool isModified = false;

        public DatosAsociacion()
        {
            InitializeComponent();
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ONLOAD
        private void DatosAsociacion_Load(object sender, EventArgs e)
        {
            loadDataToForm();
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - BOTON ALMACENAR
        private void buttonAlmacenar_Click(object sender, EventArgs e)
        {
            almacenarDatosEntidad();
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - DATOS ENTIDAD a FORM
        private void loadDataToForm()
        {
            // carga comunidades y provincias
            bindingSourceComunidades.DataSource = DBAccess.ComunidadesORM.SelectAllEntidades();
            bindingSourceProvincias.DataSource = ((CCAA)comboBoxComunidad.SelectedItem).PROVINCIAS.ToList();
            AsociationDataes entidad = null;
            // Lee Archivo JSON desde servidor
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://api.eevapp.es/api/UPDATAS");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            try
            {
                StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream());
                string result = (String)streamReader.ReadToEnd();
                JObject jsonentidad = JObject.Parse(result);
                entidad = jsonentidad.ToObject<AsociationDataes>();
            }
            catch (Exception ex) { Debug.Write(ex.ToString()); }
            // Asigna datos a formulario
            textBoxNombre.Text = entidad.m_Nombre;
            textBoxCIF.Text = entidad.m_CIF;
            textBoxTelefono.Text = entidad.m_Telefono;
            textBoxDireccion.Text = entidad.m_Direccion;
            textBoxCiudad.Text = entidad.m_Ciudad;
            textBoxCodigoPostal.Text = entidad.m_CodigoPostal;
            comboBoxComunidad.SelectedValue = entidad.m_IdComunidad;
            comboBoxProvincia.SelectedValue = entidad.m_IdProvincia;
            textBoxEmail.Text = entidad.m_Email;
            textBoxWeb.Text = entidad.m_Web;
            textBoxRGPD.Text = entidad.m_RGPD;
            isModified = false;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - DATOS FORM a ENTIDAD
        private AsociationDataes asignDataFormToEntity()
        {
            AsociationDataes entidad = new AsociationDataes();
            entidad.m_Nombre = textBoxNombre.Text;
            entidad.m_CIF = textBoxCIF.Text;
            entidad.m_Telefono = textBoxTelefono.Text;
            entidad.m_Direccion = textBoxDireccion.Text;
            entidad.m_Ciudad = textBoxCiudad.Text;
            entidad.m_CodigoPostal = textBoxCodigoPostal.Text;
            entidad.m_IdComunidad = ((CCAA)comboBoxComunidad.SelectedItem).id;
            entidad.m_IdProvincia = ((PROVINCIAS)comboBoxProvincia.SelectedItem).id;
            entidad.m_Email = textBoxEmail.Text;
            entidad.m_Web = textBoxWeb.Text;
            entidad.m_RGPD = textBoxRGPD.Text;
            entidad.m_UserModif = Publica.usuario;
            DateTime nowmismo = DateTime.Now;
            entidad.m_LastModif = new int[] {nowmismo.Year, nowmismo.Month, nowmismo.Day, nowmismo.Hour, nowmismo.Minute, nowmismo.Second};
            return entidad;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ALMACENAR DATOS ENTIDAD
        private void almacenarDatosEntidad()
        {
            AsociationDataes entidad = asignDataFormToEntity();
            if (entidad != null)
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://api.eevapp.es/api/UPDATAS");
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
                }
                catch (Exception ex) { Debug.WriteLine(ex.ToString()); }
            }
            isModified = false;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - CONTROL on EXIT WITHOUT SAVE
        private void DatosAsociacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isModified)
            {
                String mnsj = "Se ha modificado contenido y no ha sido grabado, desea guardar la información ??";
                DialogResult isOK = MessageBox.Show(mnsj, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (isOK == DialogResult.Yes) { almacenarDatosEntidad(); }
            }
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - CONTROL EN CONTENIDO MODIFICADO
        private void textBoxNombre_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxCIF_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxTelefono_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxDireccion_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxCiudad_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxCodigoPostal_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void comboBoxComunidad_SelectedIndexChanged(object sender, EventArgs e) {
            isModified = true;
            CCAA _comunidad;
            if (comboBoxComunidad.SelectedItem != null) {
                _comunidad = (CCAA)comboBoxComunidad.SelectedItem;
                bindingSourceProvincias.DataSource = _comunidad.PROVINCIAS;
            }
        }
        private void comboBoxProvincia_SelectedIndexChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxEmail_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxWeb_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxRGPD_TextChanged(object sender, EventArgs e) { isModified = true; }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
    }
}
