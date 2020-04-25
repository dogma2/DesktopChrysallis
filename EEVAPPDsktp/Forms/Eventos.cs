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
// EEVAPP Project - Eventos: gestiona datos de Socios en BBDD
// PROYECTO - 2º Proyecto DAM2T
// DOGMA2 - 07/04/2020 - CEP
// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
// More Data
// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

namespace EEVAPPDsktp.Forms
{
    public partial class Eventos : Form
    {
        public Eventos()
        {
            InitializeComponent();
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

        private void textBoxTitulo_TextChanged(object sender, EventArgs e) { loadDataToGrid(); textBoxTitulo.Focus(); }

        private void comboBoxEstado_SelectedIndexChanged(object sender, EventArgs e) { loadDataToGrid(); }

        private void textBoxCiudad_TextChanged(object sender, EventArgs e) { loadDataToGrid(); }

        private void comboBoxDelegacion_SelectedIndexChanged(object sender, EventArgs e) { loadDataToGrid(); }

        // - - - - - - - - - - - - - - - - - - - - - Carga de datos en bindingSource
        private void loadDataToGrid()
        {
            int estado = comboBoxEstado.SelectedIndex;
            if (estado < 0) { estado = 0; }
            if (Publica.master)
            {
                int iddelegacion;
                if (comboBoxDelegacion.SelectedValue != null) { iddelegacion = (int)comboBoxDelegacion.SelectedValue; } else { iddelegacion = -1; }
                bindingSourceEventos.DataSource = DBAccess.EventosORM.SelectByFilters(textBoxTitulo.Text, (byte)estado, textBoxCiudad.Text, iddelegacion);
            }
            else
            {
                bindingSourceEventos.DataSource = DBAccess.EventosORM.SelectByFilters(textBoxTitulo.Text, (byte)estado, textBoxCiudad.Text, Publica.iddelegacion);
            }
        }

        // - - - - - - - - - - - - - - - - - - - - - Abre opcion NUEVA entidad
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetallesEvento frm = new DetallesEvento(new EVENTOS());
            frm.ShowDialog();
            loadDataToGrid();
        }

        // - - - - - - - - - - - - - - - - - - - - - Abre opcion MODIFICA entidad
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewEventos.CurrentRow != null && dataGridViewEventos.CurrentRow.Index >= 0)
            {
                EVENTOS entidad = (EVENTOS)dataGridViewEventos.CurrentRow.DataBoundItem;
                DetallesEvento frm = new DetallesEvento(entidad);
                frm.ShowDialog();
                loadDataToGrid();
            }
        }

        // - - - - - - - - - - - - - - - - - - - - - Abre opcion BORRA entidad
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewEventos.CurrentRow != null && dataGridViewEventos.CurrentRow.Index >= 0)
            {
                EVENTOS _entidad = (EVENTOS)dataGridViewEventos.CurrentRow.DataBoundItem;
                String mnsj = "Está seguro de eliminar definitivamente a " + _entidad.email + " ?";
                DialogResult isOK = MessageBox.Show(mnsj, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (isOK == DialogResult.OK)
                {
                    mnsj = DBAccess.EventosORM.DeleteEntidad(_entidad);
                    if (!mnsj.Equals("")) { MessageBox.Show(mnsj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    else { loadDataToGrid(); }
                }

            }
        }

        // - - - - - - - - - - - - - - - - - - - - - ACTIVA/DESACTIVA ESTADO de socio
        private void activadesactivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewEventos.CurrentRow != null && dataGridViewEventos.CurrentRow.Index >= 0)
            {
                byte estado;
                EVENTOS _entidad = (EVENTOS)dataGridViewEventos.CurrentRow.DataBoundItem;
                if (_entidad.estado == 0) { estado = 1; }
                else { estado = 0; }
                _entidad.estado = estado;
                string mnsj = DBAccess.EventosORM.ModificaEntidad(_entidad);
                if (!mnsj.Equals("")) { MessageBox.Show(mnsj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else { loadDataToGrid(); }
            }
        }

        // Retorna lista de USUARIOS filtrados por DELEGACION
        private List<EVENTOS> GetBySelectedDelegacion()
        {
            return ((DELEGACIONES)comboBoxDelegacion.SelectedItem).EVENTOS.ToList();
        }

        private void dataGridViewEventos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // obtiene los valores de objeto de la fila
            EVENTOS _entidad = (EVENTOS)dataGridViewEventos.Rows[e.RowIndex].DataBoundItem;
            // controla valor de estadoi del objeto
            if (e.ColumnIndex == 3) // Estado string Activo / Inactivo
            {
                e.CellStyle.ForeColor = Color.White;
                if (_entidad.estado == 0)
                {
                    e.CellStyle.SelectionBackColor = Color.Red;
                    e.CellStyle.BackColor = Color.Red;
                    e.Value = "Inactive";
                }
                else
                {
                    e.CellStyle.SelectionBackColor = Color.ForestGreen;
                    e.CellStyle.BackColor = Color.ForestGreen;
                    e.Value = "Active";
                }
            }
            else if (e.ColumnIndex == 5) // Delegacion
            {
                e.Value = _entidad.DELEGACIONES.nombre;
            }
        }

    }

}
