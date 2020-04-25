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

// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
// EEVAPP Project - DatosInteres: gestiona datos de Socios en BBDD
// PROYECTO - 2º Proyecto DAM2T
// DOGMA2 - 07/04/2020 - CEP
// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
// More Data
// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

namespace EEVAPPDsktp.Forms
{
    public partial class DatosInteres : Form
    {
        
        public DatosInteres()
        {
            InitializeComponent();
        }

        private void DatosInteres_Load(object sender, EventArgs e)
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

        private void textBoxFiltroNombre_TextChanged(object sender, EventArgs e) { loadDataToGrid(); textBoxNombre.Focus(); }

        private void comboBoxEstado_SelectedIndexChanged(object sender, EventArgs e) { loadDataToGrid();  }

        private void textBoxCiudad_TextChanged(object sender, EventArgs e) { loadDataToGrid();  }

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
                bindingSourceDatosInteres.DataSource = DBAccess.DatosInteresORM.SelectByFilters(textBoxNombre.Text, (byte)estado, textBoxCiudad.Text, iddelegacion);
            }
            else
            {
                bindingSourceDatosInteres.DataSource = DBAccess.DatosInteresORM.SelectByFilters(textBoxNombre.Text, (byte)estado, textBoxCiudad.Text, Publica.iddelegacion);
            }
        }

        // - - - - - - - - - - - - - - - - - - - - - Abre opcion NUEVA entidad
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosInteresAdd frm = new DatosInteresAdd(new DATOSINTERES());
            frm.ShowDialog();
            loadDataToGrid();
        }

        // - - - - - - - - - - - - - - - - - - - - - Abre opcion MODIFICA entidad
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaDatosInteres.CurrentRow != null && dataGridViewListaDatosInteres.CurrentRow.Index >= 0)
            {
                DATOSINTERES entidad = (DATOSINTERES)dataGridViewListaDatosInteres.CurrentRow.DataBoundItem;
                DatosInteresAdd frm = new DatosInteresAdd(entidad);
                frm.ShowDialog();
                loadDataToGrid();
            }
        }

        // - - - - - - - - - - - - - - - - - - - - - Abre opcion BORRA entidad
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaDatosInteres.CurrentRow != null && dataGridViewListaDatosInteres.CurrentRow.Index >= 0)
            {
                DATOSINTERES _entidad = (DATOSINTERES)dataGridViewListaDatosInteres.CurrentRow.DataBoundItem;
                String mnsj = "Está seguro de eliminar definitivamente a " + _entidad.email + " ?";
                DialogResult isOK = MessageBox.Show(mnsj, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (isOK == DialogResult.OK)
                {
                    mnsj = DBAccess.DatosInteresORM.DeleteEntidad(_entidad);
                    if (!mnsj.Equals("")) { MessageBox.Show(mnsj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    else { loadDataToGrid(); }
                }

            }
        }

        // - - - - - - - - - - - - - - - - - - - - - ACTIVA/DESACTIVA ESTADO de socio
        private void activadesactivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaDatosInteres.CurrentRow != null && dataGridViewListaDatosInteres.CurrentRow.Index >= 0)
            {
                byte estado;
                DATOSINTERES _entidad = (DATOSINTERES)dataGridViewListaDatosInteres.CurrentRow.DataBoundItem;
                if (_entidad.estado == 0) { estado = 1; }
                else { estado = 0; }
                _entidad.estado = estado;
                string mnsj = DBAccess.DatosInteresORM.ModificaEntidad(_entidad);
                if (!mnsj.Equals("")) { MessageBox.Show(mnsj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else { loadDataToGrid(); }
            }
        }

        // Retorna lista de USUARIOS filtrados por DELEGACION
        private List<DATOSINTERES> GetBySelectedDelegacion()
        {
            return ((DELEGACIONES)comboBoxDelegacion.SelectedItem).DATOSINTERES.ToList();
        }

        private void dataGridViewListaDatosInteres_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // obtiene los valores de objeto de la fila
            DATOSINTERES _entidad = (DATOSINTERES)dataGridViewListaDatosInteres.Rows[e.RowIndex].DataBoundItem;
            // controla valor de estadoi del objeto
            if (e.ColumnIndex == 2) // Estado string Activo / Inactivo
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
            else if (e.ColumnIndex == 4) // Delegacion
            {
                e.Value = _entidad.DELEGACIONES.nombre;
            }

        }

    }
}
