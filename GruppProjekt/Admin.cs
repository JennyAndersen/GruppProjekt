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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GruppProjekt
{
    public partial class Admin : Form

    {

        MySqlConnection conn;
        TextBox[] txtBoxesKunder;

        public Admin()
        {
            InitializeComponent();

            //Bygger upp MysqlConnection  objekt för Admin 
            string server = "localhost";
            string database = "grupprojekt";
            string user = "root";
            string pass = "Onsala01";
            string connString = $"SERVER={server};DATABASE={database};UID={user};PASSWORD={pass};";
            conn = new MySqlConnection(connString);
            //Skapar en array ref för input av fälten 
            txtBoxesKunder = new TextBox[] { txtbNamn, txtbTelefonnummer, txtbAdress, txtbLosenord };
        }

        //Metod knapp för att spara en anställd 
        public void SparaKunder()
        {
            //validering 
            bool valid = true;

            foreach (TextBox txtBox in txtBoxesKunder)
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
            foreach (TextBox txtBox in txtBoxesKunder)
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
            string sqlQuerry = $"CALL sparaKunder('{namn}', '{telefonnummer}', '{adress}', '{losenord}');";

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

            VisaKunder();
            MessageBox.Show("Kund tillagd!");

        }

        //Knapp Spara 
        private void btnSpara_Click(object sender, EventArgs e)
        {
            SparaKunder();
        }


        //För att visa listan 
        public void VisaKunder(string keyword = "")
        {
            //Skapa en sql querrry 
            string sqlQuerry;
            if (keyword == "") sqlQuerry = $"CALL visaKunder();";
            else sqlQuerry = $"CALL sökKunder('{keyword}');";

            //skapa ett objekt av mysqlcommand
            MySqlCommand cmd = new MySqlCommand(sqlQuerry, conn);

            //Exekvera querry mot DB. Få data tillbaka
            try
            {
                //Öppnar koppling till DB
                conn.Open();

                //Exekvera cmd
                MySqlDataReader reader = cmd.ExecuteReader();

                //Placera data i en DataTable objekt
                DataTable dt = new DataTable();
                dt.Load(reader);

                //Koppla TD objekt som DataSource till Grid
                gridKunder.DataSource = dt;

                //Ladda Reader på Nytt
                reader = cmd.ExecuteReader();

                //Tömma kundlista 
                Kund.kund.Clear();

                while (reader.Read())
                {
                    //Hämta och spara data till variablerna 
                    int id = Convert.ToInt32(reader["kunder_id"]);
                    string namn = reader["kunder_namn"].ToString();
                    string telefonnummer = reader["kunder_telefonnummer"].ToString();
                    string adress = reader["kunder_adress"].ToString();
                    string losenord = reader["kunder_losenord"].ToString();

                    //Skapa ett kund objekt och spara i den statiska listan 
                    Kund.kund.Add(new Kund(id, namn, telefonnummer, adress, losenord));
                }

                //stänga kopplingen till db
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            //Enabla knapp för Update och Delete
        }

        private void ValjKund()
        {
            //Kontrollera att vi har en markerad rad i grid
            if (gridKunder.SelectedRows.Count != 1) return;

            //Hämta data från grid
            DataGridViewSelectedRowCollection row = gridKunder.SelectedRows;
            int id = Convert.ToInt32(row[0].Cells[0].Value);

            //Skriva in data från grid till formulär
            foreach (Kund kund in Kund.kund)
            {
                // Kontrollera ID property
                if (kund.id == id)
                {

                    txtbNamn.Text = kund.namn; 
                    txtbTelefonnummer.Text = kund.telefonnummer;
                    txtbAdress.Text = kund.adress; 
                    txtbLosenord.Text = kund.losenord;

                    break;

                }
            }

        }
       





        //Metod för att Radera kunder

        public void RaderaKunder()
        {
            //Kontrollera att vi har en markerad rad i grid
            if (gridKunder.SelectedRows.Count != 1) return;

            //Hämta data från grid
            DataGridViewSelectedRowCollection row = gridKunder.SelectedRows;
            int id = Convert.ToInt32(row[0].Cells[0].Value);

            //Skapar en SQL Querry
            string SqlQuerry = $"CALL raderaKunder({id});";

            //MySqlCommand
            MySqlCommand cmd = new MySqlCommand(SqlQuerry, conn);

            try
            {
                //Öppna koppling till DB
                conn.Open();

                //Exekverar commando
                cmd.ExecuteReader();

                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            //Hämta den nya datan
            VisaKunder();
        }

        //Knapp för att radera kunder
        private void btnRadera_Click(object sender, EventArgs e)
        {
            RaderaKunder();
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            VisaKunder();
        }



        //Metoder för att Ändra kunder

        private void AndraKunder()
        {
            //Kontrollera att vi har en markerad rad i grid
            if (gridKunder.SelectedRows.Count != 1) return;

            //Hämta data från grid
            DataGridViewSelectedRowCollection row = gridKunder.SelectedRows;
            int id = Convert.ToInt32(row[0].Cells[0].Value);

            //hämta värden från txtfält
            string namn = txtbNamn.Text;
            string telefonnummer = txtbTelefonnummer.Text;
            string adress = txtbAdress.Text;
            string losenord = txtbLosenord.Text;
           
            //Skapar en SQL Querry
            string SqlQuerry = $"CALL andraKunder( {id}, '{namn}', '{telefonnummer}', '{adress}', '{losenord}');";

            //MySqlCommand
            MySqlCommand cmd = new MySqlCommand(SqlQuerry, conn);

            try
            {
                //Öppna koppling till DB
                conn.Open();

                //Exekverar commando
                cmd.ExecuteReader();

                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            //Hämta den nya datan
            VisaKunder();
        }

        //Knapp för att ändra kunder 
        private void btnAndra_Click(object sender, EventArgs e)
        {
            AndraKunder();
        }

        private void gridKunder_SelectionChanged(object sender, EventArgs e)
        {
            ValjKund();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }



}
    
            



  
