namespace GruppProjekt
{
    partial class LoggaIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoggaIn));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtbAnvandarnamn = new System.Windows.Forms.TextBox();
            this.txtbLosenord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLosenord = new System.Windows.Forms.Label();
            this.lblAnvandarnamn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLoggain = new System.Windows.Forms.Button();
            this.LinkRegistrering = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(710, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // txtbAnvandarnamn
            // 
            this.txtbAnvandarnamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbAnvandarnamn.Location = new System.Drawing.Point(334, 152);
            this.txtbAnvandarnamn.Name = "txtbAnvandarnamn";
            this.txtbAnvandarnamn.Size = new System.Drawing.Size(260, 39);
            this.txtbAnvandarnamn.TabIndex = 1;
            // 
            // txtbLosenord
            // 
            this.txtbLosenord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbLosenord.Location = new System.Drawing.Point(334, 217);
            this.txtbLosenord.Name = "txtbLosenord";
            this.txtbLosenord.Size = new System.Drawing.Size(260, 39);
            this.txtbLosenord.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inloggning";
            // 
            // lblLosenord
            // 
            this.lblLosenord.AutoSize = true;
            this.lblLosenord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLosenord.Location = new System.Drawing.Point(174, 222);
            this.lblLosenord.Name = "lblLosenord";
            this.lblLosenord.Size = new System.Drawing.Size(141, 32);
            this.lblLosenord.TabIndex = 2;
            this.lblLosenord.Text = "Lösenord";
            // 
            // lblAnvandarnamn
            // 
            this.lblAnvandarnamn.AutoSize = true;
            this.lblAnvandarnamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnvandarnamn.Location = new System.Drawing.Point(94, 157);
            this.lblAnvandarnamn.Name = "lblAnvandarnamn";
            this.lblAnvandarnamn.Size = new System.Drawing.Size(219, 32);
            this.lblAnvandarnamn.TabIndex = 2;
            this.lblAnvandarnamn.Text = "Användarnamn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(526, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Administratör";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnLoggain
            // 
            this.btnLoggain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoggain.Location = new System.Drawing.Point(378, 288);
            this.btnLoggain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoggain.Name = "btnLoggain";
            this.btnLoggain.Size = new System.Drawing.Size(153, 49);
            this.btnLoggain.TabIndex = 4;
            this.btnLoggain.Text = "Logga in";
            this.btnLoggain.UseVisualStyleBackColor = true;
            // 
            // LinkRegistrering
            // 
            this.LinkRegistrering.AutoSize = true;
            this.LinkRegistrering.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkRegistrering.Location = new System.Drawing.Point(328, 386);
            this.LinkRegistrering.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkRegistrering.Name = "LinkRegistrering";
            this.LinkRegistrering.Size = new System.Drawing.Size(173, 33);
            this.LinkRegistrering.TabIndex = 5;
            this.LinkRegistrering.TabStop = true;
            this.LinkRegistrering.Text = "Registrering";
            this.LinkRegistrering.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkRegistrering_LinkClicked);
            // 
            // LoggaIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 477);
            this.Controls.Add(this.LinkRegistrering);
            this.Controls.Add(this.btnLoggain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAnvandarnamn);
            this.Controls.Add(this.lblLosenord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbLosenord);
            this.Controls.Add(this.txtbAnvandarnamn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoggaIn";
            this.Text = "LoggaIn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtbAnvandarnamn;
        private System.Windows.Forms.TextBox txtbLosenord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLosenord;
        private System.Windows.Forms.Label lblAnvandarnamn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLoggain;
        private System.Windows.Forms.LinkLabel LinkRegistrering;
    }
}