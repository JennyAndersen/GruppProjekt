using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GruppProjekt
{

   

    public partial class Produkter : Form
    {
        MySqlConnection conn;
        TextBox[] txtBoxesProdukter;

        public Produkter()
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
            txtBoxesProdukter = new TextBox[] { txtbProduktnamn, txtbProduktmarke, txtbPris, txtbAntal };
        }

        public void SparaProdukter()
        {
            //validering
            bool valid = true;

            foreach (TextBox txtBox in txtBoxesProdukter)
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
            foreach (TextBox txtBox in txtBoxesProdukter)
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
            string produktnamn = txtbProduktnamn.Text.ToString();
            string produktmarke = txtbProduktmarke.Text.ToString();
            decimal pris = Convert.ToDecimal(txtbPris.Text);
            string matvarugrupp = cbMatvarugrupp.Text.ToString();
            int antal = Convert.ToInt32(txtbAntal.Text);

            //Bygg upp SQL Querry 
            string sqlQuerry = $"CALL sparaProdukter('{produktnamn}', '{produktmarke}', '{pris}', '{matvarugrupp}', '{antal}');";

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

            VisaProdukter();
            MessageBox.Show("Produkt är tillagd!");
        }

        private void btnSparaProdukt_Click(object sender, EventArgs e)
        {
            SparaProdukter(); 
        }

        public void VisaProdukter(string keyword = "" )
        {
            //Skapa en sql querrry 
            string sqlQuerry;
            if (keyword == "") sqlQuerry = $"CALL visaProdukter();";
            else sqlQuerry = $"CALL sokProdukter('{keyword}');";

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
                gridProdukter.DataSource = dt;

                //Ladda Reader på Nytt
                reader = cmd.ExecuteReader();

                //Tömma personallista 
                Produkt.produkt.Clear();

                while (reader.Read())
                {
                    //Hämta och spara data till variablerna 
                    int produktid = Convert.ToInt32(reader["produkter_produktid"]);
                    string produktnamn = reader["produkter_produktnamn"].ToString();
                    string produktmarke = reader["produkter_produktmarke"].ToString();
                    string matvarugrupp = reader["produkter_matvarugrupp"].ToString();
                    decimal pris = Convert.ToDecimal(reader["produkter_pris"]);
                    int antal = Convert.ToInt32(reader["produkter_antal"]);


                    //Skapa ett personal objekt och spara i den statiska listan 
                    Produkt.produkt.Add(new Produkt(produktid, produktnamn, produktmarke, pris, matvarugrupp, antal));
                }

                //stänga kopplingen till db
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            //Enabla knapp för update och delet 
        }

        private void ValjProdukt()
        {
            //Kontrollera att vi har en markerad rad i grid
            if (gridProdukter.SelectedRows.Count != 1) return;

            //Hämta data från grid
            DataGridViewSelectedRowCollection row = gridProdukter.SelectedRows;
            int produktid = Convert.ToInt32(row[0].Cells[0].Value);

            //Skriva in data från grid till formulär
            foreach (Produkt produkt in Produkt.produkt)
            {
                // Kontrollera ID property
                if (produkt.produktid == produktid)
                {

                    txtbProduktnamn.Text = produkt.produktnamn;
                    txtbProduktmarke.Text = produkt.produktmarke;
                    txtbPris.Text = produkt.pris.ToString();
                    cbMatvarugrupp.Text = produkt.matvarugrupp;
                    txtbAntal.Text = produkt.antal.ToString();

                    break;

                }
            }

        }

        private void gridProdukter_SelectionChanged(object sender, EventArgs e)
        {
            ValjProdukt(); 
        }

        public void RaderaProdukter()
        {

            //Kontrollera att vi har en markerad rad i grid
            if (gridProdukter.SelectedRows.Count != 1) return;

            //Hämta data från grid
            DataGridViewSelectedRowCollection row = gridProdukter.SelectedRows;
            int produktid = Convert.ToInt32(row[0].Cells[0].Value);

            //Skapar en SQL Querry
            string SqlQuerry = $"CALL raderaProdukter({produktid});";

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
            VisaProdukter();
        }

        private void btnRaderaProdukt_Click(object sender, EventArgs e)
        {
            RaderaProdukter();
        }

        private void btnVisaProdukt_Click(object sender, EventArgs e)
        {
            VisaProdukter();
        }

        private void AndraProdukter()
        {
            //Kontrollera att vi har en markerad rad i grid
            if (gridProdukter.SelectedRows.Count != 1) return;

            //Hämta data från grid
            DataGridViewSelectedRowCollection row = gridProdukter.SelectedRows;
            int produktid = Convert.ToInt32(row[0].Cells[0].Value);

            //hämta värden från txtfält
            string produktnamn = txtbProduktnamn.Text.ToString();
            string produktmarke = txtbProduktmarke.Text.ToString();
            decimal pris = Convert.ToDecimal(txtbPris.Text);
            string matvarugrupp = cbMatvarugrupp.Text.ToString();
            int antal = Convert.ToInt32(txtbAntal.Text);

            //Skapar en SQL Querry
            string SqlQuerry = $"CALL andraProdukter( '{produktid}', '{produktnamn}', '{produktmarke}', '{pris}', '{matvarugrupp}', '{antal}');";

            
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
            VisaProdukter();
        }

        private void btnAndraProdukt_Click(object sender, EventArgs e)
        {
            AndraProdukter();
        }
    }


}
