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

namespace EEVAPPDsktp.Forms
{
    public partial class SociosForm : Form
    {
        // atributos de clase 
        USUARIOS entidad;
        bool isModified;

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - Constructor
        public SociosForm(USUARIOS entidad)
        {
            InitializeComponent();
            this.entidad = entidad;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - Form Load 
        private void SociosForm_Load(object sender, EventArgs e)
        {
            if (Publica.master)
            {
                bindingSourceDelegaciones.DataSource = DBAccess.DelegacionesORM.SelectAllEntidades();
            }
            else
            {
                bindingSourceDelegaciones.DataSource = DBAccess.DelegacionesORM.SelectById(Publica.iddelegacion);
            }
            if (entidad.id > 0) { loadDataForm(); this.Text = "Modifica Socio"; }
            else { this.Text = "Nuevo Socios"; }
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - LOAD data Form
        private void loadDataForm()
        {
            textBoxCodigoUsuario.Text = entidad.idsocio;
            textBoxEmail.Text = entidad.email;
            comboBoxDelegacion.SelectedValue = entidad.iddelegacion;
            if (entidad.estado == 1) { checkBoxActivado.Checked = true; }
            dateTimePickerFechaEstado.Value = new DateTime((long)entidad.fechaestado);
            textBoxNotaEstado.Text = entidad.notaestado;
            isModified = false;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - GET data Form
        private void getDataForm()
        {
            entidad.idsocio = textBoxCodigoUsuario.Text;
            entidad.email = textBoxEmail.Text;
            if (comboBoxDelegacion.SelectedValue!=null) { entidad.iddelegacion = (int)comboBoxDelegacion.SelectedValue; }
            if (checkBoxActivado.Checked) { entidad.estado = 1; } else { entidad.estado = 0; }
            entidad.fechaestado = (long)dateTimePickerFechaEstado.Value.Ticks;
            entidad.notaestado = textBoxNotaEstado.Text;
            if (Publica.idusuario != 0) { entidad.iddsktuser = Publica.idusuario; }
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - VALIDATE data
        private bool validateData() {
            string errmsg = "";
            String[] emailtest;
            bool isOK = true;
            getDataForm();
            // - - - - - email obligatorio
            if (isOK && entidad.email.Equals("")) { isOK = false; errmsg = "El email no puede estar vacío"; textBoxEmail.Focus(); }
            // - - - - - formato email
            if (isOK)
            {
                emailtest = entidad.email.Split('@');
                if (emailtest.Count() < 2)
                {
                    isOK = false; errmsg = "Formato de email incorrecto"; textBoxEmail.Focus();
                }
                else
                {
                    if (isOK && emailtest[1].Split('.').Count() < 2) { isOK = false; errmsg = "Formato de email incorrecto"; textBoxEmail.Focus(); }
                }
            }
            if (!isOK) { MessageBox.Show(errmsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            return isOK;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - SAVE data
        private bool almacenarEntidad()
        {
            bool isOK = true;
            String ormmsg = "";
            // - - - - - graba nuevo / modificacion
            if (entidad.id > 0) { ormmsg = DBAccess.UsuariosORM.ModificaEntidad(entidad); }
            else { ormmsg = DBAccess.UsuariosORM.InsertaEntidad(entidad); }
            // - - - - - control por error de grabacion
            if (!ormmsg.Equals("")) { MessageBox.Show(ormmsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); isOK = false; }
            else { MessageBox.Show( "Los datos se han almacenado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);  }
            return isOK;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - Pick SAVE data form 
        private void buttonAlmacenar_Click(object sender, EventArgs e)
        {
            if (validateData()) { if (almacenarEntidad()) { isModified = false; this.Close(); } }
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ALTER data form 
        private void textBoxCodigoUsuario_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxEmail_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void comboBoxDelegacion_SelectedIndexChanged(object sender, EventArgs e) { isModified = true; }
        private void checkBoxActivado_CheckedChanged(object sender, EventArgs e) { isModified = true; }
        private void dateTimePickerFechaEstado_ValueChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxNotaEstado_TextChanged(object sender, EventArgs e) { isModified = true; }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - Pick CLOSE data form
        private void SociosForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isModified)
            {
                String mnsj = "Se ha modificado contenido y no ha sido grabado, desea guardar la información ??";
                DialogResult isOK = MessageBox.Show(mnsj, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (isOK == DialogResult.Yes) { if (validateData()) { if (almacenarEntidad()) { isModified = false; this.Close(); } } }
            }
        }


    }
}
