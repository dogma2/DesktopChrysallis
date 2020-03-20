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
    public partial class Traducciones : Form
    {
        public bool isModified = false;
        public Traducciones()
        {
            InitializeComponent();
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - LOAD method
        private void Traducciones_Load(object sender, EventArgs e) {


        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - CONTROL on modified content
        private void textBox2_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxLiteral1_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void textBox1_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void Traducciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isModified)
            {
                String mnsj = "Se ha modificado contenido y no ha sido grabado, desea guardar la información ??";
                DialogResult isOK = MessageBox.Show( mnsj, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (isOK == DialogResult.Yes)
                {
                    //mnsj = DBAccess.DelegacionesORM.ModificaEntidad(   );
                    if (!mnsj.Equals(""))
                    {
                        MessageBox.Show(mnsj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                }

            }
        }
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

        /*        private void dataGridViewHoteles_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
                {
                    hoteles hotel = (hoteles)dataGridViewHoteles.CurrentRow.DataBoundItem;
                    String mnsj = "Está seguro de eliminar definitivamente el hotel " + hotel.nombre + " ?";
                    DialogResult isOK = MessageBox.Show(mnsj, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (isOK == DialogResult.Yes)
                    {
                        mnsj = DBData.HotelORM.DeleteHotel(hotel);
                        if (!mnsj.Equals(""))
                        {
                            MessageBox.Show(mnsj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            e.Cancel = true;
                        }
                    }
                    else { e.Cancel = true; }
                    bindingSourceCiudades.DataSource = DBData.CiudadORM.SelectAllCiudades();
                    bindingSourceHoteles.DataSource = GetBySelectedCity();
                }

                private void dataGridViewHoteles_DeleteRow(object sender, DataGridViewRowCancelEventArgs e)
                {
                    hoteles hotel = (hoteles)dataGridViewHoteles.CurrentRow.DataBoundItem;
                    String mnsj = "Está seguro de eliminar definitivamente el hotel " + hotel.nombre + " ?";
                    DialogResult isOK = MessageBox.Show(mnsj, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (isOK == DialogResult.OK)
                    {
                        mnsj = DBData.HotelORM.DeleteHotel(hotel);
                        if (!mnsj.Equals(""))
                        {
                            MessageBox.Show(mnsj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    bindingSourceCiudades.DataSource = DBData.CiudadORM.SelectAllCiudades();
                    bindingSourceHoteles.DataSource = GetBySelectedCity();
                }









                private void dataGridViewHoteles_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            hoteles hotel = (hoteles)dataGridViewHoteles.CurrentRow.DataBoundItem;
            FormHotel frm = new FormHotel(hotel);
            frm.Text = "Modificación hotel";
            frm.ShowDialog();
            // bindingSourceCiudades.DataSource = DBData.CiudadORM.SelectAllCiudades();
            bindingSourceHoteles.DataSource = GetBySelectedCity();
        }









                private void comboBoxCiudades_SelectedIndexChanged(object sender, EventArgs e)
        {
            ciudades _ciudad;
            if (comboBoxCiudades.SelectedItem != null)
            {
                _ciudad = (ciudades)comboBoxCiudades.SelectedItem;
                bindingSourceHoteles.DataSource = _ciudad.hoteles;
            }








                private void FormHoteles_Load(object sender, EventArgs e)
        {
            bindingSourceCiudades.DataSource = DBData.CiudadORM.SelectAllCiudades();
            //bindingSourceHoteles.DataSource = DBData.HotelORM.SelectAllhoteles();
            bindingSourceHoteles.DataSource = GetBySelectedCity();
        }

        private void toolStripMenuItemNuevo_Click(object sender, EventArgs e)
        {
            FormHotel frm = new FormHotel();
            frm.Text = "Alta hotel";
            frm.ShowDialog();
            // bindingSourceCiudades.DataSource = DBData.CiudadORM.SelectAllCiudades();
            bindingSourceHoteles.DataSource = GetBySelectedCity();
        }








        */
    }
}
