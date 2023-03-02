using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GruppProjekt
{
    public partial class Admin : Form

    {

        MySqlConnection conn;
        TextBox[] txtBoxesPersonal; 

        public Admin()
        {
            InitializeComponent();
       
            //Bygger upp MysqlConnection  objekt för Admin 
            string server = "localhost";
            string database = "grupprojekt";
            string user = "root";
            string pass = "pass"; 
            string connString = $"SERVER={server};DATABASE={database};UID={user};PASSWORD={pass};";
            conn = new MySqlConnection(connString);
            //Skapar en array ref för input av fälten 
            txtBoxesPersonal = new TextBox[] { txtbNamn, txtbTelefonnummer, txtbAdress, txtbLosenord }; 
        }

        //Metod knapp för att spara en anställd 
        public void SparaPersonal()
        {
            //validering 
            bool valid = true;

            foreach (TextBox txtBox in txtBoxesPersonal)
            {
                //Trimmar test-innehållet
                txtBox.Text = txtBox.Text.Trim();

                //Kontrollera att txtBox har text
                if (txtBox.Text == "")
                {
                    //Validering har misslyckats
                    valid = false;
                    txtBox.BackColor = Color.IndianRed;
                }
                else
                {
                    txtBox.BackColor = TextBox.DefaultBackColor;
                }
            }

            //Kontrollera valid
            if (!valid)
            {
                MessageBox.Show("Felaktig validering. Kontrollera röda fält.");
                return;
            }
            foreach (TextBox txtBox in txtBoxesPersonal)
            {
                //Trimmar test-innehållet
                txtBox.Text = txtBox.Text.Trim();

                //Kontrollera att txtBox har text
                if (txtBox.Text == "")
                {
                    //Validering har misslyckats
                    valid = false;
                    txtBox.BackColor = Color.IndianRed;
                }
                else
                {
                    txtBox.BackColor = TextBox.DefaultBackColor;
                }
            }

            //Kontrollera valid
            if (!valid)
            {
                MessageBox.Show("Felaktig validering. Kontrollera röda fält.");
                return;
            }

            //Hämta värdena från textfält 
            string namn = txtbNamn.Text.ToString(); 
            string telefonnummer = txtbTelefonnummer.Text.ToString(); 
            string adress = txtbAdress.Text.ToString(); 
            string losenord = txtbLosenord.Text.ToString(); 

            //Bygg upp SQL Querry 
            string sqlQuerry = $"CALL sparaPersonal('{namn}', '{telefonnummer}', '{adress}', '{losenord}');";

            //Skapar ett MySqlCommand objekt 
            MySqlCommand cmd = new MySqlCommand(sqlQuerry, conn);

            //skapa ett try catch block 
            try
            {
                //Öppna Connection
                conn.Open();

                //Exekvera kommando
                cmd.ExecuteReader();

                //Stänga Connection
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            MessageBox.Show("Personal tillagd!");

        }


    private void btnSpara_Click(object sender, EventArgs e)
        {
            SparaPersonal(); 
        }
    }
}
