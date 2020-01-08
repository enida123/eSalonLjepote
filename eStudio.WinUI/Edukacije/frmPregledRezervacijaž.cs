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
    public partial class frmPregledRezervacijaž : Form
    {
        private readonly APIService aPIService = new APIService("Edukacije");
        private readonly APIService aPIServiceRezervacije = new APIService("RezervacijaEdukacije");

        public frmPregledRezervacijaž()
        {
            InitializeComponent();
        }
        
        private async void frmPregledRezervacijaž_Load(object sender, EventArgs e)
        {
            await Edukacije_Load();
        }
        private async Task Edukacije_Load()
        {
            var result = await aPIService.Get<List<eStudioLjepote.Model.Edukacija>>(null);
            result.Insert(0, new eStudioLjepote.Model.Edukacija());
            comboBox1.DataSource = result;

            comboBox1.ValueMember = "Id";

            comboBox1.DisplayMember = "Naziv";
        }
        
        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = comboBox1.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                await Rezervacije_Load(id);

            }
        }
        private async Task Rezervacije_Load(int id)
        {
            RezervacijaEdukacijeSearch request = new RezervacijaEdukacijeSearch();
            request.EdukacijaId = id;


            var result = await aPIServiceRezervacije.Get<List<eStudioLjepote.Model.RezervacijaEdukacije>>(request);


            dgvRezervacije.DataSource = result;

        }
    }
}
