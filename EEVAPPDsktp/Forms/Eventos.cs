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
    public partial class Eventos : Form
    {
        public Eventos()
        {
            InitializeComponent();
            dataGridViewEventos.DataSource = DBAccess.EventosORM.SelectAllEntidades();
        }

        private void Eventos_Load(object sender, EventArgs e)
        {
            if (Publica.master)
            {
                bindingSourceDelegaciones.DataSource = DBAccess.DelegacionesORM.SelectAllEntidades();
            }
            else
            {
                bindingSourceDelegaciones.DataSource = DBAccess.DelegacionesORM.SelectById(Publica.iddelegacion);
            }
            loadDataToGrid();
        }

        private void labelSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadDataToGrid()
        {
            int estado = comboBoxEstado.SelectedIndex;
            if (estado < 0) { estado = 0; }
            if (Publica.master)
            {
                int iddelegacion;
                if (comboBoxDelegacion.SelectedValue != null) { iddelegacion = (int)comboBoxDelegacion.SelectedValue; } else { iddelegacion = -1; }
                bindingSourceEventos.DataSource = DBAccess.UsuariosORM.SelectByFilters(textBoxTitulo.Text, estado, textBoxCiudad.Text, iddelegacion);
            }
            else
            {
                bindingSourceEventos.DataSource = DBAccess.UsuariosORM.SelectByFilters(textBoxTitulo.Text, estado, textBoxCiudad.Text, Publica.iddelegacion);
            }
        }

        private void labelEliminar_Click(object sender, EventArgs e)
        {
            DBAccess.EventosORM.DeleteEntidad((EVENTOS)dataGridViewEventos.SelectedRows[0].DataBoundItem);
            if (dataGridViewEventos.CurrentRow != null && dataGridViewEventos.CurrentRow.Index >= 0)
            {
                EVENTOS _entidad = (EVENTOS)dataGridViewEventos.CurrentRow.DataBoundItem;
                String mnsj = "¿Está seguro de eliminar definitivamente a " + _entidad.titulo + " ?";
                DialogResult isOK = MessageBox.Show(mnsj, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (isOK == DialogResult.OK)
                {
                    mnsj = DBAccess.EventosORM.DeleteEntidad(_entidad);
                    if (!mnsj.Equals("")) { MessageBox.Show(mnsj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    else { loadDataToGrid(); }
                }

            }
        }

        private void labelNuevo_Click(object sender, EventArgs e)
        {
            DetallesEvento f = new DetallesEvento();
            f.Show();
        }        
    }
}
