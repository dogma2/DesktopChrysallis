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
    public partial class ProyectoEevapp : Form
    {
        public ProyectoEevapp()
        {
            InitializeComponent();
        }

        private void labelDescription_Click(object sender, EventArgs e) { this.Close(); }
        private void pictureBoxLogo_Click(object sender, EventArgs e) { this.Close(); }
        private void groupProyecto_Enter(object sender, EventArgs e) { this.Close(); }
        private void ProyectoEevapp_Click(object sender, EventArgs e) { this.Close(); }
    }
}
