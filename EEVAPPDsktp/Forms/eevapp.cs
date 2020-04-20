using EEVAPPDsktp.Classes;
using EEVAPPDsktp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEVAPPDsktp
{
    public partial class MainStartForm : Form
    {
        public MainStartForm()
        {
            InitializeComponent();
            // set bg color transparent active
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - OPCIONES DE LOGIN

        // - - - - - Opcion INGRESAR
        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            // controla que exista
            if ( ! (textBoxUsuario.Text.Equals("") && textBoxClave.Text.Equals("")) ) {
                // - - - - - control por superuser (puerta trasera)
                if (textBoxUsuario.Text.Equals(Publica.superadmin) && textBoxClave.Text.Equals(Publica.superclave))
                {
                    menuStripMain.Enabled = true;
                    groupBoxLogin.Visible = false;
                    Publica.usuario = "SuperAdmin";
                    Publica.idusuario = 0;
                    Publica.iddelegacion = 0;
                    Publica.master = true;
                }
                else 
                {
                    DSKTUSERS us = DBAccess.AdministradoresORM.LoginDsktUser(textBoxUsuario.Text, textBoxClave.Text);
                    if ( us != null) {

                        menuStripMain.Enabled = true;
                        groupBoxLogin.Visible = false;
                        Publica.usuario = us.nickname;
                        Publica.idusuario = us.id;
                        Publica.iddelegacion = us.iddelegacion;
                        Publica.master = ((us.ctrlmaster==1)?true:false);
                        Publica.idccaa = (byte)us.idccaa;

                        }
                    else {
                        MessageBox.Show("El Usuario o Contraseña ingresados no es correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            else
            {
                MessageBox.Show("Se debe informar Usuario y Contraseña.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // - - - - - Opcion CANCELAR
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - OPCIONES DE MENU

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - Opcion EVENTOS
        private void toolStripMenuItemEventos_Click(object sender, EventArgs e)
        {
            Eventos frm = new Eventos();
            frm.ShowDialog();
        }
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - Opcion DATOS de INTERES
        private void toolStripMenuItemDatosInteres_Click(object sender, EventArgs e)
        {
            DatosInteres frm = new DatosInteres();
            frm.ShowDialog();
        }
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - Opciones de SOCIOS
        private void toolStripMenuItemSocios_Click(object sender, EventArgs e)
        {
            Socios frm = new Socios();
            frm.ShowDialog();
        }
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - Opciones de ADMINISTRACION
        private void toolStripMenuItemDelegaciones_Click(object sender, EventArgs e)
        {
            // control si tiene acceso a ver/modificar formulario
            if (!Publica.master)
            {
                MessageBox.Show("No tiene autorizacion para acceder a esta opcion.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                Delegaciones frm = new Delegaciones();
                frm.ShowDialog();
            }
        }
        private void toolStripMenuItemAdministradores_Click(object sender, EventArgs e)
        {
            Administradores frm = new Administradores();
            frm.ShowDialog();
        }
        private void toolStripMenuItemDatosAsociacion_Click(object sender, EventArgs e)
        {
            // control si tiene acceso a ver/modificar formulario
            if (!Publica.master)
            {
                MessageBox.Show("No tiene autorizacion para acceder a esta opcion.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                DatosAsociacion frm = new DatosAsociacion();
                frm.ShowDialog();
            }
        }
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - Opciones de CONFIGURACION DE APP
        private void toolStripMenuItemTraducciones_Click(object sender, EventArgs e)
        {
            // control si tiene acceso a ver/modificar formulario
            if (!Publica.master)
            {
                MessageBox.Show("No tiene autorizacion para acceder a esta opcion.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                Traducciones frm = new Traducciones();
                frm.ShowDialog();
            }
        }

        private void toolStripMenuItemConfiguracionInicial_Click(object sender, EventArgs e)
        {
            // control si tiene acceso a ver/modificar formulario
            if (!Publica.master)
            {
                MessageBox.Show("No tiene autorizacion para acceder a esta opcion.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                ConfiguracionInicial frm = new ConfiguracionInicial();
                frm.ShowDialog();
            }
        }
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - Opciones de ABOUT US
        private void toolStripMenuItemEevapp_Click(object sender, EventArgs e)
        {
            ProyectoEevapp frm = new ProyectoEevapp();
            frm.ShowDialog();

        }
        private void ToolStripMenuItemDogma2_Click(object sender, EventArgs e)
        {
            Dogma2 frm = new Dogma2();
            frm.ShowDialog();
        }
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - Opcion SALIR
        private void toolStripMenuItemSalir_Click(object sender, EventArgs e) { Application.Exit(); }
    }
}
