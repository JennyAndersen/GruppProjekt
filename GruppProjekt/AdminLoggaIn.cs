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
    public partial class AdminLoggaIn : Form
    {
        public AdminLoggaIn()
        {
            InitializeComponent(); 
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            if (txtAnvändarnamnAdmin.Text == "")
            {
            MessageBox.Show("Vänligen skriv in användarnamn");
            }
            else if (txtLösenordAdmin.Text == "")
            {
             MessageBox.Show("Vänligen skriv in lösenord"); 
            }  
            else if (txtAnvändarnamnAdmin.Text == "Admin" && txtLösenordAdmin.Text == "Losen123!")
            {
                this.Hide();
                Form admin = new Admin(); 
                admin.Show();
            }

            
            

        }
    }
}
