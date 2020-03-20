using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEVAPPDsktp.Forms
{
    public partial class Administradores : Form
    {
        public bool isModified = false;
        public bool isNew = false;

        public Administradores()
        {
            InitializeComponent();
        }

        private void Administradores_Load(object sender, EventArgs e)
        {
            loadListsDataToForm();
            loadInitialSelectedData();
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - SELECCION de ENTIDAD
        private void listBoxLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            asignDataEntityToForm((DSKTUSERS)listBoxLista.SelectedItem);
            isModified = false;
            textBoxUsuario.Focus();
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - BOTON ELIMINAR
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            DSKTUSERS entidad = (DSKTUSERS)listBoxLista.SelectedItem;
            if (entidad != null)
            {
                String mnsj = "Está seguro de eliminar definitivamente " + entidad.nickname + " ?";
                DialogResult isOK = MessageBox.Show(mnsj, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (isOK == DialogResult.Yes)
                {
                    mnsj = DBAccess.AdministradoresORM.DeleteEntidad(entidad);
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
            asignDataEntityToForm((DSKTUSERS)listBoxLista.SelectedItem);
            isModified = false;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - BOTON ALMACENAR
        private void buttonAlmacenar_Click(object sender, EventArgs e)
        {
            DSKTUSERS entidad = asignDataFormToEntity();
            if (controlEntityData(entidad))
            {
                String mnsj;
                if (isNew) { mnsj = DBAccess.AdministradoresORM.InsertaEntidad(entidad); }
                else { mnsj = DBAccess.AdministradoresORM.ModificaEntidad(entidad); }
                // Si existe un error se genera mensaje
                if (!mnsj.Equals("")) { MessageBox.Show(mnsj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else { loadListsDataToForm(); }
            }
            isModified = false;
            loadInitialSelectedData();
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - DATOS ENTIDAD a FORM
        private void loadListsDataToForm()
        {
            bindingSourceAdministradores.DataSource = DBAccess.AdministradoresORM.SelectAllEntidades();
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
        private DSKTUSERS generateEmptyEntity()
        {
            DSKTUSERS entidad = new DSKTUSERS();
            entidad.id = 0;
            entidad.estado = 0;
            entidad.nickname = "";
            entidad.password = "";
            entidad.nombre = "";
            entidad.email = "";
            entidad.idprovincia = 0;
            entidad.idccaa = 0;
            entidad.iddelegacion = 0;
            entidad.ctrlmaster = 0;
            return entidad;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - DATOS ENTIDAD a FORM
        private void asignDataEntityToForm(DSKTUSERS entidad)
        {
            if (entidad != null)
            {
                textBoxId.Text = entidad.id.ToString();
                textBoxUsuario.Text = entidad.nickname;
                textBoxClave.Text = entidad.password;
                if (entidad.estado == 1) { checkBoxActivado.Checked = true; }
                else { checkBoxActivado.Checked = false; }
                textBoxNombre.Text = entidad.nombre;
                textBoxEmail.Text = entidad.email;

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
                comboBoxDelegacion.SelectedValue = entidad.iddelegacion;
                if (entidad.ctrlmaster == 1) { checkBoxMaster.Checked = true; }
                else { checkBoxMaster.Checked = false; }
            }
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - DATOS FORM a ENTIDAD
        private DSKTUSERS asignDataFormToEntity()
        {
            int aux;
            DSKTUSERS entidad;
            if ((int.TryParse(textBoxId.Text, out aux)) && (int.Parse(textBoxId.Text) > 0))
            {
                entidad = (DSKTUSERS)listBoxLista.SelectedItem;
                isNew = false;
            }
            else
            {
                entidad = generateEmptyEntity();
                isNew = true;
            }
            if (checkBoxActivado.Checked == true) { entidad.estado = 1; }
            else { entidad.estado = 0; }
            entidad.nickname = textBoxUsuario.Text;
            entidad.password = textBoxClave.Text;
            entidad.nombre = textBoxNombre.Text;
            entidad.email = textBoxEmail.Text;
            entidad.idccaa = ((CCAA)comboBoxComunidad.SelectedItem).id;
            entidad.idprovincia = ((PROVINCIAS)comboBoxProvincia.SelectedItem).id;
            entidad.iddelegacion = ((DELEGACIONES)comboBoxDelegacion.SelectedItem).id;
            entidad.ctrlmaster = 0;
            if (checkBoxMaster.Checked == true) { entidad.ctrlmaster = 1; }
            else { entidad.ctrlmaster = 0; }
            return entidad;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ALMACENAR DATOS ENTIDAD
        private void almacenarDatosEntidad(DSKTUSERS entidad)
        {
            if (controlEntityData(entidad))
            {
                String mnsj;
                if (isNew) { mnsj = DBAccess.AdministradoresORM.InsertaEntidad(entidad); }
                else { mnsj = DBAccess.AdministradoresORM.ModificaEntidad(entidad); }
                // Si existe un error se genera mensaje
                if (!mnsj.Equals("")) { MessageBox.Show(mnsj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else { loadListsDataToForm(); }
            }
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - CONTROL DATOS ENTIDAD
        private bool controlEntityData(DSKTUSERS entidad)
        {
            bool isOK = true;
            string mnsj = "";
            // Si nombre vacio, genera flag de error y mensaje
            if (isOK && entidad.nickname.Length <= 0) { isOK = false; mnsj = "El nombre no puede estar vacío."; textBoxUsuario.Focus(); }
            // Si clave vacio, genera flag de error y mensaje
            if (isOK && entidad.password.Length <= 0) { isOK = false; mnsj = "La clave no puede estar vacía."; textBoxClave.Focus(); }
            // Si existe un error se genera mensaje
            if (!isOK) { MessageBox.Show(mnsj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            return isOK;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - CONTROL on EXIT WITHOUT SAVE
        private void Administradores_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isModified)
            {
                DSKTUSERS entidad = asignDataFormToEntity();
                String mnsj = "Se ha modificado contenido y no ha sido grabado, desea guardar la información ??";
                DialogResult isOK = MessageBox.Show(mnsj, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (isOK == DialogResult.Yes) { almacenarDatosEntidad(entidad); }
            }
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - CONTROL EN CONTENIDO MODIFICADO
        private void textBoxUsuario_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxClave_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void checkBoxActivado_CheckedChanged(object sender, EventArgs e) { isModified = true; }
        private void checkBoxMaster_CheckedChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxNombre_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxEmail_TextChanged(object sender, EventArgs e) { isModified = true; }
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
        private void comboBoxDelegacion_SelectedIndexChanged(object sender, EventArgs e) { isModified = true; }
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

    }
}
