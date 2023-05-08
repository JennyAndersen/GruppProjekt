using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
        //Här definieras fyra statiska egenskaper (kundlistId, produktnamn,
        //antal, totalpris) av typen string och int. Dessa används
        //för att lagra information om en beställning och verkar vara
        //tillgängliga från olika delar av koden.
        public static string kundlistId { get; set; }
        public static string produktnamn { get; set; }
        public static int antal { get; set; }
        public static int totalpris { get; set; }

        // Detta är en konstruktor för en klass med namnet Bestallning.
        // Konstruktorn körs när en ny instans av klassen skapas. Här inaktiveras
        // en textruta (txtbPris) genom att sätta Enabled-egenskapen till false.
        public Bestallning()
        {
            InitializeComponent();
            txtbPris.Enabled = false;

        }

        //Här skapas en instans av klassen Dbconnection,
        //vilket antyder att det finns en separat klass
        //för att hantera en databasanslutning.
        Dbconnection dbconnection = new Dbconnection();

        //Detta är en händelsehanterare för händelsen Load av Bestallning-formuläret.
        private void Bestallning_Load(object sender, EventArgs e)
        {
            //När formuläret laddas, hämtas produktinformation från databasen genom
            //att anropa visaprodukt-metoden på dbconnection-objektet. 
            List<string> productNames = dbconnection.visaprodukt();
            //Produktinformationen används för att fylla en rullgardinsmeny (cBProduktNamn).
            cBProduktNamn.Items.AddRange(productNames.ToArray());

            //Därefter anropas kundlistprodukter- och kundvarukorg-metoderna på
            //dbconnection-objektet för att hämta och visa beställnings- och varukorgsinformation
            //i data-grid-vyer (gridProdukter och gridVarukorg).
            dbconnection.kundlistprodukter(gridProdukter);
            dbconnection.kundvarukorg(gridVarukorg);
        }

        //Denna metod hanterar händelsen när användaren väljer en produkt i rullgardinsmenyn (cBProduktNamn).
        private void cBProduktNamn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBProduktNamn.Text == "- Välj Produkt -")
            {
                //Rullgardinsmenyn cBKvantitet töms.
                cBKvantitet.Items.Clear();
                //Textrutan txtbPris töms.
                txtbPris.Text = "";
            }
            else
            {
                cBKvantitet.Items.Clear();
                txtbPris.Text = "";
                //Värdet i den valda produkten sparas i variabeln produktnamn.
                produktnamn = cBProduktNamn.Text;
                //Metoden visaproduktpris anropas på dbconnection-objektet för
                //att hämta produktpriset från databasen. Det hämtade priset
                //sparas i Dbconnection.produktPrisDb.
                dbconnection.visaproduktpris();
                //Produktpriset visas i textrutan txtbPris.
                txtbPris.Text = Dbconnection.produktPrisDb;

                //En loop körs från 1 till antalet som finns i Dbconnection.produktAntalDb
                //(som antas vara en siffra som representerar tillgängligt antal). Varje nummer läggs
                //till i rullgardinsmenyn cBKvantitet.
                for (int i = 1; i <= Convert.ToInt32(Dbconnection.produktAntalDb); i++)
                {
                    cBKvantitet.Items.Add(i);
                }
            }
            
        }

        ////Om ingen produkt har valts från rullgardinsmenyn (cBProduktNamn), visas ett meddelande att
        //användaren ska välja en produkt.
        private void btnAndra_Click(object sender, EventArgs e)
        {
            if (cBProduktNamn.Text == "- Välj Produkt -")
            {
                //Om ingen produkt har valts från rullgardinsmenyn (cBProduktNamn), visas ett meddelande att
                //användaren ska välja en produkt.
                MessageBox.Show("Välj en produkt");
            }
            else
            {
                //Beräkning av totalpris genom att multiplicera antalet valt i rullgardinsmenyn (cBKvantitet)
                //med priset angivet i textrutan txtbPris.
                totalpris = Convert.ToInt32(cBKvantitet.Text) * Convert.ToInt32(txtbPris.Text);

                //Produktnamnet och antalet sparas i respektive variabel.
                produktnamn = cBProduktNamn.Text;
                antal = int.Parse(cBKvantitet.Text);

                //Ett meddelande visas med produktnamnet, antalet och det totala priset.
                MessageBox.Show($"{produktnamn} {antal} {totalpris}");

                //Metoden ändrakundlist anropas på dbconnection-objektet.
                dbconnection.ändrakundlist();

                //Rullgardinsmenyn cBProduktNamn, rullgardinsmenyn cBKvantitet, textrutan txtbPris töms
                //och återställs till standardvärden.
                cBProduktNamn.Items.Clear();
                cBProduktNamn.Text = "- Välj Produkt -";
                cBKvantitet.Items.Clear();
                cBKvantitet.Text = "- Välj antal -";
                txtbPris.Text = "";

                //Metoden Bestallning_Load anropas för att uppdatera innehållet i formuläret.
                Bestallning_Load(sender, e);
            }
           
        }

        //gridProdukter_CellClick är en händelsehanterare för händelsen CellClick på en data-grid-vy med namnet gridProdukter.
        //Denna metod aktiveras när en cell i datagrid-vyn klickas på.
        private void gridProdukter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kundlistId = gridProdukter.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
            cBProduktNamn.Text = gridProdukter.Rows[e.RowIndex].Cells["Produkt Namn"].FormattedValue.ToString();
            cBKvantitet.Text = gridProdukter.Rows[e.RowIndex].Cells["Antal"].FormattedValue.ToString();
            string totalPris = gridProdukter.Rows[e.RowIndex].Cells["Total Pris"].FormattedValue.ToString();
            
            int pris = int.Parse(totalPris.ToString()) / int.Parse(cBKvantitet.Text);
            txtbPris.Text = pris.ToString();


        }
        //Denna metod hanterar händelsen när användaren klickar på knappen "list". Om ingen produkt har valts från
        //rullgardinsmenyn (cBProduktNamn),
        //visas ett meddelande att användaren ska välja en produkt.
        private void btnlist_Click(object sender, EventArgs e)
        {

            if (cBProduktNamn.Text == "- Välj Produkt -")
            {
       
                MessageBox.Show("Välj en produkt");
            }
            else
            {
                totalpris = Convert.ToInt32(cBKvantitet.Text) * Convert.ToInt32(txtbPris.Text);

                produktnamn = cBProduktNamn.Text;

                antal = int.Parse(cBKvantitet.Text);

                // Add a new row to the grid with the values
                dbconnection.sparakundlist();

                cBProduktNamn.Items.Clear();
                cBProduktNamn.Text = "- Välj Produkt -";
                cBKvantitet.Items.Clear();
                cBKvantitet.Text = "- Välj antal -";
                txtbPris.Text = "";
                Bestallning_Load(sender, e);
            }

        }

        //Denna metod hanterar händelsen när användaren klickar på en bildkontroll med namnet "picExit".
        //När detta sker skapas en ny instans av formuläret LoggaIn, det aktuella formuläret stängs (this.Close())
        //och det nya formuläret loggaIn visas.
        private void picExit_Click(object sender, EventArgs e)
        {
            LoggaIn loggaIn = new LoggaIn();
            this.Close();
            loggaIn.Show();
        }


        //Denna metod hanterar händelsen när användaren klickar på knappen "Radera". Metoden
        //raderakundlistprodukt anropas på dbconnection-objektet för att radera den valda produkten
        //från kundlistan. Sedan anropas metoden Bestallning_Load för att uppdatera innehållet i formuläret.
        private void btnRadera_Click(object sender, EventArgs e)
        {
            dbconnection.raderakundlistprodukt();
            Bestallning_Load(sender, e);
        }

        //Denna metod hanterar händelsen när användaren klickar på knappen "Lägg i Varukorg"
        private void btnLaggiVarukorg_Click(object sender, EventArgs e)
        {
            //Metoden LäggiVarukorg anropas på dbconnection-objektet
            //för att lägga till den valda produkten i varukorgen.
            dbconnection.LäggiVarukorg();

            //Metoden Bestallning_Load anropas för att uppdatera innehållet i formuläret.
            Bestallning_Load(sender, e);

            //Metoden kundvarukorg anropas på dbconnection-objektet för att hämta och visa
            //varukorgen i datagrid-vyn gridVarukorg.
            dbconnection.kundvarukorg(gridVarukorg);

            //Rullgardinsmenyn cBProduktNamn, rullgardinsmenyn cBKvantitet, textrutan txtbPris
            //töms och återställs till standardvärden.
            cBProduktNamn.Items.Clear();
            cBProduktNamn.Text = "- Välj Produkt -";
            cBKvantitet.Items.Clear();
            cBKvantitet.Text = "- Välj antal -";
            txtbPris.Text = "";

            //Metoden Bestallning_Load anropas igen för att uppdatera innehållet i formuläret.
            Bestallning_Load(sender, e);

        }

        //Denna metod hanterar händelsen när användaren klickar på knappen "Betalning".
        private void btnBetalning_Click(object sender, EventArgs e)
        {
            dbconnection.raderavarkorg();
            MessageBox.Show("Tack för din order, din order kommer att behandlas så fort som möjligt. Vi har skickat en orderbekräftelse till angivet telefonnummer och faktura kommer att skickas till angiven adress efter leverans.");
            Bestallning_Load(sender, e);
        }
    }
}
