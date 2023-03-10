namespace GruppProjekt
{
    partial class Bestallning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bestallning));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLaggiVarukorg = new System.Windows.Forms.Button();
            this.btnBetalning = new System.Windows.Forms.Button();
            this.gridVarukorg = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.gridProdukter = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbPris = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.cBProduktNamn = new System.Windows.Forms.ComboBox();
            this.cBKvantitet = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVarukorg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdukter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.cBKvantitet);
            this.panel1.Controls.Add(this.cBProduktNamn);
            this.panel1.Controls.Add(this.btnLaggiVarukorg);
            this.panel1.Controls.Add(this.btnBetalning);
            this.panel1.Controls.Add(this.gridVarukorg);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.gridProdukter);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtbPris);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-11, -6);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 417);
            this.panel1.TabIndex = 1;
            // 
            // btnLaggiVarukorg
            // 
            this.btnLaggiVarukorg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaggiVarukorg.Location = new System.Drawing.Point(225, 303);
            this.btnLaggiVarukorg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLaggiVarukorg.Name = "btnLaggiVarukorg";
            this.btnLaggiVarukorg.Size = new System.Drawing.Size(108, 46);
            this.btnLaggiVarukorg.TabIndex = 40;
            this.btnLaggiVarukorg.Text = "Lägg till i varukorg";
            this.btnLaggiVarukorg.UseVisualStyleBackColor = true;
            this.btnLaggiVarukorg.Click += new System.EventHandler(this.btnLaggiVarukorg_Click);
            // 
            // btnBetalning
            // 
            this.btnBetalning.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBetalning.Location = new System.Drawing.Point(495, 357);
            this.btnBetalning.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBetalning.Name = "btnBetalning";
            this.btnBetalning.Size = new System.Drawing.Size(129, 47);
            this.btnBetalning.TabIndex = 39;
            this.btnBetalning.Text = "Vidare till betalning";
            this.btnBetalning.UseVisualStyleBackColor = true;
            // 
            // gridVarukorg
            // 
            this.gridVarukorg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVarukorg.Location = new System.Drawing.Point(383, 86);
            this.gridVarukorg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridVarukorg.Name = "gridVarukorg";
            this.gridVarukorg.RowHeadersWidth = 62;
            this.gridVarukorg.RowTemplate.Height = 28;
            this.gridVarukorg.Size = new System.Drawing.Size(241, 254);
            this.gridVarukorg.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(439, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 29);
            this.label6.TabIndex = 37;
            this.label6.Text = "Varukorg";
            // 
            // gridProdukter
            // 
            this.gridProdukter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdukter.Location = new System.Drawing.Point(42, 164);
            this.gridProdukter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridProdukter.Name = "gridProdukter";
            this.gridProdukter.RowHeadersWidth = 62;
            this.gridProdukter.RowTemplate.Height = 28;
            this.gridProdukter.Size = new System.Drawing.Size(291, 131);
            this.gridProdukter.TabIndex = 36;
            this.gridProdukter.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProdukter_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(247, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Önskad kvantitet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Pris";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Produktnamn";
            // 
            // txtbPris
            // 
            this.txtbPris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPris.Location = new System.Drawing.Point(42, 136);
            this.txtbPris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbPris.Name = "txtbPris";
            this.txtbPris.Size = new System.Drawing.Size(69, 21);
            this.txtbPris.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "Beställning";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(650, 257);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // picExit
            // 
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(746, -1);
            this.picExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(67, 58);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 26;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // cBProduktNamn
            // 
            this.cBProduktNamn.FormattingEnabled = true;
            this.cBProduktNamn.Items.AddRange(new object[] {
            "- Välj Produkt -",
            "Havregryn",
            "Yoghurt",
            "Mjölk",
            "Vaniljpulver",
            "Honung",
            "Havregryn",
            "Banan",
            "Ägg",
            "Bacon",
            "Spenat",
            "Tomat",
            "Avokado",
            "Smör",
            "Fralla",
            "Ättika",
            "Rödlök",
            "Socker"});
            this.cBProduktNamn.Location = new System.Drawing.Point(42, 100);
            this.cBProduktNamn.Name = "cBProduktNamn";
            this.cBProduktNamn.Size = new System.Drawing.Size(121, 21);
            this.cBProduktNamn.TabIndex = 41;
            this.cBProduktNamn.Text = "- Välj Produkt -";
            this.cBProduktNamn.SelectedIndexChanged += new System.EventHandler(this.cBProduktNamn_SelectedIndexChanged);
            // 
            // cBKvantitet
            // 
            this.cBKvantitet.FormattingEnabled = true;
            this.cBKvantitet.Items.AddRange(new object[] {
            "- Välj antal -",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cBKvantitet.Location = new System.Drawing.Point(250, 138);
            this.cBKvantitet.Name = "cBKvantitet";
            this.cBKvantitet.Size = new System.Drawing.Size(83, 21);
            this.cBKvantitet.TabIndex = 41;
            this.cBKvantitet.Text = "- Välj antal -";
            // 
            // Bestallning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 406);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Bestallning";
            this.Text = "Bestallning";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVarukorg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdukter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gridProdukter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbPris;
        private System.Windows.Forms.Button btnBetalning;
        private System.Windows.Forms.DataGridView gridVarukorg;
        private System.Windows.Forms.Button btnLaggiVarukorg;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.ComboBox cBKvantitet;
        private System.Windows.Forms.ComboBox cBProduktNamn;
    }
}