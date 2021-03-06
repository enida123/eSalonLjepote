﻿using eStudioLjepote.Model;
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

namespace eStudio.WinUI.Uplate
{
    public partial class frmUplate : Form
    {
        private readonly APIService aPIService = new APIService("Uplate");
        private readonly APIService aPIServiceUplate = new APIService("Uplate2");

        private readonly APIService aPIServiceTipoviUplata = new APIService("TipoviUplate");

        public frmUplate()
        {

            InitializeComponent();

        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new UplateSearchRequest()
            {
                Dan=txtDan.Text,
                Mjesec=txtMjesec.Text,
                Godina=txtGodina.Text
            };
            var result = await aPIServiceUplate.Get<List<UplateViewModel>>(search);

            dgvUplate.DataSource = result;
        }

        private void btnNovaUplata_Click(object sender, EventArgs e)
        {
            frmUplateDetalji frm = new frmUplateDetalji();
            frm.Show();
        }

        private void dgvUplate_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvUplate.SelectedRows[0].Cells[0].Value;
            frmUplateDetalji frm = new frmUplateDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

        private async void frmUplate_Load(object sender, EventArgs e)
        {
            var result = await aPIServiceUplate.Get<List<UplateViewModel>>(null);

            dgvUplate.DataSource = result;
        }
    }
}
