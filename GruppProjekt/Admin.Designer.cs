namespace GruppProjekt
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.btnVisa = new System.Windows.Forms.Button();
            this.txtbSok = new System.Windows.Forms.TextBox();
            this.btnSokKund = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridKunder = new System.Windows.Forms.DataGridView();
            this.btnRadera = new System.Windows.Forms.Button();
            this.btnAndra = new System.Windows.Forms.Button();
            this.btnSpara = new System.Windows.Forms.Button();
            this.txtbLosenord = new System.Windows.Forms.TextBox();
            this.txtbAdress = new System.Windows.Forms.TextBox();
            this.txtbTelefonnummer = new System.Windows.Forms.TextBox();
            this.lblLosenord = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblTelefonnummer = new System.Windows.Forms.Label();
            this.lblNamn = new System.Windows.Forms.Label();
            this.txtbNamn = new System.Windows.Forms.TextBox();
            this.lblProdukter = new System.Windows.Forms.Label();
            this.lblKunder = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errortxtbNamn = new System.Windows.Forms.ErrorProvider(this.components);
            this.errortxtbTelefonnummer = new System.Windows.Forms.ErrorProvider(this.components);
            this.errortxtbAdress = new System.Windows.Forms.ErrorProvider(this.components);
            this.errortxtbLosenord = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKunder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errortxtbNamn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errortxtbTelefonnummer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errortxtbAdress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errortxtbLosenord)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.picExit);
            this.panel1.Controls.Add(this.btnVisa);
            this.panel1.Controls.Add(this.txtbSok);
            this.panel1.Controls.Add(this.btnSokKund);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.gridKunder);
            this.panel1.Controls.Add(this.btnRadera);
            this.panel1.Controls.Add(this.btnAndra);
            this.panel1.Controls.Add(this.btnSpara);
            this.panel1.Controls.Add(this.txtbLosenord);
            this.panel1.Controls.Add(this.txtbAdress);
            this.panel1.Controls.Add(this.txtbTelefonnummer);
            this.panel1.Controls.Add(this.lblLosenord);
            this.panel1.Controls.Add(this.lblAdress);
            this.panel1.Controls.Add(this.lblTelefonnummer);
            this.panel1.Controls.Add(this.lblNamn);
            this.panel1.Controls.Add(this.txtbNamn);
            this.panel1.Controls.Add(this.lblProdukter);
            this.panel1.Controls.Add(this.lblKunder);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 406);
            this.panel1.TabIndex = 0;
            // 
            // picExit
            // 
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(730, 5);
            this.picExit.Margin = new System.Windows.Forms.Padding(2);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(67, 58);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 25;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // btnVisa
            // 
            this.btnVisa.BackColor = System.Drawing.Color.LightGreen;
            this.btnVisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisa.Location = new System.Drawing.Point(10, 143);
            this.btnVisa.Name = "btnVisa";
            this.btnVisa.Size = new System.Drawing.Size(102, 32);
            this.btnVisa.TabIndex = 24;
            this.btnVisa.Text = "Visa Lista";
            this.btnVisa.UseVisualStyleBackColor = false;
            this.btnVisa.Click += new System.EventHandler(this.btnVisa_Click);
            // 
            // txtbSok
            // 
            this.txtbSok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtbSok.Location = new System.Drawing.Point(449, 151);
            this.txtbSok.Margin = new System.Windows.Forms.Padding(2);
            this.txtbSok.Name = "txtbSok";
            this.txtbSok.Size = new System.Drawing.Size(118, 20);
            this.txtbSok.TabIndex = 23;
            this.txtbSok.TextChanged += new System.EventHandler(this.txtbSok_TextChanged);
            // 
            // btnSokKund
            // 
            this.btnSokKund.BackColor = System.Drawing.Color.LightGreen;
            this.btnSokKund.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSokKund.Location = new System.Drawing.Point(571, 143);
            this.btnSokKund.Name = "btnSokKund";
            this.btnSokKund.Size = new System.Drawing.Size(119, 32);
            this.btnSokKund.TabIndex = 22;
            this.btnSokKund.Text = "Sök Kundnamn";
            this.btnSokKund.UseVisualStyleBackColor = false;
            this.btnSokKund.Click += new System.EventHandler(this.btnSokKund_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(141, 5);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 54);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(311, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGreen;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F);
            this.panel2.Location = new System.Drawing.Point(220, 39);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 3);
            this.panel2.TabIndex = 19;
            // 
            // gridKunder
            // 
            this.gridKunder.AllowUserToAddRows = false;
            this.gridKunder.AllowUserToDeleteRows = false;
            this.gridKunder.AllowUserToResizeColumns = false;
            this.gridKunder.AllowUserToResizeRows = false;
            this.gridKunder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridKunder.BackgroundColor = System.Drawing.Color.White;
            this.gridKunder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridKunder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridKunder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridKunder.ColumnHeadersHeight = 30;
            this.gridKunder.EnableHeadersVisualStyles = false;
            this.gridKunder.Location = new System.Drawing.Point(0, 192);
            this.gridKunder.Margin = new System.Windows.Forms.Padding(2);
            this.gridKunder.MultiSelect = false;
            this.gridKunder.Name = "gridKunder";
            this.gridKunder.ReadOnly = true;
            this.gridKunder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridKunder.RowHeadersWidth = 40;
            this.gridKunder.RowTemplate.Height = 28;
            this.gridKunder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridKunder.Size = new System.Drawing.Size(603, 214);
            this.gridKunder.TabIndex = 18;
            this.gridKunder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridKunder_CellClick);
            // 
            // btnRadera
            // 
            this.btnRadera.BackColor = System.Drawing.Color.LightGreen;
            this.btnRadera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRadera.Location = new System.Drawing.Point(327, 143);
            this.btnRadera.Name = "btnRadera";
            this.btnRadera.Size = new System.Drawing.Size(102, 32);
            this.btnRadera.TabIndex = 16;
            this.btnRadera.Text = "Radera";
            this.btnRadera.UseVisualStyleBackColor = false;
            this.btnRadera.Click += new System.EventHandler(this.btnRadera_Click);
            // 
            // btnAndra
            // 
            this.btnAndra.BackColor = System.Drawing.Color.LightGreen;
            this.btnAndra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAndra.Location = new System.Drawing.Point(220, 143);
            this.btnAndra.Name = "btnAndra";
            this.btnAndra.Size = new System.Drawing.Size(102, 32);
            this.btnAndra.TabIndex = 15;
            this.btnAndra.Text = "Ändra";
            this.btnAndra.UseVisualStyleBackColor = false;
            this.btnAndra.Click += new System.EventHandler(this.btnAndra_Click);
            // 
            // btnSpara
            // 
            this.btnSpara.BackColor = System.Drawing.Color.LightGreen;
            this.btnSpara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpara.Location = new System.Drawing.Point(113, 143);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(102, 32);
            this.btnSpara.TabIndex = 14;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = false;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // txtbLosenord
            // 
            this.txtbLosenord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtbLosenord.Location = new System.Drawing.Point(451, 103);
            this.txtbLosenord.Margin = new System.Windows.Forms.Padding(2);
            this.txtbLosenord.Name = "txtbLosenord";
            this.txtbLosenord.Size = new System.Drawing.Size(118, 20);
            this.txtbLosenord.TabIndex = 13;
            // 
            // txtbAdress
            // 
            this.txtbAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtbAdress.Location = new System.Drawing.Point(303, 103);
            this.txtbAdress.Margin = new System.Windows.Forms.Padding(2);
            this.txtbAdress.Name = "txtbAdress";
            this.txtbAdress.Size = new System.Drawing.Size(118, 20);
            this.txtbAdress.TabIndex = 12;
            // 
            // txtbTelefonnummer
            // 
            this.txtbTelefonnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtbTelefonnummer.Location = new System.Drawing.Point(152, 103);
            this.txtbTelefonnummer.Margin = new System.Windows.Forms.Padding(2);
            this.txtbTelefonnummer.Name = "txtbTelefonnummer";
            this.txtbTelefonnummer.Size = new System.Drawing.Size(118, 20);
            this.txtbTelefonnummer.TabIndex = 11;
            // 
            // lblLosenord
            // 
            this.lblLosenord.AutoSize = true;
            this.lblLosenord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLosenord.Location = new System.Drawing.Point(456, 90);
            this.lblLosenord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLosenord.Name = "lblLosenord";
            this.lblLosenord.Size = new System.Drawing.Size(59, 13);
            this.lblLosenord.TabIndex = 10;
            this.lblLosenord.Text = "Lösenord";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdress.Location = new System.Drawing.Point(308, 90);
            this.lblAdress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(45, 13);
            this.lblAdress.TabIndex = 9;
            this.lblAdress.Text = "Adress";
            // 
            // lblTelefonnummer
            // 
            this.lblTelefonnummer.AutoSize = true;
            this.lblTelefonnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonnummer.Location = new System.Drawing.Point(157, 90);
            this.lblTelefonnummer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefonnummer.Name = "lblTelefonnummer";
            this.lblTelefonnummer.Size = new System.Drawing.Size(93, 13);
            this.lblTelefonnummer.TabIndex = 8;
            this.lblTelefonnummer.Text = "Telefonnummer";
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamn.Location = new System.Drawing.Point(17, 90);
            this.lblNamn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(39, 13);
            this.lblNamn.TabIndex = 7;
            this.lblNamn.Text = "Namn";
            // 
            // txtbNamn
            // 
            this.txtbNamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtbNamn.Location = new System.Drawing.Point(12, 103);
            this.txtbNamn.Margin = new System.Windows.Forms.Padding(2);
            this.txtbNamn.Name = "txtbNamn";
            this.txtbNamn.Size = new System.Drawing.Size(118, 20);
            this.txtbNamn.TabIndex = 6;
            // 
            // lblProdukter
            // 
            this.lblProdukter.AutoSize = true;
            this.lblProdukter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProdukter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdukter.Location = new System.Drawing.Point(392, 18);
            this.lblProdukter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProdukter.Name = "lblProdukter";
            this.lblProdukter.Size = new System.Drawing.Size(87, 20);
            this.lblProdukter.TabIndex = 5;
            this.lblProdukter.Text = "Produkter";
            this.lblProdukter.Click += new System.EventHandler(this.lblProdukter_Click);
            // 
            // lblKunder
            // 
            this.lblKunder.AutoSize = true;
            this.lblKunder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKunder.Location = new System.Drawing.Point(217, 18);
            this.lblKunder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKunder.Name = "lblKunder";
            this.lblKunder.Size = new System.Drawing.Size(66, 20);
            this.lblKunder.TabIndex = 4;
            this.lblKunder.Text = "Kunder";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(638, 253);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // errortxtbNamn
            // 
            this.errortxtbNamn.ContainerControl = this;
            // 
            // errortxtbTelefonnummer
            // 
            this.errortxtbTelefonnummer.ContainerControl = this;
            // 
            // errortxtbAdress
            // 
            this.errortxtbAdress.ContainerControl = this;
            // 
            // errortxtbLosenord
            // 
            this.errortxtbLosenord.ContainerControl = this;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(807, 425);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKunder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errortxtbNamn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errortxtbTelefonnummer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errortxtbAdress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errortxtbLosenord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblProdukter;
        private System.Windows.Forms.Label lblKunder;
        private System.Windows.Forms.TextBox txtbNamn;
        private System.Windows.Forms.TextBox txtbLosenord;
        private System.Windows.Forms.TextBox txtbAdress;
        private System.Windows.Forms.TextBox txtbTelefonnummer;
        private System.Windows.Forms.Label lblLosenord;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblTelefonnummer;
        private System.Windows.Forms.Label lblNamn;
        private System.Windows.Forms.Button btnRadera;
        private System.Windows.Forms.Button btnAndra;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gridKunder;
        private System.Windows.Forms.TextBox txtbSok;
        private System.Windows.Forms.Button btnSokKund;
        private System.Windows.Forms.Button btnVisa;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.ErrorProvider errortxtbNamn;
        private System.Windows.Forms.ErrorProvider errortxtbTelefonnummer;
        private System.Windows.Forms.ErrorProvider errortxtbAdress;
        private System.Windows.Forms.ErrorProvider errortxtbLosenord;
    }
}