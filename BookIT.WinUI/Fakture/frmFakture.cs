using BookIT.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookIT.WinUI.Fakture
{
    public partial class frmFakture : Form
    {
        private readonly APIService _apiServiceFakture = new APIService("Fakture");

        public frmMain FrmMain { get; }

        public frmFakture(frmMain frmMain)
        {
            InitializeComponent();
            FrmMain = frmMain;
        }

        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
            await BindForm();
        }

        private async Task BindForm()
        {
            var search = new FaktureSearchRequest()
            {
                ImeKlijenta = txtImeKlijenta.Text

            };
            var result = await _apiServiceFakture.Get<List<Model.Faktura>>(search);
            int i = 1;
            foreach (var item in result)
            {
                item.RedniBroj = i++;
            }

            dgvFakture.AutoGenerateColumns = false;
            dgvFakture.DataSource = result;
        }

        private void dgvFakture_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var FakturaId = int.Parse(dgvFakture.SelectedRows[0].Cells[0].Value.ToString());

            frmFakturaDetalji frm = new frmFakturaDetalji(FakturaId);
            this.Hide();
            frm.Location = this.Location;
            FrmMain.UpdateSizeAndLocation(frm);
            frm.ShowDialog();
            this.Show();
        }

        private async void frmFakture_Load(object sender, EventArgs e)
        {
            await BindForm();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmFakture_Resize(object sender, EventArgs e)
        {
            close.Location = new Point(this.Width - 24, 5);

        }

        private async void txtImeKlijenta_KeyUp(object sender, KeyEventArgs e)
        {
            await BindForm();
        }
    }
}
