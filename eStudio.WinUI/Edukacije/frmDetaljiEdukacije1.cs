using eStudioLjepote.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eStudio.WinUI.Edukacije
{
    public partial class frmDetaljiEdukacije1 : Form
    {
        private readonly APIService aPIServiceZaposlenici = new APIService("Zaposlenici");
        private readonly APIService aPIService = new APIService("Edukacije");
        private int? _edukacijaId;

        public frmDetaljiEdukacije1(int? edukacijaId = null)
        {
            InitializeComponent();
            _edukacijaId = edukacijaId;
        }
        private async Task Zaposlenici_Load()
        {
            var result = await aPIServiceZaposlenici.Get<List<eStudioLjepote.Model.Zaposlenik>>(null);
            result.Insert(0, new eStudioLjepote.Model.Zaposlenik());
            comboBoxZaposlenici.DataSource = result;

            comboBoxZaposlenici.DisplayMember = "FullName";
            comboBoxZaposlenici.ValueMember = "Id";
        }

        private async void frmDetaljiEdukacije1_Load(object sender, EventArgs e)
        {
            await Zaposlenici_Load();
            if (_edukacijaId.HasValue)
            {
                var edukacija = await aPIService.GetById<eStudioLjepote.Model.Edukacija>(_edukacijaId);
                var zaposlenik = await aPIServiceZaposlenici.GetById<eStudioLjepote.Model.Zaposlenik>(edukacija.ZaposlenikId);
                txtNaziv.Text = edukacija.Naziv;
                dateTimePickerPocetak.Text = edukacija.Pocetak.ToString();
                dateTimePickerKraj.Text = edukacija.Kraj.ToString();

                comboBoxZaposlenici.SelectedValue = edukacija.ZaposlenikId;
                txtBrojOsoba.Text = edukacija.BrojUcesnika.ToString();
                txtCijena.Text = edukacija.Cijena.ToString();
            }
        }
        EdukacijeUpsertRequest request = new EdukacijeUpsertRequest();

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            request.Cijena = int.Parse(txtCijena.Text);
            request.Naziv = txtNaziv.Text;
            request.Pocetak = DateTime.Parse(dateTimePickerPocetak.Text);
            request.Kraj = DateTime.Parse(dateTimePickerKraj.Text);
            request.BrojUcesnika = int.Parse(txtBrojOsoba.Text);
            request.ZaposlenikId = (int)comboBoxZaposlenici.SelectedValue;
            request.BrojPrijavljenih = 0;

            if (_edukacijaId.HasValue)
            {
                await aPIService.Update<eStudioLjepote.Model.Edukacija>(_edukacijaId, request);

            }
            else
            {
                await aPIService.Insert<eStudioLjepote.Model.Edukacija>(request);
            }
        }
    }
}
