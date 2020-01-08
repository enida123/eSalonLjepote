namespace eStudio.WinUI.Proizvodi
{
    partial class frmProizvodiDetalji
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
            this.btnSacuvajProizvod = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerDatumKupovine = new System.Windows.Forms.DateTimePicker();
            this.txtSkladiste = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNazivProizvoda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxVrstaProizvoda = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnInserPhoto = new System.Windows.Forms.Button();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNovaVrsta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSacuvajProizvod
            // 
            this.btnSacuvajProizvod.Location = new System.Drawing.Point(17, 382);
            this.btnSacuvajProizvod.Name = "btnSacuvajProizvod";
            this.btnSacuvajProizvod.Size = new System.Drawing.Size(92, 29);
            this.btnSacuvajProizvod.TabIndex = 34;
            this.btnSacuvajProizvod.Text = "Sacuvaj";
            this.btnSacuvajProizvod.UseVisualStyleBackColor = true;
            this.btnSacuvajProizvod.Click += new System.EventHandler(this.btnSacuvajProizvod_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(457, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(16, 220);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(144, 20);
            this.txtCijena.TabIndex = 32;
            this.txtCijena.TextChanged += new System.EventHandler(this.txtCijena_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Cijena:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Skladiste:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dateTimePickerDatumKupovine
            // 
            this.dateTimePickerDatumKupovine.Location = new System.Drawing.Point(17, 268);
            this.dateTimePickerDatumKupovine.Name = "dateTimePickerDatumKupovine";
            this.dateTimePickerDatumKupovine.Size = new System.Drawing.Size(292, 20);
            this.dateTimePickerDatumKupovine.TabIndex = 29;
            this.dateTimePickerDatumKupovine.ValueChanged += new System.EventHandler(this.dateTimePickerDatumKupovine_ValueChanged);
            // 
            // txtSkladiste
            // 
            this.txtSkladiste.Location = new System.Drawing.Point(169, 220);
            this.txtSkladiste.Name = "txtSkladiste";
            this.txtSkladiste.Size = new System.Drawing.Size(139, 20);
            this.txtSkladiste.TabIndex = 28;
            this.txtSkladiste.TextChanged += new System.EventHandler(this.txtSkladiste_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Datum kupovine:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNazivProizvoda
            // 
            this.txtNazivProizvoda.Location = new System.Drawing.Point(16, 174);
            this.txtNazivProizvoda.Name = "txtNazivProizvoda";
            this.txtNazivProizvoda.Size = new System.Drawing.Size(292, 20);
            this.txtNazivProizvoda.TabIndex = 26;
            this.txtNazivProizvoda.TextChanged += new System.EventHandler(this.txtNazivProizvoda_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Naziv:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(16, 134);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(292, 20);
            this.txtSifra.TabIndex = 24;
            this.txtSifra.TextChanged += new System.EventHandler(this.txtSifra_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Sifra:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Vrste proizvoda:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxVrstaProizvoda
            // 
            this.comboBoxVrstaProizvoda.FormattingEnabled = true;
            this.comboBoxVrstaProizvoda.Location = new System.Drawing.Point(16, 90);
            this.comboBoxVrstaProizvoda.Name = "comboBoxVrstaProizvoda";
            this.comboBoxVrstaProizvoda.Size = new System.Drawing.Size(292, 21);
            this.comboBoxVrstaProizvoda.TabIndex = 21;
            this.comboBoxVrstaProizvoda.SelectedIndexChanged += new System.EventHandler(this.comboBoxVrstaProizvoda_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(198)))), ((int)(((byte)(208)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(94)))), ((int)(((byte)(124)))));
            this.panel1.Location = new System.Drawing.Point(16, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 2);
            this.panel1.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(94)))), ((int)(((byte)(124)))));
            this.label8.Location = new System.Drawing.Point(12, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 22);
            this.label8.TabIndex = 38;
            this.label8.Text = "Podaci o proizvodu";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnInserPhoto
            // 
            this.btnInserPhoto.Location = new System.Drawing.Point(322, 318);
            this.btnInserPhoto.Name = "btnInserPhoto";
            this.btnInserPhoto.Size = new System.Drawing.Size(51, 22);
            this.btnInserPhoto.TabIndex = 42;
            this.btnInserPhoto.Text = "Dodaj";
            this.btnInserPhoto.UseVisualStyleBackColor = true;
            this.btnInserPhoto.Click += new System.EventHandler(this.btnInserPhoto_Click_1);
            // 
            // txtSlika
            // 
            this.txtSlika.Location = new System.Drawing.Point(16, 318);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(300, 20);
            this.txtSlika.TabIndex = 41;
            this.txtSlika.TextChanged += new System.EventHandler(this.txtSlika_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Slika:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnNovaVrsta
            // 
            this.btnNovaVrsta.Location = new System.Drawing.Point(314, 90);
            this.btnNovaVrsta.Name = "btnNovaVrsta";
            this.btnNovaVrsta.Size = new System.Drawing.Size(50, 23);
            this.btnNovaVrsta.TabIndex = 43;
            this.btnNovaVrsta.Text = "...";
            this.btnNovaVrsta.UseVisualStyleBackColor = true;
            this.btnNovaVrsta.Click += new System.EventHandler(this.btnNovaVrsta_Click);
            // 
            // frmProizvodiDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 427);
            this.Controls.Add(this.btnNovaVrsta);
            this.Controls.Add(this.btnInserPhoto);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSacuvajProizvod);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerDatumKupovine);
            this.Controls.Add(this.txtSkladiste);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNazivProizvoda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxVrstaProizvoda);
            this.Name = "frmProizvodiDetalji";
            this.Text = "Podaci o proizvodu";
            this.Load += new System.EventHandler(this.frmProizvodiDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSacuvajProizvod;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumKupovine;
        private System.Windows.Forms.TextBox txtSkladiste;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNazivProizvoda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxVrstaProizvoda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnInserPhoto;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNovaVrsta;
    }
}