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

        public static string kundlistId { get; set; }
        public static string produktnamn { get; set; }
        public static int antal { get; set; }
        public static int totalpris { get; set; }
        public Bestallning()
        {
            InitializeComponent();
            txtbPris.Enabled = false;

        }

        Dbconnection dbconnection = new Dbconnection();
        private void Bestallning_Load(object sender, EventArgs e)
        {
            List<string> productNames = dbconnection.visaprodukt();
            cBProduktNamn.Items.AddRange(productNames.ToArray());
            dbconnection.kundlistprodukter(gridProdukter);

            dbconnection.kundvarukorg(gridVarukorg);
        }

        private void cBProduktNamn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBProduktNamn.Text == "- Välj Produkt -")
            {
                cBKvantitet.Items.Clear();
                txtbPris.Text = "";
            }
            else
            {
                cBKvantitet.Items.Clear();
                txtbPris.Text = "";
                produktnamn = cBProduktNamn.Text;
                dbconnection.visaproduktpris();
                txtbPris.Text = Dbconnection.produktPrisDb;

                for (int i = 1; i <= Convert.ToInt32(Dbconnection.produktAntalDb); i++)
                {
                    cBKvantitet.Items.Add(i);
                }
            }
            
        }

        private void btnAndra_Click(object sender, EventArgs e)
        {
            if (cBProduktNamn.Text == "- Välj Produkt -")
            {
                MessageBox.Show("Välj a produkt");
            }
            else
            {
                totalpris = Convert.ToInt32(cBKvantitet.Text) * Convert.ToInt32(txtbPris.Text);

                produktnamn = cBProduktNamn.Text;

                antal = int.Parse(cBKvantitet.Text);

                MessageBox.Show($"{produktnamn} {antal} {totalpris}");

                dbconnection.ändrakundlist();


                cBProduktNamn.Items.Clear();
                cBProduktNamn.Text = "- Välj Produkt -";
                cBKvantitet.Items.Clear();
                cBKvantitet.Text = "- Välj antal -";
                txtbPris.Text = "";


                Bestallning_Load(sender, e);
            }
           
        }

        private void gridProdukter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kundlistId = gridProdukter.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
            cBProduktNamn.Text = gridProdukter.Rows[e.RowIndex].Cells["Produkt Namn"].FormattedValue.ToString();
            cBKvantitet.Text = gridProdukter.Rows[e.RowIndex].Cells["Antal"].FormattedValue.ToString();
            string totalPris = gridProdukter.Rows[e.RowIndex].Cells["Total Pris"].FormattedValue.ToString();
            
            int pris = int.Parse(totalPris.ToString()) / int.Parse(cBKvantitet.Text);
            txtbPris.Text = pris.ToString();


        }

        private void btnlist_Click(object sender, EventArgs e)
        {

            if (cBProduktNamn.Text == "- Välj Produkt -")
            {
                MessageBox.Show("Välj a produkt");
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

        private void picExit_Click(object sender, EventArgs e)
        {
            LoggaIn loggaIn = new LoggaIn();
            this.Close();
            loggaIn.Show();
        }

        private void btnRadera_Click(object sender, EventArgs e)
        {
            dbconnection.raderakundlistprodukt();
            Bestallning_Load(sender, e);
        }

        private void btnLaggiVarukorg_Click(object sender, EventArgs e)
        {
            dbconnection.LäggiVarukorg();
            Bestallning_Load(sender, e);
            dbconnection.kundvarukorg(gridVarukorg);
            cBProduktNamn.Items.Clear();
            cBProduktNamn.Text = "- Välj Produkt -";
            cBKvantitet.Items.Clear();
            cBKvantitet.Text = "- Välj antal -";
            txtbPris.Text = "";
            Bestallning_Load(sender, e);

        }

        private void btnBetalning_Click(object sender, EventArgs e)
        {
            dbconnection.raderavarkorg();
            MessageBox.Show("Tack för din betallning.");
            Bestallning_Load(sender, e);
        }
    }
}
