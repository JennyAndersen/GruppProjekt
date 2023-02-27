using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GruppProjekt
{
    public partial class LoggaIn : Form
    {
        public LoggaIn()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LinkRegistrering_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrering registrering = new Registrering();
            registrering.Show();
            this.Hide();
        }
    }
}
