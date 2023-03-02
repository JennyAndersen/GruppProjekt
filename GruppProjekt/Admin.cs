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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            if(txtbNamn.Text == " " || txtbAdress.Text == " " || txtbTelefonnummer.Text == " " || txtbLosenord.Text == " ")
            {
                MessageBox.Show("Det saknas information");
            }
            else
            {
                try
                {

                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
