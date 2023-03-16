using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace GruppProjekt
{
    internal class Dbconnection
    {
        public static string server = "localhost";
        public static string database = "grupprojekt";
        public static string user = "root";
        public static string pass = "0909";
        MySqlConnection conn = new MySqlConnection($"SERVER={server};DATABASE={database};UID={user};PASSWORD={pass};");

        public static int login_idDb { get; set; }
        public static int kund_idDb { get; set; }
        public static string användarnamnDb { get; set; }
        public static string lösenordDb { get; set; }
        public static int Dubblettnamn { get; set; }

        public static string kund_namnDb { get; set; }
        public static string produktNamnDb { get; set; }
        public static string produktPrisDb { get; set; }

        public void kundLogin()
        {
            LoggaIn loggaIn = new LoggaIn();
            string query = "grupprojekt.Kundlogin";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("$login_användarnamn", LoggaIn.användarnamn);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    login_idDb = reader.GetInt32(0);
                    användarnamnDb = reader.GetString(1);
                    lösenordDb = reader.GetString(2);
                    kund_idDb = reader.GetInt32(3);
                }
            }
            conn.Close();
        }

        public void visaProdukter()
        {
            LoggaIn loggaIn = new LoggaIn();
            string query = "grupprojekt.visaProdukt";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("$produktNamn", produktNamnDb);
            cmd.CommandType = CommandType.StoredProcedure;
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    produktPrisDb = reader.GetString(2);
                }
            }
            conn.Close();
        }


        public void kollaDubblettnamn()
        {
            string query = "grupprojekt.kollaDubblettnamn;";

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("$Dubblettnamn", Admin.Namn );
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Dubblettnamn = reader.GetInt32(0);

                }
            }
            conn.Close(); ;
        }


        public void sparakund()
        {

            Admin admin = new Admin();
            string query = "grupprojekt.sparakund;";

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("$kund_namn", Admin.Namn);
            cmd.Parameters.AddWithValue("$kund_telefonnummer", Admin.Telefonnummer);
            cmd.Parameters.AddWithValue("$kund_adress", Admin.Adress);
            cmd.Parameters.AddWithValue("$kund_lösenord", Admin.Lösenord);

            var ds = new DataSet();

            cmd.ExecuteReader();

            conn.Close();
        }



        internal void visaAllaKunder(DataGridView dataGridView)
        {
            string query = "grupprojekt.visaAllaKunder";
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);


            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                DataTable table = new DataTable();
                table.Load(reader);
                dataGridView.DataSource = table;
            }
            conn.Close();
        }


        public void ändrakund()
        {
            
            Admin admin = new Admin();
            string query = "grupprojekt.ändrakund;";

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("$kund_id", Admin.kundId);
            cmd.Parameters.AddWithValue("$kund_namn", Admin.Namn);
            cmd.Parameters.AddWithValue("$kund_telefonnummer", Admin.Telefonnummer);
            cmd.Parameters.AddWithValue("$kund_adress", Admin.Adress);

            var ds = new DataSet();

            cmd.ExecuteReader();

            conn.Close();
        }


        public void raderakund()
        {

            Admin admin = new Admin();
            string query = "grupprojekt.raderakund;";

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("$kund_idDb", Admin.kundId);

            var ds = new DataSet();

            cmd.ExecuteReader();

            conn.Close();
        }


        internal void sökkundnamn(DataGridView dataGridView)
        {
            string query = "grupprojekt.sökkundnamn";
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("$kundnamn", Admin.sökkundnamn);


            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                DataTable table = new DataTable();
                table.Load(reader);
                dataGridView.DataSource = table;
            }
            conn.Close();
        }

        
        internal void visalistprodukter(DataGridView dataGridView)
        {
            string query = "grupprojekt.visalistprodukter";
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);
           

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                DataTable table = new DataTable();
                table.Load(reader);
                dataGridView.DataSource = table;
            }
            conn.Close();
        }
          
        internal void sparalistprodukter()
        {
            string query = "grupprojekt.sparalistprodukter";
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("$produktnamn", Bestallning.produktnamn);
            cmd.Parameters.AddWithValue("$antal", Bestallning.antal);
            cmd.Parameters.AddWithValue("$totalpris", Bestallning.totalpris);
            var ds = new DataSet();

            cmd.ExecuteReader();

            conn.Close();
        }




    }


}
