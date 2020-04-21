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
    public partial class DatosInteres : Form
    {
        
        public DatosInteres()
        {
            InitializeComponent();
            comboBoxFiltrarXDelegacion.DisplayMember = "nombre";
            comboBoxFiltrarXDelegacion.ValueMember = "id";
            comboBoxFiltrarXDelegacion.DataSource = DelegacionesORM.SelectAllEntidades();
           /*
            if(Publica.iddelegacion != -1)
            {
                comboBoxFiltrarXDelegacion.SelectedValue = Publica.iddelegacion;

            }
            */
            comboBoxEstado.SelectedItem = "Todos";




        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DATOSINTERES _entidad = (DATOSINTERES)dataGridView1.Rows[e.RowIndex].DataBoundItem;

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
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosInteresAdd f = new DatosInteresAdd((int)comboBoxFiltrarXDelegacion.SelectedValue);
            f.ShowDialog();
            actualizarDataGrid();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                DatosInteresAdd f = new DatosInteresAdd((DATOSINTERES)dataGridView1.SelectedRows[0].DataBoundItem);
                f.ShowDialog();
                actualizarDataGrid();
            }            
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult se = MessageBox.Show("Seguro que quieres eliminar el dato de interes?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (se == DialogResult.Yes)
                {
                    DatosInteresORM.DeleteEntidad((DATOSINTERES)dataGridView1.Rows[0].DataBoundItem);
                    actualizarDataGrid();
                }
            }            
        }

        private void activadesactivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DATOSINTERES d = (DATOSINTERES)dataGridView1.SelectedRows[0].DataBoundItem;
                if(d.estado == 0)
                {
                    d.estado = 1;
                }
                else
                {
                    d.estado = 0;
                }
                DatosInteresORM.ModificaEntidad(d);
                actualizarDataGrid();
            }
            
        }
        private void actualizarDataGrid()
        {
            int estado = comboBoxEstado.SelectedIndex;
            if (estado < 0) { estado = 0; }

            int iddelegacion;
            if (comboBoxFiltrarXDelegacion.SelectedValue != null) { iddelegacion = (int)comboBoxFiltrarXDelegacion.SelectedValue; } else { iddelegacion = -1; }
            
            dataGridView1.DataSource = DBAccess.DatosInteresORM.SelectByFilters(textBoxFiltrarXnombre.Text, Convert.ToByte(estado), textBoxFiltrarXCiudad.Text, iddelegacion);                                
           
            
        }

        private void comboBoxFiltrarXDelegacion_SelectedIndexChanged(object sender, EventArgs e)
        {            
            actualizarDataGrid();
        }

        private void textBoxFiltrarXnombre_TextChanged(object sender, EventArgs e)
        {
            actualizarDataGrid();
        }

        private void comboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarDataGrid();
        }

        private void textBoxFiltrarXCiudad_TextChanged(object sender, EventArgs e)
        {
            actualizarDataGrid();
        }
    }
}
