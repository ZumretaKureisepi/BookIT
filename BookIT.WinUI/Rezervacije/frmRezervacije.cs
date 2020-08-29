using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookIT.WinUI.Rezervacije
{
    public partial class frmRezervacije : Form
    {
        private readonly APIService _apiServiceRezervacije = new APIService("Rezervacije");
        private readonly APIService _apiServiceSmjestaji = new APIService("Smjestaji");
        private readonly APIService _apiServiceFakture = new APIService("Fakture");
        private readonly APIService _apiServiceDodatneUslugeRezervacije = new APIService("DodatneUslugeRezervacije");
        private readonly APIService _apiServiceSobeRezervacije = new APIService("SobeRezervacije");
        private readonly frmMain frmMain;

        public frmRezervacije(frmMain frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;
        }

        private async void frmRezervacije_Load(object sender, EventArgs e)
        {
            var listSmjestaji= await _apiServiceSmjestaji.Get<List<Model.Smjestaj>>(null);
            listSmjestaji.Insert(0, new Model.Smjestaj
            {
                SmjestajId = 0,
                Naziv = "(svi smještaji)"
            });
            cmbSmjestaj.DataSource = listSmjestaji;
           
            cmbSmjestaj.ValueMember = "SmjestajId";
            cmbSmjestaj.DisplayMember = "Naziv";

            await BindForm();
        }

        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
            await BindForm();
        }

        public async Task BindForm()
        {
            // Pretraga rezervacija za odabrani smještaj
            var search_rezervacije = new Model.Requests.RezervacijeSearchRequest
            {
                SmjestajId = ((Model.Smjestaj)cmbSmjestaj.SelectedItem).SmjestajId
            };
            var resultRezervacije = await _apiServiceRezervacije.Get<List<Model.Rezervacija>>(search_rezervacije);

            // foreach petlja za računanje ukupne cijene rezervacije, bez fakture
            foreach (Model.Rezervacija rezervacija in resultRezervacije)
            {
                //Model.Rezervacija temp = await GetCijenaRezervacijeINaziveSoba(rezervacija);
                //rezervacija.Cijena = temp.Cijena;
                //rezervacija.Sobe = temp.Sobe;
                await RezervacijaHelper.GetCijenaRezervacijeINaziveSoba(rezervacija);
            }

            dgvRezervacije.AutoGenerateColumns = false;
            dgvRezervacije.DataSource = resultRezervacije;
        }

        private void dgvRezervacije_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var RezervacijaId = int.Parse(dgvRezervacije.SelectedRows[0].Cells[0].Value.ToString());

            frmRezervacijeDetalji frm = new frmRezervacijeDetalji(RezervacijaId, this);
            this.Hide();
            frm.Location = this.Location;
            frmMain.UpdateSizeAndLocation(frm);
            frm.ShowDialog();
            this.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmRezervacije_Resize(object sender, EventArgs e)
        {
            close.Location = new Point(this.Width - 24, 5);

        }

        private void cmbSmjestaj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down)
                e.SuppressKeyPress = true;
        }

        private async void cmbSmjestaj_SelectedIndexChanged(object sender, EventArgs e)
        {
            await BindForm();
        }

        private void frmRezervacije_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.DimGray, 4),
                         this.DisplayRectangle);
        }
    }
}
