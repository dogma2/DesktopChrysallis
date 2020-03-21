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

// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
// EEVAPP Project - Datos Asociaciones: gestiona datos DatosAsociacion en archivo JSON en local con opcion de carga en servidor
// PROYECTO - 2º Proyecto DAM2T
// DOGMA2 - 21/03/2020 - CEP
// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
// More Data JSON API IN WEB https://techclub.tajamar.es/consultas-de-accion-con-json-en-una-webapi/
// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

namespace EEVAPPDsktp.Forms
{
    public partial class DatosAsociacion : Form
    {
        public bool isModified = false;
        public const string FILE_DATA = "AsociationData.json";
        public const string FILE_PATH = @"..\..\JsonFiles\";

        public DatosAsociacion()
        {
            InitializeComponent();
        }

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
            AsociationDataes entidad;
            // carga comunidades y provincias
            bindingSourceComunidades.DataSource = DBAccess.ComunidadesORM.SelectAllEntidades();
            bindingSourceProvincias.DataSource = ((CCAA)comboBoxComunidad.SelectedItem).PROVINCIAS.ToList();
            // si existe JSON
            if ( File.Exists( FILE_PATH + FILE_DATA ) )
            {
                // Lee Archivo JSON
                JObject jsonentidad = JObject.Parse( File.ReadAllText( FILE_PATH + FILE_DATA ) );
                entidad = jsonentidad.ToObject<AsociationDataes>();
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
            }
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - DATOS FORM a ENTIDAD
        private AsociationDataes asignDataFormToEntity()
        {
            int aux;
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
            return entidad;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ALMACENAR DATOS ENTIDAD
        private void almacenarDatosEntidad()
        {
            AsociationDataes entidad = asignDataFormToEntity();
            String mnsj = "";
            if (entidad != null) {
                JObject jsonentidad = (JObject)JToken.FromObject(entidad);
                StreamWriter fichero = File.CreateText( FILE_PATH + FILE_DATA );
                JsonTextWriter jsonwriter = new JsonTextWriter(fichero);
                jsonentidad.WriteTo(jsonwriter);
                jsonwriter.Close();
                isModified = false;
            }
            else {
                mnsj = "Entidad vacía (nulo)";
            }
            // Si existe un error se genera mensaje
            if (!mnsj.Equals("")) { MessageBox.Show(mnsj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else { MessageBox.Show("Datos almacenados correctamente...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - CONTROL on EXIT WITHOUT SAVE
        private void DatosAsociacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isModified)
            {
                AsociationDataes entidad = asignDataFormToEntity();
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
