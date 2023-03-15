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
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GruppProjekt
{
    public partial class Admin : Form

    {

        public static string  Namn { get; set; }
        public static string  Telefonnummer { get; set; }
        public static string  Adress { get; set; }
        public static string  Lösenord { get; set; }

        public Admin()
        {
            InitializeComponent();

            
        }

         

        //Knapp Spara 
        private void btnSpara_Click(object sender, EventArgs e)
        {
            Namn = txtbNamn.Text;
            Telefonnummer = txtbTelefonnummer.Text;
            Adress = txtbAdress.Text;
            Lösenord = txtbLosenord.Text;
          
        }


        //För att visa listan 
       






        //Metod för att Radera kunder

       

        //Knapp för att radera kunder
        private void btnRadera_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            
        }



        //Knapp för att ändra kunder 
        private void btnAndra_Click(object sender, EventArgs e)
        {

        }

        private void gridKunder_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblProdukter_Click(object sender, EventArgs e)
        {
            Produkter produkter = new Produkter();

            produkter.Show();

            this.Close();
        }
    }



}
    
            



  
