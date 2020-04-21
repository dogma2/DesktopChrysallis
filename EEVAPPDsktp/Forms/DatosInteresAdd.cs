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
        private bool IsNewDato;
        private DATOSINTERES datos;
        public DatosInteresAdd(int id_deleg)
        {
            InitializeComponent();
            datos = new DATOSINTERES();
            datos.iddelegacion = id_deleg;
            datos.iddsktuser = Publica.idusuario;
            IsNewDato = true;
            
        }
        public DatosInteresAdd(DATOSINTERES datosInteres)
        {
            InitializeComponent();
            datos = datosInteres;
            IsNewDato = false;
        }

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
    }
}
