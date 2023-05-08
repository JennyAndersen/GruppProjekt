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

        Dbconnection dbconnection = new Dbconnection();
        public static string  sökkundnamn { get; set; }
        public static string  kundId { get; set; }
        public static string  Namn { get; set; }
        public static string  Telefonnummer { get; set; }
        public static string  Adress { get; set; }
        public static string  Lösenord { get; set; }

        public Admin()
        {
            InitializeComponent();

            
        }


        private void Admin_Load(object sender, EventArgs e)
        {
            btnVisa_Click(sender, e);
        }

        //Knapp Spara 
        private void btnSpara_Click(object sender, EventArgs e)
        {
            try
            {
                Namn = txtbNamn.Text;
                Telefonnummer = txtbTelefonnummer.Text;
                Adress = txtbAdress.Text;
                Lösenord = txtbLosenord.Text;

                if (txtbNamn.Text != "")
                {
                    errortxtbNamn.SetError(txtbNamn, string.Empty);
                }
                else
                {
                    errortxtbNamn.SetError(txtbNamn, "Måste finns ett namn");
                }

                if (txtbTelefonnummer.Text != "")
                {
                    errortxtbTelefonnummer.SetError(txtbTelefonnummer, string.Empty);
                }
                else
                {
                    errortxtbTelefonnummer.SetError(txtbTelefonnummer, "Måste finns telefonenummer");
                }

                if (txtbAdress.Text != "")
                {
                    errortxtbAdress.SetError(txtbAdress, string.Empty);
                }
                else
                {
                    errortxtbAdress.SetError(txtbAdress, "Måste finns adress");
                }

                if (txtbLosenord.Text != "")
                {
                    errortxtbLosenord.SetError(txtbLosenord, string.Empty);
                }
                else
                {
                    errortxtbLosenord.SetError(txtbLosenord, "Måste finns lösenord");
                }

                if(txtbNamn.Text != "" && txtbTelefonnummer.Text != "" && txtbLosenord.Text != "" && txtbLosenord.Text != "")
                {
                    
                    dbconnection.kollaDubblettnamn();
                    
                    if(Dbconnection.Dubblettnamn > 0)
                    {
                        errortxtbNamn.SetError(txtbNamn, "Namnet finns redan");
                    }
                    else
                    {
                        errortxtbNamn.SetError(txtbNamn, string.Empty);

                        dbconnection.sparakund();
                        dbconnection.visaAllaKunder(gridKunder);
                    }
                    

                }
                else
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Metod för att Radera kunder


        private void gridKunder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                gridKunder.CurrentRow.Selected = true;

                kundId = gridKunder.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                txtbNamn.Text = gridKunder.Rows[e.RowIndex].Cells["Namn"].FormattedValue.ToString();
                txtbTelefonnummer.Text = gridKunder.Rows[e.RowIndex].Cells["Telefonnummer"].FormattedValue.ToString();
                txtbAdress.Text = gridKunder.Rows[e.RowIndex].Cells["Adress"].FormattedValue.ToString();

                Namn = txtbNamn.Text;
                Telefonnummer = txtbTelefonnummer.Text;
                Adress = txtbAdress.Text;
            }
            catch
            {

            }
        }

        
        private void btnRadera_Click(object sender, EventArgs e)
        {
            Namn = txtbNamn.Text;
            Telefonnummer = txtbTelefonnummer.Text;
            Adress = txtbAdress.Text;

            DialogResult result = MessageBox.Show("Är du säker på att du vill radera den kunden? \n" +
                                             $"        Kundnamn = {Namn}",
                                             "Bekräftelse",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question,
                                             MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                dbconnection.raderakund();
                btnVisa_Click(sender, e);
            }
            else if (result == DialogResult.No)
            {
                
            }
        }

        //För att visa listan

        private void btnVisa_Click(object sender, EventArgs e)
        {
            dbconnection.visaAllaKunder(gridKunder);
        }



        //Knapp för att ändra kunder 
        private void btnAndra_Click(object sender, EventArgs e)
        {
            try
            {
                Namn = txtbNamn.Text;
                Telefonnummer = txtbTelefonnummer.Text;
                Adress = txtbAdress.Text;
                Lösenord = txtbLosenord.Text;

                if (txtbNamn.Text != "")
                {
                    errortxtbNamn.SetError(txtbNamn, string.Empty);
                }
                else
                {
                    errortxtbNamn.SetError(txtbNamn, "Måste finns ett namn");
                }

                if (txtbTelefonnummer.Text != "")
                {
                    errortxtbTelefonnummer.SetError(txtbTelefonnummer, string.Empty);
                }
                else
                {
                    errortxtbTelefonnummer.SetError(txtbTelefonnummer, "Måste finns telefonenummer");
                }

                if (txtbAdress.Text != "")
                {
                    errortxtbAdress.SetError(txtbAdress, string.Empty);
                }
                else
                {
                    errortxtbAdress.SetError(txtbAdress, "Måste finns adress");
                }

          

                if (txtbNamn.Text != "" && txtbTelefonnummer.Text != "" && txtbAdress.Text != "" )
                {


                    if (Dbconnection.Dubblettnamn > 0)
                    {
                        errortxtbNamn.SetError(txtbNamn, "Namnet finns redan");
                    }
                    else
                    {
                        errortxtbNamn.SetError(txtbNamn, string.Empty);

                        
                        DialogResult result = MessageBox.Show("Är du säker på att du vill ändra den kunden? \n" +
                                                         $"        \nKundnamn = {Namn}",
                                                         "Bekräftelse",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question,
                                                         MessageBoxDefaultButton.Button2);
                        if (result == DialogResult.Yes)
                        {
                            dbconnection.ändrakund();
                            btnVisa_Click(sender, e);
                        }
                        else if (result == DialogResult.No)
                        {

                        }
                    }


                }
                else
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            LoggaIn loggaIn = new LoggaIn();
            this.Close();
            loggaIn.Show();
        }

        private void lblProdukter_Click(object sender, EventArgs e)
        {
            Produkter produkter = new Produkter();

            produkter.Show();

            this.Close();
        }

        private void txtbSok_TextChanged(object sender, EventArgs e)
        {
            sökkundnamn = txtbSok.Text;
            dbconnection.sökkundnamn(gridKunder);
        }

        private void btnSokKund_Click(object sender, EventArgs e)
        {
            txtbSok_TextChanged(sender, e);
        }
    }



}
    
            



  
