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
        TextBox[] txtBoxesPersonal;

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

            VisaPersonal();
            MessageBox.Show("Personal tillagd!");

        }

        //Knapp Spara 
        private void btnSpara_Click(object sender, EventArgs e)
        {
            SparaPersonal();
        }


        //För att visa listan 
        public void VisaPersonal(string keyword = "")
        {
            //Skapa en sql querrry 
            string sqlQuerry;
            if (keyword == "") sqlQuerry = $"CALL visaPersonal();";
            else sqlQuerry = $"CALL sökPersonal('{keyword}');";

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
                gridPersonal.DataSource = dt;

                //Ladda Reader på Nytt
                reader = cmd.ExecuteReader();

                //Tömma personallista 
                Personal.personal.Clear();

                while (reader.Read())
                {
                    //Hämta och spara data till variablerna 
                    int id = Convert.ToInt32(reader["personal_id"]);
                    string namn = reader["personal_namn"].ToString();
                    string telefonnummer = reader["personal_telefonnummer"].ToString();
                    string adress = reader["personal_adress"].ToString();
                    string losenord = reader["personal_losenord"].ToString();

                    //Skapa ett personal objekt och spara i den statiska listan 
                    Personal.personal.Add(new Personal(id, namn, telefonnummer, adress, losenord));
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

        private void ValjPersonal()
        {
            //Kontrollera att vi har en markerad rad i grid
            if (gridPersonal.SelectedRows.Count != 1) return;

            //Hämta data från grid
            DataGridViewSelectedRowCollection row = gridPersonal.SelectedRows;
            int id = Convert.ToInt32(row[0].Cells[0].Value);

            //Skriva in data från grid till formulär
            foreach (Personal personal in Personal.personal)
            {
                // Kontrollera ID property
                if (personal.id == id)
                {

                    txtbNamn.Text = personal.namn; 
                    txtbTelefonnummer.Text = personal.telefonnummer;
                    txtbAdress.Text = personal.adress; 
                    txtbLosenord.Text = personal.losenord;

                    break;

                }
            }

        }
       
        private void gridPersonal_SelectionChanged_1(object sender, EventArgs e)
        {
            ValjPersonal();
        }




        //Metod för att Radera personal 

        public void RaderaPersonal()
        {
            //Kontrollera att vi har en markerad rad i grid
            if (gridPersonal.SelectedRows.Count != 1) return;

            //Hämta data från grid
            DataGridViewSelectedRowCollection row = gridPersonal.SelectedRows;
            int id = Convert.ToInt32(row[0].Cells[0].Value);

            //Skapar en SQL Querry
            string SqlQuerry = $"CALL raderaPersonal({id});";

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
            VisaPersonal();
        }

        //Knapp för att radera personal 
        private void btnRadera_Click(object sender, EventArgs e)
        {
            RaderaPersonal();
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            VisaPersonal();
        }



        //Metoder för att Ändra personal 

        private void AndraPersonal()
        {
            //Kontrollera att vi har en markerad rad i grid
            if (gridPersonal.SelectedRows.Count != 1) return;

            //Hämta data från grid
            DataGridViewSelectedRowCollection row = gridPersonal.SelectedRows;
            int id = Convert.ToInt32(row[0].Cells[0].Value);

            //hämta värden från txtfält
            string namn = txtbNamn.Text;
            string telefonnummer = txtbTelefonnummer.Text;
            string adress = txtbAdress.Text;
            string losenord = txtbLosenord.Text;
           
            //Skapar en SQL Querry
            string SqlQuerry = $"CALL andraPersonal( {id}, '{namn}', '{telefonnummer}', '{adress}', '{losenord}');";

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
            VisaPersonal();
        }

        //Knapp för att ändra personal 
        private void btnAndra_Click(object sender, EventArgs e)
        {
            AndraPersonal();
        }

      
    }



}
    
            



  
