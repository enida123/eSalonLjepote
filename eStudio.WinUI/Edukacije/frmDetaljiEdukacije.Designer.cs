namespace eStudio.WinUI.Edukacije
{
    partial class frmDetaljiEdukacije
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetaljiEdukacije));
            this.txt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerPocetak = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerKraj = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxZaposlenici = new System.Windows.Forms.ComboBox();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtBrojOsoba = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt
            // 
            resources.ApplyResources(this.txt, "txt");
            this.txt.Name = "txt";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(198)))), ((int)(((byte)(208)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(94)))), ((int)(((byte)(124)))));
            this.panel1.Name = "panel1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(94)))), ((int)(((byte)(124)))));
            this.label3.Name = "label3";
            // 
            // dateTimePickerPocetak
            // 
            resources.ApplyResources(this.dateTimePickerPocetak, "dateTimePickerPocetak");
            this.dateTimePickerPocetak.Name = "dateTimePickerPocetak";
            this.dateTimePickerPocetak.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePickerKraj
            // 
            resources.ApplyResources(this.dateTimePickerKraj, "dateTimePickerKraj");
            this.dateTimePickerKraj.Name = "dateTimePickerKraj";
            this.dateTimePickerKraj.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // comboBoxZaposlenici
            // 
            resources.ApplyResources(this.comboBoxZaposlenici, "comboBoxZaposlenici");
            this.comboBoxZaposlenici.FormattingEnabled = true;
            this.comboBoxZaposlenici.Name = "comboBoxZaposlenici";
            // 
            // btnSnimi
            // 
            resources.ApplyResources(this.btnSnimi, "btnSnimi");
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // txtNaziv
            // 
            resources.ApplyResources(this.txtNaziv, "txtNaziv");
            this.txtNaziv.Name = "txtNaziv";
            // 
            // txtBrojOsoba
            // 
            resources.ApplyResources(this.txtBrojOsoba, "txtBrojOsoba");
            this.txtBrojOsoba.Name = "txtBrojOsoba";
            this.txtBrojOsoba.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCijena
            // 
            resources.ApplyResources(this.txtCijena, "txtCijena");
            this.txtCijena.Name = "txtCijena";
            // 
            // frmDetaljiEdukacije
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtBrojOsoba);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxZaposlenici);
            this.Controls.Add(this.dateTimePickerKraj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerPocetak);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDetaljiEdukacije";
            this.Load += new System.EventHandler(this.frmDetaljiEdukacije_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerPocetak;
        private System.Windows.Forms.DateTimePicker dateTimePickerKraj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxZaposlenici;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtBrojOsoba;
        private System.Windows.Forms.TextBox txtCijena;
    }
}