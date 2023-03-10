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
    public partial class Administratör : Form
    {
        public Administratör()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtLösenordAdmin.Text == "Losenord123!")
            {
                Admin admin = new Admin();
                admin.Show();
                this.Hide();
            } else if (txtLösenordAdmin.Text == "")
            {
                MessageBox.Show("Vänligen skriv in lösenord.");
            } else
            {
                MessageBox.Show("Fel lösenord. Vänligen försök igen.");
            }
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            LoggaIn loggaIn = new LoggaIn();

            loggaIn.Show();

            this.Close();
        }
    }
}
