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
        public static string användarnamn { get; set; }
        public static string lösenord { get; set; }



        public LoggaIn()
        {
            InitializeComponent();
        }
       
  

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                användarnamn = txtAnvändarnamn.Text;
                lösenord = txtLösenord.Text;

                Dbconnection dbconnection = new Dbconnection();
                dbconnection.kundLogin();



                if (användarnamn == Dbconnection.användarnamnDb && lösenord == Dbconnection.lösenordDb)
                {
                    Bestallning bestallning = new Bestallning();

                    bestallning.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("wrong username and password");
                }
            }
            catch
            {
                    MessageBox.Show("w");

            }



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Administratör administratör = new Administratör();

            administratör.Show();
            this.Hide();
        }

        private void btnNyKund_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hej och Välkommen kära kund! Vänligen kontakta kundtjänst för ett inlogg på kundtjanst@kampholludvig.se.");
        }

        private void picExit_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}
