namespace GruppProjekt
{
    partial class Produkter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produkter));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridProdukter = new System.Windows.Forms.DataGridView();
            this.txtbAntal = new System.Windows.Forms.TextBox();
            this.lblAntal = new System.Windows.Forms.Label();
            this.btnVisaProdukt = new System.Windows.Forms.Button();
            this.btnRaderaProdukt = new System.Windows.Forms.Button();
            this.btnAndraProdukt = new System.Windows.Forms.Button();
            this.btnSparaProdukt = new System.Windows.Forms.Button();
            this.cbMatvarugrupp = new System.Windows.Forms.ComboBox();
            this.txtbPris = new System.Windows.Forms.TextBox();
            this.txtbProduktmarke = new System.Windows.Forms.TextBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblTelefonnummer = new System.Windows.Forms.Label();
            this.lblNamn = new System.Windows.Forms.Label();
            this.txtbProduktnamn = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdukter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.gridProdukter);
            this.panel1.Controls.Add(this.txtbAntal);
            this.panel1.Controls.Add(this.lblAntal);
            this.panel1.Controls.Add(this.btnVisaProdukt);
            this.panel1.Controls.Add(this.btnRaderaProdukt);
            this.panel1.Controls.Add(this.btnAndraProdukt);
            this.panel1.Controls.Add(this.btnSparaProdukt);
            this.panel1.Controls.Add(this.cbMatvarugrupp);
            this.panel1.Controls.Add(this.txtbPris);
            this.panel1.Controls.Add(this.txtbProduktmarke);
            this.panel1.Controls.Add(this.lblKategori);
            this.panel1.Controls.Add(this.lblAdress);
            this.panel1.Controls.Add(this.lblTelefonnummer);
            this.panel1.Controls.Add(this.lblNamn);
            this.panel1.Controls.Add(this.txtbProduktnamn);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1219, 624);
            this.panel1.TabIndex = 0;
            // 
            // gridProdukter
            // 
            this.gridProdukter.BackgroundColor = System.Drawing.Color.White;
            this.gridProdukter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdukter.Location = new System.Drawing.Point(18, 290);
            this.gridProdukter.Name = "gridProdukter";
            this.gridProdukter.RowHeadersWidth = 62;
            this.gridProdukter.RowTemplate.Height = 28;
            this.gridProdukter.Size = new System.Drawing.Size(1171, 289);
            this.gridProdukter.TabIndex = 42;
            this.gridProdukter.SelectionChanged += new System.EventHandler(this.gridProdukter_SelectionChanged);
            // 
            // txtbAntal
            // 
            this.txtbAntal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtbAntal.Location = new System.Drawing.Point(593, 177);
            this.txtbAntal.Name = "txtbAntal";
            this.txtbAntal.Size = new System.Drawing.Size(175, 26);
            this.txtbAntal.TabIndex = 41;
            // 
            // lblAntal
            // 
            this.lblAntal.AutoSize = true;
            this.lblAntal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblAntal.Location = new System.Drawing.Point(589, 154);
            this.lblAntal.Name = "lblAntal";
            this.lblAntal.Size = new System.Drawing.Size(51, 20);
            this.lblAntal.TabIndex = 40;
            this.lblAntal.Text = "Antal";
            // 
            // btnVisaProdukt
            // 
            this.btnVisaProdukt.BackColor = System.Drawing.Color.LightGreen;
            this.btnVisaProdukt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisaProdukt.Location = new System.Drawing.Point(126, 214);
            this.btnVisaProdukt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVisaProdukt.Name = "btnVisaProdukt";
            this.btnVisaProdukt.Size = new System.Drawing.Size(153, 49);
            this.btnVisaProdukt.TabIndex = 39;
            this.btnVisaProdukt.Text = "Visa Lista";
            this.btnVisaProdukt.UseVisualStyleBackColor = false;
            this.btnVisaProdukt.Click += new System.EventHandler(this.btnVisaProdukt_Click);
            // 
            // btnRaderaProdukt
            // 
            this.btnRaderaProdukt.BackColor = System.Drawing.Color.LightGreen;
            this.btnRaderaProdukt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaderaProdukt.Location = new System.Drawing.Point(602, 213);
            this.btnRaderaProdukt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRaderaProdukt.Name = "btnRaderaProdukt";
            this.btnRaderaProdukt.Size = new System.Drawing.Size(153, 49);
            this.btnRaderaProdukt.TabIndex = 38;
            this.btnRaderaProdukt.Text = "Radera";
            this.btnRaderaProdukt.UseVisualStyleBackColor = false;
            this.btnRaderaProdukt.Click += new System.EventHandler(this.btnRaderaProdukt_Click);
            // 
            // btnAndraProdukt
            // 
            this.btnAndraProdukt.BackColor = System.Drawing.Color.LightGreen;
            this.btnAndraProdukt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAndraProdukt.Location = new System.Drawing.Point(441, 214);
            this.btnAndraProdukt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAndraProdukt.Name = "btnAndraProdukt";
            this.btnAndraProdukt.Size = new System.Drawing.Size(153, 49);
            this.btnAndraProdukt.TabIndex = 37;
            this.btnAndraProdukt.Text = "Ändra";
            this.btnAndraProdukt.UseVisualStyleBackColor = false;
            this.btnAndraProdukt.Click += new System.EventHandler(this.btnAndraProdukt_Click);
            // 
            // btnSparaProdukt
            // 
            this.btnSparaProdukt.BackColor = System.Drawing.Color.LightGreen;
            this.btnSparaProdukt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSparaProdukt.Location = new System.Drawing.Point(280, 214);
            this.btnSparaProdukt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSparaProdukt.Name = "btnSparaProdukt";
            this.btnSparaProdukt.Size = new System.Drawing.Size(153, 49);
            this.btnSparaProdukt.TabIndex = 36;
            this.btnSparaProdukt.Text = "Spara";
            this.btnSparaProdukt.UseVisualStyleBackColor = false;
            this.btnSparaProdukt.Click += new System.EventHandler(this.btnSparaProdukt_Click);
            // 
            // cbMatvarugrupp
            // 
            this.cbMatvarugrupp.FormattingEnabled = true;
            this.cbMatvarugrupp.Items.AddRange(new object[] {
            "Bröd ",
            "Mejeri ",
            "Skafferivaror ",
            "Bakning ",
            "Grönsaker ",
            "Frukt ",
            "Animaliska Produkter"});
            this.cbMatvarugrupp.Location = new System.Drawing.Point(794, 175);
            this.cbMatvarugrupp.Name = "cbMatvarugrupp";
            this.cbMatvarugrupp.Size = new System.Drawing.Size(180, 28);
            this.cbMatvarugrupp.TabIndex = 35;
            // 
            // txtbPris
            // 
            this.txtbPris.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtbPris.Location = new System.Drawing.Point(405, 177);
            this.txtbPris.Name = "txtbPris";
            this.txtbPris.Size = new System.Drawing.Size(175, 26);
            this.txtbPris.TabIndex = 34;
            // 
            // txtbProduktmarke
            // 
            this.txtbProduktmarke.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtbProduktmarke.Location = new System.Drawing.Point(212, 177);
            this.txtbProduktmarke.Name = "txtbProduktmarke";
            this.txtbProduktmarke.Size = new System.Drawing.Size(175, 26);
            this.txtbProduktmarke.TabIndex = 33;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblKategori.Location = new System.Drawing.Point(790, 154);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(119, 20);
            this.lblKategori.TabIndex = 32;
            this.lblKategori.Text = "Matvarugrupp";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblAdress.Location = new System.Drawing.Point(401, 154);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(39, 20);
            this.lblAdress.TabIndex = 31;
            this.lblAdress.Text = "Pris";
            // 
            // lblTelefonnummer
            // 
            this.lblTelefonnummer.AutoSize = true;
            this.lblTelefonnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblTelefonnummer.Location = new System.Drawing.Point(208, 154);
            this.lblTelefonnummer.Name = "lblTelefonnummer";
            this.lblTelefonnummer.Size = new System.Drawing.Size(58, 20);
            this.lblTelefonnummer.TabIndex = 30;
            this.lblTelefonnummer.Text = "Märke";
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblNamn.Location = new System.Drawing.Point(14, 154);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(115, 20);
            this.lblNamn.TabIndex = 29;
            this.lblNamn.Text = "Produktnamn";
            // 
            // txtbProduktnamn
            // 
            this.txtbProduktnamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtbProduktnamn.Location = new System.Drawing.Point(18, 177);
            this.txtbProduktnamn.Name = "txtbProduktnamn";
            this.txtbProduktnamn.Size = new System.Drawing.Size(175, 26);
            this.txtbProduktnamn.TabIndex = 28;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(212, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(112, 83);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(467, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGreen;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F);
            this.panel2.Location = new System.Drawing.Point(593, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 4);
            this.panel2.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(588, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Produkter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(325, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Personal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(975, -36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Produkter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1211, 654);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Produkter";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Produkter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdukter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbMatvarugrupp;
        private System.Windows.Forms.TextBox txtbPris;
        private System.Windows.Forms.TextBox txtbProduktmarke;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblTelefonnummer;
        private System.Windows.Forms.Label lblNamn;
        private System.Windows.Forms.TextBox txtbProduktnamn;
        private System.Windows.Forms.DataGridView gridProdukter;
        private System.Windows.Forms.TextBox txtbAntal;
        private System.Windows.Forms.Label lblAntal;
        private System.Windows.Forms.Button btnVisaProdukt;
        private System.Windows.Forms.Button btnRaderaProdukt;
        private System.Windows.Forms.Button btnAndraProdukt;
        private System.Windows.Forms.Button btnSparaProdukt;
    }
}