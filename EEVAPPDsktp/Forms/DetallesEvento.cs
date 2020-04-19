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
        private string imagen, destino;
        private bool modify = false;
        private EVENTOS evento;

        public DetallesEvento()
        {
            InitializeComponent();
            loadListsDataToForm();
            evento = new EVENTOS();
        }

        public DetallesEvento(EVENTOS eventos)
        {
            InitializeComponent();
            loadListsDataToForm();
            evento = eventos;
            MemoryStream ms = new MemoryStream(eventos.imagen);
            Image image = Image.FromStream(ms);
            pictureBoxImagenEvento.Image = image;
            textBoxTitulo.Text = eventos.titulo;
            if (eventos.ctrlglobal == 1)
            {
                checkBoxGlobal.Checked = true; 
            }
            else
            {
                checkBoxGlobal.Checked = false;
            }
            if (eventos.estado == 1)
            {
                checkBoxActivado.Checked = true;
            }
            else
            {
                checkBoxActivado.Checked = false;
            }
            richTextBoxDescripcion.Text = eventos.descripcion;
            richTextBoxIntroduccion.Text = eventos.intro;
            richTextBoxTransporte.Text = eventos.notastransporte;
            dateTimePickerInicio.Value = (DateTime)eventos.fechainicio;
            textBoxHoraInicio.Text = eventos.horainicio.ToString();
            dateTimePickerFechaFin.Value = (DateTime)eventos.fechafin;
            textBoxHoraFin.Text = eventos.horafin.ToString();
            comboBoxDelegacion.SelectedValue = eventos.iddelegacion;
            textBoxCiudad.Text = eventos.ciudad;
            textBoxCodigoPostal.Text = eventos.codigopostal;
            comboBoxProvincia.SelectedValue = eventos.idprovincia;
            comboBoxComunidad.SelectedValue = eventos.idccaa;
            textBoxEmail.Text = eventos.email;
            textBoxTelefono.Text = eventos.telefono;
            textBoxContacto.Text = eventos.responsable;
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
            string mensaje = validateData();
            if (mensaje.Equals(""))
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
                evento.iddsktuser = Publica.idusuario;
                MessageBox.Show("El evento se ha añadido correctamente", "Nuevo evento añadido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else {
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

        private string validateData() {
            string mensaje = "";

            if (pictureBoxImagenEvento == null)
            {
                mensaje = "Falta la imágen del evento";
            }
            else if (textBoxTitulo.Text.Equals(""))
            {
                mensaje = "Falta el título del evento";
            }
            else if (richTextBoxDescripcion.Text.Equals(""))
            {
                mensaje = "Falta la descripción del evento";
            }
            else if (richTextBoxIntroduccion.Text.Equals(""))
            {
                mensaje = "Falta la introducción del evento";
            }
            else if (richTextBoxTransporte.Text.Equals(""))
            {
                mensaje = "Faltan las notas de transporte";
            }
            else if (textBoxHoraInicio.Text.Equals(""))
            {
                mensaje = "Debes indicar una hora de inicio del evento";
            }
            else if (textBoxHoraFin.Text.Equals(""))
            {
                mensaje = "Debees indicar una hora de fin del evento";
            }
            else if (textBoxCiudad.Text.Equals(""))
            {
                mensaje = "Falta la ciudad en la que se celebrará el evento";
            }
            else if (textBoxCodigoPostal.Text.Equals(""))
            {
                mensaje = "Debes incluir el código postal de la ubicación del evento";
            }
            else if (textBoxEmail.Text.Equals(""))
            {
                mensaje = "Debes incluir un correo electrónico de contacto";
            }
            else if (textBoxTelefono.Text.Equals(""))
            {
                mensaje = "Debes incluir un teléfono de contacto";
            }
            else if (textBoxContacto.Text.Equals(""))
            {
                mensaje = "Debes incluir un responsable del evento";
            }
            else if (textBoxCodigoPostal.Text.Equals(""))
            {
                mensaje = "Debes incluir codigo postal de la ubicación del evento";
            }


            return mensaje;
        }

        private void buttonSeleccionarImagen_Click(object sender, EventArgs e)
        {
            seleccionarImagen();
        }

        private void DetallesEvento_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (modify)
            {
                DBAccess.EventosORM.ModificaEntidad(evento);
            }
            else
            {
                DBAccess.EventosORM.InsertaEntidad(evento);
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
                 */
            }
        }
    }
}
