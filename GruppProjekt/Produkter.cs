using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
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
        public static string produkid { get; set; }
        public static string produktnamn { get; set; }
        public static string märke { get; set; }
        public static string pris { get; set; }
        public static string antal { get; set; }
        public static string matvarugruppid { get; set; }
        public static string matvarugrupp { get; set; }

        
        public Produkter()
        {
            InitializeComponent();

        }

        Dbconnection dbconnection = new Dbconnection();
        private void btnVisaProdukt_Click(object sender, EventArgs e)
        {
            Dbconnection dbconnection = new Dbconnection();
            dbconnection.visaprodukter(gridProdukter);
        }

        private void btnSparaProdukt_Click(object sender, EventArgs e)
        {
            try
            {
                produktnamn = txtbProduktnamn.Text;
                märke = txtbProduktmarke.Text; ;
                pris = txtbPris.Text;
                antal = txtbAntal.Text;
                matvarugrupp = cbMatvarugrupp.Text;


                if (txtbProduktnamn.Text != "")
                {
                    errortxtbProduktnamn.SetError(txtbProduktnamn, string.Empty);
                }
                else
                {
                    errortxtbProduktnamn.SetError(txtbProduktnamn, "Måste finns ett produktnamn");
                }

                if (txtbProduktmarke.Text != "")
                {
                    errortxtbProduktmarke.SetError(txtbProduktmarke, string.Empty);
                }
                else
                {
                    errortxtbProduktmarke.SetError(txtbProduktmarke, "Måste finns ett märktnamn");
                }

                if (txtbPris.Text != "")
                {
                    errortxtbPris.SetError(txtbPris, string.Empty);
                }
                else
                {
                    errortxtbPris.SetError(txtbPris, "Måste finns pris");
                }

                if (txtbAntal.Text != "")
                {
                    errortxtbAntal.SetError(txtbAntal, string.Empty);
                }
                else
                {
                    errortxtbAntal.SetError(txtbAntal, "Måste finns antal produkter");
                }

                if (cbMatvarugrupp.Text != "- Välj matvarugrupp-")
                {
                    errorcbMatvarugrupp.SetError(cbMatvarugrupp, string.Empty);
                }
                else
                {
                    errorcbMatvarugrupp.SetError(cbMatvarugrupp, "Måste Välj matvarugrupp");
                }

                if (txtbProduktnamn.Text != "" && txtbProduktmarke.Text != "" && txtbPris.Text != "" && txtbAntal.Text != "" && cbMatvarugrupp.Text != "- Välj matvarugrupp-")
                {

                    dbconnection.kollaDubblettproduktnamn();
                    
                    if (Dbconnection.Dubblettproduktnamn > 0)
                    {
                        errortxtbProduktnamn.SetError(txtbProduktnamn, "Namnet finns redan");
                    }
                    else
                    {
                        errortxtbProduktnamn.SetError(txtbProduktnamn, string.Empty);
                        dbconnection.sparaprodukter();
                        dbconnection.visaprodukter(gridProdukter);

                        txtbProduktnamn.Text = "";
                        txtbPris.Text = "";
                        txtbAntal.Text = "";
                        txtbProduktmarke.Text = "";
                        cbMatvarugrupp.Text = "- Välj matvarugrupp-";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAndraProdukt_Click(object sender, EventArgs e)
        {
            try
            {
                produktnamn = txtbProduktnamn.Text;
                märke = txtbProduktmarke.Text; ;
                pris = txtbPris.Text;
                antal = txtbAntal.Text;
                matvarugrupp = cbMatvarugrupp.Text;

                if (txtbProduktnamn.Text != "")
                {
                    errortxtbProduktnamn.SetError(txtbProduktnamn, string.Empty);
                }
                else
                {
                    errortxtbProduktnamn.SetError(txtbProduktnamn, "Måste finns ett produktnamn");
                }

                if (txtbProduktmarke.Text != "")
                {
                    errortxtbProduktmarke.SetError(txtbProduktmarke, string.Empty);
                }
                else
                {
                    errortxtbProduktmarke.SetError(txtbProduktmarke, "Måste finns ett märktnamn");
                }

                if (txtbPris.Text != "")
                {
                    errortxtbPris.SetError(txtbPris, string.Empty);
                }
                else
                {
                    errortxtbPris.SetError(txtbPris, "Måste finns pris");
                }

                if (txtbAntal.Text != "")
                {
                    errortxtbAntal.SetError(txtbAntal, string.Empty);
                }
                else
                {
                    errortxtbAntal.SetError(txtbAntal, "Måste finns antal produkter");
                }

                if (cbMatvarugrupp.Text != "- Välj matvarugrupp-")
                {
                    errorcbMatvarugrupp.SetError(cbMatvarugrupp, string.Empty);
                }
                else
                {
                    errorcbMatvarugrupp.SetError(cbMatvarugrupp, "Måste Välj matvarugrupp");
                }

                if (txtbProduktnamn.Text != "" && txtbProduktmarke.Text != "" && txtbPris.Text != "" && txtbAntal.Text != "" && cbMatvarugrupp.Text != "- Välj matvarugrupp-")
                {
                    DialogResult result = MessageBox.Show("Är du säker på att du vill ändra den kunden? \n" +
                                                         $"        \n Produktnamn = {produktnamn}" +
                                                         $"        \n Märke = {märke}" +
                                                         $"        \n Pris = {pris}" +
                                                         $"        \n Antal = {antal}" +
                                                         $"        \n Matvarugrupp = {matvarugrupp}",
                                                         "Bekräftelse",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question,
                                                         MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        txtbProduktnamn.Text = "";
                        txtbPris.Text = "";
                        txtbAntal.Text = "";
                        txtbProduktmarke.Text = "";
                        cbMatvarugrupp.Text = "- Välj matvarugrupp-";

                        dbconnection.ändraprodukt();
                        btnVisaProdukt_Click(sender, e);

                    }


                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnRaderaProdukt_Click(object sender, EventArgs e)
        {
            produktnamn = txtbProduktnamn.Text;


            DialogResult result = MessageBox.Show("Är du säker på att du vill radera den kunden? \n" +
                                             $"        Produktnamn = {produktnamn}",
                                             "Bekräftelse",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question,
                                             MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                dbconnection.raderaprodukt();
                btnVisaProdukt_Click(sender, e);
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void Produkter_Load(object sender, EventArgs e)
        {
            Dbconnection dbconnection = new Dbconnection();
            dbconnection.visaprodukter(gridProdukter);
        }

        private void gridProdukter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Dbconnection dbconnection = new Dbconnection();
            try
            {
                gridProdukter.CurrentRow.Selected = true;

                produkid = gridProdukter.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                txtbProduktnamn.Text = gridProdukter.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                txtbProduktmarke.Text = gridProdukter.Rows[e.RowIndex].Cells["Märke"].FormattedValue.ToString();
                txtbPris.Text = gridProdukter.Rows[e.RowIndex].Cells["Pris"].FormattedValue.ToString();
                txtbAntal.Text = gridProdukter.Rows[e.RowIndex].Cells["Antal"].FormattedValue.ToString();
                cbMatvarugrupp.Text = gridProdukter.Rows[e.RowIndex].Cells["Matvarugrupp"].FormattedValue.ToString();


                produktnamn = txtbProduktnamn.Text;
                märke = txtbProduktmarke.Text;
                pris = txtbPris.Text;
                antal= txtbAntal.Text;
                matvarugruppid = cbMatvarugrupp.SelectedItem.ToString();

                matvarugrupp = cbMatvarugrupp.Text;

            }
            catch
            {

            }
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            LoggaIn loggaIn = new LoggaIn();
            this.Close();
            loggaIn.Show();
        }

        private void lblKunder_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Close();
            admin.Show();
        }
    }


}
