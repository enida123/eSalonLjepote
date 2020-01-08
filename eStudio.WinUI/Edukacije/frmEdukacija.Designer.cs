namespace eStudio.WinUI.Edukacije
{
    partial class frmEdukacija
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPregledRezervacija = new System.Windows.Forms.Button();
            this.dgvEdukacije = new System.Windows.Forms.DataGridView();
            this.EdukacijaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pocetak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kraj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojUcesnika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNovaEdukacija = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdukacije)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPregledRezervacija
            // 
            this.btnPregledRezervacija.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPregledRezervacija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPregledRezervacija.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregledRezervacija.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPregledRezervacija.Location = new System.Drawing.Point(12, 132);
            this.btnPregledRezervacija.Name = "btnPregledRezervacija";
            this.btnPregledRezervacija.Size = new System.Drawing.Size(187, 47);
            this.btnPregledRezervacija.TabIndex = 14;
            this.btnPregledRezervacija.Text = "Pregled rezervacija";
            this.btnPregledRezervacija.UseVisualStyleBackColor = false;
            this.btnPregledRezervacija.Click += new System.EventHandler(this.btnPregledRezervacija_Click);
            // 
            // dgvEdukacije
            // 
            this.dgvEdukacije.AllowUserToAddRows = false;
            this.dgvEdukacije.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEdukacije.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEdukacije.BackgroundColor = System.Drawing.Color.White;
            this.dgvEdukacije.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEdukacije.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvEdukacije.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEdukacije.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEdukacije.ColumnHeadersHeight = 50;
            this.dgvEdukacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EdukacijaID,
            this.Naziv,
            this.Pocetak,
            this.Kraj,
            this.BrojUcesnika});
            this.dgvEdukacije.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEdukacije.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEdukacije.EnableHeadersVisualStyles = false;
            this.dgvEdukacije.GridColor = System.Drawing.SystemColors.Control;
            this.dgvEdukacije.Location = new System.Drawing.Point(12, 221);
            this.dgvEdukacije.Name = "dgvEdukacije";
            this.dgvEdukacije.ReadOnly = true;
            this.dgvEdukacije.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEdukacije.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEdukacije.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEdukacije.RowTemplate.Height = 40;
            this.dgvEdukacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEdukacije.Size = new System.Drawing.Size(1119, 335);
            this.dgvEdukacije.TabIndex = 11;
            this.dgvEdukacije.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvEdukacije_MouseDoubleClick);
            // 
            // EdukacijaID
            // 
            this.EdukacijaID.DataPropertyName = "Id";
            this.EdukacijaID.HeaderText = "EdukacijaID";
            this.EdukacijaID.Name = "EdukacijaID";
            this.EdukacijaID.ReadOnly = true;
            this.EdukacijaID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 200;
            // 
            // Pocetak
            // 
            this.Pocetak.DataPropertyName = "Pocetak";
            this.Pocetak.HeaderText = "Pocetak";
            this.Pocetak.Name = "Pocetak";
            this.Pocetak.ReadOnly = true;
            this.Pocetak.Width = 200;
            // 
            // Kraj
            // 
            this.Kraj.DataPropertyName = "Kraj";
            this.Kraj.HeaderText = "Kraj";
            this.Kraj.Name = "Kraj";
            this.Kraj.ReadOnly = true;
            this.Kraj.Width = 200;
            // 
            // BrojUcesnika
            // 
            this.BrojUcesnika.DataPropertyName = "BrojUcesnika";
            this.BrojUcesnika.HeaderText = "BrojUcesnika";
            this.BrojUcesnika.Name = "BrojUcesnika";
            this.BrojUcesnika.ReadOnly = true;
            this.BrojUcesnika.Width = 200;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 50);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Edukacije";
            // 
            // btnNovaEdukacija
            // 
            this.btnNovaEdukacija.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnNovaEdukacija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaEdukacija.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaEdukacija.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNovaEdukacija.Location = new System.Drawing.Point(214, 132);
            this.btnNovaEdukacija.Name = "btnNovaEdukacija";
            this.btnNovaEdukacija.Size = new System.Drawing.Size(187, 47);
            this.btnNovaEdukacija.TabIndex = 15;
            this.btnNovaEdukacija.Text = "Novi edukacija";
            this.btnNovaEdukacija.UseVisualStyleBackColor = false;
            this.btnNovaEdukacija.Click += new System.EventHandler(this.btnNovaEdukacija_Click);
            // 
            // frmEdukacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1075, 568);
            this.ControlBox = false;
            this.Controls.Add(this.btnNovaEdukacija);
            this.Controls.Add(this.btnPregledRezervacija);
            this.Controls.Add(this.dgvEdukacije);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEdukacija";
            this.Text = "frmEdukacija";
            this.Load += new System.EventHandler(this.frmEdukacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdukacije)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPregledRezervacija;
        private System.Windows.Forms.DataGridView dgvEdukacije;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EdukacijaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pocetak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kraj;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojUcesnika;
        private System.Windows.Forms.Button btnNovaEdukacija;
    }
}