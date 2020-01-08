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
    public partial class frmEdukacija : Form
    {
        private readonly APIService aPIService = new APIService("Edukacije");
        public frmEdukacija()
        {
            InitializeComponent();
        }

        private async void frmEdukacija_Load(object sender, EventArgs e)
        {
            var result = await aPIService.Get<List<eStudioLjepote.Model.Edukacija>>(null);
            dgvEdukacije.AutoGenerateColumns = false;




            dgvEdukacije.DataSource = result;
        }

        private void btnNovaEdukacija_Click(object sender, EventArgs e)
        {
            frmDetaljiEdukacije1 frm = new frmDetaljiEdukacije1();
            frm.Show();
        }

        private void dgvEdukacije_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvEdukacije.SelectedRows[0].Cells[0].Value;
            frmDetaljiEdukacije1 frm = new frmDetaljiEdukacije1(int.Parse(id.ToString()));
            frm.Show();
        }

        private void btnPregledRezervacija_Click(object sender, EventArgs e)
        {
            frmPregledRezervacijaž frm = new frmPregledRezervacijaž();
            frm.Show();
        }
    }
}
