using EEVAPPDsktp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEVAPPDsktp.Forms
{
    public partial class DetallesEvento : Form
    {
        // atributos de clase 
        EVENTOS entidad;
        bool isModified;

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - Constructor
        public DetallesEvento(EVENTOS entidad)
        {
            InitializeComponent();
            this.entidad = entidad;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - Form Load 
        private void DetallesEvento_Load(object sender, EventArgs e)
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
            if (entidad.id > 0) { loadDataForm(); this.Text = "Modifica Evento"; }
            else { this.Text = "Nuevo Evento"; }
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - LOAD data Form
        private void loadDataForm()
        {
            textBoxTitulo.Text = entidad.titulo;
            if (entidad.ctrlglobal == 1) { checkBoxGlobal.Checked = true; }
            else { checkBoxGlobal.Checked = false; }
            if (entidad.estado == 1) { checkBoxActivado.Checked = true; }
            else { checkBoxActivado.Checked = false; }
            richTextBoxDescripcion.Text = entidad.descripcion;
            richTextBoxIntroduccion.Text = entidad.intro;
            richTextBoxTransporte.Text = entidad.notastransporte;
            dateTimePickerInicio.Value = (DateTime)entidad.fechainicio;
            textBoxHoraInicio.Text = entidad.horainicio.ToString();
            dateTimePickerFechaFin.Value = (DateTime)entidad.fechafin;
            textBoxHoraFin.Text = entidad.horafin.ToString();
            comboBoxDelegacion.SelectedValue = entidad.iddelegacion;
            textBoxCiudad.Text = entidad.ciudad;
            textBoxCodigoPostal.Text = entidad.codigopostal;
            comboBoxProvincia.SelectedValue = entidad.idprovincia;
            comboBoxComunidad.SelectedValue = entidad.idccaa;
            textBoxEmail.Text = entidad.email;
            textBoxTelefono.Text = entidad.telefono;
            textBoxContacto.Text = entidad.responsable;
            // - - - - - - - - - imagen ->
            Image image;
            using (MemoryStream ms = new MemoryStream(entidad.imagen))
            {
                image = Image.FromStream(ms);
            }
            pictureBoxImagenEvento.Image = image;
            // - - - - - - - - - imagen //
            isModified = false;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - GET data Form
        private void getDataForm()
        {
            entidad.titulo = textBoxTitulo.Text;
            entidad.descripcion = richTextBoxDescripcion.Text;
            if (checkBoxGlobal.Checked) { entidad.ctrlglobal = 1; }
            else { entidad.ctrlglobal = 0; }
            if (checkBoxActivado.Checked) { entidad.estado = 1; }
            else { entidad.estado = 0; }
            entidad.intro = richTextBoxIntroduccion.Text;
            entidad.notastransporte = richTextBoxTransporte.Text;
            entidad.fechainicio = dateTimePickerInicio.Value.Date;
            entidad.horainicio = TimeSpan.Parse(textBoxHoraInicio.Text);
            entidad.fechafin = dateTimePickerFechaFin.Value.Date;
            if (!textBoxHoraFin.Text.Equals("")) { entidad.horafin = TimeSpan.Parse(textBoxHoraFin.Text); }
            entidad.ciudad = textBoxCiudad.Text;
            entidad.codigopostal = textBoxCodigoPostal.Text;
            entidad.email = textBoxEmail.Text;
            entidad.idprovincia = (byte)comboBoxProvincia.SelectedValue;
            entidad.idccaa = (byte)comboBoxComunidad.SelectedValue;
            if (pictureBoxImagenEvento.Image != null) {
                try
                {

                    MemoryStream stream = new MemoryStream();
                    pictureBoxImagenEvento.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] pic = stream.ToArray();
                    entidad.imagen = pic;

//                    Image img = pictureBoxImagenEvento.Image;
//                    ImageConverter converter = new ImageConverter();
//                    entidad.imagen = (byte[])converter.ConvertTo(img, typeof(byte[]));
                }
                catch (FileNotFoundException excep) { Console.WriteLine(excep.Message); }
            }
            entidad.iddelegacion = (int)comboBoxDelegacion.SelectedValue;
            entidad.telefono = textBoxTelefono.Text;
            entidad.responsable = textBoxContacto.Text;
            if (Publica.idusuario != 0) { entidad.iddsktuser = Publica.idusuario; }
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - VALIDATE data
        private bool validateData()
        {
            string errmsg = "";
            bool isOK = true;
            getDataForm();
            // - - - - - datos obligatorios
            if (isOK && pictureBoxImagenEvento.Image == null) { isOK = false; errmsg = "Falta la imágen del evento"; pictureBoxImagenEvento.Focus(); }
            if (isOK && textBoxTitulo.Text.Equals("")) { isOK = false; errmsg = "Falta el título del evento"; textBoxTitulo.Focus(); }
            if (isOK && richTextBoxDescripcion.Text.Equals("")) { isOK = false; errmsg = "Falta la descripción del evento"; richTextBoxDescripcion.Focus(); }
            if (isOK && richTextBoxIntroduccion.Text.Equals("")) { isOK = false; errmsg = "Falta la introducción del evento"; richTextBoxIntroduccion.Focus(); }
            if (isOK && textBoxHoraInicio.Text.Equals("")) { isOK = false; errmsg = "Debes indicar una hora de inicio del evento"; textBoxHoraInicio.Focus(); }
            if (isOK && textBoxCiudad.Text.Equals("")) { isOK = false; errmsg = "Falta la ciudad en la que se celebrará el evento"; textBoxCiudad.Focus(); }
            if (isOK && textBoxEmail.Text.Equals("")) { isOK = false; errmsg = "Debes incluir un correo electrónico de contacto"; textBoxEmail.Focus(); }
            if (isOK && textBoxTelefono.Text.Equals("")) { isOK = false; errmsg = "Debes incluir un teléfono de contacto"; textBoxTelefono.Focus(); }
            if (isOK && textBoxContacto.Text.Equals("")) { isOK = false; errmsg = "Debes incluir un responsable del evento"; textBoxContacto.Focus(); }
            if (!isOK) { MessageBox.Show(errmsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            return isOK;
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - SAVE data
        private bool almacenarEntidad()
        {
            bool isOK = true;
            String ormmsg = "";
            // - - - - - graba nuevo / modificacion
            if (entidad.id > 0) { ormmsg = DBAccess.EventosORM.ModificaEntidad(entidad); }
            else { ormmsg = DBAccess.EventosORM.InsertaEntidad(entidad); }
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
        private void pictureBoxImagenEvento_Click(object sender, EventArgs e) { isModified = true; }
        private void textBoxTitulo_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void checkBoxGlobal_CheckedChanged(object sender, EventArgs e) { isModified = true; }
        private void checkBoxActivado_CheckedChanged(object sender, EventArgs e) { isModified = true; }
        private void richTextBoxDescripcion_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void richTextBoxIntroduccion_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void richTextBoxTransporte_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void dateTimePickerInicio_ValueChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxHoraInicio_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void dateTimePickerFechaFin_ValueChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxHoraFin_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxCiudad_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxCodigoPostal_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxEmail_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxTelefono_TextChanged(object sender, EventArgs e) { isModified = true; }
        private void textBoxContacto_TextChanged(object sender, EventArgs e) { isModified = true; }
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
        private void DetallesEvento_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isModified)
            {
                String mnsj = "Se ha modificado contenido y no ha sido grabado, desea guardar la información ??";
                DialogResult isOK = MessageBox.Show(mnsj, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (isOK == DialogResult.Yes) { if (validateData()) { if (almacenarEntidad()) { isModified = false; this.Close(); } } }
            }
        }


        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - CARGA DE IMAGEN
        private void buttonSeleccionarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (pictureBoxImagenEvento.ImageLocation != null)
                {
                    File.Delete(pictureBoxImagenEvento.ImageLocation);
                }

                pictureBoxImagenEvento.Image = Image.FromFile(openFileDialog.FileName);

                //imagen = DateTime.Now.Ticks.ToString();
                //imagen += openFileDialog.SafeFileName;
                //destino = @"..\..\imagenes\" + imagen;
                //File.Copy(openFileDialog.FileName, destino);
                /*
                 *  Bitmap bitmapImage = picturebox.Resourses;
                    byte[] data;
                    JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create(bitmapImage));
                    using(MemoryStream ms = new MemoryStream())
                    {
                        encoder.Save(ms);
                        data = ms.ToArray();
                    }
                 */
            }
        }









        /*









                public DetallesEvento(EVENTOS eventos)
                {
                    InitializeComponent();
                    loadListsDataToForm();
                    evento = eventos;
                    if (evento.imagen != null)
                    {
                        MemoryStream ms = new MemoryStream(eventos.imagen);
                        Image image = Image.FromStream(ms);
                        pictureBoxImagenEvento.Image = image;
                    }

                }

                private void labelSalir_Click(object sender, EventArgs e)
                {
                    this.Close();
                }

                private void buttonCancelarEvento_Click(object sender, EventArgs e)
                {
                    this.Close();
                }

                private void buttonGuardarEvento_Click(object sender, EventArgs e)
                {
                    string mensaje = validateData(), ormmsg = "";
                    if (mensaje.Equals(""))
                    {
                        saveData();
                        if (modify)
                        {
                            ormmsg = DBAccess.EventosORM.ModificaEntidad(evento);
                            MessageBox.Show(ormmsg, "Evento modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            ormmsg = DBAccess.EventosORM.InsertaEntidad(evento);
                            MessageBox.Show(ormmsg, "Nuevo evento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                private byte[] ImageToByteArraybyImageConverter(Image image)
                {
                    throw new NotImplementedException();
                }

                private void loadListsDataToForm()
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
                }

                private string validateData()
                {
                    string mensaje = "";



                    return mensaje;
                }

                private void buttonSeleccionarImagen_Click(object sender, EventArgs e)
                {
                    seleccionarImagen();
                }

                private void DetallesEvento_FormClosing(object sender, FormClosingEventArgs e)
                {
                    if (validateData().Equals(""))
                    {

                    }
                }

                private void comboBoxComunidad_SelectedIndexChanged(object sender, EventArgs e)
                {
                    //isModified = true;
                    CCAA _comunidad;
                    if (comboBoxComunidad.SelectedItem != null)
                    {
                        _comunidad = (CCAA)comboBoxComunidad.SelectedItem;
                        bindingSourceProvincias.DataSource = _comunidad.PROVINCIAS;
                    }
                }

                private void DetallesEvento_Load(object sender, EventArgs e)
                {

                }

                private void saveData()
                {
                    CCAA ccaa = new CCAA();
                    evento = new EVENTOS();
                    evento.titulo = textBoxTitulo.Text;
                    evento.descripcion = richTextBoxDescripcion.Text;
                    if (checkBoxGlobal.Checked)
                    {
                        evento.ctrlglobal = 1;
                    }
                    else
                    {
                        evento.ctrlglobal = 0;
                    }
                    if (checkBoxActivado.Checked)
                    {
                        evento.estado = 1;
                    }
                    else
                    {
                        evento.estado = 0;
                    }
                    evento.intro = richTextBoxIntroduccion.Text;
                    evento.notastransporte = richTextBoxTransporte.Text;
                    evento.fechainicio = dateTimePickerInicio.Value.Date;
                    evento.horainicio = TimeSpan.Parse(textBoxHoraInicio.Text);
                    evento.fechafin = dateTimePickerFechaFin.Value.Date;
                    evento.horafin = TimeSpan.Parse(textBoxHoraFin.Text);
                    evento.ciudad = textBoxCiudad.Text;
                    evento.codigopostal = textBoxCodigoPostal.Text;
                    evento.email = textBoxEmail.Text;
                    evento.idprovincia = (byte)comboBoxProvincia.SelectedValue;
                    evento.idccaa = (byte)comboBoxComunidad.SelectedValue;
                    if (pictureBoxImagenEvento.Image != null)
                    {
                        try
                        {
                            System.Drawing.Image image = System.Drawing.Image.FromFile(destino);
                            evento.imagen = ImageToByteArraybyImageConverter(image);
                        }
                        catch (FileNotFoundException excep)
                        {
                            Console.WriteLine(excep.Message);
                        }
                    }
                    evento.iddelegacion = (int)comboBoxDelegacion.SelectedValue;
                    evento.telefono = textBoxTelefono.Text;
                    evento.responsable = textBoxContacto.Text;
                    if (Publica.idusuario != 0) { evento.iddsktuser = Publica.idusuario; }
                }


                private void seleccionarImagen()
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        if (pictureBoxImagenEvento.ImageLocation != null)
                        {
                            File.Delete(pictureBoxImagenEvento.ImageLocation);
                        }

                        pictureBoxImagenEvento.Image = Image.FromFile(openFileDialog.FileName);

                        imagen = DateTime.Now.Ticks.ToString();
                        imagen += openFileDialog.SafeFileName;

                        destino = @"..\..\imagenes\" + imagen;
                        //File.Copy(openFileDialog.FileName, destino);
                        /*
                         *  Bitmap bitmapImage = picturebox.Resourses;
                            byte[] data;
                            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                            encoder.Frames.Add(BitmapFrame.Create(bitmapImage));
                            using(MemoryStream ms = new MemoryStream())
                            {
                                encoder.Save(ms);
                                data = ms.ToArray();
                            }
                         * /
                    }
                }






        */








    }
}
