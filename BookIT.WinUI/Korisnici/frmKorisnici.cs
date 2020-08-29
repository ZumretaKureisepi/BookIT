using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using Flurl;
using BookIT.Model.Requests;

namespace BookIT.WinUI.Korisnici
{
    public partial class frmKorisnici : Form
    {
        private readonly APIService _apiService = new APIService("korisnici");

        public frmMainAdmin FrmMainAdmin { get; }

        public frmKorisnici(frmMainAdmin frmMainAdmin)
        {
            InitializeComponent();
            FrmMainAdmin = frmMainAdmin;
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            await BindForm();
        }

        private async Task BindForm()
        {
            var search = new KorisniciSearchRequest()
            {
                ImePrezime = txtPretraga.Text
            };
            var result = await _apiService.Get<List<Model.Korisnik>>(search);
            dgvKorisnici.AutoGenerateColumns = false;
            dgvKorisnici.DataSource = result;
        }

        private void dgvKorisnici_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var KorisnikId = int.Parse(dgvKorisnici.SelectedRows[0].Cells[0].Value.ToString());
            frmKorisniciDetalji frm = new frmKorisniciDetalji(KorisnikId);
            this.Hide();
            frm.Location = this.Location;
            FrmMainAdmin.UpdateSizeAndLocation(frm);
            frm.ShowDialog();
            this.Show();
        }

        private async void frmKorisnici_Load(object sender, EventArgs e)
        {
            await BindForm();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmKorisnici_Resize(object sender, EventArgs e)
        {
            close.Location = new Point(this.Width - 24, 5);
        }

        private async void txtPretraga_KeyUp(object sender, KeyEventArgs e)
        {
            await BindForm();
        }
    }
}
