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
        public static string pass = "password";
        MySqlConnection conn = new MySqlConnection($"SERVER={server};DATABASE={database};UID={user};PASSWORD={pass};");

        public static int login_id { get; set; }
        public static int kund_id { get; set; }
        public static string användarnamnDb { get; set; }
        public static string lösenordDb { get; set; }

        public static string kund_namn { get; set; }
        public static string produktNamn { get; set; }
        public static string produktPris { get; set; }

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
                    login_id = reader.GetInt32(0);
                    användarnamnDb = reader.GetString(1);
                    lösenordDb = reader.GetString(2);
                    kund_id = reader.GetInt32(3);
                    kund_namn = reader.GetString(4);
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
            cmd.Parameters.AddWithValue("$produktNamn", produktNamn);
            cmd.CommandType = CommandType.StoredProcedure;
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    produktPris = reader.GetString(2);
                }
            }
            conn.Close();
        }

    }
        
    
}
