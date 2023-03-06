using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; 

namespace GruppProjekt
{
    public partial class Bestallning : Form
    {

        MySqlConnection conn; 

        public Bestallning()
        {
            InitializeComponent();

            //Bygger upp MysqlConnection  objekt för Bestallning
            string server = "localhost";
            string database = "grupprojekt";
            string user = "root";
            string pass = "Onsala01";
            string connString = $"SERVER={server};DATABASE={database};UID={user};PASSWORD={pass};";
            conn = new MySqlConnection(connString);

            VisaProdukter();
            Varukorgen();
        }

        public void VisaProdukter(string keyword = "")
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

        }

        private void Varukorgen()
        {
            //Skapa en SQL Querry 
            string sqlQuerry = $"SELECT * FROM varukorgen";

            //skapa ett MySqlCommand object
            MySqlCommand cmd = new MySqlCommand(sqlQuerry, conn);

            //exekvera qyerry mot DB. Få data tillbaka 
            try
            {
                //Öppna koppling till DB 
                conn.Open();

                //Exekvera cmd
                MySqlDataReader reader = cmd.ExecuteReader();

                //Placera data i en datatable objekt
                DataTable dt = new DataTable();
                dt.Load(reader);

                //koppla Dt objekt som datasource till grid 
                gridVarukorg.DataSource = dt;

                //Stänga koppling till DB 
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }





    }
}
