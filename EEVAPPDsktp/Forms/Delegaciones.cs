using EEVAPPDsktp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
// EEVAPP Project - Delegaciones: gestiona datos de Delegaciones en BBDD
// PROYECTO - 2º Proyecto DAM2T
// DOGMA2 - 21/03/2020 - CEP
// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
// More Data
// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

namespace EEVAPPDsktp.Forms
{
    public partial class Delegaciones : Form
    {
        public bool isModified = false;
        public bool isNew = false;

        public Delegaciones()
        {
            InitializeComponent();
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ONLOAD
        private void Delegaciones_Load(object sender, EventArgs e)
        {
            // control si tiene acceso a ver/modificar formulario
            if (!Publica.master)
            {
                MessageBox.Show("No tiene autorizacion para acceder a esta opcion.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
            }
            else {
                loadListsDataToForm();
                loadInitialSelectedData();
            }
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - SELECCION de ENTIDAD
        private void listBoxLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            asignDataEntityToForm( (DELEGACIONES)listBoxLista.SelectedItem );
            isModified = false;
            textBoxNombre.Focus();
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - BOTON ELIMINAR
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            DELEGACIONES entidad = (DELEGACIONES)listBoxLista.SelectedItem;
            if (entidad != null)
            {
                String mnsj = "Está seguro de eliminar definitivamente " + entidad.nombre + " ?";
                DialogResult isOK = MessageBox.Show(mnsj, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (isOK == DialogResult.Yes)
                {
                    mnsj = DBAccess.DelegacionesORM.DeleteEntidad(entidad);
                    // Si existe un error se genera mensaje
                    if (!mnsj.Equals("")) { MessageBox.Show(mnsj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                loadListsDataToForm();
                loadInitialSelectedData();
            }
            isModified = false;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - BOTON AGREGAR
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            listBoxLista.SelectedIndex = (-1);
            asignDataEntityToForm(generateEmptyEntity());
            isModified = false;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - BOTON ALMACENAR
        private void buttonAlmacenar_Click(object sender, EventArgs e)
        {
            almacenarDatosEntidad();
            loadInitialSelectedData();
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - DATOS ENTIDAD a FORM
        private void loadListsDataToForm()
        {
            bindingSourceDelegaciones.DataSource = DBAccess.DelegacionesORM.SelectAllEntidades();
            bindingSourceComunidades.DataSource = DBAccess.ComunidadesORM.SelectAllEntidades();
            bindingSourceProvincias.DataSource = ((CCAA)comboBoxComunidad.SelectedItem).PROVINCIAS.ToList();
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - DATOS ENTIDAD a FORM
        private void loadInitialSelectedData()
        {
            listBoxLista.SelectedIndex = (-1);
            asignDataEntityToForm(generateEmptyEntity());
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - GENERA ENTIDAD VACIA
        private DELEGACIONES generateEmptyEntity()
        {
            DELEGACIONES entidad = new DELEGACIONES();
            entidad.id = 0;
            entidad.nombre = "";
            entidad.telefono = "";
            entidad.estado = 0;
            entidad.direccion = "";
            entidad.ciudad = "";
            entidad.cp = "";
            entidad.idccaa = 0;
            entidad.idprovincia = 0;
            entidad.email = "";
            entidad.contacto = "";
            return entidad;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - DATOS ENTIDAD a FORM
        private void asignDataEntityToForm(DELEGACIONES entidad)
        {
            if (entidad != null)
            { 
                textBoxId.Text = entidad.id.ToString();
                textBoxNombre.Text = entidad.nombre;
                textBoxTelefono.Text = entidad.telefono;
                if (entidad.estado == 1) { checkBoxActivado.Checked = true; }
                else { checkBoxActivado.Checked = false; }
                textBoxDireccion.Text = entidad.direccion;
                textBoxCiudad.Text = entidad.ciudad;
                textBoxCodigoPostal.Text = entidad.cp;
                if (entidad.idccaa > 0)
                {
                    comboBoxComunidad.SelectedValue = entidad.idccaa;
                    comboBoxProvincia.SelectedValue = entidad.idprovincia;
                }
                else
                {
                    comboBoxComunidad.SelectedIndex = 0;
                    bindingSourceProvincias.DataSource = ((CCAA)comboBoxComunidad.SelectedItem).PROVINCIAS.ToList();
                }
                textBoxEmail.Text = entidad.email;
                textBoxContacto.Text = entidad.contacto;
            }
            isModified = false;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - DATOS FORM a ENTIDAD
        private DELEGACIONES asignDataFormToEntity()
        {
            int aux;
            DELEGACIONES entidad;
            if ((int.TryParse(textBoxId.Text, out aux)) && (int.Parse(textBoxId.Text) > 0))
            {
                entidad = (DELEGACIONES)listBoxLista.SelectedItem;
                isNew = false;
            }
            else
            {
                entidad = generateEmptyEntity();
                isNew = true;
            }
            entidad.nombre = textBoxNombre.Text;
            entidad.telefono = textBoxTelefono.Text;
            if (checkBoxActivado.Checked == true) { entidad.estado = 1; }
            else { entidad.estado = 0; }
            entidad.direccion = textBoxDireccion.Text;
            entidad.ciudad = textBoxCiudad.Text;
            entidad.cp = textBoxCodigoPostal.Text;
            entidad.idccaa = ((CCAA)comboBoxComunidad.SelectedItem).id;
            entidad.idprovincia = ((PROVINCIAS)comboBoxProvincia.SelectedItem).id;
            entidad.email = textBoxEmail.Text;
            entidad.contacto = textBoxContacto.Text;
            return entidad;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ALMACENAR DATOS ENTIDAD
        private void almacenarDatosEntidad()
        {
            DELEGACIONES entidad = asignDataFormToEntity();
            if (controlEntityData(entidad)) { 
                String mnsj;
                if (isNew) { mnsj = DBAccess.DelegacionesORM.InsertaEntidad(entidad); }
                else { mnsj = DBAccess.DelegacionesORM.ModificaEntidad(entidad); }
                // Si existe un error se genera mensaje
                if (!mnsj.Equals("")) { MessageBox.Show(mnsj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else { MessageBox.Show("Datos almacenados correctamente...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);  loadListsDataToForm(); }
            }
            isModified = false;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - CONTROL DATOS ENTIDAD
        private bool controlEntityData(DELEGACIONES entidad)
        {
            bool isOK = true;
            string mnsj = "";
            // Si nombre vacio, genera flag de error y mensaje
            if (isOK && entidad.nombre.Length <= 0) { isOK = false; mnsj = "El nombre no puede estar vacío."; textBoxNombre.Focus(); }
            // Si existe un error se genera mensaje
            if (!isOK) { MessageBox.Show(mnsj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            return isOK;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - CONTROL on EXIT WITHOUT SAVE
        private void Delegaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isModified)
            {
                DELEGACIONES entidad = asignDataFormToEntity();
                String mnsj = "Se ha modificado contenido y no ha sido grabado, desea guardar la información ??";
                DialogResult isOK = MessageBox.Show(mnsj, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (isOK == DialogResult.Yes) { almacenarDatosEntidad(); }
            }
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - CONTROL EN CONTENIDO MODIFICADO
        private void textBoxNombre_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxTelefono_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void checkBoxActivado_CheckedChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxDireccion_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxCiudad_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxCodigoPostal_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void comboBoxComunidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            isModified = true;
            CCAA _comunidad;
            if (comboBoxComunidad.SelectedItem != null)
            {
                _comunidad = (CCAA)comboBoxComunidad.SelectedItem;
                bindingSourceProvincias.DataSource = _comunidad.PROVINCIAS;
            }
        }
        private void comboBoxProvincia_SelectedIndexChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxEmail_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxContacto_TextChanged(object sender, EventArgs e) { isModified = true; }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

    }
}
