namespace eStudio.WinUI.Usluge
{
    partial class frmUslugeDetalji
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
            this.btnInserPhoto = new System.Windows.Forms.Button();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSacuvajUslugu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnDodajSliciocu = new System.Windows.Forms.Button();
            this.txtImageThumb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxSlicica = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxVrstaUsluge = new System.Windows.Forms.ComboBox();
            this.richTextBoxkratkiOpis = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlicica)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInserPhoto
            // 
            this.btnInserPhoto.Location = new System.Drawing.Point(299, 409);
            this.btnInserPhoto.Name = "btnInserPhoto";
            this.btnInserPhoto.Size = new System.Drawing.Size(56, 25);
            this.btnInserPhoto.TabIndex = 35;
            this.btnInserPhoto.Text = "Dodaj";
            this.btnInserPhoto.UseVisualStyleBackColor = true;
            this.btnInserPhoto.Click += new System.EventHandler(this.btnInserPhoto_Click);
            // 
            // txtSlika
            // 
            this.txtSlika.Location = new System.Drawing.Point(16, 412);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(277, 20);
            this.txtSlika.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Slika:";
            // 
            // btnSacuvajUslugu
            // 
            this.btnSacuvajUslugu.Location = new System.Drawing.Point(16, 510);
            this.btnSacuvajUslugu.Name = "btnSacuvajUslugu";
            this.btnSacuvajUslugu.Size = new System.Drawing.Size(129, 29);
            this.btnSacuvajUslugu.TabIndex = 32;
            this.btnSacuvajUslugu.Text = "Sacuvaj";
            this.btnSacuvajUslugu.UseVisualStyleBackColor = true;
            this.btnSacuvajUslugu.Click += new System.EventHandler(this.btnSacuvajUslugu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(523, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(15, 363);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(278, 20);
            this.txtCijena.TabIndex = 30;
            this.txtCijena.Validating += new System.ComponentModel.CancelEventHandler(this.txtCijena_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Cijena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Opis:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(16, 132);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(277, 20);
            this.txtNaziv.TabIndex = 22;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Naziv:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(16, 174);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(277, 96);
            this.txtOpis.TabIndex = 36;
            this.txtOpis.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnDodajSliciocu
            // 
            this.btnDodajSliciocu.Location = new System.Drawing.Point(299, 455);
            this.btnDodajSliciocu.Name = "btnDodajSliciocu";
            this.btnDodajSliciocu.Size = new System.Drawing.Size(56, 24);
            this.btnDodajSliciocu.TabIndex = 39;
            this.btnDodajSliciocu.Text = "Dodaj";
            this.btnDodajSliciocu.UseVisualStyleBackColor = true;
            this.btnDodajSliciocu.Click += new System.EventHandler(this.btnDodajSliciocu_Click);
            // 
            // txtImageThumb
            // 
            this.txtImageThumb.Location = new System.Drawing.Point(20, 459);
            this.txtImageThumb.Name = "txtImageThumb";
            this.txtImageThumb.Size = new System.Drawing.Size(273, 20);
            this.txtImageThumb.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Slicica:";
            // 
            // pictureBoxSlicica
            // 
            this.pictureBoxSlicica.Location = new System.Drawing.Point(368, 80);
            this.pictureBoxSlicica.Name = "pictureBoxSlicica";
            this.pictureBoxSlicica.Size = new System.Drawing.Size(129, 129);
            this.pictureBoxSlicica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSlicica.TabIndex = 40;
            this.pictureBoxSlicica.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Vrste usluge:";
            // 
            // comboBoxVrstaUsluge
            // 
            this.comboBoxVrstaUsluge.FormattingEnabled = true;
            this.comboBoxVrstaUsluge.Location = new System.Drawing.Point(16, 80);
            this.comboBoxVrstaUsluge.Name = "comboBoxVrstaUsluge";
            this.comboBoxVrstaUsluge.Size = new System.Drawing.Size(277, 21);
            this.comboBoxVrstaUsluge.TabIndex = 42;
            // 
            // richTextBoxkratkiOpis
            // 
            this.richTextBoxkratkiOpis.Location = new System.Drawing.Point(15, 297);
            this.richTextBoxkratkiOpis.Name = "richTextBoxkratkiOpis";
            this.richTextBoxkratkiOpis.Size = new System.Drawing.Size(278, 41);
            this.richTextBoxkratkiOpis.TabIndex = 45;
            this.richTextBoxkratkiOpis.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Kratki opis:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(198)))), ((int)(((byte)(208)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(94)))), ((int)(((byte)(124)))));
            this.panel1.Location = new System.Drawing.Point(15, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 2);
            this.panel1.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(94)))), ((int)(((byte)(124)))));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 22);
            this.label8.TabIndex = 46;
            this.label8.Text = "Podaci o uslugama";
            // 
            // frmUslugeDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.richTextBoxkratkiOpis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxVrstaUsluge);
            this.Controls.Add(this.pictureBoxSlicica);
            this.Controls.Add(this.btnDodajSliciocu);
            this.Controls.Add(this.txtImageThumb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.btnInserPhoto);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSacuvajUslugu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label2);
            this.Name = "frmUslugeDetalji";
            this.Text = "Detalji usluga";
            this.Load += new System.EventHandler(this.frmUslugeDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlicica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserPhoto;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSacuvajUslugu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtOpis;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBoxSlicica;
        private System.Windows.Forms.Button btnDodajSliciocu;
        private System.Windows.Forms.TextBox txtImageThumb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxVrstaUsluge;
        private System.Windows.Forms.RichTextBox richTextBoxkratkiOpis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
    }
}