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
    public partial class frmUslugeDetalji : Form
    {
        private int? _uslugaId;
        private readonly APIService aPIServiceUsluge = new APIService("Usluge");
        private readonly APIService aPIServiceVrstaUsluge = new APIService("VrsteUsluga");

        public frmUslugeDetalji(int? uslugaId=null)
        {
            InitializeComponent();
            _uslugaId = uslugaId;
        }
        private async Task vrsteUsluga_Load()
        {
            var result = await aPIServiceVrstaUsluge.Get<List<eStudioLjepote.Model.VrstaUsluge>>(null);
            result.Insert(0, new eStudioLjepote.Model.VrstaUsluge());
            comboBoxVrstaUsluge.DisplayMember = "Naziv";
            comboBoxVrstaUsluge.ValueMember = "ID";
            comboBoxVrstaUsluge.DataSource = result;
        }
        private async void frmUslugeDetalji_Load(object sender, EventArgs e)
        {

            await vrsteUsluga_Load();
            if (_uslugaId.HasValue)
            {
                var usluga = await aPIServiceUsluge.GetById<eStudioLjepote.Model.Usluga>(_uslugaId);
                var vrstaUsluge = await aPIServiceVrstaUsluge.GetById<eStudioLjepote.Model.VrstaUsluge>(usluga.VrstaUslugeId);
                txtNaziv.Text = usluga.Naziv;
                txtOpis.Text = usluga.Opis;
                richTextBoxkratkiOpis.Text = usluga.KratkiOpis;
                txtCijena.Text = usluga.Cijena.ToString();
                comboBoxVrstaUsluge.SelectedValue = usluga.VrstaUslugeId;
                MemoryStream memoryStream = new MemoryStream(usluga.Slika);
                pictureBox1.Image = Image.FromStream(memoryStream);
                request.Slika = usluga.Slika;

                memoryStream = new MemoryStream(usluga.ImageThumbnail);

                pictureBoxSlicica.Image = Image.FromStream(memoryStream);
                request.ImageThumbnail = usluga.ImageThumbnail;

            }
        }


        UslugeUpsertRequest request = new UslugeUpsertRequest();

        private async void btnSacuvajUslugu_Click(object sender, EventArgs e)
        {
            var idObj = comboBoxVrstaUsluge.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int vrstaId))
            {
                request.VrstaUslugeId = vrstaId;
            }


            request.Naziv = txtNaziv.Text;
            request.Cijena = float.Parse(txtCijena.Text);
            request.Opis = txtOpis.Text;
            request.KratkiOpis = richTextBoxkratkiOpis.Text;
            if (_uslugaId.HasValue)
            {
                await aPIServiceUsluge.Update<eStudioLjepote.Model.Usluga>(_uslugaId, request);
            }
            else
            {
                await aPIServiceUsluge.Insert<eStudioLjepote.Model.Usluga>(request);
            }
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
                txtSlika.Text = fileName;

                Image image = Image.FromFile(fileName);
                pictureBox1.Image = image;
            }
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                errorProvider1.SetError(txtNaziv, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtNaziv, null);
            }
        }

        private void txtCijena_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCijena.Text))
            {
                errorProvider1.SetError(txtCijena, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtCijena, null);
            }
        }

        private void btnDodajSliciocu_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);

                request.ImageThumbnail = file;
                txtImageThumb.Text = fileName;

                Image image = Image.FromFile(fileName);
                pictureBoxSlicica.Image = image;
            }

        }
    }
}
