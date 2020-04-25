using EEVAPPDsktp.Classes;
using EEVAPPDsktp.DBAccess;
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
    public partial class DatosInteresAdd : Form
    {
        // atributos de clase 
        DATOSINTERES entidad;
        bool isModified;

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - Constructor
        public DatosInteresAdd(DATOSINTERES entidad)
        {
            InitializeComponent();
            this.entidad = entidad;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - Form Load 
        private void DatosInteresAdd_Load(object sender, EventArgs e)
        {
            if (Publica.master)
            {
                bindingSourceDelegaciones.DataSource = DBAccess.DelegacionesORM.SelectAllEntidades();
                bindingSourceComunidades.DataSource = DBAccess.ComunidadesORM.SelectAllEntidades();
                bindingSourceProvincias.DataSource = ((CCAA)comboBoxComunidad.SelectedItem).PROVINCIAS.ToList();
            }
            else
            {
                bindingSourceDelegaciones.DataSource = DBAccess.DelegacionesORM.SelectById(Publica.iddelegacion);
                bindingSourceComunidades.DataSource = DBAccess.ComunidadesORM.SelectAllEntidades();
                if (Publica.idccaa > 0) { comboBoxComunidad.SelectedValue = Publica.idccaa; }
                bindingSourceProvincias.DataSource = ((CCAA)comboBoxComunidad.SelectedItem).PROVINCIAS.ToList();
            }
            if (entidad.id > 0) { loadDataForm(); this.Text = "Modifica Dato Interés"; }
            else { this.Text = "Nuevo Dato Interés"; }
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - LOAD data Form
        private void loadDataForm()
        {
            textBoxNombre.Text = entidad.nombre;
            checkBoxActivado.Checked = Convert.ToBoolean(entidad.estado);
            textBoxDescripcion.Text = entidad.descripcion;
            textBoxCiudad.Text = entidad.ciudad;
            textBoxCodigoPostal.Text = entidad.cp;
            comboBoxDelegacion.SelectedValue = (byte)entidad.iddelegacion;
            comboBoxComunidad.SelectedValue = (byte)entidad.idccaa;
            comboBoxProvincia.SelectedValue = (byte)entidad.idprovincia;
            textBoxEmail.Text = entidad.email;
            textBoxTelefono.Text = entidad.telefono;
            textBoxPersoa.Text = entidad.contacto;
            isModified = false;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - GET data Form
        private void getDataForm()
        {
            entidad.nombre = textBoxNombre.Text;
            entidad.estado = Convert.ToByte(checkBoxActivado.Checked);
            entidad.descripcion = textBoxDescripcion.Text;
            entidad.ciudad = textBoxCiudad.Text;
            entidad.cp = textBoxCodigoPostal.Text;
            entidad.iddelegacion = (int)comboBoxDelegacion.SelectedValue;
            entidad.idccaa = (byte)comboBoxComunidad.SelectedValue;
            entidad.idprovincia = (byte)comboBoxProvincia.SelectedValue;
            entidad.email = textBoxEmail.Text;
            entidad.telefono = textBoxTelefono.Text;
            entidad.contacto = textBoxPersoa.Text;
            //datos.ctrlglobal = Convert.ToByte(CheckBoxGlobal.Checked);
            if (Publica.idusuario != 0) { entidad.iddsktuser = Publica.idusuario; }
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - VALIDATE data
        private bool validateData()
        {
            string errmsg = "";
            bool isOK = true;
            getDataForm();
            // - - - - - datos obligatorios
            if (isOK && entidad.nombre.Equals("")) { isOK = false; errmsg = "El nombre no puede estar vacío"; textBoxNombre.Focus(); }
            if (isOK && entidad.descripcion.Equals("")) { isOK = false; errmsg = "El descripcion no puede estar vacío"; textBoxDescripcion.Focus(); }
            if (isOK && entidad.ciudad.Equals("")) { isOK = false; errmsg = "El ciudad no puede estar vacío"; textBoxCiudad.Focus(); }
            if (isOK && entidad.email.Equals("")) { isOK = false; errmsg = "El email no puede estar vacío"; textBoxEmail.Focus(); }
            if (!isOK) { MessageBox.Show(errmsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            return isOK;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - SAVE data
        private bool almacenarEntidad()
        {
            bool isOK = true;
            String ormmsg = "";
            // - - - - - graba nuevo / modificacion
            if (entidad.id > 0) { ormmsg = DBAccess.DatosInteresORM.ModificaEntidad(entidad); }
            else { ormmsg = DBAccess.DatosInteresORM.InsertaEntidad(entidad); }
            // - - - - - control por error de grabacion
            if (!ormmsg.Equals("")) { MessageBox.Show(ormmsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); isOK = false; }
            else { MessageBox.Show("Los datos se han almacenado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            return isOK;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - Pick SAVE data form 
        private void buttonAlmacenar_Click(object sender, EventArgs e)
        {
            if (validateData()) { if (almacenarEntidad()) { isModified = false; this.Close(); } }
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ALTER data form 
        private void textBoxNombre_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void CheckBoxGlobal_CheckedChanged(object sender, EventArgs e) { isModified = true; }
        private void checkBoxActivado_CheckedChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxDescripcion_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxCiudad_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxCodigoPostal_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxEmail_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxTelefono_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxPersoa_TextChanged(object sender, EventArgs e) { isModified = true; }
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

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - Pick CLOSE data form
        private void DatosInteresAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isModified)
            {
                String mnsj = "Se ha modificado contenido y no ha sido grabado, desea guardar la información ??";
                DialogResult isOK = MessageBox.Show(mnsj, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (isOK == DialogResult.Yes) { if (validateData()) { if (almacenarEntidad()) { isModified = false; this.Close(); } } }
            }
        }



















        /*




        private void buttonAlmacenar_Click(object sender, EventArgs e)
        {
            CargarFormToDatos();
            if(IsNewDato)
            {
                Console.WriteLine(DatosInteresORM.InsertaEntidad(datos));
            }
            else
            {
                DatosInteresORM.ModificaEntidad(datos);
            }
            this.Close();

            //Nombre
            //Activado -> Estado
            //Descripcion
            //Ciudadd
            //Codigo Postal
            //ComunitatSutonoma
            //Provincia
            //Email
            //Telefono
            //Persona Contacto
        }
        private void CargarDatosToForm()
        {
            textBoxNombre.Text = datos.nombre;
            checkBoxActivado.Checked = Convert.ToBoolean(datos.estado);
            textBoxDescripcion.Text = datos.descripcion;
            textBoxCiudad.Text = datos.ciudad;
            textBoxCodigoPostal.Text = datos.cp;
            comboBoxComunidadA.SelectedValue = (byte)datos.idccaa;
            comboBoxProvincia.SelectedValue = (byte) datos.idprovincia;
            textBoxEmail.Text = datos.email;
            textBoxTelefono.Text = datos.telefono;
            textBoxPersoa.Text = datos.contacto;
            //CheckBoxGlobal.Checked = Convert.ToBoolean(datos.ctrlglobal);

        }
        private void CargarFormToDatos()
        {
            datos.nombre = textBoxNombre.Text;
            datos.estado = Convert.ToByte(checkBoxActivado.Checked);
            datos.descripcion = textBoxDescripcion.Text;
            datos.ciudad = textBoxCiudad.Text;
            datos.cp = textBoxCodigoPostal.Text;
            datos.idccaa = (Byte) comboBoxComunidadA.SelectedValue;
            datos.idprovincia = (Byte) comboBoxProvincia.SelectedValue;
            datos.email = textBoxEmail.Text;
            datos.telefono = textBoxTelefono.Text;
            datos.contacto = textBoxPersoa.Text;
            //datos.ctrlglobal = Convert.ToByte(CheckBoxGlobal.Checked);
            if (Publica.idusuario != 0) { datos.iddsktuser = Publica.idusuario; }

        }      
               

        private void DatosInteresAdd_Load(object sender, EventArgs e)
        {            
            comboBoxComunidadA.DataSource = DBAccess.ComunidadesORM.SelectAllEntidades();
            comboBoxComunidadA.DisplayMember = "nombre";
            comboBoxComunidadA.ValueMember = "id";

            comboBoxProvincia.DisplayMember = "nombre";
            comboBoxProvincia.ValueMember = "id";
           
            if (!IsNewDato)
            {
                CargarDatosToForm();
            }

        }

        private void comboBoxComunidadA_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxProvincia.DataSource = ((CCAA)comboBoxComunidadA.SelectedItem).PROVINCIAS.ToList();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



*/


    }
}
