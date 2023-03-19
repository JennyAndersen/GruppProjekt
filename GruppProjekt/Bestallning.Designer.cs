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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bestallning));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridVarukorg = new System.Windows.Forms.DataGridView();
            this.gridProdukter = new System.Windows.Forms.DataGridView();
            this.cBKvantitet = new System.Windows.Forms.ComboBox();
            this.cBProduktNamn = new System.Windows.Forms.ComboBox();
            this.btnAndra = new System.Windows.Forms.Button();
            this.btnlist = new System.Windows.Forms.Button();
            this.btnRadera = new System.Windows.Forms.Button();
            this.btnLaggiVarukorg = new System.Windows.Forms.Button();
            this.btnBetalning = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbPris = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
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
            this.panel1.Controls.Add(this.gridVarukorg);
            this.panel1.Controls.Add(this.gridProdukter);
            this.panel1.Controls.Add(this.cBKvantitet);
            this.panel1.Controls.Add(this.cBProduktNamn);
            this.panel1.Controls.Add(this.btnAndra);
            this.panel1.Controls.Add(this.btnlist);
            this.panel1.Controls.Add(this.btnRadera);
            this.panel1.Controls.Add(this.btnLaggiVarukorg);
            this.panel1.Controls.Add(this.btnBetalning);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtbPris);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-11, -6);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 417);
            this.panel1.TabIndex = 1;
            // 
            // gridVarukorg
            // 
            this.gridVarukorg.AllowUserToAddRows = false;
            this.gridVarukorg.AllowUserToDeleteRows = false;
            this.gridVarukorg.AllowUserToResizeColumns = false;
            this.gridVarukorg.AllowUserToResizeRows = false;
            this.gridVarukorg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridVarukorg.BackgroundColor = System.Drawing.Color.White;
            this.gridVarukorg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridVarukorg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridVarukorg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridVarukorg.ColumnHeadersHeight = 30;
            this.gridVarukorg.EnableHeadersVisualStyles = false;
            this.gridVarukorg.Location = new System.Drawing.Point(418, 84);
            this.gridVarukorg.Margin = new System.Windows.Forms.Padding(2);
            this.gridVarukorg.MultiSelect = false;
            this.gridVarukorg.Name = "gridVarukorg";
            this.gridVarukorg.ReadOnly = true;
            this.gridVarukorg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridVarukorg.RowHeadersWidth = 40;
            this.gridVarukorg.RowTemplate.Height = 28;
            this.gridVarukorg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridVarukorg.Size = new System.Drawing.Size(276, 254);
            this.gridVarukorg.TabIndex = 43;
            // 
            // gridProdukter
            // 
            this.gridProdukter.AllowUserToAddRows = false;
            this.gridProdukter.AllowUserToDeleteRows = false;
            this.gridProdukter.AllowUserToResizeColumns = false;
            this.gridProdukter.AllowUserToResizeRows = false;
            this.gridProdukter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProdukter.BackgroundColor = System.Drawing.Color.White;
            this.gridProdukter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridProdukter.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProdukter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridProdukter.ColumnHeadersHeight = 30;
            this.gridProdukter.EnableHeadersVisualStyles = false;
            this.gridProdukter.Location = new System.Drawing.Point(42, 161);
            this.gridProdukter.Margin = new System.Windows.Forms.Padding(2);
            this.gridProdukter.MultiSelect = false;
            this.gridProdukter.Name = "gridProdukter";
            this.gridProdukter.ReadOnly = true;
            this.gridProdukter.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridProdukter.RowHeadersWidth = 40;
            this.gridProdukter.RowTemplate.Height = 28;
            this.gridProdukter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProdukter.Size = new System.Drawing.Size(372, 140);
            this.gridProdukter.TabIndex = 42;
            this.gridProdukter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProdukter_CellClick);
            // 
            // cBKvantitet
            // 
            this.cBKvantitet.FormattingEnabled = true;
            this.cBKvantitet.Items.AddRange(new object[] {
            "- Välj antal -"});
            this.cBKvantitet.Location = new System.Drawing.Point(250, 138);
            this.cBKvantitet.Name = "cBKvantitet";
            this.cBKvantitet.Size = new System.Drawing.Size(83, 21);
            this.cBKvantitet.TabIndex = 41;
            this.cBKvantitet.Text = "- Välj antal -";
            // 
            // cBProduktNamn
            // 
            this.cBProduktNamn.FormattingEnabled = true;
            this.cBProduktNamn.Items.AddRange(new object[] {
            "- Välj Produkt -"});
            this.cBProduktNamn.Location = new System.Drawing.Point(42, 100);
            this.cBProduktNamn.Name = "cBProduktNamn";
            this.cBProduktNamn.Size = new System.Drawing.Size(121, 21);
            this.cBProduktNamn.TabIndex = 41;
            this.cBProduktNamn.Text = "- Välj Produkt -";
            this.cBProduktNamn.SelectedIndexChanged += new System.EventHandler(this.cBProduktNamn_SelectedIndexChanged);
            // 
            // btnAndra
            // 
            this.btnAndra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAndra.Location = new System.Drawing.Point(131, 305);
            this.btnAndra.Margin = new System.Windows.Forms.Padding(2);
            this.btnAndra.Name = "btnAndra";
            this.btnAndra.Size = new System.Drawing.Size(84, 46);
            this.btnAndra.TabIndex = 40;
            this.btnAndra.Text = "Ändra list";
            this.btnAndra.UseVisualStyleBackColor = true;
            this.btnAndra.Click += new System.EventHandler(this.btnAndra_Click);
            // 
            // btnlist
            // 
            this.btnlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlist.Location = new System.Drawing.Point(43, 305);
            this.btnlist.Margin = new System.Windows.Forms.Padding(2);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(84, 46);
            this.btnlist.TabIndex = 40;
            this.btnlist.Text = "Lägg till i list";
            this.btnlist.UseVisualStyleBackColor = true;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click);
            // 
            // btnRadera
            // 
            this.btnRadera.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRadera.Location = new System.Drawing.Point(227, 305);
            this.btnRadera.Margin = new System.Windows.Forms.Padding(2);
            this.btnRadera.Name = "btnRadera";
            this.btnRadera.Size = new System.Drawing.Size(84, 46);
            this.btnRadera.TabIndex = 40;
            this.btnRadera.Text = "Radera";
            this.btnRadera.UseVisualStyleBackColor = true;
            this.btnRadera.Click += new System.EventHandler(this.btnRadera_Click);
            // 
            // btnLaggiVarukorg
            // 
            this.btnLaggiVarukorg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaggiVarukorg.Location = new System.Drawing.Point(315, 305);
            this.btnLaggiVarukorg.Margin = new System.Windows.Forms.Padding(2);
            this.btnLaggiVarukorg.Name = "btnLaggiVarukorg";
            this.btnLaggiVarukorg.Size = new System.Drawing.Size(84, 46);
            this.btnLaggiVarukorg.TabIndex = 40;
            this.btnLaggiVarukorg.Text = "Lägg till i varukorg";
            this.btnLaggiVarukorg.UseVisualStyleBackColor = true;
            this.btnLaggiVarukorg.Click += new System.EventHandler(this.btnLaggiVarukorg_Click);
            // 
            // btnBetalning
            // 
            this.btnBetalning.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBetalning.Location = new System.Drawing.Point(495, 357);
            this.btnBetalning.Margin = new System.Windows.Forms.Padding(2);
            this.btnBetalning.Name = "btnBetalning";
            this.btnBetalning.Size = new System.Drawing.Size(129, 47);
            this.btnBetalning.TabIndex = 39;
            this.btnBetalning.Text = "Betalning";
            this.btnBetalning.UseVisualStyleBackColor = true;
            this.btnBetalning.Click += new System.EventHandler(this.btnBetalning_Click);
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
            this.txtbPris.Margin = new System.Windows.Forms.Padding(2);
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
            this.pictureBox1.Location = new System.Drawing.Point(698, 257);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // picExit
            // 
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(794, -1);
            this.picExit.Margin = new System.Windows.Forms.Padding(2);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(67, 58);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 26;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // Bestallning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(863, 406);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Bestallning";
            this.Text = "Bestallning";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Bestallning_Load);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbPris;
        private System.Windows.Forms.Button btnBetalning;
        private System.Windows.Forms.Button btnLaggiVarukorg;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.ComboBox cBKvantitet;
        private System.Windows.Forms.ComboBox cBProduktNamn;
        private System.Windows.Forms.DataGridView gridProdukter;
        private System.Windows.Forms.DataGridView gridVarukorg;
        private System.Windows.Forms.Button btnRadera;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.Button btnAndra;
    }
}