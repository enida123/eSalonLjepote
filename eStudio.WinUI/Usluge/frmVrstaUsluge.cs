using eStudioLjepote.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eStudio.WinUI.Usluge
{
    public partial class frmVrstaUsluge : Form
    {
        private readonly APIService aPIServiceVrstaUsluge = new APIService("VrsteUsluga");
        public frmVrstaUsluge()
        {
            InitializeComponent();
        }
       VrsteUslugeUpsertRequest  request = new VrsteUslugeUpsertRequest();

      

        private async void btnSacuvajVrstuUslugu_Click(object sender, EventArgs e)
        {
            request.Naziv = txtNazivVrsteUsluge.Text;
           
            request.Opis = txtOpisVrsteUsluge.Text;
           
           
           await aPIServiceVrstaUsluge.Insert<eStudioLjepote.Model.VrstaUsluge>(request);
            
            MessageBox.Show("Operacija uspjesna.");
        }

        private void btnInserPhoto_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);

                request.Slika = file;
                txtSlikaVrste.Text = fileName;

                Image image = Image.FromFile(fileName);
                pictureBoxSlicica.Image = image;
            }
        }

        private void frmVrstaUsluge_Load(object sender, EventArgs e)
        {

        }
    }
}
