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

namespace eStudio.WinUI.Usluge
{
    public partial class frmUsluge : Form
    {
        private readonly APIService aPIService = new APIService("Usluge");
        private readonly APIService aPIServiceVrstaUsluge = new APIService("VrsteUsluga");
        public frmUsluge()
        {
            InitializeComponent();
        }

        private async void frmUsluge_Load(object sender, EventArgs e)
        {
            //var result = await aPIService.Get<List<eStudioLjepote.Model.Usluga>>(null);
            //dgvUsluge.AutoGenerateColumns = false;
            //dgvUsluge.DataSource = result;
            await   vrsteUsluga_Load();
        }

        private void dgvUsluge_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnNovaUsluga_Click(object sender, EventArgs e)
        {
            frmUslugeDetalji frm = new frmUslugeDetalji();
            frm.Show();
        }

        private void dgvUsluge_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            var id = dgvUsluge.SelectedRows[0].Cells[0].Value;
            frmUslugeDetalji frm = new frmUslugeDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

        private void btnDodajNovuVrstu_Click(object sender, EventArgs e)
        {
            frmVrstaUsluge frm = new frmVrstaUsluge();
            frm.Show();
        }
        private async Task vrsteUsluga_Load()
        {
            var result = await aPIServiceVrstaUsluge.Get<List<eStudioLjepote.Model.VrstaUsluge>>(null);
            result.Insert(0, new eStudioLjepote.Model.VrstaUsluge());
            comboBoxVrstaUsluge.DisplayMember = "Naziv";
            comboBoxVrstaUsluge.ValueMember = "ID";
            comboBoxVrstaUsluge.DataSource = result;
        }
        private async void comboBoxVrstaUsluge_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = comboBoxVrstaUsluge.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                await Usluge_Load(id);

            }

        }
        private async Task Usluge_Load(int VrstaUslugeId)
        {
            var result = await aPIService.Get<List<eStudioLjepote.Model.Usluga>>(new UslugaSearchRequest()
            {
                VrstaUslugeId = VrstaUslugeId
            });
            dgvUsluge.AutoGenerateColumns = false;

            dgvUsluge.DataSource = result;

        }
    }
}
