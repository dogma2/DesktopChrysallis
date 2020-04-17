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
// EEVAPP Project - Socios: gestiona datos de Socios en BBDD
// PROYECTO - 2º Proyecto DAM2T
// DOGMA2 - 07/04/2020 - CEP
// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
// More Data
// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

namespace EEVAPPDsktp.Forms
{
    public partial class Socios : Form
    {
        public Socios()
        {
            InitializeComponent();
        }

        private void Socios_Load(object sender, EventArgs e)
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

        private void textBoxEmail_TextChanged(object sender, EventArgs e) { loadDataToGrid(); textBoxEmail.Focus(); }

        private void comboBoxLang_SelectedIndexChanged(object sender, EventArgs e) { loadDataToGrid(); }

        private void textBoxCodigoSocio_TextChanged(object sender, EventArgs e) { loadDataToGrid(); }

        private void comboBoxDelegacion_SelectedIndexChanged(object sender, EventArgs e) { loadDataToGrid();
            // if ( comboBoxDelegacion.SelectedIndex >= 0 ) { DELEGACIONES _delegacion = (DELEGACIONES)comboBoxDelegacion.SelectedItem; bindingSourceSocios.DataSource = _delegacion.USUARIOS; }
        }

        // - - - - - - - - - - - - - - - - - - - - - Carga de datos en bindingSource
        private void loadDataToGrid()
        {
            int estado = comboBoxEstado.SelectedIndex;
            if (estado < 0) { estado = 0; }
            if (Publica.master)
            {
                int iddelegacion;
                if (comboBoxDelegacion.SelectedValue != null) { iddelegacion = (int)comboBoxDelegacion.SelectedValue; } else { iddelegacion = -1; }
                bindingSourceSocios.DataSource = DBAccess.UsuariosORM.SelectByFilters(textBoxEmail.Text, estado, textBoxCodigoSocio.Text, iddelegacion);
            }
            else
            {
                bindingSourceSocios.DataSource = DBAccess.UsuariosORM.SelectByFilters(textBoxEmail.Text, estado, textBoxCodigoSocio.Text, Publica.iddelegacion);
            }
        }

        // - - - - - - - - - - - - - - - - - - - - - Abre opcion NUEVA entidad
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SociosForm frm = new SociosForm( new USUARIOS() );
            frm.ShowDialog();
            loadDataToGrid();
        }

        // - - - - - - - - - - - - - - - - - - - - - Abre opcion MODIFICA entidad
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaSocios.CurrentRow != null && dataGridViewListaSocios.CurrentRow.Index >= 0)
            {
                USUARIOS entidad = (USUARIOS)dataGridViewListaSocios.CurrentRow.DataBoundItem;
                SociosForm frm = new SociosForm(entidad);
                frm.ShowDialog();
                loadDataToGrid();
            }
        }

        // - - - - - - - - - - - - - - - - - - - - - Abre opcion BORRA entidad
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaSocios.CurrentRow != null && dataGridViewListaSocios.CurrentRow.Index >= 0)
            {
                USUARIOS _entidad = (USUARIOS)dataGridViewListaSocios.CurrentRow.DataBoundItem;
                String mnsj = "Está seguro de eliminar definitivamente a " + _entidad.email + " ?";
                DialogResult isOK = MessageBox.Show(mnsj, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (isOK == DialogResult.OK)
                {
                    mnsj = DBAccess.UsuariosORM.DeleteEntidad(_entidad);
                    if (!mnsj.Equals("")) { MessageBox.Show(mnsj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    else { loadDataToGrid(); }
                }
                
            }
        }

        // - - - - - - - - - - - - - - - - - - - - - ACTIVA/DESACTIVA ESTADO de socio
        private void activadesactivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaSocios.CurrentRow != null && dataGridViewListaSocios.CurrentRow.Index >= 0)
            {
                String title;
                byte estado;
                USUARIOS _entidad = (USUARIOS)dataGridViewListaSocios.CurrentRow.DataBoundItem;
                if (_entidad.estado == 0) { title = "Activa estado de aplicacion de "; estado = 1; }
                else { title = "Desactiva estado aplicacion de "; estado = 0; }
                String promptText = Prompt.ShowDialog(title+_entidad.email, "Nota de estado: ");
                if (!promptText.Equals(""))
                {
                    _entidad.estado = estado;
                    _entidad.notaestado = promptText;
                    _entidad.fechaestado = (long)DateTime.Now.Ticks;
                    string mnsj = DBAccess.UsuariosORM.ModificaEntidad(_entidad);
                    if (!mnsj.Equals("")) { MessageBox.Show(mnsj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    else { loadDataToGrid(); }
                }
            }
        }

        // Retorna lista de USUARIOS filtrados por DELEGACION
        private List<USUARIOS> GetBySelectedDelegacion()
        {
            return ((DELEGACIONES)comboBoxDelegacion.SelectedItem).USUARIOS.ToList();
        }

        private void dataGridViewListaSocios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // obtiene los valores de objeto de la fila
            USUARIOS _entidad = (USUARIOS)dataGridViewListaSocios.Rows[e.RowIndex].DataBoundItem;
            // controla valor de estadoi del objeto
            if (e.ColumnIndex == 3) // Estado string Activo / Inactivo
            {
                e.CellStyle.ForeColor = Color.White;
                if (_entidad.estado == 0)
                {
                    e.CellStyle.SelectionBackColor = Color.Red;
                    e.CellStyle.BackColor = Color.Red;
                    e.Value = "Inactive";
                } else {
                    e.CellStyle.SelectionBackColor = Color.ForestGreen;
                    e.CellStyle.BackColor = Color.ForestGreen;
                    e.Value = "Active";
                }
            }
        }
    }

    // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - DIALOG BOX
    // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - DIALOG BOX
    // call: string promptValue = Prompt.ShowDialog("title", "input label");
    public static class Prompt
    {
        public static string ShowDialog(string titulo, string etiqueta )
        {
            Form prompt = new Form()
            {
                Width = 520,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = titulo,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label labelText = new Label() { Left = 10, Top = 15, Text = etiqueta };
            TextBox inputText = new TextBox() { Left = 10, Top = 40, Width = 480 };
            Button confirmationButton = new Button() { Text = "OK", Left = 410, Top = 70, Width = 80,  DialogResult = DialogResult.OK };
            confirmationButton.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(labelText);
            prompt.Controls.Add(inputText);
            prompt.Controls.Add(confirmationButton);
            prompt.AcceptButton = confirmationButton;
            return prompt.ShowDialog() == DialogResult.OK ? "# "+inputText.Text : "";
        }
    }
}
