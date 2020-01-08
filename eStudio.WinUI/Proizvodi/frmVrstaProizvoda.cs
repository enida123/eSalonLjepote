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

namespace eStudio.WinUI.Proizvodi
{
    public partial class frmVrstaProizvoda : Form
    {
        private readonly APIService aPIServiceVrsteProizvoda = new APIService("VrsteProizvoda");

        public frmVrstaProizvoda()
        {
            InitializeComponent();
        }
        VrsteProizvodaUpsert request = new VrsteProizvodaUpsert();



      

       
        private void btnInserPhoto_Click_1(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);

                request.Slika = file;
                txtSlikaVrsteProizvoda.Text = fileName;

                Image image = Image.FromFile(fileName);
                pictureBoxSlicica.Image = image;
            }
        }

        private async void btnSacuvajVrstuProizvoda_Click_1(object sender, EventArgs e)
        {
            request.Naziv = txtNazivVrsteProizvoda.Text;

            request.Opis = txtOpisVrsteProizvoda.Text;


            await aPIServiceVrsteProizvoda.Insert<eStudioLjepote.Model.VrsteProizvoda>(request);

            MessageBox.Show("Operacija uspjesna.");
        }

        private void frmVrstaProizvoda_Load(object sender, EventArgs e)
        {

        }
    }
}
